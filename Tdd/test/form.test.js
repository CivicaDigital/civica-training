import * as form from '../src/form';

describe('Integration tests', () => {
  describe('The input validation tests', () => {
    test('Validate input', () => {
      const result = form.validateInput({ name: 'first-name', value: 'aaa11', validation: 'alphabetical' });
      expect(result.valid).toEqual(false);
      expect(result.inputName).toEqual('first-name');
      expect(result.errorMessage).toEqual('input must only contain letters');
    });
  });
});
