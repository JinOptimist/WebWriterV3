import { Component } from '@angular/core';
import { HttpHelper } from 'src/app/helper/http.helper';
import { IBookModel, BookModel } from 'src/app/models/models';

@Component({
  selector: 'writer-book',
  templateUrl: './writer.book.component.html',
})

export class WriterBookComponent {
  public book: IBookModel;
  public httpHelper: HttpHelper;

  constructor(httpHelper: HttpHelper) {
    this.httpHelper = httpHelper;

    //httpHelper
    //  .Get('writer/load')
    //  .subscribe(x => { this.book = x; });

    this.book = new BookModel();
  }

  public Save() {
    this.httpHelper
      .Post('writer/save', this.book)
      .subscribe(x => { alert('+') });
  }
}

