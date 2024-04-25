import networkx as nx
import matplotlib.pyplot as plt


def Ex01():
    G = nx.Graph()
    G.add_edges_from(
        ebunch_to_add=[
            ("A", "B"),
            ("A", "C"),
            ("D", "B"),
            ("E", "C"),
            ("E", "F"),
            ("B", "H"),
            ("B", "G"),
            ("B", "F"),
            ("C", "G"),
        ]
    )

    nx.draw(G=G)

    plt.show()


def Ex02():
    G = nx.DiGraph()

    G.add_edges_from(
        ebunch_to_add=[
            ("A", "B"),
            ("A", "C"),
            ("D", "B"),
            ("E", "C"),
            ("E", "F"),
            ("B", "H"),
            ("B", "G"),
            ("B", "F"),
            ("C", "G"),
        ]
    )

    nx.draw(G=G)

    plt.show()


def Ex03():
    G = nx.DiGraph()

    G.add_edges_from(
        ebunch_to_add=[
            ("A", "B"),
            ("A", "C"),
            ("D", "B"),
            ("E", "C"),
            ("E", "F"),
            ("B", "H"),
            ("B", "G"),
            ("B", "F"),
            ("C", "G"),
        ]
    )

    nx.draw(G=G, with_labels=True)

    plt.show()


def Ex04():
    G = nx.Graph()

    G.add_edge(u_of_edge="A", v_of_edge="B", weight=4)
    G.add_edge(u_of_edge="B", v_of_edge="D", weight=2)
    G.add_edge(u_of_edge="A", v_of_edge="C", weight=3)
    G.add_edge(u_of_edge="C", v_of_edge="D", weight=4)
    print(nx.shortest_path(G=G, source="A", target="D", weight="weight"))


def Ex05():
    G = nx.Graph()
    G.add_edges_from(ebunch_to_add=[("1", "4"), ("4", "2"), ("3", "4")])
    nx.draw(G=G, with_labels=True)
    plt.show()


def Ex06():
    G = nx.Graph()

    G.add_edge(u_of_edge="A", v_of_edge="B", weight=1)
    G.add_edge(u_of_edge="B", v_of_edge="D", weight=2)
    G.add_edge(u_of_edge="B", v_of_edge="E", weight=3)
    G.add_edge(u_of_edge="D", v_of_edge="E", weight=5)
    G.add_edge(u_of_edge="A", v_of_edge="E", weight=2)
    G.add_edge(u_of_edge="A", v_of_edge="C", weight=4)
    G.add_edge(u_of_edge="C", v_of_edge="F", weight=6)
    G.add_edge(u_of_edge="C", v_of_edge="G", weight=7)
    nx.draw(G=G, with_labels=True)

    plt.show()


def Ex07():
    G = nx.Graph()

    G.add_edge("A", "B", weight=1)
    G.add_edge("B", "D", weight=2)
    G.add_edge("B", "E", weight=3)
    G.add_edge("D", "E", weight=5)
    G.add_edge("A", "E", weight=2)
    G.add_edge("A", "C", weight=4)
    G.add_edge("C", "F", weight=6)
    G.add_edge("C", "G", weight=7)
    print(nx.shortest_path(G, "A", "D", weight="weight"))


def Ex08():
    G = nx.Graph()

    G.add_edge(u_of_edge="0", v_of_edge="1", weight=3)
    G.add_edge(u_of_edge="0", v_of_edge="3", weight=7)
    G.add_edge(u_of_edge="0", v_of_edge="4", weight=8)
    G.add_edge(u_of_edge="1", v_of_edge="2", weight=1)
    G.add_edge(u_of_edge="1", v_of_edge="3", weight=4)
    G.add_edge(u_of_edge="2", v_of_edge="3", weight=2)
    G.add_edge(u_of_edge="3", v_of_edge="4", weight=3)

    nx.draw(G=G, with_labels=True)
    plt.show()

    print(nx.shortest_path(G=G, source="1", target="4", weight="weight"))


def Ex09():
    G = nx.Graph()

    G.add_edge("v1", "v2", weight=5)
    G.add_edge("v1", "v3", weight=6)
    G.add_edge("v2", "v3", weight=8)
    G.add_edge("v2", "v4", weight=3)
    G.add_edge("v2", "v5", weight=4)
    G.add_edge("v3", "v5", weight=6)
    G.add_edge("v4", "v5", weight=3)
    G.add_edge("v4", "v6", weight=7)
    G.add_edge("v5", "v6", weight=7)

    nx.draw(G=G, with_labels=True)
    plt.show()

    print(nx.shortest_path(G=G, source="v1", target="v6", weight="weight"))


def Ex10():
    G = nx.Graph()

    G.add_edge("0", "1", weight=0.54)
    G.add_edge("0", "2", weight=0.14)
    G.add_edge("0", "7", weight=0.47)
    G.add_edge("1", "2", weight=0.63)
    G.add_edge("1", "3", weight=0.35)
    G.add_edge("1", "4", weight=0.30)
    G.add_edge("1", "7", weight=0.31)
    G.add_edge("2", "3", weight=0.31)
    G.add_edge("3", "4", weight=0.54)
    G.add_edge("3", "5", weight=0.43)
    G.add_edge("3", "7", weight=0.13)
    G.add_edge("4", "5", weight=0.54)
    G.add_edge("4", "6", weight=0.62)
    G.add_edge("4", "7", weight=0.54)
    G.add_edge("5", "6", weight=0.37)

    nx.draw(G=G, with_labels=True)
    plt.show()

    print(nx.shortest_path(G=G, source="0", target="6", weight="weight"))


def Ex11():
    G = nx.Graph()

    G.add_edge("0", "1", weight=4)
    G.add_edge("0", "7", weight=8)
    G.add_edge("1", "2", weight=8)
    G.add_edge("1", "7", weight=11)
    G.add_edge("2", "3", weight=7)
    G.add_edge("2", "8", weight=2)
    G.add_edge("2", "5", weight=4)
    G.add_edge("3", "4", weight=9)
    G.add_edge("3", "5", weight=14)
    G.add_edge("4", "5", weight=10)
    G.add_edge("5", "6", weight=2)
    G.add_edge("6", "7", weight=1)
    G.add_edge("6", "8", weight=6)
    G.add_edge("7", "8", weight=7)

    nx.draw(G=G, with_labels=True)
    plt.show()

    print(nx.shortest_path(G=G, source="1", target="5", weight="weight"))


Ex01()
Ex02()
Ex03()
Ex04()
Ex05()
Ex06()
Ex07()
Ex08()
Ex09()
Ex10()
Ex11()
