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
public class LNNJCNPEGJJ : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6F03E0", Offset = "0x6EF3E0", VA = "0x1806F03E0")]
	public LNNJCNPEGJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x513D900", Offset = "0x513C900", VA = "0x18513D900")]
	public byte[] BOCKNDPJDIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void DEBKFHJPHAG(IncrementalHash IGDKGBAJACK);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xD61E50", Offset = "0xD60E50", VA = "0x180D61E50")]
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
	[JGBLNAGDHNC]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	[JGBLNAGDHNC]
	[HideInInspector]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5141FD0", Offset = "0x5140FD0", VA = "0x185141FD0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5141F90", Offset = "0x5140F90", VA = "0x185141F90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5142010", Offset = "0x5141010", VA = "0x185142010")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5142220", Offset = "0x5141220", VA = "0x185142220")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5142190", Offset = "0x5141190", VA = "0x185142190")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x10C2E90", Offset = "0x10C1E90", VA = "0x1810C2E90")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1118620", Offset = "0x1117620", VA = "0x181118620")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5141F50", Offset = "0x5140F50", VA = "0x185141F50")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5142100", Offset = "0x5141100", VA = "0x185142100")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5141980", Offset = "0x5140980", VA = "0x185141980")]
	public void CopyBounds(SavedExtents INIEAOGGCLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5141EC0", Offset = "0x5140EC0", VA = "0x185141EC0")]
	public void SetLocalSpaceBounds(Bounds DNDDADBMMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8A3390", Offset = "0x8A2390", VA = "0x1808A3390")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5141DF0", Offset = "0x5140DF0", VA = "0x185141DF0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x51419B0", Offset = "0x51409B0", VA = "0x1851419B0")]
	private void DBHCAGLHHOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5141BC0", Offset = "0x5140BC0", VA = "0x185141BC0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x51413C0", Offset = "0x51403C0", VA = "0x1851413C0")]
	public static void CalculateLocalBoundsFor(GameObject EMHOKENKLPP, out Bounds DNDDADBMMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5141E00", Offset = "0x5140E00", VA = "0x185141E00")]
	private static void PMMLOJLDDNL(Bounds PEAHMNEGGIF, Color DEJNODGKJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5141EE0", Offset = "0x5140EE0", VA = "0x185141EE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x58C1D0", Offset = "0x58B1D0", VA = "0x18058C1D0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x58CEE0", Offset = "0x58BEE0", VA = "0x18058CEE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x58C4A0", Offset = "0x58B4A0", VA = "0x18058C4A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80", Slot = "4")]
	public virtual void IDECCHEBLFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1E42690", Offset = "0x1E41690", VA = "0x181E42690")]
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
	[LNNJCNPEGJJ]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x29F6E00", Offset = "0x29F5E00", VA = "0x1829F6E00", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x29F6940", Offset = "0x29F5940", VA = "0x1829F6940", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x29F7400", Offset = "0x29F6400", VA = "0x1829F7400")]
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
	private sealed class BBALAFINKAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1E42690", Offset = "0x1E41690", VA = "0x181E42690")]
		public BBALAFINKAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4269DF0", Offset = "0x4268DF0", VA = "0x184269DF0")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[LNNJCNPEGJJ]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x58C1D0", Offset = "0x58B1D0", VA = "0x18058C1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4272370", Offset = "0x4271370", VA = "0x184272370", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x42723A0", Offset = "0x42713A0", VA = "0x1842723A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x42722C0", Offset = "0x42712C0", VA = "0x1842722C0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public TVal this[TKey DDFHJDPPNBF]
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x42722F0", Offset = "0x42712F0", VA = "0x1842722F0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x42721C0", Offset = "0x42711C0", VA = "0x1842721C0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4271A20", Offset = "0x4270A20", VA = "0x184271A20", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4271390", Offset = "0x4270390", VA = "0x184271390", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4270FC0", Offset = "0x426FFC0", VA = "0x184270FC0", Slot = "14")]
	protected virtual string KCBDJLLFDGE(TKeyVal KAGKBHHHCNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3185820", Offset = "0x3184820", VA = "0x183185820", Slot = "4")]
	public bool ContainsKey(TKey DDFHJDPPNBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x42720B0", Offset = "0x42710B0", VA = "0x1842720B0", Slot = "5")]
	public bool TryGetValue(TKey DDFHJDPPNBF, out TVal BMNJAHFFOPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4270F00", Offset = "0x426FF00", VA = "0x184270F00", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4270F00", Offset = "0x426FF00", VA = "0x184270F00", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x42720E0", Offset = "0x42710E0", VA = "0x1842720E0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class LHPKNDCOGEC<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class LMJEDNEEHME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1E42690", Offset = "0x1E41690", VA = "0x181E42690")]
		public LMJEDNEEHME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x31964F0", Offset = "0x31954F0", VA = "0x1831964F0")]
		internal bool <GetSamples>b__0(global::DOMIHEFCIHI<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly float BNBNJMJNBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly float CMCKOBLBJCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private List<global::DOMIHEFCIHI<float, T>> HKDEDCFLNPM;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int CBMMLNCHABB
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3195B30", Offset = "0x3194B30", VA = "0x183195B30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x31963D0", Offset = "0x31953D0", VA = "0x1831963D0")]
	public LHPKNDCOGEC(float HLMCBGEHPHA, float DAFBKLNJENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x31959D0", Offset = "0x31949D0", VA = "0x1831959D0")]
	public bool CILBIBPFHCM(float PDOMAMACOOB, T BMNJAHFFOPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3195CF0", Offset = "0x3194CF0", VA = "0x183195CF0")]
	public int NDJLPDBJPNP(float PDOMAMACOOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3195D50", Offset = "0x3194D50", VA = "0x183195D50")]
	public IEnumerable<T> OIPNGOPFBDM(float PDOMAMACOOB, [Optional] float? MNOMIPLEJEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3195840", Offset = "0x3194840", VA = "0x183195840")]
	public void BFHLNDADIAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3195C30", Offset = "0x3194C30", VA = "0x183195C30")]
	private void JOEIHNPDHNL(float PDOMAMACOOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class NHBFBKAHCFO<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct DHAEPAJBKDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public T MHLLNAFLMHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float JPIKPEGDJEF;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static float IGGBFCFINJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private List<T> ONMEMMJEIPC;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private const int JMAIGBOOECK = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private DHAEPAJBKDB[] PEGJLEIKJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int NLACGOAAIBK;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float DLMECCPBCJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xFC5370", Offset = "0xFC4370", VA = "0x180FC5370")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xFC53A0", Offset = "0xFC43A0", VA = "0x180FC53A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3832100", Offset = "0x3831100", VA = "0x183832100")]
	public NHBFBKAHCFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3832130", Offset = "0x3831130", VA = "0x183832130")]
	public NHBFBKAHCFO(int MAAFLBOPOCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3831E00", Offset = "0x3830E00", VA = "0x183831E00")]
	public void NJFAMEHLCGO(float PDOMAMACOOB, T BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3831160", Offset = "0x3830160", VA = "0x183831160")]
	public void BFHLNDADIAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3830FA0", Offset = "0x382FFA0", VA = "0x183830FA0")]
	public bool ALNJLNBFKGE(float JHGLGHMPFBB, float FBLFPCNGAAH, out T BMNJAHFFOPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x38316F0", Offset = "0x38306F0", VA = "0x1838316F0")]
	public bool DPKHMICNNBD(float JHGLGHMPFBB, float FBLFPCNGAAH, out T BMNJAHFFOPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3831A10", Offset = "0x3830A10", VA = "0x183831A10")]
	public void LGHPIGFIANI(float JHGLGHMPFBB, float FBLFPCNGAAH, List<T> EHKCNAODFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3832080", Offset = "0x3831080", VA = "0x183832080")]
	private int NKGCOLMJFGN(int GBIHIBNPLGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3831550", Offset = "0x3830550", VA = "0x183831550")]
	private void DENIGJBPBIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T PMNHPFCAPBA();

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T NAMGIDFMJNI(T AFNKBCIFFBF, T DICKNDOEJLF, float FNGOFIALAJH);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T BCIMAKHFEMP(T BMNJAHFFOPC, float FNGOFIALAJH);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T NOAHAAKDIGI(T AFNKBCIFFBF, T DICKNDOEJLF);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T GNIIAFLHMJA(T AFNKBCIFFBF, T DICKNDOEJLF);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class GDAOMLMFFOH : global::NHBFBKAHCFO<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x513CBD0", Offset = "0x513BBD0", VA = "0x18513CBD0", Slot = "4")]
	protected override Vector3 PMNHPFCAPBA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x513CA60", Offset = "0x513BA60", VA = "0x18513CA60", Slot = "5")]
	protected override Vector3 NAMGIDFMJNI(Vector3 AFNKBCIFFBF, Vector3 DICKNDOEJLF, float FNGOFIALAJH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x513C950", Offset = "0x513B950", VA = "0x18513C950", Slot = "6")]
	protected override Vector3 BCIMAKHFEMP(Vector3 BMNJAHFFOPC, float FNGOFIALAJH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x513CB20", Offset = "0x513BB20", VA = "0x18513CB20", Slot = "7")]
	protected override Vector3 NOAHAAKDIGI(Vector3 AFNKBCIFFBF, Vector3 DICKNDOEJLF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x513C9F0", Offset = "0x513B9F0", VA = "0x18513C9F0", Slot = "8")]
	protected override Vector3 GNIIAFLHMJA(Vector3 AFNKBCIFFBF, Vector3 DICKNDOEJLF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x513CC40", Offset = "0x513BC40", VA = "0x18513CC40")]
	public GDAOMLMFFOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class INEAAEEDOLJ : global::NHBFBKAHCFO<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x513DAE0", Offset = "0x513CAE0", VA = "0x18513DAE0")]
	public INEAAEEDOLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x513DA70", Offset = "0x513CA70", VA = "0x18513DA70")]
	public INEAAEEDOLJ(int MAAFLBOPOCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0xED1A70", Offset = "0xED0A70", VA = "0x180ED1A70", Slot = "4")]
	protected override float PMNHPFCAPBA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x513D9F0", Offset = "0x513C9F0", VA = "0x18513D9F0", Slot = "5")]
	protected override float NAMGIDFMJNI(float AFNKBCIFFBF, float DICKNDOEJLF, float FNGOFIALAJH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4103770", Offset = "0x4102770", VA = "0x184103770", Slot = "6")]
	protected override float BCIMAKHFEMP(float BMNJAHFFOPC, float FNGOFIALAJH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x26F90B0", Offset = "0x26F80B0", VA = "0x1826F90B0", Slot = "7")]
	protected override float NOAHAAKDIGI(float AFNKBCIFFBF, float DICKNDOEJLF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x513D9E0", Offset = "0x513C9E0", VA = "0x18513D9E0", Slot = "8")]
	protected override float GNIIAFLHMJA(float AFNKBCIFFBF, float DICKNDOEJLF)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class ANBNLFOMJAP
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1FC5160", Offset = "0x1FC4160", VA = "0x181FC5160")]
	public static global::KNGLOHNPHAP<T1> GJHMDGALCIL<T1>(T1 FLGHECGJCOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x25F7AF0", Offset = "0x25F6AF0", VA = "0x1825F7AF0")]
	public static global::DOMIHEFCIHI<T1, T2> GJHMDGALCIL<T1, T2>(T1 FLGHECGJCOK, T2 HACIALBPMPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x227B5B0", Offset = "0x227A5B0", VA = "0x18227B5B0")]
	public static global::LGFKEKFKAJJ<T1, T2, T3> GJHMDGALCIL<T1, T2, T3>(T1 FLGHECGJCOK, T2 HACIALBPMPB, T3 ENOMMAADJEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1D75ED0", Offset = "0x1D74ED0", VA = "0x181D75ED0")]
	public static global::OKOGIIFGCHF<T1, T2, T3, T4> GJHMDGALCIL<T1, T2, T3, T4>(T1 FLGHECGJCOK, T2 HACIALBPMPB, T3 ENOMMAADJEF, T4 DCIMBONLHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x227B7D0", Offset = "0x227A7D0", VA = "0x18227B7D0")]
	public static global::PFAJNLJNGFH<T1, T2, T3, T4, T5> GJHMDGALCIL<T1, T2, T3, T4, T5>(T1 FLGHECGJCOK, T2 HACIALBPMPB, T3 ENOMMAADJEF, T4 DCIMBONLHDC, T5 FLFGGFAKFNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x25F7B60", Offset = "0x25F6B60", VA = "0x1825F7B60")]
	public static global::AHABMGFINBB<T1, T2, T3, T4, T5, T6> GJHMDGALCIL<T1, T2, T3, T4, T5, T6>(T1 FLGHECGJCOK, T2 HACIALBPMPB, T3 ENOMMAADJEF, T4 DCIMBONLHDC, T5 FLFGGFAKFNL, T6 IEEAHMAFAIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x227B710", Offset = "0x227A710", VA = "0x18227B710")]
	public static global::IKPMKFELIPP<T1, T2, T3, T4, T5, T6, T7> GJHMDGALCIL<T1, T2, T3, T4, T5, T6, T7>(T1 FLGHECGJCOK, T2 HACIALBPMPB, T3 ENOMMAADJEF, T4 DCIMBONLHDC, T5 FLFGGFAKFNL, T6 IEEAHMAFAIC, T7 LEEFOKBIPLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x227B640", Offset = "0x227A640", VA = "0x18227B640")]
	public static global::LMKCCNEPGGH<T1, T2, T3, T4, T5, T6, T7, T8> GJHMDGALCIL<T1, T2, T3, T4, T5, T6, T7, T8>(T1 FLGHECGJCOK, T2 HACIALBPMPB, T3 ENOMMAADJEF, T4 DCIMBONLHDC, T5 FLFGGFAKFNL, T6 IEEAHMAFAIC, T7 LEEFOKBIPLO, T8 AOCHONMNPMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1B5AC10", Offset = "0x1B59C10", VA = "0x181B5AC10")]
	[IteratorStateMachine(typeof(BANPOCKPPMI))]
	public static IEnumerable<global::DOMIHEFCIHI<T1, T2>> GEDPCJGLCPM<T1, T2>(IEnumerable<T1> JAELLKEBFMM, IEnumerable<T2> PEAHMNEGGIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1B5D750", Offset = "0x1B5C750", VA = "0x181B5D750")]
	[IteratorStateMachine(typeof(CLFFMJAMMED))]
	public static IEnumerable<global::LGFKEKFKAJJ<T1, T2, T3>> GEDPCJGLCPM<T1, T2, T3>(IEnumerable<T1> JAELLKEBFMM, IEnumerable<T2> PEAHMNEGGIF, IEnumerable<T3> DEJNODGKJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x27B5C70", Offset = "0x27B4C70", VA = "0x1827B5C70")]
	internal static int CKFOCGFDGAA(int JBKAMDPIPOD, int CINBMJMFKDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3DF69A0", Offset = "0x3DF59A0", VA = "0x183DF69A0")]
	internal static int CKFOCGFDGAA(int JBKAMDPIPOD, int CINBMJMFKDM, int NMPBFJJNJON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3DF69B0", Offset = "0x3DF59B0", VA = "0x183DF69B0")]
	internal static int CKFOCGFDGAA(int JBKAMDPIPOD, int CINBMJMFKDM, int NMPBFJJNJON, int ENLBPMGLMEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x513AF40", Offset = "0x5139F40", VA = "0x18513AF40")]
	internal static int CKFOCGFDGAA(int JBKAMDPIPOD, int CINBMJMFKDM, int NMPBFJJNJON, int ENLBPMGLMEK, int KGKHIACMKKK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x513AF60", Offset = "0x5139F60", VA = "0x18513AF60")]
	internal static int CKFOCGFDGAA(int JBKAMDPIPOD, int CINBMJMFKDM, int NMPBFJJNJON, int ENLBPMGLMEK, int KGKHIACMKKK, int MMJIPLFNKON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x513AF80", Offset = "0x5139F80", VA = "0x18513AF80")]
	internal static int CKFOCGFDGAA(int JBKAMDPIPOD, int CINBMJMFKDM, int NMPBFJJNJON, int ENLBPMGLMEK, int KGKHIACMKKK, int MMJIPLFNKON, int FKEKJFFHFPB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x513AFB0", Offset = "0x5139FB0", VA = "0x18513AFB0")]
	internal static int CKFOCGFDGAA(int JBKAMDPIPOD, int CINBMJMFKDM, int NMPBFJJNJON, int ENLBPMGLMEK, int KGKHIACMKKK, int MMJIPLFNKON, int FKEKJFFHFPB, int OACOCGPABDP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class KNGLOHNPHAP<T1> : IComparable<global::KNGLOHNPHAP<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T1 HBCGEJFDAMH;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x214B810", Offset = "0x214A810", VA = "0x18214B810")]
	public KNGLOHNPHAP(T1 FLGHECGJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3219E70", Offset = "0x3218E70", VA = "0x183219E70", Slot = "4")]
	public int CompareTo(global::KNGLOHNPHAP<T1> INIEAOGGCLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3219EE0", Offset = "0x3218EE0", VA = "0x183219EE0", Slot = "0")]
	public override bool Equals(object INIEAOGGCLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x895E50", Offset = "0x894E50", VA = "0x180895E50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3219F80", Offset = "0x3218F80", VA = "0x183219F80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class DOMIHEFCIHI<T1, T2> : IComparable<global::DOMIHEFCIHI<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T1 HBCGEJFDAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T2 PDKNDJMCNHD;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x351E590", Offset = "0x351D590", VA = "0x18351E590")]
	public DOMIHEFCIHI(T1 FLGHECGJCOK, T2 HACIALBPMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x351C9F0", Offset = "0x351B9F0", VA = "0x18351C9F0", Slot = "4")]
	public int CompareTo(global::DOMIHEFCIHI<T1, T2> INIEAOGGCLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x351D0E0", Offset = "0x351C0E0", VA = "0x18351D0E0", Slot = "0")]
	public override bool Equals(object INIEAOGGCLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x351D6C0", Offset = "0x351C6C0", VA = "0x18351D6C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x351E080", Offset = "0x351D080", VA = "0x18351E080", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class LGFKEKFKAJJ<T1, T2, T3> : IComparable<global::LGFKEKFKAJJ<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 HBCGEJFDAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 PDKNDJMCNHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T3 KPLOIBPDABH;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3193790", Offset = "0x3192790", VA = "0x183193790")]
	public LGFKEKFKAJJ(T1 FLGHECGJCOK, T2 HACIALBPMPB, T3 ENOMMAADJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3192FB0", Offset = "0x3191FB0", VA = "0x183192FB0", Slot = "4")]
	public int CompareTo(global::LGFKEKFKAJJ<T1, T2, T3> INIEAOGGCLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x31932A0", Offset = "0x31922A0", VA = "0x1831932A0", Slot = "0")]
	public override bool Equals(object INIEAOGGCLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3193410", Offset = "0x3192410", VA = "0x183193410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3193510", Offset = "0x3192510", VA = "0x183193510", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class OKOGIIFGCHF<T1, T2, T3, T4> : IComparable<global::OKOGIIFGCHF<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T1 HBCGEJFDAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T2 PDKNDJMCNHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T3 KPLOIBPDABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T4 EMAAEEJFNPF;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3429360", Offset = "0x3428360", VA = "0x183429360")]
	public OKOGIIFGCHF(T1 FLGHECGJCOK, T2 HACIALBPMPB, T3 ENOMMAADJEF, T4 DCIMBONLHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x458A0A0", Offset = "0x45890A0", VA = "0x18458A0A0", Slot = "4")]
	public int CompareTo(global::OKOGIIFGCHF<T1, T2, T3, T4> INIEAOGGCLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x458A1E0", Offset = "0x45891E0", VA = "0x18458A1E0", Slot = "0")]
	public override bool Equals(object INIEAOGGCLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x458A300", Offset = "0x4589300", VA = "0x18458A300", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x458A3C0", Offset = "0x45893C0", VA = "0x18458A3C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class PFAJNLJNGFH<T1, T2, T3, T4, T5> : IComparable<global::PFAJNLJNGFH<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T1 HBCGEJFDAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T2 PDKNDJMCNHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T3 KPLOIBPDABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T4 EMAAEEJFNPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T5 EMOFBHOMMLK;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x398A0B0", Offset = "0x39890B0", VA = "0x18398A0B0")]
	public PFAJNLJNGFH(T1 FLGHECGJCOK, T2 HACIALBPMPB, T3 ENOMMAADJEF, T4 DCIMBONLHDC, T5 FLFGGFAKFNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3989BC0", Offset = "0x3988BC0", VA = "0x183989BC0", Slot = "4")]
	public int CompareTo(global::PFAJNLJNGFH<T1, T2, T3, T4, T5> INIEAOGGCLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3989D40", Offset = "0x3988D40", VA = "0x183989D40", Slot = "0")]
	public override bool Equals(object INIEAOGGCLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3989E80", Offset = "0x3988E80", VA = "0x183989E80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3989F80", Offset = "0x3988F80", VA = "0x183989F80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class AHABMGFINBB<T1, T2, T3, T4, T5, T6> : IComparable<global::AHABMGFINBB<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T1 HBCGEJFDAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T2 PDKNDJMCNHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T3 KPLOIBPDABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T4 EMAAEEJFNPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T5 EMOFBHOMMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T6 IFKKIPNLJCB;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x366C550", Offset = "0x366B550", VA = "0x18366C550")]
	public AHABMGFINBB(T1 FLGHECGJCOK, T2 HACIALBPMPB, T3 ENOMMAADJEF, T4 DCIMBONLHDC, T5 FLFGGFAKFNL, T6 IEEAHMAFAIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x366BFB0", Offset = "0x366AFB0", VA = "0x18366BFB0", Slot = "4")]
	public int CompareTo(global::AHABMGFINBB<T1, T2, T3, T4, T5, T6> INIEAOGGCLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x366C170", Offset = "0x366B170", VA = "0x18366C170", Slot = "0")]
	public override bool Equals(object INIEAOGGCLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x366C2E0", Offset = "0x366B2E0", VA = "0x18366C2E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x366C400", Offset = "0x366B400", VA = "0x18366C400", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class IKPMKFELIPP<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::IKPMKFELIPP<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T1 HBCGEJFDAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T2 PDKNDJMCNHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T3 KPLOIBPDABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T4 EMAAEEJFNPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T5 EMOFBHOMMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T6 IFKKIPNLJCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T7 JKHFBMNPHAG;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3BE5E10", Offset = "0x3BE4E10", VA = "0x183BE5E10")]
	public IKPMKFELIPP(T1 FLGHECGJCOK, T2 HACIALBPMPB, T3 ENOMMAADJEF, T4 DCIMBONLHDC, T5 FLFGGFAKFNL, T6 IEEAHMAFAIC, T7 LEEFOKBIPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3BE57B0", Offset = "0x3BE47B0", VA = "0x183BE57B0", Slot = "4")]
	public int CompareTo(global::IKPMKFELIPP<T1, T2, T3, T4, T5, T6, T7> INIEAOGGCLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3BE59B0", Offset = "0x3BE49B0", VA = "0x183BE59B0", Slot = "0")]
	public override bool Equals(object INIEAOGGCLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3BE5B50", Offset = "0x3BE4B50", VA = "0x183BE5B50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3BE5CA0", Offset = "0x3BE4CA0", VA = "0x183BE5CA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class LMKCCNEPGGH<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::LMKCCNEPGGH<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T1 HBCGEJFDAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T2 PDKNDJMCNHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T3 KPLOIBPDABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T4 EMAAEEJFNPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T5 EMOFBHOMMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T6 IFKKIPNLJCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T7 JKHFBMNPHAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T8 FNJEIPIICAO;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x27F1C40", Offset = "0x27F0C40", VA = "0x1827F1C40")]
	public LMKCCNEPGGH(T1 FLGHECGJCOK, T2 HACIALBPMPB, T3 ENOMMAADJEF, T4 DCIMBONLHDC, T5 FLFGGFAKFNL, T6 IEEAHMAFAIC, T7 LEEFOKBIPLO, T8 AOCHONMNPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x27F1530", Offset = "0x27F0530", VA = "0x1827F1530", Slot = "4")]
	public int CompareTo(global::LMKCCNEPGGH<T1, T2, T3, T4, T5, T6, T7, T8> INIEAOGGCLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x27F1780", Offset = "0x27F0780", VA = "0x1827F1780", Slot = "0")]
	public override bool Equals(object INIEAOGGCLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x27F1940", Offset = "0x27F0940", VA = "0x1827F1940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x27F1AB0", Offset = "0x27F0AB0", VA = "0x1827F1AB0", Slot = "3")]
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
	public T MHLLNAFLMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5B4A30", Offset = "0x5B3A30", VA = "0x1805B4A30")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6C4580", Offset = "0x6C3580", VA = "0x1806C4580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float CLKIJMKMNIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x112A8E0", Offset = "0x11298E0", VA = "0x18112A8E0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x46857D0", Offset = "0x46847D0", VA = "0x1846857D0")]
	public T OBBBHMMDHHI(float FNGOFIALAJH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x46856C0", Offset = "0x46846C0", VA = "0x1846856C0")]
	public T GGMHICDIDPE(float FNGOFIALAJH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T NAMGIDFMJNI(T AFNKBCIFFBF, T DICKNDOEJLF, float FNGOFIALAJH);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1E42690", Offset = "0x1E41690", VA = "0x181E42690")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x513C890", Offset = "0x513B890", VA = "0x18513C890", Slot = "4")]
	protected override float NAMGIDFMJNI(float AFNKBCIFFBF, float DICKNDOEJLF, float FNGOFIALAJH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x513C910", Offset = "0x513B910", VA = "0x18513C910")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5143180", Offset = "0x5142180", VA = "0x185143180", Slot = "4")]
	protected override Vector3 NAMGIDFMJNI(Vector3 AFNKBCIFFBF, Vector3 DICKNDOEJLF, float FNGOFIALAJH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5143240", Offset = "0x5142240", VA = "0x185143240")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x513BC00", Offset = "0x513AC00", VA = "0x18513BC00", Slot = "4")]
	protected override Color NAMGIDFMJNI(Color AFNKBCIFFBF, Color DICKNDOEJLF, float FNGOFIALAJH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x513BC50", Offset = "0x513AC50", VA = "0x18513BC50")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class POLBBCKCMKJ : global::AHMDJHJCKHB<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5140A90", Offset = "0x513FA90", VA = "0x185140A90")]
	public POLBBCKCMKJ(int EHCFCNDLJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5140A30", Offset = "0x513FA30", VA = "0x185140A30")]
	public POLBBCKCMKJ(AJEGMAGJFAG[] OKOODMJEAFH, bool IEOJHOHBDJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x51409C0", Offset = "0x513F9C0", VA = "0x1851409C0", Slot = "6")]
	protected override uint KFPKMHNLICI(uint IGDKGBAJACK, string BMNJAHFFOPC)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class HFMNPMEBBEG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly IDisposable LOBJDNDFAIF;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public HFMNPMEBBEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DebuggerTypeProxy(typeof(global::MCDOBGDOCIF<>.BCFFINLCHKL))]
[DefaultMember("Item")]
public sealed class MCDOBGDOCIF<T> : IDisposable, global::AMJDJHKCIIE<T>, AFJIEGAGOJN, global::OFPJFGPODLE<T, global::MCDOBGDOCIF<T>.CFHENBICAGF>, global::PAMNFOFDGOB<T>, global::EKFKGIDGDDN<T, global::MCDOBGDOCIF<T>.CFHENBICAGF>, global::BECOCOIOBCI<T>, global::FKNAIBBLFKB<T, global::MCDOBGDOCIF<T>.CFHENBICAGF>, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public struct CFHENBICAGF : AFJIEGAGOJN, global::GFOBABIABNO<T>, global::ONNEBBFBHJH<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly global::MCDOBGDOCIF<T> HJHCBAHBHJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private int EBNLGNCPLBK;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int AGNENIFEHDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x1E497A0", Offset = "0x1E487A0", VA = "0x181E497A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public T LBMKEDIKANE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x27E0440", Offset = "0x27DF440", VA = "0x1827E0440", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private T HDBPMDHJJCL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x27DFEC0", Offset = "0x27DEEC0", VA = "0x1827DFEC0", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x27DFFE0", Offset = "0x27DEFE0", VA = "0x1827DFFE0", Slot = "7")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x27E02E0", Offset = "0x27DF2E0", VA = "0x1827E02E0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2094760", Offset = "0x2093760", VA = "0x182094760")]
		private CFHENBICAGF(global::MCDOBGDOCIF<T> LDOMHDGLEOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2094580", Offset = "0x2093580", VA = "0x182094580")]
		public static CFHENBICAGF PFJGPKGHGPI(global::MCDOBGDOCIF<T> LDOMHDGLEOC)
		{
			return default(CFHENBICAGF);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2094420", Offset = "0x2093420", VA = "0x182094420", Slot = "9")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x20945E0", Offset = "0x20935E0", VA = "0x1820945E0", Slot = "11")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80", Slot = "8")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class BCFFINLCHKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly global::MCDOBGDOCIF<T> HJHCBAHBHJI;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public int AGNENIFEHDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1E42C60", Offset = "0x1E41C60", VA = "0x181E42C60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T[] JNAOCBNNDLB
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x27DFE00", Offset = "0x27DEE00", VA = "0x1827DFE00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool JHAIFDBLLML
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x27DFD40", Offset = "0x27DED40", VA = "0x1827DFD40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x214B810", Offset = "0x214A810", VA = "0x18214B810")]
		public BCFFINLCHKL(global::MCDOBGDOCIF<T> LDOMHDGLEOC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly IHHDENOEDED AFEKCHCBBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private T[] OABMNGPOEHD;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int AGNENIFEHDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x58CCD0", Offset = "0x58BCD0", VA = "0x18058CCD0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x60DA10", Offset = "0x60CA10", VA = "0x18060DA10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Span<T> JNAOCBNNDLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x209C270", Offset = "0x209B270", VA = "0x18209C270")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public T OJBKIBFADNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x209C4B0", Offset = "0x209B4B0", VA = "0x18209C4B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public T KDGJMBOFPHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x209C4B0", Offset = "0x209B4B0", VA = "0x18209C4B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public T HLNIIBDGPEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x209B4F0", Offset = "0x209A4F0", VA = "0x18209B4F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x209E1F0", Offset = "0x209D1F0", VA = "0x18209E1F0")]
	public static global::MCDOBGDOCIF<T> PFJGPKGHGPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x209CC80", Offset = "0x209BC80", VA = "0x18209CC80")]
	public static global::MCDOBGDOCIF<T> FFOBKGJOFLA(int EHCFCNDLJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x209E8B0", Offset = "0x209D8B0", VA = "0x18209E8B0")]
	internal MCDOBGDOCIF(T[] LEMLHMGFBHB, int NGOMPCKMIBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x209C400", Offset = "0x209B400", VA = "0x18209C400", Slot = "5")]
	public T DLCONIPBGNI(int BHFIJCEBIFE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x209C430", Offset = "0x209B430", VA = "0x18209C430", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x209D130", Offset = "0x209C130", VA = "0x18209D130")]
	public void NJFAMEHLCGO(in T BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x209C620", Offset = "0x209B620", VA = "0x18209C620")]
	public void FAIPNHJAJID(int FBOCJCCNMND, in T BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x209CF80", Offset = "0x209BF80", VA = "0x18209CF80")]
	public void KBEFPINOHPL(int FBOCJCCNMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x209D720", Offset = "0x209C720", VA = "0x18209D720")]
	public void NLFBIMNHLHM(int MAAFLBOPOCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x209CDC0", Offset = "0x209BDC0", VA = "0x18209CDC0")]
	private void GOHJEEPCGFA(int EHCFCNDLJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x209ABA0", Offset = "0x2099BA0", VA = "0x18209ABA0")]
	public void BFHLNDADIAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x209AD70", Offset = "0x2099D70", VA = "0x18209AD70")]
	public global::MCDOBGDOCIF<T> CDOFLFMOHFM(global::AHDCJLCFDKN<T, T> LBJOIJFGLCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x209CF40", Offset = "0x209BF40", VA = "0x18209CF40", Slot = "11")]
	public CFHENBICAGF GetEnumerator()
	{
		return default(CFHENBICAGF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x209CC00", Offset = "0x209BC00", VA = "0x18209CC00", Slot = "8")]
	private global::GFOBABIABNO<T> LFNGLJAHNEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x209CC00", Offset = "0x209BC00", VA = "0x18209CC00", Slot = "10")]
	private global::ONNEBBFBHJH<T> FENPIIAEPEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x209CC00", Offset = "0x209BC00", VA = "0x18209CC00", Slot = "12")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x209CC00", Offset = "0x209BC00", VA = "0x18209CC00", Slot = "13")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class EKJNHECEODA
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x25D7E10", Offset = "0x25D6E10", VA = "0x1825D7E10")]
	public static bool ELMDNLAPNLH<T>(this global::MCDOBGDOCIF<T> LDOMHDGLEOC, in T BMNJAHFFOPC) where T : global::IFIOBPICNCP<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct CILPHEPGKFC
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class PMPHPGHFFJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public TaskCompletionSource<PKCLOEDHIOM> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public PMPHPGHFFJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5140970", Offset = "0x513F970", VA = "0x185140970")]
		internal void <StartRequest>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<PKCLOEDHIOM>> LBCICNGMJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private int KNKECMAKGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int CGFPBHMDCOJ;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x9996E0", Offset = "0x9986E0", VA = "0x1809996E0")]
	private CILPHEPGKFC(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<PKCLOEDHIOM>> OOCOIMKMDJA, int GBBPAEGAJJH, int DEFBCFDDMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x513BB80", Offset = "0x513AB80", VA = "0x18513BB80")]
	public static CILPHEPGKFC PFJGPKGHGPI()
	{
		return default(CILPHEPGKFC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x513B830", Offset = "0x513A830", VA = "0x18513B830")]
	public (int, int, Task) ODMCCODHPLC(int IFLPJKFKLOO, [Optional] CancellationToken DBKPHPKFAOL)
	{
		return default((int, int, Task));
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x513B780", Offset = "0x513A780", VA = "0x18513B780")]
	public void LICDGDICHIF(int IFLPJKFKLOO, int DEFBCFDDMOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class EEOFPGEFIDG<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly Dictionary<TKey, TVal> CPLFHFIJKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly Dictionary<TVal, TKey> KILILCFCJAA;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int AGNENIFEHDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x1E42C60", Offset = "0x1E41C60", VA = "0x181E42C60", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool HBFNBGIFOHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x58CEC0", Offset = "0x58BEC0", VA = "0x18058CEC0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public ICollection<TKey> BCLGOBIPCIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x29E3480", Offset = "0x29E2480", VA = "0x1829E3480", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public ICollection<TVal> NBLKMHLHKBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2ED7C00", Offset = "0x2ED6C00", VA = "0x182ED7C00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public TVal HLNIIBDGPEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x21EBC70", Offset = "0x21EAC70", VA = "0x1821EBC70", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x214A270", Offset = "0x2149270", VA = "0x18214A270", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public TKey HLNIIBDGPEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3BC8F50", Offset = "0x3BC7F50", VA = "0x183BC8F50")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3BC8F10", Offset = "0x3BC7F10", VA = "0x183BC8F10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x3BC8DB0", Offset = "0x3BC7DB0", VA = "0x183BC8DB0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3BC9890", Offset = "0x3BC8890", VA = "0x183BC9890", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x214B5D0", Offset = "0x214A5D0", VA = "0x18214B5D0", Slot = "9")]
	public void Add(TKey DDFHJDPPNBF, TVal BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3BC8D80", Offset = "0x3BC7D80", VA = "0x183BC8D80", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> OMLEPPBGLGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x311B320", Offset = "0x311A320", VA = "0x18311B320", Slot = "8")]
	public bool ContainsKey(TKey DDFHJDPPNBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3BC7F00", Offset = "0x3BC6F00", VA = "0x183BC7F00", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> OMLEPPBGLGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3BC9860", Offset = "0x3BC8860", VA = "0x183BC9860", Slot = "10")]
	public bool Remove(TKey DDFHJDPPNBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3BC9860", Offset = "0x3BC8860", VA = "0x183BC9860", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> OMLEPPBGLGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x27F6310", Offset = "0x27F5310", VA = "0x1827F6310", Slot = "11")]
	public bool TryGetValue(TKey DDFHJDPPNBF, out TVal BMNJAHFFOPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3BC8FB0", Offset = "0x3BC7FB0", VA = "0x183BC8FB0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3BC8E40", Offset = "0x3BC7E40", VA = "0x183BC8E40", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] PEGJLEIKJED, int IBMIEACPLPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x3BC97C0", Offset = "0x3BC87C0", VA = "0x183BC97C0")]
	public void NJFAMEHLCGO(TVal OOEOCFOBJLO, TKey DDFHJDPPNBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3BC9740", Offset = "0x3BC8740", VA = "0x183BC9740")]
	public void NJFAMEHLCGO(KeyValuePair<TVal, TKey> OMLEPPBGLGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x3BC8EA0", Offset = "0x3BC7EA0", VA = "0x183BC8EA0")]
	public bool DBGJLGFLGIE(TVal DDFHJDPPNBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x2376560", Offset = "0x2375560", VA = "0x182376560")]
	public bool DNKBNIOBOIB(KeyValuePair<TVal, TKey> OMLEPPBGLGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x214A640", Offset = "0x2149640", VA = "0x18214A640")]
	public bool INAIIIEHGLD(TVal DDFHJDPPNBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x214A640", Offset = "0x2149640", VA = "0x18214A640")]
	public bool INAIIIEHGLD(KeyValuePair<TVal, TKey> OMLEPPBGLGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x3BC9800", Offset = "0x3BC8800", VA = "0x183BC9800")]
	public bool NOGIDOCGHEN(TVal DDFHJDPPNBF, out TKey BMNJAHFFOPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x3BC9170", Offset = "0x3BC8170", VA = "0x183BC9170")]
	public IEnumerator<KeyValuePair<TVal, TKey>> KIPHHOEENEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3BC91F0", Offset = "0x3BC81F0", VA = "0x183BC91F0")]
	private void KMKMEDMMKBD(TKey DDFHJDPPNBF, TVal OOEOCFOBJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3BC9600", Offset = "0x3BC8600", VA = "0x183BC9600")]
	private void MBAOMFIIJBD(TKey DDFHJDPPNBF, TVal OOEOCFOBJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3BC9300", Offset = "0x3BC8300", VA = "0x183BC9300")]
	private bool MAPFHHGHMGO(TKey DDFHJDPPNBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3BC9480", Offset = "0x3BC8480", VA = "0x183BC9480")]
	private bool MAPFHHGHMGO(TVal OOEOCFOBJLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3BC9930", Offset = "0x3BC8930", VA = "0x183BC9930")]
	public EEOFPGEFIDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class DIOCECIOJED<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private global::DIOCECIOJED<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xFC5370", Offset = "0xFC4370", VA = "0x180FC5370", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x3B252C0", Offset = "0x3B242C0", VA = "0x183B252C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x3B25520", Offset = "0x3B24520", VA = "0x183B25520")]
		public Enumerator(global::DIOCECIOJED<T> EHKCNAODFJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x3B24C70", Offset = "0x3B23C70", VA = "0x183B24C70", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x3B24ED0", Offset = "0x3B23ED0", VA = "0x183B24ED0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x3B24870", Offset = "0x3B23870", VA = "0x183B24870")]
		private void AOLPCIHJDEB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private T[] KECMIABDOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private int LPLEHFIAKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private int BFPLDLPGNHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private int EPIIAPHJKPC;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int AGNENIFEHDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3B211C0", Offset = "0x3B201C0", VA = "0x183B211C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public T HLNIIBDGPEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3B20CC0", Offset = "0x3B1FCC0", VA = "0x183B20CC0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x3B20B00", Offset = "0x3B1FB00", VA = "0x183B20B00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3B224F0", Offset = "0x3B214F0", VA = "0x183B224F0")]
	public DIOCECIOJED(int EHCFCNDLJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3B21F70", Offset = "0x3B20F70", VA = "0x183B21F70")]
	public void NJFAMEHLCGO(T FNGOFIALAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3B21820", Offset = "0x3B20820", VA = "0x183B21820")]
	public void LFAFKKOJPNG(IEnumerable<T> ECIIMJNCNFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3B204A0", Offset = "0x3B1F4A0", VA = "0x183B204A0")]
	public void BFHLNDADIAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3B20D70", Offset = "0x3B1FD70", VA = "0x183B20D70")]
	public void DPACBFHFAKI(int NGOMPCKMIBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3B21E20", Offset = "0x3B20E20", VA = "0x183B21E20")]
	public void MPOOCODEJEK(int NGOMPCKMIBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3B20610", Offset = "0x3B1F610", VA = "0x183B20610")]
	public void CDHLDAOGJDI(T[] PEGJLEIKJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3B22220", Offset = "0x3B21220", VA = "0x183B22220")]
	public Enumerator OCEJNOMNLJH()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3B22300", Offset = "0x3B21300", VA = "0x183B22300", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3B22300", Offset = "0x3B21300", VA = "0x183B22300", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3B20EF0", Offset = "0x3B1FEF0", VA = "0x183B20EF0")]
	private int EBKEAGFBMPM(int FBOCJCCNMND)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3B20470", Offset = "0x3B1F470", VA = "0x183B20470")]
	private int AIFGNLNADGP(int FBOCJCCNMND)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct INKFMOOIFAO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly IDisposable[] OABMNGPOEHD;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6CD170", Offset = "0x6CC170", VA = "0x1806CD170")]
	public INKFMOOIFAO(params IDisposable[] LEMLHMGFBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0xDBE010", Offset = "0xDBD010", VA = "0x180DBE010")]
	public static INKFMOOIFAO PFJGPKGHGPI(params IDisposable[] LEMLHMGFBHB)
	{
		return default(INKFMOOIFAO);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x513DB40", Offset = "0x513CB40", VA = "0x18513DB40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct EFHAMCAHMMO<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly IDisposable IDLHOMGHAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public T MHLLNAFLMHJ;

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x253C1E0", Offset = "0x253B1E0", VA = "0x18253C1E0")]
	public EFHAMCAHMMO(IDisposable ANOBCBEPEBH, in T BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2600F80", Offset = "0x25FFF80", VA = "0x182600F80")]
	public static global::EFHAMCAHMMO<U> OKDOCHEFHCO<U>(in global::EFHAMCAHMMO<T> ANOBCBEPEBH, in U BMNJAHFFOPC)
	{
		return default(global::EFHAMCAHMMO<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1D762D0", Offset = "0x1D752D0", VA = "0x181D762D0")]
	public global::EFHAMCAHMMO<U> KGMOBAOMOGC<U>(in U BMNJAHFFOPC)
	{
		return default(global::EFHAMCAHMMO<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x2600D20", Offset = "0x25FFD20", VA = "0x182600D20")]
	public static global::EFHAMCAHMMO<(T, U)> FOPCHGGFECM<U>(in global::EFHAMCAHMMO<T> JAELLKEBFMM, in global::EFHAMCAHMMO<U> PEAHMNEGGIF)
	{
		return default(global::EFHAMCAHMMO<(T, U)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x3BC9B50", Offset = "0x3BC8B50", VA = "0x183BC9B50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class GDEONMDBNHI
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2601F90", Offset = "0x2600F90", VA = "0x182601F90")]
	public static global::EFHAMCAHMMO<T> PFJGPKGHGPI<T>(IDisposable ANOBCBEPEBH, in T BMNJAHFFOPC)
	{
		return default(global::EFHAMCAHMMO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x1D762D0", Offset = "0x1D752D0", VA = "0x181D762D0")]
	public static global::EFHAMCAHMMO<U> OKDOCHEFHCO<U, T>(in global::EFHAMCAHMMO<T> DEHMEEBNJDP, in U BMNJAHFFOPC)
	{
		return default(global::EFHAMCAHMMO<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x1D77C30", Offset = "0x1D76C30", VA = "0x181D77C30")]
	public static global::EFHAMCAHMMO<(T, U)> FOPCHGGFECM<T, U>(in global::EFHAMCAHMMO<T> JAELLKEBFMM, in global::EFHAMCAHMMO<U> PEAHMNEGGIF)
	{
		return default(global::EFHAMCAHMMO<(T, U)>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct IHHDENOEDED : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x58CEC0", Offset = "0x58BEC0", VA = "0x18058CEC0")]
	public static IHHDENOEDED MCJGNNPFECI<T>([Optional] string LJOFPFGLKDH, [Optional] string AMFMDOBFMLL, bool EHPLGKMDECF = false)
	{
		return default(IHHDENOEDED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[DefaultMember("Item")]
public readonly struct KIDDIOAGLCJ<T> : global::EKFKGIDGDDN<T, global::KIDDIOAGLCJ<T>.GHLKANECFFJ>, global::BECOCOIOBCI<T>, global::FKNAIBBLFKB<T, global::KIDDIOAGLCJ<T>.GHLKANECFFJ>, IEnumerable<T>, IEnumerable, global::AMJDJHKCIIE<T>, AFJIEGAGOJN
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct GHLKANECFFJ : AFJIEGAGOJN, global::ONNEBBFBHJH<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly T[] HJHCBAHBHJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private int EBNLGNCPLBK;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public int AGNENIFEHDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x21EC7F0", Offset = "0x21EB7F0", VA = "0x1821EC7F0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public T LBMKEDIKANE
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x21F0BD0", Offset = "0x21EFBD0", VA = "0x1821F0BD0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x21F0B80", Offset = "0x21EFB80", VA = "0x1821F0B80", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x21F0B80", Offset = "0x21EFB80", VA = "0x1821F0B80", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x9CD790", Offset = "0x9CC790", VA = "0x1809CD790")]
		private GHLKANECFFJ(T[] LDOMHDGLEOC, int FBOCJCCNMND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2094580", Offset = "0x2093580", VA = "0x182094580")]
		public static GHLKANECFFJ PFJGPKGHGPI(T[] LDOMHDGLEOC)
		{
			return default(GHLKANECFFJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x21F0B00", Offset = "0x21EFB00", VA = "0x1821F0B00", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x20945E0", Offset = "0x20935E0", VA = "0x1820945E0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly T[] MMAJALJJGFL;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int PNNHIIMLNIK
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x21EC7F0", Offset = "0x21EB7F0", VA = "0x1821EC7F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int AGNENIFEHDL
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x21EC810", Offset = "0x21EB810", VA = "0x1821EC810", Slot = "10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public T HLNIIBDGPEL
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x21EC4F0", Offset = "0x21EB4F0", VA = "0x1821EC4F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6CD170", Offset = "0x6CC170", VA = "0x1806CD170")]
	internal KIDDIOAGLCJ(T[] PEGJLEIKJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x21EC730", Offset = "0x21EB730", VA = "0x1821EC730")]
	public static global::KIDDIOAGLCJ<T> HBKBNBICFLH()
	{
		return default(global::KIDDIOAGLCJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x21EC530", Offset = "0x21EB530", VA = "0x1821EC530", Slot = "9")]
	public T DLCONIPBGNI(int FBOCJCCNMND)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x29B7EE0", Offset = "0x29B6EE0", VA = "0x1829B7EE0", Slot = "6")]
	public GHLKANECFFJ GetEnumerator()
	{
		return default(GHLKANECFFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x29B7DE0", Offset = "0x29B6DE0", VA = "0x1829B7DE0", Slot = "5")]
	private global::ONNEBBFBHJH<T> FENPIIAEPEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x29B7DE0", Offset = "0x29B6DE0", VA = "0x1829B7DE0", Slot = "7")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x29B7DE0", Offset = "0x29B6DE0", VA = "0x1829B7DE0", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class FHDMOPKHIGA
{
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x1D7B090", Offset = "0x1D7A090", VA = "0x181D7B090")]
	public static global::KIDDIOAGLCJ<T> PFJGPKGHGPI<T>(T[] PEGJLEIKJED)
	{
		return default(global::KIDDIOAGLCJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x19DF180", Offset = "0x19DE180", VA = "0x1819DF180")]
	public static global::KIDDIOAGLCJ<T> BKCHOPNAJGD<T>(this T[] LDOMHDGLEOC)
	{
		return default(global::KIDDIOAGLCJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x1D7B060", Offset = "0x1D7A060", VA = "0x181D7B060")]
	public static global::KIDDIOAGLCJ<T>.GHLKANECFFJ ICJKCJBDCDG<T>(this T[] LDOMHDGLEOC)
	{
		return default(global::KIDDIOAGLCJ<T>.GHLKANECFFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x19DF180", Offset = "0x19DE180", VA = "0x1819DF180")]
	public static global::KIDDIOAGLCJ<T> GHLGIHKHOAC<T>(this T[] LDOMHDGLEOC)
	{
		return default(global::KIDDIOAGLCJ<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct NOJPBAPMFEN<T, U> : global::EKFKGIDGDDN<T, U>, global::BECOCOIOBCI<T>, global::FKNAIBBLFKB<T, U>, IEnumerable<T>, IEnumerable where U : global::ONNEBBFBHJH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly U BNEOABENOCM;

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x21EB0E0", Offset = "0x21EA0E0", VA = "0x1821EB0E0")]
	internal NOJPBAPMFEN(in U NGFMABNLDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7620E0", Offset = "0x7610E0", VA = "0x1807620E0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2386600", Offset = "0x2385600", VA = "0x182386600", Slot = "5")]
	private global::ONNEBBFBHJH<T> FENPIIAEPEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x2386600", Offset = "0x2385600", VA = "0x182386600", Slot = "7")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x2386600", Offset = "0x2385600", VA = "0x182386600", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class ACJCNEKGDAC<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x1D77730", Offset = "0x1D76730", VA = "0x181D77730")]
	public static global::NOJPBAPMFEN<T, U> PFJGPKGHGPI<U>(in U NGFMABNLDEL) where U : global::ONNEBBFBHJH<T>
	{
		return default(global::NOJPBAPMFEN<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class CDCHDAEDLAB<TResult, TResultEnumerator> where TResultEnumerator : global::ONNEBBFBHJH<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x2282610", Offset = "0x2281610", VA = "0x182282610")]
	public static global::OBLHLEKCMGJ<TSourceEnumerator, TResultEnumerator, TResult> NKKKCIJHHFP<TSourceEnumerator>(in TSourceEnumerator LDOMHDGLEOC) where TSourceEnumerator : IEnumerator<TResultEnumerator>
	{
		return default(global::OBLHLEKCMGJ<TSourceEnumerator, TResultEnumerator, TResult>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct OBLHLEKCMGJ<TSourceEnumerator, TResultEnumerator, TResult> : global::ONNEBBFBHJH<TResult>, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : IEnumerator<TResultEnumerator> where TResultEnumerator : global::ONNEBBFBHJH<TResult>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private TSourceEnumerator HJHCBAHBHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private TResultEnumerator EMMKCFAIOOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private bool BGOMHMLMKCB;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public TResult LBMKEDIKANE
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x4A85D40", Offset = "0x4A84D40", VA = "0x184A85D40", Slot = "4")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	TResult IEnumerator<TResult>.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x4A85CA0", Offset = "0x4A84CA0", VA = "0x184A85CA0", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x4A85CA0", Offset = "0x4A84CA0", VA = "0x184A85CA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x4A85CF0", Offset = "0x4A84CF0", VA = "0x184A85CF0")]
	internal OBLHLEKCMGJ(in TSourceEnumerator LDOMHDGLEOC, in TResultEnumerator GAGNGAIBLLI, bool MGACNCCLGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x4A85B20", Offset = "0x4A84B20", VA = "0x184A85B20", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x4A85C50", Offset = "0x4A84C50", VA = "0x184A85C50", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x4A85AD0", Offset = "0x4A84AD0", VA = "0x184A85AD0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct MFEBFAGIHHD<TSourceEnumerator, TSource, TResult> : AFJIEGAGOJN, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : AFJIEGAGOJN, global::ONNEBBFBHJH<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private TSourceEnumerator HJHCBAHBHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly global::AHDCJLCFDKN<TSource, TResult> DDBHPKAONCJ;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int AGNENIFEHDL
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x20A0360", Offset = "0x209F360", VA = "0x1820A0360", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public TResult LBMKEDIKANE
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x20A0E80", Offset = "0x209FE80", VA = "0x1820A0E80", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x20A0A30", Offset = "0x209FA30", VA = "0x1820A0A30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x20A0B30", Offset = "0x209FB30", VA = "0x1820A0B30")]
	internal MFEBFAGIHHD(in TSourceEnumerator LDOMHDGLEOC, global::AHDCJLCFDKN<TSource, TResult> HHGEAGKJNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x20A0680", Offset = "0x209F680", VA = "0x1820A0680", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x20A0900", Offset = "0x209F900", VA = "0x1820A0900", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x20A0220", Offset = "0x209F220", VA = "0x1820A0220", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct JCEHLOHGHFC<TSourceEnumerator, TSource, TResultEnumerator, TResult> : global::ONNEBBFBHJH<TResult>, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : global::ONNEBBFBHJH<TSource> where TResultEnumerator : global::ONNEBBFBHJH<TResult>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private TSourceEnumerator HJHCBAHBHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private TResultEnumerator EMMKCFAIOOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly global::AHDCJLCFDKN<TSource, TResultEnumerator> DDBHPKAONCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private bool BGOMHMLMKCB;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public TResult LBMKEDIKANE
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x3BE8FB0", Offset = "0x3BE7FB0", VA = "0x183BE8FB0", Slot = "4")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	TResult IEnumerator<TResult>.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x3BE8EC0", Offset = "0x3BE7EC0", VA = "0x183BE8EC0", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x3BE8EC0", Offset = "0x3BE7EC0", VA = "0x183BE8EC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x3BE8F50", Offset = "0x3BE7F50", VA = "0x183BE8F50")]
	internal JCEHLOHGHFC(in TSourceEnumerator LDOMHDGLEOC, in TResultEnumerator GAGNGAIBLLI, global::AHDCJLCFDKN<TSource, TResultEnumerator> HHGEAGKJNJL, bool MGACNCCLGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x3BE8CE0", Offset = "0x3BE7CE0", VA = "0x183BE8CE0", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x3BE8E70", Offset = "0x3BE7E70", VA = "0x183BE8E70", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3BE8C90", Offset = "0x3BE7C90", VA = "0x183BE8C90", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct NHLAGFEJCHO<TSource1Enumerator, TSource1, TSource2Enumerator, TSource2> : AFJIEGAGOJN, IEnumerator<(TSource1, TSource2)>, IEnumerator, IDisposable where TSource1Enumerator : AFJIEGAGOJN, global::ONNEBBFBHJH<TSource1> where TSource2Enumerator : AFJIEGAGOJN, global::ONNEBBFBHJH<TSource2>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private TSource1Enumerator EDCJBPADLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private TSource2Enumerator EPEBJHODLLK;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int AGNENIFEHDL
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x38322D0", Offset = "0x38312D0", VA = "0x1838322D0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public (TSource1, TSource2) LBMKEDIKANE
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3832530", Offset = "0x3831530", VA = "0x183832530", Slot = "5")]
		get
		{
			return default((TSource1, TSource2));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3832450", Offset = "0x3831450", VA = "0x183832450", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x38324F0", Offset = "0x38314F0", VA = "0x1838324F0")]
	internal NHLAGFEJCHO(in TSource1Enumerator CMLHAFMOGNJ, in TSource2Enumerator PPGKAMPFILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x3832370", Offset = "0x3831370", VA = "0x183832370", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x38323E0", Offset = "0x38313E0", VA = "0x1838323E0", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x3832270", Offset = "0x3831270", VA = "0x183832270", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public readonly struct OPLEBPKAJOH<T, U> : global::FKNAIBBLFKB<T, U>, IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly U BNEOABENOCM;

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2386640", Offset = "0x2385640", VA = "0x182386640")]
	internal OPLEBPKAJOH(in U NGFMABNLDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x23864D0", Offset = "0x23854D0", VA = "0x1823864D0", Slot = "4")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x23864F0", Offset = "0x23854F0", VA = "0x1823864F0", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x23864F0", Offset = "0x23854F0", VA = "0x1823864F0", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class CGJPIPIGKMO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x22826C0", Offset = "0x22816C0", VA = "0x1822826C0")]
	public static global::OPLEBPKAJOH<T, U> PFJGPKGHGPI<U>(in U NGFMABNLDEL) where U : IEnumerator<T>
	{
		return default(global::OPLEBPKAJOH<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct MAKELHDHLNB<TSourceEnumerator, TSource, TResult> : AFJIEGAGOJN, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : AFJIEGAGOJN, IEnumerator<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private TSourceEnumerator HJHCBAHBHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly Func<TSource, TResult> DDBHPKAONCJ;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int AGNENIFEHDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x27F7D50", Offset = "0x27F6D50", VA = "0x1827F7D50", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public TResult LBMKEDIKANE
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x27F7EE0", Offset = "0x27F6EE0", VA = "0x1827F7EE0", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x27F7EA0", Offset = "0x27F6EA0", VA = "0x1827F7EA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x20A0B70", Offset = "0x209FB70", VA = "0x1820A0B70")]
	internal MAKELHDHLNB(in TSourceEnumerator LDOMHDGLEOC, Func<TSource, TResult> HHGEAGKJNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x27F7E00", Offset = "0x27F6E00", VA = "0x1827F7E00", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x27F7E50", Offset = "0x27F6E50", VA = "0x1827F7E50", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x27F7D00", Offset = "0x27F6D00", VA = "0x1827F7D00", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class HJMKBEIDHCH
{
	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x25D9AE0", Offset = "0x25D8AE0", VA = "0x1825D9AE0")]
	public static bool LJIGGELHKEM<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator LDOMHDGLEOC, in TArgs AIAEIEGFNFD, in global::IEBCGHFMACL<TArgs, TSource, bool> FIPLNDAAJHL) where TSourceEnumerator : global::ONNEBBFBHJH<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2090AD0", Offset = "0x208FAD0", VA = "0x182090AD0")]
	public static int FPGIKDKACGJ<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator LDOMHDGLEOC, in TArgs AIAEIEGFNFD, global::IEBCGHFMACL<TArgs, TSource, bool> FIPLNDAAJHL) where TSourceEnumerator : global::ONNEBBFBHJH<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x25D9A00", Offset = "0x25D8A00", VA = "0x1825D9A00")]
	public static bool BIAJDIKJNKK<TSourceEnumerator, TSource>(this TSourceEnumerator LDOMHDGLEOC, in TSource OMLEPPBGLGA) where TSourceEnumerator : global::ONNEBBFBHJH<TSource> where TSource : global::IFIOBPICNCP<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x2090DC0", Offset = "0x208FDC0", VA = "0x182090DC0")]
	public static int IONDFACGNHH<TSourceEnumerator, TSource>(this TSourceEnumerator LDOMHDGLEOC, in TSource BMNJAHFFOPC) where TSourceEnumerator : global::ONNEBBFBHJH<TSource> where TSource : global::IFIOBPICNCP<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2284A40", Offset = "0x2283A40", VA = "0x182284A40")]
	public static global::MFEBFAGIHHD<TSourceEnumerator, TSource, TResult> FFJCCHINCCI<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator LDOMHDGLEOC, global::AHDCJLCFDKN<TSource, TResult> HHGEAGKJNJL) where TSourceEnumerator : AFJIEGAGOJN, global::ONNEBBFBHJH<TSource>
	{
		return default(global::MFEBFAGIHHD<TSourceEnumerator, TSource, TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2282670", Offset = "0x2281670", VA = "0x182282670")]
	public static global::MAKELHDHLNB<TSourceEnumerator, TSource, TResult> MEGPJGOGIIM<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator LDOMHDGLEOC, Func<TSource, TResult> HHGEAGKJNJL) where TSourceEnumerator : AFJIEGAGOJN, IEnumerator<TSource>
	{
		return default(global::MAKELHDHLNB<TSourceEnumerator, TSource, TResult>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class MEAGHAMLDDC<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x25DD220", Offset = "0x25DC220", VA = "0x1825DD220")]
	public static bool FOMKGJFECOB<TSourceEnumerator>(TSourceEnumerator LDOMHDGLEOC) where TSourceEnumerator : IEnumerator<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x19E47C0", Offset = "0x19E37C0", VA = "0x1819E47C0")]
	public static T CLEGNDAHKPF<TSourceEnumerator>(TSourceEnumerator LDOMHDGLEOC) where TSourceEnumerator : global::ONNEBBFBHJH<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x2286D60", Offset = "0x2285D60", VA = "0x182286D60")]
	public static global::JCEHLOHGHFC<TSourceEnumerator, TSource, TResultEnumerator, T> MEKIKOLPLDJ<TSourceEnumerator, TSource, TResultEnumerator>(in TSourceEnumerator LDOMHDGLEOC, global::AHDCJLCFDKN<TSource, TResultEnumerator> HHGEAGKJNJL) where TSourceEnumerator : global::ONNEBBFBHJH<TSource> where TResultEnumerator : global::ONNEBBFBHJH<T>
	{
		return default(global::JCEHLOHGHFC<TSourceEnumerator, TSource, TResultEnumerator, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x37A11E0", Offset = "0x37A01E0", VA = "0x1837A11E0")]
	public static string OPBMBMGFBFH<TSourceEnumerator>(TSourceEnumerator LDOMHDGLEOC) where TSourceEnumerator : IEnumerator<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x2E20680", Offset = "0x2E1F680", VA = "0x182E20680")]
	public static T[] JFBNONPIPLO<TSourceEnumerator>(TSourceEnumerator LDOMHDGLEOC) where TSourceEnumerator : AFJIEGAGOJN, IEnumerator<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x1FDD3B0", Offset = "0x1FDC3B0", VA = "0x181FDD3B0")]
	public static T BADJKJHCNFF<TSourceEnumerator>(TSourceEnumerator LDOMHDGLEOC) where TSourceEnumerator : IEnumerator<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x25DD350", Offset = "0x25DC350", VA = "0x1825DD350")]
	public static bool KEIJHLNAHEL<TSourceEnumerator>(TSourceEnumerator LDOMHDGLEOC) where TSourceEnumerator : IEnumerator<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class IPDMHJMFPJM<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x2284B30", Offset = "0x2283B30", VA = "0x182284B30")]
	public static global::NHLAGFEJCHO<TSource1Enumerator, T, TSource2Enumerator, U> JJFLCONNKCB<TSource1Enumerator, TSource2Enumerator>(in TSource1Enumerator CMLHAFMOGNJ, in TSource2Enumerator PPGKAMPFILM) where TSource1Enumerator : AFJIEGAGOJN, global::ONNEBBFBHJH<T> where TSource2Enumerator : AFJIEGAGOJN, global::ONNEBBFBHJH<U>
	{
		return default(global::NHLAGFEJCHO<TSource1Enumerator, T, TSource2Enumerator, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface BECOCOIOBCI<T>
{
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::ONNEBBFBHJH<T> GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface EKFKGIDGDDN<T, TEnumerator> : global::BECOCOIOBCI<T>, global::FKNAIBBLFKB<T, TEnumerator>, IEnumerable<T>, IEnumerable where TEnumerator : global::ONNEBBFBHJH<T>
{
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new TEnumerator GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface ONNEBBFBHJH<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	T LBMKEDIKANE
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface AMJDJHKCIIE<T> : AFJIEGAGOJN
{
	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T DLCONIPBGNI(int BHFIJCEBIFE);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface FKNAIBBLFKB<T, TEnumerator> : IEnumerable<T>, IEnumerable where TEnumerator : IEnumerator<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new TEnumerator GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface AFJIEGAGOJN
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	int AGNENIFEHDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface IFIOBPICNCP<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ABPGEKLLPBF(in T INIEAOGGCLC);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface PAMNFOFDGOB<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::GFOBABIABNO<T> GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface OFPJFGPODLE<T, TEnumerator> : global::PAMNFOFDGOB<T>, global::EKFKGIDGDDN<T, TEnumerator>, global::BECOCOIOBCI<T>, global::FKNAIBBLFKB<T, TEnumerator>, IEnumerable<T>, IEnumerable where TEnumerator : global::GFOBABIABNO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new TEnumerator GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface GFOBABIABNO<T> : global::ONNEBBFBHJH<T>, IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	new T LBMKEDIKANE
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public delegate void BEOCOHNCFBC<T>(in T KJHLPNDFFPC);
[Cpp2IlInjected.Token(Token = "0x200004A")]
public delegate void EIABMOFANKI<T1, T2>(in T1 LPJPDMBCHJJ, in T2 KFMJMACKKEP);
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class ACPGFHOJOJO
{
	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x25D1440", Offset = "0x25D0440", VA = "0x1825D1440")]
	public static bool CLOKKEFBBFI<T, U>(this T LDOMHDGLEOC, in U OOJKHPLJJMJ) where T : global::IFIOBPICNCP<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public delegate TResult AHDCJLCFDKN<T, out TResult>(in T KJHLPNDFFPC);
[Cpp2IlInjected.Token(Token = "0x200004D")]
public delegate TResult IEBCGHFMACL<T1, T2, out TResult>(in T1 LPJPDMBCHJJ, in T2 KFMJMACKKEP);
[Cpp2IlInjected.Token(Token = "0x200004E")]
public delegate TResult IPNAOOGGNPF<T1, T2, T3, out TResult>(in T1 LPJPDMBCHJJ, in T2 KFMJMACKKEP, in T3 JAAMNHHILEB);
[Cpp2IlInjected.Token(Token = "0x200004F")]
public delegate TResult EGENPCAJADO<T1, T2, T3, T4, out TResult>(in T1 LPJPDMBCHJJ, in T2 KFMJMACKKEP, in T3 JAAMNHHILEB, in T4 CFCJMDPPKMG);
[Cpp2IlInjected.Token(Token = "0x2000050")]
public delegate TResult HMNIGOIHIHL<T1, T2, T3, T4, T5, out TResult>(in T1 LPJPDMBCHJJ, in T2 KFMJMACKKEP, in T3 JAAMNHHILEB, in T4 CFCJMDPPKMG, in T5 LCMNGKHCDDD);
[Cpp2IlInjected.Token(Token = "0x2000051")]
public delegate TResult AGFFOMMBPIK<T, TResult>(in T KJHLPNDFFPC);
[Cpp2IlInjected.Token(Token = "0x2000052")]
public delegate TResult GPPLLLNCCNA<T1, T2, TResult>(in T1 LPJPDMBCHJJ, in T2 KFMJMACKKEP);
[Cpp2IlInjected.Token(Token = "0x2000053")]
public delegate TResult EKNEJCEPOGO<T1, T2, T3, TResult>(in T1 LPJPDMBCHJJ, in T2 KFMJMACKKEP, in T3 JAAMNHHILEB);
[Cpp2IlInjected.Token(Token = "0x2000054")]
[DefaultMember("Item")]
public struct HGFOHINHEKL<T> : global::OFPJFGPODLE<T, global::HGFOHINHEKL<T>.LILMKFPCGGE>, global::PAMNFOFDGOB<T>, global::EKFKGIDGDDN<T, global::HGFOHINHEKL<T>.LILMKFPCGGE>, global::BECOCOIOBCI<T>, global::FKNAIBBLFKB<T, global::HGFOHINHEKL<T>.LILMKFPCGGE>, IEnumerable<T>, IEnumerable, global::AMJDJHKCIIE<T>, AFJIEGAGOJN
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct LILMKFPCGGE : AFJIEGAGOJN, global::GFOBABIABNO<T>, global::ONNEBBFBHJH<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private T[] HJHCBAHBHJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int EBNLGNCPLBK;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public int AGNENIFEHDL
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x21EC7F0", Offset = "0x21EB7F0", VA = "0x1821EC7F0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public T LBMKEDIKANE
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x21F0BD0", Offset = "0x21EFBD0", VA = "0x1821F0BD0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		private T HDBPMDHJJCL
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x21F0B30", Offset = "0x21EFB30", VA = "0x1821F0B30", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x21F0B80", Offset = "0x21EFB80", VA = "0x1821F0B80", Slot = "7")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x21F0B80", Offset = "0x21EFB80", VA = "0x1821F0B80", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x9CD790", Offset = "0x9CC790", VA = "0x1809CD790")]
		private LILMKFPCGGE(T[] LDOMHDGLEOC, int FBOCJCCNMND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2094580", Offset = "0x2093580", VA = "0x182094580")]
		public static LILMKFPCGGE PFJGPKGHGPI(T[] LDOMHDGLEOC)
		{
			return default(LILMKFPCGGE);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x21F0B00", Offset = "0x21EFB00", VA = "0x1821F0B00", Slot = "9")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x20945E0", Offset = "0x20935E0", VA = "0x1820945E0", Slot = "11")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80", Slot = "8")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private T[] MMAJALJJGFL;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int PNNHIIMLNIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x21EC7F0", Offset = "0x21EB7F0", VA = "0x1821EC7F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public int AGNENIFEHDL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x21EC810", Offset = "0x21EB810", VA = "0x1821EC810", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public T HLNIIBDGPEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x21EC4F0", Offset = "0x21EB4F0", VA = "0x1821EC4F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6CD170", Offset = "0x6CC170", VA = "0x1806CD170")]
	internal HGFOHINHEKL(T[] PEGJLEIKJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x21EC730", Offset = "0x21EB730", VA = "0x1821EC730")]
	public static global::HGFOHINHEKL<T> HBKBNBICFLH()
	{
		return default(global::HGFOHINHEKL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x21EC530", Offset = "0x21EB530", VA = "0x1821EC530", Slot = "11")]
	public T DLCONIPBGNI(int FBOCJCCNMND)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x21EC850", Offset = "0x21EB850", VA = "0x1821EC850")]
	public global::KIDDIOAGLCJ<T> NBGICLLPPIA()
	{
		return default(global::KIDDIOAGLCJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x21EC690", Offset = "0x21EB690", VA = "0x1821EC690", Slot = "8")]
	public LILMKFPCGGE GetEnumerator()
	{
		return default(LILMKFPCGGE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x21EC590", Offset = "0x21EB590", VA = "0x1821EC590", Slot = "5")]
	private global::GFOBABIABNO<T> LFNGLJAHNEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x21EC590", Offset = "0x21EB590", VA = "0x1821EC590", Slot = "7")]
	private global::ONNEBBFBHJH<T> FENPIIAEPEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x21EC590", Offset = "0x21EB590", VA = "0x1821EC590", Slot = "9")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x21EC590", Offset = "0x21EB590", VA = "0x1821EC590", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class PPPDLBEIKPL
{
	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x1D7B090", Offset = "0x1D7A090", VA = "0x181D7B090")]
	public static global::HGFOHINHEKL<T> PFJGPKGHGPI<T>(T[] PEGJLEIKJED)
	{
		return default(global::HGFOHINHEKL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x19DF180", Offset = "0x19DE180", VA = "0x1819DF180")]
	public static global::HGFOHINHEKL<T> OKGGNMBPHFO<T>(this T[] LDOMHDGLEOC)
	{
		return default(global::HGFOHINHEKL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x1D7B060", Offset = "0x1D7A060", VA = "0x181D7B060")]
	public static global::HGFOHINHEKL<T>.LILMKFPCGGE ABNBIOOJBOC<T>(this T[] LDOMHDGLEOC)
	{
		return default(global::HGFOHINHEKL<T>.LILMKFPCGGE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x19DF180", Offset = "0x19DE180", VA = "0x1819DF180")]
	public static global::HGFOHINHEKL<T> FPCDINMMIKP<T>(this T[] LDOMHDGLEOC)
	{
		return default(global::HGFOHINHEKL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public readonly struct BPEDFPDMLPO<T, U> : global::OFPJFGPODLE<T, U>, global::PAMNFOFDGOB<T>, global::EKFKGIDGDDN<T, U>, global::BECOCOIOBCI<T>, global::FKNAIBBLFKB<T, U>, IEnumerable<T>, IEnumerable where U : global::GFOBABIABNO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly U BNEOABENOCM;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x21EB0E0", Offset = "0x21EA0E0", VA = "0x1821EB0E0")]
	internal BPEDFPDMLPO(in U NGFMABNLDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7620E0", Offset = "0x7610E0", VA = "0x1807620E0", Slot = "8")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x2386600", Offset = "0x2385600", VA = "0x182386600", Slot = "5")]
	private global::GFOBABIABNO<T> LFNGLJAHNEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x2386600", Offset = "0x2385600", VA = "0x182386600", Slot = "7")]
	private global::ONNEBBFBHJH<T> FENPIIAEPEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x2386600", Offset = "0x2385600", VA = "0x182386600", Slot = "9")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x2386600", Offset = "0x2385600", VA = "0x182386600", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class LICOABMCDAK<T>
{
	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x1D77730", Offset = "0x1D76730", VA = "0x181D77730")]
	public static global::BPEDFPDMLPO<T, U> PFJGPKGHGPI<U>(in U NGFMABNLDEL) where U : global::GFOBABIABNO<T>
	{
		return default(global::BPEDFPDMLPO<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[DefaultMember("Item")]
public class AAPLNGFCFBC<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly Func<Internal, External> ABBCBCPMKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly Func<External, Internal> GLHNPLALEHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private IList<Internal> NNKFFLIIPKA;

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public IList<Internal> JJBMIOACLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x58EDF0", Offset = "0x58DDF0", VA = "0x18058EDF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x5B6D70", Offset = "0x5B5D70", VA = "0x1805B6D70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool HBFNBGIFOHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x60D990", Offset = "0x60C990", VA = "0x18060D990", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x9DAE80", Offset = "0x9D9E80", VA = "0x1809DAE80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public External HLNIIBDGPEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x413D140", Offset = "0x413C140", VA = "0x18413D140", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x413D1E0", Offset = "0x413C1E0", VA = "0x18413D1E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public int AGNENIFEHDL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x413D0E0", Offset = "0x413C0E0", VA = "0x18413D0E0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x413D050", Offset = "0x413C050", VA = "0x18413D050")]
	public AAPLNGFCFBC(Func<Internal, External> ABBCBCPMKON, Func<External, Internal> GLHNPLALEHL, bool PAMOOANPIOM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x413CD60", Offset = "0x413BD60", VA = "0x18413CD60", Slot = "6")]
	public int IndexOf(External OMLEPPBGLGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x413C9E0", Offset = "0x413B9E0", VA = "0x18413C9E0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x413CA40", Offset = "0x413BA40", VA = "0x18413CA40", Slot = "13")]
	public bool Contains(External OMLEPPBGLGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x413CAD0", Offset = "0x413BAD0", VA = "0x18413CAD0", Slot = "14")]
	public void CopyTo(External[] PEGJLEIKJED, int IBMIEACPLPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x413C8F0", Offset = "0x413B8F0", VA = "0x18413C8F0", Slot = "11")]
	public void Add(External OMLEPPBGLGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x413CE50", Offset = "0x413BE50", VA = "0x18413CE50", Slot = "7")]
	public void Insert(int FBOCJCCNMND, External OMLEPPBGLGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x413CFC0", Offset = "0x413BFC0", VA = "0x18413CFC0", Slot = "15")]
	public bool Remove(External OMLEPPBGLGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x413CEF0", Offset = "0x413BEF0", VA = "0x18413CEF0", Slot = "8")]
	public void RemoveAt(int FBOCJCCNMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x413CCF0", Offset = "0x413BCF0", VA = "0x18413CCF0", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x1FF81D0", Offset = "0x1FF71D0", VA = "0x181FF81D0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[DefaultMember("Item")]
public class AMOFKMLKBPP<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Func<Internal, External> ABBCBCPMKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private IReadOnlyList<Internal> NNKFFLIIPKA;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public IReadOnlyList<Internal> JJBMIOACLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x58C4A0", Offset = "0x58B4A0", VA = "0x18058C4A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool HBFNBGIFOHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x58CFE0", Offset = "0x58BFE0", VA = "0x18058CFE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public External HLNIIBDGPEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x2EC8F20", Offset = "0x2EC7F20", VA = "0x182EC8F20", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public int AGNENIFEHDL
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x2EC8EC0", Offset = "0x2EC7EC0", VA = "0x182EC8EC0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x214B810", Offset = "0x214A810", VA = "0x18214B810")]
	public AMOFKMLKBPP(Func<Internal, External> ABBCBCPMKON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x2EC8E70", Offset = "0x2EC7E70", VA = "0x182EC8E70")]
	public AMOFKMLKBPP(IReadOnlyList<Internal> NNKFFLIIPKA, Func<Internal, External> ABBCBCPMKON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x2EC8BE0", Offset = "0x2EC7BE0", VA = "0x182EC8BE0")]
	public void CDHLDAOGJDI(External[] PEGJLEIKJED, int IBMIEACPLPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x2EC8E00", Offset = "0x2EC7E00", VA = "0x182EC8E00", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x1E9FEE0", Offset = "0x1E9EEE0", VA = "0x181E9FEE0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[DefaultMember("Item")]
public class EDILJPINNKH<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private IReadOnlyList<Internal> NNKFFLIIPKA;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public IReadOnlyList<Internal> JJBMIOACLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x58C1D0", Offset = "0x58B1D0", VA = "0x18058C1D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x58C490", Offset = "0x58B490", VA = "0x18058C490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public bool HBFNBGIFOHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x58CFE0", Offset = "0x58BFE0", VA = "0x18058CFE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public External HLNIIBDGPEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3BC56A0", Offset = "0x3BC46A0", VA = "0x183BC56A0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int AGNENIFEHDL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3BC5640", Offset = "0x3BC4640", VA = "0x183BC5640", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x214B810", Offset = "0x214A810", VA = "0x18214B810")]
	public EDILJPINNKH(IReadOnlyList<Internal> NNKFFLIIPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x3BC5530", Offset = "0x3BC4530", VA = "0x183BC5530")]
	public bool DNKBNIOBOIB(External OMLEPPBGLGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3BC5300", Offset = "0x3BC4300", VA = "0x183BC5300")]
	public void CDHLDAOGJDI(External[] PEGJLEIKJED, int IBMIEACPLPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x3BC55D0", Offset = "0x3BC45D0", VA = "0x183BC55D0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x1FF81D0", Offset = "0x1FF71D0", VA = "0x181FF81D0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public abstract class AHIPLCLEEFB
{
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void NINBOEBNFJG(object[] AIAEIEGFNFD);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	protected AHIPLCLEEFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class PEMCDPMKBIF<T> : AHIPLCLEEFB
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	protected struct HPAHEIBJCMH
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public enum CCECFGMJMOH
		{
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public CCECFGMJMOH GOKHKCCNGMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public T KAIJPPOLHDF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private int AENENFPADEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly bool ADFHHGGIPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	protected readonly bool EFAKNGCNKLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	protected List<T> FGBGJOEDEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private List<HPAHEIBJCMH> MGIFDDFGGPD;

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool BILLDBFBKMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3988570", Offset = "0x3987570", VA = "0x183988570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x39887D0", Offset = "0x39877D0", VA = "0x1839887D0")]
	protected PEMCDPMKBIF(bool EFAKNGCNKLK, bool ADFHHGGIPJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x3988730", Offset = "0x3987730", VA = "0x183988730")]
	protected bool PMILDKFLJJB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x3988180", Offset = "0x3987180", VA = "0x183988180")]
	protected void GMMNGMCIIDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x39883C0", Offset = "0x39873C0", VA = "0x1839883C0")]
	protected void JNGBOMBCKKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x38D3A80", Offset = "0x38D2A80", VA = "0x1838D3A80")]
	private static void NBJJODJDNKG<U>(ref List<U> NNKFFLIIPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x39885B0", Offset = "0x39875B0", VA = "0x1839885B0", Slot = "5")]
	public void NJFAMEHLCGO(T KAIJPPOLHDF, bool EJPIHOCPCPP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x3988260", Offset = "0x3987260", VA = "0x183988260", Slot = "6")]
	public void INAIIIEHGLD(T KAIJPPOLHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x3988050", Offset = "0x3987050", VA = "0x183988050")]
	public void BFHLNDADIAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface LFBAAOFBHFE
{
	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NJFAMEHLCGO(Action KAIJPPOLHDF, bool EJPIHOCPCPP = false);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void INAIIIEHGLD(Action KAIJPPOLHDF);
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public sealed class IPAFKFONBKE : global::PEMCDPMKBIF<Action>, LFBAAOFBHFE
{
	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x513DF60", Offset = "0x513CF60", VA = "0x18513DF60")]
	public IPAFKFONBKE(bool EFAKNGCNKLK = false, bool ADFHHGGIPJM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x513DDA0", Offset = "0x513CDA0", VA = "0x18513DDA0")]
	public void PODJJFBHDBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x513DD20", Offset = "0x513CD20", VA = "0x18513DD20", Slot = "4")]
	public override void NINBOEBNFJG(object[] AIAEIEGFNFD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x513DCC0", Offset = "0x513CCC0", VA = "0x18513DCC0")]
	public static IPAFKFONBKE MCAPNMFNAKO(IPAFKFONBKE GKLACFEAMMG, Action KAIJPPOLHDF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x513DC60", Offset = "0x513CC60", VA = "0x18513DC60")]
	public static IPAFKFONBKE BDFKJFNDJGN(IPAFKFONBKE GKLACFEAMMG, Action KAIJPPOLHDF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface NPLOBDHFIIN<T>
{
	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NJFAMEHLCGO(Action<T> KAIJPPOLHDF, bool EJPIHOCPCPP = false);

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void INAIIIEHGLD(Action<T> KAIJPPOLHDF);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public sealed class ADIPIMHFLAB<T> : global::PEMCDPMKBIF<Action<T>>, global::NPLOBDHFIIN<T>
{
	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x2540B40", Offset = "0x253FB40", VA = "0x182540B40")]
	public ADIPIMHFLAB(bool EFAKNGCNKLK = false, bool ADFHHGGIPJM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x3EECFE0", Offset = "0x3EEBFE0", VA = "0x183EECFE0")]
	public void PODJJFBHDBG(T FNGOFIALAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x3EE9E60", Offset = "0x3EE8E60", VA = "0x183EE9E60", Slot = "4")]
	public override void NINBOEBNFJG(object[] AIAEIEGFNFD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x3EE9670", Offset = "0x3EE8670", VA = "0x183EE9670")]
	public static global::ADIPIMHFLAB<T> MCAPNMFNAKO(global::ADIPIMHFLAB<T> GKLACFEAMMG, Action<T> KAIJPPOLHDF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x3EE95D0", Offset = "0x3EE85D0", VA = "0x183EE95D0")]
	public static global::ADIPIMHFLAB<T> BDFKJFNDJGN(global::ADIPIMHFLAB<T> GKLACFEAMMG, Action<T> KAIJPPOLHDF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface HNDBAECJAEH<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NJFAMEHLCGO(Action<T, U> KAIJPPOLHDF, bool EJPIHOCPCPP = false);

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void INAIIIEHGLD(Action<T, U> KAIJPPOLHDF);
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public sealed class IBGBLHJEHKG<T, U> : global::PEMCDPMKBIF<Action<T, U>>, global::HNDBAECJAEH<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x2540B40", Offset = "0x253FB40", VA = "0x182540B40")]
	public IBGBLHJEHKG(bool EFAKNGCNKLK = false, bool ADFHHGGIPJM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x34243B0", Offset = "0x34233B0", VA = "0x1834243B0")]
	public void PODJJFBHDBG(T FNGOFIALAJH, U CEFCJNLBMJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x40ABD00", Offset = "0x40AAD00", VA = "0x1840ABD00", Slot = "4")]
	public override void NINBOEBNFJG(object[] AIAEIEGFNFD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x341FF00", Offset = "0x341EF00", VA = "0x18341FF00")]
	public static global::IBGBLHJEHKG<T, U> MCAPNMFNAKO(global::IBGBLHJEHKG<T, U> GKLACFEAMMG, Action<T, U> KAIJPPOLHDF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x341FE60", Offset = "0x341EE60", VA = "0x18341FE60")]
	public static global::IBGBLHJEHKG<T, U> BDFKJFNDJGN(global::IBGBLHJEHKG<T, U> GKLACFEAMMG, Action<T, U> KAIJPPOLHDF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface APKPMCJKPFA<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NJFAMEHLCGO(Action<T, U, V> KAIJPPOLHDF, bool EJPIHOCPCPP = false);

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void INAIIIEHGLD(Action<T, U, V> KAIJPPOLHDF);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public sealed class CNOLKOPLMHP<T, U, V> : global::PEMCDPMKBIF<Action<T, U, V>>, global::APKPMCJKPFA<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x2540B40", Offset = "0x253FB40", VA = "0x182540B40")]
	public CNOLKOPLMHP(bool EFAKNGCNKLK = false, bool ADFHHGGIPJM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x253E980", Offset = "0x253D980", VA = "0x18253E980")]
	public void PODJJFBHDBG(T FNGOFIALAJH, U CEFCJNLBMJH, V NDCAPABKMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x253DB40", Offset = "0x253CB40", VA = "0x18253DB40", Slot = "4")]
	public override void NINBOEBNFJG(object[] AIAEIEGFNFD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x253CE40", Offset = "0x253BE40", VA = "0x18253CE40")]
	public static global::CNOLKOPLMHP<T, U, V> MCAPNMFNAKO(global::CNOLKOPLMHP<T, U, V> GKLACFEAMMG, Action<T, U, V> KAIJPPOLHDF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x253CDA0", Offset = "0x253BDA0", VA = "0x18253CDA0")]
	public static global::CNOLKOPLMHP<T, U, V> BDFKJFNDJGN(global::CNOLKOPLMHP<T, U, V> GKLACFEAMMG, Action<T, U, V> KAIJPPOLHDF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface JMFNCNKEDLD<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NJFAMEHLCGO(Action<T, U, V, W> KAIJPPOLHDF, bool EJPIHOCPCPP = false);

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void INAIIIEHGLD(Action<T, U, V, W> KAIJPPOLHDF);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public sealed class KJLKGHPODEE<T, U, V, W> : global::PEMCDPMKBIF<Action<T, U, V, W>>, global::JMFNCNKEDLD<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x2540B40", Offset = "0x253FB40", VA = "0x182540B40")]
	public KJLKGHPODEE(bool EFAKNGCNKLK = false, bool ADFHHGGIPJM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x29BA700", Offset = "0x29B9700", VA = "0x1829BA700")]
	public void PODJJFBHDBG(T FNGOFIALAJH, U CEFCJNLBMJH, V NDCAPABKMLD, W HNDCAHMOFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x29B9170", Offset = "0x29B8170", VA = "0x1829B9170", Slot = "4")]
	public override void NINBOEBNFJG(object[] AIAEIEGFNFD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x29B8470", Offset = "0x29B7470", VA = "0x1829B8470")]
	public static global::KJLKGHPODEE<T, U, V, W> MCAPNMFNAKO(global::KJLKGHPODEE<T, U, V, W> GKLACFEAMMG, Action<T, U, V, W> KAIJPPOLHDF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x29B83D0", Offset = "0x29B73D0", VA = "0x1829B83D0")]
	public static global::KJLKGHPODEE<T, U, V, W> BDFKJFNDJGN(global::KJLKGHPODEE<T, U, V, W> GKLACFEAMMG, Action<T, U, V, W> KAIJPPOLHDF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface MEIBCENDEHN<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NJFAMEHLCGO(Action<T, U, V, W, X> KAIJPPOLHDF, bool EJPIHOCPCPP = false);

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void INAIIIEHGLD(Action<T, U, V, W, X> KAIJPPOLHDF);
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public sealed class CAKOPNHPIPL<T, U, V, W, X> : global::PEMCDPMKBIF<Action<T, U, V, W, X>>, global::MEIBCENDEHN<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x2540B40", Offset = "0x253FB40", VA = "0x182540B40")]
	public CAKOPNHPIPL(bool EFAKNGCNKLK = false, bool ADFHHGGIPJM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x3063190", Offset = "0x3062190", VA = "0x183063190")]
	public void PODJJFBHDBG(T FNGOFIALAJH, U CEFCJNLBMJH, V NDCAPABKMLD, W HNDCAHMOFNF, X JBEHFGFFAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x3062870", Offset = "0x3061870", VA = "0x183062870", Slot = "4")]
	public override void NINBOEBNFJG(object[] AIAEIEGFNFD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x30627D0", Offset = "0x30617D0", VA = "0x1830627D0")]
	public static global::CAKOPNHPIPL<T, U, V, W, X> MCAPNMFNAKO(global::CAKOPNHPIPL<T, U, V, W, X> GKLACFEAMMG, Action<T, U, V, W, X> KAIJPPOLHDF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x3062730", Offset = "0x3061730", VA = "0x183062730")]
	public static global::CAKOPNHPIPL<T, U, V, W, X> BDFKJFNDJGN(global::CAKOPNHPIPL<T, U, V, W, X> GKLACFEAMMG, Action<T, U, V, W, X> KAIJPPOLHDF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public interface EDKDPNJNIEF<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NJFAMEHLCGO(Action<T, U, V, W, X, Y> KAIJPPOLHDF, bool EJPIHOCPCPP = false);

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void INAIIIEHGLD(Action<T, U, V, W, X, Y> KAIJPPOLHDF);
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public sealed class JPCAJIAOLHC<T, U, V, W, X, Y> : global::PEMCDPMKBIF<Action<T, U, V, W, X, Y>>, global::EDKDPNJNIEF<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x2540B40", Offset = "0x253FB40", VA = "0x182540B40")]
	public JPCAJIAOLHC(bool EFAKNGCNKLK = false, bool ADFHHGGIPJM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x42C6140", Offset = "0x42C5140", VA = "0x1842C6140")]
	public void PODJJFBHDBG(T FNGOFIALAJH, U CEFCJNLBMJH, V NDCAPABKMLD, W HNDCAHMOFNF, X JBEHFGFFAPE, Y GLCMAAPCBBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x42C54C0", Offset = "0x42C44C0", VA = "0x1842C54C0", Slot = "4")]
	public override void NINBOEBNFJG(object[] AIAEIEGFNFD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x42C50D0", Offset = "0x42C40D0", VA = "0x1842C50D0")]
	public static global::JPCAJIAOLHC<T, U, V, W, X, Y> MCAPNMFNAKO(global::JPCAJIAOLHC<T, U, V, W, X, Y> GKLACFEAMMG, Action<T, U, V, W, X, Y> KAIJPPOLHDF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x42C5030", Offset = "0x42C4030", VA = "0x1842C5030")]
	public static global::JPCAJIAOLHC<T, U, V, W, X, Y> BDFKJFNDJGN(global::JPCAJIAOLHC<T, U, V, W, X, Y> GKLACFEAMMG, Action<T, U, V, W, X, Y> KAIJPPOLHDF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public sealed class COBNLOMEFDG<T>
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public readonly struct JDJEGMHFFIC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly global::COBNLOMEFDG<T> GCJBFBJIEEO;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public T MHLLNAFLMHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x2549C10", Offset = "0x2548C10", VA = "0x182549C10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x2549BE0", Offset = "0x2548BE0", VA = "0x182549BE0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x6CD170", Offset = "0x6CC170", VA = "0x1806CD170")]
		public JDJEGMHFFIC(global::COBNLOMEFDG<T> GCJBFBJIEEO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct HFDEAHNNCJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AsyncTaskMethodBuilder<JDJEGMHFFIC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public global::COBNLOMEFDG<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x2548C90", Offset = "0x2547C90", VA = "0x182548C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x253BE00", Offset = "0x253AE00", VA = "0x18253BE00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct AIKCALLBHLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncTaskMethodBuilder<JDJEGMHFFIC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public global::COBNLOMEFDG<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x253BC30", Offset = "0x253AC30", VA = "0x18253BC30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x253BE00", Offset = "0x253AE00", VA = "0x18253BE00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly SemaphoreSlim HLMEFPNBDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private T PFLPPEJJCAC;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int BEBAPCGEBCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x25411B0", Offset = "0x25401B0", VA = "0x1825411B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x25412A0", Offset = "0x25402A0", VA = "0x1825412A0")]
	public COBNLOMEFDG(in T PFLPPEJJCAC, int ODOCFFEKMFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x2541270", Offset = "0x2540270", VA = "0x182541270")]
	public COBNLOMEFDG(in T PFLPPEJJCAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x2541170", Offset = "0x2540170", VA = "0x182541170")]
	public JDJEGMHFFIC GEKDPPEEEMH()
	{
		return default(JDJEGMHFFIC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x2541130", Offset = "0x2540130", VA = "0x182541130")]
	public JDJEGMHFFIC GEKDPPEEEMH(CancellationToken DBKPHPKFAOL)
	{
		return default(JDJEGMHFFIC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x2540CF0", Offset = "0x253FCF0", VA = "0x182540CF0")]
	[AsyncStateMachine(typeof(global::COBNLOMEFDG<>.HFDEAHNNCJO))]
	public Task<JDJEGMHFFIC> ELKCAIGKHMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x2540B70", Offset = "0x253FB70", VA = "0x182540B70")]
	[AsyncStateMachine(typeof(global::COBNLOMEFDG<>.AIKCALLBHLJ))]
	public Task<JDJEGMHFFIC> ELKCAIGKHMF(CancellationToken DBKPHPKFAOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class HNHDNJJHCDF
{
	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x513D830", Offset = "0x513C830", VA = "0x18513D830")]
	public static global::COBNLOMEFDG<PKCLOEDHIOM> PFJGPKGHGPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x513D890", Offset = "0x513C890", VA = "0x18513D890")]
	public static global::COBNLOMEFDG<PKCLOEDHIOM> PFJGPKGHGPI(int ODOCFFEKMFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x1FC5160", Offset = "0x1FC4160", VA = "0x181FC5160")]
	public static global::COBNLOMEFDG<T> PFJGPKGHGPI<T>(in T PFLPPEJJCAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x22844E0", Offset = "0x22834E0", VA = "0x1822844E0")]
	public static global::COBNLOMEFDG<T> PFJGPKGHGPI<T>(in T PFLPPEJJCAC, int ODOCFFEKMFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class GLMKLDKIDGB<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public delegate bool KFOEDAIFGOH(global::GLMKLDKIDGB<T> GHPMKAJMKGM);

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class CKPFKDCDPFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public T nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public global::GLMKLDKIDGB<T> foundNode;

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x1E42690", Offset = "0x1E41690", VA = "0x181E42690")]
		public CKPFKDCDPFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x38953C0", Offset = "0x38943C0", VA = "0x1838953C0")]
		internal bool <FindNode>b__0(global::GLMKLDKIDGB<T> node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public T JLLBHEKBICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public LinkedList<global::GLMKLDKIDGB<T>> BCCNEBJEDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public global::GLMKLDKIDGB<T> EODCJOCKBEI;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public global::GLMKLDKIDGB<T> HBJABBOBDNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x5DF130", Offset = "0x5DE130", VA = "0x1805DF130")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x389FD00", Offset = "0x389ED00", VA = "0x18389FD00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool BOJDFIOLECC
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x38A05A0", Offset = "0x389F5A0", VA = "0x1838A05A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool AMDJOCKIEKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x389FA00", Offset = "0x389EA00", VA = "0x18389FA00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public global::GLMKLDKIDGB<T> CEOKDDJOCEK
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x38A0710", Offset = "0x389F710", VA = "0x1838A0710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x38A1B50", Offset = "0x38A0B50", VA = "0x1838A1B50")]
	public GLMKLDKIDGB(T DDNPFOKIGFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x38A1310", Offset = "0x38A0310", VA = "0x1838A1310")]
	public global::GLMKLDKIDGB<T> MNLCJBPDOKN(T HIHCFNMMGAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x38A03D0", Offset = "0x389F3D0", VA = "0x1838A03D0")]
	public global::GLMKLDKIDGB<T> GGGCIJFADNG(T FFDHKBOCBCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x38A0660", Offset = "0x389F660", VA = "0x1838A0660")]
	public global::GLMKLDKIDGB<T> INAIIIEHGLD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x389F760", Offset = "0x389E760", VA = "0x18389F760")]
	public void BFHLNDADIAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x389FB10", Offset = "0x389EB10", VA = "0x18389FB10")]
	public global::GLMKLDKIDGB<T> DNGDLPAECFP(T EBIOPMCBHMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x38A1770", Offset = "0x38A0770", VA = "0x1838A1770")]
	public static void NKBHBOLOAHC(global::GLMKLDKIDGB<T> NJNOCJJPOHM, KFOEDAIFGOH ACLOJAAMGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x2DE6B50", Offset = "0x2DE5B50", VA = "0x182DE6B50")]
	public static void NKBHBOLOAHC<A>(global::GLMKLDKIDGB<T> NJNOCJJPOHM, Func<global::GLMKLDKIDGB<T>, A, bool> ACLOJAAMGGL, A KJHLPNDFFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x38A0CE0", Offset = "0x389FCE0", VA = "0x1838A0CE0")]
	public static string MHFJGJPKPAC(global::GLMKLDKIDGB<T> NJNOCJJPOHM, int EBFLECLDFLM = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x389FFF0", Offset = "0x389EFF0", VA = "0x18389FFF0")]
	public static global::GLMKLDKIDGB<T> FABHMJCECNP(global::GLMKLDKIDGB<T> NJNOCJJPOHM, T IEKFFKKABHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class GHFBOKABDDJ<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public delegate Task<TResult> FKCALCPFDMM(TRequest ABKBIBODPME, CancellationToken DBKPHPKFAOL);

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public enum FAFFFINBPPL
	{
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class CLNJBJCEFCP
	{
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private const float MIIEMBKKAHL = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private TimeSpan CJGNKBIIKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public int NAJIHKEMOCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public FAFFFINBPPL MILJPBNNEIJ;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public static readonly CLNJBJCEFCP LDOCOAFJGDF;

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public float HGIHCCCMDOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x3895520", Offset = "0x3894520", VA = "0x183895520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public TimeSpan JLFIAJEAGDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x58C1D0", Offset = "0x58B1D0", VA = "0x18058C1D0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x3895600", Offset = "0x3894600", VA = "0x183895600")]
		public CLNJBJCEFCP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private readonly struct MDMCHILIECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public readonly TRequest ABKBIBODPME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public readonly CancellationToken DBKPHPKFAOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public readonly TaskCompletionSource<TResult> EJFDKHGHKPD;

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x38A3B20", Offset = "0x38A2B20", VA = "0x1838A3B20")]
		public MDMCHILIECN(TRequest ABKBIBODPME, TaskCompletionSource<TResult> EJFDKHGHKPD, CancellationToken DBKPHPKFAOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class KNNDLIOGBJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x1E42690", Offset = "0x1E41690", VA = "0x181E42690")]
		public KNNDLIOGBJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x1E42C60", Offset = "0x1E41C60", VA = "0x181E42C60")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private struct FFHLBCIILAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public global::GHFBOKABDDJ<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x38960C0", Offset = "0x38950C0", VA = "0x1838960C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x7EDFE0", Offset = "0x7ECFE0", VA = "0x1807EDFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private struct JCELJFMBOBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public global::GHFBOKABDDJ<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private MDMCHILIECN <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x38A1CF0", Offset = "0x38A0CF0", VA = "0x1838A1CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x7EDFE0", Offset = "0x7ECFE0", VA = "0x1807EDFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly CancellationTokenSource HAEGLNEEFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly List<MDMCHILIECN> DIOFFGJIHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private readonly CLNJBJCEFCP GEGFILIPFMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly FKCALCPFDMM IGOBOMHIFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private Task MJOOCOEEFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private int PDDGHJDIMNN;

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x3899430", Offset = "0x3898430", VA = "0x183899430")]
	public GHFBOKABDDJ(FKCALCPFDMM IGOBOMHIFHP, [Optional] CLNJBJCEFCP GEGFILIPFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x3897EF0", Offset = "0x3896EF0", VA = "0x183897EF0")]
	public Task<TResult> GLMINCJBIDN(TRequest ABKBIBODPME, CancellationToken DBKPHPKFAOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x3898740", Offset = "0x3897740", VA = "0x183898740")]
	private void HGNFCPMOICN(MDMCHILIECN HHBKMJCEPPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x3897B70", Offset = "0x3896B70", VA = "0x183897B70")]
	[AsyncStateMachine(typeof(global::GHFBOKABDDJ<, >.FFHLBCIILAC))]
	private Task GANALGBPGGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x3898B40", Offset = "0x3897B40", VA = "0x183898B40")]
	private MDMCHILIECN OMABACPMAPK()
	{
		return default(MDMCHILIECN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x3898900", Offset = "0x3897900", VA = "0x183898900")]
	[AsyncStateMachine(typeof(global::GHFBOKABDDJ<, >.JCELJFMBOBC))]
	private Task KLKBLOFCHPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x3898470", Offset = "0x3897470", VA = "0x183898470")]
	private void HDMKOEKIHNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x3897910", Offset = "0x3896910", VA = "0x183897910", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class GIFBNMFGAPH<TKey, TVal> : global::OHMJFHLLJCF<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private int JFPIAPFGODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	internal Dictionary<TKey, (TVal value, int size)> PMOACLHGJLC;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	internal override int PLBEBGCDJEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x3899C10", Offset = "0x3898C10", VA = "0x183899C10", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	internal int IEIIPCMEKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x3899BE0", Offset = "0x3898BE0", VA = "0x183899BE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public override int AGNENIFEHDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x3899C40", Offset = "0x3898C40", VA = "0x183899C40", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x3899E70", Offset = "0x3898E70", VA = "0x183899E70")]
	public GIFBNMFGAPH(int EHCFCNDLJCD, [Optional] NLFCAMLMMAE CFIFCNOLNHJ, [Optional] IEqualityComparer<TKey> NLOLADHCGOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x38999C0", Offset = "0x38989C0", VA = "0x1838999C0")]
	public void APLKELJOPAF(TKey DDFHJDPPNBF, TVal BMNJAHFFOPC, bool ICMKGDLJOPK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x3899D50", Offset = "0x3898D50", VA = "0x183899D50")]
	public bool OJDKCBPNKJH(TKey DDFHJDPPNBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x3899CA0", Offset = "0x3898CA0", VA = "0x183899CA0", Slot = "6")]
	public override bool NOGIDOCGHEN(TKey OJCADKGKNPA, out TVal BMNJAHFFOPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x3899790", Offset = "0x3898790", VA = "0x183899790")]
	public bool AJHHJAJOGMJ(TKey DDFHJDPPNBF, TVal BMNJAHFFOPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x3899AD0", Offset = "0x3898AD0", VA = "0x183899AD0")]
	public bool CECMIPIBCNB(TKey DDFHJDPPNBF, TVal BMNJAHFFOPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x3899A60", Offset = "0x3898A60", VA = "0x183899A60", Slot = "7")]
	public override void BFHLNDADIAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x3899DD0", Offset = "0x3898DD0", VA = "0x183899DD0")]
	private bool OMCHOOJINNA(TKey DDFHJDPPNBF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[DefaultMember("Item")]
public class OHMJFHLLJCF<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public delegate int NLFCAMLMMAE(TKey DDFHJDPPNBF, TVal BMNJAHFFOPC);

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private class IFOMJIDIKBF
	{
		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public TKey LEAFJIBNHBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x58C1D0", Offset = "0x58B1D0", VA = "0x18058C1D0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public TVal MHLLNAFLMHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x6BAC80", Offset = "0x6B9C80", VA = "0x1806BAC80")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x7609D0", Offset = "0x75F9D0", VA = "0x1807609D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public int BEKDBNBHEAN
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x6DE5D0", Offset = "0x6DD5D0", VA = "0x1806DE5D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x6DE600", Offset = "0x6DD600", VA = "0x1806DE600")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public DateTime EDNCIHGGFPL
		{
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0x58EDF0", Offset = "0x58DDF0", VA = "0x18058EDF0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0x14CE960", Offset = "0x14CD960", VA = "0x1814CE960")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x457AC10", Offset = "0x4579C10", VA = "0x18457AC10")]
		public IFOMJIDIKBF(TKey DDFHJDPPNBF, TVal OOEOCFOBJLO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public const int MFFOBGIPMBP = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly Dictionary<TKey, LinkedListNode<IFOMJIDIKBF>> FLBEPMHGPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly LinkedList<IFOMJIDIKBF> CLBPJFBJGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	protected readonly NLFCAMLMMAE CFIFCNOLNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly TimeSpan OMKOCONIDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly GJMLMIBBIAE HIPMIHMOGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private int MDFFACCFPNO;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public int CJBLCFKBIJI
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x6E79D0", Offset = "0x6E69D0", VA = "0x1806E79D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	private bool BGMDKDCKOPN
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x457E9D0", Offset = "0x457D9D0", VA = "0x18457E9D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	internal virtual int PLBEBGCDJEL
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6E79E0", Offset = "0x6E69E0", VA = "0x1806E79E0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	private int NGOMPCKMIBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x20A74C0", Offset = "0x20A64C0", VA = "0x1820A74C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public virtual int AGNENIFEHDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x1E9FA30", Offset = "0x1E9EA30", VA = "0x181E9FA30", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public IEnumerable<TKey> BCLGOBIPCIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x457E650", Offset = "0x457D650", VA = "0x18457E650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public TVal HLNIIBDGPEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x2DE3000", Offset = "0x2DE2000", VA = "0x182DE3000")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x214A100", Offset = "0x2149100", VA = "0x18214A100")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x457F9D0", Offset = "0x457E9D0", VA = "0x18457F9D0")]
	public OHMJFHLLJCF(int EHCFCNDLJCD, [Optional] NLFCAMLMMAE CFIFCNOLNHJ, [Optional] IEqualityComparer<TKey> NLOLADHCGOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x457FCF0", Offset = "0x457ECF0", VA = "0x18457FCF0")]
	public OHMJFHLLJCF(TimeSpan OMKOCONIDBP, [Optional] IEqualityComparer<TKey> NLOLADHCGOP, [Optional] GJMLMIBBIAE HIPMIHMOGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x457F980", Offset = "0x457E980", VA = "0x18457F980")]
	public OHMJFHLLJCF(int EHCFCNDLJCD, TimeSpan OMKOCONIDBP, [Optional] IEqualityComparer<TKey> NLOLADHCGOP, [Optional] GJMLMIBBIAE HIPMIHMOGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x457FAA0", Offset = "0x457EAA0", VA = "0x18457FAA0")]
	public OHMJFHLLJCF(int EHCFCNDLJCD, NLFCAMLMMAE CFIFCNOLNHJ, TimeSpan OMKOCONIDBP, [Optional] IEqualityComparer<TKey> NLOLADHCGOP, [Optional] GJMLMIBBIAE HIPMIHMOGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x457F460", Offset = "0x457E460", VA = "0x18457F460")]
	public void OPLKNDGBNCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x457F0F0", Offset = "0x457E0F0", VA = "0x18457F0F0")]
	public void MLBPEOBGAOB(TKey DDFHJDPPNBF, TVal BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x457E870", Offset = "0x457D870", VA = "0x18457E870")]
	public bool INAIIIEHGLD(TKey DDFHJDPPNBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x457F5D0", Offset = "0x457E5D0", VA = "0x18457F5D0")]
	private TVal PPHNCEKAGCA(TKey OJCADKGKNPA)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x457F1B0", Offset = "0x457E1B0", VA = "0x18457F1B0", Slot = "6")]
	public virtual bool NOGIDOCGHEN(TKey OJCADKGKNPA, out TVal BMNJAHFFOPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x457DF00", Offset = "0x457CF00", VA = "0x18457DF00", Slot = "7")]
	public virtual void BFHLNDADIAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x457EF70", Offset = "0x457DF70", VA = "0x18457EF70")]
	private bool LDJMKOHKDFO(IFOMJIDIKBF KCKMIGNLMHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x457EA60", Offset = "0x457DA60", VA = "0x18457EA60")]
	private void KGMEFLGDMLC(LinkedListNode<IFOMJIDIKBF> DGBBGELAOOE, TVal NDDDMNCCDPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x457E480", Offset = "0x457D480", VA = "0x18457E480")]
	private void GLIJNCAGDLH(TKey DDFHJDPPNBF, TVal BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x457DF70", Offset = "0x457CF70", VA = "0x18457DF70")]
	private void DHJACOMAICP(IFOMJIDIKBF KCKMIGNLMHP, TVal NDDDMNCCDPF, int LIDEIIACKPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[DefaultMember("Item")]
public class HGBADFEGHMG<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly List<T> NNKFFLIIPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private HashSet<T> HCPIDDKPDHB;

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public int AGNENIFEHDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x1E42C60", Offset = "0x1E41C60", VA = "0x181E42C60", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public bool HBFNBGIFOHM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x58CEC0", Offset = "0x58BEC0", VA = "0x18058CEC0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public T HLNIIBDGPEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x21EC340", Offset = "0x21EB340", VA = "0x1821EC340", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x21EC430", Offset = "0x21EB430", VA = "0x1821EC430", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x21EB990", Offset = "0x21EA990", VA = "0x1821EB990", Slot = "11")]
	public void Add(T OMLEPPBGLGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x21EBF10", Offset = "0x21EAF10", VA = "0x1821EBF10")]
	public bool OIJIJCLDMLM(T OMLEPPBGLGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x21EC1E0", Offset = "0x21EB1E0", VA = "0x1821EC1E0", Slot = "15")]
	public bool Remove(T OMLEPPBGLGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x21EBBF0", Offset = "0x21EABF0", VA = "0x1821EBBF0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x1FF17E0", Offset = "0x1FF07E0", VA = "0x181FF17E0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x21EB9C0", Offset = "0x21EA9C0", VA = "0x1821EB9C0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x215B4C0", Offset = "0x215A4C0", VA = "0x18215B4C0", Slot = "13")]
	public bool Contains(T OMLEPPBGLGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x21EBA20", Offset = "0x21EAA20", VA = "0x1821EBA20", Slot = "14")]
	public void CopyTo(T[] PEGJLEIKJED, int IBMIEACPLPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x21EBC70", Offset = "0x21EAC70", VA = "0x1821EBC70", Slot = "6")]
	public int IndexOf(T OMLEPPBGLGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x21EBCA0", Offset = "0x21EACA0", VA = "0x1821EBCA0", Slot = "7")]
	public void Insert(int FBOCJCCNMND, T OMLEPPBGLGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x21EC080", Offset = "0x21EB080", VA = "0x1821EC080", Slot = "8")]
	public void RemoveAt(int FBOCJCCNMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x21EBB20", Offset = "0x21EAB20", VA = "0x1821EBB20")]
	public void EHLNFFCEBEA(Predicate<T> MDMGEIKDFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x21EBE30", Offset = "0x21EAE30", VA = "0x1821EBE30")]
	public void OIDKPLBCJNG(Comparison<T> PEFLILPELMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x21EC260", Offset = "0x21EB260", VA = "0x1821EC260")]
	public HGBADFEGHMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public static class GDDIEFJIEMM
{
	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x513D0F0", Offset = "0x513C0F0", VA = "0x18513D0F0")]
	public static Vector3 BENGOEHFBIE(this GameObject EMHOKENKLPP, float HJKHNDNCEIA)
	{
		return default(Vector3);
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x220B6E0", Offset = "0x220A6E0", VA = "0x18220B6E0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x5142760", Offset = "0x5141760", VA = "0x185142760")]
		public SerializedGuid(in Guid OJJMLFLBLOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x51422B0", Offset = "0x51412B0", VA = "0x1851422B0")]
		public static SerializedGuid AIBIKBIIMPF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x51426E0", Offset = "0x51416E0", VA = "0x1851426E0")]
		public static SerializedGuid POKBFKNMDLH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x51424E0", Offset = "0x51414E0", VA = "0x1851424E0")]
		public bool GIJJPCDDGMA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x51426B0", Offset = "0x51416B0", VA = "0x1851426B0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x5142610", Offset = "0x5141610", VA = "0x185142610", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x5142580", Offset = "0x5141580", VA = "0x185142580")]
		public bool LBIHKFOCCFJ(in Guid OJJMLFLBLOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x5142360", Offset = "0x5141360", VA = "0x185142360", Slot = "7")]
		public bool Equals(SerializedGuid INIEAOGGCLC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x5142400", Offset = "0x5141400", VA = "0x185142400", Slot = "0")]
		public override bool Equals(object OOJKHPLJJMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x5142570", Offset = "0x5141570", VA = "0x185142570", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x5142330", Offset = "0x5141330", VA = "0x185142330", Slot = "6")]
		public int CompareTo(SerializedGuid INIEAOGGCLC)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class BCDFBNABHNC : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public readonly Type IMCOFDHPANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public readonly string JCBCECHDEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public readonly bool LFMLCKLGNBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public readonly bool LGLJMLGBEKN;

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x513B3F0", Offset = "0x513A3F0", VA = "0x18513B3F0")]
	public BCDFBNABHNC(Type COACPJAKNCP, string OBPOEJJAKGH, bool KKGHLCIAFCM = false, bool PEJKFCIHPKH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public interface ONMOMCBNHCG
{
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public interface ANLDALLGHLD<T> : ONMOMCBNHCG
{
	[Cpp2IlInjected.Token(Token = "0x17000079")]
	T MHLLNAFLMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	bool ANBHIMKHPOF
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	string CIBBFOGBHFK
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::ANLDALLGHLD<T> IOJHDGBIMNA(Action<T> MHKFHFBFCIM);

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::ANLDALLGHLD<T> AGDFDKJBKCA(Action<T> MHKFHFBFCIM);

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::ANLDALLGHLD<T> MHNGLNGBJPH(Action<T, T> FAEHBDNPMHN);

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::ANLDALLGHLD<T> EOMAMHGINIK(Action<T, T> FAEHBDNPMHN);

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::ANLDALLGHLD<T> IELGEIPBJNH(Action<string> PLLJMGDLBOE);

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::ANLDALLGHLD<T> MEAFNFJGOJD(Action<string> PLLJMGDLBOE);
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class GIMCFFHBIEC<T> : global::ANLDALLGHLD<T>, ONMOMCBNHCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private global::IBGBLHJEHKG<T, T> AKOKPLLOFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private global::ADIPIMHFLAB<T> NHBLIPLEDOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private global::ADIPIMHFLAB<string> MBBNNJHNFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private string JGBFMLFAGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private T IMDEFJLGKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private bool AACICAMEHGG;

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public T MHLLNAFLMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x5B4A30", Offset = "0x5B3A30", VA = "0x1805B4A30", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x2376E30", Offset = "0x2375E30", VA = "0x182376E30", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public bool ANBHIMKHPOF
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x60E8B0", Offset = "0x60D8B0", VA = "0x18060E8B0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public string CIBBFOGBHFK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x5B50C0", Offset = "0x5B40C0", VA = "0x1805B50C0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x214B1D0", Offset = "0x214A1D0", VA = "0x18214B1D0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x3899FA0", Offset = "0x3898FA0", VA = "0x183899FA0")]
	private void CHAOBMPPLCP(T KBOOFLMIFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x389A120", Offset = "0x3899120", VA = "0x18389A120")]
	private void IIGFBOLMMDE(string EOGLFEOLNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x389A310", Offset = "0x3899310", VA = "0x18389A310")]
	public void MKJDECMAJIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x389A2C0", Offset = "0x38992C0", VA = "0x18389A2C0", Slot = "6")]
	public global::ANLDALLGHLD<T> MHNGLNGBJPH(Action<T, T> FAEHBDNPMHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x389A040", Offset = "0x3899040", VA = "0x18389A040", Slot = "7")]
	public global::ANLDALLGHLD<T> EOMAMHGINIK(Action<T, T> FAEHBDNPMHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x389A1C0", Offset = "0x38991C0", VA = "0x18389A1C0", Slot = "4")]
	public global::ANLDALLGHLD<T> IOJHDGBIMNA(Action<T> FAEHBDNPMHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x3899F50", Offset = "0x3898F50", VA = "0x183899F50", Slot = "5")]
	public global::ANLDALLGHLD<T> AGDFDKJBKCA(Action<T> MHKFHFBFCIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x389A090", Offset = "0x3899090", VA = "0x18389A090", Slot = "8")]
	public global::ANLDALLGHLD<T> IELGEIPBJNH(Action<string> PLLJMGDLBOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x389A250", Offset = "0x3899250", VA = "0x18389A250", Slot = "9")]
	public global::ANLDALLGHLD<T> MEAFNFJGOJD(Action<string> PLLJMGDLBOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x389A3C0", Offset = "0x38993C0", VA = "0x18389A3C0")]
	public GIMCFFHBIEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public static class GGBHKMIFNBG
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class NJCOAGGFBGO<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public global::ANLDALLGHLD<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public global::AADOKEPFDDG<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x1E42690", Offset = "0x1E41690", VA = "0x181E42690")]
		public NJCOAGGFBGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x320BAB0", Offset = "0x320AAB0", VA = "0x18320BAB0")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x2AA1CD0", Offset = "0x2AA0CD0", VA = "0x182AA1CD0")]
	public static global::IHDAFNHGAJF<T> CGPDFDLOGCM<T>(this global::ANLDALLGHLD<T> JDAMGPPHHHN, Action<T> ACDPINKOGPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public class JMCOHHGCFDO<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public readonly struct GCCPGDOAEDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public readonly long MKKADDHGALJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public readonly long DLCGCOOHKEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public readonly int JHGDOHMGILB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public readonly int IDAPBILHEPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public readonly bool GJKKIBLMKGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private readonly string LIDMHEPJLAC;

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x42B71E0", Offset = "0x42B61E0", VA = "0x1842B71E0")]
		public GCCPGDOAEDD(long MKKADDHGALJ, int JHGDOHMGILB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x42B71B0", Offset = "0x42B61B0", VA = "0x1842B71B0")]
		public GCCPGDOAEDD(long MKKADDHGALJ, long DLCGCOOHKEF, int JHGDOHMGILB, int IDAPBILHEPI, bool GJKKIBLMKGM, string LIDMHEPJLAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x42B7140", Offset = "0x42B6140", VA = "0x1842B7140")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void OBLMFNHPKDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x42B70F0", Offset = "0x42B60F0", VA = "0x1842B70F0")]
		public int EKBANEOGKKE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x42B6FA0", Offset = "0x42B5FA0", VA = "0x1842B6FA0")]
		public int ACHNNLCGJHO(int HFKLIFOMPKO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x42B7080", Offset = "0x42B6080", VA = "0x1842B7080")]
		public double DFIDNMJHAAI()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x42B6FC0", Offset = "0x42B5FC0", VA = "0x1842B6FC0")]
		public GCCPGDOAEDD AJEALHKPPFO(long DLCGCOOHKEF, int IDAPBILHEPI)
		{
			return default(GCCPGDOAEDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public class ECKKNIKHLKB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public readonly TKey LEAFJIBNHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private readonly global::JMCOHHGCFDO<TKey> LKHJGGJDDIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private List<ECKKNIKHLKB> JGELIDMLHKM;

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public string NJALEMBHIBL
		{
			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x1E42A10", Offset = "0x1E41A10", VA = "0x181E42A10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x2386B40", Offset = "0x2385B40", VA = "0x182386B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public IEnumerable<ECKKNIKHLKB> BCCNEBJEDNM
		{
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x42B68D0", Offset = "0x42B58D0", VA = "0x1842B68D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public GCCPGDOAEDD OBDAGMIEHFA
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x1063910", Offset = "0x1062910", VA = "0x181063910")]
			[CompilerGenerated]
			get
			{
				return default(GCCPGDOAEDD);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x42B68A0", Offset = "0x42B58A0", VA = "0x1842B68A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x42B6A00", Offset = "0x42B5A00", VA = "0x1842B6A00")]
		internal ECKKNIKHLKB(global::JMCOHHGCFDO<TKey> LKHJGGJDDIP, TKey DDFHJDPPNBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x42B68F0", Offset = "0x42B58F0", VA = "0x1842B68F0")]
		public ECKKNIKHLKB LAFMJBFPEDG(TKey DDFHJDPPNBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x42B65E0", Offset = "0x42B55E0", VA = "0x1842B65E0")]
		public void BNJJDGHLLIE(TKey DDFHJDPPNBF, Action<ECKKNIKHLKB> KAIJPPOLHDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x2130610", Offset = "0x212F610", VA = "0x182130610")]
		public T BNJJDGHLLIE<T>(TKey DDFHJDPPNBF, Func<ECKKNIKHLKB, T> CDPFCGNCMDM)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x1FBC6A0", Offset = "0x1FBB6A0", VA = "0x181FBC6A0")]
		[AsyncStateMachine(typeof(EEFEPNMLPML))]
		public Task<T> FONBJBJLJOP<T>(TKey DDFHJDPPNBF, Func<ECKKNIKHLKB, Task<T>> CDPFCGNCMDM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x42B66E0", Offset = "0x42B56E0", VA = "0x1842B66E0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class DELANEBPIEH : IEnumerable<(TKey, List<TKey>, GCCPGDOAEDD)>, IEnumerable, IEnumerator<(TKey, List<TKey>, GCCPGDOAEDD)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private (TKey key, List<TKey> path, GCCPGDOAEDD timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public global::JMCOHHGCFDO<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private IEnumerator<(TKey key, List<TKey> path, GCCPGDOAEDD timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		private (TKey, List<TKey>, GCCPGDOAEDD) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x3AE6960", Offset = "0x3AE5960", VA = "0x183AE6960", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, GCCPGDOAEDD));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x42B64B0", Offset = "0x42B54B0", VA = "0x1842B64B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x3DC1DB0", Offset = "0x3DC0DB0", VA = "0x183DC1DB0")]
		[DebuggerHidden]
		public DELANEBPIEH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x42B6510", Offset = "0x42B5510", VA = "0x1842B6510", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x42B6130", Offset = "0x42B5130", VA = "0x1842B6130", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x42B6590", Offset = "0x42B5590", VA = "0x1842B6590")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x42B6460", Offset = "0x42B5460", VA = "0x1842B6460", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x42B63A0", Offset = "0x42B53A0", VA = "0x1842B63A0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, GCCPGDOAEDD)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x1FFD070", Offset = "0x1FFC070", VA = "0x181FFD070", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private sealed class BDDLIFOKELJ : IEnumerable<(TKey, List<TKey>, GCCPGDOAEDD)>, IEnumerable, IEnumerator<(TKey, List<TKey>, GCCPGDOAEDD)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private (TKey key, List<TKey> path, GCCPGDOAEDD timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private ECKKNIKHLKB timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public ECKKNIKHLKB <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public global::JMCOHHGCFDO<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private IEnumerator<ECKKNIKHLKB> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private IEnumerator<(TKey key, List<TKey> path, GCCPGDOAEDD timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		private (TKey, List<TKey>, GCCPGDOAEDD) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x3AE6960", Offset = "0x3AE5960", VA = "0x183AE6960", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, GCCPGDOAEDD));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x42B5F60", Offset = "0x42B4F60", VA = "0x1842B5F60", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x3DC1DB0", Offset = "0x3DC0DB0", VA = "0x183DC1DB0")]
		[DebuggerHidden]
		public BDDLIFOKELJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x42B5FC0", Offset = "0x42B4FC0", VA = "0x1842B5FC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x42B5900", Offset = "0x42B4900", VA = "0x1842B5900", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x42B6090", Offset = "0x42B5090", VA = "0x1842B6090")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x42B60E0", Offset = "0x42B50E0", VA = "0x1842B60E0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x42B5F10", Offset = "0x42B4F10", VA = "0x1842B5F10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x42B5E40", Offset = "0x42B4E40", VA = "0x1842B5E40", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, GCCPGDOAEDD)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x27F7CD0", Offset = "0x27F6CD0", VA = "0x1827F7CD0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly Action<TKey, GCCPGDOAEDD> BMAKJJMPGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly Action<TKey, GCCPGDOAEDD> NDPLKDCLLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly Action<global::JMCOHHGCFDO<TKey>> NMLDCEGHFBI;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private const string FFKGFPABLBJ = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly ECKKNIKHLKB PAKLJFJEOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private bool KMDCHDFHKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private int FKMPIPPCDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly Stopwatch POIHHIFEBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public readonly int CKJGGKICNPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private string HEOOPEOAOAM;

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public ECKKNIKHLKB LICMNCLEODF
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x5B50C0", Offset = "0x5B40C0", VA = "0x1805B50C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	[NotNull]
	public string NJALEMBHIBL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x5DF130", Offset = "0x5DE130", VA = "0x1805DF130")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x42C37D0", Offset = "0x42C27D0", VA = "0x1842C37D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public long KNKOEFICKIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x42C34E0", Offset = "0x42C24E0", VA = "0x1842C34E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public int DPPKNFONHEN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x42C3590", Offset = "0x42C2590", VA = "0x1842C3590")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x42C3830", Offset = "0x42C2830", VA = "0x1842C3830")]
	public JMCOHHGCFDO(TKey POFPHOPKBHF, [Optional] int? JHGDOHMGILB, [Optional][CanBeNull] Stopwatch POIHHIFEBAF, [Optional] Action<TKey, GCCPGDOAEDD> BMAKJJMPGHG, [Optional] Action<TKey, GCCPGDOAEDD> NDPLKDCLLAC, [Optional] Action<global::JMCOHHGCFDO<TKey>> NMLDCEGHFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x42C3500", Offset = "0x42C2500", VA = "0x1842C3500", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x42C34C0", Offset = "0x42C24C0", VA = "0x1842C34C0")]
	public void BDHKLBCGACP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x42C3720", Offset = "0x42C2720", VA = "0x1842C3720")]
	public void HNAJIOAJLOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x42C3690", Offset = "0x42C2690", VA = "0x1842C3690")]
	[IteratorStateMachine(typeof(global::JMCOHHGCFDO<>.DELANEBPIEH))]
	public IEnumerable<(TKey, List<TKey>, GCCPGDOAEDD)> GMGICIMKCEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x42C35C0", Offset = "0x42C25C0", VA = "0x1842C35C0")]
	[IteratorStateMachine(typeof(global::JMCOHHGCFDO<>.BDDLIFOKELJ))]
	private IEnumerable<(TKey, List<TKey>, GCCPGDOAEDD)> GMGICIMKCEH(List<TKey> JOFDAALAADD, ECKKNIKHLKB NIMLLDKKLDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x42C3740", Offset = "0x42C2740", VA = "0x1842C3740")]
	private (long, int) OFCKIEEMAPD()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public abstract class CDIPOOFHKNB<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut GMDPGAOCAPF(global::JMCOHHGCFDO<TKey> LKHJGGJDDIP);

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x1E42690", Offset = "0x1E41690", VA = "0x181E42690")]
	protected CDIPOOFHKNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public abstract class EJJPPBLJGDA<TKey> : global::CDIPOOFHKNB<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public delegate string ELHNKELMJGA(TKey DDFHJDPPNBF);

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x4327920", Offset = "0x4326920", VA = "0x184327920")]
	protected string MGLBKLNBNEO(double BAFEBEGEIDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x4327980", Offset = "0x4326980", VA = "0x184327980")]
	protected string NIPEHPHHCCD(int LOBHBDPNGCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x4327710", Offset = "0x4326710", VA = "0x184327710")]
	private static string GKCJLJKADEB(TKey DDFHJDPPNBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x4327750", Offset = "0x4326750", VA = "0x184327750", Slot = "4")]
	public override string GMDPGAOCAPF(global::JMCOHHGCFDO<TKey> LKHJGGJDDIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x4327800", Offset = "0x4326800", VA = "0x184327800")]
	public string GMDPGAOCAPF(global::JMCOHHGCFDO<TKey> LKHJGGJDDIP, [NotNull] ELHNKELMJGA NGMJCDLNIFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string GIICJCOKJHA(global::JMCOHHGCFDO<TKey> LKHJGGJDDIP, [NotNull] ELHNKELMJGA NGMJCDLNIFK);

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x1FF81D0", Offset = "0x1FF71D0", VA = "0x181FF81D0")]
	protected EJJPPBLJGDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public class LACHIAACBLI<TKey> : global::CDIPOOFHKNB<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public delegate string BHGONHGIDKH(TKey DDFHJDPPNBF);

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private const int HMEJHBBJCBP = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly string PEBCJINDPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly double IBPLMCDGMKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly bool CGAMKEHDKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly int HCOINIMBDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly ISet<string> AKFFHOALEND;

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x3189E60", Offset = "0x3188E60", VA = "0x183189E60")]
	private static string GKCJLJKADEB(TKey DDFHJDPPNBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x318A3F0", Offset = "0x31893F0", VA = "0x18318A3F0")]
	public LACHIAACBLI(string PEBCJINDPHG = "F2", double IBPLMCDGMKB = double.MaxValue, bool CGAMKEHDKDE = false, int HCOINIMBDHP = int.MaxValue, [Optional] ISet<string> AKFFHOALEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x318A340", Offset = "0x3189340", VA = "0x18318A340", Slot = "4")]
	public override Dictionary<string, string> GMDPGAOCAPF(global::JMCOHHGCFDO<TKey> LKHJGGJDDIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x3189A70", Offset = "0x3188A70", VA = "0x183189A70")]
	private bool EIJOPFDPION(string KNLIBGAGDJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x3189EA0", Offset = "0x3188EA0", VA = "0x183189EA0")]
	public Dictionary<string, string> GMDPGAOCAPF(global::JMCOHHGCFDO<TKey> LKHJGGJDDIP, BHGONHGIDKH NGMJCDLNIFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x3189CB0", Offset = "0x3188CB0", VA = "0x183189CB0")]
	private string FADAGIMEAPA(StringBuilder JPLGNBGFCIA, List<TKey> KKCOGJPCGHC, BHGONHGIDKH NGMJCDLNIFK, bool NDEOIGHGEAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x3189B50", Offset = "0x3188B50", VA = "0x183189B50")]
	private static void EPJMBOFPMIP(StringBuilder OFOLHABDHME, string PNEAMLCPDCJ, bool IAIIMOHPGNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public class LOKFGNDFAJN<TKey> : global::EJJPPBLJGDA<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private struct CDBAMODNJCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public ELHNKELMJGA keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public static global::LOKFGNDFAJN<TKey> LOBJDNDFAIF;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private const int PPLPNFBFNLB = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly string[] HHKBDJNMKIA;

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x27F6120", Offset = "0x27F5120", VA = "0x1827F6120")]
	private LOKFGNDFAJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x27F5120", Offset = "0x27F4120", VA = "0x1827F5120", Slot = "5")]
	protected override string GIICJCOKJHA(global::JMCOHHGCFDO<TKey> LKHJGGJDDIP, ELHNKELMJGA NGMJCDLNIFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x27F5F40", Offset = "0x27F4F40", VA = "0x1827F5F40")]
	[CompilerGenerated]
	internal static string JOOBJEPKMHF(string INOBMBDFOIA, TKey DDFHJDPPNBF, ref CDBAMODNJCF P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public class IKKGOMPPEEL<TKey> : global::EJJPPBLJGDA<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class LPDFENLDMCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public ELHNKELMJGA keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x1E42690", Offset = "0x1E41690", VA = "0x181E42690")]
		public LPDFENLDMCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x215E270", Offset = "0x215D270", VA = "0x18215E270")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x3BE5060", Offset = "0x3BE4060", VA = "0x183BE5060", Slot = "5")]
	protected override string GIICJCOKJHA(global::JMCOHHGCFDO<TKey> LKHJGGJDDIP, ELHNKELMJGA NGMJCDLNIFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x27F6480", Offset = "0x27F5480", VA = "0x1827F6480")]
	public IKKGOMPPEEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public sealed class HINKLBOILHJ : global::JMCOHHGCFDO<string>
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class EMDDHBKPAAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public Action<HINKLBOILHJ> callback;

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public EMDDHBKPAAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x513BE80", Offset = "0x513AE80", VA = "0x18513BE80")]
		internal void <Wrap>b__0(global::JMCOHHGCFDO<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x513D710", Offset = "0x513C710", VA = "0x18513D710")]
	public HINKLBOILHJ([Optional] string PODLDNMMGJC, [Optional] int? JHGDOHMGILB, [Optional] Stopwatch POIHHIFEBAF, [Optional] Action<string, GCCPGDOAEDD> BMAKJJMPGHG, [Optional] Action<string, GCCPGDOAEDD> NDPLKDCLLAC, [Optional] Action<HINKLBOILHJ> NMLDCEGHFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x513D650", Offset = "0x513C650", VA = "0x18513D650")]
	private static Action<global::JMCOHHGCFDO<string>> BNJJDGHLLIE(Action<HINKLBOILHJ> ACDPINKOGPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public abstract class GJMLMIBBIAE
{
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	private class AGADCEHAEHN : GJMLMIBBIAE
	{
		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public static GJMLMIBBIAE LOBJDNDFAIF
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x513ADE0", Offset = "0x5139DE0", VA = "0x18513ADE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public override DateTime KEHJMFIIOEK
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x513AD80", Offset = "0x5139D80", VA = "0x18513AD80", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public override float FMCNJLPAIJF
		{
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x513ADD0", Offset = "0x5139DD0", VA = "0x18513ADD0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x513AEE0", Offset = "0x5139EE0", VA = "0x18513AEE0")]
		public AGADCEHAEHN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private static GJMLMIBBIAE JBGONCFIOJB;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public static GJMLMIBBIAE LDOCOAFJGDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x513D380", Offset = "0x513C380", VA = "0x18513D380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public abstract DateTime KEHJMFIIOEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public abstract float FMCNJLPAIJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	protected GJMLMIBBIAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class PAPMMKENJMI : global::DJMBNLLLGLC<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x51406B0", Offset = "0x513F6B0", VA = "0x1851406B0")]
	public PAPMMKENJMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public class DJMBNLLLGLC<T> : global::MIJJEEPKDNA<T>, BJDPFFGHNNI, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public Task<T> DJJDCGOFGNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x58C1D0", Offset = "0x58B1D0", VA = "0x18058C1D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private Task EDHOBENLCNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x1E3ED50", Offset = "0x1E3DD50", VA = "0x181E3ED50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public global::IHDAFNHGAJF<T> HODNFKDKBFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private CFBFBBBFDFL FICFCHEKMDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x1E41A70", Offset = "0x1E40A70", VA = "0x181E41A70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x351A730", Offset = "0x3519730", VA = "0x18351A730")]
	public DJMBNLLLGLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public class JDABLIMGLDC : global::GEMLNAGHAAP<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x513E0A0", Offset = "0x513D0A0", VA = "0x18513E0A0")]
	public JDABLIMGLDC(Exception OPNLBLDAFKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public class GEMLNAGHAAP<T> : global::MIJJEEPKDNA<T>, BJDPFFGHNNI, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public Task<T> DJJDCGOFGNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x58C1D0", Offset = "0x58B1D0", VA = "0x18058C1D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private Task EDHOBENLCNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x1E3ED50", Offset = "0x1E3DD50", VA = "0x181E3ED50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public global::IHDAFNHGAJF<T> HODNFKDKBFA
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private CFBFBBBFDFL FICFCHEKMDI
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x1E41A70", Offset = "0x1E40A70", VA = "0x181E41A70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x3201760", Offset = "0x3200760", VA = "0x183201760")]
	public GEMLNAGHAAP(Exception OPNLBLDAFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public interface BJDPFFGHNNI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000098")]
	[NotNull]
	Task DJJDCGOFGNE
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	[NotNull]
	CFBFBBBFDFL HODNFKDKBFA
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public interface MIJJEEPKDNA<T> : BJDPFFGHNNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	[NotNull]
	new Task<T> DJJDCGOFGNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	[NotNull]
	new global::IHDAFNHGAJF<T> HODNFKDKBFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public abstract class IFGEJOJEHBO<TTask, T> : global::MIJJEEPKDNA<T>, BJDPFFGHNNI, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class DCCMACMHEAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public global::IFGEJOJEHBO<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x1E42690", Offset = "0x1E41690", VA = "0x181E42690")]
		public DCCMACMHEAA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static bool POBGALCLKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly Task<T> KLPNIJDNEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	protected readonly CancellationTokenSource FMHOKJCPJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private bool KMDCHDFHKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private SynchronizationContext CLGDGBBGDBD;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Task<T> DJJDCGOFGNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x58C1D0", Offset = "0x58B1D0", VA = "0x18058C1D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private Task EDHOBENLCNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x58C1D0", Offset = "0x58B1D0", VA = "0x18058C1D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public global::IHDAFNHGAJF<T> HODNFKDKBFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private CFBFBBBFDFL FICFCHEKMDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x1FF40D0", Offset = "0x1FF30D0", VA = "0x181FF40D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool JHAIFDBLLML
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x60D990", Offset = "0x60C990", VA = "0x18060D990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x342DE20", Offset = "0x342CE20", VA = "0x18342DE20")]
	static IFGEJOJEHBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x342E140", Offset = "0x342D140", VA = "0x18342E140")]
	protected IFGEJOJEHBO(TTask KLPNIJDNEJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x342D8E0", Offset = "0x342C8E0", VA = "0x18342D8E0", Slot = "1")]
	~IFGEJOJEHBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x342D810", Offset = "0x342C810", VA = "0x18342D810", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x342DB40", Offset = "0x342CB40", VA = "0x18342DB40")]
	private void PKDHKFNAFHJ(bool AMMFECCIPNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T BJFIDGHGDPI(TTask PCNFPHPPLKN);

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void JGCFIOKHHPO();

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x342D980", Offset = "0x342C980", VA = "0x18342D980")]
	[CompilerGenerated]
	private void LILIFLJBKFL(object BNNJOKOOGLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public interface CKDJDLEGLKK
{
	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	float JDGAEEAJJAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event LBLCMADKFAI PAEMDIBPODO;
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public class JNNBGPLDEFO : CKDJDLEGLKK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public readonly struct FNALHHGHDLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public readonly float JLECCIEFBFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public readonly float FNMJHDMFOAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		internal readonly bool KDDGLFMHJIC;

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public float BEKDBNBHEAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x513C5F0", Offset = "0x513B5F0", VA = "0x18513C5F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x513C760", Offset = "0x513B760", VA = "0x18513C760")]
		public FNALHHGHDLG(float DOAOIAFHHOJ, float KANEENJPAME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x513C600", Offset = "0x513B600", VA = "0x18513C600", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class BEOKDJEKEPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public JNNBGPLDEFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public BEOKDJEKEPI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly int EHCFCNDLJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private int LKLHIJGPOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly CKDJDLEGLKK[] IFAMIMIHEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly LBLCMADKFAI[] LJFGGELDADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private readonly FNALHHGHDLG[] NPOCAHBEEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private FNALHHGHDLG PNKJMGAGOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly BKOLHMDCBKJ JNLBAONPJHL;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public FNALHHGHDLG PBLKIFKKDDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x32F1070", Offset = "0x32F0070", VA = "0x1832F1070")]
		get
		{
			return default(FNALHHGHDLG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float JDGAEEAJJAN
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x513F290", Offset = "0x513E290", VA = "0x18513F290", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event LBLCMADKFAI PAEMDIBPODO
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x513EF00", Offset = "0x513DF00", VA = "0x18513EF00", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x513F1D0", Offset = "0x513E1D0", VA = "0x18513F1D0", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x513F730", Offset = "0x513E730", VA = "0x18513F730")]
	public JNNBGPLDEFO(int EHCFCNDLJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x513EFC0", Offset = "0x513DFC0", VA = "0x18513EFC0")]
	public BKOLHMDCBKJ BGAKPBHNGBM(FNALHHGHDLG ECIIMJNCNFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x513F350", Offset = "0x513E350", VA = "0x18513F350")]
	public void PLAEBDODKLG(CKDJDLEGLKK JNDGGGNNCIC, [Optional] FNALHHGHDLG DCOABLIICBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x513F300", Offset = "0x513E300", VA = "0x18513F300")]
	internal int OOIFLNKCDMF(CKDJDLEGLKK HNPMLEOOKLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x513F2B0", Offset = "0x513E2B0", VA = "0x18513F2B0")]
	internal FNALHHGHDLG NLOMIGPCMIC(int FBOCJCCNMND)
	{
		return default(FNALHHGHDLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x513F040", Offset = "0x513E040", VA = "0x18513F040", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public delegate void LBLCMADKFAI(float GBCEJCGLOAN);
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class BEDCMBCDGHL
{
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	internal const float NGIOJMPLEKG = 0.0001f;
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public static class DIGGPDBLDKI
{
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	private class IPDOGJEFDLC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private readonly CKDJDLEGLKK HNPMLEOOKLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private readonly LBLCMADKFAI ACDPINKOGPO;

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x513E010", Offset = "0x513D010", VA = "0x18513E010")]
		public IPDOGJEFDLC(CKDJDLEGLKK HNPMLEOOKLJ, LBLCMADKFAI ACDPINKOGPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x513DFC0", Offset = "0x513CFC0", VA = "0x18513DFC0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x513BD50", Offset = "0x513AD50", VA = "0x18513BD50")]
	internal static bool ILDFJABFBHN(float JAELLKEBFMM, float PEAHMNEGGIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x3D205F0", Offset = "0x3D1F5F0", VA = "0x183D205F0")]
	internal static float HBCKPAOKINP(float JAELLKEBFMM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x513BC90", Offset = "0x513AC90", VA = "0x18513BC90")]
	public static IDisposable ECGMJGJJMID(this CKDJDLEGLKK HNPMLEOOKLJ, LBLCMADKFAI ACDPINKOGPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public class BKOLHMDCBKJ : CKDJDLEGLKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private float GBCEJCGLOAN;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public float JDGAEEAJJAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x10C2E90", Offset = "0x10C1E90", VA = "0x1810C2E90", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x513B650", Offset = "0x513A650", VA = "0x18513B650")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event LBLCMADKFAI PAEMDIBPODO
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x513B510", Offset = "0x513A510", VA = "0x18513B510", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x513B5B0", Offset = "0x513A5B0", VA = "0x18513B5B0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public BKOLHMDCBKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public class CHOBPKBIMMK : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public readonly Type IMCOFDHPANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public readonly string JCBCECHDEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public readonly bool LFMLCKLGNBN;

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x513B720", Offset = "0x513A720", VA = "0x18513B720")]
	public CHOBPKBIMMK(Type COACPJAKNCP, string OBPOEJJAKGH, bool KKGHLCIAFCM = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public class HANGCHJOJDP : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x513D500", Offset = "0x513C500", VA = "0x18513D500")]
	public HANGCHJOJDP(string EOGLFEOLNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x513D570", Offset = "0x513C570", VA = "0x18513D570")]
	public HANGCHJOJDP(string EOGLFEOLNBK, Exception MOLKGFOIHNA)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0x58CED0", Offset = "0x58BED0", VA = "0x18058CED0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0x5B0710", Offset = "0x5AF710", VA = "0x1805B0710")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public T this[int BHFIJCEBIFE, int FLLLJCMBGDJ]
		{
			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x1E3F2E0", Offset = "0x1E3E2E0", VA = "0x181E3F2E0")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x1E3F380", Offset = "0x1E3E380", VA = "0x181E3F380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x1E3F250", Offset = "0x1E3E250", VA = "0x181E3F250")]
		public Array2D(uint DFGJDFLDIBI, uint LDIDAFFCGNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x1E3F1D0", Offset = "0x1E3E1D0", VA = "0x181E3F1D0")]
		public void BFHLNDADIAA()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x513AFE0", Offset = "0x5139FE0", VA = "0x18513AFE0")]
		public Array2DVector3(uint DFGJDFLDIBI, uint LDIDAFFCGNN)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal static class PMOEABEELJC
{
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public const int ABLIDFCELHK = -1;

	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public const int IEBICDJBPGH = 0;
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[DefaultMember("Item")]
public class NJOJIBKOMFJ<THandle, TValue> : IDisposable where THandle : struct, GFCLNMBKJPO where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly List<THandle> DFOHHIKJAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly List<TValue> AMNHMFIMCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly Func<TValue> FICEPFBJNFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private readonly Action<TValue> HFBOMEOGDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private int BMMHEPPEFBH;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public TValue HLNIIBDGPEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x214A640", Offset = "0x2149640", VA = "0x18214A640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x3834560", Offset = "0x3833560", VA = "0x183834560")]
	public NJOJIBKOMFJ(Action<TValue> HFBOMEOGDCK, [Optional] Func<TValue> FICEPFBJNFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x3833B60", Offset = "0x3832B60", VA = "0x183833B60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x3833DF0", Offset = "0x3832DF0", VA = "0x183833DF0")]
	public THandle GJHMDGALCIL()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x38343A0", Offset = "0x38333A0", VA = "0x1838343A0")]
	public THandle NJFAMEHLCGO(TValue BMNJAHFFOPC)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x3834260", Offset = "0x3833260", VA = "0x183834260")]
	public bool INAIIIEHGLD(THandle NJKEAEPJNIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x3834180", Offset = "0x3833180", VA = "0x183834180")]
	public bool IILCCBCGCEN(THandle NJKEAEPJNIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x38340E0", Offset = "0x38330E0", VA = "0x1838340E0")]
	public bool HNJCPFHMOPN(THandle NJKEAEPJNIH, out TValue BMNJAHFFOPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x3834510", Offset = "0x3833510", VA = "0x183834510")]
	public TValue PPHNCEKAGCA(THandle NJKEAEPJNIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x3834030", Offset = "0x3833030", VA = "0x183834030")]
	public bool HMOLHLDKLLF(THandle NJKEAEPJNIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x3834310", Offset = "0x3833310", VA = "0x183834310")]
	private THandle LJPAGGANBFF(int FBOCJCCNMND)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x3833AD0", Offset = "0x3832AD0", VA = "0x183833AD0")]
	private TValue CGPDFDLOGCM(int FBOCJCCNMND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x38344D0", Offset = "0x38334D0", VA = "0x1838344D0")]
	private void PJONDIJENDH(int FBOCJCCNMND, in THandle NJKEAEPJNIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x3833B00", Offset = "0x3832B00", VA = "0x183833B00")]
	private void CHAOBMPPLCP(int FBOCJCCNMND, in TValue BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x38339C0", Offset = "0x38329C0", VA = "0x1838339C0")]
	private THandle BCJIMONALCD()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x3834410", Offset = "0x3833410", VA = "0x183834410")]
	private void NJOBEFJOOGH(THandle NJKEAEPJNIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x3833B40", Offset = "0x3832B40", VA = "0x183833B40")]
	private int DAEEPGEJJGE(int EPIIAPHJKPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x3833B50", Offset = "0x3832B50", VA = "0x183833B50")]
	private bool DHGCODFNFBG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x5DD9A0", Offset = "0x5DC9A0", VA = "0x1805DD9A0")]
	private void HDOEOGGCBOO(THandle NJKEAEPJNIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x3833E90", Offset = "0x3832E90", VA = "0x183833E90")]
	private bool HAMIBNLNNBJ(out THandle NJKEAEPJNIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x3833BE0", Offset = "0x3832BE0", VA = "0x183833BE0")]
	private bool FKBBFKMFHGC(out THandle NJKEAEPJNIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x3834340", Offset = "0x3833340", VA = "0x183834340")]
	private void LOCGGALAJAJ(THandle NJKEAEPJNIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x3833F10", Offset = "0x3832F10", VA = "0x183833F10")]
	private void HJMPBNMDIHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public interface GFCLNMBKJPO
{
	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	int NBBAFHCPDPA
	{
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	int OPMBFIMNJNK
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public interface BDLKMFLDHDF<T> : GFCLNMBKJPO, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public static class DJPOOPFBJPD
{
	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x25D6700", Offset = "0x25D5700", VA = "0x1825D6700")]
	public static bool KDDGLFMHJIC<T>(this T NJKEAEPJNIH) where T : struct, GFCLNMBKJPO
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public class JNIMEBMPPPI
{
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	private enum NGJJNMENOBB : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private int IGDKGBAJACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private bool ALNHLLLCFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private NGJJNMENOBB BLGKAPHJAJK;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool HBKBNBICFLH
	{
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x513EAA0", Offset = "0x513DAA0", VA = "0x18513EAA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool PDKDGDNDCFK
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x513EE50", Offset = "0x513DE50", VA = "0x18513EE50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x513EED0", Offset = "0x513DED0", VA = "0x18513EED0")]
	public JNIMEBMPPPI(bool ALNHLLLCFBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x513E530", Offset = "0x513D530", VA = "0x18513E530")]
	public void FGMBJIHAGDC(object OOJKHPLJJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x513EAB0", Offset = "0x513DAB0", VA = "0x18513EAB0")]
	public void HIJECCGJJNO(int BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x513EA90", Offset = "0x513DA90", VA = "0x18513EA90")]
	public void GOIAGENGGEJ(uint HMHHEGFNNIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x513EBD0", Offset = "0x513DBD0", VA = "0x18513EBD0")]
	public void JJBODBAABLN(bool NAIOJELCMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x513EA50", Offset = "0x513DA50", VA = "0x18513EA50")]
	public void GNKBCKGDDEI(long AKGIBLJHFGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x513EE10", Offset = "0x513DE10", VA = "0x18513EE10")]
	public void NNALEIPAHIG(ulong AOIDCHJGIGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x513EE60", Offset = "0x513DE60", VA = "0x18513EE60")]
	public void PMDIONPHHOB(string GMLEIGNAEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x513ED10", Offset = "0x513DD10", VA = "0x18513ED10")]
	public void LHNLBDHAHPG(Enum OPNLBLDAFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x513EBF0", Offset = "0x513DBF0", VA = "0x18513EBF0")]
	public void JKJPCAELMJC(IList NNKFFLIIPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x2DED4C0", Offset = "0x2DEC4C0", VA = "0x182DED4C0")]
	public void FPNCBCHCGJL<T, U>(Dictionary<T, U> JEBLFIJGCEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x513E170", Offset = "0x513D170", VA = "0x18513E170")]
	private void DOOKGEPDAMM(IDictionary JEBLFIJGCEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x513EDA0", Offset = "0x513DDA0", VA = "0x18513EDA0")]
	public int MJJEJBGNAAH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x513EB60", Offset = "0x513DB60", VA = "0x18513EB60")]
	public short HIKHFOMEKDE()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x513E0F0", Offset = "0x513D0F0", VA = "0x18513E0F0")]
	public void BFHLNDADIAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x513E100", Offset = "0x513D100", VA = "0x18513E100")]
	private void CCPHMIEDPFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public abstract class KEJACFHPKDC<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	internal class BDMDPNHNIGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public TNode LDOMHDGLEOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public TNode ACJKMIDAEJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public GBCDPLIDIKH ANOBCBEPEBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public List<GBCDPLIDIKH> FKBAKAIODLO;

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x1E42690", Offset = "0x1E41690", VA = "0x181E42690")]
		public BDMDPNHNIGB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	internal struct GBCDPLIDIKH : IComparable<GBCDPLIDIKH>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public int MLBBLBCMLMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public TClaimant DOAEJBAEBDK;

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x594CF0", Offset = "0x593CF0", VA = "0x180594CF0")]
		public GBCDPLIDIKH(int MLBBLBCMLMM, TClaimant DOAEJBAEBDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x29A9CA0", Offset = "0x29A8CA0", VA = "0x1829A9CA0")]
		public bool ADNLGCPNOFG(in GBCDPLIDIKH INIEAOGGCLC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x29A9D00", Offset = "0x29A8D00", VA = "0x1829A9D00")]
		public bool AKODGICNPPD(in GBCDPLIDIKH INIEAOGGCLC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x29A9D10", Offset = "0x29A8D10", VA = "0x1829A9D10", Slot = "4")]
		public int CompareTo(GBCDPLIDIKH INIEAOGGCLC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x29A9D20", Offset = "0x29A8D20", VA = "0x1829A9D20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public enum FMAKOEPHBKL
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private sealed class DHLPGPONGMG : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public global::KEJACFHPKDC<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x2140800", Offset = "0x213F800", VA = "0x182140800")]
		[DebuggerHidden]
		public DHLPGPONGMG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x29A98C0", Offset = "0x29A88C0", VA = "0x1829A98C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x29A9A80", Offset = "0x29A8A80", VA = "0x1829A9A80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x29A99A0", Offset = "0x29A89A0", VA = "0x1829A99A0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x1E4F550", Offset = "0x1E4E550", VA = "0x181E4F550", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private static readonly global::EBDMLGBPDCJ<BDMDPNHNIGB> AOLHCGCPMMI;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private static readonly global::EBDMLGBPDCJ<List<GBCDPLIDIKH>> JPILBOPLIKI;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private static int OFHGOLBPNKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	internal readonly Dictionary<TClaimant, TNode> LAMPPMHOCHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	internal readonly Dictionary<TNode, BDMDPNHNIGB> IOECGICMKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private FMAKOEPHBKL NLPCHIBFNAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private bool FFEBDMPJINN;

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode NIJCLHCLLHG(TNode GHPMKAJMKGM);

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void HIIMJFPGNEB(TNode GHPMKAJMKGM, TClaimant LOBKNGDGKIE, TClaimant BPCLOEGJEFF);

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x29B0930", Offset = "0x29AF930", VA = "0x1829B0930")]
	public KEJACFHPKDC(FMAKOEPHBKL NLPCHIBFNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x29AF1D0", Offset = "0x29AE1D0", VA = "0x1829AF1D0")]
	public void AHOILDMDFOE(TNode GHPMKAJMKGM, TNode EBIOPMCBHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x29AF0D0", Offset = "0x29AE0D0", VA = "0x1829AF0D0")]
	public void AGFGFHMOOEH(TClaimant DOAEJBAEBDK, TNode LBLEBPDMFBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x29AF410", Offset = "0x29AE410", VA = "0x1829AF410", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x29AF770", Offset = "0x29AE770", VA = "0x1829AF770")]
	private void EHNKFEFJMLA(TClaimant DOAEJBAEBDK, TNode OFCLPCAOAHF, TNode LBLEBPDMFBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x29B0220", Offset = "0x29AF220", VA = "0x1829B0220")]
	private int LLHJHCDGGIA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x29B0520", Offset = "0x29AF520", VA = "0x1829B0520")]
	private void PMGKNMGHHKH(TClaimant DOAEJBAEBDK, TNode NANLDPKOFFO, TNode FMCHGEPPMDK, int CJBIJDBHCNN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x29B0290", Offset = "0x29AF290", VA = "0x1829B0290")]
	private void LNGMBGOLFEH(GBCDPLIDIKH KNJJNKJHPJI, BDMDPNHNIGB DGJGGAACIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x29AFAA0", Offset = "0x29AEAA0", VA = "0x1829AFAA0")]
	private void IIOEBDPGNAP(TClaimant DOAEJBAEBDK, TNode NANLDPKOFFO, TNode FMCHGEPPMDK, int CJBIJDBHCNN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x29AF810", Offset = "0x29AE810", VA = "0x1829AF810")]
	private void GCGDNCBFEDC(GBCDPLIDIKH KNJJNKJHPJI, TNode GHPMKAJMKGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x29AF670", Offset = "0x29AE670", VA = "0x1829AF670")]
	private void EDADNFHAEFE(GBCDPLIDIKH KNJJNKJHPJI, BDMDPNHNIGB DGJGGAACIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x29B03E0", Offset = "0x29AF3E0", VA = "0x1829B03E0")]
	private void PFHOGPHAFJC(BDMDPNHNIGB DGJGGAACIEL, bool NDADMMEOGIO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x29AFDE0", Offset = "0x29AEDE0", VA = "0x1829AFDE0")]
	private void LCJPBMLKNDG(BDMDPNHNIGB DGJGGAACIEL, TNode EBIOPMCBHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x29AFD10", Offset = "0x29AED10", VA = "0x1829AFD10")]
	[IteratorStateMachine(typeof(global::KEJACFHPKDC<, >.DHLPGPONGMG))]
	private IEnumerable<TNode> INOOPFDPCCJ(TNode NANLDPKOFFO, TNode FMCHGEPPMDK, bool PBDFHBDJDMI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x29B0320", Offset = "0x29AF320", VA = "0x1829B0320")]
	private BDMDPNHNIGB NBKLJJPGEGJ(TNode GHPMKAJMKGM, TNode ACJKMIDAEJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x29AF910", Offset = "0x29AE910", VA = "0x1829AF910")]
	private BDMDPNHNIGB GOLHBGNFDHM(TNode GHPMKAJMKGM, TNode ACJKMIDAEJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x29AF250", Offset = "0x29AE250", VA = "0x1829AF250")]
	private void AOBANINEJCJ(BDMDPNHNIGB DGJGGAACIEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public class AHMDJHJCKHB<T> : IEnumerable<global::AHMDJHJCKHB<T>.AJEGMAGJFAG>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public struct AJEGMAGJFAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public T BMNJAHFFOPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public int FBOCJCCNMND;
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public class FDGABHGDGPI : IEnumerator<AJEGMAGJFAG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private global::AHMDJHJCKHB<T> HKDIPLBODPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private int FBOCJCCNMND;

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0x2759790", Offset = "0x2758790", VA = "0x182759790", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public AJEGMAGJFAG LBMKEDIKANE
		{
			[Cpp2IlInjected.Token(Token = "0x60003FB")]
			[Cpp2IlInjected.Address(RVA = "0x3676E30", Offset = "0x3675E30", VA = "0x183676E30", Slot = "4")]
			get
			{
				return default(AJEGMAGJFAG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x8BA030", Offset = "0x8B9030", VA = "0x1808BA030")]
		public FDGABHGDGPI(global::AHMDJHJCKHB<T> HKDIPLBODPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x3676C20", Offset = "0x3675C20", VA = "0x183676C20", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x81D480", Offset = "0x81C480", VA = "0x18081D480", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x851F80", Offset = "0x850F80", VA = "0x180851F80", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	private struct AOEBAFONOLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public bool OAIJEDKOJDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public T BMNJAHFFOPC;
	}

	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private const int KFLBKMIEGBE = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly Dictionary<T, int> PDKNLMAEBMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private AOEBAFONOLC[] OCPFCNPNEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private int MPKOLDBAOED;

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public int NNEOPMEPNCA
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x58CCC0", Offset = "0x58BCC0", VA = "0x18058CCC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x6E6EB0", Offset = "0x6E5EB0", VA = "0x1806E6EB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public int AGNENIFEHDL
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x1E42C60", Offset = "0x1E41C60", VA = "0x181E42C60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x3670020", Offset = "0x366F020", VA = "0x183670020")]
	public AHMDJHJCKHB(int EHCFCNDLJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x366F840", Offset = "0x366E840", VA = "0x18366F840")]
	public AHMDJHJCKHB(AJEGMAGJFAG[] OKOODMJEAFH, bool IEOJHOHBDJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x366E5F0", Offset = "0x366D5F0", VA = "0x18366E5F0")]
	public int HOABCALFFAP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x366EAA0", Offset = "0x366DAA0", VA = "0x18366EAA0")]
	private int NFDAFINCLFN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x366E7F0", Offset = "0x366D7F0", VA = "0x18366E7F0", Slot = "6")]
	protected virtual uint KFPKMHNLICI(uint IGDKGBAJACK, T BMNJAHFFOPC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x366E430", Offset = "0x366D430", VA = "0x18366E430")]
	public bool CMEOHBNAMMG(T BMNJAHFFOPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x366E810", Offset = "0x366D810", VA = "0x18366E810")]
	public bool KIPDGJMGMHP(int FBOCJCCNMND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x366E470", Offset = "0x366D470", VA = "0x18366E470")]
	public bool DNKBNIOBOIB(Func<T, bool> IDAMLAEHEEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x366E260", Offset = "0x366D260", VA = "0x18366E260")]
	public int CDNIDMMGEOG(T BMNJAHFFOPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x366E310", Offset = "0x366D310", VA = "0x18366E310")]
	public T CGPDFDLOGCM(int FBOCJCCNMND)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x366E1E0", Offset = "0x366D1E0", VA = "0x18366E1E0")]
	public void BFHLNDADIAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x366F270", Offset = "0x366E270", VA = "0x18366F270")]
	public bool OIJIJCLDMLM(T BMNJAHFFOPC, bool JJHAIMABAOF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x366EFF0", Offset = "0x366DFF0", VA = "0x18366EFF0")]
	public bool OIJIJCLDMLM(T BMNJAHFFOPC, int FBOCJCCNMND, bool JJHAIMABAOF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x366E6E0", Offset = "0x366D6E0", VA = "0x18366E6E0")]
	public bool INAIIIEHGLD(T BMNJAHFFOPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x366E770", Offset = "0x366D770", VA = "0x18366E770")]
	public bool KBEFPINOHPL(int FBOCJCCNMND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x366E8D0", Offset = "0x366D8D0", VA = "0x18366E8D0")]
	private void MAPFHHGHMGO(int FBOCJCCNMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x366F510", Offset = "0x366E510", VA = "0x18366F510")]
	public AJEGMAGJFAG[] PKLFCANAEOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x366EFA0", Offset = "0x366DFA0", VA = "0x18366EFA0")]
	private int OHBDCOPBODK(int LPLEHFIAKIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x366F7C0", Offset = "0x366E7C0", VA = "0x18366F7C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x366F7C0", Offset = "0x366E7C0", VA = "0x18366F7C0", Slot = "4")]
	private IEnumerator<AJEGMAGJFAG> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public class EBDMLGBPDCJ<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private readonly Stack<T> HAPFABGEGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private readonly List<T> JDMFENNKCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private readonly int PJBLLLFNFNJ;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public int ENEDCKFIPBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x1E42A10", Offset = "0x1E41A10", VA = "0x181E42A10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public int FOHFIJOOIAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x1E43380", Offset = "0x1E42380", VA = "0x181E43380")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x3522000", Offset = "0x3521000", VA = "0x183522000")]
	public static global::EBDMLGBPDCJ<T> KIAPNGLPGFK(int EHCFCNDLJCD = 0, int PJBLLLFNFNJ = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x3522200", Offset = "0x3521200", VA = "0x183522200")]
	public static global::EBDMLGBPDCJ<T> LFOGOAHNDIJ(int EHCFCNDLJCD = 0, int PJBLLLFNFNJ = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x35222F0", Offset = "0x35212F0", VA = "0x1835222F0")]
	public EBDMLGBPDCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x3522330", Offset = "0x3521330", VA = "0x183522330")]
	public EBDMLGBPDCJ(int EHCFCNDLJCD, int PJBLLLFNFNJ = int.MaxValue, bool KBAPOKBCNJF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x35220D0", Offset = "0x35210D0", VA = "0x1835220D0")]
	public T LFOGKPCDJPM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x3521D20", Offset = "0x3520D20", VA = "0x183521D20")]
	public void FDONFDGPDGF(T BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x3521AA0", Offset = "0x3520AA0", VA = "0x183521AA0")]
	private void BAOENHDFAEA(T BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x35222D0", Offset = "0x35212D0", VA = "0x1835222D0")]
	private void PDLLHPAOLCG(T BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x3521A00", Offset = "0x3520A00", VA = "0x183521A00")]
	[Conditional("DEBUG_BUILD")]
	private void AALOOCFGHPN(T CCJEMHHMLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x3521B60", Offset = "0x3520B60", VA = "0x183521B60")]
	[Conditional("DEBUG_BUILD")]
	private void BDIMFPBNDCB(T CCJEMHHMLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x3521C10", Offset = "0x3520C10", VA = "0x183521C10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x3521DE0", Offset = "0x3520DE0", VA = "0x183521DE0")]
	private void JLGAMEFAIDM(IEnumerable<T> AMNHMFIMCMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public class HHIKGAJMEKB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private Dictionary<int, T> MEGJCAHADIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private T CKMOJLMCCEH;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public virtual T GNLGENMMFCC
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x58C4A0", Offset = "0x58B4A0", VA = "0x18058C4A0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool PFAMEIFIGBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x21EE600", Offset = "0x21ED600", VA = "0x1821EE600")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x21EE340", Offset = "0x21ED340", VA = "0x1821EE340")]
	public bool GLIJNCAGDLH(T BMNJAHFFOPC, int MLBBLBCMLMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x21EE5A0", Offset = "0x21ED5A0", VA = "0x1821EE5A0")]
	public bool HNEMFBJMDHE(int MLBBLBCMLMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x21EDE70", Offset = "0x21ECE70", VA = "0x1821EDE70")]
	public T EFAAPGAGOLE(int PNIAEHLMNJA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x21EDE10", Offset = "0x21ECE10", VA = "0x1821EDE10")]
	public void BFHLNDADIAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x21EE510", Offset = "0x21ED510", VA = "0x1821EE510")]
	private bool HBDAAKCCABD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x21EE640", Offset = "0x21ED640", VA = "0x1821EE640")]
	public bool NOGIDOCGHEN(int MLBBLBCMLMM, out T BMNJAHFFOPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x21EE670", Offset = "0x21ED670", VA = "0x1821EE670")]
	public HHIKGAJMEKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public class AGICIMDAAKJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	protected struct KJEOANKBKBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public T MHLLNAFLMHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public int LLOCBAOOOJG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	protected readonly List<KJEOANKBKBH> KECMIABDOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private T OIHKNOAKLCJ;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public int AGNENIFEHDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x1E42C60", Offset = "0x1E41C60", VA = "0x181E42C60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x2E52030", Offset = "0x2E51030", VA = "0x182E52030")]
	public bool DNKBNIOBOIB(T BMNJAHFFOPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x2E525B0", Offset = "0x2E515B0", VA = "0x182E525B0")]
	public void NJFAMEHLCGO(T BMNJAHFFOPC, int MLBBLBCMLMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x2E52280", Offset = "0x2E51280", VA = "0x182E52280")]
	public bool INAIIIEHGLD(T BMNJAHFFOPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x2E51FD0", Offset = "0x2E50FD0", VA = "0x182E51FD0")]
	public void BFHLNDADIAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x2E51F40", Offset = "0x2E50F40", VA = "0x182E51F40")]
	public T AMIGMFGLAPI()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x2E52650", Offset = "0x2E51650", VA = "0x182E52650")]
	public T OMABACPMAPK()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x2E523A0", Offset = "0x2E513A0", VA = "0x182E523A0")]
	private void LGFGDKFLEDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x2E526C0", Offset = "0x2E516C0", VA = "0x182E526C0")]
	public AGICIMDAAKJ()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		[SerializeField]
		[KDJOALBJPIO(KJNDCKKOGLL.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0x5140CC0", Offset = "0x513FCC0", VA = "0x185140CC0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x5141190", Offset = "0x5140190", VA = "0x185141190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x5140FB0", Offset = "0x513FFB0", VA = "0x185140FB0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0x5141330", Offset = "0x5140330", VA = "0x185141330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0x5140B80", Offset = "0x513FB80", VA = "0x185140B80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0x5141050", Offset = "0x5140050", VA = "0x185141050")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x5140E70", Offset = "0x513FE70", VA = "0x185140E70")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x5140AE0", Offset = "0x513FAE0", VA = "0x185140AE0")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public interface OFNCAOKLPLN
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public abstract class ResourcePrefabReference<T> : OFNCAOKLPLN where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x1E52570", Offset = "0x1E51570", VA = "0x181E52570", Slot = "4")]
		public virtual T GKODPBPKLML()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x1E42690", Offset = "0x1E41690", VA = "0x181E42690")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public class NFDHINFGNNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly Dictionary<byte, GDCGPHOONIM> HGPOLNCBJEI;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public GDCGPHOONIM LEDDMHPIIFH
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x58C1D0", Offset = "0x58B1D0", VA = "0x18058C1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x58C490", Offset = "0x58B490", VA = "0x18058C490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector2 KDGKNBBLGIG
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x1634190", Offset = "0x1633190", VA = "0x181634190")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x2ED6710", Offset = "0x2ED5710", VA = "0x182ED6710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public Vector2 KKFOPMIPADN
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x15FDC50", Offset = "0x15FCC50", VA = "0x1815FDC50")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x15FDCE0", Offset = "0x15FCCE0", VA = "0x1815FDCE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public Vector2 IIPBHHNCCKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x5140080", Offset = "0x513F080", VA = "0x185140080")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x5140060", Offset = "0x513F060", VA = "0x185140060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public int FBDFDDKONGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x5B77E0", Offset = "0x5B67E0", VA = "0x1805B77E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x5DD9A0", Offset = "0x5DC9A0", VA = "0x1805DD9A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x5140190", Offset = "0x513F190", VA = "0x185140190")]
	public NFDHINFGNNB(Bounds CLKCDJHMBMD, Vector2[] COLDMINLEMA, int CDBEBJKPAHM, byte LPLEHFIAKIB, float MCAJJPIBCHB = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x5140000", Offset = "0x513F000", VA = "0x185140000")]
	public GDCGPHOONIM HMBGOODGHOM(byte FBOCJCCNMND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x51400A0", Offset = "0x513F0A0", VA = "0x1851400A0")]
	public void NDCMDLFGMLF(Vector3 CAIONMHOLNJ, float LLIKNLGKCHP, float MANNNLEIENG, ref List<byte> PJHONIFJOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x513FEB0", Offset = "0x513EEB0", VA = "0x18513FEB0")]
	public void GAOKDNMGBIO(GDCGPHOONIM.EIPCMDKALOA GPKLIIALIDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x513FED0", Offset = "0x513EED0", VA = "0x18513FED0")]
	private GDCGPHOONIM HIAJEBDNBFG(byte FBOCJCCNMND, GDCGPHOONIM.ELBIDBEGNDM BGLHLMEHJGK, GDCGPHOONIM ACJKMIDAEJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x513F990", Offset = "0x513E990", VA = "0x18513F990")]
	private void BKHEALMCCJF(GDCGPHOONIM ACJKMIDAEJL, Vector2[] COLDMINLEMA, int BAMJKIONFMK, int KOPNMDCNGPJ, int IMAJHEFCLEL, int NFBJMMGHOFP, float MCAJJPIBCHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public class GDCGPHOONIM
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	public enum ELBIDBEGNDM
	{
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public enum EIPCMDKALOA
	{
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public byte JNFPOJFDEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public Vector3 LJCKBOCMOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public Vector3 BEKDBNBHEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public Vector3 OEELAPNNAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public Vector3 BMIFNMACNAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public ELBIDBEGNDM BAMCEIMJFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public GDCGPHOONIM HBJABBOBDNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public List<GDCGPHOONIM> LGCGNCGIKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public bool NMHMADBIOAD;

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x513D070", Offset = "0x513C070", VA = "0x18513D070")]
	public GDCGPHOONIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x513D090", Offset = "0x513C090", VA = "0x18513D090")]
	public GDCGPHOONIM(byte MDOMNGAAEFJ, ELBIDBEGNDM BGLHLMEHJGK, GDCGPHOONIM ACJKMIDAEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x513CCE0", Offset = "0x513BCE0", VA = "0x18513CCE0")]
	public void MNLCJBPDOKN(GDCGPHOONIM LPDNPFINMIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80")]
	public void GAOKDNMGBIO(int HNHCPMMBHAK, EIPCMDKALOA GPKLIIALIDB, int CCLEIHDCIGA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x513CD80", Offset = "0x513BD80", VA = "0x18513CD80")]
	public void NDCMDLFGMLF(List<byte> PJHONIFJOLP, Vector3 CAIONMHOLNJ, float LLIKNLGKCHP, float MANNNLEIENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x513D010", Offset = "0x513C010", VA = "0x18513D010")]
	public bool OENMLJDCMCP(Vector3 AOEGFIEEENK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x513CCA0", Offset = "0x513BCA0", VA = "0x18513CCA0")]
	public bool KEHCGHGEGHF(Vector3 AOEGFIEEENK, float MIANCLHDKIF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class DPMBCDIOHOE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private readonly Dictionary<T, object> CLLGMBAGCGN;

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x215E270", Offset = "0x215D270", VA = "0x18215E270")]
	public bool LCEGANNEMMK(T FEIJMODLBIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x351EF90", Offset = "0x351DF90", VA = "0x18351EF90")]
	public bool LCEGANNEMMK(T FEIJMODLBIF, object DLNBPAAGBNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x351EF30", Offset = "0x351DF30", VA = "0x18351EF30")]
	public bool LCEGANNEMMK(T FEIJMODLBIF, object DLNBPAAGBNI, out object OLGMNKBILOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x351EE60", Offset = "0x351DE60", VA = "0x18351EE60")]
	public bool JPHPIGEIEHE(T FEIJMODLBIF, object DLNBPAAGBNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x351EE20", Offset = "0x351DE20", VA = "0x18351EE20")]
	public bool GEMIFNNFDIM(T FEIJMODLBIF, object DLNBPAAGBNI, out object OLGMNKBILOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x351EEA0", Offset = "0x351DEA0", VA = "0x18351EEA0")]
	public bool JPHPIGEIEHE(T FEIJMODLBIF, object DLNBPAAGBNI, out object OLGMNKBILOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x342D630", Offset = "0x342C630", VA = "0x18342D630")]
	public void EIHIODHODEO(T FEIJMODLBIF, object DLNBPAAGBNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x351ED80", Offset = "0x351DD80", VA = "0x18351ED80")]
	public void CIDMLILGFPL(T FEIJMODLBIF, object DLNBPAAGBNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x351EFD0", Offset = "0x351DFD0", VA = "0x18351EFD0")]
	public DPMBCDIOHOE()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		public struct KGAJCBLIEFK<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			private readonly List<Component> NNKFFLIIPKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			private readonly bool IMOJONECLDK;

			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(RVA = "0x7CC060", Offset = "0x7CB060", VA = "0x1807CC060")]
			public KGAJCBLIEFK(List<Component> NNKFFLIIPKA, bool IMOJONECLDK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0x1E47740", Offset = "0x1E46740", VA = "0x181E47740")]
			public DJFIGEPLHNK<T> OCEJNOMNLJH()
			{
				return default(DJFIGEPLHNK<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0x1E477B0", Offset = "0x1E467B0", VA = "0x181E477B0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600045E")]
			[Cpp2IlInjected.Address(RVA = "0x1E477B0", Offset = "0x1E467B0", VA = "0x181E477B0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		public struct DJFIGEPLHNK<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			private readonly List<Component> NNKFFLIIPKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			private readonly bool IMOJONECLDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			private int FBOCJCCNMND;

			[Cpp2IlInjected.Token(Token = "0x170000C4")]
			public T LBMKEDIKANE
			{
				[Cpp2IlInjected.Token(Token = "0x6000460")]
				[Cpp2IlInjected.Address(RVA = "0x1E423C0", Offset = "0x1E413C0", VA = "0x181E423C0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000C5")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000461")]
				[Cpp2IlInjected.Address(RVA = "0x1E42350", Offset = "0x1E41350", VA = "0x181E42350", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600045F")]
			[Cpp2IlInjected.Address(RVA = "0x1E42390", Offset = "0x1E41390", VA = "0x181E42390")]
			public DJFIGEPLHNK(List<Component> NNKFFLIIPKA, bool IMOJONECLDK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0x1E42280", Offset = "0x1E41280", VA = "0x181E42280", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0x1E42290", Offset = "0x1E41290", VA = "0x181E42290", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000464")]
			[Cpp2IlInjected.Address(RVA = "0x1E42340", Offset = "0x1E41340", VA = "0x181E42340", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x600044B")]
			[Cpp2IlInjected.Address(RVA = "0x5142FF0", Offset = "0x5141FF0", VA = "0x185142FF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x5142FB0", Offset = "0x5141FB0", VA = "0x185142FB0")]
		public ToolHierarchyCache(GameObject ACDPGOLHPDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x5142A40", Offset = "0x5141A40", VA = "0x185142A40")]
		private void BGKBBGPIDLH(GameObject ACDPGOLHPDL, bool PFGBAAJKACD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x5142B60", Offset = "0x5141B60", VA = "0x185142B60")]
		public static void BGKBBGPIDLH(GameObject ACDPGOLHPDL, ref ToolHierarchyCache MNKBFBGJLOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x5142BF0", Offset = "0x5141BF0", VA = "0x185142BF0")]
		public void ENFDJMBMCLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x5142F00", Offset = "0x5141F00", VA = "0x185142F00")]
		public void MHLMJKEBKOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x24E5490", Offset = "0x24E4490", VA = "0x1824E5490")]
		public void CKDDAGOHFPI<T>(Action<T> KAIJPPOLHDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x5142D40", Offset = "0x5141D40", VA = "0x185142D40")]
		public Component FHNGAHFCCOG(Type GOKHKCCNGMD, bool IMOJONECLDK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x1FE0FD0", Offset = "0x1FDFFD0", VA = "0x181FE0FD0")]
		public T FHNGAHFCCOG<T>(bool IMOJONECLDK = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x5142E70", Offset = "0x5141E70", VA = "0x185142E70")]
		public KGAJCBLIEFK<Component> LLPOCCIHMLM(Type GOKHKCCNGMD, bool IMOJONECLDK = false)
		{
			return default(KGAJCBLIEFK<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x228F770", Offset = "0x228E770", VA = "0x18228F770")]
		public KGAJCBLIEFK<T> LLPOCCIHMLM<T>(bool IMOJONECLDK = false) where T : class
		{
			return default(KGAJCBLIEFK<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x5142790", Offset = "0x5141790", VA = "0x185142790")]
		public List<Component> BCEFHGLBBMM(Type GOKHKCCNGMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x5142CC0", Offset = "0x5141CC0", VA = "0x185142CC0", Slot = "4")]
		public bool Equals(ToolHierarchyCache JBEHFGFFAPE, ToolHierarchyCache GLCMAAPCBBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x5142E00", Offset = "0x5141E00", VA = "0x185142E00", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache OOJKHPLJJMJ)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public class LDAHGJBCEIE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private int EHCFCNDLJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private int MLMLLLCIOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private List<T> IHICDIPLHBN;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public int AGNENIFEHDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x1E42A10", Offset = "0x1E41A10", VA = "0x181E42A10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public T GEIMABBIODL
	{
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x318B8A0", Offset = "0x318A8A0", VA = "0x18318B8A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public T HOEPOJNLOPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x318BD60", Offset = "0x318AD60", VA = "0x18318BD60")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public T FMAHODPCLHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x318BAF0", Offset = "0x318AAF0", VA = "0x18318BAF0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x318BE20", Offset = "0x318AE20", VA = "0x18318BE20")]
	public LDAHGJBCEIE(int EHCFCNDLJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x318BC90", Offset = "0x318AC90", VA = "0x18318BC90")]
	public void NJFAMEHLCGO(T PJOFEKHMJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x318B9C0", Offset = "0x318A9C0", VA = "0x18318B9C0")]
	public void BFHLNDADIAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x318BA00", Offset = "0x318AA00", VA = "0x18318BA00")]
	public void CGKIPLLHEKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x318BAA0", Offset = "0x318AAA0", VA = "0x18318BAA0")]
	public void DOLOJHCIPBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x318BE10", Offset = "0x318AE10", VA = "0x18318BE10")]
	public void PDEKBMCLLCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public class LPFGIGPPOCD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private bool MNBKDAILBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private Action KAIJPPOLHDF;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public static LPFGIGPPOCD ANNCNFIDBEF
	{
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x513F910", Offset = "0x513E910", VA = "0x18513F910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public bool LHGMFEODBEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x5B77B0", Offset = "0x5B67B0", VA = "0x1805B77B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x8A3950", Offset = "0x8A2950", VA = "0x1808A3950")]
	public LPFGIGPPOCD(Action KAIJPPOLHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x513F8F0", Offset = "0x513E8F0", VA = "0x18513F8F0")]
	public void NAFAAPPDJFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x513F8F0", Offset = "0x513E8F0", VA = "0x18513F8F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public static class JCOFGLKJBJD
{
	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80")]
	public static void NLEIBHMJOOD(BAFGANADAFE KMPKBAIJHON, string ABNIMGHCANN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public class DEJMFEIFJKC<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	private struct KIDAOLEKEJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public int LLOCBAOOOJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public T MHLLNAFLMHJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private readonly Dictionary<object, KIDAOLEKEJK> MEGJCAHADIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private T CKMOJLMCCEH;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public virtual T GNLGENMMFCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x1634190", Offset = "0x1633190", VA = "0x181634190", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x2ED6710", Offset = "0x2ED5710", VA = "0x182ED6710", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public bool PFAMEIFIGBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x3907B20", Offset = "0x3906B20", VA = "0x183907B20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public object JOBNBHPJNGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x58EDF0", Offset = "0x58DDF0", VA = "0x18058EDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x5B6D70", Offset = "0x5B5D70", VA = "0x1805B6D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x3902D80", Offset = "0x3901D80", VA = "0x183902D80")]
	public bool GLIJNCAGDLH(T BMNJAHFFOPC, object DLNBPAAGBNI, int MLBBLBCMLMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x3907AB0", Offset = "0x3906AB0", VA = "0x183907AB0")]
	public bool HNEMFBJMDHE(object DLNBPAAGBNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x3907DF0", Offset = "0x3906DF0", VA = "0x183907DF0")]
	public bool NOGIDOCGHEN(object DLNBPAAGBNI, out T BMNJAHFFOPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x2ED4850", Offset = "0x2ED3850", VA = "0x182ED4850")]
	public void BFHLNDADIAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x3903F60", Offset = "0x3902F60", VA = "0x183903F60")]
	private bool HBDAAKCCABD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x21EE670", Offset = "0x21ED670", VA = "0x1821EE670")]
	public DEJMFEIFJKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public class PGNOOPFOAGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private Dictionary<object, float> MEGJCAHADIM;

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public float HOJHJIHIJKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x10C2E90", Offset = "0x10C1E90", VA = "0x1810C2E90")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0xDBD350", Offset = "0xDBC350", VA = "0x180DBD350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x5140810", Offset = "0x513F810", VA = "0x185140810")]
	public void GLIJNCAGDLH(float BMNJAHFFOPC, object DLNBPAAGBNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x5140880", Offset = "0x513F880", VA = "0x185140880")]
	public void HNEMFBJMDHE(object DLNBPAAGBNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x51406F0", Offset = "0x513F6F0", VA = "0x1851406F0")]
	private void BADJJCBBDKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x51408F0", Offset = "0x513F8F0", VA = "0x1851408F0")]
	public PGNOOPFOAGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public class FMAOGAPANAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public readonly string JOBEJNAMCEJ;

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x6C1360", Offset = "0x6C0360", VA = "0x1806C1360")]
	public FMAOGAPANAO(string KGLDBAMEFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x513C540", Offset = "0x513B540", VA = "0x18513C540")]
	public FMAOGAPANAO(UnityEngine.Object FGCJIBINJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x513C4F0", Offset = "0x513B4F0", VA = "0x18513C4F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class BAFGANADAFE
{
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[CompilerGenerated]
	private sealed class EAEIFIOOOKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public EAEIFIOOOKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x513BDD0", Offset = "0x513ADD0", VA = "0x18513BDD0")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private readonly HashSet<object> JJGMADEHCOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private int HMDMIPBHBLL;

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public IReadOnlyCollection<object> EMHPKMIPKED
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x58C1D0", Offset = "0x58B1D0", VA = "0x18058C1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public bool HDAGGNGDAHI
	{
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x513B100", Offset = "0x513A100", VA = "0x18513B100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public int AGNENIFEHDL
	{
		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x618670", Offset = "0x617670", VA = "0x180618670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x513B190", Offset = "0x513A190", VA = "0x18513B190")]
	public bool NJFAMEHLCGO(object DLNBPAAGBNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x513B110", Offset = "0x513A110", VA = "0x18513B110")]
	public bool INAIIIEHGLD(object DLNBPAAGBNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x513B0A0", Offset = "0x513A0A0", VA = "0x18513B0A0")]
	public bool DNKBNIOBOIB(object DLNBPAAGBNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x513B040", Offset = "0x513A040", VA = "0x18513B040")]
	public void AIGACNBFNKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x513B210", Offset = "0x513A210", VA = "0x18513B210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x513B380", Offset = "0x513A380", VA = "0x18513B380")]
	public BAFGANADAFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public class BCDONPANGCG<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	private struct DMJKADCJGNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public float JPIKPEGDJEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public T MHLLNAFLMHJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private Dictionary<object, DMJKADCJGNJ> MEGJCAHADIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private T NPFLOLCBIDF;

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public virtual T LJICFAELDND
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x10EF7A0", Offset = "0x10EE7A0", VA = "0x1810EF7A0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x189BB00", Offset = "0x189AB00", VA = "0x18189BB00", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public object MOBFGFCAFNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x58EDF0", Offset = "0x58DDF0", VA = "0x18058EDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x6C4580", Offset = "0x6C3580", VA = "0x1806C4580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public bool PFAMEIFIGBC
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x2ED6730", Offset = "0x2ED5730", VA = "0x182ED6730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x2ED4880", Offset = "0x2ED3880", VA = "0x182ED4880")]
	public bool GLIJNCAGDLH(T BMNJAHFFOPC, object DLNBPAAGBNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x2ED66B0", Offset = "0x2ED56B0", VA = "0x182ED66B0")]
	public bool HNEMFBJMDHE(object DLNBPAAGBNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x2ED4850", Offset = "0x2ED3850", VA = "0x182ED4850")]
	public void BFHLNDADIAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x2ED68A0", Offset = "0x2ED58A0", VA = "0x182ED68A0")]
	public bool NOGIDOCGHEN(object DLNBPAAGBNI, out T BMNJAHFFOPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x2ED62D0", Offset = "0x2ED52D0", VA = "0x182ED62D0")]
	private bool HBDAAKCCABD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x2ED69F0", Offset = "0x2ED59F0", VA = "0x182ED69F0")]
	public BCDONPANGCG()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public class FIEGLPKEOLP
{
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static byte[] KGMNFGCKGCC;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static int PACKDELFILO;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static int EAEPHMJCION;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static BigInteger BEBMPCAFPLJ;

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public FIEGLPKEOLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x513BF00", Offset = "0x513AF00", VA = "0x18513BF00")]
	private static string EHOHANMBAEF(byte[] PEAHMNEGGIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x513C000", Offset = "0x513B000", VA = "0x18513C000")]
	public static string GFDPFHBIGNB(byte[] KCNDJOGONOI, bool LFHPFEDNDMG)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
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
