using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;
using RecRoom.Avatars;
using RecRoom.Avatars.Data.Shared;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class LAOHCGJNOLJ : FALJPGJCKKB<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int AKKFFAPEOHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9ADA30", Offset = "0x9ACE30", VA = "0x1809ADA30", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x67A6530", Offset = "0x67A5930", VA = "0x1867A6530", Slot = "36")]
	protected override Vector3 BKOBFJAFNAK(float[] FJJNGLOPNDO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x67A6580", Offset = "0x67A5980", VA = "0x1867A6580", Slot = "37")]
	protected override float[] DDIJPMGPJCD(Vector3 OBEEJPGJPFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x67A6600", Offset = "0x67A5A00", VA = "0x1867A6600")]
	public LAOHCGJNOLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class MKDNAIEBNGP : FALJPGJCKKB<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int AKKFFAPEOHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9A0F70", Offset = "0x9A0370", VA = "0x1809A0F70", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x67A6920", Offset = "0x67A5D20", VA = "0x1867A6920", Slot = "36")]
	protected override Vector2 BKOBFJAFNAK(float[] FJJNGLOPNDO)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x67A6960", Offset = "0x67A5D60", VA = "0x1867A6960", Slot = "37")]
	protected override float[] DDIJPMGPJCD(Vector2 OBEEJPGJPFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x67A69D0", Offset = "0x67A5DD0", VA = "0x1867A69D0")]
	public MKDNAIEBNGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class ALMFOAIFEDL : FALJPGJCKKB<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int AKKFFAPEOHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9A0160", Offset = "0x99F560", VA = "0x1809A0160", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x67A25E0", Offset = "0x67A19E0", VA = "0x1867A25E0", Slot = "36")]
	protected override Quaternion BKOBFJAFNAK(float[] FJJNGLOPNDO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x67A2640", Offset = "0x67A1A40", VA = "0x1867A2640", Slot = "37")]
	protected override float[] DDIJPMGPJCD(Quaternion OBEEJPGJPFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x67A26D0", Offset = "0x67A1AD0", VA = "0x1867A26D0")]
	public ALMFOAIFEDL()
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class AvatarItemDownloadableConfig
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public enum EJFKDCCCLPP
		{
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			Prerelease = 0,
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			InitialRelease = 1,
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			CurrentPlusOne = 2,
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			Current = 1
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public static JsonSerializerOptions Options;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public EJFKDCCCLPP Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x84B1A0", Offset = "0x84A5A0", VA = "0x18084B1A0")]
			[CompilerGenerated]
			get
			{
				return default(EJFKDCCCLPP);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x84D870", Offset = "0x84CC70", VA = "0x18084D870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x84D8F0", Offset = "0x84CCF0", VA = "0x18084D8F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9F3840", Offset = "0x9F2C40", VA = "0x1809F3840")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class BDHJBCDNIGN : OIFIHGEMFMA<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class DPBNIAHHOGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public DPBNIAHHOGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x67A39B0", Offset = "0x67A2DB0", VA = "0x1867A39B0")]
		internal void ADNIHLFECFL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x67A3D10", Offset = "0x67A3110", VA = "0x1867A3D10")]
		internal void EKDEKEOLLOH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x67A3BC0", Offset = "0x67A2FC0", VA = "0x1867A3BC0")]
		internal void BKMLAHKFIBK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x67A3E70", Offset = "0x67A3270", VA = "0x1867A3E70")]
		internal void JAMHCOMCFEH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x67A3900", Offset = "0x67A2D00", VA = "0x1867A3900")]
		internal void ACEBHIDJCJF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x67A3DC0", Offset = "0x67A31C0", VA = "0x1867A3DC0")]
		internal void IKLFKKLDCHF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x67A3B10", Offset = "0x67A2F10", VA = "0x1867A3B10")]
		internal void AJPPOHJIKOB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x67A3A60", Offset = "0x67A2E60", VA = "0x1867A3A60")]
		internal void AHFIEIKPBPJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x67A3C70", Offset = "0x67A3070", VA = "0x1867A3C70")]
		internal void DBOKKKFCHPA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x67A3F20", Offset = "0x67A3320", VA = "0x1867A3F20")]
		internal void MDHNFEHHOLA(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct KAPFKEAHPKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x67A2EC0", Offset = "0x67A22C0", VA = "0x1867A2EC0", Slot = "35")]
	public override void BCBLELBBGAA(Utf8JsonReader CKPGDBBGEAK, JsonSerializerOptions ANGMLGCFELB, string DHNNKKAIOAA, AnchorParamsRestrictions OFMNHGBOMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x67A33E0", Offset = "0x67A27E0", VA = "0x1867A33E0", Slot = "36")]
	public override void GGFPEBJNGLO(Utf8JsonWriter CCOPEDCAMKJ, AnchorParamsRestrictions OBEEJPGJPFD, JsonSerializerOptions ANGMLGCFELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x67A3880", Offset = "0x67A2C80", VA = "0x1867A3880")]
	public BDHJBCDNIGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x28E37F0", Offset = "0x28E2BF0", VA = "0x1828E37F0")]
	[CompilerGenerated]
	internal static void MDNAFALOINL<T>(string DHNNKKAIOAA, T ELOBPEFBAOG, T LDGGHLEPBMA, KAPFKEAHPKB P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class HPIEGBJCBGB : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private delegate void DMNMDNKLIFE(Utf8JsonReader LONPDOIHFKH);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class NLNAMFAOPHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public SerializedAvatarItemData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public bool hasReadOutfitType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public HPIEGBJCBGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public DMNMDNKLIFE <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public DMNMDNKLIFE <>9__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public DMNMDNKLIFE <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public DMNMDNKLIFE <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public DMNMDNKLIFE <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DMNMDNKLIFE <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public DMNMDNKLIFE <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public DMNMDNKLIFE <>9__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public DMNMDNKLIFE <>9__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public DMNMDNKLIFE <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public DMNMDNKLIFE <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public DMNMDNKLIFE <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public DMNMDNKLIFE <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public DMNMDNKLIFE <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public NLNAMFAOPHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x67A6EA0", Offset = "0x67A62A0", VA = "0x1867A6EA0")]
		internal void HHLGIEEOGEI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x67A4930", Offset = "0x67A3D30", VA = "0x1867A4930")]
		internal void CMBAFFHHFMI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x67A6A90", Offset = "0x67A5E90", VA = "0x1867A6A90")]
		internal void AKMKKHPIAOA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x67A6F80", Offset = "0x67A6380", VA = "0x1867A6F80")]
		internal void JCFHCOJLCMA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x67A6DF0", Offset = "0x67A61F0", VA = "0x1867A6DF0")]
		internal void GMCLLKNENDL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x67A7060", Offset = "0x67A6460", VA = "0x1867A7060")]
		internal void PNPOFMCGHGL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x67A7030", Offset = "0x67A6430", VA = "0x1867A7030")]
		internal void MOELCIAIAPD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x67A6EE0", Offset = "0x67A62E0", VA = "0x1867A6EE0")]
		internal void HJENPJIFDJL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x67A6F50", Offset = "0x67A6350", VA = "0x1867A6F50")]
		internal void IJDKANHMMMH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x67A6A10", Offset = "0x67A5E10", VA = "0x1867A6A10")]
		internal void AKBNOPAKOKK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x67A6BE0", Offset = "0x67A5FE0", VA = "0x1867A6BE0")]
		internal void EBIJJALKBHP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x67A6F10", Offset = "0x67A6310", VA = "0x1867A6F10")]
		internal void HOBHJDEDODO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x67A6B40", Offset = "0x67A5F40", VA = "0x1867A6B40")]
		internal void CECBBMAICGK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x67A6CC0", Offset = "0x67A60C0", VA = "0x1867A6CC0")]
		internal void EJHFHMELMPH(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x67A4BF0", Offset = "0x67A3FF0", VA = "0x1867A4BF0", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader CKPGDBBGEAK, Type KDPCMKEFAIB, JsonSerializerOptions ANGMLGCFELB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x67A5650", Offset = "0x67A4A50", VA = "0x1867A5650", Slot = "28")]
	public override void Write(Utf8JsonWriter CCOPEDCAMKJ, SerializedAvatarItemData OBEEJPGJPFD, JsonSerializerOptions ANGMLGCFELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x67A4AD0", Offset = "0x67A3ED0", VA = "0x1867A4AD0")]
	private AdditionalOutfitTypeData GCIHEHIBHNE(Utf8JsonReader CKPGDBBGEAK, OutfitType EPPKBKJHHHJ, JsonSerializerOptions ANGMLGCFELB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x67A5B00", Offset = "0x67A4F00", VA = "0x1867A5B00")]
	public HPIEGBJCBGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class KANDNCIONIB : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x67A6050", Offset = "0x67A5450", VA = "0x1867A6050", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader CKPGDBBGEAK, Type KDPCMKEFAIB, JsonSerializerOptions ANGMLGCFELB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x67A63C0", Offset = "0x67A57C0", VA = "0x1867A63C0", Slot = "28")]
	public override void Write(Utf8JsonWriter CCOPEDCAMKJ, AvatarItemDownloadableConfig OBEEJPGJPFD, JsonSerializerOptions ANGMLGCFELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x67A64B0", Offset = "0x67A58B0", VA = "0x1867A64B0")]
	public KANDNCIONIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class MELPDGDFBCP : OIFIHGEMFMA<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x67A6640", Offset = "0x67A5A40", VA = "0x1867A6640", Slot = "35")]
	public override void BCBLELBBGAA(Utf8JsonReader CKPGDBBGEAK, JsonSerializerOptions ANGMLGCFELB, string DHNNKKAIOAA, BeardData OFMNHGBOMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x67A67E0", Offset = "0x67A5BE0", VA = "0x1867A67E0", Slot = "36")]
	public override void GGFPEBJNGLO(Utf8JsonWriter CCOPEDCAMKJ, BeardData OBEEJPGJPFD, JsonSerializerOptions ANGMLGCFELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x67A68A0", Offset = "0x67A5CA0", VA = "0x1867A68A0")]
	public MELPDGDFBCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class KCEMELNLLOE : JMDGIKMLPCM<EELDMELBMLB>
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x67A64F0", Offset = "0x67A58F0", VA = "0x1867A64F0")]
	public KCEMELNLLOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JKPMMBDDHLH : JMDGIKMLPCM<FNNANKKDODC>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x67A6010", Offset = "0x67A5410", VA = "0x1867A6010")]
	public JKPMMBDDHLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MJDIFEEDGNI : JMDGIKMLPCM<IKBEKODFIOD>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x67A68E0", Offset = "0x67A5CE0", VA = "0x1867A68E0")]
	public MJDIFEEDGNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class DNDGECLEEFK : INIMJDAJNIO<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x67A38C0", Offset = "0x67A2CC0", VA = "0x1867A38C0")]
	public DNDGECLEEFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class OECLKGDNBEO : OIFIHGEMFMA<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class HMLPHOJLJDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public HMLPHOJLJDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x67A4850", Offset = "0x67A3C50", VA = "0x1867A4850")]
		internal void ADNIHLFECFL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x67A4960", Offset = "0x67A3D60", VA = "0x1867A4960")]
		internal void EKDEKEOLLOH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x67A4930", Offset = "0x67A3D30", VA = "0x1867A4930")]
		internal void BKMLAHKFIBK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x67A4A30", Offset = "0x67A3E30", VA = "0x1867A4A30")]
		internal void JAMHCOMCFEH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x67A47B0", Offset = "0x67A3BB0", VA = "0x1867A47B0")]
		internal void ACEBHIDJCJF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x67A4990", Offset = "0x67A3D90", VA = "0x1867A4990")]
		internal void IKLFKKLDCHF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x67A4900", Offset = "0x67A3D00", VA = "0x1867A4900")]
		internal void AJPPOHJIKOB(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x67A7110", Offset = "0x67A6510", VA = "0x1867A7110", Slot = "35")]
	public override void BCBLELBBGAA(Utf8JsonReader CKPGDBBGEAK, JsonSerializerOptions ANGMLGCFELB, string DHNNKKAIOAA, HairData OFMNHGBOMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x67A7500", Offset = "0x67A6900", VA = "0x1867A7500", Slot = "36")]
	public override void GGFPEBJNGLO(Utf8JsonWriter CCOPEDCAMKJ, HairData OBEEJPGJPFD, JsonSerializerOptions ANGMLGCFELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x67A77E0", Offset = "0x67A6BE0", VA = "0x1867A77E0")]
	public OECLKGDNBEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class EMJLAGMDHNI : OIFIHGEMFMA<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class JHCKCFEHGFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public JHCKCFEHGFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x67A5BF0", Offset = "0x67A4FF0", VA = "0x1867A5BF0")]
		internal void ADNIHLFECFL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x67A5E10", Offset = "0x67A5210", VA = "0x1867A5E10")]
		internal void EKDEKEOLLOH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x67A5D60", Offset = "0x67A5160", VA = "0x1867A5D60")]
		internal void BKMLAHKFIBK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x67A5F60", Offset = "0x67A5360", VA = "0x1867A5F60")]
		internal void JAMHCOMCFEH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x67A5B40", Offset = "0x67A4F40", VA = "0x1867A5B40")]
		internal void ACEBHIDJCJF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x67A5EC0", Offset = "0x67A52C0", VA = "0x1867A5EC0")]
		internal void IKLFKKLDCHF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x67A5CC0", Offset = "0x67A50C0", VA = "0x1867A5CC0")]
		internal void AJPPOHJIKOB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x67A5C20", Offset = "0x67A5020", VA = "0x1867A5C20")]
		internal void AHFIEIKPBPJ(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x67A3FC0", Offset = "0x67A33C0", VA = "0x1867A3FC0", Slot = "35")]
	public override void BCBLELBBGAA(Utf8JsonReader CKPGDBBGEAK, JsonSerializerOptions ANGMLGCFELB, string DHNNKKAIOAA, AdditionalHatData OFMNHGBOMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x67A4420", Offset = "0x67A3820", VA = "0x1867A4420", Slot = "36")]
	public override void GGFPEBJNGLO(Utf8JsonWriter CCOPEDCAMKJ, AdditionalHatData OBEEJPGJPFD, JsonSerializerOptions ANGMLGCFELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x67A4770", Offset = "0x67A3B70", VA = "0x1867A4770")]
	public EMJLAGMDHNI()
	{
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class SerializedAvatarItemData
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x850BC0", VA = "0x1808517C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8517F0", Offset = "0x850BF0", VA = "0x1808517F0")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x851810", Offset = "0x850C10", VA = "0x180851810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x84D8A0", Offset = "0x84CCA0", VA = "0x18084D8A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x84D8D0", Offset = "0x84CCD0", VA = "0x18084D8D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xB41E20", Offset = "0xB41220", VA = "0x180B41E20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xC38310", Offset = "0xC37710", VA = "0x180C38310")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xED10C0", Offset = "0xED04C0", VA = "0x180ED10C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xED12A0", Offset = "0xED06A0", VA = "0x180ED12A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x1EF5800", Offset = "0x1EF4C00", VA = "0x181EF5800")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x1EF5810", Offset = "0x1EF4C10", VA = "0x181EF5810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x14DFD60", Offset = "0x14DF160", VA = "0x1814DFD60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x67A7820", Offset = "0x67A6C20", VA = "0x1867A7820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2335B10", Offset = "0x2334F10", VA = "0x182335B10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2335CC0", Offset = "0x23350C0", VA = "0x182335CC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x1C1E610", Offset = "0x1C1DA10", VA = "0x181C1E610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x1C1E620", Offset = "0x1C1DA20", VA = "0x181C1E620")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public IJCBONOKOKD ItemBodyType
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xC09BF0", Offset = "0xC08FF0", VA = "0x180C09BF0")]
			[CompilerGenerated]
			get
			{
				return default(IJCBONOKOKD);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xC093E0", Offset = "0xC087E0", VA = "0x180C093E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public GAGIPHDMFOM.EKBGBPNADEI ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x9F2DF0", Offset = "0x9F21F0", VA = "0x1809F2DF0")]
			[CompilerGenerated]
			get
			{
				return default(GAGIPHDMFOM.EKBGBPNADEI);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xC09600", Offset = "0xC08A00", VA = "0x180C09600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8507B0", Offset = "0x84FBB0", VA = "0x1808507B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8507A0", Offset = "0x84FBA0", VA = "0x1808507A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Guid ProxyAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x9528F0", Offset = "0x951CF0", VA = "0x1809528F0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9506D0", Offset = "0x94FAD0", VA = "0x1809506D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Guid AvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x112BC30", Offset = "0x112B030", VA = "0x18112BC30")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x37DF750", Offset = "0x37DEB50", VA = "0x1837DF750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public SerializedAvatarItemData()
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
