var hooks = require('hooks');

hooks.beforeAll(function (transactions, done) {
  hooks.log('before all');
  done();
});

hooks.beforeEach(function (transaction, done) {
  hooks.log('before each');
//   console.log(transaction);
  done();
});

hooks.afterEach(function (transaction, done) {
  hooks.log('after each');
  done();
});

hooks.afterAll(function (transactions, done) {
  hooks.log('after all');
  done();
})