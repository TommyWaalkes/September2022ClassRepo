//you'll see duplicate errors on your class names , you can safely ignore that if your code is able to run
var Circle = /** @class */ (function () {
    function Circle(radius, bigEnough, creator) {
        this.bigEnough = bigEnough;
        this.radius = radius;
        this.creator = creator;
    }
    Circle.prototype.GetArea = function () {
        var area = Math.PI * this.radius * this.radius;
        return area;
    };
    return Circle;
}());
var c = new Circle(10, true, "Tommy");
console.log(c.GetArea());
var circles = [new Circle(15, true, "Jimmy"),
    new Circle(22, true, "Frank"),
    new Circle(3, false, "Alex")];
for (var i = 0; i < circles.length; i++) {
    var cir = circles[i];
    console.log(cir);
}
