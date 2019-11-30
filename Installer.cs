using System;
namespace Composition {
  public class Installer {
    private Logger _logger;
    public void DbMigrator (Logger logger) {
      _logger = logger;
    }

    public Installer (Logger logger) {
      _logger = logger;
    }
    public void Install () {
      _logger.Log ("Installing . . . ");
    }
  }
}