import { FrontTodoPage } from './app.po';

describe('front-todo App', function() {
  let page: FrontTodoPage;

  beforeEach(() => {
    page = new FrontTodoPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
