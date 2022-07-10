from asyncore import loop


def loop_size(node):
    index = {}
    i = 0
    while True:
        if node in index:
            return i - index[node]

        index[node] = i
        node = node.next
        i += 1


def loop_size_fifi(node):
    nodes = []
    while node:
        if node in nodes:
            idx = nodes.index(node)
            return(len(nodes) - idx)

        nodes.append(node)
        node = node.next

    return {}


class Node:
    _ID = 0

    def __init__(self) -> None:
        self.id = self._ID
        self.__class__._ID += 1
        self.next = None


def create_chain(chain, loop):
    nodes = [Node() for _ in range(chain)]
    for node, next_node in zip(nodes, nodes[1:]):
        node.next = next_node

    nodes[chain - 1].next = nodes[chain - loop - 1]

    return nodes[0]


nodes = [Node() for _ in range(50)]
for node, next_node in zip(nodes, nodes[1:]):
    node.next = next_node
nodes[49].next = nodes[21]


print(loop_size(nodes[0]))
