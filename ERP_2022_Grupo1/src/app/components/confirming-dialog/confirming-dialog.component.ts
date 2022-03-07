import { Component, OnInit } from '@angular/core';
import { MatDialogRef} from '@angular/material/dialog';
import { OrderListComponent } from '../order-list/order-list.component';

@Component({
  selector: 'app-confirming-dialog',
  templateUrl: './confirming-dialog.component.html',
  styleUrls: ['./confirming-dialog.component.scss']
})
export class ConfirmingDialogComponent implements OnInit {

  constructor(private dialogRef: MatDialogRef<OrderListComponent>) {}

ngOnInit() {

}
/**
 * Header: save()
 * 
 * Description: Este metodo cierra el dialog y guarda los datos
 * 
 * Precondition: Ninguna
 * Postcondition: Cierra el dialog y guarda los datos.
 */
save() {
    this.dialogRef.close(true);
}
/**
 * Header: close()
 * 
 * Description: Este metodo se encarga de cerrar el dialog
 * 
 * Precondition: Ninguna
 * Postcondition: Cierra el dialog
 */
close() {
    this.dialogRef.close();
}
}