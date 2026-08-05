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
public class HPAPEGCNHMA : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6B3AC0", Offset = "0x6B2AC0", VA = "0x1806B3AC0")]
	public HPAPEGCNHMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4B7A680", Offset = "0x4B79680", VA = "0x184B7A680")]
	public byte[] MIFEAFBHDBA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void AGIHNMMOCKD(IncrementalHash HMPDEPCCOHA);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xCF8920", Offset = "0xCF7920", VA = "0x180CF8920")]
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
	[DOBDDBEGPMO]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	[DOBDDBEGPMO]
	[HideInInspector]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4B7DDE0", Offset = "0x4B7CDE0", VA = "0x184B7DDE0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4B7DDA0", Offset = "0x4B7CDA0", VA = "0x184B7DDA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4B7DE20", Offset = "0x4B7CE20", VA = "0x184B7DE20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4B7E030", Offset = "0x4B7D030", VA = "0x184B7E030")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4B7DFA0", Offset = "0x4B7CFA0", VA = "0x184B7DFA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xEE0760", Offset = "0xEDF760", VA = "0x180EE0760")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xF131C0", Offset = "0xF121C0", VA = "0x180F131C0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4B7DD60", Offset = "0x4B7CD60", VA = "0x184B7DD60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4B7DF10", Offset = "0x4B7CF10", VA = "0x184B7DF10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4B7D850", Offset = "0x4B7C850", VA = "0x184B7D850")]
	public void CopyBounds(SavedExtents JFBDCEDLHDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4B7DCD0", Offset = "0x4B7CCD0", VA = "0x184B7DCD0")]
	public void SetLocalSpaceBounds(Bounds GCEHGNKCIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x85D130", Offset = "0x85C130", VA = "0x18085D130")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4B7DCC0", Offset = "0x4B7CCC0", VA = "0x184B7DCC0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4B7D880", Offset = "0x4B7C880", VA = "0x184B7D880")]
	private void OHIKABOAOOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4B7DA90", Offset = "0x4B7CA90", VA = "0x184B7DA90")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4B7D290", Offset = "0x4B7C290", VA = "0x184B7D290")]
	public static void CalculateLocalBoundsFor(GameObject CDELJLCJCHC, out Bounds GCEHGNKCIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4B7D1D0", Offset = "0x4B7C1D0", VA = "0x184B7D1D0")]
	private static void AEIJGIELIJI(Bounds EJCAMPCKMFA, Color AMPIDGKCPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4B7DCF0", Offset = "0x4B7CCF0", VA = "0x184B7DCF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5231D0", Offset = "0x5221D0", VA = "0x1805231D0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x523EE0", Offset = "0x522EE0", VA = "0x180523EE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5234A0", Offset = "0x5224A0", VA = "0x1805234A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x523E80", Offset = "0x522E80", VA = "0x180523E80", Slot = "4")]
	public virtual void OHNLDEDEDKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1C193A0", Offset = "0x1C183A0", VA = "0x181C193A0")]
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
	[HPAPEGCNHMA]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3E06040", Offset = "0x3E05040", VA = "0x183E06040", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3E05B80", Offset = "0x3E04B80", VA = "0x183E05B80", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3E06640", Offset = "0x3E05640", VA = "0x183E06640")]
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
	private sealed class IOHFHPOGOIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1C193A0", Offset = "0x1C183A0", VA = "0x181C193A0")]
		public IOHFHPOGOIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x372DCF0", Offset = "0x372CCF0", VA = "0x18372DCF0")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[HPAPEGCNHMA]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5231D0", Offset = "0x5221D0", VA = "0x1805231D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x372DA20", Offset = "0x372CA20", VA = "0x18372DA20", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x372DA50", Offset = "0x372CA50", VA = "0x18372DA50", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x372D970", Offset = "0x372C970", VA = "0x18372D970", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public TVal this[TKey ACPAGAEJCEC]
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x372D9A0", Offset = "0x372C9A0", VA = "0x18372D9A0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x372D870", Offset = "0x372C870", VA = "0x18372D870", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x372D0D0", Offset = "0x372C0D0", VA = "0x18372D0D0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x372CA40", Offset = "0x372BA40", VA = "0x18372CA40", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x372C5B0", Offset = "0x372B5B0", VA = "0x18372C5B0", Slot = "14")]
	protected virtual string CPHDKPFFIMM(TKeyVal INKHJJDIFCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2AD80A0", Offset = "0x2AD70A0", VA = "0x182AD80A0", Slot = "4")]
	public bool ContainsKey(TKey ACPAGAEJCEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x372D760", Offset = "0x372C760", VA = "0x18372D760", Slot = "5")]
	public bool TryGetValue(TKey ACPAGAEJCEC, out TVal PLIDGBGAHIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x372C640", Offset = "0x372B640", VA = "0x18372C640", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x372C640", Offset = "0x372B640", VA = "0x18372C640", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x372D790", Offset = "0x372C790", VA = "0x18372D790")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class MHDHAEHNDJJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class GILAIFFCPKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1C193A0", Offset = "0x1C183A0", VA = "0x181C193A0")]
		public GILAIFFCPKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2FE12B0", Offset = "0x2FE02B0", VA = "0x182FE12B0")]
		internal bool <GetSamples>b__0(global::KNHNPGHCLLP<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly float HCILPOKGOOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly float CEDNJJJIEAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private List<global::KNHNPGHCLLP<float, T>> GGPNLCJGFMB;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int KNLCBLCEJEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2FF6B40", Offset = "0x2FF5B40", VA = "0x182FF6B40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2267130", Offset = "0x2266130", VA = "0x182267130")]
	public MHDHAEHNDJJ(float NGCBJLAEAKH, float GIIKHCOAHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2FF6BC0", Offset = "0x2FF5BC0", VA = "0x182FF6BC0")]
	public bool IMBALNNGOPC(float KDEDLIAMPCL, T PLIDGBGAHIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2266C30", Offset = "0x2265C30", VA = "0x182266C30")]
	public int IJFEGMFBDBC(float KDEDLIAMPCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2266DF0", Offset = "0x2265DF0", VA = "0x182266DF0")]
	public IEnumerable<T> PMGMCKMMCCD(float KDEDLIAMPCL, [Optional] float? ODOPCHGEGNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2266B80", Offset = "0x2265B80", VA = "0x182266B80")]
	public void EMKEODJBGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2266AC0", Offset = "0x2265AC0", VA = "0x182266AC0")]
	private void BOGCKEPPFNK(float KDEDLIAMPCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class LHNLEAFBALF<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct JNKLFDGDGFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public T OGNMMFGGOMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float GGALIFFNDNH;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static float PHGJFOJJJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private List<T> IFDDALIEPJB;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private const int GFCKHFOPAMJ = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private JNKLFDGDGFE[] DPLIBGFAGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int EGPCBKEEDCK;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float LPACBCIDAFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xFD3CF0", Offset = "0xFD2CF0", VA = "0x180FD3CF0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xFD3D00", Offset = "0xFD2D00", VA = "0x180FD3D00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x36281C0", Offset = "0x36271C0", VA = "0x1836281C0")]
	public LHNLEAFBALF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x36280E0", Offset = "0x36270E0", VA = "0x1836280E0")]
	public LHNLEAFBALF(int BGJKLECOEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x36270D0", Offset = "0x36260D0", VA = "0x1836270D0")]
	public void IPMJFBAMOHP(float KDEDLIAMPCL, T PLIDGBGAHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3626D30", Offset = "0x3625D30", VA = "0x183626D30")]
	public void EMKEODJBGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3627710", Offset = "0x3626710", VA = "0x183627710")]
	public bool PBKIDCFGPJD(float GAPPLJGNHFM, float MJLHHHBDBOD, out T PLIDGBGAHIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x36275A0", Offset = "0x36265A0", VA = "0x1836275A0")]
	public bool KFGJBKAODPO(float GAPPLJGNHFM, float MJLHHHBDBOD, out T PLIDGBGAHIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3627F40", Offset = "0x3626F40", VA = "0x183627F40")]
	public void PFGFIAMCPDN(float GAPPLJGNHFM, float MJLHHHBDBOD, List<T> OOAKOGKAEKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3626BB0", Offset = "0x3625BB0", VA = "0x183626BB0")]
	private int BEJLFHLDKJN(int GOBAFDMDOAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3626FD0", Offset = "0x3625FD0", VA = "0x183626FD0")]
	private void IMIALHJEHJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T HIAIKOGIJOF();

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T NPBIJEPMOLB(T GONHPLJMHJK, T CHGAACPNHMK, float AEOLAKIGFGF);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T OFEPOGGHJKD(T PLIDGBGAHIA, float AEOLAKIGFGF);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T CABEACFHFKB(T GONHPLJMHJK, T CHGAACPNHMK);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T BKNEHBDNBHJ(T GONHPLJMHJK, T CHGAACPNHMK);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class IKJHPKODDLJ : global::LHNLEAFBALF<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4B7A8D0", Offset = "0x4B798D0", VA = "0x184B7A8D0", Slot = "4")]
	protected override Vector3 HIAIKOGIJOF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4B7A940", Offset = "0x4B79940", VA = "0x184B7A940", Slot = "5")]
	protected override Vector3 NPBIJEPMOLB(Vector3 GONHPLJMHJK, Vector3 CHGAACPNHMK, float AEOLAKIGFGF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4B7AA00", Offset = "0x4B79A00", VA = "0x184B7AA00", Slot = "6")]
	protected override Vector3 OFEPOGGHJKD(Vector3 PLIDGBGAHIA, float AEOLAKIGFGF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4B7A820", Offset = "0x4B79820", VA = "0x184B7A820", Slot = "7")]
	protected override Vector3 CABEACFHFKB(Vector3 GONHPLJMHJK, Vector3 CHGAACPNHMK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4B7A7B0", Offset = "0x4B797B0", VA = "0x184B7A7B0", Slot = "8")]
	protected override Vector3 BKNEHBDNBHJ(Vector3 GONHPLJMHJK, Vector3 CHGAACPNHMK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4B7AAA0", Offset = "0x4B79AA0", VA = "0x184B7AAA0")]
	public IKJHPKODDLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class OHHFBHEJEJK : global::LHNLEAFBALF<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4B7B3E0", Offset = "0x4B7A3E0", VA = "0x184B7B3E0")]
	public OHHFBHEJEJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4B7B440", Offset = "0x4B7A440", VA = "0x184B7B440")]
	public OHHFBHEJEJK(int BGJKLECOEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0xE53A90", Offset = "0xE52A90", VA = "0x180E53A90", Slot = "4")]
	protected override float HIAIKOGIJOF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4B7B360", Offset = "0x4B7A360", VA = "0x184B7B360", Slot = "5")]
	protected override float NPBIJEPMOLB(float GONHPLJMHJK, float CHGAACPNHMK, float AEOLAKIGFGF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3CA84A0", Offset = "0x3CA74A0", VA = "0x183CA84A0", Slot = "6")]
	protected override float OFEPOGGHJKD(float PLIDGBGAHIA, float AEOLAKIGFGF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x28ECAB0", Offset = "0x28EBAB0", VA = "0x1828ECAB0", Slot = "7")]
	protected override float CABEACFHFKB(float GONHPLJMHJK, float CHGAACPNHMK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4B7B350", Offset = "0x4B7A350", VA = "0x184B7B350", Slot = "8")]
	protected override float BKNEHBDNBHJ(float GONHPLJMHJK, float CHGAACPNHMK)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class LGEILPEHHCG
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1E0BA80", Offset = "0x1E0AA80", VA = "0x181E0BA80")]
	public static global::IAALMKLCHIE<T1> ANENLEADNCN<T1>(T1 PCIMHCDAKOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2316520", Offset = "0x2315520", VA = "0x182316520")]
	public static global::KNHNPGHCLLP<T1, T2> ANENLEADNCN<T1, T2>(T1 PCIMHCDAKOF, T2 GMGFHDGNEKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1E11CF0", Offset = "0x1E10CF0", VA = "0x181E11CF0")]
	public static global::FLKLNDBLPAL<T1, T2, T3> ANENLEADNCN<T1, T2, T3>(T1 PCIMHCDAKOF, T2 GMGFHDGNEKL, T3 CBKCEIBGIGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1E13CC0", Offset = "0x1E12CC0", VA = "0x181E13CC0")]
	public static global::GJFJKCDCCMN<T1, T2, T3, T4> ANENLEADNCN<T1, T2, T3, T4>(T1 PCIMHCDAKOF, T2 GMGFHDGNEKL, T3 CBKCEIBGIGB, T4 OBGONCFANBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1E11F10", Offset = "0x1E10F10", VA = "0x181E11F10")]
	public static global::BPJKMGHADKG<T1, T2, T3, T4, T5> ANENLEADNCN<T1, T2, T3, T4, T5>(T1 PCIMHCDAKOF, T2 GMGFHDGNEKL, T3 CBKCEIBGIGB, T4 OBGONCFANBE, T5 BCCCAEBKCIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2316590", Offset = "0x2315590", VA = "0x182316590")]
	public static global::IOIOLKPADEO<T1, T2, T3, T4, T5, T6> ANENLEADNCN<T1, T2, T3, T4, T5, T6>(T1 PCIMHCDAKOF, T2 GMGFHDGNEKL, T3 CBKCEIBGIGB, T4 OBGONCFANBE, T5 BCCCAEBKCIK, T6 ELDKDMNOCPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1E11E50", Offset = "0x1E10E50", VA = "0x181E11E50")]
	public static global::AAMDJPIFAAF<T1, T2, T3, T4, T5, T6, T7> ANENLEADNCN<T1, T2, T3, T4, T5, T6, T7>(T1 PCIMHCDAKOF, T2 GMGFHDGNEKL, T3 CBKCEIBGIGB, T4 OBGONCFANBE, T5 BCCCAEBKCIK, T6 ELDKDMNOCPI, T7 EEHLMONMPOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1E11D80", Offset = "0x1E10D80", VA = "0x181E11D80")]
	public static global::ACAFNMOFHEK<T1, T2, T3, T4, T5, T6, T7, T8> ANENLEADNCN<T1, T2, T3, T4, T5, T6, T7, T8>(T1 PCIMHCDAKOF, T2 GMGFHDGNEKL, T3 CBKCEIBGIGB, T4 OBGONCFANBE, T5 BCCCAEBKCIK, T6 ELDKDMNOCPI, T7 EEHLMONMPOJ, T8 JHHHADFOAGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x18DC930", Offset = "0x18DB930", VA = "0x1818DC930")]
	[IteratorStateMachine(typeof(DIBFEEIFMJA))]
	public static IEnumerable<global::KNHNPGHCLLP<T1, T2>> KOPOBDGIINI<T1, T2>(IEnumerable<T1> HGNFJBMPOBI, IEnumerable<T2> EJCAMPCKMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1AAF1E0", Offset = "0x1AAE1E0", VA = "0x181AAF1E0")]
	[IteratorStateMachine(typeof(PHJLAONLINK))]
	public static IEnumerable<global::FLKLNDBLPAL<T1, T2, T3>> KOPOBDGIINI<T1, T2, T3>(IEnumerable<T1> HGNFJBMPOBI, IEnumerable<T2> EJCAMPCKMFA, IEnumerable<T3> AMPIDGKCPBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x23EE070", Offset = "0x23ED070", VA = "0x1823EE070")]
	internal static int DJHCAJEKKPH(int OIPFHIAPFPC, int GLLPIGDPLAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4339600", Offset = "0x4338600", VA = "0x184339600")]
	internal static int DJHCAJEKKPH(int OIPFHIAPFPC, int GLLPIGDPLAP, int ANBGFOELDPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4339610", Offset = "0x4338610", VA = "0x184339610")]
	internal static int DJHCAJEKKPH(int OIPFHIAPFPC, int GLLPIGDPLAP, int ANBGFOELDPO, int LGJDDPBFDPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4B7B0B0", Offset = "0x4B7A0B0", VA = "0x184B7B0B0")]
	internal static int DJHCAJEKKPH(int OIPFHIAPFPC, int GLLPIGDPLAP, int ANBGFOELDPO, int LGJDDPBFDPC, int LHEDHOJFEGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4B7B060", Offset = "0x4B7A060", VA = "0x184B7B060")]
	internal static int DJHCAJEKKPH(int OIPFHIAPFPC, int GLLPIGDPLAP, int ANBGFOELDPO, int LGJDDPBFDPC, int LHEDHOJFEGG, int IPBHKNOJFIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4B7B0D0", Offset = "0x4B7A0D0", VA = "0x184B7B0D0")]
	internal static int DJHCAJEKKPH(int OIPFHIAPFPC, int GLLPIGDPLAP, int ANBGFOELDPO, int LGJDDPBFDPC, int LHEDHOJFEGG, int IPBHKNOJFIL, int HAMKJBFFFKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4B7B080", Offset = "0x4B7A080", VA = "0x184B7B080")]
	internal static int DJHCAJEKKPH(int OIPFHIAPFPC, int GLLPIGDPLAP, int ANBGFOELDPO, int LGJDDPBFDPC, int LHEDHOJFEGG, int IPBHKNOJFIL, int HAMKJBFFFKB, int CHKFBNDGFDM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class IAALMKLCHIE<T1> : IComparable<global::IAALMKLCHIE<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T1 CHNKKFOJJOM;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1DED850", Offset = "0x1DEC850", VA = "0x181DED850")]
	public IAALMKLCHIE(T1 PCIMHCDAKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x32B7700", Offset = "0x32B6700", VA = "0x1832B7700", Slot = "4")]
	public int CompareTo(global::IAALMKLCHIE<T1> JFBDCEDLHDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x32B7770", Offset = "0x32B6770", VA = "0x1832B7770", Slot = "0")]
	public override bool Equals(object JFBDCEDLHDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x84FBF0", Offset = "0x84EBF0", VA = "0x18084FBF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x32B7810", Offset = "0x32B6810", VA = "0x1832B7810", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class KNHNPGHCLLP<T1, T2> : IComparable<global::KNHNPGHCLLP<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T1 CHNKKFOJJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T2 LEHCGPIJAAN;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3C39640", Offset = "0x3C38640", VA = "0x183C39640")]
	public KNHNPGHCLLP(T1 PCIMHCDAKOF, T2 GMGFHDGNEKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3D15DF0", Offset = "0x3D14DF0", VA = "0x183D15DF0", Slot = "4")]
	public int CompareTo(global::KNHNPGHCLLP<T1, T2> JFBDCEDLHDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3D16510", Offset = "0x3D15510", VA = "0x183D16510", Slot = "0")]
	public override bool Equals(object JFBDCEDLHDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3D16F90", Offset = "0x3D15F90", VA = "0x183D16F90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3D17010", Offset = "0x3D16010", VA = "0x183D17010", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class FLKLNDBLPAL<T1, T2, T3> : IComparable<global::FLKLNDBLPAL<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 CHNKKFOJJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 LEHCGPIJAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T3 GPDDINNGOKD;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2AE69E0", Offset = "0x2AE59E0", VA = "0x182AE69E0")]
	public FLKLNDBLPAL(T1 PCIMHCDAKOF, T2 GMGFHDGNEKL, T3 CBKCEIBGIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6300", Offset = "0x2AE5300", VA = "0x182AE6300", Slot = "4")]
	public int CompareTo(global::FLKLNDBLPAL<T1, T2, T3> JFBDCEDLHDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6400", Offset = "0x2AE5400", VA = "0x182AE6400", Slot = "0")]
	public override bool Equals(object JFBDCEDLHDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2AE66F0", Offset = "0x2AE56F0", VA = "0x182AE66F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6850", Offset = "0x2AE5850", VA = "0x182AE6850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class GJFJKCDCCMN<T1, T2, T3, T4> : IComparable<global::GJFJKCDCCMN<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T1 CHNKKFOJJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T2 LEHCGPIJAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T3 GPDDINNGOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T4 NMKEOPHOPKB;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2761390", Offset = "0x2760390", VA = "0x182761390")]
	public GJFJKCDCCMN(T1 PCIMHCDAKOF, T2 GMGFHDGNEKL, T3 CBKCEIBGIGB, T4 OBGONCFANBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2760F60", Offset = "0x275FF60", VA = "0x182760F60", Slot = "4")]
	public int CompareTo(global::GJFJKCDCCMN<T1, T2, T3, T4> JFBDCEDLHDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x27610A0", Offset = "0x27600A0", VA = "0x1827610A0", Slot = "0")]
	public override bool Equals(object JFBDCEDLHDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x27611C0", Offset = "0x27601C0", VA = "0x1827611C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2761280", Offset = "0x2760280", VA = "0x182761280", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class BPJKMGHADKG<T1, T2, T3, T4, T5> : IComparable<global::BPJKMGHADKG<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T1 CHNKKFOJJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T2 LEHCGPIJAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T3 GPDDINNGOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T4 NMKEOPHOPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T5 INGFFKBEODF;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3E627F0", Offset = "0x3E617F0", VA = "0x183E627F0")]
	public BPJKMGHADKG(T1 PCIMHCDAKOF, T2 GMGFHDGNEKL, T3 CBKCEIBGIGB, T4 OBGONCFANBE, T5 BCCCAEBKCIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3E62300", Offset = "0x3E61300", VA = "0x183E62300", Slot = "4")]
	public int CompareTo(global::BPJKMGHADKG<T1, T2, T3, T4, T5> JFBDCEDLHDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3E62480", Offset = "0x3E61480", VA = "0x183E62480", Slot = "0")]
	public override bool Equals(object JFBDCEDLHDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3E625C0", Offset = "0x3E615C0", VA = "0x183E625C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3E626C0", Offset = "0x3E616C0", VA = "0x183E626C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class IOIOLKPADEO<T1, T2, T3, T4, T5, T6> : IComparable<global::IOIOLKPADEO<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T1 CHNKKFOJJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T2 LEHCGPIJAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T3 GPDDINNGOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T4 NMKEOPHOPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T5 INGFFKBEODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T6 PEJAKLOPGEC;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3B431A0", Offset = "0x3B421A0", VA = "0x183B431A0")]
	public IOIOLKPADEO(T1 PCIMHCDAKOF, T2 GMGFHDGNEKL, T3 CBKCEIBGIGB, T4 OBGONCFANBE, T5 BCCCAEBKCIK, T6 ELDKDMNOCPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3B42C00", Offset = "0x3B41C00", VA = "0x183B42C00", Slot = "4")]
	public int CompareTo(global::IOIOLKPADEO<T1, T2, T3, T4, T5, T6> JFBDCEDLHDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3B42DC0", Offset = "0x3B41DC0", VA = "0x183B42DC0", Slot = "0")]
	public override bool Equals(object JFBDCEDLHDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3B42F30", Offset = "0x3B41F30", VA = "0x183B42F30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3B43050", Offset = "0x3B42050", VA = "0x183B43050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class AAMDJPIFAAF<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::AAMDJPIFAAF<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T1 CHNKKFOJJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T2 LEHCGPIJAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T3 GPDDINNGOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T4 NMKEOPHOPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T5 INGFFKBEODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T6 PEJAKLOPGEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T7 HELALKCANHJ;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x41BB810", Offset = "0x41BA810", VA = "0x1841BB810")]
	public AAMDJPIFAAF(T1 PCIMHCDAKOF, T2 GMGFHDGNEKL, T3 CBKCEIBGIGB, T4 OBGONCFANBE, T5 BCCCAEBKCIK, T6 ELDKDMNOCPI, T7 EEHLMONMPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x41BB1B0", Offset = "0x41BA1B0", VA = "0x1841BB1B0", Slot = "4")]
	public int CompareTo(global::AAMDJPIFAAF<T1, T2, T3, T4, T5, T6, T7> JFBDCEDLHDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x41BB3B0", Offset = "0x41BA3B0", VA = "0x1841BB3B0", Slot = "0")]
	public override bool Equals(object JFBDCEDLHDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x41BB550", Offset = "0x41BA550", VA = "0x1841BB550", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x41BB6A0", Offset = "0x41BA6A0", VA = "0x1841BB6A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class ACAFNMOFHEK<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::ACAFNMOFHEK<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T1 CHNKKFOJJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T2 LEHCGPIJAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T3 GPDDINNGOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T4 NMKEOPHOPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T5 INGFFKBEODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T6 PEJAKLOPGEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T7 HELALKCANHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T8 PHNPDDOKDHG;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x41BE130", Offset = "0x41BD130", VA = "0x1841BE130")]
	public ACAFNMOFHEK(T1 PCIMHCDAKOF, T2 GMGFHDGNEKL, T3 CBKCEIBGIGB, T4 OBGONCFANBE, T5 BCCCAEBKCIK, T6 ELDKDMNOCPI, T7 EEHLMONMPOJ, T8 JHHHADFOAGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x41BDA20", Offset = "0x41BCA20", VA = "0x1841BDA20", Slot = "4")]
	public int CompareTo(global::ACAFNMOFHEK<T1, T2, T3, T4, T5, T6, T7, T8> JFBDCEDLHDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x41BDC70", Offset = "0x41BCC70", VA = "0x1841BDC70", Slot = "0")]
	public override bool Equals(object JFBDCEDLHDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x41BDE30", Offset = "0x41BCE30", VA = "0x1841BDE30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x41BDFA0", Offset = "0x41BCFA0", VA = "0x1841BDFA0", Slot = "3")]
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
	public T OGNMMFGGOMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x54BA30", Offset = "0x54AA30", VA = "0x18054BA30")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6673A0", Offset = "0x6663A0", VA = "0x1806673A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float INKAHEILKOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xDD57C0", Offset = "0xDD47C0", VA = "0x180DD57C0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x39AD3E0", Offset = "0x39AC3E0", VA = "0x1839AD3E0")]
	public T KHLOPLJKKIH(float AEOLAKIGFGF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x39AD550", Offset = "0x39AC550", VA = "0x1839AD550")]
	public T ODCOKDCNHEG(float AEOLAKIGFGF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T NPBIJEPMOLB(T GONHPLJMHJK, T CHGAACPNHMK, float AEOLAKIGFGF);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1C193A0", Offset = "0x1C183A0", VA = "0x181C193A0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4B7A2F0", Offset = "0x4B792F0", VA = "0x184B7A2F0", Slot = "4")]
	protected override float NPBIJEPMOLB(float GONHPLJMHJK, float CHGAACPNHMK, float AEOLAKIGFGF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4B7A370", Offset = "0x4B79370", VA = "0x184B7A370")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4B7EF90", Offset = "0x4B7DF90", VA = "0x184B7EF90", Slot = "4")]
	protected override Vector3 NPBIJEPMOLB(Vector3 GONHPLJMHJK, Vector3 CHGAACPNHMK, float AEOLAKIGFGF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4B7F050", Offset = "0x4B7E050", VA = "0x184B7F050")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4B78B30", Offset = "0x4B77B30", VA = "0x184B78B30", Slot = "4")]
	protected override Color NPBIJEPMOLB(Color GONHPLJMHJK, Color CHGAACPNHMK, float AEOLAKIGFGF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4B78B80", Offset = "0x4B77B80", VA = "0x184B78B80")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[DefaultMember("Item")]
public sealed class GMNFNIGMPMF<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private T[] AMFHKCEFABK;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int PHEEIFDPPOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x5AF670", Offset = "0x5AE670", VA = "0x1805AF670")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6A1CF0", Offset = "0x6A0CF0", VA = "0x1806A1CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T KBPJCMENGBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2767090", Offset = "0x2766090", VA = "0x182767090")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2766DB0", Offset = "0x2765DB0", VA = "0x182766DB0")]
	public static global::GMNFNIGMPMF<T> BHANGEOFHDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2766EE0", Offset = "0x2765EE0", VA = "0x182766EE0")]
	public static global::GMNFNIGMPMF<T> BNNJCJEEPMM(int EOFEALDJCNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2767F60", Offset = "0x2766F60", VA = "0x182767F60")]
	private GMNFNIGMPMF(T[] NIJDAGINJKO, int EOFEALDJCNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2767020", Offset = "0x2766020", VA = "0x182767020", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x27673C0", Offset = "0x27663C0", VA = "0x1827673C0")]
	public void IPMJFBAMOHP(in T PLIDGBGAHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2767EC0", Offset = "0x2766EC0", VA = "0x182767EC0")]
	public void PGBHCFNJAPM(int EKKABPEEACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2767740", Offset = "0x2766740", VA = "0x182767740")]
	public void JBOIIODGKNN(in T PLIDGBGAHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2767D40", Offset = "0x2766D40", VA = "0x182767D40")]
	public void MGKJEACKIDC(int BGJKLECOEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2767150", Offset = "0x2766150", VA = "0x182767150")]
	private void FNOMOLILJKA(int EOFEALDJCNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class JACPNLJFLOD
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x205F1C0", Offset = "0x205E1C0", VA = "0x18205F1C0")]
	public static global::GMNFNIGMPMF<T> BHANGEOFHDG<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1BFA820", Offset = "0x1BF9820", VA = "0x181BFA820")]
	public static global::GMNFNIGMPMF<T> BNNJCJEEPMM<T>(int EOFEALDJCNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public class IINLMPEMBKP<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Dictionary<TKey, TVal> FLPKHOGJLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<TVal, TKey> BLDANIJALMI;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int PHEEIFDPPOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1F36AC0", Offset = "0x1F35AC0", VA = "0x181F36AC0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool FPPHEAHPBBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x523EC0", Offset = "0x522EC0", VA = "0x180523EC0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public ICollection<TKey> KENJAHLACBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x27664D0", Offset = "0x27654D0", VA = "0x1827664D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TVal> HCAJFKABGEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x229A260", Offset = "0x2299260", VA = "0x18229A260", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public TVal KBPJCMENGBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x307DFD0", Offset = "0x307CFD0", VA = "0x18307DFD0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x307E000", Offset = "0x307D000", VA = "0x18307E000", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TKey KBPJCMENGBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x307DA00", Offset = "0x307CA00", VA = "0x18307DA00")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x307D7F0", Offset = "0x307C7F0", VA = "0x18307D7F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x307D890", Offset = "0x307C890", VA = "0x18307D890", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x307DE70", Offset = "0x307CE70", VA = "0x18307DE70", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x307D830", Offset = "0x307C830", VA = "0x18307D830", Slot = "9")]
	public void Add(TKey ACPAGAEJCEC, TVal PLIDGBGAHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x307D860", Offset = "0x307C860", VA = "0x18307D860", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> AGLHBPHIFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x307D8F0", Offset = "0x307C8F0", VA = "0x18307D8F0", Slot = "8")]
	public bool ContainsKey(TKey ACPAGAEJCEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2272D00", Offset = "0x2271D00", VA = "0x182272D00", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> AGLHBPHIFEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x307DE40", Offset = "0x307CE40", VA = "0x18307DE40", Slot = "10")]
	public bool Remove(TKey ACPAGAEJCEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x307DE40", Offset = "0x307CE40", VA = "0x18307DE40", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> AGLHBPHIFEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x307DEC0", Offset = "0x307CEC0", VA = "0x18307DEC0", Slot = "11")]
	public bool TryGetValue(TKey ACPAGAEJCEC, out TVal PLIDGBGAHIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x307DA30", Offset = "0x307CA30", VA = "0x18307DA30", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x307D920", Offset = "0x307C920", VA = "0x18307D920", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] DPLIBGFAGAK, int JACHCJLPJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x307DB20", Offset = "0x307CB20", VA = "0x18307DB20")]
	public void IPMJFBAMOHP(TVal CDHAGALPBAP, TKey ACPAGAEJCEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x307DAE0", Offset = "0x307CAE0", VA = "0x18307DAE0")]
	public void IPMJFBAMOHP(KeyValuePair<TVal, TKey> AGLHBPHIFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x307DD60", Offset = "0x307CD60", VA = "0x18307DD60")]
	public bool LHHPBHACMFE(TVal ACPAGAEJCEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x307DAB0", Offset = "0x307CAB0", VA = "0x18307DAB0")]
	public bool HGMOGCLFPNP(KeyValuePair<TVal, TKey> AGLHBPHIFEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3020140", Offset = "0x301F140", VA = "0x183020140")]
	public bool JBOIIODGKNN(TVal ACPAGAEJCEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3020140", Offset = "0x301F140", VA = "0x183020140")]
	public bool JBOIIODGKNN(KeyValuePair<TVal, TKey> AGLHBPHIFEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x307DE10", Offset = "0x307CE10", VA = "0x18307DE10")]
	public bool PFJCFGHJDPO(TVal ACPAGAEJCEC, out TKey PLIDGBGAHIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x307DB60", Offset = "0x307CB60", VA = "0x18307DB60")]
	public IEnumerator<KeyValuePair<TVal, TKey>> JPFLEKPMPFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x307DD90", Offset = "0x307CD90", VA = "0x18307DD90")]
	private void OGHMEOOGJEO(TKey ACPAGAEJCEC, TVal CDHAGALPBAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x307D980", Offset = "0x307C980", VA = "0x18307D980")]
	private void DIJJMGGMPME(TKey ACPAGAEJCEC, TVal CDHAGALPBAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x307DBE0", Offset = "0x307CBE0", VA = "0x18307DBE0")]
	private bool KHDHAHKLIAB(TKey ACPAGAEJCEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x307DCA0", Offset = "0x307CCA0", VA = "0x18307DCA0")]
	private bool KHDHAHKLIAB(TVal CDHAGALPBAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x307DEF0", Offset = "0x307CEF0", VA = "0x18307DEF0")]
	public IINLMPEMBKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class PGPENHBEEGP<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private global::PGPENHBEEGP<T> buffer;

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
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xFD3CF0", Offset = "0xFD2CF0", VA = "0x180FD3CF0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x37B1690", Offset = "0x37B0690", VA = "0x1837B1690", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x37B17E0", Offset = "0x37B07E0", VA = "0x1837B17E0")]
		public Enumerator(global::PGPENHBEEGP<T> OOAKOGKAEKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x523E80", Offset = "0x522E80", VA = "0x180523E80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x37B0DB0", Offset = "0x37AFDB0", VA = "0x1837B0DB0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x37B1240", Offset = "0x37B0240", VA = "0x1837B1240", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x37B0BF0", Offset = "0x37AFBF0", VA = "0x1837B0BF0")]
		private void JGFHEEIKGGB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private T[] JNNMPCOMGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int JIBJAEPFHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private int APMGFFOCPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int ELJOMJDDOPI;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int PHEEIFDPPOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x37C2D90", Offset = "0x37C1D90", VA = "0x1837C2D90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public T KBPJCMENGBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x37C1FE0", Offset = "0x37C0FE0", VA = "0x1837C1FE0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x37C0F70", Offset = "0x37BFF70", VA = "0x1837C0F70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x37C2FF0", Offset = "0x37C1FF0", VA = "0x1837C2FF0")]
	public PGPENHBEEGP(int EOFEALDJCNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x37C2AC0", Offset = "0x37C1AC0", VA = "0x1837C2AC0")]
	public void IPMJFBAMOHP(T AEOLAKIGFGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x37C1780", Offset = "0x37C0780", VA = "0x1837C1780")]
	public void BDCBOONDFIL(IEnumerable<T> BOEMDPLCEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x37C1E10", Offset = "0x37C0E10", VA = "0x1837C1E10")]
	public void EMKEODJBGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x37C2D00", Offset = "0x37C1D00", VA = "0x1837C2D00")]
	public void OBHLFEJNFPF(int EGFLDBNNFNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x37C1D80", Offset = "0x37C0D80", VA = "0x1837C1D80")]
	public void CJPCPKFCJDP(int EGFLDBNNFNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x37C2500", Offset = "0x37C1500", VA = "0x1837C2500")]
	public void FLAEELNJCGA(T[] DPLIBGFAGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x37C1F20", Offset = "0x37C0F20", VA = "0x1837C1F20")]
	public Enumerator FGBDFIIFHCE()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x37C2E00", Offset = "0x37C1E00", VA = "0x1837C2E00", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x37C2E00", Offset = "0x37C1E00", VA = "0x1837C2E00", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x37C2830", Offset = "0x37C1830", VA = "0x1837C2830")]
	private int IOCEFDIJDBP(int EKKABPEEACK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x37C2DD0", Offset = "0x37C1DD0", VA = "0x1837C2DD0")]
	private int PGMKMOEBACN(int EKKABPEEACK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[DefaultMember("Item")]
public class JAHNNMEJMNP<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly Func<Internal, External> HOKDFLHFKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly Func<External, Internal> JICHDLDHBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private IList<Internal> HGHCNAACJPO;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public IList<Internal> IDBOJMPOFLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x525DF0", Offset = "0x524DF0", VA = "0x180525DF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x54DD70", Offset = "0x54CD70", VA = "0x18054DD70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool FPPHEAHPBBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5A4990", Offset = "0x5A3990", VA = "0x1805A4990", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6E4EB0", Offset = "0x6E3EB0", VA = "0x1806E4EB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public External KBPJCMENGBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3B44C10", Offset = "0x3B43C10", VA = "0x183B44C10", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3B44CB0", Offset = "0x3B43CB0", VA = "0x183B44CB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int PHEEIFDPPOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3B44BB0", Offset = "0x3B43BB0", VA = "0x183B44BB0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3B44B20", Offset = "0x3B43B20", VA = "0x183B44B20")]
	public JAHNNMEJMNP(Func<Internal, External> HOKDFLHFKCL, Func<External, Internal> JICHDLDHBBG, bool FALNAGMDLBG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x3B44830", Offset = "0x3B43830", VA = "0x183B44830", Slot = "6")]
	public int IndexOf(External AGLHBPHIFEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3B444B0", Offset = "0x3B434B0", VA = "0x183B444B0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3B44510", Offset = "0x3B43510", VA = "0x183B44510", Slot = "13")]
	public bool Contains(External AGLHBPHIFEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3B445A0", Offset = "0x3B435A0", VA = "0x183B445A0", Slot = "14")]
	public void CopyTo(External[] DPLIBGFAGAK, int JACHCJLPJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3B443C0", Offset = "0x3B433C0", VA = "0x183B443C0", Slot = "11")]
	public void Add(External AGLHBPHIFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3B44920", Offset = "0x3B43920", VA = "0x183B44920", Slot = "7")]
	public void Insert(int EKKABPEEACK, External AGLHBPHIFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3B44A90", Offset = "0x3B43A90", VA = "0x183B44A90", Slot = "15")]
	public bool Remove(External AGLHBPHIFEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3B449C0", Offset = "0x3B439C0", VA = "0x183B449C0", Slot = "8")]
	public void RemoveAt(int EKKABPEEACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x3B447C0", Offset = "0x3B437C0", VA = "0x183B447C0", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x1C21D30", Offset = "0x1C20D30", VA = "0x181C21D30", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[DefaultMember("Item")]
public class COLLBLDJKBE<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly Func<Internal, External> HOKDFLHFKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private IReadOnlyList<Internal> HGHCNAACJPO;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public IReadOnlyList<Internal> IDBOJMPOFLG
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5234A0", Offset = "0x5224A0", VA = "0x1805234A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool FPPHEAHPBBM
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x523FE0", Offset = "0x522FE0", VA = "0x180523FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public External KBPJCMENGBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x22A21D0", Offset = "0x22A11D0", VA = "0x1822A21D0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int PHEEIFDPPOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x22A2170", Offset = "0x22A1170", VA = "0x1822A2170", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x1DED850", Offset = "0x1DEC850", VA = "0x181DED850")]
	public COLLBLDJKBE(Func<Internal, External> HOKDFLHFKCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x22A2120", Offset = "0x22A1120", VA = "0x1822A2120")]
	public COLLBLDJKBE(IReadOnlyList<Internal> HGHCNAACJPO, Func<Internal, External> HOKDFLHFKCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x22A1E90", Offset = "0x22A0E90", VA = "0x1822A1E90")]
	public void FLAEELNJCGA(External[] DPLIBGFAGAK, int JACHCJLPJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x22A20B0", Offset = "0x22A10B0", VA = "0x1822A20B0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x1C29FD0", Offset = "0x1C28FD0", VA = "0x181C29FD0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public class ALHDDAHEOMP<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private IReadOnlyList<Internal> HGHCNAACJPO;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public IReadOnlyList<Internal> IDBOJMPOFLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5231D0", Offset = "0x5221D0", VA = "0x1805231D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x523490", Offset = "0x522490", VA = "0x180523490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool FPPHEAHPBBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x523FE0", Offset = "0x522FE0", VA = "0x180523FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public External KBPJCMENGBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x1DED8F0", Offset = "0x1DEC8F0", VA = "0x181DED8F0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int PHEEIFDPPOK
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x1DED890", Offset = "0x1DEC890", VA = "0x181DED890", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x1DED850", Offset = "0x1DEC850", VA = "0x181DED850")]
	public ALHDDAHEOMP(IReadOnlyList<Internal> HGHCNAACJPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x1DED7B0", Offset = "0x1DEC7B0", VA = "0x181DED7B0")]
	public bool HGMOGCLFPNP(External AGLHBPHIFEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x1DED510", Offset = "0x1DEC510", VA = "0x181DED510")]
	public void FLAEELNJCGA(External[] DPLIBGFAGAK, int JACHCJLPJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x1DED740", Offset = "0x1DEC740", VA = "0x181DED740", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x1C21D30", Offset = "0x1C20D30", VA = "0x181C21D30", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public abstract class JOMECEDNEJH
{
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void OBBKFJIPMEL(object[] DDOJBFMFLBH);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
	protected JOMECEDNEJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public abstract class DGAFIMEHELK<T> : JOMECEDNEJH
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	protected struct FDKLEHFOOLC
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public enum IJOBMOECLFK
		{
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public IJOBMOECLFK LDJDMLKKJPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public T HCODLMJPEMJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private int HIAMGNBJCPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly bool KFLPCIDFIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	protected readonly bool NDNMMECFEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	protected List<T> LGLJIAHMBLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private List<FDKLEHFOOLC> GEOBFANHDDK;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool POMANMHKADF
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3B67730", Offset = "0x3B66730", VA = "0x183B67730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3B67EB0", Offset = "0x3B66EB0", VA = "0x183B67EB0")]
	protected DGAFIMEHELK(bool NDNMMECFEDM, bool KFLPCIDFIHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3B67770", Offset = "0x3B66770", VA = "0x183B67770")]
	protected bool DIEGPNNFKNE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x3B67DD0", Offset = "0x3B66DD0", VA = "0x183B67DD0")]
	protected void LLGEDGDGCKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3B67940", Offset = "0x3B66940", VA = "0x183B67940")]
	protected void HFCDPANILHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x1E3BEA0", Offset = "0x1E3AEA0", VA = "0x181E3BEA0")]
	private static void JFGGCHAFICG<U>(ref List<U> HGHCNAACJPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3B67AF0", Offset = "0x3B66AF0", VA = "0x183B67AF0", Slot = "5")]
	public void IPMJFBAMOHP(T HCODLMJPEMJ, bool JCLCGBKLPDF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3B67C70", Offset = "0x3B66C70", VA = "0x183B67C70", Slot = "6")]
	public void JBOIIODGKNN(T HCODLMJPEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3B67810", Offset = "0x3B66810", VA = "0x183B67810")]
	public void EMKEODJBGFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface OGBHJHMLMBL
{
	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IPMJFBAMOHP(Action HCODLMJPEMJ, bool JCLCGBKLPDF = false);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JBOIIODGKNN(Action HCODLMJPEMJ);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class EKMBLIFIIOC : global::DGAFIMEHELK<Action>, OGBHJHMLMBL
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x4B78FC0", Offset = "0x4B77FC0", VA = "0x184B78FC0")]
	public EKMBLIFIIOC(bool NDNMMECFEDM = false, bool KFLPCIDFIHE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x4B78E00", Offset = "0x4B77E00", VA = "0x184B78E00")]
	public void OPDLEIGAJJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x4B78D20", Offset = "0x4B77D20", VA = "0x184B78D20", Slot = "4")]
	public override void OBBKFJIPMEL(object[] DDOJBFMFLBH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x4B78DA0", Offset = "0x4B77DA0", VA = "0x184B78DA0")]
	public static EKMBLIFIIOC OKFBALCLFPK(EKMBLIFIIOC KAIIONOHLPF, Action HCODLMJPEMJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x4B78CC0", Offset = "0x4B77CC0", VA = "0x184B78CC0")]
	public static EKMBLIFIIOC AMEEMPOGJEJ(EKMBLIFIIOC KAIIONOHLPF, Action HCODLMJPEMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface LBOCJFEOHAO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IPMJFBAMOHP(Action<T> HCODLMJPEMJ, bool JCLCGBKLPDF = false);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JBOIIODGKNN(Action<T> HCODLMJPEMJ);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class GIHOCHIODCE<T> : global::DGAFIMEHELK<Action<T>>, global::LBOCJFEOHAO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x1F1C450", Offset = "0x1F1B450", VA = "0x181F1C450")]
	public GIHOCHIODCE(bool NDNMMECFEDM = false, bool KFLPCIDFIHE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x353AFB0", Offset = "0x3539FB0", VA = "0x18353AFB0")]
	public void OPDLEIGAJJL(T AEOLAKIGFGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3539690", Offset = "0x3538690", VA = "0x183539690", Slot = "4")]
	public override void OBBKFJIPMEL(object[] DDOJBFMFLBH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x2760BA0", Offset = "0x275FBA0", VA = "0x182760BA0")]
	public static global::GIHOCHIODCE<T> OKFBALCLFPK(global::GIHOCHIODCE<T> KAIIONOHLPF, Action<T> HCODLMJPEMJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x27609B0", Offset = "0x275F9B0", VA = "0x1827609B0")]
	public static global::GIHOCHIODCE<T> AMEEMPOGJEJ(global::GIHOCHIODCE<T> KAIIONOHLPF, Action<T> HCODLMJPEMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface JEGGEIDFFGO<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IPMJFBAMOHP(Action<T, U> HCODLMJPEMJ, bool JCLCGBKLPDF = false);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JBOIIODGKNN(Action<T, U> HCODLMJPEMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class DOAIJDGHGAP<T, U> : global::DGAFIMEHELK<Action<T, U>>, global::JEGGEIDFFGO<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x1F1C450", Offset = "0x1F1B450", VA = "0x181F1C450")]
	public DOAIJDGHGAP(bool NDNMMECFEDM = false, bool KFLPCIDFIHE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3014260", Offset = "0x3013260", VA = "0x183014260")]
	public void OPDLEIGAJJL(T AEOLAKIGFGF, U GMELCOLMHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x3347B00", Offset = "0x3346B00", VA = "0x183347B00", Slot = "4")]
	public override void OBBKFJIPMEL(object[] DDOJBFMFLBH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3013AA0", Offset = "0x3012AA0", VA = "0x183013AA0")]
	public static global::DOAIJDGHGAP<T, U> OKFBALCLFPK(global::DOAIJDGHGAP<T, U> KAIIONOHLPF, Action<T, U> HCODLMJPEMJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x3012B20", Offset = "0x3011B20", VA = "0x183012B20")]
	public static global::DOAIJDGHGAP<T, U> AMEEMPOGJEJ(global::DOAIJDGHGAP<T, U> KAIIONOHLPF, Action<T, U> HCODLMJPEMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface LLKKPIDFKNN<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IPMJFBAMOHP(Action<T, U, V> HCODLMJPEMJ, bool JCLCGBKLPDF = false);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JBOIIODGKNN(Action<T, U, V> HCODLMJPEMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class MNMJEIMIMDK<T, U, V> : global::DGAFIMEHELK<Action<T, U, V>>, global::LLKKPIDFKNN<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x1F1C450", Offset = "0x1F1B450", VA = "0x181F1C450")]
	public MNMJEIMIMDK(bool NDNMMECFEDM = false, bool KFLPCIDFIHE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x22708F0", Offset = "0x226F8F0", VA = "0x1822708F0")]
	public void OPDLEIGAJJL(T AEOLAKIGFGF, U GMELCOLMHOC, V DCLAGPBEJAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x226F660", Offset = "0x226E660", VA = "0x18226F660", Slot = "4")]
	public override void OBBKFJIPMEL(object[] DDOJBFMFLBH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x22702C0", Offset = "0x226F2C0", VA = "0x1822702C0")]
	public static global::MNMJEIMIMDK<T, U, V> OKFBALCLFPK(global::MNMJEIMIMDK<T, U, V> KAIIONOHLPF, Action<T, U, V> HCODLMJPEMJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x226E980", Offset = "0x226D980", VA = "0x18226E980")]
	public static global::MNMJEIMIMDK<T, U, V> AMEEMPOGJEJ(global::MNMJEIMIMDK<T, U, V> KAIIONOHLPF, Action<T, U, V> HCODLMJPEMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface AJBEMDGNKIG<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IPMJFBAMOHP(Action<T, U, V, W> HCODLMJPEMJ, bool JCLCGBKLPDF = false);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JBOIIODGKNN(Action<T, U, V, W> HCODLMJPEMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class CALJJILINJA<T, U, V, W> : global::DGAFIMEHELK<Action<T, U, V, W>>, global::AJBEMDGNKIG<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x1F1C450", Offset = "0x1F1B450", VA = "0x181F1C450")]
	public CALJJILINJA(bool NDNMMECFEDM = false, bool KFLPCIDFIHE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x1F1AEC0", Offset = "0x1F19EC0", VA = "0x181F1AEC0")]
	public void OPDLEIGAJJL(T AEOLAKIGFGF, U GMELCOLMHOC, V DCLAGPBEJAL, W IBICEGJOGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A8C0", Offset = "0x1F198C0", VA = "0x181F1A8C0", Slot = "4")]
	public override void OBBKFJIPMEL(object[] DDOJBFMFLBH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x1F1AB80", Offset = "0x1F19B80", VA = "0x181F1AB80")]
	public static global::CALJJILINJA<T, U, V, W> OKFBALCLFPK(global::CALJJILINJA<T, U, V, W> KAIIONOHLPF, Action<T, U, V, W> HCODLMJPEMJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x1F19470", Offset = "0x1F18470", VA = "0x181F19470")]
	public static global::CALJJILINJA<T, U, V, W> AMEEMPOGJEJ(global::CALJJILINJA<T, U, V, W> KAIIONOHLPF, Action<T, U, V, W> HCODLMJPEMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface EIGOIAEPHOB<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IPMJFBAMOHP(Action<T, U, V, W, X> HCODLMJPEMJ, bool JCLCGBKLPDF = false);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JBOIIODGKNN(Action<T, U, V, W, X> HCODLMJPEMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class ENKBMPGMNNK<T, U, V, W, X> : global::DGAFIMEHELK<Action<T, U, V, W, X>>, global::EIGOIAEPHOB<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x1F1C450", Offset = "0x1F1B450", VA = "0x181F1C450")]
	public ENKBMPGMNNK(bool NDNMMECFEDM = false, bool KFLPCIDFIHE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x372B0B0", Offset = "0x372A0B0", VA = "0x18372B0B0")]
	public void OPDLEIGAJJL(T AEOLAKIGFGF, U GMELCOLMHOC, V DCLAGPBEJAL, W IBICEGJOGOF, X PACPIJAANIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x372AA10", Offset = "0x3729A10", VA = "0x18372AA10", Slot = "4")]
	public override void OBBKFJIPMEL(object[] DDOJBFMFLBH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x372AD00", Offset = "0x3729D00", VA = "0x18372AD00")]
	public static global::ENKBMPGMNNK<T, U, V, W, X> OKFBALCLFPK(global::ENKBMPGMNNK<T, U, V, W, X> KAIIONOHLPF, Action<T, U, V, W, X> HCODLMJPEMJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x372A650", Offset = "0x3729650", VA = "0x18372A650")]
	public static global::ENKBMPGMNNK<T, U, V, W, X> AMEEMPOGJEJ(global::ENKBMPGMNNK<T, U, V, W, X> KAIIONOHLPF, Action<T, U, V, W, X> HCODLMJPEMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface CELEOLFMEIA<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IPMJFBAMOHP(Action<T, U, V, W, X, Y> HCODLMJPEMJ, bool JCLCGBKLPDF = false);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JBOIIODGKNN(Action<T, U, V, W, X, Y> HCODLMJPEMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class FDKCHLGHFMC<T, U, V, W, X, Y> : global::DGAFIMEHELK<Action<T, U, V, W, X, Y>>, global::CELEOLFMEIA<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x1F1C450", Offset = "0x1F1B450", VA = "0x181F1C450")]
	public FDKCHLGHFMC(bool NDNMMECFEDM = false, bool KFLPCIDFIHE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x2ADEA00", Offset = "0x2ADDA00", VA = "0x182ADEA00")]
	public void OPDLEIGAJJL(T AEOLAKIGFGF, U GMELCOLMHOC, V DCLAGPBEJAL, W IBICEGJOGOF, X PACPIJAANIO, Y OKDBMFJJANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x2ADE2D0", Offset = "0x2ADD2D0", VA = "0x182ADE2D0", Slot = "4")]
	public override void OBBKFJIPMEL(object[] DDOJBFMFLBH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x2ADE960", Offset = "0x2ADD960", VA = "0x182ADE960")]
	public static global::FDKCHLGHFMC<T, U, V, W, X, Y> OKFBALCLFPK(global::FDKCHLGHFMC<T, U, V, W, X, Y> KAIIONOHLPF, Action<T, U, V, W, X, Y> HCODLMJPEMJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x2ADDEC0", Offset = "0x2ADCEC0", VA = "0x182ADDEC0")]
	public static global::FDKCHLGHFMC<T, U, V, W, X, Y> AMEEMPOGJEJ(global::FDKCHLGHFMC<T, U, V, W, X, Y> KAIIONOHLPF, Action<T, U, V, W, X, Y> HCODLMJPEMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class HLIFENDLHJH<T>
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct MKEKLOBGJAM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly global::HLIFENDLHJH<T> CAEMMJOBPJJ;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public T OGNMMFGGOMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x3462BE0", Offset = "0x3461BE0", VA = "0x183462BE0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3462BB0", Offset = "0x3461BB0", VA = "0x183462BB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x690850", Offset = "0x68F850", VA = "0x180690850")]
		public MKEKLOBGJAM(global::HLIFENDLHJH<T> CAEMMJOBPJJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct MFECKKMBCKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AsyncTaskMethodBuilder<MKEKLOBGJAM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public global::HLIFENDLHJH<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x34629E0", Offset = "0x34619E0", VA = "0x1834629E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x344CCD0", Offset = "0x344BCD0", VA = "0x18344CCD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct BHFBGEGPJCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public AsyncTaskMethodBuilder<MKEKLOBGJAM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public global::HLIFENDLHJH<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x344C930", Offset = "0x344B930", VA = "0x18344C930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x344CCD0", Offset = "0x344BCD0", VA = "0x18344CCD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly SemaphoreSlim CNDHMPFOPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private T POKGOADPJBB;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int IBFBJLFFDMA
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x3454CD0", Offset = "0x3453CD0", VA = "0x183454CD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x34552B0", Offset = "0x34542B0", VA = "0x1834552B0")]
	public HLIFENDLHJH(in T POKGOADPJBB, int NFNBCOJLIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x3154C50", Offset = "0x3153C50", VA = "0x183154C50")]
	public HLIFENDLHJH(in T POKGOADPJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x3454C50", Offset = "0x3453C50", VA = "0x183454C50")]
	public MKEKLOBGJAM IIJFPFLBGBO()
	{
		return default(MKEKLOBGJAM);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x3454C90", Offset = "0x3453C90", VA = "0x183454C90")]
	public MKEKLOBGJAM IIJFPFLBGBO(CancellationToken NBKOFEKBJGA)
	{
		return default(MKEKLOBGJAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x3455150", Offset = "0x3454150", VA = "0x183455150")]
	[AsyncStateMachine(typeof(global::HLIFENDLHJH<>.MFECKKMBCKK))]
	public Task<MKEKLOBGJAM> NLIPBACAJGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x3454CF0", Offset = "0x3453CF0", VA = "0x183454CF0")]
	[AsyncStateMachine(typeof(global::HLIFENDLHJH<>.BHFBGEGPJCM))]
	public Task<MKEKLOBGJAM> NLIPBACAJGC(CancellationToken NBKOFEKBJGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class MKOMJGOMGBI
{
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x4B7B280", Offset = "0x4B7A280", VA = "0x184B7B280")]
	public static global::HLIFENDLHJH<CJCMBLFIGNN> BHANGEOFHDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x4B7B2E0", Offset = "0x4B7A2E0", VA = "0x184B7B2E0")]
	public static global::HLIFENDLHJH<CJCMBLFIGNN> BHANGEOFHDG(int NFNBCOJLIOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x1E0BA80", Offset = "0x1E0AA80", VA = "0x181E0BA80")]
	public static global::HLIFENDLHJH<T> BHANGEOFHDG<T>(in T POKGOADPJBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x1E13BC0", Offset = "0x1E12BC0", VA = "0x181E13BC0")]
	public static global::HLIFENDLHJH<T> BHANGEOFHDG<T>(in T POKGOADPJBB, int NFNBCOJLIOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class GLINAKDLCLE<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public delegate bool DOIFODLIFGO(global::GLINAKDLCLE<T> ODGFBBJPCEB);

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class HJBKAACDOMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public T nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public global::GLINAKDLCLE<T> foundNode;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x1C193A0", Offset = "0x1C183A0", VA = "0x181C193A0")]
		public HJBKAACDOMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x276A580", Offset = "0x2769580", VA = "0x18276A580")]
		internal bool <FindNode>b__0(global::GLINAKDLCLE<T> node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public T NDIGJKEHHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public LinkedList<global::GLINAKDLCLE<T>> MDMFPPGMAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public global::GLINAKDLCLE<T> ECCBDCAHJOK;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public global::GLINAKDLCLE<T> BDMPMIJDNHA
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x576130", Offset = "0x575130", VA = "0x180576130")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x27654D0", Offset = "0x27644D0", VA = "0x1827654D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool IPJCNOHIMDD
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x2764C10", Offset = "0x2763C10", VA = "0x182764C10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool EEEHLCELKBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x27646C0", Offset = "0x27636C0", VA = "0x1827646C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public global::GLINAKDLCLE<T> CHMPCBBJOCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2765690", Offset = "0x2764690", VA = "0x182765690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2766380", Offset = "0x2765380", VA = "0x182766380")]
	public GLINAKDLCLE(T LNMIGICAHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x27652C0", Offset = "0x27642C0", VA = "0x1827652C0")]
	public global::GLINAKDLCLE<T> KHKNHFJHFMN(T FILEABEOCLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2764740", Offset = "0x2763740", VA = "0x182764740")]
	public global::GLINAKDLCLE<T> INIMFLIKEBP(T GDPOOGBEGHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2764B60", Offset = "0x2763B60", VA = "0x182764B60")]
	public global::GLINAKDLCLE<T> JBOIIODGKNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2764460", Offset = "0x2763460", VA = "0x182764460")]
	public void EMKEODJBGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2765710", Offset = "0x2764710", VA = "0x182765710")]
	public global::GLINAKDLCLE<T> MDIEIMNBGNH(T ELPMOAHNJMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x2764F80", Offset = "0x2763F80", VA = "0x182764F80")]
	public static void KCJPHDLHFPE(global::GLINAKDLCLE<T> HCENPENOKAJ, DOIFODLIFGO PCONPJNFODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x2B519C0", Offset = "0x2B509C0", VA = "0x182B519C0")]
	public static void KCJPHDLHFPE<A>(global::GLINAKDLCLE<T> HCENPENOKAJ, Func<global::GLINAKDLCLE<T>, A, bool> PCONPJNFODG, A NIBOEEFPIFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x2765E40", Offset = "0x2764E40", VA = "0x182765E40")]
	public static string OCBPPBDBPMJ(global::GLINAKDLCLE<T> HCENPENOKAJ, int CLOKNLNKIIJ = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x2763FE0", Offset = "0x2762FE0", VA = "0x182763FE0")]
	public static global::GLINAKDLCLE<T> DBJNNFKICOA(global::GLINAKDLCLE<T> HCENPENOKAJ, T DHOGNOKEABL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class AMHEFDOLIFC<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public delegate Task<TResult> MOALNPNIPMB(TRequest MNBFBMPNALN, CancellationToken NBKOFEKBJGA);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public enum KHMDFJADKPE
	{
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class DIJJMFLONFA
	{
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private const float AGBEDLAPFBA = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TimeSpan CHJCNDHJCKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public int ELHAFELJKAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public KHMDFJADKPE ECGOFOJLOKD;

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public static readonly DIJJMFLONFA JNOOCAGMNOA;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float ABEJEDDAPPC
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x3C21BD0", Offset = "0x3C20BD0", VA = "0x183C21BD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public TimeSpan EINNJOHEDCA
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x5231D0", Offset = "0x5221D0", VA = "0x1805231D0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3C21CB0", Offset = "0x3C20CB0", VA = "0x183C21CB0")]
		public DIJJMFLONFA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private readonly struct AHJMJBBBGGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public readonly TRequest MNBFBMPNALN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly CancellationToken NBKOFEKBJGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public readonly TaskCompletionSource<TResult> KNIBHFOHFIG;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3C11D90", Offset = "0x3C10D90", VA = "0x183C11D90")]
		public AHJMJBBBGGA(TRequest MNBFBMPNALN, TaskCompletionSource<TResult> KNIBHFOHFIG, CancellationToken NBKOFEKBJGA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class HDPCPAIJDHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x1C193A0", Offset = "0x1C183A0", VA = "0x181C193A0")]
		public HDPCPAIJDHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x1F36AC0", Offset = "0x1F35AC0", VA = "0x181F36AC0")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct MHAEBJDHANE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public global::AMHEFDOLIFC<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3C2C200", Offset = "0x3C2B200", VA = "0x183C2C200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6E5190", Offset = "0x6E4190", VA = "0x1806E5190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class JAABHAOOCMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AHJMJBBBGGA req;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public global::AMHEFDOLIFC<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x1C193A0", Offset = "0x1C183A0", VA = "0x181C193A0")]
		public JAABHAOOCMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3C23F70", Offset = "0x3C22F70", VA = "0x183C23F70")]
		internal void <ProcessQueue>b__0(Task<TResult> task)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CancellationTokenSource HDFOBOMIGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly List<AHJMJBBBGGA> LMNEPAPLFJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly DIJJMFLONFA KEEOMCDHIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly MOALNPNIPMB PJENGIBJIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private Task IFNIGHAACDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private int CILHGEKOAFE;

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x3C14290", Offset = "0x3C13290", VA = "0x183C14290")]
	public AMHEFDOLIFC(MOALNPNIPMB PJENGIBJIJK, [Optional] DIJJMFLONFA KEEOMCDHIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x3C12820", Offset = "0x3C11820", VA = "0x183C12820")]
	public Task<TResult> BPHPFKEJGBD(TRequest MNBFBMPNALN, CancellationToken NBKOFEKBJGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x3C13390", Offset = "0x3C12390", VA = "0x183C13390")]
	private void IKGPAAKEOBP(AHJMJBBBGGA NNEKLFGDCDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x3C13E20", Offset = "0x3C12E20", VA = "0x183C13E20")]
	[AsyncStateMachine(typeof(global::AMHEFDOLIFC<, >.MHAEBJDHANE))]
	private Task KMODFPIFMHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x3C134C0", Offset = "0x3C124C0", VA = "0x183C134C0")]
	private AHJMJBBBGGA JHCEOANIDEA()
	{
		return default(AHJMJBBBGGA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x3C13110", Offset = "0x3C12110", VA = "0x183C13110")]
	private void HEIJLCGGKFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x3C12CF0", Offset = "0x3C11CF0", VA = "0x183C12CF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[DefaultMember("Item")]
public class EJMODCAKBHC<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public delegate int BIBAILKBDCO(TKey ACPAGAEJCEC, TVal PLIDGBGAHIA);

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class NEPMECLKGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public TKey IDCDHNMBHAN
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x5231D0", Offset = "0x5221D0", VA = "0x1805231D0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public TVal OGNMMFGGOMO
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x651BA0", Offset = "0x650BA0", VA = "0x180651BA0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x6E4AD0", Offset = "0x6E3AD0", VA = "0x1806E4AD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public int LGCMEBDOBPM
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x6A1CB0", Offset = "0x6A0CB0", VA = "0x1806A1CB0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x6A1CE0", Offset = "0x6A0CE0", VA = "0x1806A1CE0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public DateTime GAAOOOMMPAC
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x525DF0", Offset = "0x524DF0", VA = "0x180525DF0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0xED69E0", Offset = "0xED59E0", VA = "0x180ED69E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3024540", Offset = "0x3023540", VA = "0x183024540")]
		public NEPMECLKGMJ(TKey ACPAGAEJCEC, TVal CDHAGALPBAP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public const int LACBLPFJKMD = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly Dictionary<TKey, LinkedListNode<NEPMECLKGMJ>> KFDKNDGGBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly LinkedList<NEPMECLKGMJ> LPPCBILMEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly BIBAILKBDCO ALHEJPABLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly TimeSpan MOFBIOFAGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly LMGCJCCINKB IMIMMMJBDGK;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int IAPCAKGIKDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x6AB0B0", Offset = "0x6AA0B0", VA = "0x1806AB0B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private bool ODCKGEGCOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x30207A0", Offset = "0x301F7A0", VA = "0x1830207A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal int LALFHMCFNJG
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x6AB0C0", Offset = "0x6AA0C0", VA = "0x1806AB0C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x69FDD0", Offset = "0x69EDD0", VA = "0x18069FDD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int PHEEIFDPPOK
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x24B41E0", Offset = "0x24B31E0", VA = "0x1824B41E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public IEnumerable<TKey> KENJAHLACBO
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x301FC60", Offset = "0x301EC60", VA = "0x18301FC60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public TVal KBPJCMENGBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3020140", Offset = "0x301F140", VA = "0x183020140")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x301FC30", Offset = "0x301EC30", VA = "0x18301FC30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x37259B0", Offset = "0x37249B0", VA = "0x1837259B0")]
	public EJMODCAKBHC(int EOFEALDJCNO, [Optional] BIBAILKBDCO ALHEJPABLPL, [Optional] IEqualityComparer<TKey> DHJAFEJPODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x3020D60", Offset = "0x301FD60", VA = "0x183020D60")]
	public EJMODCAKBHC(TimeSpan MOFBIOFAGHK, [Optional] IEqualityComparer<TKey> DHJAFEJPODH, [Optional] LMGCJCCINKB IMIMMMJBDGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x3021050", Offset = "0x3020050", VA = "0x183021050")]
	public EJMODCAKBHC(int EOFEALDJCNO, TimeSpan MOFBIOFAGHK, [Optional] IEqualityComparer<TKey> DHJAFEJPODH, [Optional] LMGCJCCINKB IMIMMMJBDGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x3020DB0", Offset = "0x301FDB0", VA = "0x183020DB0")]
	public EJMODCAKBHC(int EOFEALDJCNO, BIBAILKBDCO ALHEJPABLPL, TimeSpan MOFBIOFAGHK, [Optional] IEqualityComparer<TKey> DHJAFEJPODH, [Optional] LMGCJCCINKB IMIMMMJBDGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x30209D0", Offset = "0x301F9D0", VA = "0x1830209D0")]
	public void OPMEOJMHAGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x3020080", Offset = "0x301F080", VA = "0x183020080")]
	public void FHONGGKHMKA(TKey ACPAGAEJCEC, TVal PLIDGBGAHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x3020380", Offset = "0x301F380", VA = "0x183020380")]
	public bool JBOIIODGKNN(TKey ACPAGAEJCEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x301FF40", Offset = "0x301EF40", VA = "0x18301FF40")]
	private TVal ELOPIDONOEF(TKey MLABEANJCIF)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x37255B0", Offset = "0x37245B0", VA = "0x1837255B0")]
	public bool PFJCFGHJDPO(TKey MLABEANJCIF, out TVal PLIDGBGAHIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x3020000", Offset = "0x301F000", VA = "0x183020000")]
	public void EMKEODJBGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x301FE80", Offset = "0x301EE80", VA = "0x18301FE80")]
	private bool BNCBEFIKNHG(NEPMECLKGMJ GFOBCOJDDDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x3020510", Offset = "0x301F510", VA = "0x183020510")]
	private void KIJPJOKHFEO(LinkedListNode<NEPMECLKGMJ> LDHALLHBDPK, TVal FHADNJDAGOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x3020170", Offset = "0x301F170", VA = "0x183020170")]
	private void FOPPAMGFOBA(TKey ACPAGAEJCEC, TVal PLIDGBGAHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x3020830", Offset = "0x301F830", VA = "0x183020830")]
	private void MPALIGEGOPA(NEPMECLKGMJ GFOBCOJDDDN, TVal FHADNJDAGOE, int PGLDMONBMCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[DefaultMember("Item")]
public class BICGHDDPMJH<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly List<T> HGHCNAACJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private HashSet<T> INCGIMFABHE;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int PHEEIFDPPOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x1F36AC0", Offset = "0x1F35AC0", VA = "0x181F36AC0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool FPPHEAHPBBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x523EC0", Offset = "0x522EC0", VA = "0x180523EC0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public T KBPJCMENGBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x31A86E0", Offset = "0x31A76E0", VA = "0x1831A86E0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x348F6B0", Offset = "0x348E6B0", VA = "0x18348F6B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x348EC70", Offset = "0x348DC70", VA = "0x18348EC70", Slot = "11")]
	public void Add(T AGLHBPHIFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x348F190", Offset = "0x348E190", VA = "0x18348F190")]
	public bool JAJBCKKAAGN(T AGLHBPHIFEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x348F400", Offset = "0x348E400", VA = "0x18348F400", Slot = "15")]
	public bool Remove(T AGLHBPHIFEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x348ED30", Offset = "0x348DD30", VA = "0x18348ED30", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x1C1ABE0", Offset = "0x1C19BE0", VA = "0x181C1ABE0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x348ECA0", Offset = "0x348DCA0", VA = "0x18348ECA0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x314B3D0", Offset = "0x314A3D0", VA = "0x18314B3D0", Slot = "13")]
	public bool Contains(T AGLHBPHIFEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x348ED00", Offset = "0x348DD00", VA = "0x18348ED00", Slot = "14")]
	public void CopyTo(T[] DPLIBGFAGAK, int JACHCJLPJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x307DFD0", Offset = "0x307CFD0", VA = "0x18307DFD0", Slot = "6")]
	public int IndexOf(T AGLHBPHIFEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x348EF50", Offset = "0x348DF50", VA = "0x18348EF50", Slot = "7")]
	public void Insert(int EKKABPEEACK, T AGLHBPHIFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x348F260", Offset = "0x348E260", VA = "0x18348F260", Slot = "8")]
	public void RemoveAt(int EKKABPEEACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x348EDB0", Offset = "0x348DDB0", VA = "0x18348EDB0")]
	public void HHLBDLHECIP(Predicate<T> IEGIDGHNODJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x348F230", Offset = "0x348E230", VA = "0x18348F230")]
	public void LBJNBIAIHMC(Comparison<T> ICBCOAAOJMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x348F510", Offset = "0x348E510", VA = "0x18348F510")]
	public BICGHDDPMJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class HLIEAODBCBE
{
	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x4B7A3F0", Offset = "0x4B793F0", VA = "0x184B7A3F0")]
	public static Vector3 LANNJDICNEP(this GameObject CDELJLCJCHC, float JAFBPBNCBJB)
	{
		return default(Vector3);
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x1FE1F30", Offset = "0x1FE0F30", VA = "0x181FE1F30")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x4B7E570", Offset = "0x4B7D570", VA = "0x184B7E570")]
		public SerializedGuid(in Guid LJMJBJAKMBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x4B7E180", Offset = "0x4B7D180", VA = "0x184B7E180")]
		public static SerializedGuid EIJMMENGOMB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x4B7E390", Offset = "0x4B7D390", VA = "0x184B7E390")]
		public static SerializedGuid IHBMDFANIGA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x4B7E0C0", Offset = "0x4B7D0C0", VA = "0x184B7E0C0")]
		public bool CBFOCNKMHNB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x4B7E540", Offset = "0x4B7D540", VA = "0x184B7E540", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x4B7E4A0", Offset = "0x4B7D4A0", VA = "0x184B7E4A0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x4B7E410", Offset = "0x4B7D410", VA = "0x184B7E410")]
		public bool OAFAANEMGOI(in Guid LJMJBJAKMBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x4B7E200", Offset = "0x4B7D200", VA = "0x184B7E200", Slot = "7")]
		public bool Equals(SerializedGuid JFBDCEDLHDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x4B7E2A0", Offset = "0x4B7D2A0", VA = "0x184B7E2A0", Slot = "0")]
		public override bool Equals(object HAFCDCMNBJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x4B7E380", Offset = "0x4B7D380", VA = "0x184B7E380", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x4B7E150", Offset = "0x4B7D150", VA = "0x184B7E150", Slot = "6")]
		public int CompareTo(SerializedGuid JFBDCEDLHDN)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class LAEMHGDIBIO : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly Type NABAJNDFJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly string GPAIAKMKPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly bool DMDGMGFOFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly bool CNMIAGFGFJJ;

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x4B7AFF0", Offset = "0x4B79FF0", VA = "0x184B7AFF0")]
	public LAEMHGDIBIO(Type AAMKMEIPFCD, string COBPKNHLFPF, bool PAAPHONIEFL = false, bool CJEJABAAOAA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface DPHLMACIIOB
{
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface DKGCFHOGGMM<T> : DPHLMACIIOB
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	T OGNMMFGGOMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool CLMEGMPHGCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	string LEAMFDEFLME
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::DKGCFHOGGMM<T> ANCNACIECKO(Action<T> NBNIAKBFGOO);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::DKGCFHOGGMM<T> HAAKPACFKJK(Action<T> NBNIAKBFGOO);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::DKGCFHOGGMM<T> FHEJJDBGFON(Action<T, T> OHBNNGHBFEL);

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::DKGCFHOGGMM<T> MAAAKGIFADL(Action<T, T> OHBNNGHBFEL);

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::DKGCFHOGGMM<T> DPHCFHHCJBA(Action<string> EOKNBBLBLAA);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::DKGCFHOGGMM<T> PMKHFFJFDKP(Action<string> EOKNBBLBLAA);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class JCMFBHAAGKI<T> : global::DKGCFHOGGMM<T>, DPHLMACIIOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private global::DOAIJDGHGAP<T, T> NIBKDIFICDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private global::GIHOCHIODCE<T> AIOOKEPELEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private global::GIHOCHIODCE<string> FBLGNPBDECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private string BKDCGOBDEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private T FBLFMDDMFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private bool APFIHGHPIJI;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public T OGNMMFGGOMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x54BA30", Offset = "0x54AA30", VA = "0x18054BA30", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x2F34060", Offset = "0x2F33060", VA = "0x182F34060", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool CLMEGMPHGCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x5A58B0", Offset = "0x5A48B0", VA = "0x1805A58B0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public string LEAMFDEFLME
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x54C0C0", Offset = "0x54B0C0", VA = "0x18054C0C0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x2563B70", Offset = "0x2562B70", VA = "0x182563B70", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x3B47D50", Offset = "0x3B46D50", VA = "0x183B47D50")]
	private void MFBLJJEHMJM(T MAOFHEFHMFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x3B47A80", Offset = "0x3B46A80", VA = "0x183B47A80")]
	private void DCBGFPGKPKG(string IONEBLEBOJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x3B47C00", Offset = "0x3B46C00", VA = "0x183B47C00")]
	public void GFAAAEIMPBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x3B47BB0", Offset = "0x3B46BB0", VA = "0x183B47BB0", Slot = "6")]
	public global::DKGCFHOGGMM<T> FHEJJDBGFON(Action<T, T> OHBNNGHBFEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x3B47D00", Offset = "0x3B46D00", VA = "0x183B47D00", Slot = "7")]
	public global::DKGCFHOGGMM<T> MAAAKGIFADL(Action<T, T> OHBNNGHBFEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x3B479F0", Offset = "0x3B469F0", VA = "0x183B479F0", Slot = "4")]
	public global::DKGCFHOGGMM<T> ANCNACIECKO(Action<T> OHBNNGHBFEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x3B47CB0", Offset = "0x3B46CB0", VA = "0x183B47CB0", Slot = "5")]
	public global::DKGCFHOGGMM<T> HAAKPACFKJK(Action<T> NBNIAKBFGOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x3B47B20", Offset = "0x3B46B20", VA = "0x183B47B20", Slot = "8")]
	public global::DKGCFHOGGMM<T> DPHCFHHCJBA(Action<string> EOKNBBLBLAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3B47DF0", Offset = "0x3B46DF0", VA = "0x183B47DF0", Slot = "9")]
	public global::DKGCFHOGGMM<T> PMKHFFJFDKP(Action<string> EOKNBBLBLAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x3B47E60", Offset = "0x3B46E60", VA = "0x183B47E60")]
	public JCMFBHAAGKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class HGPEHJNLIKB
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class CDCOGPDKJBF<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public global::DKGCFHOGGMM<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public global::NJDHBAAKDND<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x1C193A0", Offset = "0x1C183A0", VA = "0x181C193A0")]
		public CDCOGPDKJBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x425D800", Offset = "0x425C800", VA = "0x18425D800")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x1D43F80", Offset = "0x1D42F80", VA = "0x181D43F80")]
	public static global::GIFPPDKJJDK<T> ILHOBFMIBDC<T>(this global::DKGCFHOGGMM<T> MJHFFCPKKBC, Action<T> JKHIBJGOJLH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class LMGCJCCINKB
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private class CCMOFBJGIJD : LMGCJCCINKB
	{
		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public static LMGCJCCINKB HGCFOCCEAJH
		{
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x4B78980", Offset = "0x4B77980", VA = "0x184B78980")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public override DateTime BEAAFKIFEOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x4B789E0", Offset = "0x4B779E0", VA = "0x184B789E0", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public override float EKHAANLGPJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x4B6C4A0", Offset = "0x4B6B4A0", VA = "0x184B6C4A0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x4B78AD0", Offset = "0x4B77AD0", VA = "0x184B78AD0")]
		public CCMOFBJGIJD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static LMGCJCCINKB MBHOAKPPLGA;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public static LMGCJCCINKB JNOOCAGMNOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x4B7B100", Offset = "0x4B7A100", VA = "0x184B7B100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public abstract DateTime BEAAFKIFEOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public abstract float EKHAANLGPJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
	protected LMGCJCCINKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class HKHHPDBPIMD : global::FNAFLMMFFPK<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x4B7A3B0", Offset = "0x4B793B0", VA = "0x184B7A3B0")]
	public HKHHPDBPIMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class FNAFLMMFFPK<T> : global::MMOPPAINOBK<T>, OJNLGKKEAMG, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public Task<T> PCGNGOEGLKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x5231D0", Offset = "0x5221D0", VA = "0x1805231D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private Task GIFEMENHLND
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x1C193C0", Offset = "0x1C183C0", VA = "0x181C193C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public global::GIFPPDKJJDK<T> POLHEGIPFLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	private FPHLJBABNHP MGJFFPPOGBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x1C20230", Offset = "0x1C1F230", VA = "0x181C20230", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x352FC80", Offset = "0x352EC80", VA = "0x18352FC80")]
	public FNAFLMMFFPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x523E80", Offset = "0x522E80", VA = "0x180523E80", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class DDEJMNJGNDK : global::EAIADAIKOKL<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x4B78BC0", Offset = "0x4B77BC0", VA = "0x184B78BC0")]
	public DDEJMNJGNDK(Exception KECOEODIMDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class EAIADAIKOKL<T> : global::MMOPPAINOBK<T>, OJNLGKKEAMG, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public Task<T> PCGNGOEGLKM
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x5231D0", Offset = "0x5221D0", VA = "0x1805231D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	private Task GIFEMENHLND
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x1C193C0", Offset = "0x1C183C0", VA = "0x181C193C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public global::GIFPPDKJJDK<T> POLHEGIPFLG
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	private FPHLJBABNHP MGJFFPPOGBL
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x1C20230", Offset = "0x1C1F230", VA = "0x181C20230", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x301A720", Offset = "0x3019720", VA = "0x18301A720")]
	public EAIADAIKOKL(Exception KECOEODIMDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x523E80", Offset = "0x522E80", VA = "0x180523E80", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface OJNLGKKEAMG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	[NotNull]
	Task PCGNGOEGLKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	[NotNull]
	FPHLJBABNHP POLHEGIPFLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface MMOPPAINOBK<T> : OJNLGKKEAMG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	[NotNull]
	new Task<T> PCGNGOEGLKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	[NotNull]
	new global::GIFPPDKJJDK<T> POLHEGIPFLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public abstract class ADFCMHIMEFI<TTask, T> : global::MMOPPAINOBK<T>, OJNLGKKEAMG, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class OMNBJLLKBPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public global::ADFCMHIMEFI<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x1C193A0", Offset = "0x1C183A0", VA = "0x181C193A0")]
		public OMNBJLLKBPG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static bool IBCFOGMCIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly Task<T> MPENMHHNIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	protected readonly CancellationTokenSource KPDCPNIHEJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool BMBDJGBFCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private SynchronizationContext NFGDOENAHOA;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Task<T> PCGNGOEGLKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x5231D0", Offset = "0x5221D0", VA = "0x1805231D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private Task GIFEMENHLND
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x5231D0", Offset = "0x5221D0", VA = "0x1805231D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public global::GIFPPDKJJDK<T> POLHEGIPFLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	private FPHLJBABNHP MGJFFPPOGBL
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x1CFF1E0", Offset = "0x1CFE1E0", VA = "0x181CFF1E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool BPDPHDOJLDB
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x5A4990", Offset = "0x5A3990", VA = "0x1805A4990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x41BE7E0", Offset = "0x41BD7E0", VA = "0x1841BE7E0")]
	static ADFCMHIMEFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x41BEB00", Offset = "0x41BDB00", VA = "0x1841BEB00")]
	protected ADFCMHIMEFI(TTask MPENMHHNIKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x41BE200", Offset = "0x41BD200", VA = "0x1841BE200", Slot = "1")]
	~ADFCMHIMEFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x39B3C30", Offset = "0x39B2C30", VA = "0x1839B3C30", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x41BE390", Offset = "0x41BD390", VA = "0x1841BE390")]
	private void NIICFFGCHPN(bool BJGAHNAFALH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T PBIEMINMOEJ(TTask PEJBGFIPEDG);

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void ABKIPCJMPBN();

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x41BE340", Offset = "0x41BD340", VA = "0x1841BE340")]
	[CompilerGenerated]
	private void IHAKOOCCICA(object KJJELHOLNJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class BMFGCJLJMMM : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public readonly Type NABAJNDFJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public readonly string GPAIAKMKPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public readonly bool DMDGMGFOFND;

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x4B78920", Offset = "0x4B77920", VA = "0x184B78920")]
	public BMFGCJLJMMM(Type AAMKMEIPFCD, string COBPKNHLFPF, bool PAAPHONIEFL = false)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x523ED0", Offset = "0x522ED0", VA = "0x180523ED0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x547710", Offset = "0x546710", VA = "0x180547710")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public T this[int BHMABHNBMJE, int LIIMBCBAKNH]
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x1F300E0", Offset = "0x1F2F0E0", VA = "0x181F300E0")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x1F30180", Offset = "0x1F2F180", VA = "0x181F30180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x1F30050", Offset = "0x1F2F050", VA = "0x181F30050")]
		public Array2D(uint DNPKPAMDPOM, uint OFPEKKPMEGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x1F2FFD0", Offset = "0x1F2EFD0", VA = "0x181F2FFD0")]
		public void EMKEODJBGFL()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x4B788C0", Offset = "0x4B778C0", VA = "0x184B788C0")]
		public Array2DVector3(uint DNPKPAMDPOM, uint OFPEKKPMEGK)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal static class MIMEEEJJOJJ
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public const int IMKDNGKLGHN = -1;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public const int HHGDOOHJELK = 0;
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[DefaultMember("Item")]
public class LAAMOJECPFF<THandle, TValue> : IDisposable where THandle : struct, PILHAHHJKAO where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly List<THandle> MFBICMAGNFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly List<TValue> LFABLMMJAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly Func<TValue> ILFFBPDJCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly Action<TValue> FCAFHFAICFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private int NEAKKOOEPJN;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public TValue KBPJCMENGBH
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x3020140", Offset = "0x301F140", VA = "0x183020140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x3D1A130", Offset = "0x3D19130", VA = "0x183D1A130")]
	public LAAMOJECPFF(Action<TValue> FCAFHFAICFF, [Optional] Func<TValue> ILFFBPDJCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x3D19AB0", Offset = "0x3D18AB0", VA = "0x183D19AB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x3D19750", Offset = "0x3D18750", VA = "0x183D19750")]
	public THandle ANENLEADNCN()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x3D19DF0", Offset = "0x3D18DF0", VA = "0x183D19DF0")]
	public THandle IPMJFBAMOHP(TValue PLIDGBGAHIA)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x3D19E60", Offset = "0x3D18E60", VA = "0x183D19E60")]
	public bool JBOIIODGKNN(THandle BIHDAONKAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x3D19CA0", Offset = "0x3D18CA0", VA = "0x183D19CA0")]
	public bool HBEBAEGKIKL(THandle BIHDAONKAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x3D1A080", Offset = "0x3D19080", VA = "0x183D1A080")]
	public bool OHHPOFFENOI(THandle BIHDAONKAFA, out TValue PLIDGBGAHIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x3D19B90", Offset = "0x3D18B90", VA = "0x183D19B90")]
	public TValue ELOPIDONOEF(THandle BIHDAONKAFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x3D19A00", Offset = "0x3D18A00", VA = "0x183D19A00")]
	public bool DEMNLOLEPAD(THandle BIHDAONKAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x3D197F0", Offset = "0x3D187F0", VA = "0x183D197F0")]
	private THandle BFFKGDCALKB(int EKKABPEEACK)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x3D19DC0", Offset = "0x3D18DC0", VA = "0x183D19DC0")]
	private TValue ILHOBFMIBDC(int EKKABPEEACK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x3D19D80", Offset = "0x3D18D80", VA = "0x183D19D80")]
	private void HDFMEODLGHB(int EKKABPEEACK, in THandle BIHDAONKAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x3D1A040", Offset = "0x3D19040", VA = "0x183D1A040")]
	private void MFBLJJEHMJM(int EKKABPEEACK, in TValue PLIDGBGAHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x3D198F0", Offset = "0x3D188F0", VA = "0x183D198F0")]
	private THandle DBFPHILACFE()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x3D19BE0", Offset = "0x3D18BE0", VA = "0x183D19BE0")]
	private void GCLEMKOGNGF(THandle BIHDAONKAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x3D1A120", Offset = "0x3D19120", VA = "0x183D1A120")]
	private int PAKFBKHMAEC(int ELJOMJDDOPI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x3D1A030", Offset = "0x3D19030", VA = "0x183D1A030")]
	private bool KKFFLPOGCOJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x5749A0", Offset = "0x5739A0", VA = "0x1805749A0")]
	private void OHAKLOHEIGE(THandle BIHDAONKAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x3D19590", Offset = "0x3D18590", VA = "0x183D19590")]
	private bool ABCNKAOBDBJ(out THandle BIHDAONKAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x3D19820", Offset = "0x3D18820", VA = "0x183D19820")]
	private bool BHCOBKHLIPJ(out THandle BIHDAONKAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x3D19B30", Offset = "0x3D18B30", VA = "0x183D19B30")]
	private void EIKNICPODLE(THandle BIHDAONKAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x3D19F10", Offset = "0x3D18F10", VA = "0x183D19F10")]
	private void KKBGOIFADGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public interface PILHAHHJKAO
{
	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	int LNGEFDKGBOK
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	int AKHAAILOLAF
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface BNOBFPKKPMN<T> : PILHAHHJKAO, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class OGCCLBPBNGM
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x23D2530", Offset = "0x23D1530", VA = "0x1823D2530")]
	public static bool MAPKFMNHJLI<T>(this T BIHDAONKAFA) where T : struct, PILHAHHJKAO
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class PGNLLDPGGKB
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private enum BNNCDDPBBIN : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private int HMPDEPCCOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private bool NLBBPCANFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private BNNCDDPBBIN OPDFNKFLKHI;

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool ACKJGANEAPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x4B7C230", Offset = "0x4B7B230", VA = "0x184B7C230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool MJFOGEHEHMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x4B7C240", Offset = "0x4B7B240", VA = "0x184B7C240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C290", Offset = "0x4B7B290", VA = "0x184B7C290")]
	public PGNLLDPGGKB(bool NLBBPCANFNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x4B7B620", Offset = "0x4B7A620", VA = "0x184B7B620")]
	public void DJOCAKPKMHF(object HAFCDCMNBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C070", Offset = "0x4B7B070", VA = "0x184B7C070")]
	public void LIBMBJCKDLK(int PLIDGBGAHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C190", Offset = "0x4B7B190", VA = "0x184B7C190")]
	public void OKGLIBPBOBH(uint EPECEKKINFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x4B7B590", Offset = "0x4B7A590", VA = "0x184B7B590")]
	public void DBMGLAFNMLP(bool ADBEMDFJJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C250", Offset = "0x4B7B250", VA = "0x184B7C250")]
	public void PPAMJJPOFHK(long IBPOLIAADBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C030", Offset = "0x4B7B030", VA = "0x184B7C030")]
	public void LDBOKJEOIKP(ulong EDHJIKJAMGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x4B7B520", Offset = "0x4B7A520", VA = "0x184B7B520")]
	public void CFICCBPDCDH(string JOCGGFPHFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C1A0", Offset = "0x4B7B1A0", VA = "0x184B7C1A0")]
	public void OONLKKJIBKB(Enum KECOEODIMDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x4B7BF10", Offset = "0x4B7AF10", VA = "0x184B7BF10")]
	public void LBGMJPPLBAO(IList HGHCNAACJPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7D60", Offset = "0x2CE6D60", VA = "0x182CE7D60")]
	public void FEDFNIIJEAH<T, U>(Dictionary<T, U> CIDPGHDNNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x4B7BB40", Offset = "0x4B7AB40", VA = "0x184B7BB40")]
	private void EFIEKKCEPHL(IDictionary CIDPGHDNNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x4B7B5B0", Offset = "0x4B7A5B0", VA = "0x184B7B5B0")]
	public int DDEPDNMDFGF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C120", Offset = "0x4B7B120", VA = "0x184B7C120")]
	public short NNDNBEKOEPN()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x4B7BF00", Offset = "0x4B7AF00", VA = "0x184B7BF00")]
	public void EMKEODJBGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x4B7B4B0", Offset = "0x4B7A4B0", VA = "0x184B7B4B0")]
	private void AENIHGKDCCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public abstract class OJJLFDCJILI<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	internal class PKCLFJMONCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public TNode IEAADLFMGGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public TNode BMCODBFOLMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public DGKMNKDNEJJ JOBJBNJBKEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public List<DGKMNKDNEJJ> NLOOHHKKOKM;

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x1C193A0", Offset = "0x1C183A0", VA = "0x181C193A0")]
		public PKCLFJMONCL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	internal struct DGKMNKDNEJJ : IComparable<DGKMNKDNEJJ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int BMADDHGHCIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public TClaimant BEDDPHJHIAD;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x52BCF0", Offset = "0x52ACF0", VA = "0x18052BCF0")]
		public DGKMNKDNEJJ(int BMADDHGHCIE, TClaimant BEDDPHJHIAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x314B4E0", Offset = "0x314A4E0", VA = "0x18314B4E0")]
		public bool CPABJOCFJOK(in DGKMNKDNEJJ JFBDCEDLHDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x314B550", Offset = "0x314A550", VA = "0x18314B550")]
		public bool JKMIAPBDMKO(in DGKMNKDNEJJ JFBDCEDLHDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x314B540", Offset = "0x314A540", VA = "0x18314B540", Slot = "4")]
		public int CompareTo(DGKMNKDNEJJ JFBDCEDLHDN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x314B560", Offset = "0x314A560", VA = "0x18314B560", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public enum GOHJMJNDKLC
	{
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class OKOGKNOBNJF : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public global::OJJLFDCJILI<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x2EED790", Offset = "0x2EEC790", VA = "0x182EED790")]
		[DebuggerHidden]
		public OKOGKNOBNJF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x523E80", Offset = "0x522E80", VA = "0x180523E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x3156AC0", Offset = "0x3155AC0", VA = "0x183156AC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x3156C80", Offset = "0x3155C80", VA = "0x183156C80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x3156BA0", Offset = "0x3155BA0", VA = "0x183156BA0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x1C241F0", Offset = "0x1C231F0", VA = "0x181C241F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private static readonly global::HJEEKOOKCGD<PKCLFJMONCL> GFDNHFEIGMN;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private static readonly global::HJEEKOOKCGD<List<DGKMNKDNEJJ>> EPIICCEDIMG;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static int CLJKPGNNDOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	internal readonly Dictionary<TClaimant, TNode> POJCFNFLDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	internal readonly Dictionary<TNode, PKCLFJMONCL> MOMJAJKEAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private GOHJMJNDKLC DCAOONJKPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private bool CEBPLIEGIDP;

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode EJJALIMEJGB(TNode ODGFBBJPCEB);

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void OCKFKHPOCKN(TNode ODGFBBJPCEB, TClaimant DFCOGMEKPGO, TClaimant GKMNJAPACCH);

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x31565C0", Offset = "0x31555C0", VA = "0x1831565C0")]
	public OJJLFDCJILI(GOHJMJNDKLC DCAOONJKPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x31558A0", Offset = "0x31548A0", VA = "0x1831558A0")]
	public void GAJIBFNOMDE(TNode ODGFBBJPCEB, TNode ELPMOAHNJMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x31550E0", Offset = "0x31540E0", VA = "0x1831550E0")]
	public void BNCDCKLMBDN(TClaimant BEDDPHJHIAD, TNode BMCKJNDJFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x31551E0", Offset = "0x31541E0", VA = "0x1831551E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x3155920", Offset = "0x3154920", VA = "0x183155920")]
	private void GLFAPIMCKBI(TClaimant BEDDPHJHIAD, TNode LCPBHKCGKLG, TNode BMCKJNDJFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x3155D40", Offset = "0x3154D40", VA = "0x183155D40")]
	private int LBPJAKELJGP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x3154E30", Offset = "0x3153E30", VA = "0x183154E30")]
	private void BHJLIJCIAML(TClaimant BEDDPHJHIAD, TNode IHDGEEBHCOI, TNode IKDCOMFFMHB, int OMJHCFCBFCL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x3155810", Offset = "0x3154810", VA = "0x183155810")]
	private void FKOIAHCAHEH(DGKMNKDNEJJ DCGAEINGPNA, PKCLFJMONCL LKCAEGBKBKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x3155DB0", Offset = "0x3154DB0", VA = "0x183155DB0")]
	private void LGBNIGLJEAH(TClaimant BEDDPHJHIAD, TNode IHDGEEBHCOI, TNode IKDCOMFFMHB, int OMJHCFCBFCL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x3155710", Offset = "0x3154710", VA = "0x183155710")]
	private void EEHANDPMJBN(DGKMNKDNEJJ DCGAEINGPNA, TNode ODGFBBJPCEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x3155A80", Offset = "0x3154A80", VA = "0x183155A80")]
	private void IAGEIJIAOMD(DGKMNKDNEJJ DCGAEINGPNA, PKCLFJMONCL LKCAEGBKBKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x31555D0", Offset = "0x31545D0", VA = "0x1831555D0")]
	private void ECPHONIBAEL(PKCLFJMONCL LKCAEGBKBKM, bool FBBJFHFBPHE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x3156020", Offset = "0x3155020", VA = "0x183156020")]
	private void LOIGELMLEFG(PKCLFJMONCL LKCAEGBKBKM, TNode ELPMOAHNJMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x3154D60", Offset = "0x3153D60", VA = "0x183154D60")]
	[IteratorStateMachine(typeof(global::OJJLFDCJILI<, >.OKOGKNOBNJF))]
	private IEnumerable<TNode> BCHCBKDBNFG(TNode IHDGEEBHCOI, TNode IKDCOMFFMHB, bool MIBPAGFHCHL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x31559C0", Offset = "0x31549C0", VA = "0x1831559C0")]
	private PKCLFJMONCL GOLJKKOBBCO(TNode ODGFBBJPCEB, TNode BMCODBFOLMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x3155440", Offset = "0x3154440", VA = "0x183155440")]
	private PKCLFJMONCL EBBNMOIMADP(TNode ODGFBBJPCEB, TNode BMCODBFOLMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x3155B80", Offset = "0x3154B80", VA = "0x183155B80")]
	private void KIGFGDIGPEE(PKCLFJMONCL LKCAEGBKBKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class HDECPDEABIL<T> : IEnumerable<global::HDECPDEABIL<T>.LPBLDFGHDKB>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public struct LPBLDFGHDKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public T PLIDGBGAHIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public int EKKABPEEACK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class HDIFLILIPNN : IEnumerator<LPBLDFGHDKB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private global::HDECPDEABIL<T> KFOAIMILKCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private int EKKABPEEACK;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x2842440", Offset = "0x2841440", VA = "0x182842440", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public LPBLDFGHDKB ODPOJCJJJLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x4268960", Offset = "0x4267960", VA = "0x184268960", Slot = "4")]
			get
			{
				return default(LPBLDFGHDKB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x873D30", Offset = "0x872D30", VA = "0x180873D30")]
		public HDIFLILIPNN(global::HDECPDEABIL<T> KFOAIMILKCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x42688D0", Offset = "0x42678D0", VA = "0x1842688D0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x7D75B0", Offset = "0x7D65B0", VA = "0x1807D75B0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x80BD40", Offset = "0x80AD40", VA = "0x18080BD40", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private struct FDPIDJEOJMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public bool IHDIIBAJHBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public T PLIDGBGAHIA;
	}

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private const int NKGIFGJJCNN = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private Dictionary<T, int> BFDIHFHEAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private FDPIDJEOJMG[] ACOHMPPJBFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private int BMMECNIDMFE;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public int PHEEIFDPPOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x27664D0", Offset = "0x27654D0", VA = "0x1827664D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x4268180", Offset = "0x4267180", VA = "0x184268180")]
	public static global::HDECPDEABIL<T> LKKEHLDEFKP(LPBLDFGHDKB[] BHAMNGIAKMD, bool FLBCLKGPECI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x42687F0", Offset = "0x42677F0", VA = "0x1842687F0")]
	public HDECPDEABIL(int EOFEALDJCNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x352F960", Offset = "0x352E960", VA = "0x18352F960")]
	public bool BBPPHLFCFIP(T PLIDGBGAHIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x4267BE0", Offset = "0x4266BE0", VA = "0x184267BE0")]
	public bool ABGKBLKIAHB(int EKKABPEEACK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x4267CE0", Offset = "0x4266CE0", VA = "0x184267CE0")]
	public bool HGMOGCLFPNP(Func<T, bool> IICBFGDGEKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x42686D0", Offset = "0x42676D0", VA = "0x1842686D0")]
	public int PAFAAHHLICK(T PLIDGBGAHIA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x4267D90", Offset = "0x4266D90", VA = "0x184267D90")]
	public T ILHOBFMIBDC(int EKKABPEEACK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x4267C90", Offset = "0x4266C90", VA = "0x184267C90")]
	public void EMKEODJBGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x4268030", Offset = "0x4267030", VA = "0x184268030")]
	public bool JAJBCKKAAGN(T PLIDGBGAHIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x4267E00", Offset = "0x4266E00", VA = "0x184267E00")]
	public bool JAJBCKKAAGN(T PLIDGBGAHIA, int EKKABPEEACK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x4268050", Offset = "0x4267050", VA = "0x184268050")]
	public bool JBOIIODGKNN(T PLIDGBGAHIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x4268720", Offset = "0x4267720", VA = "0x184268720")]
	public bool PGBHCFNJAPM(int EKKABPEEACK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x42680D0", Offset = "0x42670D0", VA = "0x1842680D0")]
	private void KHDHAHKLIAB(int EKKABPEEACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x4268560", Offset = "0x4267560", VA = "0x184268560")]
	public LPBLDFGHDKB[] OOHEAALMBAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x4267C40", Offset = "0x4266C40", VA = "0x184267C40")]
	private int DNIEBIOLDEM(int JIBJAEPFHMH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x4268770", Offset = "0x4267770", VA = "0x184268770", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x4268770", Offset = "0x4267770", VA = "0x184268770", Slot = "4")]
	private IEnumerator<LPBLDFGHDKB> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class HJEEKOOKCGD<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly Stack<T> HMNFHOHAFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly List<T> MCFPGKCIIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly int KELDJHDKDFP;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public int IGLPOFHFLMC
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x1F388B0", Offset = "0x1F378B0", VA = "0x181F388B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public int CDILGPFPEAB
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x1F36AF0", Offset = "0x1F35AF0", VA = "0x181F36AF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x4269000", Offset = "0x4268000", VA = "0x184269000")]
	public static global::HJEEKOOKCGD<T> EPMMCJBCLFF(int EOFEALDJCNO = 0, int KELDJHDKDFP = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x42690D0", Offset = "0x42680D0", VA = "0x1842690D0")]
	public static global::HJEEKOOKCGD<T> FLBKNGMGMDA(int EOFEALDJCNO = 0, int KELDJHDKDFP = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x42695D0", Offset = "0x42685D0", VA = "0x1842695D0")]
	public HJEEKOOKCGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x4269440", Offset = "0x4268440", VA = "0x184269440")]
	public HJEEKOOKCGD(int EOFEALDJCNO, int KELDJHDKDFP = int.MaxValue, bool IGPNNFCMLAK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x4269310", Offset = "0x4268310", VA = "0x184269310")]
	public T NKOGNMKGDCK()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x4268F40", Offset = "0x4267F40", VA = "0x184268F40")]
	public void EEMDNAFIMDP(T PLIDGBGAHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x42691A0", Offset = "0x42681A0", VA = "0x1842691A0")]
	private void IFELKCELKLI(T PLIDGBGAHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x4268BF0", Offset = "0x4267BF0", VA = "0x184268BF0")]
	private void ANENCLIDHGC(T PLIDGBGAHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x4268B50", Offset = "0x4267B50", VA = "0x184268B50")]
	[Conditional("DEBUG_BUILD")]
	private void AFFINGAAMPK(T FGMDJKNJEJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x4269260", Offset = "0x4268260", VA = "0x184269260")]
	[Conditional("DEBUG_BUILD")]
	private void JIOJIAGKOEJ(T FGMDJKNJEJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x4268E30", Offset = "0x4267E30", VA = "0x184268E30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x4268C10", Offset = "0x4267C10", VA = "0x184268C10")]
	private void BJOOALGGMPC(IEnumerable<T> LFABLMMJAJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class BHIBPCAAGID<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private Dictionary<int, T> LFAAMNBHNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private T EAMAEONEOFO;

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public virtual T FMGKNLDEONI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x5234A0", Offset = "0x5224A0", VA = "0x1805234A0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public bool BMDMEDCFHOK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x348E8B0", Offset = "0x348D8B0", VA = "0x18348E8B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x348E950", Offset = "0x348D950", VA = "0x18348E950")]
	public bool FOPPAMGFOBA(T PLIDGBGAHIA, int BMADDHGHCIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x348EB80", Offset = "0x348DB80", VA = "0x18348EB80")]
	public bool PKHNGEBGEIH(int BMADDHGHCIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x348E380", Offset = "0x348D380", VA = "0x18348E380")]
	public T DCPODBOGMCM(int KPMBGHCIHNE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x348E850", Offset = "0x348D850", VA = "0x18348E850")]
	public void EMKEODJBGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x348EAC0", Offset = "0x348DAC0", VA = "0x18348EAC0")]
	private bool GLBKEIHNPGP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x348EB50", Offset = "0x348DB50", VA = "0x18348EB50")]
	public bool PFJCFGHJDPO(int BMADDHGHCIE, out T PLIDGBGAHIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x348EBE0", Offset = "0x348DBE0", VA = "0x18348EBE0")]
	public BHIBPCAAGID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class EKEKACOMNPP<T>
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	protected struct BCAFOPGKNHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public T OGNMMFGGOMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public int GNMCBBOMFIM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	protected readonly List<BCAFOPGKNHG> JNNMPCOMGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private T MCGINHBMAMB;

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public int PHEEIFDPPOK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x1F36AC0", Offset = "0x1F35AC0", VA = "0x181F36AC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x3725AE0", Offset = "0x3724AE0", VA = "0x183725AE0")]
	public bool HGMOGCLFPNP(T PLIDGBGAHIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x3725D30", Offset = "0x3724D30", VA = "0x183725D30")]
	public void IPMJFBAMOHP(T PLIDGBGAHIA, int BMADDHGHCIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x3725DD0", Offset = "0x3724DD0", VA = "0x183725DD0")]
	public bool JBOIIODGKNN(T PLIDGBGAHIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x3725A80", Offset = "0x3724A80", VA = "0x183725A80")]
	public void EMKEODJBGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x3725F60", Offset = "0x3724F60", VA = "0x183725F60")]
	public T JLLHGGKDKPJ()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x3725EF0", Offset = "0x3724EF0", VA = "0x183725EF0")]
	public T JHCEOANIDEA()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x3725FF0", Offset = "0x3724FF0", VA = "0x183725FF0")]
	private void KBMBFCCMBPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x3726200", Offset = "0x3725200", VA = "0x183726200")]
	public EKEKACOMNPP()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[SerializeField]
		[HDHOGJGJBFN(OGLALOIFFPF.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x4B7CAD0", Offset = "0x4B7BAD0", VA = "0x184B7CAD0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x4B7CFA0", Offset = "0x4B7BFA0", VA = "0x184B7CFA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x4B7CDC0", Offset = "0x4B7BDC0", VA = "0x184B7CDC0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x4B7D140", Offset = "0x4B7C140", VA = "0x184B7D140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x4B7C990", Offset = "0x4B7B990", VA = "0x184B7C990")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x4B7CE60", Offset = "0x4B7BE60", VA = "0x184B7CE60")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x4B7CC80", Offset = "0x4B7BC80", VA = "0x184B7CC80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x4B7C8F0", Offset = "0x4B7B8F0", VA = "0x184B7C8F0")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public interface BHJJNGFKHNN
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public abstract class ResourcePrefabReference<T> : BHJJNGFKHNN where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x1F439B0", Offset = "0x1F429B0", VA = "0x181F439B0", Slot = "4")]
		public virtual T OHJFAKDKLHL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x1C193A0", Offset = "0x1C183A0", VA = "0x181C193A0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class FEOLMNGHENI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly Dictionary<byte, JNOEDEOHLCE> MGHJCEPFEGE;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public JNOEDEOHLCE IBHFKNFFDOL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x5231D0", Offset = "0x5221D0", VA = "0x1805231D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x523490", Offset = "0x522490", VA = "0x180523490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public Vector2 IPGMKOHNKMM
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x14B55A0", Offset = "0x14B45A0", VA = "0x1814B55A0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x2EF1580", Offset = "0x2EF0580", VA = "0x182EF1580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Vector2 CPKMJHHKOEF
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x153D590", Offset = "0x153C590", VA = "0x18153D590")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x153D5F0", Offset = "0x153C5F0", VA = "0x18153D5F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Vector2 DGKPCINEGLP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x363D340", Offset = "0x363C340", VA = "0x18363D340")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x363D360", Offset = "0x363C360", VA = "0x18363D360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public int EJCBLNGDEBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x54E7E0", Offset = "0x54D7E0", VA = "0x18054E7E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x5749A0", Offset = "0x5739A0", VA = "0x1805749A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x4B79DD0", Offset = "0x4B78DD0", VA = "0x184B79DD0")]
	public FEOLMNGHENI(Bounds DPJFONGOGEE, Vector2[] IFEHPPGBJFL, int LNNNAJIODAE, byte JIBJAEPFHMH, float GPNNFHDPNAL = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x4B79610", Offset = "0x4B78610", VA = "0x184B79610")]
	public JNOEDEOHLCE BMOBGKGHOKB(byte EKKABPEEACK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x4B79670", Offset = "0x4B78670", VA = "0x184B79670")]
	public void FAEFPHKONIF(Vector3 ODCBANFDMOH, float AOPCBNKJNII, float CECHLAGDLJE, ref List<byte> NBDLBLDGIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x4B79C80", Offset = "0x4B78C80", VA = "0x184B79C80")]
	public void LIHLCFKCFPG(JNOEDEOHLCE.EDIFEINMOKP COFEADICOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x4B79CA0", Offset = "0x4B78CA0", VA = "0x184B79CA0")]
	private JNOEDEOHLCE LKNJMMKKAHC(byte EKKABPEEACK, JNOEDEOHLCE.IPLKHMADJAM ABAGHCECOPL, JNOEDEOHLCE BMCODBFOLMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x4B79760", Offset = "0x4B78760", VA = "0x184B79760")]
	private void IELHDNJOFPE(JNOEDEOHLCE BMCODBFOLMP, Vector2[] IFEHPPGBJFL, int CACHOEGCLLM, int HMDFJBJAJBL, int MCJALDLHABN, int LHLGPHGFCGB, float GPNNFHDPNAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class JNOEDEOHLCE
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public enum IPLKHMADJAM
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public enum EDIFEINMOKP
	{
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public byte KKJLMKOGMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public Vector3 IPJAEIMKIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public Vector3 LGCMEBDOBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public Vector3 NOMBNKOKBDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public Vector3 BKCEFECDMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public IPLKHMADJAM DPHKJCJADCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public JNOEDEOHLCE BDMPMIJDNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public List<JNOEDEOHLCE> JNPFPNEFHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public bool EIHFJOEDLHM;

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x4B7AF70", Offset = "0x4B79F70", VA = "0x184B7AF70")]
	public JNOEDEOHLCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x4B7AF90", Offset = "0x4B79F90", VA = "0x184B7AF90")]
	public JNOEDEOHLCE(byte IKMEJIEPFCI, IPLKHMADJAM ABAGHCECOPL, JNOEDEOHLCE BMCODBFOLMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x4B7AE70", Offset = "0x4B79E70", VA = "0x184B7AE70")]
	public void KHKNHFJHFMN(JNOEDEOHLCE AFLMHKAHGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x523E80", Offset = "0x522E80", VA = "0x180523E80")]
	public void LIHLCFKCFPG(int IBHBAEHLFJH, EDIFEINMOKP COFEADICOOP, int NAINEOMGJGC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x4B7ABA0", Offset = "0x4B79BA0", VA = "0x184B7ABA0")]
	public void FAEFPHKONIF(List<byte> NBDLBLDGIDN, Vector3 ODCBANFDMOH, float AOPCBNKJNII, float CECHLAGDLJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x4B7AF10", Offset = "0x4B79F10", VA = "0x184B7AF10")]
	public bool KIPPONNNOBI(Vector3 GAJJAOBPAAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x4B7AE30", Offset = "0x4B79E30", VA = "0x184B7AE30")]
	public bool GFLNLFMIFKB(Vector3 GAJJAOBPAAK, float DOKJLICFOHA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class MMJLBGCIJGM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly Dictionary<T, object> MKCHPJBMAMB;

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x226B960", Offset = "0x226A960", VA = "0x18226B960")]
	public bool CBCBMBMGHBL(T JLKPMEOAPII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x226C660", Offset = "0x226B660", VA = "0x18226C660")]
	public bool CBCBMBMGHBL(T JLKPMEOAPII, object NPCBGOCOLAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x226C600", Offset = "0x226B600", VA = "0x18226C600")]
	public bool CBCBMBMGHBL(T JLKPMEOAPII, object NPCBGOCOLAF, out object BNDJNIENBLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x226C770", Offset = "0x226B770", VA = "0x18226C770")]
	public bool LIGLDFJNJIL(T JLKPMEOAPII, object NPCBGOCOLAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x226C6A0", Offset = "0x226B6A0", VA = "0x18226C6A0")]
	public bool FOAEPEDFHCO(T JLKPMEOAPII, object NPCBGOCOLAF, out object BNDJNIENBLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x226C6E0", Offset = "0x226B6E0", VA = "0x18226C6E0")]
	public bool LIGLDFJNJIL(T JLKPMEOAPII, object NPCBGOCOLAF, out object BNDJNIENBLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x226C7B0", Offset = "0x226B7B0", VA = "0x18226C7B0")]
	public void PBBBDEEFFJF(T JLKPMEOAPII, object NPCBGOCOLAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x226C7E0", Offset = "0x226B7E0", VA = "0x18226C7E0")]
	public void PDIPNBPBNED(T JLKPMEOAPII, object NPCBGOCOLAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x226C880", Offset = "0x226B880", VA = "0x18226C880")]
	public MMJLBGCIJGM()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		public struct NHNCJDCGALA<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			private readonly List<Component> HGHCNAACJPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			private readonly bool AGGGLFPGHFK;

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x782880", Offset = "0x781880", VA = "0x180782880")]
			public NHNCJDCGALA(List<Component> HGHCNAACJPO, bool AGGGLFPGHFK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x1F38F40", Offset = "0x1F37F40", VA = "0x181F38F40")]
			public KPJHEDOHKBG<T> FGBDFIIFHCE()
			{
				return default(KPJHEDOHKBG<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x1F38FB0", Offset = "0x1F37FB0", VA = "0x181F38FB0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x1F38FB0", Offset = "0x1F37FB0", VA = "0x181F38FB0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000085")]
		public struct KPJHEDOHKBG<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			private readonly List<Component> HGHCNAACJPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			private readonly bool AGGGLFPGHFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			private int EKKABPEEACK;

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public T ODPOJCJJJLB
			{
				[Cpp2IlInjected.Token(Token = "0x60002FD")]
				[Cpp2IlInjected.Address(RVA = "0x1F387A0", Offset = "0x1F377A0", VA = "0x181F387A0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000084")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002FE")]
				[Cpp2IlInjected.Address(RVA = "0x1F38730", Offset = "0x1F37730", VA = "0x181F38730", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x1F38770", Offset = "0x1F37770", VA = "0x181F38770")]
			public KPJHEDOHKBG(List<Component> HGHCNAACJPO, bool AGGGLFPGHFK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x1F38660", Offset = "0x1F37660", VA = "0x181F38660", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x1F38670", Offset = "0x1F37670", VA = "0x181F38670", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x1F38720", Offset = "0x1F37720", VA = "0x181F38720", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x4B7EE00", Offset = "0x4B7DE00", VA = "0x184B7EE00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x4B7EDC0", Offset = "0x4B7DDC0", VA = "0x184B7EDC0")]
		public ToolHierarchyCache(GameObject CADDDPJHLNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x4B7E630", Offset = "0x4B7D630", VA = "0x184B7E630")]
		private void AMFLIFGPNGM(GameObject CADDDPJHLNM, bool DGDLOMNBBNJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x4B7E5A0", Offset = "0x4B7D5A0", VA = "0x184B7E5A0")]
		public static void AMFLIFGPNGM(GameObject CADDDPJHLNM, ref ToolHierarchyCache KGLJCEABLEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x4B7E750", Offset = "0x4B7D750", VA = "0x184B7E750")]
		public void BAOCMPFPLGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x4B7EA60", Offset = "0x4B7DA60", VA = "0x184B7EA60")]
		public void MEMBCLALNFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x1BB95F0", Offset = "0x1BB85F0", VA = "0x181BB95F0")]
		public void FBCFOOKCKJH<T>(Action<T> HCODLMJPEMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x4B7E820", Offset = "0x4B7D820", VA = "0x184B7E820")]
		public Component BOHGEPENEAK(Type LDJDMLKKJPF, bool AGGGLFPGHFK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x1DED360", Offset = "0x1DEC360", VA = "0x181DED360")]
		public T BOHGEPENEAK<T>(bool AGGGLFPGHFK = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x4B7E960", Offset = "0x4B7D960", VA = "0x184B7E960")]
		public NHNCJDCGALA<Component> GGDDJPKHBIK(Type LDJDMLKKJPF, bool AGGGLFPGHFK = false)
		{
			return default(NHNCJDCGALA<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x297D2F0", Offset = "0x297C2F0", VA = "0x18297D2F0")]
		public NHNCJDCGALA<T> GGDDJPKHBIK<T>(bool AGGGLFPGHFK = false) where T : class
		{
			return default(NHNCJDCGALA<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x4B7EAB0", Offset = "0x4B7DAB0", VA = "0x184B7EAB0")]
		public List<Component> PPDCIAKCHMC(Type LDJDMLKKJPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x4B7E8E0", Offset = "0x4B7D8E0", VA = "0x184B7E8E0", Slot = "4")]
		public bool Equals(ToolHierarchyCache PACPIJAANIO, ToolHierarchyCache OKDBMFJJANH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x4B7E9F0", Offset = "0x4B7D9F0", VA = "0x184B7E9F0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache HAFCDCMNBJO)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class PNHGFMLPDIF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private int EOFEALDJCNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private int HHCIIHIJDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private List<T> GKFBHEMILJG;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int PHEEIFDPPOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x1F388B0", Offset = "0x1F378B0", VA = "0x181F388B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public T GOMJDNJLCKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x4194210", Offset = "0x4193210", VA = "0x184194210")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public T EIKFCLPFCOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x4194580", Offset = "0x4193580", VA = "0x184194580")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public T ABIMLHIIHIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x4194110", Offset = "0x4193110", VA = "0x184194110")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x4194690", Offset = "0x4193690", VA = "0x184194690")]
	public PNHGFMLPDIF(int EOFEALDJCNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x4194330", Offset = "0x4193330", VA = "0x184194330")]
	public void IPMJFBAMOHP(T FHPNHJCJFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x41941D0", Offset = "0x41931D0", VA = "0x1841941D0")]
	public void EMKEODJBGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x41944E0", Offset = "0x41934E0", VA = "0x1841944E0")]
	public void JFOMGGLOFPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x4194640", Offset = "0x4193640", VA = "0x184194640")]
	public void POLNJOCGEGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x4194630", Offset = "0x4193630", VA = "0x184194630")]
	public void NHNJONEICLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class JCJOGJMLGEO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private bool OCKNNIENHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private Action HCODLMJPEMJ;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public static JCJOGJMLGEO JKBGBOGKDKH
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x4B7AB00", Offset = "0x4B79B00", VA = "0x184B7AB00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool FGOBIOLNBAE
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x54E7B0", Offset = "0x54D7B0", VA = "0x18054E7B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x85D6F0", Offset = "0x85C6F0", VA = "0x18085D6F0")]
	public JCJOGJMLGEO(Action HCODLMJPEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x4B7AB80", Offset = "0x4B79B80", VA = "0x184B7AB80")]
	public void GJKAPAPOEHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x4B7AB80", Offset = "0x4B79B80", VA = "0x184B7AB80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public static class CBFEECEKPEE
{
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x523E80", Offset = "0x522E80", VA = "0x180523E80")]
	public static void ILCLBBEGPFJ(PHHODAEBEGH FJIGDDJNFAF, string NGFHPGIOHKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class BIFOOLCHBAB<T>
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private struct FCDONNHFIEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public int GNMCBBOMFIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public T OGNMMFGGOMO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private Dictionary<object, FCDONNHFIEF> LFAAMNBHNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private T EAMAEONEOFO;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public virtual T FMGKNLDEONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x14B55A0", Offset = "0x14B45A0", VA = "0x1814B55A0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x2EF1580", Offset = "0x2EF0580", VA = "0x182EF1580", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool BMDMEDCFHOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x348F790", Offset = "0x348E790", VA = "0x18348F790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public object BGEEAIGLNHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x525DF0", Offset = "0x524DF0", VA = "0x180525DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x54DD70", Offset = "0x54CD70", VA = "0x18054DD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x348F960", Offset = "0x348E960", VA = "0x18348F960")]
	public bool FOPPAMGFOBA(T PLIDGBGAHIA, object NPCBGOCOLAF, int BMADDHGHCIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x3495360", Offset = "0x3494360", VA = "0x183495360")]
	public bool PKHNGEBGEIH(object NPCBGOCOLAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x3494F00", Offset = "0x3493F00", VA = "0x183494F00")]
	public bool PFJCFGHJDPO(object NPCBGOCOLAF, out T PLIDGBGAHIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x3015860", Offset = "0x3014860", VA = "0x183015860")]
	public void EMKEODJBGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x3493460", Offset = "0x3492460", VA = "0x183493460")]
	private bool GLBKEIHNPGP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x348EBE0", Offset = "0x348DBE0", VA = "0x18348EBE0")]
	public BIFOOLCHBAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public class PLOBELAJMMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private Dictionary<object, float> LFAAMNBHNLA;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public float NAFKFJJLFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0xEE0760", Offset = "0xEDF760", VA = "0x180EE0760")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0xD50260", Offset = "0xD4F260", VA = "0x180D50260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C670", Offset = "0x4B7B670", VA = "0x184B7C670")]
	public void FOPPAMGFOBA(float PLIDGBGAHIA, object NPCBGOCOLAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C800", Offset = "0x4B7B800", VA = "0x184B7C800")]
	public void PKHNGEBGEIH(object NPCBGOCOLAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C6E0", Offset = "0x4B7B6E0", VA = "0x184B7C6E0")]
	private void HOHKOINFFBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C870", Offset = "0x4B7B870", VA = "0x184B7C870")]
	public PLOBELAJMMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public sealed class PHHODAEBEGH
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public sealed class ICEEIHJMMHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private readonly string GCHAHGMGFCH;

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
		private ICEEIHJMMHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x684A70", Offset = "0x683A70", VA = "0x180684A70")]
		public ICEEIHJMMHM(string GCHAHGMGFCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x4B7A760", Offset = "0x4B79760", VA = "0x184B7A760", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class DDHOKGLNGDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
		public DDHOKGLNGDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x4B78C10", Offset = "0x4B77C10", VA = "0x184B78C10")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private readonly HashSet<object> LMKNGKOGNBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private int GEGBPKMANBE;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public bool FMGGBEJHCCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x4B7C480", Offset = "0x4B7B480", VA = "0x184B7C480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public int PHEEIFDPPOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x5AF670", Offset = "0x5AE670", VA = "0x1805AF670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C380", Offset = "0x4B7B380", VA = "0x184B7C380")]
	public bool IPMJFBAMOHP(object NPCBGOCOLAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C400", Offset = "0x4B7B400", VA = "0x184B7C400")]
	public bool JBOIIODGKNN(object NPCBGOCOLAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C320", Offset = "0x4B7B320", VA = "0x184B7C320")]
	public bool HGMOGCLFPNP(object NPCBGOCOLAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C2C0", Offset = "0x4B7B2C0", VA = "0x184B7C2C0")]
	public void GEJFNKEFLDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C490", Offset = "0x4B7B490", VA = "0x184B7C490", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C600", Offset = "0x4B7B600", VA = "0x184B7C600")]
	public PHHODAEBEGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class DOOFLABBMLE<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	private struct ABMGFELOBKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public float GGALIFFNDNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public T OGNMMFGGOMO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private Dictionary<object, ABMGFELOBKE> LFAAMNBHNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private T AMMGBCNEDFJ;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public virtual T KKJPIOCLOPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x196BF20", Offset = "0x196AF20", VA = "0x18196BF20", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x3015840", Offset = "0x3014840", VA = "0x183015840", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public object KCLHBOGIDMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x54BA30", Offset = "0x54AA30", VA = "0x18054BA30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x6673A0", Offset = "0x6663A0", VA = "0x1806673A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool BMDMEDCFHOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x3015890", Offset = "0x3014890", VA = "0x183015890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x30159E0", Offset = "0x30149E0", VA = "0x1830159E0")]
	public bool FOPPAMGFOBA(T PLIDGBGAHIA, object NPCBGOCOLAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x3017980", Offset = "0x3016980", VA = "0x183017980")]
	public bool PKHNGEBGEIH(object NPCBGOCOLAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x3015860", Offset = "0x3014860", VA = "0x183015860")]
	public void EMKEODJBGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x3017830", Offset = "0x3016830", VA = "0x183017830")]
	public bool PFJCFGHJDPO(object NPCBGOCOLAF, out T PLIDGBGAHIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x3016CC0", Offset = "0x3015CC0", VA = "0x183016CC0")]
	private bool GLBKEIHNPGP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x30179E0", Offset = "0x30169E0", VA = "0x1830179E0")]
	public DOOFLABBMLE()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class EMILBIDIJON
{
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private static byte[] MHCBODEMNDA;

	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private static int DAIOMNBGJFA;

	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private static int DDGCDEKJNBF;

	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private static BigInteger CONMBDBFJHL;

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
	public EMILBIDIJON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x4B79350", Offset = "0x4B78350", VA = "0x184B79350")]
	private static string PDOGHHMIGDK(byte[] EJCAMPCKMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x4B79020", Offset = "0x4B78020", VA = "0x184B79020")]
	public static string KPIGCAGDHMH(byte[] BGILCKNBLBG, bool LCPNKOKDLIC)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000094")]
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
