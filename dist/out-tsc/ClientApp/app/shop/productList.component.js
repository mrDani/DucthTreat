"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.ProductList = void 0;
var tslib_1 = require("tslib");
var core_1 = require("@angular/core");
var ProductList = /** @class */ (function () {
    function ProductList() {
        this.products = [
            {
                title: "First Product",
                price: 19.99
            },
            {
                title: "Second Product",
                price: 59.99
            },
            {
                title: "Third Product",
                price: 14.99
            }
        ];
    }
    ProductList = tslib_1.__decorate([
        core_1.Component({
            selector: "product-list",
            templateUrl: "productList.component.html",
            styleUrls: []
        })
    ], ProductList);
    return ProductList;
}());
exports.ProductList = ProductList;
//# sourceMappingURL=productList.component.js.map