import { DateTimeFormatPipe } from './DateTimeFormat.pipe';

describe('Pipe: DateTimeFormate', () => {
  it('create an instance', () => {
    let pipe = new DateTimeFormatPipe('dd/mm/yyyy h:mm');
    expect(pipe).toBeTruthy();
  });
});
