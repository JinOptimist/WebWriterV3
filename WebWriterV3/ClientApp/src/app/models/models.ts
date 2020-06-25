export interface IBookModel {
  name: string;
  text: string;
  authorName: string;
}

export class BookModel implements IBookModel {
  name: string;
  text: string;
  authorName: string;
}
