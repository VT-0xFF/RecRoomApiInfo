using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;
using RecRoom.AssetIds;
using RecRoom.Avatars;
using RecRoom.Avatars.Data.Shared;
using RecRoom.Logging.Attributes;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_AvatarRenderingSystems_Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : DHBOPDJGFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8366EA0", Offset = "0x83654A0", VA = "0x188366EA0", Slot = "4")]
		public override void NCEHDCEOICJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class KDIENLLELBI : NGIPAAPAACN<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int EEGOGBABKAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD3B1C0", Offset = "0xD397C0", VA = "0x180D3B1C0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8366DD0", Offset = "0x83653D0", VA = "0x188366DD0", Slot = "36")]
	protected override Vector3 PFBLLIEPMLB(float[] LGMBOCEBOMM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8366D50", Offset = "0x8365350", VA = "0x188366D50", Slot = "37")]
	protected override float[] NGACLBPFFMM(Vector3 KOPHBHGIACG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8366E20", Offset = "0x8365420", VA = "0x188366E20")]
	public KDIENLLELBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class CBIFDCOMJHI : NGIPAAPAACN<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int EEGOGBABKAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xC4BAB0", Offset = "0xC4A0B0", VA = "0x180C4BAB0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8362B20", Offset = "0x8361120", VA = "0x188362B20", Slot = "36")]
	protected override Vector2 PFBLLIEPMLB(float[] LGMBOCEBOMM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8362AB0", Offset = "0x83610B0", VA = "0x188362AB0", Slot = "37")]
	protected override float[] NGACLBPFFMM(Vector2 KOPHBHGIACG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8362B60", Offset = "0x8361160", VA = "0x188362B60")]
	public CBIFDCOMJHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NKCFLECBNAF : NGIPAAPAACN<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int EEGOGBABKAE
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xBAD870", Offset = "0xBABE70", VA = "0x180BAD870", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8367220", Offset = "0x8365820", VA = "0x188367220", Slot = "36")]
	protected override Quaternion PFBLLIEPMLB(float[] LGMBOCEBOMM)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8367190", Offset = "0x8365790", VA = "0x188367190", Slot = "37")]
	protected override float[] NGACLBPFFMM(Quaternion KOPHBHGIACG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8367280", Offset = "0x8365880", VA = "0x188367280")]
	public NKCFLECBNAF()
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AvatarItemDownloadableConfig : IEquatable<AvatarItemDownloadableConfig>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public enum HNMMCPOIFLA
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
		public HNMMCPOIFLA Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180")]
			[CompilerGenerated]
			get
			{
				return default(HNMMCPOIFLA);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAA7130", Offset = "0xAA5730", VA = "0x180AA7130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xAA55C0", Offset = "0xAA3BC0", VA = "0x180AA55C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8361CE0", Offset = "0x83602E0", VA = "0x188361CE0", Slot = "0")]
		public override bool Equals(object AAGCKLPFJME)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8361F50", Offset = "0x8360550", VA = "0x188361F50")]
		public static bool MGLHCKHANFO(AvatarItemDownloadableConfig NEOIFOEJGFD, AvatarItemDownloadableConfig KNACFLNMNOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8361E10", Offset = "0x8360410", VA = "0x188361E10", Slot = "4")]
		public bool Equals(AvatarItemDownloadableConfig AAGCKLPFJME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8361EE0", Offset = "0x83604E0", VA = "0x188361EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x10BF130", Offset = "0x10BD730", VA = "0x1810BF130")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Runtime
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedAvatarItemSelection : IEquatable<SerializedAvatarItemSelection>, IComparable<SerializedAvatarItemSelection>, CCOONKOMFAG, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public SerializedAvatarItemId AvatarItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public SerializedCombinationId CombinationId;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8368E70", Offset = "0x8367470", VA = "0x188368E70")]
		private void CCFAHJBHKFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8368F00", Offset = "0x8367500", VA = "0x188368F00", Slot = "4")]
		public bool Equals(SerializedAvatarItemSelection AAGCKLPFJME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8368F80", Offset = "0x8367580", VA = "0x188368F80", Slot = "0")]
		public override bool Equals(object MPIDDJPOOMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8369070", Offset = "0x8367670", VA = "0x188369070", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8368EE0", Offset = "0x83674E0", VA = "0x188368EE0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemSelection AAGCKLPFJME)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x12CB4E0", Offset = "0x12C9AE0", VA = "0x1812CB4E0", Slot = "6")]
		public Guid JGIEIICPJCB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8368E70", Offset = "0x8367470", VA = "0x188368E70", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8369080", Offset = "0x8367680", VA = "0x188369080", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class FEPBBHKDKGD : JCIDINNKHCA<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class HNFAGPBLIKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public HNFAGPBLIKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x83631B0", Offset = "0x83617B0", VA = "0x1883631B0")]
		internal void NDJMDEPMOBF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8366340", Offset = "0x8364940", VA = "0x188366340")]
		internal void BGNFFDNKHJD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x83667F0", Offset = "0x8364DF0", VA = "0x1883667F0")]
		internal void NGKIGIBOBNP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x83666A0", Offset = "0x8364CA0", VA = "0x1883666A0")]
		internal void MLLDIGLGEPB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x83665F0", Offset = "0x8364BF0", VA = "0x1883665F0")]
		internal void LEAJJFFEKJD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x83663F0", Offset = "0x83649F0", VA = "0x1883663F0")]
		internal void CBALCALFFIP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8366540", Offset = "0x8364B40", VA = "0x188366540")]
		internal void JICFDLFJNGG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x83668A0", Offset = "0x8364EA0", VA = "0x1883668A0")]
		internal void PBPFNCPAOMO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8366750", Offset = "0x8364D50", VA = "0x188366750")]
		internal void MOGBFJCFPAN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x83664A0", Offset = "0x8364AA0", VA = "0x1883664A0")]
		internal void GOPLKBOMPPH(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct GPDDOLFJCMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x83658A0", Offset = "0x8363EA0", VA = "0x1883658A0", Slot = "37")]
	public override void PJLOBLPJLOA(Utf8JsonReader KLIAOPJFDOK, JsonSerializerOptions PLMLGIGGGNL, string JKLGGALPDGD, AnchorParamsRestrictions NANHMPOBBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8365400", Offset = "0x8363A00", VA = "0x188365400", Slot = "38")]
	public override void ABGJNJOBCGP(Utf8JsonWriter CKPHLHCIFLA, AnchorParamsRestrictions KOPHBHGIACG, JsonSerializerOptions PLMLGIGGGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8365DC0", Offset = "0x83643C0", VA = "0x188365DC0")]
	public FEPBBHKDKGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3DBBB30", Offset = "0x3DBA130", VA = "0x183DBBB30")]
	[CompilerGenerated]
	internal static void IJJFOKANCNK<T>(string JKLGGALPDGD, T IKJAADLGNCL, T GNLNAAOPLFJ, GPDDOLFJCMG P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class DICIAFFHLFO : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private delegate void IBDILDDCAEC(Utf8JsonReader OCNJDNNPAAP);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class PPKNKCMILIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public SerializedAvatarItemData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public bool hasReadOutfitType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public DICIAFFHLFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public IBDILDDCAEC <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public IBDILDDCAEC <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public IBDILDDCAEC <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public IBDILDDCAEC <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public IBDILDDCAEC <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public IBDILDDCAEC <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public IBDILDDCAEC <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public IBDILDDCAEC <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public IBDILDDCAEC <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public IBDILDDCAEC <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public IBDILDDCAEC <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public PPKNKCMILIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x83688C0", Offset = "0x8366EC0", VA = "0x1883688C0")]
		internal void KBJEDHAOJNO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8368450", Offset = "0x8366A50", VA = "0x188368450")]
		internal void CLNCMNMKOEI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x83686C0", Offset = "0x8366CC0", VA = "0x1883686C0")]
		internal void ENPIMNHDABD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x83685E0", Offset = "0x8366BE0", VA = "0x1883685E0")]
		internal void DIOPFDCBJNJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8368810", Offset = "0x8366E10", VA = "0x188368810")]
		internal void HCBDMHDEOPL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8368690", Offset = "0x8366C90", VA = "0x188368690")]
		internal void EGGEBJJHANK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x83683D0", Offset = "0x83669D0", VA = "0x1883683D0")]
		internal void BAFGCHBMGGM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8368500", Offset = "0x8366B00", VA = "0x188368500")]
		internal void CPMFKILOPAB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8368950", Offset = "0x8366F50", VA = "0x188368950")]
		internal void ODJHAPJJJHC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8368770", Offset = "0x8366D70", VA = "0x188368770")]
		internal void FKBCHMOMGIC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8368900", Offset = "0x8366F00", VA = "0x188368900")]
		internal void LLAKOFEJPAJ(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class OICCGJHMDFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string propertyName;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public OICCGJHMDFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8367520", Offset = "0x8365B20", VA = "0x188367520")]
		internal void LEGECIJKGAH(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x83638F0", Offset = "0x8361EF0", VA = "0x1883638F0", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader KLIAOPJFDOK, Type GHELDBCOLBK, JsonSerializerOptions PLMLGIGGGNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x83644F0", Offset = "0x8362AF0", VA = "0x1883644F0", Slot = "28")]
	public override void Write(Utf8JsonWriter CKPHLHCIFLA, SerializedAvatarItemData KOPHBHGIACG, JsonSerializerOptions PLMLGIGGGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8363610", Offset = "0x8361C10", VA = "0x188363610")]
	private AdditionalOutfitTypeData FKJKAJAMICF(Utf8JsonReader KLIAOPJFDOK, OutfitType GPEIAHGICNA, JsonSerializerOptions PLMLGIGGGNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8364930", Offset = "0x8362F30", VA = "0x188364930")]
	public DICIAFFHLFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GENNLBAPFHH : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8365E00", Offset = "0x8364400", VA = "0x188365E00", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader KLIAOPJFDOK, Type GHELDBCOLBK, JsonSerializerOptions PLMLGIGGGNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8366190", Offset = "0x8364790", VA = "0x188366190", Slot = "28")]
	public override void Write(Utf8JsonWriter CKPHLHCIFLA, AvatarItemDownloadableConfig KOPHBHGIACG, JsonSerializerOptions PLMLGIGGGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x83662C0", Offset = "0x83648C0", VA = "0x1883662C0")]
	public GENNLBAPFHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class FEDAHDCKNON : JCIDINNKHCA<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8365220", Offset = "0x8363820", VA = "0x188365220", Slot = "37")]
	public override void PJLOBLPJLOA(Utf8JsonReader KLIAOPJFDOK, JsonSerializerOptions PLMLGIGGGNL, string JKLGGALPDGD, BeardData NANHMPOBBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8365160", Offset = "0x8363760", VA = "0x188365160", Slot = "38")]
	public override void ABGJNJOBCGP(Utf8JsonWriter CKPHLHCIFLA, BeardData KOPHBHGIACG, JsonSerializerOptions PLMLGIGGGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x83653C0", Offset = "0x83639C0", VA = "0x1883653C0")]
	public FEDAHDCKNON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class HACILDODPGK : EEJFKOGCNCF<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8366300", Offset = "0x8364900", VA = "0x188366300")]
	public HACILDODPGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class AAGJMFKNILH : EEJFKOGCNCF<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8361CA0", Offset = "0x83602A0", VA = "0x188361CA0")]
	public AAGJMFKNILH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class JAIBCDEFIPA : EEJFKOGCNCF<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8366950", Offset = "0x8364F50", VA = "0x188366950")]
	public JAIBCDEFIPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class LBKOAIOKGCF : DEEPMGALBGG<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x8366E60", Offset = "0x8365460", VA = "0x188366E60")]
	public LBKOAIOKGCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class CDHNFKGFELA : JCIDINNKHCA<AdditionalFeetData>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class CKHNLBLJBAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AdditionalFeetData item;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public CKHNLBLJBAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8363290", Offset = "0x8361890", VA = "0x188363290")]
		internal void NDJMDEPMOBF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8363260", Offset = "0x8361860", VA = "0x188363260")]
		internal void BGNFFDNKHJD(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8362FA0", Offset = "0x83615A0", VA = "0x188362FA0", Slot = "37")]
	public override void PJLOBLPJLOA(Utf8JsonReader KLIAOPJFDOK, JsonSerializerOptions PLMLGIGGGNL, string JKLGGALPDGD, AdditionalFeetData NANHMPOBBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8362ED0", Offset = "0x83614D0", VA = "0x188362ED0", Slot = "38")]
	public override void ABGJNJOBCGP(Utf8JsonWriter CKPHLHCIFLA, AdditionalFeetData KOPHBHGIACG, JsonSerializerOptions PLMLGIGGGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8363130", Offset = "0x8361730", VA = "0x188363130")]
	public CDHNFKGFELA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class OKEJJAFOJEM : JCIDINNKHCA<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class JMEGABOJIHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public JMEGABOJIHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8366BD0", Offset = "0x83651D0", VA = "0x188366BD0")]
		internal void NDJMDEPMOBF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x83669C0", Offset = "0x8364FC0", VA = "0x1883669C0")]
		internal void BGNFFDNKHJD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8366C80", Offset = "0x8365280", VA = "0x188366C80")]
		internal void NGKIGIBOBNP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8366B30", Offset = "0x8365130", VA = "0x188366B30")]
		internal void MLLDIGLGEPB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8366A90", Offset = "0x8365090", VA = "0x188366A90")]
		internal void LEAJJFFEKJD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x83669F0", Offset = "0x8364FF0", VA = "0x1883669F0")]
		internal void CBALCALFFIP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8363290", Offset = "0x8361890", VA = "0x188363290")]
		internal void JICFDLFJNGG(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x83678A0", Offset = "0x8365EA0", VA = "0x1883678A0", Slot = "37")]
	public override void PJLOBLPJLOA(Utf8JsonReader KLIAOPJFDOK, JsonSerializerOptions PLMLGIGGGNL, string JKLGGALPDGD, HairData NANHMPOBBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x83675C0", Offset = "0x8365BC0", VA = "0x1883675C0", Slot = "38")]
	public override void ABGJNJOBCGP(Utf8JsonWriter CKPHLHCIFLA, HairData KOPHBHGIACG, JsonSerializerOptions PLMLGIGGGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8367C90", Offset = "0x8366290", VA = "0x188367C90")]
	public OKEJJAFOJEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class DLBLPAIGBPK : JCIDINNKHCA<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class ONKODLIKJJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public ONKODLIKJJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8366990", Offset = "0x8364F90", VA = "0x188366990")]
		internal void NDJMDEPMOBF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8367CD0", Offset = "0x83662D0", VA = "0x188367CD0")]
		internal void BGNFFDNKHJD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8368020", Offset = "0x8366620", VA = "0x188368020")]
		internal void NGKIGIBOBNP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8367F70", Offset = "0x8366570", VA = "0x188367F70")]
		internal void MLLDIGLGEPB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8367EC0", Offset = "0x83664C0", VA = "0x188367EC0")]
		internal void LEAJJFFEKJD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8367D80", Offset = "0x8366380", VA = "0x188367D80")]
		internal void CBALCALFFIP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8367E20", Offset = "0x8366420", VA = "0x188367E20")]
		internal void JICFDLFJNGG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x83680D0", Offset = "0x83666D0", VA = "0x1883680D0")]
		internal void PBPFNCPAOMO(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8364CC0", Offset = "0x83632C0", VA = "0x188364CC0", Slot = "37")]
	public override void PJLOBLPJLOA(Utf8JsonReader KLIAOPJFDOK, JsonSerializerOptions PLMLGIGGGNL, string JKLGGALPDGD, AdditionalHatData NANHMPOBBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8364970", Offset = "0x8362F70", VA = "0x188364970", Slot = "38")]
	public override void ABGJNJOBCGP(Utf8JsonWriter CKPHLHCIFLA, AdditionalHatData KOPHBHGIACG, JsonSerializerOptions PLMLGIGGGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8365120", Offset = "0x8363720", VA = "0x188365120")]
	public DLBLPAIGBPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class DEGNFNGGBIM : JCIDINNKHCA<RoomieEquipmentData>
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class JJCGAGPJFBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public RoomieEquipmentData item;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public JJCGAGPJFBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8366990", Offset = "0x8364F90", VA = "0x188366990")]
		internal void NDJMDEPMOBF(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8363350", Offset = "0x8361950", VA = "0x188363350", Slot = "35")]
	protected override void FFALGPGFFKD(RoomieEquipmentData NANHMPOBBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8363400", Offset = "0x8361A00", VA = "0x188363400", Slot = "37")]
	public override void PJLOBLPJLOA(Utf8JsonReader KLIAOPJFDOK, JsonSerializerOptions PLMLGIGGGNL, string JKLGGALPDGD, RoomieEquipmentData NANHMPOBBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x83632C0", Offset = "0x83618C0", VA = "0x1883632C0", Slot = "38")]
	public override void ABGJNJOBCGP(Utf8JsonWriter CKPHLHCIFLA, RoomieEquipmentData KOPHBHGIACG, JsonSerializerOptions PLMLGIGGGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x83635D0", Offset = "0x8361BD0", VA = "0x1883635D0")]
	public DEGNFNGGBIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class MPLJLMOODHL : JCIDINNKHCA<RoomieEyeData>
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class GBOAGAIFKIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public RoomieEyeData item;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public GBOAGAIFKIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x83631B0", Offset = "0x83617B0", VA = "0x1883631B0")]
		internal void NDJMDEPMOBF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8363170", Offset = "0x8361770", VA = "0x188363170")]
		internal void BGNFFDNKHJD(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8366FC0", Offset = "0x83655C0", VA = "0x188366FC0", Slot = "37")]
	public override void PJLOBLPJLOA(Utf8JsonReader KLIAOPJFDOK, JsonSerializerOptions PLMLGIGGGNL, string JKLGGALPDGD, RoomieEyeData NANHMPOBBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8366F30", Offset = "0x8365530", VA = "0x188366F30", Slot = "38")]
	public override void ABGJNJOBCGP(Utf8JsonWriter CKPHLHCIFLA, RoomieEyeData KOPHBHGIACG, JsonSerializerOptions PLMLGIGGGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8367150", Offset = "0x8365750", VA = "0x188367150")]
	public MPLJLMOODHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class CCGJGKMBCEP : JCIDINNKHCA<RoomieHatData>
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class JNJOGNFKJCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public RoomieHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public JNJOGNFKJCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x83631B0", Offset = "0x83617B0", VA = "0x1883631B0")]
		internal void NDJMDEPMOBF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8363170", Offset = "0x8361770", VA = "0x188363170")]
		internal void BGNFFDNKHJD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8366CB0", Offset = "0x83652B0", VA = "0x188366CB0")]
		internal void NGKIGIBOBNP(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8362CA0", Offset = "0x83612A0", VA = "0x188362CA0", Slot = "37")]
	public override void PJLOBLPJLOA(Utf8JsonReader KLIAOPJFDOK, JsonSerializerOptions PLMLGIGGGNL, string JKLGGALPDGD, RoomieHatData NANHMPOBBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8362BA0", Offset = "0x83611A0", VA = "0x188362BA0", Slot = "38")]
	public override void ABGJNJOBCGP(Utf8JsonWriter CKPHLHCIFLA, RoomieHatData KOPHBHGIACG, JsonSerializerOptions PLMLGIGGGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8362E90", Offset = "0x8361490", VA = "0x188362E90")]
	public CCGJGKMBCEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class PABBDNPOEFO : JCIDINNKHCA<RoomieMouthData>
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class MFAOENPNKJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public RoomieMouthData item;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public MFAOENPNKJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x83631B0", Offset = "0x83617B0", VA = "0x1883631B0")]
		internal void NDJMDEPMOBF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8363170", Offset = "0x8361770", VA = "0x188363170")]
		internal void BGNFFDNKHJD(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8368200", Offset = "0x8366800", VA = "0x188368200", Slot = "37")]
	public override void PJLOBLPJLOA(Utf8JsonReader KLIAOPJFDOK, JsonSerializerOptions PLMLGIGGGNL, string JKLGGALPDGD, RoomieMouthData NANHMPOBBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8368170", Offset = "0x8366770", VA = "0x188368170", Slot = "38")]
	public override void ABGJNJOBCGP(Utf8JsonWriter CKPHLHCIFLA, RoomieMouthData KOPHBHGIACG, JsonSerializerOptions PLMLGIGGGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8368390", Offset = "0x8366990", VA = "0x188368390")]
	public PABBDNPOEFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class OFJNEAJBEBH : JCIDINNKHCA<RoomieWaistData>
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class CGKJANHLLBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public RoomieWaistData item;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public CGKJANHLLBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x83631B0", Offset = "0x83617B0", VA = "0x1883631B0")]
		internal void NDJMDEPMOBF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8363170", Offset = "0x8361770", VA = "0x188363170")]
		internal void BGNFFDNKHJD(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8367350", Offset = "0x8365950", VA = "0x188367350", Slot = "37")]
	public override void PJLOBLPJLOA(Utf8JsonReader KLIAOPJFDOK, JsonSerializerOptions PLMLGIGGGNL, string JKLGGALPDGD, RoomieWaistData NANHMPOBBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x83672C0", Offset = "0x83658C0", VA = "0x1883672C0", Slot = "38")]
	public override void ABGJNJOBCGP(Utf8JsonWriter CKPHLHCIFLA, RoomieWaistData KOPHBHGIACG, JsonSerializerOptions PLMLGIGGGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x83674E0", Offset = "0x8365AE0", VA = "0x1883674E0")]
	public OFJNEAJBEBH()
	{
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class SerializedAvatarItemData : IEquatable<SerializedAvatarItemData>
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAA55F0", Offset = "0xAA3BF0", VA = "0x180AA55F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xAB04F0", Offset = "0xAAEAF0", VA = "0x180AB04F0")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xAB2A20", Offset = "0xAB1020", VA = "0x180AB2A20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xAA70F0", Offset = "0xAA56F0", VA = "0x180AA70F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xC58290", Offset = "0xC56890", VA = "0x180C58290")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xC18890", Offset = "0xC16E90", VA = "0x180C18890")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xF8C250", Offset = "0xF8A850", VA = "0x180F8C250")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xF8C260", Offset = "0xF8A860", VA = "0x180F8C260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x10CB400", Offset = "0x10C9A00", VA = "0x1810CB400")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x10CB410", Offset = "0x10C9A10", VA = "0x1810CB410")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x22E8C30", Offset = "0x22E7230", VA = "0x1822E8C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x8368E60", Offset = "0x8367460", VA = "0x188368E60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2FCE2C0", Offset = "0x2FCC8C0", VA = "0x182FCE2C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x2FCE150", Offset = "0x2FCC750", VA = "0x182FCE150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xAF4430", Offset = "0xAF2A30", VA = "0x180AF4430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xAF4440", Offset = "0xAF2A40", VA = "0x180AF4440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public EDHDPNHKKLO.IBJCDOEDFHO ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xAA55B0", Offset = "0xAA3BB0", VA = "0x180AA55B0")]
			[CompilerGenerated]
			get
			{
				return default(EDHDPNHKKLO.IBJCDOEDFHO);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x1402CE0", Offset = "0x14012E0", VA = "0x181402CE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xAA5710", Offset = "0xAA3D10", VA = "0x180AA5710")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xAA5590", Offset = "0xAA3B90", VA = "0x180AA5590")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8368990", Offset = "0x8366F90", VA = "0x188368990", Slot = "0")]
		public override bool Equals(object AAGCKLPFJME)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8368E40", Offset = "0x8367440", VA = "0x188368E40")]
		public static bool MGLHCKHANFO(SerializedAvatarItemData NEOIFOEJGFD, SerializedAvatarItemData KNACFLNMNOM)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8368E10", Offset = "0x8367410", VA = "0x188368E10")]
		public static bool HKOGMNAKMAE(SerializedAvatarItemData NEOIFOEJGFD, SerializedAvatarItemData KNACFLNMNOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8368A20", Offset = "0x8367020", VA = "0x188368A20", Slot = "4")]
		public bool Equals(SerializedAvatarItemData AAGCKLPFJME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8368D40", Offset = "0x8367340", VA = "0x188368D40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
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
