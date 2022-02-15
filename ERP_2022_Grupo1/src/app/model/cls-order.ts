class ClsOrder {
    //Attributes
    private _orderId: number;
    private _total: number;
    private _orderDate: Date;
    private _limitOrderDate: Date;
    private _notes: String;
    private _supplierId: number;

    //Constructor
    constructor(orderId: number,total: number,orderDate: Date,limitOrderDate: Date,notes: String,supplierId: number){
        this._orderId = orderId;
        this._total = total;
        this._orderDate = orderDate;
        this._limitOrderDate = limitOrderDate;
        this._notes = notes;
        this._supplierId = supplierId;
    }

    //Getters & Setters 
    get orderId() : number{
        return this._orderId;
    }
    set orderId(orderId: number){
        this._orderId = orderId;
    }
    get total(): number{
        return this._total;
    }
    set total(total: number){
        this._total = total;
    }
    get orderDate() : Date{
        return this._orderDate;
    }
    set orderDate(orderDate: Date){
        this._orderDate = orderDate;
    }
    get limitOrderDate() : Date{
        return this._limitOrderDate;
    }
    set limitOrderDate(limitOrderDate: Date){
        this._limitOrderDate = limitOrderDate;
    }
    get notes() : String{
        return this._notes;
    }
    set notes(notes: String){
        this._notes = notes;
    }
    get supplierId() : number{
        return this._supplierId;
    }
    set supplierId(supplierId: number){
        this._supplierId = supplierId;
    }
}
