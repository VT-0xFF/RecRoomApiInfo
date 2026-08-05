using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.AssetIds;
using RecRoom.NoEngine.Common;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class EHABGFJLBCA : CKHHHBABJJE
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex MMMBGLEMMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly DPPDOHIIFOI JKJBHKOGOOF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7132BA0", Offset = "0x7131FA0", VA = "0x187132BA0")]
	[PGKDFPMEDOJ(CDFBKAGHDGH.GameOnly)]
	private static void PIJPEIOOLKO(IFJJAPHPIAE LDNJCMFLLMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7132B40", Offset = "0x7131F40", VA = "0x187132B40")]
	[PGKDFPMEDOJ(CDFBKAGHDGH.EditorOnly)]
	private static void LHKOPJJKNFG(IFJJAPHPIAE LDNJCMFLLMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8C4170", Offset = "0x8C3570", VA = "0x1808C4170")]
	[Preserve]
	public EHABGFJLBCA([JLJFOFICIEA(null)] DPPDOHIIFOI JKJBHKOGOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7131EF0", Offset = "0x71312F0", VA = "0x187131EF0", Slot = "4")]
	public string CJMDONJKOCN(MONOMKJHJJP MNNPDPNIFNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x71323F0", Offset = "0x71317F0", VA = "0x1871323F0", Slot = "5")]
	public MONOMKJHJJP EFFJDOFDOEN(string MNNPDPNIFNM)
	{
		return default(MONOMKJHJJP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class OEAGKBIOFPH
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4C992F0", Offset = "0x4C986F0", VA = "0x184C992F0")]
	public static string MBHEEEHFMHD(this Guid DDJMKPCJBFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7133D50", Offset = "0x7133150", VA = "0x187133D50")]
	public static Guid AMGMHCBCNPH(string LIMEMBEDHNF)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GHLPEEJKFMB<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> HDOJCKACOJJ(IEnumerable<(string modernStr, string legacyStr)> LCFLDDEMLCE);
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, HGMCICIEMNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB335E0", Offset = "0xB329E0", VA = "0x180B335E0", Slot = "6")]
		public Guid IAGJHJMHOHE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x71344F0", Offset = "0x71338F0", VA = "0x1871344F0")]
		public ACOEOELODDL EFFJDOFDOEN()
		{
			return default(ACOEOELODDL);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x71345C0", Offset = "0x71339C0", VA = "0x1871345C0", Slot = "4")]
		public bool Equals(SerializedColorId ICELKIGIKKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x71344D0", Offset = "0x71338D0", VA = "0x1871344D0", Slot = "5")]
		public int CompareTo(SerializedColorId ICELKIGIKKP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7134770", Offset = "0x7133B70", VA = "0x187134770", Slot = "0")]
		public override bool Equals(object HFAGBIOODHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x71345E0", Offset = "0x71339E0", VA = "0x1871345E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7134810", Offset = "0x7133C10", VA = "0x187134810", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal class AssetIdMappingJsonData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public string comment;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public SortedDictionary<string, string> modernToLegacy;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7131440", Offset = "0x7130840", VA = "0x187131440")]
		public AssetIdMappingJsonData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, HGMCICIEMNE, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private SerializedMaterialId materialId1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		private SerializedMaterialId materialId2;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x71348A0", Offset = "0x7133CA0", VA = "0x1871348A0")]
		public MFHLJNIJHGK EFFJDOFDOEN()
		{
			return default(MFHLJNIJHGK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xB335E0", Offset = "0xB329E0", VA = "0x180B335E0", Slot = "6")]
		public Guid IAGJHJMHOHE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7134D80", Offset = "0x7134180", VA = "0x187134D80")]
		public SerializedCombinationId(MFHLJNIJHGK ACJGILILFID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7134980", Offset = "0x7133D80", VA = "0x187134980")]
		private void EODKPKCHBED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7134C50", Offset = "0x7134050", VA = "0x187134C50", Slot = "4")]
		public bool Equals(SerializedCombinationId ICELKIGIKKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7134B30", Offset = "0x7133F30", VA = "0x187134B30", Slot = "0")]
		public override bool Equals(object HFAGBIOODHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7134CF0", Offset = "0x71340F0", VA = "0x187134CF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7134880", Offset = "0x7133C80", VA = "0x187134880", Slot = "5")]
		public int CompareTo(SerializedCombinationId ICELKIGIKKP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7134D10", Offset = "0x7134110", VA = "0x187134D10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7134D00", Offset = "0x7134100", VA = "0x187134D00", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class EFBMFIBLHCP : LIPOJDPDPAB<IOLGKLJDGAC>
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x9D35E0", Offset = "0x9D29E0", VA = "0x1809D35E0", Slot = "6")]
	protected override IOLGKLJDGAC CEGGHKBKJJA(Guid DDJMKPCJBFO)
	{
		return default(IOLGKLJDGAC);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7131EB0", Offset = "0x71312B0", VA = "0x187131EB0")]
	public EFBMFIBLHCP()
	{
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, HGMCICIEMNE
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

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x71344F0", Offset = "0x71338F0", VA = "0x1871344F0")]
		public KNCOKELJIKJ EFFJDOFDOEN()
		{
			return default(KNCOKELJIKJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xB335E0", Offset = "0xB329E0", VA = "0x180B335E0", Slot = "6")]
		public Guid IAGJHJMHOHE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x71345C0", Offset = "0x71339C0", VA = "0x1871345C0", Slot = "4")]
		public bool Equals(SerializedBodyShapeId ICELKIGIKKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x71344D0", Offset = "0x71338D0", VA = "0x1871344D0", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId ICELKIGIKKP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7134660", Offset = "0x7133A60", VA = "0x187134660", Slot = "0")]
		public override bool Equals(object HFAGBIOODHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x71345E0", Offset = "0x71339E0", VA = "0x1871345E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7134700", Offset = "0x7133B00", VA = "0x187134700", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class ACLKFEEHIIN
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class BKKIINJAJNJ : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private (string, string) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private AssetIdMappingJsonData jsonData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AssetIdMappingJsonData <>3__jsonData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private SortedDictionary<string, string>.Enumerator <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private KeyValuePair<string, string> <kvp>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private (string, string) System.Collections.Generic.IEnumerator<(System.String,System.String)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x9D48A0", Offset = "0x9D3CA0", VA = "0x1809D48A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((string, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7131870", Offset = "0x7130C70", VA = "0x187131870", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x259A8D0", Offset = "0x2599CD0", VA = "0x18259A8D0")]
		[DebuggerHidden]
		public BKKIINJAJNJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x71318C0", Offset = "0x7130CC0", VA = "0x1871318C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7131520", Offset = "0x7130920", VA = "0x187131520", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7131740", Offset = "0x7130B40", VA = "0x187131740")]
		private void PPOPDODPNIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7131830", Offset = "0x7130C30", VA = "0x187131830", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7131790", Offset = "0x7130B90", VA = "0x187131790", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.String,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7131790", Offset = "0x7130B90", VA = "0x187131790", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x15DBDE0", Offset = "0x15DB1E0", VA = "0x1815DBDE0")]
	internal static IEnumerable<(TModern, string)> AKLANFGPBKF<TModern>(string KLPJDKJFHOF, GHLPEEJKFMB<TModern> HJGANFHENKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7131380", Offset = "0x7130780", VA = "0x187131380")]
	[IteratorStateMachine(typeof(BKKIINJAJNJ))]
	private static IEnumerable<(string, string)> JDPAMFAKKLB(AssetIdMappingJsonData JBCKPGHBBLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class LINAFMINFDD : LIPOJDPDPAB<OKKHNOAMHFC>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x9D35E0", Offset = "0x9D29E0", VA = "0x1809D35E0", Slot = "6")]
	protected override OKKHNOAMHFC CEGGHKBKJJA(Guid DDJMKPCJBFO)
	{
		return default(OKKHNOAMHFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7133C80", Offset = "0x7133080", VA = "0x187133C80")]
	internal static string AOHGADCJLEC(string BHGFJPAPEEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7133D10", Offset = "0x7133110", VA = "0x187133D10")]
	public LINAFMINFDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class EDMLKALAJOL : ONENMDKLBPO<MFHLJNIJHGK>, GHLPEEJKFMB<MFHLJNIJHGK>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class KNEBEPCAKDC : IEnumerable<(MFHLJNIJHGK, string)>, IEnumerable, IEnumerator<(MFHLJNIJHGK, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private (MFHLJNIJHGK, string) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private IEnumerable<(string modernStr, string legacyStr)> jsonStrings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public IEnumerable<(string modernStr, string legacyStr)> <>3__jsonStrings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public EDMLKALAJOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private IEnumerator<(string modernStr, string legacyStr)> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private (string modernStr, string legacyStr) <kvp>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private string <modernStr>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private string <legacyStr>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private MFHLJNIJHGK <modern>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private string <newModernStr>5__6;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private (MFHLJNIJHGK, string) System.Collections.Generic.IEnumerator<(RecRoom.AssetIds.CombinationId,System.String)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x22BCF30", Offset = "0x22BC330", VA = "0x1822BCF30", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((MFHLJNIJHGK, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7133B50", Offset = "0x7132F50", VA = "0x187133B50", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7133C10", Offset = "0x7133010", VA = "0x187133C10")]
		[DebuggerHidden]
		public KNEBEPCAKDC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7133BC0", Offset = "0x7132FC0", VA = "0x187133BC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7133240", Offset = "0x7132640", VA = "0x187133240", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x71339A0", Offset = "0x7132DA0", VA = "0x1871339A0")]
		private void PPOPDODPNIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7133B10", Offset = "0x7132F10", VA = "0x187133B10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7133A60", Offset = "0x7132E60", VA = "0x187133A60", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(MFHLJNIJHGK, string)> System.Collections.Generic.IEnumerable<(RecRoom.AssetIds.CombinationId,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7133A60", Offset = "0x7132E60", VA = "0x187133A60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly ONENMDKLBPO<OBMCHBDHDDC> APBGOHGAMCI;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8C4170", Offset = "0x8C3570", VA = "0x1808C4170")]
	public EDMLKALAJOL(ONENMDKLBPO<OBMCHBDHDDC> APBGOHGAMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x71319D0", Offset = "0x7130DD0", VA = "0x1871319D0", Slot = "4")]
	public MFHLJNIJHGK AAINPGDFHNI(string BHGFJPAPEEC)
	{
		return default(MFHLJNIJHGK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7131E20", Offset = "0x7131220", VA = "0x187131E20", Slot = "5")]
	[IteratorStateMachine(typeof(KNEBEPCAKDC))]
	public IEnumerable<(MFHLJNIJHGK, string)> HDOJCKACOJJ(IEnumerable<(string modernStr, string legacyStr)> LCFLDDEMLCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7131DE0", Offset = "0x71311E0", VA = "0x187131DE0")]
	internal static string AOHGADCJLEC(string BHGFJPAPEEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class KPJPLDGDFFE : LIPOJDPDPAB<OBMCHBDHDDC>
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x9D35E0", Offset = "0x9D29E0", VA = "0x1809D35E0", Slot = "6")]
	protected override OBMCHBDHDDC CEGGHKBKJJA(Guid DDJMKPCJBFO)
	{
		return default(OBMCHBDHDDC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7133C40", Offset = "0x7133040", VA = "0x187133C40")]
	public KPJPLDGDFFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class EHEJMFJJGDF : LIPOJDPDPAB<ACOEOELODDL>
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x9D35E0", Offset = "0x9D29E0", VA = "0x1809D35E0", Slot = "6")]
	protected override ACOEOELODDL CEGGHKBKJJA(Guid DDJMKPCJBFO)
	{
		return default(ACOEOELODDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7132D10", Offset = "0x7132110", VA = "0x187132D10")]
	public EHEJMFJJGDF()
	{
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, HGMCICIEMNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x20CE640", Offset = "0x20CDA40", VA = "0x1820CE640")]
		public SerializedHairPatternId(MHPMGBKNHIJ JNHCLKAAKHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xB335E0", Offset = "0xB329E0", VA = "0x180B335E0", Slot = "6")]
		public Guid IAGJHJMHOHE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x71344F0", Offset = "0x71338F0", VA = "0x1871344F0")]
		public MHPMGBKNHIJ EFFJDOFDOEN()
		{
			return default(MHPMGBKNHIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x71345C0", Offset = "0x71339C0", VA = "0x1871345C0", Slot = "4")]
		public bool Equals(SerializedHairPatternId ICELKIGIKKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x71344D0", Offset = "0x71338D0", VA = "0x1871344D0", Slot = "5")]
		public int CompareTo(SerializedHairPatternId ICELKIGIKKP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7135140", Offset = "0x7134540", VA = "0x187135140", Slot = "0")]
		public override bool Equals(object HFAGBIOODHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x71345E0", Offset = "0x71339E0", VA = "0x1871345E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x71351E0", Offset = "0x71345E0", VA = "0x1871351E0")]
		public static bool PHJEMBLBEDF(SerializedHairPatternId FINJCDHFPJB, SerializedHairPatternId JHJGODIMNAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7135200", Offset = "0x7134600", VA = "0x187135200", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class COIDFIJIAIH : LIPOJDPDPAB<MHPMGBKNHIJ>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x9D35E0", Offset = "0x9D29E0", VA = "0x1809D35E0", Slot = "6")]
	protected override MHPMGBKNHIJ CEGGHKBKJJA(Guid DDJMKPCJBFO)
	{
		return default(MHPMGBKNHIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7131950", Offset = "0x7130D50", VA = "0x187131950")]
	public COIDFIJIAIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class EKOKDGBLCPM : DPPDOHIIFOI
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static EKOKDGBLCPM FNGGPKJOCFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7132D50", Offset = "0x7132150", VA = "0x187132D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public LMHHEANJMDP<OKKHNOAMHFC> HGMPOBFDPAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7132DA0", Offset = "0x71321A0", VA = "0x187132DA0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public LMHHEANJMDP<IOLGKLJDGAC> CAOBECMEAIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7132EE0", Offset = "0x71322E0", VA = "0x187132EE0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public LMHHEANJMDP<MHPMGBKNHIJ> HNNNHKLJGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7132FD0", Offset = "0x71323D0", VA = "0x187132FD0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public LMHHEANJMDP<MFHLJNIJHGK> JHCNPOEDGNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7132E90", Offset = "0x7132290", VA = "0x187132E90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public LMHHEANJMDP<ACOEOELODDL> LCFFANMKIPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7132E40", Offset = "0x7132240", VA = "0x187132E40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public LMHHEANJMDP<IGCMNGAJHEF> NEJDPMDCPOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7132F80", Offset = "0x7132380", VA = "0x187132F80", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public LMHHEANJMDP<KNCOKELJIKJ> LJGMGALIDAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7132DF0", Offset = "0x71321F0", VA = "0x187132DF0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public LMHHEANJMDP<DNFDFLJPDAL> COHANJADLPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7132F30", Offset = "0x7132330", VA = "0x187132F30", Slot = "11")]
		get
		{
			return null;
		}
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, HGMCICIEMNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xB335E0", Offset = "0xB329E0", VA = "0x180B335E0", Slot = "6")]
		public Guid IAGJHJMHOHE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x71344F0", Offset = "0x71338F0", VA = "0x1871344F0")]
		public IGCMNGAJHEF EFFJDOFDOEN()
		{
			return default(IGCMNGAJHEF);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x71345C0", Offset = "0x71339C0", VA = "0x1871345C0", Slot = "4")]
		public bool Equals(SerializedFaceShapeId ICELKIGIKKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x71344D0", Offset = "0x71338D0", VA = "0x1871344D0", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId ICELKIGIKKP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7135030", Offset = "0x7134430", VA = "0x187135030", Slot = "0")]
		public override bool Equals(object HFAGBIOODHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x71345E0", Offset = "0x71339E0", VA = "0x1871345E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x71350D0", Offset = "0x71344D0", VA = "0x1871350D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class PMDGDPMENOO<TModern> : LMHHEANJMDP<TModern>, ONENMDKLBPO<TModern> where TModern : IEquatable<TModern>, HGMCICIEMNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<TModern, string> FPJLKJOBJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly Dictionary<string, TModern> JGBCNKKCCLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[CanBeNull]
	private readonly Func<string, string> PHGOJCMFAEI;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3D0E020", Offset = "0x3D0D420", VA = "0x183D0E020")]
	public PMDGDPMENOO(TextAsset MLPDCMPOEHP, GHLPEEJKFMB<TModern> HJGANFHENKI, [CanBeNull] Func<string, string> PHGOJCMFAEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3D0A5F0", Offset = "0x3D099F0", VA = "0x183D0A5F0", Slot = "5")]
	public TModern AAINPGDFHNI(string BHGFJPAPEEC)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3D0C870", Offset = "0x3D0BC70", VA = "0x183D0C870", Slot = "4")]
	public string EIHHBLBAHCO(TModern FHEIOEKMPCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class PJJNHPBOMGD : LIPOJDPDPAB<DNFDFLJPDAL>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x9D35E0", Offset = "0x9D29E0", VA = "0x1809D35E0", Slot = "6")]
	protected override DNFDFLJPDAL CEGGHKBKJJA(Guid DDJMKPCJBFO)
	{
		return default(DNFDFLJPDAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7133DC0", Offset = "0x71331C0", VA = "0x187133DC0")]
	public PJJNHPBOMGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class LIPOJDPDPAB<TModern> : ONENMDKLBPO<TModern>, GHLPEEJKFMB<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class CHOPEGAHBPM : IEnumerable<(TModern, string)>, IEnumerable, IEnumerator<(TModern, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private (TModern, string) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private IEnumerable<(string modernStr, string legacyStr)> jsonValues;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public IEnumerable<(string modernStr, string legacyStr)> <>3__jsonValues;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public LIPOJDPDPAB<TModern> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private IEnumerator<(string modernStr, string legacyStr)> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private (string modernStr, string legacyStr) <kvp>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private string <modernStr>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private string <legacyStr>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private TModern <modern>5__5;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private (TModern, string) System.Collections.Generic.IEnumerator<(TModern,System.String)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x1122D70", Offset = "0x1122170", VA = "0x181122D70", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TModern, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x30A9C90", Offset = "0x30A9090", VA = "0x1830A9C90", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x30A9CE0", Offset = "0x30A90E0", VA = "0x1830A9CE0")]
		[DebuggerHidden]
		public CHOPEGAHBPM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x22FB570", Offset = "0x22FA970", VA = "0x1822FB570", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x30A8FD0", Offset = "0x30A83D0", VA = "0x1830A8FD0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x30A9950", Offset = "0x30A8D50", VA = "0x1830A9950")]
		private void PPOPDODPNIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x30A9BD0", Offset = "0x30A8FD0", VA = "0x1830A9BD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x30A9A90", Offset = "0x30A8E90", VA = "0x1830A9A90", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TModern, string)> System.Collections.Generic.IEnumerable<(TModern,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x1FFFBD0", Offset = "0x1FFEFD0", VA = "0x181FFFBD0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TModern CEGGHKBKJJA(Guid DDJMKPCJBFO);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2BC0860", Offset = "0x2BBFC60", VA = "0x182BC0860", Slot = "4")]
	public TModern AAINPGDFHNI(string BHGFJPAPEEC)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2BC0920", Offset = "0x2BBFD20", VA = "0x182BC0920", Slot = "5")]
	[IteratorStateMachine(typeof(LIPOJDPDPAB<>.CHOPEGAHBPM))]
	public IEnumerable<(TModern, string)> HDOJCKACOJJ(IEnumerable<(string modernStr, string legacyStr)> DGKGELBNCMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
	protected LIPOJDPDPAB()
	{
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, HGMCICIEMNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7134DA0", Offset = "0x71341A0", VA = "0x187134DA0")]
		public static SerializedEquipmentSkinId DPDDFJBBKBL()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xB335E0", Offset = "0xB329E0", VA = "0x180B335E0", Slot = "6")]
		public Guid IAGJHJMHOHE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x71344F0", Offset = "0x71338F0", VA = "0x1871344F0")]
		public IOLGKLJDGAC EFFJDOFDOEN()
		{
			return default(IOLGKLJDGAC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x71345C0", Offset = "0x71339C0", VA = "0x1871345C0", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId ICELKIGIKKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7134E10", Offset = "0x7134210", VA = "0x187134E10", Slot = "0")]
		public override bool Equals(object HFAGBIOODHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x71344D0", Offset = "0x71338D0", VA = "0x1871344D0", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId ICELKIGIKKP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x71345E0", Offset = "0x71339E0", VA = "0x1871345E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7134EB0", Offset = "0x71342B0", VA = "0x187134EB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class EAELFPMKGHB : LIPOJDPDPAB<IGCMNGAJHEF>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x9D35E0", Offset = "0x9D29E0", VA = "0x1809D35E0", Slot = "6")]
	protected override IGCMNGAJHEF CEGGHKBKJJA(Guid DDJMKPCJBFO)
	{
		return default(IGCMNGAJHEF);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7131990", Offset = "0x7130D90", VA = "0x187131990")]
	public EAELFPMKGHB()
	{
	}
}
namespace RecRoom.AssetIds
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class RuntimeIdAssetMappers : ScriptableObject, DPPDOHIIFOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private TextAsset avatarItemIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private TextAsset combinationIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private TextAsset equipmentSkinIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private TextAsset hairPatternIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		private TextAsset materialIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		private TextAsset colorIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		private TextAsset faceShapeIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		private TextAsset bodyShapeIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[SerializeField]
		private TextAsset faceFeatureIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private PMDGDPMENOO<OKKHNOAMHFC> avatarItemIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private PMDGDPMENOO<IOLGKLJDGAC> equipmentSkinIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private PMDGDPMENOO<MHPMGBKNHIJ> hairPatternIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private PMDGDPMENOO<OBMCHBDHDDC> materialIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private PMDGDPMENOO<MFHLJNIJHGK> combinationIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private PMDGDPMENOO<ACOEOELODDL> colorIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private PMDGDPMENOO<IGCMNGAJHEF> faceShapeIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private PMDGDPMENOO<KNCOKELJIKJ> bodyShapeIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private PMDGDPMENOO<DNFDFLJPDAL> faceFeatureIdLegacyMapper;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public LMHHEANJMDP<OKKHNOAMHFC> AvatarItemIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x8CBFE0", Offset = "0x8CB3E0", VA = "0x1808CBFE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public LMHHEANJMDP<IOLGKLJDGAC> EquipmentSkinIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x99C4F0", Offset = "0x99B8F0", VA = "0x18099C4F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public LMHHEANJMDP<MHPMGBKNHIJ> HairPatternIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x9B7D80", Offset = "0x9B7180", VA = "0x1809B7D80", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public LMHHEANJMDP<OBMCHBDHDDC> MaterialIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x8F8D80", Offset = "0x8F8180", VA = "0x1808F8D80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public LMHHEANJMDP<MFHLJNIJHGK> CombinationIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x8F8470", Offset = "0x8F7870", VA = "0x1808F8470", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public LMHHEANJMDP<ACOEOELODDL> ColorIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x9B8210", Offset = "0x9B7610", VA = "0x1809B8210", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public LMHHEANJMDP<IGCMNGAJHEF> FaceShapeIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x8CA060", Offset = "0x8C9460", VA = "0x1808CA060", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public LMHHEANJMDP<KNCOKELJIKJ> BodyShapeIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x8BE5D0", Offset = "0x8BD9D0", VA = "0x1808BE5D0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public LMHHEANJMDP<DNFDFLJPDAL> FaceFeatureIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xAFBF00", Offset = "0xAFB300", VA = "0x180AFBF00", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7133E00", Offset = "0x7133200", VA = "0x187133E00")]
		[PGKDFPMEDOJ(OCCBJMOEDKI.Root, CDFBKAGHDGH.GameOnly)]
		private static void BAPPIPJDFJJ(IFJJAPHPIAE LDNJCMFLLMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7133E80", Offset = "0x7133280", VA = "0x187133E80")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x9840D0", Offset = "0x9834D0", VA = "0x1809840D0")]
		public RuntimeIdAssetMappers()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, HGMCICIEMNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x20CE640", Offset = "0x20CDA40", VA = "0x1820CE640")]
		public SerializedAvatarItemId(OKKHNOAMHFC JNHCLKAAKHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x71344F0", Offset = "0x71338F0", VA = "0x1871344F0")]
		public OKKHNOAMHFC EFFJDOFDOEN()
		{
			return default(OKKHNOAMHFC);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xB335E0", Offset = "0xB329E0", VA = "0x180B335E0", Slot = "6")]
		public Guid IAGJHJMHOHE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x71345C0", Offset = "0x71339C0", VA = "0x1871345C0", Slot = "4")]
		public bool Equals(SerializedAvatarItemId ICELKIGIKKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x71344D0", Offset = "0x71338D0", VA = "0x1871344D0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId ICELKIGIKKP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7134520", Offset = "0x7133920", VA = "0x187134520", Slot = "0")]
		public override bool Equals(object HFAGBIOODHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x71345E0", Offset = "0x71339E0", VA = "0x1871345E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x71345F0", Offset = "0x71339F0", VA = "0x1871345F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class AELABHGMMHK
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x71313F0", Offset = "0x71307F0", VA = "0x1871313F0")]
	public static DPPDOHIIFOI NNCLCJMODJD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class BIONLGFKGBJ : LIPOJDPDPAB<KNCOKELJIKJ>
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x9D35E0", Offset = "0x9D29E0", VA = "0x1809D35E0", Slot = "6")]
	protected override KNCOKELJIKJ CEGGHKBKJJA(Guid DDJMKPCJBFO)
	{
		return default(KNCOKELJIKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x71314E0", Offset = "0x71308E0", VA = "0x1871314E0")]
	public BIONLGFKGBJ()
	{
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, HGMCICIEMNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x20CE640", Offset = "0x20CDA40", VA = "0x1820CE640")]
		public SerializedMaterialId(OBMCHBDHDDC JNHCLKAAKHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xB335E0", Offset = "0xB329E0", VA = "0x180B335E0", Slot = "6")]
		public Guid IAGJHJMHOHE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x71344F0", Offset = "0x71338F0", VA = "0x1871344F0")]
		public OBMCHBDHDDC EFFJDOFDOEN()
		{
			return default(OBMCHBDHDDC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7135270", Offset = "0x7134670", VA = "0x187135270", Slot = "4")]
		public bool Equals(SerializedMaterialId ICELKIGIKKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7135300", Offset = "0x7134700", VA = "0x187135300", Slot = "0")]
		public override bool Equals(object HFAGBIOODHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x71345E0", Offset = "0x71339E0", VA = "0x1871345E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7135400", Offset = "0x7134800", VA = "0x187135400")]
		public static bool PHJEMBLBEDF(SerializedMaterialId FINJCDHFPJB, SerializedMaterialId JHJGODIMNAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x71344D0", Offset = "0x71338D0", VA = "0x1871344D0", Slot = "5")]
		public int CompareTo(SerializedMaterialId ICELKIGIKKP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7135480", Offset = "0x7134880", VA = "0x187135480", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class GKOJANHNIIE
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7133020", Offset = "0x7132420", VA = "0x187133020")]
	public static Guid HKAIEMMIDGH(string CMAENNBMJLG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x71330E0", Offset = "0x71324E0", VA = "0x1871330E0")]
	public static bool OFEKALDECCH(string CMAENNBMJLG, out Guid DDJMKPCJBFO)
	{
		return default(bool);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, HGMCICIEMNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xB335E0", Offset = "0xB329E0", VA = "0x180B335E0", Slot = "6")]
		public Guid IAGJHJMHOHE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x71344F0", Offset = "0x71338F0", VA = "0x1871344F0")]
		public DNFDFLJPDAL EFFJDOFDOEN()
		{
			return default(DNFDFLJPDAL);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x71345C0", Offset = "0x71339C0", VA = "0x1871345C0", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId ICELKIGIKKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x71344D0", Offset = "0x71338D0", VA = "0x1871344D0", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId ICELKIGIKKP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7134F20", Offset = "0x7134320", VA = "0x187134F20", Slot = "0")]
		public override bool Equals(object HFAGBIOODHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x71345E0", Offset = "0x71339E0", VA = "0x1871345E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7134FC0", Offset = "0x71343C0", VA = "0x187134FC0", Slot = "3")]
		public override string ToString()
		{
			return null;
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
