"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.AppComponent = void 0;
var tslib_1 = require("tslib");
var core_1 = require("@angular/core");
var AppComponent = /** @class */ (function () {
    function AppComponent() {
        this.title = 'Ducth Treat';
    }
    AppComponent = tslib_1.__decorate([
        core_1.Component({
            selector: 'my-app',
            template: "\n    <div style=\"text-align:center\" class=\"content\">\n      <h1>\n        Welcome to {{title}}!\n      </h1>\n         </div>\n  ",
            styles: []
        })
    ], AppComponent);
    return AppComponent;
}());
exports.AppComponent = AppComponent;
//# sourceMappingURL=app.component.js.map