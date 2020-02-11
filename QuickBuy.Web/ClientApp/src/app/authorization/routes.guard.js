"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var RoutesGuard = /** @class */ (function () {
    function RoutesGuard() {
    }
    RoutesGuard.prototype.canActivate = function (route, state) {
        // if authenticated user
        return true;
    };
    return RoutesGuard;
}());
exports.RoutesGuard = RoutesGuard;
//# sourceMappingURL=routes.guard.js.map