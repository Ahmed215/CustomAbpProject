import { CustomAbpProjectTemplatePage } from './app.po';

describe('CustomAbpProject App', function() {
  let page: CustomAbpProjectTemplatePage;

  beforeEach(() => {
    page = new CustomAbpProjectTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
