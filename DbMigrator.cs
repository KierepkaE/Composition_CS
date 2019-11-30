using System;

namespace Composition {
  public class DbMigrator {
    private Logger _logger;
    public DbMigrator (Logger logger) {
      _logger = logger;
    }

    public void Migrate () {
      _logger.Log ("Migrating . . . ");
    }
  }
}