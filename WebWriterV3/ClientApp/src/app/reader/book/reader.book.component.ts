import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'reader-book',
  templateUrl: './reader.book.component.html',
})

export class ReaderBookComponent {
  public chapters: ChapterModel[];
  public currentChapter: ChapterModel;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<ChapterModel[]>(baseUrl + 'reader/All').subscribe(result => {
      this.chapters = result;
      this.currentChapter = this.chapters[0];
    }, error => console.error(error));
  }

  public GoToChapter(index) {
    this.currentChapter = this.chapters[index];
  }
}

interface ChapterModel {
  title: string;
  body: string;
  action: string;
  topics: string[];
}
