USE [master]
GO
/****** Object:  Database [AdministracionAgencia]    Script Date: 03/02/2024 20:41:00 ******/
CREATE DATABASE [AdministracionAgencia]

GO
USE [AdministracionAgencia]
GO
/****** Object:  Table [dbo].[Agencia]    Script Date: 03/02/2024 20:41:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Agencia](
	[IdAgencia] [int] NOT NULL,
	[NombrePlataforma] [varchar](max) NULL,
	[IdTipoIdentificacion] [int] NULL,
	[Identificacion] [varchar](50) NULL,
 CONSTRAINT [PK_Agencia] PRIMARY KEY CLUSTERED 
(
	[IdAgencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Agente]    Script Date: 03/02/2024 20:41:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Agente](
	[IdAgente] [int] IDENTITY(1,1) NOT NULL,
	[NombreAgente] [varchar](100) NOT NULL,
	[PrimerApellido] [varchar](100) NOT NULL,
	[SegundoApellido] [varchar](100) NULL,
	[IdTipoDocumento] [int] NOT NULL,
	[Identificacion] [varchar](50) NOT NULL,
 CONSTRAINT [PK__Agente__FAD2D3A6A26F30E8] PRIMARY KEY CLUSTERED 
(
	[IdAgente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AgenteHoteles]    Script Date: 03/02/2024 20:41:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AgenteHoteles](
	[IdAgenteHotel] [int] IDENTITY(1,1) NOT NULL,
	[IdHabitacion] [int] NOT NULL,
	[IdEstadoHotel] [int] NOT NULL,
	[IdEstadoHabitacion] [int] NOT NULL,
	[IdHotel] [int] NOT NULL,
	[IdAgente] [int] NOT NULL,
 CONSTRAINT [PK__AgenteHo__FAD2D3A67447DC9A] PRIMARY KEY CLUSTERED 
(
	[IdAgenteHotel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estado]    Script Date: 03/02/2024 20:41:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado](
	[IdEstado] [int] IDENTITY(1,1) NOT NULL,
	[TipoEstado] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdEstado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genero]    Script Date: 03/02/2024 20:41:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genero](
	[IdGenero] [int] NOT NULL,
	[TipoGenero] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Genero] PRIMARY KEY CLUSTERED 
(
	[IdGenero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Habitacion]    Script Date: 03/02/2024 20:41:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Habitacion](
	[IdHabitacion] [int] IDENTITY(1,1) NOT NULL,
	[NombreHabitacion] [varchar](100) NOT NULL,
	[IdTipoHabitacion] [int] NOT NULL,
	[ValorHabitacion] [decimal](18, 1) NOT NULL,
	[IdUbicacion] [int] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[FechaModificacion] [datetime] NOT NULL,
 CONSTRAINT [PK__Habitaci__8BBBF901BA082A87] PRIMARY KEY CLUSTERED 
(
	[IdHabitacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HabitacionImpuestos]    Script Date: 03/02/2024 20:41:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HabitacionImpuestos](
	[IdHabitacionImpuestos] [int] IDENTITY(1,1) NOT NULL,
	[IdHabitacion] [int] NOT NULL,
	[IdTipoImpuesto] [int] NOT NULL,
	[CostoBase] [decimal](18, 1) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdHabitacionImpuestos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hoteles]    Script Date: 03/02/2024 20:41:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hoteles](
	[IdHotel] [int] IDENTITY(1,1) NOT NULL,
	[RazonSocial] [varchar](max) NULL,
	[Identificacion] [varchar](50) NULL,
	[Direccion] [varchar](50) NULL,
	[Telefono] [varchar](10) NULL,
	[IdTipoDocumento] [int] NULL,
	[FechaCreacion] [datetime] NULL,
	[FechaModificacion] [datetime] NULL,
 CONSTRAINT [PK__Hoteles__653BCCC4DCCE1118] PRIMARY KEY CLUSTERED 
(
	[IdHotel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Impuestos]    Script Date: 03/02/2024 20:41:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Impuestos](
	[IdImpuesto] [int] IDENTITY(1,1) NOT NULL,
	[TipoImpuesto] [varchar](100) NOT NULL,
	[NombreImpuesto] [varchar](100) NOT NULL,
	[Porcentaje] [decimal](18, 1) NULL,
	[Base] [decimal](18, 1) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdImpuesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pasajero]    Script Date: 03/02/2024 20:41:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pasajero](
	[IdPasajero] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[PrimerApellido] [varchar](50) NOT NULL,
	[SegundoApellido] [varchar](50) NOT NULL,
	[FechaNacimiento] [datetime] NOT NULL,
	[IdGenero] [int] NOT NULL,
	[IdTipoDocumento] [int] NOT NULL,
	[NumeroDocumento] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Telefono] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Pasajero] PRIMARY KEY CLUSTERED 
(
	[IdPasajero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlataformaHotelesViajero]    Script Date: 03/02/2024 20:41:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlataformaHotelesViajero](
	[IdPlataformaViajero] [int] NOT NULL,
	[IdViajero] [int] NOT NULL,
	[IdHotel] [int] NOT NULL,
	[IdAgencia] [int] NOT NULL,
	[FechaAlojamiento] [datetime] NULL,
	[FechaSalidaAlojamiento] [datetime] NULL,
	[CantidadPersonas] [int] NULL,
	[Ciudad] [varchar](50) NULL,
 CONSTRAINT [PK_PlataformaHotelesViajero] PRIMARY KEY CLUSTERED 
(
	[IdPlataformaViajero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reserva]    Script Date: 03/02/2024 20:41:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reserva](
	[IdReserva] [int] NOT NULL,
	[IdViajero] [int] NOT NULL,
	[IdPasajero] [int] NOT NULL,
	[IdHotel] [int] NOT NULL,
	[IdHabitacion] [int] NOT NULL,
	[NombreContactoEmergencia] [varchar](50) NOT NULL,
	[ApellidoContactoEmergencia] [varchar](50) NOT NULL,
	[TelefonoContactoEmergencia] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoDocumento]    Script Date: 03/02/2024 20:41:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDocumento](
	[IdTipoDocumento] [int] IDENTITY(1,1) NOT NULL,
	[NombreTipoDocumento] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TipoDocumento] PRIMARY KEY CLUSTERED 
(
	[IdTipoDocumento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoHabitacion]    Script Date: 03/02/2024 20:41:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoHabitacion](
	[IdTipoHabitacion] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdTipoHabitacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UbicacionHabitacion]    Script Date: 03/02/2024 20:41:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UbicacionHabitacion](
	[IdUbicacionHabitacion] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdUbicacionHabitacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Viajero]    Script Date: 03/02/2024 20:41:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Viajero](
	[IdViajero] [int] NOT NULL,
	[Nombre] [varchar](max) NULL,
	[PrimerApellido] [varchar](50) NULL,
	[SegundoApellido] [varchar](50) NULL,
 CONSTRAINT [PK_Viajero] PRIMARY KEY CLUSTERED 
(
	[IdViajero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Agencia]  WITH CHECK ADD  CONSTRAINT [FK_Agencia_tipoidenti] FOREIGN KEY([IdTipoIdentificacion])
REFERENCES [dbo].[TipoDocumento] ([IdTipoDocumento])
GO
ALTER TABLE [dbo].[Agencia] CHECK CONSTRAINT [FK_Agencia_tipoidenti]
GO
ALTER TABLE [dbo].[Agente]  WITH CHECK ADD  CONSTRAINT [FK_TIPO_IDENT] FOREIGN KEY([IdTipoDocumento])
REFERENCES [dbo].[TipoDocumento] ([IdTipoDocumento])
GO
ALTER TABLE [dbo].[Agente] CHECK CONSTRAINT [FK_TIPO_IDENT]
GO
ALTER TABLE [dbo].[AgenteHoteles]  WITH CHECK ADD  CONSTRAINT [FK_AGENTE] FOREIGN KEY([IdAgente])
REFERENCES [dbo].[Agente] ([IdAgente])
GO
ALTER TABLE [dbo].[AgenteHoteles] CHECK CONSTRAINT [FK_AGENTE]
GO
ALTER TABLE [dbo].[AgenteHoteles]  WITH CHECK ADD  CONSTRAINT [FK_ESTADO_HAB] FOREIGN KEY([IdEstadoHabitacion])
REFERENCES [dbo].[Estado] ([IdEstado])
GO
ALTER TABLE [dbo].[AgenteHoteles] CHECK CONSTRAINT [FK_ESTADO_HAB]
GO
ALTER TABLE [dbo].[AgenteHoteles]  WITH CHECK ADD  CONSTRAINT [FK_ESTADO_HOTEL] FOREIGN KEY([IdEstadoHotel])
REFERENCES [dbo].[Estado] ([IdEstado])
GO
ALTER TABLE [dbo].[AgenteHoteles] CHECK CONSTRAINT [FK_ESTADO_HOTEL]
GO
ALTER TABLE [dbo].[AgenteHoteles]  WITH CHECK ADD  CONSTRAINT [FK_HABITACION] FOREIGN KEY([IdHabitacion])
REFERENCES [dbo].[Habitacion] ([IdHabitacion])
GO
ALTER TABLE [dbo].[AgenteHoteles] CHECK CONSTRAINT [FK_HABITACION]
GO
ALTER TABLE [dbo].[AgenteHoteles]  WITH CHECK ADD  CONSTRAINT [FK_HOTEL] FOREIGN KEY([IdHotel])
REFERENCES [dbo].[Hoteles] ([IdHotel])
GO
ALTER TABLE [dbo].[AgenteHoteles] CHECK CONSTRAINT [FK_HOTEL]
GO
ALTER TABLE [dbo].[Habitacion]  WITH CHECK ADD  CONSTRAINT [FK_TIPO_HAB] FOREIGN KEY([IdTipoHabitacion])
REFERENCES [dbo].[TipoHabitacion] ([IdTipoHabitacion])
GO
ALTER TABLE [dbo].[Habitacion] CHECK CONSTRAINT [FK_TIPO_HAB]
GO
ALTER TABLE [dbo].[Habitacion]  WITH CHECK ADD  CONSTRAINT [FK_UBICACION] FOREIGN KEY([IdUbicacion])
REFERENCES [dbo].[UbicacionHabitacion] ([IdUbicacionHabitacion])
GO
ALTER TABLE [dbo].[Habitacion] CHECK CONSTRAINT [FK_UBICACION]
GO
ALTER TABLE [dbo].[HabitacionImpuestos]  WITH CHECK ADD  CONSTRAINT [FK_IMP_HABI] FOREIGN KEY([IdHabitacion])
REFERENCES [dbo].[Habitacion] ([IdHabitacion])
GO
ALTER TABLE [dbo].[HabitacionImpuestos] CHECK CONSTRAINT [FK_IMP_HABI]
GO
ALTER TABLE [dbo].[HabitacionImpuestos]  WITH CHECK ADD  CONSTRAINT [FK_IMPUESTOS] FOREIGN KEY([IdTipoImpuesto])
REFERENCES [dbo].[Impuestos] ([IdImpuesto])
GO
ALTER TABLE [dbo].[HabitacionImpuestos] CHECK CONSTRAINT [FK_IMPUESTOS]
GO
ALTER TABLE [dbo].[Hoteles]  WITH CHECK ADD  CONSTRAINT [FK_TIPO_IDENT_HOT] FOREIGN KEY([IdTipoDocumento])
REFERENCES [dbo].[TipoDocumento] ([IdTipoDocumento])
GO
ALTER TABLE [dbo].[Hoteles] CHECK CONSTRAINT [FK_TIPO_IDENT_HOT]
GO
ALTER TABLE [dbo].[Pasajero]  WITH CHECK ADD  CONSTRAINT [FK_GENERO_PASA] FOREIGN KEY([IdGenero])
REFERENCES [dbo].[Genero] ([IdGenero])
GO
ALTER TABLE [dbo].[Pasajero] CHECK CONSTRAINT [FK_GENERO_PASA]
GO
ALTER TABLE [dbo].[Pasajero]  WITH CHECK ADD  CONSTRAINT [FK_TIPO_DOC_PASA] FOREIGN KEY([IdTipoDocumento])
REFERENCES [dbo].[TipoDocumento] ([IdTipoDocumento])
GO
ALTER TABLE [dbo].[Pasajero] CHECK CONSTRAINT [FK_TIPO_DOC_PASA]
GO
ALTER TABLE [dbo].[PlataformaHotelesViajero]  WITH CHECK ADD  CONSTRAINT [FK_Agencia] FOREIGN KEY([IdAgencia])
REFERENCES [dbo].[Agencia] ([IdAgencia])
GO
ALTER TABLE [dbo].[PlataformaHotelesViajero] CHECK CONSTRAINT [FK_Agencia]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_HABITACION_RESER] FOREIGN KEY([IdHabitacion])
REFERENCES [dbo].[Habitacion] ([IdHabitacion])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_HABITACION_RESER]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_HOTEL_RESER] FOREIGN KEY([IdHotel])
REFERENCES [dbo].[Hoteles] ([IdHotel])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_HOTEL_RESER]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_PASAJERO_RESER] FOREIGN KEY([IdPasajero])
REFERENCES [dbo].[Pasajero] ([IdPasajero])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_PASAJERO_RESER]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_VIAJERO_RESER] FOREIGN KEY([IdViajero])
REFERENCES [dbo].[Viajero] ([IdViajero])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_VIAJERO_RESER]
GO
USE [master]
GO
ALTER DATABASE [AdministracionAgencia] SET  READ_WRITE 
GO
