Reto de Refactorización: Operación Tienda D1 (High Cohesion + ISP)

Tienes un sistema interno de una tienda tipo D1. Al inicio era una tienda pequeña y una persona hacía de todo, por eso se creó una sola interfaz con todo mezclado. Hoy la tienda creció y ya existen roles separados: caja, bodega y soporte. El sistema funciona, pero el diseño está mal para escalar.

Estado actual (ANTES)

Problemas claros:

Interfaz demasiado grande (ISP roto)
Caja, bodega y soporte dependen del mismo contrato, aunque cada rol usa solo una parte.

Clase central con demasiadas responsabilidades (baja cohesión)
Una sola clase implementa todo: ventas, inventario y reclamos.

Cambios con efecto dominó
Cambiar algo de inventario puede afectar caja, porque todo pasa por el mismo sistema.

Objetivo del reto

Refactoriza para cumplir:

ISP: separar la interfaz grande en interfaces pequeñas por rol.

High Cohesion: separar la clase central en clases cohesionadas (cada una con propósito claro).
