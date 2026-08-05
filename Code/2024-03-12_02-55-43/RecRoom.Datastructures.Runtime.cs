using System;
using System.Buffers;
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
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class DBDDIPKBHPL : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7CB100", Offset = "0x7CA300", VA = "0x1807CB100")]
	public DBDDIPKBHPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, LOBFDGDAGEI, BGMLKOFKILJ, ISerializationCallbackReceiver
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[SerializeField]
	private byte[] stableHash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	private byte[] seed;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public byte[] StableHash
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7BA410", Offset = "0x7B9610", VA = "0x1807BA410", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7BA390", Offset = "0x7B9590", VA = "0x1807BA390", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3E0", Offset = "0x7B95E0", VA = "0x1807BA3E0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x87D8F0", Offset = "0x87CAF0", VA = "0x18087D8F0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash LAPGBHDGOAB);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8A6AB0", Offset = "0x8A5CB0", VA = "0x1808A6AB0")]
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
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[SerializeField]
	[DKJIPEIIGKO]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[HideInInspector]
	[SerializeField]
	[DKJIPEIIGKO]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6126E10", Offset = "0x6126010", VA = "0x186126E10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6126DD0", Offset = "0x6125FD0", VA = "0x186126DD0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6126E50", Offset = "0x6126050", VA = "0x186126E50")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6127000", Offset = "0x6126200", VA = "0x186127000")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6126F70", Offset = "0x6126170", VA = "0x186126F70")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x943DF0", Offset = "0x942FF0", VA = "0x180943DF0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9FB1A0", Offset = "0x9FA3A0", VA = "0x1809FB1A0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6126D90", Offset = "0x6125F90", VA = "0x186126D90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6126EE0", Offset = "0x61260E0", VA = "0x186126EE0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6126800", Offset = "0x6125A00", VA = "0x186126800")]
	public void CopyBounds(SavedExtents NFMPGFPPFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6126CE0", Offset = "0x6125EE0", VA = "0x186126CE0")]
	public void SetLocalSpaceBounds(Bounds NIOKCNCJAHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0xA18210", Offset = "0xA17410", VA = "0x180A18210")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6126CD0", Offset = "0x6125ED0", VA = "0x186126CD0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6126830", Offset = "0x6125A30", VA = "0x186126830")]
	private void EKLIPOPAFKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6126AB0", Offset = "0x6125CB0", VA = "0x186126AB0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6126190", Offset = "0x6125390", VA = "0x186126190")]
	public static void CalculateLocalBoundsFor(GameObject JLBELLDLMIF, [Out] Bounds NIOKCNCJAHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x61269F0", Offset = "0x6125BF0", VA = "0x1861269F0")]
	private static void NONIDOKPJOI(Bounds LPGCLIAKDPH, Color IKNBBOHGFEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6126D00", Offset = "0x6125F00", VA = "0x186126D00")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7BA180", Offset = "0x7B9380", VA = "0x1807BA180")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7BF590", Offset = "0x7BE790", VA = "0x1807BF590")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xE55AA0", Offset = "0xE54CA0", VA = "0x180E55AA0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x43243F0", Offset = "0x43235F0", VA = "0x1843243F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "4")]
	public virtual void DKLHPBLAEHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[DBDDIPKBHPL]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4323FD0", Offset = "0x43231D0", VA = "0x184323FD0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4322C70", Offset = "0x4321E70", VA = "0x184322C70", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4324320", Offset = "0x4323520", VA = "0x184324320")]
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
	private sealed class PGJEEJGBKOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public PGJEEJGBKOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4133160", Offset = "0x4132360", VA = "0x184133160")]
		internal int CAALCLLBLGM(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[DBDDIPKBHPL]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x32E3E70", Offset = "0x32E3070", VA = "0x1832E3E70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x32E3EC0", Offset = "0x32E30C0", VA = "0x1832E3EC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x32E3D70", Offset = "0x32E2F70", VA = "0x1832E3D70", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey HKNPGHOCJDO]
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x32E3E10", Offset = "0x32E3010", VA = "0x1832E3E10", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x32E3C50", Offset = "0x32E2E50", VA = "0x1832E3C50", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x32E3970", Offset = "0x32E2B70", VA = "0x1832E3970", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x32E2E10", Offset = "0x32E2010", VA = "0x1832E2E10", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x32E2D80", Offset = "0x32E1F80", VA = "0x1832E2D80", Slot = "14")]
	protected virtual string NFLAFAMKDGC(TKeyVal GBAHFGJIMKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x32E2C90", Offset = "0x32E1E90", VA = "0x1832E2C90", Slot = "4")]
	public bool ContainsKey(TKey HKNPGHOCJDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x32E3B10", Offset = "0x32E2D10", VA = "0x1832E3B10", Slot = "5")]
	public bool TryGetValue(TKey HKNPGHOCJDO, [Out] TVal AFCGKMGKPEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x32E2CE0", Offset = "0x32E1EE0", VA = "0x1832E2CE0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x32E2CE0", Offset = "0x32E1EE0", VA = "0x1832E2CE0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x32E3B60", Offset = "0x32E2D60", VA = "0x1832E3B60")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class MBLDEMNMNII<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private class IBNAMJMJANI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public float PEABCLJKFHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public T FMINBKHGIKA;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public IBNAMJMJANI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class OMNMIEFAGBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public OMNMIEFAGBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4085630", Offset = "0x4084830", VA = "0x184085630")]
		internal bool HEFGDBKHOJE(IBNAMJMJANI sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float DFCLDKALEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float HBEDKPJJKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<IBNAMJMJANI> KNCEIEMHJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private HFGIPALFGBN<IBNAMJMJANI> GBBKLCDAJDI;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int KAAEJMLDFDN
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3E68200", Offset = "0x3E67400", VA = "0x183E68200")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3E68270", Offset = "0x3E67470", VA = "0x183E68270")]
	public MBLDEMNMNII(float JHIFPMFGHLJ, float GBELENMFBFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3E67CB0", Offset = "0x3E66EB0", VA = "0x183E67CB0")]
	public bool CCBJBODFPBE(float PODEEFCDAGD, T AFCGKMGKPEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3E67650", Offset = "0x3E66850", VA = "0x183E67650")]
	public IEnumerable<T> AIEBMEIMFBM(float PODEEFCDAGD, [Optional] float? BIJGCDJKHAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3E67FC0", Offset = "0x3E671C0", VA = "0x183E67FC0")]
	public void IICCKONGNNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3E68030", Offset = "0x3E67230", VA = "0x183E68030")]
	private void KGKENNBOINH(float PODEEFCDAGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class DKMABEIDKFI<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct HOENBFCPNAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public T FMINBKHGIKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public float AFJOLBGNGAO;
	}

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static float LCLNHAKEGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private List<T> DANNNEHFMLB;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private const int LJNBJIGMAEB = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private HOENBFCPNAK[] NPPGGGEFJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private int BCPIELHIPKD;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float EEKCMFKDMAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x852AB0", Offset = "0x851CB0", VA = "0x180852AB0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x87A9B0", Offset = "0x879BB0", VA = "0x18087A9B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5080150", Offset = "0x507F350", VA = "0x185080150")]
	public DKMABEIDKFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5080170", Offset = "0x507F370", VA = "0x185080170")]
	public DKMABEIDKFI(int DKMFLNHKFDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x507FDA0", Offset = "0x507EFA0", VA = "0x18507FDA0")]
	public void OJOKKDMOJFN(float PODEEFCDAGD, T AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x507FAB0", Offset = "0x507ECB0", VA = "0x18507FAB0")]
	public void IICCKONGNNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x507F880", Offset = "0x507EA80", VA = "0x18507F880")]
	public bool BKDHEEAEIMI(float IGNKFFHMACN, float ANKPNFAOBLI, [Out] T AFCGKMGKPEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x507F270", Offset = "0x507E470", VA = "0x18507F270")]
	public bool AMIAKMHNDOM(float IGNKFFHMACN, float ANKPNFAOBLI, [Out] T AFCGKMGKPEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x507FFB0", Offset = "0x507F1B0", VA = "0x18507FFB0")]
	public void PEMPADFHPEB(float IGNKFFHMACN, float ANKPNFAOBLI, List<T> JCGIBGELCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x507FA80", Offset = "0x507EC80", VA = "0x18507FA80")]
	private int DFMMMDEMEPL(int MMPIGIKIIOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x507FC90", Offset = "0x507EE90", VA = "0x18507FC90")]
	private void JOEIBPCNMDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T BBPIOLJEPEL();

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T NGBMLCGBOBK(T AFCGKMGKPEF, float LFCIAEJOMBP);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T BGJHPDIBNPH(T KGLNCFAJNGP, T KINCGEJJBNA);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T APNJLOBNMJN(T KGLNCFAJNGP, T KINCGEJJBNA);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class MJOGJDBKGEA : DKMABEIDKFI<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7CB990", Offset = "0x7CAB90", VA = "0x1807CB990", Slot = "4")]
	protected override Vector3 BBPIOLJEPEL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6125450", Offset = "0x6124650", VA = "0x186125450", Slot = "5")]
	protected override Vector3 NGBMLCGBOBK(Vector3 AFCGKMGKPEF, float LFCIAEJOMBP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6125400", Offset = "0x6124600", VA = "0x186125400", Slot = "6")]
	protected override Vector3 BGJHPDIBNPH(Vector3 KGLNCFAJNGP, Vector3 KINCGEJJBNA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6125380", Offset = "0x6124580", VA = "0x186125380", Slot = "7")]
	protected override Vector3 APNJLOBNMJN(Vector3 KGLNCFAJNGP, Vector3 KINCGEJJBNA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6125490", Offset = "0x6124690", VA = "0x186125490")]
	public MJOGJDBKGEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class NEJFDNHPGML
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x28A6420", Offset = "0x28A5620", VA = "0x1828A6420")]
	public static JJIELGLIIAE<T1, T2> NAIBINGPDAH<T1, T2>(T1 JLPGGAOJKGA, T2 EJPFENCNIMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x28A64A0", Offset = "0x28A56A0", VA = "0x1828A64A0")]
	public static EHKGDKMBDBI<T1, T2, T3> NAIBINGPDAH<T1, T2, T3>(T1 JLPGGAOJKGA, T2 EJPFENCNIMI, T3 LAKNPLEBKFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3ECCDE0", Offset = "0x3ECBFE0", VA = "0x183ECCDE0")]
	internal static int EKEHIDDDLDL(int EMJHLIDBCIE, int INNGKAEBBDG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x554C6A0", Offset = "0x554B8A0", VA = "0x18554C6A0")]
	internal static int EKEHIDDDLDL(int EMJHLIDBCIE, int INNGKAEBBDG, int FPGFAKPGEPB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class JJIELGLIIAE<T1, T2> : IComparable<JJIELGLIIAE<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T1 BIFHJAGBNML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly T2 ICPAMBBGANJ;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3AB1980", Offset = "0x3AB0B80", VA = "0x183AB1980")]
	public JJIELGLIIAE(T1 JLPGGAOJKGA, T2 EJPFENCNIMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3AB0190", Offset = "0x3AAF390", VA = "0x183AB0190", Slot = "4")]
	public int CompareTo(JJIELGLIIAE<T1, T2> NFMPGFPPFKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3AB05B0", Offset = "0x3AAF7B0", VA = "0x183AB05B0", Slot = "0")]
	public override bool Equals(object NFMPGFPPFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3AB0FC0", Offset = "0x3AB01C0", VA = "0x183AB0FC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3AB1530", Offset = "0x3AB0730", VA = "0x183AB1530", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class EHKGDKMBDBI<T1, T2, T3> : IComparable<EHKGDKMBDBI<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly T1 BIFHJAGBNML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly T2 ICPAMBBGANJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly T3 CMKDFCDBFON;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x32B76E0", Offset = "0x32B68E0", VA = "0x1832B76E0")]
	public EHKGDKMBDBI(T1 JLPGGAOJKGA, T2 EJPFENCNIMI, T3 LAKNPLEBKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x32B6DA0", Offset = "0x32B5FA0", VA = "0x1832B6DA0", Slot = "4")]
	public int CompareTo(EHKGDKMBDBI<T1, T2, T3> NFMPGFPPFKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x32B7020", Offset = "0x32B6220", VA = "0x1832B7020", Slot = "0")]
	public override bool Equals(object NFMPGFPPFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x32B72E0", Offset = "0x32B64E0", VA = "0x1832B72E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x32B7520", Offset = "0x32B6720", VA = "0x1832B7520", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T FMINBKHGIKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x20F8A50", Offset = "0x20F7C50", VA = "0x1820F8A50")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x20F89B0", Offset = "0x20F7BB0", VA = "0x1820F89B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float DKJCPGEMLDG
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8BEFA0", Offset = "0x8BE1A0", VA = "0x1808BEFA0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4514A00", Offset = "0x4513C00", VA = "0x184514A00")]
	public T MIBCPBPNLAN(float LFCIAEJOMBP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4514E40", Offset = "0x4514040", VA = "0x184514E40")]
	public T PPHCADNIONO(float LFCIAEJOMBP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T MEOLDKJDJGJ(T KGLNCFAJNGP, T KINCGEJJBNA, float LFCIAEJOMBP);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6123040", Offset = "0x6122240", VA = "0x186123040", Slot = "4")]
	protected override float MEOLDKJDJGJ(float KGLNCFAJNGP, float KINCGEJJBNA, float LFCIAEJOMBP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6123080", Offset = "0x6122280", VA = "0x186123080")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xCFF610", Offset = "0xCFE810", VA = "0x180CFF610", Slot = "4")]
	protected override Vector3 MEOLDKJDJGJ(Vector3 KGLNCFAJNGP, Vector3 KINCGEJJBNA, float LFCIAEJOMBP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6127D10", Offset = "0x6126F10", VA = "0x186127D10")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6122F40", Offset = "0x6122140", VA = "0x186122F40", Slot = "4")]
	protected override Color MEOLDKJDJGJ(Color KGLNCFAJNGP, Color KINCGEJJBNA, float LFCIAEJOMBP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6123000", Offset = "0x6122200", VA = "0x186123000")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class OOENIDHABMG : JCCPOOOMBGP<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6125560", Offset = "0x6124760", VA = "0x186125560")]
	public OOENIDHABMG(int EOPCNNFHDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x61254F0", Offset = "0x61246F0", VA = "0x1861254F0", Slot = "6")]
	protected override uint CEHCJAKHMGC(uint LAPGBHDGOAB, string AFCGKMGKPEF)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class CHPDKDEKKGF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly IDisposable MJANIPKLNPJ;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public CHPDKDEKKGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct HFHIBLIOGDF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> PFFGNGCENCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int JFCPODGOIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int EKBKHHFEEFI;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x37C7B60", Offset = "0x37C6D60", VA = "0x1837C7B60")]
	private HFHIBLIOGDF(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> EJCBKPHENEE, int NBDBDGCDFNN, int APOANJNPLOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x37C60E0", Offset = "0x37C52E0", VA = "0x1837C60E0")]
	public static HFHIBLIOGDF<T> GOMGEEBODDD()
	{
		return default(HFHIBLIOGDF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x37C74A0", Offset = "0x37C66A0", VA = "0x1837C74A0")]
	public (int, int, Task<T>) OOKMFKHICHD(int GMBNCAOLOEM, [Optional] CancellationToken OBNOJDAGGOE, double NCFLLHLBEIG = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x37C6530", Offset = "0x37C5730", VA = "0x1837C6530")]
	public void NAMFJKCBCPE(int GMBNCAOLOEM, int APOANJNPLOP, [In] T JKJJELABMHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class HCOGCINFNDE
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6124260", Offset = "0x6123460", VA = "0x186124260")]
	public static HFHIBLIOGDF<PGENBOHGKNI> GOMGEEBODDD()
	{
		return default(HFHIBLIOGDF<PGENBOHGKNI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x61242B0", Offset = "0x61234B0", VA = "0x1861242B0")]
	public static void NAMFJKCBCPE([In] this HFHIBLIOGDF<PGENBOHGKNI> KPBGCHDNDLM, int GMBNCAOLOEM, int APOANJNPLOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DefaultMember("Item")]
public class IONEGOBNOLE<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly Dictionary<TKey, TVal> OGDNDEHNCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly Dictionary<TVal, TKey> KBMLGKICPEA;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int MNPNLHNEGFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x30E4440", Offset = "0x30E3640", VA = "0x1830E4440", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool FPDKMGECOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802CA0", VA = "0x180803AA0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ICollection<TKey> CLBKIHGHECL
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x32C8A40", Offset = "0x32C7C40", VA = "0x1832C8A40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ICollection<TVal> ECMNIOOBHPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x38C96D0", Offset = "0x38C88D0", VA = "0x1838C96D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TVal ECAKAEFHALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x38C9620", Offset = "0x38C8820", VA = "0x1838C9620", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x38C9730", Offset = "0x38C8930", VA = "0x1838C9730", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey ECAKAEFHALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x38C8CD0", Offset = "0x38C7ED0", VA = "0x1838C8CD0")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x38C89F0", Offset = "0x38C7BF0", VA = "0x1838C89F0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x38C94A0", Offset = "0x38C86A0", VA = "0x1838C94A0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x38C8980", Offset = "0x38C7B80", VA = "0x1838C8980", Slot = "9")]
	public void Add(TKey HKNPGHOCJDO, TVal AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x38C8950", Offset = "0x38C7B50", VA = "0x1838C8950", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> BCCLIJMKECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x38C8A50", Offset = "0x38C7C50", VA = "0x1838C8A50", Slot = "8")]
	public bool ContainsKey(TKey HKNPGHOCJDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x38C8AC0", Offset = "0x38C7CC0", VA = "0x1838C8AC0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> BCCLIJMKECF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x38C9370", Offset = "0x38C8570", VA = "0x1838C9370", Slot = "10")]
	public bool Remove(TKey HKNPGHOCJDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x38C93D0", Offset = "0x38C85D0", VA = "0x1838C93D0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> BCCLIJMKECF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x38C94F0", Offset = "0x38C86F0", VA = "0x1838C94F0", Slot = "11")]
	public bool TryGetValue(TKey HKNPGHOCJDO, [Out] TVal AFCGKMGKPEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x38C8BA0", Offset = "0x38C7DA0", VA = "0x1838C8BA0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x38C8B20", Offset = "0x38C7D20", VA = "0x1838C8B20", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] NPPGGGEFJIJ, int CEJCILDFGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x38C8890", Offset = "0x38C7A90", VA = "0x1838C8890")]
	public bool AOAADIOEPBK(TVal HKNPGHOCJDO, [Out] TKey AFCGKMGKPEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x38C8D70", Offset = "0x38C7F70", VA = "0x1838C8D70")]
	private void JDHJPLAGION(TKey HKNPGHOCJDO, TVal PDNEJFLCFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x38C9050", Offset = "0x38C8250", VA = "0x1838C9050")]
	private void PCIAKIHPJCJ(TKey HKNPGHOCJDO, TVal PDNEJFLCFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x38C9290", Offset = "0x38C8490", VA = "0x1838C9290")]
	private bool PNBFKFGBHOJ(TKey HKNPGHOCJDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x38C9530", Offset = "0x38C8730", VA = "0x1838C9530")]
	public IONEGOBNOLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[DefaultMember("Item")]
public class MLHOPDPCPFA<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private MLHOPDPCPFA<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x332AA10", Offset = "0x3329C10", VA = "0x18332AA10", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x3333390", Offset = "0x3332590", VA = "0x183333390", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3333DF0", Offset = "0x3332FF0", VA = "0x183333DF0")]
		public Enumerator(MLHOPDPCPFA<T> JCGIBGELCJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x332FD50", Offset = "0x332EF50", VA = "0x18332FD50", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x3331B80", Offset = "0x3330D80", VA = "0x183331B80", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x332F460", Offset = "0x332E660", VA = "0x18332F460")]
		private void EDNPFCGIKEG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private T[] IPKEBFFPHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int CMAABPPFEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int IPJMIPJDJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private int LMCDLECLJKJ;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int MNPNLHNEGFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x3E81900", Offset = "0x3E80B00", VA = "0x183E81900")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T ECAKAEFHALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x3E821D0", Offset = "0x3E813D0", VA = "0x183E821D0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3E81630", Offset = "0x3E80830", VA = "0x183E81630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3E83460", Offset = "0x3E82660", VA = "0x183E83460")]
	public MLHOPDPCPFA(int EOPCNNFHDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3E82D10", Offset = "0x3E81F10", VA = "0x183E82D10")]
	public void OJOKKDMOJFN(T LFCIAEJOMBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3E82380", Offset = "0x3E81580", VA = "0x183E82380")]
	public void IICCKONGNNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3E81850", Offset = "0x3E80A50", VA = "0x183E81850")]
	public void DFOFHFLEGPB(int BNPJLEJJKIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3E82960", Offset = "0x3E81B60", VA = "0x183E82960")]
	public void JBPCBBCHPNM(T[] NPPGGGEFJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3E81FE0", Offset = "0x3E811E0", VA = "0x183E81FE0")]
	public Enumerator HPMIKEPMPON()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3E83270", Offset = "0x3E82470", VA = "0x183E83270", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3E83270", Offset = "0x3E82470", VA = "0x183E83270", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3E81E90", Offset = "0x3E81090", VA = "0x183E81E90")]
	private int HMGIOEEHMHK(int ILNNGHKJMBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3E81530", Offset = "0x3E80730", VA = "0x183E81530")]
	private int AEAGJMJIMOP(int ILNNGHKJMBD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class OPLMEKEMDOD<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Func<Internal, External> FMIPMAFFIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private IReadOnlyList<Internal> MJCNKJMKHLD;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public External ECAKAEFHALG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4095AD0", Offset = "0x4094CD0", VA = "0x184095AD0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int MNPNLHNEGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x4095A80", Offset = "0x4094C80", VA = "0x184095A80", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7C5FB0", Offset = "0x7C51B0", VA = "0x1807C5FB0")]
	public OPLMEKEMDOD(Func<Internal, External> FMIPMAFFIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4095A30", Offset = "0x4094C30", VA = "0x184095A30")]
	public OPLMEKEMDOD(IReadOnlyList<Internal> MJCNKJMKHLD, Func<Internal, External> FMIPMAFFIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x40959B0", Offset = "0x4094BB0", VA = "0x1840959B0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x368B200", Offset = "0x368A400", VA = "0x18368B200", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class CCCMPMHDDOL<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate Task<TResult> ONEGCKAILNO(TRequest BDKDFPBHDIC, CancellationToken OBNOJDAGGOE);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public enum MICPEHCMOAN
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class CEELLBFFPJK
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private const float KLAFOKHKHJF = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TimeSpan DIOGDIJMPGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int BKEMCPICGOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public MICPEHCMOAN IIMAONGHOPK;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static readonly CEELLBFFPJK NAPBCIPCGOL;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float JPNCLMKMJAB
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x49CEB20", Offset = "0x49CDD20", VA = "0x1849CEB20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TimeSpan EPDDPMLMBHM
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x7BA3A0", Offset = "0x7B95A0", VA = "0x1807BA3A0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x49CEC70", Offset = "0x49CDE70", VA = "0x1849CEC70")]
		public CEELLBFFPJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private readonly struct JDDIHOEHIKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly TRequest BDKDFPBHDIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly CancellationToken OBNOJDAGGOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly TaskCompletionSource<TResult> EMHLGGPPPMK;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x3A70360", Offset = "0x3A6F560", VA = "0x183A70360")]
		public JDDIHOEHIKO(TRequest BDKDFPBHDIC, TaskCompletionSource<TResult> EMHLGGPPPMK, CancellationToken OBNOJDAGGOE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct MPELCIPEONM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public CCCMPMHDDOL<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x3E8F120", Offset = "0x3E8E320", VA = "0x183E8F120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x3E8F8E0", Offset = "0x3E8EAE0", VA = "0x183E8F8E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct LDMNOCKDEPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public CCCMPMHDDOL<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private JDDIHOEHIKO <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x3C12110", Offset = "0x3C11310", VA = "0x183C12110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3C12C60", Offset = "0x3C11E60", VA = "0x183C12C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly CancellationTokenSource ICPOEBNOKMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly List<JDDIHOEHIKO> GMEMGOBKDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly CEELLBFFPJK PBIAPJLFDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly ONEGCKAILNO ANPAMAHGBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Task LLPFDKABKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private int LEHNKLFDDFJ;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x48E6660", Offset = "0x48E5860", VA = "0x1848E6660")]
	public CCCMPMHDDOL(ONEGCKAILNO ANPAMAHGBGE, [Optional] CEELLBFFPJK PBIAPJLFDEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x48E57B0", Offset = "0x48E49B0", VA = "0x1848E57B0")]
	public Task<TResult> HIJMKKKFOEF(TRequest BDKDFPBHDIC, CancellationToken OBNOJDAGGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x48E6210", Offset = "0x48E5410", VA = "0x1848E6210")]
	private void PGFBGMOELON(JDDIHOEHIKO PLFIGEGNBNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x48E4FB0", Offset = "0x48E41B0", VA = "0x1848E4FB0")]
	[AsyncStateMachine(typeof(CCCMPMHDDOL<, >.MPELCIPEONM))]
	private Task EMFOCHIIHCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x48E5C50", Offset = "0x48E4E50", VA = "0x1848E5C50")]
	private JDDIHOEHIKO IMDMBBLIHFO()
	{
		return default(JDDIHOEHIKO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x48E5270", Offset = "0x48E4470", VA = "0x1848E5270")]
	[AsyncStateMachine(typeof(CCCMPMHDDOL<, >.LDMNOCKDEPN))]
	private Task HGFBGMPBOAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x48E4B40", Offset = "0x48E3D40", VA = "0x1848E4B40")]
	private void EEDNBMCIACE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x48E4B00", Offset = "0x48E3D00", VA = "0x1848E4B00", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public class FFCJIBAPKFP<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly List<T> MJCNKJMKHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private HashSet<T> ALBEHGOFJHF;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int MNPNLHNEGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x30E4440", Offset = "0x30E3640", VA = "0x1830E4440", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool FPDKMGECOKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802CA0", VA = "0x180803AA0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T ECAKAEFHALG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x36178E0", Offset = "0x3616AE0", VA = "0x1836178E0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3617920", Offset = "0x3616B20", VA = "0x183617920", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3616F80", Offset = "0x3616180", VA = "0x183616F80", Slot = "11")]
	public void Add(T BCCLIJMKECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3617130", Offset = "0x3616330", VA = "0x183617130")]
	public bool EILIJHDLBEH(T BCCLIJMKECF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3617680", Offset = "0x3616880", VA = "0x183617680", Slot = "15")]
	public bool Remove(T BCCLIJMKECF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x36171F0", Offset = "0x36163F0", VA = "0x1836171F0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x36177C0", Offset = "0x36169C0", VA = "0x1836177C0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3616FA0", Offset = "0x36161A0", VA = "0x183616FA0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3617000", Offset = "0x3616200", VA = "0x183617000", Slot = "13")]
	public bool Contains(T BCCLIJMKECF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3617040", Offset = "0x3616240", VA = "0x183617040", Slot = "14")]
	public void CopyTo(T[] NPPGGGEFJIJ, int CEJCILDFGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3617280", Offset = "0x3616480", VA = "0x183617280", Slot = "6")]
	public int IndexOf(T BCCLIJMKECF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x36173B0", Offset = "0x36165B0", VA = "0x1836173B0", Slot = "7")]
	public void Insert(int ILNNGHKJMBD, T BCCLIJMKECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3617490", Offset = "0x3616690", VA = "0x183617490", Slot = "8")]
	public void RemoveAt(int ILNNGHKJMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x36177F0", Offset = "0x36169F0", VA = "0x1836177F0")]
	public FFCJIBAPKFP()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x1F652E0", Offset = "0x1F644E0", VA = "0x181F652E0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x61273A0", Offset = "0x61265A0", VA = "0x1861273A0")]
		public SerializedGuid([In] Guid OHJPHHKPEGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6127090", Offset = "0x6126290", VA = "0x186127090")]
		public static SerializedGuid AOOEDMOJELJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6127220", Offset = "0x6126420", VA = "0x186127220")]
		public static SerializedGuid IABHMEPCGFK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6127290", Offset = "0x6126490", VA = "0x186127290")]
		public bool IOBGPOINBGP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6127370", Offset = "0x6126570", VA = "0x186127370", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x61272F0", Offset = "0x61264F0", VA = "0x1861272F0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6127140", Offset = "0x6126340", VA = "0x186127140", Slot = "7")]
		public bool Equals(SerializedGuid NFMPGFPPFKH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6127180", Offset = "0x6126380", VA = "0x186127180", Slot = "0")]
		public override bool Equals(object MFLACBLODGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6127210", Offset = "0x6126410", VA = "0x186127210", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6127110", Offset = "0x6126310", VA = "0x186127110", Slot = "6")]
		public int CompareTo(SerializedGuid NFMPGFPPFKH)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class LPOKBLLNBEA : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly Type KCLENIMEEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly string FKKEKIHLBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool AEPJBDEEMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool KCGPGLKFCBC;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6124500", Offset = "0x6123700", VA = "0x186124500")]
	public LPOKBLLNBEA(Type PGEPHOGDDJJ, string FCPBBODNNAN, bool GOINMLGLGLM = false, bool EBOHHHDIMII = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class HLMFHAJGJKJ<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public readonly struct GHMIOELAAKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly long ACNOIOONNKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly long GAJGKLMNKLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public readonly int FJGAJENOIPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly int KLCBAKABMJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly bool GHFEDAOPFLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly string GEJEIHFJJJB;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3755FB0", Offset = "0x37551B0", VA = "0x183755FB0")]
		public GHMIOELAAKC(long ACNOIOONNKM, int FJGAJENOIPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3756020", Offset = "0x3755220", VA = "0x183756020")]
		public GHMIOELAAKC(long ACNOIOONNKM, long GAJGKLMNKLG, int FJGAJENOIPL, int KLCBAKABMJK, bool GHFEDAOPFLM, string GEJEIHFJJJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3755F60", Offset = "0x3755160", VA = "0x183755F60")]
		public int MBEPJJJAACN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3755E40", Offset = "0x3755040", VA = "0x183755E40")]
		public int CGDKNPEAAGO(int CKGPJPALFLD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3755F00", Offset = "0x3755100", VA = "0x183755F00")]
		public double LPOLDOKCLJN()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3755E60", Offset = "0x3755060", VA = "0x183755E60")]
		public GHMIOELAAKC HCDMKJEKFML(long GAJGKLMNKLG, int KLCBAKABMJK)
		{
			return default(GHMIOELAAKC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class PDHMENHMAFO : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct GKHPEKFFPAE<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public PDHMENHMAFO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Func<PDHMENHMAFO, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private PDHMENHMAFO <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x375B330", Offset = "0x375A530", VA = "0x18375B330", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x375B850", Offset = "0x375AA50", VA = "0x18375B850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly TKey OMEPDDHLMOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly HLMFHAJGJKJ<TKey> JLNOKHENILJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly DNCJPFEBFGD COBKBPPCGME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private List<PDHMENHMAFO> NCKADBKDHCM;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string ENFNJMLNJBO
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x412E530", Offset = "0x412D730", VA = "0x18412E530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IEnumerable<PDHMENHMAFO> OHCDJJMBAHD
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x412E6F0", Offset = "0x412D8F0", VA = "0x18412E6F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public GHMIOELAAKC EAIHLHGFGKE
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x412E730", Offset = "0x412D930", VA = "0x18412E730")]
			[CompilerGenerated]
			get
			{
				return default(GHMIOELAAKC);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x412E560", Offset = "0x412D760", VA = "0x18412E560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x412E750", Offset = "0x412D950", VA = "0x18412E750")]
		internal PDHMENHMAFO(HLMFHAJGJKJ<TKey> JLNOKHENILJ, TKey HKNPGHOCJDO, DNCJPFEBFGD COBKBPPCGME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x412E590", Offset = "0x412D790", VA = "0x18412E590")]
		public PDHMENHMAFO JLHBBJDCBAD(TKey HKNPGHOCJDO, [Optional] DNCJPFEBFGD? BAHFPPPAPJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x26B2C60", Offset = "0x26B1E60", VA = "0x1826B2C60")]
		[AsyncStateMachine(typeof(GKHPEKFFPAE<>))]
		public Task<T> FMEDJJPBNCD<T>(TKey HKNPGHOCJDO, Func<PDHMENHMAFO, Task<T>> PFGMNDNOGDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x412E330", Offset = "0x412D530", VA = "0x18412E330", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class PBPKBALCDJP : IEnumerable<(TKey, List<TKey>, GHMIOELAAKC)>, IEnumerable, IEnumerator<(TKey, List<TKey>, GHMIOELAAKC)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private (TKey key, List<TKey> path, GHMIOELAAKC timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public HLMFHAJGJKJ<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IEnumerator<(TKey key, List<TKey> path, GHMIOELAAKC timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, GHMIOELAAKC) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x1F4E0C0", Offset = "0x1F4D2C0", VA = "0x181F4E0C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, GHMIOELAAKC));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x4129F50", Offset = "0x4129150", VA = "0x184129F50", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x1F4E1B0", Offset = "0x1F4D3B0", VA = "0x181F4E1B0")]
		[DebuggerHidden]
		public PBPKBALCDJP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x32B04C0", Offset = "0x32AF6C0", VA = "0x1832B04C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x4129AA0", Offset = "0x4128CA0", VA = "0x184129AA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4129A50", Offset = "0x4128C50", VA = "0x184129A50")]
		private void EBDKPHOBLLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x4129F00", Offset = "0x4129100", VA = "0x184129F00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x4129E40", Offset = "0x4129040", VA = "0x184129E40", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, GHMIOELAAKC)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x36136F0", Offset = "0x36128F0", VA = "0x1836136F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class EHGEEMAFHGF : IEnumerable<(TKey, List<TKey>, GHMIOELAAKC)>, IEnumerable, IEnumerator<(TKey, List<TKey>, GHMIOELAAKC)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private (TKey key, List<TKey> path, GHMIOELAAKC timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private PDHMENHMAFO timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public PDHMENHMAFO <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public HLMFHAJGJKJ<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private IEnumerator<PDHMENHMAFO> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private IEnumerator<(TKey key, List<TKey> path, GHMIOELAAKC timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private (TKey, List<TKey>, GHMIOELAAKC) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x1F4E0C0", Offset = "0x1F4D2C0", VA = "0x181F4E0C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, GHMIOELAAKC));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x32B6BE0", Offset = "0x32B5DE0", VA = "0x1832B6BE0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x1F4E1B0", Offset = "0x1F4D3B0", VA = "0x181F4E1B0")]
		[DebuggerHidden]
		public EHGEEMAFHGF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x32B6C40", Offset = "0x32B5E40", VA = "0x1832B6C40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x32B62D0", Offset = "0x32B54D0", VA = "0x1832B62D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x32B6210", Offset = "0x32B5410", VA = "0x1832B6210")]
		private void EBDKPHOBLLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x32B6270", Offset = "0x32B5470", VA = "0x1832B6270")]
		private void GOIMEKOFDEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x32B6B90", Offset = "0x32B5D90", VA = "0x1832B6B90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x32B6A80", Offset = "0x32B5C80", VA = "0x1832B6A80", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, GHMIOELAAKC)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x32B6B60", Offset = "0x32B5D60", VA = "0x1832B6B60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly Action<TKey, GHMIOELAAKC, DNCJPFEBFGD> JJCDAEHMIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Action<TKey, GHMIOELAAKC, DNCJPFEBFGD> IPJGDIIMOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly Action<HLMFHAJGJKJ<TKey>, DNCJPFEBFGD> HEBNEIEKHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly DNCJPFEBFGD COBKBPPCGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly PDHMENHMAFO AHPGHAADEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private bool GMBEAIDAPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int CNAFJAODLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly Stopwatch APJMKCCCMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly int GICNPKHCKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private string KPOBHHDGCHB;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public PDHMENHMAFO LFDPFLFAIEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3C0", Offset = "0x7B95C0", VA = "0x1807BA3C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[NotNull]
	public string ENFNJMLNJBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7BDFB0", Offset = "0x7BD1B0", VA = "0x1807BDFB0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x37F9C90", Offset = "0x37F8E90", VA = "0x1837F9C90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x37F9D70", Offset = "0x37F8F70", VA = "0x1837F9D70")]
	public HLMFHAJGJKJ(TKey HKCMNDBDBCL, DNCJPFEBFGD COBKBPPCGME, [Optional] int? FJGAJENOIPL, [Optional][CanBeNull] Stopwatch APJMKCCCMAE, [Optional] Action<TKey, GHMIOELAAKC, DNCJPFEBFGD> JJCDAEHMIHK, [Optional] Action<TKey, GHMIOELAAKC, DNCJPFEBFGD> IPJGDIIMOCE, [Optional] Action<HLMFHAJGJKJ<TKey>, DNCJPFEBFGD> HEBNEIEKHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x37F9C00", Offset = "0x37F8E00", VA = "0x1837F9C00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x37F9AA0", Offset = "0x37F8CA0", VA = "0x1837F9AA0")]
	[IteratorStateMachine(typeof(HLMFHAJGJKJ<>.PBPKBALCDJP))]
	public IEnumerable<(TKey, List<TKey>, GHMIOELAAKC)> AGKDGNOOHLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x37F9B30", Offset = "0x37F8D30", VA = "0x1837F9B30")]
	[IteratorStateMachine(typeof(HLMFHAJGJKJ<>.EHGEEMAFHGF))]
	private IEnumerable<(TKey, List<TKey>, GHMIOELAAKC)> AGKDGNOOHLO(List<TKey> OICGBAMGDDJ, PDHMENHMAFO BNBPCEPEKIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x37F9CF0", Offset = "0x37F8EF0", VA = "0x1837F9CF0")]
	private (long, int) KINPMFKFKGN()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public abstract class GADGNDGMHIA<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut BJDGOKGGFEB(HLMFHAJGJKJ<TKey> JLNOKHENILJ);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	protected GADGNDGMHIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public abstract class IKODNIFEIIC<TKey> : GADGNDGMHIA<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate string GKKMDOMGEDA(TKey HKNPGHOCJDO);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x38B0DE0", Offset = "0x38AFFE0", VA = "0x1838B0DE0")]
	private static string GMPDBMBKIKF(TKey HKNPGHOCJDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x38B0D20", Offset = "0x38AFF20", VA = "0x1838B0D20", Slot = "4")]
	public override string BJDGOKGGFEB(HLMFHAJGJKJ<TKey> JLNOKHENILJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x38B0BD0", Offset = "0x38AFDD0", VA = "0x1838B0BD0")]
	public string BJDGOKGGFEB(HLMFHAJGJKJ<TKey> JLNOKHENILJ, [NotNull] GKKMDOMGEDA PDBNEELIKIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string OHMOCDCOLDN(HLMFHAJGJKJ<TKey> JLNOKHENILJ, [NotNull] GKKMDOMGEDA PDBNEELIKIH);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x32B90C0", Offset = "0x32B82C0", VA = "0x1832B90C0")]
	protected IKODNIFEIIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class BIJINLOOKFA<TKey> : GADGNDGMHIA<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate string FNAACCINMPC(TKey HKNPGHOCJDO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly string DLJOECPGGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly double KDBPMNGLKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly bool COBIAKLFMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly int KCHPMFNGLFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly ISet<string> OIGNPHGLGFL;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x47ACEA0", Offset = "0x47AC0A0", VA = "0x1847ACEA0")]
	private static string GMPDBMBKIKF(TKey HKNPGHOCJDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x47AD360", Offset = "0x47AC560", VA = "0x1847AD360")]
	public BIJINLOOKFA(string DLJOECPGGAK = "F2", double KDBPMNGLKDD = double.MaxValue, bool COBIAKLFMEA = false, int KCHPMFNGLFL = int.MaxValue, [Optional] ISet<string> OIGNPHGLGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x47AC7F0", Offset = "0x47AB9F0", VA = "0x1847AC7F0", Slot = "4")]
	public override Dictionary<string, string> BJDGOKGGFEB(HLMFHAJGJKJ<TKey> JLNOKHENILJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x47AD040", Offset = "0x47AC240", VA = "0x1847AD040")]
	private bool IMOKNFJMDGJ(string OPOCMOMBELN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x47AC8B0", Offset = "0x47ABAB0", VA = "0x1847AC8B0")]
	public Dictionary<string, string> BJDGOKGGFEB(HLMFHAJGJKJ<TKey> JLNOKHENILJ, FNAACCINMPC PDBNEELIKIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x47AD120", Offset = "0x47AC320", VA = "0x1847AD120")]
	private string PAMFMBNGLPF(StringBuilder OLEAIKNKFGC, List<TKey> MIELOCFKPAA, FNAACCINMPC PDBNEELIKIH, bool GPKGBKDBABJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x47ACEE0", Offset = "0x47AC0E0", VA = "0x1847ACEE0")]
	private static void GOBIOAAGLHD(StringBuilder NKMHODLBMGD, string KOPIENBFMMI, bool OOJCKPELHKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class HMHKPCCGLGC<TKey> : IKODNIFEIIC<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct BDGLCMOMLNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public GKKMDOMGEDA keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static HMHKPCCGLGC<TKey> MJANIPKLNPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly string[] NFGCIFKBKND;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3800BD0", Offset = "0x37FFDD0", VA = "0x183800BD0")]
	private HMHKPCCGLGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x37FFC60", Offset = "0x37FEE60", VA = "0x1837FFC60", Slot = "5")]
	protected override string OHMOCDCOLDN(HLMFHAJGJKJ<TKey> JLNOKHENILJ, GKKMDOMGEDA PDBNEELIKIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x37FFB70", Offset = "0x37FED70", VA = "0x1837FFB70")]
	[CompilerGenerated]
	internal static string ACHINAIMDNB(string CABMJADMPOB, TKey HKNPGHOCJDO, BDGLCMOMLNH P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class PKCOMKBJKJH : HLMFHAJGJKJ<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class MGAENDHODFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Action<PKCOMKBJKJH, DNCJPFEBFGD> callback;

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public MGAENDHODFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6124570", Offset = "0x6123770", VA = "0x186124570")]
		internal void FJLPMHPDJBJ(HLMFHAJGJKJ<string> timer, DNCJPFEBFGD log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6125B00", Offset = "0x6124D00", VA = "0x186125B00")]
	public PKCOMKBJKJH(DNCJPFEBFGD COBKBPPCGME, [Optional] string CLPDJOEKEOF, [Optional] int? FJGAJENOIPL, [Optional] Stopwatch APJMKCCCMAE, [Optional] Action<string, GHMIOELAAKC, DNCJPFEBFGD> JJCDAEHMIHK, [Optional] Action<string, GHMIOELAAKC, DNCJPFEBFGD> IPJGDIIMOCE, [Optional] Action<PKCOMKBJKJH, DNCJPFEBFGD> HEBNEIEKHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6125A40", Offset = "0x6124C40", VA = "0x186125A40")]
	private static Action<HLMFHAJGJKJ<string>, DNCJPFEBFGD> LLIAJKBPJIK(Action<PKCOMKBJKJH, DNCJPFEBFGD> FPMNHFJNBFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public abstract class IHGCPJPICAA
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private class BEEFLHACFKC : IHGCPJPICAA
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static IHGCPJPICAA MJANIPKLNPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x6122840", Offset = "0x6121A40", VA = "0x186122840")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override float OAFIHJHGFLO
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x1D88740", Offset = "0x1D87940", VA = "0x181D88740", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6122940", Offset = "0x6121B40", VA = "0x186122940")]
		public BEEFLHACFKC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static IHGCPJPICAA FOBMNEOADJA;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static IHGCPJPICAA NAPBCIPCGOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6124330", Offset = "0x6123530", VA = "0x186124330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public abstract float OAFIHJHGFLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	protected IHGCPJPICAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class IBPCPJEGJKH<T> : DJHNLODMDMN<T> where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public override Task<T> MILNOBPFJBH
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public override NNPPFIMPNGB<T> CKIPICALOCI
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7BA390", Offset = "0x7B9590", VA = "0x1807BA390", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x3889980", Offset = "0x3888B80", VA = "0x183889980")]
	public IBPCPJEGJKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "10")]
	protected override void PEOJPEJHHBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class OMKJBHOIGFC<T> : DJHNLODMDMN<T> where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public override Task<T> MILNOBPFJBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public override NNPPFIMPNGB<T> CKIPICALOCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7BA390", Offset = "0x7B9590", VA = "0x1807BA390", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x407DDE0", Offset = "0x407CFE0", VA = "0x18407DDE0")]
	public OMKJBHOIGFC(Exception ACDJDIDJFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "10")]
	protected override void PEOJPEJHHBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface KAICAHBHKID : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool BINBACMBECC
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface EGFEEHILLCB<T> : KAICAHBHKID, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	[NotNull]
	Task<T> MILNOBPFJBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	[NotNull]
	NNPPFIMPNGB<T> CKIPICALOCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public abstract class DJHNLODMDMN<T> : EGFEEHILLCB<T>, KAICAHBHKID, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly BMEHHGBDHJD NMJNAKIMPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private bool GMBEAIDAPEH;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool BINBACMBECC
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xA0F460", Offset = "0xA0E660", VA = "0x180A0F460", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public abstract Task<T> MILNOBPFJBH
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public abstract NNPPFIMPNGB<T> CKIPICALOCI
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x507C950", Offset = "0x507BB50", VA = "0x18507C950")]
	public DJHNLODMDMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x507C7D0", Offset = "0x507B9D0", VA = "0x18507C7D0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void PEOJPEJHHBN();
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public abstract class HEMKHKKCMAE<TTask, T> : DJHNLODMDMN<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class BOAAMLAGDJG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public BOAAMLAGDJG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x30D44C0", Offset = "0x30D36C0", VA = "0x1830D44C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x30D4A30", Offset = "0x30D3C30", VA = "0x1830D4A30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public HEMKHKKCMAE<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public BOAAMLAGDJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x47C05C0", Offset = "0x47BF7C0", VA = "0x1847C05C0")]
		[AsyncStateMachine(typeof(HEMKHKKCMAE<, >.BOAAMLAGDJG.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> CAEIHJFLNME(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly Task<T> GMIPPGJENPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	protected readonly CancellationTokenSource OHBKFBPCNAN;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public override Task<T> MILNOBPFJBH
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public override NNPPFIMPNGB<T> CKIPICALOCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7BA390", Offset = "0x7B9590", VA = "0x1807BA390", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x37C38B0", Offset = "0x37C2AB0", VA = "0x1837C38B0")]
	protected HEMKHKKCMAE(TTask GMIPPGJENPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x37C3520", Offset = "0x37C2720", VA = "0x1837C3520", Slot = "10")]
	protected override void PEOJPEJHHBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T IOFBHNLGLEK(TTask JIIAHKPEKAE);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void DGPNIHPKHIJ();
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class BGJMIHHCEID<T> : DJHNLODMDMN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly ININENKNCEG<Task<T>> BABJJCGLOBJ;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public override Task<T> MILNOBPFJBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x32A9D00", Offset = "0x32A8F00", VA = "0x1832A9D00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public override NNPPFIMPNGB<T> CKIPICALOCI
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7BA390", Offset = "0x7B9590", VA = "0x1807BA390", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x4798130", Offset = "0x4797330", VA = "0x184798130")]
	public BGJMIHHCEID(ININENKNCEG<Task<T>> INFCBNDDJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x4798110", Offset = "0x4797310", VA = "0x184798110", Slot = "10")]
	protected override void PEOJPEJHHBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class CDNOPIJDBNP
{
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6122E50", Offset = "0x6122050", VA = "0x186122E50")]
	[NotNull]
	public static byte[] MNNCIJIFDAP(this LOBFDGDAGEI LDAAPMGDNHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6122DE0", Offset = "0x6121FE0", VA = "0x186122DE0")]
	[NotNull]
	public static byte[] MNNCIJIFDAP(this LOBFDGDAGEI LDAAPMGDNHK, HashAlgorithmName NMHGIDNKMHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6122AB0", Offset = "0x6121CB0", VA = "0x186122AB0")]
	public static bool KHIHNIOMKMD([CanBeNull] this LOBFDGDAGEI LDAAPMGDNHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6122C40", Offset = "0x6121E40", VA = "0x186122C40")]
	public static bool KHIHNIOMKMD([CanBeNull] this LOBFDGDAGEI LDAAPMGDNHK, [Out] string PLLLDOCFAPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6122990", Offset = "0x6121B90", VA = "0x186122990")]
	private static bool JCONCGCLLPP([NotNull] LOBFDGDAGEI LDAAPMGDNHK, [Out][CanBeNull] byte[] EBHFMACGLGA, [Out][CanBeNull] byte[] NPNJMEFOOEO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class GMGOINKNGAI
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6124020", Offset = "0x6123220", VA = "0x186124020")]
	[NotNull]
	public static byte[] MNNCIJIFDAP(this BGMLKOFKILJ IJIGPNKNPEO, HashAlgorithmName NMHGIDNKMHJ, byte[] MIGKCKOIFNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface BGMLKOFKILJ
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash LAPGBHDGOAB);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface LOBFDGDAGEI : BGMLKOFKILJ
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	[CanBeNull]
	byte[] CMPEAMHBKKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	[CanBeNull]
	byte[] CCGMOHBGHOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class MJHBIMBIBIN
{
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static readonly ArrayPool<byte> IMLBFLINMFK;

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static bool ADLJLCCCMNK;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x61247D0", Offset = "0x61239D0", VA = "0x1861247D0")]
	public static void AMBDNGKKMCB(this IncrementalHash JFFMNNOFDDN, [CanBeNull] GameObject JLBELLDLMIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x2851A50", Offset = "0x2850C50", VA = "0x182851A50")]
	public static void AMBDNGKKMCB<T>(this IncrementalHash JFFMNNOFDDN, [CanBeNull] T OLMPJIPAILL) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x28519C0", Offset = "0x2850BC0", VA = "0x1828519C0")]
	public static void AJGMIJKBAJH<T>(this IncrementalHash JFFMNNOFDDN, [CanBeNull] T IJIGPNKNPEO) where T : BGMLKOFKILJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x2852140", Offset = "0x2851340", VA = "0x182852140")]
	public static void LIBNIIPKFCK<T>(this IncrementalHash JFFMNNOFDDN, [CanBeNull] IList<T> ADMOJDDHDPO) where T : BGMLKOFKILJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x61250C0", Offset = "0x61242C0", VA = "0x1861250C0")]
	private static bool MGKKFJBHNAM([CanBeNull] BGMLKOFKILJ IJIGPNKNPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x61251B0", Offset = "0x61243B0", VA = "0x1861251B0")]
	public static void NGACHMBLNON(this IncrementalHash LAPGBHDGOAB, [CanBeNull] string NGEAHCFNCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6124600", Offset = "0x6123800", VA = "0x186124600")]
	public static void AFEHEPLFPBH(this IncrementalHash LAPGBHDGOAB, long JIGGEFPGEDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6124A80", Offset = "0x6123C80", VA = "0x186124A80")]
	public static void EDDJBMHDGFJ(this IncrementalHash LAPGBHDGOAB, int GLFJGBPNBFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x61248B0", Offset = "0x6123AB0", VA = "0x1861248B0")]
	public static void BLHGCNCHKCD(this IncrementalHash LAPGBHDGOAB, short BOGAAJHJHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6124DC0", Offset = "0x6123FC0", VA = "0x186124DC0")]
	public static void ICJOLKNIAGK(this IncrementalHash LAPGBHDGOAB, byte HBPKEHLPGKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6124C50", Offset = "0x6123E50", VA = "0x186124C50")]
	public static void EKKMJMBPJCF(this IncrementalHash LAPGBHDGOAB, bool OELOCCHHGNE, bool FJNKGJEBPIP = false, bool FLEPCBGDPGI = false, bool GOMKKKLACKP = false, bool JOMANOEOOEB = false, bool BEMEEHFCAIN = false, bool FFODDGNJGLD = false, bool GMMAGJPDHHE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2851B10", Offset = "0x2850D10", VA = "0x182851B10")]
	public static void CIHGMDLIOHL<T>(this IncrementalHash LAPGBHDGOAB, T INAFIMGOJNH) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6125210", Offset = "0x6124410", VA = "0x186125210")]
	public static void PJNFMBPCNJK(this IncrementalHash LAPGBHDGOAB, float AMNCDNBGJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6125060", Offset = "0x6124260", VA = "0x186125060")]
	public static void LDDBHBFBIBK(this IncrementalHash LAPGBHDGOAB, ulong LBNEKBIBPEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6125150", Offset = "0x6124350", VA = "0x186125150")]
	public static void NAPDJBPDEJL(this IncrementalHash LAPGBHDGOAB, uint CBLAELHPFOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6124ED0", Offset = "0x61240D0", VA = "0x186124ED0")]
	public static void JBJKFFJAFEO(this IncrementalHash LAPGBHDGOAB, ushort OBLPBIPHBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6124F30", Offset = "0x6124130", VA = "0x186124F30")]
	public static void JNLGABJIJCI(this IncrementalHash LAPGBHDGOAB, Vector3 HACFEMFDPEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class KBBKKAMMDCO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x61244A0", Offset = "0x61236A0", VA = "0x1861244A0")]
	public KBBKKAMMDCO(string LFMFEFFGFLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public abstract class NDHDDJDKIJO<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	internal class LBIMIPLPFMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public TNode KPBGCHDNDLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public TNode DMKJLMNBOME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public LFHCPDLODAI JLPGFNMEAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public List<LFHCPDLODAI> FMIKNMBLOCM;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public LBIMIPLPFMC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	internal struct LFHCPDLODAI : IComparable<LFHCPDLODAI>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public int CKCDOFHAFKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public TClaimant GGDAJHHPJHN;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xC3DDB0", Offset = "0xC3CFB0", VA = "0x180C3DDB0")]
		public LFHCPDLODAI(int CKCDOFHAFKI, TClaimant GGDAJHHPJHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3C1A5C0", Offset = "0x3C197C0", VA = "0x183C1A5C0")]
		public bool AKGAPHHKMNI([In] LFHCPDLODAI NFMPGFPPFKH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3C1A630", Offset = "0x3C19830", VA = "0x183C1A630")]
		public bool IFEEJHCECAI([In] LFHCPDLODAI NFMPGFPPFKH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3C1A620", Offset = "0x3C19820", VA = "0x183C1A620", Slot = "4")]
		public int CompareTo(LFHCPDLODAI NFMPGFPPFKH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3C1A640", Offset = "0x3C19840", VA = "0x183C1A640", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public enum JBLIDNCOHEP
	{
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class PGBPKHDAKHJ : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public NDHDDJDKIJO<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x807710", Offset = "0x806910", VA = "0x180807710")]
		[DebuggerHidden]
		public PGBPKHDAKHJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x4131580", Offset = "0x4130780", VA = "0x184131580", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x4131740", Offset = "0x4130940", VA = "0x184131740", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x4131660", Offset = "0x4130860", VA = "0x184131660", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x32B0440", Offset = "0x32AF640", VA = "0x1832B0440", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static readonly HFGIPALFGBN<LBIMIPLPFMC> EIOKHCGBKID;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static readonly HFGIPALFGBN<List<LFHCPDLODAI>> CFCCBIGJAPN;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static int EECAMICDCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	internal readonly Dictionary<TClaimant, TNode> GLOIPIIMEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	internal readonly Dictionary<TNode, LBIMIPLPFMC> NFECNHBONEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private JBLIDNCOHEP GCDFEPGDJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private bool OLAHAMNIKKD;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode LDGPHMCLLEE(TNode DEBAEMIFHOC);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void LLENAOIOKBJ(TNode DEBAEMIFHOC, TClaimant MEOALDJJAKP, TClaimant OFKHOPDAAEJ);

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x3F14000", Offset = "0x3F13200", VA = "0x183F14000")]
	public NDHDDJDKIJO(JBLIDNCOHEP GCDFEPGDJKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x3F12DF0", Offset = "0x3F11FF0", VA = "0x183F12DF0")]
	public void DJJOFGCHLPP(TNode DEBAEMIFHOC, TNode IKEECPHGAFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3F13420", Offset = "0x3F12620", VA = "0x183F13420")]
	public void IKNMEKIHCPP(TClaimant GGDAJHHPJHN, TNode OIBIEGGLIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3F12E80", Offset = "0x3F12080", VA = "0x183F12E80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3F13630", Offset = "0x3F12830", VA = "0x183F13630")]
	private void JILONPJCGDP(TClaimant GGDAJHHPJHN, TNode NCFEALOLKKJ, TNode OIBIEGGLIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3F13050", Offset = "0x3F12250", VA = "0x183F13050")]
	private int EOKCHABMJIO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3F136D0", Offset = "0x3F128D0", VA = "0x183F136D0")]
	private void KLIDKKPCGBD(TClaimant GGDAJHHPJHN, TNode OBLCNACCFDN, TNode NHNMJIDCFEF, int FDOFJIGKJPA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3F12C30", Offset = "0x3F11E30", VA = "0x183F12C30")]
	private void BJCMPAGNILL(LFHCPDLODAI JHJDLPFPGHG, LBIMIPLPFMC MEADHOGLMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3F12950", Offset = "0x3F11B50", VA = "0x183F12950")]
	private void AOONHLEINDD(TClaimant GGDAJHHPJHN, TNode OBLCNACCFDN, TNode NHNMJIDCFEF, int FDOFJIGKJPA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3F130C0", Offset = "0x3F122C0", VA = "0x183F130C0")]
	private void FLMPMKGLJKO(LFHCPDLODAI JHJDLPFPGHG, TNode DEBAEMIFHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3F13A10", Offset = "0x3F12C10", VA = "0x183F13A10")]
	private void OMENAPKIOFM(LFHCPDLODAI JHJDLPFPGHG, LBIMIPLPFMC MEADHOGLMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3F12CC0", Offset = "0x3F11EC0", VA = "0x183F12CC0")]
	private void CHAFOBLEDNK(LBIMIPLPFMC MEADHOGLMCH, bool CMGBCGENICK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3F13B00", Offset = "0x3F12D00", VA = "0x183F13B00")]
	private void PIOKDEIPIDI(LBIMIPLPFMC MEADHOGLMCH, TNode IKEECPHGAFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x3F13340", Offset = "0x3F12540", VA = "0x183F13340")]
	[IteratorStateMachine(typeof(NDHDDJDKIJO<, >.PGBPKHDAKHJ))]
	private IEnumerable<TNode> HDOBFJMPIIO(TNode OBLCNACCFDN, TNode NHNMJIDCFEF, bool IHCOEJHFLNM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x3F13540", Offset = "0x3F12740", VA = "0x183F13540")]
	private LBIMIPLPFMC ILMIJLJFAPJ(TNode DEBAEMIFHOC, TNode DMKJLMNBOME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3F127E0", Offset = "0x3F119E0", VA = "0x183F127E0")]
	private LBIMIPLPFMC AJAFMENCNJK(TNode DEBAEMIFHOC, TNode DMKJLMNBOME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x3F131D0", Offset = "0x3F123D0", VA = "0x183F131D0")]
	private void GANNPLDLMFO(LBIMIPLPFMC MEADHOGLMCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class JCCPOOOMBGP<T> : IEnumerable<JCCPOOOMBGP<T>.AFCMDPAFFIC>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct AFCMDPAFFIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public T AFCGKMGKPEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int ILNNGHKJMBD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class OAPHCKBPLGF : IEnumerator<AFCMDPAFFIC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private JCCPOOOMBGP<T> OPPKABJJMNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private int ILNNGHKJMBD;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x32E46E0", Offset = "0x32E38E0", VA = "0x1832E46E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public AFCMDPAFFIC DNINAAJGKKI
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x403EEF0", Offset = "0x403E0F0", VA = "0x18403EEF0", Slot = "4")]
			get
			{
				return default(AFCMDPAFFIC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x403EE00", Offset = "0x403E000", VA = "0x18403EE00")]
		public OAPHCKBPLGF(JCCPOOOMBGP<T> OPPKABJJMNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x403ED80", Offset = "0x403DF80", VA = "0x18403ED80", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3335A20", Offset = "0x3334C20", VA = "0x183335A20", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x879C20", Offset = "0x878E20", VA = "0x180879C20", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private struct NPJFGKOKCPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public bool EENEJMMMMAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public T AFCGKMGKPEF;
	}

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int EIPFJDEOJBE = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly Dictionary<T, int> FGNANOEEBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private NPJFGKOKCPA[] LBOJIBBOFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int HMPGOCFFJNO;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int MDDEBLHBALJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7FA4E0", Offset = "0x7F96E0", VA = "0x1807FA4E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7F9AE0", Offset = "0x7F8CE0", VA = "0x1807F9AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int MNPNLHNEGFK
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x30E4440", Offset = "0x30E3640", VA = "0x1830E4440")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x3A68B00", Offset = "0x3A67D00", VA = "0x183A68B00")]
	public JCCPOOOMBGP(int EOPCNNFHDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x3A68FB0", Offset = "0x3A681B0", VA = "0x183A68FB0")]
	public JCCPOOOMBGP(AFCMDPAFFIC[] BKIENEBFFGL, bool BDIKKMDMGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3A68930", Offset = "0x3A67B30", VA = "0x183A68930")]
	public int NNEMGAMPGEM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3A684B0", Offset = "0x3A676B0", VA = "0x183A684B0")]
	private int NFMOEPDNNCD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x3A67DD0", Offset = "0x3A66FD0", VA = "0x183A67DD0", Slot = "6")]
	protected virtual uint CEHCJAKHMGC(uint LAPGBHDGOAB, T AFCGKMGKPEF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x3A68460", Offset = "0x3A67660", VA = "0x183A68460")]
	public bool EOECAFNHCJE(T AFCGKMGKPEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x3A67E90", Offset = "0x3A67090", VA = "0x183A67E90")]
	public int DPNOEICBLGE(T AFCGKMGKPEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x3A68A10", Offset = "0x3A67C10", VA = "0x183A68A10")]
	public T POCHEIMJHNI(int ILNNGHKJMBD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x3A68110", Offset = "0x3A67310", VA = "0x183A68110")]
	public bool EILIJHDLBEH(T AFCGKMGKPEF, bool HEAMIEAEJPA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x3A67F00", Offset = "0x3A67100", VA = "0x183A67F00")]
	public bool EILIJHDLBEH(T AFCGKMGKPEF, int ILNNGHKJMBD, bool HEAMIEAEJPA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x3A68890", Offset = "0x3A67A90", VA = "0x183A68890")]
	private int NGOAJBDBJPB(int CMAABPPFEEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x3A68A80", Offset = "0x3A67C80", VA = "0x183A68A80", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x3A68A80", Offset = "0x3A67C80", VA = "0x183A68A80", Slot = "4")]
	private IEnumerator<AFCMDPAFFIC> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class HFGIPALFGBN<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly Stack<T> CEFHCAAIKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private readonly List<T> FJDLLKLMBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly int KPFAOGJBODA;

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x37C5A20", Offset = "0x37C4C20", VA = "0x1837C5A20")]
	public static HFGIPALFGBN<T> HHONBLIMEDF(int EOPCNNFHDCM = 0, int KPFAOGJBODA = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x37C5C80", Offset = "0x37C4E80", VA = "0x1837C5C80")]
	public static HFGIPALFGBN<T> NFFBDGPJPLE(int EOPCNNFHDCM = 0, int KPFAOGJBODA = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x37C5F10", Offset = "0x37C5110", VA = "0x1837C5F10")]
	public HFGIPALFGBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x37C5F40", Offset = "0x37C5140", VA = "0x1837C5F40")]
	public HFGIPALFGBN(int EOPCNNFHDCM, int KPFAOGJBODA = int.MaxValue, bool OJANOJPJLBK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x37C5B00", Offset = "0x37C4D00", VA = "0x1837C5B00")]
	public T JGNENEJKLGJ()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x37C5E40", Offset = "0x37C5040", VA = "0x1837C5E40")]
	public void PFNABIFCBEO(T AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x37C5D60", Offset = "0x37C4F60", VA = "0x1837C5D60")]
	private void PBJBFCCOFLG(T AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x37C5A00", Offset = "0x37C4C00", VA = "0x1837C5A00")]
	private void FFPPEGLLIPI(T AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x37C58C0", Offset = "0x37C4AC0", VA = "0x1837C58C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x37C56C0", Offset = "0x37C48C0", VA = "0x1837C56C0")]
	private void BHEIOIFMLII(IEnumerable<T> OJPPDIEMMAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class IJAEJFGHKHC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private Dictionary<int, T> KIDIHHHGLCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private T BNKDEJEBJFK;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual T HKNMIGBONHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7BA410", Offset = "0x7B9610", VA = "0x1807BA410", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x38A55B0", Offset = "0x38A47B0", VA = "0x1838A55B0")]
	public bool FPPDILEGGNE(T AFCGKMGKPEF, int CKCDOFHAFKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x3726530", Offset = "0x3725730", VA = "0x183726530")]
	public bool MODILKLACII(int CKCDOFHAFKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x38A5350", Offset = "0x38A4550", VA = "0x1838A5350")]
	public T CPDNDPFOPHH(int IKIKJEAMMKH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x38A5740", Offset = "0x38A4940", VA = "0x1838A5740")]
	private bool HCOADGDFCMC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x38A5110", Offset = "0x38A4310", VA = "0x1838A5110")]
	public bool AOAADIOEPBK(int CKCDOFHAFKI, [Out] T AFCGKMGKPEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x38A57E0", Offset = "0x38A49E0", VA = "0x1838A57E0")]
	public IJAEJFGHKHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class LKEBHDHMAHD<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	protected struct PGEPDEAHMIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public T FMINBKHGIKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int OMIKBMAIBKH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	protected readonly List<PGEPDEAHMIN> IPKEBFFPHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private T LDMACILFPFE;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int MNPNLHNEGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x30E4440", Offset = "0x30E3640", VA = "0x1830E4440")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x3C9CB50", Offset = "0x3C9BD50", VA = "0x183C9CB50")]
	public bool NGGGJPKJNOI(T AFCGKMGKPEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x3C9CCD0", Offset = "0x3C9BED0", VA = "0x183C9CCD0")]
	public void OJOKKDMOJFN(T AFCGKMGKPEF, int CKCDOFHAFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x3C9CD70", Offset = "0x3C9BF70", VA = "0x183C9CD70")]
	public bool PADFOOPDKDB(T AFCGKMGKPEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x3C9C990", Offset = "0x3C9BB90", VA = "0x183C9C990")]
	public void IICCKONGNNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x3C9C910", Offset = "0x3C9BB10", VA = "0x183C9C910")]
	public T FPGMHPCDANI()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x3C9C9F0", Offset = "0x3C9BBF0", VA = "0x183C9C9F0")]
	private void KKAADJHONCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x3C9CEC0", Offset = "0x3C9C0C0", VA = "0x183C9CEC0")]
	public LKEBHDHMAHD()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[SerializeField]
		[PFGEJILCEKJ(DOGHHGCAALN.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x6125D90", Offset = "0x6124F90", VA = "0x186125D90")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x6126060", Offset = "0x6125260", VA = "0x186126060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x6125F70", Offset = "0x6125170", VA = "0x186125F70")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x6125CE0", Offset = "0x6124EE0", VA = "0x186125CE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x6125FB0", Offset = "0x61251B0", VA = "0x186125FB0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x6125EC0", Offset = "0x61250C0", VA = "0x186125EC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x6125C50", Offset = "0x6124E50", VA = "0x186125C50")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x42ED220", Offset = "0x42EC420", VA = "0x1842ED220", Slot = "4")]
		public virtual T BLNCBIDEACH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class GHCABKEMGLJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly Dictionary<byte, PEIHAEECKFA> HFHBHHCMDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly HFGIPALFGBN<PEIHAEECKFA> JIKIMJMCHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly bool NBKCBKDKFDA;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public PEIHAEECKFA JFADIMDJOOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3A0", Offset = "0x7B95A0", VA = "0x1807BA3A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7BA400", Offset = "0x7B9600", VA = "0x1807BA400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public Vector2 DDLJECNHAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xBBE500", Offset = "0xBBD700", VA = "0x180BBE500")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xE96A50", Offset = "0xE95C50", VA = "0x180E96A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private Vector2 DJPBEPGKLDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xED80B0", Offset = "0xED72B0", VA = "0x180ED80B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public Vector2 FOCMKHJPNPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x6123A20", Offset = "0x6122C20", VA = "0x186123A20")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x7C1C10", Offset = "0x7C0E10", VA = "0x1807C1C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public int AIBHKHJMMNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x7C7810", Offset = "0x7C6A10", VA = "0x1807C7810")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x7C7820", Offset = "0x7C6A20", VA = "0x1807C7820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6123B90", Offset = "0x6122D90", VA = "0x186123B90")]
	public GHCABKEMGLJ(Bounds NNBNDECIJOA, Vector2[] OFONNHMEELK, int OFBDOKIAKJJ, byte CMAABPPFEEC, float AAKJNMHABPN = 0f, [Optional] HFGIPALFGBN<PEIHAEECKFA> JIKIMJMCHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6123B30", Offset = "0x6122D30", VA = "0x186123B30")]
	public PEIHAEECKFA NNFKKHHPHAB(byte ILNNGHKJMBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x61235A0", Offset = "0x61227A0", VA = "0x1861235A0")]
	public void JAOHDGFGNEK(Vector3 HBEJPCPOKJI, float PMFODBNNJEE, float KELFKKDHNNF, List<byte> KJNBFNHOLNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x58A75D0", Offset = "0x58A67D0", VA = "0x1858A75D0")]
	public void IANIFNMGDJM(PEIHAEECKFA.MNGONOLNCNM NJDAAHFHPEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6123A40", Offset = "0x6122C40", VA = "0x186123A40")]
	public static int NANAIPLBMIB(Vector2[] OFONNHMEELK, int OFBDOKIAKJJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6123120", Offset = "0x6122320", VA = "0x186123120")]
	private PEIHAEECKFA FAOGGEEDGHC(byte ILNNGHKJMBD, PEIHAEECKFA.FMFAFNEEHNN NEAJOKAJBEK, PEIHAEECKFA DMKJLMNBOME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x6123670", Offset = "0x6122870", VA = "0x186123670")]
	private void KKMOPJKMGLN(PEIHAEECKFA DMKJLMNBOME, Vector2[] OFONNHMEELK, int IBBJEOLFAEL, int IJFGODDFAFC, int DLFKPMBFKIM, int HCHDDGNCPLO, float AAKJNMHABPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x6123380", Offset = "0x6122580", VA = "0x186123380")]
	private void IODCGMMPCAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x61230C0", Offset = "0x61222C0", VA = "0x1861230C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x6123320", Offset = "0x6122520", VA = "0x186123320", Slot = "1")]
	~GHCABKEMGLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class PEIHAEECKFA
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public enum FMFAFNEEHNN
	{
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public enum MNGONOLNCNM
	{
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public byte HKBOKMJPIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public Vector3 DBNNONHHNII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public Vector3 OMLLDMPJCFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public Vector3 GPCPAIJMICE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public Vector3 POJDMBKPMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public FMFAFNEEHNN FIHLNBFDJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public PEIHAEECKFA KDMGGCGDEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public List<PEIHAEECKFA> IHOKAAMAMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public bool OKHMEBLBCIO;

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6125A20", Offset = "0x6124C20", VA = "0x186125A20")]
	public PEIHAEECKFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x61258D0", Offset = "0x6124AD0", VA = "0x1861258D0")]
	public void LNMODEGKMKK(PEIHAEECKFA HLNBFGHFDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0")]
	public void IANIFNMGDJM(int BNEGPAIGNEM, MNGONOLNCNM NJDAAHFHPEJ, int MCJNJCHPJBC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6125640", Offset = "0x6124840", VA = "0x186125640")]
	public void JAOHDGFGNEK(List<byte> KJNBFNHOLNF, Vector3 HBEJPCPOKJI, float PMFODBNNJEE, float KELFKKDHNNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x61258A0", Offset = "0x6124AA0", VA = "0x1861258A0")]
	public bool LFOCEMCLLED(Vector3 CPPDJJKKMJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x61259F0", Offset = "0x6124BF0", VA = "0x1861259F0")]
	public bool PFLGMPLBCAC(Vector3 CPPDJJKKMJI, float CPKMEAEIGIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x61255B0", Offset = "0x61247B0", VA = "0x1861255B0")]
	public void AKCGAJHNOGB()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		public struct PJHOMLHOBMM<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private readonly List<Component> MJCNKJMKHLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private readonly bool EJABGHKJJNA;

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x38C2410", Offset = "0x38C1610", VA = "0x1838C2410")]
			public PJHOMLHOBMM(List<Component> MJCNKJMKHLD, bool EJABGHKJJNA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x4142B10", Offset = "0x4141D10", VA = "0x184142B10")]
			public PDFKMHMGBFH<T> HPMIKEPMPON()
			{
				return default(PDFKMHMGBFH<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x4142B80", Offset = "0x4141D80", VA = "0x184142B80", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x4142B80", Offset = "0x4141D80", VA = "0x184142B80", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public struct PDFKMHMGBFH<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private readonly List<Component> MJCNKJMKHLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			private readonly bool EJABGHKJJNA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			private int ILNNGHKJMBD;

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			public T DNINAAJGKKI
			{
				[Cpp2IlInjected.Token(Token = "0x60001ED")]
				[Cpp2IlInjected.Address(RVA = "0x412DC90", Offset = "0x412CE90", VA = "0x18412DC90", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001EE")]
				[Cpp2IlInjected.Address(RVA = "0x412DC20", Offset = "0x412CE20", VA = "0x18412DC20", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x412DC60", Offset = "0x412CE60", VA = "0x18412DC60")]
			public PDFKMHMGBFH(List<Component> MJCNKJMKHLD, bool EJABGHKJJNA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x412DB60", Offset = "0x412CD60", VA = "0x18412DB60", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x412DB70", Offset = "0x412CD70", VA = "0x18412DB70", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x3327C70", Offset = "0x3326E70", VA = "0x183327C70", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6127590", Offset = "0x6126790", VA = "0x186127590")]
		private void AKCGAJHNOGB(GameObject MCILOMMKPPB, bool DBMLIHEKMKO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x61273D0", Offset = "0x61265D0", VA = "0x1861273D0")]
		public static void AKCGAJHNOGB(GameObject MCILOMMKPPB, ToolHierarchyCache KKEPCNIADKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x2A34270", Offset = "0x2A33470", VA = "0x182A34270")]
		public void BGOJDOONEHA<T>(Action<T> CEBHNDLCHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x2A34550", Offset = "0x2A33750", VA = "0x182A34550")]
		public T OJCJIKLOODO<T>(bool EJABGHKJJNA = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x2A34490", Offset = "0x2A33690", VA = "0x182A34490")]
		public PJHOMLHOBMM<T> FFFPMEAIFEJ<T>(bool EJABGHKJJNA = false) where T : class
		{
			return default(PJHOMLHOBMM<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6127700", Offset = "0x6126900", VA = "0x186127700")]
		public List<Component> CEAKCDLAKJB(Type DMEGHACCPAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6127A50", Offset = "0x6126C50", VA = "0x186127A50", Slot = "4")]
		public bool Equals(ToolHierarchyCache DHOHKCEOCND, ToolHierarchyCache CKNDNFKDDJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6127AD0", Offset = "0x6126CD0", VA = "0x186127AD0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache MFLACBLODGN)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class OFJDNNOBBIG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private int EOPCNNFHDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int HHHJGIHBKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private List<T> AJFCEGGIKGG;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int MNPNLHNEGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x32A9D00", Offset = "0x32A8F00", VA = "0x1832A9D00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public T GLDIDDCPOOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x40664E0", Offset = "0x40656E0", VA = "0x1840664E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public T MJGKLFBACAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x40665A0", Offset = "0x40657A0", VA = "0x1840665A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public T PMOBNIIDKMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x4066650", Offset = "0x4065850", VA = "0x184066650")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x4066840", Offset = "0x4065A40", VA = "0x184066840")]
	public OFJDNNOBBIG(int EOPCNNFHDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x4066740", Offset = "0x4065940", VA = "0x184066740")]
	public void OJOKKDMOJFN(T FIGNLDPMKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x4066610", Offset = "0x4065810", VA = "0x184066610")]
	public void IICCKONGNNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x4066410", Offset = "0x4065610", VA = "0x184066410")]
	public void CBNOGNLNJOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x40666E0", Offset = "0x40658E0", VA = "0x1840666E0")]
	public void LPPDDLNDEMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x40666D0", Offset = "0x40658D0", VA = "0x1840666D0")]
	public void LOJOAMCKBML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class KJOCDEMGFNM<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	private struct CGGBJKAAHMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public int OMIKBMAIBKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public T FMINBKHGIKA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly Dictionary<object, CGGBJKAAHMC> KIDIHHHGLCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly EqualityComparer<T> LHDNAGJCJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private T BNKDEJEBJFK;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public virtual T HKNMIGBONHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x106E0D0", Offset = "0x106D2D0", VA = "0x18106E0D0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3B6C4F0", Offset = "0x3B6B6F0", VA = "0x183B6C4F0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool BIPHEDEEMDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3B6C610", Offset = "0x3B6B810", VA = "0x183B6C610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public object NGMDCDDKOON
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3C0", Offset = "0x7B95C0", VA = "0x1807BA3C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x7BA420", Offset = "0x7B9620", VA = "0x1807BA420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x3B69250", Offset = "0x3B68450", VA = "0x183B69250")]
	public bool FPPDILEGGNE(T AFCGKMGKPEF, object COAGHPOILPB, int CKCDOFHAFKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x3B6C580", Offset = "0x3B6B780", VA = "0x183B6C580")]
	public bool MODILKLACII(object COAGHPOILPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x3B68AC0", Offset = "0x3B67CC0", VA = "0x183B68AC0")]
	public bool AOAADIOEPBK(object COAGHPOILPB, [Out] T AFCGKMGKPEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x3B6C460", Offset = "0x3B6B660", VA = "0x183B6C460")]
	public void IICCKONGNNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x3B6C180", Offset = "0x3B6B380", VA = "0x183B6C180")]
	private bool HCOADGDFCMC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x3B6C660", Offset = "0x3B6B860", VA = "0x183B6C660")]
	public KJOCDEMGFNM()
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
