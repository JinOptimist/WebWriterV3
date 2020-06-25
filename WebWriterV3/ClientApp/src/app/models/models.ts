export interface IBookModel {
  name: string;
  authorName: string;
}

export class BookModel implements IBookModel {
  name: string;
  authorName: string;
}
