import { ArtisanTemplatePage } from './app.po';

describe('Artisan App', function() {
  let page: ArtisanTemplatePage;

  beforeEach(() => {
    page = new ArtisanTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
