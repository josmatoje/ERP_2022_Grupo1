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

save() {
    this.dialogRef.close(true);
}

close() {
    this.dialogRef.close();
}
}