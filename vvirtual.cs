using System;
class sample{
    int a=45;
    public virtual void Show(){
        a=350;
        Console.WriteLine("hey");
         Console.WriteLine(a);
    }
}
class vvirtual:sample{
    public override void Show(){
         Console.WriteLine("bye");
    }
    static void Main(string[] args){
        vvirtual a=new vvirtual();
        a.Show();
    }
}