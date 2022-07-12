function loop_size(node) {
  var nodes = [];
  var n = node;

  while (nodes.indexOf(n) === -1) {
    nodes.push(node);
    n = n.next;
  }

  return nodes.length - nodes.indexOf(n);
}

class Node {
  constructor() {
    this.nextNode = null;
  }

  get next() {
    return this.nextNode;
  }
  set next(node) {
    this.nextNode = node;
  }
}

const A = new Node(),
  B = new Node();
A.next = B;
B.next = A;

var result = loop_size(A);
console.log(result);
