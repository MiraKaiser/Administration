/// <reference path="MyClass.ts" />

namespace MyNameSpace {

    function Welcome(person: string) {
        return "<h2>Hello " + person + ", Lets learn TypeScript!</h2>";
    }

    function ClickMeButton() {
        let user: string = "MithunVP";
        document.getElementById("divMsg").innerHTML = Welcome(user);
    }

    var test3 = new MyClass();
    var test2 = new MyClass();
    var test5 = new MyClass();
    var test4 = new MyClass();

}