using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Mono.Math;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class FBLDJMBFPMO : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x850150", Offset = "0x84ED50", VA = "0x180850150")]
	public FBLDJMBFPMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x16FC6F0", Offset = "0x16FB2F0", VA = "0x1816FC6F0")]
	public byte[] COPOOJEPADI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void LHLFFBAMCNP(IncrementalHash MJMBKIPNMMN);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x61EFF0", Offset = "0x61DBF0", VA = "0x18061EFF0")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000004")]
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
	[MJNBGHJOIIP]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[MJNBGHJOIIP]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x16FF840", Offset = "0x16FE440", VA = "0x1816FF840")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x16FF800", Offset = "0x16FE400", VA = "0x1816FF800")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x16FF880", Offset = "0x16FE480", VA = "0x1816FF880")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x16FFA90", Offset = "0x16FE690", VA = "0x1816FFA90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x16FFA00", Offset = "0x16FE600", VA = "0x1816FFA00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x87C4D0", Offset = "0x87B0D0", VA = "0x18087C4D0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x87C190", Offset = "0x87AD90", VA = "0x18087C190")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x16FF7C0", Offset = "0x16FE3C0", VA = "0x1816FF7C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x16FF970", Offset = "0x16FE570", VA = "0x1816FF970")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x16FF2B0", Offset = "0x16FDEB0", VA = "0x1816FF2B0")]
	public void CopyBounds(SavedExtents DEIAHGDLBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x16FF730", Offset = "0x16FE330", VA = "0x1816FF730")]
	public void SetLocalSpaceBounds(Bounds KJPMCBFLLLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xAE0AA0", Offset = "0xADF6A0", VA = "0x180AE0AA0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x16FF720", Offset = "0x16FE320", VA = "0x1816FF720")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x16FF2E0", Offset = "0x16FDEE0", VA = "0x1816FF2E0")]
	private void KCFOKIOKPNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x16FF4F0", Offset = "0x16FE0F0", VA = "0x1816FF4F0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x16FECF0", Offset = "0x16FD8F0", VA = "0x1816FECF0")]
	public static void CalculateLocalBoundsFor(GameObject HMMABJMEBLO, out Bounds KJPMCBFLLLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x16FEC30", Offset = "0x16FD830", VA = "0x1816FEC30")]
	private static void BBHAENICNCM(Bounds JCHDICMDCKL, Color DILCHLNKBGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x16FF750", Offset = "0x16FE350", VA = "0x1816FF750")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000006")]
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
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x553480", Offset = "0x552080", VA = "0x180553480")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x577BA0", Offset = "0x5767A0", VA = "0x180577BA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x556460", Offset = "0x555060", VA = "0x180556460")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "4")]
	public virtual void IPAOOKJLJKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760490", VA = "0x180761890")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[SerializeField]
	[FBLDJMBFPMO]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x313B9C0", Offset = "0x313A5C0", VA = "0x18313B9C0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x313B500", Offset = "0x313A100", VA = "0x18313B500", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x313BFC0", Offset = "0x313ABC0", VA = "0x18313BFC0")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class PDLLLLPBDEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760490", VA = "0x180761890")]
		public PDLLLLPBDEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3692B60", Offset = "0x3691760", VA = "0x183692B60")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[FBLDJMBFPMO]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x553480", Offset = "0x552080", VA = "0x180553480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x368D600", Offset = "0x368C200", VA = "0x18368D600", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x368D630", Offset = "0x368C230", VA = "0x18368D630", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x368D550", Offset = "0x368C150", VA = "0x18368D550", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public TVal this[TKey GMCMHIFODNN]
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x368D580", Offset = "0x368C180", VA = "0x18368D580", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x368D450", Offset = "0x368C050", VA = "0x18368D450", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x368CCB0", Offset = "0x368B8B0", VA = "0x18368CCB0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x368C620", Offset = "0x368B220", VA = "0x18368C620", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x368C1F0", Offset = "0x368ADF0", VA = "0x18368C1F0", Slot = "14")]
	protected virtual string EFOMBPBCEKF(TKeyVal EGJANNLOLNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x11D3C40", Offset = "0x11D2840", VA = "0x1811D3C40", Slot = "4")]
	public bool ContainsKey(TKey GMCMHIFODNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x368D340", Offset = "0x368BF40", VA = "0x18368D340", Slot = "5")]
	public bool TryGetValue(TKey GMCMHIFODNN, out TVal JHEBJPCMJGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x368C220", Offset = "0x368AE20", VA = "0x18368C220", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x368C220", Offset = "0x368AE20", VA = "0x18368C220", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x368D370", Offset = "0x368BF70", VA = "0x18368D370")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class GDMHBKBFMBG<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class JCBDNEFELAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760490", VA = "0x180761890")]
		public JCBDNEFELAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x12A8C20", Offset = "0x12A7820", VA = "0x1812A8C20")]
		internal bool <GetSamples>b__0(global::KBCNBDEOLGE<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly float JCGICLDGNMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly float AIAHIJOAJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private List<global::KBCNBDEOLGE<float, T>> JJBFKMMPFAC;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int FOOFFGJILLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x12A4140", Offset = "0x12A2D40", VA = "0x1812A4140")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x12A45C0", Offset = "0x12A31C0", VA = "0x1812A45C0")]
	public GDMHBKBFMBG(float KIDIDDPCCGH, float IKPKELFGJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x12A4240", Offset = "0x12A2E40", VA = "0x1812A4240")]
	public bool KMBCFLALAFB(float HAENLLDICJI, T JHEBJPCMJGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x12A3A30", Offset = "0x12A2630", VA = "0x1812A3A30")]
	public int EABKALFLJCN(float HAENLLDICJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x12A3DD0", Offset = "0x12A29D0", VA = "0x1812A3DD0")]
	public IEnumerable<T> GIHGIAIEJDA(float HAENLLDICJI, [Optional] float? OFEDBFCHBBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x12A4110", Offset = "0x12A2D10", VA = "0x1812A4110")]
	public void IJBCCCJHCJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x12A4500", Offset = "0x12A3100", VA = "0x1812A4500")]
	private void ONJBEFOMOJC(float HAENLLDICJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class LGEJOEANJBP<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct BGGIFKOHAJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public T EFFCIDNMALB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float DEPAJLEIJPC;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static float CONLEABJPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private List<T> FIHLPCMEMGE;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private const int AAOEDEAJAGK = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private BGGIFKOHAJC[] BBFDALJHIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int FEDBBOIAHKL;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float GKKKEAPMBHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6FE6D0", Offset = "0x6FD2D0", VA = "0x1806FE6D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6FE7A0", Offset = "0x6FD3A0", VA = "0x1806FE7A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x42825F0", Offset = "0x42811F0", VA = "0x1842825F0")]
	public LGEJOEANJBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4282620", Offset = "0x4281220", VA = "0x184282620")]
	public LGEJOEANJBP(int CFIGNJHENGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x42811B0", Offset = "0x427FDB0", VA = "0x1842811B0")]
	public void DLPDCPCMKFM(float HAENLLDICJI, T JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4281E80", Offset = "0x4280A80", VA = "0x184281E80")]
	public void IJBCCCJHCJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4281370", Offset = "0x427FF70", VA = "0x184281370")]
	public bool FMLFKNGNHOA(float MOIMIPECGCE, float HABANIDLGCO, out T JHEBJPCMJGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4282430", Offset = "0x4281030", VA = "0x184282430")]
	public bool OOANMLADJKK(float MOIMIPECGCE, float HABANIDLGCO, out T JHEBJPCMJGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4281A60", Offset = "0x4280660", VA = "0x184281A60")]
	public void FPLOBBHECLI(float MOIMIPECGCE, float HABANIDLGCO, List<T> KPKLOHHPHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x42810C0", Offset = "0x427FCC0", VA = "0x1842810C0")]
	private int ADEMJMCGOJM(int NHCBDFFCONB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4281CF0", Offset = "0x42808F0", VA = "0x184281CF0")]
	private void GBBKGNFAINC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T AFIIBLBLILE();

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T ELMDFCLADLG(T CPEDHIPPHNM, T DPHKKMEJFLG, float BMKMABBLJGA);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T KDLCJIDBKHC(T JHEBJPCMJGD, float BMKMABBLJGA);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T FICEMNKMHHM(T CPEDHIPPHNM, T DPHKKMEJFLG);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T KGADKJMFJKL(T CPEDHIPPHNM, T DPHKKMEJFLG);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class MJAOIMHLKKH : global::LGEJOEANJBP<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x16FCE60", Offset = "0x16FBA60", VA = "0x1816FCE60", Slot = "4")]
	protected override Vector3 AFIIBLBLILE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x16FCED0", Offset = "0x16FBAD0", VA = "0x1816FCED0", Slot = "5")]
	protected override Vector3 ELMDFCLADLG(Vector3 CPEDHIPPHNM, Vector3 DPHKKMEJFLG, float BMKMABBLJGA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x16FD040", Offset = "0x16FBC40", VA = "0x1816FD040", Slot = "6")]
	protected override Vector3 KDLCJIDBKHC(Vector3 JHEBJPCMJGD, float BMKMABBLJGA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x16FCF90", Offset = "0x16FBB90", VA = "0x1816FCF90", Slot = "7")]
	protected override Vector3 FICEMNKMHHM(Vector3 CPEDHIPPHNM, Vector3 DPHKKMEJFLG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x16FD0E0", Offset = "0x16FBCE0", VA = "0x1816FD0E0", Slot = "8")]
	protected override Vector3 KGADKJMFJKL(Vector3 CPEDHIPPHNM, Vector3 DPHKKMEJFLG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x16FD150", Offset = "0x16FBD50", VA = "0x1816FD150")]
	public MJAOIMHLKKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class GPDDCLPOOGF : global::LGEJOEANJBP<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x16FC620", Offset = "0x16FB220", VA = "0x1816FC620")]
	public GPDDCLPOOGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x16FC680", Offset = "0x16FB280", VA = "0x1816FC680")]
	public GPDDCLPOOGF(int CFIGNJHENGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6F4230", Offset = "0x6F2E30", VA = "0x1806F4230", Slot = "4")]
	protected override float AFIIBLBLILE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x16FC580", Offset = "0x16FB180", VA = "0x1816FC580", Slot = "5")]
	protected override float ELMDFCLADLG(float CPEDHIPPHNM, float DPHKKMEJFLG, float BMKMABBLJGA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1359D40", Offset = "0x1358940", VA = "0x181359D40", Slot = "6")]
	protected override float KDLCJIDBKHC(float JHEBJPCMJGD, float BMKMABBLJGA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x16FC600", Offset = "0x16FB200", VA = "0x1816FC600", Slot = "7")]
	protected override float FICEMNKMHHM(float CPEDHIPPHNM, float DPHKKMEJFLG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x16FC610", Offset = "0x16FB210", VA = "0x1816FC610", Slot = "8")]
	protected override float KGADKJMFJKL(float CPEDHIPPHNM, float DPHKKMEJFLG)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class OLOCLIOHHPH
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x26B6F60", Offset = "0x26B5B60", VA = "0x1826B6F60")]
	public static global::EGBLEHLIJEK<T1> JFONNKANKPC<T1>(T1 IALEHHJEBIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x276D580", Offset = "0x276C180", VA = "0x18276D580")]
	public static global::KBCNBDEOLGE<T1, T2> JFONNKANKPC<T1, T2>(T1 IALEHHJEBIK, T2 MGPMFBCIBHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2F27EE0", Offset = "0x2F26AE0", VA = "0x182F27EE0")]
	public static global::ONFBNLPCMBK<T1, T2, T3> JFONNKANKPC<T1, T2, T3>(T1 IALEHHJEBIK, T2 MGPMFBCIBHC, T3 GNLCCAFFCDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2768210", Offset = "0x2766E10", VA = "0x182768210")]
	public static global::PHGAFEECOOJ<T1, T2, T3, T4> JFONNKANKPC<T1, T2, T3, T4>(T1 IALEHHJEBIK, T2 MGPMFBCIBHC, T3 GNLCCAFFCDP, T4 BNHAAAIJFFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x289E5E0", Offset = "0x289D1E0", VA = "0x18289E5E0")]
	public static global::BDDPPKMNBPM<T1, T2, T3, T4, T5> JFONNKANKPC<T1, T2, T3, T4, T5>(T1 IALEHHJEBIK, T2 MGPMFBCIBHC, T3 GNLCCAFFCDP, T4 BNHAAAIJFFG, T5 CKBJOEINDAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2F27F70", Offset = "0x2F26B70", VA = "0x182F27F70")]
	public static global::PMECFBLDNEI<T1, T2, T3, T4, T5, T6> JFONNKANKPC<T1, T2, T3, T4, T5, T6>(T1 IALEHHJEBIK, T2 MGPMFBCIBHC, T3 GNLCCAFFCDP, T4 BNHAAAIJFFG, T5 CKBJOEINDAO, T6 FPINPLEFGGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x276D6C0", Offset = "0x276C2C0", VA = "0x18276D6C0")]
	public static global::KCIEAFBAMAH<T1, T2, T3, T4, T5, T6, T7> JFONNKANKPC<T1, T2, T3, T4, T5, T6, T7>(T1 IALEHHJEBIK, T2 MGPMFBCIBHC, T3 GNLCCAFFCDP, T4 BNHAAAIJFFG, T5 CKBJOEINDAO, T6 FPINPLEFGGK, T7 AEPKCMLIDNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x276D5F0", Offset = "0x276C1F0", VA = "0x18276D5F0")]
	public static global::JLCKKAPBDLB<T1, T2, T3, T4, T5, T6, T7, T8> JFONNKANKPC<T1, T2, T3, T4, T5, T6, T7, T8>(T1 IALEHHJEBIK, T2 MGPMFBCIBHC, T3 GNLCCAFFCDP, T4 BNHAAAIJFFG, T5 CKBJOEINDAO, T6 FPINPLEFGGK, T7 AEPKCMLIDNE, T8 BICEMKNPJBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x23C8B20", Offset = "0x23C7720", VA = "0x1823C8B20")]
	[IteratorStateMachine(typeof(DKHOLLGOJCF))]
	public static IEnumerable<global::KBCNBDEOLGE<T1, T2>> NLPAOLNBDBJ<T1, T2>(IEnumerable<T1> FIJKOPICOJA, IEnumerable<T2> JCHDICMDCKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x25F3C20", Offset = "0x25F2820", VA = "0x1825F3C20")]
	[IteratorStateMachine(typeof(BLKPPJPFJHB))]
	public static IEnumerable<global::ONFBNLPCMBK<T1, T2, T3>> NLPAOLNBDBJ<T1, T2, T3>(IEnumerable<T1> FIJKOPICOJA, IEnumerable<T2> JCHDICMDCKL, IEnumerable<T3> DILCHLNKBGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x16FE310", Offset = "0x16FCF10", VA = "0x1816FE310")]
	internal static int GPOHLMBCJEP(int CNPLILINDPK, int LJHCOBNMBPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x16FE2E0", Offset = "0x16FCEE0", VA = "0x1816FE2E0")]
	internal static int GPOHLMBCJEP(int CNPLILINDPK, int LJHCOBNMBPF, int OJPIEANHMNB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x16FE2C0", Offset = "0x16FCEC0", VA = "0x1816FE2C0")]
	internal static int GPOHLMBCJEP(int CNPLILINDPK, int LJHCOBNMBPF, int OJPIEANHMNB, int OMDPKHGDFHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x16FE2A0", Offset = "0x16FCEA0", VA = "0x1816FE2A0")]
	internal static int GPOHLMBCJEP(int CNPLILINDPK, int LJHCOBNMBPF, int OJPIEANHMNB, int OMDPKHGDFHL, int HBOCCNDIMKI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x16FE2F0", Offset = "0x16FCEF0", VA = "0x1816FE2F0")]
	internal static int GPOHLMBCJEP(int CNPLILINDPK, int LJHCOBNMBPF, int OJPIEANHMNB, int OMDPKHGDFHL, int HBOCCNDIMKI, int NBMPBPOHAEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x16FE270", Offset = "0x16FCE70", VA = "0x1816FE270")]
	internal static int GPOHLMBCJEP(int CNPLILINDPK, int LJHCOBNMBPF, int OJPIEANHMNB, int OMDPKHGDFHL, int HBOCCNDIMKI, int NBMPBPOHAEH, int BONCEOCACJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x16FE320", Offset = "0x16FCF20", VA = "0x1816FE320")]
	internal static int GPOHLMBCJEP(int CNPLILINDPK, int LJHCOBNMBPF, int OJPIEANHMNB, int OMDPKHGDFHL, int HBOCCNDIMKI, int NBMPBPOHAEH, int BONCEOCACJO, int AHDDFNNKIML)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class EGBLEHLIJEK<T1> : IComparable<global::EGBLEHLIJEK<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T1 AFKMNPBKFBM;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x825910", Offset = "0x824510", VA = "0x180825910")]
	public EGBLEHLIJEK(T1 IALEHHJEBIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x363A8D0", Offset = "0x36394D0", VA = "0x18363A8D0", Slot = "4")]
	public int CompareTo(global::EGBLEHLIJEK<T1> DEIAHGDLBHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x363A940", Offset = "0x3639540", VA = "0x18363A940", Slot = "0")]
	public override bool Equals(object DEIAHGDLBHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x9A6490", Offset = "0x9A5090", VA = "0x1809A6490", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x363A9E0", Offset = "0x36395E0", VA = "0x18363A9E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class KBCNBDEOLGE<T1, T2> : IComparable<global::KBCNBDEOLGE<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T1 AFKMNPBKFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T2 ALFPDBLAOKI;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x14A4A10", Offset = "0x14A3610", VA = "0x1814A4A10")]
	public KBCNBDEOLGE(T1 IALEHHJEBIK, T2 MGPMFBCIBHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x14A2DC0", Offset = "0x14A19C0", VA = "0x1814A2DC0", Slot = "4")]
	public int CompareTo(global::KBCNBDEOLGE<T1, T2> DEIAHGDLBHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x14A32A0", Offset = "0x14A1EA0", VA = "0x1814A32A0", Slot = "0")]
	public override bool Equals(object DEIAHGDLBHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x14A3EA0", Offset = "0x14A2AA0", VA = "0x1814A3EA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x14A4720", Offset = "0x14A3320", VA = "0x1814A4720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ONFBNLPCMBK<T1, T2, T3> : IComparable<global::ONFBNLPCMBK<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 AFKMNPBKFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 ALFPDBLAOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T3 CPCMFONIOBE;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2972100", Offset = "0x2970D00", VA = "0x182972100")]
	public ONFBNLPCMBK(T1 IALEHHJEBIK, T2 MGPMFBCIBHC, T3 GNLCCAFFCDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2971920", Offset = "0x2970520", VA = "0x182971920", Slot = "4")]
	public int CompareTo(global::ONFBNLPCMBK<T1, T2, T3> DEIAHGDLBHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2971B20", Offset = "0x2970720", VA = "0x182971B20", Slot = "0")]
	public override bool Equals(object DEIAHGDLBHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2971D80", Offset = "0x2970980", VA = "0x182971D80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2971F70", Offset = "0x2970B70", VA = "0x182971F70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class PHGAFEECOOJ<T1, T2, T3, T4> : IComparable<global::PHGAFEECOOJ<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T1 AFKMNPBKFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T2 ALFPDBLAOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T3 CPCMFONIOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T4 KBDLKKEBDHG;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0xEEBD80", Offset = "0xEEA980", VA = "0x180EEBD80")]
	public PHGAFEECOOJ(T1 IALEHHJEBIK, T2 MGPMFBCIBHC, T3 GNLCCAFFCDP, T4 BNHAAAIJFFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3729940", Offset = "0x3728540", VA = "0x183729940", Slot = "4")]
	public int CompareTo(global::PHGAFEECOOJ<T1, T2, T3, T4> DEIAHGDLBHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3729A80", Offset = "0x3728680", VA = "0x183729A80", Slot = "0")]
	public override bool Equals(object DEIAHGDLBHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3729BA0", Offset = "0x37287A0", VA = "0x183729BA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3729C60", Offset = "0x3728860", VA = "0x183729C60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class BDDPPKMNBPM<T1, T2, T3, T4, T5> : IComparable<global::BDDPPKMNBPM<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T1 AFKMNPBKFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T2 ALFPDBLAOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T3 CPCMFONIOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T4 KBDLKKEBDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T5 JMKPMPKIAML;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1601330", Offset = "0x15FFF30", VA = "0x181601330")]
	public BDDPPKMNBPM(T1 IALEHHJEBIK, T2 MGPMFBCIBHC, T3 GNLCCAFFCDP, T4 BNHAAAIJFFG, T5 CKBJOEINDAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x40105E0", Offset = "0x400F1E0", VA = "0x1840105E0", Slot = "4")]
	public int CompareTo(global::BDDPPKMNBPM<T1, T2, T3, T4, T5> DEIAHGDLBHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4010760", Offset = "0x400F360", VA = "0x184010760", Slot = "0")]
	public override bool Equals(object DEIAHGDLBHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x40108A0", Offset = "0x400F4A0", VA = "0x1840108A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x40109A0", Offset = "0x400F5A0", VA = "0x1840109A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class PMECFBLDNEI<T1, T2, T3, T4, T5, T6> : IComparable<global::PMECFBLDNEI<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T1 AFKMNPBKFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T2 ALFPDBLAOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T3 CPCMFONIOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T4 KBDLKKEBDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T5 JMKPMPKIAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T6 ICFMBAMNAEO;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1602EC0", Offset = "0x1601AC0", VA = "0x181602EC0")]
	public PMECFBLDNEI(T1 IALEHHJEBIK, T2 MGPMFBCIBHC, T3 GNLCCAFFCDP, T4 BNHAAAIJFFG, T5 CKBJOEINDAO, T6 FPINPLEFGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x372F260", Offset = "0x372DE60", VA = "0x18372F260", Slot = "4")]
	public int CompareTo(global::PMECFBLDNEI<T1, T2, T3, T4, T5, T6> DEIAHGDLBHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x372F420", Offset = "0x372E020", VA = "0x18372F420", Slot = "0")]
	public override bool Equals(object DEIAHGDLBHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x372F590", Offset = "0x372E190", VA = "0x18372F590", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x372F6B0", Offset = "0x372E2B0", VA = "0x18372F6B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class KCIEAFBAMAH<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::KCIEAFBAMAH<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T1 AFKMNPBKFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T2 ALFPDBLAOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T3 CPCMFONIOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T4 KBDLKKEBDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T5 JMKPMPKIAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T6 ICFMBAMNAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T7 NDJEDGAOCCK;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x14A53F0", Offset = "0x14A3FF0", VA = "0x1814A53F0")]
	public KCIEAFBAMAH(T1 IALEHHJEBIK, T2 MGPMFBCIBHC, T3 GNLCCAFFCDP, T4 BNHAAAIJFFG, T5 CKBJOEINDAO, T6 FPINPLEFGGK, T7 AEPKCMLIDNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x14A4D90", Offset = "0x14A3990", VA = "0x1814A4D90", Slot = "4")]
	public int CompareTo(global::KCIEAFBAMAH<T1, T2, T3, T4, T5, T6, T7> DEIAHGDLBHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x14A4F90", Offset = "0x14A3B90", VA = "0x1814A4F90", Slot = "0")]
	public override bool Equals(object DEIAHGDLBHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x14A5130", Offset = "0x14A3D30", VA = "0x1814A5130", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x14A5280", Offset = "0x14A3E80", VA = "0x1814A5280", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class JLCKKAPBDLB<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::JLCKKAPBDLB<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T1 AFKMNPBKFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T2 ALFPDBLAOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T3 CPCMFONIOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T4 KBDLKKEBDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T5 JMKPMPKIAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T6 ICFMBAMNAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T7 NDJEDGAOCCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T8 AOMOMHILOJK;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0xEECC10", Offset = "0xEEB810", VA = "0x180EECC10")]
	public JLCKKAPBDLB(T1 IALEHHJEBIK, T2 MGPMFBCIBHC, T3 GNLCCAFFCDP, T4 BNHAAAIJFFG, T5 CKBJOEINDAO, T6 FPINPLEFGGK, T7 AEPKCMLIDNE, T8 BICEMKNPJBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0xEEC500", Offset = "0xEEB100", VA = "0x180EEC500", Slot = "4")]
	public int CompareTo(global::JLCKKAPBDLB<T1, T2, T3, T4, T5, T6, T7, T8> DEIAHGDLBHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0xEEC750", Offset = "0xEEB350", VA = "0x180EEC750", Slot = "0")]
	public override bool Equals(object DEIAHGDLBHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0xEEC910", Offset = "0xEEB510", VA = "0x180EEC910", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0xEECA80", Offset = "0xEEB680", VA = "0x180EECA80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
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
	public T EFFCIDNMALB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x552A10", Offset = "0x551610", VA = "0x180552A10")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6131E0", Offset = "0x611DE0", VA = "0x1806131E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float KKBDILDAMGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6548D0", Offset = "0x6534D0", VA = "0x1806548D0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4044090", Offset = "0x4042C90", VA = "0x184044090")]
	public T OLPDILAHMPM(float BMKMABBLJGA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4043E70", Offset = "0x4042A70", VA = "0x184043E70")]
	public T ACDLLIKNNJA(float BMKMABBLJGA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T ELMDFCLADLG(T CPEDHIPPHNM, T DPHKKMEJFLG, float BMKMABBLJGA);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760490", VA = "0x180761890")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x16FBF90", Offset = "0x16FAB90", VA = "0x1816FBF90", Slot = "4")]
	protected override float ELMDFCLADLG(float CPEDHIPPHNM, float DPHKKMEJFLG, float BMKMABBLJGA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x16FC010", Offset = "0x16FAC10", VA = "0x1816FC010")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x1700A10", Offset = "0x16FF610", VA = "0x181700A10", Slot = "4")]
	protected override Vector3 ELMDFCLADLG(Vector3 CPEDHIPPHNM, Vector3 DPHKKMEJFLG, float BMKMABBLJGA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x1700AD0", Offset = "0x16FF6D0", VA = "0x181700AD0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x16FA440", Offset = "0x16F9040", VA = "0x1816FA440", Slot = "4")]
	protected override Color ELMDFCLADLG(Color CPEDHIPPHNM, Color DPHKKMEJFLG, float BMKMABBLJGA)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x16FA490", Offset = "0x16F9090", VA = "0x1816FA490")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[DefaultMember("Item")]
public sealed class FFHJNAFLBCE<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly NOALDPMAPLB ODFGCOIHKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private T[] PKKIIGJJFPA;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int IAPBBGBICKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x5779B0", Offset = "0x5765B0", VA = "0x1805779B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x62A0D0", Offset = "0x628CD0", VA = "0x18062A0D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T KHCFJKNJCLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x12CF9C0", Offset = "0x12CE5C0", VA = "0x1812CF9C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x12CEC80", Offset = "0x12CD880", VA = "0x1812CEC80")]
	public static global::FFHJNAFLBCE<T> EEJCKKCGPGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x12CE4F0", Offset = "0x12CD0F0", VA = "0x1812CE4F0")]
	public static global::FFHJNAFLBCE<T> BNLLCAIAMGH(int EAAJKPJKHNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x12CFC60", Offset = "0x12CE860", VA = "0x1812CFC60")]
	private FFHJNAFLBCE(T[] NLKNELKBMLG, int EAAJKPJKHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x12CEC00", Offset = "0x12CD800", VA = "0x1812CEC00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x12CE910", Offset = "0x12CD510", VA = "0x1812CE910")]
	public void DLPDCPCMKFM(in T JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x12CF860", Offset = "0x12CE460", VA = "0x1812CF860")]
	public void HFLIJOGBHNO(int KMCFICBBFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x12CF320", Offset = "0x12CDF20", VA = "0x1812CF320")]
	public void FPHIDOPNOAO(int CFIGNJHENGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x12CFA40", Offset = "0x12CE640", VA = "0x1812CFA40")]
	private void OOIGHFKJAGF(int EAAJKPJKHNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class FAIJJMMPJHM
{
	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x289CB80", Offset = "0x289B780", VA = "0x18289CB80")]
	public static global::FFHJNAFLBCE<T> EEJCKKCGPGE<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x26BC6E0", Offset = "0x26BB2E0", VA = "0x1826BC6E0")]
	public static global::FFHJNAFLBCE<T> BNLLCAIAMGH<T>(int EAAJKPJKHNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct LOAGLCFNAKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<BDOJJEFHALN>> LLFBEAHMHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int JCHKHGKAAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int EDMODGILCOG;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0xB4BDC0", Offset = "0xB4A9C0", VA = "0x180B4BDC0")]
	private LOAGLCFNAKC(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<BDOJJEFHALN>> KEEIJJOIKNI, int JAOGIPJOIJN, int LOPJAFGHKAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x16FCB70", Offset = "0x16FB770", VA = "0x1816FCB70")]
	public static LOAGLCFNAKC EEJCKKCGPGE()
	{
		return default(LOAGLCFNAKC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x16FCBF0", Offset = "0x16FB7F0", VA = "0x1816FCBF0")]
	public (int, int, Task) HGIEBDGELJA(int GKPALPCHPGC)
	{
		return default((int, int, Task));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x16FCAC0", Offset = "0x16FB6C0", VA = "0x1816FCAC0")]
	public void DJCAKMOEGDB(int GKPALPCHPGC, int LOPJAFGHKAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class BIBGABBMMPO<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly Dictionary<TKey, TVal> FCPIADNBLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly Dictionary<TVal, TKey> HDCCOHOBDKM;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int IAPBBGBICKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x761860", Offset = "0x760460", VA = "0x180761860", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool APOIGGCKAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x577B90", Offset = "0x576790", VA = "0x180577B90", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public ICollection<TKey> OEDAOHBDPEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x762560", Offset = "0x761160", VA = "0x180762560", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TVal> KHEFGAPPPDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x1009F40", Offset = "0x1008B40", VA = "0x181009F40", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public TVal KHCFJKNJCLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x142E890", Offset = "0x142D490", VA = "0x18142E890", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xEEB490", Offset = "0xEEA090", VA = "0x180EEB490", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TKey KHCFJKNJCLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x3987350", Offset = "0x3985F50", VA = "0x183987350")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x3987050", Offset = "0x3985C50", VA = "0x183987050")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3986D60", Offset = "0x3985960", VA = "0x183986D60", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x39873E0", Offset = "0x3985FE0", VA = "0x1839873E0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x29982A0", Offset = "0x2996EA0", VA = "0x1829982A0", Slot = "9")]
	public void Add(TKey GMCMHIFODNN, TVal JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3986A00", Offset = "0x3985600", VA = "0x183986A00", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> ALMNLLOIKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x138B160", Offset = "0x1389D60", VA = "0x18138B160", Slot = "8")]
	public bool ContainsKey(TKey GMCMHIFODNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3986DF0", Offset = "0x39859F0", VA = "0x183986DF0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> ALMNLLOIKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3987380", Offset = "0x3985F80", VA = "0x183987380", Slot = "10")]
	public bool Remove(TKey GMCMHIFODNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3987380", Offset = "0x3985F80", VA = "0x183987380", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> ALMNLLOIKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1009D00", Offset = "0x1008900", VA = "0x181009D00", Slot = "11")]
	public bool TryGetValue(TKey GMCMHIFODNN, out TVal JHEBJPCMJGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3986FD0", Offset = "0x3985BD0", VA = "0x183986FD0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3986E20", Offset = "0x3985A20", VA = "0x183986E20", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] BBFDALJHIIP, int APNFPBAMMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3986EF0", Offset = "0x3985AF0", VA = "0x183986EF0")]
	public void DLPDCPCMKFM(TVal LEJMLBJOPAG, TKey GMCMHIFODNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3986F30", Offset = "0x3985B30", VA = "0x183986F30")]
	public void DLPDCPCMKFM(KeyValuePair<TVal, TKey> ALMNLLOIKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3987210", Offset = "0x3985E10", VA = "0x183987210")]
	public bool KMGMCJBOOIA(TVal GMCMHIFODNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3986F70", Offset = "0x3985B70", VA = "0x183986F70")]
	public bool FCKGFBCLJGJ(KeyValuePair<TVal, TKey> ALMNLLOIKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0xEEBBC0", Offset = "0xEEA7C0", VA = "0x180EEBBC0")]
	public bool AFEKNPNIBII(TVal GMCMHIFODNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0xEEBBC0", Offset = "0xEEA7C0", VA = "0x180EEBBC0")]
	public bool AFEKNPNIBII(KeyValuePair<TVal, TKey> ALMNLLOIKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x39870D0", Offset = "0x3985CD0", VA = "0x1839870D0")]
	public bool ICGEJEGNFAB(TVal GMCMHIFODNN, out TKey JHEBJPCMJGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3986950", Offset = "0x3985550", VA = "0x183986950")]
	public IEnumerator<KeyValuePair<TVal, TKey>> AAAMKAMPDKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3987190", Offset = "0x3985D90", VA = "0x183987190")]
	private void IOJMBCLAGJN(TKey GMCMHIFODNN, TVal LEJMLBJOPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x39872D0", Offset = "0x3985ED0", VA = "0x1839872D0")]
	private void MBJHPINFIOO(TKey GMCMHIFODNN, TVal LEJMLBJOPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3986CA0", Offset = "0x39858A0", VA = "0x183986CA0")]
	private bool COPOMAMCFJG(TKey GMCMHIFODNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3986B20", Offset = "0x3985720", VA = "0x183986B20")]
	private bool COPOMAMCFJG(TVal LEJMLBJOPAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3987480", Offset = "0x3986080", VA = "0x183987480")]
	public BIBGABBMMPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[DefaultMember("Item")]
public class DPPBNMMKJHE<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private global::DPPBNMMKJHE<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x6FE6D0", Offset = "0x6FD2D0", VA = "0x1806FE6D0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x32E54B0", Offset = "0x32E40B0", VA = "0x1832E54B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x32E58B0", Offset = "0x32E44B0", VA = "0x1832E58B0")]
		public Enumerator(global::DPPBNMMKJHE<T> KPKLOHHPHLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x32E50F0", Offset = "0x32E3CF0", VA = "0x1832E50F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x32E52C0", Offset = "0x32E3EC0", VA = "0x1832E52C0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x32E4CC0", Offset = "0x32E38C0", VA = "0x1832E4CC0")]
		private void IIFPMDMKOIN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private T[] NAICNCLLFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int NJKMJOGIJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private int KJMKIECFAHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private int KPEOHEHDBEF;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int IAPBBGBICKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x32DA100", Offset = "0x32D8D00", VA = "0x1832DA100")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public T KHCFJKNJCLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x32D9FC0", Offset = "0x32D8BC0", VA = "0x1832D9FC0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x32D87A0", Offset = "0x32D73A0", VA = "0x1832D87A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x32DA330", Offset = "0x32D8F30", VA = "0x1832DA330")]
	public DPPBNMMKJHE(int EAAJKPJKHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x32D8340", Offset = "0x32D6F40", VA = "0x1832D8340")]
	public void DLPDCPCMKFM(T BMKMABBLJGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x32D9BF0", Offset = "0x32D87F0", VA = "0x1832D9BF0")]
	public void NBEFAJODKCF(IEnumerable<T> ONFNEDGHCAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x32D8820", Offset = "0x32D7420", VA = "0x1832D8820")]
	public void IJBCCCJHCJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x32DA070", Offset = "0x32D8C70", VA = "0x1832DA070")]
	public void OAAOCKGGMLL(int PMKGCDLMBFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x32D82B0", Offset = "0x32D6EB0", VA = "0x1832D82B0")]
	public void CMFDEDGLEMJ(int PMKGCDLMBFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x32D8DC0", Offset = "0x32D79C0", VA = "0x1832D8DC0")]
	public void LCHCBJDOGKH(T[] BBFDALJHIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x32D8960", Offset = "0x32D7560", VA = "0x1832D8960")]
	public Enumerator KOBMKMHPKIK()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x32DA140", Offset = "0x32D8D40", VA = "0x1832DA140", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x32DA140", Offset = "0x32D8D40", VA = "0x1832DA140", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x32D91E0", Offset = "0x32D7DE0", VA = "0x1832D91E0")]
	private int LHCNIDEDOHA(int KMCFICBBFCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x32D8840", Offset = "0x32D7440", VA = "0x1832D8840")]
	private int JPBKMHLMPPH(int KMCFICBBFCD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct AJNOKDHGLKN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly IDisposable[] PKKIIGJJFPA;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x7AD320", Offset = "0x7ABF20", VA = "0x1807AD320")]
	public AJNOKDHGLKN(params IDisposable[] NLKNELKBMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x16F9F70", Offset = "0x16F8B70", VA = "0x1816F9F70")]
	public static AJNOKDHGLKN EEJCKKCGPGE(params IDisposable[] NLKNELKBMLG)
	{
		return default(AJNOKDHGLKN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x16F9E50", Offset = "0x16F8A50", VA = "0x1816F9E50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct KAGNHEPBBJD<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public readonly IDisposable FBOMMDJDDKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public T EFFCIDNMALB;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x138CBE0", Offset = "0x138B7E0", VA = "0x18138CBE0")]
	public KAGNHEPBBJD(IDisposable DEEJIANJDED, in T JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2767D70", Offset = "0x2766970", VA = "0x182767D70")]
	public static global::KAGNHEPBBJD<U> BNOEKPHDBBL<U>(in global::KAGNHEPBBJD<T> DEEJIANJDED, in U JHEBJPCMJGD)
	{
		return default(global::KAGNHEPBBJD<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2761E60", Offset = "0x2760A60", VA = "0x182761E60")]
	public global::KAGNHEPBBJD<U> PFMCKGNBNMH<U>(in U JHEBJPCMJGD)
	{
		return default(global::KAGNHEPBBJD<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2767DB0", Offset = "0x27669B0", VA = "0x182767DB0")]
	public static global::KAGNHEPBBJD<(T, U)> ONFAJAIKFEE<U>(in global::KAGNHEPBBJD<T> FIJKOPICOJA, in global::KAGNHEPBBJD<U> JCHDICMDCKL)
	{
		return default(global::KAGNHEPBBJD<(T, U)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x14A29D0", Offset = "0x14A15D0", VA = "0x1814A29D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class GNFPHCOFLCA
{
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2761ED0", Offset = "0x2760AD0", VA = "0x182761ED0")]
	public static global::KAGNHEPBBJD<T> EEJCKKCGPGE<T>(IDisposable DEEJIANJDED, in T JHEBJPCMJGD)
	{
		return default(global::KAGNHEPBBJD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2761E60", Offset = "0x2760A60", VA = "0x182761E60")]
	public static global::KAGNHEPBBJD<U> BNOEKPHDBBL<U, T>(in global::KAGNHEPBBJD<T> GGPIFDDNGJO, in U JHEBJPCMJGD)
	{
		return default(global::KAGNHEPBBJD<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2761F20", Offset = "0x2760B20", VA = "0x182761F20")]
	public static global::KAGNHEPBBJD<(T, U)> ONFAJAIKFEE<T, U>(in global::KAGNHEPBBJD<T> FIJKOPICOJA, in global::KAGNHEPBBJD<U> JCHDICMDCKL)
	{
		return default(global::KAGNHEPBBJD<(T, U)>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct NOALDPMAPLB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x577B90", Offset = "0x576790", VA = "0x180577B90")]
	public static NOALDPMAPLB HNDPFPJEMPH<T>([Optional] string IFLMPALPCDJ, [Optional] string GEFLNGGMFAF, bool JPAAPDEDLGM = false)
	{
		return default(NOALDPMAPLB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[DefaultMember("Item")]
public class NAHKJICPENA<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Func<Internal, External> GPMDAEFFNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Func<External, Internal> PFMMNEEKCBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private IList<Internal> NKPIPAAOHKF;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public IList<Internal> HHKAMPFMIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5534B0", Offset = "0x5520B0", VA = "0x1805534B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x556540", Offset = "0x555140", VA = "0x180556540")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool APOIGGCKAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x62A050", Offset = "0x628C50", VA = "0x18062A050", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x881FC0", Offset = "0x880BC0", VA = "0x180881FC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public External KHCFJKNJCLD
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3CE9AC0", Offset = "0x3CE86C0", VA = "0x183CE9AC0", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x3CE9B60", Offset = "0x3CE8760", VA = "0x183CE9B60", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int IAPBBGBICKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x3CE9A60", Offset = "0x3CE8660", VA = "0x183CE9A60", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3CE99D0", Offset = "0x3CE85D0", VA = "0x183CE99D0")]
	public NAHKJICPENA(Func<Internal, External> GPMDAEFFNDM, Func<External, Internal> PFMMNEEKCBH, bool EPNDBDDEOEI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3CE96E0", Offset = "0x3CE82E0", VA = "0x183CE96E0", Slot = "6")]
	public int IndexOf(External ALMNLLOIKLD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3CE92B0", Offset = "0x3CE7EB0", VA = "0x183CE92B0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3CE9360", Offset = "0x3CE7F60", VA = "0x183CE9360", Slot = "13")]
	public bool Contains(External ALMNLLOIKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3CE93F0", Offset = "0x3CE7FF0", VA = "0x183CE93F0", Slot = "14")]
	public void CopyTo(External[] BBFDALJHIIP, int APNFPBAMMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3CE91C0", Offset = "0x3CE7DC0", VA = "0x183CE91C0", Slot = "11")]
	public void Add(External ALMNLLOIKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3CE97D0", Offset = "0x3CE83D0", VA = "0x183CE97D0", Slot = "7")]
	public void Insert(int KMCFICBBFCD, External ALMNLLOIKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3CE9940", Offset = "0x3CE8540", VA = "0x183CE9940", Slot = "15")]
	public bool Remove(External ALMNLLOIKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3CE9870", Offset = "0x3CE8470", VA = "0x183CE9870", Slot = "8")]
	public void RemoveAt(int KMCFICBBFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3CE9610", Offset = "0x3CE8210", VA = "0x183CE9610", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x129A980", Offset = "0x1299580", VA = "0x18129A980", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DefaultMember("Item")]
public class EBALOOHJAGN<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly Func<Internal, External> GPMDAEFFNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private IReadOnlyList<Internal> NKPIPAAOHKF;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public IReadOnlyList<Internal> HHKAMPFMIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x556460", Offset = "0x555060", VA = "0x180556460")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool APOIGGCKAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x577CA0", Offset = "0x5768A0", VA = "0x180577CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public External KHCFJKNJCLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x3636BB0", Offset = "0x36357B0", VA = "0x183636BB0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int IAPBBGBICKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3636B50", Offset = "0x3635750", VA = "0x183636B50", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x825910", Offset = "0x824510", VA = "0x180825910")]
	public EBALOOHJAGN(Func<Internal, External> GPMDAEFFNDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3636B00", Offset = "0x3635700", VA = "0x183636B00")]
	public EBALOOHJAGN(IReadOnlyList<Internal> NKPIPAAOHKF, Func<Internal, External> GPMDAEFFNDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x36368E0", Offset = "0x36354E0", VA = "0x1836368E0")]
	public void LCHCBJDOGKH(External[] BBFDALJHIIP, int APNFPBAMMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3636870", Offset = "0x3635470", VA = "0x183636870", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x271F840", Offset = "0x271E440", VA = "0x18271F840", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public class DINFKMJOOOM<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private IReadOnlyList<Internal> NKPIPAAOHKF;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public IReadOnlyList<Internal> HHKAMPFMIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x553480", Offset = "0x552080", VA = "0x180553480")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x577180", Offset = "0x575D80", VA = "0x180577180")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool APOIGGCKAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x577CA0", Offset = "0x5768A0", VA = "0x180577CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public External KHCFJKNJCLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x3D7DE60", Offset = "0x3D7CA60", VA = "0x183D7DE60", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int IAPBBGBICKL
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x3D7DE00", Offset = "0x3D7CA00", VA = "0x183D7DE00", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x825910", Offset = "0x824510", VA = "0x180825910")]
	public DINFKMJOOOM(IReadOnlyList<Internal> NKPIPAAOHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3D7DAC0", Offset = "0x3D7C6C0", VA = "0x183D7DAC0")]
	public bool FCKGFBCLJGJ(External ALMNLLOIKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3D7DBD0", Offset = "0x3D7C7D0", VA = "0x183D7DBD0")]
	public void LCHCBJDOGKH(External[] BBFDALJHIIP, int APNFPBAMMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3D7DB60", Offset = "0x3D7C760", VA = "0x183D7DB60", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x129A980", Offset = "0x1299580", VA = "0x18129A980", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public abstract class EHCKHIALAIJ
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void KFIEOBPAMPN(object[] JFLAEJLOLOE);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	protected EHCKHIALAIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public abstract class BKEDBHBJPEL<T> : EHCKHIALAIJ
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	protected struct FEALFCFAOMD
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public enum JEMJFOLJPIN
		{
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public JEMJFOLJPIN IONHFMDGLFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public T LKFICPAOGAF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private int IHBCDKCLLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly bool BFFDFNHFEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	protected readonly bool POCLIFNADNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	protected List<T> ODIPFJFHDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private List<FEALFCFAOMD> KOAJIEHKEOO;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool HIPFBANAJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x398A770", Offset = "0x3989370", VA = "0x18398A770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x398A7B0", Offset = "0x39893B0", VA = "0x18398A7B0")]
	protected BKEDBHBJPEL(bool POCLIFNADNN, bool BFFDFNHFEOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x398A190", Offset = "0x3988D90", VA = "0x18398A190")]
	protected bool BONNJNPJGOL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x398A690", Offset = "0x3989290", VA = "0x18398A690")]
	protected void PLKHOODFGHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x398A230", Offset = "0x3988E30", VA = "0x18398A230")]
	protected void CANJDNDCHMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x2CCDB30", Offset = "0x2CCC730", VA = "0x182CCDB30")]
	private static void HHHOBKDLDCH<U>(ref List<U> NKPIPAAOHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x398A3E0", Offset = "0x3988FE0", VA = "0x18398A3E0", Slot = "5")]
	public void DLPDCPCMKFM(T LKFICPAOGAF, bool JBKELNEDOID = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x398A030", Offset = "0x3988C30", VA = "0x18398A030", Slot = "6")]
	public void AFEKNPNIBII(T LKFICPAOGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x398A560", Offset = "0x3989160", VA = "0x18398A560")]
	public void IJBCCCJHCJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface NEFLOCAFEHJ
{
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DLPDCPCMKFM(Action LKFICPAOGAF, bool JBKELNEDOID = false);

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AFEKNPNIBII(Action LKFICPAOGAF);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class GGJPBMMBEKM : global::BKEDBHBJPEL<Action>, NEFLOCAFEHJ
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x16FC350", Offset = "0x16FAF50", VA = "0x1816FC350")]
	public GGJPBMMBEKM(bool POCLIFNADNN = false, bool BFFDFNHFEOD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x16FC190", Offset = "0x16FAD90", VA = "0x1816FC190")]
	public void PGDPCPIOFGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x16FC0B0", Offset = "0x16FACB0", VA = "0x1816FC0B0", Slot = "4")]
	public override void KFIEOBPAMPN(object[] JFLAEJLOLOE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x16FC130", Offset = "0x16FAD30", VA = "0x1816FC130")]
	public static GGJPBMMBEKM OHGKCMEBKBN(GGJPBMMBEKM JDIFIJPOAPC, Action LKFICPAOGAF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x16FC050", Offset = "0x16FAC50", VA = "0x1816FC050")]
	public static GGJPBMMBEKM JHHDBENEAON(GGJPBMMBEKM JDIFIJPOAPC, Action LKFICPAOGAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface NAGCDCMDBPC<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DLPDCPCMKFM(Action<T> LKFICPAOGAF, bool JBKELNEDOID = false);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AFEKNPNIBII(Action<T> LKFICPAOGAF);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class OEDEHHGDIGH<T> : global::BKEDBHBJPEL<Action<T>>, global::NAGCDCMDBPC<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0xEEAE20", Offset = "0xEE9A20", VA = "0x180EEAE20")]
	public OEDEHHGDIGH(bool POCLIFNADNN = false, bool BFFDFNHFEOD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x4128530", Offset = "0x4127130", VA = "0x184128530")]
	public void PGDPCPIOFGL(T BMKMABBLJGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x4125410", Offset = "0x4124010", VA = "0x184125410", Slot = "4")]
	public override void KFIEOBPAMPN(object[] JFLAEJLOLOE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x4126840", Offset = "0x4125440", VA = "0x184126840")]
	public static global::OEDEHHGDIGH<T> OHGKCMEBKBN(global::OEDEHHGDIGH<T> JDIFIJPOAPC, Action<T> LKFICPAOGAF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x4124AA0", Offset = "0x41236A0", VA = "0x184124AA0")]
	public static global::OEDEHHGDIGH<T> JHHDBENEAON(global::OEDEHHGDIGH<T> JDIFIJPOAPC, Action<T> LKFICPAOGAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface IPEJEHKMGBK<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DLPDCPCMKFM(Action<T, U> LKFICPAOGAF, bool JBKELNEDOID = false);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AFEKNPNIBII(Action<T, U> LKFICPAOGAF);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class BHNNNMJDMJH<T, U> : global::BKEDBHBJPEL<Action<T, U>>, global::IPEJEHKMGBK<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0xEEAE20", Offset = "0xEE9A20", VA = "0x180EEAE20")]
	public BHNNNMJDMJH(bool POCLIFNADNN = false, bool BFFDFNHFEOD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3984710", Offset = "0x3983310", VA = "0x183984710")]
	public void PGDPCPIOFGL(T BMKMABBLJGA, U NMJJFAOHEPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x39806B0", Offset = "0x397F2B0", VA = "0x1839806B0", Slot = "4")]
	public override void KFIEOBPAMPN(object[] JFLAEJLOLOE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3982C70", Offset = "0x3981870", VA = "0x183982C70")]
	public static global::BHNNNMJDMJH<T, U> OHGKCMEBKBN(global::BHNNNMJDMJH<T, U> JDIFIJPOAPC, Action<T, U> LKFICPAOGAF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x39802D0", Offset = "0x397EED0", VA = "0x1839802D0")]
	public static global::BHNNNMJDMJH<T, U> JHHDBENEAON(global::BHNNNMJDMJH<T, U> JDIFIJPOAPC, Action<T, U> LKFICPAOGAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface JLNPMFPBFLG<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DLPDCPCMKFM(Action<T, U, V> LKFICPAOGAF, bool JBKELNEDOID = false);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AFEKNPNIBII(Action<T, U, V> LKFICPAOGAF);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class CBGLODOMCFB<T, U, V> : global::BKEDBHBJPEL<Action<T, U, V>>, global::JLNPMFPBFLG<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0xEEAE20", Offset = "0xEE9A20", VA = "0x180EEAE20")]
	public CBGLODOMCFB(bool POCLIFNADNN = false, bool BFFDFNHFEOD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x3A10370", Offset = "0x3A0EF70", VA = "0x183A10370")]
	public void PGDPCPIOFGL(T BMKMABBLJGA, U NMJJFAOHEPA, V LPAKJPLGCCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x3A0EDE0", Offset = "0x3A0D9E0", VA = "0x183A0EDE0", Slot = "4")]
	public override void KFIEOBPAMPN(object[] JFLAEJLOLOE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x3A10050", Offset = "0x3A0EC50", VA = "0x183A10050")]
	public static global::CBGLODOMCFB<T, U, V> OHGKCMEBKBN(global::CBGLODOMCFB<T, U, V> JDIFIJPOAPC, Action<T, U, V> LKFICPAOGAF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x3A0E940", Offset = "0x3A0D540", VA = "0x183A0E940")]
	public static global::CBGLODOMCFB<T, U, V> JHHDBENEAON(global::CBGLODOMCFB<T, U, V> JDIFIJPOAPC, Action<T, U, V> LKFICPAOGAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface KMGLFHONCAB<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DLPDCPCMKFM(Action<T, U, V, W> LKFICPAOGAF, bool JBKELNEDOID = false);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AFEKNPNIBII(Action<T, U, V, W> LKFICPAOGAF);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class MNNKNPBNNDL<T, U, V, W> : global::BKEDBHBJPEL<Action<T, U, V, W>>, global::KMGLFHONCAB<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0xEEAE20", Offset = "0xEE9A20", VA = "0x180EEAE20")]
	public MNNKNPBNNDL(bool POCLIFNADNN = false, bool BFFDFNHFEOD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x3A3F2B0", Offset = "0x3A3DEB0", VA = "0x183A3F2B0")]
	public void PGDPCPIOFGL(T BMKMABBLJGA, U NMJJFAOHEPA, V LPAKJPLGCCN, W DGOIKAEPCOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x3A3ECC0", Offset = "0x3A3D8C0", VA = "0x183A3ECC0", Slot = "4")]
	public override void KFIEOBPAMPN(object[] JFLAEJLOLOE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x3A3EF80", Offset = "0x3A3DB80", VA = "0x183A3EF80")]
	public static global::MNNKNPBNNDL<T, U, V, W> OHGKCMEBKBN(global::MNNKNPBNNDL<T, U, V, W> JDIFIJPOAPC, Action<T, U, V, W> LKFICPAOGAF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3A3D870", Offset = "0x3A3C470", VA = "0x183A3D870")]
	public static global::MNNKNPBNNDL<T, U, V, W> JHHDBENEAON(global::MNNKNPBNNDL<T, U, V, W> JDIFIJPOAPC, Action<T, U, V, W> LKFICPAOGAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface OGMDIKALLDI<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DLPDCPCMKFM(Action<T, U, V, W, X> LKFICPAOGAF, bool JBKELNEDOID = false);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AFEKNPNIBII(Action<T, U, V, W, X> LKFICPAOGAF);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class NBGBHLFNOOK<T, U, V, W, X> : global::BKEDBHBJPEL<Action<T, U, V, W, X>>, global::OGMDIKALLDI<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0xEEAE20", Offset = "0xEE9A20", VA = "0x180EEAE20")]
	public NBGBHLFNOOK(bool POCLIFNADNN = false, bool BFFDFNHFEOD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x386DA30", Offset = "0x386C630", VA = "0x18386DA30")]
	public void PGDPCPIOFGL(T BMKMABBLJGA, U NMJJFAOHEPA, V LPAKJPLGCCN, W DGOIKAEPCOF, X PKLHFCEKMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x386D6A0", Offset = "0x386C2A0", VA = "0x18386D6A0", Slot = "4")]
	public override void KFIEOBPAMPN(object[] JFLAEJLOLOE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x386D990", Offset = "0x386C590", VA = "0x18386D990")]
	public static global::NBGBHLFNOOK<T, U, V, W, X> OHGKCMEBKBN(global::NBGBHLFNOOK<T, U, V, W, X> JDIFIJPOAPC, Action<T, U, V, W, X> LKFICPAOGAF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x386D2E0", Offset = "0x386BEE0", VA = "0x18386D2E0")]
	public static global::NBGBHLFNOOK<T, U, V, W, X> JHHDBENEAON(global::NBGBHLFNOOK<T, U, V, W, X> JDIFIJPOAPC, Action<T, U, V, W, X> LKFICPAOGAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface JEANECGBHHI<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DLPDCPCMKFM(Action<T, U, V, W, X, Y> LKFICPAOGAF, bool JBKELNEDOID = false);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AFEKNPNIBII(Action<T, U, V, W, X, Y> LKFICPAOGAF);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public sealed class JBFEHLFNENE<T, U, V, W, X, Y> : global::BKEDBHBJPEL<Action<T, U, V, W, X, Y>>, global::JEANECGBHHI<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0xEEAE20", Offset = "0xEE9A20", VA = "0x180EEAE20")]
	public JBFEHLFNENE(bool POCLIFNADNN = false, bool BFFDFNHFEOD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0xEEAB60", Offset = "0xEE9760", VA = "0x180EEAB60")]
	public void PGDPCPIOFGL(T BMKMABBLJGA, U NMJJFAOHEPA, V LPAKJPLGCCN, W DGOIKAEPCOF, X PKLHFCEKMJB, Y JGEGPABGNNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0xEE9E40", Offset = "0xEE8A40", VA = "0x180EE9E40", Slot = "4")]
	public override void KFIEOBPAMPN(object[] JFLAEJLOLOE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0xEEA4F0", Offset = "0xEE90F0", VA = "0x180EEA4F0")]
	public static global::JBFEHLFNENE<T, U, V, W, X, Y> OHGKCMEBKBN(global::JBFEHLFNENE<T, U, V, W, X, Y> JDIFIJPOAPC, Action<T, U, V, W, X, Y> LKFICPAOGAF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0xEE9A50", Offset = "0xEE8650", VA = "0x180EE9A50")]
	public static global::JBFEHLFNENE<T, U, V, W, X, Y> JHHDBENEAON(global::JBFEHLFNENE<T, U, V, W, X, Y> JDIFIJPOAPC, Action<T, U, V, W, X, Y> LKFICPAOGAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public sealed class OENGPHJDADJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public readonly struct OOCNFIJHHEK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly global::OENGPHJDADJ<T> AEOJJJFAINK;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public T EFFCIDNMALB
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x2975070", Offset = "0x2973C70", VA = "0x182975070")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2975040", Offset = "0x2973C40", VA = "0x182975040", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7AD320", Offset = "0x7ABF20", VA = "0x1807AD320")]
		public OOCNFIJHHEK(global::OENGPHJDADJ<T> AEOJJJFAINK)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct NKHMCKNBIND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder<OOCNFIJHHEK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public global::OENGPHJDADJ<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x2966B00", Offset = "0x2965700", VA = "0x182966B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x121B330", Offset = "0x1219F30", VA = "0x18121B330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct OCBJDLIHDAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder<OOCNFIJHHEK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public global::OENGPHJDADJ<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x2966EE0", Offset = "0x2965AE0", VA = "0x182966EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x121B330", Offset = "0x1219F30", VA = "0x18121B330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly SemaphoreSlim PHBEEEPAINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private T NMJIPGCFJNM;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int IHOAACMHEFL
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x2967900", Offset = "0x2966500", VA = "0x182967900")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x29679A0", Offset = "0x29665A0", VA = "0x1829679A0")]
	public OENGPHJDADJ(in T NMJIPGCFJNM, int AGJJEONBPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x1430800", Offset = "0x142F400", VA = "0x181430800")]
	public OENGPHJDADJ(in T NMJIPGCFJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x2967960", Offset = "0x2966560", VA = "0x182967960")]
	public OOCNFIJHHEK OAPBAKOGFCK()
	{
		return default(OOCNFIJHHEK);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2967920", Offset = "0x2966520", VA = "0x182967920")]
	public OOCNFIJHHEK OAPBAKOGFCK(CancellationToken DDPNAGPNMPM)
	{
		return default(OOCNFIJHHEK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x29674C0", Offset = "0x29660C0", VA = "0x1829674C0")]
	[AsyncStateMachine(typeof(global::OENGPHJDADJ<>.NKHMCKNBIND))]
	public Task<OOCNFIJHHEK> BEEAIMAPMAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2967340", Offset = "0x2965F40", VA = "0x182967340")]
	[AsyncStateMachine(typeof(global::OENGPHJDADJ<>.OCBJDLIHDAK))]
	public Task<OOCNFIJHHEK> BEEAIMAPMAG(CancellationToken DDPNAGPNMPM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class OGKKLNOPPBK
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x16FD200", Offset = "0x16FBE00", VA = "0x1816FD200")]
	public static global::OENGPHJDADJ<BDOJJEFHALN> EEJCKKCGPGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x16FD260", Offset = "0x16FBE60", VA = "0x1816FD260")]
	public static global::OENGPHJDADJ<BDOJJEFHALN> EEJCKKCGPGE(int AGJJEONBPFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x26B6F60", Offset = "0x26B5B60", VA = "0x1826B6F60")]
	public static global::OENGPHJDADJ<T> EEJCKKCGPGE<T>(in T NMJIPGCFJNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x2768110", Offset = "0x2766D10", VA = "0x182768110")]
	public static global::OENGPHJDADJ<T> EEJCKKCGPGE<T>(in T NMJIPGCFJNM, int AGJJEONBPFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class AIMNBMAFPPF<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public delegate bool BAEJFKGJFAF(global::AIMNBMAFPPF<T> ILAIGPHHGCD);

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class PIBPOGIPAFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public T nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public global::AIMNBMAFPPF<T> foundNode;

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760490", VA = "0x180761890")]
		public PIBPOGIPAFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x29A3120", Offset = "0x29A1D20", VA = "0x1829A3120")]
		internal bool <FindNode>b__0(global::AIMNBMAFPPF<T> node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public T KALEFIPJEDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public LinkedList<global::AIMNBMAFPPF<T>> PHDAAGBMGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public global::AIMNBMAFPPF<T> JNFHJCJFMHO;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public global::AIMNBMAFPPF<T> DCHLIMBOGAK
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x5F9760", Offset = "0x5F8360", VA = "0x1805F9760")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x298F9C0", Offset = "0x298E5C0", VA = "0x18298F9C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool FHCPKFMCMDF
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x29902A0", Offset = "0x298EEA0", VA = "0x1829902A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool JCLOABCJADO
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x298FB80", Offset = "0x298E780", VA = "0x18298FB80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public global::AIMNBMAFPPF<T> IEPGIADAFOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x298F940", Offset = "0x298E540", VA = "0x18298F940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x2990D80", Offset = "0x298F980", VA = "0x182990D80")]
	public AIMNBMAFPPF(T FJILFKFEGJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x298F3A0", Offset = "0x298DFA0", VA = "0x18298F3A0")]
	public global::AIMNBMAFPPF<T> CFGMBHAHMND(T HBFCCDFCFKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x298F770", Offset = "0x298E370", VA = "0x18298F770")]
	public global::AIMNBMAFPPF<T> CNAGICPDCCL(T CMKPPFLBGKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x298F260", Offset = "0x298DE60", VA = "0x18298F260")]
	public global::AIMNBMAFPPF<T> AFEKNPNIBII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x298FC00", Offset = "0x298E800", VA = "0x18298FC00")]
	public void IJBCCCJHCJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x29900C0", Offset = "0x298ECC0", VA = "0x1829900C0")]
	public global::AIMNBMAFPPF<T> IMNEKBAGFKD(T CGNOFEDFEIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x2990610", Offset = "0x298F210", VA = "0x182990610")]
	public static void MICPCPCILNF(global::AIMNBMAFPPF<T> NANCLOOCFGE, BAEJFKGJFAF CKFINFJDPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x2CCA3E0", Offset = "0x2CC8FE0", VA = "0x182CCA3E0")]
	public static void MICPCPCILNF<A>(global::AIMNBMAFPPF<T> NANCLOOCFGE, Func<global::AIMNBMAFPPF<T>, A, bool> CKFINFJDPPH, A OBCADMALLNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x298ED20", Offset = "0x298D920", VA = "0x18298ED20")]
	public static string ACOPOFHNKEI(global::AIMNBMAFPPF<T> NANCLOOCFGE, int JPOCGFPMJDP = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x2990950", Offset = "0x298F550", VA = "0x182990950")]
	public static global::AIMNBMAFPPF<T> NACABBOJCGL(global::AIMNBMAFPPF<T> NANCLOOCFGE, T IJMLHFNHNOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class ICOLBGBEOCD<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public delegate Task<TResult> BAJEKPGPAEJ(TRequest KNDMNNPBJNE, CancellationToken DDPNAGPNMPM);

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public enum EKLFAOIAIPI
	{
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class OGHKPGMNOBN
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private const float OLFJFHGLAHK = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private TimeSpan ICKHGIGDDOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int EMIAPHLFLFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public EKLFAOIAIPI KPPFGDGKBIP;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly OGHKPGMNOBN NOMEFEEFAGL;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float HCJBBDLDBJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x77B500", Offset = "0x77A100", VA = "0x18077B500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public TimeSpan FPCJOAAFBPL
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x553480", Offset = "0x552080", VA = "0x180553480")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x77B6E0", Offset = "0x77A2E0", VA = "0x18077B6E0")]
		public OGHKPGMNOBN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private readonly struct PEHCHGPOAAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public readonly TRequest KNDMNNPBJNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public readonly CancellationToken DDPNAGPNMPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public readonly TaskCompletionSource<TResult> PHJFIJFJPGG;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x77C4F0", Offset = "0x77B0F0", VA = "0x18077C4F0")]
		public PEHCHGPOAAE(TRequest KNDMNNPBJNE, TaskCompletionSource<TResult> PHJFIJFJPGG, CancellationToken DDPNAGPNMPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class BELLIEPAMBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760490", VA = "0x180761890")]
		public BELLIEPAMBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x761860", Offset = "0x760460", VA = "0x180761860")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct OKLNDHFIMCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public global::ICOLBGBEOCD<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x77BD00", Offset = "0x77A900", VA = "0x18077BD00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x77BFA0", Offset = "0x77ABA0", VA = "0x18077BFA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class BGKDGEDMCOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public PEHCHGPOAAE req;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public global::ICOLBGBEOCD<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760490", VA = "0x180761890")]
		public BGKDGEDMCOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x761BB0", Offset = "0x7607B0", VA = "0x180761BB0")]
		internal void <ProcessQueue>b__0(Task<TResult> task)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly CancellationTokenSource FJGDCGOIMGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly List<PEHCHGPOAAE> EACPCFCDLMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly OGHKPGMNOBN IEHNIJDMDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly BAJEKPGPAEJ JFAOCMOBDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private Task POFDEDGJNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int CNDPIGNHIJF;

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x765950", Offset = "0x764550", VA = "0x180765950")]
	public ICOLBGBEOCD(BAJEKPGPAEJ JFAOCMOBDCF, [Optional] OGHKPGMNOBN IEHNIJDMDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7642B0", Offset = "0x762EB0", VA = "0x1807642B0")]
	public Task<TResult> KDLMIOOHONO(TRequest KNDMNNPBJNE, CancellationToken DDPNAGPNMPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x763FB0", Offset = "0x762BB0", VA = "0x180763FB0")]
	private void FGBKKMKEINO(PEHCHGPOAAE FAHONKDCACP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x764870", Offset = "0x763470", VA = "0x180764870")]
	[AsyncStateMachine(typeof(global::ICOLBGBEOCD<, >.OKLNDHFIMCB))]
	private Task MMHCGOPCDKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x764F70", Offset = "0x763B70", VA = "0x180764F70")]
	private PEHCHGPOAAE NDLLJDEAMFA()
	{
		return default(PEHCHGPOAAE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7653B0", Offset = "0x763FB0", VA = "0x1807653B0")]
	private void NMIKAPNJECK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x763E40", Offset = "0x762A40", VA = "0x180763E40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class ADBAOGPCANJ<TKey, TVal> : global::IPGMACLAPEO<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private int GNIGONHCJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	internal Dictionary<TKey, (TVal value, int size)> NBKBDADGNMC;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	internal override int OKKAIFANPOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xDF6CE0", Offset = "0xDF58E0", VA = "0x180DF6CE0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	internal int ONILALODDJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xDF6A80", Offset = "0xDF5680", VA = "0x180DF6A80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public override int IAPBBGBICKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xDF6D10", Offset = "0xDF5910", VA = "0x180DF6D10", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0xDF6D70", Offset = "0xDF5970", VA = "0x180DF6D70")]
	public ADBAOGPCANJ(int EAAJKPJKHNJ, [Optional] ALLOIAGKIKD FPLELAPHMLB, [Optional] IEqualityComparer<TKey> KBFEAINBOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0xDF67B0", Offset = "0xDF53B0", VA = "0x180DF67B0")]
	public void EGCPKBCDLLI(TKey GMCMHIFODNN, TVal JHEBJPCMJGD, bool GDOKABELDMP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0xDF6690", Offset = "0xDF5290", VA = "0x180DF6690")]
	public bool APPFKBIMDLA(TKey GMCMHIFODNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0xDF6AB0", Offset = "0xDF56B0", VA = "0x180DF6AB0", Slot = "6")]
	public override bool ICGEJEGNFAB(TKey KKJNGDBPGDL, out TVal JHEBJPCMJGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0xDF6850", Offset = "0xDF5450", VA = "0x180DF6850")]
	public bool GBJDHGLLAIK(TKey GMCMHIFODNN, TVal JHEBJPCMJGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0xDF6BD0", Offset = "0xDF57D0", VA = "0x180DF6BD0")]
	public bool JPBDCKLCICN(TKey GMCMHIFODNN, TVal JHEBJPCMJGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0xDF6B60", Offset = "0xDF5760", VA = "0x180DF6B60", Slot = "7")]
	public override void IJBCCCJHCJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0xDF6710", Offset = "0xDF5310", VA = "0x180DF6710")]
	private bool CGMKGMAILCE(TKey GMCMHIFODNN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[DefaultMember("Item")]
public class IPGMACLAPEO<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public delegate int ALLOIAGKIKD(TKey GMCMHIFODNN, TVal JHEBJPCMJGD);

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class DKKCJDDAGAG
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public TKey CGBHHKNJCCC
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x553480", Offset = "0x552080", VA = "0x180553480")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public TVal EFFCIDNMALB
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x811B10", Offset = "0x810710", VA = "0x180811B10")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x8EB230", Offset = "0x8E9E30", VA = "0x1808EB230")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public int OKLPHEBIEMI
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x616AB0", Offset = "0x6156B0", VA = "0x180616AB0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x5B07E0", Offset = "0x5AF3E0", VA = "0x1805B07E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public DateTime CFILOBIEHIC
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x5534B0", Offset = "0x5520B0", VA = "0x1805534B0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x80DB50", Offset = "0x80C750", VA = "0x18080DB50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xEDE530", Offset = "0xEDD130", VA = "0x180EDE530")]
		public DKKCJDDAGAG(TKey GMCMHIFODNN, TVal LEJMLBJOPAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public const int DCHNNIONJIP = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly Dictionary<TKey, LinkedListNode<DKKCJDDAGAG>> LLMDJPFAGFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly LinkedList<DKKCJDDAGAG> PAMAHMOCJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	protected readonly ALLOIAGKIKD FPLELAPHMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private readonly TimeSpan HECCMGFGBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly GLLMKDAKDNA HHJFBADLLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private int JDGPKANMBEJ;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int GLPGAPIGFOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x552A00", Offset = "0x551600", VA = "0x180552A00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private bool ELBJCOGAGMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xEE6190", Offset = "0xEE4D90", VA = "0x180EE6190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	internal virtual int OKKAIFANPOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x732A50", Offset = "0x731650", VA = "0x180732A50", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	private int PMKGCDLMBFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x762530", Offset = "0x761130", VA = "0x180762530")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public virtual int IAPBBGBICKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x83E440", Offset = "0x83D040", VA = "0x18083E440", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<TKey> OEDAOHBDPEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xEE4E90", Offset = "0xEE3A90", VA = "0x180EE4E90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public TVal KHCFJKNJCLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xEE6160", Offset = "0xEE4D60", VA = "0x180EE6160")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xEE57F0", Offset = "0xEE43F0", VA = "0x180EE57F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0xEE6590", Offset = "0xEE5190", VA = "0x180EE6590")]
	public IPGMACLAPEO(int EAAJKPJKHNJ, [Optional] ALLOIAGKIKD FPLELAPHMLB, [Optional] IEqualityComparer<TKey> KBFEAINBOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0xEE6220", Offset = "0xEE4E20", VA = "0x180EE6220")]
	public IPGMACLAPEO(TimeSpan HECCMGFGBFG, [Optional] IEqualityComparer<TKey> KBFEAINBOGE, [Optional] GLLMKDAKDNA HHJFBADLLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0xEE6660", Offset = "0xEE5260", VA = "0x180EE6660")]
	public IPGMACLAPEO(int EAAJKPJKHNJ, TimeSpan HECCMGFGBFG, [Optional] IEqualityComparer<TKey> KBFEAINBOGE, [Optional] GLLMKDAKDNA HHJFBADLLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0xEE6340", Offset = "0xEE4F40", VA = "0x180EE6340")]
	public IPGMACLAPEO(int EAAJKPJKHNJ, ALLOIAGKIKD FPLELAPHMLB, TimeSpan HECCMGFGBFG, [Optional] IEqualityComparer<TKey> KBFEAINBOGE, [Optional] GLLMKDAKDNA HHJFBADLLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0xEE50B0", Offset = "0xEE3CB0", VA = "0x180EE50B0")]
	public void FDEOHCOMKCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0xEE60A0", Offset = "0xEE4CA0", VA = "0x180EE60A0")]
	public void MLPJBGOCDOH(TKey GMCMHIFODNN, TVal JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0xEE4990", Offset = "0xEE3590", VA = "0x180EE4990")]
	public bool AFEKNPNIBII(TKey GMCMHIFODNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0xEE5BF0", Offset = "0xEE47F0", VA = "0x180EE5BF0")]
	private TVal JFMNFJDNJKA(TKey KKJNGDBPGDL)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0xEE5980", Offset = "0xEE4580", VA = "0x180EE5980", Slot = "6")]
	public virtual bool ICGEJEGNFAB(TKey KKJNGDBPGDL, out TVal JHEBJPCMJGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0xEE5AD0", Offset = "0xEE46D0", VA = "0x180EE5AD0", Slot = "7")]
	public virtual void IJBCCCJHCJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0xEE5220", Offset = "0xEE3E20", VA = "0x180EE5220")]
	private bool GCAPFENFNDH(DKKCJDDAGAG APKDEHBNDEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0xEE53A0", Offset = "0xEE3FA0", VA = "0x180EE53A0")]
	private void GFIJFAEOMPM(LinkedListNode<DKKCJDDAGAG> OEJJPPPPFGN, TVal GLDMLGOHMOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0xEE4AF0", Offset = "0xEE36F0", VA = "0x180EE4AF0")]
	private void CPPEMODJEHC(TKey GMCMHIFODNN, TVal JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0xEE5E40", Offset = "0xEE4A40", VA = "0x180EE5E40")]
	private void LMHNFLBBNAB(DKKCJDDAGAG APKDEHBNDEA, TVal GLDMLGOHMOO, int OMEOALBMBDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[DefaultMember("Item")]
public class NCIOHAGIACO<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly List<T> NKPIPAAOHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private HashSet<T> GPAMCHOEFHE;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int IAPBBGBICKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x761860", Offset = "0x760460", VA = "0x180761860", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool APOIGGCKAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x577B90", Offset = "0x576790", VA = "0x180577B90", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public T KHCFJKNJCLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x1009FA0", Offset = "0x1008BA0", VA = "0x181009FA0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x386EDD0", Offset = "0x386D9D0", VA = "0x18386EDD0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0xEE3760", Offset = "0xEE2360", VA = "0x180EE3760", Slot = "11")]
	public void Add(T ALMNLLOIKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x386E610", Offset = "0x386D210", VA = "0x18386E610")]
	public bool AMIPHNDNCGN(T ALMNLLOIKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x386EBE0", Offset = "0x386D7E0", VA = "0x18386EBE0", Slot = "15")]
	public bool Remove(T ALMNLLOIKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x11EDDE0", Offset = "0x11EC9E0", VA = "0x1811EDDE0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x29916F0", Offset = "0x29902F0", VA = "0x1829916F0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x386E6B0", Offset = "0x386D2B0", VA = "0x18386E6B0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0xEEE500", Offset = "0xEED100", VA = "0x180EEE500", Slot = "13")]
	public bool Contains(T ALMNLLOIKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x1009DC0", Offset = "0x10089C0", VA = "0x181009DC0", Slot = "14")]
	public void CopyTo(T[] BBFDALJHIIP, int APNFPBAMMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x142E890", Offset = "0x142D490", VA = "0x18142E890", Slot = "6")]
	public int IndexOf(T ALMNLLOIKLD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x386E710", Offset = "0x386D310", VA = "0x18386E710", Slot = "7")]
	public void Insert(int KMCFICBBFCD, T ALMNLLOIKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x386EA40", Offset = "0x386D640", VA = "0x18386EA40", Slot = "8")]
	public void RemoveAt(int KMCFICBBFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x386E8A0", Offset = "0x386D4A0", VA = "0x18386E8A0")]
	public void KBAECKANOCB(Predicate<T> LJGPHPEILDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x386E530", Offset = "0x386D130", VA = "0x18386E530")]
	public void AIFAEPLAIJA(Comparison<T> MLEHGOBHDOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x386ECF0", Offset = "0x386D8F0", VA = "0x18386ECF0")]
	public NCIOHAGIACO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class IOJPIEIFNBA
{
	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x16FC7D0", Offset = "0x16FB3D0", VA = "0x1816FC7D0")]
	public static Vector3 NMFFFBIAMCM(this GameObject HMMABJMEBLO, float CAALMMDJJOF)
	{
		return default(Vector3);
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x61FB40", Offset = "0x61E740", VA = "0x18061FB40")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x16FFFD0", Offset = "0x16FEBD0", VA = "0x1816FFFD0")]
		public SerializedGuid(in Guid PGAEDAICAPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x16FFD70", Offset = "0x16FE970", VA = "0x1816FFD70")]
		public static SerializedGuid HCMGPAJJMDI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x16FFEC0", Offset = "0x16FEAC0", VA = "0x1816FFEC0")]
		public static SerializedGuid PDCJOJGEKDE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x16FFF40", Offset = "0x16FEB40", VA = "0x1816FFF40")]
		public bool PHDHHHJCGEJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x16FFE90", Offset = "0x16FEA90", VA = "0x1816FFE90", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x16FFDF0", Offset = "0x16FE9F0", VA = "0x1816FFDF0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x16FFB50", Offset = "0x16FE750", VA = "0x1816FFB50")]
		public bool EOFIHCCDBML(in Guid PGAEDAICAPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x16FFBE0", Offset = "0x16FE7E0", VA = "0x1816FFBE0", Slot = "7")]
		public bool Equals(SerializedGuid DEIAHGDLBHH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x16FFC80", Offset = "0x16FE880", VA = "0x1816FFC80", Slot = "0")]
		public override bool Equals(object KLDDDNGBABC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x16FFD60", Offset = "0x16FE960", VA = "0x1816FFD60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x16FFB20", Offset = "0x16FE720", VA = "0x1816FFB20", Slot = "6")]
		public int CompareTo(SerializedGuid DEIAHGDLBHH)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class DDCJPIIKFBD : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly Type PFKCDMLOLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly string NGGJFFIDDHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly bool LCILIHPILAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly bool KEBCLPBCIJC;

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x16FA4D0", Offset = "0x16F90D0", VA = "0x1816FA4D0")]
	public DDCJPIIKFBD(Type PJCHOJNLLMG, string HLGHPGHCPBI, bool CLCMCOMCCJO = false, bool BABBGPOBMLI = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface MOMHNKJDKCK
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface MEEFDHMLHFB<T> : MOMHNKJDKCK
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	T EFFCIDNMALB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool MPFFEHFBLPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	string DALHCNINCJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::MEEFDHMLHFB<T> JEMIDGKKGJC(Action<T> JHLBMDAAMJA);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::MEEFDHMLHFB<T> JNHGMBMHEKG(Action<T> JHLBMDAAMJA);

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::MEEFDHMLHFB<T> MDONBOBNJOO(Action<T, T> LDHBBBJDCCA);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::MEEFDHMLHFB<T> DGBLKADFDNB(Action<T, T> LDHBBBJDCCA);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::MEEFDHMLHFB<T> IMHLKFGOPIH(Action<string> COFFIOOFBJA);

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::MEEFDHMLHFB<T> AFPHDGHNDIE(Action<string> COFFIOOFBJA);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class NLLIPKCCJCG<T> : global::MEEFDHMLHFB<T>, MOMHNKJDKCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private global::BHNNNMJDMJH<T, T> GHJBIFEAHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private global::OEDEHHGDIGH<T> ICGNFGLNIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private global::OEDEHHGDIGH<string> CDLHCKGFGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private string JFBFEFFLMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private T JAGEKFPDBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private bool FKALLEEFLOG;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public T EFFCIDNMALB
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x552A10", Offset = "0x551610", VA = "0x180552A10", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x29A2740", Offset = "0x29A1340", VA = "0x1829A2740", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool MPFFEHFBLPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x62AF70", Offset = "0x629B70", VA = "0x18062AF70", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public string DALHCNINCJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x553490", Offset = "0x552090", VA = "0x180553490", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x762500", Offset = "0x761100", VA = "0x180762500", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x3A05550", Offset = "0x3A04150", VA = "0x183A05550")]
	private void PBKLIEGIDKB(T LCKIKJEFFAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x3A052F0", Offset = "0x3A03EF0", VA = "0x183A052F0")]
	private void FLOHBFKMGIL(string MCDGHKDLPFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x3A051F0", Offset = "0x3A03DF0", VA = "0x183A051F0")]
	public void CLICKJANIPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x3A05500", Offset = "0x3A04100", VA = "0x183A05500", Slot = "6")]
	public global::MEEFDHMLHFB<T> MDONBOBNJOO(Action<T, T> LDHBBBJDCCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x3A052A0", Offset = "0x3A03EA0", VA = "0x183A052A0", Slot = "7")]
	public global::MEEFDHMLHFB<T> DGBLKADFDNB(Action<T, T> LDHBBBJDCCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x3A05420", Offset = "0x3A04020", VA = "0x183A05420", Slot = "4")]
	public global::MEEFDHMLHFB<T> JEMIDGKKGJC(Action<T> LDHBBBJDCCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x3A054B0", Offset = "0x3A040B0", VA = "0x183A054B0", Slot = "5")]
	public global::MEEFDHMLHFB<T> JNHGMBMHEKG(Action<T> JHLBMDAAMJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x3A05390", Offset = "0x3A03F90", VA = "0x183A05390", Slot = "8")]
	public global::MEEFDHMLHFB<T> IMHLKFGOPIH(Action<string> COFFIOOFBJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x3A05180", Offset = "0x3A03D80", VA = "0x183A05180", Slot = "9")]
	public global::MEEFDHMLHFB<T> AFPHDGHNDIE(Action<string> COFFIOOFBJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x3A055F0", Offset = "0x3A041F0", VA = "0x183A055F0")]
	public NLLIPKCCJCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class DEENGBJPBFB
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class IPGDEKJNJBH<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public global::MEEFDHMLHFB<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public global::MPFMAEPNJMA<T> promise;

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760490", VA = "0x180761890")]
		public IPGDEKJNJBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x36186F0", Offset = "0x36172F0", VA = "0x1836186F0")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x275F590", Offset = "0x275E190", VA = "0x18275F590")]
	public static global::NHGODCKFGMA<T> DGCGNLJMLGO<T>(this global::MEEFDHMLHFB<T> NKGMMMAPNAK, Action<T> OMCIJDNLADG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class GLLMKDAKDNA
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private class FHHPLHANJIA : GLLMKDAKDNA
	{
		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public static GLLMKDAKDNA APCGFOPGBDO
		{
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x16FAFD0", Offset = "0x16F9BD0", VA = "0x1816FAFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public override DateTime FLJPNFJEFAA
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x16FB030", Offset = "0x16F9C30", VA = "0x1816FB030", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public override float PMPLIFGBCJB
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x16FAFC0", Offset = "0x16F9BC0", VA = "0x1816FAFC0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x16FB120", Offset = "0x16F9D20", VA = "0x1816FB120")]
		public FHHPLHANJIA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static GLLMKDAKDNA OAOGGABMJAN;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public static GLLMKDAKDNA NOMEFEEFAGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x16FC400", Offset = "0x16FB000", VA = "0x1816FC400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public abstract DateTime FLJPNFJEFAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public abstract float PMPLIFGBCJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	protected GLLMKDAKDNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class EPIFABKMKAD : global::KPGDJMIOJJF<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x16FAEE0", Offset = "0x16F9AE0", VA = "0x1816FAEE0")]
	public EPIFABKMKAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class KPGDJMIOJJF<T> : global::BIHIBHJBLHB<T>, EIMCOODGJDK, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public Task<T> DMEDOKCDPEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x553480", Offset = "0x552080", VA = "0x180553480", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	private Task CFMKOGLJFDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x763B20", Offset = "0x762720", VA = "0x180763B20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public global::NHGODCKFGMA<T> NCOBCBLPENA
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	private EPHEJFPBCIA ALKEDHJAKMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x1203730", Offset = "0x1202330", VA = "0x181203730", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x138CDA0", Offset = "0x138B9A0", VA = "0x18138CDA0")]
	public KPGDJMIOJJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class GKKNPCELHJM : global::MCLIDKNCNAJ<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x16FC3B0", Offset = "0x16FAFB0", VA = "0x1816FC3B0")]
	public GKKNPCELHJM(Exception AADNPGFOACH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class MCLIDKNCNAJ<T> : global::BIHIBHJBLHB<T>, EIMCOODGJDK, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Task<T> DMEDOKCDPEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x553480", Offset = "0x552080", VA = "0x180553480", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	private Task CFMKOGLJFDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x763B20", Offset = "0x762720", VA = "0x180763B20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public global::NHGODCKFGMA<T> NCOBCBLPENA
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	private EPHEJFPBCIA ALKEDHJAKMF
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x1203730", Offset = "0x1202330", VA = "0x181203730", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x1431510", Offset = "0x1430110", VA = "0x181431510")]
	public MCLIDKNCNAJ(Exception AADNPGFOACH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface EIMCOODGJDK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	[NotNull]
	Task DMEDOKCDPEI
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	[NotNull]
	EPHEJFPBCIA NCOBCBLPENA
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface BIHIBHJBLHB<T> : EIMCOODGJDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000063")]
	[NotNull]
	new Task<T> DMEDOKCDPEI
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	[NotNull]
	new global::NHGODCKFGMA<T> NCOBCBLPENA
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public abstract class KELEMHFMCNK<TTask, T> : global::BIHIBHJBLHB<T>, EIMCOODGJDK, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class IAPACPHGAOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public global::KELEMHFMCNK<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760490", VA = "0x180761890")]
		public IAPACPHGAOH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static bool EKFAFIIHLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly Task<T> MHDCLDEMKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	protected readonly CancellationTokenSource LDGGJCAOMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool KNMBINEJEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private SynchronizationContext OLJFAPFNDAO;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public Task<T> DMEDOKCDPEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x553480", Offset = "0x552080", VA = "0x180553480", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	private Task CFMKOGLJFDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x553480", Offset = "0x552080", VA = "0x180553480", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public global::NHGODCKFGMA<T> NCOBCBLPENA
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	private EPHEJFPBCIA ALKEDHJAKMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x100A210", Offset = "0x1008E10", VA = "0x18100A210", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public bool DMPBEOOIIDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x62A050", Offset = "0x628C50", VA = "0x18062A050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x120F020", Offset = "0x120DC20", VA = "0x18120F020")]
	static KELEMHFMCNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x120F4B0", Offset = "0x120E0B0", VA = "0x18120F4B0")]
	protected KELEMHFMCNK(TTask MHDCLDEMKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x120EF80", Offset = "0x120DB80", VA = "0x18120EF80", Slot = "1")]
	~KELEMHFMCNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x120EEB0", Offset = "0x120DAB0", VA = "0x18120EEB0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x120ED40", Offset = "0x120D940", VA = "0x18120ED40")]
	private void CCNPHFEIOJM(bool JIMBKELGADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T PCFBAGDIJBH(TTask KBOBNEDMEON);

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void FDFBAFKJGJC();

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x120EB80", Offset = "0x120D780", VA = "0x18120EB80")]
	[CompilerGenerated]
	private void ALMGILAELII(object BMMKEAHNPAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class JHCOEDDCOEC : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public readonly Type PFKCDMLOLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public readonly string NGGJFFIDDHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public readonly bool LCILIHPILAF;

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x16FCA60", Offset = "0x16FB660", VA = "0x1816FCA60")]
	public JHCOEDDCOEC(Type PJCHOJNLLMG, string HLGHPGHCPBI, bool CLCMCOMCCJO = false)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x54F010", Offset = "0x54DC10", VA = "0x18054F010")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x59B370", Offset = "0x599F70", VA = "0x18059B370")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public T this[int EPHKOIPAMCK, int LMJJCOKOEBE]
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x270E280", Offset = "0x270CE80", VA = "0x18270E280")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x270E320", Offset = "0x270CF20", VA = "0x18270E320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x270E1F0", Offset = "0x270CDF0", VA = "0x18270E1F0")]
		public Array2D(uint LOAJHEIDPPI, uint KBNEJJFCEEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x270E170", Offset = "0x270CD70", VA = "0x18270E170")]
		public void IJBCCCJHCJP()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x16F9F90", Offset = "0x16F8B90", VA = "0x1816F9F90")]
		public Array2DVector3(uint LOAJHEIDPPI, uint KBNEJJFCEEJ)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal static class HCLAPBFDNCO
{
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public const int BOAJBGKGJIK = -1;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public const int OLNFJJDMCEP = 0;
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[DefaultMember("Item")]
public class OAPCOEIEDOF<THandle, TValue> : IDisposable where THandle : struct, FEFCJIHAFNE where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly List<THandle> IEJAPCGDJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly List<TValue> JBGIJHKCMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly Func<TValue> GDAGNIIFHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly Action<TValue> DEAHFEFCKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private int IJPDCJLPJAK;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public TValue KHCFJKNJCLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xEEBBC0", Offset = "0xEEA7C0", VA = "0x180EEBBC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x411E720", Offset = "0x411D320", VA = "0x18411E720")]
	public OAPCOEIEDOF(Action<TValue> DEAHFEFCKNL, [Optional] Func<TValue> GDAGNIIFHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x411DE40", Offset = "0x411CA40", VA = "0x18411DE40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x411E0F0", Offset = "0x411CCF0", VA = "0x18411E0F0")]
	public THandle JFONNKANKPC()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x411DDD0", Offset = "0x411C9D0", VA = "0x18411DDD0")]
	public THandle DLPDCPCMKFM(TValue JHEBJPCMJGD)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x411DC20", Offset = "0x411C820", VA = "0x18411DC20")]
	public bool AFEKNPNIBII(THandle LFGAIKKMBAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x411E640", Offset = "0x411D240", VA = "0x18411E640")]
	public bool PDBBNDAJDHA(THandle LFGAIKKMBAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x411DB80", Offset = "0x411C780", VA = "0x18411DB80")]
	public bool ACFEEFLJJHO(THandle LFGAIKKMBAH, out TValue JHEBJPCMJGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x411E0A0", Offset = "0x411CCA0", VA = "0x18411E0A0")]
	public TValue JFMNFJDNJKA(THandle LFGAIKKMBAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x411E2D0", Offset = "0x411CED0", VA = "0x18411E2D0")]
	public bool JLAIJOGKCBH(THandle LFGAIKKMBAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x411E070", Offset = "0x411CC70", VA = "0x18411E070")]
	private THandle HNAINIJDHKL(int KMCFICBBFCD)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x411DDA0", Offset = "0x411C9A0", VA = "0x18411DDA0")]
	private TValue DGCGNLJMLGO(int KMCFICBBFCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x411DEC0", Offset = "0x411CAC0", VA = "0x18411DEC0")]
	private void HGCBCPJJEFN(int KMCFICBBFCD, in THandle LFGAIKKMBAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x411E600", Offset = "0x411D200", VA = "0x18411E600")]
	private void PBKLIEGIDKB(int KMCFICBBFCD, in TValue JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x411DF00", Offset = "0x411CB00", VA = "0x18411DF00")]
	private THandle HHCFPPOHBPB()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x411DCE0", Offset = "0x411C8E0", VA = "0x18411DCE0")]
	private void CGLAFJFBOAH(THandle LFGAIKKMBAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x411DCD0", Offset = "0x411C8D0", VA = "0x18411DCD0")]
	private int BMBEDIFJDEA(int KPEOHEHDBEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x411E4A0", Offset = "0x411D0A0", VA = "0x18411E4A0")]
	private bool KGKBNDFIMLD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED90", Offset = "0xA6D990", VA = "0x180A6ED90")]
	private void ICOGPOJPHMI(THandle LFGAIKKMBAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x411E4B0", Offset = "0x411D0B0", VA = "0x18411E4B0")]
	private bool KILHBJKOGIB(out THandle LFGAIKKMBAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x411E530", Offset = "0x411D130", VA = "0x18411E530")]
	private bool OCNHLPPJFBD(out THandle LFGAIKKMBAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x411E010", Offset = "0x411CC10", VA = "0x18411E010")]
	private void HKNPCPCLOPH(THandle LFGAIKKMBAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x411E380", Offset = "0x411CF80", VA = "0x18411E380")]
	private void KEMHENJFFHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface FEFCJIHAFNE
{
	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	int BPILIAKMPMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	int GJFFFBBIJDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public interface CKFAKJPPNKG<T> : FEFCJIHAFNE, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public static class GJKFGLPDCIA
{
	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x3764660", Offset = "0x3763260", VA = "0x183764660")]
	public static bool BPNFPEJLKDL<T>(this T LFGAIKKMBAH) where T : struct, FEFCJIHAFNE
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class FOOGCFIAAHF
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private enum KEFDGHHAPCG : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private int MJMBKIPNMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private bool HHMCCKLKPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private KEFDGHHAPCG NIAPLDBHODK;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool FGJDMGNDHIC
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x16FBC90", Offset = "0x16FA890", VA = "0x1816FBC90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool DOLOHKFFHKL
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x16FBB90", Offset = "0x16FA790", VA = "0x1816FBB90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x16FBF60", Offset = "0x16FAB60", VA = "0x1816FBF60")]
	public FOOGCFIAAHF(bool HHMCCKLKPIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x16FB270", Offset = "0x16F9E70", VA = "0x1816FB270")]
	public void FGCIIBHBAPB(object KLDDDNGBABC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x16FBE00", Offset = "0x16FAA00", VA = "0x1816FBE00")]
	public void NELINININJB(int JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x16FB260", Offset = "0x16F9E60", VA = "0x1816FB260")]
	public void DLKLOOFDEPH(uint IIPNIIOOHLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x16FBEB0", Offset = "0x16FAAB0", VA = "0x1816FBEB0")]
	public void NPNLINIIKMH(bool MKMDHNAKIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x16FBCA0", Offset = "0x16FA8A0", VA = "0x1816FBCA0")]
	public void KOMAGNMHNDG(long GKMPLOHOCIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x16FB790", Offset = "0x16FA390", VA = "0x1816FB790")]
	public void FPOAOHCGCNH(ulong EDNCKPBBHFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x16FB1F0", Offset = "0x16F9DF0", VA = "0x1816FB1F0")]
	public void CAOFBJMPDFK(string BEFOHGNCAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x16FBED0", Offset = "0x16FAAD0", VA = "0x1816FBED0")]
	public void PDPBGKLNBHC(Enum AADNPGFOACH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x16FBCE0", Offset = "0x16FA8E0", VA = "0x1816FBCE0")]
	public void LMIPAPCMLJB(IList NKPIPAAOHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x3359310", Offset = "0x3357F10", VA = "0x183359310")]
	public void KGBOBKLDKNF<T, U>(Dictionary<T, U> OCBJIMOOBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x16FB7D0", Offset = "0x16FA3D0", VA = "0x1816FB7D0")]
	private void GJLEAIJDDKD(IDictionary OCBJIMOOBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x16FBBB0", Offset = "0x16FA7B0", VA = "0x1816FBBB0")]
	public int IPHJFBLDFGN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x16FB180", Offset = "0x16F9D80", VA = "0x1816FB180")]
	public short ACOOIOJIINH()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x16FBBA0", Offset = "0x16FA7A0", VA = "0x1816FBBA0")]
	public void IJBCCCJHCJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x16FBC20", Offset = "0x16FA820", VA = "0x1816FBC20")]
	private void JNMLLOBAEHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public abstract class MIKNCDNDFOO<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	internal class AIBJGJMKELC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public TNode ADJBCMPCLMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public TNode IDFFNMDMLBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public HHFCPBCKPLG DEEJIANJDED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public List<HHFCPBCKPLG> MGALOBIKKEB;

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760490", VA = "0x180761890")]
		public AIBJGJMKELC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	internal struct HHFCPBCKPLG : IComparable<HHFCPBCKPLG>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public int MDPIGMOLBNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public TClaimant NBKIJBKEAGC;

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x57F980", Offset = "0x57E580", VA = "0x18057F980")]
		public HHFCPBCKPLG(int MDPIGMOLBNK, TClaimant NBKIJBKEAGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x3964DE0", Offset = "0x39639E0", VA = "0x183964DE0")]
		public bool PMDOLDENLDI(in HHFCPBCKPLG DEIAHGDLBHH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x3964DC0", Offset = "0x39639C0", VA = "0x183964DC0")]
		public bool BPPKOEGOJFL(in HHFCPBCKPLG DEIAHGDLBHH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x3964DD0", Offset = "0x39639D0", VA = "0x183964DD0", Slot = "4")]
		public int CompareTo(HHFCPBCKPLG DEIAHGDLBHH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x3964E40", Offset = "0x3963A40", VA = "0x183964E40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public enum GFJPANEGADG
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class OKEDLGCKLHB : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public global::MIKNCDNDFOO<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x129AA00", Offset = "0x1299600", VA = "0x18129AA00")]
		[DebuggerHidden]
		public OKEDLGCKLHB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x397AD20", Offset = "0x3979920", VA = "0x18397AD20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x397AEE0", Offset = "0x3979AE0", VA = "0x18397AEE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x397AE00", Offset = "0x3979A00", VA = "0x18397AE00", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x271DB50", Offset = "0x271C750", VA = "0x18271DB50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static readonly global::MJBIELHCKBM<AIBJGJMKELC> PCLIAGAKMCG;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static readonly global::MJBIELHCKBM<List<HHFCPBCKPLG>> LELNCBGHHLP;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static int HIEKJLEAAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	internal readonly Dictionary<TClaimant, TNode> KHAMEODCOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	internal readonly Dictionary<TNode, AIBJGJMKELC> LCFKDOLLDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private GFJPANEGADG KGGLFNEDFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private bool GPJNPICOMHB;

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode LKLIKPPNFLM(TNode ILAIGPHHGCD);

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void IAMGGCHCCBN(TNode ILAIGPHHGCD, TClaimant MNPBMHFOMDM, TClaimant MHHADOADPLG);

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x3975EE0", Offset = "0x3974AE0", VA = "0x183975EE0")]
	public MIKNCDNDFOO(GFJPANEGADG KGGLFNEDFOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x3974E30", Offset = "0x3973A30", VA = "0x183974E30")]
	public void CNGEMPDAJIM(TNode ILAIGPHHGCD, TNode CGNOFEDFEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x3974680", Offset = "0x3973280", VA = "0x183974680")]
	public void BECKCPCMFKP(TClaimant NBKIJBKEAGC, TNode LLAIFHHHJLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x3974F70", Offset = "0x3973B70", VA = "0x183974F70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x3975490", Offset = "0x3974090", VA = "0x183975490")]
	private void IIAJFHHEHOF(TClaimant NBKIJBKEAGC, TNode GKOKHHGMDIO, TNode LLAIFHHHJLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x3975970", Offset = "0x3974570", VA = "0x183975970")]
	private int LCBJFDEGNLD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x3974880", Offset = "0x3973480", VA = "0x183974880")]
	private void CAGANIFKDPI(TClaimant NBKIJBKEAGC, TNode EAFGLGLEFDH, TNode NKABGAJAMEB, int LJFNCNOBKMJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x3974B30", Offset = "0x3973730", VA = "0x183974B30")]
	private void CFBKDKHFAON(HHFCPBCKPLG KGGHJNDLHHK, AIBJGJMKELC MPNLKCLIGED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x3974BC0", Offset = "0x39737C0", VA = "0x183974BC0")]
	private void CGCPKCLOEDH(TClaimant NBKIJBKEAGC, TNode EAFGLGLEFDH, TNode NKABGAJAMEB, int LJFNCNOBKMJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x3974780", Offset = "0x3973380", VA = "0x183974780")]
	private void BNKFKCAPFPD(HHFCPBCKPLG KGGHJNDLHHK, TNode ILAIGPHHGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x3975390", Offset = "0x3973F90", VA = "0x183975390")]
	private void HFJJCILHFBA(HHFCPBCKPLG KGGHJNDLHHK, AIBJGJMKELC MPNLKCLIGED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x3975B70", Offset = "0x3974770", VA = "0x183975B70")]
	private void NNINCGIHEAP(AIBJGJMKELC MPNLKCLIGED, bool NHNPBDPHOCE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x3975530", Offset = "0x3974130", VA = "0x183975530")]
	private void JJMLFLOKLHO(AIBJGJMKELC MPNLKCLIGED, TNode CGNOFEDFEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x3975CB0", Offset = "0x39748B0", VA = "0x183975CB0")]
	[IteratorStateMachine(typeof(global::MIKNCDNDFOO<, >.OKEDLGCKLHB))]
	private IEnumerable<TNode> PKKEABNCIMM(TNode EAFGLGLEFDH, TNode NKABGAJAMEB, bool MDAIAGIEPDB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x3974EB0", Offset = "0x3973AB0", VA = "0x183974EB0")]
	private AIBJGJMKELC DFNJEJBFELK(TNode ILAIGPHHGCD, TNode IDFFNMDMLBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x39759E0", Offset = "0x39745E0", VA = "0x1839759E0")]
	private AIBJGJMKELC MKBCONBABGA(TNode ILAIGPHHGCD, TNode IDFFNMDMLBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x39751D0", Offset = "0x3973DD0", VA = "0x1839751D0")]
	private void HCHEBILMNJN(AIBJGJMKELC MPNLKCLIGED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class AOCCBFGOODI<T> : IEnumerable<global::AOCCBFGOODI<T>.CIEPKGMKOPB>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public struct CIEPKGMKOPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public T JHEBJPCMJGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int KMCFICBBFCD;
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class FENODPHJCJB : IEnumerator<CIEPKGMKOPB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private global::AOCCBFGOODI<T> FDGENIDGIIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private int KMCFICBBFCD;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x299A9D0", Offset = "0x29995D0", VA = "0x18299A9D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public CIEPKGMKOPB JACKEFHMHDB
		{
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x299AA40", Offset = "0x2999640", VA = "0x18299AA40", Slot = "4")]
			get
			{
				return default(CIEPKGMKOPB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x5BCE70", Offset = "0x5BBA70", VA = "0x1805BCE70")]
		public FENODPHJCJB(global::AOCCBFGOODI<T> FDGENIDGIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x299A940", Offset = "0x2999540", VA = "0x18299A940", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x5BCE60", Offset = "0x5BBA60", VA = "0x1805BCE60", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0xA70EF0", Offset = "0xA6FAF0", VA = "0x180A70EF0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private struct NJCHMKAJKAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public bool JGBEKALADPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public T JHEBJPCMJGD;
	}

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int NEMNGPEGBAO = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private Dictionary<T, int> JFGKKPHGIAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NJCHMKAJKAM[] OGHJNAIBDAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int CPAMPCLPFML;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public int IAPBBGBICKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x762560", Offset = "0x761160", VA = "0x180762560")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x2995650", Offset = "0x2994250", VA = "0x182995650")]
	public static global::AOCCBFGOODI<T> JCBIPANJHNK(CIEPKGMKOPB[] MDEMMHPDMGI, bool MGHABCOPECL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x2995B00", Offset = "0x2994700", VA = "0x182995B00")]
	public AOCCBFGOODI(int EAAJKPJKHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x11EDD70", Offset = "0x11EC970", VA = "0x1811EDD70")]
	public bool FHECECHEOLF(T JHEBJPCMJGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x29951C0", Offset = "0x2993DC0", VA = "0x1829951C0")]
	public bool CABAFBAHGME(int KMCFICBBFCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x2995340", Offset = "0x2993F40", VA = "0x182995340")]
	public bool FCKGFBCLJGJ(Func<T, bool> NHAFICHPNOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x29955B0", Offset = "0x29941B0", VA = "0x1829955B0")]
	public int HGBDEPDKFEP(T JHEBJPCMJGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x29952D0", Offset = "0x2993ED0", VA = "0x1829952D0")]
	public T DGCGNLJMLGO(int KMCFICBBFCD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x2995600", Offset = "0x2994200", VA = "0x182995600")]
	public void IJBCCCJHCJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x2994F70", Offset = "0x2993B70", VA = "0x182994F70")]
	public bool AMIPHNDNCGN(T JHEBJPCMJGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x2994F90", Offset = "0x2993B90", VA = "0x182994F90")]
	public bool AMIPHNDNCGN(T JHEBJPCMJGD, int KMCFICBBFCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x2994EF0", Offset = "0x2993AF0", VA = "0x182994EF0")]
	public bool AFEKNPNIBII(T JHEBJPCMJGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x2995560", Offset = "0x2994160", VA = "0x182995560")]
	public bool HFLIJOGBHNO(int KMCFICBBFCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x2995220", Offset = "0x2993E20", VA = "0x182995220")]
	private void COPOMAMCFJG(int KMCFICBBFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x29953F0", Offset = "0x2993FF0", VA = "0x1829953F0")]
	public CIEPKGMKOPB[] GEMJKIMGFLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x2995A30", Offset = "0x2994630", VA = "0x182995A30")]
	private int PGBPPLEMNGA(int NJKMJOGIJKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x2995A80", Offset = "0x2994680", VA = "0x182995A80", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x2995A80", Offset = "0x2994680", VA = "0x182995A80", Slot = "4")]
	private IEnumerator<CIEPKGMKOPB> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class MJBIELHCKBM<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly Stack<T> GBGDBMODNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly List<T> CEMFEKJFINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly int IPFBNMCFJMA;

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public int JEDOJKHGCHH
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xEEDB60", Offset = "0xEEC760", VA = "0x180EEDB60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public int LPILKAPIKIO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x138B620", Offset = "0x138A220", VA = "0x18138B620")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x3976810", Offset = "0x3975410", VA = "0x183976810")]
	public static global::MJBIELHCKBM<T> HJMONFBBKOE(int EAAJKPJKHNJ = 0, int IPFBNMCFJMA = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x3976AE0", Offset = "0x39756E0", VA = "0x183976AE0")]
	public static global::MJBIELHCKBM<T> LPDKNHFOANA(int EAAJKPJKHNJ = 0, int IPFBNMCFJMA = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x3976FA0", Offset = "0x3975BA0", VA = "0x183976FA0")]
	public MJBIELHCKBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x3976E10", Offset = "0x3975A10", VA = "0x183976E10")]
	public MJBIELHCKBM(int EAAJKPJKHNJ, int IPFBNMCFJMA = int.MaxValue, bool DNHGNLFAAIA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x39768E0", Offset = "0x39754E0", VA = "0x1839768E0")]
	public T HNGHIKIECGL()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x3976580", Offset = "0x3975180", VA = "0x183976580")]
	public void BGLOCOJJHEC(T JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x3976640", Offset = "0x3975240", VA = "0x183976640")]
	private void CJENKNDCHIF(T JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x3976AC0", Offset = "0x39756C0", VA = "0x183976AC0")]
	private void JMFMIPHKIOO(T JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x3976D70", Offset = "0x3975970", VA = "0x183976D70")]
	[Conditional("DEBUG_BUILD")]
	private void MIGIPECBGAA(T IHKHDMEENDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x3976A10", Offset = "0x3975610", VA = "0x183976A10")]
	[Conditional("DEBUG_BUILD")]
	private void JBCCKBFIJLH(T IHKHDMEENDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x3976700", Offset = "0x3975300", VA = "0x183976700", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x3976BB0", Offset = "0x39757B0", VA = "0x183976BB0")]
	private void MEDJFMLOJGC(IEnumerable<T> JBGIJHKCMJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class DOFMLHAEABM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private Dictionary<int, T> LOOIMAHFIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private T GPBGPJCKILC;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public virtual T FPOJIMBIGEC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x556460", Offset = "0x555060", VA = "0x180556460", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool DPPIJMFLPGC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x32D7A10", Offset = "0x32D6610", VA = "0x1832D7A10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x32D77B0", Offset = "0x32D63B0", VA = "0x1832D77B0")]
	public bool CPPEMODJEHC(T JHEBJPCMJGD, int MDPIGMOLBNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x32D7810", Offset = "0x32D6410", VA = "0x1832D7810")]
	public bool EINMKINKIBF(int MDPIGMOLBNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x32D7AE0", Offset = "0x32D66E0", VA = "0x1832D7AE0")]
	public T MPNPDLPAEGP(int CNIKCKFBHHM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x32D7A80", Offset = "0x32D6680", VA = "0x1832D7A80")]
	public void IJBCCCJHCJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x32D7870", Offset = "0x32D6470", VA = "0x1832D7870")]
	private bool ENJAMFHPBJB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x32D7A50", Offset = "0x32D6650", VA = "0x1832D7A50")]
	public bool ICGEJEGNFAB(int MDPIGMOLBNK, out T JHEBJPCMJGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x32D7FB0", Offset = "0x32D6BB0", VA = "0x1832D7FB0")]
	public DOFMLHAEABM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class IIKNIMIILDC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	protected struct KOMPEANGIEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public T EFFCIDNMALB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public int HNCAPNPFGDF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	protected readonly List<KOMPEANGIEN> NAICNCLLFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private T JBDEABLIEMH;

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public int IAPBBGBICKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x761860", Offset = "0x760460", VA = "0x180761860")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x1009620", Offset = "0x1008220", VA = "0x181009620")]
	public bool FCKGFBCLJGJ(T JHEBJPCMJGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x10094F0", Offset = "0x10080F0", VA = "0x1810094F0")]
	public void DLPDCPCMKFM(T JHEBJPCMJGD, int MDPIGMOLBNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x10093D0", Offset = "0x1007FD0", VA = "0x1810093D0")]
	public bool AFEKNPNIBII(T JHEBJPCMJGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x1009A80", Offset = "0x1008680", VA = "0x181009A80")]
	public void IJBCCCJHCJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x1009590", Offset = "0x1008190", VA = "0x181009590")]
	public T EKNNNIKJPCC()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x1009AE0", Offset = "0x10086E0", VA = "0x181009AE0")]
	public T NDLLJDEAMFA()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x1009870", Offset = "0x1008470", VA = "0x181009870")]
	private void GOIKDPPOFDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x1009B50", Offset = "0x1008750", VA = "0x181009B50")]
	public IIKNIMIILDC()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[SerializeField]
		[DPPCAMLCCHE(JNPNDJBCKEE.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x16FE530", Offset = "0x16FD130", VA = "0x1816FE530")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x16FEA00", Offset = "0x16FD600", VA = "0x1816FEA00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x16FE820", Offset = "0x16FD420", VA = "0x1816FE820")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x16FEBA0", Offset = "0x16FD7A0", VA = "0x1816FEBA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x16FE3F0", Offset = "0x16FCFF0", VA = "0x1816FE3F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x16FE8C0", Offset = "0x16FD4C0", VA = "0x1816FE8C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x16FE6E0", Offset = "0x16FD2E0", VA = "0x1816FE6E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x16FE350", Offset = "0x16FCF50", VA = "0x1816FE350")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface BCGCANLNIIN
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public abstract class ResourcePrefabReference<T> : BCGCANLNIIN where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x271D880", Offset = "0x271C480", VA = "0x18271D880", Slot = "4")]
		public virtual T NEADDADNAAL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760490", VA = "0x180761890")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class OKACHBGIHPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private readonly Dictionary<byte, BMLBLOOMCEP> IGFMNCEGEAF;

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public BMLBLOOMCEP IODMDNJDJBH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x553480", Offset = "0x552080", VA = "0x180553480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x577180", Offset = "0x575D80", VA = "0x180577180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Vector2 OAJDNNBPCHC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xD1F6E0", Offset = "0xD1E2E0", VA = "0x180D1F6E0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x1550300", Offset = "0x154EF00", VA = "0x181550300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Vector2 LFPOMPJILJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xBB4EA0", Offset = "0xBB3AA0", VA = "0x180BB4EA0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xBB4EC0", Offset = "0xBB3AC0", VA = "0x180BB4EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Vector2 BJAIJLEIGKP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x16FD980", Offset = "0x16FC580", VA = "0x1816FD980")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x16FD960", Offset = "0x16FC560", VA = "0x1816FD960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int ICLKCENBLJP
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x630780", Offset = "0x62F380", VA = "0x180630780")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED90", Offset = "0xA6D990", VA = "0x180A6ED90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x16FDAD0", Offset = "0x16FC6D0", VA = "0x1816FDAD0")]
	public OKACHBGIHPK(Bounds OFKGAEDFAIJ, Vector2[] ICOAAIAAOMB, int LBOFIGLNBDK, byte NJKMJOGIJKL, float ECKDKBLBEON = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x16FD2D0", Offset = "0x16FBED0", VA = "0x1816FD2D0")]
	public BMLBLOOMCEP AADINBHAFHE(byte KMCFICBBFCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x16FD870", Offset = "0x16FC470", VA = "0x1816FD870")]
	public void GPBEGFNOKGJ(Vector3 JFHKCFAKLKK, float JAOOLBJDLPI, float EEADEMKLNJM, ref List<byte> KENOOKKGGNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x16FD850", Offset = "0x16FC450", VA = "0x1816FD850")]
	public void FOIKHOOAKAN(BMLBLOOMCEP.FEKHMBPPCBK FOBHDHIMHPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x16FD9A0", Offset = "0x16FC5A0", VA = "0x1816FD9A0")]
	private BMLBLOOMCEP PDLEADDFKAN(byte KMCFICBBFCD, BMLBLOOMCEP.CBLLPOHOAPD GLFHFJMDBFF, BMLBLOOMCEP IDFFNMDMLBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x16FD330", Offset = "0x16FBF30", VA = "0x1816FD330")]
	private void CMLLEEDHGGJ(BMLBLOOMCEP IDFFNMDMLBG, Vector2[] ICOAAIAAOMB, int HOAPDCOPFAK, int FHIELDKPOHD, int FELPFDCPHOL, int LFIAGDCOGHH, float ECKDKBLBEON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class BMLBLOOMCEP
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public enum CBLLPOHOAPD
	{
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public enum FEKHMBPPCBK
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public byte IPADIMKAEBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public Vector3 NKBAEMFKHMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public Vector3 OKLPHEBIEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public Vector3 GIKACOLGDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public Vector3 POFEBEDELEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public CBLLPOHOAPD OPLCGLCHBMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public BMLBLOOMCEP DCHLIMBOGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public List<BMLBLOOMCEP> COBCKIEAOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public bool NBCMKAPBIIE;

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x16FA3C0", Offset = "0x16F8FC0", VA = "0x1816FA3C0")]
	public BMLBLOOMCEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x16FA3E0", Offset = "0x16F8FE0", VA = "0x1816FA3E0")]
	public BMLBLOOMCEP(byte CPMOGHLIOBH, CBLLPOHOAPD GLFHFJMDBFF, BMLBLOOMCEP IDFFNMDMLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x16F9FF0", Offset = "0x16F8BF0", VA = "0x1816F9FF0")]
	public void CFGMBHAHMND(BMLBLOOMCEP BNNAACNBBAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30")]
	public void FOIKHOOAKAN(int CKIALEMMCOH, FEKHMBPPCBK FOBHDHIMHPI, int DNFFBDFHLLG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x16FA0D0", Offset = "0x16F8CD0", VA = "0x1816FA0D0")]
	public void GPBEGFNOKGJ(List<byte> KENOOKKGGNO, Vector3 JFHKCFAKLKK, float JAOOLBJDLPI, float EEADEMKLNJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x16FA360", Offset = "0x16F8F60", VA = "0x1816FA360")]
	public bool MMMCJNBHIBI(Vector3 IABANLOJEAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x16FA090", Offset = "0x16F8C90", VA = "0x1816FA090")]
	public bool DFPHMLLIJGN(Vector3 IABANLOJEAM, float GFIPEOGKPKC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class DGLANNFCDHF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly Dictionary<T, object> LLBNBHCPKGL;

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x142BCC0", Offset = "0x142A8C0", VA = "0x18142BCC0")]
	public bool GEOIACFHNAJ(T IDNPEEOFGCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x3D6F8A0", Offset = "0x3D6E4A0", VA = "0x183D6F8A0")]
	public bool GEOIACFHNAJ(T IDNPEEOFGCC, object BCFIBCIPMFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x3D6F840", Offset = "0x3D6E440", VA = "0x183D6F840")]
	public bool GEOIACFHNAJ(T IDNPEEOFGCC, object BCFIBCIPMFN, out object EPDLFAFIBJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x3D6F970", Offset = "0x3D6E570", VA = "0x183D6F970")]
	public bool JPBJODJECAC(T IDNPEEOFGCC, object BCFIBCIPMFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x3D6F9B0", Offset = "0x3D6E5B0", VA = "0x183D6F9B0")]
	public bool KPGKIBMCGIA(T IDNPEEOFGCC, object BCFIBCIPMFN, out object EPDLFAFIBJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x3D6F8E0", Offset = "0x3D6E4E0", VA = "0x183D6F8E0")]
	public bool JPBJODJECAC(T IDNPEEOFGCC, object BCFIBCIPMFN, out object EPDLFAFIBJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x1009FD0", Offset = "0x1008BD0", VA = "0x181009FD0")]
	public void MKPJDHGAGEJ(T IDNPEEOFGCC, object BCFIBCIPMFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x3D6F7A0", Offset = "0x3D6E3A0", VA = "0x183D6F7A0")]
	public void ANECOLIJLPA(T IDNPEEOFGCC, object BCFIBCIPMFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x3D6F9F0", Offset = "0x3D6E5F0", VA = "0x183D6F9F0")]
	public DGLANNFCDHF()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		public struct DEBNBNGDNKP<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			private readonly List<Component> NKPIPAAOHKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			private readonly bool CGBFJOPGIEJ;

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x94A310", Offset = "0x948F10", VA = "0x18094A310")]
			public DEBNBNGDNKP(List<Component> NKPIPAAOHKF, bool CGBFJOPGIEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x27109D0", Offset = "0x270F5D0", VA = "0x1827109D0")]
			public IBENINPCJKN<T> KOBMKMHPKIK()
			{
				return default(IBENINPCJKN<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x2710A40", Offset = "0x270F640", VA = "0x182710A40", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x2710A40", Offset = "0x270F640", VA = "0x182710A40", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public struct IBENINPCJKN<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			private readonly List<Component> NKPIPAAOHKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			private readonly bool CGBFJOPGIEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			private int KMCFICBBFCD;

			[Cpp2IlInjected.Token(Token = "0x17000087")]
			public T JACKEFHMHDB
			{
				[Cpp2IlInjected.Token(Token = "0x6000318")]
				[Cpp2IlInjected.Address(RVA = "0x2710F90", Offset = "0x270FB90", VA = "0x182710F90", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000088")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000319")]
				[Cpp2IlInjected.Address(RVA = "0x2710F20", Offset = "0x270FB20", VA = "0x182710F20", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x2710F60", Offset = "0x270FB60", VA = "0x182710F60")]
			public IBENINPCJKN(List<Component> NKPIPAAOHKF, bool CGBFJOPGIEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x2710E50", Offset = "0x270FA50", VA = "0x182710E50", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x2710E60", Offset = "0x270FA60", VA = "0x182710E60", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x2710F10", Offset = "0x270FB10", VA = "0x182710F10", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x1700860", Offset = "0x16FF460", VA = "0x181700860")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x1700820", Offset = "0x16FF420", VA = "0x181700820")]
		public ToolHierarchyCache(GameObject EHMGOIGEBCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x17005E0", Offset = "0x16FF1E0", VA = "0x1817005E0")]
		private void NFHIBICHHJH(GameObject EHMGOIGEBCM, bool LBMPEPOBNEM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x1700550", Offset = "0x16FF150", VA = "0x181700550")]
		public static void NFHIBICHHJH(GameObject EHMGOIGEBCM, ref ToolHierarchyCache PHIGJGFEFCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x1700480", Offset = "0x16FF080", VA = "0x181700480")]
		public void HDLJOJPILAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x17003C0", Offset = "0x16FEFC0", VA = "0x1817003C0")]
		public void FAOEPLKKNIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FEF0", Offset = "0x2B9EAF0", VA = "0x182B9FEF0")]
		public void OGGDCCOGBII<T>(Action<T> LKFICPAOGAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x1700700", Offset = "0x16FF300", VA = "0x181700700")]
		public Component NHMBBIOHALA(Type IONHFMDGLFB, bool CGBFJOPGIEJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x28C7960", Offset = "0x28C6560", VA = "0x1828C7960")]
		public T NHMBBIOHALA<T>(bool CGBFJOPGIEJ = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x1700000", Offset = "0x16FEC00", VA = "0x181700000")]
		public DEBNBNGDNKP<Component> BDNHFHMPKIK(Type IONHFMDGLFB, bool CGBFJOPGIEJ = false)
		{
			return default(DEBNBNGDNKP<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x2F28470", Offset = "0x2F27070", VA = "0x182F28470")]
		public DEBNBNGDNKP<T> BDNHFHMPKIK<T>(bool CGBFJOPGIEJ = false) where T : class
		{
			return default(DEBNBNGDNKP<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x1700090", Offset = "0x16FEC90", VA = "0x181700090")]
		public List<Component> CLFKJAINGJC(Type IONHFMDGLFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x1700340", Offset = "0x16FEF40", VA = "0x181700340", Slot = "4")]
		public bool Equals(ToolHierarchyCache PKLHFCEKMJB, ToolHierarchyCache JGEGPABGNNL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x1700410", Offset = "0x16FF010", VA = "0x181700410", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache KLDDDNGBABC)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public class OJNILGPBIEN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int EAAJKPJKHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private int LOFGOMNMONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private List<T> FKNEPAONFGO;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int IAPBBGBICKL
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0xEEDB60", Offset = "0xEEC760", VA = "0x180EEDB60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public T BMDPDMGFGOK
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x296DEA0", Offset = "0x296CAA0", VA = "0x18296DEA0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public T CIPPCBEBGDE
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x296DC20", Offset = "0x296C820", VA = "0x18296DC20")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public T BMICCCBPGEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x296DDB0", Offset = "0x296C9B0", VA = "0x18296DDB0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x296DF70", Offset = "0x296CB70", VA = "0x18296DF70")]
	public OJNILGPBIEN(int EAAJKPJKHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x296DAE0", Offset = "0x296C6E0", VA = "0x18296DAE0")]
	public void DLPDCPCMKFM(T FNGGPEJDGHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x296DC60", Offset = "0x296C860", VA = "0x18296DC60")]
	public void IJBCCCJHCJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x296DCA0", Offset = "0x296C8A0", VA = "0x18296DCA0")]
	public void LCHCDCKOIMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x296DF20", Offset = "0x296CB20", VA = "0x18296DF20")]
	public void POKOKBENCOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x296D9F0", Offset = "0x296C5F0", VA = "0x18296D9F0")]
	public void BIEBFKCGENH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public class FFOJJBBNJGM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private bool MMBNMOLKBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private Action LKFICPAOGAF;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public static FFOJJBBNJGM PGEFGPDPEBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x16FAF20", Offset = "0x16F9B20", VA = "0x1816FAF20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool MONCEHKLPEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x62AF80", Offset = "0x629B80", VA = "0x18062AF80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x700E40", Offset = "0x6FFA40", VA = "0x180700E40")]
	public FFOJJBBNJGM(Action LKFICPAOGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x16FAFA0", Offset = "0x16F9BA0", VA = "0x1816FAFA0")]
	public void OMAIJKDLOLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x16FAFA0", Offset = "0x16F9BA0", VA = "0x1816FAFA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class IMFKPCJJHGJ
{
	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30")]
	public static void JOBFFMEPMHJ(DJFMPKNHLPB GMKLCAJKMBN, string ICCMPDDCPEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class EPOGOBOJPAA<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	private struct FMHHKFLAMID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public int HNCAPNPFGDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public T EFFCIDNMALB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private Dictionary<object, FMHHKFLAMID> LOOIMAHFIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private T GPBGPJCKILC;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public virtual T FPOJIMBIGEC
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xD1F6E0", Offset = "0xD1E2E0", VA = "0x180D1F6E0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x1550300", Offset = "0x154EF00", VA = "0x181550300", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public bool DPPIJMFLPGC
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x368BAA0", Offset = "0x368A6A0", VA = "0x18368BAA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public object FIEJPGOJGJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x5534B0", Offset = "0x5520B0", VA = "0x1805534B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x556540", Offset = "0x555140", VA = "0x180556540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x3686860", Offset = "0x3685460", VA = "0x183686860")]
	public bool CPPEMODJEHC(T JHEBJPCMJGD, object BCFIBCIPMFN, int MDPIGMOLBNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x3686DA0", Offset = "0x36859A0", VA = "0x183686DA0")]
	public bool EINMKINKIBF(object BCFIBCIPMFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x368BEA0", Offset = "0x368AAA0", VA = "0x18368BEA0")]
	public bool ICGEJEGNFAB(object BCFIBCIPMFN, out T JHEBJPCMJGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x3616F90", Offset = "0x3615B90", VA = "0x183616F90")]
	public void IJBCCCJHCJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x3687850", Offset = "0x3686450", VA = "0x183687850")]
	private bool ENJAMFHPBJB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x32D7FB0", Offset = "0x32D6BB0", VA = "0x1832D7FB0")]
	public EPOGOBOJPAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class OLDKJNABMML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private Dictionary<object, float> LOOIMAHFIOO;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public float EHAOONMPCPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x87C4D0", Offset = "0x87B0D0", VA = "0x18087C4D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x87C680", Offset = "0x87B280", VA = "0x18087C680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x16FDFF0", Offset = "0x16FCBF0", VA = "0x1816FDFF0")]
	public void CPPEMODJEHC(float JHEBJPCMJGD, object BCFIBCIPMFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x16FE180", Offset = "0x16FCD80", VA = "0x1816FE180")]
	public void EINMKINKIBF(object BCFIBCIPMFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x16FE060", Offset = "0x16FCC60", VA = "0x1816FE060")]
	private void EANKEDEDIFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x16FE1F0", Offset = "0x16FCDF0", VA = "0x1816FE1F0")]
	public OLDKJNABMML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public sealed class DJFMPKNHLPB
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public sealed class NNCAKDNCCCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private readonly string ALPCCDGHGOC;

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		private NNCAKDNCCCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x5B97A0", Offset = "0x5B83A0", VA = "0x1805B97A0")]
		public NNCAKDNCCCJ(string ALPCCDGHGOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x16FD1B0", Offset = "0x16FBDB0", VA = "0x1816FD1B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class AJHEIFKBIAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		public AJHEIFKBIAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x16F9DA0", Offset = "0x16F89A0", VA = "0x1816F9DA0")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private readonly HashSet<object> OAOGDCBHKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private int MNBKIIPNJDA;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool AFFBEKBPCNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x16FABB0", Offset = "0x16F97B0", VA = "0x1816FABB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public int IAPBBGBICKL
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x553470", Offset = "0x552070", VA = "0x180553470")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x16FABC0", Offset = "0x16F97C0", VA = "0x1816FABC0")]
	public bool DLPDCPCMKFM(object BCFIBCIPMFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x16FAB30", Offset = "0x16F9730", VA = "0x1816FAB30")]
	public bool AFEKNPNIBII(object BCFIBCIPMFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x16FAC40", Offset = "0x16F9840", VA = "0x1816FAC40")]
	public bool FCKGFBCLJGJ(object BCFIBCIPMFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x16FACA0", Offset = "0x16F98A0", VA = "0x1816FACA0")]
	public void FODKCHINPOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x16FAD00", Offset = "0x16F9900", VA = "0x1816FAD00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x16FAE70", Offset = "0x16F9A70", VA = "0x1816FAE70")]
	public DJFMPKNHLPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public class DFKCBKAGHPI<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private struct OPNDGFFCFFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public float DEPAJLEIJPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public T EFFCIDNMALB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private Dictionary<object, OPNDGFFCFFF> LOOIMAHFIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private T DGLBCADLKLJ;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public virtual T MPNKJPGJJEP
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x124EC20", Offset = "0x124D820", VA = "0x18124EC20", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x1F44FE0", Offset = "0x1F43BE0", VA = "0x181F44FE0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public object FLFHBJKPANA
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x5534B0", Offset = "0x5520B0", VA = "0x1805534B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x6131E0", Offset = "0x611DE0", VA = "0x1806131E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool DPPIJMFLPGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x3616E00", Offset = "0x3615A00", VA = "0x183616E00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x3D6EBB0", Offset = "0x3D6D7B0", VA = "0x183D6EBB0")]
	public bool CPPEMODJEHC(T JHEBJPCMJGD, object BCFIBCIPMFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x3615F00", Offset = "0x3614B00", VA = "0x183615F00")]
	public bool EINMKINKIBF(object BCFIBCIPMFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x3616F90", Offset = "0x3615B90", VA = "0x183616F90")]
	public void IJBCCCJHCJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x3616E40", Offset = "0x3615A40", VA = "0x183616E40")]
	public bool ICGEJEGNFAB(object BCFIBCIPMFN, out T JHEBJPCMJGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x3616A20", Offset = "0x3615620", VA = "0x183616A20")]
	private bool ENJAMFHPBJB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x3616FE0", Offset = "0x3615BE0", VA = "0x183616FE0")]
	public DFKCBKAGHPI()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000097")]
public class DFHLNHOECAE
{
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private static byte[] BPCJOEHDNHL;

	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private static int JGOMGPKCOBP;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private static int EJPBFKNOMCK;

	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private static BigInteger DKHAKAEJLPK;

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public DFHLNHOECAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x16FA540", Offset = "0x16F9140", VA = "0x1816FA540")]
	private static string ALAJABKKJNA(byte[] JCHDICMDCKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x16FA640", Offset = "0x16F9240", VA = "0x1816FA640")]
	public static string NBAPPGOEMPA(byte[] GLAICJAMEED, bool NFOOKAPIMMN)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000099")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000168")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200009A")]
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
