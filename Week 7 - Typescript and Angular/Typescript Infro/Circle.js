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
