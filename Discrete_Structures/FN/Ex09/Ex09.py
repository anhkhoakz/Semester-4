from cryptography.hazmat.primitives.asymmetric import padding, rsa
from cryptography.hazmat.primitives import serialization, hashes, padding as sym_padding
from cryptography.hazmat.primitives.ciphers import Cipher, algorithms, modes
from cryptography.hazmat.backends import default_backend
from random import randrange, getrandbits


# RSA functions from initial implementation


def is_prime(num):
    if num < 2:
        return False
    for i in range(2, int(num**0.5) + 1):
        if num % i == 0:
            return False
    return True


def generate_prime(bits):
    while True:
        num = getrandbits(bits)
        if is_prime(num):
            return num


def gcd(a, b):
    while b != 0:
        a, b = b, a % b
    return a


def mod_inverse(a, m):
    g, x, y = extended_gcd(a, m)
    if g != 1:
        return None
    return x % m


def extended_gcd(a, b):
    if a == 0:
        return b, 0, 1
    gcd, x1, y1 = extended_gcd(b % a, a)
    x = y1 - (b // a) * x1
    y = x1
    return gcd, x, y


def generate_keypair(p, q):
    n = p * q
    phi = (p - 1) * (q - 1)
    e = randrange(1, phi)
    g = gcd(e, phi)
    while g != 1:
        e = randrange(1, phi)
        g = gcd(e, phi)
    d = mod_inverse(e, phi)
    return ((e, n), (d, n))


def encrypt(public_key, plaintext):
    e, n = public_key
    cipher = [pow(ord(char), e, n) for char in plaintext]
    return cipher


def decrypt(private_key, ciphertext):
    d, n = private_key
    plain = [chr(pow(char, d, n)) for char in ciphertext]
    return "".join(plain)


# RSA functions
def generate_keys():
    private_key = rsa.generate_private_key(public_exponent=65537, key_size=4096)
    public_key = private_key.public_key()
    return private_key, public_key


def serialize_keys(private_key, public_key, password=None):
    pem_private_key = private_key.private_bytes(
        encoding=serialization.Encoding.PEM,
        format=serialization.PrivateFormat.PKCS8,
        encryption_algorithm=serialization.BestAvailableEncryption(password.encode())
        if password
        else serialization.NoEncryption(),
    )

    pem_public_key = public_key.public_bytes(
        encoding=serialization.Encoding.PEM,
        format=serialization.PublicFormat.SubjectPublicKeyInfo,
    )

    return pem_private_key, pem_public_key


def save_key_to_file(file_path, key_data):
    with open(file_path, "wb") as file:
        file.write(key_data)


def encrypt_message(public_key, message):
    cipher_text = public_key.encrypt(
        message,
        padding.OAEP(
            mgf=padding.MGF1(algorithm=hashes.SHA256()),
            algorithm=hashes.SHA256(),
            label=None,
        ),
    )
    return cipher_text


def load_public_key(file_path):
    with open(file_path, "rb") as file:
        public_key = serialization.load_pem_public_key(
            file.read(),
        )
    return public_key


def decrypt_message(private_key, cipher_text):
    plain_text = private_key.decrypt(
        cipher_text,
        padding.OAEP(
            mgf=padding.MGF1(algorithm=hashes.SHA256()),
            algorithm=hashes.SHA256(),
            label=None,
        ),
    )
    return plain_text


def load_private_key(file_path, password=None):
    with open(file_path, "rb") as key_file:
        private_key = serialization.load_pem_private_key(
            key_file.read(), password=password.encode() if password else None
        )
    return private_key


def load_cipher_text(file_path):
    with open(file_path, "rb") as file:
        cipher_text = file.read()
    return cipher_text


def save_plain_text(file_path, plain_text):
    with open(file_path, "w") as file:
        file.write(plain_text)


# AES functions
def generate_key(key_length):
    return bytes(getrandbits(8) for _ in range(key_length))


def aes_encrypt(key, plaintext):
    backend = default_backend()
    cipher = Cipher(algorithms.AES(key), modes.ECB(), backend=backend)
    encryptor = cipher.encryptor()

    padder = sym_padding.PKCS7(algorithms.AES.block_size).padder()
    padded_data = padder.update(plaintext) + padder.finalize()

    ciphertext = encryptor.update(padded_data) + encryptor.finalize()
    return ciphertext


def aes_decrypt(key, ciphertext):
    backend = default_backend()
    cipher = Cipher(algorithms.AES(key), modes.ECB(), backend=backend)
    decryptor = cipher.decryptor()

    padded_plaintext = decryptor.update(ciphertext) + decryptor.finalize()

    unpadder = sym_padding.PKCS7(algorithms.AES.block_size).unpadder()
    plaintext = unpadder.update(padded_plaintext) + unpadder.finalize()
    return plaintext


def main():
    # RSA parts from initial implementation
    p = generate_prime(bits=32)
    q = generate_prime(bits=32)

    public_key, private_key = generate_keypair(p, q)
    message = "The quick brown fox jumps over the lazy dog"
    encrypted_message = encrypt(public_key, message)
    decrypted_message = decrypt(private_key, encrypted_message)

    print("Generated prime p:", p)
    print("Generated prime q:", q)

    print("Generated public key:", public_key)
    print("Generated private key:", private_key)

    print("Original message:", message)

    print("Encrypted message:", encrypted_message)
    print("Decrypted message:", decrypted_message)

    # RSA parts
    message = b"The quick brown fox jumps over the lazy dog"

    private_key, public_key = generate_keys()

    pem_private_key, pem_public_key = serialize_keys(private_key, public_key)

    save_key_to_file("./private_key.pem", pem_private_key)
    save_key_to_file("./public_key.pem", pem_public_key)

    cipher_text = encrypt_message(public_key, message)

    plain_text = decrypt_message(private_key, cipher_text)

    save_plain_text("./message.txt", plain_text.decode())

    save_plain_text("./message.txt", plain_text.decode())

    private_key = None
    public_key = None
    pem_private_key = None
    pem_public_key = None
    cipher_text = None
    plain_text = None
    key = None
    ciphertext = None
    decrypted_text = None

    # AES parts
    key_length = 16

    key = generate_key(key_length)
    plaintext = b"The quick brown fox jumps over the lazy dog"

    ciphertext = aes_encrypt(key, plaintext)

    decrypted_text = aes_decrypt(key, ciphertext)

    print("Key:", key)
    print("Ciphertext:", ciphertext)
    print("Decrypted text:", decrypted_text)


if __name__ == "__main__":
    main()
