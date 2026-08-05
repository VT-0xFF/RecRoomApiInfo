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
public class HLGPKNDKBPO : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7B9100", Offset = "0x7B7F00", VA = "0x1807B9100")]
	public HLGPKNDKBPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, NMJFBANAJLP, JHGMNIJBLBK, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7A81C0", Offset = "0x7A6FC0", VA = "0x1807A81C0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7A81F0", Offset = "0x7A6FF0", VA = "0x1807A81F0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7A81D0", Offset = "0x7A6FD0", VA = "0x1807A81D0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x87F3D0", Offset = "0x87E1D0", VA = "0x18087F3D0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash JHFKHJKILDH);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x831660", Offset = "0x830460", VA = "0x180831660")]
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
	[EJKEHKNDGLC]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[HideInInspector]
	[SerializeField]
	[EJKEHKNDGLC]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5FCD710", Offset = "0x5FCC510", VA = "0x185FCD710")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5FCD6D0", Offset = "0x5FCC4D0", VA = "0x185FCD6D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5FCD750", Offset = "0x5FCC550", VA = "0x185FCD750")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5FCD900", Offset = "0x5FCC700", VA = "0x185FCD900")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5FCD870", Offset = "0x5FCC670", VA = "0x185FCD870")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8CF010", Offset = "0x8CDE10", VA = "0x1808CF010")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x94CB70", Offset = "0x94B970", VA = "0x18094CB70")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5FCD690", Offset = "0x5FCC490", VA = "0x185FCD690")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5FCD7E0", Offset = "0x5FCC5E0", VA = "0x185FCD7E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5FCD100", Offset = "0x5FCBF00", VA = "0x185FCD100")]
	public void CopyBounds(SavedExtents FPEEGIOMOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5FCD5E0", Offset = "0x5FCC3E0", VA = "0x185FCD5E0")]
	public void SetLocalSpaceBounds(Bounds CDHMKNCAPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x9A2240", Offset = "0x9A1040", VA = "0x1809A2240")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5FCD5D0", Offset = "0x5FCC3D0", VA = "0x185FCD5D0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5FCD1F0", Offset = "0x5FCBFF0", VA = "0x185FCD1F0")]
	private void NOLGICOAPKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5FCD3B0", Offset = "0x5FCC1B0", VA = "0x185FCD3B0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5FCCA90", Offset = "0x5FCB890", VA = "0x185FCCA90")]
	public static void CalculateLocalBoundsFor(GameObject IPHCMOEHILB, [Out] Bounds CDHMKNCAPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5FCD130", Offset = "0x5FCBF30", VA = "0x185FCD130")]
	private static void JDFCLDOEBLN(Bounds LGCDJBDIEJC, Color JJJKOMKEIGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5FCD600", Offset = "0x5FCC400", VA = "0x185FCD600")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A8180", Offset = "0x7A6F80", VA = "0x1807A8180")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7B3DB0", Offset = "0x7B2BB0", VA = "0x1807B3DB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xDE2460", Offset = "0xDE1260", VA = "0x180DE2460")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4218930", Offset = "0x4217730", VA = "0x184218930")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "4")]
	public virtual void AMOLAGFEIDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
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
	[HLGPKNDKBPO]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4218510", Offset = "0x4217310", VA = "0x184218510", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x42171B0", Offset = "0x4215FB0", VA = "0x1842171B0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4218860", Offset = "0x4217660", VA = "0x184218860")]
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
	private sealed class MPCPEPPCPKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public MPCPEPPCPKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3E00680", Offset = "0x3DFF480", VA = "0x183E00680")]
		internal int OILPMDOHLLL(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[HLGPKNDKBPO]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x32763D0", Offset = "0x32751D0", VA = "0x1832763D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3276420", Offset = "0x3275220", VA = "0x183276420", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x32762D0", Offset = "0x32750D0", VA = "0x1832762D0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey JCMGBFKGKLO]
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3276370", Offset = "0x3275170", VA = "0x183276370", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x32761B0", Offset = "0x3274FB0", VA = "0x1832761B0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3275ED0", Offset = "0x3274CD0", VA = "0x183275ED0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3275370", Offset = "0x3274170", VA = "0x183275370", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3275310", Offset = "0x3274110", VA = "0x183275310", Slot = "14")]
	protected virtual string IEKHOOCBBPB(TKeyVal OGOAMAFCMHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x32751F0", Offset = "0x3273FF0", VA = "0x1832751F0", Slot = "4")]
	public bool ContainsKey(TKey JCMGBFKGKLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3276070", Offset = "0x3274E70", VA = "0x183276070", Slot = "5")]
	public bool TryGetValue(TKey JCMGBFKGKLO, [Out] TVal NKKIECLCEML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3275240", Offset = "0x3274040", VA = "0x183275240", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3275240", Offset = "0x3274040", VA = "0x183275240", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x32760C0", Offset = "0x3274EC0", VA = "0x1832760C0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class JADPJHMBDMI<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private class AEDOKKFHODJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public float INFPDOOBKPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public T DFPHMDCMPIO;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public AEDOKKFHODJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class DPKOEMGJPGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public DPKOEMGJPGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4F56080", Offset = "0x4F54E80", VA = "0x184F56080")]
		internal bool BEGDPMKFOJF(AEDOKKFHODJ sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float GIIGAIABENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float CPCFBOKEIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<AEDOKKFHODJ> BIBKFCOKBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private HKOLBKHAPJN<AEDOKKFHODJ> DIEBJHECHBE;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int LJADEGENPLG
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x39EF740", Offset = "0x39EE540", VA = "0x1839EF740")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x39F0280", Offset = "0x39EF080", VA = "0x1839F0280")]
	public JADPJHMBDMI(float LNEDFLMMFBF, float NBFBABOMALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x39EFF70", Offset = "0x39EED70", VA = "0x1839EFF70")]
	public bool PEPHBLCDCIM(float JKFFGJGCLAE, T NKKIECLCEML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x39EFAE0", Offset = "0x39EE8E0", VA = "0x1839EFAE0")]
	public IEnumerable<T> MEJHGPPHNMP(float JKFFGJGCLAE, [Optional] float? FELENDOEAKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x39EF660", Offset = "0x39EE460", VA = "0x1839EF660")]
	public void BBGCGJHDDBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x39EFE10", Offset = "0x39EEC10", VA = "0x1839EFE10")]
	private void NJDKOPJOEOC(float JKFFGJGCLAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class AMEKPPEDCLJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct KCFCJDLCBPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public T DFPHMDCMPIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public float CGOKFIJIKNI;
	}

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static float MBKEICCANIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private List<T> CJBMHKADHAC;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private const int HMKMJJLOINK = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private KCFCJDLCBPG[] AAKJIOEDOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private int EHJOFCHFBMH;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float ENHAACNFAKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xB669D0", Offset = "0xB657D0", VA = "0x180B669D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xB669B0", Offset = "0xB657B0", VA = "0x180B669B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3737DA0", Offset = "0x3736BA0", VA = "0x183737DA0")]
	public AMEKPPEDCLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3737CB0", Offset = "0x3736AB0", VA = "0x183737CB0")]
	public AMEKPPEDCLJ(int DDGPJFNNFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3736E90", Offset = "0x3735C90", VA = "0x183736E90")]
	public void ANMBPKAMKOK(float JKFFGJGCLAE, T NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3736F50", Offset = "0x3735D50", VA = "0x183736F50")]
	public void BBGCGJHDDBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3737790", Offset = "0x3736590", VA = "0x183737790")]
	public bool MDLPIEBNMNK(float LDECMGDMHAF, float CODNPHHPIPB, [Out] T NKKIECLCEML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3737320", Offset = "0x3736120", VA = "0x183737320")]
	public bool GELGDOGLJED(float LDECMGDMHAF, float CODNPHHPIPB, [Out] T NKKIECLCEML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3737AE0", Offset = "0x37368E0", VA = "0x183737AE0")]
	public void MICIDNNMMCL(float LDECMGDMHAF, float CODNPHHPIPB, List<T> CDNPBOBHCMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3737C20", Offset = "0x3736A20", VA = "0x183737C20")]
	private int OOIPGKGOBGL(int BGCLBHCBAIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x37374C0", Offset = "0x37362C0", VA = "0x1837374C0")]
	private void GNNKBIFKICO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T BIOADIEFLNO();

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T BEFNNNFPHJE(T NKKIECLCEML, float GBMCNPIMCLE);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T LCDNHNFCBDK(T EHBONBMIDMA, T MKAKMHGMJJL);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T JGHDCNBHBJI(T EHBONBMIDMA, T MKAKMHGMJJL);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class NBIJJKGFLKL : AMEKPPEDCLJ<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7B9990", Offset = "0x7B8790", VA = "0x1807B9990", Slot = "4")]
	protected override Vector3 BIOADIEFLNO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5FCB970", Offset = "0x5FCA770", VA = "0x185FCB970", Slot = "5")]
	protected override Vector3 BEFNNNFPHJE(Vector3 NKKIECLCEML, float GBMCNPIMCLE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5FCBA30", Offset = "0x5FCA830", VA = "0x185FCBA30", Slot = "6")]
	protected override Vector3 LCDNHNFCBDK(Vector3 EHBONBMIDMA, Vector3 MKAKMHGMJJL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5FCB9B0", Offset = "0x5FCA7B0", VA = "0x185FCB9B0", Slot = "7")]
	protected override Vector3 JGHDCNBHBJI(Vector3 EHBONBMIDMA, Vector3 MKAKMHGMJJL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5FCBA80", Offset = "0x5FCA880", VA = "0x185FCBA80")]
	public NBIJJKGFLKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class FFNFIGBAHJF
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x26E4A20", Offset = "0x26E3820", VA = "0x1826E4A20")]
	public static DNBANAGLFEI<T1, T2> IKNJBMGGGFK<T1, T2>(T1 BINFHNIHOML, T2 KFEHIPEKEOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x26E4AA0", Offset = "0x26E38A0", VA = "0x1826E4AA0")]
	public static GNMFMNPFPJN<T1, T2, T3> IKNJBMGGGFK<T1, T2, T3>(T1 BINFHNIHOML, T2 KFEHIPEKEOL, T3 NCNHMKAHICI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3E30350", Offset = "0x3E2F150", VA = "0x183E30350")]
	internal static int FGOHBHOPPNL(int PHNCPODEFDN, int INIDOIPMHKE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x53FDFF0", Offset = "0x53FCDF0", VA = "0x1853FDFF0")]
	internal static int FGOHBHOPPNL(int PHNCPODEFDN, int INIDOIPMHKE, int IAOLELHGGFF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class DNBANAGLFEI<T1, T2> : IComparable<DNBANAGLFEI<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T1 BMCGKNHDPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly T2 MOKJIMHJDLL;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4F51060", Offset = "0x4F4FE60", VA = "0x184F51060")]
	public DNBANAGLFEI(T1 BINFHNIHOML, T2 KFEHIPEKEOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4F4F9C0", Offset = "0x4F4E7C0", VA = "0x184F4F9C0", Slot = "4")]
	public int CompareTo(DNBANAGLFEI<T1, T2> FPEEGIOMOFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4F4FBA0", Offset = "0x4F4E9A0", VA = "0x184F4FBA0", Slot = "0")]
	public override bool Equals(object FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4F50490", Offset = "0x4F4F290", VA = "0x184F50490", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4F50D90", Offset = "0x4F4FB90", VA = "0x184F50D90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class GNMFMNPFPJN<T1, T2, T3> : IComparable<GNMFMNPFPJN<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly T1 BMCGKNHDPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly T2 MOKJIMHJDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly T3 BNLMGJJAIEG;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x36D1140", Offset = "0x36CFF40", VA = "0x1836D1140")]
	public GNMFMNPFPJN(T1 BINFHNIHOML, T2 KFEHIPEKEOL, T3 NCNHMKAHICI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x36D0800", Offset = "0x36CF600", VA = "0x1836D0800", Slot = "4")]
	public int CompareTo(GNMFMNPFPJN<T1, T2, T3> FPEEGIOMOFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x36D0B90", Offset = "0x36CF990", VA = "0x1836D0B90", Slot = "0")]
	public override bool Equals(object FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x36D0DD0", Offset = "0x36CFBD0", VA = "0x1836D0DD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x36D0F80", Offset = "0x36CFD80", VA = "0x1836D0F80", Slot = "3")]
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
	public T DFPHMDCMPIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x208B490", Offset = "0x208A290", VA = "0x18208B490")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x208B3E0", Offset = "0x208A1E0", VA = "0x18208B3E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float ANAHCKJLPHI
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x849BD0", Offset = "0x8489D0", VA = "0x180849BD0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4400C20", Offset = "0x43FFA20", VA = "0x184400C20")]
	public T CLHJFELOGLO(float GBMCNPIMCLE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4400F30", Offset = "0x43FFD30", VA = "0x184400F30")]
	public T KEKFLEPNAKF(float GBMCNPIMCLE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T LKAFBGBBGDK(T EHBONBMIDMA, T MKAKMHGMJJL, float GBMCNPIMCLE);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5FC9880", Offset = "0x5FC8680", VA = "0x185FC9880", Slot = "4")]
	protected override float LKAFBGBBGDK(float EHBONBMIDMA, float MKAKMHGMJJL, float GBMCNPIMCLE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5FC98C0", Offset = "0x5FC86C0", VA = "0x185FC98C0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xC8EB30", Offset = "0xC8D930", VA = "0x180C8EB30", Slot = "4")]
	protected override Vector3 LKAFBGBBGDK(Vector3 EHBONBMIDMA, Vector3 MKAKMHGMJJL, float GBMCNPIMCLE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5FCE5E0", Offset = "0x5FCD3E0", VA = "0x185FCE5E0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5FC9720", Offset = "0x5FC8520", VA = "0x185FC9720", Slot = "4")]
	protected override Color LKAFBGBBGDK(Color EHBONBMIDMA, Color MKAKMHGMJJL, float GBMCNPIMCLE)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5FC97E0", Offset = "0x5FC85E0", VA = "0x185FC97E0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class CIKAKBDILDL : KOHKHBGHCOK<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5FC96D0", Offset = "0x5FC84D0", VA = "0x185FC96D0")]
	public CIKAKBDILDL(int BKPALGGNBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5FC9660", Offset = "0x5FC8460", VA = "0x185FC9660", Slot = "6")]
	protected override uint HDHCMELDNHC(uint JHFKHJKILDH, string NKKIECLCEML)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class JJKHNHLNKPL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly IDisposable AHFNEPHAKHC;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public JJKHNHLNKPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct KCEJLMJIANH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> BBKPMJKBLJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int GFNDIKFIGCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int DNMJCCCAIBB;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3A9CF20", Offset = "0x3A9BD20", VA = "0x183A9CF20")]
	private KCEJLMJIANH(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> HBPDKAJBKJD, int DFBJAKBJGDE, int LOBIOCHCPEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3A9B9E0", Offset = "0x3A9A7E0", VA = "0x183A9B9E0")]
	public static KCEJLMJIANH<T> KJKFMOENPNA()
	{
		return default(KCEJLMJIANH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3A9C1A0", Offset = "0x3A9AFA0", VA = "0x183A9C1A0")]
	public (int, int, Task<T>) PBEDOEOEOFB(int PMIHOHEADPP, [Optional] CancellationToken HHBHDBLGMFA, double JDMCAOCKBDE = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3A9B4A0", Offset = "0x3A9A2A0", VA = "0x183A9B4A0")]
	public void GIKIIFJHKPC(int PMIHOHEADPP, int LOBIOCHCPEE, [In] T BGCCPJGDEGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class JFCBHFPGBFI
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5FC9980", Offset = "0x5FC8780", VA = "0x185FC9980")]
	public static KCEJLMJIANH<JEGFFGGMBEH> KJKFMOENPNA()
	{
		return default(KCEJLMJIANH<JEGFFGGMBEH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5FC9900", Offset = "0x5FC8700", VA = "0x185FC9900")]
	public static void GIKIIFJHKPC([In] this KCEJLMJIANH<JEGFFGGMBEH> CNFBJPGPBBJ, int PMIHOHEADPP, int LOBIOCHCPEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DefaultMember("Item")]
public class CHOJBDFCFOC<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly Dictionary<TKey, TVal> HABAGPDCPLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly Dictionary<TVal, TKey> CIBDJLOKLBB;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int DDMEKBICEFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x305C500", Offset = "0x305B300", VA = "0x18305C500", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool JPJFNMHJCCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ICollection<TKey> PCKCIKFNJCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x35CFFC0", Offset = "0x35CEDC0", VA = "0x1835CFFC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ICollection<TVal> BOEKFJCDIMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x4983180", Offset = "0x4981F80", VA = "0x184983180", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TVal LKDOJBHIIBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x4983120", Offset = "0x4981F20", VA = "0x184983120", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x49831E0", Offset = "0x4981FE0", VA = "0x1849831E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey LKDOJBHIIBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x49827D0", Offset = "0x49815D0", VA = "0x1849827D0")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4982490", Offset = "0x4981290", VA = "0x184982490", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4982F00", Offset = "0x4981D00", VA = "0x184982F00", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x49823D0", Offset = "0x49811D0", VA = "0x1849823D0", Slot = "9")]
	public void Add(TKey JCMGBFKGKLO, TVal NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4982420", Offset = "0x4981220", VA = "0x184982420", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> PEFIMPHEJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3F85AB0", Offset = "0x3F848B0", VA = "0x183F85AB0", Slot = "8")]
	public bool ContainsKey(TKey JCMGBFKGKLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x49824F0", Offset = "0x49812F0", VA = "0x1849824F0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> PEFIMPHEJCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4982E70", Offset = "0x4981C70", VA = "0x184982E70", Slot = "10")]
	public bool Remove(TKey JCMGBFKGKLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4982ED0", Offset = "0x4981CD0", VA = "0x184982ED0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> PEFIMPHEJCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4982FF0", Offset = "0x4981DF0", VA = "0x184982FF0", Slot = "11")]
	public bool TryGetValue(TKey JCMGBFKGKLO, [Out] TVal NKKIECLCEML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x49826A0", Offset = "0x49814A0", VA = "0x1849826A0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4982580", Offset = "0x4981380", VA = "0x184982580", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] AAKJIOEDOGA, int LNFNDNMPKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4982600", Offset = "0x4981400", VA = "0x184982600")]
	public bool GNMCOJGNPDP(TVal JCMGBFKGKLO, [Out] TKey NKKIECLCEML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4982990", Offset = "0x4981790", VA = "0x184982990")]
	private void KJBNKHLPBON(TKey JCMGBFKGKLO, TVal NGFDKOKHGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4982AC0", Offset = "0x49818C0", VA = "0x184982AC0")]
	private void LNPMHEMIHJC(TKey JCMGBFKGKLO, TVal NGFDKOKHGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4982CC0", Offset = "0x4981AC0", VA = "0x184982CC0")]
	private bool MCOMBJNJIOF(TKey JCMGBFKGKLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4983030", Offset = "0x4981E30", VA = "0x184983030")]
	public CHOJBDFCFOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[DefaultMember("Item")]
public class FJMLNAPHBBC<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private FJMLNAPHBBC<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x32BD600", Offset = "0x32BC400", VA = "0x1832BD600", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x32CB2E0", Offset = "0x32CA0E0", VA = "0x1832CB2E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x32CBB00", Offset = "0x32CA900", VA = "0x1832CBB00")]
		public Enumerator(FJMLNAPHBBC<T> CDNPBOBHCMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x32C8DF0", Offset = "0x32C7BF0", VA = "0x1832C8DF0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x32C9410", Offset = "0x32C8210", VA = "0x1832C9410", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x32C78E0", Offset = "0x32C66E0", VA = "0x1832C78E0")]
		private void JIGHBOEPEEN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private T[] HFOALDPPCOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int BKOJFCPJPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int HDOODKLECOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private int ILCLKBNEPAJ;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int DDMEKBICEFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x35D7A00", Offset = "0x35D6800", VA = "0x1835D7A00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T LKDOJBHIIBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x35D7270", Offset = "0x35D6070", VA = "0x1835D7270")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x35D6D50", Offset = "0x35D5B50", VA = "0x1835D6D50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x35D8730", Offset = "0x35D7530", VA = "0x1835D8730")]
	public FJMLNAPHBBC(int BKPALGGNBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x35D6990", Offset = "0x35D5790", VA = "0x1835D6990")]
	public void ANMBPKAMKOK(T GBMCNPIMCLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x35D6D30", Offset = "0x35D5B30", VA = "0x1835D6D30")]
	public void BBGCGJHDDBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x35D7040", Offset = "0x35D5E40", VA = "0x1835D7040")]
	public void CCILAKEOFCH(int BPFMGMBDOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x35D8170", Offset = "0x35D6F70", VA = "0x1835D8170")]
	public void JNEOEPIPDLN(T[] AAKJIOEDOGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x35D8380", Offset = "0x35D7180", VA = "0x1835D8380")]
	public Enumerator OOEEFIELKKG()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x35D8540", Offset = "0x35D7340", VA = "0x1835D8540", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x35D8540", Offset = "0x35D7340", VA = "0x1835D8540", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x35D78F0", Offset = "0x35D66F0", VA = "0x1835D78F0")]
	private int IDCIDADDJMB(int ENPOKNEMOMH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x35D82E0", Offset = "0x35D70E0", VA = "0x1835D82E0")]
	private int MGMEEPLFDJC(int ENPOKNEMOMH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class KEEBFIEAOIG<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Func<Internal, External> BMMNHJDNPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private IReadOnlyList<Internal> FOKGGJDBEOD;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public External LKDOJBHIIBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3AA1610", Offset = "0x3AA0410", VA = "0x183AA1610", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int DDMEKBICEFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3AA15C0", Offset = "0x3AA03C0", VA = "0x183AA15C0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040")]
	public KEEBFIEAOIG(Func<Internal, External> BMMNHJDNPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3AA1570", Offset = "0x3AA0370", VA = "0x183AA1570")]
	public KEEBFIEAOIG(IReadOnlyList<Internal> FOKGGJDBEOD, Func<Internal, External> BMMNHJDNPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3AA14F0", Offset = "0x3AA02F0", VA = "0x183AA14F0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x34E6C90", Offset = "0x34E5A90", VA = "0x1834E6C90", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class OOENFBDGALI<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate Task<TResult> LCABNBOOLBE(TRequest MIMLCIHLPAB, CancellationToken HHBHDBLGMFA);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public enum LDKKNFOEAGN
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class ONOKEMFHDEL
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private const float IGHMMHLJOFM = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TimeSpan PAAKDJPIPAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int NMKHBNHHGGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public LDKKNFOEAGN MHEBEGJFJJM;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static readonly ONOKEMFHDEL IEMILNCFJOJ;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float FMOLOIBHIPL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x3F85790", Offset = "0x3F84590", VA = "0x183F85790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TimeSpan IBOADLNEBKM
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x3F85870", Offset = "0x3F84670", VA = "0x183F85870")]
		public ONOKEMFHDEL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private readonly struct MNKJPIOOLCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly TRequest MIMLCIHLPAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly CancellationToken HHBHDBLGMFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly TaskCompletionSource<TResult> HNGGKIBECFD;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFF60", Offset = "0x3DFED60", VA = "0x183DFFF60")]
		public MNKJPIOOLCH(TRequest MIMLCIHLPAB, TaskCompletionSource<TResult> HNGGKIBECFD, CancellationToken HHBHDBLGMFA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct IEILGLFABMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public OOENFBDGALI<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x384AE20", Offset = "0x3849C20", VA = "0x18384AE20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x384B6A0", Offset = "0x384A4A0", VA = "0x18384B6A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct MKKCPOMEIGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public OOENFBDGALI<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private MNKJPIOOLCH <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8A60", Offset = "0x3DE7860", VA = "0x183DE8A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3DE9C90", Offset = "0x3DE8A90", VA = "0x183DE9C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly CancellationTokenSource ODBLIPEMDHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly List<MNKJPIOOLCH> PGLFNAEMOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly ONOKEMFHDEL GBCOGAINCDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly LCABNBOOLBE KHLLANOLGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Task PIDKENPFAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private int AKIDMDHIMBH;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3F89640", Offset = "0x3F88440", VA = "0x183F89640")]
	public OOENFBDGALI(LCABNBOOLBE KHLLANOLGDP, [Optional] ONOKEMFHDEL GBCOGAINCDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3F89260", Offset = "0x3F88060", VA = "0x183F89260")]
	public Task<TResult> OFNHLGONLMC(TRequest MIMLCIHLPAB, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3F89450", Offset = "0x3F88250", VA = "0x183F89450")]
	private void PFAMALOGPJI(MNKJPIOOLCH MHBFDGACOME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3F88950", Offset = "0x3F87750", VA = "0x183F88950")]
	[AsyncStateMachine(typeof(OOENFBDGALI<, >.IEILGLFABMC))]
	private Task DCMELGGANIK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3F880B0", Offset = "0x3F86EB0", VA = "0x183F880B0")]
	private MNKJPIOOLCH CMONOFKIHBN()
	{
		return default(MNKJPIOOLCH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3F88B30", Offset = "0x3F87930", VA = "0x183F88B30")]
	[AsyncStateMachine(typeof(OOENFBDGALI<, >.MKKCPOMEIGG))]
	private Task JCIPJOKLJLD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3F87DE0", Offset = "0x3F86BE0", VA = "0x183F87DE0")]
	private void BGBANOAPDEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3F88AF0", Offset = "0x3F878F0", VA = "0x183F88AF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public class JLNAMMOGMIC<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly List<T> FOKGGJDBEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private HashSet<T> OEKCGFBPPPE;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int DDMEKBICEFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x305C500", Offset = "0x305B300", VA = "0x18305C500", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool JPJFNMHJCCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T LKDOJBHIIBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x37B7BE0", Offset = "0x37B69E0", VA = "0x1837B7BE0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3A5D530", Offset = "0x3A5C330", VA = "0x183A5D530", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x35FD420", Offset = "0x35FC220", VA = "0x1835FD420", Slot = "11")]
	public void Add(T PEFIMPHEJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3A5CEB0", Offset = "0x3A5BCB0", VA = "0x183A5CEB0")]
	public bool OEADEOBEAEM(T PEFIMPHEJCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3A5D2C0", Offset = "0x3A5C0C0", VA = "0x183A5D2C0", Slot = "15")]
	public bool Remove(T PEFIMPHEJCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3A5CC10", Offset = "0x3A5BA10", VA = "0x183A5CC10", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x362DB50", Offset = "0x362C950", VA = "0x18362DB50", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3A5CB40", Offset = "0x3A5B940", VA = "0x183A5CB40", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3A5CBA0", Offset = "0x3A5B9A0", VA = "0x183A5CBA0", Slot = "13")]
	public bool Contains(T PEFIMPHEJCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3A5CBE0", Offset = "0x3A5B9E0", VA = "0x183A5CBE0", Slot = "14")]
	public void CopyTo(T[] AAKJIOEDOGA, int LNFNDNMPKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3A5CCA0", Offset = "0x3A5BAA0", VA = "0x183A5CCA0", Slot = "6")]
	public int IndexOf(T PEFIMPHEJCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3A5CDD0", Offset = "0x3A5BBD0", VA = "0x183A5CDD0", Slot = "7")]
	public void Insert(int ENPOKNEMOMH, T PEFIMPHEJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3A5D130", Offset = "0x3A5BF30", VA = "0x183A5D130", Slot = "8")]
	public void RemoveAt(int ENPOKNEMOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3A5D360", Offset = "0x3A5C160", VA = "0x183A5D360")]
	public JLNAMMOGMIC()
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
			[Cpp2IlInjected.Address(RVA = "0x1EFD540", Offset = "0x1EFC340", VA = "0x181EFD540")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x1979940", Offset = "0x1978740", VA = "0x181979940")]
		public SerializedGuid([In] Guid FANIDECOFDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5FCDB00", Offset = "0x5FCC900", VA = "0x185FCDB00")]
		public static SerializedGuid NEOIEPLCIPF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5FCDC30", Offset = "0x5FCCA30", VA = "0x185FCDC30")]
		public static SerializedGuid PPNELEAMEIB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5FCD990", Offset = "0x5FCC790", VA = "0x185FCD990")]
		public bool CHDBPBGLOPC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5FCDC00", Offset = "0x5FCCA00", VA = "0x185FCDC00", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5FCDB80", Offset = "0x5FCC980", VA = "0x185FCDB80", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5FCDA20", Offset = "0x5FCC820", VA = "0x185FCDA20", Slot = "7")]
		public bool Equals(SerializedGuid FPEEGIOMOFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5FCDA60", Offset = "0x5FCC860", VA = "0x185FCDA60", Slot = "0")]
		public override bool Equals(object NHLNHJGAONN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5FCDAF0", Offset = "0x5FCC8F0", VA = "0x185FCDAF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5FCD9F0", Offset = "0x5FCC7F0", VA = "0x185FCD9F0", Slot = "6")]
		public int CompareTo(SerializedGuid FPEEGIOMOFF)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class PEFNNHLEBHM : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly Type AGPNNGCHFHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly string BOIGPJGPGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool KDAKGKDMAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool LONGLBIMGMF;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5FCC4E0", Offset = "0x5FCB2E0", VA = "0x185FCC4E0")]
	public PEFNNHLEBHM(Type KOFKNEEHLEL, string IBFJOILDGPF, bool IEFLLGEPPIP = false, bool FKLCHMBPEDH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class GAKKIOAFLLE<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public readonly struct PHKFKJLBNIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly long DGNIDNCAIKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly long EJIEDMPNNFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public readonly int PDLBBPEMHOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly int BONPKOKMOOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly bool LKINEJNMFND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly string IJFJLHPMGAD;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x4045120", Offset = "0x4043F20", VA = "0x184045120")]
		public PHKFKJLBNIJ(long DGNIDNCAIKK, int PDLBBPEMHOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x4045190", Offset = "0x4043F90", VA = "0x184045190")]
		public PHKFKJLBNIJ(long DGNIDNCAIKK, long EJIEDMPNNFM, int PDLBBPEMHOA, int BONPKOKMOOH, bool LKINEJNMFND, string IJFJLHPMGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x4044FB0", Offset = "0x4043DB0", VA = "0x184044FB0")]
		public int EDIKNHAICFL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x4045000", Offset = "0x4043E00", VA = "0x184045000")]
		public int FJBCOJKECIK(int EIPMFOIFIEK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x40450C0", Offset = "0x4043EC0", VA = "0x1840450C0")]
		public double NOMPNOHBJDB()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x4045020", Offset = "0x4043E20", VA = "0x184045020")]
		public PHKFKJLBNIJ KMGNJDIJBMK(long EJIEDMPNNFM, int BONPKOKMOOH)
		{
			return default(PHKFKJLBNIJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class AGJOEKMHOHC : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct GKCPIJNBPNF<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public AGJOEKMHOHC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Func<AGJOEKMHOHC, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private AGJOEKMHOHC <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x36CA7C0", Offset = "0x36C95C0", VA = "0x1836CA7C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x36CACE0", Offset = "0x36C9AE0", VA = "0x1836CACE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly TKey DIJJAKBLGBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly GAKKIOAFLLE<TKey> JNIKEBIHBPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly KNPFMNBIIDA PGKJJCPHNLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private List<AGJOEKMHOHC> MHCLKHMPNFE;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string EAJCPGBFIJA
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x3679E00", Offset = "0x3678C00", VA = "0x183679E00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IEnumerable<AGJOEKMHOHC> CGEECCJFLKE
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x367A030", Offset = "0x3678E30", VA = "0x18367A030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public PHKFKJLBNIJ IKKFPJIGDKD
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x367A1D0", Offset = "0x3678FD0", VA = "0x18367A1D0")]
			[CompilerGenerated]
			get
			{
				return default(PHKFKJLBNIJ);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x3679DD0", Offset = "0x3678BD0", VA = "0x183679DD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x367A1F0", Offset = "0x3678FF0", VA = "0x18367A1F0")]
		internal AGJOEKMHOHC(GAKKIOAFLLE<TKey> JNIKEBIHBPI, TKey JCMGBFKGKLO, KNPFMNBIIDA PGKJJCPHNLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x367A070", Offset = "0x3678E70", VA = "0x18367A070")]
		public AGJOEKMHOHC HHLPCMIAAAP(TKey JCMGBFKGKLO, [Optional] KNPFMNBIIDA? DBAGAPKKKAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x22431A0", Offset = "0x2241FA0", VA = "0x1822431A0")]
		[AsyncStateMachine(typeof(GKCPIJNBPNF<>))]
		public Task<T> ABBGCKEFGKG<T>(TKey JCMGBFKGKLO, Func<AGJOEKMHOHC, Task<T>> ANOLKHFMNBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x3679E30", Offset = "0x3678C30", VA = "0x183679E30", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class IJGAHNFENIL : IEnumerable<(TKey, List<TKey>, PHKFKJLBNIJ)>, IEnumerable, IEnumerator<(TKey, List<TKey>, PHKFKJLBNIJ)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private (TKey key, List<TKey> path, PHKFKJLBNIJ timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public GAKKIOAFLLE<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IEnumerator<(TKey key, List<TKey> path, PHKFKJLBNIJ timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, PHKFKJLBNIJ) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x1EF1520", Offset = "0x1EF0320", VA = "0x181EF1520", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, PHKFKJLBNIJ));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x385D3A0", Offset = "0x385C1A0", VA = "0x18385D3A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x1EF1610", Offset = "0x1EF0410", VA = "0x181EF1610")]
		[DebuggerHidden]
		public IJGAHNFENIL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x34E4DB0", Offset = "0x34E3BB0", VA = "0x1834E4DB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x385CF00", Offset = "0x385BD00", VA = "0x18385CF00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x385D240", Offset = "0x385C040", VA = "0x18385D240")]
		private void ONJBEDHNBAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x385D350", Offset = "0x385C150", VA = "0x18385D350", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x385D290", Offset = "0x385C090", VA = "0x18385D290", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, PHKFKJLBNIJ)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3608960", Offset = "0x3607760", VA = "0x183608960", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class JKAHHOICDME : IEnumerable<(TKey, List<TKey>, PHKFKJLBNIJ)>, IEnumerable, IEnumerator<(TKey, List<TKey>, PHKFKJLBNIJ)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private (TKey key, List<TKey> path, PHKFKJLBNIJ timerEntry) <>2__current;

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
		private AGJOEKMHOHC timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public AGJOEKMHOHC <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public GAKKIOAFLLE<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private IEnumerator<AGJOEKMHOHC> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private IEnumerator<(TKey key, List<TKey> path, PHKFKJLBNIJ timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private (TKey, List<TKey>, PHKFKJLBNIJ) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x1EF1520", Offset = "0x1EF0320", VA = "0x181EF1520", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, PHKFKJLBNIJ));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x3A53AF0", Offset = "0x3A528F0", VA = "0x183A53AF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x1EF1610", Offset = "0x1EF0410", VA = "0x181EF1610")]
		[DebuggerHidden]
		public JKAHHOICDME(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3A53B50", Offset = "0x3A52950", VA = "0x183A53B50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3A53180", Offset = "0x3A51F80", VA = "0x183A53180", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3A53930", Offset = "0x3A52730", VA = "0x183A53930")]
		private void ONJBEDHNBAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3A53120", Offset = "0x3A51F20", VA = "0x183A53120")]
		private void AGDCIDILFPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3A53AA0", Offset = "0x3A528A0", VA = "0x183A53AA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3A53990", Offset = "0x3A52790", VA = "0x183A53990", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, PHKFKJLBNIJ)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3A53A70", Offset = "0x3A52870", VA = "0x183A53A70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly Action<TKey, PHKFKJLBNIJ, KNPFMNBIIDA> LBMINEFIGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Action<TKey, PHKFKJLBNIJ, KNPFMNBIIDA> CCJHALIJIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly Action<GAKKIOAFLLE<TKey>, KNPFMNBIIDA> KNCKIMPJAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly KNPFMNBIIDA PGKJJCPHNLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly AGJOEKMHOHC MDCNDAMNMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private bool OADMEOKPNBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int DHBJKBLDOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly Stopwatch GFFGOEIHEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly int COLLFEPMIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private string CLOFCGCOFCK;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public AGJOEKMHOHC AJJKIOBIBMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[NotNull]
	public string EAJCPGBFIJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CC0", Offset = "0x7A7AC0", VA = "0x1807A8CC0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3688A90", Offset = "0x3687890", VA = "0x183688A90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3688D60", Offset = "0x3687B60", VA = "0x183688D60")]
	public GAKKIOAFLLE(TKey LHPKCELONII, KNPFMNBIIDA PGKJJCPHNLC, [Optional] int? PDLBBPEMHOA, [Optional][CanBeNull] Stopwatch GFFGOEIHEFC, [Optional] Action<TKey, PHKFKJLBNIJ, KNPFMNBIIDA> LBMINEFIGMN, [Optional] Action<TKey, PHKFKJLBNIJ, KNPFMNBIIDA> CCJHALIJIAE, [Optional] Action<GAKKIOAFLLE<TKey>, KNPFMNBIIDA> KNCKIMPJAOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3688AF0", Offset = "0x36878F0", VA = "0x183688AF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3688B80", Offset = "0x3687980", VA = "0x183688B80")]
	[IteratorStateMachine(typeof(GAKKIOAFLLE<>.IJGAHNFENIL))]
	public IEnumerable<(TKey, List<TKey>, PHKFKJLBNIJ)> FJHECMBFMLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3688C10", Offset = "0x3687A10", VA = "0x183688C10")]
	[IteratorStateMachine(typeof(GAKKIOAFLLE<>.JKAHHOICDME))]
	private IEnumerable<(TKey, List<TKey>, PHKFKJLBNIJ)> FJHECMBFMLE(List<TKey> CIPMAAMIEBA, AGJOEKMHOHC KLCONELMJIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x3688CE0", Offset = "0x3687AE0", VA = "0x183688CE0")]
	private (long, int) JFGMDLNCBED()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public abstract class PNOEIFLHHAO<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut IEICLNCKBBA(GAKKIOAFLLE<TKey> JNIKEBIHBPI);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	protected PNOEIFLHHAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public abstract class CJIFAMHBLOD<TKey> : PNOEIFLHHAO<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate string EPEGMBKCHJK(TKey JCMGBFKGKLO);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x4A56000", Offset = "0x4A54E00", VA = "0x184A56000")]
	private static string DBIOENILPOK(TKey JCMGBFKGKLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x4A56190", Offset = "0x4A54F90", VA = "0x184A56190", Slot = "4")]
	public override string IEICLNCKBBA(GAKKIOAFLLE<TKey> JNIKEBIHBPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x4A56040", Offset = "0x4A54E40", VA = "0x184A56040")]
	public string IEICLNCKBBA(GAKKIOAFLLE<TKey> JNIKEBIHBPI, [NotNull] EPEGMBKCHJK IIOBOFGGMKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string DEBBNMCKHIP(GAKKIOAFLLE<TKey> JNIKEBIHBPI, [NotNull] EPEGMBKCHJK IIOBOFGGMKP);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x366EB70", Offset = "0x366D970", VA = "0x18366EB70")]
	protected CJIFAMHBLOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class PMMMNCPGNNK<TKey> : PNOEIFLHHAO<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate string IGPHEFIBOMO(TKey JCMGBFKGKLO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly string NPLOHBGBGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly double MFFEAHFBLAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly bool MADMIDAKOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly int NHPJHMALAHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly ISet<string> EOLHPDFPOBA;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x405B390", Offset = "0x405A190", VA = "0x18405B390")]
	private static string DBIOENILPOK(TKey JCMGBFKGKLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x405BCC0", Offset = "0x405AAC0", VA = "0x18405BCC0")]
	public PMMMNCPGNNK(string NPLOHBGBGPJ = "F2", double MFFEAHFBLAB = double.MaxValue, bool MADMIDAKOJM = false, int NHPJHMALAHA = int.MaxValue, [Optional] ISet<string> EOLHPDFPOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x405B3D0", Offset = "0x405A1D0", VA = "0x18405B3D0", Slot = "4")]
	public override Dictionary<string, string> IEICLNCKBBA(GAKKIOAFLLE<TKey> JNIKEBIHBPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x405BA80", Offset = "0x405A880", VA = "0x18405BA80")]
	private bool KNDCJJAEDBP(string IGJKGDNEMAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x405B490", Offset = "0x405A290", VA = "0x18405B490")]
	public Dictionary<string, string> IEICLNCKBBA(GAKKIOAFLLE<TKey> JNIKEBIHBPI, IGPHEFIBOMO IIOBOFGGMKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x405B150", Offset = "0x4059F50", VA = "0x18405B150")]
	private string BKFGIJELBIM(StringBuilder IHIJHEEKJDF, List<TKey> GMGBLICEOAO, IGPHEFIBOMO IIOBOFGGMKP, bool JONJFLKLMII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x405BB60", Offset = "0x405A960", VA = "0x18405BB60")]
	private static void OBGHOGANJFO(StringBuilder IEGFDOACKEE, string ICKBNPJIHNC, bool PGBIKDAMPOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class IIKILHJNOKI<TKey> : CJIFAMHBLOD<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct MDKOCHJOEGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public EPEGMBKCHJK keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static IIKILHJNOKI<TKey> AHFNEPHAKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly string[] NAPIMKGJOPN;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x385B010", Offset = "0x3859E10", VA = "0x18385B010")]
	private IIKILHJNOKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3859FB0", Offset = "0x3858DB0", VA = "0x183859FB0", Slot = "5")]
	protected override string DEBBNMCKHIP(GAKKIOAFLLE<TKey> JNIKEBIHBPI, EPEGMBKCHJK IIOBOFGGMKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x385ADE0", Offset = "0x3859BE0", VA = "0x18385ADE0")]
	[CompilerGenerated]
	internal static string NCLPGBLLPJB(string LDOGLONKAPF, TKey JCMGBFKGKLO, MDKOCHJOEGC P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class NOLGEMCHFPP : GAKKIOAFLLE<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class ACCIINAFGEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Action<NOLGEMCHFPP, KNPFMNBIIDA> callback;

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public ACCIINAFGEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5FC95D0", Offset = "0x5FC83D0", VA = "0x185FC95D0")]
		internal void NOEDAEAIAIM(GAKKIOAFLLE<string> timer, KNPFMNBIIDA log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5FCBD10", Offset = "0x5FCAB10", VA = "0x185FCBD10")]
	public NOLGEMCHFPP(KNPFMNBIIDA PGKJJCPHNLC, [Optional] string DAFGMOEPNKF, [Optional] int? PDLBBPEMHOA, [Optional] Stopwatch GFFGOEIHEFC, [Optional] Action<string, PHKFKJLBNIJ, KNPFMNBIIDA> LBMINEFIGMN, [Optional] Action<string, PHKFKJLBNIJ, KNPFMNBIIDA> CCJHALIJIAE, [Optional] Action<NOLGEMCHFPP, KNPFMNBIIDA> KNCKIMPJAOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5FCBC50", Offset = "0x5FCAA50", VA = "0x185FCBC50")]
	private static Action<GAKKIOAFLLE<string>, KNPFMNBIIDA> PGECLHEBJCE(Action<NOLGEMCHFPP, KNPFMNBIIDA> IDFHKFHMFGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public abstract class NCCFLPNCLDF
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private class OPEEMKGNMJO : NCCFLPNCLDF
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static NCCFLPNCLDF AHFNEPHAKHC
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x5FCBE60", Offset = "0x5FCAC60", VA = "0x185FCBE60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override float IKHCPEKKIOH
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x1D512A0", Offset = "0x1D500A0", VA = "0x181D512A0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x5FCBF60", Offset = "0x5FCAD60", VA = "0x185FCBF60")]
		public OPEEMKGNMJO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static NCCFLPNCLDF HILILNEDGBM;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static NCCFLPNCLDF IEMILNCFJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5FCBAE0", Offset = "0x5FCA8E0", VA = "0x185FCBAE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public abstract float IKHCPEKKIOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	protected NCCFLPNCLDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class CGLFKLGAKHD<T> : KGABHDDFELA<T> where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public override Task<T> NCKLPNIOLLA
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public override DOPLGHLIBGN<T> BGHMBBEJALJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7A81F0", Offset = "0x7A6FF0", VA = "0x1807A81F0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x497F4A0", Offset = "0x497E2A0", VA = "0x18497F4A0")]
	public CGLFKLGAKHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "10")]
	protected override void DDABGGLCGBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class DAHIGOFEJDH<T> : KGABHDDFELA<T> where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public override Task<T> NCKLPNIOLLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public override DOPLGHLIBGN<T> BGHMBBEJALJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7A81F0", Offset = "0x7A6FF0", VA = "0x1807A81F0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x4F1B900", Offset = "0x4F1A700", VA = "0x184F1B900")]
	public DAHIGOFEJDH(Exception IHEECNGJNNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "10")]
	protected override void DDABGGLCGBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface NJLGNLFFLFF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool NJDBJPCDOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface CINGBHLEODA<T> : NJLGNLFFLFF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	[NotNull]
	Task<T> NCKLPNIOLLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	[NotNull]
	DOPLGHLIBGN<T> BGHMBBEJALJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public abstract class KGABHDDFELA<T> : CINGBHLEODA<T>, NJLGNLFFLFF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly EHEIKHGHOCA CCMPDDNAIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private bool OADMEOKPNBL;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool NJDBJPCDOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x99B210", Offset = "0x99A010", VA = "0x18099B210", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public abstract Task<T> NCKLPNIOLLA
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public abstract DOPLGHLIBGN<T> BGHMBBEJALJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x3AA54E0", Offset = "0x3AA42E0", VA = "0x183AA54E0")]
	public KGABHDDFELA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3AA52F0", Offset = "0x3AA40F0", VA = "0x183AA52F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void DDABGGLCGBF();
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public abstract class FAODBOAHNMI<TTask, T> : KGABHDDFELA<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class APKDOJINGGA
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
			public APKDOJINGGA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x304C8A0", Offset = "0x304B6A0", VA = "0x18304C8A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x304D0E0", Offset = "0x304BEE0", VA = "0x18304D0E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public FAODBOAHNMI<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public APKDOJINGGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x3851850", Offset = "0x3850650", VA = "0x183851850")]
		[AsyncStateMachine(typeof(FAODBOAHNMI<, >.APKDOJINGGA.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> NCHJOONPMCI(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly Task<T> IMKKNGNMOEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	protected readonly CancellationTokenSource HMAJEHPOLEJ;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public override Task<T> NCKLPNIOLLA
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public override DOPLGHLIBGN<T> BGHMBBEJALJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7A81F0", Offset = "0x7A6FF0", VA = "0x1807A81F0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x359F170", Offset = "0x359DF70", VA = "0x18359F170")]
	protected FAODBOAHNMI(TTask IMKKNGNMOEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x359F120", Offset = "0x359DF20", VA = "0x18359F120", Slot = "10")]
	protected override void DDABGGLCGBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T PFEGLDKAPNN(TTask MOHOEMJMGEM);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void MBHCGDGKOEH();
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class FNPEJEICPPD<T> : KGABHDDFELA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly PPOFINEEFFF<Task<T>> HHKBDPGFFKE;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public override Task<T> NCKLPNIOLLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x359E9F0", Offset = "0x359D7F0", VA = "0x18359E9F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public override DOPLGHLIBGN<T> BGHMBBEJALJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7A81F0", Offset = "0x7A6FF0", VA = "0x1807A81F0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x35E13C0", Offset = "0x35E01C0", VA = "0x1835E13C0")]
	public FNPEJEICPPD(PPOFINEEFFF<Task<T>> JPPAJICNDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x35E13A0", Offset = "0x35E01A0", VA = "0x1835E13A0", Slot = "10")]
	protected override void DDABGGLCGBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class PBJPPDEJMCF
{
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5FCC350", Offset = "0x5FCB150", VA = "0x185FCC350")]
	[NotNull]
	public static byte[] DMKNPGKFPJF(this NMJFBANAJLP MJICJMIIHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5FCC2E0", Offset = "0x5FCB0E0", VA = "0x185FCC2E0")]
	[NotNull]
	public static byte[] DMKNPGKFPJF(this NMJFBANAJLP MJICJMIIHJI, HashAlgorithmName CLNFHDLKJFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5FCBFB0", Offset = "0x5FCADB0", VA = "0x185FCBFB0")]
	public static bool DLEADDNFJPM([CanBeNull] this NMJFBANAJLP MJICJMIIHJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5FCC140", Offset = "0x5FCAF40", VA = "0x185FCC140")]
	public static bool DLEADDNFJPM([CanBeNull] this NMJFBANAJLP MJICJMIIHJI, [Out] string OLGJDMIGDKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5FCC3C0", Offset = "0x5FCB1C0", VA = "0x185FCC3C0")]
	private static bool LHLBAMPCNKH([NotNull] NMJFBANAJLP MJICJMIIHJI, [Out][CanBeNull] byte[] JJOMEGMLIFD, [Out][CanBeNull] byte[] GLMNCDLECCG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class JPNPOFNDKEL
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5FC9A50", Offset = "0x5FC8850", VA = "0x185FC9A50")]
	[NotNull]
	public static byte[] DMKNPGKFPJF(this JHGMNIJBLBK KIPCBMDACIK, HashAlgorithmName CLNFHDLKJFL, byte[] LPECPIDGJJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface JHGMNIJBLBK
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash JHFKHJKILDH);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface NMJFBANAJLP : JHGMNIJBLBK
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	[CanBeNull]
	byte[] GGAEADNJBDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	[CanBeNull]
	byte[] FHBEGFAIKJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class MMGAKDGKLBM
{
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static readonly ArrayPool<byte> ILPGHCJFPDI;

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static bool FPABIHBDNKH;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5FCB050", Offset = "0x5FC9E50", VA = "0x185FCB050")]
	public static void CAOMFKJNNBH(this IncrementalHash PIOBOKKGGOO, [CanBeNull] GameObject IPHCMOEHILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x27D28A0", Offset = "0x27D16A0", VA = "0x1827D28A0")]
	public static void CAOMFKJNNBH<T>(this IncrementalHash PIOBOKKGGOO, [CanBeNull] T EIFNJBJEIMP) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x27D34B0", Offset = "0x27D22B0", VA = "0x1827D34B0")]
	public static void PJPANMMOKIK<T>(this IncrementalHash PIOBOKKGGOO, [CanBeNull] T KIPCBMDACIK) where T : JHGMNIJBLBK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x27D2960", Offset = "0x27D1760", VA = "0x1827D2960")]
	public static void DNOJJCCOFCK<T>(this IncrementalHash PIOBOKKGGOO, [CanBeNull] IList<T> OPOJLLJGCIC) where T : JHGMNIJBLBK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5FCB130", Offset = "0x5FC9F30", VA = "0x185FCB130")]
	private static bool DGNLLDKOOCE([CanBeNull] JHGMNIJBLBK KIPCBMDACIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5FCB520", Offset = "0x5FCA320", VA = "0x185FCB520")]
	public static void OELOCINLCKD(this IncrementalHash JHFKHJKILDH, [CanBeNull] string LIKIIOCNHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5FCB690", Offset = "0x5FCA490", VA = "0x185FCB690")]
	public static void OLLFDOFGIAL(this IncrementalHash JHFKHJKILDH, long GDNBNNIDAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5FCADC0", Offset = "0x5FC9BC0", VA = "0x185FCADC0")]
	public static void BNIIKBBHECN(this IncrementalHash JHFKHJKILDH, int IDNGGMBFGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5FCABF0", Offset = "0x5FC99F0", VA = "0x185FCABF0")]
	public static void AGNBPKCPFKN(this IncrementalHash JHFKHJKILDH, short KCNHBOBBNEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5FCB580", Offset = "0x5FCA380", VA = "0x185FCB580")]
	public static void OHNALDHMHPF(this IncrementalHash JHFKHJKILDH, byte FBPHLECCCJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5FCB220", Offset = "0x5FCA020", VA = "0x185FCB220")]
	public static void HIDFLFBFIEA(this IncrementalHash JHFKHJKILDH, bool KIJKNIGLOMH, bool DDHEFMFOLGI = false, bool AIIGLEKMKHG = false, bool IJDHBEBBGHJ = false, bool KEMDCAODAHM = false, bool CLFEAIAHALK = false, bool CKKCCIMAOEC = false, bool IJDKHGEBNDP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x27D2E80", Offset = "0x27D1C80", VA = "0x1827D2E80")]
	public static void NLICPLGODBD<T>(this IncrementalHash JHFKHJKILDH, T BLFMPLMBDLD) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5FCAFF0", Offset = "0x5FC9DF0", VA = "0x185FCAFF0")]
	public static void BOKMAKHDMAM(this IncrementalHash JHFKHJKILDH, float FCMHIOPOBAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5FCB4C0", Offset = "0x5FCA2C0", VA = "0x185FCB4C0")]
	public static void MMMPONNIFEN(this IncrementalHash JHFKHJKILDH, ulong COJELFIGFDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5FCB1C0", Offset = "0x5FC9FC0", VA = "0x185FCB1C0")]
	public static void FOJMGGBLKDK(this IncrementalHash JHFKHJKILDH, uint GMOEBCGJONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5FCAF90", Offset = "0x5FC9D90", VA = "0x185FCAF90")]
	public static void BOFONIJMOCN(this IncrementalHash JHFKHJKILDH, ushort FBGEMPPFAGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5FCB390", Offset = "0x5FCA190", VA = "0x185FCB390")]
	public static void MDNIJKCFFCA(this IncrementalHash JHFKHJKILDH, Vector3 LMLABCFKOHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class ENINHPPLBFO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5FC9820", Offset = "0x5FC8620", VA = "0x185FC9820")]
	public ENINHPPLBFO(string EMKENBOOEOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public abstract class NDIJOCOBBJB<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	internal class CNPAEMHANFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public TNode CNFBJPGPBBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public TNode AJKCELPHOFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public BCIBCGNOJGI ACCBBJBNABI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public List<BCIBCGNOJGI> LFOEDHPEPBB;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public CNPAEMHANFD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	internal struct BCIBCGNOJGI : IComparable<BCIBCGNOJGI>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public int EHKNDMCNKBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public TClaimant JNACAFOHGJM;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xBA8D80", Offset = "0xBA7B80", VA = "0x180BA8D80")]
		public BCIBCGNOJGI(int EHKNDMCNKBA, TClaimant JNACAFOHGJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x4662890", Offset = "0x4661690", VA = "0x184662890")]
		public bool DGOCHDDPMNN([In] BCIBCGNOJGI FPEEGIOMOFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x46628F0", Offset = "0x46616F0", VA = "0x1846628F0")]
		public bool PBANJBBOEIK([In] BCIBCGNOJGI FPEEGIOMOFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x4662880", Offset = "0x4661680", VA = "0x184662880", Slot = "4")]
		public int CompareTo(BCIBCGNOJGI FPEEGIOMOFF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x4662900", Offset = "0x4661700", VA = "0x184662900", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public enum JGPPIONPBDE
	{
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class IMMEMJCCFFI : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
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
		public NDIJOCOBBJB<TClaimant, TNode> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x947C30", Offset = "0x946A30", VA = "0x180947C30")]
		[DebuggerHidden]
		public IMMEMJCCFFI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3875490", Offset = "0x3874290", VA = "0x183875490", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3875650", Offset = "0x3874450", VA = "0x183875650", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3875570", Offset = "0x3874370", VA = "0x183875570", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x34E6220", Offset = "0x34E5020", VA = "0x1834E6220", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static readonly HKOLBKHAPJN<CNPAEMHANFD> HHENHMFKAJK;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static readonly HKOLBKHAPJN<List<BCIBCGNOJGI>> BMLLMPKBEHM;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static int BHPLABHPOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	internal readonly Dictionary<TClaimant, TNode> EAJFLKAMOAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	internal readonly Dictionary<TNode, CNPAEMHANFD> EPCCBMFBPIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private JGPPIONPBDE EAPOADFKJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private bool FCGEEBKFDBI;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode KDGNHAPLGEO(TNode ACNLHBNEANJ);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void FJPKNKIHGBJ(TNode ACNLHBNEANJ, TClaimant JKDDLFENKFE, TClaimant DHJPOGOKKIK);

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x3E61520", Offset = "0x3E60320", VA = "0x183E61520")]
	public NDIJOCOBBJB(JGPPIONPBDE EAPOADFKJDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x3E611B0", Offset = "0x3E5FFB0", VA = "0x183E611B0")]
	public void LGHEHLNLCDP(TNode ACNLHBNEANJ, TNode PKMANOIKNOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3E61240", Offset = "0x3E60040", VA = "0x183E61240")]
	public void OFKNEJLCNFK(TClaimant JNACAFOHGJM, TNode FCHEIFMPCDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3E60490", Offset = "0x3E5F290", VA = "0x183E60490", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3E5FDE0", Offset = "0x3E5EBE0", VA = "0x183E5FDE0")]
	private void ALJJNJJNGJI(TClaimant JNACAFOHGJM, TNode ALHJHECFLCK, TNode FCHEIFMPCDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3E600E0", Offset = "0x3E5EEE0", VA = "0x183E600E0")]
	private int DEEJJKJIFDI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3E60150", Offset = "0x3E5EF50", VA = "0x183E60150")]
	private void DFILDOFMACP(TClaimant JNACAFOHGJM, TNode DELHINFNNMG, TNode CGCPLEANCCA, int BHEEIAAJJCH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3E60940", Offset = "0x3E5F740", VA = "0x183E60940")]
	private void HGIKAGGAELI(BCIBCGNOJGI GEBKOHLOIDA, CNPAEMHANFD ECIIMDOKNPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3E60660", Offset = "0x3E5F460", VA = "0x183E60660")]
	private void GFHGCHLDPGB(TClaimant JNACAFOHGJM, TNode DELHINFNNMG, TNode CGCPLEANCCA, int BHEEIAAJJCH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3E60D10", Offset = "0x3E5FB10", VA = "0x183E60D10")]
	private void IEJHPHBMCJO(BCIBCGNOJGI GEBKOHLOIDA, TNode ACNLHBNEANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3E5FE80", Offset = "0x3E5EC80", VA = "0x183E5FE80")]
	private void BGIPCAMKKMB(BCIBCGNOJGI GEBKOHLOIDA, CNPAEMHANFD ECIIMDOKNPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3E60E20", Offset = "0x3E5FC20", VA = "0x183E60E20")]
	private void JIHFMBIKLCB(CNPAEMHANFD ECIIMDOKNPG, bool POGCGOFCHAF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3E609D0", Offset = "0x3E5F7D0", VA = "0x183E609D0")]
	private void HJBNEMINHIH(CNPAEMHANFD ECIIMDOKNPG, TNode PKMANOIKNOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x3E5FD00", Offset = "0x3E5EB00", VA = "0x183E5FD00")]
	[IteratorStateMachine(typeof(NDIJOCOBBJB<, >.IMMEMJCCFFI))]
	private IEnumerable<TNode> AHJHAAFBJFG(TNode DELHINFNNMG, TNode CGCPLEANCCA, bool FEBEKPCDLME = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x3E60F50", Offset = "0x3E5FD50", VA = "0x183E60F50")]
	private CNPAEMHANFD KGFBOJPCPGL(TNode ACNLHBNEANJ, TNode AJKCELPHOFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3E61040", Offset = "0x3E5FE40", VA = "0x183E61040")]
	private CNPAEMHANFD LDONMCNPAIL(TNode ACNLHBNEANJ, TNode AJKCELPHOFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x3E5FF70", Offset = "0x3E5ED70", VA = "0x183E5FF70")]
	private void CBHFIJIEONH(CNPAEMHANFD ECIIMDOKNPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class KOHKHBGHCOK<T> : IEnumerable<KOHKHBGHCOK<T>.GHGFNDDLOPE>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct GHGFNDDLOPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public T NKKIECLCEML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int ENPOKNEMOMH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class FIPFCABAPNK : IEnumerator<GHGFNDDLOPE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private KOHKHBGHCOK<T> AIJEOLGHEDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private int ENPOKNEMOMH;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x3276A80", Offset = "0x3275880", VA = "0x183276A80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public GHGFNDDLOPE ODMJFPGIBHC
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x35D0C90", Offset = "0x35CFA90", VA = "0x1835D0C90", Slot = "4")]
			get
			{
				return default(GHGFNDDLOPE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x35D0BA0", Offset = "0x35CF9A0", VA = "0x1835D0BA0")]
		public FIPFCABAPNK(KOHKHBGHCOK<T> AIJEOLGHEDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x35D0AA0", Offset = "0x35CF8A0", VA = "0x1835D0AA0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x32C9240", Offset = "0x32C8040", VA = "0x1832C9240", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xC3CF10", Offset = "0xC3BD10", VA = "0x180C3CF10", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private struct KEMHCNGNONM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public bool OHNPOLADNDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public T NKKIECLCEML;
	}

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int CDFBJAGGFMJ = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly Dictionary<T, int> MALGLLCAAAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private KEMHCNGNONM[] NFABBJNJLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int LPPHLFHCPIJ;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int BJEBLMANCJI
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7E8AA0", Offset = "0x7E78A0", VA = "0x1807E8AA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7E85E0", Offset = "0x7E73E0", VA = "0x1807E85E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int DDMEKBICEFI
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x305C500", Offset = "0x305B300", VA = "0x18305C500")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x3B16AB0", Offset = "0x3B158B0", VA = "0x183B16AB0")]
	public KOHKHBGHCOK(int BKPALGGNBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x3B16310", Offset = "0x3B15110", VA = "0x183B16310")]
	public KOHKHBGHCOK(GHGFNDDLOPE[] GBAAAAIKLBF, bool BNGAFHDCOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3B155E0", Offset = "0x3B143E0", VA = "0x183B155E0")]
	public int BEDFGOHACBE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3B15860", Offset = "0x3B14660", VA = "0x183B15860")]
	private int CPJNFBHGMBC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x3B15BF0", Offset = "0x3B149F0", VA = "0x183B15BF0", Slot = "6")]
	protected virtual uint HDHCMELDNHC(uint JHFKHJKILDH, T NKKIECLCEML)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x3B15B70", Offset = "0x3B14970", VA = "0x183B15B70")]
	public bool HACPMGPHDFE(T NKKIECLCEML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x3B15AB0", Offset = "0x3B148B0", VA = "0x183B15AB0")]
	public int EIJFKNAJFCM(T NKKIECLCEML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x3B16220", Offset = "0x3B15020", VA = "0x183B16220")]
	public T OEPHGIMBBEI(int ENPOKNEMOMH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x3B15CC0", Offset = "0x3B14AC0", VA = "0x183B15CC0")]
	public bool OEADEOBEAEM(T NKKIECLCEML, bool OIOAMFFFJAP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x3B15FC0", Offset = "0x3B14DC0", VA = "0x183B15FC0")]
	public bool OEADEOBEAEM(T NKKIECLCEML, int ENPOKNEMOMH, bool OIOAMFFFJAP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x3B15C20", Offset = "0x3B14A20", VA = "0x183B15C20")]
	private int KDKMLEKGKPA(int BKOJFCPJPEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x3B16290", Offset = "0x3B15090", VA = "0x183B16290", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x3B16290", Offset = "0x3B15090", VA = "0x183B16290", Slot = "4")]
	private IEnumerator<GHGFNDDLOPE> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class HKOLBKHAPJN<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly Stack<T> IKNIJABMAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private readonly List<T> JGALIHENCPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly int GEMBEPLAKFL;

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x37A9080", Offset = "0x37A7E80", VA = "0x1837A9080")]
	public static HKOLBKHAPJN<T> OEKIBJMJEJH(int BKPALGGNBEN = 0, int GEMBEPLAKFL = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x37A8FA0", Offset = "0x37A7DA0", VA = "0x1837A8FA0")]
	public static HKOLBKHAPJN<T> LLELDEJKEIE(int BKPALGGNBEN = 0, int GEMBEPLAKFL = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x37A93B0", Offset = "0x37A81B0", VA = "0x1837A93B0")]
	public HKOLBKHAPJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x37A93E0", Offset = "0x37A81E0", VA = "0x1837A93E0")]
	public HKOLBKHAPJN(int BKPALGGNBEN, int GEMBEPLAKFL = int.MaxValue, bool LOFCNLFEBCK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x37A9160", Offset = "0x37A7F60", VA = "0x1837A9160")]
	public T PCNIIBFANEF()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x37A92E0", Offset = "0x37A80E0", VA = "0x1837A92E0")]
	public void PHNBJIDPAFI(T NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x37A8EC0", Offset = "0x37A7CC0", VA = "0x1837A8EC0")]
	private void IMPGOOHAMEO(T NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x37A8EA0", Offset = "0x37A7CA0", VA = "0x1837A8EA0")]
	private void EBFFBGMKOIL(T NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x37A8D60", Offset = "0x37A7B60", VA = "0x1837A8D60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x37A8B60", Offset = "0x37A7960", VA = "0x1837A8B60")]
	private void CJDCDMIMOLG(IEnumerable<T> NCNPEIAEPGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class DPOHJDGIEDC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private Dictionary<int, T> BNNBPKMEFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private T FLABHLJEMPA;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual T PNODHIFOMOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7A81C0", Offset = "0x7A6FC0", VA = "0x1807A81C0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x4F565B0", Offset = "0x4F553B0", VA = "0x184F565B0")]
	public bool FMOCGEPCGJE(T NKKIECLCEML, int EHKNDMCNKBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x3672960", Offset = "0x3671760", VA = "0x183672960")]
	public bool AJOKBCANKKO(int EHKNDMCNKBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x4F56160", Offset = "0x4F54F60", VA = "0x184F56160")]
	public T BBJKGDBOENK(int AMKMAHOJJMO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x4F56680", Offset = "0x4F55480", VA = "0x184F56680")]
	private bool OBFBMIGADME()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x4F56630", Offset = "0x4F55430", VA = "0x184F56630")]
	public bool GNMCOJGNPDP(int EHKNDMCNKBA, [Out] T NKKIECLCEML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x4F56830", Offset = "0x4F55630", VA = "0x184F56830")]
	public DPOHJDGIEDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class CFBPHLBPFEJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	protected struct OGDADHIHANH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public T DFPHMDCMPIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int OEBIAHOKLDL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	protected readonly List<OGDADHIHANH> HFOALDPPCOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private T GAIMIMKLLAH;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int DDMEKBICEFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x305C500", Offset = "0x305B300", VA = "0x18305C500")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x497CA00", Offset = "0x497B800", VA = "0x18497CA00")]
	public bool BOPPHNBAJLP(T NKKIECLCEML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x497C900", Offset = "0x497B700", VA = "0x18497C900")]
	public void ANMBPKAMKOK(T NKKIECLCEML, int EHKNDMCNKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x497CB80", Offset = "0x497B980", VA = "0x18497CB80")]
	public bool JJGPDDBMEBN(T NKKIECLCEML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x497C9A0", Offset = "0x497B7A0", VA = "0x18497C9A0")]
	public void BBGCGJHDDBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x497CCD0", Offset = "0x497BAD0", VA = "0x18497CCD0")]
	public T PNNDBECACCJ()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x497C7A0", Offset = "0x497B5A0", VA = "0x18497C7A0")]
	private void ANGAHDGBMBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x497CD50", Offset = "0x497BB50", VA = "0x18497CD50")]
	public CFBPHLBPFEJ()
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
		[AHOEPOHPCNC(ONGLIIBHLOO.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x5FCC690", Offset = "0x5FCB490", VA = "0x185FCC690")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x5FCC960", Offset = "0x5FCB760", VA = "0x185FCC960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x5FCC870", Offset = "0x5FCB670", VA = "0x185FCC870")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x5FCC5E0", Offset = "0x5FCB3E0", VA = "0x185FCC5E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x5FCC8B0", Offset = "0x5FCB6B0", VA = "0x185FCC8B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x5FCC7C0", Offset = "0x5FCB5C0", VA = "0x185FCC7C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x5FCC550", Offset = "0x5FCB350", VA = "0x185FCC550")]
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
		[Cpp2IlInjected.Address(RVA = "0x41E1760", Offset = "0x41E0560", VA = "0x1841E1760", Slot = "4")]
		public virtual T KDAJDKJAEHB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class MJMOIHAKNHP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly Dictionary<byte, AAIKOPFKNNC> KPJAEEKEPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly HKOLBKHAPJN<AAIKOPFKNNC> JIAOBKMCCNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly bool OCGOABEIHMK;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public AAIKOPFKNNC NIAJOFABGLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7A8210", Offset = "0x7A7010", VA = "0x1807A8210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public Vector2 MAMMGOFCBPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xB3F440", Offset = "0xB3E240", VA = "0x180B3F440")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xE3B780", Offset = "0xE3A580", VA = "0x180E3B780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private Vector2 PNEMFNNFLFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xE64300", Offset = "0xE63100", VA = "0x180E64300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public Vector2 OHFOIKEIFPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x5FCA390", Offset = "0x5FC9190", VA = "0x185FCA390")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x7AD150", Offset = "0x7ABF50", VA = "0x1807AD150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public int PGONCFGGOOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x7B49A0", Offset = "0x7B37A0", VA = "0x1807B49A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x7B45D0", Offset = "0x7B33D0", VA = "0x1807B45D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x5FCA760", Offset = "0x5FC9560", VA = "0x185FCA760")]
	public MJMOIHAKNHP(Bounds NAICAJCCGJF, Vector2[] AHCPELAGBAO, int FKGOIEHGCDM, byte BKOJFCPJPEL, float IKGHCFKHJPC = 0f, [Optional] HKOLBKHAPJN<AAIKOPFKNNC> JIAOBKMCCNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x5FC9C90", Offset = "0x5FC8A90", VA = "0x185FC9C90")]
	public AAIKOPFKNNC BFMBEEGEBMN(byte ENPOKNEMOMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5FCA2C0", Offset = "0x5FC90C0", VA = "0x185FCA2C0")]
	public void INDJDAHFAKD(Vector3 JCOIMLJCHFJ, float DAMNKPEKLHH, float GPBILIPLEPK, List<byte> OPDBMLPELFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3DE0", Offset = "0x5CC2BE0", VA = "0x185CC3DE0")]
	public void DGJAOIKJICE(AAIKOPFKNNC.OMJPGPLABBO DPFHGIPLKBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x5FC9F70", Offset = "0x5FC8D70", VA = "0x185FC9F70")]
	public static int FBPADPAPEOE(Vector2[] AHCPELAGBAO, int FKGOIEHGCDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x5FCA060", Offset = "0x5FC8E60", VA = "0x185FCA060")]
	private AAIKOPFKNNC FEBMJJHKBKN(byte ENPOKNEMOMH, AAIKOPFKNNC.HLHKBIPKPDI LOCGKMKAOPO, AAIKOPFKNNC AJKCELPHOFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x5FCA3B0", Offset = "0x5FC91B0", VA = "0x185FCA3B0")]
	private void NEFIGKEPMBH(AAIKOPFKNNC AJKCELPHOFC, Vector2[] AHCPELAGBAO, int DPONFHPHJIE, int OPFOLJKNOON, int ICHODJLNCBI, int DEMBDIGMDKG, float IKGHCFKHJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x5FC9CF0", Offset = "0x5FC8AF0", VA = "0x185FC9CF0")]
	private void CDIBBBCPDKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x5FC9F10", Offset = "0x5FC8D10", VA = "0x185FC9F10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x5FCA260", Offset = "0x5FC9060", VA = "0x185FCA260", Slot = "1")]
	~MJMOIHAKNHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class AAIKOPFKNNC
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public enum HLHKBIPKPDI
	{
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public enum OMJPGPLABBO
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
	public byte FFDOGOLOLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public Vector3 ONNDDMNILLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public Vector3 MLMGACONFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public Vector3 NJIBKILIPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public Vector3 HBPCBLDEIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public HLHKBIPKPDI JDEKEDOHPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public AAIKOPFKNNC DIOGANGKEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public List<AAIKOPFKNNC> PDKGJDFPHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public bool CCGOCDFGKJH;

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x5FC95B0", Offset = "0x5FC83B0", VA = "0x185FC95B0")]
	public AAIKOPFKNNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x5FC9490", Offset = "0x5FC8290", VA = "0x185FC9490")]
	public void POLLOHFPCNE(AAIKOPFKNNC BIFNKFCMILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
	public void DGJAOIKJICE(int EPBPNJJMEGI, OMJPGPLABBO DPFHGIPLKBH, int ODBAJNFEEBO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x5FC91D0", Offset = "0x5FC7FD0", VA = "0x185FC91D0")]
	public void INDJDAHFAKD(List<byte> OPDBMLPELFI, Vector3 JCOIMLJCHFJ, float DAMNKPEKLHH, float GPBILIPLEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5FC9460", Offset = "0x5FC8260", VA = "0x185FC9460")]
	public bool MHKHDLNMAFA(Vector3 MHCNCLONLOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x5FC9430", Offset = "0x5FC8230", VA = "0x185FC9430")]
	public bool JFNPMLEAOPB(Vector3 MHCNCLONLOI, float LHMGECJJHLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x5FC9140", Offset = "0x5FC7F40", VA = "0x185FC9140")]
	public void FCIFMHNEBDM()
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
		public struct OJOJPAKNOAO<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private readonly List<Component> FOKGGJDBEOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private readonly bool JJMJILOFKAD;

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x3B96140", Offset = "0x3B94F40", VA = "0x183B96140")]
			public OJOJPAKNOAO(List<Component> FOKGGJDBEOD, bool JJMJILOFKAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x3F78AF0", Offset = "0x3F778F0", VA = "0x183F78AF0")]
			public AIOPBMIKBFD<T> OOEEFIELKKG()
			{
				return default(AIOPBMIKBFD<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x3F78B60", Offset = "0x3F77960", VA = "0x183F78B60", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x3F78B60", Offset = "0x3F77960", VA = "0x183F78B60", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public struct AIOPBMIKBFD<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private readonly List<Component> FOKGGJDBEOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			private readonly bool JJMJILOFKAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			private int ENPOKNEMOMH;

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			public T ODMJFPGIBHC
			{
				[Cpp2IlInjected.Token(Token = "0x60001ED")]
				[Cpp2IlInjected.Address(RVA = "0x37261E0", Offset = "0x3724FE0", VA = "0x1837261E0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001EE")]
				[Cpp2IlInjected.Address(RVA = "0x3726170", Offset = "0x3724F70", VA = "0x183726170", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x37261B0", Offset = "0x3724FB0", VA = "0x1837261B0")]
			public AIOPBMIKBFD(List<Component> FOKGGJDBEOD, bool JJMJILOFKAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x37260B0", Offset = "0x3724EB0", VA = "0x1837260B0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x37260C0", Offset = "0x3724EC0", VA = "0x1837260C0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x32B9660", Offset = "0x32B8460", VA = "0x1832B9660", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x5FCDEE0", Offset = "0x5FCCCE0", VA = "0x185FCDEE0")]
		private void FCIFMHNEBDM(GameObject FEGJFGOAMKG, bool KCOHBBNEOFL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x5FCDD20", Offset = "0x5FCCB20", VA = "0x185FCDD20")]
		public static void FCIFMHNEBDM(GameObject FEGJFGOAMKG, ToolHierarchyCache FNFFBGBDPIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x29A82B0", Offset = "0x29A70B0", VA = "0x1829A82B0")]
		public void KMHJECJPNFG<T>(Action<T> ENHEBPDFNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x29A8240", Offset = "0x29A7040", VA = "0x1829A8240")]
		public T FJHJEKAKEDE<T>(bool JJMJILOFKAD = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x29A84D0", Offset = "0x29A72D0", VA = "0x1829A84D0")]
		public OJOJPAKNOAO<T> OPHKJLBONHH<T>(bool JJMJILOFKAD = false) where T : class
		{
			return default(OJOJPAKNOAO<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5FCE0C0", Offset = "0x5FCCEC0", VA = "0x185FCE0C0")]
		public List<Component> PDMLLBFJBMH(Type HFFNCGFKMBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x5FCDCA0", Offset = "0x5FCCAA0", VA = "0x185FCDCA0", Slot = "4")]
		public bool Equals(ToolHierarchyCache AHPBAINPGNA, ToolHierarchyCache KMGCEBLELOI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x5FCE050", Offset = "0x5FCCE50", VA = "0x185FCE050", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache NHLNHJGAONN)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class GCDFLDDIHLB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private int BKPALGGNBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int CEFFANDGHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private List<T> NKICLGBEJFP;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int DDMEKBICEFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x359E9F0", Offset = "0x359D7F0", VA = "0x18359E9F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public T HPALBOJMJAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3690820", Offset = "0x368F620", VA = "0x183690820")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public T AKOHLCJKCII
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3690A20", Offset = "0x368F820", VA = "0x183690A20")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public T IPMLJBHIOLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3690940", Offset = "0x368F740", VA = "0x183690940")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x3690BC0", Offset = "0x368F9C0", VA = "0x183690BC0")]
	public GCDFLDDIHLB(int BKPALGGNBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x3690540", Offset = "0x368F340", VA = "0x183690540")]
	public void ANMBPKAMKOK(T LKGGCAMPMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x3690730", Offset = "0x368F530", VA = "0x183690730")]
	public void BBGCGJHDDBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x3690A90", Offset = "0x368F890", VA = "0x183690A90")]
	public void MDJGJPIJPJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x3690B60", Offset = "0x368F960", VA = "0x183690B60")]
	public void PBNOKAKNJOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x3690530", Offset = "0x368F330", VA = "0x183690530")]
	public void AEIPKAPNHLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class LLMLGPPEOMI<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	private struct FJBIJGPLPFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public int OEBIAHOKLDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public T DFPHMDCMPIO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly Dictionary<object, FJBIJGPLPFN> BNNBPKMEFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly EqualityComparer<T> MCGNFDNBHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private T FLABHLJEMPA;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public virtual T PNODHIFOMOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xEFE710", Offset = "0xEFD510", VA = "0x180EFE710", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3C14960", Offset = "0x3C13760", VA = "0x183C14960", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool BLJNLKOKFAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3C136B0", Offset = "0x3C124B0", VA = "0x183C136B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public object MALNFLMKCGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x7A8190", Offset = "0x7A6F90", VA = "0x1807A8190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x3C13D10", Offset = "0x3C12B10", VA = "0x183C13D10")]
	public bool FMOCGEPCGJE(T NKKIECLCEML, object NBGOKNOECBH, int EHKNDMCNKBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x3C135A0", Offset = "0x3C123A0", VA = "0x183C135A0")]
	public bool AJOKBCANKKO(object NBGOKNOECBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x3C14690", Offset = "0x3C13490", VA = "0x183C14690")]
	public bool GNMCOJGNPDP(object NBGOKNOECBH, [Out] T NKKIECLCEML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x3C13630", Offset = "0x3C12430", VA = "0x183C13630")]
	public void BBGCGJHDDBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x3C168C0", Offset = "0x3C156C0", VA = "0x183C168C0")]
	private bool OBFBMIGADME()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x3C17360", Offset = "0x3C16160", VA = "0x183C17360")]
	public LLMLGPPEOMI()
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
