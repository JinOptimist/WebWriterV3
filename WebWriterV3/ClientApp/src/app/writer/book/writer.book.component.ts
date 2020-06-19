import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'writer-book',
  templateUrl: './writer.book.component.html',
})

export class WriterBookComponent {
  public book: IBookModel;
  private http: HttpClient;
  private baseUrl: string;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.book = new BookModel();
    this.http = http;
    this.baseUrl = baseUrl;
  }

  public Save() {
    this.http.post<IBookModel>(this.baseUrl + 'writer/save', this.book)
      .subscribe(answer => {
        if (answer) {
          alert('+');
        }
      }, error => console.error(error));
  }
}

class BookModel implements IBookModel{
    name: string;
    authorName: string;
}

interface IBookModel {
  name: string;
  authorName: string;
}
