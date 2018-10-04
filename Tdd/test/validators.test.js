import * as validators from '../src/validators';

describe('Unit tests', () => {
  describe('The alphanumeric validation tests', () => {
    test('An alphanumeric value is identified as valid', () => {
      const result = validators.isAlphanumeric('Bob');
      expect(result).toEqual(true);
    });
  });
});
