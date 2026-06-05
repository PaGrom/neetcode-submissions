public class MinStack {

    private Node Current;

    public MinStack() {
        Current = null;
    }
    
    public void Push(int val) {
        Current = new Node(val, Current);
    }
    
    public void Pop() {
        Current = Current.Prev;
    }
    
    public int Top() {
        return Current.Val;
    }
    
    public int GetMin() {
        return Current.Min;
    }
}

public class Node {
    public int Val {get;}
    public Node Prev {get;}
    public int Min {get;}

    public Node(int val, Node prev){
        Val = val;
        Prev = prev;
        if (prev != null) {
            Min = int.Min(val, prev.Min);
        }
        else {
            Min = val;
        }
    }
}
