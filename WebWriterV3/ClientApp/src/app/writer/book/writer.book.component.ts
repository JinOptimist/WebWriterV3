import { Component } from '@angular/core';
import { HttpHelper } from 'src/app/helper/http.helper';
import FroalaEditor from 'froala-editor';
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

    this.httpHelper
      .Get<IBookModel>('writer/load')
      .then(answer => { this.book = answer; });
  }

  public Save() {
    this.httpHelper.Post<IBookModel>('writer/save', this.book)
      .then(x => { console.log('1') })
      .then(x => { console.log('2') })
      .then(x => { console.log('3') });
  }

  options = {
    toolbarButtons: ['Boom'],
  };

  
}

