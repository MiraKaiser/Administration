var MyNameSpace;
(function (MyNameSpace) {
    var MyClass = /** @class */ (function () {
        function MyClass() {
        }
        return MyClass;
    }());
    MyNameSpace.MyClass = MyClass;
})(MyNameSpace || (MyNameSpace = {}));
/// <reference path="MyClass.ts" />
var MyNameSpace;
(function (MyNameSpace) {
    function Welcome(person) {
        return "<h2>Hello " + person + ", Lets learn TypeScript!</h2>";
    }
    function ClickMeButton() {
        var user = "MithunVP";
        document.getElementById("divMsg").innerHTML = Welcome(user);
    }
    var test3 = new MyNameSpace.MyClass();
    var test2 = new MyNameSpace.MyClass();
    var test5 = new MyNameSpace.MyClass();
    var test4 = new MyNameSpace.MyClass();
})(MyNameSpace || (MyNameSpace = {}));
//# sourceMappingURL=Main.js.map