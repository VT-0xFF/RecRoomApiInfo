using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Mono.Math;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class JNDKPJAPMML : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x598B30", Offset = "0x597130", VA = "0x180598B30")]
	public JNDKPJAPMML()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[FFEJGKFIEJH]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[FFEJGKFIEJH]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x4A4C4A0", Offset = "0x4A4AAA0", VA = "0x184A4C4A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4A4C460", Offset = "0x4A4AA60", VA = "0x184A4C460")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4A4C4E0", Offset = "0x4A4AAE0", VA = "0x184A4C4E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4A4C6F0", Offset = "0x4A4ACF0", VA = "0x184A4C6F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4A4C660", Offset = "0x4A4AC60", VA = "0x184A4C660")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x750B30", Offset = "0x74F130", VA = "0x180750B30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x74F850", Offset = "0x74DE50", VA = "0x18074F850")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4A4C420", Offset = "0x4A4AA20", VA = "0x184A4C420")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4A4C5D0", Offset = "0x4A4ABD0", VA = "0x184A4C5D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4A4BE50", Offset = "0x4A4A450", VA = "0x184A4BE50")]
	public void CopyBounds(SavedExtents DBPHKEMCPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4A4C390", Offset = "0x4A4A990", VA = "0x184A4C390")]
	public void SetLocalSpaceBounds(Bounds KJJIIHDDIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x71AAA0", Offset = "0x7190A0", VA = "0x18071AAA0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4A4C380", Offset = "0x4A4A980", VA = "0x184A4C380")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4A4BF40", Offset = "0x4A4A540", VA = "0x184A4BF40")]
	private void IMJEOLKPEHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4A4C150", Offset = "0x4A4A750", VA = "0x184A4C150")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4A4B890", Offset = "0x4A49E90", VA = "0x184A4B890")]
	public static void CalculateLocalBoundsFor(GameObject POBIIKOLKCO, out Bounds KJJIIHDDIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4A4BE80", Offset = "0x4A4A480", VA = "0x184A4BE80")]
	private static void GJFOINFFDAL(Bounds CGENIFKMPBB, Color LPDAIJGFKBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4A4C3B0", Offset = "0x4A4A9B0", VA = "0x184A4C3B0")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5734D0", Offset = "0x571AD0", VA = "0x1805734D0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5898C0", Offset = "0x587EC0", VA = "0x1805898C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5898D0", Offset = "0x587ED0", VA = "0x1805898D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x513200", Offset = "0x511800", VA = "0x180513200", Slot = "4")]
	public virtual void DCBPOJDKMNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x9587B0", Offset = "0x956DB0", VA = "0x1809587B0")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[JNDKPJAPMML]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1CCC710", Offset = "0x1CCAD10", VA = "0x181CCC710", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1CCC250", Offset = "0x1CCA850", VA = "0x181CCC250", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1CCCD10", Offset = "0x1CCB310", VA = "0x181CCCD10")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class EGGBDDHBADL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9587B0", Offset = "0x956DB0", VA = "0x1809587B0")]
		public EGGBDDHBADL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xF0C8E0", Offset = "0xF0AEE0", VA = "0x180F0C8E0")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[JNDKPJAPMML]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5734D0", Offset = "0x571AD0", VA = "0x1805734D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xF1B340", Offset = "0xF19940", VA = "0x180F1B340", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xF1B370", Offset = "0xF19970", VA = "0x180F1B370", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xF1B290", Offset = "0xF19890", VA = "0x180F1B290", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public TVal this[TKey DOICKNFOJNK]
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xF1B2C0", Offset = "0xF198C0", VA = "0x180F1B2C0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xF1B190", Offset = "0xF19790", VA = "0x180F1B190", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xF1A960", Offset = "0xF18F60", VA = "0x180F1A960", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xF1A2D0", Offset = "0xF188D0", VA = "0x180F1A2D0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xF1B020", Offset = "0xF19620", VA = "0x180F1B020", Slot = "14")]
	protected virtual string PFDLNLJDDPN(TKeyVal AONHMIPGKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xF19EA0", Offset = "0xF184A0", VA = "0x180F19EA0", Slot = "4")]
	public bool ContainsKey(TKey DOICKNFOJNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xF1B080", Offset = "0xF19680", VA = "0x180F1B080", Slot = "5")]
	public bool TryGetValue(TKey DOICKNFOJNK, out TVal BEOHMGPJCII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xF19ED0", Offset = "0xF184D0", VA = "0x180F19ED0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0xF19ED0", Offset = "0xF184D0", VA = "0x180F19ED0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xF1B0B0", Offset = "0xF196B0", VA = "0x180F1B0B0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class BGFKCBLJMMO<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class FGPBACKJOHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9587B0", Offset = "0x956DB0", VA = "0x1809587B0")]
		public FGPBACKJOHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1D752D0", Offset = "0x1D738D0", VA = "0x181D752D0")]
		internal bool <GetSamples>b__0(global::FKLMNOIBJGA<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly float CLFIBNICNAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly float HHCMNALLKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private List<global::FKLMNOIBJGA<float, T>> PPFLNOJGANC;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int GJNENPGJFJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1D6F430", Offset = "0x1D6DA30", VA = "0x181D6F430")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1D6F530", Offset = "0x1D6DB30", VA = "0x181D6F530")]
	public BGFKCBLJMMO(float LOGGMAENKPG, float HABAHFMMIEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1D6F210", Offset = "0x1D6D810", VA = "0x181D6F210")]
	public bool ILDGBJDFGAH(float HAPLPMCDNNG, T BEOHMGPJCII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1D6E9A0", Offset = "0x1D6CFA0", VA = "0x181D6E9A0")]
	public int GDJFPFBNKOK(float HAPLPMCDNNG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1D6ED70", Offset = "0x1D6D370", VA = "0x181D6ED70")]
	public IEnumerable<T> GOOBCFIIMNH(float HAPLPMCDNNG, [Optional] float? PFHMBLKGJCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1D6EA00", Offset = "0x1D6D000", VA = "0x181D6EA00")]
	public void GMBCIADOMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1D6F370", Offset = "0x1D6D970", VA = "0x181D6F370")]
	private void LNGJOIMCPLK(float HAPLPMCDNNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public abstract class NDPBOKFHBAG<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct KIAPIEIKHGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public T OMBLCGHBLCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float DHKGOBANPAD;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static float KAKLKCNJLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private List<T> ONLOHKMFGEB;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private const int AEIJAABKOPF = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private KIAPIEIKHGJ[] IPALGAJDHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int NLBOMBJAIKD;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float OMGOFOKIFJK
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x73FA60", Offset = "0x73E060", VA = "0x18073FA60")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x73F9B0", Offset = "0x73DFB0", VA = "0x18073F9B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3C362B0", Offset = "0x3C348B0", VA = "0x183C362B0")]
	public NDPBOKFHBAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3C361D0", Offset = "0x3C347D0", VA = "0x183C361D0")]
	public NDPBOKFHBAG(int MMFNMECEIOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3C35F00", Offset = "0x3C34500", VA = "0x183C35F00")]
	public void MEEOIBACLCF(float HAPLPMCDNNG, T BEOHMGPJCII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3C359C0", Offset = "0x3C33FC0", VA = "0x183C359C0")]
	public void GMBCIADOMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3C35560", Offset = "0x3C33B60", VA = "0x183C35560")]
	public bool GBMHECOGEEK(float OCJBJOFJFOK, float FJLEDOGLICD, out T BEOHMGPJCII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3C35020", Offset = "0x3C33620", VA = "0x183C35020")]
	public bool FFBPOCEGFPO(float OCJBJOFJFOK, float FJLEDOGLICD, out T BEOHMGPJCII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3C35C50", Offset = "0x3C34250", VA = "0x183C35C50")]
	public void HKMIHPIEFPE(float OCJBJOFJFOK, float FJLEDOGLICD, List<T> OLKGMLDDKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3C34CE0", Offset = "0x3C332E0", VA = "0x183C34CE0")]
	private int DPMFAMFFKKN(int MDMGPBLNFEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3C34CA0", Offset = "0x3C332A0", VA = "0x183C34CA0")]
	private void DBIJLMFMMAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T HBBLHNBELNB();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T CBEKLNMBOEK(T KCPADFGPKKP, T JIPLEOBHMFD, float GMMDOKCFICC);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T FGAJPMNPCIB(T BEOHMGPJCII, float GMMDOKCFICC);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T BJIIMCGHPGG(T KCPADFGPKKP, T JIPLEOBHMFD);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T DLKGLNHGJOM(T KCPADFGPKKP, T JIPLEOBHMFD);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class NFEDMHAHAIF : global::NDPBOKFHBAG<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4A49FE0", Offset = "0x4A485E0", VA = "0x184A49FE0", Slot = "4")]
	protected override Vector3 HBBLHNBELNB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4A49E10", Offset = "0x4A48410", VA = "0x184A49E10", Slot = "5")]
	protected override Vector3 CBEKLNMBOEK(Vector3 KCPADFGPKKP, Vector3 JIPLEOBHMFD, float GMMDOKCFICC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4A49F40", Offset = "0x4A48540", VA = "0x184A49F40", Slot = "6")]
	protected override Vector3 FGAJPMNPCIB(Vector3 BEOHMGPJCII, float GMMDOKCFICC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4A49D60", Offset = "0x4A48360", VA = "0x184A49D60", Slot = "7")]
	protected override Vector3 BJIIMCGHPGG(Vector3 KCPADFGPKKP, Vector3 JIPLEOBHMFD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4A49ED0", Offset = "0x4A484D0", VA = "0x184A49ED0", Slot = "8")]
	protected override Vector3 DLKGLNHGJOM(Vector3 KCPADFGPKKP, Vector3 JIPLEOBHMFD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4A4A050", Offset = "0x4A48650", VA = "0x184A4A050")]
	public NFEDMHAHAIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class GLMBCNFGDCF : global::NDPBOKFHBAG<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4A47C40", Offset = "0x4A46240", VA = "0x184A47C40")]
	public GLMBCNFGDCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4A47BD0", Offset = "0x4A461D0", VA = "0x184A47BD0")]
	public GLMBCNFGDCF(int MMFNMECEIOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x906FB0", Offset = "0x9055B0", VA = "0x180906FB0", Slot = "4")]
	protected override float HBBLHNBELNB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4A47B40", Offset = "0x4A46140", VA = "0x184A47B40", Slot = "5")]
	protected override float CBEKLNMBOEK(float KCPADFGPKKP, float JIPLEOBHMFD, float GMMDOKCFICC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1D279A0", Offset = "0x1D25FA0", VA = "0x181D279A0", Slot = "6")]
	protected override float FGAJPMNPCIB(float BEOHMGPJCII, float GMMDOKCFICC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x587FB0", Offset = "0x5865B0", VA = "0x180587FB0", Slot = "7")]
	protected override float BJIIMCGHPGG(float KCPADFGPKKP, float JIPLEOBHMFD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4A47BC0", Offset = "0x4A461C0", VA = "0x184A47BC0", Slot = "8")]
	protected override float DLKGLNHGJOM(float KCPADFGPKKP, float JIPLEOBHMFD)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class KNHLBCJLNNF
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x178CA00", Offset = "0x178B000", VA = "0x18178CA00")]
	public static global::MOKINOFGBPI<T1> GMAHEMAIIFF<T1>(T1 HLPECNMGHGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2FF71F0", Offset = "0x2FF57F0", VA = "0x182FF71F0")]
	public static global::FKLMNOIBJGA<T1, T2> GMAHEMAIIFF<T1, T2>(T1 HLPECNMGHGN, T2 GODPIFLDDDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2F94530", Offset = "0x2F92B30", VA = "0x182F94530")]
	public static global::AMMAOFKCNEG<T1, T2, T3> GMAHEMAIIFF<T1, T2, T3>(T1 HLPECNMGHGN, T2 GODPIFLDDDI, T3 HPOPIBFPJBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1797BA0", Offset = "0x17961A0", VA = "0x181797BA0")]
	public static global::NKJOAJOEEIF<T1, T2, T3, T4> GMAHEMAIIFF<T1, T2, T3, T4>(T1 HLPECNMGHGN, T2 GODPIFLDDDI, T3 HPOPIBFPJBP, T4 AJBFBOOFGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3325F30", Offset = "0x3324530", VA = "0x183325F30")]
	public static global::BEPANEMDMGB<T1, T2, T3, T4, T5> GMAHEMAIIFF<T1, T2, T3, T4, T5>(T1 HLPECNMGHGN, T2 GODPIFLDDDI, T3 HPOPIBFPJBP, T4 AJBFBOOFGFK, T5 JPEHEELNHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2FF7260", Offset = "0x2FF5860", VA = "0x182FF7260")]
	public static global::JLAHLBFMEPD<T1, T2, T3, T4, T5, T6> GMAHEMAIIFF<T1, T2, T3, T4, T5, T6>(T1 HLPECNMGHGN, T2 GODPIFLDDDI, T3 HPOPIBFPJBP, T4 AJBFBOOFGFK, T5 JPEHEELNHCH, T6 CJNDAFFBHPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1797AE0", Offset = "0x17960E0", VA = "0x181797AE0")]
	public static global::OMMKLBCJIIL<T1, T2, T3, T4, T5, T6, T7> GMAHEMAIIFF<T1, T2, T3, T4, T5, T6, T7>(T1 HLPECNMGHGN, T2 GODPIFLDDDI, T3 HPOPIBFPJBP, T4 AJBFBOOFGFK, T5 JPEHEELNHCH, T6 CJNDAFFBHPE, T7 JANAPPDEIKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3325E60", Offset = "0x3324460", VA = "0x183325E60")]
	public static global::DPGMPBMNAHP<T1, T2, T3, T4, T5, T6, T7, T8> GMAHEMAIIFF<T1, T2, T3, T4, T5, T6, T7, T8>(T1 HLPECNMGHGN, T2 GODPIFLDDDI, T3 HPOPIBFPJBP, T4 AJBFBOOFGFK, T5 JPEHEELNHCH, T6 CJNDAFFBHPE, T7 JANAPPDEIKF, T8 NIHADGEIAPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2B11400", Offset = "0x2B0FA00", VA = "0x182B11400")]
	[IteratorStateMachine(typeof(BLEHCNCFMPB))]
	public static IEnumerable<global::FKLMNOIBJGA<T1, T2>> LGGGPOPEJCO<T1, T2>(IEnumerable<T1> AIOBBLAENLL, IEnumerable<T2> CGENIFKMPBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2DE68F0", Offset = "0x2DE4EF0", VA = "0x182DE68F0")]
	[IteratorStateMachine(typeof(HDJNFPIDHEL))]
	public static IEnumerable<global::AMMAOFKCNEG<T1, T2, T3>> LGGGPOPEJCO<T1, T2, T3>(IEnumerable<T1> AIOBBLAENLL, IEnumerable<T2> CGENIFKMPBB, IEnumerable<T3> LPDAIJGFKBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x32FB370", Offset = "0x32F9970", VA = "0x1832FB370")]
	internal static int PNNAIBIOAGN(int DMHKCFPMCKA, int IPGLMACAIBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x434BF40", Offset = "0x434A540", VA = "0x18434BF40")]
	internal static int PNNAIBIOAGN(int DMHKCFPMCKA, int IPGLMACAIBE, int BCHCHIBKAHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x434BF50", Offset = "0x434A550", VA = "0x18434BF50")]
	internal static int PNNAIBIOAGN(int DMHKCFPMCKA, int IPGLMACAIBE, int BCHCHIBKAHD, int DGHHOKBBJFE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4A49800", Offset = "0x4A47E00", VA = "0x184A49800")]
	internal static int PNNAIBIOAGN(int DMHKCFPMCKA, int IPGLMACAIBE, int BCHCHIBKAHD, int DGHHOKBBJFE, int DIEOLGALNDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4A49850", Offset = "0x4A47E50", VA = "0x184A49850")]
	internal static int PNNAIBIOAGN(int DMHKCFPMCKA, int IPGLMACAIBE, int BCHCHIBKAHD, int DGHHOKBBJFE, int DIEOLGALNDH, int PDPPHFJGKML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4A497D0", Offset = "0x4A47DD0", VA = "0x184A497D0")]
	internal static int PNNAIBIOAGN(int DMHKCFPMCKA, int IPGLMACAIBE, int BCHCHIBKAHD, int DGHHOKBBJFE, int DIEOLGALNDH, int PDPPHFJGKML, int NOLDFDMGNBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4A49820", Offset = "0x4A47E20", VA = "0x184A49820")]
	internal static int PNNAIBIOAGN(int DMHKCFPMCKA, int IPGLMACAIBE, int BCHCHIBKAHD, int DGHHOKBBJFE, int DIEOLGALNDH, int PDPPHFJGKML, int NOLDFDMGNBN, int LAGJPMAJNJB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class MOKINOFGBPI<T1> : IComparable<global::MOKINOFGBPI<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T1 DPKPHCPBEEK;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x15CA010", Offset = "0x15C8610", VA = "0x1815CA010")]
	public MOKINOFGBPI(T1 HLPECNMGHGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3857460", Offset = "0x3855A60", VA = "0x183857460", Slot = "4")]
	public int CompareTo(global::MOKINOFGBPI<T1> DBPHKEMCPDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x38574D0", Offset = "0x3855AD0", VA = "0x1838574D0", Slot = "0")]
	public override bool Equals(object DBPHKEMCPDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x57A150", Offset = "0x578750", VA = "0x18057A150", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3857570", Offset = "0x3855B70", VA = "0x183857570", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FKLMNOIBJGA<T1, T2> : IComparable<global::FKLMNOIBJGA<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T1 DPKPHCPBEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T2 BCNMEIOGKEF;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1536780", Offset = "0x1534D80", VA = "0x181536780")]
	public FKLMNOIBJGA(T1 HLPECNMGHGN, T2 GODPIFLDDDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1534B20", Offset = "0x1533120", VA = "0x181534B20", Slot = "4")]
	public int CompareTo(global::FKLMNOIBJGA<T1, T2> DBPHKEMCPDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1535710", Offset = "0x1533D10", VA = "0x181535710", Slot = "0")]
	public override bool Equals(object DBPHKEMCPDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1535B10", Offset = "0x1534110", VA = "0x181535B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1535DF0", Offset = "0x15343F0", VA = "0x181535DF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class AMMAOFKCNEG<T1, T2, T3> : IComparable<global::AMMAOFKCNEG<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 DPKPHCPBEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 BCNMEIOGKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T3 DDNCABJLGCJ;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4174D20", Offset = "0x4173320", VA = "0x184174D20")]
	public AMMAOFKCNEG(T1 HLPECNMGHGN, T2 GODPIFLDDDI, T3 HPOPIBFPJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4174640", Offset = "0x4172C40", VA = "0x184174640", Slot = "4")]
	public int CompareTo(global::AMMAOFKCNEG<T1, T2, T3> DBPHKEMCPDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4174830", Offset = "0x4172E30", VA = "0x184174830", Slot = "0")]
	public override bool Equals(object DBPHKEMCPDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x41749A0", Offset = "0x4172FA0", VA = "0x1841749A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4174B90", Offset = "0x4173190", VA = "0x184174B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class NKJOAJOEEIF<T1, T2, T3, T4> : IComparable<global::NKJOAJOEEIF<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T1 DPKPHCPBEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T2 BCNMEIOGKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T3 DDNCABJLGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T4 DOHBOECDHMA;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1E8D670", Offset = "0x1E8BC70", VA = "0x181E8D670")]
	public NKJOAJOEEIF(T1 HLPECNMGHGN, T2 GODPIFLDDDI, T3 HPOPIBFPJBP, T4 AJBFBOOFGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3C3C9F0", Offset = "0x3C3AFF0", VA = "0x183C3C9F0", Slot = "4")]
	public int CompareTo(global::NKJOAJOEEIF<T1, T2, T3, T4> DBPHKEMCPDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3C3CB30", Offset = "0x3C3B130", VA = "0x183C3CB30", Slot = "0")]
	public override bool Equals(object DBPHKEMCPDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3C3CC50", Offset = "0x3C3B250", VA = "0x183C3CC50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3C3CD10", Offset = "0x3C3B310", VA = "0x183C3CD10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class BEPANEMDMGB<T1, T2, T3, T4, T5> : IComparable<global::BEPANEMDMGB<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T1 DPKPHCPBEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T2 BCNMEIOGKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T3 DDNCABJLGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T4 DOHBOECDHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T5 JHDPIBEDPKE;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x12EB800", Offset = "0x12E9E00", VA = "0x1812EB800")]
	public BEPANEMDMGB(T1 HLPECNMGHGN, T2 GODPIFLDDDI, T3 HPOPIBFPJBP, T4 AJBFBOOFGFK, T5 JPEHEELNHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x41776D0", Offset = "0x4175CD0", VA = "0x1841776D0", Slot = "4")]
	public int CompareTo(global::BEPANEMDMGB<T1, T2, T3, T4, T5> DBPHKEMCPDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4177850", Offset = "0x4175E50", VA = "0x184177850", Slot = "0")]
	public override bool Equals(object DBPHKEMCPDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4177990", Offset = "0x4175F90", VA = "0x184177990", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4177A90", Offset = "0x4176090", VA = "0x184177A90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class JLAHLBFMEPD<T1, T2, T3, T4, T5, T6> : IComparable<global::JLAHLBFMEPD<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T1 DPKPHCPBEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T2 BCNMEIOGKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T3 DDNCABJLGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T4 DOHBOECDHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T5 JHDPIBEDPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T6 KOJFLBKHHAJ;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x123E260", Offset = "0x123C860", VA = "0x18123E260")]
	public JLAHLBFMEPD(T1 HLPECNMGHGN, T2 GODPIFLDDDI, T3 HPOPIBFPJBP, T4 AJBFBOOFGFK, T5 JPEHEELNHCH, T6 CJNDAFFBHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x123DCC0", Offset = "0x123C2C0", VA = "0x18123DCC0", Slot = "4")]
	public int CompareTo(global::JLAHLBFMEPD<T1, T2, T3, T4, T5, T6> DBPHKEMCPDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x123DE80", Offset = "0x123C480", VA = "0x18123DE80", Slot = "0")]
	public override bool Equals(object DBPHKEMCPDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x123DFF0", Offset = "0x123C5F0", VA = "0x18123DFF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x123E110", Offset = "0x123C710", VA = "0x18123E110", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class OMMKLBCJIIL<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::OMMKLBCJIIL<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T1 DPKPHCPBEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T2 BCNMEIOGKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T3 DDNCABJLGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T4 DOHBOECDHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T5 JHDPIBEDPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T6 KOJFLBKHHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T7 OKCODJJOGKC;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x966980", Offset = "0x964F80", VA = "0x180966980")]
	public OMMKLBCJIIL(T1 HLPECNMGHGN, T2 GODPIFLDDDI, T3 HPOPIBFPJBP, T4 AJBFBOOFGFK, T5 JPEHEELNHCH, T6 CJNDAFFBHPE, T7 JANAPPDEIKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x966320", Offset = "0x964920", VA = "0x180966320", Slot = "4")]
	public int CompareTo(global::OMMKLBCJIIL<T1, T2, T3, T4, T5, T6, T7> DBPHKEMCPDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x966520", Offset = "0x964B20", VA = "0x180966520", Slot = "0")]
	public override bool Equals(object DBPHKEMCPDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x9666C0", Offset = "0x964CC0", VA = "0x1809666C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x966810", Offset = "0x964E10", VA = "0x180966810", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class DPGMPBMNAHP<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::DPGMPBMNAHP<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T1 DPKPHCPBEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T2 BCNMEIOGKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T3 DDNCABJLGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T4 DOHBOECDHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T5 JHDPIBEDPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T6 KOJFLBKHHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T7 OKCODJJOGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T8 GIOONOPLELE;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x32C7570", Offset = "0x32C5B70", VA = "0x1832C7570")]
	public DPGMPBMNAHP(T1 HLPECNMGHGN, T2 GODPIFLDDDI, T3 HPOPIBFPJBP, T4 AJBFBOOFGFK, T5 JPEHEELNHCH, T6 CJNDAFFBHPE, T7 JANAPPDEIKF, T8 NIHADGEIAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x32C6E60", Offset = "0x32C5460", VA = "0x1832C6E60", Slot = "4")]
	public int CompareTo(global::DPGMPBMNAHP<T1, T2, T3, T4, T5, T6, T7, T8> DBPHKEMCPDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x32C70B0", Offset = "0x32C56B0", VA = "0x1832C70B0", Slot = "0")]
	public override bool Equals(object DBPHKEMCPDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x32C7270", Offset = "0x32C5870", VA = "0x1832C7270", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x32C73E0", Offset = "0x32C59E0", VA = "0x1832C73E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public T OMBLCGHBLCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x534830", Offset = "0x532E30", VA = "0x180534830")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x534510", Offset = "0x532B10", VA = "0x180534510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float LGPGLONBFLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x83A820", Offset = "0x838E20", VA = "0x18083A820")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3A5A010", Offset = "0x3A58610", VA = "0x183A5A010")]
	public T EFLPCKHJOLL(float GMMDOKCFICC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3A59BB0", Offset = "0x3A581B0", VA = "0x183A59BB0")]
	public T DNEMHPJDGKN(float GMMDOKCFICC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T CBEKLNMBOEK(T KCPADFGPKKP, T JIPLEOBHMFD, float GMMDOKCFICC);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x9587B0", Offset = "0x956DB0", VA = "0x1809587B0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4A47A80", Offset = "0x4A46080", VA = "0x184A47A80", Slot = "4")]
	protected override float CBEKLNMBOEK(float KCPADFGPKKP, float JIPLEOBHMFD, float GMMDOKCFICC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4A47B00", Offset = "0x4A46100", VA = "0x184A47B00")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4A4D650", Offset = "0x4A4BC50", VA = "0x184A4D650", Slot = "4")]
	protected override Vector3 CBEKLNMBOEK(Vector3 KCPADFGPKKP, Vector3 JIPLEOBHMFD, float GMMDOKCFICC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4A4D710", Offset = "0x4A4BD10", VA = "0x184A4D710")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x1FFEE00", Offset = "0x1FFD400", VA = "0x181FFEE00", Slot = "4")]
	protected override Color CBEKLNMBOEK(Color KCPADFGPKKP, Color JIPLEOBHMFD, float GMMDOKCFICC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4A472D0", Offset = "0x4A458D0", VA = "0x184A472D0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public sealed class MEGIJAABCFO<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private T[] FOCLMBELAPL;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int PKIGJFDDAAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x535300", Offset = "0x533900", VA = "0x180535300")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x58E110", Offset = "0x58C710", VA = "0x18058E110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T HOKHJKLNMJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3A29790", Offset = "0x3A27D90", VA = "0x183A29790")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3A29810", Offset = "0x3A27E10", VA = "0x183A29810")]
	public static global::MEGIJAABCFO<T> BLDFDKFJCHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3A299B0", Offset = "0x3A27FB0", VA = "0x183A299B0")]
	public static global::MEGIJAABCFO<T> LDAKAPBBFME(int MLFIIPFKFNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3A2A350", Offset = "0x3A28950", VA = "0x183A2A350")]
	private MEGIJAABCFO(T[] OLIAMEFJMOH, int MLFIIPFKFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3A29940", Offset = "0x3A27F40", VA = "0x183A29940", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3A29D60", Offset = "0x3A28360", VA = "0x183A29D60")]
	public void MEEOIBACLCF(in T BEOHMGPJCII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3A2A090", Offset = "0x3A28690", VA = "0x183A2A090")]
	public void OPPEPMOKGDH(int MMFNMECEIOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3A29AF0", Offset = "0x3A280F0", VA = "0x183A29AF0")]
	private void LIDCOONIHOB(int MLFIIPFKFNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class DNCNAIAKILE
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2FF0420", Offset = "0x2FEEA20", VA = "0x182FF0420")]
	public static global::MEGIJAABCFO<T> BLDFDKFJCHG<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2784770", Offset = "0x2782D70", VA = "0x182784770")]
	public static global::MEGIJAABCFO<T> LDAKAPBBFME<T>(int MLFIIPFKFNC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[DefaultMember("Item")]
public class AOLCLDOACNK<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Dictionary<TKey, TVal> LEJMANLBPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<TVal, TKey> MFDGJBMHKBD;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int PKIGJFDDAAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x15D58C0", Offset = "0x15D3EC0", VA = "0x1815D58C0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool BIEMINDKIJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x570FF0", Offset = "0x56F5F0", VA = "0x180570FF0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public ICollection<TKey> MHLNPIMILBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x1241D00", Offset = "0x1240300", VA = "0x181241D00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TVal> KDLOLPHPAPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1CC4B00", Offset = "0x1CC3100", VA = "0x181CC4B00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public TVal HOKHJKLNMJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x33CB410", Offset = "0x33C9A10", VA = "0x1833CB410", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x4175A10", Offset = "0x4174010", VA = "0x184175A10", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TKey HOKHJKLNMJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x4174E30", Offset = "0x4173430", VA = "0x184174E30")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x41753D0", Offset = "0x41739D0", VA = "0x1841753D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x41751C0", Offset = "0x41737C0", VA = "0x1841751C0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4175890", Offset = "0x4173E90", VA = "0x184175890", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4174DA0", Offset = "0x41733A0", VA = "0x184174DA0", Slot = "9")]
	public void Add(TKey DOICKNFOJNK, TVal BEOHMGPJCII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4174E00", Offset = "0x4173400", VA = "0x184174E00", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> EGONGGIKEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3908F20", Offset = "0x3907520", VA = "0x183908F20", Slot = "8")]
	public bool ContainsKey(TKey DOICKNFOJNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1834290", Offset = "0x1832890", VA = "0x181834290", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> EGONGGIKEKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4175830", Offset = "0x4173E30", VA = "0x184175830", Slot = "10")]
	public bool Remove(TKey DOICKNFOJNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4175830", Offset = "0x4173E30", VA = "0x184175830", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> EGONGGIKEKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x32C7760", Offset = "0x32C5D60", VA = "0x1832C7760", Slot = "11")]
	public bool TryGetValue(TKey DOICKNFOJNK, out TVal BEOHMGPJCII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4175310", Offset = "0x4173910", VA = "0x184175310", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4175250", Offset = "0x4173850", VA = "0x184175250", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] IPALGAJDHKH, int JBCDCIFKDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x41755D0", Offset = "0x4173BD0", VA = "0x1841755D0")]
	public void MEEOIBACLCF(TVal FNFKPHHGMNL, TKey DOICKNFOJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x4175520", Offset = "0x4173B20", VA = "0x184175520")]
	public void MEEOIBACLCF(KeyValuePair<TVal, TKey> EGONGGIKEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x41752B0", Offset = "0x41738B0", VA = "0x1841752B0")]
	public bool FHLBMHLNIGN(TVal DOICKNFOJNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x4174E60", Offset = "0x4173460", VA = "0x184174E60")]
	public bool BNOCOFCGNDC(KeyValuePair<TVal, TKey> EGONGGIKEKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1242CD0", Offset = "0x12412D0", VA = "0x181242CD0")]
	public bool FJHOKKOHPIB(TVal DOICKNFOJNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1242CD0", Offset = "0x12412D0", VA = "0x181242CD0")]
	public bool FJHOKKOHPIB(KeyValuePair<TVal, TKey> EGONGGIKEKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4174D70", Offset = "0x4173370", VA = "0x184174D70")]
	public bool AGAPKJFBJHE(TVal DOICKNFOJNK, out TKey BEOHMGPJCII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x41757B0", Offset = "0x4173DB0", VA = "0x1841757B0")]
	public IEnumerator<KeyValuePair<TVal, TKey>> POLJKMBHALJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x41756A0", Offset = "0x4173CA0", VA = "0x1841756A0")]
	private void NGBJOBBHEID(TKey DOICKNFOJNK, TVal FNFKPHHGMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x41754A0", Offset = "0x4173AA0", VA = "0x1841754A0")]
	private void MAINJMKHKCK(TKey DOICKNFOJNK, TVal FNFKPHHGMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4174F80", Offset = "0x4173580", VA = "0x184174F80")]
	private bool CIHANHPALDD(TKey DOICKNFOJNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4175040", Offset = "0x4173640", VA = "0x184175040")]
	private bool CIHANHPALDD(TVal FNFKPHHGMNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4175930", Offset = "0x4173F30", VA = "0x184175930")]
	public AOLCLDOACNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public class CHCCDNHAGEM<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private global::CHCCDNHAGEM<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x73FA60", Offset = "0x73E060", VA = "0x18073FA60", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x39953B0", Offset = "0x39939B0", VA = "0x1839953B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x39954C0", Offset = "0x3993AC0", VA = "0x1839954C0")]
		public Enumerator(global::CHCCDNHAGEM<T> OLKGMLDDKMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x513200", Offset = "0x511800", VA = "0x180513200", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3994D40", Offset = "0x3993340", VA = "0x183994D40", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3994F60", Offset = "0x3993560", VA = "0x183994F60", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3994890", Offset = "0x3992E90", VA = "0x183994890")]
		private void GIGENPEKAJC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private T[] LKMHOBGCKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int GKFKJKKLIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private int BDLEBHNJOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int IDBNAOJOPOF;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int PKIGJFDDAAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x39920A0", Offset = "0x39906A0", VA = "0x1839920A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public T HOKHJKLNMJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x3992550", Offset = "0x3990B50", VA = "0x183992550")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x3993A20", Offset = "0x3992020", VA = "0x183993A20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3994120", Offset = "0x3992720", VA = "0x183994120")]
	public CHCCDNHAGEM(int MLFIIPFKFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3993CC0", Offset = "0x39922C0", VA = "0x183993CC0")]
	public void MEEOIBACLCF(T GMMDOKCFICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3993060", Offset = "0x3991660", VA = "0x183993060")]
	public void FGDBDCAGLIJ(IEnumerable<T> AICEPFANEPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x39934C0", Offset = "0x3991AC0", VA = "0x1839934C0")]
	public void GMBCIADOMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x39926B0", Offset = "0x3990CB0", VA = "0x1839926B0")]
	public void CGHBMJIDIPC(int FDHHIMCPBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3992620", Offset = "0x3990C20", VA = "0x183992620")]
	public void CFBANCFBOBJ(int FDHHIMCPBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x39934E0", Offset = "0x3991AE0", VA = "0x1839934E0")]
	public void HOBJBNCNELL(T[] IPALGAJDHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x3993360", Offset = "0x3991960", VA = "0x183993360")]
	public Enumerator GGMPPJKPMML()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x3993FE0", Offset = "0x39925E0", VA = "0x183993FE0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3993FE0", Offset = "0x39925E0", VA = "0x183993FE0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x39920E0", Offset = "0x39906E0", VA = "0x1839920E0")]
	private int BBCGBFJHFFN(int JGJLGOCHIGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3993F00", Offset = "0x3992500", VA = "0x183993F00")]
	private int NEIFKHFKDMP(int JGJLGOCHIGF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class NMEIFIGKHGC
{
	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void LDJKNAIGEPK(object[] JKOPPFCLBPF);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
	protected NMEIFIGKHGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class GIKHPFNFMHK<T> : NMEIFIGKHGC
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	protected struct IAMJOCIAEOF
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public enum BBBFJHIGDOK
		{
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public BBBFJHIGDOK FFNKIDPAEGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public T EMFPEPGCJKF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private int GLOOHEDHEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly bool FHJDCFABOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	protected readonly bool LAHNFHMLHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	protected List<T> DJDKKABAANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private List<IAMJOCIAEOF> AMAJCJGJAHI;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool ACOCHLKLHEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x15489F0", Offset = "0x1546FF0", VA = "0x1815489F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x1548BB0", Offset = "0x15471B0", VA = "0x181548BB0")]
	protected GIKHPFNFMHK(bool LAHNFHMLHLK, bool FHJDCFABOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x1548950", Offset = "0x1546F50", VA = "0x181548950")]
	protected bool JHPKEAIODOD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x15485E0", Offset = "0x1546BE0", VA = "0x1815485E0")]
	protected void BEIFIGLDMKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x1548430", Offset = "0x1546A30", VA = "0x181548430")]
	protected void BAKDNPBEIBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x35FF8D0", Offset = "0x35FDED0", VA = "0x1835FF8D0")]
	private static void BBNLDBIHCEP<U>(ref List<U> HNDGNAECIOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x1548A30", Offset = "0x1547030", VA = "0x181548A30", Slot = "5")]
	public void MEEOIBACLCF(T EMFPEPGCJKF, bool ANPKLCJJPGI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x15486C0", Offset = "0x1546CC0", VA = "0x1815486C0", Slot = "6")]
	public void FJHOKKOHPIB(T EMFPEPGCJKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x1548820", Offset = "0x1546E20", VA = "0x181548820")]
	public void GMBCIADOMKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface CIHEDBKKICI
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MEEOIBACLCF(Action EMFPEPGCJKF, bool ANPKLCJJPGI = false);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FJHOKKOHPIB(Action EMFPEPGCJKF);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class EDOMFAGNPKP : global::GIKHPFNFMHK<Action>, CIHEDBKKICI
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4A47610", Offset = "0x4A45C10", VA = "0x184A47610")]
	public EDOMFAGNPKP(bool LAHNFHMLHLK = false, bool FHJDCFABOKG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4A47310", Offset = "0x4A45910", VA = "0x184A47310")]
	public void AEIJLPCLBNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x4A47590", Offset = "0x4A45B90", VA = "0x184A47590", Slot = "4")]
	public override void LDJKNAIGEPK(object[] JKOPPFCLBPF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4A474D0", Offset = "0x4A45AD0", VA = "0x184A474D0")]
	public static EDOMFAGNPKP HALPCGCMNJI(EDOMFAGNPKP IFCLOEMKFHP, Action EMFPEPGCJKF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4A47530", Offset = "0x4A45B30", VA = "0x184A47530")]
	public static EDOMFAGNPKP JOBEKLACNMM(EDOMFAGNPKP IFCLOEMKFHP, Action EMFPEPGCJKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface AGKOHLFGALI<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MEEOIBACLCF(Action<T> EMFPEPGCJKF, bool ANPKLCJJPGI = false);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FJHOKKOHPIB(Action<T> EMFPEPGCJKF);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public sealed class OKNBPPFOHNE<T> : global::GIKHPFNFMHK<Action<T>>, global::AGKOHLFGALI<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x965690", Offset = "0x963C90", VA = "0x180965690")]
	public OKNBPPFOHNE(bool LAHNFHMLHLK = false, bool FHJDCFABOKG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x960E20", Offset = "0x95F420", VA = "0x180960E20")]
	public void AEIJLPCLBNP(T GMMDOKCFICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x9644F0", Offset = "0x962AF0", VA = "0x1809644F0", Slot = "4")]
	public override void LDJKNAIGEPK(object[] JKOPPFCLBPF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x963840", Offset = "0x961E40", VA = "0x180963840")]
	public static global::OKNBPPFOHNE<T> HALPCGCMNJI(global::OKNBPPFOHNE<T> IFCLOEMKFHP, Action<T> EMFPEPGCJKF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x9638E0", Offset = "0x961EE0", VA = "0x1809638E0")]
	public static global::OKNBPPFOHNE<T> JOBEKLACNMM(global::OKNBPPFOHNE<T> IFCLOEMKFHP, Action<T> EMFPEPGCJKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface FFKDALBCFFK<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MEEOIBACLCF(Action<T, U> EMFPEPGCJKF, bool ANPKLCJJPGI = false);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FJHOKKOHPIB(Action<T, U> EMFPEPGCJKF);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class CLDHIIFBKIC<T, U> : global::GIKHPFNFMHK<Action<T, U>>, global::FFKDALBCFFK<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x965690", Offset = "0x963C90", VA = "0x180965690")]
	public CLDHIIFBKIC(bool LAHNFHMLHLK = false, bool FHJDCFABOKG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x33D82E0", Offset = "0x33D68E0", VA = "0x1833D82E0")]
	public void AEIJLPCLBNP(T GMMDOKCFICC, U LCOBLNOLEHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x33DBCB0", Offset = "0x33DA2B0", VA = "0x1833DBCB0", Slot = "4")]
	public override void LDJKNAIGEPK(object[] JKOPPFCLBPF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x33DA4A0", Offset = "0x33D8AA0", VA = "0x1833DA4A0")]
	public static global::CLDHIIFBKIC<T, U> HALPCGCMNJI(global::CLDHIIFBKIC<T, U> IFCLOEMKFHP, Action<T, U> EMFPEPGCJKF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x33DA540", Offset = "0x33D8B40", VA = "0x1833DA540")]
	public static global::CLDHIIFBKIC<T, U> JOBEKLACNMM(global::CLDHIIFBKIC<T, U> IFCLOEMKFHP, Action<T, U> EMFPEPGCJKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface EMFDOLCMJNC<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MEEOIBACLCF(Action<T, U, V> EMFPEPGCJKF, bool ANPKLCJJPGI = false);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FJHOKKOHPIB(Action<T, U, V> EMFPEPGCJKF);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class ECFPGJKGBNH<T, U, V> : global::GIKHPFNFMHK<Action<T, U, V>>, global::EMFDOLCMJNC<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x965690", Offset = "0x963C90", VA = "0x180965690")]
	public ECFPGJKGBNH(bool LAHNFHMLHLK = false, bool FHJDCFABOKG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3C54630", Offset = "0x3C52C30", VA = "0x183C54630")]
	public void AEIJLPCLBNP(T GMMDOKCFICC, U LCOBLNOLEHD, V IMCICOKIGHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3C54FD0", Offset = "0x3C535D0", VA = "0x183C54FD0", Slot = "4")]
	public override void LDJKNAIGEPK(object[] JKOPPFCLBPF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3C548B0", Offset = "0x3C52EB0", VA = "0x183C548B0")]
	public static global::ECFPGJKGBNH<T, U, V> HALPCGCMNJI(global::ECFPGJKGBNH<T, U, V> IFCLOEMKFHP, Action<T, U, V> EMFPEPGCJKF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3C54950", Offset = "0x3C52F50", VA = "0x183C54950")]
	public static global::ECFPGJKGBNH<T, U, V> JOBEKLACNMM(global::ECFPGJKGBNH<T, U, V> IFCLOEMKFHP, Action<T, U, V> EMFPEPGCJKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface MELFIKGHFGJ<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MEEOIBACLCF(Action<T, U, V, W> EMFPEPGCJKF, bool ANPKLCJJPGI = false);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FJHOKKOHPIB(Action<T, U, V, W> EMFPEPGCJKF);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class JNPADGNPJIK<T, U, V, W> : global::GIKHPFNFMHK<Action<T, U, V, W>>, global::MELFIKGHFGJ<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x965690", Offset = "0x963C90", VA = "0x180965690")]
	public JNPADGNPJIK(bool LAHNFHMLHLK = false, bool FHJDCFABOKG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x123F030", Offset = "0x123D630", VA = "0x18123F030")]
	public void AEIJLPCLBNP(T GMMDOKCFICC, U LCOBLNOLEHD, V IMCICOKIGHM, W JIABHIKNJHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x1240B30", Offset = "0x123F130", VA = "0x181240B30", Slot = "4")]
	public override void LDJKNAIGEPK(object[] JKOPPFCLBPF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x1240000", Offset = "0x123E600", VA = "0x181240000")]
	public static global::JNPADGNPJIK<T, U, V, W> HALPCGCMNJI(global::JNPADGNPJIK<T, U, V, W> IFCLOEMKFHP, Action<T, U, V, W> EMFPEPGCJKF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x12400A0", Offset = "0x123E6A0", VA = "0x1812400A0")]
	public static global::JNPADGNPJIK<T, U, V, W> JOBEKLACNMM(global::JNPADGNPJIK<T, U, V, W> IFCLOEMKFHP, Action<T, U, V, W> EMFPEPGCJKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface FPNFHDHHBJH<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MEEOIBACLCF(Action<T, U, V, W, X> EMFPEPGCJKF, bool ANPKLCJJPGI = false);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FJHOKKOHPIB(Action<T, U, V, W, X> EMFPEPGCJKF);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class EAKBEGKFEGD<T, U, V, W, X> : global::GIKHPFNFMHK<Action<T, U, V, W, X>>, global::FPNFHDHHBJH<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x965690", Offset = "0x963C90", VA = "0x180965690")]
	public EAKBEGKFEGD(bool LAHNFHMLHLK = false, bool FHJDCFABOKG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3C51680", Offset = "0x3C4FC80", VA = "0x183C51680")]
	public void AEIJLPCLBNP(T GMMDOKCFICC, U LCOBLNOLEHD, V IMCICOKIGHM, W JIABHIKNJHH, X NJIPMFDFONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3C52010", Offset = "0x3C50610", VA = "0x183C52010", Slot = "4")]
	public override void LDJKNAIGEPK(object[] JKOPPFCLBPF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3C51ED0", Offset = "0x3C504D0", VA = "0x183C51ED0")]
	public static global::EAKBEGKFEGD<T, U, V, W, X> HALPCGCMNJI(global::EAKBEGKFEGD<T, U, V, W, X> IFCLOEMKFHP, Action<T, U, V, W, X> EMFPEPGCJKF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3C51F70", Offset = "0x3C50570", VA = "0x183C51F70")]
	public static global::EAKBEGKFEGD<T, U, V, W, X> JOBEKLACNMM(global::EAKBEGKFEGD<T, U, V, W, X> IFCLOEMKFHP, Action<T, U, V, W, X> EMFPEPGCJKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface AEPIKHDEDIK<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MEEOIBACLCF(Action<T, U, V, W, X, Y> EMFPEPGCJKF, bool ANPKLCJJPGI = false);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FJHOKKOHPIB(Action<T, U, V, W, X, Y> EMFPEPGCJKF);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class IFGONCNHEND<T, U, V, W, X, Y> : global::GIKHPFNFMHK<Action<T, U, V, W, X, Y>>, global::AEPIKHDEDIK<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x965690", Offset = "0x963C90", VA = "0x180965690")]
	public IFGONCNHEND(bool LAHNFHMLHLK = false, bool FHJDCFABOKG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0xED0E10", Offset = "0xECF410", VA = "0x180ED0E10")]
	public void AEIJLPCLBNP(T GMMDOKCFICC, U LCOBLNOLEHD, V IMCICOKIGHM, W JIABHIKNJHH, X NJIPMFDFONJ, Y ENLDDEBGJMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0xED1520", Offset = "0xECFB20", VA = "0x180ED1520", Slot = "4")]
	public override void LDJKNAIGEPK(object[] JKOPPFCLBPF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0xED13E0", Offset = "0xECF9E0", VA = "0x180ED13E0")]
	public static global::IFGONCNHEND<T, U, V, W, X, Y> HALPCGCMNJI(global::IFGONCNHEND<T, U, V, W, X, Y> IFCLOEMKFHP, Action<T, U, V, W, X, Y> EMFPEPGCJKF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0xED1480", Offset = "0xECFA80", VA = "0x180ED1480")]
	public static global::IFGONCNHEND<T, U, V, W, X, Y> JOBEKLACNMM(global::IFGONCNHEND<T, U, V, W, X, Y> IFCLOEMKFHP, Action<T, U, V, W, X, Y> EMFPEPGCJKF)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
public readonly struct OEOLPHILGMJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class PFHJNPEJLHK<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public readonly struct HHENLACIKOF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly global::PFHJNPEJLHK<T> ILJIHFLBCFK;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public T OMBLCGHBLCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x3160420", Offset = "0x315EA20", VA = "0x183160420")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x31603F0", Offset = "0x315E9F0", VA = "0x1831603F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8B5D10", Offset = "0x8B4310", VA = "0x1808B5D10")]
		public HHENLACIKOF(global::PFHJNPEJLHK<T> ILJIHFLBCFK)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct PFKHEBPJJGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public AsyncTaskMethodBuilder<HHENLACIKOF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public global::PFHJNPEJLHK<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x3177010", Offset = "0x3175610", VA = "0x183177010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x31607E0", Offset = "0x315EDE0", VA = "0x1831607E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct JKCFIJNGJCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public AsyncTaskMethodBuilder<HHENLACIKOF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public global::PFHJNPEJLHK<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x3160440", Offset = "0x315EA40", VA = "0x183160440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x31607E0", Offset = "0x315EDE0", VA = "0x1831607E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly SemaphoreSlim NKJHFJCOMLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private T GHNJKCKHHHM;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int IBDNGENJGBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x3176EB0", Offset = "0x31754B0", VA = "0x183176EB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x3176ED0", Offset = "0x31754D0", VA = "0x183176ED0")]
	public PFHJNPEJLHK(in T GHNJKCKHHHM, int ADFKAKNOJEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x123BA30", Offset = "0x123A030", VA = "0x18123BA30")]
	public PFHJNPEJLHK(in T GHNJKCKHHHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3176870", Offset = "0x3174E70", VA = "0x183176870")]
	public HHENLACIKOF AHMMLIGBHPN()
	{
		return default(HHENLACIKOF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x31768B0", Offset = "0x3174EB0", VA = "0x1831768B0")]
	public HHENLACIKOF AHMMLIGBHPN(CancellationToken CKLMBBKFAGN)
	{
		return default(HHENLACIKOF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x31768F0", Offset = "0x3174EF0", VA = "0x1831768F0")]
	[AsyncStateMachine(typeof(global::PFHJNPEJLHK<>.PFKHEBPJJGD))]
	public Task<HHENLACIKOF> GPFCJJGLKFH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3176BB0", Offset = "0x31751B0", VA = "0x183176BB0")]
	[AsyncStateMachine(typeof(global::PFHJNPEJLHK<>.JKCFIJNGJCO))]
	public Task<HHENLACIKOF> GPFCJJGLKFH(CancellationToken CKLMBBKFAGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class ANDFNDPDBEI
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x4A471A0", Offset = "0x4A457A0", VA = "0x184A471A0")]
	public static global::PFHJNPEJLHK<OEOLPHILGMJ> BLDFDKFJCHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x4A47200", Offset = "0x4A45800", VA = "0x184A47200")]
	public static global::PFHJNPEJLHK<OEOLPHILGMJ> BLDFDKFJCHG(int ADFKAKNOJEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x178CA00", Offset = "0x178B000", VA = "0x18178CA00")]
	public static global::PFHJNPEJLHK<T> BLDFDKFJCHG<T>(in T GHNJKCKHHHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x178CA60", Offset = "0x178B060", VA = "0x18178CA60")]
	public static global::PFHJNPEJLHK<T> BLDFDKFJCHG<T>(in T GHNJKCKHHHM, int ADFKAKNOJEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class HFADDCJFNBE<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public delegate bool OLNPNHJBAPB(global::HFADDCJFNBE<T> LJEFIDNOOMO);

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class LCOGDLGHDIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public T nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public global::HFADDCJFNBE<T> foundNode;

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x9587B0", Offset = "0x956DB0", VA = "0x1809587B0")]
		public LCOGDLGHDIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x3F40900", Offset = "0x3F3EF00", VA = "0x183F40900")]
		internal bool <FindNode>b__0(global::HFADDCJFNBE<T> node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public T OJNKBNHFMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public LinkedList<global::HFADDCJFNBE<T>> IFFEFOBMEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public global::HFADDCJFNBE<T> CHLJKHDCEMC;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public global::HFADDCJFNBE<T> FEIHFKLBCMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x55A3F0", Offset = "0x5589F0", VA = "0x18055A3F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x3F31DE0", Offset = "0x3F303E0", VA = "0x183F31DE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool POBPBOMAOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x3F32080", Offset = "0x3F30680", VA = "0x183F32080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool DAEGDMOGGMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x3F31F00", Offset = "0x3F30500", VA = "0x183F31F00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public global::HFADDCJFNBE<T> KDOCDFLBPBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x3F32570", Offset = "0x3F30B70", VA = "0x183F32570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x3F342B0", Offset = "0x3F328B0", VA = "0x183F342B0")]
	public HFADDCJFNBE(T FHPOKAHGLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x3F32E50", Offset = "0x3F31450", VA = "0x183F32E50")]
	public global::HFADDCJFNBE<T> MHLPCMHJMNM(T OIONANLGGFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x3F33F20", Offset = "0x3F32520", VA = "0x183F33F20")]
	public global::HFADDCJFNBE<T> PLOPKJGECCK(T NEMBMKGBLHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3F31FD0", Offset = "0x3F305D0", VA = "0x183F31FD0")]
	public global::HFADDCJFNBE<T> FJHOKKOHPIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3F32310", Offset = "0x3F30910", VA = "0x183F32310")]
	public void GMBCIADOMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3F325F0", Offset = "0x3F30BF0", VA = "0x183F325F0")]
	public global::HFADDCJFNBE<T> KCNMHPFNNNC(T PNNIGCNFMIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3F32B10", Offset = "0x3F31110", VA = "0x183F32B10")]
	public static void LBIGKGGECPD(global::HFADDCJFNBE<T> DFGEBECGEIB, OLNPNHJBAPB FPDNGJHLBNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3600D40", Offset = "0x35FF340", VA = "0x183600D40")]
	public static void LBIGKGGECPD<A>(global::HFADDCJFNBE<T> DFGEBECGEIB, Func<global::HFADDCJFNBE<T>, A, bool> FPDNGJHLBNI, A NNBKNGECLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3F339E0", Offset = "0x3F31FE0", VA = "0x183F339E0")]
	public static string NLEDFGJBGEI(global::HFADDCJFNBE<T> DFGEBECGEIB, int GFDLNLPJGDB = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x3F33060", Offset = "0x3F31660", VA = "0x183F33060")]
	public static global::HFADDCJFNBE<T> NCKCADNBAKK(global::HFADDCJFNBE<T> DFGEBECGEIB, T HLGGBKJALFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class NHIPFPHPBON<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public delegate Task<TResult> JEAAEKAKNFL(TRequest NGMDHDEGDIM, CancellationToken CKLMBBKFAGN);

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public enum NOPAKDANLJC
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class JBMLNBNPJDL
	{
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private const float FBIOBNFKMON = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TimeSpan IONPBBHPBCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public int ALCFHEIPGJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public NOPAKDANLJC IJLMCEIAPOJ;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly JBMLNBNPJDL NFMMEFOILJM;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public float GJPAAKIDIJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x3C2EEB0", Offset = "0x3C2D4B0", VA = "0x183C2EEB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public TimeSpan NCDFJFAACNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x5734D0", Offset = "0x571AD0", VA = "0x1805734D0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3C2EF90", Offset = "0x3C2D590", VA = "0x183C2EF90")]
		public JBMLNBNPJDL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private readonly struct JEPJOIDFNMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public readonly TRequest NGMDHDEGDIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public readonly CancellationToken CKLMBBKFAGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public readonly TaskCompletionSource<TResult> JEJIOEBNMJA;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x3C2FE70", Offset = "0x3C2E470", VA = "0x183C2FE70")]
		public JEPJOIDFNMP(TRequest NGMDHDEGDIM, TaskCompletionSource<TResult> JEJIOEBNMJA, CancellationToken CKLMBBKFAGN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class FMPGNLOPGGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x9587B0", Offset = "0x956DB0", VA = "0x1809587B0")]
		public FMPGNLOPGGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x15D58C0", Offset = "0x15D3EC0", VA = "0x1815D58C0")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct CMJLABJIIJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public global::NHIPFPHPBON<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3C2DB30", Offset = "0x3C2C130", VA = "0x183C2DB30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x791710", Offset = "0x78FD10", VA = "0x180791710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class DACBICAPKJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public JEPJOIDFNMP req;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public global::NHIPFPHPBON<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x9587B0", Offset = "0x956DB0", VA = "0x1809587B0")]
		public DACBICAPKJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3C2DF90", Offset = "0x3C2C590", VA = "0x183C2DF90")]
		internal void <ProcessQueue>b__0(Task<TResult> task)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly CancellationTokenSource IPOPJHNDBHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly List<JEPJOIDFNMP> LBLDABPECMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly JBMLNBNPJDL AEIBEMNILNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly JEAAEKAKNFL IPEBJGABLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Task JKLNDPCMJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private int HKDCCIBAJDO;

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3C3A830", Offset = "0x3C38E30", VA = "0x183C3A830")]
	public NHIPFPHPBON(JEAAEKAKNFL IPEBJGABLKM, [Optional] JBMLNBNPJDL AEIBEMNILNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x3C39620", Offset = "0x3C37C20", VA = "0x183C39620")]
	public Task<TResult> LNOKDPJOHNP(TRequest NGMDHDEGDIM, CancellationToken CKLMBBKFAGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x3C39E70", Offset = "0x3C38470", VA = "0x183C39E70")]
	private void MDALFDAJBEN(JEPJOIDFNMP JABHPDAAMLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x3C392F0", Offset = "0x3C378F0", VA = "0x183C392F0")]
	[AsyncStateMachine(typeof(global::NHIPFPHPBON<, >.CMJLABJIIJI))]
	private Task ELGCPAKOFEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x3C38DC0", Offset = "0x3C373C0", VA = "0x183C38DC0")]
	private JEPJOIDFNMP DGPDLNBBHJK()
	{
		return default(JEPJOIDFNMP);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3C3A2E0", Offset = "0x3C388E0", VA = "0x183C3A2E0")]
	private void MFBHPBAPKCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x3C392B0", Offset = "0x3C378B0", VA = "0x183C392B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[DefaultMember("Item")]
public class KCLCBKABIFN<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public delegate int CKGAHJANFDB(TKey DOICKNFOJNK, TVal BEOHMGPJCII);

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class IODDHOOGHDM
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public TKey FGHCCNDFKNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x5734D0", Offset = "0x571AD0", VA = "0x1805734D0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public TVal OMBLCGHBLCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x7438E0", Offset = "0x741EE0", VA = "0x1807438E0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x743C60", Offset = "0x742260", VA = "0x180743C60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public int LFHNEKJHEEA
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x6B8500", Offset = "0x6B6B00", VA = "0x1806B8500")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x6B82C0", Offset = "0x6B68C0", VA = "0x1806B82C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public DateTime JEIFJOFNJAM
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x523CC0", Offset = "0x5222C0", VA = "0x180523CC0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x6AE830", Offset = "0x6ACE30", VA = "0x1806AE830")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x1238680", Offset = "0x1236C80", VA = "0x181238680")]
		public IODDHOOGHDM(TKey DOICKNFOJNK, TVal FNFKPHHGMNL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public const int KKLIONPDAKO = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly Dictionary<TKey, LinkedListNode<IODDHOOGHDM>> OKOEJCDGNIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly LinkedList<IODDHOOGHDM> CAPIOLMACOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly CKGAHJANFDB DKGDHLBEABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly TimeSpan OCHDNADJBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly PGCFIDLAKNF DJGAFEPMPEK;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int KJCJDEEIKPH
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x5FFFB0", Offset = "0x5FE5B0", VA = "0x1805FFFB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private bool EKMKCDPDAIG
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x12443D0", Offset = "0x12429D0", VA = "0x1812443D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	internal int KDPBPNJALJK
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x71A9A0", Offset = "0x718FA0", VA = "0x18071A9A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xAAD8D0", Offset = "0xAABED0", VA = "0x180AAD8D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int PKIGJFDDAAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x1068710", Offset = "0x1066D10", VA = "0x181068710")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public IEnumerable<TKey> MHLNPIMILBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x1244030", Offset = "0x1242630", VA = "0x181244030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public TVal HOKHJKLNMJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x1242CD0", Offset = "0x12412D0", VA = "0x181242CD0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x1244000", Offset = "0x1242600", VA = "0x181244000")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x1244A70", Offset = "0x1243070", VA = "0x181244A70")]
	public KCLCBKABIFN(int MLFIIPFKFNC, [Optional] CKGAHJANFDB DKGDHLBEABI, [Optional] IEqualityComparer<TKey> FLGMPNGLFEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x1244460", Offset = "0x1242A60", VA = "0x181244460")]
	public KCLCBKABIFN(TimeSpan OCHDNADJBIJ, [Optional] IEqualityComparer<TKey> FLGMPNGLFEE, [Optional] PGCFIDLAKNF DJGAFEPMPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x12447D0", Offset = "0x1242DD0", VA = "0x1812447D0")]
	public KCLCBKABIFN(int MLFIIPFKFNC, TimeSpan OCHDNADJBIJ, [Optional] IEqualityComparer<TKey> FLGMPNGLFEE, [Optional] PGCFIDLAKNF DJGAFEPMPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x12444B0", Offset = "0x1242AB0", VA = "0x1812444B0")]
	public KCLCBKABIFN(int MLFIIPFKFNC, CKGAHJANFDB DKGDHLBEABI, TimeSpan OCHDNADJBIJ, [Optional] IEqualityComparer<TKey> FLGMPNGLFEE, [Optional] PGCFIDLAKNF DJGAFEPMPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x12435D0", Offset = "0x1241BD0", VA = "0x1812435D0")]
	public void DGMGNPHMMLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x1243110", Offset = "0x1241710", VA = "0x181243110")]
	public void CBFNCDEHMFE(TKey DOICKNFOJNK, TVal BEOHMGPJCII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x1243740", Offset = "0x1241D40", VA = "0x181243740")]
	public bool FJHOKKOHPIB(TKey DOICKNFOJNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x1243F40", Offset = "0x1242540", VA = "0x181243F40")]
	private TVal JDHJFFECIGH(TKey KJJDAPCLMCK)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x1242A20", Offset = "0x1241020", VA = "0x181242A20")]
	public bool AGAPKJFBJHE(TKey KJJDAPCLMCK, out TVal BEOHMGPJCII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x1243DF0", Offset = "0x12423F0", VA = "0x181243DF0")]
	public void GMBCIADOMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x1244310", Offset = "0x1242910", VA = "0x181244310")]
	private bool NOAMNLLPCMI(IODDHOOGHDM KGNGAPELBDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x1243B60", Offset = "0x1242160", VA = "0x181243B60")]
	private void GDDKLKCBHNJ(LinkedListNode<IODDHOOGHDM> GLMHMABGEIK, TVal JJFPPONFFLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x1242F00", Offset = "0x1241500", VA = "0x181242F00")]
	private void BNEBGLDCJNK(TKey DOICKNFOJNK, TVal BEOHMGPJCII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x1243430", Offset = "0x1241A30", VA = "0x181243430")]
	private void COABGNLCPNG(IODDHOOGHDM KGNGAPELBDE, TVal JJFPPONFFLH, int JOIIOBMKGAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[DefaultMember("Item")]
public class JHBGBENPNJM<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly List<T> HNDGNAECIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private HashSet<T> KMHFAHEBECL;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int PKIGJFDDAAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x15D58C0", Offset = "0x15D3EC0", VA = "0x1815D58C0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool BIEMINDKIJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x570FF0", Offset = "0x56F5F0", VA = "0x180570FF0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public T HOKHJKLNMJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x15A7B90", Offset = "0x15A6190", VA = "0x1815A7B90", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x33CBC50", Offset = "0x33CA250", VA = "0x1833CBC50", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x95F860", Offset = "0x95DE60", VA = "0x18095F860", Slot = "11")]
	public void Add(T EGONGGIKEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x33CB820", Offset = "0x33C9E20", VA = "0x1833CB820")]
	public bool OONNLONGBJM(T EGONGGIKEKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x33CBAF0", Offset = "0x33CA0F0", VA = "0x1833CBAF0", Slot = "15")]
	public bool Remove(T EGONGGIKEKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x32C76B0", Offset = "0x32C5CB0", VA = "0x1832C76B0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x106D270", Offset = "0x106B870", VA = "0x18106D270", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x33CB350", Offset = "0x33C9950", VA = "0x1833CB350", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0xECEAB0", Offset = "0xECD0B0", VA = "0x180ECEAB0", Slot = "13")]
	public bool Contains(T EGONGGIKEKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x33CB3B0", Offset = "0x33C99B0", VA = "0x1833CB3B0", Slot = "14")]
	public void CopyTo(T[] IPALGAJDHKH, int JBCDCIFKDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x33CB410", Offset = "0x33C9A10", VA = "0x1833CB410", Slot = "6")]
	public int IndexOf(T EGONGGIKEKI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x33CB440", Offset = "0x33C9A40", VA = "0x1833CB440", Slot = "7")]
	public void Insert(int JGJLGOCHIGF, T EGONGGIKEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x33CB8C0", Offset = "0x33C9EC0", VA = "0x1833CB8C0", Slot = "8")]
	public void RemoveAt(int JGJLGOCHIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x33CB6A0", Offset = "0x33C9CA0", VA = "0x1833CB6A0")]
	public void LPFCNHDGDBJ(Predicate<T> HHCNJNDHAND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x33CB3E0", Offset = "0x33C99E0", VA = "0x1833CB3E0")]
	public void IAIPJPLAENH(Comparison<T> NGNGEEPFKGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x33CBB70", Offset = "0x33CA170", VA = "0x1833CBB70")]
	public JHBGBENPNJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class IFDMHKEBCHH
{
	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x4A48D30", Offset = "0x4A47330", VA = "0x184A48D30")]
	public static Vector3 HNNLFCGIEJI(this GameObject POBIIKOLKCO, float DDFMFFGDNCD)
	{
		return default(Vector3);
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x721F50", Offset = "0x720550", VA = "0x180721F50")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x4A4CC30", Offset = "0x4A4B230", VA = "0x184A4CC30")]
		public SerializedGuid(in Guid OMNPOILKOAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x4A4C9C0", Offset = "0x4A4AFC0", VA = "0x184A4C9C0")]
		public static SerializedGuid GCNCOLJBOGC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x4A4CBB0", Offset = "0x4A4B1B0", VA = "0x184A4CBB0")]
		public static SerializedGuid PEPBOGCMIED()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x4A4C780", Offset = "0x4A4AD80", VA = "0x184A4C780")]
		public bool AHLKGLOHFNO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x4A4CB80", Offset = "0x4A4B180", VA = "0x184A4CB80", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x4A4CAE0", Offset = "0x4A4B0E0", VA = "0x184A4CAE0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x4A4CA50", Offset = "0x4A4B050", VA = "0x184A4CA50")]
		public bool IJAGLJKAAHM(in Guid OMNPOILKOAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4A4C840", Offset = "0x4A4AE40", VA = "0x184A4C840", Slot = "7")]
		public bool Equals(SerializedGuid DBPHKEMCPDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4A4C8E0", Offset = "0x4A4AEE0", VA = "0x184A4C8E0", Slot = "0")]
		public override bool Equals(object AIHPMIAHIBA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4A4CA40", Offset = "0x4A4B040", VA = "0x184A4CA40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4A4C810", Offset = "0x4A4AE10", VA = "0x184A4C810", Slot = "6")]
		public int CompareTo(SerializedGuid DBPHKEMCPDK)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class JHKIKMMNDCF : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly Type IDLADALIHGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly string JMHEDDJPOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly bool LKFNDJOJPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly bool KBPLCPPCOCM;

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x4A48FC0", Offset = "0x4A475C0", VA = "0x184A48FC0")]
	public JHKIKMMNDCF(Type PAIPLBBKOFK, string CDKIEDDEJMO, bool GABKKAJCKLB = false, bool MPIKJHIMFJH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface NLKEGKAKIJP
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface HEHPANGCKGN<T> : NLKEGKAKIJP
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	T OMBLCGHBLCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	bool BAMIHMPFNAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	string POAJFGBCMDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::HEHPANGCKGN<T> HGFGJDNEEBG(Action<T> EJMGDMFKEBN);

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::HEHPANGCKGN<T> HHLLDPAMIIN(Action<T> EJMGDMFKEBN);

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::HEHPANGCKGN<T> NGGEOIPODFP(Action<T, T> CCBDLJCCMBA);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::HEHPANGCKGN<T> HMOIPKBGLIE(Action<T, T> CCBDLJCCMBA);

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::HEHPANGCKGN<T> KINADJHJPLD(Action<string> FNDEOCOOEKL);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::HEHPANGCKGN<T> GDHLAAIGFLM(Action<string> FNDEOCOOEKL);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class CLNMEFIELJJ<T> : global::HEHPANGCKGN<T>, NLKEGKAKIJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private global::CLDHIIFBKIC<T, T> LOJKKFKMKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private global::OKNBPPFOHNE<T> MMMAHKAOLLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private global::OKNBPPFOHNE<string> KOHPNALPANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private string HJAJAOPFGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private T FGCHJFNJCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private bool EGHFPOCBOGE;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public T OMBLCGHBLCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x534830", Offset = "0x532E30", VA = "0x180534830", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x9656C0", Offset = "0x963CC0", VA = "0x1809656C0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool BAMIHMPFNAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x76B5A0", Offset = "0x769BA0", VA = "0x18076B5A0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public string POAJFGBCMDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x535290", Offset = "0x533890", VA = "0x180535290", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xC4EF30", Offset = "0xC4D530", VA = "0x180C4EF30", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x33DCD40", Offset = "0x33DB340", VA = "0x1833DCD40")]
	private void EJJLLDPADIH(T KKJEBHHOPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x33DD010", Offset = "0x33DB610", VA = "0x1833DD010")]
	private void LDPAEGPNPPH(string DDJONAGOBHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x33DD0B0", Offset = "0x33DB6B0", VA = "0x1833DD0B0")]
	public void LKFNMONLKBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x33DD160", Offset = "0x33DB760", VA = "0x1833DD160", Slot = "6")]
	public global::HEHPANGCKGN<T> NGGEOIPODFP(Action<T, T> CCBDLJCCMBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x33DCF30", Offset = "0x33DB530", VA = "0x1833DCF30", Slot = "7")]
	public global::HEHPANGCKGN<T> HMOIPKBGLIE(Action<T, T> CCBDLJCCMBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x33DCE50", Offset = "0x33DB450", VA = "0x1833DCE50", Slot = "4")]
	public global::HEHPANGCKGN<T> HGFGJDNEEBG(Action<T> CCBDLJCCMBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x33DCEE0", Offset = "0x33DB4E0", VA = "0x1833DCEE0", Slot = "5")]
	public global::HEHPANGCKGN<T> HHLLDPAMIIN(Action<T> EJMGDMFKEBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x33DCF80", Offset = "0x33DB580", VA = "0x1833DCF80", Slot = "8")]
	public global::HEHPANGCKGN<T> KINADJHJPLD(Action<string> FNDEOCOOEKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x33DCDE0", Offset = "0x33DB3E0", VA = "0x1833DCDE0", Slot = "9")]
	public global::HEHPANGCKGN<T> GDHLAAIGFLM(Action<string> FNDEOCOOEKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x33DD1B0", Offset = "0x33DB7B0", VA = "0x1833DD1B0")]
	public CLNMEFIELJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class LHFLJGKFBFP
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class HFCBLBJKHLO<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public global::HEHPANGCKGN<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public global::FKLAHNHEJJK<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x9587B0", Offset = "0x956DB0", VA = "0x1809587B0")]
		public HFCBLBJKHLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3A242B0", Offset = "0x3A228B0", VA = "0x183A242B0")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x2F945C0", Offset = "0x2F92BC0", VA = "0x182F945C0")]
	public static global::ANHHADAADKH<T> GEANDBLCKKL<T>(this global::HEHPANGCKGN<T> FKFKLGJNFPG, Action<T> CGFIJPDBLBH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public abstract class PGCFIDLAKNF
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class KBKABCOGOGK : PGCFIDLAKNF
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static PGCFIDLAKNF KIFJOHLMIFO
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x4A49030", Offset = "0x4A47630", VA = "0x184A49030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override DateTime LIJFEHOEGMI
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x4A49090", Offset = "0x4A47690", VA = "0x184A49090", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override float MELCFPPCJGC
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x4A46F20", Offset = "0x4A45520", VA = "0x184A46F20", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x4A49180", Offset = "0x4A47780", VA = "0x184A49180")]
		public KBKABCOGOGK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static PGCFIDLAKNF FLBPIJCKJKN;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public static PGCFIDLAKNF NFMMEFOILJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x4A4ADE0", Offset = "0x4A493E0", VA = "0x184A4ADE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public abstract DateTime LIJFEHOEGMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public abstract float MELCFPPCJGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
	protected PGCFIDLAKNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class AGGOEJEPBGB : global::FENOJHBDPJN<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x4A470B0", Offset = "0x4A456B0", VA = "0x184A470B0")]
	public AGGOEJEPBGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class FENOJHBDPJN<T> : global::GKDPHAPDMOD<T>, MEHPEMFLJAA, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public Task<T> DFFMEEAJFJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x5734D0", Offset = "0x571AD0", VA = "0x1805734D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private Task EDCBNNBDBPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xC49920", Offset = "0xC47F20", VA = "0x180C49920", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public global::ANHHADAADKH<T> DHBHOMJFMPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	private FDFGBMEHONB AFDNBPMJPJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xC4B260", Offset = "0xC49860", VA = "0x180C4B260", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x1BA44D0", Offset = "0x1BA2AD0", VA = "0x181BA44D0")]
	public FENOJHBDPJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x513200", Offset = "0x511800", VA = "0x180513200", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class PFDCFKCJNJH : global::DCDNBONCGKK<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AD90", Offset = "0x4A49390", VA = "0x184A4AD90")]
	public PFDCFKCJNJH(Exception OBBHILLKPGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class DCDNBONCGKK<T> : global::GKDPHAPDMOD<T>, MEHPEMFLJAA, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public Task<T> DFFMEEAJFJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5734D0", Offset = "0x571AD0", VA = "0x1805734D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	private Task EDCBNNBDBPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0xC49920", Offset = "0xC47F20", VA = "0x180C49920", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public global::ANHHADAADKH<T> DHBHOMJFMPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	private FDFGBMEHONB AFDNBPMJPJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xC4B260", Offset = "0xC49860", VA = "0x180C4B260", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x32BFCC0", Offset = "0x32BE2C0", VA = "0x1832BFCC0")]
	public DCDNBONCGKK(Exception OBBHILLKPGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x513200", Offset = "0x511800", VA = "0x180513200", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface MEHPEMFLJAA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	[NotNull]
	Task DFFMEEAJFJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	[NotNull]
	FDFGBMEHONB DHBHOMJFMPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface GKDPHAPDMOD<T> : MEHPEMFLJAA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	[NotNull]
	new Task<T> DFFMEEAJFJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	[NotNull]
	new global::ANHHADAADKH<T> DHBHOMJFMPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public abstract class LIFGLCDJMEH<TTask, T> : global::GKDPHAPDMOD<T>, MEHPEMFLJAA, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class BGENJLMBIFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public global::LIFGLCDJMEH<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x9587B0", Offset = "0x956DB0", VA = "0x1809587B0")]
		public BGENJLMBIFK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static bool AGEKMLJNKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly Task<T> IOMIAMDEEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	protected readonly CancellationTokenSource FNDKILALBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private bool PEDKFHFJMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private SynchronizationContext FAJOADDPFFP;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public Task<T> DFFMEEAJFJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x5734D0", Offset = "0x571AD0", VA = "0x1805734D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private Task EDCBNNBDBPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x5734D0", Offset = "0x571AD0", VA = "0x1805734D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public global::ANHHADAADKH<T> DHBHOMJFMPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	private FDFGBMEHONB AFDNBPMJPJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xC4DBE0", Offset = "0xC4C1E0", VA = "0x180C4DBE0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool BBMNKDBHIMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x706230", Offset = "0x704830", VA = "0x180706230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x3A27E90", Offset = "0x3A26490", VA = "0x183A27E90")]
	static LIFGLCDJMEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x3A28170", Offset = "0x3A26770", VA = "0x183A28170")]
	protected LIFGLCDJMEH(TTask IOMIAMDEEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x3A27AC0", Offset = "0x3A260C0", VA = "0x183A27AC0", Slot = "1")]
	~LIFGLCDJMEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x3A279F0", Offset = "0x3A25FF0", VA = "0x183A279F0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x3A27B60", Offset = "0x3A26160", VA = "0x183A27B60")]
	private void OJJBINEMABO(bool PGKDCNBMAPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T CKBFHKHAJAN(TTask EIBBINJMBDM);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void PELBGKFAIHD();

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x3A27E40", Offset = "0x3A26440", VA = "0x183A27E40")]
	[CompilerGenerated]
	private void PMLIDBKJKOC(object CANMLEHJDGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class FDFIGHJIIII : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly Type IDLADALIHGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public readonly string JMHEDDJPOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public readonly bool LKFNDJOJPAD;

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x4A47670", Offset = "0x4A45C70", VA = "0x184A47670")]
	public FDFIGHJIIII(Type PAIPLBBKOFK, string CDKIEDDEJMO, bool GABKKAJCKLB = false)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x52EF70", Offset = "0x52D570", VA = "0x18052EF70")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x58E100", Offset = "0x58C700", VA = "0x18058E100")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public T this[int JGJNFKKDEKE, int KBNDDHCHFCL]
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x330D370", Offset = "0x330B970", VA = "0x18330D370")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x330D410", Offset = "0x330BA10", VA = "0x18330D410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x330D2E0", Offset = "0x330B8E0", VA = "0x18330D2E0")]
		public Array2D(uint OMKIDNPFIFC, uint JEGDAENABFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x330D260", Offset = "0x330B860", VA = "0x18330D260")]
		public void GMBCIADOMKO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x4A47270", Offset = "0x4A45870", VA = "0x184A47270")]
		public Array2DVector3(uint OMKIDNPFIFC, uint JEGDAENABFA)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class HFHENANINMC
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private enum FBHNDALLFKP : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private int HAGHPJEMCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private bool EIPGFNBOEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private FBHNDALLFKP PGKNEBHNAEL;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool APPKFLLLNAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x4A48C80", Offset = "0x4A47280", VA = "0x184A48C80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool KGNFHMOGJDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x4A48620", Offset = "0x4A46C20", VA = "0x184A48620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x4A48D00", Offset = "0x4A47300", VA = "0x184A48D00")]
	public HFHENANINMC(bool EIPGFNBOEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x4A48760", Offset = "0x4A46D60", VA = "0x184A48760")]
	public void MBGDPCGMAOJ(object AIHPMIAHIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x4A48470", Offset = "0x4A46A70", VA = "0x184A48470")]
	public void DCJMCFPLDIF(int BEOHMGPJCII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x4A48610", Offset = "0x4A46C10", VA = "0x184A48610")]
	public void FLNHCMENNEC(uint CHHNBCGMIOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x4A48740", Offset = "0x4A46D40", VA = "0x184A48740")]
	public void KHKIALKNHKA(bool APIHKEDJKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x4A48590", Offset = "0x4A46B90", VA = "0x184A48590")]
	public void ELOEPPGMMMO(long IDMJKCNIJLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x4A485D0", Offset = "0x4A46BD0", VA = "0x184A485D0")]
	public void FFADKIIDMFN(ulong MCMCJJOPEEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x4A48630", Offset = "0x4A46C30", VA = "0x184A48630")]
	public void GBPLGENMOHM(string BLOKNMIMNJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x4A486B0", Offset = "0x4A46CB0", VA = "0x184A486B0")]
	public void IOAKBEPCEDO(Enum OBBHILLKPGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x4A47F20", Offset = "0x4A46520", VA = "0x184A47F20")]
	public void BGOOGGOFLLH(IList HNDGNAECIOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x3601010", Offset = "0x35FF610", VA = "0x183601010")]
	public void KLAKNGNGNAL<T, U>(Dictionary<T, U> PJNNLLIIMAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x4A480B0", Offset = "0x4A466B0", VA = "0x184A480B0")]
	private void DBILKHBBPIJ(IDictionary PJNNLLIIMAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x4A48C90", Offset = "0x4A47290", VA = "0x184A48C90")]
	public int OLLDOJDFMLE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x4A48040", Offset = "0x4A46640", VA = "0x184A48040")]
	public short BIFHFIIDDKD()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x4A486A0", Offset = "0x4A46CA0", VA = "0x184A486A0")]
	public void GMBCIADOMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x4A48520", Offset = "0x4A46B20", VA = "0x184A48520")]
	private void DLDIFCCDNCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public abstract class GOCCHJAMAJA<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	internal class JNEHAANCICK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public TNode NLENMDMFMEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public TNode EPJKFCLNEED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public HFABCCKLCIO NDFGNGKJCPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public List<HFABCCKLCIO> GDFALMEEEAK;

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x9587B0", Offset = "0x956DB0", VA = "0x1809587B0")]
		public JNEHAANCICK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	internal struct HFABCCKLCIO : IComparable<HFABCCKLCIO>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public int NEKFHCJIGIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public TClaimant BGEAENOJLAK;

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x62CB30", Offset = "0x62B130", VA = "0x18062CB30")]
		public HFABCCKLCIO(int NEKFHCJIGIH, TClaimant BGEAENOJLAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x15CD5B0", Offset = "0x15CBBB0", VA = "0x1815CD5B0")]
		public bool DFGDHHDAGPM(in HFABCCKLCIO DBPHKEMCPDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x15CD610", Offset = "0x15CBC10", VA = "0x1815CD610")]
		public bool FHIIGJOLEEM(in HFABCCKLCIO DBPHKEMCPDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x15CD5A0", Offset = "0x15CBBA0", VA = "0x1815CD5A0", Slot = "4")]
		public int CompareTo(HFABCCKLCIO DBPHKEMCPDK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x15CD620", Offset = "0x15CBC20", VA = "0x1815CD620", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public enum EKGEFFKFCNN
	{
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class LNHHFJANDIE : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public global::GOCCHJAMAJA<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xF1C270", Offset = "0xF1A870", VA = "0x180F1C270")]
		[DebuggerHidden]
		public LNHHFJANDIE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x513200", Offset = "0x511800", VA = "0x180513200", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x15CDBA0", Offset = "0x15CC1A0", VA = "0x1815CDBA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x15CDD60", Offset = "0x15CC360", VA = "0x1815CDD60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x15CDC80", Offset = "0x15CC280", VA = "0x1815CDC80", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xC4D3A0", Offset = "0xC4B9A0", VA = "0x180C4D3A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static readonly global::KJNCDANBJDN<JNEHAANCICK> OCEAHNGHPPN;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static readonly global::KJNCDANBJDN<List<HFABCCKLCIO>> CKAJBDFLPCI;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private static int FBAFMNFNHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	internal readonly Dictionary<TClaimant, TNode> FODPJJHOELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	internal readonly Dictionary<TNode, JNEHAANCICK> BDFGBKDABOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private EKGEFFKFCNN JELCBHMLKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private bool HJACELCFJKB;

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode EHHJGLMIMHP(TNode LJEFIDNOOMO);

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void PDGCGLMHIBN(TNode LJEFIDNOOMO, TClaimant KBNOGGBIJKB, TClaimant EMGLAKIGOPN);

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x15CC110", Offset = "0x15CA710", VA = "0x1815CC110")]
	public GOCCHJAMAJA(EKGEFFKFCNN JELCBHMLKHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x15CBDD0", Offset = "0x15CA3D0", VA = "0x1815CBDD0")]
	public void NMKHNGCGJGF(TNode LJEFIDNOOMO, TNode PNNIGCNFMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x15CA8B0", Offset = "0x15C8EB0", VA = "0x1815CA8B0")]
	public void AEHBHPGNAFF(TClaimant BGEAENOJLAK, TNode EILFHGAMPGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x15CB2B0", Offset = "0x15C98B0", VA = "0x1815CB2B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x15CAC80", Offset = "0x15C9280", VA = "0x1815CAC80")]
	private void BMIMKBGJHBL(TClaimant BGEAENOJLAK, TNode IMDOBCFJIIO, TNode EILFHGAMPGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x15CAF90", Offset = "0x15C9590", VA = "0x1815CAF90")]
	private int DGFBCJKNAID()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x15CB000", Offset = "0x15C9600", VA = "0x1815CB000")]
	private void DMIAENCLBJP(TClaimant BGEAENOJLAK, TNode DOPPPFHNDPK, TNode GELNHFOECJC, int COBPGPFFMEH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x15CBE50", Offset = "0x15CA450", VA = "0x1815CBE50")]
	private void OBOEBMLCGHJ(HFABCCKLCIO FCOMFPGOAIC, JNEHAANCICK INHPBAMBLBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x15CAD20", Offset = "0x15C9320", VA = "0x1815CAD20")]
	private void CEKEJHBLFJH(TClaimant BGEAENOJLAK, TNode DOPPPFHNDPK, TNode GELNHFOECJC, int COBPGPFFMEH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x15CB510", Offset = "0x15C9B10", VA = "0x1815CB510")]
	private void EIDBLNLBBEN(HFABCCKLCIO FCOMFPGOAIC, TNode LJEFIDNOOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x15CBA50", Offset = "0x15CA050", VA = "0x1815CBA50")]
	private void GLMALDFAALJ(HFABCCKLCIO FCOMFPGOAIC, JNEHAANCICK INHPBAMBLBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x15CAB40", Offset = "0x15C9140", VA = "0x1815CAB40")]
	private void BKNDANECHIA(JNEHAANCICK INHPBAMBLBL, bool CMMJCHOMKAJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x15CB610", Offset = "0x15C9C10", VA = "0x1815CB610")]
	private void EJIIBNJMBEJ(JNEHAANCICK INHPBAMBLBL, TNode PNNIGCNFMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x15CBEE0", Offset = "0x15CA4E0", VA = "0x1815CBEE0")]
	[IteratorStateMachine(typeof(global::GOCCHJAMAJA<, >.LNHHFJANDIE))]
	private IEnumerable<TNode> PKAPAMMJODL(TNode DOPPPFHNDPK, TNode GELNHFOECJC, bool GEJHNNCDEBJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x15CBD10", Offset = "0x15CA310", VA = "0x1815CBD10")]
	private JNEHAANCICK MOMBJDGGDCH(TNode LJEFIDNOOMO, TNode EPJKFCLNEED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x15CA9B0", Offset = "0x15C8FB0", VA = "0x1815CA9B0")]
	private JNEHAANCICK ANDBHJCPNCE(TNode LJEFIDNOOMO, TNode EPJKFCLNEED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x15CBB50", Offset = "0x15CA150", VA = "0x1815CBB50")]
	private void MNLJGDDGBPB(JNEHAANCICK INHPBAMBLBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class KCDMHGDDOKK<T> : IEnumerable<global::KCDMHGDDOKK<T>.PAEHANGCOHC>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public struct PAEHANGCOHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public T BEOHMGPJCII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public int JGJLGOCHIGF;
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class DBHJMGCDKPF : IEnumerator<PAEHANGCOHC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private global::KCDMHGDDOKK<T> ABEFDNBENGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private int JGJLGOCHIGF;

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x1234260", Offset = "0x1232860", VA = "0x181234260", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public PAEHANGCOHC ONFPNEAPPEE
		{
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x12342D0", Offset = "0x12328D0", VA = "0x1812342D0", Slot = "4")]
			get
			{
				return default(PAEHANGCOHC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xD70440", Offset = "0xD6EA40", VA = "0x180D70440")]
		public DBHJMGCDKPF(global::KCDMHGDDOKK<T> ABEFDNBENGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x12341D0", Offset = "0x12327D0", VA = "0x1812341D0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xC1B590", Offset = "0xC19B90", VA = "0x180C1B590", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0xF922B0", Offset = "0xF908B0", VA = "0x180F922B0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private struct OCPPBHLLJDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public bool ADIKPHPMIHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public T BEOHMGPJCII;
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private const int ALFAOBBLPPA = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private Dictionary<T, int> DOHBICDLLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private OCPPBHLLJDJ[] KFMINOFHGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private int PNHNEJIKKBE;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public int PKIGJFDDAAN
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x1241D00", Offset = "0x1240300", VA = "0x181241D00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x1241EE0", Offset = "0x12404E0", VA = "0x181241EE0")]
	public static global::KCDMHGDDOKK<T> CPOLLKIFDCA(PAEHANGCOHC[] LKKDOEEJKPN, bool CABAPAJOGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x1242940", Offset = "0x1240F40", VA = "0x181242940")]
	public KCDMHGDDOKK(int MLFIIPFKFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0xF0E9C0", Offset = "0xF0CFC0", VA = "0x180F0E9C0")]
	public bool OPGOJGHIBOG(T BEOHMGPJCII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x1242400", Offset = "0x1240A00", VA = "0x181242400")]
	public bool IDCBJKCGEIG(int JGJLGOCHIGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x1241D30", Offset = "0x1240330", VA = "0x181241D30")]
	public bool BNOCOFCGNDC(Func<T, bool> LJOIAMKOOMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x1241DE0", Offset = "0x12403E0", VA = "0x181241DE0")]
	public int CBJADBKJPOK(T BEOHMGPJCII)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x1242340", Offset = "0x1240940", VA = "0x181242340")]
	public T GEANDBLCKKL(int JGJLGOCHIGF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x12423B0", Offset = "0x12409B0", VA = "0x1812423B0")]
	public void GMBCIADOMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x12428A0", Offset = "0x1240EA0", VA = "0x1812428A0")]
	public bool OONNLONGBJM(T BEOHMGPJCII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x1242670", Offset = "0x1240C70", VA = "0x181242670")]
	public bool OONNLONGBJM(T BEOHMGPJCII, int JGJLGOCHIGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x12422C0", Offset = "0x12408C0", VA = "0x1812422C0")]
	public bool FJHOKKOHPIB(T BEOHMGPJCII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x12425D0", Offset = "0x1240BD0", VA = "0x1812425D0")]
	public bool MODGKKLKIEL(int JGJLGOCHIGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x1241E30", Offset = "0x1240430", VA = "0x181241E30")]
	private void CIHANHPALDD(int JGJLGOCHIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x1242460", Offset = "0x1240A60", VA = "0x181242460")]
	public PAEHANGCOHC[] IKLEPMIJODK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x1242620", Offset = "0x1240C20", VA = "0x181242620")]
	private int OGELNDDKLKD(int GKFKJKKLIEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x12428C0", Offset = "0x1240EC0", VA = "0x1812428C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x12428C0", Offset = "0x1240EC0", VA = "0x1812428C0", Slot = "4")]
	private IEnumerator<PAEHANGCOHC> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class KJNCDANBJDN<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private readonly Stack<T> FGKNNIHBMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly List<T> JCNMEGPKOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly int IDDHCCDPHHK;

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public int FKONLJPGJKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x1ABE070", Offset = "0x1ABC670", VA = "0x181ABE070")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int CGKFAFBHONH
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x1ABDAF0", Offset = "0x1ABC0F0", VA = "0x181ABDAF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x1ABDCF0", Offset = "0x1ABC2F0", VA = "0x181ABDCF0")]
	public static global::KJNCDANBJDN<T> HBMMNGDIGMB(int MLFIIPFKFNC = 0, int IDDHCCDPHHK = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x1ABDEF0", Offset = "0x1ABC4F0", VA = "0x181ABDEF0")]
	public static global::KJNCDANBJDN<T> KJABIFADKNB(int MLFIIPFKFNC = 0, int IDDHCCDPHHK = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x1ABE160", Offset = "0x1ABC760", VA = "0x181ABE160")]
	public KJNCDANBJDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x1ABE1A0", Offset = "0x1ABC7A0", VA = "0x181ABE1A0")]
	public KJNCDANBJDN(int MLFIIPFKFNC, int IDDHCCDPHHK = int.MaxValue, bool JBDMIGFNNAM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x1ABDDC0", Offset = "0x1ABC3C0", VA = "0x181ABDDC0")]
	public T IOJBJIOKALP()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x1ABE0A0", Offset = "0x1ABC6A0", VA = "0x181ABE0A0")]
	public void NEGPMDPDHHC(T BEOHMGPJCII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x1ABDC30", Offset = "0x1ABC230", VA = "0x181ABDC30")]
	private void EDCMNNLJDIM(T BEOHMGPJCII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x1ABD810", Offset = "0x1ABBE10", VA = "0x181ABD810")]
	private void AKPOHCBEGBA(T BEOHMGPJCII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x1ABDA50", Offset = "0x1ABC050", VA = "0x181ABDA50")]
	[Conditional("DEBUG_BUILD")]
	private void CLEOAMJONIF(T KFIIKFBJOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x1ABDFC0", Offset = "0x1ABC5C0", VA = "0x181ABDFC0")]
	[Conditional("DEBUG_BUILD")]
	private void MFJKCECDOAO(T KFIIKFBJOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x1ABDB20", Offset = "0x1ABC120", VA = "0x181ABDB20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x1ABD830", Offset = "0x1ABBE30", VA = "0x181ABD830")]
	private void CFHMMJJDNFK(IEnumerable<T> OBEFEEAAPPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class HIGHFHPNJHB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private Dictionary<int, T> FDHHAIMJGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private T LDAILILJGGM;

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public virtual T PAFHEBGDCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x5898D0", Offset = "0x587ED0", VA = "0x1805898D0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public bool HOADMCAFEIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x3F344F0", Offset = "0x3F32AF0", VA = "0x183F344F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x3F34430", Offset = "0x3F32A30", VA = "0x183F34430")]
	public bool BNEBGLDCJNK(T BEOHMGPJCII, int NEKFHCJIGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x3F34590", Offset = "0x3F32B90", VA = "0x183F34590")]
	public bool IDAPPEJNOCP(int NEKFHCJIGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x3F34A00", Offset = "0x3F33000", VA = "0x183F34A00")]
	public T LOANNJLFMAP(int BCBCBCGDCFE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x3F34530", Offset = "0x3F32B30", VA = "0x183F34530")]
	public void GMBCIADOMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x3F34700", Offset = "0x3F32D00", VA = "0x183F34700")]
	private bool LBGLKEOANGI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x3F34400", Offset = "0x3F32A00", VA = "0x183F34400")]
	public bool AGAPKJFBJHE(int NEKFHCJIGIH, out T BEOHMGPJCII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x39B6400", Offset = "0x39B4A00", VA = "0x1839B6400")]
	public HIGHFHPNJHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class LNGMHEGKGPB<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	protected struct HKFMEAEKFLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public T OMBLCGHBLCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public int GJBGOBDPOJO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	protected readonly List<HKFMEAEKFLH> LKMHOBGCKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private T BELDKIPPEEB;

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public int PKIGJFDDAAN
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x15D58C0", Offset = "0x15D3EC0", VA = "0x1815D58C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x3A286E0", Offset = "0x3A26CE0", VA = "0x183A286E0")]
	public bool BNOCOFCGNDC(T BEOHMGPJCII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x3A28D30", Offset = "0x3A27330", VA = "0x183A28D30")]
	public void MEEOIBACLCF(T BEOHMGPJCII, int NEKFHCJIGIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x3A289A0", Offset = "0x3A26FA0", VA = "0x183A289A0")]
	public bool FJHOKKOHPIB(T BEOHMGPJCII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x3A28CD0", Offset = "0x3A272D0", VA = "0x183A28CD0")]
	public void GMBCIADOMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x3A28DD0", Offset = "0x3A273D0", VA = "0x183A28DD0")]
	public T NEPOKMKIPJJ()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x3A28930", Offset = "0x3A26F30", VA = "0x183A28930")]
	public T DGPDLNBBHJK()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x3A28AC0", Offset = "0x3A270C0", VA = "0x183A28AC0")]
	private void FNCBNDDCIHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x3A28E60", Offset = "0x3A27460", VA = "0x183A28E60")]
	public LNGMHEGKGPB()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[SerializeField]
		[EHHJIFONIMG(DPOJEDLGDJE.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x4A4B190", Offset = "0x4A49790", VA = "0x184A4B190")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x4A4B660", Offset = "0x4A49C60", VA = "0x184A4B660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x4A4B480", Offset = "0x4A49A80", VA = "0x184A4B480")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x4A4B800", Offset = "0x4A49E00", VA = "0x184A4B800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x4A4B050", Offset = "0x4A49650", VA = "0x184A4B050")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x4A4B520", Offset = "0x4A49B20", VA = "0x184A4B520")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x4A4B340", Offset = "0x4A49940", VA = "0x184A4B340")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x4A4AFB0", Offset = "0x4A495B0", VA = "0x184A4AFB0")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public interface IOCJOEBLGEE
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public abstract class ResourcePrefabReference<T> : IOCJOEBLGEE where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x3320C30", Offset = "0x331F230", VA = "0x183320C30", Slot = "4")]
		public virtual T KIIDFCHPCIE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x9587B0", Offset = "0x956DB0", VA = "0x1809587B0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class NGPAIKLIOGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<byte, MALDPHCAOLO> EICMDJDKBAH;

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public MALDPHCAOLO KNALLKMGHPI
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x5734D0", Offset = "0x571AD0", VA = "0x1805734D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x513000", Offset = "0x511600", VA = "0x180513000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public Vector2 BMBOCNKIFPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x12CC170", Offset = "0x12CA770", VA = "0x1812CC170")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x1D9FA40", Offset = "0x1D9E040", VA = "0x181D9FA40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public Vector2 HLMKPLNOOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x1DE3480", Offset = "0x1DE1A80", VA = "0x181DE3480")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x2975320", Offset = "0x2973920", VA = "0x182975320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector2 CDJLCCFOCLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x17363E0", Offset = "0x17349E0", VA = "0x1817363E0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x1736400", Offset = "0x1734A00", VA = "0x181736400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public int AAEALOJBIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x67AAA0", Offset = "0x6790A0", VA = "0x18067AAA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x6A0C10", Offset = "0x69F210", VA = "0x1806A0C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x4A4A870", Offset = "0x4A48E70", VA = "0x184A4A870")]
	public NGPAIKLIOGH(Bounds PMKGNEIHLJO, Vector2[] GJDDNIGBDDN, int PIDPGJGAJJA, byte GKFKJKKLIEB, float AAHPKEEIPOL = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x4A4A5D0", Offset = "0x4A48BD0", VA = "0x184A4A5D0")]
	public MALDPHCAOLO CFJPKBLOHMH(byte JGJLGOCHIGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x4A4A760", Offset = "0x4A48D60", VA = "0x184A4A760")]
	public void HCGBNMHNHML(Vector3 FOJIDKMBLHH, float GJPAOCPMDIP, float AKCHHINPLCK, ref List<byte> KBLHBOHEPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x4A4A850", Offset = "0x4A48E50", VA = "0x184A4A850")]
	public void JFFENBEHAOH(MALDPHCAOLO.HFBGGCPIEAG JDEEOAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x4A4A630", Offset = "0x4A48C30", VA = "0x184A4A630")]
	private MALDPHCAOLO CLHKPLOJCHB(byte JGJLGOCHIGF, MALDPHCAOLO.JLDAGOFMFEI HNLLPOMPBFP, MALDPHCAOLO EPJKFCLNEED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x4A4A0B0", Offset = "0x4A486B0", VA = "0x184A4A0B0")]
	private void BBFACIKPHGI(MALDPHCAOLO EPJKFCLNEED, Vector2[] GJDDNIGBDDN, int FBMINJADKNN, int PCCOADHEAHA, int BKAMFGHBIIG, int NDDPFADCNNP, float AAHPKEEIPOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class MALDPHCAOLO
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public enum JLDAGOFMFEI
	{
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public enum HFBGGCPIEAG
	{
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public byte MLBKJECMNHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public Vector3 CAMJEPILPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public Vector3 LFHNEKJHEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public Vector3 PDJCHOIHFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public Vector3 CJOHLPINLNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public JLDAGOFMFEI NLKAGIKOLCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public MALDPHCAOLO FEIHFKLBCMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public List<MALDPHCAOLO> PCLAMABOPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public bool MOKDFMGKGFH;

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x4A49CA0", Offset = "0x4A482A0", VA = "0x184A49CA0")]
	public MALDPHCAOLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x4A49C40", Offset = "0x4A48240", VA = "0x184A49C40")]
	public MALDPHCAOLO(byte BJGDCPLBJEG, JLDAGOFMFEI HNLLPOMPBFP, MALDPHCAOLO EPJKFCLNEED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x4A49B00", Offset = "0x4A48100", VA = "0x184A49B00")]
	public void MHLPCMHJMNM(MALDPHCAOLO DPHMNGHPPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x513200", Offset = "0x511800", VA = "0x180513200")]
	public void JFFENBEHAOH(int BLICKFOFKFP, HFBGGCPIEAG JDEEOAAGEAF, int BOPOMNHEOPH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x4A49870", Offset = "0x4A47E70", VA = "0x184A49870")]
	public void HCGBNMHNHML(List<byte> KBLHBOHEPBK, Vector3 FOJIDKMBLHH, float GJPAOCPMDIP, float AKCHHINPLCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x4A49BE0", Offset = "0x4A481E0", VA = "0x184A49BE0")]
	public bool PHKPGMFLFAE(Vector3 BMBIEOKMECJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x4A49BA0", Offset = "0x4A481A0", VA = "0x184A49BA0")]
	public bool NKCKEJGLIMD(Vector3 BMBIEOKMECJ, float BLMHFKNICKC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class POPDMGOHENO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly Dictionary<T, object> GBCPMMFFMFH;

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0xECA5F0", Offset = "0xEC8BF0", VA = "0x180ECA5F0")]
	public bool NGPEDFMDBPL(T CEGPDOPHINB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x40C1DF0", Offset = "0x40C03F0", VA = "0x1840C1DF0")]
	public bool NGPEDFMDBPL(T CEGPDOPHINB, object FEAIPLKNBKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x40C1E30", Offset = "0x40C0430", VA = "0x1840C1E30")]
	public bool NGPEDFMDBPL(T CEGPDOPHINB, object FEAIPLKNBKH, out object FCGDJPNNCBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x40C1D80", Offset = "0x40C0380", VA = "0x1840C1D80")]
	public bool GJPMAKPNHLC(T CEGPDOPHINB, object FEAIPLKNBKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x40C1E90", Offset = "0x40C0490", VA = "0x1840C1E90")]
	public bool PNOEBLCHEBA(T CEGPDOPHINB, object FEAIPLKNBKH, out object FCGDJPNNCBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x40C1CF0", Offset = "0x40C02F0", VA = "0x1840C1CF0")]
	public bool GJPMAKPNHLC(T CEGPDOPHINB, object FEAIPLKNBKH, out object FCGDJPNNCBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x40C1DC0", Offset = "0x40C03C0", VA = "0x1840C1DC0")]
	public void MHHCIKKMMBK(T CEGPDOPHINB, object FEAIPLKNBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x40C1C50", Offset = "0x40C0250", VA = "0x1840C1C50")]
	public void FCNLNFMDAMN(T CEGPDOPHINB, object FEAIPLKNBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x40C1ED0", Offset = "0x40C04D0", VA = "0x1840C1ED0")]
	public POPDMGOHENO()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		public struct EDCDIHCMEEA<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			private readonly List<Component> HNDGNAECIOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			private readonly bool IHHPGJCMAIM;

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0xE17370", Offset = "0xE15970", VA = "0x180E17370")]
			public EDCDIHCMEEA(List<Component> HNDGNAECIOD, bool IHHPGJCMAIM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x330E340", Offset = "0x330C940", VA = "0x18330E340")]
			public MHJFINJKNGL<T> GGMPPJKPMML()
			{
				return default(MHJFINJKNGL<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x330E3B0", Offset = "0x330C9B0", VA = "0x18330E3B0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x330E3B0", Offset = "0x330C9B0", VA = "0x18330E3B0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public struct MHJFINJKNGL<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			private readonly List<Component> HNDGNAECIOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			private readonly bool IHHPGJCMAIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			private int JGJLGOCHIGF;

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			public T ONFPNEAPPEE
			{
				[Cpp2IlInjected.Token(Token = "0x60002B3")]
				[Cpp2IlInjected.Address(RVA = "0x33167B0", Offset = "0x3314DB0", VA = "0x1833167B0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002B4")]
				[Cpp2IlInjected.Address(RVA = "0x3316740", Offset = "0x3314D40", VA = "0x183316740", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x3316780", Offset = "0x3314D80", VA = "0x183316780")]
			public MHJFINJKNGL(List<Component> HNDGNAECIOD, bool IHHPGJCMAIM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x3316670", Offset = "0x3314C70", VA = "0x183316670", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x3316680", Offset = "0x3314C80", VA = "0x183316680", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x3316730", Offset = "0x3314D30", VA = "0x183316730", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x4A4D4C0", Offset = "0x4A4BAC0", VA = "0x184A4D4C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x4A4D480", Offset = "0x4A4BA80", VA = "0x184A4D480")]
		public ToolHierarchyCache(GameObject CFMGIKIABNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x4A4CCF0", Offset = "0x4A4B2F0", VA = "0x184A4CCF0")]
		private void BAAHEFDHEPF(GameObject CFMGIKIABNI, bool AMNGIMHJGMG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x4A4CC60", Offset = "0x4A4B260", VA = "0x184A4CC60")]
		public static void BAAHEFDHEPF(GameObject CFMGIKIABNI, ref ToolHierarchyCache OIPPJOHJGLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x4A4D270", Offset = "0x4A4B870", VA = "0x184A4D270")]
		public void HJEONDACCHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x4A4D3D0", Offset = "0x4A4B9D0", VA = "0x184A4D3D0")]
		public void KOFHODLMMJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x31C4570", Offset = "0x31C2B70", VA = "0x1831C4570")]
		public void JJFMKAAJCGB<T>(Action<T> EMFPEPGCJKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x4A4D140", Offset = "0x4A4B740", VA = "0x184A4D140")]
		public Component GLPMGIJNJGB(Type FFNKIDPAEGE, bool IHHPGJCMAIM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x2F51D90", Offset = "0x2F50390", VA = "0x182F51D90")]
		public T GLPMGIJNJGB<T>(bool IHHPGJCMAIM = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x4A4D340", Offset = "0x4A4B940", VA = "0x184A4D340")]
		public EDCDIHCMEEA<Component> KMADGOALCKI(Type FFNKIDPAEGE, bool IHHPGJCMAIM = false)
		{
			return default(EDCDIHCMEEA<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x179E560", Offset = "0x179CB60", VA = "0x18179E560")]
		public EDCDIHCMEEA<T> KMADGOALCKI<T>(bool IHHPGJCMAIM = false) where T : class
		{
			return default(EDCDIHCMEEA<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x4A4CE10", Offset = "0x4A4B410", VA = "0x184A4CE10")]
		public List<Component> DJLHOHBCGPG(Type FFNKIDPAEGE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x4A4D0C0", Offset = "0x4A4B6C0", VA = "0x184A4D0C0", Slot = "4")]
		public bool Equals(ToolHierarchyCache NJIPMFDFONJ, ToolHierarchyCache ENLDDEBGJMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x4A4D200", Offset = "0x4A4B800", VA = "0x184A4D200", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache AIHPMIAHIBA)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class PCDACECIIBE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private int MLFIIPFKFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private int CHILFAOKBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private List<T> OGOJAHPAFKG;

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public int PKIGJFDDAAN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x1ABE070", Offset = "0x1ABC670", VA = "0x181ABE070")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public T NNACNHALDDF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x316C150", Offset = "0x316A750", VA = "0x18316C150")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public T EAGGJANCEHN
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x316C530", Offset = "0x316AB30", VA = "0x18316C530")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public T NCMGEDFINDF
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x316C5E0", Offset = "0x316ABE0", VA = "0x18316C5E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x316C630", Offset = "0x316AC30", VA = "0x18316C630")]
	public PCDACECIIBE(int MLFIIPFKFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x316C3F0", Offset = "0x316A9F0", VA = "0x18316C3F0")]
	public void MEEOIBACLCF(T JLPPAGKOGGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x316C270", Offset = "0x316A870", VA = "0x18316C270")]
	public void GMBCIADOMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x316C0B0", Offset = "0x316A6B0", VA = "0x18316C0B0")]
	public void BLMFGHPFPKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x316C2B0", Offset = "0x316A8B0", VA = "0x18316C2B0")]
	public void JLGNNAJHDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x316C300", Offset = "0x316A900", VA = "0x18316C300")]
	public void KDMEDCEFBOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class MGBDHAOKLOD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private bool BHMAEDHEHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private Action EMFPEPGCJKF;

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public static MGBDHAOKLOD AEAMMHEEEAI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x4A49CE0", Offset = "0x4A482E0", VA = "0x184A49CE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public bool KEIHJMFNJKB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x599D90", Offset = "0x598390", VA = "0x180599D90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x913B30", Offset = "0x912130", VA = "0x180913B30")]
	public MGBDHAOKLOD(Action EMFPEPGCJKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x4A49CC0", Offset = "0x4A482C0", VA = "0x184A49CC0")]
	public void FHDFGHEFBIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x4A49CC0", Offset = "0x4A482C0", VA = "0x184A49CC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public static class KMANCKDKHBB
{
	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x513200", Offset = "0x511800", VA = "0x180513200")]
	public static void AHLLALOCIHC(FJLALNGKDPA OKAGNEDEMJB, string MDGBADBDMMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class HMOLNKDIHPI<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private struct KPINPOLEINH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public int GJBGOBDPOJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public T OMBLCGHBLCN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private Dictionary<object, KPINPOLEINH> FDHHAIMJGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private T LDAILILJGGM;

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public virtual T PAFHEBGDCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x12CC170", Offset = "0x12CA770", VA = "0x1812CC170", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x1D9FA40", Offset = "0x1D9E040", VA = "0x181D9FA40", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public bool HOADMCAFEIG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x39B1650", Offset = "0x39AFC50", VA = "0x1839B1650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public object NMJBKKJNAKP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x523CC0", Offset = "0x5222C0", VA = "0x180523CC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x523A10", Offset = "0x522010", VA = "0x180523A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x39B0E70", Offset = "0x39AF470", VA = "0x1839B0E70")]
	public bool BNEBGLDCJNK(T BEOHMGPJCII, object FEAIPLKNBKH, int NEKFHCJIGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x39B16F0", Offset = "0x39AFCF0", VA = "0x1839B16F0")]
	public bool IDAPPEJNOCP(object FEAIPLKNBKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x39B0C30", Offset = "0x39AF230", VA = "0x1839B0C30")]
	public bool AGAPKJFBJHE(object FEAIPLKNBKH, out T BEOHMGPJCII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x33C6B60", Offset = "0x33C5160", VA = "0x1833C6B60")]
	public void GMBCIADOMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x39B2920", Offset = "0x39B0F20", VA = "0x1839B2920")]
	private bool LBGLKEOANGI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x39B6400", Offset = "0x39B4A00", VA = "0x1839B6400")]
	public HMOLNKDIHPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class GOHFOLEJCLH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private Dictionary<object, float> FDHHAIMJGHG;

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public float BMFHLMPIMEO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x750B30", Offset = "0x74F130", VA = "0x180750B30")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x750B40", Offset = "0x74F140", VA = "0x180750B40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x4A47CA0", Offset = "0x4A462A0", VA = "0x184A47CA0")]
	public void BNEBGLDCJNK(float BEOHMGPJCII, object FEAIPLKNBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x4A47E30", Offset = "0x4A46430", VA = "0x184A47E30")]
	public void IDAPPEJNOCP(object FEAIPLKNBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x4A47D10", Offset = "0x4A46310", VA = "0x184A47D10")]
	private void HPNOFOHKMON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x4A47EA0", Offset = "0x4A464A0", VA = "0x184A47EA0")]
	public GOHFOLEJCLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public sealed class FJLALNGKDPA
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class PHCLBNKLFLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private readonly string JFAKDAIGFMN;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
		private PHCLBNKLFLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x57A1E0", Offset = "0x5787E0", VA = "0x18057A1E0")]
		public PHCLBNKLFLO(string JFAKDAIGFMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x4A4AF60", Offset = "0x4A49560", VA = "0x184A4AF60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class AIGHDADHMDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
		public AIGHDADHMDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x4A470F0", Offset = "0x4A456F0", VA = "0x184A470F0")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly HashSet<object> BAECEBKDICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int HBEOGMNHOPK;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public bool PEGFMOMMDJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x4A47810", Offset = "0x4A45E10", VA = "0x184A47810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public int PKIGJFDDAAN
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x535300", Offset = "0x533900", VA = "0x180535300")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x4A47820", Offset = "0x4A45E20", VA = "0x184A47820")]
	public bool MEEOIBACLCF(object FEAIPLKNBKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x4A47730", Offset = "0x4A45D30", VA = "0x184A47730")]
	public bool FJHOKKOHPIB(object FEAIPLKNBKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x4A476D0", Offset = "0x4A45CD0", VA = "0x184A476D0")]
	public bool BNOCOFCGNDC(object FEAIPLKNBKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x4A477B0", Offset = "0x4A45DB0", VA = "0x184A477B0")]
	public void GIEMDKJLDPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x4A478A0", Offset = "0x4A45EA0", VA = "0x184A478A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x4A47A10", Offset = "0x4A46010", VA = "0x184A47A10")]
	public FJLALNGKDPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class JDBNJCPGEEF<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	private struct HLMFEBFOFIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public float DHKGOBANPAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public T OMBLCGHBLCN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private Dictionary<object, HLMFEBFOFIH> FDHHAIMJGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private T GJBDOIOIDFA;

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public virtual T GFPFHALFAHC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x9CF660", Offset = "0x9CDC60", VA = "0x1809CF660", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x33C6B20", Offset = "0x33C5120", VA = "0x1833C6B20", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public object EDDDJKAJJJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x534830", Offset = "0x532E30", VA = "0x180534830")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x534510", Offset = "0x532B10", VA = "0x180534510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public bool HOADMCAFEIG
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x33C6AE0", Offset = "0x33C50E0", VA = "0x1833C6AE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x33C69E0", Offset = "0x33C4FE0", VA = "0x1833C69E0")]
	public bool BNEBGLDCJNK(T BEOHMGPJCII, object FEAIPLKNBKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x33C6B90", Offset = "0x33C5190", VA = "0x1833C6B90")]
	public bool IDAPPEJNOCP(object FEAIPLKNBKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x33C6B60", Offset = "0x33C5160", VA = "0x1833C6B60")]
	public void GMBCIADOMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x33C60D0", Offset = "0x33C46D0", VA = "0x1833C60D0")]
	public bool AGAPKJFBJHE(object FEAIPLKNBKH, out T BEOHMGPJCII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x33C84C0", Offset = "0x33C6AC0", VA = "0x1833C84C0")]
	private bool LBGLKEOANGI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x33C88A0", Offset = "0x33C6EA0", VA = "0x1833C88A0")]
	public JDBNJCPGEEF()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class KKINEKHOKMG
{
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private static byte[] DOJNIBDEPHD;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private static int KFPMCEOFNHF;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private static int FPHJGLDCBHD;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private static BigInteger HMCNEAFPECA;

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
	public KKINEKHOKMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x4A49510", Offset = "0x4A47B10", VA = "0x184A49510")]
	private static string IOLHAJOLOLL(byte[] CGENIFKMPBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x4A491E0", Offset = "0x4A477E0", VA = "0x184A491E0")]
	public static string FFHDEGOGLMA(byte[] LDGCJAPEANM, bool ONIHJAEONNB)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
