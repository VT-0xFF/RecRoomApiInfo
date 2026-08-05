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
public class FHAINJFGBBF : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6CF000", Offset = "0x6CD800", VA = "0x1806CF000")]
	public FHAINJFGBBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4E3B480", Offset = "0x4E39C80", VA = "0x184E3B480")]
	public byte[] PLHNOLNBHEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void CMBDGMDFLCD(IncrementalHash MNKLNMHPAPP);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xBF9D00", Offset = "0xBF8500", VA = "0x180BF9D00")]
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
	[EIHJBFIJLEO]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[EIHJBFIJLEO]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4E3E2D0", Offset = "0x4E3CAD0", VA = "0x184E3E2D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4E3E290", Offset = "0x4E3CA90", VA = "0x184E3E290")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4E3E310", Offset = "0x4E3CB10", VA = "0x184E3E310")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4E3E520", Offset = "0x4E3CD20", VA = "0x184E3E520")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4E3E490", Offset = "0x4E3CC90", VA = "0x184E3E490")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xE7E3C0", Offset = "0xE7CBC0", VA = "0x180E7E3C0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xE12300", Offset = "0xE10B00", VA = "0x180E12300")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4E3E250", Offset = "0x4E3CA50", VA = "0x184E3E250")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4E3E400", Offset = "0x4E3CC00", VA = "0x184E3E400")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4E3DC80", Offset = "0x4E3C480", VA = "0x184E3DC80")]
	public void CopyBounds(SavedExtents GKBKHIIEFAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4E3E1C0", Offset = "0x4E3C9C0", VA = "0x184E3E1C0")]
	public void SetLocalSpaceBounds(Bounds OFLIICJPOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x804AE0", Offset = "0x8032E0", VA = "0x180804AE0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4E3DFA0", Offset = "0x4E3C7A0", VA = "0x184E3DFA0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4E3DFB0", Offset = "0x4E3C7B0", VA = "0x184E3DFB0")]
	private void PMDOFAMPLIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4E3DD70", Offset = "0x4E3C570", VA = "0x184E3DD70")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4E3D6C0", Offset = "0x4E3BEC0", VA = "0x184E3D6C0")]
	public static void CalculateLocalBoundsFor(GameObject NJCEGNEAEJH, out Bounds OFLIICJPOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4E3DCB0", Offset = "0x4E3C4B0", VA = "0x184E3DCB0")]
	private static void OMBJOBLMGGE(Bounds FMMAACMCILJ, Color MCODHPOGBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4E3E1E0", Offset = "0x4E3C9E0", VA = "0x184E3E1E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5611D0", Offset = "0x55F9D0", VA = "0x1805611D0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x561EE0", Offset = "0x5606E0", VA = "0x180561EE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5611C0", Offset = "0x55F9C0", VA = "0x1805611C0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5614A0", Offset = "0x55FCA0", VA = "0x1805614A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x561E80", Offset = "0x560680", VA = "0x180561E80", Slot = "4")]
	public virtual void IGAJGADHMED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1BA2E10", Offset = "0x1BA1610", VA = "0x181BA2E10")]
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
	[FHAINJFGBBF]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x282D2E0", Offset = "0x282BAE0", VA = "0x18282D2E0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x282CE20", Offset = "0x282B620", VA = "0x18282CE20", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x282D8E0", Offset = "0x282C0E0", VA = "0x18282D8E0")]
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
	private sealed class ONGBDLBPHBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1BA2E10", Offset = "0x1BA1610", VA = "0x181BA2E10")]
		public ONGBDLBPHBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x35D82E0", Offset = "0x35D6AE0", VA = "0x1835D82E0")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[FHAINJFGBBF]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5611D0", Offset = "0x55F9D0", VA = "0x1805611D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x35CC0A0", Offset = "0x35CA8A0", VA = "0x1835CC0A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x35CC0D0", Offset = "0x35CA8D0", VA = "0x1835CC0D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x35CBFF0", Offset = "0x35CA7F0", VA = "0x1835CBFF0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public TVal this[TKey BJKKIOODGOA]
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x35CC020", Offset = "0x35CA820", VA = "0x1835CC020", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x35CBEF0", Offset = "0x35CA6F0", VA = "0x1835CBEF0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x35CB750", Offset = "0x35C9F50", VA = "0x1835CB750", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x35CB0C0", Offset = "0x35C98C0", VA = "0x1835CB0C0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x35CACF0", Offset = "0x35C94F0", VA = "0x1835CACF0", Slot = "14")]
	protected virtual string NHAIJLIMDCB(TKeyVal BBCGHEDINOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2E47910", Offset = "0x2E46110", VA = "0x182E47910", Slot = "4")]
	public bool ContainsKey(TKey BJKKIOODGOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x35CBDE0", Offset = "0x35CA5E0", VA = "0x1835CBDE0", Slot = "5")]
	public bool TryGetValue(TKey BJKKIOODGOA, out TVal MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x35CAC30", Offset = "0x35C9430", VA = "0x1835CAC30", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x35CAC30", Offset = "0x35C9430", VA = "0x1835CAC30", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x35CBE10", Offset = "0x35CA610", VA = "0x1835CBE10")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class HBGFADPMBAD<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class IDFPADGHBJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1BA2E10", Offset = "0x1BA1610", VA = "0x181BA2E10")]
		public IDFPADGHBJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3A263E0", Offset = "0x3A24BE0", VA = "0x183A263E0")]
		internal bool <GetSamples>b__0(global::JEIJHHJGJEP<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly float LACBBFMAJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly float LDDNKFOCLGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private List<global::JEIJHHJGJEP<float, T>> EFEELHLEOBG;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int LFMEMFHOLLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3A1AFD0", Offset = "0x3A197D0", VA = "0x183A1AFD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3A1B190", Offset = "0x3A19990", VA = "0x183A1B190")]
	public HBGFADPMBAD(float PHFGMDKGIJK, float NNDFGJOFEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3A1AE70", Offset = "0x3A19670", VA = "0x183A1AE70")]
	public bool KONFMAKLKBJ(float EPBBCHMOFCN, T MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3A1A600", Offset = "0x3A18E00", VA = "0x183A1A600")]
	public int ANBDNHLNHNC(float EPBBCHMOFCN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3A1A690", Offset = "0x3A18E90", VA = "0x183A1A690")]
	public IEnumerable<T> DHDOOLJPMGM(float EPBBCHMOFCN, [Optional] float? HFMAHHCIBJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3A1A660", Offset = "0x3A18E60", VA = "0x183A1A660")]
	public void BNEMLHGGHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3A1B0D0", Offset = "0x3A198D0", VA = "0x183A1B0D0")]
	private void OGEINGACIJH(float EPBBCHMOFCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class IICPDPJLKBE<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct OOOPKBOOOEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public T CIFMBHMEFPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float PNBNHPKCNNB;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static float OFEJFGJHFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private List<T> IDKIJKDDGJI;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private const int HBPAKBKHKGH = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private OOOPKBOOOEP[] ECGFLNEOIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int NALAFEEKKJE;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float KBOOGILELJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xF36A30", Offset = "0xF35230", VA = "0x180F36A30")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xC9EEE0", Offset = "0xC9D6E0", VA = "0x180C9EEE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1D975F0", Offset = "0x1D95DF0", VA = "0x181D975F0")]
	public IICPDPJLKBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1D97510", Offset = "0x1D95D10", VA = "0x181D97510")]
	public IICPDPJLKBE(int DDMFGCPNLGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1D96960", Offset = "0x1D95160", VA = "0x181D96960")]
	public void IONNJMGFDPB(float EPBBCHMOFCN, T MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1D95FE0", Offset = "0x1D947E0", VA = "0x181D95FE0")]
	public void BNEMLHGGHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x1D965F0", Offset = "0x1D94DF0", VA = "0x181D965F0")]
	public bool HMGEEILFBHF(float KBCDOFHLMAP, float AHHLDEANCNN, out T MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1D96C50", Offset = "0x1D95450", VA = "0x181D96C50")]
	public bool PDLEJLKOEAH(float KBCDOFHLMAP, float AHHLDEANCNN, out T MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1D970D0", Offset = "0x1D958D0", VA = "0x181D970D0")]
	public void PKGJJBDIJMC(float KBCDOFHLMAP, float AHHLDEANCNN, List<T> MGGGNBHMHDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1D96C20", Offset = "0x1D95420", VA = "0x181D96C20")]
	private int PBLNOGLPLMD(int GHLBEDMNIKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1D96BE0", Offset = "0x1D953E0", VA = "0x181D96BE0")]
	private void KOPGGLELHGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T JDHEENCCIIH();

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T BMJBNCNEAPH(T LLKALDKKJFP, T EIFOFLJGEEA, float AHIMPPGEGDB);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T GLKFEOODFCE(T MFBIHMKFNKA, float AHIMPPGEGDB);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T IGDIGEFLBDG(T LLKALDKKJFP, T EIFOFLJGEEA);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T GHLLJPCNAOP(T LLKALDKKJFP, T EIFOFLJGEEA);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class HDFGGOOMFJK : global::IICPDPJLKBE<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4E3B350", Offset = "0x4E39B50", VA = "0x184E3B350", Slot = "4")]
	protected override Vector3 JDHEENCCIIH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4E3B0D0", Offset = "0x4E398D0", VA = "0x184E3B0D0", Slot = "5")]
	protected override Vector3 BMJBNCNEAPH(Vector3 LLKALDKKJFP, Vector3 EIFOFLJGEEA, float AHIMPPGEGDB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4E3B200", Offset = "0x4E39A00", VA = "0x184E3B200", Slot = "6")]
	protected override Vector3 GLKFEOODFCE(Vector3 MFBIHMKFNKA, float AHIMPPGEGDB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4E3B2A0", Offset = "0x4E39AA0", VA = "0x184E3B2A0", Slot = "7")]
	protected override Vector3 IGDIGEFLBDG(Vector3 LLKALDKKJFP, Vector3 EIFOFLJGEEA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4E3B190", Offset = "0x4E39990", VA = "0x184E3B190", Slot = "8")]
	protected override Vector3 GHLLJPCNAOP(Vector3 LLKALDKKJFP, Vector3 EIFOFLJGEEA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4E3B3C0", Offset = "0x4E39BC0", VA = "0x184E3B3C0")]
	public HDFGGOOMFJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class FGJOIKMHLFJ : global::IICPDPJLKBE<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4E39F90", Offset = "0x4E38790", VA = "0x184E39F90")]
	public FGJOIKMHLFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4E39FF0", Offset = "0x4E387F0", VA = "0x184E39FF0")]
	public FGJOIKMHLFJ(int DDMFGCPNLGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0xCC5AC0", Offset = "0xCC42C0", VA = "0x180CC5AC0", Slot = "4")]
	protected override float JDHEENCCIIH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4E39F00", Offset = "0x4E38700", VA = "0x184E39F00", Slot = "5")]
	protected override float BMJBNCNEAPH(float LLKALDKKJFP, float EIFOFLJGEEA, float AHIMPPGEGDB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3F3EF00", Offset = "0x3F3D700", VA = "0x183F3EF00", Slot = "6")]
	protected override float GLKFEOODFCE(float MFBIHMKFNKA, float AHIMPPGEGDB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x29D2C20", Offset = "0x29D1420", VA = "0x1829D2C20", Slot = "7")]
	protected override float IGDIGEFLBDG(float LLKALDKKJFP, float EIFOFLJGEEA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4E39F80", Offset = "0x4E38780", VA = "0x184E39F80", Slot = "8")]
	protected override float GHLLJPCNAOP(float LLKALDKKJFP, float EIFOFLJGEEA)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class MACIBANHAPA
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x19BBC20", Offset = "0x19BA420", VA = "0x1819BBC20")]
	public static global::HJCKNLNAFCH<T1> JHOEBDGEJAE<T1>(T1 EJGPPOJHNJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1E5A370", Offset = "0x1E58B70", VA = "0x181E5A370")]
	public static global::JEIJHHJGJEP<T1, T2> JHOEBDGEJAE<T1, T2>(T1 EJGPPOJHNJF, T2 KGMFHLFODBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1FC4580", Offset = "0x1FC2D80", VA = "0x181FC4580")]
	public static global::CJCDMFEOEOE<T1, T2, T3> JHOEBDGEJAE<T1, T2, T3>(T1 EJGPPOJHNJF, T2 KGMFHLFODBN, T3 HLGMELMDMOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1E4C2A0", Offset = "0x1E4AAA0", VA = "0x181E4C2A0")]
	public static global::HEKCFNKIALC<T1, T2, T3, T4> JHOEBDGEJAE<T1, T2, T3, T4>(T1 EJGPPOJHNJF, T2 KGMFHLFODBN, T3 HLGMELMDMOK, T4 EPEMFEKOCKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1FBB4B0", Offset = "0x1FB9CB0", VA = "0x181FBB4B0")]
	public static global::FACCAIHFLFG<T1, T2, T3, T4, T5> JHOEBDGEJAE<T1, T2, T3, T4, T5>(T1 EJGPPOJHNJF, T2 KGMFHLFODBN, T3 HLGMELMDMOK, T4 EPEMFEKOCKN, T5 IECLAAKKNOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1E5A4B0", Offset = "0x1E58CB0", VA = "0x181E5A4B0")]
	public static global::MJJNBLFMIDI<T1, T2, T3, T4, T5, T6> JHOEBDGEJAE<T1, T2, T3, T4, T5, T6>(T1 EJGPPOJHNJF, T2 KGMFHLFODBN, T3 HLGMELMDMOK, T4 EPEMFEKOCKN, T5 IECLAAKKNOL, T6 KCDMLCGGNPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1FC4610", Offset = "0x1FC2E10", VA = "0x181FC4610")]
	public static global::DNFOEJDDMKL<T1, T2, T3, T4, T5, T6, T7> JHOEBDGEJAE<T1, T2, T3, T4, T5, T6, T7>(T1 EJGPPOJHNJF, T2 KGMFHLFODBN, T3 HLGMELMDMOK, T4 EPEMFEKOCKN, T5 IECLAAKKNOL, T6 KCDMLCGGNPJ, T7 MGFKFABHDLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1E5A3E0", Offset = "0x1E58BE0", VA = "0x181E5A3E0")]
	public static global::KGKHKMINIGM<T1, T2, T3, T4, T5, T6, T7, T8> JHOEBDGEJAE<T1, T2, T3, T4, T5, T6, T7, T8>(T1 EJGPPOJHNJF, T2 KGMFHLFODBN, T3 HLGMELMDMOK, T4 EPEMFEKOCKN, T5 IECLAAKKNOL, T6 KCDMLCGGNPJ, T7 MGFKFABHDLJ, T8 OJEKLAEMBFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1879F80", Offset = "0x1878780", VA = "0x181879F80")]
	[IteratorStateMachine(typeof(FMJNAHLLLNJ))]
	public static IEnumerable<global::JEIJHHJGJEP<T1, T2>> AKDAFHFFNKH<T1, T2>(IEnumerable<T1> OOKPIHBNHGF, IEnumerable<T2> FMMAACMCILJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x187BB00", Offset = "0x187A300", VA = "0x18187BB00")]
	[IteratorStateMachine(typeof(APOFFCDPLAP))]
	public static IEnumerable<global::CJCDMFEOEOE<T1, T2, T3>> AKDAFHFFNKH<T1, T2, T3>(IEnumerable<T1> OOKPIHBNHGF, IEnumerable<T2> FMMAACMCILJ, IEnumerable<T3> MCODHPOGBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x24B65F0", Offset = "0x24B4DF0", VA = "0x1824B65F0")]
	internal static int GFPGCKJJPLF(int KNFPENNEDOE, int JEECPCJLFCJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3B58020", Offset = "0x3B56820", VA = "0x183B58020")]
	internal static int GFPGCKJJPLF(int KNFPENNEDOE, int JEECPCJLFCJ, int OOBIOGOFEJG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3B58030", Offset = "0x3B56830", VA = "0x183B58030")]
	internal static int GFPGCKJJPLF(int KNFPENNEDOE, int JEECPCJLFCJ, int OOBIOGOFEJG, int JPLBICFHNBG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4E3C010", Offset = "0x4E3A810", VA = "0x184E3C010")]
	internal static int GFPGCKJJPLF(int KNFPENNEDOE, int JEECPCJLFCJ, int OOBIOGOFEJG, int JPLBICFHNBG, int GAIKCHBNFIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4E3C030", Offset = "0x4E3A830", VA = "0x184E3C030")]
	internal static int GFPGCKJJPLF(int KNFPENNEDOE, int JEECPCJLFCJ, int OOBIOGOFEJG, int JPLBICFHNBG, int GAIKCHBNFIM, int OHHLHDIOGOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4E3BFE0", Offset = "0x4E3A7E0", VA = "0x184E3BFE0")]
	internal static int GFPGCKJJPLF(int KNFPENNEDOE, int JEECPCJLFCJ, int OOBIOGOFEJG, int JPLBICFHNBG, int GAIKCHBNFIM, int OHHLHDIOGOJ, int ANAIFJIBBNE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4E3C050", Offset = "0x4E3A850", VA = "0x184E3C050")]
	internal static int GFPGCKJJPLF(int KNFPENNEDOE, int JEECPCJLFCJ, int OOBIOGOFEJG, int JPLBICFHNBG, int GAIKCHBNFIM, int OHHLHDIOGOJ, int ANAIFJIBBNE, int MKFOBHJDKKN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HJCKNLNAFCH<T1> : IComparable<global::HJCKNLNAFCH<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T1 CGJODAAIBHH;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1F9B960", Offset = "0x1F9A160", VA = "0x181F9B960")]
	public HJCKNLNAFCH(T1 EJGPPOJHNJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x36758D0", Offset = "0x36740D0", VA = "0x1836758D0", Slot = "4")]
	public int CompareTo(global::HJCKNLNAFCH<T1> GKBKHIIEFAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3675940", Offset = "0x3674140", VA = "0x183675940", Slot = "0")]
	public override bool Equals(object GKBKHIIEFAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7F7590", Offset = "0x7F5D90", VA = "0x1807F7590", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x36759E0", Offset = "0x36741E0", VA = "0x1836759E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class JEIJHHJGJEP<T1, T2> : IComparable<global::JEIJHHJGJEP<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T1 CGJODAAIBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T2 KEOEKIIHGPM;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4085A50", Offset = "0x4084250", VA = "0x184085A50")]
	public JEIJHHJGJEP(T1 EJGPPOJHNJF, T2 KGMFHLFODBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3669F00", Offset = "0x3668700", VA = "0x183669F00", Slot = "4")]
	public int CompareTo(global::JEIJHHJGJEP<T1, T2> GKBKHIIEFAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x366A020", Offset = "0x3668820", VA = "0x18366A020", Slot = "0")]
	public override bool Equals(object GKBKHIIEFAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x366A180", Offset = "0x3668980", VA = "0x18366A180", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x366A200", Offset = "0x3668A00", VA = "0x18366A200", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class CJCDMFEOEOE<T1, T2, T3> : IComparable<global::CJCDMFEOEOE<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 CGJODAAIBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 KEOEKIIHGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T3 FENCGDCFMFB;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3455710", Offset = "0x3453F10", VA = "0x183455710")]
	public CJCDMFEOEOE(T1 EJGPPOJHNJF, T2 KGMFHLFODBN, T3 HLGMELMDMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3455030", Offset = "0x3453830", VA = "0x183455030", Slot = "4")]
	public int CompareTo(global::CJCDMFEOEOE<T1, T2, T3> GKBKHIIEFAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3455130", Offset = "0x3453930", VA = "0x183455130", Slot = "0")]
	public override bool Equals(object GKBKHIIEFAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3455420", Offset = "0x3453C20", VA = "0x183455420", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3455580", Offset = "0x3453D80", VA = "0x183455580", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class HEKCFNKIALC<T1, T2, T3, T4> : IComparable<global::HEKCFNKIALC<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T1 CGJODAAIBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T2 KEOEKIIHGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T3 FENCGDCFMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T4 AFFKOACANCF;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2193FF0", Offset = "0x21927F0", VA = "0x182193FF0")]
	public HEKCFNKIALC(T1 EJGPPOJHNJF, T2 KGMFHLFODBN, T3 HLGMELMDMOK, T4 EPEMFEKOCKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3A1BC00", Offset = "0x3A1A400", VA = "0x183A1BC00", Slot = "4")]
	public int CompareTo(global::HEKCFNKIALC<T1, T2, T3, T4> GKBKHIIEFAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3A1BD40", Offset = "0x3A1A540", VA = "0x183A1BD40", Slot = "0")]
	public override bool Equals(object GKBKHIIEFAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3A1BE60", Offset = "0x3A1A660", VA = "0x183A1BE60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3A1BF20", Offset = "0x3A1A720", VA = "0x183A1BF20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class FACCAIHFLFG<T1, T2, T3, T4, T5> : IComparable<global::FACCAIHFLFG<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T1 CGJODAAIBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T2 KEOEKIIHGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T3 FENCGDCFMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T4 AFFKOACANCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T5 JMMKAFDHNNL;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x35CC840", Offset = "0x35CB040", VA = "0x1835CC840")]
	public FACCAIHFLFG(T1 EJGPPOJHNJF, T2 KGMFHLFODBN, T3 HLGMELMDMOK, T4 EPEMFEKOCKN, T5 IECLAAKKNOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x35CC350", Offset = "0x35CAB50", VA = "0x1835CC350", Slot = "4")]
	public int CompareTo(global::FACCAIHFLFG<T1, T2, T3, T4, T5> GKBKHIIEFAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x35CC4D0", Offset = "0x35CACD0", VA = "0x1835CC4D0", Slot = "0")]
	public override bool Equals(object GKBKHIIEFAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x35CC610", Offset = "0x35CAE10", VA = "0x1835CC610", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x35CC710", Offset = "0x35CAF10", VA = "0x1835CC710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class MJJNBLFMIDI<T1, T2, T3, T4, T5, T6> : IComparable<global::MJJNBLFMIDI<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T1 CGJODAAIBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T2 KEOEKIIHGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T3 FENCGDCFMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T4 AFFKOACANCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T5 JMMKAFDHNNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T6 GHKKNLACLHA;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2189810", Offset = "0x2188010", VA = "0x182189810")]
	public MJJNBLFMIDI(T1 EJGPPOJHNJF, T2 KGMFHLFODBN, T3 HLGMELMDMOK, T4 EPEMFEKOCKN, T5 IECLAAKKNOL, T6 KCDMLCGGNPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2189270", Offset = "0x2187A70", VA = "0x182189270", Slot = "4")]
	public int CompareTo(global::MJJNBLFMIDI<T1, T2, T3, T4, T5, T6> GKBKHIIEFAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2189430", Offset = "0x2187C30", VA = "0x182189430", Slot = "0")]
	public override bool Equals(object GKBKHIIEFAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x21895A0", Offset = "0x2187DA0", VA = "0x1821895A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x21896C0", Offset = "0x2187EC0", VA = "0x1821896C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class DNFOEJDDMKL<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::DNFOEJDDMKL<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T1 CGJODAAIBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T2 KEOEKIIHGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T3 FENCGDCFMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T4 AFFKOACANCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T5 JMMKAFDHNNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T6 GHKKNLACLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T7 FPNAKPJKKOE;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3478F50", Offset = "0x3477750", VA = "0x183478F50")]
	public DNFOEJDDMKL(T1 EJGPPOJHNJF, T2 KGMFHLFODBN, T3 HLGMELMDMOK, T4 EPEMFEKOCKN, T5 IECLAAKKNOL, T6 KCDMLCGGNPJ, T7 MGFKFABHDLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x34788F0", Offset = "0x34770F0", VA = "0x1834788F0", Slot = "4")]
	public int CompareTo(global::DNFOEJDDMKL<T1, T2, T3, T4, T5, T6, T7> GKBKHIIEFAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3478AF0", Offset = "0x34772F0", VA = "0x183478AF0", Slot = "0")]
	public override bool Equals(object GKBKHIIEFAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3478C90", Offset = "0x3477490", VA = "0x183478C90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3478DE0", Offset = "0x34775E0", VA = "0x183478DE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class KGKHKMINIGM<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::KGKHKMINIGM<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T1 CGJODAAIBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T2 KEOEKIIHGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T3 FENCGDCFMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T4 AFFKOACANCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T5 JMMKAFDHNNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T6 GHKKNLACLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T7 FPNAKPJKKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T8 OEPMILEIMJG;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2962450", Offset = "0x2960C50", VA = "0x182962450")]
	public KGKHKMINIGM(T1 EJGPPOJHNJF, T2 KGMFHLFODBN, T3 HLGMELMDMOK, T4 EPEMFEKOCKN, T5 IECLAAKKNOL, T6 KCDMLCGGNPJ, T7 MGFKFABHDLJ, T8 OJEKLAEMBFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2961D40", Offset = "0x2960540", VA = "0x182961D40", Slot = "4")]
	public int CompareTo(global::KGKHKMINIGM<T1, T2, T3, T4, T5, T6, T7, T8> GKBKHIIEFAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2961F90", Offset = "0x2960790", VA = "0x182961F90", Slot = "0")]
	public override bool Equals(object GKBKHIIEFAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2962150", Offset = "0x2960950", VA = "0x182962150", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x29622C0", Offset = "0x2960AC0", VA = "0x1829622C0", Slot = "3")]
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
	public T CIFMBHMEFPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x589A30", Offset = "0x588230", VA = "0x180589A30")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6828D0", Offset = "0x6810D0", VA = "0x1806828D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float CEHBKMAPOLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xEA7970", Offset = "0xEA6170", VA = "0x180EA7970")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4BEC9A0", Offset = "0x4BEB1A0", VA = "0x184BEC9A0")]
	public T MNEBHPEINEN(float AHIMPPGEGDB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4BEC800", Offset = "0x4BEB000", VA = "0x184BEC800")]
	public T CLFBEINLNOG(float AHIMPPGEGDB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T BMJBNCNEAPH(T LLKALDKKJFP, T EIFOFLJGEEA, float AHIMPPGEGDB);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1BA2E10", Offset = "0x1BA1610", VA = "0x181BA2E10")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4E3AE70", Offset = "0x4E39670", VA = "0x184E3AE70", Slot = "4")]
	protected override float BMJBNCNEAPH(float LLKALDKKJFP, float EIFOFLJGEEA, float AHIMPPGEGDB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4E3AEF0", Offset = "0x4E396F0", VA = "0x184E3AEF0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4E3F480", Offset = "0x4E3DC80", VA = "0x184E3F480", Slot = "4")]
	protected override Vector3 BMJBNCNEAPH(Vector3 LLKALDKKJFP, Vector3 EIFOFLJGEEA, float AHIMPPGEGDB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4E3F540", Offset = "0x4E3DD40", VA = "0x184E3F540")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4E385D0", Offset = "0x4E36DD0", VA = "0x184E385D0", Slot = "4")]
	protected override Color BMJBNCNEAPH(Color LLKALDKKJFP, Color EIFOFLJGEEA, float AHIMPPGEGDB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4E38620", Offset = "0x4E36E20", VA = "0x184E38620")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class IOPIMMLDDIP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly IDisposable GBAAOFDIJNK;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x561E80", Offset = "0x560680", VA = "0x180561E80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
	public IOPIMMLDDIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[DefaultMember("Item")]
public sealed class BGPEIBFIKBD<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly AHCBFGLNCFM CHPBGBIIOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private T[] KPBDGKEGNGO;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int GJEPFFENNCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x561CD0", Offset = "0x5604D0", VA = "0x180561CD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5E2A10", Offset = "0x5E1210", VA = "0x1805E2A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T PDOIHJPOGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x3AA4700", Offset = "0x3AA2F00", VA = "0x183AA4700")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3AA3CC0", Offset = "0x3AA24C0", VA = "0x183AA3CC0")]
	public static global::BGPEIBFIKBD<T> BAPHMNFAJJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3AA4440", Offset = "0x3AA2C40", VA = "0x183AA4440")]
	public static global::BGPEIBFIKBD<T> KPGOMLIBGPH(int FFHMMNBBJIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3AA48E0", Offset = "0x3AA30E0", VA = "0x183AA48E0")]
	private BGPEIBFIKBD(T[] CFJMEKFEPPD, int FFHMMNBBJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3AA3DF0", Offset = "0x3AA25F0", VA = "0x183AA3DF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3AA4070", Offset = "0x3AA2870", VA = "0x183AA4070")]
	public void IONNJMGFDPB(in T MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3AA3170", Offset = "0x3AA1970", VA = "0x183AA3170")]
	public void AKGGEDBEDOG(int CFANIPEBCPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3AA3210", Offset = "0x3AA1A10", VA = "0x183AA3210")]
	public void AKLLNNAAAGJ(int DDMFGCPNLGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3AA4580", Offset = "0x3AA2D80", VA = "0x183AA4580")]
	private void OCMKAFFOPBE(int FFHMMNBBJIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class IDOMIGOBOBN
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF7B0", Offset = "0x1FBDFB0", VA = "0x181FBF7B0")]
	public static global::BGPEIBFIKBD<T> BAPHMNFAJJN<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x19BFA90", Offset = "0x19BE290", VA = "0x1819BFA90")]
	public static global::BGPEIBFIKBD<T> KPGOMLIBGPH<T>(int FFHMMNBBJIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct PJMDODMLCLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<HGPEMCJLGLF>> BNNJANLOGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int CCPDFCLHGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private int DALKGIKNPAN;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8A65C0", Offset = "0x8A4DC0", VA = "0x1808A65C0")]
	private PJMDODMLCLE(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<HGPEMCJLGLF>> HNMFKJOCFBM, int OKMFEMLGIGO, int GMBFCMDCOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4E3C5C0", Offset = "0x4E3ADC0", VA = "0x184E3C5C0")]
	public static PJMDODMLCLE BAPHMNFAJJN()
	{
		return default(PJMDODMLCLE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4E3C6F0", Offset = "0x4E3AEF0", VA = "0x184E3C6F0")]
	public (int, int, Task) NFMIAFJEGIP(int OFDDFGBMNKD)
	{
		return default((int, int, Task));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4E3C640", Offset = "0x4E3AE40", VA = "0x184E3C640")]
	public void BOFPINOHHFN(int OFDDFGBMNKD, int GMBFCMDCOMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[DefaultMember("Item")]
public class GFMOPFKENHB<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly Dictionary<TKey, TVal> EJNKOJHDDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Dictionary<TVal, TKey> IPAGMBEMLBL;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int GJEPFFENNCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x1B9F310", Offset = "0x1B9DB10", VA = "0x181B9F310", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool LFMMFBCPEJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x561EC0", Offset = "0x5606C0", VA = "0x180561EC0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public ICollection<TKey> JGBNGJPBNKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x1D98F00", Offset = "0x1D97700", VA = "0x181D98F00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TVal> JHJMINNLBBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x1D98520", Offset = "0x1D96D20", VA = "0x181D98520", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public TVal PDOIHJPOGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x295B570", Offset = "0x2959D70", VA = "0x18295B570", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x33689B0", Offset = "0x33671B0", VA = "0x1833689B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TKey PDOIHJPOGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x33687A0", Offset = "0x3366FA0", VA = "0x1833687A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3368720", Offset = "0x3366F20", VA = "0x183368720")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3367DA0", Offset = "0x33665A0", VA = "0x183367DA0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3368800", Offset = "0x3367000", VA = "0x183368800", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x295B220", Offset = "0x2959A20", VA = "0x18295B220", Slot = "9")]
	public void Add(TKey BJKKIOODGOA, TVal MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3367D40", Offset = "0x3366540", VA = "0x183367D40", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> AJODLAHIEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2A03670", Offset = "0x2A01E70", VA = "0x182A03670", Slot = "8")]
	public bool ContainsKey(TKey BJKKIOODGOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3367E30", Offset = "0x3366630", VA = "0x183367E30", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> AJODLAHIEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2BCDA40", Offset = "0x2BCC240", VA = "0x182BCDA40", Slot = "10")]
	public bool Remove(TKey BJKKIOODGOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2BCDA40", Offset = "0x2BCC240", VA = "0x182BCDA40", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> AJODLAHIEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x33688A0", Offset = "0x33670A0", VA = "0x1833688A0", Slot = "11")]
	public bool TryGetValue(TKey BJKKIOODGOA, out TVal MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3368000", Offset = "0x3366800", VA = "0x183368000", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3367E60", Offset = "0x3366660", VA = "0x183367E60", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] ECGFLNEOIIM, int GAEDOACAGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3368380", Offset = "0x3366B80", VA = "0x183368380")]
	public void IONNJMGFDPB(TVal BPAFLPOFGHP, TKey BJKKIOODGOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x33683C0", Offset = "0x3366BC0", VA = "0x1833683C0")]
	public void IONNJMGFDPB(KeyValuePair<TVal, TKey> AJODLAHIEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3367EC0", Offset = "0x33666C0", VA = "0x183367EC0")]
	public bool ENMGGOLDCEG(TVal BJKKIOODGOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x26BCF30", Offset = "0x26BB730", VA = "0x1826BCF30")]
	public bool CDHEDEIGJMA(KeyValuePair<TVal, TKey> AJODLAHIEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x33684A0", Offset = "0x3366CA0", VA = "0x1833684A0")]
	public bool JPAMCOIJOBL(TVal BJKKIOODGOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x33684A0", Offset = "0x3366CA0", VA = "0x1833684A0")]
	public bool JPAMCOIJOBL(KeyValuePair<TVal, TKey> AJODLAHIEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x33686F0", Offset = "0x3366EF0", VA = "0x1833686F0")]
	public bool OADACMKKJNG(TVal BJKKIOODGOA, out TKey MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3367F80", Offset = "0x3366780", VA = "0x183367F80")]
	public IEnumerator<KeyValuePair<TVal, TKey>> FLCPDBCJAIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x33684D0", Offset = "0x3366CD0", VA = "0x1833684D0")]
	private void MMHALBANMIA(TKey BJKKIOODGOA, TVal BPAFLPOFGHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3368670", Offset = "0x3366E70", VA = "0x183368670")]
	private void NNNLOEONAIA(TKey BJKKIOODGOA, TVal BPAFLPOFGHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3368140", Offset = "0x3366940", VA = "0x183368140")]
	private bool IGOCCBLCPFH(TKey BJKKIOODGOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3368200", Offset = "0x3366A00", VA = "0x183368200")]
	private bool IGOCCBLCPFH(TVal BPAFLPOFGHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x33688D0", Offset = "0x33670D0", VA = "0x1833688D0")]
	public GFMOPFKENHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[DefaultMember("Item")]
public class JHBMGHMNEJG<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private global::JHBMGHMNEJG<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0xF36A30", Offset = "0xF35230", VA = "0x180F36A30", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x4187C60", Offset = "0x4186460", VA = "0x184187C60", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x41881C0", Offset = "0x41869C0", VA = "0x1841881C0")]
		public Enumerator(global::JHBMGHMNEJG<T> MGGGNBHMHDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x561E80", Offset = "0x560680", VA = "0x180561E80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x41879F0", Offset = "0x41861F0", VA = "0x1841879F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x4187B20", Offset = "0x4186320", VA = "0x184187B20", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x4187540", Offset = "0x4185D40", VA = "0x184187540")]
		private void CKKMBALIMFO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private T[] OGFGMOHGGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private int HKONJCKHNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private int FPNEDMKNKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private int CEHIIEKHBCF;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int GJEPFFENNCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x419DFD0", Offset = "0x419C7D0", VA = "0x18419DFD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public T PDOIHJPOGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x419F0E0", Offset = "0x419D8E0", VA = "0x18419F0E0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x419EF10", Offset = "0x419D710", VA = "0x18419EF10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x419F380", Offset = "0x419DB80", VA = "0x18419F380")]
	public JHBMGHMNEJG(int FFHMMNBBJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x419E830", Offset = "0x419D030", VA = "0x18419E830")]
	public void IONNJMGFDPB(T AHIMPPGEGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x419D300", Offset = "0x419BB00", VA = "0x18419D300")]
	public void ANMEOHCCMID(IEnumerable<T> DNFKPCJBKGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x419DFB0", Offset = "0x419C7B0", VA = "0x18419DFB0")]
	public void BNEMLHGGHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x419E170", Offset = "0x419C970", VA = "0x18419E170")]
	public void HOKACCBPPDG(int KLPGLGDELCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x419DF20", Offset = "0x419C720", VA = "0x18419DF20")]
	public void BHNNMJPFDOE(int KLPGLGDELCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x419E230", Offset = "0x419CA30", VA = "0x18419E230")]
	public void IJCLBMEAOBA(T[] ECGFLNEOIIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x419E080", Offset = "0x419C880", VA = "0x18419E080")]
	public Enumerator EGDKACNFMBB()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x419F240", Offset = "0x419DA40", VA = "0x18419F240", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x419F240", Offset = "0x419DA40", VA = "0x18419F240", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x419ED30", Offset = "0x419D530", VA = "0x18419ED30")]
	private int OFMEBENMNMF(int CFANIPEBCPB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x419E200", Offset = "0x419CA00", VA = "0x18419E200")]
	private int IGKDJFLNANB(int CFANIPEBCPB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct COLDEBFAKGC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly IDisposable[] KPBDGKEGNGO;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6ABD90", Offset = "0x6AA590", VA = "0x1806ABD90")]
	public COLDEBFAKGC(params IDisposable[] CFJMEKFEPPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0xC52360", Offset = "0xC50B60", VA = "0x180C52360")]
	public static COLDEBFAKGC BAPHMNFAJJN(params IDisposable[] CFJMEKFEPPD)
	{
		return default(COLDEBFAKGC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4E384B0", Offset = "0x4E36CB0", VA = "0x184E384B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct LNBFPELIBLH<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly IDisposable IBIBKOCJGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public T CIFMBHMEFPE;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2588320", Offset = "0x2586B20", VA = "0x182588320")]
	public LNBFPELIBLH(IDisposable OHIDPFBACFG, in T MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x1E59F80", Offset = "0x1E58780", VA = "0x181E59F80")]
	public static global::LNBFPELIBLH<U> MJIHGCENJMD<U>(in global::LNBFPELIBLH<T> OHIDPFBACFG, in U MFBIHMKFNKA)
	{
		return default(global::LNBFPELIBLH<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x1E4DF90", Offset = "0x1E4C790", VA = "0x181E4DF90")]
	public global::LNBFPELIBLH<U> NGIINMKHPJO<U>(in U MFBIHMKFNKA)
	{
		return default(global::LNBFPELIBLH<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x1E59FC0", Offset = "0x1E587C0", VA = "0x181E59FC0")]
	public static global::LNBFPELIBLH<(T, U)> NPMKDKFMHEK<U>(in global::LNBFPELIBLH<T> OOKPIHBNHGF, in global::LNBFPELIBLH<U> FMMAACMCILJ)
	{
		return default(global::LNBFPELIBLH<(T, U)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2588290", Offset = "0x2586A90", VA = "0x182588290", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class FADJEFHANAM
{
	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x1E4DF40", Offset = "0x1E4C740", VA = "0x181E4DF40")]
	public static global::LNBFPELIBLH<T> BAPHMNFAJJN<T>(IDisposable OHIDPFBACFG, in T MFBIHMKFNKA)
	{
		return default(global::LNBFPELIBLH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x1E4DF90", Offset = "0x1E4C790", VA = "0x181E4DF90")]
	public static global::LNBFPELIBLH<U> MJIHGCENJMD<U, T>(in global::LNBFPELIBLH<T> MOHAGKHNADH, in U MFBIHMKFNKA)
	{
		return default(global::LNBFPELIBLH<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x1E4DFC0", Offset = "0x1E4C7C0", VA = "0x181E4DFC0")]
	public static global::LNBFPELIBLH<(T, U)> NPMKDKFMHEK<T, U>(in global::LNBFPELIBLH<T> OOKPIHBNHGF, in global::LNBFPELIBLH<U> FMMAACMCILJ)
	{
		return default(global::LNBFPELIBLH<(T, U)>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct AHCBFGLNCFM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x561EC0", Offset = "0x5606C0", VA = "0x180561EC0")]
	public static AHCBFGLNCFM PMDCLFNPECG<T>([Optional] string JKKHCCJEKHF, [Optional] string POECCIABBIB, bool OOJKKAHKPEK = false)
	{
		return default(AHCBFGLNCFM);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x561E80", Offset = "0x560680", VA = "0x180561E80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DefaultMember("Item")]
public class HFICLDIALAH<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Func<Internal, External> HBMJDPHMOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly Func<External, Internal> LCNCNMLPALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private IList<Internal> DPOGJPHIACD;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public IList<Internal> ICIKKALGMNN
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x563DF0", Offset = "0x5625F0", VA = "0x180563DF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x58BD70", Offset = "0x58A570", VA = "0x18058BD70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool LFMMFBCPEJK
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5E2990", Offset = "0x5E1190", VA = "0x1805E2990", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7003F0", Offset = "0x6FEBF0", VA = "0x1807003F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public External PDOIHJPOGFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3A256D0", Offset = "0x3A23ED0", VA = "0x183A256D0", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x3A25770", Offset = "0x3A23F70", VA = "0x183A25770", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int GJEPFFENNCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x3A25670", Offset = "0x3A23E70", VA = "0x183A25670", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3A255E0", Offset = "0x3A23DE0", VA = "0x183A255E0")]
	public HFICLDIALAH(Func<Internal, External> HBMJDPHMOMC, Func<External, Internal> LCNCNMLPALH, bool LPAAGLDJCHL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3A25350", Offset = "0x3A23B50", VA = "0x183A25350", Slot = "6")]
	public int IndexOf(External AJODLAHIEME)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3A24F70", Offset = "0x3A23770", VA = "0x183A24F70", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3A24FD0", Offset = "0x3A237D0", VA = "0x183A24FD0", Slot = "13")]
	public bool Contains(External AJODLAHIEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3A25060", Offset = "0x3A23860", VA = "0x183A25060", Slot = "14")]
	public void CopyTo(External[] ECGFLNEOIIM, int GAEDOACAGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3A24E80", Offset = "0x3A23680", VA = "0x183A24E80", Slot = "11")]
	public void Add(External AJODLAHIEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3A25440", Offset = "0x3A23C40", VA = "0x183A25440", Slot = "7")]
	public void Insert(int CFANIPEBCPB, External AJODLAHIEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3A25550", Offset = "0x3A23D50", VA = "0x183A25550", Slot = "15")]
	public bool Remove(External AJODLAHIEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3A254E0", Offset = "0x3A23CE0", VA = "0x183A254E0", Slot = "8")]
	public void RemoveAt(int CFANIPEBCPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3A25280", Offset = "0x3A23A80", VA = "0x183A25280", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x1DDE6D0", Offset = "0x1DDCED0", VA = "0x181DDE6D0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public class LDFOIGNGDGI<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly Func<Internal, External> HBMJDPHMOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private IReadOnlyList<Internal> DPOGJPHIACD;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public IReadOnlyList<Internal> ICIKKALGMNN
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5611C0", Offset = "0x55F9C0", VA = "0x1805611C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5614A0", Offset = "0x55FCA0", VA = "0x1805614A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool LFMMFBCPEJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x561FE0", Offset = "0x5607E0", VA = "0x180561FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public External PDOIHJPOGFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x26B35C0", Offset = "0x26B1DC0", VA = "0x1826B35C0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int GJEPFFENNCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x26B3560", Offset = "0x26B1D60", VA = "0x1826B3560", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x1F9B960", Offset = "0x1F9A160", VA = "0x181F9B960")]
	public LDFOIGNGDGI(Func<Internal, External> HBMJDPHMOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x26B3510", Offset = "0x26B1D10", VA = "0x1826B3510")]
	public LDFOIGNGDGI(IReadOnlyList<Internal> DPOGJPHIACD, Func<Internal, External> HBMJDPHMOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x26B32F0", Offset = "0x26B1AF0", VA = "0x1826B32F0")]
	public void IJCLBMEAOBA(External[] ECGFLNEOIIM, int GAEDOACAGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x26B3280", Offset = "0x26B1A80", VA = "0x1826B3280", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x1C5D6A0", Offset = "0x1C5BEA0", VA = "0x181C5D6A0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[DefaultMember("Item")]
public class LDCJKNABAOI<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private IReadOnlyList<Internal> DPOGJPHIACD;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public IReadOnlyList<Internal> ICIKKALGMNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5611D0", Offset = "0x55F9D0", VA = "0x1805611D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x561490", Offset = "0x55FC90", VA = "0x180561490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool LFMMFBCPEJK
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x561FE0", Offset = "0x5607E0", VA = "0x180561FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public External PDOIHJPOGFK
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x26B2290", Offset = "0x26B0A90", VA = "0x1826B2290", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int GJEPFFENNCK
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x26B2230", Offset = "0x26B0A30", VA = "0x1826B2230", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x1F9B960", Offset = "0x1F9A160", VA = "0x181F9B960")]
	public LDCJKNABAOI(IReadOnlyList<Internal> DPOGJPHIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x26B1EF0", Offset = "0x26B06F0", VA = "0x1826B1EF0")]
	public bool CDHEDEIGJMA(External AJODLAHIEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x26B2000", Offset = "0x26B0800", VA = "0x1826B2000")]
	public void IJCLBMEAOBA(External[] ECGFLNEOIIM, int GAEDOACAGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x26B1F90", Offset = "0x26B0790", VA = "0x1826B1F90", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x1DDE6D0", Offset = "0x1DDCED0", VA = "0x181DDE6D0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public abstract class CBJEKJFEEOD
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void PIMMIIONJOM(object[] DHAMMIIHHBF);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
	protected CBJEKJFEEOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public abstract class CCIFEKDLIEJ<T> : CBJEKJFEEOD
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	protected struct JBAHDBKMMME
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public enum GGCBBFGINGI
		{
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public GGCBBFGINGI DMBEFJIHONB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public T DJBODGKMGGL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private int GMANBAGCBEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly bool KPNDCMOAOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	protected readonly bool JGONEINHOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	protected List<T> NODEDLJBIJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private List<JBAHDBKMMME> MIGJKOOCAIL;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool BPJDGMIGFKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x361DAE0", Offset = "0x361C2E0", VA = "0x18361DAE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x361E260", Offset = "0x361CA60", VA = "0x18361E260")]
	protected CCIFEKDLIEJ(bool JGONEINHOKL, bool KPNDCMOAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x361E0E0", Offset = "0x361C8E0", VA = "0x18361E0E0")]
	protected bool MHEELPLIIOJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x361E180", Offset = "0x361C980", VA = "0x18361E180")]
	protected void NCEFIGOMIPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x361DC50", Offset = "0x361C450", VA = "0x18361DC50")]
	protected void DKLBLANPJJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x1D25FA0", Offset = "0x1D247A0", VA = "0x181D25FA0")]
	private static void PBCHKLGIGJN<U>(ref List<U> DPOGJPHIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x361DE00", Offset = "0x361C600", VA = "0x18361DE00", Slot = "5")]
	public void IONNJMGFDPB(T DJBODGKMGGL, bool PBEPGECDECM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x361DF80", Offset = "0x361C780", VA = "0x18361DF80", Slot = "6")]
	public void JPAMCOIJOBL(T DJBODGKMGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x361DB20", Offset = "0x361C320", VA = "0x18361DB20")]
	public void BNEMLHGGHNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface EAGAFCENEAD
{
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IONNJMGFDPB(Action DJBODGKMGGL, bool PBEPGECDECM = false);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JPAMCOIJOBL(Action DJBODGKMGGL);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class EBEHMDGBKDH : global::CCIFEKDLIEJ<Action>, EAGAFCENEAD
{
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x4E39B50", Offset = "0x4E38350", VA = "0x184E39B50")]
	public EBEHMDGBKDH(bool JGONEINHOKL = false, bool KPNDCMOAOCD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x4E39910", Offset = "0x4E38110", VA = "0x184E39910")]
	public void PDFCGMMIIKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x4E39AD0", Offset = "0x4E382D0", VA = "0x184E39AD0", Slot = "4")]
	public override void PIMMIIONJOM(object[] DHAMMIIHHBF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x4E39850", Offset = "0x4E38050", VA = "0x184E39850")]
	public static EBEHMDGBKDH GCJLOHFJPJA(EBEHMDGBKDH KLGKANJBCOO, Action DJBODGKMGGL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x4E398B0", Offset = "0x4E380B0", VA = "0x184E398B0")]
	public static EBEHMDGBKDH KAHEKGMBKFK(EBEHMDGBKDH KLGKANJBCOO, Action DJBODGKMGGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface JBBOLFHCCDM<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IONNJMGFDPB(Action<T> DJBODGKMGGL, bool PBEPGECDECM = false);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JPAMCOIJOBL(Action<T> DJBODGKMGGL);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class AKCANMNILAC<T> : global::CCIFEKDLIEJ<Action<T>>, global::JBBOLFHCCDM<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x1D945E0", Offset = "0x1D92DE0", VA = "0x181D945E0")]
	public AKCANMNILAC(bool JGONEINHOKL = false, bool KPNDCMOAOCD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x2BC7E10", Offset = "0x2BC6610", VA = "0x182BC7E10")]
	public void PDFCGMMIIKI(T AHIMPPGEGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x2BCAAF0", Offset = "0x2BC92F0", VA = "0x182BCAAF0", Slot = "4")]
	public override void PIMMIIONJOM(object[] DHAMMIIHHBF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x2BC6EF0", Offset = "0x2BC56F0", VA = "0x182BC6EF0")]
	public static global::AKCANMNILAC<T> GCJLOHFJPJA(global::AKCANMNILAC<T> KLGKANJBCOO, Action<T> DJBODGKMGGL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x2BC6F90", Offset = "0x2BC5790", VA = "0x182BC6F90")]
	public static global::AKCANMNILAC<T> KAHEKGMBKFK(global::AKCANMNILAC<T> KLGKANJBCOO, Action<T> DJBODGKMGGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface AIPBGCHKFIL<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IONNJMGFDPB(Action<T, U> DJBODGKMGGL, bool PBEPGECDECM = false);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JPAMCOIJOBL(Action<T, U> DJBODGKMGGL);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class OIBDELKGGAL<T, U> : global::CCIFEKDLIEJ<Action<T, U>>, global::AIPBGCHKFIL<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x1D945E0", Offset = "0x1D92DE0", VA = "0x181D945E0")]
	public OIBDELKGGAL(bool JGONEINHOKL = false, bool KPNDCMOAOCD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x36AD260", Offset = "0x36ABA60", VA = "0x1836AD260")]
	public void PDFCGMMIIKI(T AHIMPPGEGDB, U HIJOPBOGMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3D915B0", Offset = "0x3D8FDB0", VA = "0x183D915B0", Slot = "4")]
	public override void PIMMIIONJOM(object[] DHAMMIIHHBF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x36AB000", Offset = "0x36A9800", VA = "0x1836AB000")]
	public static global::OIBDELKGGAL<T, U> GCJLOHFJPJA(global::OIBDELKGGAL<T, U> KLGKANJBCOO, Action<T, U> DJBODGKMGGL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x36AB0A0", Offset = "0x36A98A0", VA = "0x1836AB0A0")]
	public static global::OIBDELKGGAL<T, U> KAHEKGMBKFK(global::OIBDELKGGAL<T, U> KLGKANJBCOO, Action<T, U> DJBODGKMGGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface IIGODPLDOAF<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IONNJMGFDPB(Action<T, U, V> DJBODGKMGGL, bool PBEPGECDECM = false);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JPAMCOIJOBL(Action<T, U, V> DJBODGKMGGL);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class BEBPFHHHDLM<T, U, V> : global::CCIFEKDLIEJ<Action<T, U, V>>, global::IIGODPLDOAF<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x1D945E0", Offset = "0x1D92DE0", VA = "0x181D945E0")]
	public BEBPFHHHDLM(bool JGONEINHOKL = false, bool KPNDCMOAOCD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x3AA0170", Offset = "0x3A9E970", VA = "0x183AA0170")]
	public void PDFCGMMIIKI(T AHIMPPGEGDB, U HIJOPBOGMED, V ANCLCJIJMKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x40888A0", Offset = "0x40870A0", VA = "0x1840888A0", Slot = "4")]
	public override void PIMMIIONJOM(object[] DHAMMIIHHBF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3AA0030", Offset = "0x3A9E830", VA = "0x183AA0030")]
	public static global::BEBPFHHHDLM<T, U, V> GCJLOHFJPJA(global::BEBPFHHHDLM<T, U, V> KLGKANJBCOO, Action<T, U, V> DJBODGKMGGL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x3AA00D0", Offset = "0x3A9E8D0", VA = "0x183AA00D0")]
	public static global::BEBPFHHHDLM<T, U, V> KAHEKGMBKFK(global::BEBPFHHHDLM<T, U, V> KLGKANJBCOO, Action<T, U, V> DJBODGKMGGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface CIFFIAPCGDC<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IONNJMGFDPB(Action<T, U, V, W> DJBODGKMGGL, bool PBEPGECDECM = false);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JPAMCOIJOBL(Action<T, U, V, W> DJBODGKMGGL);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class IGHACMNGGMK<T, U, V, W> : global::CCIFEKDLIEJ<Action<T, U, V, W>>, global::CIFFIAPCGDC<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x1D945E0", Offset = "0x1D92DE0", VA = "0x181D945E0")]
	public IGHACMNGGMK(bool JGONEINHOKL = false, bool KPNDCMOAOCD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x4795110", Offset = "0x4793910", VA = "0x184795110")]
	public void PDFCGMMIIKI(T AHIMPPGEGDB, U HIJOPBOGMED, V ANCLCJIJMKE, W ENPBHFNIBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x4795D70", Offset = "0x4794570", VA = "0x184795D70", Slot = "4")]
	public override void PIMMIIONJOM(object[] DHAMMIIHHBF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x1D92AF0", Offset = "0x1D912F0", VA = "0x181D92AF0")]
	public static global::IGHACMNGGMK<T, U, V, W> GCJLOHFJPJA(global::IGHACMNGGMK<T, U, V, W> KLGKANJBCOO, Action<T, U, V, W> DJBODGKMGGL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x1D92B90", Offset = "0x1D91390", VA = "0x181D92B90")]
	public static global::IGHACMNGGMK<T, U, V, W> KAHEKGMBKFK(global::IGHACMNGGMK<T, U, V, W> KLGKANJBCOO, Action<T, U, V, W> DJBODGKMGGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface GCHILPFFJFM<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IONNJMGFDPB(Action<T, U, V, W, X> DJBODGKMGGL, bool PBEPGECDECM = false);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JPAMCOIJOBL(Action<T, U, V, W, X> DJBODGKMGGL);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class HKPDPNOBCFP<T, U, V, W, X> : global::CCIFEKDLIEJ<Action<T, U, V, W, X>>, global::GCHILPFFJFM<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x1D945E0", Offset = "0x1D92DE0", VA = "0x181D945E0")]
	public HKPDPNOBCFP(bool JGONEINHOKL = false, bool KPNDCMOAOCD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x3677A20", Offset = "0x3676220", VA = "0x183677A20")]
	public void PDFCGMMIIKI(T AHIMPPGEGDB, U HIJOPBOGMED, V ANCLCJIJMKE, W ENPBHFNIBIC, X FMMKCBAOFKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x3677CC0", Offset = "0x36764C0", VA = "0x183677CC0", Slot = "4")]
	public override void PIMMIIONJOM(object[] DHAMMIIHHBF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x36775D0", Offset = "0x3675DD0", VA = "0x1836775D0")]
	public static global::HKPDPNOBCFP<T, U, V, W, X> GCJLOHFJPJA(global::HKPDPNOBCFP<T, U, V, W, X> KLGKANJBCOO, Action<T, U, V, W, X> DJBODGKMGGL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x3677670", Offset = "0x3675E70", VA = "0x183677670")]
	public static global::HKPDPNOBCFP<T, U, V, W, X> KAHEKGMBKFK(global::HKPDPNOBCFP<T, U, V, W, X> KLGKANJBCOO, Action<T, U, V, W, X> DJBODGKMGGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface CNMEHLFHMEP<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IONNJMGFDPB(Action<T, U, V, W, X, Y> DJBODGKMGGL, bool PBEPGECDECM = false);

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JPAMCOIJOBL(Action<T, U, V, W, X, Y> DJBODGKMGGL);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public sealed class JKADDLCKBBL<T, U, V, W, X, Y> : global::CCIFEKDLIEJ<Action<T, U, V, W, X, Y>>, global::CNMEHLFHMEP<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x1D945E0", Offset = "0x1D92DE0", VA = "0x181D945E0")]
	public JKADDLCKBBL(bool JGONEINHOKL = false, bool KPNDCMOAOCD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x2EA4A00", Offset = "0x2EA3200", VA = "0x182EA4A00")]
	public void PDFCGMMIIKI(T AHIMPPGEGDB, U HIJOPBOGMED, V ANCLCJIJMKE, W ENPBHFNIBIC, X FMMKCBAOFKA, Y HPNMBFKMIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x2EA4F80", Offset = "0x2EA3780", VA = "0x182EA4F80", Slot = "4")]
	public override void PIMMIIONJOM(object[] DHAMMIIHHBF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x2EA45B0", Offset = "0x2EA2DB0", VA = "0x182EA45B0")]
	public static global::JKADDLCKBBL<T, U, V, W, X, Y> GCJLOHFJPJA(global::JKADDLCKBBL<T, U, V, W, X, Y> KLGKANJBCOO, Action<T, U, V, W, X, Y> DJBODGKMGGL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2EA4650", Offset = "0x2EA2E50", VA = "0x182EA4650")]
	public static global::JKADDLCKBBL<T, U, V, W, X, Y> KAHEKGMBKFK(global::JKADDLCKBBL<T, U, V, W, X, Y> KLGKANJBCOO, Action<T, U, V, W, X, Y> DJBODGKMGGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class HNOIJOKGLGE<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public readonly struct BLIFPGNGNIN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private readonly global::HNOIJOKGLGE<T> GBELKJHPJIM;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public T CIFMBHMEFPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x3674600", Offset = "0x3672E00", VA = "0x183674600")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x36745D0", Offset = "0x3672DD0", VA = "0x1836745D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6ABD90", Offset = "0x6AA590", VA = "0x1806ABD90")]
		public BLIFPGNGNIN(global::HNOIJOKGLGE<T> GBELKJHPJIM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct DGMDNOMHKCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder<BLIFPGNGNIN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public global::HNOIJOKGLGE<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x3674BA0", Offset = "0x36733A0", VA = "0x183674BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3674D70", Offset = "0x3673570", VA = "0x183674D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct OLPIODHGACJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder<BLIFPGNGNIN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public global::HNOIJOKGLGE<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3688570", Offset = "0x3686D70", VA = "0x183688570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3674D70", Offset = "0x3673570", VA = "0x183674D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly SemaphoreSlim ALJFKPFKHAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private T JMOINLHNEAK;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int BDIILOOPJEO
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x367DA60", Offset = "0x367C260", VA = "0x18367DA60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x367E0C0", Offset = "0x367C8C0", VA = "0x18367E0C0")]
	public HNOIJOKGLGE(in T JMOINLHNEAK, int JDDBODAOLPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x367E200", Offset = "0x367CA00", VA = "0x18367E200")]
	public HNOIJOKGLGE(in T JMOINLHNEAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x367DAC0", Offset = "0x367C2C0", VA = "0x18367DAC0")]
	public BLIFPGNGNIN CNIEMGJOOPO()
	{
		return default(BLIFPGNGNIN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x367DA80", Offset = "0x367C280", VA = "0x18367DA80")]
	public BLIFPGNGNIN CNIEMGJOOPO(CancellationToken LFOGICEEHBE)
	{
		return default(BLIFPGNGNIN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x367DB00", Offset = "0x367C300", VA = "0x18367DB00")]
	[AsyncStateMachine(typeof(global::HNOIJOKGLGE<>.DGMDNOMHKCK))]
	public Task<BLIFPGNGNIN> PCCDJNEDJGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x367DC60", Offset = "0x367C460", VA = "0x18367DC60")]
	[AsyncStateMachine(typeof(global::HNOIJOKGLGE<>.OLPIODHGACJ))]
	public Task<BLIFPGNGNIN> PCCDJNEDJGD(CancellationToken LFOGICEEHBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class PLBOEFDNEPF
{
	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x4E3C960", Offset = "0x4E3B160", VA = "0x184E3C960")]
	public static global::HNOIJOKGLGE<HGPEMCJLGLF> BAPHMNFAJJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x4E3C9C0", Offset = "0x4E3B1C0", VA = "0x184E3C9C0")]
	public static global::HNOIJOKGLGE<HGPEMCJLGLF> BAPHMNFAJJN(int JDDBODAOLPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x19BBC20", Offset = "0x19BA420", VA = "0x1819BBC20")]
	public static global::HNOIJOKGLGE<T> BAPHMNFAJJN<T>(in T JMOINLHNEAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x1E5EBF0", Offset = "0x1E5D3F0", VA = "0x181E5EBF0")]
	public static global::HNOIJOKGLGE<T> BAPHMNFAJJN<T>(in T JMOINLHNEAK, int JDDBODAOLPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class JJLEFOILODG<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public delegate bool JEHBBCFKHJE(global::JJLEFOILODG<T> HCLJNIDPDDK);

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class CKKFKMGCMFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public T nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public global::JJLEFOILODG<T> foundNode;

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x1BA2E10", Offset = "0x1BA1610", VA = "0x181BA2E10")]
		public CKKFKMGCMFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2E97D20", Offset = "0x2E96520", VA = "0x182E97D20")]
		internal bool <FindNode>b__0(global::JJLEFOILODG<T> node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public T PHAGDNDMFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public LinkedList<global::JJLEFOILODG<T>> LJGPANFGKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public global::JJLEFOILODG<T> AAFBLFKJOEJ;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public global::JJLEFOILODG<T> PAIJNEEMEIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x5B4130", Offset = "0x5B2930", VA = "0x1805B4130")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2EA3A40", Offset = "0x2EA2240", VA = "0x182EA3A40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool NKICKLMEDGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x2EA2AB0", Offset = "0x2EA12B0", VA = "0x182EA2AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool JACAJEJCFPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2EA2860", Offset = "0x2EA1060", VA = "0x182EA2860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public global::JJLEFOILODG<T> APMCDMMCIMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2EA27A0", Offset = "0x2EA0FA0", VA = "0x182EA27A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x2EA4460", Offset = "0x2EA2C60", VA = "0x182EA4460")]
	public JJLEFOILODG(T BHOKFNONJIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x2EA28A0", Offset = "0x2EA10A0", VA = "0x182EA28A0")]
	public global::JJLEFOILODG<T> GIDFGAEEKPL(T BKNBBCFNAAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x2EA2CA0", Offset = "0x2EA14A0", VA = "0x182EA2CA0")]
	public global::JJLEFOILODG<T> JKKAHLKGDOH(T OBEFLMEHOIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x2EA2F00", Offset = "0x2EA1700", VA = "0x182EA2F00")]
	public global::JJLEFOILODG<T> JPAMCOIJOBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x2EA1EB0", Offset = "0x2EA06B0", VA = "0x182EA1EB0")]
	public void BNEMLHGGHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x2EA3C00", Offset = "0x2EA2400", VA = "0x182EA3C00")]
	public global::JJLEFOILODG<T> NLMJEKOEJKB(T NMIEICEKHGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x2EA3DE0", Offset = "0x2EA25E0", VA = "0x182EA3DE0")]
	public static void NOMNHFIPDFC(global::JJLEFOILODG<T> CDJBNJMJFHA, JEHBBCFKHJE KGHMBCJKMII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x33A1AA0", Offset = "0x33A02A0", VA = "0x1833A1AA0")]
	public static void NOMNHFIPDFC<A>(global::JJLEFOILODG<T> CDJBNJMJFHA, Func<global::JJLEFOILODG<T>, A, bool> KGHMBCJKMII, A OOLOJKLEIKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x2EA2FB0", Offset = "0x2EA17B0", VA = "0x182EA2FB0")]
	public static string MDMDOFECHHI(global::JJLEFOILODG<T> CDJBNJMJFHA, int LOOFANMHKBL = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x2EA2370", Offset = "0x2EA0B70", VA = "0x182EA2370")]
	public static global::JJLEFOILODG<T> COMMHCKOOJD(global::JJLEFOILODG<T> CDJBNJMJFHA, T KLJOPFNLKDN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class LFCDHBKJMOA<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public delegate Task<TResult> NMDHHOHHIAF(TRequest ANHMAOHNMJC, CancellationToken LFOGICEEHBE);

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public enum CKFOOANKDCG
	{
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class MJECKLMENCD
	{
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private const float DPPMKFCJLLP = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private TimeSpan HFIPIEMLDJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int JIBAGIFKAFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public CKFOOANKDCG IBHIFBHNHKA;

		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public static readonly MJECKLMENCD BNBEJHJGDAJ;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float ILADGBLKGOA
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x26BCFD0", Offset = "0x26BB7D0", VA = "0x1826BCFD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public TimeSpan NOLBCLIGHNN
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x5611D0", Offset = "0x55F9D0", VA = "0x1805611D0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x26BD190", Offset = "0x26BB990", VA = "0x1826BD190")]
		public MJECKLMENCD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private readonly struct AOEEPDAOFHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public readonly TRequest ANHMAOHNMJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public readonly CancellationToken LFOGICEEHBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public readonly TaskCompletionSource<TResult> FDGKJCFKKEI;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x26ABBF0", Offset = "0x26AA3F0", VA = "0x1826ABBF0")]
		public AOEEPDAOFHN(TRequest ANHMAOHNMJC, TaskCompletionSource<TResult> FDGKJCFKKEI, CancellationToken LFOGICEEHBE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class OJGGEANACGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x1BA2E10", Offset = "0x1BA1610", VA = "0x181BA2E10")]
		public OJGGEANACGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x1B9F310", Offset = "0x1B9DB10", VA = "0x181B9F310")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct JFLILNEEBPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public global::LFCDHBKJMOA<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x26AD220", Offset = "0x26ABA20", VA = "0x1826AD220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x7006D0", Offset = "0x6FEED0", VA = "0x1807006D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class DNDPHBNJKPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AOEEPDAOFHN req;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public global::LFCDHBKJMOA<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x1BA2E10", Offset = "0x1BA1610", VA = "0x181BA2E10")]
		public DNDPHBNJKPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x26AC420", Offset = "0x26AAC20", VA = "0x1826AC420")]
		internal void <ProcessQueue>b__0(Task<TResult> task)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly CancellationTokenSource HKJHDMEOGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly List<AOEEPDAOFHN> LLIELGCBGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly MJECKLMENCD OJAPLLCFDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly NMDHHOHHIAF IGFAEBDKGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private Task PJOLKHMBDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int NKELNADKOBK;

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x26B9D70", Offset = "0x26B8570", VA = "0x1826B9D70")]
	public LFCDHBKJMOA(NMDHHOHHIAF IGFAEBDKGCP, [Optional] MJECKLMENCD OJAPLLCFDCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x26B8BB0", Offset = "0x26B73B0", VA = "0x1826B8BB0")]
	public Task<TResult> FEIFAAJIKOO(TRequest ANHMAOHNMJC, CancellationToken LFOGICEEHBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x26B8820", Offset = "0x26B7020", VA = "0x1826B8820")]
	private void ENPDOEFNEDC(AOEEPDAOFHN KBLMEAAEHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x26B8630", Offset = "0x26B6E30", VA = "0x1826B8630")]
	[AsyncStateMachine(typeof(global::LFCDHBKJMOA<, >.JFLILNEEBPO))]
	private Task CLFGOLHDEOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x26B9540", Offset = "0x26B7D40", VA = "0x1826B9540")]
	private AOEEPDAOFHN HIHJJMBDNIA()
	{
		return default(AOEEPDAOFHN);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x26B97A0", Offset = "0x26B7FA0", VA = "0x1826B97A0")]
	private void NLKKDOHKGCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x26B8740", Offset = "0x26B6F40", VA = "0x1826B8740", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class FGBOPLLKBLE<TKey, TVal> : global::IDLNCHFLECO<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int AGOFHHDHCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	internal Dictionary<TKey, (TVal value, int size)> NCDOCICEDIK;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	internal override int GCBEOECAGKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x25F1C50", Offset = "0x25F0450", VA = "0x1825F1C50", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	internal int OJKGLNIFBCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x25F1C80", Offset = "0x25F0480", VA = "0x1825F1C80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public override int GJEPFFENNCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x25F1B50", Offset = "0x25F0350", VA = "0x1825F1B50", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x25F2120", Offset = "0x25F0920", VA = "0x1825F2120")]
	public FGBOPLLKBLE(int FFHMMNBBJIL, [Optional] AKKHDKGHBHP MBHDNFJHLLL, [Optional] IEqualityComparer<TKey> OIBFCHDFOIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x25F1AB0", Offset = "0x25F02B0", VA = "0x1825F1AB0")]
	public void CDCOAMHOCNK(TKey BJKKIOODGOA, TVal MFBIHMKFNKA, bool KCPJCKLHHCK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x25F1CB0", Offset = "0x25F04B0", VA = "0x1825F1CB0")]
	public bool JHINLPEIGBE(TKey BJKKIOODGOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x25F1F60", Offset = "0x25F0760", VA = "0x1825F1F60", Slot = "6")]
	public override bool OADACMKKJNG(TKey KCBJEAFAABP, out TVal MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x25F1D30", Offset = "0x25F0530", VA = "0x1825F1D30")]
	public bool NFPLOPKCNPO(TKey BJKKIOODGOA, TVal MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x25F2010", Offset = "0x25F0810", VA = "0x1825F2010")]
	public bool OKLKPNDMMDE(TKey BJKKIOODGOA, TVal MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x25F1A40", Offset = "0x25F0240", VA = "0x1825F1A40", Slot = "7")]
	public override void BNEMLHGGHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x25F1BB0", Offset = "0x25F03B0", VA = "0x1825F1BB0")]
	private bool DNBCLHFPMGC(TKey BJKKIOODGOA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[DefaultMember("Item")]
public class IDLNCHFLECO<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public delegate int AKKHDKGHBHP(TKey BJKKIOODGOA, TVal MFBIHMKFNKA);

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class PNKGAHIGBKB
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public TKey LOKNCHMIENF
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x5611D0", Offset = "0x55F9D0", VA = "0x1805611D0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public TVal CIFMBHMEFPE
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x688F70", Offset = "0x687770", VA = "0x180688F70")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x700010", Offset = "0x6FE810", VA = "0x180700010")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public int NBHCNACMKMB
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x6BD1F0", Offset = "0x6BB9F0", VA = "0x1806BD1F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x6BD220", Offset = "0x6BBA20", VA = "0x1806BD220")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public DateTime CNALCNMLDPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x563DF0", Offset = "0x5625F0", VA = "0x180563DF0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x1286920", Offset = "0x1285120", VA = "0x181286920")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x49CA800", Offset = "0x49C9000", VA = "0x1849CA800")]
		public PNKGAHIGBKB(TKey BJKKIOODGOA, TVal BPAFLPOFGHP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public const int NNJNDPLEKEF = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly Dictionary<TKey, LinkedListNode<PNKGAHIGBKB>> NONAKFMOEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly LinkedList<PNKGAHIGBKB> ODIGGOAOGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	protected readonly AKKHDKGHBHP MBHDNFJHLLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly TimeSpan JLJAGDIDIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly OPBAJAHKLKH IKAAJNOHAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int NPHJKKFNEAO;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int MBOBFNEGKPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x6C65F0", Offset = "0x6C4DF0", VA = "0x1806C65F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private bool NAMMFGCALNA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x49C4E70", Offset = "0x49C3670", VA = "0x1849C4E70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	internal virtual int GCBEOECAGKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x6C6600", Offset = "0x6C4E00", VA = "0x1806C6600", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	private int KLPGLGDELCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x1E1F680", Offset = "0x1E1DE80", VA = "0x181E1F680")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public virtual int GJEPFFENNCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x1C5D5B0", Offset = "0x1C5BDB0", VA = "0x181C5D5B0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<TKey> JGBNGJPBNKA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x49C56D0", Offset = "0x49C3ED0", VA = "0x1849C56D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public TVal PDOIHJPOGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x263F620", Offset = "0x263DE20", VA = "0x18263F620")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x39749D0", Offset = "0x39731D0", VA = "0x1839749D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x49C5E30", Offset = "0x49C4630", VA = "0x1849C5E30")]
	public IDLNCHFLECO(int FFHMMNBBJIL, [Optional] AKKHDKGHBHP MBHDNFJHLLL, [Optional] IEqualityComparer<TKey> OIBFCHDFOIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x49C5B40", Offset = "0x49C4340", VA = "0x1849C5B40")]
	public IDLNCHFLECO(TimeSpan JLJAGDIDIOG, [Optional] IEqualityComparer<TKey> OIBFCHDFOIK, [Optional] OPBAJAHKLKH IKAAJNOHAPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x49C5B90", Offset = "0x49C4390", VA = "0x1849C5B90")]
	public IDLNCHFLECO(int FFHMMNBBJIL, TimeSpan JLJAGDIDIOG, [Optional] IEqualityComparer<TKey> OIBFCHDFOIK, [Optional] OPBAJAHKLKH IKAAJNOHAPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x49C5BE0", Offset = "0x49C43E0", VA = "0x1849C5BE0")]
	public IDLNCHFLECO(int FFHMMNBBJIL, AKKHDKGHBHP MBHDNFJHLLL, TimeSpan JLJAGDIDIOG, [Optional] IEqualityComparer<TKey> OIBFCHDFOIK, [Optional] OPBAJAHKLKH IKAAJNOHAPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x49C4BA0", Offset = "0x49C33A0", VA = "0x1849C4BA0")]
	public void ILHIFLGOGFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x49C46E0", Offset = "0x49C2EE0", VA = "0x1849C46E0")]
	public void GCLFAKHIAMJ(TKey BJKKIOODGOA, TVal MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x49C4D10", Offset = "0x49C3510", VA = "0x1849C4D10")]
	public bool JPAMCOIJOBL(TKey BJKKIOODGOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x49C4580", Offset = "0x49C2D80", VA = "0x1849C4580")]
	private TVal FLCFGOMKECP(TKey KCBJEAFAABP)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x49C4F00", Offset = "0x49C3700", VA = "0x1849C4F00", Slot = "6")]
	public virtual bool OADACMKKJNG(TKey KCBJEAFAABP, out TVal MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x49C40C0", Offset = "0x49C28C0", VA = "0x1849C40C0", Slot = "7")]
	public virtual void BNEMLHGGHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x49C5270", Offset = "0x49C3A70", VA = "0x1849C5270")]
	private bool OCNHJKCHKJG(PNKGAHIGBKB IOELKPFLGGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x49C4130", Offset = "0x49C2930", VA = "0x1849C4130")]
	private void EADLPHOJEPF(LinkedListNode<PNKGAHIGBKB> BDDMHBNDDHE, TVal ICFAPCFNPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x49C5500", Offset = "0x49C3D00", VA = "0x1849C5500")]
	private void OKEGCOKGHHP(TKey BJKKIOODGOA, TVal MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x49C4860", Offset = "0x49C3060", VA = "0x1849C4860")]
	private void IDMJEJHLIMG(PNKGAHIGBKB IOELKPFLGGG, TVal ICFAPCFNPHF, int MPAHBNHIEDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[DefaultMember("Item")]
public class JPEGMMBMEMP<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly List<T> DPOGJPHIACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private HashSet<T> EBDHBMBIBDL;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int GJEPFFENNCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x1B9F310", Offset = "0x1B9DB10", VA = "0x181B9F310", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool LFMMFBCPEJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x561EC0", Offset = "0x5606C0", VA = "0x180561EC0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public T PDOIHJPOGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x295BC90", Offset = "0x295A490", VA = "0x18295BC90", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x295BD80", Offset = "0x295A580", VA = "0x18295BD80", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x295B2E0", Offset = "0x2959AE0", VA = "0x18295B2E0", Slot = "11")]
	public void Add(T AJODLAHIEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x295B310", Offset = "0x2959B10", VA = "0x18295B310")]
	public bool BGBJIKPDFEG(T AJODLAHIEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x295BB30", Offset = "0x295A330", VA = "0x18295BB30", Slot = "15")]
	public bool Remove(T AJODLAHIEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x295B4F0", Offset = "0x2959CF0", VA = "0x18295B4F0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x1DD6970", Offset = "0x1DD5170", VA = "0x181DD6970", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x295B460", Offset = "0x2959C60", VA = "0x18295B460", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x29536E0", Offset = "0x2951EE0", VA = "0x1829536E0", Slot = "13")]
	public bool Contains(T AJODLAHIEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x295B4C0", Offset = "0x2959CC0", VA = "0x18295B4C0", Slot = "14")]
	public void CopyTo(T[] ECGFLNEOIIM, int GAEDOACAGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x295B570", Offset = "0x2959D70", VA = "0x18295B570", Slot = "6")]
	public int IndexOf(T AJODLAHIEME)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x295B5A0", Offset = "0x2959DA0", VA = "0x18295B5A0", Slot = "7")]
	public void Insert(int CFANIPEBCPB, T AJODLAHIEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x295B900", Offset = "0x295A100", VA = "0x18295B900", Slot = "8")]
	public void RemoveAt(int CFANIPEBCPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x295B830", Offset = "0x295A030", VA = "0x18295B830")]
	public void MLPEKAEPDGA(Predicate<T> IJPHBEGKADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x295B730", Offset = "0x2959F30", VA = "0x18295B730")]
	public void JLAILMDDCFD(Comparison<T> GKEAECBBGGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x295BBB0", Offset = "0x295A3B0", VA = "0x18295BBB0")]
	public JPEGMMBMEMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class NMEHAPGACBG
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x4E3C080", Offset = "0x4E3A880", VA = "0x184E3C080")]
	public static Vector3 DDKCHJBGAMD(this GameObject NJCEGNEAEJH, float OLAIGFMFPDL)
	{
		return default(Vector3);
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x2035EA0", Offset = "0x20346A0", VA = "0x182035EA0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x4E3EA60", Offset = "0x4E3D260", VA = "0x184E3EA60")]
		public SerializedGuid(in Guid OFAPLABHPIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x4E3E5B0", Offset = "0x4E3CDB0", VA = "0x184E3E5B0")]
		public static SerializedGuid BOMGMKJICCH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x4E3E870", Offset = "0x4E3D070", VA = "0x184E3E870")]
		public static SerializedGuid FPCIEGGPHEJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4E3E630", Offset = "0x4E3CE30", VA = "0x184E3E630")]
		public bool CKKNCOMKHFE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x4E3EA30", Offset = "0x4E3D230", VA = "0x184E3EA30", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x4E3E990", Offset = "0x4E3D190", VA = "0x184E3E990", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x4E3E900", Offset = "0x4E3D100", VA = "0x184E3E900")]
		public bool HHFANCOAJID(in Guid OFAPLABHPIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x4E3E6F0", Offset = "0x4E3CEF0", VA = "0x184E3E6F0", Slot = "7")]
		public bool Equals(SerializedGuid GKBKHIIEFAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x4E3E790", Offset = "0x4E3CF90", VA = "0x184E3E790", Slot = "0")]
		public override bool Equals(object OMILIKJDDEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x4E3E8F0", Offset = "0x4E3D0F0", VA = "0x184E3E8F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x4E3E6C0", Offset = "0x4E3CEC0", VA = "0x184E3E6C0", Slot = "6")]
		public int CompareTo(SerializedGuid GKBKHIIEFAH)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class EAGGKHPBHID : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly Type NCKNGJHPBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly string OOKJNEDHFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly bool CKJBOEPDPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public readonly bool MNAANMEBGIG;

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x4E397E0", Offset = "0x4E37FE0", VA = "0x184E397E0")]
	public EAGGKHPBHID(Type NIHLIJBPIID, string BKCKKNLMBAN, bool GCPEPIFDAIL = false, bool JJAJEADOPPC = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface COFFMOEAFFC
{
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface DIDHAMMHPDI<T> : COFFMOEAFFC
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	T CIFMBHMEFPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool BHCADIEEAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	string CEEEBHBFBFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::DIDHAMMHPDI<T> AGKAAPEDOGB(Action<T> LALCAMKBDPG);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::DIDHAMMHPDI<T> JKBNFHMHHLF(Action<T> LALCAMKBDPG);

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::DIDHAMMHPDI<T> AJFCEOBEKPJ(Action<T, T> BJGJPOGNNKC);

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::DIDHAMMHPDI<T> GNMLDEDBHGF(Action<T, T> BJGJPOGNNKC);

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::DIDHAMMHPDI<T> NLNKLHMDKKI(Action<string> HHLPOPLGNGL);

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::DIDHAMMHPDI<T> NIDFGDMHBOB(Action<string> HHLPOPLGNGL);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class NGMDFKNNGDH<T> : global::DIDHAMMHPDI<T>, COFFMOEAFFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private global::OIBDELKGGAL<T, T> KKKGBJKALKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private global::AKCANMNILAC<T> JJMBCGJHOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private global::AKCANMNILAC<string> FDPMJLPAIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private string FHJBPHCDOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private T AFGNBGMNGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private bool AFEFCGJGLGF;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public T CIFMBHMEFPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x589A30", Offset = "0x588230", VA = "0x180589A30", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x2415BB0", Offset = "0x24143B0", VA = "0x182415BB0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool BHCADIEEAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x5E38B0", Offset = "0x5E20B0", VA = "0x1805E38B0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public string CEEEBHBFBFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x58A0C0", Offset = "0x5888C0", VA = "0x18058A0C0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x27D1760", Offset = "0x27CFF60", VA = "0x1827D1760", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x3974C80", Offset = "0x3973480", VA = "0x183974C80")]
	private void FINDIOADIDM(T LCPCMCBOFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x3974E70", Offset = "0x3973670", VA = "0x183974E70")]
	private void MOBPJMBKICD(string LMJMILCCPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x3974D70", Offset = "0x3973570", VA = "0x183974D70")]
	public void IDHIAHKAEGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x3974C30", Offset = "0x3973430", VA = "0x183974C30", Slot = "6")]
	public global::DIDHAMMHPDI<T> AJFCEOBEKPJ(Action<T, T> BJGJPOGNNKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x3974D20", Offset = "0x3973520", VA = "0x183974D20", Slot = "7")]
	public global::DIDHAMMHPDI<T> GNMLDEDBHGF(Action<T, T> BJGJPOGNNKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x3974BA0", Offset = "0x39733A0", VA = "0x183974BA0", Slot = "4")]
	public global::DIDHAMMHPDI<T> AGKAAPEDOGB(Action<T> BJGJPOGNNKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x3974E20", Offset = "0x3973620", VA = "0x183974E20", Slot = "5")]
	public global::DIDHAMMHPDI<T> JKBNFHMHHLF(Action<T> LALCAMKBDPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x3974F80", Offset = "0x3973780", VA = "0x183974F80", Slot = "8")]
	public global::DIDHAMMHPDI<T> NLNKLHMDKKI(Action<string> HHLPOPLGNGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x3974F10", Offset = "0x3973710", VA = "0x183974F10", Slot = "9")]
	public global::DIDHAMMHPDI<T> NIDFGDMHBOB(Action<string> HHLPOPLGNGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x3975010", Offset = "0x3973810", VA = "0x183975010")]
	public NGMDFKNNGDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class NGMEPCBHFDK
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class PBBILBLGFPP<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public global::DIDHAMMHPDI<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public global::FCENHLGFPDA<T> promise;

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x1BA2E10", Offset = "0x1BA1610", VA = "0x181BA2E10")]
		public PBBILBLGFPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x397B9C0", Offset = "0x397A1C0", VA = "0x18397B9C0")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x1D6BAA0", Offset = "0x1D6A2A0", VA = "0x181D6BAA0")]
	public static global::PKODKNLJGEP<T> AGCFOHCOPCO<T>(this global::DIDHAMMHPDI<T> AGNDECFIDCK, Action<T> IJOJDDBGAPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public sealed class JHEDKPNEPKB : global::DFNNHIGOAIC<string>
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class AENDNEEHOBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public Action<JHEDKPNEPKB> callback;

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		public AENDNEEHOBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x4E37170", Offset = "0x4E35970", VA = "0x184E37170")]
		internal void <Wrap>b__0(global::DFNNHIGOAIC<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x4E3B8A0", Offset = "0x4E3A0A0", VA = "0x184E3B8A0")]
	public JHEDKPNEPKB([Optional] int? PGKJJAFALJE, [Optional] Stopwatch JJOJBGFABCC, [Optional] Action<string, AKGDIMEOFMO> HGMMOCFOGKA, [Optional] Action<string, AKGDIMEOFMO> NKOHMJMOEBI, [Optional] Action<JHEDKPNEPKB> NOEFOALPEJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x4E3B670", Offset = "0x4E39E70", VA = "0x184E3B670")]
	private static Action<global::DFNNHIGOAIC<string>> DAJKFECJPFD(Action<JHEDKPNEPKB> IJOJDDBGAPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x4E3B730", Offset = "0x4E39F30", VA = "0x184E3B730")]
	public static global::IKCMMBLIDGP<JHEDKPNEPKB, string> IDPBCBJJLOC(JHEDKPNEPKB IEKKOBNPHHL, [Optional] Action<JHEDKPNEPKB> LPEOEJGHIOE)
	{
		return default(global::IKCMMBLIDGP<JHEDKPNEPKB, string>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class DFNNHIGOAIC<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private class FOMBIINIFIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public TKey LOKNCHMIENF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public AKGDIMEOFMO ECGFJFBAJBL;

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x1BA2E10", Offset = "0x1BA1610", VA = "0x181BA2E10")]
		public FOMBIINIFIO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public readonly struct AKGDIMEOFMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public readonly long DMIPOAIDPDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public readonly long APEHAGKPBCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public readonly int PGKJJAFALJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public readonly int CLGHBDLKGKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public readonly bool IMLAODEPEKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private readonly string PMKAGOLGMIM;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x2E3AAD0", Offset = "0x2E392D0", VA = "0x182E3AAD0")]
		public AKGDIMEOFMO(long DMIPOAIDPDL, int PGKJJAFALJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x2E3AAA0", Offset = "0x2E392A0", VA = "0x182E3AAA0")]
		public AKGDIMEOFMO(long DMIPOAIDPDL, long APEHAGKPBCJ, int PGKJJAFALJE, int CLGHBDLKGKN, bool IMLAODEPEKC, string PMKAGOLGMIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x2E3A970", Offset = "0x2E39170", VA = "0x182E3A970")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void NDFNHPFCHKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x2E3A900", Offset = "0x2E39100", VA = "0x182E3A900")]
		public int KBMOBKDGCLF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x2E3A950", Offset = "0x2E39150", VA = "0x182E3A950")]
		public int LKDGBBMHFBG(int LPIKFBCNHPE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x2E3A890", Offset = "0x2E39090", VA = "0x182E3A890")]
		public double IMHGHAJELOM()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x2E3A9E0", Offset = "0x2E391E0", VA = "0x182E3A9E0")]
		public AKGDIMEOFMO PIHANDPMMFJ(long APEHAGKPBCJ, int CLGHBDLKGKN)
		{
			return default(AKGDIMEOFMO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public readonly struct BEOFHLBNHHK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private readonly global::DFNNHIGOAIC<TKey> IEKKOBNPHHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private readonly TKey BJKKIOODGOA;

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x2E3ABE0", Offset = "0x2E393E0", VA = "0x182E3ABE0")]
		internal BEOFHLBNHHK(global::DFNNHIGOAIC<TKey> IEKKOBNPHHL, TKey BJKKIOODGOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x2E3AB40", Offset = "0x2E39340", VA = "0x182E3AB40", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class PAIGBOFGBCC : IEnumerable<(TKey, List<TKey>, AKGDIMEOFMO)>, IEnumerable, IEnumerator<(TKey, List<TKey>, AKGDIMEOFMO)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private (TKey key, List<TKey> path, AKGDIMEOFMO timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public global::DFNNHIGOAIC<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private HashSet<FOMBIINIFIO>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private IEnumerator<(TKey key, List<TKey> path, AKGDIMEOFMO timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		private (TKey, List<TKey>, AKGDIMEOFMO) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x2E3A540", Offset = "0x2E38D40", VA = "0x182E3A540", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, AKGDIMEOFMO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x2E49540", Offset = "0x2E47D40", VA = "0x182E49540", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x2E3A850", Offset = "0x2E39050", VA = "0x182E3A850")]
		[DebuggerHidden]
		public PAIGBOFGBCC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x2E495A0", Offset = "0x2E47DA0", VA = "0x182E495A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x2E490F0", Offset = "0x2E478F0", VA = "0x182E490F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x2E49670", Offset = "0x2E47E70", VA = "0x182E49670")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x2E49770", Offset = "0x2E47F70", VA = "0x182E49770")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x2E494F0", Offset = "0x2E47CF0", VA = "0x182E494F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x2E49400", Offset = "0x2E47C00", VA = "0x182E49400", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, AKGDIMEOFMO)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x2E494C0", Offset = "0x2E47CC0", VA = "0x182E494C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class ADNMLCFPMJL : IEnumerable<(TKey, List<TKey>, AKGDIMEOFMO)>, IEnumerable, IEnumerator<(TKey, List<TKey>, AKGDIMEOFMO)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private (TKey key, List<TKey> path, AKGDIMEOFMO timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private FOMBIINIFIO timerStackEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public FOMBIINIFIO <>3__timerStackEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public global::DFNNHIGOAIC<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private HashSet<FOMBIINIFIO>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private IEnumerator<(TKey key, List<TKey> path, AKGDIMEOFMO timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		private (TKey, List<TKey>, AKGDIMEOFMO) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x2E3A540", Offset = "0x2E38D40", VA = "0x182E3A540", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, AKGDIMEOFMO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x2E3A5C0", Offset = "0x2E38DC0", VA = "0x182E3A5C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x2E3A850", Offset = "0x2E39050", VA = "0x182E3A850")]
		[DebuggerHidden]
		public ADNMLCFPMJL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x2E3A620", Offset = "0x2E38E20", VA = "0x182E3A620", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x2E39FB0", Offset = "0x2E387B0", VA = "0x182E39FB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x2E3A6F0", Offset = "0x2E38EF0", VA = "0x182E3A6F0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x2E3A800", Offset = "0x2E39000", VA = "0x182E3A800")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x2E3A570", Offset = "0x2E38D70", VA = "0x182E3A570", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x2E3A460", Offset = "0x2E38C60", VA = "0x182E3A460", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, AKGDIMEOFMO)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x281BE30", Offset = "0x281A630", VA = "0x18281BE30", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly Action<TKey, AKGDIMEOFMO> HGMMOCFOGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private readonly Action<TKey, AKGDIMEOFMO> NKOHMJMOEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly Action<global::DFNNHIGOAIC<TKey>> NOEFOALPEJN;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private const string AGBJOGCPHLK = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly HashSet<FOMBIINIFIO> FLAEEHMBHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly Dictionary<FOMBIINIFIO, HashSet<FOMBIINIFIO>> MJFPFEHKBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly Stack<FOMBIINIFIO> GNKMEIMEPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private bool MGKCHJEDODG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private int JFIMPKENLHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly Stopwatch JJOJBGFABCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public readonly int NGNGCCALDDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private string PLDMBCFDKHI;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	[NotNull]
	public string KAPLCAKEEJI
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x573220", Offset = "0x571A20", VA = "0x180573220")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x2E416A0", Offset = "0x2E3FEA0", VA = "0x182E416A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public long FBPJNIBBFCG
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x2E41680", Offset = "0x2E3FE80", VA = "0x182E41680")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public int NLHABAJBMFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x2E412F0", Offset = "0x2E3FAF0", VA = "0x182E412F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x2E41A30", Offset = "0x2E40230", VA = "0x182E41A30")]
	public DFNNHIGOAIC([Optional] int? PGKJJAFALJE, [Optional][CanBeNull] Stopwatch JJOJBGFABCC, [Optional] Action<TKey, AKGDIMEOFMO> HGMMOCFOGKA, [Optional] Action<TKey, AKGDIMEOFMO> NKOHMJMOEBI, [Optional] Action<global::DFNNHIGOAIC<TKey>> NOEFOALPEJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x2E41070", Offset = "0x2E3F870", VA = "0x182E41070", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x2E41170", Offset = "0x2E3F970", VA = "0x182E41170")]
	public void EPFLFCKJPAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x2E41A10", Offset = "0x2E40210", VA = "0x182E41A10")]
	public void POHAGHAIHNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x2E41450", Offset = "0x2E3FC50", VA = "0x182E41450")]
	public static global::IKCMMBLIDGP<global::DFNNHIGOAIC<TKey>, TKey> IDPBCBJJLOC(global::DFNNHIGOAIC<TKey> IEKKOBNPHHL, [Optional] Action<global::DFNNHIGOAIC<TKey>> LPEOEJGHIOE)
	{
		return default(global::IKCMMBLIDGP<global::DFNNHIGOAIC<TKey>, TKey>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x2E41190", Offset = "0x2E3F990", VA = "0x182E41190")]
	[IteratorStateMachine(typeof(global::DFNNHIGOAIC<>.PAIGBOFGBCC))]
	public IEnumerable<(TKey, List<TKey>, AKGDIMEOFMO)> HCACPKPAAKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x2E41220", Offset = "0x2E3FA20", VA = "0x182E41220")]
	[IteratorStateMachine(typeof(global::DFNNHIGOAIC<>.ADNMLCFPMJL))]
	private IEnumerable<(TKey, List<TKey>, AKGDIMEOFMO)> HCACPKPAAKO(List<TKey> MNDDAEMGJPO, FOMBIINIFIO CFHPOJCHLIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x2E410E0", Offset = "0x2E3F8E0", VA = "0x182E410E0")]
	private (long, int) EBACJIILNAC()
	{
		return default((long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x2E41700", Offset = "0x2E3FF00", VA = "0x182E41700")]
	public void OANFHPKJDLP(TKey BJKKIOODGOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x2E41320", Offset = "0x2E3FB20", VA = "0x182E41320")]
	public void ICOPBMOBCAM(TKey BJKKIOODGOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x2E40ED0", Offset = "0x2E3F6D0", VA = "0x182E40ED0")]
	public void DAJKFECJPFD(TKey BJKKIOODGOA, Action DJBODGKMGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x21DBAB0", Offset = "0x21DA2B0", VA = "0x1821DBAB0")]
	public T DAJKFECJPFD<T>(TKey BJKKIOODGOA, Func<T> OFMJDNNNBPA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x1D28F40", Offset = "0x1D27740", VA = "0x181D28F40")]
	[AsyncStateMachine(typeof(CPFHNBBKGIO))]
	public Task<T> PDJMPNEEHCL<T>(TKey BJKKIOODGOA, Func<Task<T>> OFMJDNNNBPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x2E415A0", Offset = "0x2E3FDA0", VA = "0x182E415A0")]
	public BEOFHLBNHHK KCDANMEHALF(TKey BJKKIOODGOA)
	{
		return default(BEOFHLBNHHK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public readonly struct IKCMMBLIDGP<T, TKey> : IDisposable where T : global::DFNNHIGOAIC<TKey>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly bool ABPDHHPFDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly T IEKKOBNPHHL;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public T ELNDPHAOHMO
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x826EC0", Offset = "0x8256C0", VA = "0x180826EC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x1D97E80", Offset = "0x1D96680", VA = "0x181D97E80")]
	internal IKCMMBLIDGP(T IEKKOBNPHHL, bool ABPDHHPFDBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x1D97DF0", Offset = "0x1D965F0", VA = "0x181D97DF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public abstract class NLDBFCHEEMO<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut KDGJLGPLPKN(global::DFNNHIGOAIC<TKey> IEKKOBNPHHL);

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x1BA2E10", Offset = "0x1BA1610", VA = "0x181BA2E10")]
	protected NLDBFCHEEMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class PJIMMHFBCPO<TKey> : global::NLDBFCHEEMO<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public delegate string GMLIKDBHBJA(TKey BJKKIOODGOA);

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x37BB1C0", Offset = "0x37B99C0", VA = "0x1837BB1C0")]
	protected string EHNNJEJBGPD(double MDKGADBICMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x37BB170", Offset = "0x37B9970", VA = "0x1837BB170")]
	protected string EDBIGKANNOD(int BPIGAFENIAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x37BB130", Offset = "0x37B9930", VA = "0x1837BB130")]
	private static string BDOFDGBDBIM(TKey BJKKIOODGOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x37BB220", Offset = "0x37B9A20", VA = "0x1837BB220", Slot = "4")]
	public override string KDGJLGPLPKN(global::DFNNHIGOAIC<TKey> IEKKOBNPHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x37BB2D0", Offset = "0x37B9AD0", VA = "0x1837BB2D0")]
	public string KDGJLGPLPKN(global::DFNNHIGOAIC<TKey> IEKKOBNPHHL, [NotNull] GMLIKDBHBJA LNPNHEGAKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string ONPPICFLEDP(global::DFNNHIGOAIC<TKey> IEKKOBNPHHL, [NotNull] GMLIKDBHBJA LNPNHEGAKDG);

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x1DDE6D0", Offset = "0x1DDCED0", VA = "0x181DDE6D0")]
	protected PJIMMHFBCPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class APODPPLJJOC<TKey> : global::NLDBFCHEEMO<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public delegate string JDHBLCKPCFN(TKey BJKKIOODGOA);

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private const int HDAKCCFELEB = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private readonly string KCKDEFHOCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly double BJFMNNOOOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly bool JEFOKCEJJON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly int PGGHGHDMLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly ISet<string> AOAGAFPDMLF;

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x4070750", Offset = "0x406EF50", VA = "0x184070750")]
	private static string BDOFDGBDBIM(TKey BJKKIOODGOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x40710D0", Offset = "0x406F8D0", VA = "0x1840710D0")]
	public APODPPLJJOC(string KCKDEFHOCCN = "F2", double BJFMNNOOOGN = double.MaxValue, bool JEFOKCEJJON = false, int PGGHGHDMLLH = int.MaxValue, [Optional] ISet<string> AOAGAFPDMLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x4071020", Offset = "0x406F820", VA = "0x184071020", Slot = "4")]
	public override Dictionary<string, string> KDGJLGPLPKN(global::DFNNHIGOAIC<TKey> IEKKOBNPHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x4070AA0", Offset = "0x406F2A0", VA = "0x184070AA0")]
	private bool IKKFHOPONOO(string GIAEKHMALOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x4070B80", Offset = "0x406F380", VA = "0x184070B80")]
	public Dictionary<string, string> KDGJLGPLPKN(global::DFNNHIGOAIC<TKey> IEKKOBNPHHL, JDHBLCKPCFN LNPNHEGAKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x40708F0", Offset = "0x406F0F0", VA = "0x1840708F0")]
	private string IEHJOCJBHNM(StringBuilder KBEDEIACIGE, List<TKey> OAFOCANMEIA, JDHBLCKPCFN LNPNHEGAKDG, bool GNPBBMLHEHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x4070790", Offset = "0x406EF90", VA = "0x184070790")]
	private static void CCOBHOCEODG(StringBuilder DPIAMMBEOHC, string GKGOHCJJJPE, bool DBPNGDBHNFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class JJGNLEDCMEC<TKey> : global::PJIMMHFBCPO<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct ECNDBPEKFBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public GMLIKDBHBJA keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static global::JJGNLEDCMEC<TKey> GBAAOFDIJNK;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private const int LMPKIDFNGJD = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly string[] NDJOHBOKGCA;

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x2EA16F0", Offset = "0x2E9FEF0", VA = "0x182EA16F0")]
	private JJGNLEDCMEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x2EA07D0", Offset = "0x2E9EFD0", VA = "0x182EA07D0", Slot = "5")]
	protected override string ONPPICFLEDP(global::DFNNHIGOAIC<TKey> IEKKOBNPHHL, GMLIKDBHBJA LNPNHEGAKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x2EA06F0", Offset = "0x2E9EEF0", VA = "0x182EA06F0")]
	[CompilerGenerated]
	internal static string IMNHGPEBALJ(string NOPOBGNBINP, TKey BJKKIOODGOA, ref ECNDBPEKFBH P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class KLBBOPBMHBK<TKey> : global::PJIMMHFBCPO<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class JFONENEFMJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public GMLIKDBHBJA keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x1BA2E10", Offset = "0x1BA1610", VA = "0x181BA2E10")]
		public JFONENEFMJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x1D95D50", Offset = "0x1D94550", VA = "0x181D95D50")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x3C3AE10", Offset = "0x3C39610", VA = "0x183C3AE10", Slot = "5")]
	protected override string ONPPICFLEDP(global::DFNNHIGOAIC<TKey> IEKKOBNPHHL, GMLIKDBHBJA LNPNHEGAKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x2E494C0", Offset = "0x2E47CC0", VA = "0x182E494C0")]
	public KLBBOPBMHBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public abstract class OPBAJAHKLKH
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private class CJJMGGKJJGN : OPBAJAHKLKH
	{
		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public static OPBAJAHKLKH GBAAOFDIJNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x4E382F0", Offset = "0x4E36AF0", VA = "0x184E382F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public override DateTime HFBLAMHLPMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x4E38360", Offset = "0x4E36B60", VA = "0x184E38360", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public override float JNOBMJFOFHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x4E38350", Offset = "0x4E36B50", VA = "0x184E38350", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x4E38450", Offset = "0x4E36C50", VA = "0x184E38450")]
		public CJJMGGKJJGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static OPBAJAHKLKH NBEJLFJMMKM;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static OPBAJAHKLKH BNBEJHJGDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x4E3C440", Offset = "0x4E3AC40", VA = "0x184E3C440")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public abstract DateTime HFBLAMHLPMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public abstract float JNOBMJFOFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
	protected OPBAJAHKLKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class KIIEICGLEHF : global::CPIDDKEIFLB<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x4E3B9B0", Offset = "0x4E3A1B0", VA = "0x184E3B9B0")]
	public KIIEICGLEHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class CPIDDKEIFLB<T> : global::NHJNCCCICOA<T>, OJIPOCLKJMJ, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Task<T> MBANOJJCPDP
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x5611D0", Offset = "0x55F9D0", VA = "0x1805611D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private Task PLJAJCMBEGF
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x1B9E800", Offset = "0x1B9D000", VA = "0x181B9E800", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public global::PKODKNLJGEP<T> OGDMGCJENIE
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x5611C0", Offset = "0x55F9C0", VA = "0x1805611C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	private HFADLOCOGOG OIEBLMBHOOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x1BA3560", Offset = "0x1BA1D60", VA = "0x181BA3560", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x345B720", Offset = "0x3459F20", VA = "0x18345B720")]
	public CPIDDKEIFLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x561E80", Offset = "0x560680", VA = "0x180561E80", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class OAHGPDDBCOB : global::JEFAICGCEHL<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x4E3C310", Offset = "0x4E3AB10", VA = "0x184E3C310")]
	public OAHGPDDBCOB(Exception OADAOAPKMCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class JEFAICGCEHL<T> : global::NHJNCCCICOA<T>, OJIPOCLKJMJ, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public Task<T> MBANOJJCPDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x5611D0", Offset = "0x55F9D0", VA = "0x1805611D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	private Task PLJAJCMBEGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x1B9E800", Offset = "0x1B9D000", VA = "0x181B9E800", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public global::PKODKNLJGEP<T> OGDMGCJENIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x5611C0", Offset = "0x55F9C0", VA = "0x1805611C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	private HFADLOCOGOG OIEBLMBHOOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x1BA3560", Offset = "0x1BA1D60", VA = "0x181BA3560", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x3669E00", Offset = "0x3668600", VA = "0x183669E00")]
	public JEFAICGCEHL(Exception OADAOAPKMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x561E80", Offset = "0x560680", VA = "0x180561E80", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface OJIPOCLKJMJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000069")]
	[NotNull]
	Task MBANOJJCPDP
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	[NotNull]
	HFADLOCOGOG OGDMGCJENIE
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public interface NHJNCCCICOA<T> : OJIPOCLKJMJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	[NotNull]
	new Task<T> MBANOJJCPDP
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	[NotNull]
	new global::PKODKNLJGEP<T> OGDMGCJENIE
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public abstract class KMIBJECAJDO<TTask, T> : global::NHJNCCCICOA<T>, OJIPOCLKJMJ, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class BINOMKCAIFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public global::KMIBJECAJDO<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x1BA2E10", Offset = "0x1BA1610", VA = "0x181BA2E10")]
		public BINOMKCAIFL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static bool JAPNMPFGEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly Task<T> OBCCEHBGMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	protected readonly CancellationTokenSource BEMMKBBNAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private bool MGKCHJEDODG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private SynchronizationContext ELHJBJACOBC;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Task<T> MBANOJJCPDP
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x5611D0", Offset = "0x55F9D0", VA = "0x1805611D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	private Task PLJAJCMBEGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x5611D0", Offset = "0x55F9D0", VA = "0x1805611D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public global::PKODKNLJGEP<T> OGDMGCJENIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x5611C0", Offset = "0x55F9C0", VA = "0x1805611C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	private HFADLOCOGOG OIEBLMBHOOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x1DDC120", Offset = "0x1DDA920", VA = "0x181DDC120", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool PNLEBEDNKDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x5E2990", Offset = "0x5E1190", VA = "0x1805E2990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x3C3BBC0", Offset = "0x3C3A3C0", VA = "0x183C3BBC0")]
	static KMIBJECAJDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x3C3BD30", Offset = "0x3C3A530", VA = "0x183C3BD30")]
	protected KMIBJECAJDO(TTask OBCCEHBGMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x3C3B5E0", Offset = "0x3C39DE0", VA = "0x183C3B5E0", Slot = "1")]
	~KMIBJECAJDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x2F341C0", Offset = "0x2F329C0", VA = "0x182F341C0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x3C3B720", Offset = "0x3C39F20", VA = "0x183C3B720")]
	private void GPGHDCEFFGO(bool OOCNOGHMPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T MDPFJACDHFB(TTask KGIFIDFCBCJ);

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void NMNJJEMHOIO();

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x3C3BA00", Offset = "0x3C3A200", VA = "0x183C3BA00")]
	[CompilerGenerated]
	private void HGHBHJDBBKE(object GLCBACNALCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public interface LFJDKOBOIDP
{
	[Cpp2IlInjected.Token(Token = "0x17000072")]
	float FFMLNHCECOG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event AOAJMJGMINB OEKMEMAMLKM;
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class DDPCHHLAEKF : LFJDKOBOIDP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public readonly struct EOJMAGIDBIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public readonly float BNMHNBKDCFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public readonly float MAAAGDFBOKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		internal readonly bool POFKFEFGGPI;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public float NBHCNACMKMB
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x4E39C60", Offset = "0x4E38460", VA = "0x184E39C60")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x4E39DD0", Offset = "0x4E385D0", VA = "0x184E39DD0")]
		public EOJMAGIDBIP(float ICAAAAPMEKA, float HGCGODPLIAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x4E39C70", Offset = "0x4E38470", VA = "0x184E39C70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class ICIMEALMICF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public DDPCHHLAEKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		public ICIMEALMICF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly int FFHMMNBBJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private int DPIMKKEOPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly LFJDKOBOIDP[] KHIJGJOIIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly AOAJMJGMINB[] KFFAFDBPAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private readonly EOJMAGIDBIP[] MOKJEANINNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private EOJMAGIDBIP OMPJOPDNJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly APJDHANJOIB JNFPKJCJHHP;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public EOJMAGIDBIP PPAAANLDMOC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x2EA8330", Offset = "0x2EA6B30", VA = "0x182EA8330")]
		get
		{
			return default(EOJMAGIDBIP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float FFMLNHCECOG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x4E38660", Offset = "0x4E36E60", VA = "0x184E38660", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event AOAJMJGMINB OEKMEMAMLKM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x4E388E0", Offset = "0x4E370E0", VA = "0x184E388E0", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x4E38DD0", Offset = "0x4E375D0", VA = "0x184E38DD0", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x4E38E90", Offset = "0x4E37690", VA = "0x184E38E90")]
	public DDPCHHLAEKF(int FFHMMNBBJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x4E38860", Offset = "0x4E37060", VA = "0x184E38860")]
	public APJDHANJOIB HBFGOJFELBO(EOJMAGIDBIP DNFKPCJBKGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x4E389A0", Offset = "0x4E371A0", VA = "0x184E389A0")]
	public void KKCEIKJHCGM(LFJDKOBOIDP MLPBIMNLPCC, [Optional] EOJMAGIDBIP GLEJKGJFPAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x4E38810", Offset = "0x4E37010", VA = "0x184E38810")]
	internal int FKAEAAOPLBO(LFJDKOBOIDP ODNNMMNLPLL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x4E38D80", Offset = "0x4E37580", VA = "0x184E38D80")]
	internal EOJMAGIDBIP LEAJHNKDADJ(int CFANIPEBCPB)
	{
		return default(EOJMAGIDBIP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x4E38680", Offset = "0x4E36E80", VA = "0x184E38680", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public delegate void AOAJMJGMINB(float LGJNAJBAEJD);
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal static class CBCNLNCLJGK
{
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	internal const float CELCNAJDJHN = 0.0001f;
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public static class DIENOGMODNO
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	private class OLEDLPOBIAH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private readonly LFJDKOBOIDP ODNNMMNLPLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private readonly AOAJMJGMINB IJOJDDBGAPC;

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x4E3C3B0", Offset = "0x4E3ABB0", VA = "0x184E3C3B0")]
		public OLEDLPOBIAH(LFJDKOBOIDP ODNNMMNLPLL, AOAJMJGMINB IJOJDDBGAPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x4E3C360", Offset = "0x4E3AB60", VA = "0x184E3C360", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x4E39310", Offset = "0x4E37B10", VA = "0x184E39310")]
	internal static bool LAEPFAPAGOI(float OOKPIHBNHGF, float FMMAACMCILJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x3A750B0", Offset = "0x3A738B0", VA = "0x183A750B0")]
	internal static float MLEKNJIJPMM(float OOKPIHBNHGF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x4E39250", Offset = "0x4E37A50", VA = "0x184E39250")]
	public static IDisposable HMEKAIGAIGP(this LFJDKOBOIDP ODNNMMNLPLL, AOAJMJGMINB IJOJDDBGAPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class APJDHANJOIB : LFJDKOBOIDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private float LGJNAJBAEJD;

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float FFMLNHCECOG
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0xE7E3C0", Offset = "0xE7CBC0", VA = "0x180E7E3C0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x4E37270", Offset = "0x4E35A70", VA = "0x184E37270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event AOAJMJGMINB OEKMEMAMLKM
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x4E37340", Offset = "0x4E35B40", VA = "0x184E37340", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x4E373E0", Offset = "0x4E35BE0", VA = "0x184E373E0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
	public APJDHANJOIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class HEKKCAHBOND : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public readonly Type NCKNGJHPBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public readonly string OOKJNEDHFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public readonly bool CKJBOEPDPDC;

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x4E3B420", Offset = "0x4E39C20", VA = "0x184E3B420")]
	public HEKKCAHBOND(Type NIHLIJBPIID, string BKCKKNLMBAN, bool GCPEPIFDAIL = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class FOICAHGCJLM : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x4E3AD80", Offset = "0x4E39580", VA = "0x184E3AD80")]
	public FOICAHGCJLM(string LMJMILCCPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x4E3ADF0", Offset = "0x4E395F0", VA = "0x184E3ADF0")]
	public FOICAHGCJLM(string LMJMILCCPPB, Exception HOKOLGMONHA)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x561ED0", Offset = "0x5606D0", VA = "0x180561ED0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x585710", Offset = "0x583F10", VA = "0x180585710")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public T this[int APEAIJJLBLJ, int BAKKDPDJGDH]
		{
			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x1B9ED90", Offset = "0x1B9D590", VA = "0x181B9ED90")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x1B9EE30", Offset = "0x1B9D630", VA = "0x181B9EE30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x1B9ED00", Offset = "0x1B9D500", VA = "0x181B9ED00")]
		public Array2D(uint GPPALIDPAOJ, uint HBKDNCCDNCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x1B9EC80", Offset = "0x1B9D480", VA = "0x181B9EC80")]
		public void BNEMLHGGHNK()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x4E37480", Offset = "0x4E35C80", VA = "0x184E37480")]
		public Array2DVector3(uint GPPALIDPAOJ, uint HBKDNCCDNCO)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
internal static class AGMHEPCFBOK
{
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public const int AIODBANILEK = -1;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public const int BJPGFFEEGCP = 0;
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[DefaultMember("Item")]
public class EIIKLAMBHDF<THandle, TValue> : IDisposable where THandle : struct, ONPIFBCILPJ where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly List<THandle> CGBADKJGLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly List<TValue> FHAIKLIGKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly Func<TValue> CBEBOCOKCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private readonly Action<TValue> JFJOMDFMKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private int IBNJJIMMBMP;

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public TValue PDOIHJPOGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x33684A0", Offset = "0x3366CA0", VA = "0x1833684A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x3FEB470", Offset = "0x3FE9C70", VA = "0x183FEB470")]
	public EIIKLAMBHDF(Action<TValue> JFJOMDFMKFD, [Optional] Func<TValue> CBEBOCOKCCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x3FEAB10", Offset = "0x3FE9310", VA = "0x183FEAB10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x3FEAF50", Offset = "0x3FE9750", VA = "0x183FEAF50")]
	public THandle JHOEBDGEJAE()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x3FEADA0", Offset = "0x3FE95A0", VA = "0x183FEADA0")]
	public THandle IONNJMGFDPB(TValue MFBIHMKFNKA)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x3FEAFF0", Offset = "0x3FE97F0", VA = "0x183FEAFF0")]
	public bool JPAMCOIJOBL(THandle FJNPOOOECPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x3FEB320", Offset = "0x3FE9B20", VA = "0x183FEB320")]
	public bool MOKFFIOFCLL(THandle FJNPOOOECPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x3FEB160", Offset = "0x3FE9960", VA = "0x183FEB160")]
	public bool KKACOOPIDFN(THandle FJNPOOOECPJ, out TValue MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x3FEABD0", Offset = "0x3FE93D0", VA = "0x183FEABD0")]
	public TValue FLCFGOMKECP(THandle FJNPOOOECPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x3FEAC20", Offset = "0x3FE9420", VA = "0x183FEAC20")]
	public bool HJIKHAFGDCE(THandle FJNPOOOECPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x3FEB440", Offset = "0x3FE9C40", VA = "0x183FEB440")]
	private THandle OLPLOCJFGDA(int CFANIPEBCPB)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x3FEA8E0", Offset = "0x3FE90E0", VA = "0x183FEA8E0")]
	private TValue AGCFOHCOPCO(int CFANIPEBCPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x3FEB400", Offset = "0x3FE9C00", VA = "0x183FEB400")]
	private void MPFEHCJBFEN(int CFANIPEBCPB, in THandle FJNPOOOECPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x3FEAB90", Offset = "0x3FE9390", VA = "0x183FEAB90")]
	private void FINDIOADIDM(int CFANIPEBCPB, in TValue MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x3FEA990", Offset = "0x3FE9190", VA = "0x183FEA990")]
	private THandle BPHELOCGMOE()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x3FEB0A0", Offset = "0x3FE98A0", VA = "0x183FEB0A0")]
	private void KGOOGDAJAII(THandle FJNPOOOECPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x3FEA8D0", Offset = "0x3FE90D0", VA = "0x183FEA8D0")]
	private int ABHJLFLOGIL(int CEHIIEKHBCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x3FEAAA0", Offset = "0x3FE92A0", VA = "0x183FEAAA0")]
	private bool CGAFMEDMOHO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x5B29A0", Offset = "0x5B11A0", VA = "0x1805B29A0")]
	private void HMBOALFDFBB(THandle FJNPOOOECPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x3FEA910", Offset = "0x3FE9110", VA = "0x183FEA910")]
	private bool AHNNHLHJIHI(out THandle FJNPOOOECPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x3FEACD0", Offset = "0x3FE94D0", VA = "0x183FEACD0")]
	private bool IMCGOJLNCLE(out THandle FJNPOOOECPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x3FEAAB0", Offset = "0x3FE92B0", VA = "0x183FEAAB0")]
	private void DFIKHFEONMP(THandle FJNPOOOECPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x3FEB200", Offset = "0x3FE9A00", VA = "0x183FEB200")]
	private void MDBOMMDFBPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public interface ONPIFBCILPJ
{
	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	int MPBCIHFGEMC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	int JJMKFDIMJCD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public interface OINIFKJKGPO<T> : ONPIFBCILPJ, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public static class ELIEKGJGIIG
{
	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x23EE700", Offset = "0x23ECF00", VA = "0x1823EE700")]
	public static bool POFKFEFGGPI<T>(this T FJNPOOOECPJ) where T : struct, ONPIFBCILPJ
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class BFCLAGKEKNI
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private enum NAFIJBDIGHD : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private int MNKLNMHPAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private bool OOAPLMMOFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private NAFIJBDIGHD CJJBKHDOFPA;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public bool HAOGDNGPDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x4E37520", Offset = "0x4E35D20", VA = "0x184E37520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool BAKMAHIBJDK
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x4E374E0", Offset = "0x4E35CE0", VA = "0x184E374E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x4E382C0", Offset = "0x4E36AC0", VA = "0x184E382C0")]
	public BFCLAGKEKNI(bool OOAPLMMOFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x4E37970", Offset = "0x4E36170", VA = "0x184E37970")]
	public void JHACFFHGIOA(object OMILIKJDDEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x4E37F00", Offset = "0x4E36700", VA = "0x184E37F00")]
	public void KHBLAPKOPBE(int MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x4E38190", Offset = "0x4E36990", VA = "0x184E38190")]
	public void PACMCKKPKBP(uint KDMOIPMIEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x4E37500", Offset = "0x4E35D00", VA = "0x184E37500")]
	public void CEHJCFGKCLI(bool OHKLJBLFOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x4E37930", Offset = "0x4E36130", VA = "0x184E37930")]
	public void HOLOGFAPIBF(long LACLNGNLGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x4E378F0", Offset = "0x4E360F0", VA = "0x184E378F0")]
	public void EICEODGDMMM(ulong IGECKMJOJHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x4E38120", Offset = "0x4E36920", VA = "0x184E38120")]
	public void LNPEPBGGLOJ(string ADPHNNDAMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x4E37FB0", Offset = "0x4E367B0", VA = "0x184E37FB0")]
	public void LCOCKNIDJNA(Enum OADAOAPKMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x4E381A0", Offset = "0x4E369A0", VA = "0x184E381A0")]
	public void POLJJNIICFJ(IList DPOGJPHIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x1D25440", Offset = "0x1D23C40", VA = "0x181D25440")]
	public void MANIAMAADGB<T, U>(Dictionary<T, U> CDJNOPFDFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x4E37530", Offset = "0x4E35D30", VA = "0x184E37530")]
	private void DMAHKCKJFIJ(IDictionary CDJNOPFDFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x4E37E90", Offset = "0x4E36690", VA = "0x184E37E90")]
	public int JNHBJDMKHLK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x4E38040", Offset = "0x4E36840", VA = "0x184E38040")]
	public short LEMKNBFEJAH()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x4E374F0", Offset = "0x4E35CF0", VA = "0x184E374F0")]
	public void BNEMLHGGHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x4E380B0", Offset = "0x4E368B0", VA = "0x184E380B0")]
	private void LHCIGOIMIJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public abstract class KFFLHNDGAEO<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	internal class ODMEBLIFMDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public TNode EBOHMGAPLIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public TNode HNINKJAJDDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public NAEJIGJGMFF OHIDPFBACFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public List<NAEJIGJGMFF> OKNIBCJGGNN;

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x1BA2E10", Offset = "0x1BA1610", VA = "0x181BA2E10")]
		public ODMEBLIFMDD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	internal struct NAEJIGJGMFF : IComparable<NAEJIGJGMFF>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public int PEMFPBGDFNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public TClaimant NNJLMOPKJFF;

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x569CF0", Offset = "0x5684F0", VA = "0x180569CF0")]
		public NAEJIGJGMFF(int PEMFPBGDFNJ, TClaimant NNJLMOPKJFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x29626E0", Offset = "0x2960EE0", VA = "0x1829626E0")]
		public bool OBONPAIAMCL(in NAEJIGJGMFF GKBKHIIEFAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x29626D0", Offset = "0x2960ED0", VA = "0x1829626D0")]
		public bool ELMHODMCJMO(in NAEJIGJGMFF GKBKHIIEFAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x29626C0", Offset = "0x2960EC0", VA = "0x1829626C0", Slot = "4")]
		public int CompareTo(NAEJIGJGMFF GKBKHIIEFAH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x2962740", Offset = "0x2960F40", VA = "0x182962740", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public enum OLJHOPPODEA
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class EIEABMANNLF : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public global::KFFLHNDGAEO<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x5611C0", Offset = "0x55F9C0", VA = "0x1805611C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x5611C0", Offset = "0x55F9C0", VA = "0x1805611C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x1DA0F50", Offset = "0x1D9F750", VA = "0x181DA0F50")]
		[DebuggerHidden]
		public EIEABMANNLF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x561E80", Offset = "0x560680", VA = "0x180561E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x29540E0", Offset = "0x29528E0", VA = "0x1829540E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x29542A0", Offset = "0x2952AA0", VA = "0x1829542A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x29541C0", Offset = "0x29529C0", VA = "0x1829541C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x1BB0630", Offset = "0x1BAEE30", VA = "0x181BB0630", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static readonly global::KNLFFMDGOJH<ODMEBLIFMDD> FNPLPBPNNKI;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly global::KNLFFMDGOJH<List<NAEJIGJGMFF>> DBFKNIKMIEL;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private static int NINJJDNBCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	internal readonly Dictionary<TClaimant, TNode> BJAKOOLNPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	internal readonly Dictionary<TNode, ODMEBLIFMDD> PINCLKLHCOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private OLJHOPPODEA MLBEKKOCNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private bool DOGKKFFGKFM;

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode COKOIMAHPPF(TNode HCLJNIDPDDK);

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void IOOMPBKDKCA(TNode HCLJNIDPDDK, TClaimant LNMBBLAKCIJ, TClaimant CLCGLKCKEBM);

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x2961B80", Offset = "0x2960380", VA = "0x182961B80")]
	public KFFLHNDGAEO(OLJHOPPODEA MLBEKKOCNDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x2960B00", Offset = "0x295F300", VA = "0x182960B00")]
	public void EDPILGFGMNN(TNode HCLJNIDPDDK, TNode NMIEICEKHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x29613E0", Offset = "0x295FBE0", VA = "0x1829613E0")]
	public void HNIPJPFKIAI(TClaimant NNJLMOPKJFF, TNode MGGOIIKDFID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x29608A0", Offset = "0x295F0A0", VA = "0x1829608A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x2961180", Offset = "0x295F980", VA = "0x182961180")]
	private void HFLLEIPMLGK(TClaimant NNJLMOPKJFF, TNode PDOCFPMNNEP, TNode MGGOIIKDFID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x2961750", Offset = "0x295FF50", VA = "0x182961750")]
	private int IKFDBCCEMGC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x2960460", Offset = "0x295EC60", VA = "0x182960460")]
	private void AFIMLPECDDG(TClaimant NNJLMOPKJFF, TNode IEIMPPPOHFM, TNode JJBLMEHAEFO, int ADKPJALDKLA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x2961890", Offset = "0x2960090", VA = "0x182961890")]
	private void KJMODNKNMMA(NAEJIGJGMFF COFIPGENMLP, ODMEBLIFMDD LKNKLDCMLBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x29614E0", Offset = "0x295FCE0", VA = "0x1829614E0")]
	private void IDIJIPBBGAE(TClaimant NNJLMOPKJFF, TNode IEIMPPPOHFM, TNode JJBLMEHAEFO, int ADKPJALDKLA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x2961920", Offset = "0x2960120", VA = "0x182961920")]
	private void NBDHFODCAFK(NAEJIGJGMFF COFIPGENMLP, TNode HCLJNIDPDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x2961080", Offset = "0x295F880", VA = "0x182961080")]
	private void GGJFPFENGGK(NAEJIGJGMFF COFIPGENMLP, ODMEBLIFMDD LKNKLDCMLBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x2960320", Offset = "0x295EB20", VA = "0x182960320")]
	private void AADJKDMNBLI(ODMEBLIFMDD LKNKLDCMLBJ, bool MCJMIFGIFHH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x2960C40", Offset = "0x295F440", VA = "0x182960C40")]
	private void FGNNMMENJDI(ODMEBLIFMDD LKNKLDCMLBJ, TNode NMIEICEKHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x29617C0", Offset = "0x295FFC0", VA = "0x1829617C0")]
	[IteratorStateMachine(typeof(global::KFFLHNDGAEO<, >.EIEABMANNLF))]
	private IEnumerable<TNode> JIDFFNCGFEL(TNode IEIMPPPOHFM, TNode JJBLMEHAEFO, bool HMLOFKGNHCH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x2960B80", Offset = "0x295F380", VA = "0x182960B80")]
	private ODMEBLIFMDD EIDMBFEMFFL(TNode HCLJNIDPDDK, TNode HNINKJAJDDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x2960710", Offset = "0x295EF10", VA = "0x182960710")]
	private ODMEBLIFMDD CIPNFIHKJCL(TNode HCLJNIDPDDK, TNode HNINKJAJDDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x2961220", Offset = "0x295FA20", VA = "0x182961220")]
	private void HJHAIHAMFJD(ODMEBLIFMDD LKNKLDCMLBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public class LOKMBFDFBBI<T> : IEnumerable<global::LOKMBFDFBBI<T>.CICAEPGOJOG>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public struct CICAEPGOJOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public T MFBIHMKFNKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public int CFANIPEBCPB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public class EFJMKBHEKNO : IEnumerator<CICAEPGOJOG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private global::LOKMBFDFBBI<T> EHEAKAJJFIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int CFANIPEBCPB;

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x28ACEE0", Offset = "0x28AB6E0", VA = "0x1828ACEE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public CICAEPGOJOG LFOABFNFCIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x3913960", Offset = "0x3912160", VA = "0x183913960", Slot = "4")]
			get
			{
				return default(CICAEPGOJOG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x81B6E0", Offset = "0x819EE0", VA = "0x18081B6E0")]
		public EFJMKBHEKNO(global::LOKMBFDFBBI<T> EHEAKAJJFIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x39138D0", Offset = "0x39120D0", VA = "0x1839138D0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x79E2E0", Offset = "0x79CAE0", VA = "0x18079E2E0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x83D0C0", Offset = "0x83B8C0", VA = "0x18083D0C0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private struct NHBDEPKGADE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public bool FLIEOIPAEKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public T MFBIHMKFNKA;
	}

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private const int HMGIAHPBGIL = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private Dictionary<T, int> BEPFPHIFHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private NHBDEPKGADE[] IDCBCHHALAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private int CBGPPAKBKFL;

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public int GJEPFFENNCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x1D98F00", Offset = "0x1D97700", VA = "0x181D98F00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x391DF00", Offset = "0x391C700", VA = "0x18391DF00")]
	public static global::LOKMBFDFBBI<T> MONAKNLGJEJ(CICAEPGOJOG[] KMPJJNLEEIE, bool NMNDMGJDNAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x391E360", Offset = "0x391CB60", VA = "0x18391E360")]
	public LOKMBFDFBBI(int FFHMMNBBJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x2F6C660", Offset = "0x2F6AE60", VA = "0x182F6C660")]
	public bool MOKBLDMAJLJ(T MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x391DCD0", Offset = "0x391C4D0", VA = "0x18391DCD0")]
	public bool DBABMHEGJBL(int CFANIPEBCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x391DAB0", Offset = "0x391C2B0", VA = "0x18391DAB0")]
	public bool CDHEDEIGJMA(Func<T, bool> OKKBNEOGAHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x391DD30", Offset = "0x391C530", VA = "0x18391DD30")]
	public int HCPCGNLKGEO(T MFBIHMKFNKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x391D750", Offset = "0x391BF50", VA = "0x18391D750")]
	public T AGCFOHCOPCO(int CFANIPEBCPB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x391DA60", Offset = "0x391C260", VA = "0x18391DA60")]
	public void BNEMLHGGHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x391D810", Offset = "0x391C010", VA = "0x18391D810")]
	public bool BGBJIKPDFEG(T MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x391D830", Offset = "0x391C030", VA = "0x18391D830")]
	public bool BGBJIKPDFEG(T MFBIHMKFNKA, int CFANIPEBCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x391DE30", Offset = "0x391C630", VA = "0x18391DE30")]
	public bool JPAMCOIJOBL(T MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x391D7C0", Offset = "0x391BFC0", VA = "0x18391D7C0")]
	public bool AKGGEDBEDOG(int CFANIPEBCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x391DD80", Offset = "0x391C580", VA = "0x18391DD80")]
	private void IGOCCBLCPFH(int CFANIPEBCPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x391DB60", Offset = "0x391C360", VA = "0x18391DB60")]
	public CICAEPGOJOG[] CINJAKHIFFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x391DEB0", Offset = "0x391C6B0", VA = "0x18391DEB0")]
	private int MMABGFKMFNF(int HKONJCKHNHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x391E2E0", Offset = "0x391CAE0", VA = "0x18391E2E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x391E2E0", Offset = "0x391CAE0", VA = "0x18391E2E0", Slot = "4")]
	private IEnumerator<CICAEPGOJOG> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public class KNLFFMDGOJH<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private readonly Stack<T> PAJHPAKOEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private readonly List<T> ALDNJFCDGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private readonly int JKGIDKMPKOE;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int AJGKJILBEFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x1B9EED0", Offset = "0x1B9D6D0", VA = "0x181B9EED0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int OEJAOIIIMCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x1B9F090", Offset = "0x1B9D890", VA = "0x181B9F090")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x3C3C180", Offset = "0x3C3A980", VA = "0x183C3C180")]
	public static global::KNLFFMDGOJH<T> ACDGHIPBBPJ(int FFHMMNBBJIL = 0, int JKGIDKMPKOE = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x3C3C6A0", Offset = "0x3C3AEA0", VA = "0x183C3C6A0")]
	public static global::KNLFFMDGOJH<T> JFBLJFEKLOJ(int FFHMMNBBJIL = 0, int JKGIDKMPKOE = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x3C3CBA0", Offset = "0x3C3B3A0", VA = "0x183C3CBA0")]
	public KNLFFMDGOJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x3C3CA10", Offset = "0x3C3B210", VA = "0x183C3CA10")]
	public KNLFFMDGOJH(int FFHMMNBBJIL, int JKGIDKMPKOE = int.MaxValue, bool EADHAADLFIN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x3C3C770", Offset = "0x3C3AF70", VA = "0x183C3C770")]
	public T KBMCDAMBKBM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x3C3C950", Offset = "0x3C3B150", VA = "0x183C3C950")]
	public void PFICBFAAIAB(T MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x3C3C540", Offset = "0x3C3AD40", VA = "0x183C3C540")]
	private void FKMMDOHKEKD(T MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x3C3C360", Offset = "0x3C3AB60", VA = "0x183C3C360")]
	private void ENNHGPLGIMA(T MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x3C3C600", Offset = "0x3C3AE00", VA = "0x183C3C600")]
	[Conditional("DEBUG_BUILD")]
	private void JBMJHBEJEBA(T HLPIADCDEFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x3C3C8A0", Offset = "0x3C3B0A0", VA = "0x183C3C8A0")]
	[Conditional("DEBUG_BUILD")]
	private void LKPPBFEOIPO(T HLPIADCDEFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x3C3C250", Offset = "0x3C3AA50", VA = "0x183C3C250", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x3C3C380", Offset = "0x3C3AB80", VA = "0x183C3C380")]
	private void FEHJDDJPFMG(IEnumerable<T> FHAIKLIGKKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class HNONIKHNIAE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private Dictionary<int, T> OBBCJBEKBGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private T HCCMBKBGAND;

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public virtual T MAOBAKDEOJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x5611C0", Offset = "0x55F9C0", VA = "0x1805611C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x5614A0", Offset = "0x55FCA0", VA = "0x1805614A0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool IKOBEMDIJIP
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x367E990", Offset = "0x367D190", VA = "0x18367E990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x367E9D0", Offset = "0x367D1D0", VA = "0x18367E9D0")]
	public bool OKEGCOKGHHP(T MFBIHMKFNKA, int PEMFPBGDFNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x367E430", Offset = "0x367CC30", VA = "0x18367E430")]
	public bool EKLFHNDDCHK(int PEMFPBGDFNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x367E490", Offset = "0x367CC90", VA = "0x18367E490")]
	public T MHAMMMHDKPG(int IBDGABPGKBF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x367E230", Offset = "0x367CA30", VA = "0x18367E230")]
	public void BNEMLHGGHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x367E290", Offset = "0x367CA90", VA = "0x18367E290")]
	private bool DCDJDNGGPNO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x367E960", Offset = "0x367D160", VA = "0x18367E960")]
	public bool OADACMKKJNG(int PEMFPBGDFNJ, out T MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x3575200", Offset = "0x3573A00", VA = "0x183575200")]
	public HNONIKHNIAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public class BBOLAJFGAKA<T>
{
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	protected struct OALIDBPBKPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public T CIFMBHMEFPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public int FCAGPCJEOGP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	protected readonly List<OALIDBPBKPI> OGFGMOHGGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private T ILGDOGHOLPL;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public int GJEPFFENNCK
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x1B9F310", Offset = "0x1B9DB10", VA = "0x181B9F310")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x4081EB0", Offset = "0x40806B0", VA = "0x184081EB0")]
	public bool CDHEDEIGJMA(T MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x4082380", Offset = "0x4080B80", VA = "0x184082380")]
	public void IONNJMGFDPB(T MFBIHMKFNKA, int PEMFPBGDFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x4082420", Offset = "0x4080C20", VA = "0x184082420")]
	public bool JPAMCOIJOBL(T MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x4081E50", Offset = "0x4080650", VA = "0x184081E50")]
	public void BNEMLHGGHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x4082540", Offset = "0x4080D40", VA = "0x184082540")]
	public T LJGMCDKALNL()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x4082310", Offset = "0x4080B10", VA = "0x184082310")]
	public T HIHJJMBDNIA()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x4082100", Offset = "0x4080900", VA = "0x184082100")]
	private void DIPMBAGDIKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x40825D0", Offset = "0x4080DD0", VA = "0x1840825D0")]
	public BBOLAJFGAKA()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		[SerializeField]
		[PAOKLKEFIEK(ELHMLMEGENM.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x4E3CFC0", Offset = "0x4E3B7C0", VA = "0x184E3CFC0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x4E3D490", Offset = "0x4E3BC90", VA = "0x184E3D490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x4E3D2B0", Offset = "0x4E3BAB0", VA = "0x184E3D2B0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x4E3D630", Offset = "0x4E3BE30", VA = "0x184E3D630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x4E3CE80", Offset = "0x4E3B680", VA = "0x184E3CE80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x4E3D350", Offset = "0x4E3BB50", VA = "0x184E3D350")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x4E3D170", Offset = "0x4E3B970", VA = "0x184E3D170")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x4E3CDE0", Offset = "0x4E3B5E0", VA = "0x184E3CDE0")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public interface FOLLCMPNIHI
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public abstract class ResourcePrefabReference<T> : FOLLCMPNIHI where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x1BB3650", Offset = "0x1BB1E50", VA = "0x181BB3650", Slot = "4")]
		public virtual T BNPMELKEHHE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x1BA2E10", Offset = "0x1BA1610", VA = "0x181BA2E10")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public class FLHOGBKOLPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private readonly Dictionary<byte, DLGPNEBEOHB> JKCCECLKNBE;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public DLGPNEBEOHB IEAJJMBGGDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x5611D0", Offset = "0x55F9D0", VA = "0x1805611D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x561490", Offset = "0x55FC90", VA = "0x180561490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public Vector2 BKEHFPINNDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x1006F30", Offset = "0x1005730", VA = "0x181006F30")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x2F6B920", Offset = "0x2F6A120", VA = "0x182F6B920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public Vector2 NDELDOJOOJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x14E9160", Offset = "0x14E7960", VA = "0x1814E9160")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x14E91F0", Offset = "0x14E79F0", VA = "0x1814E91F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public Vector2 CKBOCLCBPAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x4E3A730", Offset = "0x4E38F30", VA = "0x184E3A730")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x4E3A750", Offset = "0x4E38F50", VA = "0x184E3A750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public int IOHIHHEOEBO
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x58C7E0", Offset = "0x58AFE0", VA = "0x18058C7E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x5B29A0", Offset = "0x5B11A0", VA = "0x1805B29A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x4E3A860", Offset = "0x4E39060", VA = "0x184E3A860")]
	public FLHOGBKOLPD(Bounds CNHJLDCNPLF, Vector2[] EMLHFDKIBFL, int IHCFPBKGNLM, byte HKONJCKHNHA, float KGGJGAKHLBP = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x4E3A060", Offset = "0x4E38860", VA = "0x184E3A060")]
	public DLGPNEBEOHB BNGOHIAFBDF(byte CFANIPEBCPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x4E3A770", Offset = "0x4E38F70", VA = "0x184E3A770")]
	public void OFFHMGDFBCD(Vector3 HKHJMHKLNGP, float LBMJIPDOPHA, float BPNPGJLDNFO, ref List<byte> LNBLEMLJALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x4E3A0C0", Offset = "0x4E388C0", VA = "0x184E3A0C0")]
	public void IOHILFNMPBD(DLGPNEBEOHB.JNHHCFABGJO GFMFEAGKBFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x4E3A0E0", Offset = "0x4E388E0", VA = "0x184E3A0E0")]
	private DLGPNEBEOHB LADEPALGAIN(byte CFANIPEBCPB, DLGPNEBEOHB.LILHJBIOFCO AJHJPMNOCKD, DLGPNEBEOHB HNINKJAJDDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x4E3A210", Offset = "0x4E38A10", VA = "0x184E3A210")]
	private void LKLIBJFDFNF(DLGPNEBEOHB HNINKJAJDDL, Vector2[] EMLHFDKIBFL, int JJCOGDKKHPM, int BJNPMBDLGJL, int NMJPGMCAOHB, int NDJPDEIAICB, float KGGJGAKHLBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public class DLGPNEBEOHB
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public enum LILHJBIOFCO
	{
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public enum JNHHCFABGJO
	{
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public byte MLEJCNHKNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public Vector3 BCBLMKFHAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public Vector3 NBHCNACMKMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public Vector3 BJEGEAICIJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public Vector3 NDBKNGPDPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public LILHJBIOFCO FLAJFDCHFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public DLGPNEBEOHB PAIJNEEMEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public List<DLGPNEBEOHB> JJDIIMCKGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public bool IHEMKFENCDC;

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x4E397C0", Offset = "0x4E37FC0", VA = "0x184E397C0")]
	public DLGPNEBEOHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x4E39760", Offset = "0x4E37F60", VA = "0x184E39760")]
	public DLGPNEBEOHB(byte DDEJHPOCOHL, LILHJBIOFCO AJHJPMNOCKD, DLGPNEBEOHB HNINKJAJDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x4E393D0", Offset = "0x4E37BD0", VA = "0x184E393D0")]
	public void GIDFGAEEKPL(DLGPNEBEOHB PPMKNBDKPJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x561E80", Offset = "0x560680", VA = "0x180561E80")]
	public void IOHILFNMPBD(int IDGDPHLODEH, JNHHCFABGJO GFMFEAGKBFB, int BNLGPNOKFCD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x4E394D0", Offset = "0x4E37CD0", VA = "0x184E394D0")]
	public void OFFHMGDFBCD(List<byte> LNBLEMLJALE, Vector3 HKHJMHKLNGP, float LBMJIPDOPHA, float BPNPGJLDNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x4E39470", Offset = "0x4E37C70", VA = "0x184E39470")]
	public bool NAIFPHOHEMD(Vector3 DICGPBMCFJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x4E39390", Offset = "0x4E37B90", VA = "0x184E39390")]
	public bool FIBMPEPNGJB(Vector3 DICGPBMCFJD, float NEGAIAIJGIP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public class IHLLLFEBCML<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private readonly Dictionary<T, object> KFEPAACFODC;

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x1D95D50", Offset = "0x1D94550", VA = "0x181D95D50")]
	public bool BCHBCPBDNOD(T AJHCCDOFFFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x1D95DE0", Offset = "0x1D945E0", VA = "0x181D95DE0")]
	public bool BCHBCPBDNOD(T AJHCCDOFFFG, object JGMHCJIBOFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x1D95D80", Offset = "0x1D94580", VA = "0x181D95D80")]
	public bool BCHBCPBDNOD(T AJHCCDOFFFG, object JGMHCJIBOFB, out object MIBKBCGIIBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x1D95C80", Offset = "0x1D94480", VA = "0x181D95C80")]
	public bool AAJOBGDBHHB(T AJHCCDOFFFG, object JGMHCJIBOFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x1D95E20", Offset = "0x1D94620", VA = "0x181D95E20")]
	public bool FDPOLKLFLIC(T AJHCCDOFFFG, object JGMHCJIBOFB, out object MIBKBCGIIBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x1D95CC0", Offset = "0x1D944C0", VA = "0x181D95CC0")]
	public bool AAJOBGDBHHB(T AJHCCDOFFFG, object JGMHCJIBOFB, out object MIBKBCGIIBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x1D95E60", Offset = "0x1D94660", VA = "0x181D95E60")]
	public void ICKJDPHGBLD(T AJHCCDOFFFG, object JGMHCJIBOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x1D95E90", Offset = "0x1D94690", VA = "0x181D95E90")]
	public void MIIAJJKDCIG(T AJHCCDOFFFG, object JGMHCJIBOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x1D95F30", Offset = "0x1D94730", VA = "0x181D95F30")]
	public IHLLLFEBCML()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		public struct HLMNOOAOIJP<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			private readonly List<Component> DPOGJPHIACD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			private readonly bool MJLKOPMDDPB;

			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x762600", Offset = "0x760E00", VA = "0x180762600")]
			public HLMNOOAOIJP(List<Component> DPOGJPHIACD, bool MJLKOPMDDPB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x1BA7E90", Offset = "0x1BA6690", VA = "0x181BA7E90")]
			public GEIPCAAEIPN<T> EGDKACNFMBB()
			{
				return default(GEIPCAAEIPN<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x1BA7F00", Offset = "0x1BA6700", VA = "0x181BA7F00", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0x1BA7F00", Offset = "0x1BA6700", VA = "0x181BA7F00", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A9")]
		public struct GEIPCAAEIPN<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			private readonly List<Component> DPOGJPHIACD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			private readonly bool MJLKOPMDDPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400019C")]
			private int CFANIPEBCPB;

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public T LFOABFNFCIP
			{
				[Cpp2IlInjected.Token(Token = "0x6000397")]
				[Cpp2IlInjected.Address(RVA = "0x1BA6A00", Offset = "0x1BA5200", VA = "0x181BA6A00", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000398")]
				[Cpp2IlInjected.Address(RVA = "0x1BA6990", Offset = "0x1BA5190", VA = "0x181BA6990", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0x1BA69D0", Offset = "0x1BA51D0", VA = "0x181BA69D0")]
			public GEIPCAAEIPN(List<Component> DPOGJPHIACD, bool MJLKOPMDDPB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x1BA68C0", Offset = "0x1BA50C0", VA = "0x181BA68C0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x1BA68D0", Offset = "0x1BA50D0", VA = "0x181BA68D0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x1BA6980", Offset = "0x1BA5180", VA = "0x181BA6980", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(RVA = "0x4E3F2F0", Offset = "0x4E3DAF0", VA = "0x184E3F2F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x4E3F2B0", Offset = "0x4E3DAB0", VA = "0x184E3F2B0")]
		public ToolHierarchyCache(GameObject MILFJDDFCJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x4E3EB20", Offset = "0x4E3D320", VA = "0x184E3EB20")]
		private void EMFGCIHFDBD(GameObject MILFJDDFCJD, bool GFIOFEMPBAH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x4E3EC40", Offset = "0x4E3D440", VA = "0x184E3EC40")]
		public static void EMFGCIHFDBD(GameObject MILFJDDFCJD, ref ToolHierarchyCache MFCNIHPOHLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x4E3EDC0", Offset = "0x4E3D5C0", VA = "0x184E3EDC0")]
		public void KMHMPGAMKKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x4E3F200", Offset = "0x4E3DA00", VA = "0x184E3F200")]
		public void NMALNLEBFCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x1BD92E0", Offset = "0x1BD7AE0", VA = "0x181BD92E0")]
		public void OKKCAHOECKG<T>(Action<T> DJBODGKMGGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x4E3EE90", Offset = "0x4E3D690", VA = "0x184E3EE90")]
		public Component LBILJMFOKPD(Type DMBEFJIHONB, bool MJLKOPMDDPB = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x1CB02A0", Offset = "0x1CAEAA0", VA = "0x181CB02A0")]
		public T LBILJMFOKPD<T>(bool MJLKOPMDDPB = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x4E3EA90", Offset = "0x4E3D290", VA = "0x184E3EA90")]
		public HLMNOOAOIJP<Component> EIFAKEMCADD(Type DMBEFJIHONB, bool MJLKOPMDDPB = false)
		{
			return default(HLMNOOAOIJP<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x2801240", Offset = "0x27FFA40", VA = "0x182801240")]
		public HLMNOOAOIJP<T> EIFAKEMCADD<T>(bool MJLKOPMDDPB = false) where T : class
		{
			return default(HLMNOOAOIJP<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x4E3EF50", Offset = "0x4E3D750", VA = "0x184E3EF50")]
		public List<Component> LDIJDDOFNBK(Type DMBEFJIHONB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x4E3ECD0", Offset = "0x4E3D4D0", VA = "0x184E3ECD0", Slot = "4")]
		public bool Equals(ToolHierarchyCache FMMKCBAOFKA, ToolHierarchyCache HPNMBFKMIJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x4E3ED50", Offset = "0x4E3D550", VA = "0x184E3ED50", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache OMILIKJDDEJ)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public class FDGDJOILLNJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private int FFHMMNBBJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private int ABLOAKJOFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private List<T> POAAANHIJLJ;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public int GJEPFFENNCK
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x1B9EED0", Offset = "0x1B9D6D0", VA = "0x181B9EED0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public T BODDCIMCOJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x3EDEF10", Offset = "0x3EDD710", VA = "0x183EDEF10")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public T BMOFFNMMELM
	{
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x3EDECA0", Offset = "0x3EDD4A0", VA = "0x183EDECA0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public T DEIGKLCIGPA
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x3EDF190", Offset = "0x3EDD990", VA = "0x183EDF190")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x3EDF1E0", Offset = "0x3EDD9E0", VA = "0x183EDF1E0")]
	public FDGDJOILLNJ(int FFHMMNBBJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x3EDED60", Offset = "0x3EDD560", VA = "0x183EDED60")]
	public void IONNJMGFDPB(T ACKELKANIKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x3EDEC60", Offset = "0x3EDD460", VA = "0x183EDEC60")]
	public void BNEMLHGGHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x3EDF030", Offset = "0x3EDD830", VA = "0x183EDF030")]
	public void MLPGNGJGJBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x3EDF0D0", Offset = "0x3EDD8D0", VA = "0x183EDF0D0")]
	public void PFKGGJODGJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x3EDED50", Offset = "0x3EDD550", VA = "0x183EDED50")]
	public void IHPGFDANMMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public class GEFCLDLCIKC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private bool MIAACIGJENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private Action DJBODGKMGGL;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public static GEFCLDLCIKC OIEOMEANLID
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x4E3AF50", Offset = "0x4E39750", VA = "0x184E3AF50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool OPGCJKPKIOK
	{
		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x58C7B0", Offset = "0x58AFB0", VA = "0x18058C7B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x8050A0", Offset = "0x8038A0", VA = "0x1808050A0")]
	public GEFCLDLCIKC(Action DJBODGKMGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x4E3AF30", Offset = "0x4E39730", VA = "0x184E3AF30")]
	public void GLIJLNLELKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x4E3AF30", Offset = "0x4E39730", VA = "0x184E3AF30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public static class LJFEHNFEACP
{
	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x561E80", Offset = "0x560680", VA = "0x180561E80")]
	public static void MADBMDMFNLL(PNCONINMAHM DLHKADEDHJJ, string FKNOJLALCPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public class HFLGMHECNDI<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	private struct KIMHDECCLKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public int FCAGPCJEOGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public T CIFMBHMEFPE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly Dictionary<object, KIMHDECCLKC> OBBCJBEKBGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private T HCCMBKBGAND;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public virtual T MAOBAKDEOJE
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x1006F30", Offset = "0x1005730", VA = "0x181006F30", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x2F6B920", Offset = "0x2F6A120", VA = "0x182F6B920", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool IKOBEMDIJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x3574A10", Offset = "0x3573210", VA = "0x183574A10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public object BMFLNDCOGIF
	{
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x563DF0", Offset = "0x5625F0", VA = "0x180563DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x58BD70", Offset = "0x58A570", VA = "0x18058BD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x3574F40", Offset = "0x3573740", VA = "0x183574F40")]
	public bool OKEGCOKGHHP(T MFBIHMKFNKA, object JGMHCJIBOFB, int PEMFPBGDFNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x35743C0", Offset = "0x3572BC0", VA = "0x1835743C0")]
	public bool EKLFHNDDCHK(object JGMHCJIBOFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x3574580", Offset = "0x3572D80", VA = "0x183574580")]
	public bool OADACMKKJNG(object JGMHCJIBOFB, out T MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x1D982D0", Offset = "0x1D96AD0", VA = "0x181D982D0")]
	public void BNEMLHGGHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x3A25810", Offset = "0x3A24010", VA = "0x183A25810")]
	private bool DCDJDNGGPNO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x3575200", Offset = "0x3573A00", VA = "0x183575200")]
	public HFLGMHECNDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public class DHEFPCOPCFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private Dictionary<object, float> OBBCJBEKBGL;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public float EGGIIEAFEJF
	{
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xE7E3C0", Offset = "0xE7CBC0", VA = "0x180E7E3C0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xC516A0", Offset = "0xC4FEA0", VA = "0x180C516A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x4E39160", Offset = "0x4E37960", VA = "0x184E39160")]
	public void OKEGCOKGHHP(float MFBIHMKFNKA, object JGMHCJIBOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x4E38FD0", Offset = "0x4E377D0", VA = "0x184E38FD0")]
	public void EKLFHNDDCHK(object JGMHCJIBOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x4E39040", Offset = "0x4E37840", VA = "0x184E39040")]
	private void MIBOCGECEKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x4E391D0", Offset = "0x4E379D0", VA = "0x184E391D0")]
	public DHEFPCOPCFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public class GPOHKAKJAMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public readonly string PECGNMHJHAB;

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x69FFB0", Offset = "0x69E7B0", VA = "0x18069FFB0")]
	public GPOHKAKJAMH(string MKHKBBMCNLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x4E3B020", Offset = "0x4E39820", VA = "0x184E3B020")]
	public GPOHKAKJAMH(UnityEngine.Object MENJEHPBPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x4E3AFD0", Offset = "0x4E397D0", VA = "0x184E3AFD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public sealed class PNCONINMAHM
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class EIALLFCNIOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		public EIALLFCNIOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x4E39BB0", Offset = "0x4E383B0", VA = "0x184E39BB0")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly HashSet<object> KBNFMJDHFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private int IDPKBGIOAHP;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public IReadOnlyCollection<object> HFGMJBLLECL
	{
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x5611D0", Offset = "0x55F9D0", VA = "0x1805611D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool PGBNKFDCFHL
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x4E3CB90", Offset = "0x4E3B390", VA = "0x184E3CB90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public int GJEPFFENNCK
	{
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x5ED670", Offset = "0x5EBE70", VA = "0x1805ED670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x4E3CA90", Offset = "0x4E3B290", VA = "0x184E3CA90")]
	public bool IONNJMGFDPB(object JGMHCJIBOFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x4E3CB10", Offset = "0x4E3B310", VA = "0x184E3CB10")]
	public bool JPAMCOIJOBL(object JGMHCJIBOFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x4E3CA30", Offset = "0x4E3B230", VA = "0x184E3CA30")]
	public bool CDHEDEIGJMA(object JGMHCJIBOFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x4E3CBA0", Offset = "0x4E3B3A0", VA = "0x184E3CBA0")]
	public void OILPLPNCDEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x4E3CC00", Offset = "0x4E3B400", VA = "0x184E3CC00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x4E3CD70", Offset = "0x4E3B570", VA = "0x184E3CD70")]
	public PNCONINMAHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public class HHDMCKJAKFM<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private struct BBJDKKMJMDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public float PNBNHPKCNNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public T CIFMBHMEFPE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private Dictionary<object, BBJDKKMJMDO> OBBCJBEKBGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private T BCLJIOEEKCG;

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public virtual T EMDECIAJHGN
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x1280CF0", Offset = "0x127F4F0", VA = "0x181280CF0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x1280470", Offset = "0x127EC70", VA = "0x181280470", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public object GNBJHJKMGPN
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x589A30", Offset = "0x588230", VA = "0x180589A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x6828D0", Offset = "0x6810D0", VA = "0x1806828D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool IKOBEMDIJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x3577760", Offset = "0x3575F60", VA = "0x183577760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x3577880", Offset = "0x3576080", VA = "0x183577880")]
	public bool OKEGCOKGHHP(T MFBIHMKFNKA, object JGMHCJIBOFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x3577480", Offset = "0x3575C80", VA = "0x183577480")]
	public bool EKLFHNDDCHK(object JGMHCJIBOFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x1D982D0", Offset = "0x1D96AD0", VA = "0x181D982D0")]
	public void BNEMLHGGHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x3577680", Offset = "0x3575E80", VA = "0x183577680")]
	public bool OADACMKKJNG(object JGMHCJIBOFB, out T MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x35770A0", Offset = "0x35758A0", VA = "0x1835770A0")]
	private bool DCDJDNGGPNO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x3577D70", Offset = "0x3576570", VA = "0x183577D70")]
	public HHDMCKJAKFM()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public class LCEEBCMBKCD
{
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private static byte[] FOBLDOOIPBJ;

	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private static int MKBJJHBJLOC;

	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private static int IFDBKDIOMPI;

	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private static BigInteger GDKMPNMIOJK;

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
	public LCEEBCMBKCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x4E3B9F0", Offset = "0x4E3A1F0", VA = "0x184E3B9F0")]
	private static string AFJLFGLOHPO(byte[] FMMAACMCILJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x4E3BAF0", Offset = "0x4E3A2F0", VA = "0x184E3BAF0")]
	public static string CAJPNALAKAJ(byte[] JNPIAJHKCKB, bool GKIDOBEBBAE)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x20000B7")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
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
