using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.AssetIds;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal static class DAABLJCCANJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4BF93C0", Offset = "0x4BF79C0", VA = "0x184BF93C0")]
	public static string ECHAPCBKLCK(this Guid IKGPBILBBIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x71955C0", Offset = "0x7193BC0", VA = "0x1871955C0")]
	public static Guid DFBEJDPCADB(string JEMFPCOEKGO)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DJMDINACHOK<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(string, string)> BIMJOCMNJFF(IEnumerable<(TModern, string)> BCDJFNKOFCL);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(TModern, string)> BHJLKGIODAK(IEnumerable<(string modernStr, string legacyStr)> MIEBFIJDADP);
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct ColorId : IEquatable<ColorId>, IComparable<ColorId>, HFBPDOKGMGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public static readonly ColorId Empty;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1B3F6A0", Offset = "0x1B3DCA0", VA = "0x181B3F6A0")]
		public ColorId(Guid IKGPBILBBIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7194E20", Offset = "0x7193420", VA = "0x187194E20")]
		public static ColorId FEKCLIBJICA()
		{
			return default(ColorId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA96690", Offset = "0xA94C90", VA = "0x180A96690", Slot = "6")]
		public Guid FNAJMACMDED()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x71949A0", Offset = "0x7192FA0", VA = "0x1871949A0", Slot = "4")]
		public bool Equals(ColorId EJECOGCICOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7194980", Offset = "0x7192F80", VA = "0x187194980", Slot = "5")]
		public int CompareTo(ColorId EJECOGCICOM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7194D80", Offset = "0x7193380", VA = "0x187194D80", Slot = "0")]
		public override bool Equals(object IAMEECMGPIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7194AC0", Offset = "0x71930C0", VA = "0x187194AC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7194B00", Offset = "0x7193100", VA = "0x187194B00")]
		public static bool MOJFGPLDDKP(ColorId CNCLMHODMJG, ColorId ECNLMNDOGCG)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7194AD0", Offset = "0x71930D0", VA = "0x187194AD0")]
		public static bool LFBHPMALHHK(ColorId CNCLMHODMJG, ColorId ECNLMNDOGCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7194E80", Offset = "0x7193480", VA = "0x187194E80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LAJOEDEKEPC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	LHAFDNLGABL<AvatarItemId> IFFDJHMHPHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	LHAFDNLGABL<EquipmentSkinId> OHHPKLLMBMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	LHAFDNLGABL<HairPatternId> FEANCBCCNHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	LHAFDNLGABL<MaterialId> DAPKDLADCOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	LHAFDNLGABL<CombinationId> GBHDFKDPEFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	LHAFDNLGABL<ColorId> DGFIKEEEOEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	LHAFDNLGABL<FaceShapeId> GFCPNDLPFDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	LHAFDNLGABL<BodyShapeId> MIGABDOOFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	LHAFDNLGABL<FaceFeatureId> IMCGIDAAFJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal class AssetIdMappingJsonData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public List<string> moderns;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public List<string> legacies;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x71948D0", Offset = "0x7192ED0", VA = "0x1871948D0")]
		public AssetIdMappingJsonData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct CombinationId : IEquatable<CombinationId>, IComparable<CombinationId>, HFBPDOKGMGM, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private MaterialId materialId0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private MaterialId materialId1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private MaterialId materialId2;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly CombinationId Empty;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public MaterialId MaterialId0
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x9420E0", Offset = "0x9406E0", VA = "0x1809420E0")]
			get
			{
				return default(MaterialId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public MaterialId MaterialId1
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x9A46F0", Offset = "0x9A2CF0", VA = "0x1809A46F0")]
			get
			{
				return default(MaterialId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public MaterialId MaterialId2
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xBEB750", Offset = "0xBE9D50", VA = "0x180BEB750")]
			get
			{
				return default(MaterialId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA96690", Offset = "0xA94C90", VA = "0x180A96690", Slot = "6")]
		public Guid FNAJMACMDED()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x71953A0", Offset = "0x71939A0", VA = "0x1871953A0")]
		public static CombinationId OJEFAMDGKAE(out MaterialId FMNPIGMHLPF)
		{
			return default(CombinationId);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7195580", Offset = "0x7193B80", VA = "0x187195580")]
		public CombinationId(Guid IKGPBILBBIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x71955A0", Offset = "0x7193BA0", VA = "0x1871955A0")]
		public CombinationId(MaterialId MEBEDDOPAAG, MaterialId EACBKCBLCKB, MaterialId OAALFNOKFDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x71950E0", Offset = "0x71936E0", VA = "0x1871950E0")]
		private void GIKEFCLNOOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7195050", Offset = "0x7193650", VA = "0x187195050", Slot = "4")]
		public bool Equals(CombinationId EJECOGCICOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7194F50", Offset = "0x7193550", VA = "0x187194F50", Slot = "0")]
		public override bool Equals(object IAMEECMGPIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7195300", Offset = "0x7193900", VA = "0x187195300", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7195050", Offset = "0x7193650", VA = "0x187195050")]
		public static bool MOJFGPLDDKP(CombinationId CNCLMHODMJG, CombinationId ECNLMNDOGCG)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7195310", Offset = "0x7193910", VA = "0x187195310")]
		public static bool LFBHPMALHHK(CombinationId CNCLMHODMJG, CombinationId ECNLMNDOGCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7194F30", Offset = "0x7193530", VA = "0x187194F30", Slot = "5")]
		public int CompareTo(CombinationId EJECOGCICOM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x71954C0", Offset = "0x7193AC0", VA = "0x1871954C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x71954B0", Offset = "0x7193AB0", VA = "0x1871954B0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class IFKLGPFEMIB : IFPKPFBIMGB<EquipmentSkinId>
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1B5E860", Offset = "0x1B5CE60", VA = "0x181B5E860", Slot = "7")]
	protected override EquipmentSkinId JEPPANNLDKP(Guid IKGPBILBBIK)
	{
		return default(EquipmentSkinId);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1B5E860", Offset = "0x1B5CE60", VA = "0x181B5E860", Slot = "8")]
	protected override Guid FNAJMACMDED(EquipmentSkinId ECPHLMGMGAK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x71963A0", Offset = "0x71949A0", VA = "0x1871963A0")]
	public IFKLGPFEMIB()
	{
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct BodyShapeId : IEquatable<BodyShapeId>, IComparable<BodyShapeId>, HFBPDOKGMGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly BodyShapeId Empty;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1B3F6A0", Offset = "0x1B3DCA0", VA = "0x181B3F6A0")]
		public BodyShapeId(Guid IKGPBILBBIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7194C30", Offset = "0x7193230", VA = "0x187194C30")]
		public static BodyShapeId FEKCLIBJICA()
		{
			return default(BodyShapeId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA96690", Offset = "0xA94C90", VA = "0x180A96690", Slot = "6")]
		public Guid FNAJMACMDED()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x71949A0", Offset = "0x7192FA0", VA = "0x1871949A0", Slot = "4")]
		public bool Equals(BodyShapeId EJECOGCICOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7194980", Offset = "0x7192F80", VA = "0x187194980", Slot = "5")]
		public int CompareTo(BodyShapeId EJECOGCICOM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7194B90", Offset = "0x7193190", VA = "0x187194B90", Slot = "0")]
		public override bool Equals(object IAMEECMGPIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7194AC0", Offset = "0x71930C0", VA = "0x187194AC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7194B00", Offset = "0x7193100", VA = "0x187194B00")]
		public static bool MOJFGPLDDKP(BodyShapeId CNCLMHODMJG, BodyShapeId ECNLMNDOGCG)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7194AD0", Offset = "0x71930D0", VA = "0x187194AD0")]
		public static bool LFBHPMALHHK(BodyShapeId CNCLMHODMJG, BodyShapeId ECNLMNDOGCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7194C90", Offset = "0x7193290", VA = "0x187194C90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class GIABIAONHOF
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class PFOPENBJMBA : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private (string, string) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private AssetIdMappingJsonData jsonData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public AssetIdMappingJsonData <>3__jsonData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <i>5__1;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private (string, string) System.Collections.Generic.IEnumerator<(System.String,System.String)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xA62E30", Offset = "0xA61430", VA = "0x180A62E30", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((string, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x7197FA0", Offset = "0x71965A0", VA = "0x187197FA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1D18530", Offset = "0x1D16B30", VA = "0x181D18530")]
		[DebuggerHidden]
		public PFOPENBJMBA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7197D70", Offset = "0x7196370", VA = "0x187197D70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7197F60", Offset = "0x7196560", VA = "0x187197F60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7197EC0", Offset = "0x71964C0", VA = "0x187197EC0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.String,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7197EC0", Offset = "0x71964C0", VA = "0x187197EC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1B7A380", Offset = "0x1B78980", VA = "0x181B7A380")]
	internal static IEnumerable<(TModern, string)> CLGJEDIKBGI<TModern>(string DFNBJPNEKDO, DJMDINACHOK<TModern> MPNABLHEMJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7195BC0", Offset = "0x71941C0", VA = "0x187195BC0")]
	[IteratorStateMachine(typeof(PFOPENBJMBA))]
	private static IEnumerable<(string, string)> PFDFHGDFEAP(AssetIdMappingJsonData NJOCBJMNAON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class HAFLHNLHNPL : IFPKPFBIMGB<AvatarItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1B5E860", Offset = "0x1B5CE60", VA = "0x181B5E860", Slot = "7")]
	protected override AvatarItemId JEPPANNLDKP(Guid IKGPBILBBIK)
	{
		return default(AvatarItemId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1B5E860", Offset = "0x1B5CE60", VA = "0x181B5E860", Slot = "8")]
	protected override Guid FNAJMACMDED(AvatarItemId ECPHLMGMGAK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x71961B0", Offset = "0x71947B0", VA = "0x1871961B0")]
	public HAFLHNLHNPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class GMMGCDDJIKN : HCJBIAPOPEF<CombinationId>, DJMDINACHOK<CombinationId>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class IKPAMMKFKMG : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private (string modernStr, string legacyStr) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private IEnumerable<(CombinationId, string)> values;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public IEnumerable<(CombinationId, string)> <>3__values;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public GMMGCDDJIKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private IEnumerator<(CombinationId, string)> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private CombinationId <modern>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private string <legacy>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private (string, string) System.Collections.Generic.IEnumerator<(System.StringmodernStr,System.StringlegacyStr)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA62E30", Offset = "0xA61430", VA = "0x180A62E30", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((string, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7197110", Offset = "0x7195710", VA = "0x187197110", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1D18530", Offset = "0x1D16B30", VA = "0x181D18530")]
		[DebuggerHidden]
		public IKPAMMKFKMG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7197160", Offset = "0x7195760", VA = "0x187197160", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7196D00", Offset = "0x7195300", VA = "0x187196D00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7196FD0", Offset = "0x71955D0", VA = "0x187196FD0")]
		private void PIAHDKPIMOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x71970D0", Offset = "0x71956D0", VA = "0x1871970D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7197020", Offset = "0x7195620", VA = "0x187197020", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.StringmodernStr,System.StringlegacyStr)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7197020", Offset = "0x7195620", VA = "0x187197020", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class IIIGCPKLPHB : IEnumerable<(CombinationId, string)>, IEnumerable, IEnumerator<(CombinationId, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private (CombinationId, string) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private IEnumerable<(string modernStr, string legacyStr)> jsonStrings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public IEnumerable<(string modernStr, string legacyStr)> <>3__jsonStrings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public GMMGCDDJIKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private IEnumerator<(string modernStr, string legacyStr)> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private (string modernStr, string legacyStr) <kvp>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private string <modernStr>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private string <legacyStr>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private CombinationId <modern>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private string <newModernStr>5__6;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private (CombinationId, string) System.Collections.Generic.IEnumerator<(RecRoom.AssetIds.CombinationId,System.String)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x3634880", Offset = "0x3632E80", VA = "0x183634880", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((CombinationId, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7196BD0", Offset = "0x71951D0", VA = "0x187196BD0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7196CD0", Offset = "0x71952D0", VA = "0x187196CD0")]
		[DebuggerHidden]
		public IIIGCPKLPHB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7196C40", Offset = "0x7195240", VA = "0x187196C40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x71963E0", Offset = "0x71949E0", VA = "0x1871963E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7196A80", Offset = "0x7195080", VA = "0x187196A80")]
		private void PIAHDKPIMOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7196B90", Offset = "0x7195190", VA = "0x187196B90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7196AE0", Offset = "0x71950E0", VA = "0x187196AE0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(CombinationId, string)> System.Collections.Generic.IEnumerable<(RecRoom.AssetIds.CombinationId,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7196AE0", Offset = "0x71950E0", VA = "0x187196AE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly HCJBIAPOPEF<MaterialId> PHBEKBPJIAA;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x959E30", Offset = "0x958430", VA = "0x180959E30")]
	public GMMGCDDJIKN(HCJBIAPOPEF<MaterialId> PHBEKBPJIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7195DD0", Offset = "0x71943D0", VA = "0x187195DD0", Slot = "4")]
	public CombinationId KNMLCGNKJNJ(string DABHFEKMMHB)
	{
		return default(CombinationId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7195CC0", Offset = "0x71942C0", VA = "0x187195CC0", Slot = "5")]
	[IteratorStateMachine(typeof(IKPAMMKFKMG))]
	public IEnumerable<(string, string)> BIMJOCMNJFF(IEnumerable<(CombinationId, string)> BCDJFNKOFCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7195C30", Offset = "0x7194230", VA = "0x187195C30", Slot = "6")]
	[IteratorStateMachine(typeof(IIIGCPKLPHB))]
	public IEnumerable<(CombinationId, string)> BHJLKGIODAK(IEnumerable<(string modernStr, string legacyStr)> MIEBFIJDADP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7195D50", Offset = "0x7194350", VA = "0x187195D50")]
	internal static string KBMEPEGGONC(string DABHFEKMMHB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class KLIFGLMDNOG : IFPKPFBIMGB<MaterialId>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1B5E860", Offset = "0x1B5CE60", VA = "0x181B5E860", Slot = "7")]
	protected override MaterialId JEPPANNLDKP(Guid IKGPBILBBIK)
	{
		return default(MaterialId);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1B5E860", Offset = "0x1B5CE60", VA = "0x181B5E860", Slot = "8")]
	protected override Guid FNAJMACMDED(MaterialId ECPHLMGMGAK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7197510", Offset = "0x7195B10", VA = "0x187197510")]
	public KLIFGLMDNOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface LHAFDNLGABL<TModern> : HCJBIAPOPEF<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string FOOLILJJOGP(TModern DABHFEKMMHB);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class CJPIDKHBLBC : IFPKPFBIMGB<ColorId>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1B5E860", Offset = "0x1B5CE60", VA = "0x181B5E860", Slot = "7")]
	protected override ColorId JEPPANNLDKP(Guid IKGPBILBBIK)
	{
		return default(ColorId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1B5E860", Offset = "0x1B5CE60", VA = "0x181B5E860", Slot = "8")]
	protected override Guid FNAJMACMDED(ColorId ECPHLMGMGAK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7194D40", Offset = "0x7193340", VA = "0x187194D40")]
	public CJPIDKHBLBC()
	{
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct HairPatternId : IEquatable<HairPatternId>, IComparable<HairPatternId>, HFBPDOKGMGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public static readonly HairPatternId Empty;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1B3F6A0", Offset = "0x1B3DCA0", VA = "0x181B3F6A0")]
		public HairPatternId(Guid IKGPBILBBIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7196290", Offset = "0x7194890", VA = "0x187196290")]
		public static HairPatternId FEKCLIBJICA()
		{
			return default(HairPatternId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA96690", Offset = "0xA94C90", VA = "0x180A96690", Slot = "6")]
		public Guid FNAJMACMDED()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x71949A0", Offset = "0x7192FA0", VA = "0x1871949A0", Slot = "4")]
		public bool Equals(HairPatternId EJECOGCICOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7194980", Offset = "0x7192F80", VA = "0x187194980", Slot = "5")]
		public int CompareTo(HairPatternId EJECOGCICOM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x71961F0", Offset = "0x71947F0", VA = "0x1871961F0", Slot = "0")]
		public override bool Equals(object IAMEECMGPIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7194AC0", Offset = "0x71930C0", VA = "0x187194AC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7194B00", Offset = "0x7193100", VA = "0x187194B00")]
		public static bool MOJFGPLDDKP(HairPatternId CNCLMHODMJG, HairPatternId ECNLMNDOGCG)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7194AD0", Offset = "0x71930D0", VA = "0x187194AD0")]
		public static bool LFBHPMALHHK(HairPatternId CNCLMHODMJG, HairPatternId ECNLMNDOGCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x71962F0", Offset = "0x71948F0", VA = "0x1871962F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class EPADKCJCIFL : IFPKPFBIMGB<HairPatternId>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1B5E860", Offset = "0x1B5CE60", VA = "0x181B5E860", Slot = "7")]
	protected override HairPatternId JEPPANNLDKP(Guid IKGPBILBBIK)
	{
		return default(HairPatternId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1B5E860", Offset = "0x1B5CE60", VA = "0x181B5E860", Slot = "8")]
	protected override Guid FNAJMACMDED(HairPatternId ECPHLMGMGAK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7195670", Offset = "0x7193C70", VA = "0x187195670")]
	public EPADKCJCIFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class KBOBAOGMDNN : LAJOEDEKEPC
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static KBOBAOGMDNN FBBAELKBDJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x71971F0", Offset = "0x71957F0", VA = "0x1871971F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public LHAFDNLGABL<AvatarItemId> IFFDJHMHPHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7197240", Offset = "0x7195840", VA = "0x187197240", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public LHAFDNLGABL<EquipmentSkinId> OHHPKLLMBMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7197380", Offset = "0x7195980", VA = "0x187197380", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public LHAFDNLGABL<HairPatternId> FEANCBCCNHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7197470", Offset = "0x7195A70", VA = "0x187197470", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public LHAFDNLGABL<MaterialId> DAPKDLADCOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x71974C0", Offset = "0x7195AC0", VA = "0x1871974C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public LHAFDNLGABL<CombinationId> GBHDFKDPEFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7197330", Offset = "0x7195930", VA = "0x187197330", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public LHAFDNLGABL<ColorId> DGFIKEEEOEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x71972E0", Offset = "0x71958E0", VA = "0x1871972E0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public LHAFDNLGABL<FaceShapeId> GFCPNDLPFDL
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7197420", Offset = "0x7195A20", VA = "0x187197420", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public LHAFDNLGABL<BodyShapeId> MIGABDOOFHB
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7197290", Offset = "0x7195890", VA = "0x187197290", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public LHAFDNLGABL<FaceFeatureId> IMCGIDAAFJG
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x71973D0", Offset = "0x71959D0", VA = "0x1871973D0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public KBOBAOGMDNN()
	{
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct FaceShapeId : IEquatable<FaceShapeId>, IComparable<FaceShapeId>, HFBPDOKGMGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public static readonly FaceShapeId Empty;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1B3F6A0", Offset = "0x1B3DCA0", VA = "0x181B3F6A0")]
		public FaceShapeId(Guid IKGPBILBBIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7195AB0", Offset = "0x71940B0", VA = "0x187195AB0")]
		public static FaceShapeId FEKCLIBJICA()
		{
			return default(FaceShapeId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA96690", Offset = "0xA94C90", VA = "0x180A96690", Slot = "6")]
		public Guid FNAJMACMDED()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x71949A0", Offset = "0x7192FA0", VA = "0x1871949A0", Slot = "4")]
		public bool Equals(FaceShapeId EJECOGCICOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7194980", Offset = "0x7192F80", VA = "0x187194980", Slot = "5")]
		public int CompareTo(FaceShapeId EJECOGCICOM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7195A10", Offset = "0x7194010", VA = "0x187195A10", Slot = "0")]
		public override bool Equals(object IAMEECMGPIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7194AC0", Offset = "0x71930C0", VA = "0x187194AC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7194B00", Offset = "0x7193100", VA = "0x187194B00")]
		public static bool MOJFGPLDDKP(FaceShapeId CNCLMHODMJG, FaceShapeId ECNLMNDOGCG)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7194AD0", Offset = "0x71930D0", VA = "0x187194AD0")]
		public static bool LFBHPMALHHK(FaceShapeId CNCLMHODMJG, FaceShapeId ECNLMNDOGCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7195B10", Offset = "0x7194110", VA = "0x187195B10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface HFBPDOKGMGM
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid FNAJMACMDED();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class AHBHBHPBMGM<TModern> : LHAFDNLGABL<TModern>, HCJBIAPOPEF<TModern> where TModern : IEquatable<TModern>, HFBPDOKGMGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly Dictionary<TModern, string> AFINGEDMNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly Dictionary<string, TModern> CPKPGEGEHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[CanBeNull]
	private readonly Func<string, string> HPKHBDAAIIH;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x28EFC70", Offset = "0x28EE270", VA = "0x1828EFC70")]
	public AHBHBHPBMGM(TextAsset HMKEEDFGDEA, DJMDINACHOK<TModern> MPNABLHEMJC, [CanBeNull] Func<string, string> HPKHBDAAIIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x28EE980", Offset = "0x28ECF80", VA = "0x1828EE980", Slot = "5")]
	public TModern KNMLCGNKJNJ(string DABHFEKMMHB)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x28ED8C0", Offset = "0x28EBEC0", VA = "0x1828ED8C0", Slot = "4")]
	public string FOOLILJJOGP(TModern NJIJAEJDIAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class KPIEJDMLGJH : IFPKPFBIMGB<FaceFeatureId>
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1B5E860", Offset = "0x1B5CE60", VA = "0x181B5E860", Slot = "7")]
	protected override FaceFeatureId JEPPANNLDKP(Guid IKGPBILBBIK)
	{
		return default(FaceFeatureId);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1B5E860", Offset = "0x1B5CE60", VA = "0x181B5E860", Slot = "8")]
	protected override Guid FNAJMACMDED(FaceFeatureId ECPHLMGMGAK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7197550", Offset = "0x7195B50", VA = "0x187197550")]
	public KPIEJDMLGJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface HCJBIAPOPEF<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern KNMLCGNKJNJ(string DABHFEKMMHB);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class IFPKPFBIMGB<TModern> : HCJBIAPOPEF<TModern>, DJMDINACHOK<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class LODDGGNGJCG : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (string modernStr, string legacyStr) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private IEnumerable<(TModern, string)> values;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public IEnumerable<(TModern, string)> <>3__values;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public IFPKPFBIMGB<TModern> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private IEnumerator<(TModern, string)> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TModern <modern>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private string <legacy>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private (string, string) System.Collections.Generic.IEnumerator<(System.StringmodernStr,System.StringlegacyStr)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xA62E30", Offset = "0xA61430", VA = "0x180A62E30", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((string, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x3D49050", Offset = "0x3D47650", VA = "0x183D49050", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1FF2460", Offset = "0x1FF0A60", VA = "0x181FF2460")]
		[DebuggerHidden]
		public LODDGGNGJCG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x12269B0", Offset = "0x1224FB0", VA = "0x1812269B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x3D487B0", Offset = "0x3D46DB0", VA = "0x183D487B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3D48AF0", Offset = "0x3D470F0", VA = "0x183D48AF0")]
		private void PIAHDKPIMOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3D48E70", Offset = "0x3D47470", VA = "0x183D48E70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x1FF20C0", Offset = "0x1FF06C0", VA = "0x181FF20C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.StringmodernStr,System.StringlegacyStr)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x1226940", Offset = "0x1224F40", VA = "0x181226940", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class IJGHCFNDKDN : IEnumerable<(TModern, string)>, IEnumerable, IEnumerator<(TModern, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private (TModern, string) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private IEnumerable<(string modernStr, string legacyStr)> jsonValues;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public IEnumerable<(string modernStr, string legacyStr)> <>3__jsonValues;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public IFPKPFBIMGB<TModern> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<(string modernStr, string legacyStr)> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private (string modernStr, string legacyStr) <kvp>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private string <modernStr>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private string <legacyStr>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TModern <modern>5__5;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private (TModern, string) System.Collections.Generic.IEnumerator<(TModern,System.String)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x1187EE0", Offset = "0x11864E0", VA = "0x181187EE0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TModern, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x1FF23C0", Offset = "0x1FF09C0", VA = "0x181FF23C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x1FF24A0", Offset = "0x1FF0AA0", VA = "0x181FF24A0")]
		[DebuggerHidden]
		public IJGHCFNDKDN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x12269B0", Offset = "0x1224FB0", VA = "0x1812269B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x1FF04D0", Offset = "0x1FEEAD0", VA = "0x181FF04D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x1FF1D30", Offset = "0x1FF0330", VA = "0x181FF1D30")]
		private void PIAHDKPIMOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x1FF22C0", Offset = "0x1FF08C0", VA = "0x181FF22C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x1FF2000", Offset = "0x1FF0600", VA = "0x181FF2000", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TModern, string)> System.Collections.Generic.IEnumerable<(TModern,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x1226940", Offset = "0x1224F40", VA = "0x181226940", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TModern JEPPANNLDKP(Guid IKGPBILBBIK);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Guid FNAJMACMDED(TModern ECPHLMGMGAK);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2187520", Offset = "0x2185B20", VA = "0x182187520", Slot = "4")]
	public TModern KNMLCGNKJNJ(string DABHFEKMMHB)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2187470", Offset = "0x2185A70", VA = "0x182187470", Slot = "5")]
	[IteratorStateMachine(typeof(IFPKPFBIMGB<>.LODDGGNGJCG))]
	public IEnumerable<(string, string)> BIMJOCMNJFF(IEnumerable<(TModern, string)> BCDJFNKOFCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2187310", Offset = "0x2185910", VA = "0x182187310", Slot = "6")]
	[IteratorStateMachine(typeof(IFPKPFBIMGB<>.IJGHCFNDKDN))]
	public IEnumerable<(TModern, string)> BHJLKGIODAK(IEnumerable<(string modernStr, string legacyStr)> AMMCPBNCKDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
	protected IFPKPFBIMGB()
	{
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public struct EquipmentSkinId : IEquatable<EquipmentSkinId>, IComparable<EquipmentSkinId>, HFBPDOKGMGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly EquipmentSkinId Empty;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x1B3F6A0", Offset = "0x1B3DCA0", VA = "0x181B3F6A0")]
		public EquipmentSkinId(Guid IKGPBILBBIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7195750", Offset = "0x7193D50", VA = "0x187195750")]
		public static EquipmentSkinId FEKCLIBJICA()
		{
			return default(EquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xA96690", Offset = "0xA94C90", VA = "0x180A96690", Slot = "6")]
		public Guid FNAJMACMDED()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x71949A0", Offset = "0x7192FA0", VA = "0x1871949A0", Slot = "4")]
		public bool Equals(EquipmentSkinId EJECOGCICOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x71956B0", Offset = "0x7193CB0", VA = "0x1871956B0", Slot = "0")]
		public override bool Equals(object IAMEECMGPIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7194980", Offset = "0x7192F80", VA = "0x187194980", Slot = "5")]
		public int CompareTo(EquipmentSkinId EJECOGCICOM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7194AC0", Offset = "0x71930C0", VA = "0x187194AC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7194B00", Offset = "0x7193100", VA = "0x187194B00")]
		public static bool MOJFGPLDDKP(EquipmentSkinId CNCLMHODMJG, EquipmentSkinId ECNLMNDOGCG)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7194AD0", Offset = "0x71930D0", VA = "0x187194AD0")]
		public static bool LFBHPMALHHK(EquipmentSkinId CNCLMHODMJG, EquipmentSkinId ECNLMNDOGCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x71957B0", Offset = "0x7193DB0", VA = "0x1871957B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class OMLMBDFMBOD : IFPKPFBIMGB<FaceShapeId>
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1B5E860", Offset = "0x1B5CE60", VA = "0x181B5E860", Slot = "7")]
	protected override FaceShapeId JEPPANNLDKP(Guid IKGPBILBBIK)
	{
		return default(FaceShapeId);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x1B5E860", Offset = "0x1B5CE60", VA = "0x181B5E860", Slot = "8")]
	protected override Guid FNAJMACMDED(FaceShapeId ECPHLMGMGAK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7197D30", Offset = "0x7196330", VA = "0x187197D30")]
	public OMLMBDFMBOD()
	{
	}
}
namespace RecRoom.AssetIds
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class RuntimeIdAssetMappers : ScriptableObject, LAJOEDEKEPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		private TextAsset avatarItemIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		private TextAsset combinationIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[SerializeField]
		private TextAsset equipmentSkinIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		private TextAsset hairPatternIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[SerializeField]
		private TextAsset materialIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[SerializeField]
		private TextAsset colorIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		private TextAsset faceShapeIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[SerializeField]
		private TextAsset bodyShapeIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[SerializeField]
		private TextAsset faceFeatureIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private AHBHBHPBMGM<AvatarItemId> avatarItemIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private AHBHBHPBMGM<EquipmentSkinId> equipmentSkinIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private AHBHBHPBMGM<HairPatternId> hairPatternIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private AHBHBHPBMGM<MaterialId> materialIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private AHBHBHPBMGM<CombinationId> combinationIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private AHBHBHPBMGM<ColorId> colorIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private AHBHBHPBMGM<FaceShapeId> faceShapeIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private AHBHBHPBMGM<BodyShapeId> bodyShapeIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private AHBHBHPBMGM<FaceFeatureId> faceFeatureIdLegacyMapper;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public LHAFDNLGABL<AvatarItemId> AvatarItemIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x9259E0", Offset = "0x923FE0", VA = "0x1809259E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public LHAFDNLGABL<EquipmentSkinId> EquipmentSkinIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x9259D0", Offset = "0x923FD0", VA = "0x1809259D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public LHAFDNLGABL<HairPatternId> HairPatternIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x940DB0", Offset = "0x93F3B0", VA = "0x180940DB0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public LHAFDNLGABL<MaterialId> MaterialIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x93F290", Offset = "0x93D890", VA = "0x18093F290", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public LHAFDNLGABL<CombinationId> CombinationIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x9A2700", Offset = "0x9A0D00", VA = "0x1809A2700", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public LHAFDNLGABL<ColorId> ColorIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x941250", Offset = "0x93F850", VA = "0x180941250", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public LHAFDNLGABL<FaceShapeId> FaceShapeIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xA503B0", Offset = "0xA4E9B0", VA = "0x180A503B0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public LHAFDNLGABL<BodyShapeId> BodyShapeIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xAE6900", Offset = "0xAE4F00", VA = "0x180AE6900", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public LHAFDNLGABL<FaceFeatureId> FaceFeatureIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xD9A0A0", Offset = "0xD986A0", VA = "0x180D9A0A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7198610", Offset = "0x7196C10", VA = "0x187198610")]
		[PJEDGFFEDPC(FLIHEPFCGKG.Root, PDIHHCLCNFI.GameOnly)]
		private static void PEMAGMCLMID(EIHIACACEHJ FBBMHADLAOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7197FF0", Offset = "0x71965F0", VA = "0x187197FF0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9A2FF0", Offset = "0x9A15F0", VA = "0x1809A2FF0")]
		public RuntimeIdAssetMappers()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public struct AvatarItemId : IEquatable<AvatarItemId>, IComparable<AvatarItemId>, HFBPDOKGMGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly AvatarItemId Empty;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1B3F6A0", Offset = "0x1B3DCA0", VA = "0x181B3F6A0")]
		public AvatarItemId(Guid IKGPBILBBIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x15C4190", Offset = "0x15C2790", VA = "0x1815C4190")]
		private AvatarItemId(ulong DJMLMEINCDA, ulong MGPLKBFEKIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7194A60", Offset = "0x7193060", VA = "0x187194A60")]
		public static AvatarItemId FEKCLIBJICA()
		{
			return default(AvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xA96690", Offset = "0xA94C90", VA = "0x180A96690", Slot = "6")]
		public Guid FNAJMACMDED()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x71949A0", Offset = "0x7192FA0", VA = "0x1871949A0", Slot = "4")]
		public bool Equals(AvatarItemId EJECOGCICOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7194980", Offset = "0x7192F80", VA = "0x187194980", Slot = "5")]
		public int CompareTo(AvatarItemId EJECOGCICOM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x71949C0", Offset = "0x7192FC0", VA = "0x1871949C0", Slot = "0")]
		public override bool Equals(object IAMEECMGPIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7194AC0", Offset = "0x71930C0", VA = "0x187194AC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7194B00", Offset = "0x7193100", VA = "0x187194B00")]
		public static bool MOJFGPLDDKP(AvatarItemId CNCLMHODMJG, AvatarItemId ECNLMNDOGCG)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7194AD0", Offset = "0x71930D0", VA = "0x187194AD0")]
		public static bool LFBHPMALHHK(AvatarItemId CNCLMHODMJG, AvatarItemId ECNLMNDOGCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7194B20", Offset = "0x7193120", VA = "0x187194B20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class LFFEFMJGAFB
{
	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7197590", Offset = "0x7195B90", VA = "0x187197590")]
	public static LAJOEDEKEPC MKJBLFOGICC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class EAFOPOBLKKC : IFPKPFBIMGB<BodyShapeId>
{
	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1B5E860", Offset = "0x1B5CE60", VA = "0x181B5E860", Slot = "7")]
	protected override BodyShapeId JEPPANNLDKP(Guid IKGPBILBBIK)
	{
		return default(BodyShapeId);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1B5E860", Offset = "0x1B5CE60", VA = "0x181B5E860", Slot = "8")]
	protected override Guid FNAJMACMDED(BodyShapeId ECPHLMGMGAK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7195630", Offset = "0x7193C30", VA = "0x187195630")]
	public EAFOPOBLKKC()
	{
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public struct MaterialId : IEquatable<MaterialId>, IComparable<MaterialId>, HFBPDOKGMGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public static readonly MaterialId Empty;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x1B3F6A0", Offset = "0x1B3DCA0", VA = "0x181B3F6A0")]
		public MaterialId(Guid IKGPBILBBIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7197770", Offset = "0x7195D70", VA = "0x187197770")]
		public static MaterialId FEKCLIBJICA()
		{
			return default(MaterialId);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA96690", Offset = "0xA94C90", VA = "0x180A96690", Slot = "6")]
		public Guid FNAJMACMDED()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x71976E0", Offset = "0x7195CE0", VA = "0x1871976E0", Slot = "4")]
		public bool Equals(MaterialId EJECOGCICOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x71975E0", Offset = "0x7195BE0", VA = "0x1871975E0", Slot = "0")]
		public override bool Equals(object IAMEECMGPIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7194AC0", Offset = "0x71930C0", VA = "0x187194AC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7197850", Offset = "0x7195E50", VA = "0x187197850")]
		public static bool MOJFGPLDDKP(MaterialId CNCLMHODMJG, MaterialId ECNLMNDOGCG)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x71977D0", Offset = "0x7195DD0", VA = "0x1871977D0")]
		public static bool LFBHPMALHHK(MaterialId CNCLMHODMJG, MaterialId ECNLMNDOGCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7194980", Offset = "0x7192F80", VA = "0x187194980", Slot = "5")]
		public int CompareTo(MaterialId EJECOGCICOM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x71978D0", Offset = "0x7195ED0", VA = "0x1871978D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class OAGPLJDEDBN
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7197A40", Offset = "0x7196040", VA = "0x187197A40")]
	public static byte[] IJCCKGHNBKN(string COCPECICNKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7197980", Offset = "0x7195F80", VA = "0x187197980")]
	public static Guid DGKFGBGNBBE(string EBEMFPIEMPD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7197B10", Offset = "0x7196110", VA = "0x187197B10")]
	public static bool KMNPOBEMLGJ(string EBEMFPIEMPD, out Guid IKGPBILBBIK)
	{
		return default(bool);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public struct FaceFeatureId : IEquatable<FaceFeatureId>, IComparable<FaceFeatureId>, HFBPDOKGMGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public static readonly FaceFeatureId Empty;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x1B3F6A0", Offset = "0x1B3DCA0", VA = "0x181B3F6A0")]
		public FaceFeatureId(Guid IKGPBILBBIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7195900", Offset = "0x7193F00", VA = "0x187195900")]
		public static FaceFeatureId FEKCLIBJICA()
		{
			return default(FaceFeatureId);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA96690", Offset = "0xA94C90", VA = "0x180A96690", Slot = "6")]
		public Guid FNAJMACMDED()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x71949A0", Offset = "0x7192FA0", VA = "0x1871949A0", Slot = "4")]
		public bool Equals(FaceFeatureId EJECOGCICOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7194980", Offset = "0x7192F80", VA = "0x187194980", Slot = "5")]
		public int CompareTo(FaceFeatureId EJECOGCICOM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7195860", Offset = "0x7193E60", VA = "0x187195860", Slot = "0")]
		public override bool Equals(object IAMEECMGPIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7194AC0", Offset = "0x71930C0", VA = "0x187194AC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7194B00", Offset = "0x7193100", VA = "0x187194B00")]
		public static bool MOJFGPLDDKP(FaceFeatureId CNCLMHODMJG, FaceFeatureId ECNLMNDOGCG)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7194AD0", Offset = "0x71930D0", VA = "0x187194AD0")]
		public static bool LFBHPMALHHK(FaceFeatureId CNCLMHODMJG, FaceFeatureId ECNLMNDOGCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7195960", Offset = "0x7193F60", VA = "0x187195960", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class IMLHFCPJGKL
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public IMLHFCPJGKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD111C0", VA = "0x180D12BC0")]
	public static string GOMDFOEHABF(byte[] CEBGDHINIFO, byte[] FGJCLMKLDKK)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
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
