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
internal static class IJCNEEAACAH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4C91970", Offset = "0x4C90970", VA = "0x184C91970")]
	public static string LBMHDEKLGFO(this Guid PLBICILNGEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7232560", Offset = "0x7231560", VA = "0x187232560")]
	public static Guid PDOFDJIAHCK(string GNNDFANJALC)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DONEPAMJCMM<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(string, string)> GKDALICFCLM(IEnumerable<(TModern, string)> LGIIOJHKOLK);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(TModern, string)> CNJEMJENOIP(IEnumerable<(string modernStr, string legacyStr)> FBDPCNEAJBL);
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct ColorId : IEquatable<ColorId>, IComparable<ColorId>, IJCDFLNEKAN
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
		[Cpp2IlInjected.Address(RVA = "0xBE2EF0", Offset = "0xBE1EF0", VA = "0x180BE2EF0")]
		public ColorId(Guid PLBICILNGEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7230E80", Offset = "0x722FE80", VA = "0x187230E80")]
		public static ColorId IBLCNEOLNEJ()
		{
			return default(ColorId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xE5A200", Offset = "0xE59200", VA = "0x180E5A200", Slot = "6")]
		public Guid BDHFECMMELA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7230330", Offset = "0x722F330", VA = "0x187230330", Slot = "4")]
		public bool Equals(ColorId BKLMLPFOMCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7230310", Offset = "0x722F310", VA = "0x187230310", Slot = "5")]
		public int CompareTo(ColorId BKLMLPFOMCO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7230DE0", Offset = "0x722FDE0", VA = "0x187230DE0", Slot = "0")]
		public override bool Equals(object EOHGDDIECBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x72303F0", Offset = "0x722F3F0", VA = "0x1872303F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7230490", Offset = "0x722F490", VA = "0x187230490")]
		public static bool LFCPNLBCIDE(ColorId EEDCFNGAAFO, ColorId OFBPOJFNNIJ)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7230460", Offset = "0x722F460", VA = "0x187230460")]
		public static bool JIPCNIGMDBL(ColorId EEDCFNGAAFO, ColorId OFBPOJFNNIJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7230EE0", Offset = "0x722FEE0", VA = "0x187230EE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JFCKONNFPCK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	ODEADEADGFN<AvatarItemId> AJPCBPJLAAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ODEADEADGFN<EquipmentSkinId> HOKMKMMNLFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	ODEADEADGFN<HairPatternId> HFNMEPKHIFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	ODEADEADGFN<MaterialId> IJBICINDCDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	ODEADEADGFN<CombinationId> HDHFHFEACKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	ODEADEADGFN<ColorId> PDCCHJFPMJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	ODEADEADGFN<FaceShapeId> INKMOCKICFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	ODEADEADGFN<BodyShapeId> LMOHLIPHBOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	ODEADEADGFN<FaceFeatureId> MJDAPMIPKAH
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
		[Cpp2IlInjected.Address(RVA = "0x7230260", Offset = "0x722F260", VA = "0x187230260")]
		public AssetIdMappingJsonData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct CombinationId : IEquatable<CombinationId>, IComparable<CombinationId>, IJCDFLNEKAN, ISerializationCallbackReceiver
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
			[Cpp2IlInjected.Address(RVA = "0xA76DE0", Offset = "0xA75DE0", VA = "0x180A76DE0")]
			get
			{
				return default(MaterialId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public MaterialId MaterialId1
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xA76DF0", Offset = "0xA75DF0", VA = "0x180A76DF0")]
			get
			{
				return default(MaterialId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public MaterialId MaterialId2
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xBB9100", Offset = "0xBB8100", VA = "0x180BB9100")]
			get
			{
				return default(MaterialId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xE5A200", Offset = "0xE59200", VA = "0x180E5A200", Slot = "6")]
		public Guid BDHFECMMELA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7231150", Offset = "0x7230150", VA = "0x187231150")]
		public static CombinationId INCFLNBEGID(out MaterialId KHFMHNNILJD)
		{
			return default(CombinationId);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x72315E0", Offset = "0x72305E0", VA = "0x1872315E0")]
		public CombinationId(Guid PLBICILNGEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7231600", Offset = "0x7230600", VA = "0x187231600")]
		public CombinationId(MaterialId KELECPAHAHG, MaterialId MFLBFAIIMAF, MaterialId NCMKDAJGNLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x72312F0", Offset = "0x72302F0", VA = "0x1872312F0")]
		private void MDHJCNENLFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x72310B0", Offset = "0x72300B0", VA = "0x1872310B0", Slot = "4")]
		public bool Equals(CombinationId BKLMLPFOMCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7230FB0", Offset = "0x722FFB0", VA = "0x187230FB0", Slot = "0")]
		public override bool Equals(object EOHGDDIECBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7231140", Offset = "0x7230140", VA = "0x187231140", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x72310B0", Offset = "0x72300B0", VA = "0x1872310B0")]
		public static bool LFCPNLBCIDE(CombinationId EEDCFNGAAFO, CombinationId OFBPOJFNNIJ)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7231260", Offset = "0x7230260", VA = "0x187231260")]
		public static bool JIPCNIGMDBL(CombinationId EEDCFNGAAFO, CombinationId OFBPOJFNNIJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7230F90", Offset = "0x722FF90", VA = "0x187230F90", Slot = "5")]
		public int CompareTo(CombinationId BKLMLPFOMCO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7231520", Offset = "0x7230520", VA = "0x187231520", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7231510", Offset = "0x7230510", VA = "0x187231510", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class FBIMPEKKFCC : NPOFOAFMFML<EquipmentSkinId>
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1B61D50", Offset = "0x1B60D50", VA = "0x181B61D50", Slot = "7")]
	protected override EquipmentSkinId DJEBMOIBCPA(Guid PLBICILNGEB)
	{
		return default(EquipmentSkinId);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1B61D50", Offset = "0x1B60D50", VA = "0x181B61D50", Slot = "8")]
	protected override Guid BDHFECMMELA(EquipmentSkinId EPALKCEDECI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7231810", Offset = "0x7230810", VA = "0x187231810")]
	public FBIMPEKKFCC()
	{
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct BodyShapeId : IEquatable<BodyShapeId>, IComparable<BodyShapeId>, IJCDFLNEKAN
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
		[Cpp2IlInjected.Address(RVA = "0xBE2EF0", Offset = "0xBE1EF0", VA = "0x180BE2EF0")]
		public BodyShapeId(Guid PLBICILNGEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7230600", Offset = "0x722F600", VA = "0x187230600")]
		public static BodyShapeId IBLCNEOLNEJ()
		{
			return default(BodyShapeId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xE5A200", Offset = "0xE59200", VA = "0x180E5A200", Slot = "6")]
		public Guid BDHFECMMELA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7230330", Offset = "0x722F330", VA = "0x187230330", Slot = "4")]
		public bool Equals(BodyShapeId BKLMLPFOMCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7230310", Offset = "0x722F310", VA = "0x187230310", Slot = "5")]
		public int CompareTo(BodyShapeId BKLMLPFOMCO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7230560", Offset = "0x722F560", VA = "0x187230560", Slot = "0")]
		public override bool Equals(object EOHGDDIECBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x72303F0", Offset = "0x722F3F0", VA = "0x1872303F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7230490", Offset = "0x722F490", VA = "0x187230490")]
		public static bool LFCPNLBCIDE(BodyShapeId EEDCFNGAAFO, BodyShapeId OFBPOJFNNIJ)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7230460", Offset = "0x722F460", VA = "0x187230460")]
		public static bool JIPCNIGMDBL(BodyShapeId EEDCFNGAAFO, BodyShapeId OFBPOJFNNIJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7230660", Offset = "0x722F660", VA = "0x187230660", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class KFDMJNIOFIO
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class GAABFFHBNPD : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0xBF8100", Offset = "0xBF7100", VA = "0x180BF8100", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x72322D0", Offset = "0x72312D0", VA = "0x1872322D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x259CF00", Offset = "0x259BF00", VA = "0x18259CF00")]
		[DebuggerHidden]
		public GAABFFHBNPD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x72320A0", Offset = "0x72310A0", VA = "0x1872320A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7232290", Offset = "0x7231290", VA = "0x187232290", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x72321F0", Offset = "0x72311F0", VA = "0x1872321F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.String,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x72321F0", Offset = "0x72311F0", VA = "0x1872321F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x21230B0", Offset = "0x21220B0", VA = "0x1821230B0")]
	internal static IEnumerable<(TModern, string)> PBGNAFNJLHE<TModern>(string GBCIDHANPLJ, DONEPAMJCMM<TModern> IMBDLENCEPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7232B50", Offset = "0x7231B50", VA = "0x187232B50")]
	[IteratorStateMachine(typeof(GAABFFHBNPD))]
	private static IEnumerable<(string, string)> ONNHLOMJLGP(AssetIdMappingJsonData KDIGNABKNMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class GELIDDOENHB : NPOFOAFMFML<AvatarItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1B61D50", Offset = "0x1B60D50", VA = "0x181B61D50", Slot = "7")]
	protected override AvatarItemId DJEBMOIBCPA(Guid PLBICILNGEB)
	{
		return default(AvatarItemId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1B61D50", Offset = "0x1B60D50", VA = "0x181B61D50", Slot = "8")]
	protected override Guid BDHFECMMELA(AvatarItemId EPALKCEDECI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7232320", Offset = "0x7231320", VA = "0x187232320")]
	public GELIDDOENHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class JPMBABPKHIP : FGICNBPFIIK<CombinationId>, DONEPAMJCMM<CombinationId>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class FMFIFMONKIC : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
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
		public JPMBABPKHIP <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xBF8100", Offset = "0xBF7100", VA = "0x180BF8100", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7231C60", Offset = "0x7230C60", VA = "0x187231C60", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x259CF00", Offset = "0x259BF00", VA = "0x18259CF00")]
		[DebuggerHidden]
		public FMFIFMONKIC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7231CB0", Offset = "0x7230CB0", VA = "0x187231CB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x72318A0", Offset = "0x72308A0", VA = "0x1872318A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7231850", Offset = "0x7230850", VA = "0x187231850")]
		private void MHEJAKKMIEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7231C20", Offset = "0x7230C20", VA = "0x187231C20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7231B70", Offset = "0x7230B70", VA = "0x187231B70", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.StringmodernStr,System.StringlegacyStr)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7231B70", Offset = "0x7230B70", VA = "0x187231B70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class AGMICDBJLMK : IEnumerable<(CombinationId, string)>, IEnumerable, IEnumerator<(CombinationId, string)>, IEnumerator, IDisposable
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
		public JPMBABPKHIP <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x36CF5E0", Offset = "0x36CE5E0", VA = "0x1836CF5E0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7230130", Offset = "0x722F130", VA = "0x187230130", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7230230", Offset = "0x722F230", VA = "0x187230230")]
		[DebuggerHidden]
		public AGMICDBJLMK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x72301A0", Offset = "0x722F1A0", VA = "0x1872301A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x722F9A0", Offset = "0x722E9A0", VA = "0x18722F9A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x722F940", Offset = "0x722E940", VA = "0x18722F940")]
		private void MHEJAKKMIEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x72300F0", Offset = "0x722F0F0", VA = "0x1872300F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7230040", Offset = "0x722F040", VA = "0x187230040", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(CombinationId, string)> System.Collections.Generic.IEnumerable<(RecRoom.AssetIds.CombinationId,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7230040", Offset = "0x722F040", VA = "0x187230040", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly FGICNBPFIIK<MaterialId> JEBLPCABMCK;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x919D70", Offset = "0x918D70", VA = "0x180919D70")]
	public JPMBABPKHIP(FGICNBPFIIK<MaterialId> JEBLPCABMCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7232660", Offset = "0x7231660", VA = "0x187232660", Slot = "4")]
	public CombinationId GILFDBGBFFG(string MCGNFLMKEMA)
	{
		return default(CombinationId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7232A40", Offset = "0x7231A40", VA = "0x187232A40", Slot = "5")]
	[IteratorStateMachine(typeof(FMFIFMONKIC))]
	public IEnumerable<(string, string)> GKDALICFCLM(IEnumerable<(CombinationId, string)> LGIIOJHKOLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x72325D0", Offset = "0x72315D0", VA = "0x1872325D0", Slot = "6")]
	[IteratorStateMachine(typeof(AGMICDBJLMK))]
	public IEnumerable<(CombinationId, string)> CNJEMJENOIP(IEnumerable<(string modernStr, string legacyStr)> FBDPCNEAJBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7232AD0", Offset = "0x7231AD0", VA = "0x187232AD0")]
	internal static string HKGPAJKMLOL(string MCGNFLMKEMA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class BIABFHAACAO : NPOFOAFMFML<MaterialId>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1B61D50", Offset = "0x1B60D50", VA = "0x181B61D50", Slot = "7")]
	protected override MaterialId DJEBMOIBCPA(Guid PLBICILNGEB)
	{
		return default(MaterialId);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1B61D50", Offset = "0x1B60D50", VA = "0x181B61D50", Slot = "8")]
	protected override Guid BDHFECMMELA(MaterialId EPALKCEDECI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7230520", Offset = "0x722F520", VA = "0x187230520")]
	public BIABFHAACAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface ODEADEADGFN<TModern> : FGICNBPFIIK<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string IDILDECEHDF(TModern MCGNFLMKEMA);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class DPKDDDOGELO : NPOFOAFMFML<ColorId>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1B61D50", Offset = "0x1B60D50", VA = "0x181B61D50", Slot = "7")]
	protected override ColorId DJEBMOIBCPA(Guid PLBICILNGEB)
	{
		return default(ColorId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1B61D50", Offset = "0x1B60D50", VA = "0x181B61D50", Slot = "8")]
	protected override Guid BDHFECMMELA(ColorId EPALKCEDECI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7231620", Offset = "0x7230620", VA = "0x187231620")]
	public DPKDDDOGELO()
	{
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct HairPatternId : IEquatable<HairPatternId>, IComparable<HairPatternId>, IJCDFLNEKAN
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
		[Cpp2IlInjected.Address(RVA = "0xBE2EF0", Offset = "0xBE1EF0", VA = "0x180BE2EF0")]
		public HairPatternId(Guid PLBICILNGEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7232450", Offset = "0x7231450", VA = "0x187232450")]
		public static HairPatternId IBLCNEOLNEJ()
		{
			return default(HairPatternId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xE5A200", Offset = "0xE59200", VA = "0x180E5A200", Slot = "6")]
		public Guid BDHFECMMELA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7230330", Offset = "0x722F330", VA = "0x187230330", Slot = "4")]
		public bool Equals(HairPatternId BKLMLPFOMCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7230310", Offset = "0x722F310", VA = "0x187230310", Slot = "5")]
		public int CompareTo(HairPatternId BKLMLPFOMCO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x72323B0", Offset = "0x72313B0", VA = "0x1872323B0", Slot = "0")]
		public override bool Equals(object EOHGDDIECBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x72303F0", Offset = "0x722F3F0", VA = "0x1872303F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7230490", Offset = "0x722F490", VA = "0x187230490")]
		public static bool LFCPNLBCIDE(HairPatternId EEDCFNGAAFO, HairPatternId OFBPOJFNNIJ)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7230460", Offset = "0x722F460", VA = "0x187230460")]
		public static bool JIPCNIGMDBL(HairPatternId EEDCFNGAAFO, HairPatternId OFBPOJFNNIJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x72324B0", Offset = "0x72314B0", VA = "0x1872324B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class AAEGFOGEAKC : NPOFOAFMFML<HairPatternId>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1B61D50", Offset = "0x1B60D50", VA = "0x181B61D50", Slot = "7")]
	protected override HairPatternId DJEBMOIBCPA(Guid PLBICILNGEB)
	{
		return default(HairPatternId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1B61D50", Offset = "0x1B60D50", VA = "0x181B61D50", Slot = "8")]
	protected override Guid BDHFECMMELA(HairPatternId EPALKCEDECI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x722F900", Offset = "0x722E900", VA = "0x18722F900")]
	public AAEGFOGEAKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class CJOECEHFPOM : JFCKONNFPCK
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CJOECEHFPOM HIEJPGCOIBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7230AC0", Offset = "0x722FAC0", VA = "0x187230AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ODEADEADGFN<AvatarItemId> AJPCBPJLAAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7230B10", Offset = "0x722FB10", VA = "0x187230B10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public ODEADEADGFN<EquipmentSkinId> HOKMKMMNLFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7230C50", Offset = "0x722FC50", VA = "0x187230C50", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public ODEADEADGFN<HairPatternId> HFNMEPKHIFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7230D40", Offset = "0x722FD40", VA = "0x187230D40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ODEADEADGFN<MaterialId> IJBICINDCDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7230D90", Offset = "0x722FD90", VA = "0x187230D90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ODEADEADGFN<CombinationId> HDHFHFEACKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7230C00", Offset = "0x722FC00", VA = "0x187230C00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ODEADEADGFN<ColorId> PDCCHJFPMJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7230BB0", Offset = "0x722FBB0", VA = "0x187230BB0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ODEADEADGFN<FaceShapeId> INKMOCKICFD
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7230CF0", Offset = "0x722FCF0", VA = "0x187230CF0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ODEADEADGFN<BodyShapeId> LMOHLIPHBOG
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7230B60", Offset = "0x722FB60", VA = "0x187230B60", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public ODEADEADGFN<FaceFeatureId> MJDAPMIPKAH
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7230CA0", Offset = "0x722FCA0", VA = "0x187230CA0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public CJOECEHFPOM()
	{
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct FaceShapeId : IEquatable<FaceShapeId>, IComparable<FaceShapeId>, IJCDFLNEKAN
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
		[Cpp2IlInjected.Address(RVA = "0xBE2EF0", Offset = "0xBE1EF0", VA = "0x180BE2EF0")]
		public FaceShapeId(Guid PLBICILNGEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7231F90", Offset = "0x7230F90", VA = "0x187231F90")]
		public static FaceShapeId IBLCNEOLNEJ()
		{
			return default(FaceShapeId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xE5A200", Offset = "0xE59200", VA = "0x180E5A200", Slot = "6")]
		public Guid BDHFECMMELA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7230330", Offset = "0x722F330", VA = "0x187230330", Slot = "4")]
		public bool Equals(FaceShapeId BKLMLPFOMCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7230310", Offset = "0x722F310", VA = "0x187230310", Slot = "5")]
		public int CompareTo(FaceShapeId BKLMLPFOMCO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7231EF0", Offset = "0x7230EF0", VA = "0x187231EF0", Slot = "0")]
		public override bool Equals(object EOHGDDIECBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x72303F0", Offset = "0x722F3F0", VA = "0x1872303F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7230490", Offset = "0x722F490", VA = "0x187230490")]
		public static bool LFCPNLBCIDE(FaceShapeId EEDCFNGAAFO, FaceShapeId OFBPOJFNNIJ)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7230460", Offset = "0x722F460", VA = "0x187230460")]
		public static bool JIPCNIGMDBL(FaceShapeId EEDCFNGAAFO, FaceShapeId OFBPOJFNNIJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7231FF0", Offset = "0x7230FF0", VA = "0x187231FF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface IJCDFLNEKAN
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid BDHFECMMELA();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class OGJNGAGICAH<TModern> : ODEADEADGFN<TModern>, FGICNBPFIIK<TModern> where TModern : IEquatable<TModern>, IJCDFLNEKAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly Dictionary<TModern, string> CAHPDPFAEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly Dictionary<string, TModern> PGMJEBAFNGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[CanBeNull]
	private readonly Func<string, string> CJILICBLIPJ;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2FD82A0", Offset = "0x2FD72A0", VA = "0x182FD82A0")]
	public OGJNGAGICAH(TextAsset NNDBLELMEMD, DONEPAMJCMM<TModern> IMBDLENCEPP, [CanBeNull] Func<string, string> CJILICBLIPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2FD5500", Offset = "0x2FD4500", VA = "0x182FD5500", Slot = "5")]
	public TModern GILFDBGBFFG(string MCGNFLMKEMA)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2FD7380", Offset = "0x2FD6380", VA = "0x182FD7380", Slot = "4")]
	public string IDILDECEHDF(TModern NBBGGKEJOCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class MBCCOCONEDL : NPOFOAFMFML<FaceFeatureId>
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1B61D50", Offset = "0x1B60D50", VA = "0x181B61D50", Slot = "7")]
	protected override FaceFeatureId DJEBMOIBCPA(Guid PLBICILNGEB)
	{
		return default(FaceFeatureId);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1B61D50", Offset = "0x1B60D50", VA = "0x181B61D50", Slot = "8")]
	protected override Guid BDHFECMMELA(FaceFeatureId EPALKCEDECI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7232C00", Offset = "0x7231C00", VA = "0x187232C00")]
	public MBCCOCONEDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface FGICNBPFIIK<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern GILFDBGBFFG(string MCGNFLMKEMA);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class NPOFOAFMFML<TModern> : FGICNBPFIIK<TModern>, DONEPAMJCMM<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class LMHPPCPOANP : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
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
		public NPOFOAFMFML<TModern> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xBF8100", Offset = "0xBF7100", VA = "0x180BF8100", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x250BE40", Offset = "0x250AE40", VA = "0x18250BE40", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x24485E0", Offset = "0x24475E0", VA = "0x1824485E0")]
		[DebuggerHidden]
		public LMHPPCPOANP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2062880", Offset = "0x2061880", VA = "0x182062880", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x250A720", Offset = "0x2509720", VA = "0x18250A720", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2509C80", Offset = "0x2508C80", VA = "0x182509C80")]
		private void MHEJAKKMIEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x250BB40", Offset = "0x250AB40", VA = "0x18250BB40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x250B8C0", Offset = "0x250A8C0", VA = "0x18250B8C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.StringmodernStr,System.StringlegacyStr)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xC40680", Offset = "0xC3F680", VA = "0x180C40680", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class KHDJHMGCLEA : IEnumerable<(TModern, string)>, IEnumerable, IEnumerator<(TModern, string)>, IEnumerator, IDisposable
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
		public NPOFOAFMFML<TModern> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x125E2A0", Offset = "0x125D2A0", VA = "0x18125E2A0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x35456D0", Offset = "0x35446D0", VA = "0x1835456D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x3275E50", Offset = "0x3274E50", VA = "0x183275E50")]
		[DebuggerHidden]
		public KHDJHMGCLEA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x2062880", Offset = "0x2061880", VA = "0x182062880", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x3543E60", Offset = "0x3542E60", VA = "0x183543E60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x3543720", Offset = "0x3542720", VA = "0x183543720")]
		private void MHEJAKKMIEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3545550", Offset = "0x3544550", VA = "0x183545550", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x35453D0", Offset = "0x35443D0", VA = "0x1835453D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TModern, string)> System.Collections.Generic.IEnumerable<(TModern,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xC40680", Offset = "0xC3F680", VA = "0x180C40680", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TModern DJEBMOIBCPA(Guid PLBICILNGEB);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Guid BDHFECMMELA(TModern EPALKCEDECI);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2A7ABE0", Offset = "0x2A79BE0", VA = "0x182A7ABE0", Slot = "4")]
	public TModern GILFDBGBFFG(string MCGNFLMKEMA)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2A7ACA0", Offset = "0x2A79CA0", VA = "0x182A7ACA0", Slot = "5")]
	[IteratorStateMachine(typeof(NPOFOAFMFML<>.LMHPPCPOANP))]
	public IEnumerable<(string, string)> GKDALICFCLM(IEnumerable<(TModern, string)> LGIIOJHKOLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2A7AA80", Offset = "0x2A79A80", VA = "0x182A7AA80", Slot = "6")]
	[IteratorStateMachine(typeof(NPOFOAFMFML<>.KHDJHMGCLEA))]
	public IEnumerable<(TModern, string)> CNJEMJENOIP(IEnumerable<(string modernStr, string legacyStr)> MFOGFOAMFFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
	protected NPOFOAFMFML()
	{
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public struct EquipmentSkinId : IEquatable<EquipmentSkinId>, IComparable<EquipmentSkinId>, IJCDFLNEKAN
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
		[Cpp2IlInjected.Address(RVA = "0xBE2EF0", Offset = "0xBE1EF0", VA = "0x180BE2EF0")]
		public EquipmentSkinId(Guid PLBICILNGEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7231700", Offset = "0x7230700", VA = "0x187231700")]
		public static EquipmentSkinId IBLCNEOLNEJ()
		{
			return default(EquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xE5A200", Offset = "0xE59200", VA = "0x180E5A200", Slot = "6")]
		public Guid BDHFECMMELA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7230330", Offset = "0x722F330", VA = "0x187230330", Slot = "4")]
		public bool Equals(EquipmentSkinId BKLMLPFOMCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7231660", Offset = "0x7230660", VA = "0x187231660", Slot = "0")]
		public override bool Equals(object EOHGDDIECBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7230310", Offset = "0x722F310", VA = "0x187230310", Slot = "5")]
		public int CompareTo(EquipmentSkinId BKLMLPFOMCO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x72303F0", Offset = "0x722F3F0", VA = "0x1872303F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7230490", Offset = "0x722F490", VA = "0x187230490")]
		public static bool LFCPNLBCIDE(EquipmentSkinId EEDCFNGAAFO, EquipmentSkinId OFBPOJFNNIJ)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7230460", Offset = "0x722F460", VA = "0x187230460")]
		public static bool JIPCNIGMDBL(EquipmentSkinId EEDCFNGAAFO, EquipmentSkinId OFBPOJFNNIJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7231760", Offset = "0x7230760", VA = "0x187231760", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class LAJFACHBIJD : NPOFOAFMFML<FaceShapeId>
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1B61D50", Offset = "0x1B60D50", VA = "0x181B61D50", Slot = "7")]
	protected override FaceShapeId DJEBMOIBCPA(Guid PLBICILNGEB)
	{
		return default(FaceShapeId);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x1B61D50", Offset = "0x1B60D50", VA = "0x181B61D50", Slot = "8")]
	protected override Guid BDHFECMMELA(FaceShapeId EPALKCEDECI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7232BC0", Offset = "0x7231BC0", VA = "0x187232BC0")]
	public LAJFACHBIJD()
	{
	}
}
namespace RecRoom.AssetIds
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class RuntimeIdAssetMappers : ScriptableObject, JFCKONNFPCK
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
		private OGJNGAGICAH<AvatarItemId> avatarItemIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private OGJNGAGICAH<EquipmentSkinId> equipmentSkinIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private OGJNGAGICAH<HairPatternId> hairPatternIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private OGJNGAGICAH<MaterialId> materialIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private OGJNGAGICAH<CombinationId> combinationIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private OGJNGAGICAH<ColorId> colorIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private OGJNGAGICAH<FaceShapeId> faceShapeIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private OGJNGAGICAH<BodyShapeId> bodyShapeIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private OGJNGAGICAH<FaceFeatureId> faceFeatureIdLegacyMapper;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public ODEADEADGFN<AvatarItemId> AvatarItemIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x97E5B0", Offset = "0x97D5B0", VA = "0x18097E5B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public ODEADEADGFN<EquipmentSkinId> EquipmentSkinIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x992280", Offset = "0x991280", VA = "0x180992280", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public ODEADEADGFN<HairPatternId> HairPatternIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x9AD4B0", Offset = "0x9AC4B0", VA = "0x1809AD4B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public ODEADEADGFN<MaterialId> MaterialIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x9AB9D0", Offset = "0x9AA9D0", VA = "0x1809AB9D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public ODEADEADGFN<CombinationId> CombinationIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x9B3910", Offset = "0x9B2910", VA = "0x1809B3910", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public ODEADEADGFN<ColorId> ColorIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x9AD920", Offset = "0x9AC920", VA = "0x1809AD920", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public ODEADEADGFN<FaceShapeId> FaceShapeIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xAAC140", Offset = "0xAAB140", VA = "0x180AAC140", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public ODEADEADGFN<BodyShapeId> BodyShapeIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x90F2C0", Offset = "0x90E2C0", VA = "0x18090F2C0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public ODEADEADGFN<FaceFeatureId> FaceFeatureIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xAA24A0", Offset = "0xAA14A0", VA = "0x180AA24A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7233020", Offset = "0x7232020", VA = "0x187233020")]
		[FBCFLFBFGIL(MELNECENNOL.Root, LAFFCBAHJKM.GameOnly)]
		private static void BGLPJMCJCBB(CNALHHIKJDD HDIGDGEFOCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x72330A0", Offset = "0x72320A0", VA = "0x1872330A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xA756E0", Offset = "0xA746E0", VA = "0x180A756E0")]
		public RuntimeIdAssetMappers()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public struct AvatarItemId : IEquatable<AvatarItemId>, IComparable<AvatarItemId>, IJCDFLNEKAN
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
		[Cpp2IlInjected.Address(RVA = "0xBE2EF0", Offset = "0xBE1EF0", VA = "0x180BE2EF0")]
		public AvatarItemId(Guid PLBICILNGEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x12EB3B0", Offset = "0x12EA3B0", VA = "0x1812EB3B0")]
		private AvatarItemId(ulong FNELFBEHHOP, ulong HLDOJAGGPLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7230400", Offset = "0x722F400", VA = "0x187230400")]
		public static AvatarItemId IBLCNEOLNEJ()
		{
			return default(AvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xE5A200", Offset = "0xE59200", VA = "0x180E5A200", Slot = "6")]
		public Guid BDHFECMMELA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7230330", Offset = "0x722F330", VA = "0x187230330", Slot = "4")]
		public bool Equals(AvatarItemId BKLMLPFOMCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7230310", Offset = "0x722F310", VA = "0x187230310", Slot = "5")]
		public int CompareTo(AvatarItemId BKLMLPFOMCO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7230350", Offset = "0x722F350", VA = "0x187230350", Slot = "0")]
		public override bool Equals(object EOHGDDIECBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x72303F0", Offset = "0x722F3F0", VA = "0x1872303F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7230490", Offset = "0x722F490", VA = "0x187230490")]
		public static bool LFCPNLBCIDE(AvatarItemId EEDCFNGAAFO, AvatarItemId OFBPOJFNNIJ)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7230460", Offset = "0x722F460", VA = "0x187230460")]
		public static bool JIPCNIGMDBL(AvatarItemId EEDCFNGAAFO, AvatarItemId OFBPOJFNNIJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x72304B0", Offset = "0x722F4B0", VA = "0x1872304B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class HJCEBFBKMJK
{
	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7232360", Offset = "0x7231360", VA = "0x187232360")]
	public static JFCKONNFPCK LCBAOFPNNFB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class PPJGGADBBKJ : NPOFOAFMFML<BodyShapeId>
{
	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1B61D50", Offset = "0x1B60D50", VA = "0x181B61D50", Slot = "7")]
	protected override BodyShapeId DJEBMOIBCPA(Guid PLBICILNGEB)
	{
		return default(BodyShapeId);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1B61D50", Offset = "0x1B60D50", VA = "0x181B61D50", Slot = "8")]
	protected override Guid BDHFECMMELA(BodyShapeId EPALKCEDECI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7232FE0", Offset = "0x7231FE0", VA = "0x187232FE0")]
	public PPJGGADBBKJ()
	{
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public struct MaterialId : IEquatable<MaterialId>, IComparable<MaterialId>, IJCDFLNEKAN
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
		[Cpp2IlInjected.Address(RVA = "0xBE2EF0", Offset = "0xBE1EF0", VA = "0x180BE2EF0")]
		public MaterialId(Guid PLBICILNGEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7232DD0", Offset = "0x7231DD0", VA = "0x187232DD0")]
		public static MaterialId IBLCNEOLNEJ()
		{
			return default(MaterialId);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xE5A200", Offset = "0xE59200", VA = "0x180E5A200", Slot = "6")]
		public Guid BDHFECMMELA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7232D40", Offset = "0x7231D40", VA = "0x187232D40", Slot = "4")]
		public bool Equals(MaterialId BKLMLPFOMCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7232C40", Offset = "0x7231C40", VA = "0x187232C40", Slot = "0")]
		public override bool Equals(object EOHGDDIECBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x72303F0", Offset = "0x722F3F0", VA = "0x1872303F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7232EB0", Offset = "0x7231EB0", VA = "0x187232EB0")]
		public static bool LFCPNLBCIDE(MaterialId EEDCFNGAAFO, MaterialId OFBPOJFNNIJ)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7232E30", Offset = "0x7231E30", VA = "0x187232E30")]
		public static bool JIPCNIGMDBL(MaterialId EEDCFNGAAFO, MaterialId OFBPOJFNNIJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7230310", Offset = "0x722F310", VA = "0x187230310", Slot = "5")]
		public int CompareTo(MaterialId BKLMLPFOMCO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7232F30", Offset = "0x7231F30", VA = "0x187232F30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class CDJDLLHAOND
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7230710", Offset = "0x722F710", VA = "0x187230710")]
	public static byte[] AHFNNBDEJLI(string BPNBFOFLPKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x72307E0", Offset = "0x722F7E0", VA = "0x1872307E0")]
	public static Guid DGPJOOLPOGE(string LLIDCNBPOOF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x72308A0", Offset = "0x722F8A0", VA = "0x1872308A0")]
	public static bool OFEAINHIBOO(string LLIDCNBPOOF, out Guid PLBICILNGEB)
	{
		return default(bool);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public struct FaceFeatureId : IEquatable<FaceFeatureId>, IComparable<FaceFeatureId>, IJCDFLNEKAN
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
		[Cpp2IlInjected.Address(RVA = "0xBE2EF0", Offset = "0xBE1EF0", VA = "0x180BE2EF0")]
		public FaceFeatureId(Guid PLBICILNGEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7231DE0", Offset = "0x7230DE0", VA = "0x187231DE0")]
		public static FaceFeatureId IBLCNEOLNEJ()
		{
			return default(FaceFeatureId);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xE5A200", Offset = "0xE59200", VA = "0x180E5A200", Slot = "6")]
		public Guid BDHFECMMELA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7230330", Offset = "0x722F330", VA = "0x187230330", Slot = "4")]
		public bool Equals(FaceFeatureId BKLMLPFOMCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7230310", Offset = "0x722F310", VA = "0x187230310", Slot = "5")]
		public int CompareTo(FaceFeatureId BKLMLPFOMCO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7231D40", Offset = "0x7230D40", VA = "0x187231D40", Slot = "0")]
		public override bool Equals(object EOHGDDIECBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x72303F0", Offset = "0x722F3F0", VA = "0x1872303F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7230490", Offset = "0x722F490", VA = "0x187230490")]
		public static bool LFCPNLBCIDE(FaceFeatureId EEDCFNGAAFO, FaceFeatureId OFBPOJFNNIJ)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7230460", Offset = "0x722F460", VA = "0x187230460")]
		public static bool JIPCNIGMDBL(FaceFeatureId EEDCFNGAAFO, FaceFeatureId OFBPOJFNNIJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7231E40", Offset = "0x7230E40", VA = "0x187231E40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class MHGFMJKAFPI
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public MHGFMJKAFPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0xBB9C20", Offset = "0xBB8C20", VA = "0x180BB9C20")]
	public static string KILOLNAHAFI(byte[] BKIADALNNFJ, byte[] EEICCMPLMOJ)
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
