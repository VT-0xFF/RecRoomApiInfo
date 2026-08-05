using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using RecRoom.DataLayer;
using RecRoom.Protobuf;
using Unity.Mathematics;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class XZYMFDMNRDD
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct MonoScriptData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public byte[] FilePathsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public byte[] TypesData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int TotalTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public int TotalFiles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public bool IsEditorOnly;
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
	public XZYMFDMNRDD()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class CFWDMGCYAED : QZJKTETVCZD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private NNGVETGIUWJ.PhysicsMode JPLXGSZFQHN;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly ByteString KLSBMJSFUUV;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly ByteString ESEZSPXRUAQ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override NNGVETGIUWJ.PhysicsMode LVTFYVKRYES
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAA3180", Offset = "0xAA1980", VA = "0x180AA3180", Slot = "13")]
			get
			{
				return default(NNGVETGIUWJ.PhysicsMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8282FC0", Offset = "0x82817C0", VA = "0x188282FC0")]
		public bool SMOCGIWFEJD(WSAKIWWEIUX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8282CA0", Offset = "0x82814A0", VA = "0x188282CA0")]
		private static bool DEQOXACWQPI(WSAKIWWEIUX a, [Out] NNGVETGIUWJ.PhysicsMode b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public CFWDMGCYAED()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class HBNPTKZSSKO : CXMXTYVDGAS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected WSAKIWWEIUX SGFFMWMCVZN;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public virtual WSAKIWWEIUX DQYIQAERBXZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xAA1620", Offset = "0xA9FE20", VA = "0x180AA1620", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool KLZZCGFHOXC
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x82833A0", Offset = "0x8281BA0", VA = "0x1882833A0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool QDLQHGLGEND
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x82833D0", Offset = "0x8281BD0", VA = "0x1882833D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool BECUUHINWHT
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8283400", Offset = "0x8281C00", VA = "0x188283400", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool XWVSEDHKSMZ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8283370", Offset = "0x8281B70", VA = "0x188283370", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool IXSUPTGKCAK
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8283340", Offset = "0x8281B40", VA = "0x188283340", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public HBNPTKZSSKO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class SKGOXDMWSKB : JIFOGZQCGUX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly SerializedDataWrapper SGFFMWMCVZN;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8283DA0", Offset = "0x82825A0", VA = "0x188283DA0")]
		public SKGOXDMWSKB(SerializedDataWrapper a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x82837D0", Offset = "0x8281FD0", VA = "0x1882837D0", Slot = "4")]
		public bool ESOTPZWCMBO(NNGVETGIUWJ a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8283960", Offset = "0x8282160", VA = "0x188283960", Slot = "5")]
		public bool JVHHMUMDWVR(NNGVETGIUWJ a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8283BF0", Offset = "0x82823F0", VA = "0x188283BF0", Slot = "6")]
		public bool MERJSKKLEAW(GUJDUNKUVZP a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x82838F0", Offset = "0x82820F0", VA = "0x1882838F0")]
		private IReadOnlyList<WSAKIWWEIUX> ICQJQXIVXOZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8283AC0", Offset = "0x82822C0", VA = "0x188283AC0")]
		private bool KCAVGHXDHLN(int a, [Out][NotNullWhen(true)] WSAKIWWEIUX containerData)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class DVFXOMCJTNC : QZJKTETVCZD, PDZBPNNCKBW, NNGVETGIUWJ, CXMXTYVDGAS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private RepeatedField<XZQQECINGIU> JRDOOKUTDHD;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override WSAKIWWEIUX DQYIQAERBXZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x82832E0", Offset = "0x8281AE0", VA = "0x1882832E0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override NNGVETGIUWJ.PhysicsMode LVTFYVKRYES
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8283270", Offset = "0x8281A70", VA = "0x188283270", Slot = "13")]
			get
			{
				return default(NNGVETGIUWJ.PhysicsMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int OLYZTWZNFDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x82832A0", Offset = "0x8281AA0", VA = "0x1882832A0", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8283150", Offset = "0x8281950", VA = "0x188283150", Slot = "15")]
		public void CEZBWUUMMXY(YWXIECYFSJP a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public DVFXOMCJTNC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class QZJKTETVCZD : HBNPTKZSSKO, NNGVETGIUWJ, CXMXTYVDGAS
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract NNGVETGIUWJ.PhysicsMode LVTFYVKRYES
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool MQVGHQCHVIG
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8283730", Offset = "0x8281F30", VA = "0x188283730", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool KAZSAKHSIOV
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8283770", Offset = "0x8281F70", VA = "0x188283770", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool FBLKADNGOQV
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x82837A0", Offset = "0x8281FA0", VA = "0x1882837A0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		protected QZJKTETVCZD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class THMNUTIVFWN : YWXIECYFSJP, AFRCELLAMEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private XZQQECINGIU SGFFMWMCVZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private RepeatedField<OKKDAZNQVJM> TSQIXPIKFOI;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public XZQQECINGIU DQYIQAERBXZ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x82842B0", Offset = "0x8282AB0", VA = "0x1882842B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool SILAKNNMBSO
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8283E60", Offset = "0x8282660", VA = "0x188283E60", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public PrimitiveShapeType PICFBGHHBUA
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2506280", Offset = "0x2504A80", VA = "0x182506280", Slot = "5")]
			get
			{
				return default(PrimitiveShapeType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public AFRCELLAMEN ZZXGECDYGCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8284270", Offset = "0x8282A70", VA = "0x188284270", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float3 ZJSBNRYHJFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x82844A0", Offset = "0x8282CA0", VA = "0x1882844A0", Slot = "7")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public quaternion UWXJAJSPRJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8284440", Offset = "0x8282C40", VA = "0x188284440", Slot = "8")]
			get
			{
				return default(quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float3 BDFPJJLKDEX
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8284100", Offset = "0x8282900", VA = "0x188284100", Slot = "9")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public RenderableMaterial AZNSACCNCRA
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x2FE8B30", Offset = "0x2FE7330", VA = "0x182FE8B30", Slot = "10")]
			get
			{
				return default(RenderableMaterial);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public RenderableColor CWTSHUVBTEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1057CB0", Offset = "0x10564B0", VA = "0x181057CB0", Slot = "11")]
			get
			{
				return default(RenderableColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float YRQYMFCEPWO
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8284330", Offset = "0x8282B30", VA = "0x188284330", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float3 PEVUDNVACYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8283DF0", Offset = "0x82825F0", VA = "0x188283DF0", Slot = "13")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float CQOOCFVVROV
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8283E80", Offset = "0x8282680", VA = "0x188283E80", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ShapeConfigFlags ZZNUELXOKMI
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x59F5D60", Offset = "0x59F4560", VA = "0x1859F5D60", Slot = "15")]
			get
			{
				return default(ShapeConfigFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int KGDUHTNMJHC
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8283ED0", Offset = "0x82826D0", VA = "0x188283ED0", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool PHVSKUBHCUE
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8284350", Offset = "0x8282B50", VA = "0x188284350", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool EFEPVFYBIZZ
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8283EA0", Offset = "0x82826A0", VA = "0x188283EA0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float NWJKVLZDJIA
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x82843E0", Offset = "0x8282BE0", VA = "0x1882843E0", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool SPORLWOAUNN
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8284310", Offset = "0x8282B10", VA = "0x188284310", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int LPRVSXHRVEW
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8284380", Offset = "0x8282B80", VA = "0x188284380", Slot = "21")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8283F10", Offset = "0x8282710", VA = "0x188283F10", Slot = "22")]
		public void OFOAQFQBRXH(QBPMBFEPNIR a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public THMNUTIVFWN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class QGPAVQBRFSF : QBPMBFEPNIR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private (OKKDAZNQVJM curr, OKKDAZNQVJM next, ShapeConfigFlags flags) SGFFMWMCVZN;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public (OKKDAZNQVJM curr, OKKDAZNQVJM next, ShapeConfigFlags flags) DQYIQAERBXZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x5942010", Offset = "0x5940810", VA = "0x185942010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float3 YDDTOFVMNHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8283430", Offset = "0x8281C30", VA = "0x188283430", Slot = "4")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float3 CJFCKJJVJNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8283700", Offset = "0x8281F00", VA = "0x188283700", Slot = "5")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x82834A0", Offset = "0x8281CA0", VA = "0x1882834A0", Slot = "6")]
		public quaternion RMLCVGYHMOS(float3 a)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public QGPAVQBRFSF()
		{
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
