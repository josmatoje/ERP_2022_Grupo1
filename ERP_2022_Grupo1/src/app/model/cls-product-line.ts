import { ClsProduct } from "./cls-product";

export interface ClsProductLine extends ClsProduct{
    amount:number;
    status: boolean;
}
