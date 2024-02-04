USE [AdministracionAgencia]
GO
SET IDENTITY_INSERT [dbo].[TipoHabitacion] ON 
GO
INSERT [dbo].[TipoHabitacion] ([IdTipoHabitacion], [Descripcion]) VALUES (1, N'Sencilla')
GO
INSERT [dbo].[TipoHabitacion] ([IdTipoHabitacion], [Descripcion]) VALUES (2, N'Doble')
GO
INSERT [dbo].[TipoHabitacion] ([IdTipoHabitacion], [Descripcion]) VALUES (3, N'Queen Size')
GO
INSERT [dbo].[TipoHabitacion] ([IdTipoHabitacion], [Descripcion]) VALUES (4, N'King')
GO
INSERT [dbo].[TipoHabitacion] ([IdTipoHabitacion], [Descripcion]) VALUES (5, N'Super king')
GO
INSERT [dbo].[TipoHabitacion] ([IdTipoHabitacion], [Descripcion]) VALUES (6, N'Presidencial')
GO
SET IDENTITY_INSERT [dbo].[TipoHabitacion] OFF
GO
SET IDENTITY_INSERT [dbo].[UbicacionHabitacion] ON 
GO
INSERT [dbo].[UbicacionHabitacion] ([IdUbicacionHabitacion], [Descripcion]) VALUES (1, N'Piso 1')
GO
INSERT [dbo].[UbicacionHabitacion] ([IdUbicacionHabitacion], [Descripcion]) VALUES (2, N'Piso 2')
GO
INSERT [dbo].[UbicacionHabitacion] ([IdUbicacionHabitacion], [Descripcion]) VALUES (3, N'Piso 3')
GO
INSERT [dbo].[UbicacionHabitacion] ([IdUbicacionHabitacion], [Descripcion]) VALUES (4, N'Piso 4')
GO
INSERT [dbo].[UbicacionHabitacion] ([IdUbicacionHabitacion], [Descripcion]) VALUES (5, N'Vista al mar')
GO
INSERT [dbo].[UbicacionHabitacion] ([IdUbicacionHabitacion], [Descripcion]) VALUES (6, N'Vista a la piscina')
GO
SET IDENTITY_INSERT [dbo].[UbicacionHabitacion] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoDocumento] ON 
GO
INSERT [dbo].[TipoDocumento] ([IdTipoDocumento], [NombreTipoDocumento]) VALUES (1, N'Cédula')
GO
INSERT [dbo].[TipoDocumento] ([IdTipoDocumento], [NombreTipoDocumento]) VALUES (2, N'NIT')
GO
INSERT [dbo].[TipoDocumento] ([IdTipoDocumento], [NombreTipoDocumento]) VALUES (3, N'Pasaporte')
GO
INSERT [dbo].[TipoDocumento] ([IdTipoDocumento], [NombreTipoDocumento]) VALUES (4, N'RUT')
GO
SET IDENTITY_INSERT [dbo].[TipoDocumento] OFF
GO
SET IDENTITY_INSERT [dbo].[Agente] ON 
GO
INSERT [dbo].[Agente] ([IdAgente], [NombreAgente], [PrimerApellido], [SegundoApellido], [IdTipoDocumento], [Identificacion]) VALUES (1, N'PEPE', N'PORRAS', N'PEREZ', 1, N'12345678')
GO
INSERT [dbo].[Agente] ([IdAgente], [NombreAgente], [PrimerApellido], [SegundoApellido], [IdTipoDocumento], [Identificacion]) VALUES (2, N'JUAN', N'MURILLO', N'LOPEZ', 1, N'987654321')
GO
INSERT [dbo].[Agente] ([IdAgente], [NombreAgente], [PrimerApellido], [SegundoApellido], [IdTipoDocumento], [Identificacion]) VALUES (4, N'ANA ', N'MUÑOZ', N'GONZALES', 2, N'852147963')
GO
SET IDENTITY_INSERT [dbo].[Agente] OFF
GO
SET IDENTITY_INSERT [dbo].[Hoteles] ON 
GO
INSERT [dbo].[Hoteles] ([IdHotel], [RazonSocial], [Identificacion], [Direccion], [Telefono], [IdTipoDocumento], [FechaCreacion], [FechaModificacion]) VALUES (1, N'Hotel Rosal', N'900985632', N'calle 1', N'9856847', 2, CAST(N'2023-01-13T00:00:00.000' AS DateTime), NULL)
GO
SET IDENTITY_INSERT [dbo].[Hoteles] OFF
GO
SET IDENTITY_INSERT [dbo].[Estado] ON 
GO
INSERT [dbo].[Estado] ([IdEstado], [TipoEstado]) VALUES (1, N'Activo')
GO
INSERT [dbo].[Estado] ([IdEstado], [TipoEstado]) VALUES (2, N'Inactivo')
GO
SET IDENTITY_INSERT [dbo].[Estado] OFF
GO
INSERT [dbo].[Genero] ([IdGenero], [TipoGenero]) VALUES (1, N'Femenino')
GO
INSERT [dbo].[Genero] ([IdGenero], [TipoGenero]) VALUES (2, N'Masculino')
GO
