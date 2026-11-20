public class Solution {
    public bool IsValid(string s) {
        int brace = 0, curly_brace = 0, square_brace = 0;
        Stack<char> stack = new Stack<char>();

        foreach (var ch in s){
            if(ch == '(' || ch == '{' || ch == '['){
                stack.Push(ch);
            }
            else if(stack.Count == 0){
                return false;
            }
            else if(ch == ')'){
                if(stack.Peek() == '('){
                    stack.Pop();
                }
                else return false;
            }
            else if(ch == '}'){
                if(stack.Peek() == '{'){
                    stack.Pop();
                }
                else return false;
            }
            else if(ch == ']'){
                if(stack.Peek() == '['){
                    stack.Pop();
                }
                else return false;
            }
        }
        
        if(stack.Count != 0) return false;

        return true;
    }
}
