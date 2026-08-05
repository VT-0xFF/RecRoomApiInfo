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
public class EDKFOBDPHJG : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7C9100", Offset = "0x7C7F00", VA = "0x1807C9100")]
	public EDKFOBDPHJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, LCMGAGMLKKK, DNOPOLJGONC, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F50", Offset = "0x7B7D50", VA = "0x1807B8F50", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7B8B60", Offset = "0x7B7960", VA = "0x1807B8B60", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F00", Offset = "0x7B7D00", VA = "0x1807B8F00", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x85C2D0", Offset = "0x85B0D0", VA = "0x18085C2D0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash EJDCHNKDADM);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8853D0", Offset = "0x8841D0", VA = "0x1808853D0")]
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
	[AGODPOIAGJL]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[HideInInspector]
	[SerializeField]
	[AGODPOIAGJL]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x60B7210", Offset = "0x60B6010", VA = "0x1860B7210")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x60B71D0", Offset = "0x60B5FD0", VA = "0x1860B71D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x60B7250", Offset = "0x60B6050", VA = "0x1860B7250")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x60B7400", Offset = "0x60B6200", VA = "0x1860B7400")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x60B7370", Offset = "0x60B6170", VA = "0x1860B7370")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x922D40", Offset = "0x921B40", VA = "0x180922D40")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5B0", Offset = "0x9BB3B0", VA = "0x1809BC5B0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x60B7190", Offset = "0x60B5F90", VA = "0x1860B7190")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x60B72E0", Offset = "0x60B60E0", VA = "0x1860B72E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x60B6CC0", Offset = "0x60B5AC0", VA = "0x1860B6CC0")]
	public void CopyBounds(SavedExtents EDOEJIMPOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x60B70E0", Offset = "0x60B5EE0", VA = "0x1860B70E0")]
	public void SetLocalSpaceBounds(Bounds OIGNNNNBFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x9F28D0", Offset = "0x9F16D0", VA = "0x1809F28D0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x60B70D0", Offset = "0x60B5ED0", VA = "0x1860B70D0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x60B6CF0", Offset = "0x60B5AF0", VA = "0x1860B6CF0")]
	private void IFFBNKNFEGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x60B6EB0", Offset = "0x60B5CB0", VA = "0x1860B6EB0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x60B6650", Offset = "0x60B5450", VA = "0x1860B6650")]
	public static void CalculateLocalBoundsFor(GameObject EAPMMKKAJGJ, [Out] Bounds OIGNNNNBFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x60B6590", Offset = "0x60B5390", VA = "0x1860B6590")]
	private static void AHDGFDAGPPI(Bounds FNDBFMFAGPH, Color MEJOABMJHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x60B7100", Offset = "0x60B5F00", VA = "0x1860B7100")]
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
		[Cpp2IlInjected.Address(RVA = "0x7B8180", Offset = "0x7B6F80", VA = "0x1807B8180")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7C6A70", Offset = "0x7C5870", VA = "0x1807C6A70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xE32B60", Offset = "0xE31960", VA = "0x180E32B60")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x42D5F30", Offset = "0x42D4D30", VA = "0x1842D5F30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "4")]
	public virtual void JAPGCFCGHAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
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
	[EDKFOBDPHJG]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x42D5B10", Offset = "0x42D4910", VA = "0x1842D5B10", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x42D47B0", Offset = "0x42D35B0", VA = "0x1842D47B0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x42D5E60", Offset = "0x42D4C60", VA = "0x1842D5E60")]
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
	private sealed class JDODCCFDIOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public JDODCCFDIOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3A51110", Offset = "0x3A4FF10", VA = "0x183A51110")]
		internal int PBNECMOGDIP(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[EDKFOBDPHJG]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x32BE540", Offset = "0x32BD340", VA = "0x1832BE540", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x32BE590", Offset = "0x32BD390", VA = "0x1832BE590", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x32BE440", Offset = "0x32BD240", VA = "0x1832BE440", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey ONOECNHBCDA]
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x32BE4E0", Offset = "0x32BD2E0", VA = "0x1832BE4E0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x32BE320", Offset = "0x32BD120", VA = "0x1832BE320", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x32BE040", Offset = "0x32BCE40", VA = "0x1832BE040", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x32BD4E0", Offset = "0x32BC2E0", VA = "0x1832BD4E0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x32BD4B0", Offset = "0x32BC2B0", VA = "0x1832BD4B0", Slot = "14")]
	protected virtual string IKDKLABNMLE(TKeyVal OICJCLJABGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x32BD360", Offset = "0x32BC160", VA = "0x1832BD360", Slot = "4")]
	public bool ContainsKey(TKey ONOECNHBCDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x32BE1E0", Offset = "0x32BCFE0", VA = "0x1832BE1E0", Slot = "5")]
	public bool TryGetValue(TKey ONOECNHBCDA, [Out] TVal MAEBFBHFPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x32BD3B0", Offset = "0x32BC1B0", VA = "0x1832BD3B0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x32BD3B0", Offset = "0x32BC1B0", VA = "0x1832BD3B0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x32BE230", Offset = "0x32BD030", VA = "0x1832BE230")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class FCFBBOLNHNM<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private class OGDAECFEPKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public float KNNBIPLHCGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public T CIONEDGAKHL;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public OGDAECFEPKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class HKKDEGLFCDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public HKKDEGLFCDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x37CCB20", Offset = "0x37CB920", VA = "0x1837CCB20")]
		internal bool EMMPDKGNOJA(OGDAECFEPKO sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float FIALICIGLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float CEHPCLCPPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<OGDAECFEPKO> NFHCEAEEDBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private AIALJCPOHHL<OGDAECFEPKO> BGOJGCNAFNG;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int AGIICFELHPC
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x35F53E0", Offset = "0x35F41E0", VA = "0x1835F53E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x35F5B20", Offset = "0x35F4920", VA = "0x1835F5B20")]
	public FCFBBOLNHNM(float CFMFBIGBHCM, float GLPOKAGIPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x35F5080", Offset = "0x35F3E80", VA = "0x1835F5080")]
	public bool AOIEMONAPFN(float EHBJJHHNHHF, T MAEBFBHFPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x35F5780", Offset = "0x35F4580", VA = "0x1835F5780")]
	public IEnumerable<T> NMBOHIOMDEH(float EHBJJHHNHHF, [Optional] float? MDBCCCJCAED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x35F5AB0", Offset = "0x35F48B0", VA = "0x1835F5AB0")]
	public void OCIHDBDLDKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x35F5210", Offset = "0x35F4010", VA = "0x1835F5210")]
	private void CJEIKCPDKCJ(float EHBJJHHNHHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class PKLHNPKFHJC<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct DMGLMDDDGAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public T CIONEDGAKHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public float FPJHHLINNJN;
	}

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static float MJHFJBCDHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private List<T> OEMHJAEPHHM;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private const int HBOIAEBAHPG = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private DMGLMDDDGAL[] HHAMBPGBENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private int KMLPIILDIDO;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float GCHADIOKGBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8390E0", Offset = "0x837EE0", VA = "0x1808390E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8585E0", Offset = "0x8573E0", VA = "0x1808585E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x40B63E0", Offset = "0x40B51E0", VA = "0x1840B63E0")]
	public PKLHNPKFHJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x40B6400", Offset = "0x40B5200", VA = "0x1840B6400")]
	public PKLHNPKFHJC(int JEOEJJBKODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x40B5910", Offset = "0x40B4710", VA = "0x1840B5910")]
	public void GALNLGNAACN(float EHBJJHHNHHF, T MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x40B6290", Offset = "0x40B5090", VA = "0x1840B6290")]
	public void OCIHDBDLDKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x40B5D10", Offset = "0x40B4B10", VA = "0x1840B5D10")]
	public bool HIDKJOFEEAJ(float EOBOIBODBAD, float IDHEOPEEKFF, [Out] T MAEBFBHFPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x40B5500", Offset = "0x40B4300", VA = "0x1840B5500")]
	public bool ACAJFFPMBHL(float EOBOIBODBAD, float IDHEOPEEKFF, [Out] T MAEBFBHFPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x40B5F10", Offset = "0x40B4D10", VA = "0x1840B5F10")]
	public void OCFDALOFDJE(float EOBOIBODBAD, float IDHEOPEEKFF, List<T> LIICAAPCJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x40B5890", Offset = "0x40B4690", VA = "0x1840B5890")]
	private int CCMJNIJCJNN(int JONEFJBODAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x40B58C0", Offset = "0x40B46C0", VA = "0x1840B58C0")]
	private void CNAIPJFLCLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T AANDLIDKAIF();

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T JLELPEMFPBB(T MAEBFBHFPDE, float BHBDNAGLKEL);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T OCHIAHHDAMO(T MAJJJNOEIPE, T FBEFKCHGALI);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T MJMBBCANOIJ(T MAJJJNOEIPE, T FBEFKCHGALI);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class FLBCDHDILPE : PKLHNPKFHJC<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7C9990", Offset = "0x7C8790", VA = "0x1807C9990", Slot = "4")]
	protected override Vector3 AANDLIDKAIF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x60B31A0", Offset = "0x60B1FA0", VA = "0x1860B31A0", Slot = "5")]
	protected override Vector3 JLELPEMFPBB(Vector3 MAEBFBHFPDE, float BHBDNAGLKEL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x60B3260", Offset = "0x60B2060", VA = "0x1860B3260", Slot = "6")]
	protected override Vector3 OCHIAHHDAMO(Vector3 MAJJJNOEIPE, Vector3 FBEFKCHGALI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x60B31E0", Offset = "0x60B1FE0", VA = "0x1860B31E0", Slot = "7")]
	protected override Vector3 MJMBBCANOIJ(Vector3 MAJJJNOEIPE, Vector3 FBEFKCHGALI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x60B32B0", Offset = "0x60B20B0", VA = "0x1860B32B0")]
	public FLBCDHDILPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class FMMHBAPCIFM
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2736180", Offset = "0x2734F80", VA = "0x182736180")]
	public static CFJBGHDHFFE<T1, T2> KNBFKAAGFFE<T1, T2>(T1 EJABGBPPOBA, T2 BMPMMAOHEPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2736200", Offset = "0x2735000", VA = "0x182736200")]
	public static OJFKFMKOGAM<T1, T2, T3> KNBFKAAGFFE<T1, T2, T3>(T1 EJABGBPPOBA, T2 BMPMMAOHEPH, T3 EOOMBDFKBDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3E65930", Offset = "0x3E64730", VA = "0x183E65930")]
	internal static int AECLGLEPEJH(int FIJKKDKFHAO, int CKCHDFNKLLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x54E4090", Offset = "0x54E2E90", VA = "0x1854E4090")]
	internal static int AECLGLEPEJH(int FIJKKDKFHAO, int CKCHDFNKLLN, int GPPNHCOGKBJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class CFJBGHDHFFE<T1, T2> : IComparable<CFJBGHDHFFE<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T1 DLPJLBBOPDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly T2 CFJHBPOMKMD;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4C5F940", Offset = "0x4C5E740", VA = "0x184C5F940")]
	public CFJBGHDHFFE(T1 EJABGBPPOBA, T2 BMPMMAOHEPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4C5E3D0", Offset = "0x4C5D1D0", VA = "0x184C5E3D0", Slot = "4")]
	public int CompareTo(CFJBGHDHFFE<T1, T2> EDOEJIMPOFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4C5EB20", Offset = "0x4C5D920", VA = "0x184C5EB20", Slot = "0")]
	public override bool Equals(object EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4C5EE30", Offset = "0x4C5DC30", VA = "0x184C5EE30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4C5F6F0", Offset = "0x4C5E4F0", VA = "0x184C5F6F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class OJFKFMKOGAM<T1, T2, T3> : IComparable<OJFKFMKOGAM<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly T1 DLPJLBBOPDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly T2 CFJHBPOMKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly T3 GBGAKKOIMJM;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4008250", Offset = "0x4007050", VA = "0x184008250")]
	public OJFKFMKOGAM(T1 EJABGBPPOBA, T2 BMPMMAOHEPH, T3 EOOMBDFKBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4007A50", Offset = "0x4006850", VA = "0x184007A50", Slot = "4")]
	public int CompareTo(OJFKFMKOGAM<T1, T2, T3> EDOEJIMPOFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4007CA0", Offset = "0x4006AA0", VA = "0x184007CA0", Slot = "0")]
	public override bool Equals(object EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4007EE0", Offset = "0x4006CE0", VA = "0x184007EE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4007F80", Offset = "0x4006D80", VA = "0x184007F80", Slot = "3")]
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
	public T CIONEDGAKHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x20B5D20", Offset = "0x20B4B20", VA = "0x1820B5D20")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x20B5C60", Offset = "0x20B4A60", VA = "0x1820B5C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float OAPIMPMLMNI
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x89D930", Offset = "0x89C730", VA = "0x18089D930")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x44C2D40", Offset = "0x44C1B40", VA = "0x1844C2D40")]
	public T BCLPHBEEJDL(float BHBDNAGLKEL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x44C3050", Offset = "0x44C1E50", VA = "0x1844C3050")]
	public T IEBGGHIDCKF(float BHBDNAGLKEL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T KLHIJPFDNNE(T MAJJJNOEIPE, T FBEFKCHGALI, float BHBDNAGLKEL);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x60B3310", Offset = "0x60B2110", VA = "0x1860B3310", Slot = "4")]
	protected override float KLHIJPFDNNE(float MAJJJNOEIPE, float FBEFKCHGALI, float BHBDNAGLKEL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x60B3350", Offset = "0x60B2150", VA = "0x1860B3350")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xCD47D0", Offset = "0xCD35D0", VA = "0x180CD47D0", Slot = "4")]
	protected override Vector3 KLHIJPFDNNE(Vector3 MAJJJNOEIPE, Vector3 FBEFKCHGALI, float BHBDNAGLKEL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x60B8110", Offset = "0x60B6F10", VA = "0x1860B8110")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x60B2D10", Offset = "0x60B1B10", VA = "0x1860B2D10", Slot = "4")]
	protected override Color KLHIJPFDNNE(Color MAJJJNOEIPE, Color FBEFKCHGALI, float BHBDNAGLKEL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x60B2DD0", Offset = "0x60B1BD0", VA = "0x1860B2DD0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class HIAKEJLOJMO : LDJOKJNFDCC<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x60B3570", Offset = "0x60B2370", VA = "0x1860B3570")]
	public HIAKEJLOJMO(int DKDCFCAKJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x60B3500", Offset = "0x60B2300", VA = "0x1860B3500", Slot = "6")]
	protected override uint JCCIALJOLPF(uint EJDCHNKDADM, string MAEBFBHFPDE)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class EEKDGECDHAB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly IDisposable ACHMAPLCKNO;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public EEKDGECDHAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct MIKJGBIOLJH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> FBEANNKPAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int AKADMEKGAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int MJHAHPNJGIH;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3791FA0", Offset = "0x3790DA0", VA = "0x183791FA0")]
	private MIKJGBIOLJH(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> NKPPILOIOFH, int DJAOHDICHLK, int OPOHAGDAJNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3E1D610", Offset = "0x3E1C410", VA = "0x183E1D610")]
	public static MIKJGBIOLJH<T> IKCDCJJCDKO()
	{
		return default(MIKJGBIOLJH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3E1CF50", Offset = "0x3E1BD50", VA = "0x183E1CF50")]
	public (int, int, Task<T>) FNGBCFEDKKL(int GNMODFEIMHL, [Optional] CancellationToken MBHHHCCHBAO, double CDIOCCAJDIA = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3E1D8B0", Offset = "0x3E1C6B0", VA = "0x183E1D8B0")]
	public void NNCKKHNLDGK(int GNMODFEIMHL, int OPOHAGDAJNJ, [In] T ELGNBNFKLLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class CPGCHFLAEIL
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x60B2C40", Offset = "0x60B1A40", VA = "0x1860B2C40")]
	public static MIKJGBIOLJH<CFLPFJJKMFI> IKCDCJJCDKO()
	{
		return default(MIKJGBIOLJH<CFLPFJJKMFI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x60B2C90", Offset = "0x60B1A90", VA = "0x1860B2C90")]
	public static void NNCKKHNLDGK([In] this MIKJGBIOLJH<CFLPFJJKMFI> OELHNDCFEMO, int GNMODFEIMHL, int OPOHAGDAJNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DefaultMember("Item")]
public class HFOELOJPMDO<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly Dictionary<TKey, TVal> AKLNMFMKDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly Dictionary<TVal, TKey> JGPBIAJBBMF;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int EDOFPONLMHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x30A2EB0", Offset = "0x30A1CB0", VA = "0x1830A2EB0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool OJMEMOAMNDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x801AA0", Offset = "0x8008A0", VA = "0x180801AA0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ICollection<TKey> EEEKPMFOBHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x37B1660", Offset = "0x37B0460", VA = "0x1837B1660", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ICollection<TVal> LHIKNJNINIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x37B16A0", Offset = "0x37B04A0", VA = "0x1837B16A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TVal GKAMGCEMFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x37B1600", Offset = "0x37B0400", VA = "0x1837B1600", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x37B16E0", Offset = "0x37B04E0", VA = "0x1837B16E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey GKAMGCEMFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x37B10F0", Offset = "0x37AFEF0", VA = "0x1837B10F0")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x37B0B60", Offset = "0x37AF960", VA = "0x1837B0B60", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x37B1430", Offset = "0x37B0230", VA = "0x1837B1430", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x37B0AE0", Offset = "0x37AF8E0", VA = "0x1837B0AE0", Slot = "9")]
	public void Add(TKey ONOECNHBCDA, TVal MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x37B0B30", Offset = "0x37AF930", VA = "0x1837B0B30", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> IFKPOCGDKDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x37B0BC0", Offset = "0x37AF9C0", VA = "0x1837B0BC0", Slot = "8")]
	public bool ContainsKey(TKey ONOECNHBCDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x37B0C30", Offset = "0x37AFA30", VA = "0x1837B0C30", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> IFKPOCGDKDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x37B1300", Offset = "0x37B0100", VA = "0x1837B1300", Slot = "10")]
	public bool Remove(TKey ONOECNHBCDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x37B1360", Offset = "0x37B0160", VA = "0x1837B1360", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> IFKPOCGDKDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x37B1480", Offset = "0x37B0280", VA = "0x1837B1480", Slot = "11")]
	public bool TryGetValue(TKey ONOECNHBCDA, [Out] TVal MAEBFBHFPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x37B1000", Offset = "0x37AFE00", VA = "0x1837B1000", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x37B0C90", Offset = "0x37AFA90", VA = "0x1837B0C90", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] HHAMBPGBENG, int ABBBMAHIKNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x37B0D60", Offset = "0x37AFB60", VA = "0x1837B0D60")]
	public bool EMHKBCLCPNM(TVal ONOECNHBCDA, [Out] TKey MAEBFBHFPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x37B0ED0", Offset = "0x37AFCD0", VA = "0x1837B0ED0")]
	private void GAJINGLGCKA(TKey ONOECNHBCDA, TVal KJBIGJEIABL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x37B11D0", Offset = "0x37AFFD0", VA = "0x1837B11D0")]
	private void JEHHKIIMODE(TKey ONOECNHBCDA, TVal KJBIGJEIABL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x37B09C0", Offset = "0x37AF7C0", VA = "0x1837B09C0")]
	private bool AAFLANCEHGK(TKey ONOECNHBCDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x37B14C0", Offset = "0x37B02C0", VA = "0x1837B14C0")]
	public HFOELOJPMDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[DefaultMember("Item")]
public class AGFJOAJPODO<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private AGFJOAJPODO<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x33091E0", Offset = "0x3307FE0", VA = "0x1833091E0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x3313B20", Offset = "0x3312920", VA = "0x183313B20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3315120", Offset = "0x3313F20", VA = "0x183315120")]
		public Enumerator(AGFJOAJPODO<T> LIICAAPCJGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3311D60", Offset = "0x3310B60", VA = "0x183311D60", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x3312F60", Offset = "0x3311D60", VA = "0x183312F60", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x33127F0", Offset = "0x33115F0", VA = "0x1833127F0")]
		private void NBANFDMPPBO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private T[] MGEIFNHNIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int NIAPLMNAGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int ONMBMBBJECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private int OCEOBDFJNCG;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int EDOFPONLMHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x38BC480", Offset = "0x38BB280", VA = "0x1838BC480")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T GKAMGCEMFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x38BCB20", Offset = "0x38BB920", VA = "0x1838BCB20")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x38BDDB0", Offset = "0x38BCBB0", VA = "0x1838BDDB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x38BE3B0", Offset = "0x38BD1B0", VA = "0x1838BE3B0")]
	public AGFJOAJPODO(int DKDCFCAKJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x38BC4C0", Offset = "0x38BB2C0", VA = "0x1838BC4C0")]
	public void GALNLGNAACN(T BHBDNAGLKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x38BE0A0", Offset = "0x38BCEA0", VA = "0x1838BE0A0")]
	public void OCIHDBDLDKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x38BDD00", Offset = "0x38BCB00", VA = "0x1838BDD00")]
	public void LBNCDBDDEBO(int DPKFLHPPNCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x38BCDD0", Offset = "0x38BBBD0", VA = "0x1838BCDD0")]
	public void JACBMABLJPM(T[] HHAMBPGBENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x38BCA30", Offset = "0x38BB830", VA = "0x1838BCA30")]
	public Enumerator GGNEAJGHJIC()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x38BE140", Offset = "0x38BCF40", VA = "0x1838BE140", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x38BE140", Offset = "0x38BCF40", VA = "0x1838BE140", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x38BD6A0", Offset = "0x38BC4A0", VA = "0x1838BD6A0")]
	private int LAKMKGDCJHN(int OHINPGIGDNE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x38BD670", Offset = "0x38BC470", VA = "0x1838BD670")]
	private int JMHEHINPLFB(int OHINPGIGDNE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class MMJHLOKFOLA<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Func<Internal, External> FKHFCLMJJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private IReadOnlyList<Internal> MOAFNEBEDKD;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public External GKAMGCEMFBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3E34B20", Offset = "0x3E33920", VA = "0x183E34B20", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int EDOFPONLMHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3E34AD0", Offset = "0x3E338D0", VA = "0x183E34AD0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7C8480", Offset = "0x7C7280", VA = "0x1807C8480")]
	public MMJHLOKFOLA(Func<Internal, External> FKHFCLMJJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3E34A80", Offset = "0x3E33880", VA = "0x183E34A80")]
	public MMJHLOKFOLA(IReadOnlyList<Internal> MOAFNEBEDKD, Func<Internal, External> FKHFCLMJJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3E34A00", Offset = "0x3E33800", VA = "0x183E34A00", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x363E330", Offset = "0x363D130", VA = "0x18363E330", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class OJOGJBDINHG<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate Task<TResult> NKNCNFNMANJ(TRequest GFBEKCAHNCH, CancellationToken MBHHHCCHBAO);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public enum HPFJPCEODMA
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class ICKCPDMNCHP
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private const float FCOHAOIFDJJ = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TimeSpan JILFEBOJLND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int IOCKALBHHCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public HPFJPCEODMA HPNFLLAAGBD;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static readonly ICKCPDMNCHP DKIJAJPJIFN;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float GNILDOHMMAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x3870BC0", Offset = "0x386F9C0", VA = "0x183870BC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TimeSpan IDFOBDJMLME
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x7B8400", Offset = "0x7B7200", VA = "0x1807B8400")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x3870D80", Offset = "0x386FB80", VA = "0x183870D80")]
		public ICKCPDMNCHP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private readonly struct OBANMBPEMIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly TRequest GFBEKCAHNCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly CancellationToken MBHHHCCHBAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly TaskCompletionSource<TResult> FANDFCCFKMH;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x3FB38A0", Offset = "0x3FB26A0", VA = "0x183FB38A0")]
		public OBANMBPEMIH(TRequest GFBEKCAHNCH, TaskCompletionSource<TResult> FANDFCCFKMH, CancellationToken MBHHHCCHBAO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct ILHEGJMFFNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public OJOGJBDINHG<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x389A7D0", Offset = "0x38995D0", VA = "0x18389A7D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x389AC70", Offset = "0x3899A70", VA = "0x18389AC70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct PMGAKJHMKBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public OJOGJBDINHG<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private OBANMBPEMIH <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x40B92E0", Offset = "0x40B80E0", VA = "0x1840B92E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x40B98E0", Offset = "0x40B86E0", VA = "0x1840B98E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly CancellationTokenSource CBMHMCCFPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly List<OBANMBPEMIH> NIOIJLKFHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly ICKCPDMNCHP BGCMJBGCHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly NKNCNFNMANJ LNGKDDEKDGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Task OEKHJDGCAHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private int FKONMNDBJKB;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4009D20", Offset = "0x4008B20", VA = "0x184009D20")]
	public OJOGJBDINHG(NKNCNFNMANJ LNGKDDEKDGP, [Optional] ICKCPDMNCHP BGCMJBGCHIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x40099B0", Offset = "0x40087B0", VA = "0x1840099B0")]
	public Task<TResult> OEMBNOMJKIB(TRequest GFBEKCAHNCH, CancellationToken MBHHHCCHBAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x40091B0", Offset = "0x4007FB0", VA = "0x1840091B0")]
	private void KJFJIPHHEAB(OBANMBPEMIH COIELNMFNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4009490", Offset = "0x4008290", VA = "0x184009490")]
	[AsyncStateMachine(typeof(OJOGJBDINHG<, >.ILHEGJMFFNC))]
	private Task NAJBDNFPCEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4008340", Offset = "0x4007140", VA = "0x184008340")]
	private OBANMBPEMIH AEBADPLJEBL()
	{
		return default(OBANMBPEMIH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4008F20", Offset = "0x4007D20", VA = "0x184008F20")]
	[AsyncStateMachine(typeof(OJOGJBDINHG<, >.PMGAKJHMKBD))]
	private Task GFDCDOBAPOM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4008D30", Offset = "0x4007B30", VA = "0x184008D30")]
	private void FNEMJHIHLCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4008B10", Offset = "0x4007910", VA = "0x184008B10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public class OGAOBKPLLHA<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly List<T> MOAFNEBEDKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private HashSet<T> MMCEPPAKKGN;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int EDOFPONLMHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x30A2EB0", Offset = "0x30A1CB0", VA = "0x1830A2EB0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool OJMEMOAMNDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x801AA0", Offset = "0x8008A0", VA = "0x180801AA0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T GKAMGCEMFBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3637B20", Offset = "0x3636920", VA = "0x183637B20", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3FC52D0", Offset = "0x3FC40D0", VA = "0x183FC52D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3666250", Offset = "0x3665050", VA = "0x183666250", Slot = "11")]
	public void Add(T IFKPOCGDKDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3FC4A90", Offset = "0x3FC3890", VA = "0x183FC4A90")]
	public bool IJLDICBJDCE(T IFKPOCGDKDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3FC4FC0", Offset = "0x3FC3DC0", VA = "0x183FC4FC0", Slot = "15")]
	public bool Remove(T IFKPOCGDKDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3EAE230", Offset = "0x3EAD030", VA = "0x183EAE230", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x36876D0", Offset = "0x36864D0", VA = "0x1836876D0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3FC49C0", Offset = "0x3FC37C0", VA = "0x183FC49C0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3FC4A20", Offset = "0x3FC3820", VA = "0x183FC4A20", Slot = "13")]
	public bool Contains(T IFKPOCGDKDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3FC4A60", Offset = "0x3FC3860", VA = "0x183FC4A60", Slot = "14")]
	public void CopyTo(T[] HHAMBPGBENG, int ABBBMAHIKNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3BA5500", Offset = "0x3BA4300", VA = "0x183BA5500", Slot = "6")]
	public int IndexOf(T IFKPOCGDKDB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3FC4C10", Offset = "0x3FC3A10", VA = "0x183FC4C10", Slot = "7")]
	public void Insert(int OHINPGIGDNE, T IFKPOCGDKDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3FC4DD0", Offset = "0x3FC3BD0", VA = "0x183FC4DD0", Slot = "8")]
	public void RemoveAt(int OHINPGIGDNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3FC5100", Offset = "0x3FC3F00", VA = "0x183FC5100")]
	public OGAOBKPLLHA()
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
			[Cpp2IlInjected.Address(RVA = "0x1F2D3E0", Offset = "0x1F2C1E0", VA = "0x181F2D3E0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x60B77A0", Offset = "0x60B65A0", VA = "0x1860B77A0")]
		public SerializedGuid([In] Guid MAAFBDMNKAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x60B7590", Offset = "0x60B6390", VA = "0x1860B7590")]
		public static SerializedGuid FDLPKCMHJBH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x60B7610", Offset = "0x60B6410", VA = "0x1860B7610")]
		public static SerializedGuid FLEJJGNEFDC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x60B7690", Offset = "0x60B6490", VA = "0x1860B7690")]
		public bool KOELFDEDMEJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x60B7770", Offset = "0x60B6570", VA = "0x1860B7770", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x60B76F0", Offset = "0x60B64F0", VA = "0x1860B76F0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x60B74C0", Offset = "0x60B62C0", VA = "0x1860B74C0", Slot = "7")]
		public bool Equals(SerializedGuid EDOEJIMPOFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x60B7500", Offset = "0x60B6300", VA = "0x1860B7500", Slot = "0")]
		public override bool Equals(object KDHDNCADFDJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x60B7680", Offset = "0x60B6480", VA = "0x1860B7680", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x60B7490", Offset = "0x60B6290", VA = "0x1860B7490", Slot = "6")]
		public int CompareTo(SerializedGuid EDOEJIMPOFP)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class EOKICHFKEMI : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly Type GMJAEPBFGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly string KKJHEBANPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool DCHJOIIGIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool KCMEKEGDEJN;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x60B3130", Offset = "0x60B1F30", VA = "0x1860B3130")]
	public EOKICHFKEMI(Type CKJCEHDGKIO, string FKGNGCHJOFN, bool BJDNPPMKKPE = false, bool KAOBAPDFFHC = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class GMKELMLBOAO<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public readonly struct LDLCKDIAICI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly long AMDMPAHFLDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly long CJKFPJEMFOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public readonly int ENNNHHMPJOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly int AHKHKGDFENF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly bool LNMLLHINNNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly string OBBCBPDKFJN;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3BFD170", Offset = "0x3BFBF70", VA = "0x183BFD170")]
		public LDLCKDIAICI(long AMDMPAHFLDL, int ENNNHHMPJOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3BFD140", Offset = "0x3BFBF40", VA = "0x183BFD140")]
		public LDLCKDIAICI(long AMDMPAHFLDL, long CJKFPJEMFOB, int ENNNHHMPJOK, int AHKHKGDFENF, bool LNMLLHINNNJ, string OBBCBPDKFJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3BFCFD0", Offset = "0x3BFBDD0", VA = "0x183BFCFD0")]
		public int ENANAEICOJA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3BFD020", Offset = "0x3BFBE20", VA = "0x183BFD020")]
		public int FOLEFAIAMGK(int JOOIOMKEHMB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3BFD0E0", Offset = "0x3BFBEE0", VA = "0x183BFD0E0")]
		public double MMPEBACLMEA()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3BFD040", Offset = "0x3BFBE40", VA = "0x183BFD040")]
		public LDLCKDIAICI LFJHLLMMOAC(long CJKFPJEMFOB, int AHKHKGDFENF)
		{
			return default(LDLCKDIAICI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class BDJJEKBHOMC : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct KDIHEKBDAJP<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public BDJJEKBHOMC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Func<BDJJEKBHOMC, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private BDJJEKBHOMC <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x3B01F30", Offset = "0x3B00D30", VA = "0x183B01F30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x386BE60", Offset = "0x386AC60", VA = "0x18386BE60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly TKey HBMNMFEKKLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly GMKELMLBOAO<TKey> IMFPKCJALMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly IIFCCHIKGII KOLDIMNADKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private List<BDJJEKBHOMC> MPEIIOBBBDA;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string BHNJJCANCMP
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x476A3F0", Offset = "0x47691F0", VA = "0x18476A3F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IEnumerable<BDJJEKBHOMC> LHMFCJHGBFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x476A420", Offset = "0x4769220", VA = "0x18476A420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public LDLCKDIAICI FDCENCENCFD
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x476A070", Offset = "0x4768E70", VA = "0x18476A070")]
			[CompilerGenerated]
			get
			{
				return default(LDLCKDIAICI);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x476A040", Offset = "0x4768E40", VA = "0x18476A040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x476A460", Offset = "0x4769260", VA = "0x18476A460")]
		internal BDJJEKBHOMC(GMKELMLBOAO<TKey> IMFPKCJALMD, TKey ONOECNHBCDA, IIFCCHIKGII KOLDIMNADKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x476A290", Offset = "0x4769090", VA = "0x18476A290")]
		public BDJJEKBHOMC GLGBMPDINCE(TKey ONOECNHBCDA, [Optional] IIFCCHIKGII? KLENNODLFIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x229DCD0", Offset = "0x229CAD0", VA = "0x18229DCD0")]
		[AsyncStateMachine(typeof(KDIHEKBDAJP<>))]
		public Task<T> AFNAJPKEHOA<T>(TKey ONOECNHBCDA, Func<BDJJEKBHOMC, Task<T>> BKMNKOEHPLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x476A090", Offset = "0x4768E90", VA = "0x18476A090", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class CCNGPMIHIAP : IEnumerable<(TKey, List<TKey>, LDLCKDIAICI)>, IEnumerable, IEnumerator<(TKey, List<TKey>, LDLCKDIAICI)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private (TKey key, List<TKey> path, LDLCKDIAICI timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public GMKELMLBOAO<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IEnumerator<(TKey key, List<TKey> path, LDLCKDIAICI timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, LDLCKDIAICI) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x1F1AA70", Offset = "0x1F19870", VA = "0x181F1AA70", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, LDLCKDIAICI));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x4B86590", Offset = "0x4B85390", VA = "0x184B86590", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x1F1AB60", Offset = "0x1F19960", VA = "0x181F1AB60")]
		[DebuggerHidden]
		public CCNGPMIHIAP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x34F6D40", Offset = "0x34F5B40", VA = "0x1834F6D40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x4B860E0", Offset = "0x4B84EE0", VA = "0x184B860E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4B86090", Offset = "0x4B84E90", VA = "0x184B86090")]
		private void FHJCGBCHLDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x4B86540", Offset = "0x4B85340", VA = "0x184B86540", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x4B86480", Offset = "0x4B85280", VA = "0x184B86480", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, LDLCKDIAICI)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x360CCB0", Offset = "0x360BAB0", VA = "0x18360CCB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class OHPAAKBLGJE : IEnumerable<(TKey, List<TKey>, LDLCKDIAICI)>, IEnumerable, IEnumerator<(TKey, List<TKey>, LDLCKDIAICI)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private (TKey key, List<TKey> path, LDLCKDIAICI timerEntry) <>2__current;

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
		private BDJJEKBHOMC timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public BDJJEKBHOMC <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public GMKELMLBOAO<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private IEnumerator<BDJJEKBHOMC> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private IEnumerator<(TKey key, List<TKey> path, LDLCKDIAICI timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private (TKey, List<TKey>, LDLCKDIAICI) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x1F1AA70", Offset = "0x1F19870", VA = "0x181F1AA70", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, LDLCKDIAICI));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x4003F30", Offset = "0x4002D30", VA = "0x184003F30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x1F1AB60", Offset = "0x1F19960", VA = "0x181F1AB60")]
		[DebuggerHidden]
		public OHPAAKBLGJE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4003F90", Offset = "0x4002D90", VA = "0x184003F90", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x40035C0", Offset = "0x40023C0", VA = "0x1840035C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x4003560", Offset = "0x4002360", VA = "0x184003560")]
		private void FHJCGBCHLDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4003D70", Offset = "0x4002B70", VA = "0x184003D70")]
		private void PDHPDAEENHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x4003EE0", Offset = "0x4002CE0", VA = "0x184003EE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x4003DD0", Offset = "0x4002BD0", VA = "0x184003DD0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, LDLCKDIAICI)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x4003EB0", Offset = "0x4002CB0", VA = "0x184003EB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly Action<TKey, LDLCKDIAICI, IIFCCHIKGII> DILKGKNGDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Action<TKey, LDLCKDIAICI, IIFCCHIKGII> PLNGHHDAAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly Action<GMKELMLBOAO<TKey>, IIFCCHIKGII> LHLBFMCCLMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly IIFCCHIKGII KOLDIMNADKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly BDJJEKBHOMC CFBPBBBECFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private bool JGKIPPNJKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int BLHMCFDNOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly Stopwatch EFJKNJICFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly int LFFCDKBIBMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private string KMHPMLANBOI;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public BDJJEKBHOMC KJLGKMMJKDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7BE940", Offset = "0x7BD740", VA = "0x1807BE940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[NotNull]
	public string BHNJJCANCMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7BB8D0", Offset = "0x7BA6D0", VA = "0x1807BB8D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x37126E0", Offset = "0x37114E0", VA = "0x1837126E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x37128A0", Offset = "0x37116A0", VA = "0x1837128A0")]
	public GMKELMLBOAO(TKey HJFOHMKGNFJ, IIFCCHIKGII KOLDIMNADKN, [Optional] int? ENNNHHMPJOK, [Optional][CanBeNull] Stopwatch EFJKNJICFFF, [Optional] Action<TKey, LDLCKDIAICI, IIFCCHIKGII> DILKGKNGDOG, [Optional] Action<TKey, LDLCKDIAICI, IIFCCHIKGII> PLNGHHDAAJF, [Optional] Action<GMKELMLBOAO<TKey>, IIFCCHIKGII> LHLBFMCCLMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x37125D0", Offset = "0x37113D0", VA = "0x1837125D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3712810", Offset = "0x3711610", VA = "0x183712810")]
	[IteratorStateMachine(typeof(GMKELMLBOAO<>.CCNGPMIHIAP))]
	public IEnumerable<(TKey, List<TKey>, LDLCKDIAICI)> OKOEBPAOJHA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3712740", Offset = "0x3711540", VA = "0x183712740")]
	[IteratorStateMachine(typeof(GMKELMLBOAO<>.OHPAAKBLGJE))]
	private IEnumerable<(TKey, List<TKey>, LDLCKDIAICI)> OKOEBPAOJHA(List<TKey> NOCEOCEDPNN, BDJJEKBHOMC GIIMMAGDLPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x3712660", Offset = "0x3711460", VA = "0x183712660")]
	private (long, int) GNJONNMLFON()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public abstract class FIDAFGMMAGE<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut IHFIIGPBCFM(GMKELMLBOAO<TKey> IMFPKCJALMD);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	protected FIDAFGMMAGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public abstract class KHOHPDELPIA<TKey> : FIDAFGMMAGE<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate string DBKIKHGJCGG(TKey ONOECNHBCDA);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D250", Offset = "0x3B1C050", VA = "0x183B1D250")]
	private static string JEMLCKIBCJI(TKey ONOECNHBCDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D040", Offset = "0x3B1BE40", VA = "0x183B1D040", Slot = "4")]
	public override string IHFIIGPBCFM(GMKELMLBOAO<TKey> IMFPKCJALMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D100", Offset = "0x3B1BF00", VA = "0x183B1D100")]
	public string IHFIIGPBCFM(GMKELMLBOAO<TKey> IMFPKCJALMD, [NotNull] DBKIKHGJCGG PBBPJKNIDCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string DDGGOENGOBF(GMKELMLBOAO<TKey> IMFPKCJALMD, [NotNull] DBKIKHGJCGG PBBPJKNIDCN);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x38AFC30", Offset = "0x38AEA30", VA = "0x1838AFC30")]
	protected KHOHPDELPIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class AMKIIPNPBOK<TKey> : FIDAFGMMAGE<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate string JDNHEGIIIJA(TKey ONOECNHBCDA);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly string OFCKFHMNNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly double MHLJHIADKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly bool PEIDAGMLCFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly int MNMFAJCJIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly ISet<string> DJKMHFJGAAC;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x39A90A0", Offset = "0x39A7EA0", VA = "0x1839A90A0")]
	private static string JEMLCKIBCJI(TKey ONOECNHBCDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x39A9320", Offset = "0x39A8120", VA = "0x1839A9320")]
	public AMKIIPNPBOK(string OFCKFHMNNAK = "F2", double MHLJHIADKLM = double.MaxValue, bool PEIDAGMLCFF = false, int MNMFAJCJIMC = int.MaxValue, [Optional] ISet<string> DJKMHFJGAAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x39A89F0", Offset = "0x39A77F0", VA = "0x1839A89F0", Slot = "4")]
	public override Dictionary<string, string> IHFIIGPBCFM(GMKELMLBOAO<TKey> IMFPKCJALMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x39A9240", Offset = "0x39A8040", VA = "0x1839A9240")]
	private bool OJNINCKEKEP(string OPGPAEHKFPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x39A8AB0", Offset = "0x39A78B0", VA = "0x1839A8AB0")]
	public Dictionary<string, string> IHFIIGPBCFM(GMKELMLBOAO<TKey> IMFPKCJALMD, JDNHEGIIIJA PBBPJKNIDCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x39A87B0", Offset = "0x39A75B0", VA = "0x1839A87B0")]
	private string AKOOFDMJMPM(StringBuilder GJBENEHJPFD, List<TKey> HBMPAPDBFGE, JDNHEGIIIJA PBBPJKNIDCN, bool NIBDJNNFLCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x39A90E0", Offset = "0x39A7EE0", VA = "0x1839A90E0")]
	private static void LJHAPNHFLCL(StringBuilder HODLLOELLGB, string JFPGMHDLBDN, bool HLNCABDMLFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class ICLLOEJMHMM<TKey> : KHOHPDELPIA<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct BKKOFOIAOHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public DBKIKHGJCGG keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static ICLLOEJMHMM<TKey> ACHMAPLCKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly string[] KJPELCKDMNC;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3871EC0", Offset = "0x3870CC0", VA = "0x183871EC0")]
	private ICLLOEJMHMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3870E60", Offset = "0x386FC60", VA = "0x183870E60", Slot = "5")]
	protected override string DDGGOENGOBF(GMKELMLBOAO<TKey> IMFPKCJALMD, DBKIKHGJCGG PBBPJKNIDCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3871C90", Offset = "0x3870A90", VA = "0x183871C90")]
	[CompilerGenerated]
	internal static string PIDABJOKMLG(string DBGHJDHPEBK, TKey ONOECNHBCDA, BKKOFOIAOHG P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class ILOFFBOPHLI : GMKELMLBOAO<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class IIJPLMDNCJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Action<ILOFFBOPHLI, IIFCCHIKGII> callback;

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public IIJPLMDNCJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x60B35C0", Offset = "0x60B23C0", VA = "0x1860B35C0")]
		internal void HCBLJBLIAFI(GMKELMLBOAO<string> timer, IIFCCHIKGII log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x60B3710", Offset = "0x60B2510", VA = "0x1860B3710")]
	public ILOFFBOPHLI(IIFCCHIKGII KOLDIMNADKN, [Optional] string HGCMGMIHIKM, [Optional] int? ENNNHHMPJOK, [Optional] Stopwatch EFJKNJICFFF, [Optional] Action<string, LDLCKDIAICI, IIFCCHIKGII> DILKGKNGDOG, [Optional] Action<string, LDLCKDIAICI, IIFCCHIKGII> PLNGHHDAAJF, [Optional] Action<ILOFFBOPHLI, IIFCCHIKGII> LHLBFMCCLMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x60B3650", Offset = "0x60B2450", VA = "0x1860B3650")]
	private static Action<GMKELMLBOAO<string>, IIFCCHIKGII> NBHGMDIMPCE(Action<ILOFFBOPHLI, IIFCCHIKGII> NHPEKKMOHMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public abstract class HHCAEKMDFLL
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private class MCCKILEIGML : HHCAEKMDFLL
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static HHCAEKMDFLL ACHMAPLCKNO
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x60B4220", Offset = "0x60B3020", VA = "0x1860B4220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override float CGNLLACEFIA
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x1D73D90", Offset = "0x1D72B90", VA = "0x181D73D90", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x60B4320", Offset = "0x60B3120", VA = "0x1860B4320")]
		public MCCKILEIGML()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static HHCAEKMDFLL NMEKNADDFHB;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static HHCAEKMDFLL DKIJAJPJIFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x60B3390", Offset = "0x60B2190", VA = "0x1860B3390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public abstract float CGNLLACEFIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	protected HHCAEKMDFLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class PNGELAMEODF<T> : FIABIDCENEM<T> where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public override Task<T> HCAGFLIDPAD
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public override IEONLNEHMOD<T> NMGLLKMJFMG
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7B8B60", Offset = "0x7B7960", VA = "0x1807B8B60", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x40C58D0", Offset = "0x40C46D0", VA = "0x1840C58D0")]
	public PNGELAMEODF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "10")]
	protected override void MKKLIBGDPFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class LNKKNGIBBML<T> : FIABIDCENEM<T> where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public override Task<T> HCAGFLIDPAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public override IEONLNEHMOD<T> NMGLLKMJFMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7B8B60", Offset = "0x7B7960", VA = "0x1807B8B60", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3C3F820", Offset = "0x3C3E620", VA = "0x183C3F820")]
	public LNKKNGIBBML(Exception IOKJIKNDOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "10")]
	protected override void MKKLIBGDPFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface KLGFKCBCBJL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool KMJOLKOJMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface NNOEEBAFNLF<T> : KLGFKCBCBJL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	[NotNull]
	Task<T> HCAGFLIDPAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	[NotNull]
	IEONLNEHMOD<T> NMGLLKMJFMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public abstract class FIABIDCENEM<T> : NNOEEBAFNLF<T>, KLGFKCBCBJL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly KCKOIHMNECF FNEOCJEMEDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private bool JGKIPPNJKKP;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool KMJOLKOJMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xA08F10", Offset = "0xA07D10", VA = "0x180A08F10", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public abstract Task<T> HCAGFLIDPAD
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public abstract IEONLNEHMOD<T> NMGLLKMJFMG
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x360D460", Offset = "0x360C260", VA = "0x18360D460")]
	public FIABIDCENEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x360D2E0", Offset = "0x360C0E0", VA = "0x18360D2E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void MKKLIBGDPFM();
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public abstract class GCNDGCKLHJC<TTask, T> : FIABIDCENEM<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class MIJBEFEIDAD
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
			public MIJBEFEIDAD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x3092F30", Offset = "0x3091D30", VA = "0x183092F30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x30934A0", Offset = "0x30922A0", VA = "0x1830934A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public GCNDGCKLHJC<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public MIJBEFEIDAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x3E1BF90", Offset = "0x3E1AD90", VA = "0x183E1BF90")]
		[AsyncStateMachine(typeof(GCNDGCKLHJC<, >.MIJBEFEIDAD.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> LHMCOJFIFAC(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly Task<T> NPDMMHKHJDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	protected readonly CancellationTokenSource LNBKFFEFFCN;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public override Task<T> HCAGFLIDPAD
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public override IEONLNEHMOD<T> NMGLLKMJFMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7B8B60", Offset = "0x7B7960", VA = "0x1807B8B60", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x36E46C0", Offset = "0x36E34C0", VA = "0x1836E46C0")]
	protected GCNDGCKLHJC(TTask NPDMMHKHJDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x36E4670", Offset = "0x36E3470", VA = "0x1836E4670", Slot = "10")]
	protected override void MKKLIBGDPFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T ELJPINKFIIG(TTask MBMIBOKKDMO);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void NNBGAKBJGII();
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class MGBLHAEICDG<T> : FIABIDCENEM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly LOHPMIAJHKJ<Task<T>> NMAGLOCJAEE;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public override Task<T> HCAGFLIDPAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x35EC230", Offset = "0x35EB030", VA = "0x1835EC230", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public override IEONLNEHMOD<T> NMGLLKMJFMG
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7B8B60", Offset = "0x7B7960", VA = "0x1807B8B60", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3E108D0", Offset = "0x3E0F6D0", VA = "0x183E108D0")]
	public MGBLHAEICDG(LOHPMIAJHKJ<Task<T>> JFJGONENFAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3E108B0", Offset = "0x3E0F6B0", VA = "0x183E108B0", Slot = "10")]
	protected override void MKKLIBGDPFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class KHDEIBPAEBD
{
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x60B41B0", Offset = "0x60B2FB0", VA = "0x1860B41B0")]
	[NotNull]
	public static byte[] GDHPHPFHLDG(this LCMGAGMLKKK OLJNFFDBDOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x60B4140", Offset = "0x60B2F40", VA = "0x1860B4140")]
	[NotNull]
	public static byte[] GDHPHPFHLDG(this LCMGAGMLKKK OLJNFFDBDOI, HashAlgorithmName EFMGPMEKAEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x60B3FB0", Offset = "0x60B2DB0", VA = "0x1860B3FB0")]
	public static bool EJOJJNAOPDP([CanBeNull] this LCMGAGMLKKK OLJNFFDBDOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x60B3E10", Offset = "0x60B2C10", VA = "0x1860B3E10")]
	public static bool EJOJJNAOPDP([CanBeNull] this LCMGAGMLKKK OLJNFFDBDOI, [Out] string JCNMJFGAPPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x60B3CF0", Offset = "0x60B2AF0", VA = "0x1860B3CF0")]
	private static bool BLNJEDONEON([NotNull] LCMGAGMLKKK OLJNFFDBDOI, [Out][CanBeNull] byte[] JBEGOLEGAMP, [Out][CanBeNull] byte[] MLEKANIOHGK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class DNIBDGNGAJO
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x60B2E70", Offset = "0x60B1C70", VA = "0x1860B2E70")]
	[NotNull]
	public static byte[] GDHPHPFHLDG(this DNOPOLJGONC JDGLCIHIOKP, HashAlgorithmName EFMGPMEKAEP, byte[] OFIPKMBFDIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface DNOPOLJGONC
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash EJDCHNKDADM);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface LCMGAGMLKKK : DNOPOLJGONC
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	[CanBeNull]
	byte[] JBBDFDEIGOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	[CanBeNull]
	byte[] DJEONEGKBHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class NEFAHNMGAGG
{
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static readonly ArrayPool<byte> LLFJLGIHECM;

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static bool OFGLNCJNANC;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x60B4370", Offset = "0x60B3170", VA = "0x1860B4370")]
	public static void APHBDOAHOFF(this IncrementalHash CKOHCEONANJ, [CanBeNull] GameObject EAPMMKKAJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x2865350", Offset = "0x2864150", VA = "0x182865350")]
	public static void APHBDOAHOFF<T>(this IncrementalHash CKOHCEONANJ, [CanBeNull] T DCKFFGHEGII) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x2865410", Offset = "0x2864210", VA = "0x182865410")]
	public static void DEKFBMICLLN<T>(this IncrementalHash CKOHCEONANJ, [CanBeNull] T JDGLCIHIOKP) where T : DNOPOLJGONC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x28654A0", Offset = "0x28642A0", VA = "0x1828654A0")]
	public static void LFHLHLGPGPO<T>(this IncrementalHash CKOHCEONANJ, [CanBeNull] IList<T> PKCCEHOFHEJ) where T : DNOPOLJGONC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x60B4B50", Offset = "0x60B3950", VA = "0x1860B4B50")]
	private static bool JGEEDJNMKEH([CanBeNull] DNOPOLJGONC JDGLCIHIOKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x60B4DB0", Offset = "0x60B3BB0", VA = "0x1860B4DB0")]
	public static void MGLPHKJBGEL(this IncrementalHash EJDCHNKDADM, [CanBeNull] string JLHKJBJFHNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x60B4980", Offset = "0x60B3780", VA = "0x1860B4980")]
	public static void HEFHMNAHKNJ(this IncrementalHash EJDCHNKDADM, long HGBPMCNJPIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x60B4BE0", Offset = "0x60B39E0", VA = "0x1860B4BE0")]
	public static void LJBAAHJEFHO(this IncrementalHash EJDCHNKDADM, int KBBMMEOGOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x60B4620", Offset = "0x60B3420", VA = "0x1860B4620")]
	public static void FFAHGHOECAH(this IncrementalHash EJDCHNKDADM, short MIPAEOMOENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x60B4510", Offset = "0x60B3310", VA = "0x1860B4510")]
	public static void COBGJHMNNMI(this IncrementalHash EJDCHNKDADM, byte CBPEMKBEMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x60B4E70", Offset = "0x60B3C70", VA = "0x1860B4E70")]
	public static void PIKOMBNLPID(this IncrementalHash EJDCHNKDADM, bool BIHBDGFGCKF, bool KKPMAMBCFLD = false, bool FJEFJJFHPIJ = false, bool OGKKKHLEOIE = false, bool PGDJDHGOLJD = false, bool NACIFOLMPKK = false, bool AIMOFNPINJH = false, bool NIHIFAOABAG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x28659C0", Offset = "0x28647C0", VA = "0x1828659C0")]
	public static void MFOCHEGMLAD<T>(this IncrementalHash EJDCHNKDADM, T HNNEPCFDHAJ) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x60B4450", Offset = "0x60B3250", VA = "0x1860B4450")]
	public static void CHECGFKCAPN(this IncrementalHash EJDCHNKDADM, float PCFJCKFNIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x60B47F0", Offset = "0x60B35F0", VA = "0x1860B47F0")]
	public static void GBAPNLIEENJ(this IncrementalHash EJDCHNKDADM, ulong MBHCJFEJHJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x60B44B0", Offset = "0x60B32B0", VA = "0x1860B44B0")]
	public static void CNMHIEMAFGC(this IncrementalHash EJDCHNKDADM, uint NANLMBFFFNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x60B4E10", Offset = "0x60B3C10", VA = "0x1860B4E10")]
	public static void NLLGFAONEEI(this IncrementalHash EJDCHNKDADM, ushort HCNELBMHAGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x60B4850", Offset = "0x60B3650", VA = "0x1860B4850")]
	public static void GHEINLFBOOM(this IncrementalHash EJDCHNKDADM, Vector3 JNDIKDKGBBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class DIKNICKLEBJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x60B2E10", Offset = "0x60B1C10", VA = "0x1860B2E10")]
	public DIKNICKLEBJ(string LJCDGDONMLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public abstract class JOADLFAGCJH<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	internal class OEJJCKBACCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public TNode OELHNDCFEMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public TNode FEOGIMKDFKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public FNKGPBLCNLM CMIMEIFNPKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public List<FNKGPBLCNLM> PMHBIIJCMAG;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public OEJJCKBACCI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	internal struct FNKGPBLCNLM : IComparable<FNKGPBLCNLM>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public int IAOKDNOLMMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public TClaimant NJFAJNGHOBB;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xBF9910", Offset = "0xBF8710", VA = "0x180BF9910")]
		public FNKGPBLCNLM(int IAOKDNOLMMH, TClaimant NJFAJNGHOBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3637C80", Offset = "0x3636A80", VA = "0x183637C80")]
		public bool GDBLGBJIILC([In] FNKGPBLCNLM EDOEJIMPOFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3637C70", Offset = "0x3636A70", VA = "0x183637C70")]
		public bool FIMDPEKICOI([In] FNKGPBLCNLM EDOEJIMPOFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3637C60", Offset = "0x3636A60", VA = "0x183637C60", Slot = "4")]
		public int CompareTo(FNKGPBLCNLM EDOEJIMPOFP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3637CE0", Offset = "0x3636AE0", VA = "0x183637CE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public enum BDNCEGEKLHA
	{
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class KJKLGJNMNEN : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
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
		public JOADLFAGCJH<TClaimant, TNode> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x815510", Offset = "0x814310", VA = "0x180815510")]
		[DebuggerHidden]
		public KJKLGJNMNEN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3B25760", Offset = "0x3B24560", VA = "0x183B25760", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3B25920", Offset = "0x3B24720", VA = "0x183B25920", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3B25840", Offset = "0x3B24640", VA = "0x183B25840", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x363AD50", Offset = "0x3639B50", VA = "0x18363AD50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static readonly AIALJCPOHHL<OEJJCKBACCI> ELGIAAPILDL;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static readonly AIALJCPOHHL<List<FNKGPBLCNLM>> IKKKMCGNAKP;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static int IFPIGJGLBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	internal readonly Dictionary<TClaimant, TNode> OEBICOMDLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	internal readonly Dictionary<TNode, OEJJCKBACCI> PMIHDNLCDIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private BDNCEGEKLHA DEFFIHPLIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private bool OFJKLDDBIOI;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode DBIPMIJHFHH(TNode NBFOPMANPGI);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void MNLDCFMODOB(TNode NBFOPMANPGI, TClaimant NHHEDLDMFBK, TClaimant FHMOBKODMJF);

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x3A7DDF0", Offset = "0x3A7CBF0", VA = "0x183A7DDF0")]
	public JOADLFAGCJH(BDNCEGEKLHA DEFFIHPLIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x3A7DBA0", Offset = "0x3A7C9A0", VA = "0x183A7DBA0")]
	public void PMGLKAAKBMB(TNode NBFOPMANPGI, TNode EIECDKIPGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3A7CDA0", Offset = "0x3A7BBA0", VA = "0x183A7CDA0")]
	public void IOMFPIAAKEB(TClaimant NJFAJNGHOBB, TNode NHPOBCPJINB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3A7C980", Offset = "0x3A7B780", VA = "0x183A7C980", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3A7DB00", Offset = "0x3A7C900", VA = "0x183A7DB00")]
	private void NPEPNONFCNI(TClaimant NJFAJNGHOBB, TNode JGAJBDJKOPG, TNode NHPOBCPJINB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3A7C910", Offset = "0x3A7B710", VA = "0x183A7C910")]
	private int DDJGBMOBFDP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3A7D5C0", Offset = "0x3A7C3C0", VA = "0x183A7D5C0")]
	private void NDNOOHHBMPF(TClaimant NJFAJNGHOBB, TNode DGNFIIBDJJJ, TNode BOCPDIPOGHC, int FFBEDCDMDBK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3A7D310", Offset = "0x3A7C110", VA = "0x183A7D310")]
	private void LCDDBIICIGE(FNKGPBLCNLM DNEHPHJGLFC, OEJJCKBACCI IMFOFMLKKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3A7CEC0", Offset = "0x3A7BCC0", VA = "0x183A7CEC0")]
	private void JIIDJICPHJE(TClaimant NJFAJNGHOBB, TNode DGNFIIBDJJJ, TNode BOCPDIPOGHC, int FFBEDCDMDBK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3A7D900", Offset = "0x3A7C700", VA = "0x183A7D900")]
	private void NLLHOIFPINO(FNKGPBLCNLM DNEHPHJGLFC, TNode NBFOPMANPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3A7DA10", Offset = "0x3A7C810", VA = "0x183A7DA10")]
	private void NOHJMHKBJEC(FNKGPBLCNLM DNEHPHJGLFC, OEJJCKBACCI IMFOFMLKKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3A7D490", Offset = "0x3A7C290", VA = "0x183A7D490")]
	private void NBMOHNEKKPO(OEJJCKBACCI IMFOFMLKKCI, bool PNEBILFFDON = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3A7C5D0", Offset = "0x3A7B3D0", VA = "0x183A7C5D0")]
	private void AOIBFIBFBHO(OEJJCKBACCI IMFOFMLKKCI, TNode EIECDKIPGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x3A7CB50", Offset = "0x3A7B950", VA = "0x183A7CB50")]
	[IteratorStateMachine(typeof(JOADLFAGCJH<, >.KJKLGJNMNEN))]
	private IEnumerable<TNode> GJMAHCKEIHK(TNode DGNFIIBDJJJ, TNode BOCPDIPOGHC, bool NEMPLGBAEJD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x3A7D3A0", Offset = "0x3A7C1A0", VA = "0x183A7D3A0")]
	private OEJJCKBACCI LDCLGFJLLAJ(TNode NBFOPMANPGI, TNode FEOGIMKDFKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3A7CC30", Offset = "0x3A7BA30", VA = "0x183A7CC30")]
	private OEJJCKBACCI GMKACOCJGDK(TNode NBFOPMANPGI, TNode FEOGIMKDFKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x3A7D1A0", Offset = "0x3A7BFA0", VA = "0x183A7D1A0")]
	private void JNGNNBFIAJG(OEJJCKBACCI IMFOFMLKKCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class LDJOKJNFDCC<T> : IEnumerable<LDJOKJNFDCC<T>.NNNBOGCLFIG>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct NNNBOGCLFIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public T MAEBFBHFPDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int OHINPGIGDNE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class PBKPAFCAGKP : IEnumerator<NNNBOGCLFIG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private LDJOKJNFDCC<T> HBGDBABKNLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private int OHINPGIGDNE;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x32BF020", Offset = "0x32BDE20", VA = "0x1832BF020", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public NNNBOGCLFIG OGCIBGAMGCC
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x409A170", Offset = "0x4098F70", VA = "0x18409A170", Slot = "4")]
			get
			{
				return default(NNNBOGCLFIG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x409A080", Offset = "0x4098E80", VA = "0x18409A080")]
		public PBKPAFCAGKP(LDJOKJNFDCC<T> HBGDBABKNLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x4099F80", Offset = "0x4098D80", VA = "0x184099F80", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x33128F0", Offset = "0x33116F0", VA = "0x1833128F0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x8547F0", Offset = "0x8535F0", VA = "0x1808547F0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private struct OJKNEMICDFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public bool NOLBKMABMDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public T MAEBFBHFPDE;
	}

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int PCDKLJKMKGA = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly Dictionary<T, int> BKJNOLDAALG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private OJKNEMICDFG[] FLCHDMECALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int BGHDLBFDNOK;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int MJKPCGAHFFC
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7F8A10", Offset = "0x7F7810", VA = "0x1807F8A10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7F8010", Offset = "0x7F6E10", VA = "0x1807F8010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int EDOFPONLMHN
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x30A2EB0", Offset = "0x30A1CB0", VA = "0x1830A2EB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x3BFCB20", Offset = "0x3BFB920", VA = "0x183BFCB20")]
	public LDJOKJNFDCC(int DKDCFCAKJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x3BFC750", Offset = "0x3BFB550", VA = "0x183BFC750")]
	public LDJOKJNFDCC(NNNBOGCLFIG[] EIBELEDKHLP, bool EJHHCDEPEEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3BFBAC0", Offset = "0x3BFA8C0", VA = "0x183BFBAC0")]
	public int DJEHJFKGJML()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3BFC2F0", Offset = "0x3BFB0F0", VA = "0x183BFC2F0")]
	private int MDIOGCAFOJG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x3BFC1C0", Offset = "0x3BFAFC0", VA = "0x183BFC1C0", Slot = "6")]
	protected virtual uint JCCIALJOLPF(uint EJDCHNKDADM, T MAEBFBHFPDE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x3BFBB50", Offset = "0x3BFA950", VA = "0x183BFBB50")]
	public bool FFPNJMDONLA(T MAEBFBHFPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x3BFC220", Offset = "0x3BFB020", VA = "0x183BFC220")]
	public int LHAHKJCFIHN(T MAEBFBHFPDE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x3BFBBF0", Offset = "0x3BFA9F0", VA = "0x183BFBBF0")]
	public T HLOGNNOGMID(int OHINPGIGDNE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x3BFBF60", Offset = "0x3BFAD60", VA = "0x183BFBF60")]
	public bool IJLDICBJDCE(T MAEBFBHFPDE, bool OAHCDFEAALH = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x3BFBFB0", Offset = "0x3BFADB0", VA = "0x183BFBFB0")]
	public bool IJLDICBJDCE(T MAEBFBHFPDE, int OHINPGIGDNE, bool OAHCDFEAALH = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x3BFBA20", Offset = "0x3BFA820", VA = "0x183BFBA20")]
	private int ADJHJKFPPFB(int NIAPLMNAGEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x3BFC6D0", Offset = "0x3BFB4D0", VA = "0x183BFC6D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x3BFC6D0", Offset = "0x3BFB4D0", VA = "0x183BFC6D0", Slot = "4")]
	private IEnumerator<NNNBOGCLFIG> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class AIALJCPOHHL<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly Stack<T> INLACKOOBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private readonly List<T> PHJIKFIHCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly int MCFNGIBJGMC;

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x38C0420", Offset = "0x38BF220", VA = "0x1838C0420")]
	public static AIALJCPOHHL<T> FLEGFOPNIPJ(int DKDCFCAKJAJ = 0, int MCFNGIBJGMC = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x38C0780", Offset = "0x38BF580", VA = "0x1838C0780")]
	public static AIALJCPOHHL<T> JGLFAINMGHI(int DKDCFCAKJAJ = 0, int MCFNGIBJGMC = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x38C0BB0", Offset = "0x38BF9B0", VA = "0x1838C0BB0")]
	public AIALJCPOHHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x38C0BE0", Offset = "0x38BF9E0", VA = "0x1838C0BE0")]
	public AIALJCPOHHL(int DKDCFCAKJAJ, int MCFNGIBJGMC = int.MaxValue, bool GIDKIEBIPCL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x38C0950", Offset = "0x38BF750", VA = "0x1838C0950")]
	public T LAJIGFCCLBO()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x38C0880", Offset = "0x38BF680", VA = "0x1838C0880")]
	public void KKLNFJEOADM(T MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x38C0AD0", Offset = "0x38BF8D0", VA = "0x1838C0AD0")]
	private void NNDGJAKJLJD(T MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x38C0860", Offset = "0x38BF660", VA = "0x1838C0860")]
	private void KGPONMCCBML(T MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x38C02E0", Offset = "0x38BF0E0", VA = "0x1838C02E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x38C0500", Offset = "0x38BF300", VA = "0x1838C0500")]
	private void INGADBCHAPG(IEnumerable<T> NPCOHMLDIGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class IFOEHGFMDFK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private Dictionary<int, T> GLAIHHBGMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private T GDMDLGHKKHH;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual T FGMCPODIAHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F50", Offset = "0x7B7D50", VA = "0x1807B8F50", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x38793D0", Offset = "0x38781D0", VA = "0x1838793D0")]
	public bool KAIAEIFBMCN(T MAEBFBHFPDE, int IAOKDNOLMMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x3878F10", Offset = "0x3877D10", VA = "0x183878F10")]
	public bool FFEMLCJDOBK(int IAOKDNOLMMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x3878F80", Offset = "0x3877D80", VA = "0x183878F80")]
	public T JGDLPIGNHIH(int HHFEFINEEAE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x3879560", Offset = "0x3878360", VA = "0x183879560")]
	private bool MIDMMOGIFPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x3878EC0", Offset = "0x3877CC0", VA = "0x183878EC0")]
	public bool EMHKBCLCPNM(int IAOKDNOLMMH, [Out] T MAEBFBHFPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x3879600", Offset = "0x3878400", VA = "0x183879600")]
	public IFOEHGFMDFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class EBEEELFBOPO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	protected struct BHLIMIKHMNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public T CIONEDGAKHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int MBIEGDMAKFO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	protected readonly List<BHLIMIKHMNI> MGEIFNHNIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private T LOMFDCMKALP;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int EDOFPONLMHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x30A2EB0", Offset = "0x30A1CB0", VA = "0x1830A2EB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x32930F0", Offset = "0x3291EF0", VA = "0x1832930F0")]
	public bool ADCHJIHGBAF(T MAEBFBHFPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x3293440", Offset = "0x3292240", VA = "0x183293440")]
	public void GALNLGNAACN(T MAEBFBHFPDE, int IAOKDNOLMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x32932F0", Offset = "0x32920F0", VA = "0x1832932F0")]
	public bool FIJOKOAGLFM(T MAEBFBHFPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x3293640", Offset = "0x3292440", VA = "0x183293640")]
	public void OCIHDBDLDKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x3293270", Offset = "0x3292070", VA = "0x183293270")]
	public T DAGFMHLPPOC()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x32934E0", Offset = "0x32922E0", VA = "0x1832934E0")]
	private void MMOHALLPGKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x32936A0", Offset = "0x32924A0", VA = "0x1832936A0")]
	public EBEEELFBOPO()
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
		[LNDIHOOGFKF(HLOGMCICCDP.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x60B6190", Offset = "0x60B4F90", VA = "0x1860B6190")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x60B6460", Offset = "0x60B5260", VA = "0x1860B6460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x60B6370", Offset = "0x60B5170", VA = "0x1860B6370")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x60B60E0", Offset = "0x60B4EE0", VA = "0x1860B60E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x60B63B0", Offset = "0x60B51B0", VA = "0x1860B63B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x60B62C0", Offset = "0x60B50C0", VA = "0x1860B62C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x60B6050", Offset = "0x60B4E50", VA = "0x1860B6050")]
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
		[Cpp2IlInjected.Address(RVA = "0x429ED00", Offset = "0x429DB00", VA = "0x18429ED00", Slot = "4")]
		public virtual T CPFONGDIEFM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class NLLMAPLLCLE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly Dictionary<byte, JNHGGIBOLDM> HNDOAGJAOOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly AIALJCPOHHL<JNHGGIBOLDM> PCKNMNOPGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly bool KBPCFPLBDJD;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public JNHGGIBOLDM EFGEFIEHCJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x7B8400", Offset = "0x7B7200", VA = "0x1807B8400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7B8190", Offset = "0x7B6F90", VA = "0x1807B8190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public Vector2 DHBPOBAPKLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xB8CA30", Offset = "0xB8B830", VA = "0x180B8CA30")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xE6BFA0", Offset = "0xE6ADA0", VA = "0x180E6BFA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private Vector2 MKLNIMLFGDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xEBE830", Offset = "0xEBD630", VA = "0x180EBE830")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public Vector2 KJLOEPOEOJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x60B5BA0", Offset = "0x60B49A0", VA = "0x1860B5BA0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x7BEA80", Offset = "0x7BD880", VA = "0x1807BEA80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public int NLLLMJNGGMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x7B8950", Offset = "0x7B7750", VA = "0x1807B8950")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x7B8B50", Offset = "0x7B7950", VA = "0x1807B8B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x60B5BC0", Offset = "0x60B49C0", VA = "0x1860B5BC0")]
	public NLLMAPLLCLE(Bounds LCPGKMLNDBN, Vector2[] MFBMAEMFODI, int EFOAAPNJDAD, byte NIAPLMNAGEM, float CFFAIIFILHG = 0f, [Optional] AIALJCPOHHL<JNHGGIBOLDM> PCKNMNOPGNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x60B50F0", Offset = "0x60B3EF0", VA = "0x1860B50F0")]
	public JNHGGIBOLDM BKAMHPKOADM(byte OHINPGIGDNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x60B56B0", Offset = "0x60B44B0", VA = "0x1860B56B0")]
	public void IHICLHJMDBC(Vector3 AJFNKFFNDBD, float FDLPBFGBNDI, float PKCILADKEJH, List<byte> KHNGPIFFHGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5DA5FB0", Offset = "0x5DA4DB0", VA = "0x185DA5FB0")]
	public void HLDLELNDDJN(JNHGGIBOLDM.OCKAMACPAAG EFHBMHKBOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x60B5150", Offset = "0x60B3F50", VA = "0x1860B5150")]
	public static int DKBMCPMMDMI(Vector2[] MFBMAEMFODI, int EFOAAPNJDAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x60B59A0", Offset = "0x60B47A0", VA = "0x1860B59A0")]
	private JNHGGIBOLDM MLIKPAKGIIH(byte OHINPGIGDNE, JNHGGIBOLDM.OJEKJLMCKEF LCDDGPGNLOL, JNHGGIBOLDM FEOGIMKDFKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x60B52A0", Offset = "0x60B40A0", VA = "0x1860B52A0")]
	private void ELKKMNCNDEN(JNHGGIBOLDM FEOGIMKDFKL, Vector2[] MFBMAEMFODI, int CAOGADDBOLL, int FOMOKJCEMHP, int FOODNLGLJIH, int CMIMODDAGCH, float CFFAIIFILHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x60B5780", Offset = "0x60B4580", VA = "0x1860B5780")]
	private void LAICMPDPLKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x60B5240", Offset = "0x60B4040", VA = "0x1860B5240", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x60B5650", Offset = "0x60B4450", VA = "0x1860B5650", Slot = "1")]
	~NLLMAPLLCLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class JNHGGIBOLDM
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public enum OJEKJLMCKEF
	{
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public enum OCKAMACPAAG
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
	public byte KAFEFKNGGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public Vector3 DEONCGKKGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public Vector3 LGOFLDBOEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public Vector3 DPEFFLELCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public Vector3 PACKLINGEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public OJEKJLMCKEF NENFOFMEOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public JNHGGIBOLDM GAHJCNPPPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public List<JNHGGIBOLDM> BAJKBIMFGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public bool DCKAKAKOCEG;

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x60B3CD0", Offset = "0x60B2AD0", VA = "0x1860B3CD0")]
	public JNHGGIBOLDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x60B3AC0", Offset = "0x60B28C0", VA = "0x1860B3AC0")]
	public void JLFICOCDFDA(JNHGGIBOLDM ENAIIHBGJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0")]
	public void HLDLELNDDJN(int HMJBENPDPLD, OCKAMACPAAG EFHBMHKBOJA, int NMCGPAMICED = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x60B3860", Offset = "0x60B2660", VA = "0x1860B3860")]
	public void IHICLHJMDBC(List<byte> KHNGPIFFHGH, Vector3 AJFNKFFNDBD, float FDLPBFGBNDI, float PKCILADKEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x60B3CA0", Offset = "0x60B2AA0", VA = "0x1860B3CA0")]
	public bool LJMDJCEAGBO(Vector3 MNMDECHMAEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x60B3C70", Offset = "0x60B2A70", VA = "0x1860B3C70")]
	public bool KJOLIHKEKNJ(Vector3 MNMDECHMAEG, float ENJIKLDEAJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x60B3BE0", Offset = "0x60B29E0", VA = "0x1860B3BE0")]
	public void KCJBJGBIMAI()
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
		public struct DOKMKOBMJEK<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private readonly List<Component> MOAFNEBEDKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private readonly bool LONOOCMKAAA;

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x378C4E0", Offset = "0x378B2E0", VA = "0x18378C4E0")]
			public DOKMKOBMJEK(List<Component> MOAFNEBEDKD, bool LONOOCMKAAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x504FC40", Offset = "0x504EA40", VA = "0x18504FC40")]
			public BGBBPEIFJGL<T> GGNEAJGHJIC()
			{
				return default(BGBBPEIFJGL<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x504FCB0", Offset = "0x504EAB0", VA = "0x18504FCB0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x504FCB0", Offset = "0x504EAB0", VA = "0x18504FCB0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public struct BGBBPEIFJGL<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private readonly List<Component> MOAFNEBEDKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			private readonly bool LONOOCMKAAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			private int OHINPGIGDNE;

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			public T OGCIBGAMGCC
			{
				[Cpp2IlInjected.Token(Token = "0x60001ED")]
				[Cpp2IlInjected.Address(RVA = "0x47724F0", Offset = "0x47712F0", VA = "0x1847724F0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001EE")]
				[Cpp2IlInjected.Address(RVA = "0x4772480", Offset = "0x4771280", VA = "0x184772480", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x47724C0", Offset = "0x47712C0", VA = "0x1847724C0")]
			public BGBBPEIFJGL(List<Component> MOAFNEBEDKD, bool LONOOCMKAAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x47723C0", Offset = "0x47711C0", VA = "0x1847723C0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x47723D0", Offset = "0x47711D0", VA = "0x1847723D0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x3301DB0", Offset = "0x3300BB0", VA = "0x183301DB0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x60B7A80", Offset = "0x60B6880", VA = "0x1860B7A80")]
		private void KCJBJGBIMAI(GameObject JDOCCOMDNNG, bool CPEDIDFIAIE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x60B78C0", Offset = "0x60B66C0", VA = "0x1860B78C0")]
		public static void KCJBJGBIMAI(GameObject JDOCCOMDNNG, ToolHierarchyCache AJGMHAKKLJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x29E59F0", Offset = "0x29E47F0", VA = "0x1829E59F0")]
		public void OHDHADJDBDF<T>(Action<T> CJMBDOEJJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x29E58C0", Offset = "0x29E46C0", VA = "0x1829E58C0")]
		public T IKAMDLBNOMG<T>(bool LONOOCMKAAA = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x29E5930", Offset = "0x29E4730", VA = "0x1829E5930")]
		public DOKMKOBMJEK<T> LOICNDCHLKJ<T>(bool LONOOCMKAAA = false) where T : class
		{
			return default(DOKMKOBMJEK<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x60B7BF0", Offset = "0x60B69F0", VA = "0x1860B7BF0")]
		public List<Component> OMHMLNFDOGM(Type LPFFKBBBCBL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x60B77D0", Offset = "0x60B65D0", VA = "0x1860B77D0", Slot = "4")]
		public bool Equals(ToolHierarchyCache BJKAJHEJDMP, ToolHierarchyCache FPNMMAJHCIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x60B7850", Offset = "0x60B6650", VA = "0x1860B7850", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache KDHDNCADFDJ)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class GHFMDCHBJFF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private int DKDCFCAKJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int AJJMMKJGINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private List<T> CFHMGHCOIDN;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int EDOFPONLMHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x35EC230", Offset = "0x35EB030", VA = "0x1835EC230")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public T JNLGPAPFKNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3700490", Offset = "0x36FF290", VA = "0x183700490")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public T BADLDFJMING
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3700230", Offset = "0x36FF030", VA = "0x183700230")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public T FJIHDBPFIGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3700360", Offset = "0x36FF160", VA = "0x183700360")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x37008C0", Offset = "0x36FF6C0", VA = "0x1837008C0")]
	public GHFMDCHBJFF(int DKDCFCAKJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x3700550", Offset = "0x36FF350", VA = "0x183700550")]
	public void GALNLGNAACN(T FBFBBPBLKNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x3700880", Offset = "0x36FF680", VA = "0x183700880")]
	public void OCIHDBDLDKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x37007A0", Offset = "0x36FF5A0", VA = "0x1837007A0")]
	public void KBNGGMKCHGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x3700740", Offset = "0x36FF540", VA = "0x183700740")]
	public void IEBEFHPCODG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x3700870", Offset = "0x36FF670", VA = "0x183700870")]
	public void NIJGMIJGGNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class ENJDMNBAMCK<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	private struct PBNJHDEOJGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public int MBIEGDMAKFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public T CIONEDGAKHL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly Dictionary<object, PBNJHDEOJGO> GLAIHHBGMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly EqualityComparer<T> DDDBFFMBGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private T GDMDLGHKKHH;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public virtual T FGMCPODIAHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x104C300", Offset = "0x104B100", VA = "0x18104C300", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x32B82F0", Offset = "0x32B70F0", VA = "0x1832B82F0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool BGPNPDHMLAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x32B8230", Offset = "0x32B7030", VA = "0x1832B8230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public object DOFDBLCDMKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x7BE940", Offset = "0x7BD740", VA = "0x1807BE940")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x7C24E0", Offset = "0x7C12E0", VA = "0x1807C24E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x32B5760", Offset = "0x32B4560", VA = "0x1832B5760")]
	public bool KAIAEIFBMCN(T MAEBFBHFPDE, object BNAJMHPOOCG, int IAOKDNOLMMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x32B4DF0", Offset = "0x32B3BF0", VA = "0x1832B4DF0")]
	public bool FFEMLCJDOBK(object BNAJMHPOOCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x32B4B00", Offset = "0x32B3900", VA = "0x1832B4B00")]
	public bool EMHKBCLCPNM(object BNAJMHPOOCG, [Out] T MAEBFBHFPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x32B8280", Offset = "0x32B7080", VA = "0x1832B8280")]
	public void OCIHDBDLDKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x32B76A0", Offset = "0x32B64A0", VA = "0x1832B76A0")]
	private bool MIDMMOGIFPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x32B83A0", Offset = "0x32B71A0", VA = "0x1832B83A0")]
	public ENJDMNBAMCK()
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
