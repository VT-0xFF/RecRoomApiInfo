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
using Mono.Math;
using Unity.Collections;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class GAKJMFGPIDP : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8AB4B0", Offset = "0x8AA2B0", VA = "0x1808AB4B0")]
	public GAKJMFGPIDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, MDKBNPDLGEB, NJEKPDLCGCA, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7011D0", Offset = "0x6FFFD0", VA = "0x1807011D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D30", Offset = "0x6C4B30", VA = "0x1806C5D30", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6FAD80", Offset = "0x6F9B80", VA = "0x1806FAD80", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x743E70", Offset = "0x742C70", VA = "0x180743E70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash JJOJGACMMLF);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x71DC30", Offset = "0x71CA30", VA = "0x18071DC30")]
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
	[IJIDCCGIGGL]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[IJIDCCGIGGL]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1FE8480", Offset = "0x1FE7280", VA = "0x181FE8480")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1FE8440", Offset = "0x1FE7240", VA = "0x181FE8440")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1FE84C0", Offset = "0x1FE72C0", VA = "0x181FE84C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1FE8690", Offset = "0x1FE7490", VA = "0x181FE8690")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1FE8600", Offset = "0x1FE7400", VA = "0x181FE8600")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6E4180", Offset = "0x6E2F80", VA = "0x1806E4180")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8D8D90", Offset = "0x8D7B90", VA = "0x1808D8D90")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1FE8400", Offset = "0x1FE7200", VA = "0x181FE8400")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1FE8570", Offset = "0x1FE7370", VA = "0x181FE8570")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1FE7E40", Offset = "0x1FE6C40", VA = "0x181FE7E40")]
	public void CopyBounds(SavedExtents BNIMMCIKNIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8360", Offset = "0x1FE7160", VA = "0x181FE8360")]
	public void SetLocalSpaceBounds(Bounds BGJIEBMPILJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0xDEFE10", Offset = "0xDEEC10", VA = "0x180DEFE10")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8160", Offset = "0x1FE6F60", VA = "0x181FE8160")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8170", Offset = "0x1FE6F70", VA = "0x181FE8170")]
	private void PAJJCKMBDPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1FE7F30", Offset = "0x1FE6D30", VA = "0x181FE7F30")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1FE7800", Offset = "0x1FE6600", VA = "0x181FE7800")]
	public static void CalculateLocalBoundsFor(GameObject NGIKODIIBGN, out Bounds BGJIEBMPILJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1FE7E70", Offset = "0x1FE6C70", VA = "0x181FE7E70")]
	private static void DJKIFLGALMF(Bounds BFLEMGIJKLG, Color LIHKCCBKPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8380", Offset = "0x1FE7180", VA = "0x181FE8380")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BF380", Offset = "0x6BE180", VA = "0x1806BF380")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x85DB50", Offset = "0x85C950", VA = "0x18085DB50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xCED7F0", Offset = "0xCEC5F0", VA = "0x180CED7F0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1703C20", Offset = "0x1702A20", VA = "0x181703C20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "4")]
	public virtual void BJGAGJNJDOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x22E6440", Offset = "0x22E5240", VA = "0x1822E6440")]
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
	[GAKJMFGPIDP]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3C846C0", Offset = "0x3C834C0", VA = "0x183C846C0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3C83DF0", Offset = "0x3C82BF0", VA = "0x183C83DF0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3C84C00", Offset = "0x3C83A00", VA = "0x183C84C00")]
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
	private sealed class IPJHDLHBKJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x22E6440", Offset = "0x22E5240", VA = "0x1822E6440")]
		public IPJHDLHBKJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x37444D0", Offset = "0x37432D0", VA = "0x1837444D0")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[GAKJMFGPIDP]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x22EA330", Offset = "0x22E9130", VA = "0x1822EA330", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x22EA360", Offset = "0x22E9160", VA = "0x1822EA360", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x22EA280", Offset = "0x22E9080", VA = "0x1822EA280", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public TVal this[TKey CKMEBFKEHMO]
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x22EA2B0", Offset = "0x22E90B0", VA = "0x1822EA2B0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x22EA180", Offset = "0x22E8F80", VA = "0x1822EA180", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x22E9B00", Offset = "0x22E8900", VA = "0x1822E9B00", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x22E91D0", Offset = "0x22E7FD0", VA = "0x1822E91D0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x22E90B0", Offset = "0x22E7EB0", VA = "0x1822E90B0", Slot = "14")]
	protected virtual string DBIKJKCGIMP(TKeyVal MHLMHGCLNCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x22E9080", Offset = "0x22E7E80", VA = "0x1822E9080", Slot = "4")]
	public bool ContainsKey(TKey CKMEBFKEHMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x22EA070", Offset = "0x22E8E70", VA = "0x1822EA070", Slot = "5")]
	public bool TryGetValue(TKey CKMEBFKEHMO, out TVal DPJGMDFEIDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x22E9140", Offset = "0x22E7F40", VA = "0x1822E9140", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x22E9140", Offset = "0x22E7F40", VA = "0x1822E9140", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x22EA0A0", Offset = "0x22E8EA0", VA = "0x1822EA0A0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class JDDBPMEFINA<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class NHJLPDFNIMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x22E6440", Offset = "0x22E5240", VA = "0x1822E6440")]
		public NHJLPDFNIMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x39576B0", Offset = "0x39564B0", VA = "0x1839576B0")]
		internal bool <GetSamples>b__0(global::OHHCNGJEHGJ<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float OBGBJEAIPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float LJMLBCDABKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<global::OHHCNGJEHGJ<float, T>> GKBJCCFCCLJ;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int CBCGNNJAMJO
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3AF5AB0", Offset = "0x3AF48B0", VA = "0x183AF5AB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3AF65C0", Offset = "0x3AF53C0", VA = "0x183AF65C0")]
	public JDDBPMEFINA(float DECAGGHPHBI, float OKKKOBMMJGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3AF6460", Offset = "0x3AF5260", VA = "0x183AF6460")]
	public bool MFIAKPJPEDA(float CAKJEKBKLMM, T DPJGMDFEIDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3AF5B30", Offset = "0x3AF4930", VA = "0x183AF5B30")]
	public int FEMJIADFGMO(float CAKJEKBKLMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3AF5B90", Offset = "0x3AF4990", VA = "0x183AF5B90")]
	public IEnumerable<T> FJDAGDCELMG(float CAKJEKBKLMM, [Optional] float? CGMODFCHHNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3AF62D0", Offset = "0x3AF50D0", VA = "0x183AF62D0")]
	public void KJHAHNAAJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3AF6210", Offset = "0x3AF5010", VA = "0x183AF6210")]
	private void FPNGECKCJEI(float CAKJEKBKLMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class IDKFJJKAMGC<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct AEGOOACIIKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T MHMGLCIOEKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float DAPGBPEHCEA;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float BAKJIBPNMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> EJDMOMPOLGE;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int PDLHGOKJPLN = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private AEGOOACIIKF[] HDCHHDPICKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int AMLDGDNPBHP;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float DAFFBLNIPAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xCED060", Offset = "0xCEBE60", VA = "0x180CED060")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xCED0E0", Offset = "0xCEBEE0", VA = "0x180CED0E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2C08630", Offset = "0x2C07430", VA = "0x182C08630")]
	public IDKFJJKAMGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2C08550", Offset = "0x2C07350", VA = "0x182C08550")]
	public IDKFJJKAMGC(int LCJMNMLOPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2C07AB0", Offset = "0x2C068B0", VA = "0x182C07AB0")]
	public void EKGLGHAFJEH(float CAKJEKBKLMM, T DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2C08110", Offset = "0x2C06F10", VA = "0x182C08110")]
	public void KJHAHNAAJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2C07520", Offset = "0x2C06320", VA = "0x182C07520")]
	public bool AKPFNKEBNKB(float GIHCFFJEGLH, float IGNADPKFIIF, out T DPJGMDFEIDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2C07200", Offset = "0x2C06000", VA = "0x182C07200")]
	public bool AIPCLAEDIHB(float GIHCFFJEGLH, float IGNADPKFIIF, out T DPJGMDFEIDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2C07FF0", Offset = "0x2C06DF0", VA = "0x182C07FF0")]
	public void JLJEGKKJMPH(float GIHCFFJEGLH, float IGNADPKFIIF, List<T> NGFFBKNAABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2C07D30", Offset = "0x2C06B30", VA = "0x182C07D30")]
	private int GEJPCBOKOCP(int CKFKKNKBBJN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2C07D60", Offset = "0x2C06B60", VA = "0x182C07D60")]
	private void IONPPBHLBBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T FJJAHGHOCIB();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T GDBMKBBOOOJ(T KGHGGFICJIM, T KEDFPGEDLPI, float DKOBICODCGH);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T NPHINNAECKP(T DPJGMDFEIDL, float DKOBICODCGH);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T IMNMECPJOEN(T KGHGGFICJIM, T KEDFPGEDLPI);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T DGJBMFOFJNK(T KGHGGFICJIM, T KEDFPGEDLPI);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class LAHILHPHJFO : global::IDKFJJKAMGC<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7A5980", Offset = "0x7A4780", VA = "0x1807A5980", Slot = "4")]
	protected override Vector3 FJJAHGHOCIB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1FE2A50", Offset = "0x1FE1850", VA = "0x181FE2A50", Slot = "5")]
	protected override Vector3 GDBMKBBOOOJ(Vector3 KGHGGFICJIM, Vector3 KEDFPGEDLPI, float DKOBICODCGH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1FE2BE0", Offset = "0x1FE19E0", VA = "0x181FE2BE0", Slot = "6")]
	protected override Vector3 NPHINNAECKP(Vector3 DPJGMDFEIDL, float DKOBICODCGH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1FE2B60", Offset = "0x1FE1960", VA = "0x181FE2B60", Slot = "7")]
	protected override Vector3 IMNMECPJOEN(Vector3 KGHGGFICJIM, Vector3 KEDFPGEDLPI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1FE29E0", Offset = "0x1FE17E0", VA = "0x181FE29E0", Slot = "8")]
	protected override Vector3 DGJBMFOFJNK(Vector3 KGHGGFICJIM, Vector3 KEDFPGEDLPI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1FE2C40", Offset = "0x1FE1A40", VA = "0x181FE2C40")]
	public LAHILHPHJFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class LOBHJIBOFHD : global::IDKFJJKAMGC<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3F80", Offset = "0x1FE2D80", VA = "0x181FE3F80")]
	public LOBHJIBOFHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3F10", Offset = "0x1FE2D10", VA = "0x181FE3F10")]
	public LOBHJIBOFHD(int LCJMNMLOPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xBCC170", Offset = "0xBCAF70", VA = "0x180BCC170", Slot = "4")]
	protected override float FJJAHGHOCIB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0xCCDEA0", Offset = "0xCCCCA0", VA = "0x180CCDEA0", Slot = "5")]
	protected override float GDBMKBBOOOJ(float KGHGGFICJIM, float KEDFPGEDLPI, float DKOBICODCGH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1AE88B0", Offset = "0x1AE76B0", VA = "0x181AE88B0", Slot = "6")]
	protected override float NPHINNAECKP(float DPJGMDFEIDL, float DKOBICODCGH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3F00", Offset = "0x1FE2D00", VA = "0x181FE3F00", Slot = "7")]
	protected override float IMNMECPJOEN(float KGHGGFICJIM, float KEDFPGEDLPI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3EF0", Offset = "0x1FE2CF0", VA = "0x181FE3EF0", Slot = "8")]
	protected override float DGJBMFOFJNK(float KGHGGFICJIM, float KEDFPGEDLPI)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class FEAABJLCIPH
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3666DD0", Offset = "0x3665BD0", VA = "0x183666DD0")]
	public static global::OOHICMPGCPM<T1> DIMOBFAICBM<T1>(T1 FKHNPDMBFNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3A56D10", Offset = "0x3A55B10", VA = "0x183A56D10")]
	public static global::OHHCNGJEHGJ<T1, T2> DIMOBFAICBM<T1, T2>(T1 FKHNPDMBFNL, T2 OGKGNMBNLJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3A56D80", Offset = "0x3A55B80", VA = "0x183A56D80")]
	public static global::KMJJAHFGLGD<T1, T2, T3> DIMOBFAICBM<T1, T2, T3>(T1 FKHNPDMBFNL, T2 OGKGNMBNLJG, T3 GFPFGIEKNCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3662FC0", Offset = "0x3661DC0", VA = "0x183662FC0")]
	public static global::HPHEGKMOCPG<T1, T2, T3, T4> DIMOBFAICBM<T1, T2, T3, T4>(T1 FKHNPDMBFNL, T2 OGKGNMBNLJG, T3 GFPFGIEKNCL, T4 AJHMAFEJJAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3A57050", Offset = "0x3A55E50", VA = "0x183A57050")]
	public static global::PBFLOPEHPBN<T1, T2, T3, T4, T5> DIMOBFAICBM<T1, T2, T3, T4, T5>(T1 FKHNPDMBFNL, T2 OGKGNMBNLJG, T3 GFPFGIEKNCL, T4 AJHMAFEJJAD, T5 FJKAIBNFJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3A56FA0", Offset = "0x3A55DA0", VA = "0x183A56FA0")]
	public static global::JMBFHCFBIAA<T1, T2, T3, T4, T5, T6> DIMOBFAICBM<T1, T2, T3, T4, T5, T6>(T1 FKHNPDMBFNL, T2 OGKGNMBNLJG, T3 GFPFGIEKNCL, T4 AJHMAFEJJAD, T5 FJKAIBNFJFE, T6 MGMFPLJAHOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3A56EE0", Offset = "0x3A55CE0", VA = "0x183A56EE0")]
	public static global::ANJFMLDLPBM<T1, T2, T3, T4, T5, T6, T7> DIMOBFAICBM<T1, T2, T3, T4, T5, T6, T7>(T1 FKHNPDMBFNL, T2 OGKGNMBNLJG, T3 GFPFGIEKNCL, T4 AJHMAFEJJAD, T5 FJKAIBNFJFE, T6 MGMFPLJAHOH, T7 JCFLPFFMGFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3A56E10", Offset = "0x3A55C10", VA = "0x183A56E10")]
	public static global::OENKLLJEOOF<T1, T2, T3, T4, T5, T6, T7, T8> DIMOBFAICBM<T1, T2, T3, T4, T5, T6, T7, T8>(T1 FKHNPDMBFNL, T2 OGKGNMBNLJG, T3 GFPFGIEKNCL, T4 AJHMAFEJJAD, T5 FJKAIBNFJFE, T6 MGMFPLJAHOH, T7 JCFLPFFMGFN, T8 FIAKGEFBLIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2F6F960", Offset = "0x2F6E760", VA = "0x182F6F960")]
	[IteratorStateMachine(typeof(IJEMOPIOLOB))]
	public static IEnumerable<global::OHHCNGJEHGJ<T1, T2>> IHIFFGDGPKI<T1, T2>(IEnumerable<T1> EFBCPNIKEHB, IEnumerable<T2> BFLEMGIJKLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2F6FB40", Offset = "0x2F6E940", VA = "0x182F6FB40")]
	[IteratorStateMachine(typeof(IEJKFMMIAGC))]
	public static IEnumerable<global::KMJJAHFGLGD<T1, T2, T3>> IHIFFGDGPKI<T1, T2, T3>(IEnumerable<T1> EFBCPNIKEHB, IEnumerable<T2> BFLEMGIJKLG, IEnumerable<T3> LIHKCCBKPDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x10A0B00", Offset = "0x109F900", VA = "0x1810A0B00")]
	internal static int LIDGDGHPNHB(int IHKGGEBLOIC, int MLDDHEJJLMK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x10A0AF0", Offset = "0x109F8F0", VA = "0x1810A0AF0")]
	internal static int LIDGDGHPNHB(int IHKGGEBLOIC, int MLDDHEJJLMK, int NFKIILMMANB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x10A0AD0", Offset = "0x109F8D0", VA = "0x1810A0AD0")]
	internal static int LIDGDGHPNHB(int IHKGGEBLOIC, int MLDDHEJJLMK, int NFKIILMMANB, int DGJCFOGIEFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1FE1A10", Offset = "0x1FE0810", VA = "0x181FE1A10")]
	internal static int LIDGDGHPNHB(int IHKGGEBLOIC, int MLDDHEJJLMK, int NFKIILMMANB, int DGJCFOGIEFB, int EAMMFLAFONA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1FE19F0", Offset = "0x1FE07F0", VA = "0x181FE19F0")]
	internal static int LIDGDGHPNHB(int IHKGGEBLOIC, int MLDDHEJJLMK, int NFKIILMMANB, int DGJCFOGIEFB, int EAMMFLAFONA, int GOKBIADBCAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1FE1990", Offset = "0x1FE0790", VA = "0x181FE1990")]
	internal static int LIDGDGHPNHB(int IHKGGEBLOIC, int MLDDHEJJLMK, int NFKIILMMANB, int DGJCFOGIEFB, int EAMMFLAFONA, int GOKBIADBCAG, int MIOAHJPFINF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1FE19C0", Offset = "0x1FE07C0", VA = "0x181FE19C0")]
	internal static int LIDGDGHPNHB(int IHKGGEBLOIC, int MLDDHEJJLMK, int NFKIILMMANB, int DGJCFOGIEFB, int EAMMFLAFONA, int GOKBIADBCAG, int MIOAHJPFINF, int OLLLOFBOOJL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class OOHICMPGCPM<T1> : IComparable<global::OOHICMPGCPM<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T1 DDJIAPGPEEI;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2C161E0", Offset = "0x2C14FE0", VA = "0x182C161E0")]
	public OOHICMPGCPM(T1 FKHNPDMBFNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x326D400", Offset = "0x326C200", VA = "0x18326D400", Slot = "4")]
	public int CompareTo(global::OOHICMPGCPM<T1> BNIMMCIKNIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x326D470", Offset = "0x326C270", VA = "0x18326D470", Slot = "0")]
	public override bool Equals(object BNIMMCIKNIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x9C77B0", Offset = "0x9C65B0", VA = "0x1809C77B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x326D510", Offset = "0x326C310", VA = "0x18326D510", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class OHHCNGJEHGJ<T1, T2> : IComparable<global::OHHCNGJEHGJ<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 DDJIAPGPEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 KCFFLFJAIAC;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x39FA4E0", Offset = "0x39F92E0", VA = "0x1839FA4E0")]
	public OHHCNGJEHGJ(T1 FKHNPDMBFNL, T2 OGKGNMBNLJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x43ED8F0", Offset = "0x43EC6F0", VA = "0x1843ED8F0", Slot = "4")]
	public int CompareTo(global::OHHCNGJEHGJ<T1, T2> BNIMMCIKNIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x43EDB30", Offset = "0x43EC930", VA = "0x1843EDB30", Slot = "0")]
	public override bool Equals(object BNIMMCIKNIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x43EE460", Offset = "0x43ED260", VA = "0x1843EE460", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x43EEF60", Offset = "0x43EDD60", VA = "0x1843EEF60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class KMJJAHFGLGD<T1, T2, T3> : IComparable<global::KMJJAHFGLGD<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T1 DDJIAPGPEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T2 KCFFLFJAIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T3 LIGHAHONKNA;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4374D60", Offset = "0x4373B60", VA = "0x184374D60")]
	public KMJJAHFGLGD(T1 FKHNPDMBFNL, T2 OGKGNMBNLJG, T3 GFPFGIEKNCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4374650", Offset = "0x4373450", VA = "0x184374650", Slot = "4")]
	public int CompareTo(global::KMJJAHFGLGD<T1, T2, T3> BNIMMCIKNIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4374750", Offset = "0x4373550", VA = "0x184374750", Slot = "0")]
	public override bool Equals(object BNIMMCIKNIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4374A40", Offset = "0x4373840", VA = "0x184374A40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4374AA0", Offset = "0x43738A0", VA = "0x184374AA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class HPHEGKMOCPG<T1, T2, T3, T4> : IComparable<global::HPHEGKMOCPG<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T1 DDJIAPGPEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T2 KCFFLFJAIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T3 LIGHAHONKNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T4 NJAKALIAOFL;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x36D6380", Offset = "0x36D5180", VA = "0x1836D6380")]
	public HPHEGKMOCPG(T1 FKHNPDMBFNL, T2 OGKGNMBNLJG, T3 GFPFGIEKNCL, T4 AJHMAFEJJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3949320", Offset = "0x3948120", VA = "0x183949320", Slot = "4")]
	public int CompareTo(global::HPHEGKMOCPG<T1, T2, T3, T4> BNIMMCIKNIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3949460", Offset = "0x3948260", VA = "0x183949460", Slot = "0")]
	public override bool Equals(object BNIMMCIKNIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3949580", Offset = "0x3948380", VA = "0x183949580", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3949640", Offset = "0x3948440", VA = "0x183949640", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class PBFLOPEHPBN<T1, T2, T3, T4, T5> : IComparable<global::PBFLOPEHPBN<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T1 DDJIAPGPEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T2 KCFFLFJAIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T3 LIGHAHONKNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T4 NJAKALIAOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T5 PEMOECHCLPD;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x426E5E0", Offset = "0x426D3E0", VA = "0x18426E5E0")]
	public PBFLOPEHPBN(T1 FKHNPDMBFNL, T2 OGKGNMBNLJG, T3 GFPFGIEKNCL, T4 AJHMAFEJJAD, T5 FJKAIBNFJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x426F900", Offset = "0x426E700", VA = "0x18426F900", Slot = "4")]
	public int CompareTo(global::PBFLOPEHPBN<T1, T2, T3, T4, T5> BNIMMCIKNIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x426FA80", Offset = "0x426E880", VA = "0x18426FA80", Slot = "0")]
	public override bool Equals(object BNIMMCIKNIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x426FBC0", Offset = "0x426E9C0", VA = "0x18426FBC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x426FCC0", Offset = "0x426EAC0", VA = "0x18426FCC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class JMBFHCFBIAA<T1, T2, T3, T4, T5, T6> : IComparable<global::JMBFHCFBIAA<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T1 DDJIAPGPEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T2 KCFFLFJAIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T3 LIGHAHONKNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T4 NJAKALIAOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T5 PEMOECHCLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T6 EGPACOEMIMP;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3700520", Offset = "0x36FF320", VA = "0x183700520")]
	public JMBFHCFBIAA(T1 FKHNPDMBFNL, T2 OGKGNMBNLJG, T3 GFPFGIEKNCL, T4 AJHMAFEJJAD, T5 FJKAIBNFJFE, T6 MGMFPLJAHOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x36FFF60", Offset = "0x36FED60", VA = "0x1836FFF60", Slot = "4")]
	public int CompareTo(global::JMBFHCFBIAA<T1, T2, T3, T4, T5, T6> BNIMMCIKNIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3700120", Offset = "0x36FEF20", VA = "0x183700120", Slot = "0")]
	public override bool Equals(object BNIMMCIKNIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3700290", Offset = "0x36FF090", VA = "0x183700290", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x37003B0", Offset = "0x36FF1B0", VA = "0x1837003B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class ANJFMLDLPBM<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::ANJFMLDLPBM<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T1 DDJIAPGPEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T2 KCFFLFJAIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T3 LIGHAHONKNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T4 NJAKALIAOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T5 PEMOECHCLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T6 EGPACOEMIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T7 OCHPNGPEFIJ;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4D02DF0", Offset = "0x4D01BF0", VA = "0x184D02DF0")]
	public ANJFMLDLPBM(T1 FKHNPDMBFNL, T2 OGKGNMBNLJG, T3 GFPFGIEKNCL, T4 AJHMAFEJJAD, T5 FJKAIBNFJFE, T6 MGMFPLJAHOH, T7 JCFLPFFMGFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4D02770", Offset = "0x4D01570", VA = "0x184D02770", Slot = "4")]
	public int CompareTo(global::ANJFMLDLPBM<T1, T2, T3, T4, T5, T6, T7> BNIMMCIKNIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4D02970", Offset = "0x4D01770", VA = "0x184D02970", Slot = "0")]
	public override bool Equals(object BNIMMCIKNIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4D02B10", Offset = "0x4D01910", VA = "0x184D02B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4D02C60", Offset = "0x4D01A60", VA = "0x184D02C60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class OENKLLJEOOF<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::OENKLLJEOOF<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T1 DDJIAPGPEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T2 KCFFLFJAIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T3 LIGHAHONKNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T4 NJAKALIAOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T5 PEMOECHCLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T6 EGPACOEMIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly T7 OCHPNGPEFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly T8 DKHNGFHAIGI;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x43EA510", Offset = "0x43E9310", VA = "0x1843EA510")]
	public OENKLLJEOOF(T1 FKHNPDMBFNL, T2 OGKGNMBNLJG, T3 GFPFGIEKNCL, T4 AJHMAFEJJAD, T5 FJKAIBNFJFE, T6 MGMFPLJAHOH, T7 JCFLPFFMGFN, T8 FIAKGEFBLIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x43E9DE0", Offset = "0x43E8BE0", VA = "0x1843E9DE0", Slot = "4")]
	public int CompareTo(global::OENKLLJEOOF<T1, T2, T3, T4, T5, T6, T7, T8> BNIMMCIKNIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x43EA030", Offset = "0x43E8E30", VA = "0x1843EA030", Slot = "0")]
	public override bool Equals(object BNIMMCIKNIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x43EA1F0", Offset = "0x43E8FF0", VA = "0x1843EA1F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x43EA360", Offset = "0x43E9160", VA = "0x1843EA360", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T MHMGLCIOEKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x1413650", Offset = "0x1412450", VA = "0x181413650")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x14136E0", Offset = "0x14124E0", VA = "0x1814136E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float ILPMPCMDDBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D60", Offset = "0x6C4B60", VA = "0x1806C5D60")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4B82980", Offset = "0x4B81780", VA = "0x184B82980")]
	public T BGEEAJBDNHM(float DKOBICODCGH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4B82D90", Offset = "0x4B81B90", VA = "0x184B82D90")]
	public T MHIAPOFDLGJ(float DKOBICODCGH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T GDBMKBBOOOJ(T KGHGGFICJIM, T KEDFPGEDLPI, float DKOBICODCGH);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x22E6440", Offset = "0x22E5240", VA = "0x1822E6440")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0xCCDEA0", Offset = "0xCCCCA0", VA = "0x180CCDEA0", Slot = "4")]
	protected override float GDBMKBBOOOJ(float KGHGGFICJIM, float KEDFPGEDLPI, float DKOBICODCGH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x1FE21F0", Offset = "0x1FE0FF0", VA = "0x181FE21F0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1FE2A50", Offset = "0x1FE1850", VA = "0x181FE2A50", Slot = "4")]
	protected override Vector3 GDBMKBBOOOJ(Vector3 KGHGGFICJIM, Vector3 KEDFPGEDLPI, float DKOBICODCGH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1FE9620", Offset = "0x1FE8420", VA = "0x181FE9620")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1FDFB90", Offset = "0x1FDE990", VA = "0x181FDFB90", Slot = "4")]
	protected override Color GDBMKBBOOOJ(Color KGHGGFICJIM, Color KEDFPGEDLPI, float DKOBICODCGH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x1FDFBE0", Offset = "0x1FDE9E0", VA = "0x181FDFBE0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class IPKKEAMLFAF : global::EDAOPEDAGIF<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1FE28D0", Offset = "0x1FE16D0", VA = "0x181FE28D0")]
	public IPKKEAMLFAF(int DOOAOHCDEFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1FE2920", Offset = "0x1FE1720", VA = "0x181FE2920")]
	public IPKKEAMLFAF(NKFFEDOABOO[] DPLLLLMMNEG, bool BEMMIHKAKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1FE2860", Offset = "0x1FE1660", VA = "0x181FE2860", Slot = "6")]
	protected override uint KNNBOCNMLKF(uint JJOJGACMMLF, string DPJGMDFEIDL)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class MENOLEBLAGI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly IDisposable GEHLGJGIEOF;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public MENOLEBLAGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct FJIIHKMKKGE<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class MBMKONEHEPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x22E6440", Offset = "0x22E5240", VA = "0x1822E6440")]
		public MBMKONEHEPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3713410", Offset = "0x3712210", VA = "0x183713410")]
		internal void <StartRequest>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> IBMEOGDAGDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int AIDCILBGOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int POLIHGHGIDK;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0xDE71D0", Offset = "0xDE5FD0", VA = "0x180DE71D0")]
	private FJIIHKMKKGE(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> EIFFBANKFGJ, int OJACCJKIFHE, int HPIKIBFKIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x401A650", Offset = "0x4019450", VA = "0x18401A650")]
	public static global::FJIIHKMKKGE<T> PKGIDMHJGMJ()
	{
		return default(global::FJIIHKMKKGE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x40197F0", Offset = "0x40185F0", VA = "0x1840197F0")]
	public (int, int, Task<T>) KMHMJCMIOMN(int BKKGIODOEGK, [Optional] CancellationToken ONKANLKLEAL, double JNFELLBIBAM = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4018D50", Offset = "0x4017B50", VA = "0x184018D50")]
	public void FENAKBGPCJE(int BKKGIODOEGK, int HPIKIBFKIMD, in T LILKGIPDCFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class DAAECJIFMMG
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1FDFCA0", Offset = "0x1FDEAA0", VA = "0x181FDFCA0")]
	public static global::FJIIHKMKKGE<PDIIEEBMKOH> PKGIDMHJGMJ()
	{
		return default(global::FJIIHKMKKGE<PDIIEEBMKOH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1FDFC20", Offset = "0x1FDEA20", VA = "0x181FDFC20")]
	public static void FENAKBGPCJE(this in global::FJIIHKMKKGE<PDIIEEBMKOH> BIKHFKCJEPO, int BKKGIODOEGK, int HPIKIBFKIMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[DefaultMember("Item")]
public class OECEIHHFKJJ<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Dictionary<TKey, TVal> MIKOINCNGNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Dictionary<TVal, TKey> BODFJAPFBHH;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int EKAGFOMELON
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3346810", Offset = "0x3345610", VA = "0x183346810", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool BJGAENKKDEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6E5BE0", Offset = "0x6E49E0", VA = "0x1806E5BE0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> DICPGCGPFEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x3715AF0", Offset = "0x37148F0", VA = "0x183715AF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> ALLMBMPJNCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x3716360", Offset = "0x3715160", VA = "0x183716360", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal BADELHLICNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x43E9C30", Offset = "0x43E8A30", VA = "0x1843E9C30", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x43E9C70", Offset = "0x43E8A70", VA = "0x1843E9C70", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey BADELHLICNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x43E98F0", Offset = "0x43E86F0", VA = "0x1843E98F0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x43E8F70", Offset = "0x43E7D70", VA = "0x1843E8F70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x43E8AC0", Offset = "0x43E78C0", VA = "0x1843E8AC0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x43E9A60", Offset = "0x43E8860", VA = "0x1843E9A60", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x42DACF0", Offset = "0x42D9AF0", VA = "0x1842DACF0", Slot = "9")]
	public void Add(TKey CKMEBFKEHMO, TVal DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x43E8A80", Offset = "0x43E7880", VA = "0x1843E8A80", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> BKCHCEAGIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x43E8B20", Offset = "0x43E7920", VA = "0x1843E8B20", Slot = "8")]
	public bool ContainsKey(TKey CKMEBFKEHMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x43E8B50", Offset = "0x43E7950", VA = "0x1843E8B50", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> BKCHCEAGIMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x43E99D0", Offset = "0x43E87D0", VA = "0x1843E99D0", Slot = "10")]
	public bool Remove(TKey CKMEBFKEHMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x43E9A30", Offset = "0x43E8830", VA = "0x1843E9A30", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> BKCHCEAGIMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3700F10", Offset = "0x36FFD10", VA = "0x183700F10", Slot = "11")]
	public bool TryGetValue(TKey CKMEBFKEHMO, out TVal DPJGMDFEIDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3FF4A10", Offset = "0x3FF3810", VA = "0x183FF4A10", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x43E8BB0", Offset = "0x43E79B0", VA = "0x1843E8BB0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] HDCHHDPICKJ, int HKFDIPJFPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x43E8D70", Offset = "0x43E7B70", VA = "0x1843E8D70")]
	public void EKGLGHAFJEH(TVal OAFEANCCICI, TKey CKMEBFKEHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x43E8DE0", Offset = "0x43E7BE0", VA = "0x1843E8DE0")]
	public void EKGLGHAFJEH(KeyValuePair<TVal, TKey> BKCHCEAGIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x43E8970", Offset = "0x43E7770", VA = "0x1843E8970")]
	public bool AFNPGADPHIJ(TVal CKMEBFKEHMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x43E8C70", Offset = "0x43E7A70", VA = "0x1843E8C70")]
	public bool DOMBPGEJHPH(KeyValuePair<TVal, TKey> BKCHCEAGIMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x43E9990", Offset = "0x43E8790", VA = "0x1843E9990")]
	public bool PPEAGPDBOCM(TVal CKMEBFKEHMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x43E9990", Offset = "0x43E8790", VA = "0x1843E9990")]
	public bool PPEAGPDBOCM(KeyValuePair<TVal, TKey> BKCHCEAGIMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x43E93D0", Offset = "0x43E81D0", VA = "0x1843E93D0")]
	public bool ICLIDKMCOMO(TVal CKMEBFKEHMO, out TKey DPJGMDFEIDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x43E8EA0", Offset = "0x43E7CA0", VA = "0x1843E8EA0")]
	public IEnumerator<KeyValuePair<TVal, TKey>> FADEGLNFGIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x43E9070", Offset = "0x43E7E70", VA = "0x1843E9070")]
	private void FCPPNFCFNBB(TKey CKMEBFKEHMO, TVal OAFEANCCICI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x43E92A0", Offset = "0x43E80A0", VA = "0x1843E92A0")]
	private void HKHKMIOGJJI(TKey CKMEBFKEHMO, TVal OAFEANCCICI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x43E95E0", Offset = "0x43E83E0", VA = "0x1843E95E0")]
	private bool LLBHGHLLDMC(TKey CKMEBFKEHMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x43E9500", Offset = "0x43E8300", VA = "0x1843E9500")]
	private bool LLBHGHLLDMC(TVal OAFEANCCICI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x43E9B50", Offset = "0x43E8950", VA = "0x1843E9B50")]
	public OECEIHHFKJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[DefaultMember("Item")]
public class IDDIBMKDCAH<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private global::IDDIBMKDCAH<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x3F8C230", Offset = "0x3F8B030", VA = "0x183F8C230", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3F8DB10", Offset = "0x3F8C910", VA = "0x183F8DB10")]
		public Enumerator(global::IDDIBMKDCAH<T> NGFFBKNAABM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3F88750", Offset = "0x3F87550", VA = "0x183F88750", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3F89800", Offset = "0x3F88600", VA = "0x183F89800", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3F88C30", Offset = "0x3F87A30", VA = "0x183F88C30")]
		private void NDCNBPKBBCN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private T[] HLMOBOIJGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private int NHDKCAPAOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private int HGJKAEHCMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private int LLNMOPOJDNH;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int EKAGFOMELON
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2C04F80", Offset = "0x2C03D80", VA = "0x182C04F80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T BADELHLICNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2C06BC0", Offset = "0x2C059C0", VA = "0x182C06BC0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2C053A0", Offset = "0x2C041A0", VA = "0x182C053A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2C06EC0", Offset = "0x2C05CC0", VA = "0x182C06EC0")]
	public IDDIBMKDCAH(int DOOAOHCDEFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2C051F0", Offset = "0x2C03FF0", VA = "0x182C051F0")]
	public void EKGLGHAFJEH(T DKOBICODCGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2C055A0", Offset = "0x2C043A0", VA = "0x182C055A0")]
	public void MHNPACKGLOM(IEnumerable<T> KDFKOIMENHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2C054D0", Offset = "0x2C042D0", VA = "0x182C054D0")]
	public void KJHAHNAAJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2C065F0", Offset = "0x2C053F0", VA = "0x182C065F0")]
	public void ODNIIAPEEFN(int KNPCAAMBLKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2C06560", Offset = "0x2C05360", VA = "0x182C06560")]
	public void NPBBHBOFAMN(int KNPCAAMBLKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2C067D0", Offset = "0x2C055D0", VA = "0x182C067D0")]
	public void OJHNEAPPOAD(T[] HDCHHDPICKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2C054F0", Offset = "0x2C042F0", VA = "0x182C054F0")]
	public Enumerator LEIFMBFFFGJ()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2C06E40", Offset = "0x2C05C40", VA = "0x182C06E40", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2C06E40", Offset = "0x2C05C40", VA = "0x182C06E40", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2C06470", Offset = "0x2C05270", VA = "0x182C06470")]
	private int NAMBBAKOHLN(int DJIEOHJNDEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2C054A0", Offset = "0x2C042A0", VA = "0x182C054A0")]
	private int IJOALLAGFMK(int DJIEOHJNDEK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class MFNKGLOIILB<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Func<Internal, External> KPMPGMAPHFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Func<External, Internal> NOOMPALANFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private IList<Internal> GHOABBJLFEA;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IList<Internal> CEBBDIHEBIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D30", Offset = "0x6C4B30", VA = "0x1806C5D30")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6FAD80", Offset = "0x6F9B80", VA = "0x1806FAD80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool BJGAENKKDEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x701080", Offset = "0x6FFE80", VA = "0x180701080", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x701090", Offset = "0x6FFE90", VA = "0x180701090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public External BADELHLICNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3A66120", Offset = "0x3A64F20", VA = "0x183A66120", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3A661C0", Offset = "0x3A64FC0", VA = "0x183A661C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int EKAGFOMELON
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3A660C0", Offset = "0x3A64EC0", VA = "0x183A660C0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x39312E0", Offset = "0x39300E0", VA = "0x1839312E0")]
	public MFNKGLOIILB(Func<Internal, External> KPMPGMAPHFA, Func<External, Internal> NOOMPALANFJ, bool JEFIMODPPHF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3A65E30", Offset = "0x3A64C30", VA = "0x183A65E30", Slot = "6")]
	public int IndexOf(External BKCHCEAGIMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3A65AB0", Offset = "0x3A648B0", VA = "0x183A65AB0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x3A65B10", Offset = "0x3A64910", VA = "0x183A65B10", Slot = "13")]
	public bool Contains(External BKCHCEAGIMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3A65BA0", Offset = "0x3A649A0", VA = "0x183A65BA0", Slot = "14")]
	public void CopyTo(External[] HDCHHDPICKJ, int HKFDIPJFPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3A65A20", Offset = "0x3A64820", VA = "0x183A65A20", Slot = "11")]
	public void Add(External BKCHCEAGIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3A65F20", Offset = "0x3A64D20", VA = "0x183A65F20", Slot = "7")]
	public void Insert(int DJIEOHJNDEK, External BKCHCEAGIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3A66030", Offset = "0x3A64E30", VA = "0x183A66030", Slot = "15")]
	public bool Remove(External BKCHCEAGIMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3A65FC0", Offset = "0x3A64DC0", VA = "0x183A65FC0", Slot = "8")]
	public void RemoveAt(int DJIEOHJNDEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3A65DC0", Offset = "0x3A64BC0", VA = "0x183A65DC0", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3739340", Offset = "0x3738140", VA = "0x183739340", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class FFPOOHKDCIP<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly Func<Internal, External> KPMPGMAPHFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private IReadOnlyList<Internal> GHOABBJLFEA;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyList<Internal> CEBBDIHEBIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7011D0", Offset = "0x6FFFD0", VA = "0x1807011D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool BJGAENKKDEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6C8080", Offset = "0x6C6E80", VA = "0x1806C8080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public External BADELHLICNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x40085D0", Offset = "0x40073D0", VA = "0x1840085D0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int EKAGFOMELON
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x4008570", Offset = "0x4007370", VA = "0x184008570", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x2C161E0", Offset = "0x2C14FE0", VA = "0x182C161E0")]
	public FFPOOHKDCIP(Func<Internal, External> KPMPGMAPHFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x4008520", Offset = "0x4007320", VA = "0x184008520")]
	public FFPOOHKDCIP(IReadOnlyList<Internal> GHOABBJLFEA, Func<Internal, External> KPMPGMAPHFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x4008300", Offset = "0x4007100", VA = "0x184008300")]
	public void OJHNEAPPOAD(External[] HDCHHDPICKJ, int HKFDIPJFPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x4008290", Offset = "0x4007090", VA = "0x184008290", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3746200", Offset = "0x3745000", VA = "0x183746200", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[DefaultMember("Item")]
public class AICPEDKJKHG<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private IReadOnlyList<Internal> GHOABBJLFEA;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IReadOnlyList<Internal> CEBBDIHEBIM
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F00", Offset = "0x6E5D00", VA = "0x1806E6F00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool BJGAENKKDEH
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6C8080", Offset = "0x6C6E80", VA = "0x1806C8080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public External BADELHLICNG
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x40B82B0", Offset = "0x40B70B0", VA = "0x1840B82B0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int EKAGFOMELON
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x40B8250", Offset = "0x40B7050", VA = "0x1840B8250", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2C161E0", Offset = "0x2C14FE0", VA = "0x182C161E0")]
	public AICPEDKJKHG(IReadOnlyList<Internal> GHOABBJLFEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x40B7F10", Offset = "0x40B6D10", VA = "0x1840B7F10")]
	public bool DOMBPGEJHPH(External BKCHCEAGIMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x40B8020", Offset = "0x40B6E20", VA = "0x1840B8020")]
	public void OJHNEAPPOAD(External[] HDCHHDPICKJ, int HKFDIPJFPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x40B7FB0", Offset = "0x40B6DB0", VA = "0x1840B7FB0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x3739340", Offset = "0x3738140", VA = "0x183739340", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public abstract class GILFMHEFMOD
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void BADEIILKKAL(object[] NHMGHNFFDAC);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	protected GILFMHEFMOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public abstract class LCPBBMIFLLC<T> : GILFMHEFMOD
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	protected struct DGCHJJNKCBH
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public enum ANJBEBPGFPJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public ANJBEBPGFPJ LAKBKKJKBPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public T CIAILAMJPDB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int APJBIPDMILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly bool HCDGOCCAFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	protected readonly bool MAMGHCHGENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	protected List<T> AHIICDLNONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<DGCHJJNKCBH> JHPCOKJCJNN;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool PFGOGDMEBFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x38F0FB0", Offset = "0x38EFDB0", VA = "0x1838F0FB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x38F1130", Offset = "0x38EFF30", VA = "0x1838F1130")]
	protected LCPBBMIFLLC(bool MAMGHCHGENO, bool HCDGOCCAFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x38F0C00", Offset = "0x38EFA00", VA = "0x1838F0C00")]
	protected bool BMJPIOIFOKL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x38F0DE0", Offset = "0x38EFBE0", VA = "0x1838F0DE0")]
	protected void HAAIPDOAPLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x38F0A50", Offset = "0x38EF850", VA = "0x1838F0A50")]
	protected void BMIJLHNOCJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3DAC450", Offset = "0x3DAB250", VA = "0x183DAC450")]
	private static void GDJIAFLPEKG<U>(ref List<U> GHOABBJLFEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x38F0C80", Offset = "0x38EFA80", VA = "0x1838F0C80", Slot = "5")]
	public void EKGLGHAFJEH(T CIAILAMJPDB, bool IFDFFJIGHIC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x38F0FF0", Offset = "0x38EFDF0", VA = "0x1838F0FF0", Slot = "6")]
	public void PPEAGPDBOCM(T CIAILAMJPDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x38F0EA0", Offset = "0x38EFCA0", VA = "0x1838F0EA0")]
	public void KJHAHNAAJMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface IIFHDHNDJDP
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EKGLGHAFJEH(Action CIAILAMJPDB, bool IFDFFJIGHIC = false);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PPEAGPDBOCM(Action CIAILAMJPDB);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public sealed class EEDHONDEDDI : global::LCPBBMIFLLC<Action>, IIFHDHNDJDP
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x1FE07B0", Offset = "0x1FDF5B0", VA = "0x181FE07B0")]
	public EEDHONDEDDI(bool MAMGHCHGENO = false, bool HCDGOCCAFFL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x1FE04E0", Offset = "0x1FDF2E0", VA = "0x181FE04E0")]
	public void DJBDMDGHBAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x1FE0470", Offset = "0x1FDF270", VA = "0x181FE0470", Slot = "4")]
	public override void BADEIILKKAL(object[] NHMGHNFFDAC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x1FE0750", Offset = "0x1FDF550", VA = "0x181FE0750")]
	public static EEDHONDEDDI MDHFIBHEPOI(EEDHONDEDDI CLAOOPHNBCB, Action CIAILAMJPDB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x1FE06F0", Offset = "0x1FDF4F0", VA = "0x181FE06F0")]
	public static EEDHONDEDDI DLKHGFHHNJJ(EEDHONDEDDI CLAOOPHNBCB, Action CIAILAMJPDB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface EKOJBIPIFIN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EKGLGHAFJEH(Action<T> CIAILAMJPDB, bool IFDFFJIGHIC = false);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PPEAGPDBOCM(Action<T> CIAILAMJPDB);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class EGPJGAAPCPL<T> : global::LCPBBMIFLLC<Action<T>>, global::EKOJBIPIFIN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x36D1C20", Offset = "0x36D0A20", VA = "0x1836D1C20")]
	public EGPJGAAPCPL(bool MAMGHCHGENO = false, bool HCDGOCCAFFL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x36D0F20", Offset = "0x36CFD20", VA = "0x1836D0F20")]
	public void DJBDMDGHBAG(T DKOBICODCGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x36CE1A0", Offset = "0x36CCFA0", VA = "0x1836CE1A0", Slot = "4")]
	public override void BADEIILKKAL(object[] NHMGHNFFDAC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x36D1B80", Offset = "0x36D0980", VA = "0x1836D1B80")]
	public static global::EGPJGAAPCPL<T> MDHFIBHEPOI(global::EGPJGAAPCPL<T> CLAOOPHNBCB, Action<T> CIAILAMJPDB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x36D1AE0", Offset = "0x36D08E0", VA = "0x1836D1AE0")]
	public static global::EGPJGAAPCPL<T> DLKHGFHHNJJ(global::EGPJGAAPCPL<T> CLAOOPHNBCB, Action<T> CIAILAMJPDB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface AGNCFLALGIL<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EKGLGHAFJEH(Action<T, U> CIAILAMJPDB, bool IFDFFJIGHIC = false);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PPEAGPDBOCM(Action<T, U> CIAILAMJPDB);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class KCGHCNPGINP<T, U> : global::LCPBBMIFLLC<Action<T, U>>, global::AGNCFLALGIL<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x36D1C20", Offset = "0x36D0A20", VA = "0x1836D1C20")]
	public KCGHCNPGINP(bool MAMGHCHGENO = false, bool HCDGOCCAFFL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x39B2710", Offset = "0x39B1510", VA = "0x1839B2710")]
	public void DJBDMDGHBAG(T DKOBICODCGH, U HHNFALMCDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x39B0F40", Offset = "0x39AFD40", VA = "0x1839B0F40", Slot = "4")]
	public override void BADEIILKKAL(object[] NHMGHNFFDAC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x39B45F0", Offset = "0x39B33F0", VA = "0x1839B45F0")]
	public static global::KCGHCNPGINP<T, U> MDHFIBHEPOI(global::KCGHCNPGINP<T, U> CLAOOPHNBCB, Action<T, U> CIAILAMJPDB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x39B4550", Offset = "0x39B3350", VA = "0x1839B4550")]
	public static global::KCGHCNPGINP<T, U> DLKHGFHHNJJ(global::KCGHCNPGINP<T, U> CLAOOPHNBCB, Action<T, U> CIAILAMJPDB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface MHPEHEIEFOK<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EKGLGHAFJEH(Action<T, U, V> CIAILAMJPDB, bool IFDFFJIGHIC = false);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PPEAGPDBOCM(Action<T, U, V> CIAILAMJPDB);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class GGJCCGGLCGM<T, U, V> : global::LCPBBMIFLLC<Action<T, U, V>>, global::MHPEHEIEFOK<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x36D1C20", Offset = "0x36D0A20", VA = "0x1836D1C20")]
	public GGJCCGGLCGM(bool MAMGHCHGENO = false, bool HCDGOCCAFFL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x3766FF0", Offset = "0x3765DF0", VA = "0x183766FF0")]
	public void DJBDMDGHBAG(T DKOBICODCGH, U HHNFALMCDEE, V FKCJFNALIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x3765680", Offset = "0x3764480", VA = "0x183765680", Slot = "4")]
	public override void BADEIILKKAL(object[] NHMGHNFFDAC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3768EA0", Offset = "0x3767CA0", VA = "0x183768EA0")]
	public static global::GGJCCGGLCGM<T, U, V> MDHFIBHEPOI(global::GGJCCGGLCGM<T, U, V> CLAOOPHNBCB, Action<T, U, V> CIAILAMJPDB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3768E00", Offset = "0x3767C00", VA = "0x183768E00")]
	public static global::GGJCCGGLCGM<T, U, V> DLKHGFHHNJJ(global::GGJCCGGLCGM<T, U, V> CLAOOPHNBCB, Action<T, U, V> CIAILAMJPDB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface EKGIILLOLII<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EKGLGHAFJEH(Action<T, U, V, W> CIAILAMJPDB, bool IFDFFJIGHIC = false);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PPEAGPDBOCM(Action<T, U, V, W> CIAILAMJPDB);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class MAHPBAPGFLL<T, U, V, W> : global::LCPBBMIFLLC<Action<T, U, V, W>>, global::EKGIILLOLII<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x36D1C20", Offset = "0x36D0A20", VA = "0x1836D1C20")]
	public MAHPBAPGFLL(bool MAMGHCHGENO = false, bool HCDGOCCAFFL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3F64960", Offset = "0x3F63760", VA = "0x183F64960")]
	public void DJBDMDGHBAG(T DKOBICODCGH, U HHNFALMCDEE, V FKCJFNALIGC, W FALKGHPMDGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x3F63510", Offset = "0x3F62310", VA = "0x183F63510", Slot = "4")]
	public override void BADEIILKKAL(object[] NHMGHNFFDAC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x3F65A20", Offset = "0x3F64820", VA = "0x183F65A20")]
	public static global::MAHPBAPGFLL<T, U, V, W> MDHFIBHEPOI(global::MAHPBAPGFLL<T, U, V, W> CLAOOPHNBCB, Action<T, U, V, W> CIAILAMJPDB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x3F65980", Offset = "0x3F64780", VA = "0x183F65980")]
	public static global::MAHPBAPGFLL<T, U, V, W> DLKHGFHHNJJ(global::MAHPBAPGFLL<T, U, V, W> CLAOOPHNBCB, Action<T, U, V, W> CIAILAMJPDB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface PAJIIPAGHDO<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EKGLGHAFJEH(Action<T, U, V, W, X> CIAILAMJPDB, bool IFDFFJIGHIC = false);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PPEAGPDBOCM(Action<T, U, V, W, X> CIAILAMJPDB);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class GLEOCHBMLPM<T, U, V, W, X> : global::LCPBBMIFLLC<Action<T, U, V, W, X>>, global::PAJIIPAGHDO<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x36D1C20", Offset = "0x36D0A20", VA = "0x1836D1C20")]
	public GLEOCHBMLPM(bool MAMGHCHGENO = false, bool HCDGOCCAFFL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x4220A30", Offset = "0x421F830", VA = "0x184220A30")]
	public void DJBDMDGHBAG(T DKOBICODCGH, U HHNFALMCDEE, V FKCJFNALIGC, W FALKGHPMDGO, X IDDALCIIJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x4220740", Offset = "0x421F540", VA = "0x184220740", Slot = "4")]
	public override void BADEIILKKAL(object[] NHMGHNFFDAC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x4221090", Offset = "0x421FE90", VA = "0x184221090")]
	public static global::GLEOCHBMLPM<T, U, V, W, X> MDHFIBHEPOI(global::GLEOCHBMLPM<T, U, V, W, X> CLAOOPHNBCB, Action<T, U, V, W, X> CIAILAMJPDB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x4220FF0", Offset = "0x421FDF0", VA = "0x184220FF0")]
	public static global::GLEOCHBMLPM<T, U, V, W, X> DLKHGFHHNJJ(global::GLEOCHBMLPM<T, U, V, W, X> CLAOOPHNBCB, Action<T, U, V, W, X> CIAILAMJPDB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface ILAONNBAECJ<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EKGLGHAFJEH(Action<T, U, V, W, X, Y> CIAILAMJPDB, bool IFDFFJIGHIC = false);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PPEAGPDBOCM(Action<T, U, V, W, X, Y> CIAILAMJPDB);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class GOLGHADLOFD<T, U, V, W, X, Y> : global::LCPBBMIFLLC<Action<T, U, V, W, X, Y>>, global::ILAONNBAECJ<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x36D1C20", Offset = "0x36D0A20", VA = "0x1836D1C20")]
	public GOLGHADLOFD(bool MAMGHCHGENO = false, bool HCDGOCCAFFL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x4B4B6C0", Offset = "0x4B4A4C0", VA = "0x184B4B6C0")]
	public void DJBDMDGHBAG(T DKOBICODCGH, U HHNFALMCDEE, V FKCJFNALIGC, W FALKGHPMDGO, X IDDALCIIJOJ, Y GIJPFDNHKHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x4B4B380", Offset = "0x4B4A180", VA = "0x184B4B380", Slot = "4")]
	public override void BADEIILKKAL(object[] NHMGHNFFDAC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x4B4BFE0", Offset = "0x4B4ADE0", VA = "0x184B4BFE0")]
	public static global::GOLGHADLOFD<T, U, V, W, X, Y> MDHFIBHEPOI(global::GOLGHADLOFD<T, U, V, W, X, Y> CLAOOPHNBCB, Action<T, U, V, W, X, Y> CIAILAMJPDB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x4B4BF40", Offset = "0x4B4AD40", VA = "0x184B4BF40")]
	public static global::GOLGHADLOFD<T, U, V, W, X, Y> DLKHGFHHNJJ(global::GOLGHADLOFD<T, U, V, W, X, Y> CLAOOPHNBCB, Action<T, U, V, W, X, Y> CIAILAMJPDB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class LPLBEAFPFFH<T>
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public readonly struct FDHJIMGKNMJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly global::LPLBEAFPFFH<T> LLDDJDIKLIN;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public T MHMGLCIOEKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x3FB23B0", Offset = "0x3FB11B0", VA = "0x183FB23B0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3FB2380", Offset = "0x3FB1180", VA = "0x183FB2380", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x963B70", Offset = "0x962970", VA = "0x180963B70")]
		public FDHJIMGKNMJ(global::LPLBEAFPFFH<T> LLDDJDIKLIN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct CIJMCGJIEPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder<FDHJIMGKNMJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public global::LPLBEAFPFFH<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x38B30E0", Offset = "0x38B1EE0", VA = "0x1838B30E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x2F9DD10", Offset = "0x2F9CB10", VA = "0x182F9DD10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct GJFOJCHLJMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AsyncTaskMethodBuilder<FDHJIMGKNMJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public global::LPLBEAFPFFH<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x421D520", Offset = "0x421C320", VA = "0x18421D520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x2F9DD10", Offset = "0x2F9CB10", VA = "0x182F9DD10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly SemaphoreSlim JBLPDIFPCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private T EOFGGANFBFE;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int PINKCFOKBNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x3905860", Offset = "0x3904660", VA = "0x183905860")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x3905EF0", Offset = "0x3904CF0", VA = "0x183905EF0")]
	public LPLBEAFPFFH(in T EOFGGANFBFE, int CMKNGLOGEJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x3905E20", Offset = "0x3904C20", VA = "0x183905E20")]
	public LPLBEAFPFFH(in T EOFGGANFBFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x39057E0", Offset = "0x39045E0", VA = "0x1839057E0")]
	public FDHJIMGKNMJ CKBIDDNCPCH()
	{
		return default(FDHJIMGKNMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3905820", Offset = "0x3904620", VA = "0x183905820")]
	public FDHJIMGKNMJ CKBIDDNCPCH(CancellationToken ONKANLKLEAL)
	{
		return default(FDHJIMGKNMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x3905880", Offset = "0x3904680", VA = "0x183905880")]
	[AsyncStateMachine(typeof(global::LPLBEAFPFFH<>.CIJMCGJIEPC))]
	public Task<FDHJIMGKNMJ> PLCKCLAJOLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x3905B50", Offset = "0x3904950", VA = "0x183905B50")]
	[AsyncStateMachine(typeof(global::LPLBEAFPFFH<>.GJFOJCHLJMD))]
	public Task<FDHJIMGKNMJ> PLCKCLAJOLI(CancellationToken ONKANLKLEAL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class LJNNFCCNOEA
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3E90", Offset = "0x1FE2C90", VA = "0x181FE3E90")]
	public static global::LPLBEAFPFFH<PDIIEEBMKOH> PKGIDMHJGMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3E20", Offset = "0x1FE2C20", VA = "0x181FE3E20")]
	public static global::LPLBEAFPFFH<PDIIEEBMKOH> PKGIDMHJGMJ(int CMKNGLOGEJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3666DD0", Offset = "0x3665BD0", VA = "0x183666DD0")]
	public static global::LPLBEAFPFFH<T> PKGIDMHJGMJ<T>(in T EOFGGANFBFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x380D340", Offset = "0x380C140", VA = "0x18380D340")]
	public static global::LPLBEAFPFFH<T> PKGIDMHJGMJ<T>(in T EOFGGANFBFE, int CMKNGLOGEJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class EDMGHCKHING<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public delegate Task<TResult> KMKAFNGMLBG(TRequest GKLLPHJPFFI, CancellationToken ONKANLKLEAL);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public enum DEKCCIBOMPK
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class LNLBJMNKAMA
	{
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private const float OIGDJBEIFGC = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TimeSpan NCAPJINCJEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int CKOMIDCFMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public DEKCCIBOMPK ANHLHIGCAIN;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly LNLBJMNKAMA JLGGJMINNJN;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float MDPEAJLHOBH
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x3903C60", Offset = "0x3902A60", VA = "0x183903C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TimeSpan MBINDHMCKLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3903D40", Offset = "0x3902B40", VA = "0x183903D40")]
		public LNLBJMNKAMA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private readonly struct FLFHOMMDPBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly TRequest GKLLPHJPFFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public readonly CancellationToken ONKANLKLEAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public readonly TaskCompletionSource<TResult> MMKGHENBCEH;

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x37998E0", Offset = "0x37986E0", VA = "0x1837998E0")]
		public FLFHOMMDPBG(TRequest GKLLPHJPFFI, TaskCompletionSource<TResult> MMKGHENBCEH, CancellationToken ONKANLKLEAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class AMONCEGCJFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x22E6440", Offset = "0x22E5240", VA = "0x1822E6440")]
		public AMONCEGCJFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3346810", Offset = "0x3345610", VA = "0x183346810")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct PCOEBDBGDFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public global::EDMGHCKHING<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x51E6F00", Offset = "0x51E5D00", VA = "0x1851E6F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xA73C20", Offset = "0xA72A20", VA = "0x180A73C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct GJCPOPCNHIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public global::EDMGHCKHING<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private FLFHOMMDPBG <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x421CAB0", Offset = "0x421B8B0", VA = "0x18421CAB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA73C20", Offset = "0xA72A20", VA = "0x180A73C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CancellationTokenSource CDFNACDNGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly List<FLFHOMMDPBG> KFCILKBLDOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly LNLBJMNKAMA NFJMOOJEBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly KMKAFNGMLBG KPAGAJKGGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Task PFNJEKOHILE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int HDOFILHAFOL;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x4103DB0", Offset = "0x4102BB0", VA = "0x184103DB0")]
	public EDMGHCKHING(KMKAFNGMLBG KPAGAJKGGLO, [Optional] LNLBJMNKAMA NFJMOOJEBDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x41034F0", Offset = "0x41022F0", VA = "0x1841034F0")]
	public Task<TResult> PKOGCLEOKOF(TRequest GKLLPHJPFFI, CancellationToken ONKANLKLEAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x4102700", Offset = "0x4101500", VA = "0x184102700")]
	private void FDCLNBDODMH(FLFHOMMDPBG GLLBNMGKPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x41031F0", Offset = "0x4101FF0", VA = "0x1841031F0")]
	[AsyncStateMachine(typeof(global::EDMGHCKHING<, >.PCOEBDBGDFN))]
	private Task OHHDNAMIKIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x4102C40", Offset = "0x4101A40", VA = "0x184102C40")]
	private FLFHOMMDPBG GLPHIJDBAAP()
	{
		return default(FLFHOMMDPBG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x4102E90", Offset = "0x4101C90", VA = "0x184102E90")]
	[AsyncStateMachine(typeof(global::EDMGHCKHING<, >.GJCPOPCNHIN))]
	private Task ICNBNIGDFGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x41024B0", Offset = "0x41012B0", VA = "0x1841024B0")]
	private void CENBKEKMJLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x4102580", Offset = "0x4101380", VA = "0x184102580", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class EPNMNPJNJGH<TKey, TVal> : global::NOMONGAKDLK<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int HGFBHLECBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	internal Dictionary<TKey, (TVal value, int size)> DDPNJGIKNPN;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	internal override int FMHHPNFHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x22E6790", Offset = "0x22E5590", VA = "0x1822E6790", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal int LKFGGHCFNON
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x22E67C0", Offset = "0x22E55C0", VA = "0x1822E67C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public override int EKAGFOMELON
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x22E6730", Offset = "0x22E5530", VA = "0x1822E6730", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x22E6D40", Offset = "0x22E5B40", VA = "0x1822E6D40")]
	public EPNMNPJNJGH(int DOOAOHCDEFK, [Optional] PFNDKFGCEIM ILGBLMPMNFP, [Optional] IEqualityComparer<TKey> GGJCMBHMHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x22E6690", Offset = "0x22E5490", VA = "0x1822E6690")]
	public void AAHEGLODCIC(TKey CKMEBFKEHMO, TVal DPJGMDFEIDL, bool JMEGCCFJFMC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x22E6CC0", Offset = "0x22E5AC0", VA = "0x1822E6CC0")]
	public bool PJBGGBJGFEE(TKey CKMEBFKEHMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x22E67F0", Offset = "0x22E55F0", VA = "0x1822E67F0", Slot = "6")]
	public override bool ICLIDKMCOMO(TKey ECBFBHAIJEJ, out TVal DPJGMDFEIDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x22E6890", Offset = "0x22E5690", VA = "0x1822E6890")]
	public bool JDIKBLLAGLD(TKey CKMEBFKEHMO, TVal DPJGMDFEIDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x22E6AA0", Offset = "0x22E58A0", VA = "0x1822E6AA0")]
	public bool JECFADIONLG(TKey CKMEBFKEHMO, TVal DPJGMDFEIDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x22E6BB0", Offset = "0x22E59B0", VA = "0x1822E6BB0", Slot = "7")]
	public override void KJHAHNAAJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x22E6C20", Offset = "0x22E5A20", VA = "0x1822E6C20")]
	private bool PDMEGHGNEGM(TKey CKMEBFKEHMO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[DefaultMember("Item")]
public class NOMONGAKDLK<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public delegate int PFNDKFGCEIM(TKey CKMEBFKEHMO, TVal DPJGMDFEIDL);

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class DNANKANKKNC
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public TKey GKKFJKNNDIH
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x909CA0", Offset = "0x908AA0", VA = "0x180909CA0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public TVal MHMGLCIOEKC
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D30", Offset = "0x6C4B30", VA = "0x1806C5D30")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x6FAD80", Offset = "0x6F9B80", VA = "0x1806FAD80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public int BJEJGEAMGOH
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x6C5CE0", Offset = "0x6C4AE0", VA = "0x1806C5CE0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x6DBF60", Offset = "0x6DAD60", VA = "0x1806DBF60")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public DateTime IDNBDLEMHPN
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x6D0BA0", Offset = "0x6CF9A0", VA = "0x1806D0BA0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x1012040", Offset = "0x1010E40", VA = "0x181012040")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x499BB20", Offset = "0x499A920", VA = "0x18499BB20")]
		public DNANKANKKNC(TKey CKMEBFKEHMO, TVal OAFEANCCICI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public const int FKNAHEKJGHP = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly Dictionary<TKey, LinkedListNode<DNANKANKKNC>> OIJJIAADPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly LinkedList<DNANKANKKNC> FJCLBJMGMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	protected readonly PFNDKFGCEIM ILGBLMPMNFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly TimeSpan ODFAJDNMBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly MHKGNAHKGJB POLHDCIFDPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int IPFDLIEADGF;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int LOFJCNPKFOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x81CD00", Offset = "0x81BB00", VA = "0x18081CD00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private bool KEIMMECMMPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x49EC640", Offset = "0x49EB440", VA = "0x1849EC640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal virtual int FMHHPNFHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x96A7C0", Offset = "0x9695C0", VA = "0x18096A7C0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private int KNPCAAMBLKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3124240", Offset = "0x3123040", VA = "0x183124240")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public virtual int EKAGFOMELON
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x37E3BD0", Offset = "0x37E29D0", VA = "0x1837E3BD0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public IEnumerable<TKey> DICPGCGPFEB
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x49E9910", Offset = "0x49E8710", VA = "0x1849E9910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public TVal BADELHLICNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x49EC700", Offset = "0x49EB500", VA = "0x1849EC700")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x376F160", Offset = "0x376DF60", VA = "0x18376F160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x49ED880", Offset = "0x49EC680", VA = "0x1849ED880")]
	public NOMONGAKDLK(int DOOAOHCDEFK, [Optional] PFNDKFGCEIM ILGBLMPMNFP, [Optional] IEqualityComparer<TKey> GGJCMBHMHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x49ECB70", Offset = "0x49EB970", VA = "0x1849ECB70")]
	public NOMONGAKDLK(TimeSpan ODFAJDNMBFN, [Optional] IEqualityComparer<TKey> GGJCMBHMHMD, [Optional] MHKGNAHKGJB POLHDCIFDPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x49ECE40", Offset = "0x49EBC40", VA = "0x1849ECE40")]
	public NOMONGAKDLK(int DOOAOHCDEFK, TimeSpan ODFAJDNMBFN, [Optional] IEqualityComparer<TKey> GGJCMBHMHMD, [Optional] MHKGNAHKGJB POLHDCIFDPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x49ECBC0", Offset = "0x49EB9C0", VA = "0x1849ECBC0")]
	public NOMONGAKDLK(int DOOAOHCDEFK, PFNDKFGCEIM ILGBLMPMNFP, TimeSpan ODFAJDNMBFN, [Optional] IEqualityComparer<TKey> GGJCMBHMHMD, [Optional] MHKGNAHKGJB POLHDCIFDPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x49E9CA0", Offset = "0x49E8AA0", VA = "0x1849E9CA0")]
	public void EMEHGLDFLEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x49EBED0", Offset = "0x49EACD0", VA = "0x1849EBED0")]
	public void LMMFIPJEJPN(TKey CKMEBFKEHMO, TVal DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x49EC8A0", Offset = "0x49EB6A0", VA = "0x1849EC8A0")]
	public bool PPEAGPDBOCM(TKey CKMEBFKEHMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x49EA1F0", Offset = "0x49E8FF0", VA = "0x1849EA1F0")]
	private TVal HEOCMNIHPLM(TKey ECBFBHAIJEJ)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x49EA6F0", Offset = "0x49E94F0", VA = "0x1849EA6F0", Slot = "6")]
	public virtual bool ICLIDKMCOMO(TKey ECBFBHAIJEJ, out TVal DPJGMDFEIDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x49EB310", Offset = "0x49EA110", VA = "0x1849EB310", Slot = "7")]
	public virtual void KJHAHNAAJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x49EA9E0", Offset = "0x49E97E0", VA = "0x1849EA9E0")]
	private bool JGHHEJCGKLB(DNANKANKKNC BMABJKEGBFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x49EBA40", Offset = "0x49EA840", VA = "0x1849EBA40")]
	private void LKNKGPFIEHA(LinkedListNode<DNANKANKKNC> PIBBBOMPMHA, TVal IOMHKOCLPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x49EAB60", Offset = "0x49E9960", VA = "0x1849EAB60")]
	private void KEKCLMKGJCF(TKey CKMEBFKEHMO, TVal DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x49EC300", Offset = "0x49EB100", VA = "0x1849EC300")]
	private void MBKCGGLPMFJ(DNANKANKKNC BMABJKEGBFB, TVal IOMHKOCLPDA, int AOCLGABDDDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[DefaultMember("Item")]
public class AOMPIINAAOG<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly List<T> GHOABBJLFEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private HashSet<T> EIGBMAINAHM;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int EKAGFOMELON
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3346810", Offset = "0x3345610", VA = "0x183346810", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool BJGAENKKDEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x6E5BE0", Offset = "0x6E49E0", VA = "0x1806E5BE0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public T BADELHLICNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2F05930", Offset = "0x2F04730", VA = "0x182F05930", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x4D03F90", Offset = "0x4D02D90", VA = "0x184D03F90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x3741900", Offset = "0x3740700", VA = "0x183741900", Slot = "11")]
	public void Add(T BKCHCEAGIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x4D03C10", Offset = "0x4D02A10", VA = "0x184D03C10")]
	public bool BFANBNANLGD(T BKCHCEAGIMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x4D03F10", Offset = "0x4D02D10", VA = "0x184D03F10", Slot = "15")]
	public bool Remove(T BKCHCEAGIMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x42DA140", Offset = "0x42D8F40", VA = "0x1842DA140", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x36F1520", Offset = "0x36F0320", VA = "0x1836F1520", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x42DA0B0", Offset = "0x42D8EB0", VA = "0x1842DA0B0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x37977A0", Offset = "0x37965A0", VA = "0x1837977A0", Slot = "13")]
	public bool Contains(T BKCHCEAGIMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x42DA110", Offset = "0x42D8F10", VA = "0x1842DA110", Slot = "14")]
	public void CopyTo(T[] HDCHHDPICKJ, int HKFDIPJFPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x42DA1C0", Offset = "0x42D8FC0", VA = "0x1842DA1C0", Slot = "6")]
	public int IndexOf(T BKCHCEAGIMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x4D03CB0", Offset = "0x4D02AB0", VA = "0x184D03CB0", Slot = "7")]
	public void Insert(int DJIEOHJNDEK, T BKCHCEAGIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x4D03E40", Offset = "0x4D02C40", VA = "0x184D03E40", Slot = "8")]
	public void RemoveAt(int DJIEOHJNDEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x4D03D70", Offset = "0x4D02B70", VA = "0x184D03D70")]
	public void PHIHBDOJPBF(Predicate<T> HBLEHCKGEIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x42D9FD0", Offset = "0x42D8DD0", VA = "0x1842D9FD0")]
	public void BCLDFOPOKFK(Comparison<T> KILJAMLKLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x42DA4F0", Offset = "0x42D92F0", VA = "0x1842DA4F0")]
	public AOMPIINAAOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class FLBBONAOPDJ
{
	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x1FE1EE0", Offset = "0x1FE0CE0", VA = "0x181FE1EE0")]
	public static Vector3 JFFPPDENGEE(this GameObject NGIKODIIBGN, float ONGEIHAEIDF)
	{
		return default(Vector3);
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xDE4FC0", Offset = "0xDE3DC0", VA = "0x180DE4FC0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x1FE8C00", Offset = "0x1FE7A00", VA = "0x181FE8C00")]
		public SerializedGuid(in Guid KFIPLDEPOPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x1FE8B70", Offset = "0x1FE7970", VA = "0x181FE8B70")]
		public static SerializedGuid PALGOCAKEGA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x1FE8A10", Offset = "0x1FE7810", VA = "0x181FE8A10")]
		public static SerializedGuid OLDCJJAOBMB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x1FE88F0", Offset = "0x1FE76F0", VA = "0x181FE88F0")]
		public bool JPFCFFDFJJM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x1FE8B40", Offset = "0x1FE7940", VA = "0x181FE8B40", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x1FE8AA0", Offset = "0x1FE78A0", VA = "0x181FE8AA0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x1FE8980", Offset = "0x1FE7780", VA = "0x181FE8980")]
		public bool MLHEGDJEPEH(in Guid KFIPLDEPOPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x1FE8750", Offset = "0x1FE7550", VA = "0x181FE8750", Slot = "7")]
		public bool Equals(SerializedGuid BNIMMCIKNIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x1FE8800", Offset = "0x1FE7600", VA = "0x181FE8800", Slot = "0")]
		public override bool Equals(object LOPIEGGIDMF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x1FE88E0", Offset = "0x1FE76E0", VA = "0x181FE88E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x1FE8720", Offset = "0x1FE7520", VA = "0x181FE8720", Slot = "6")]
		public int CompareTo(SerializedGuid BNIMMCIKNIE)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class DLNJBAEIPMI : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly Type PENHGJBDHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly string GEEEMGNOAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly bool EBFBAOMBECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly bool KLDFBBEMGBO;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x1FDFEE0", Offset = "0x1FDECE0", VA = "0x181FDFEE0")]
	public DLNJBAEIPMI(Type KDAEKCPFLMP, string AFCNLMEJCOC, bool PJDPEKDEHON = false, bool OCDLLHLEAAN = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface LGEFPKCLGPA
{
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface JODHGAOPMGC<T> : LGEFPKCLGPA
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	T MHMGLCIOEKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool BDGLEMCAIID
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	string GDFDHIAKAEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::JODHGAOPMGC<T> LJFCIEFABHP(Action<T> GBLOFGKMBKG);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::JODHGAOPMGC<T> JNMLPMKFKMA(Action<T> GBLOFGKMBKG);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::JODHGAOPMGC<T> CLPHIGGNLLF(Action<T, T> CKPNCGJCPNP);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::JODHGAOPMGC<T> KGOFKKICCCA(Action<T, T> CKPNCGJCPNP);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::JODHGAOPMGC<T> MCECAAFMCOO(Action<string> CAHJIPBOECD);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::JODHGAOPMGC<T> IPFGOHIHIOI(Action<string> CAHJIPBOECD);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class AGADMKMCAMG<T> : global::JODHGAOPMGC<T>, LGEFPKCLGPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private global::KCGHCNPGINP<T, T> OINNBFFGGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private global::EGPJGAAPCPL<T> FMFPFKMPGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private global::EGPJGAAPCPL<string> LAKDKLKJEAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private string KDIFPAMDOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private T LILKGIPDCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool KCPGBANIGDM;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public T MHMGLCIOEKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6D0BA0", Offset = "0x6CF9A0", VA = "0x1806D0BA0", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x3262220", Offset = "0x3261020", VA = "0x183262220", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool BDGLEMCAIID
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x6D0BC0", Offset = "0x6CF9C0", VA = "0x1806D0BC0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string GDFDHIAKAEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x6D0BB0", Offset = "0x6CF9B0", VA = "0x1806D0BB0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x2CFF700", Offset = "0x2CFE500", VA = "0x182CFF700", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x40B3FF0", Offset = "0x40B2DF0", VA = "0x1840B3FF0")]
	private void HKGFAOHKACC(T GGOKHMJBGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x40B42D0", Offset = "0x40B30D0", VA = "0x1840B42D0")]
	private void OLKFIFGNDOM(string IACFBMPPCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x40B3F40", Offset = "0x40B2D40", VA = "0x1840B3F40")]
	public void FLOLCMPEDIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x40B3EF0", Offset = "0x40B2CF0", VA = "0x1840B3EF0", Slot = "6")]
	public global::JODHGAOPMGC<T> CLPHIGGNLLF(Action<T, T> CKPNCGJCPNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x40B4150", Offset = "0x40B2F50", VA = "0x1840B4150", Slot = "7")]
	public global::JODHGAOPMGC<T> KGOFKKICCCA(Action<T, T> CKPNCGJCPNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x40B41A0", Offset = "0x40B2FA0", VA = "0x1840B41A0", Slot = "4")]
	public global::JODHGAOPMGC<T> LJFCIEFABHP(Action<T> CKPNCGJCPNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x40B4100", Offset = "0x40B2F00", VA = "0x1840B4100", Slot = "5")]
	public global::JODHGAOPMGC<T> JNMLPMKFKMA(Action<T> GBLOFGKMBKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x40B4230", Offset = "0x40B3030", VA = "0x1840B4230", Slot = "8")]
	public global::JODHGAOPMGC<T> MCECAAFMCOO(Action<string> CAHJIPBOECD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x40B4090", Offset = "0x40B2E90", VA = "0x1840B4090", Slot = "9")]
	public global::JODHGAOPMGC<T> IPFGOHIHIOI(Action<string> CAHJIPBOECD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x40B4380", Offset = "0x40B3180", VA = "0x1840B4380")]
	public AGADMKMCAMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class MCKPLNKGAFO
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class FHANMCDGAEO<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public global::JODHGAOPMGC<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public global::NBNDPFFHLHN<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x22E6440", Offset = "0x22E5240", VA = "0x1822E6440")]
		public FHANMCDGAEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x4009A20", Offset = "0x4008820", VA = "0x184009A20")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x365B200", Offset = "0x365A000", VA = "0x18365B200")]
	public static global::KOILDJEEFJD<T> JEIOEOGODCD<T>(this global::JODHGAOPMGC<T> GHGHBEPJNFM, Action<T> JAKHBAJPHJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class GFFHDAJEBGF<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public readonly struct IJJKHNOPPPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public readonly long NLAOCFOCLMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public readonly long MFKLDKHJNGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public readonly int MHPCJELDJFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public readonly int APDFEGLEMGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public readonly bool OHMEHBELFIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly string EMKINAHLLBJ;

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x3739790", Offset = "0x3738590", VA = "0x183739790")]
		public IJJKHNOPPPG(long NLAOCFOCLMO, int MHPCJELDJFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3739800", Offset = "0x3738600", VA = "0x183739800")]
		public IJJKHNOPPPG(long NLAOCFOCLMO, long MFKLDKHJNGF, int MHPCJELDJFL, int APDFEGLEMGI, bool OHMEHBELFIN, string EMKINAHLLBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x3739700", Offset = "0x3738500", VA = "0x183739700")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void JIHPBGHPHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x37396B0", Offset = "0x37384B0", VA = "0x1837396B0")]
		public int IBHMIKEPHDM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x3739770", Offset = "0x3738570", VA = "0x183739770")]
		public int NCGNONMKMKN(int JJLMKFLCCHH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x37395B0", Offset = "0x37383B0", VA = "0x1837395B0")]
		public double BDCMNENCLIB()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x3739620", Offset = "0x3738420", VA = "0x183739620")]
		public IJJKHNOPPPG BOFOAININCJ(long MFKLDKHJNGF, int APDFEGLEMGI)
		{
			return default(IJJKHNOPPPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class LDNBHEGFOMH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly TKey GKKFJKNNDIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly global::GFFHDAJEBGF<TKey> IPNOLEKMJNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private List<LDNBHEGFOMH> ELGHELJHGAP;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string PFOGICBGAOD
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x38F56F0", Offset = "0x38F44F0", VA = "0x1838F56F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x38F5850", Offset = "0x38F4650", VA = "0x1838F5850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public IEnumerable<LDNBHEGFOMH> ILLDNLANPEN
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x38F5830", Offset = "0x38F4630", VA = "0x1838F5830")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public IJJKHNOPPPG LLHJOJLFJLC
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0xD41D70", Offset = "0xD40B70", VA = "0x180D41D70")]
			[CompilerGenerated]
			get
			{
				return default(IJJKHNOPPPG);
			}
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x38F5880", Offset = "0x38F4680", VA = "0x1838F5880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x38F5990", Offset = "0x38F4790", VA = "0x1838F5990")]
		internal LDNBHEGFOMH(global::GFFHDAJEBGF<TKey> IPNOLEKMJNB, TKey CKMEBFKEHMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x38F5720", Offset = "0x38F4520", VA = "0x1838F5720")]
		public LDNBHEGFOMH JIMCEDOJODO(TKey CKMEBFKEHMO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x38F58B0", Offset = "0x38F46B0", VA = "0x1838F58B0")]
		public void OHFJJCNLJME(TKey CKMEBFKEHMO, Action<LDNBHEGFOMH> CIAILAMJPDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3DAC4C0", Offset = "0x3DAB2C0", VA = "0x183DAC4C0")]
		public T OHFJJCNLJME<T>(TKey CKMEBFKEHMO, Func<LDNBHEGFOMH, T> NICNKBALKJN)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x3DAC5B0", Offset = "0x3DAB3B0", VA = "0x183DAC5B0")]
		[AsyncStateMachine(typeof(DLMJBCNCOJN))]
		public Task<T> PPIPOBIMBJN<T>(TKey CKMEBFKEHMO, Func<LDNBHEGFOMH, Task<T>> NICNKBALKJN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x38F5540", Offset = "0x38F4340", VA = "0x1838F5540", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class FDCMKFGMABD : IEnumerable<(TKey, List<TKey>, IJJKHNOPPPG)>, IEnumerable, IEnumerator<(TKey, List<TKey>, IJJKHNOPPPG)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private (TKey key, List<TKey> path, IJJKHNOPPPG timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public global::GFFHDAJEBGF<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private IEnumerator<(TKey key, List<TKey> path, IJJKHNOPPPG timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		private (TKey, List<TKey>, IJJKHNOPPPG) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x38B2750", Offset = "0x38B1550", VA = "0x1838B2750", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, IJJKHNOPPPG));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x3FB1820", Offset = "0x3FB0620", VA = "0x183FB1820", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x38B2AA0", Offset = "0x38B18A0", VA = "0x1838B2AA0")]
		[DebuggerHidden]
		public FDCMKFGMABD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x38ADBE0", Offset = "0x38AC9E0", VA = "0x1838ADBE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x3FB1470", Offset = "0x3FB0270", VA = "0x183FB1470", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x3FB1880", Offset = "0x3FB0680", VA = "0x183FB1880")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x3FB17E0", Offset = "0x3FB05E0", VA = "0x183FB17E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x3FB1720", Offset = "0x3FB0520", VA = "0x183FB1720", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, IJJKHNOPPPG)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x3126360", Offset = "0x3125160", VA = "0x183126360", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class NIIPIBEIMPD : IEnumerable<(TKey, List<TKey>, IJJKHNOPPPG)>, IEnumerable, IEnumerator<(TKey, List<TKey>, IJJKHNOPPPG)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private (TKey key, List<TKey> path, IJJKHNOPPPG timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private LDNBHEGFOMH timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public LDNBHEGFOMH <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public global::GFFHDAJEBGF<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private IEnumerator<LDNBHEGFOMH> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private IEnumerator<(TKey key, List<TKey> path, IJJKHNOPPPG timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		private (TKey, List<TKey>, IJJKHNOPPPG) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x38B2750", Offset = "0x38B1550", VA = "0x1838B2750", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, IJJKHNOPPPG));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x3958270", Offset = "0x3957070", VA = "0x183958270", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x38B2AA0", Offset = "0x38B18A0", VA = "0x1838B2AA0")]
		[DebuggerHidden]
		public NIIPIBEIMPD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x39582D0", Offset = "0x39570D0", VA = "0x1839582D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x3957B80", Offset = "0x3956980", VA = "0x183957B80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3958370", Offset = "0x3957170", VA = "0x183958370")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x39583D0", Offset = "0x39571D0", VA = "0x1839583D0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3958230", Offset = "0x3957030", VA = "0x183958230", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x3958120", Offset = "0x3956F20", VA = "0x183958120", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, IJJKHNOPPPG)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x3958200", Offset = "0x3957000", VA = "0x183958200", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Action<TKey, IJJKHNOPPPG> LBDCEFOGFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Action<TKey, IJJKHNOPPPG> EHNHKIBBBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly Action<global::GFFHDAJEBGF<TKey>> GLNAPFKEFCO;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private const string LJLADAAPDMN = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly LDNBHEGFOMH APOJMEDMDAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool CGEHGMDPJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private int ADEEOBLOEGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly Stopwatch IBCKILPAMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly int GFJEAHIBMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private string LMNJKOHLOKO;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public LDNBHEGFOMH OHPEHJFDKIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6D0BB0", Offset = "0x6CF9B0", VA = "0x1806D0BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	[NotNull]
	public string PFOGICBGAOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x6CB7A0", Offset = "0x6CA5A0", VA = "0x1806CB7A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3763A50", Offset = "0x3762850", VA = "0x183763A50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public long ADKIIELFNPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3763B30", Offset = "0x3762930", VA = "0x183763B30")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int DLKCKAOMNGK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3763880", Offset = "0x3762680", VA = "0x183763880")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x3763B50", Offset = "0x3762950", VA = "0x183763B50")]
	public GFFHDAJEBGF(TKey PEIAOMELDIK, [Optional] int? MHPCJELDJFL, [Optional][CanBeNull] Stopwatch IBCKILPAMFE, [Optional] Action<TKey, IJJKHNOPPPG> LBDCEFOGFKJ, [Optional] Action<TKey, IJJKHNOPPPG> EHNHKIBBBMG, [Optional] Action<global::GFFHDAJEBGF<TKey>> GLNAPFKEFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x37637F0", Offset = "0x37625F0", VA = "0x1837637F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x37638D0", Offset = "0x37626D0", VA = "0x1837638D0")]
	public void LGGMHAHLAND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x37638B0", Offset = "0x37626B0", VA = "0x1837638B0")]
	public void FDNMMCMDEPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x37639C0", Offset = "0x37627C0", VA = "0x1837639C0")]
	[IteratorStateMachine(typeof(global::GFFHDAJEBGF<>.FDCMKFGMABD))]
	public IEnumerable<(TKey, List<TKey>, IJJKHNOPPPG)> MHFKFOEFGIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x37638F0", Offset = "0x37626F0", VA = "0x1837638F0")]
	[IteratorStateMachine(typeof(global::GFFHDAJEBGF<>.NIIPIBEIMPD))]
	private IEnumerable<(TKey, List<TKey>, IJJKHNOPPPG)> MHFKFOEFGIA(List<TKey> PAEKKCIOLNB, LDNBHEGFOMH KCNAPCGCLKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x3763AB0", Offset = "0x37628B0", VA = "0x183763AB0")]
	private (long, int) NACBEIBJIOJ()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class PCOPNMNOACM<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut PIKMOJPIGFK(global::GFFHDAJEBGF<TKey> IPNOLEKMJNB);

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x22E6440", Offset = "0x22E5240", VA = "0x1822E6440")]
	protected PCOPNMNOACM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public abstract class ANGMCFFEIIF<TKey> : global::PCOPNMNOACM<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate string EJFMFIJHKDC(TKey CKMEBFKEHMO);

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x4D024E0", Offset = "0x4D012E0", VA = "0x184D024E0")]
	protected string ECKJCBOIJLO(double FEPNKFEKAKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x4D02480", Offset = "0x4D01280", VA = "0x184D02480")]
	protected string AALNFAPNDKM(int MMLIFILHPPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x4D02550", Offset = "0x4D01350", VA = "0x184D02550")]
	private static string OODDMOLANDL(TKey CKMEBFKEHMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x4D026C0", Offset = "0x4D014C0", VA = "0x184D026C0", Slot = "4")]
	public override string PIKMOJPIGFK(global::GFFHDAJEBGF<TKey> IPNOLEKMJNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x4D02590", Offset = "0x4D01390", VA = "0x184D02590")]
	public string PIKMOJPIGFK(global::GFFHDAJEBGF<TKey> IPNOLEKMJNB, [NotNull] EJFMFIJHKDC DICIHHLNCFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string AONBJGIJLCA(global::GFFHDAJEBGF<TKey> IPNOLEKMJNB, [NotNull] EJFMFIJHKDC DICIHHLNCFD);

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x3739340", Offset = "0x3738140", VA = "0x183739340")]
	protected ANGMCFFEIIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class KAOIABBLPCN<TKey> : global::PCOPNMNOACM<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public delegate string HNNIOIHHLOJ(TKey CKMEBFKEHMO);

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private const int DMODNPACABM = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly string JFHENCLPFJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly double DCPHACKGDKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly bool IDOLFGGGCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly int NJBCFOHJKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly ISet<string> FLEDGFDEHAF;

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x3717FF0", Offset = "0x3716DF0", VA = "0x183717FF0")]
	private static string OODDMOLANDL(TKey CKMEBFKEHMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x3718620", Offset = "0x3717420", VA = "0x183718620")]
	public KAOIABBLPCN(string JFHENCLPFJP = "F2", double DCPHACKGDKK = double.MaxValue, bool IDOLFGGGCMG = false, int NJBCFOHJKOE = int.MaxValue, [Optional] ISet<string> FLEDGFDEHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x3718570", Offset = "0x3717370", VA = "0x183718570", Slot = "4")]
	public override Dictionary<string, string> PIKMOJPIGFK(global::GFFHDAJEBGF<TKey> IPNOLEKMJNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x3717F10", Offset = "0x3716D10", VA = "0x183717F10")]
	private bool NIOHKEOBILF(string IAPJPLCAJAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x3718030", Offset = "0x3716E30", VA = "0x183718030")]
	public Dictionary<string, string> PIKMOJPIGFK(global::GFFHDAJEBGF<TKey> IPNOLEKMJNB, HNNIOIHHLOJ DICIHHLNCFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x3717D60", Offset = "0x3716B60", VA = "0x183717D60")]
	private string FOJGDFGFHCE(StringBuilder KMDDLPLCJHJ, List<TKey> BCIKDAFIIDH, HNNIOIHHLOJ DICIHHLNCFD, bool EBCHHFIADHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x3717BE0", Offset = "0x37169E0", VA = "0x183717BE0")]
	private static void DGICGMHPEFJ(StringBuilder AEHNOEBKCHC, string DDFODFNKKKO, bool DIFGCEGIJBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class DPLHFKMKDIB<TKey> : global::ANGMCFFEIIF<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct DIMGLFIPIFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public EJFMFIJHKDC keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static global::DPLHFKMKDIB<TKey> GEHLGJGIEOF;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private const int NKDFCEHPEOP = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly string[] BLKJGCEKDLK;

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x4750070", Offset = "0x474EE70", VA = "0x184750070")]
	private DPLHFKMKDIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x474F080", Offset = "0x474DE80", VA = "0x18474F080", Slot = "5")]
	protected override string AONBJGIJLCA(global::GFFHDAJEBGF<TKey> IPNOLEKMJNB, EJFMFIJHKDC DICIHHLNCFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x474EF90", Offset = "0x474DD90", VA = "0x18474EF90")]
	[CompilerGenerated]
	internal static string AFOJOEFBBLG(string MIDIPBFIJLK, TKey CKMEBFKEHMO, ref DIMGLFIPIFN P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class GGHMCJBIDHG<TKey> : global::ANGMCFFEIIF<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class MPGJKFGAACH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public EJFMFIJHKDC keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x22E6440", Offset = "0x22E5240", VA = "0x1822E6440")]
		public MPGJKFGAACH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x3124870", Offset = "0x3123670", VA = "0x183124870")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x3764660", Offset = "0x3763460", VA = "0x183764660", Slot = "5")]
	protected override string AONBJGIJLCA(global::GFFHDAJEBGF<TKey> IPNOLEKMJNB, EJFMFIJHKDC DICIHHLNCFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x3764FB0", Offset = "0x3763DB0", VA = "0x183764FB0")]
	public GGHMCJBIDHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public sealed class FGOLDMDGFAJ : global::GFFHDAJEBGF<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class PLMMMPLHFPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public Action<FGOLDMDGFAJ> callback;

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public PLMMMPLHFPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x1FE70C0", Offset = "0x1FE5EC0", VA = "0x181FE70C0")]
		internal void <Wrap>b__0(global::GFFHDAJEBGF<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x1FE1D90", Offset = "0x1FE0B90", VA = "0x181FE1D90")]
	public FGOLDMDGFAJ([Optional] string DNFIGNLNBEA, [Optional] int? MHPCJELDJFL, [Optional] Stopwatch IBCKILPAMFE, [Optional] Action<string, IJJKHNOPPPG> LBDCEFOGFKJ, [Optional] Action<string, IJJKHNOPPPG> EHNHKIBBBMG, [Optional] Action<FGOLDMDGFAJ> GLNAPFKEFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x1FE1CB0", Offset = "0x1FE0AB0", VA = "0x181FE1CB0")]
	private static Action<global::GFFHDAJEBGF<string>> OHFJJCNLJME(Action<FGOLDMDGFAJ> JAKHBAJPHJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class MHKGNAHKGJB
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private class HGALDPKMBCM : MHKGNAHKGJB
	{
		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public static MHKGNAHKGJB GEHLGJGIEOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x1FE2230", Offset = "0x1FE1030", VA = "0x181FE2230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public override DateTime CHPEFCFCGHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x1FE22A0", Offset = "0x1FE10A0", VA = "0x181FE22A0", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public override float EBFLDGHFPFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x1FE2290", Offset = "0x1FE1090", VA = "0x181FE2290", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x1FE2390", Offset = "0x1FE1190", VA = "0x181FE2390")]
		public HGALDPKMBCM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static MHKGNAHKGJB PMOMDMAPHBD;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static MHKGNAHKGJB JLGGJMINNJN
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x1FE5100", Offset = "0x1FE3F00", VA = "0x181FE5100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public abstract DateTime CHPEFCFCGHF
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public abstract float EBFLDGHFPFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	protected MHKGNAHKGJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class FMFJEHGAGPP : global::KGMMEBIPDJJ<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x1FE21B0", Offset = "0x1FE0FB0", VA = "0x181FE21B0")]
	public FMFJEHGAGPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class KGMMEBIPDJJ<T> : global::JOPKPGPOBHH<T>, BILBGOMOIJP, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Task<T> GGOGLDCCAMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private Task HJGAKGHLMMK
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x274F730", Offset = "0x274E530", VA = "0x18274F730", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public global::KOILDJEEFJD<T> MCJMIDFMEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	private FFFHIGBANBM BDLLNPCKAGP
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x2CFEF30", Offset = "0x2CFDD30", VA = "0x182CFEF30", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x39BE5B0", Offset = "0x39BD3B0", VA = "0x1839BE5B0")]
	public KGMMEBIPDJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class NOGFOAKBKBO : global::EKNHKNFALPF<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x1FE5DC0", Offset = "0x1FE4BC0", VA = "0x181FE5DC0")]
	public NOGFOAKBKBO(Exception HOJKPDKANGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class EKNHKNFALPF<T> : global::JOPKPGPOBHH<T>, BILBGOMOIJP, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public Task<T> GGOGLDCCAMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	private Task HJGAKGHLMMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x274F730", Offset = "0x274E530", VA = "0x18274F730", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public global::KOILDJEEFJD<T> MCJMIDFMEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	private FFFHIGBANBM BDLLNPCKAGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x2CFEF30", Offset = "0x2CFDD30", VA = "0x182CFEF30", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x36D7310", Offset = "0x36D6110", VA = "0x1836D7310")]
	public EKNHKNFALPF(Exception HOJKPDKANGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface BILBGOMOIJP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000069")]
	[NotNull]
	Task GGOGLDCCAMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	[NotNull]
	FFFHIGBANBM MCJMIDFMEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public interface JOPKPGPOBHH<T> : BILBGOMOIJP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	[NotNull]
	new Task<T> GGOGLDCCAMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	[NotNull]
	new global::KOILDJEEFJD<T> MCJMIDFMEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public abstract class NMMGNJDGKMC<TTask, T> : global::JOPKPGPOBHH<T>, BILBGOMOIJP, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private sealed class EEFEEIDJFNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public global::NMMGNJDGKMC<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x22E6440", Offset = "0x22E5240", VA = "0x1822E6440")]
		public EEFEEIDJFNA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static bool BNJGFPJPGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly Task<T> OJKEFJOHEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	protected readonly CancellationTokenSource PPJCBPHOKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private bool CGEHGMDPJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private SynchronizationContext IAIIOHABAIE;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Task<T> GGOGLDCCAMN
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	private Task HJGAKGHLMMK
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public global::KOILDJEEFJD<T> MCJMIDFMEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	private FFFHIGBANBM BDLLNPCKAGP
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x2C00350", Offset = "0x2BFF150", VA = "0x182C00350", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool MCKHJMONIDM
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x701080", Offset = "0x6FFE80", VA = "0x180701080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x3966CF0", Offset = "0x3965AF0", VA = "0x183966CF0")]
	static NMMGNJDGKMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x3967030", Offset = "0x3965E30", VA = "0x183967030")]
	protected NMMGNJDGKMC(TTask OJKEFJOHEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x39667E0", Offset = "0x39655E0", VA = "0x1839667E0", Slot = "1")]
	~NMMGNJDGKMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x39667B0", Offset = "0x39655B0", VA = "0x1839667B0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x3966850", Offset = "0x3965650", VA = "0x183966850")]
	private void LFLAMKKDLCF(bool DDAMDLDCDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T PCLIMKPLCMB(TTask KICCKAGFIEB);

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void FKOHEBHACOM();

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x3966B30", Offset = "0x3965930", VA = "0x183966B30")]
	[CompilerGenerated]
	private void LMGFICPBJAH(object HNDKIKCHCLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface FANKFMIEBOM
{
	[Cpp2IlInjected.Token(Token = "0x17000072")]
	float GDNOICLDJNL
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event COMIKCIIAJA LFHFDGFICJB;
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class AFGHBOLCFKM : FANKFMIEBOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public readonly struct EFNMPPDHAPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public readonly float LCDANBPKPJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public readonly float EKEBNPMDPBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		internal readonly bool GLKFOIMGEAG;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public float BJEJGEAMGOH
		{
			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x1FE0810", Offset = "0x1FDF610", VA = "0x181FE0810")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x1FE09A0", Offset = "0x1FDF7A0", VA = "0x181FE09A0")]
		public EFNMPPDHAPC(float CPMHNPIOINN, float DAFMFEFJEFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x1FE0820", Offset = "0x1FDF620", VA = "0x181FE0820", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class BNOCAHBEAOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public AFGHBOLCFKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public BNOCAHBEAOP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly int DOOAOHCDEFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private int KPPCKIHKDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly FANKFMIEBOM[] NIOIMJCKDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly COMIKCIIAJA[] IDFDCEEBKGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly EFNMPPDHAPC[] ILFFNHJKKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private EFNMPPDHAPC EFIDAOLPAKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly PKMLHEJBLNO CCICMIGCBMB;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public EFNMPPDHAPC DAIIDFDIFMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x15EA410", Offset = "0x15E9210", VA = "0x1815EA410")]
		get
		{
			return default(EFNMPPDHAPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float GDNOICLDJNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x1FDEE80", Offset = "0x1FDDC80", VA = "0x181FDEE80", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event COMIKCIIAJA LFHFDGFICJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x1FDF3B0", Offset = "0x1FDE1B0", VA = "0x181FDF3B0", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x1FDF2F0", Offset = "0x1FDE0F0", VA = "0x181FDF2F0", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x1FDF470", Offset = "0x1FDE270", VA = "0x181FDF470")]
	public AFGHBOLCFKM(int DOOAOHCDEFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x1FDEBC0", Offset = "0x1FDD9C0", VA = "0x181FDEBC0")]
	public PKMLHEJBLNO COOFPEBHOAM(EFNMPPDHAPC KDFKOIMENHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x1FDEEA0", Offset = "0x1FDDCA0", VA = "0x181FDEEA0")]
	public void GLPJHLFLILO(FANKFMIEBOM MGCDLCGFPNL, [Optional] EFNMPPDHAPC OBGFKAADPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x1FDEC50", Offset = "0x1FDDA50", VA = "0x181FDEC50")]
	internal int DMLIELKNFBC(FANKFMIEBOM GIBAMNFCADF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x1FDECA0", Offset = "0x1FDDAA0", VA = "0x181FDECA0")]
	internal EFNMPPDHAPC DNGJINGIJJG(int DJIEOHJNDEK)
	{
		return default(EFNMPPDHAPC);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x1FDECF0", Offset = "0x1FDDAF0", VA = "0x181FDECF0", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public delegate void COMIKCIIAJA(float KBBPHBNKMKF);
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal static class DGLGIKENGKD
{
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	internal const float KADOONGFEAL = 0.0001f;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public static class EJPAPKLICJA
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private class MFIIBIMFHJO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private readonly FANKFMIEBOM GIBAMNFCADF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private readonly COMIKCIIAJA JAKHBAJPHJL;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x1FE5070", Offset = "0x1FE3E70", VA = "0x181FE5070")]
		public MFIIBIMFHJO(FANKFMIEBOM GIBAMNFCADF, COMIKCIIAJA JAKHBAJPHJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x1FE5020", Offset = "0x1FE3E20", VA = "0x181FE5020", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x1FE1140", Offset = "0x1FDFF40", VA = "0x181FE1140")]
	internal static bool NMIEIOLDMDL(float EFBCPNIKEHB, float BFLEMGIJKLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x1582FB0", Offset = "0x1581DB0", VA = "0x181582FB0")]
	internal static float EDCMLLNBJCA(float EFBCPNIKEHB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x1FE1080", Offset = "0x1FDFE80", VA = "0x181FE1080")]
	public static IDisposable LJDGFBDIMNK(this FANKFMIEBOM GIBAMNFCADF, COMIKCIIAJA JAKHBAJPHJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class PKMLHEJBLNO : FANKFMIEBOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private float KBBPHBNKMKF;

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float GDNOICLDJNL
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x6E4180", Offset = "0x6E2F80", VA = "0x1806E4180", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x1FE6EC0", Offset = "0x1FE5CC0", VA = "0x181FE6EC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event COMIKCIIAJA LFHFDGFICJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x1FE7020", Offset = "0x1FE5E20", VA = "0x181FE7020", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x1FE6F80", Offset = "0x1FE5D80", VA = "0x181FE6F80", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public PKMLHEJBLNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class EHBKIPHFFBC
{
	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x1FE0C00", Offset = "0x1FDFA00", VA = "0x181FE0C00")]
	[NotNull]
	public static byte[] EFCHNMDECCI(this MDKBNPDLGEB AFHBGNDECBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x1FE0C70", Offset = "0x1FDFA70", VA = "0x181FE0C70")]
	[NotNull]
	public static byte[] EFCHNMDECCI(this MDKBNPDLGEB AFHBGNDECBD, HashAlgorithmName EHCDAGILKOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x1FE0CE0", Offset = "0x1FDFAE0", VA = "0x181FE0CE0")]
	public static bool GILBDMBNAOO([CanBeNull] this MDKBNPDLGEB AFHBGNDECBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x1FE0E70", Offset = "0x1FDFC70", VA = "0x181FE0E70")]
	public static bool GILBDMBNAOO([CanBeNull] this MDKBNPDLGEB AFHBGNDECBD, out string KDIFPAMDOPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x1FE1010", Offset = "0x1FDFE10", VA = "0x181FE1010")]
	private static string OELKCCOLEAG([CanBeNull] byte[] GACPBGKAIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x1FE0AE0", Offset = "0x1FDF8E0", VA = "0x181FE0AE0")]
	private static bool APJICIDCIPP([NotNull] MDKBNPDLGEB AFHBGNDECBD, [CanBeNull] out byte[] ELKAJEBMCAC, [CanBeNull] out byte[] IKHAOGDOPCB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public static class IKIJMNDKPOK
{
	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x1FE25F0", Offset = "0x1FE13F0", VA = "0x181FE25F0")]
	[NotNull]
	public static byte[] EFCHNMDECCI(this NJEKPDLCGCA EOPJHPGBAAA, byte[] CFNLKEBNFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x1FE2630", Offset = "0x1FE1430", VA = "0x181FE2630")]
	[NotNull]
	public static byte[] EFCHNMDECCI(this NJEKPDLCGCA EOPJHPGBAAA, HashAlgorithmName EHCDAGILKOG, byte[] CFNLKEBNFGI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface NJEKPDLCGCA
{
	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash JJOJGACMMLF);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface MDKBNPDLGEB : NJEKPDLCGCA
{
	[Cpp2IlInjected.Token(Token = "0x17000077")]
	[CanBeNull]
	byte[] FJDDFOKAEBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	[CanBeNull]
	byte[] HAHPBLILGFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	UnityEngine.Object NCFDONIJNPB
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public static class LICOIBBHAPP
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private class DJPPPOAHCOC : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x1FDFD50", Offset = "0x1FDEB50", VA = "0x181FDFD50")]
		public DJPPPOAHCOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x1FDFCF0", Offset = "0x1FDEAF0", VA = "0x181FDFCF0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private const byte HPOBKDJLHEN = 1;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private const byte IAHALCKBELF = 0;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static readonly ArrayPool<byte> KFHBNLEKHMA;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static bool IIECPKNOGNH;

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x3C73510", Offset = "0x3C72310", VA = "0x183C73510")]
	[Conditional("UNITY_EDITOR")]
	private static void FDLJBHIALAG<T>(params T[] DBMDKMDGOKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3070", Offset = "0x1FE1E70", VA = "0x181FE3070")]
	public static IDisposable GEEODOBEHEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x1FE2F80", Offset = "0x1FE1D80", VA = "0x181FE2F80")]
	public static void FFLDOGLMLNL(this IncrementalHash GLDGGMCABCH, [CanBeNull] GameObject NGIKODIIBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x3C73800", Offset = "0x3C72600", VA = "0x183C73800")]
	public static void FFLDOGLMLNL<T>(this IncrementalHash GLDGGMCABCH, [CanBeNull] T BFKBHAILEEA) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x3C738D0", Offset = "0x3C726D0", VA = "0x183C738D0")]
	public static void KCHJEFCMMEK<T>(this IncrementalHash GLDGGMCABCH, [CanBeNull] T EOPJHPGBAAA) where T : NJEKPDLCGCA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x3C74050", Offset = "0x3C72E50", VA = "0x183C74050")]
	public static void LIEBGACLLMO<T>(this IncrementalHash GLDGGMCABCH, [CanBeNull] IList<T> NKCHBIFAKAF) where T : NJEKPDLCGCA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x1FE2CB0", Offset = "0x1FE1AB0", VA = "0x181FE2CB0")]
	private static bool EACFELLAOKP([CanBeNull] NJEKPDLCGCA EOPJHPGBAAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3C40", Offset = "0x1FE2A40", VA = "0x181FE3C40")]
	public static void PKCCDBEFIIB(this IncrementalHash JJOJGACMMLF, [CanBeNull] string NGJHLCDIFCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x1FE32D0", Offset = "0x1FE20D0", VA = "0x181FE32D0")]
	public static void GKHNMDIPLKH(this IncrementalHash JJOJGACMMLF, long PHFIKFCPMNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x1FE2D40", Offset = "0x1FE1B40", VA = "0x181FE2D40")]
	public static void EJFAFABMECG(this IncrementalHash JJOJGACMMLF, int JFEHNBKJCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3730", Offset = "0x1FE2530", VA = "0x181FE3730")]
	public static void MLAALJNDABB(this IncrementalHash JJOJGACMMLF, short PHNMDFILIMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3960", Offset = "0x1FE2760", VA = "0x181FE3960")]
	public static void NJMOEKMBHLN(this IncrementalHash JJOJGACMMLF, byte HAENBEOBPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3560", Offset = "0x1FE2360", VA = "0x181FE3560")]
	public static void LALFCDNJMCO(this IncrementalHash JJOJGACMMLF, bool EPMKHPONFBM, bool GABABFACEJM = false, bool LOPGOMAMHEC = false, bool BMJLHCHPGPA = false, bool LCFFPHPPOCH = false, bool JMOLENBLFHO = false, bool JAAAOIDLHMB = false, bool ONAFCOGELFH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x3C73960", Offset = "0x3C72760", VA = "0x183C73960")]
	public static void LEEKADPAMJG<T>(this IncrementalHash JJOJGACMMLF, T OBOKCPGHOGM) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x1FE34A0", Offset = "0x1FE22A0", VA = "0x181FE34A0")]
	public static void GMENICHJMCP(this IncrementalHash JJOJGACMMLF, float DKLMBBIEIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3900", Offset = "0x1FE2700", VA = "0x181FE3900")]
	public static void NHIGFEPFPGJ(this IncrementalHash JJOJGACMMLF, double CJOKBODMBMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3CA0", Offset = "0x1FE2AA0", VA = "0x181FE3CA0")]
	public static void PPADBNCCAMI(this IncrementalHash JJOJGACMMLF, ulong LDGIJNJPKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3500", Offset = "0x1FE2300", VA = "0x181FE3500")]
	public static void JFNOLNJAEDD(this IncrementalHash JJOJGACMMLF, uint JCFPCLFOMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x1FE2F10", Offset = "0x1FE1D10", VA = "0x181FE2F10")]
	public static void FFEFCKOOAKC(this IncrementalHash JJOJGACMMLF, ushort DMAMMGDEGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3AD0", Offset = "0x1FE28D0", VA = "0x181FE3AD0")]
	public static void PFHFONBFFKH(this IncrementalHash JJOJGACMMLF, Vector3 BNABGPJCKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3110", Offset = "0x1FE1F10", VA = "0x181FE3110")]
	public static void GFIADOJPMOI(this IncrementalHash JJOJGACMMLF, Quaternion MBJKEKHGDNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class KCFOIOEDKNO : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public readonly Type PENHGJBDHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly string GEEEMGNOAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public readonly bool EBFBAOMBECC;

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x1FE2980", Offset = "0x1FE1780", VA = "0x181FE2980")]
	public KCFOIOEDKNO(Type KDAEKCPFLMP, string AFCNLMEJCOC, bool PJDPEKDEHON = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class IEGKPKJPHJM : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x1FE2470", Offset = "0x1FE1270", VA = "0x181FE2470")]
	public IEGKPKJPHJM(string IACFBMPPCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x1FE23F0", Offset = "0x1FE11F0", VA = "0x181FE23F0")]
	public IEGKPKJPHJM(string IACFBMPPCKF, Exception KABEOLDCMCF)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x6BF380", Offset = "0x6BE180", VA = "0x1806BF380")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x8E1D20", Offset = "0x8E0B20", VA = "0x1808E1D20")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public T this[int LFDIJNFJPLK, int IDGGHEPILHN]
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x4737AA0", Offset = "0x47368A0", VA = "0x184737AA0")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x4737B40", Offset = "0x4736940", VA = "0x184737B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x4737A10", Offset = "0x4736810", VA = "0x184737A10")]
		public Array2D(uint IHIELFHBHBE, uint KDPPAHMOANJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x4737990", Offset = "0x4736790", VA = "0x184737990")]
		public void KJHAHNAAJMI()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x1FDF5F0", Offset = "0x1FDE3F0", VA = "0x181FDF5F0")]
		public Array2DVector3(uint IHIELFHBHBE, uint KDPPAHMOANJ)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct FADDOCMKOPD
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public delegate bool PEEBNJEAEGK(string JMEOBFKFIJM, FADDOCMKOPD DKHJIKOPKDG);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public int OBOKCPGHOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public string AKLNPFACBII;

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x1FE14F0", Offset = "0x1FE02F0", VA = "0x181FE14F0")]
	public static Dictionary<string, FADDOCMKOPD> HJIHABECOEO(Type ABNIGGGPBPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x1FE11C0", Offset = "0x1FDFFC0", VA = "0x181FE11C0")]
	public static Dictionary<string, FADDOCMKOPD> FIOLDHDBDKD(Type ABNIGGGPBPD, PEEBNJEAEGK CMPPFKOKKMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x1FE17E0", Offset = "0x1FE05E0", VA = "0x181FE17E0")]
	public static Dictionary<int, string> LCAFLBPAKLH(Dictionary<string, FADDOCMKOPD> PHBCKPEIIAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
internal static class LGJFPADHCOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public const int DADHHAODGJF = -1;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public const int KBMHGJECHMN = 0;
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[DefaultMember("Item")]
public class ABEGEKCKNMO<THandle, TValue> : IDisposable where THandle : struct, GHFDCEBDMDI where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly List<THandle> NEJGCKJBOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly List<TValue> FLHOJBEDKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly Func<TValue> DENJJNBIMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly Action<TValue> OLHCOCCOHII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private int PAMPFMPHBHP;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public TValue BADELHLICNG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x40AAC80", Offset = "0x40A9A80", VA = "0x1840AAC80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x40AADD0", Offset = "0x40A9BD0", VA = "0x1840AADD0")]
	public ABEGEKCKNMO(Action<TValue> OLHCOCCOHII, [Optional] Func<TValue> DENJJNBIMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x40AA5E0", Offset = "0x40A93E0", VA = "0x1840AA5E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x4CAC630", Offset = "0x4CAB430", VA = "0x184CAC630")]
	public THandle DIMOBFAICBM()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x40AA660", Offset = "0x40A9460", VA = "0x1840AA660")]
	public THandle EKGLGHAFJEH(TValue DPJGMDFEIDL)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x40AAD20", Offset = "0x40A9B20", VA = "0x1840AAD20")]
	public bool PPEAGPDBOCM(THandle ODABKCNLMCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x40AA510", Offset = "0x40A9310", VA = "0x1840AA510")]
	public bool DMKMELLNHHE(THandle ODABKCNLMCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x40AA7A0", Offset = "0x40A95A0", VA = "0x1840AA7A0")]
	public bool GBLHCMBLLEL(THandle ODABKCNLMCP, out TValue DPJGMDFEIDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x40AA900", Offset = "0x40A9700", VA = "0x1840AA900")]
	public TValue HEOCMNIHPLM(THandle ODABKCNLMCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x40AA840", Offset = "0x40A9640", VA = "0x1840AA840")]
	public bool GPGONAPLKOC(THandle ODABKCNLMCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x40AACF0", Offset = "0x40A9AF0", VA = "0x1840AACF0")]
	private THandle PLNEFFOLLEN(int DJIEOHJNDEK)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x40AAA10", Offset = "0x40A9810", VA = "0x1840AAA10")]
	private TValue JEIOEOGODCD(int DJIEOHJNDEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x40AACB0", Offset = "0x40A9AB0", VA = "0x1840AACB0")]
	private void OKDBCBKIENL(int DJIEOHJNDEK, in THandle ODABKCNLMCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x40AA950", Offset = "0x40A9750", VA = "0x1840AA950")]
	private void HKGFAOHKACC(int DJIEOHJNDEK, in TValue DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x40AAA40", Offset = "0x40A9840", VA = "0x1840AAA40")]
	private THandle LNDOMBNOBHH()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x40AA320", Offset = "0x40A9120", VA = "0x1840AA320")]
	private void CBHKOAOJMNA(THandle ODABKCNLMCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x40AA8F0", Offset = "0x40A96F0", VA = "0x1840AA8F0")]
	private int HAHOMHDABDE(int LLNMOPOJDNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x40AAC70", Offset = "0x40A9A70", VA = "0x1840AAC70")]
	private bool MPIKIDPDPJG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0xB83FE0", Offset = "0xB82DE0", VA = "0x180B83FE0")]
	private void HEIFIPHJKAJ(THandle ODABKCNLMCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x40AA990", Offset = "0x40A9790", VA = "0x1840AA990")]
	private bool IILDJHOKGPL(out THandle ODABKCNLMCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x40AA6D0", Offset = "0x40A94D0", VA = "0x1840AA6D0")]
	private bool FDMDIKJDMPM(out THandle ODABKCNLMCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x40AA2C0", Offset = "0x40A90C0", VA = "0x1840AA2C0")]
	private void BAIEGCMLPLD(THandle ODABKCNLMCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x40AAB50", Offset = "0x40A9950", VA = "0x1840AAB50")]
	private void MEHHFIIEFOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public interface GHFDCEBDMDI
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	int NCHPHHOHCKF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	int NPFJJNLPIKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public interface DPOFMDICJLA<T> : GHFDCEBDMDI, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class IGIOHEMMPEK
{
	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x16ED010", Offset = "0x16EBE10", VA = "0x1816ED010")]
	public static bool GJIKNECLAMC<T>(this T ODABKCNLMCP, T BNIMMCIKNIE) where T : struct, GHFDCEBDMDI
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x3F77A80", Offset = "0x3F76880", VA = "0x183F77A80")]
	public static bool GLKFOIMGEAG<T>(this T ODABKCNLMCP) where T : struct, GHFDCEBDMDI
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x1FE24E0", Offset = "0x1FE12E0", VA = "0x181FE24E0")]
	public static string JJHHFPAMEGJ(this GHFDCEBDMDI ODABKCNLMCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class LPMJGAAGNOJ
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private enum EPDEFGKFGNJ : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private int JJOJGACMMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private bool KCAEIMLJDMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private EPDEFGKFGNJ AJCEDEPGCCG;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public bool BHJINDJNMEB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x1FE4ED0", Offset = "0x1FE3CD0", VA = "0x181FE4ED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool GLFOCDHBEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x1FE3FF0", Offset = "0x1FE2DF0", VA = "0x181FE3FF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4EE0", Offset = "0x1FE3CE0", VA = "0x181FE4EE0")]
	public LPMJGAAGNOJ(bool KCAEIMLJDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4480", Offset = "0x1FE3280", VA = "0x181FE4480")]
	public void DACIJBNLOHE(object LOPIEGGIDMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4B70", Offset = "0x1FE3970", VA = "0x181FE4B70")]
	public void FJHMPOJDMKD(int DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4D90", Offset = "0x1FE3B90", VA = "0x181FE4D90")]
	public void MOLGJBFOPEK(uint ENMPJEPEGCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4040", Offset = "0x1FE2E40", VA = "0x181FE4040")]
	public void BKHOPGHHKHG(bool IGFAFHOGPLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4000", Offset = "0x1FE2E00", VA = "0x181FE4000")]
	public void BIOFPMNIACH(long BJILMBMBBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x1FE40D0", Offset = "0x1FE2ED0", VA = "0x181FE40D0")]
	public void CBMBBLIDAPB(ulong DGNMMGANNAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4C10", Offset = "0x1FE3A10", VA = "0x181FE4C10")]
	public void GLIGIEJFNKJ(string BJDHKMNDFAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4D00", Offset = "0x1FE3B00", VA = "0x181FE4D00")]
	public void MMHLEOKDIOH(Enum HOJKPDKANGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4DA0", Offset = "0x1FE3BA0", VA = "0x181FE4DA0")]
	public void OIMBMHDIDPF(IList GHOABBJLFEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x3C760E0", Offset = "0x3C74EE0", VA = "0x183C760E0")]
	public void IGCONFJEDHE<T, U>(Dictionary<T, U> KHCLPFJGIID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4110", Offset = "0x1FE2F10", VA = "0x181FE4110")]
	private void CGFBOPINDHF(IDictionary KHCLPFJGIID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4B00", Offset = "0x1FE3900", VA = "0x181FE4B00")]
	public int DADMPGJPPHO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4060", Offset = "0x1FE2E60", VA = "0x181FE4060")]
	public short BOBPDCHOEOG()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4CF0", Offset = "0x1FE3AF0", VA = "0x181FE4CF0")]
	public void KJHAHNAAJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4C80", Offset = "0x1FE3A80", VA = "0x181FE4C80")]
	private void GNHIAMMPFMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public abstract class JCHBJOGACIJ<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	internal class JFKHGDJPGLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public TNode BIKHFKCJEPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public TNode KICGHGEEADG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public DPALPFCJOAH AFAIENJNNPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public List<DPALPFCJOAH> LCGGDGNMADH;

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x22E6440", Offset = "0x22E5240", VA = "0x1822E6440")]
		public JFKHGDJPGLF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	internal struct DPALPFCJOAH : IComparable<DPALPFCJOAH>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public int OHLEMHGCIOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public TClaimant CHGPEEBKHPM;

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xAEAD20", Offset = "0xAE9B20", VA = "0x180AEAD20")]
		public DPALPFCJOAH(int OHLEMHGCIOH, TClaimant CHGPEEBKHPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x474DC30", Offset = "0x474CA30", VA = "0x18474DC30")]
		public bool DOJLKAGOIBK(in DPALPFCJOAH BNIMMCIKNIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x474DC90", Offset = "0x474CA90", VA = "0x18474DC90")]
		public bool FOJHHBONOIC(in DPALPFCJOAH BNIMMCIKNIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x474DC20", Offset = "0x474CA20", VA = "0x18474DC20", Slot = "4")]
		public int CompareTo(DPALPFCJOAH BNIMMCIKNIE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x474DCA0", Offset = "0x474CAA0", VA = "0x18474DCA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public enum OLKMACMEBLI
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class IJGEFNLKOJM : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public global::JCHBJOGACIJ<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x2C09180", Offset = "0x2C07F80", VA = "0x182C09180")]
		[DebuggerHidden]
		public IJGEFNLKOJM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x37393B0", Offset = "0x37381B0", VA = "0x1837393B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x3739570", Offset = "0x3738370", VA = "0x183739570", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x3739490", Offset = "0x3738290", VA = "0x183739490", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x2BFB400", Offset = "0x2BFA200", VA = "0x182BFB400", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static readonly global::DEBFKAJDONP<JFKHGDJPGLF> JGJGGKLAIFN;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static readonly global::DEBFKAJDONP<List<DPALPFCJOAH>> BCMFBNBMNHN;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static int NDFDHEHPAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	internal readonly Dictionary<TClaimant, TNode> FAKDDFPHDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	internal readonly Dictionary<TNode, JFKHGDJPGLF> ENOPJNAGMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private OLKMACMEBLI LBPMHDKPAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private bool DNDEJBANJLE;

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode GCHFIHMHOPE(TNode EGEEDBJEODH);

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void MILEHFKIPBJ(TNode EGEEDBJEODH, TClaimant CELINDPIEHD, TClaimant KLIIOKNHACB);

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x3AF3D90", Offset = "0x3AF2B90", VA = "0x183AF3D90")]
	public JCHBJOGACIJ(OLKMACMEBLI LBPMHDKPAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x3AF3310", Offset = "0x3AF2110", VA = "0x183AF3310")]
	public void JDDPJJHEDPD(TNode EGEEDBJEODH, TNode DDNBMNPALIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x3AF3210", Offset = "0x3AF2010", VA = "0x183AF3210")]
	public void HPJCFLJJAGM(TClaimant CHGPEEBKHPM, TNode LIPOFCBDAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x3AF2C80", Offset = "0x3AF1A80", VA = "0x183AF2C80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x3AF2640", Offset = "0x3AF1440", VA = "0x183AF2640")]
	private void AGDDNCGGOEF(TClaimant CHGPEEBKHPM, TNode LEPMJMHJPGK, TNode LIPOFCBDAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x3AF2C20", Offset = "0x3AF1A20", VA = "0x183AF2C20")]
	private int DLOJCEJDOMD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x3AF3980", Offset = "0x3AF2780", VA = "0x183AF3980")]
	private void PMEMOHFJFBK(TClaimant CHGPEEBKHPM, TNode POMFCKNMLCP, TNode NKHKMPCFDCI, int JELKFKMJMEM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x3AF3630", Offset = "0x3AF2430", VA = "0x183AF3630")]
	private void OBPAJHPEGKM(DPALPFCJOAH PJEJIMNKKOB, JFKHGDJPGLF CEGABFIPLEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x3AF2FB0", Offset = "0x3AF1DB0", VA = "0x183AF2FB0")]
	private void GLJOEJNJLOL(TClaimant CHGPEEBKHPM, TNode POMFCKNMLCP, TNode NKHKMPCFDCI, int JELKFKMJMEM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x3AF3520", Offset = "0x3AF2320", VA = "0x183AF3520")]
	private void LGPNLDJPIIK(DPALPFCJOAH PJEJIMNKKOB, TNode EGEEDBJEODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x3AF36C0", Offset = "0x3AF24C0", VA = "0x183AF36C0")]
	private void OLHONCHLBAM(DPALPFCJOAH PJEJIMNKKOB, JFKHGDJPGLF CEGABFIPLEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x3AF2B10", Offset = "0x3AF1910", VA = "0x183AF2B10")]
	private void DLLAOFOCNPE(JFKHGDJPGLF CEGABFIPLEP, bool JPHHGJLDLBO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x3AF26E0", Offset = "0x3AF14E0", VA = "0x183AF26E0")]
	private void CJMEPLNKCFF(JFKHGDJPGLF CEGABFIPLEP, TNode DDNBMNPALIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x3AF2EE0", Offset = "0x3AF1CE0", VA = "0x183AF2EE0")]
	[IteratorStateMachine(typeof(global::JCHBJOGACIJ<, >.IJGEFNLKOJM))]
	private IEnumerable<TNode> ECHMKGLCBEC(TNode POMFCKNMLCP, TNode NKHKMPCFDCI, bool ODMODBFKJLO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x3AF2A50", Offset = "0x3AF1850", VA = "0x183AF2A50")]
	private JFKHGDJPGLF DCBOOOFBJBE(TNode EGEEDBJEODH, TNode KICGHGEEADG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x3AF3390", Offset = "0x3AF2190", VA = "0x183AF3390")]
	private JFKHGDJPGLF JGKAKCDBBEN(TNode EGEEDBJEODH, TNode KICGHGEEADG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x3AF37C0", Offset = "0x3AF25C0", VA = "0x183AF37C0")]
	private void OPCJOIIIMMG(JFKHGDJPGLF CEGABFIPLEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public class EDAOPEDAGIF<T> : IEnumerable<global::EDAOPEDAGIF<T>.NKFFEDOABOO>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public struct NKFFEDOABOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public T DPJGMDFEIDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public int DJIEOHJNDEK;
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public class IINABAFGJAH : IEnumerator<NKFFEDOABOO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private global::EDAOPEDAGIF<T> EJIPNPFMBNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int DJIEOHJNDEK;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x22EA910", Offset = "0x22E9710", VA = "0x1822EA910", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public NKFFEDOABOO NFPBMNAHIKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x3736A80", Offset = "0x3735880", VA = "0x183736A80", Slot = "4")]
			get
			{
				return default(NKFFEDOABOO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0xA6FA40", Offset = "0xA6E840", VA = "0x180A6FA40")]
		public IINABAFGJAH(global::EDAOPEDAGIF<T> EJIPNPFMBNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x37368C0", Offset = "0x37356C0", VA = "0x1837368C0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0xA6FA30", Offset = "0xA6E830", VA = "0x180A6FA30", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x1152460", Offset = "0x1151260", VA = "0x181152460", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	private struct PNAHCBDENFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public bool DICHFHHHOLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public T DPJGMDFEIDL;
	}

	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private const int PKGCBPDJDCF = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private readonly Dictionary<T, int> KAEHKHIKIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private PNAHCBDENFA[] LIFMMLNJLMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private int IEKFPNAEJKB;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int PHPONCGDLMH
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x71D070", Offset = "0x71BE70", VA = "0x18071D070")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xBF5B70", Offset = "0xBF4970", VA = "0x180BF5B70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int EKAGFOMELON
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x3346810", Offset = "0x3345610", VA = "0x183346810")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x40FA6E0", Offset = "0x40F94E0", VA = "0x1840FA6E0")]
	public EDAOPEDAGIF(int DOOAOHCDEFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x40FA7C0", Offset = "0x40F95C0", VA = "0x1840FA7C0")]
	public EDAOPEDAGIF(NKFFEDOABOO[] DPLLLLMMNEG, bool BEMMIHKAKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x40F96B0", Offset = "0x40F84B0", VA = "0x1840F96B0")]
	public int CDFBPKIFFKJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x40F9720", Offset = "0x40F8520", VA = "0x1840F9720")]
	private int CJHIMOMAOBP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x40FA290", Offset = "0x40F9090", VA = "0x1840FA290", Slot = "6")]
	protected virtual uint KNNBOCNMLKF(uint JJOJGACMMLF, T DPJGMDFEIDL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x40F9F70", Offset = "0x40F8D70", VA = "0x1840F9F70")]
	public bool FAGPKAAHEGJ(T DPJGMDFEIDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x40FA0B0", Offset = "0x40F8EB0", VA = "0x1840FA0B0")]
	public bool GLCNGEDNEAM(int DJIEOHJNDEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x40F9B10", Offset = "0x40F8910", VA = "0x1840F9B10")]
	public bool DOMBPGEJHPH(Func<T, bool> AACLNJEGPKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x40FA000", Offset = "0x40F8E00", VA = "0x1840FA000")]
	public int FIJJBGKILKJ(T DPJGMDFEIDL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x40FA150", Offset = "0x40F8F50", VA = "0x1840FA150")]
	public T JEIOEOGODCD(int DJIEOHJNDEK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x40FA210", Offset = "0x40F9010", VA = "0x1840FA210")]
	public void KJHAHNAAJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x40F9670", Offset = "0x40F8470", VA = "0x1840F9670")]
	public bool BFANBNANLGD(T DPJGMDFEIDL, bool JFLNGLJOEJI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x40F9270", Offset = "0x40F8070", VA = "0x1840F9270")]
	public bool BFANBNANLGD(T DPJGMDFEIDL, int DJIEOHJNDEK, bool JFLNGLJOEJI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x40FA550", Offset = "0x40F9350", VA = "0x1840FA550")]
	public bool PPEAGPDBOCM(T DPJGMDFEIDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x40FA060", Offset = "0x40F8E60", VA = "0x1840FA060")]
	public bool FOJICMFLHIC(int DJIEOHJNDEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x40FA3C0", Offset = "0x40F91C0", VA = "0x1840FA3C0")]
	private void LLBHGHLLDMC(int DJIEOHJNDEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x40F9C90", Offset = "0x40F8A90", VA = "0x1840F9C90")]
	public NKFFEDOABOO[] EPIODPKLAPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x40FA4B0", Offset = "0x40F92B0", VA = "0x1840FA4B0")]
	private int PDJMNBEAGHM(int NHDKCAPAOGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x40FA660", Offset = "0x40F9460", VA = "0x1840FA660", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x40FA660", Offset = "0x40F9460", VA = "0x1840FA660", Slot = "4")]
	private IEnumerator<NKFFEDOABOO> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct JBEHLKCJKDL<Handle> where Handle : GHFDCEBDMDI, new()
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	private struct LPPPPJJBEGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly global::JBEHLKCJKDL<Handle> BBBBJACNJKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private int DJIEOHJNDEK;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public int LIDFLIONIPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x39064F0", Offset = "0x39052F0", VA = "0x1839064F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public Handle KHCLICHJOED
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x3906B90", Offset = "0x3905990", VA = "0x183906B90")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x3907230", Offset = "0x3906030", VA = "0x183907230")]
		public LPPPPJJBEGK(global::JBEHLKCJKDL<Handle> BBBBJACNJKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x3907190", Offset = "0x3905F90", VA = "0x183907190")]
		public MDLAMFNKLGD PKGIDMHJGMJ(in MDLAMFNKLGD KNNMPBLOADI)
		{
			return default(MDLAMFNKLGD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x39070F0", Offset = "0x3905EF0", VA = "0x1839070F0")]
		public DHPKFJMCJGI PKGIDMHJGMJ(in DHPKFJMCJGI KNNMPBLOADI)
		{
			return default(DHPKFJMCJGI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x39062B0", Offset = "0x39050B0", VA = "0x1839062B0")]
		public bool DHFALBNEPMK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x3906990", Offset = "0x3905790", VA = "0x183906990")]
		private int KECINNDBFIC(string IACFBMPPCKF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x3906FB0", Offset = "0x3905DB0", VA = "0x183906FB0")]
		private Handle PEBEFOOMBJL(string IACFBMPPCKF)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public struct MDLAMFNKLGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private LPPPPJJBEGK MGMEJCLLAPK;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public int NFPBMNAHIKK
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x3F66B20", Offset = "0x3F65920", VA = "0x183F66B20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x3F66C20", Offset = "0x3F65A20", VA = "0x183F66C20")]
		public MDLAMFNKLGD(global::JBEHLKCJKDL<Handle> BBBBJACNJKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x3F66A60", Offset = "0x3F65860", VA = "0x183F66A60")]
		public bool DHFALBNEPMK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x3F66AA0", Offset = "0x3F658A0", VA = "0x183F66AA0")]
		public MDLAMFNKLGD LEIFMBFFFGJ()
		{
			return default(MDLAMFNKLGD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public struct DHPKFJMCJGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private LPPPPJJBEGK MGMEJCLLAPK;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Handle NFPBMNAHIKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x42C7700", Offset = "0x42C6500", VA = "0x1842C7700")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x3F66C20", Offset = "0x3F65A20", VA = "0x183F66C20")]
		public DHPKFJMCJGI(global::JBEHLKCJKDL<Handle> BBBBJACNJKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x3F66A60", Offset = "0x3F65860", VA = "0x183F66A60")]
		public bool DHFALBNEPMK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x42C75C0", Offset = "0x42C63C0", VA = "0x1842C75C0")]
		public DHPKFJMCJGI LEIFMBFFFGJ()
		{
			return default(DHPKFJMCJGI);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private NativeList<int> KPKGFHGPJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private NativeList<int> MMPMNDEENBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private int KKKPIDEMLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private int PFCPOOKHKDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private bool PMDJHFLFFIL;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool AODFAOEBKCE
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x701080", Offset = "0x6FFE80", VA = "0x180701080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int LOFJCNPKFOE
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x468F770", Offset = "0x468E570", VA = "0x18468F770")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int AKEDJCFPFGN
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x749E00", Offset = "0x748C00", VA = "0x180749E00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int GHNOGPCGKCG
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x749E00", Offset = "0x748C00", VA = "0x180749E00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public MDLAMFNKLGD OFDDJIMCAGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x4692120", Offset = "0x4690F20", VA = "0x184692120")]
		get
		{
			return default(MDLAMFNKLGD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public DHPKFJMCJGI LDLIKPNOFBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x4690800", Offset = "0x468F600", VA = "0x184690800")]
		get
		{
			return default(DHPKFJMCJGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x4693350", Offset = "0x4692150", VA = "0x184693350")]
	public JBEHLKCJKDL(int JKNNMEEOCFD, Allocator CMCENMLGNBG = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x4692400", Offset = "0x4691200", VA = "0x184692400")]
	public void LFLAMKKDLCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x26FF2E0", Offset = "0x26FE0E0", VA = "0x1826FF2E0")]
	public static int HAHOMHDABDE(int FKCJFNALIGC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x4693140", Offset = "0x4691F40", VA = "0x184693140")]
	public static bool NKDOIJEGKEE(int FKCJFNALIGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x46914E0", Offset = "0x46902E0", VA = "0x1846914E0")]
	public static bool JKFJPODMMBL(int FKCJFNALIGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x4690420", Offset = "0x468F220", VA = "0x184690420")]
	public bool ICLBBPNDACO(int DJIEOHJNDEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x4692AA0", Offset = "0x46918A0", VA = "0x184692AA0")]
	public bool NBJMFAEDIDG(int DJIEOHJNDEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x4692870", Offset = "0x4691670", VA = "0x184692870")]
	public bool MJCOPMGDBFB(Handle ODABKCNLMCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x4690EA0", Offset = "0x468FCA0", VA = "0x184690EA0")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void JCNLDOIDKKI(Handle ODABKCNLMCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x4693070", Offset = "0x4691E70", VA = "0x184693070")]
	public Handle NDPMPBABEGJ()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x46917F0", Offset = "0x46905F0", VA = "0x1846917F0")]
	public void JLEJDIALKNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x468F4F0", Offset = "0x468E2F0", VA = "0x18468F4F0")]
	public void DNMPBLFGJHE(Handle ODABKCNLMCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x468EFE0", Offset = "0x468DDE0", VA = "0x18468EFE0")]
	public bool AFJJGCBMILL(Handle ODABKCNLMCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x701080", Offset = "0x6FFE80", VA = "0x180701080")]
	private bool OMNMOFKCLDM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x468F7F0", Offset = "0x468E5F0", VA = "0x18468F7F0")]
	private bool FFDFAFIDLAB(int DJIEOHJNDEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x468FF50", Offset = "0x468ED50", VA = "0x18468FF50")]
	private void HLHBCMDMEAH(out int DJIEOHJNDEK, out int LLNMOPOJDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x468F2F0", Offset = "0x468E0F0", VA = "0x18468F2F0")]
	private void AHCEOPPDGAP(Handle ODABKCNLMCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x4693150", Offset = "0x4691F50", VA = "0x184693150")]
	private void PIOMILOFDDE(int DJIEOHJNDEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x4690750", Offset = "0x468F550", VA = "0x184690750")]
	private bool IFMOCLFAJGF(out int DJIEOHJNDEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x468FA60", Offset = "0x468E860", VA = "0x18468FA60")]
	private static Handle HDOBEHGLHKH(int DJIEOHJNDEK, int LLNMOPOJDNH)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[DefaultMember("Item")]
public struct PNLCOEEFLCB<Handle, T> where Handle : GHFDCEBDMDI, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private global::JBEHLKCJKDL<Handle> CNCAGADCBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private T[] KKOOGDFIDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private Action<T> PFKKENKIGNJ;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool AODFAOEBKCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x35BBEF0", Offset = "0x35BACF0", VA = "0x1835BBEF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public int LOFJCNPKFOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x35BB4E0", Offset = "0x35BA2E0", VA = "0x1835BB4E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public int EKAGFOMELON
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x35BB4B0", Offset = "0x35BA2B0", VA = "0x1835BB4B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public T BADELHLICNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x35BD530", Offset = "0x35BC330", VA = "0x1835BD530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x35BE6A0", Offset = "0x35BD4A0", VA = "0x1835BE6A0")]
	public PNLCOEEFLCB(int JKNNMEEOCFD, [Optional] Action<T> PFKKENKIGNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x35BC660", Offset = "0x35BB460", VA = "0x1835BC660")]
	public void LFLAMKKDLCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x35BCCD0", Offset = "0x35BBAD0", VA = "0x1835BCCD0")]
	public bool MJCOPMGDBFB(Handle ODABKCNLMCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void JCNLDOIDKKI(Handle ODABKCNLMCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x35BBE30", Offset = "0x35BAC30", VA = "0x1835BBE30")]
	public T HEOCMNIHPLM(Handle ODABKCNLMCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x35BBCB0", Offset = "0x35BAAB0", VA = "0x1835BBCB0")]
	public bool GBLHCMBLLEL(Handle ODABKCNLMCP, out T LOPIEGGIDMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x35BC8A0", Offset = "0x35BB6A0", VA = "0x1835BC8A0")]
	public void LMMFIPJEJPN(Handle ODABKCNLMCP, T ILBFFEGCGEB, out T JCBJJCLBMOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x35BC940", Offset = "0x35BB740", VA = "0x1835BC940")]
	public void LMMFIPJEJPN(Handle ODABKCNLMCP, T ILBFFEGCGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x35BCDC0", Offset = "0x35BBBC0", VA = "0x1835BCDC0")]
	public bool NAKCIOJFCFJ(Handle ODABKCNLMCP, T ILBFFEGCGEB, out T JCBJJCLBMOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x35BD450", Offset = "0x35BC250", VA = "0x1835BD450")]
	public bool NAKCIOJFCFJ(Handle ODABKCNLMCP, T ILBFFEGCGEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x35BB710", Offset = "0x35BA510", VA = "0x1835BB710")]
	public Handle EKGLGHAFJEH(T LOPIEGGIDMF)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x35BD620", Offset = "0x35BC420", VA = "0x1835BD620")]
	public void PHIHBDOJPBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x35BE220", Offset = "0x35BD020", VA = "0x1835BE220")]
	public void PPEAGPDBOCM(Handle ODABKCNLMCP, out T JCBJJCLBMOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x35BE150", Offset = "0x35BCF50", VA = "0x1835BE150")]
	public void PPEAGPDBOCM(Handle ODABKCNLMCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x35BC2E0", Offset = "0x35BB0E0", VA = "0x1835BC2E0")]
	public bool JANFONELIIO(Handle ODABKCNLMCP, out T JCBJJCLBMOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x35BBF20", Offset = "0x35BAD20", VA = "0x1835BBF20")]
	public bool JANFONELIIO(Handle ODABKCNLMCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x35BBA10", Offset = "0x35BA810", VA = "0x1835BBA10")]
	private T FOJICMFLHIC(int DJIEOHJNDEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x35BBD60", Offset = "0x35BAB60", VA = "0x1835BBD60")]
	private void GHOLJBBLCCM(int IGAILGMGBBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public class DEBFKAJDONP<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly Stack<T> BBBBJACNJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly List<T> GPKFLIOAPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly int JMBABADFLJO;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public int MELKLIOLHGB
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x38F56F0", Offset = "0x38F44F0", VA = "0x1838F56F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int EDPBGLCELHF
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x3746310", Offset = "0x3745110", VA = "0x183746310")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x3FF5850", Offset = "0x3FF4650", VA = "0x183FF5850")]
	public static global::DEBFKAJDONP<T> ECPOPCNKPPM(int DOOAOHCDEFK = 0, int JMBABADFLJO = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x3FF5690", Offset = "0x3FF4490", VA = "0x183FF5690")]
	public static global::DEBFKAJDONP<T> DOEMKHLKMBM(int DOOAOHCDEFK = 0, int JMBABADFLJO = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x3FF5CF0", Offset = "0x3FF4AF0", VA = "0x183FF5CF0")]
	public DEBFKAJDONP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x3FF5D30", Offset = "0x3FF4B30", VA = "0x183FF5D30")]
	public DEBFKAJDONP(int DOOAOHCDEFK, int JMBABADFLJO = int.MaxValue, bool AANEGCGPMCC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x3FF5500", Offset = "0x3FF4300", VA = "0x183FF5500")]
	public T BIFPBGNCKHO()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x3FF5940", Offset = "0x3FF4740", VA = "0x183FF5940")]
	public void JNKEIDPDMAI(T DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x3FF5C20", Offset = "0x3FF4A20", VA = "0x183FF5C20")]
	private void PHGNPOOONKG(T DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x3FF5920", Offset = "0x3FF4720", VA = "0x183FF5920")]
	private void HLCOMMAFFDM(T DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x3FF5610", Offset = "0x3FF4410", VA = "0x183FF5610")]
	[Conditional("DEBUG_BUILD")]
	private void DCBJJACLCGA(T NCLAILJLBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x3FF59F0", Offset = "0x3FF47F0", VA = "0x183FF59F0")]
	[Conditional("DEBUG_BUILD")]
	private void MCBBMMJPLGA(T NCLAILJLBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x3FF5760", Offset = "0x3FF4560", VA = "0x183FF5760", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x3FF5A80", Offset = "0x3FF4880", VA = "0x183FF5A80")]
	private void PEAFMMICGEI(IEnumerable<T> FLHOJBEDKEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public class AJJNEEPGNJG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private Dictionary<int, T> MHMHOAIEBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private T DDBPEJAEMFK;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public virtual T INOPCBIPHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x7011D0", Offset = "0x6FFFD0", VA = "0x1807011D0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool FGKHLALNPCI
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x40C0860", Offset = "0x40BF660", VA = "0x1840C0860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x40C0E60", Offset = "0x40BFC60", VA = "0x1840C0E60")]
	public bool KEKCLMKGJCF(T DPJGMDFEIDL, int OHLEMHGCIOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x40C0F80", Offset = "0x40BFD80", VA = "0x1840C0F80")]
	public bool LOFEFNLJCIF(int OHLEMHGCIOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x40C0A40", Offset = "0x40BF840", VA = "0x1840C0A40")]
	public T HEHNJLDLEAD(int DAINBOCEIOD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x40C0F20", Offset = "0x40BFD20", VA = "0x1840C0F20")]
	public void KJHAHNAAJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x40C08A0", Offset = "0x40BF6A0", VA = "0x1840C08A0")]
	private bool DHKHCGINBHM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x40C0E30", Offset = "0x40BFC30", VA = "0x1840C0E30")]
	public bool ICLIDKMCOMO(int OHLEMHGCIOH, out T DPJGMDFEIDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x40C0FE0", Offset = "0x40BFDE0", VA = "0x1840C0FE0")]
	public AJJNEEPGNJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public class OGHINHMEDPL<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	protected struct BKONDKLECKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public T MHMGLCIOEKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public int HIGEJHLNFBL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	protected readonly List<BKONDKLECKB> HLMOBOIJGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private T NHJDHHFBEGN;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int EKAGFOMELON
	{
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x3346810", Offset = "0x3345610", VA = "0x183346810")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x43EC7E0", Offset = "0x43EB5E0", VA = "0x1843EC7E0")]
	public bool DOMBPGEJHPH(T DPJGMDFEIDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x43EC9F0", Offset = "0x43EB7F0", VA = "0x1843EC9F0")]
	public void EKGLGHAFJEH(T DPJGMDFEIDL, int OHLEMHGCIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x43ECB60", Offset = "0x43EB960", VA = "0x1843ECB60")]
	public bool PPEAGPDBOCM(T DPJGMDFEIDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x43ECB00", Offset = "0x43EB900", VA = "0x1843ECB00")]
	public void KJHAHNAAJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x43EC770", Offset = "0x43EB570", VA = "0x1843EC770")]
	public T DIKDNHKJBJB()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x43ECA90", Offset = "0x43EB890", VA = "0x1843ECA90")]
	public T GLPHIJDBAAP()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x43EC5B0", Offset = "0x43EB3B0", VA = "0x1843EC5B0")]
	private void AHGPHDANICO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x43ECC80", Offset = "0x43EBA80", VA = "0x1843ECC80")]
	public OGHINHMEDPL()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		[SerializeField]
		[GBGNHGGGIDI(DKGJGBDJNIO.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x1FE7280", Offset = "0x1FE6080", VA = "0x181FE7280")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x1FE7610", Offset = "0x1FE6410", VA = "0x181FE7610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x1FE7490", Offset = "0x1FE6290", VA = "0x181FE7490")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x1FE7770", Offset = "0x1FE6570", VA = "0x181FE7770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x1FE71A0", Offset = "0x1FE5FA0", VA = "0x181FE71A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x1FE7530", Offset = "0x1FE6330", VA = "0x181FE7530")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x1FE73B0", Offset = "0x1FE61B0", VA = "0x181FE73B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x1FE7150", Offset = "0x1FE5F50", VA = "0x181FE7150")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public interface NKCJJNHJEKL
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public abstract class ResourcePrefabReference<T> : NKCJJNHJEKL where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x39C85B0", Offset = "0x39C73B0", VA = "0x1839C85B0", Slot = "4")]
		public virtual T GPAOKBMPBDJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x22E6440", Offset = "0x22E5240", VA = "0x1822E6440")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public class PHCNBJBFAPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private readonly Dictionary<byte, EBCEKKBOAHF> IKEFOCGCPKO;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public EBCEKKBOAHF FOHGDGEAOHC
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F00", Offset = "0x6E5D00", VA = "0x1806E6F00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector2 BPFDKFOAPFI
	{
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xD4DD90", Offset = "0xD4CB90", VA = "0x180D4DD90")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x85DC70", Offset = "0x85CA70", VA = "0x18085DC70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector2 EAGIDLFPNNL
	{
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x118EEE0", Offset = "0x118DCE0", VA = "0x18118EEE0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0xBD6510", Offset = "0xBD5310", VA = "0x180BD6510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector2 PIGBJDLBJAL
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x1FE6A40", Offset = "0x1FE5840", VA = "0x181FE6A40")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x85DC80", Offset = "0x85CA80", VA = "0x18085DC80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int BGMIAEDICCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x7A98C0", Offset = "0x7A86C0", VA = "0x1807A98C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0xB83FE0", Offset = "0xB82DE0", VA = "0x180B83FE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x1FE6A60", Offset = "0x1FE5860", VA = "0x181FE6A60")]
	public PHCNBJBFAPH(Bounds LOBMMDMJILC, Vector2[] JGNOKKFHKIM, int PJEBJJEBDHK, byte NHDKCAPAOGD, float FJEKBNODGGL = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x1FE68E0", Offset = "0x1FE56E0", VA = "0x181FE68E0")]
	public EBCEKKBOAHF INDKMPGOEMI(byte DJIEOHJNDEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x1FE6940", Offset = "0x1FE5740", VA = "0x181FE6940")]
	public void KKPBDHDPKAD(Vector3 PGEIGNJBBKG, float FDDBCKOEIDC, float HFBEJOMBNCE, ref List<byte> ELOLOCFFMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x1FE68C0", Offset = "0x1FE56C0", VA = "0x181FE68C0")]
	public void IKDPOECDFGK(EBCEKKBOAHF.CJJIKJGEKKO AIOFBLPCPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x1FE6760", Offset = "0x1FE5560", VA = "0x181FE6760")]
	private EBCEKKBOAHF DAEMCJADICN(byte DJIEOHJNDEK, EBCEKKBOAHF.HJIEMMDMAJJ DFMCJLLKFFH, EBCEKKBOAHF KICGHGEEADG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x1FE6360", Offset = "0x1FE5160", VA = "0x181FE6360")]
	private void CKPGKHPOGNK(EBCEKKBOAHF KICGHGEEADG, Vector2[] JGNOKKFHKIM, int OKOHLNNJJKE, int FKABIDPGNKL, int AMKNGGGNAEL, int GJAEEPFINMK, float FJEKBNODGGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class EBCEKKBOAHF
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public enum HJIEMMDMAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public enum CJJIKJGEKKO
	{
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public byte CEGBKALJAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public Vector3 CNCBMMEFAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public Vector3 BJEJGEAMGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public Vector3 OHNAKKPBIIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public Vector3 HCKODHNGCKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public HJIEMMDMAJJ JLLBCJOKCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public EBCEKKBOAHF HKFFKPMFCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public List<EBCEKKBOAHF> KFPMKMIGJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public bool ADMNHHOACPN;

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x1FE03F0", Offset = "0x1FDF1F0", VA = "0x181FE03F0")]
	public EBCEKKBOAHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x1FE0410", Offset = "0x1FDF210", VA = "0x181FE0410")]
	public EBCEKKBOAHF(byte FCIFBDBBENJ, HJIEMMDMAJJ DFMCJLLKFFH, EBCEKKBOAHF KICGHGEEADG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x1FDFFF0", Offset = "0x1FDEDF0", VA = "0x181FDFFF0")]
	public void IEFILFBALKN(EBCEKKBOAHF JJJNIHBIILJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	public void IKDPOECDFGK(int CFGIBLLHBDL, CJJIKJGEKKO AIOFBLPCPOH, int HHGPIFAPDDD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x1FE0100", Offset = "0x1FDEF00", VA = "0x181FE0100")]
	public void KKPBDHDPKAD(List<byte> ELOLOCFFMJK, Vector3 PGEIGNJBBKG, float FDDBCKOEIDC, float HFBEJOMBNCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x1FE00B0", Offset = "0x1FDEEB0", VA = "0x181FE00B0")]
	public bool IKKPJDNMICE(Vector3 IODDJAKNMPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x1FE03B0", Offset = "0x1FDF1B0", VA = "0x181FE03B0")]
	public bool ONIPMFJGJKJ(Vector3 IODDJAKNMPJ, float GHPDMJIOKMJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public class NDHCKAPEHBM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly Dictionary<T, object> AMEEHDNJHAF;

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x3124870", Offset = "0x3123670", VA = "0x183124870")]
	public bool DIPKNNDMJCL(T GJJABBOHKIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x44F2D20", Offset = "0x44F1B20", VA = "0x1844F2D20")]
	public bool DIPKNNDMJCL(T GJJABBOHKIC, object DPODOOAHECI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x44F2CC0", Offset = "0x44F1AC0", VA = "0x1844F2CC0")]
	public bool DIPKNNDMJCL(T GJJABBOHKIC, object DPODOOAHECI, out object NDEPCIFJOIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x44F2E00", Offset = "0x44F1C00", VA = "0x1844F2E00")]
	public bool GANKOMDOMAK(T GJJABBOHKIC, object DPODOOAHECI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x44F2C80", Offset = "0x44F1A80", VA = "0x1844F2C80")]
	public bool CLEIFBGIELJ(T GJJABBOHKIC, object DPODOOAHECI, out object NDEPCIFJOIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x44F2E40", Offset = "0x44F1C40", VA = "0x1844F2E40")]
	public bool GANKOMDOMAK(T GJJABBOHKIC, object DPODOOAHECI, out object NDEPCIFJOIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x44F2ED0", Offset = "0x44F1CD0", VA = "0x1844F2ED0")]
	public void KJKFIBFIGKM(T GJJABBOHKIC, object DPODOOAHECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x44F2D60", Offset = "0x44F1B60", VA = "0x1844F2D60")]
	public void EJCGLFLMGBH(T GJJABBOHKIC, object DPODOOAHECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x44F2F00", Offset = "0x44F1D00", VA = "0x1844F2F00")]
	public NDHCKAPEHBM()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x20000AE")]
		public struct GGKOOPKNJPM<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			private readonly List<Component> GHOABBJLFEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			private readonly bool JLAPDJNFEPJ;

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x124F7E0", Offset = "0x124E5E0", VA = "0x18124F7E0")]
			public GGKOOPKNJPM(List<Component> GHOABBJLFEA, bool JLAPDJNFEPJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x4215F50", Offset = "0x4214D50", VA = "0x184215F50")]
			public PANAPAFBGOH<T> LEIFMBFFFGJ()
			{
				return default(PANAPAFBGOH<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x4215FC0", Offset = "0x4214DC0", VA = "0x184215FC0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x4215FC0", Offset = "0x4214DC0", VA = "0x184215FC0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AF")]
		public struct PANAPAFBGOH<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			private readonly List<Component> GHOABBJLFEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			private readonly bool JLAPDJNFEPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			private int DJIEOHJNDEK;

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public T NFPBMNAHIKK
			{
				[Cpp2IlInjected.Token(Token = "0x60003EA")]
				[Cpp2IlInjected.Address(RVA = "0x426E320", Offset = "0x426D120", VA = "0x18426E320", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003EB")]
				[Cpp2IlInjected.Address(RVA = "0x426E2B0", Offset = "0x426D0B0", VA = "0x18426E2B0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x426E2F0", Offset = "0x426D0F0", VA = "0x18426E2F0")]
			public PANAPAFBGOH(List<Component> GHOABBJLFEA, bool JLAPDJNFEPJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0x426E1F0", Offset = "0x426CFF0", VA = "0x18426E1F0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0x426E200", Offset = "0x426D000", VA = "0x18426E200", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0x2C01350", Offset = "0x2C00150", VA = "0x182C01350", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0x1FE94C0", Offset = "0x1FE82C0", VA = "0x181FE94C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x1FE9480", Offset = "0x1FE8280", VA = "0x181FE9480")]
		public ToolHierarchyCache(GameObject OPJJDKDMJMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x1FE8CC0", Offset = "0x1FE7AC0", VA = "0x181FE8CC0")]
		private void FKIENGHPLFJ(GameObject OPJJDKDMJMI, bool JBCHDAAKNKO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x1FE8E20", Offset = "0x1FE7C20", VA = "0x181FE8E20")]
		public static void FKIENGHPLFJ(GameObject OPJJDKDMJMI, ref ToolHierarchyCache NEELKCPMANJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x1FE8C30", Offset = "0x1FE7A30", VA = "0x181FE8C30")]
		public void ABDDFLBPNND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x1FE9000", Offset = "0x1FE7E00", VA = "0x181FE9000")]
		public void HAOAFEIDDGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x380A050", Offset = "0x3808E50", VA = "0x18380A050")]
		public void FAJKLGGNECA<T>(Action<T> CIAILAMJPDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x1FE8EB0", Offset = "0x1FE7CB0", VA = "0x181FE8EB0")]
		public Component GIOLJNPABJB(Type LAKBKKJKBPK, bool JLAPDJNFEPJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x380A2E0", Offset = "0x38090E0", VA = "0x18380A2E0")]
		public T GIOLJNPABJB<T>(bool JLAPDJNFEPJ = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x1FE9050", Offset = "0x1FE7E50", VA = "0x181FE9050")]
		public GGKOOPKNJPM<Component> PGOJIAINFJJ(Type LAKBKKJKBPK, bool JLAPDJNFEPJ = false)
		{
			return default(GGKOOPKNJPM<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x380A360", Offset = "0x3809160", VA = "0x18380A360")]
		public GGKOOPKNJPM<T> PGOJIAINFJJ<T>(bool JLAPDJNFEPJ = false) where T : class
		{
			return default(GGKOOPKNJPM<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x1FE90D0", Offset = "0x1FE7ED0", VA = "0x181FE90D0")]
		public List<Component> PNCAMJGILCH(Type LAKBKKJKBPK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x1FE8C40", Offset = "0x1FE7A40", VA = "0x181FE8C40", Slot = "4")]
		public bool Equals(ToolHierarchyCache IDDALCIIJOJ, ToolHierarchyCache GIJPFDNHKHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x1FE8F80", Offset = "0x1FE7D80", VA = "0x181FE8F80", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache LOPIEGGIDMF)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public class GOMKOLKPMFK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private int DOOAOHCDEFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private int CMGNHLOOENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private List<T> PDGNCDHKFCJ;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public int EKAGFOMELON
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x38F56F0", Offset = "0x38F44F0", VA = "0x1838F56F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public T JPHCMBFHGGL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x4B4D180", Offset = "0x4B4BF80", VA = "0x184B4D180")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public T AFJNFBBLIFI
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x4B4D030", Offset = "0x4B4BE30", VA = "0x184B4D030")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public T IFGHEOBACAC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x4B4D0D0", Offset = "0x4B4BED0", VA = "0x184B4D0D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x4B4D330", Offset = "0x4B4C130", VA = "0x184B4D330")]
	public GOMKOLKPMFK(int DOOAOHCDEFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x4B4CDF0", Offset = "0x4B4BBF0", VA = "0x184B4CDF0")]
	public void EKGLGHAFJEH(T DKCDALCLODI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x4B4D090", Offset = "0x4B4BE90", VA = "0x184B4D090")]
	public void KJHAHNAAJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x4B4D290", Offset = "0x4B4C090", VA = "0x184B4D290")]
	public void NDOBMIPPOEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x4B4CFA0", Offset = "0x4B4BDA0", VA = "0x184B4CFA0")]
	public void FILFLOMJJHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x4B4CDE0", Offset = "0x4B4BBE0", VA = "0x184B4CDE0")]
	public void EDCMAFCCELD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public class DMMDGCHBLLN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private bool AHLHMHFGILE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private Action CIAILAMJPDB;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public static DMMDGCHBLLN OEEEAHGNELH
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x1FDFF70", Offset = "0x1FDED70", VA = "0x181FDFF70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool OKLOEDGBEMC
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x8E8110", Offset = "0x8E6F10", VA = "0x1808E8110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x8E2520", Offset = "0x8E1320", VA = "0x1808E2520")]
	public DMMDGCHBLLN(Action CIAILAMJPDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x1FDFF50", Offset = "0x1FDED50", VA = "0x181FDFF50")]
	public void LAJHMBEEEDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x1FDFF50", Offset = "0x1FDED50", VA = "0x181FDFF50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public static class CJFIPJKJMFK
{
	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x1FDF6E0", Offset = "0x1FDE4E0", VA = "0x181FDF6E0")]
	public static void BBJNBPNKDAC(MKBPEOEKJNO JCFDILFMPGE, string EGKBEGJMEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	public static void BBJNBPNKDAC(IEnumerable<object> MDAGBLFAAKK, string EGKBEGJMEKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public class DDFCDPGBCMA<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private struct NCAGBBIBIAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public int HIGEJHLNFBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public T MHMGLCIOEKC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private readonly Dictionary<object, NCAGBBIBIAP> MHMHOAIEBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private readonly EqualityComparer<T> OPBDPGCMIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private T DDBPEJAEMFK;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public virtual T INOPCBIPHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x78E1D0", Offset = "0x78CFD0", VA = "0x18078E1D0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xA3F930", Offset = "0xA3E730", VA = "0x180A3F930", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool FGKHLALNPCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x3FEF7E0", Offset = "0x3FEE5E0", VA = "0x183FEF7E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public object IGNPMMDCNOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x6D0BA0", Offset = "0x6CF9A0", VA = "0x1806D0BA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x6D0BD0", Offset = "0x6CF9D0", VA = "0x1806D0BD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x3FF3F20", Offset = "0x3FF2D20", VA = "0x183FF3F20")]
	public bool KEKCLMKGJCF(T DPJGMDFEIDL, object DPODOOAHECI, int OHLEMHGCIOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x3FF4700", Offset = "0x3FF3500", VA = "0x183FF4700")]
	public bool LOFEFNLJCIF(object DPODOOAHECI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x3FF3880", Offset = "0x3FF2680", VA = "0x183FF3880")]
	public bool ICLIDKMCOMO(object DPODOOAHECI, out T DPJGMDFEIDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x37160F0", Offset = "0x3714EF0", VA = "0x1837160F0")]
	public void KJHAHNAAJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x3FF23D0", Offset = "0x3FF11D0", VA = "0x183FF23D0")]
	private bool DHKHCGINBHM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x3FF4820", Offset = "0x3FF3620", VA = "0x183FF4820")]
	public DDFCDPGBCMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public class FEMPDDLIHGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private Dictionary<object, float> MHMHOAIEBDE;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float GHNNGJOEDLN
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x6E4180", Offset = "0x6E2F80", VA = "0x1806E4180")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x6E3C10", Offset = "0x6E2A10", VA = "0x1806E3C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x1FE1A30", Offset = "0x1FE0830", VA = "0x181FE1A30")]
	public void KEKCLMKGJCF(float DPJGMDFEIDL, object DPODOOAHECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x1FE1AA0", Offset = "0x1FE08A0", VA = "0x181FE1AA0")]
	public void LOFEFNLJCIF(object DPODOOAHECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x1FE1B10", Offset = "0x1FE0910", VA = "0x181FE1B10")]
	private void OJGEDAGFAOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x1FE1C30", Offset = "0x1FE0A30", VA = "0x181FE1C30")]
	public FEMPDDLIHGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public class DKIGGOHPJMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public readonly string INPCBADENDO;

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x8AFA10", Offset = "0x8AE810", VA = "0x1808AFA10")]
	public DKIGGOHPJMK(string OCHLCPBLBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x1FDFE20", Offset = "0x1FDEC20", VA = "0x181FDFE20")]
	public DKIGGOHPJMK(UnityEngine.Object LDFIDAHMKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x1FDFDD0", Offset = "0x1FDEBD0", VA = "0x181FDFDD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public sealed class MKBPEOEKJNO
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class MBMMFAEFGHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public MBMMFAEFGHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x1FE4F10", Offset = "0x1FE3D10", VA = "0x181FE4F10")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private HashSet<object> MDAGBLFAAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private int CLJNJBPJOKC;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public IReadOnlyCollection<object> DHHKAILJCJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x1FE5450", Offset = "0x1FE4250", VA = "0x181FE5450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool MHDOAJCEAOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x1FE5520", Offset = "0x1FE4320", VA = "0x181FE5520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public int EKAGFOMELON
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x770E30", Offset = "0x76FC30", VA = "0x180770E30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x1FE52F0", Offset = "0x1FE40F0", VA = "0x181FE52F0")]
	public bool EKGLGHAFJEH(object DPODOOAHECI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x1FE5530", Offset = "0x1FE4330", VA = "0x181FE5530")]
	public bool PPEAGPDBOCM(object DPODOOAHECI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x1FE5290", Offset = "0x1FE4090", VA = "0x181FE5290")]
	public bool DOMBPGEJHPH(object DPODOOAHECI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x1FE53E0", Offset = "0x1FE41E0", VA = "0x181FE53E0")]
	public void ELFDDFKCBKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x1FE55D0", Offset = "0x1FE43D0", VA = "0x181FE55D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public MKBPEOEKJNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public class OFEJEEGHEAL<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private struct IKHBMHCAMPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public float DAPGBPEHCEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public T MHMGLCIOEKC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private Dictionary<object, IKHBMHCAMPK> MHMHOAIEBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private T JFHKPOKHMKK;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public virtual T IAINBIHKLAB
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x1F3F710", Offset = "0x1F3E510", VA = "0x181F3F710", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x29FD320", Offset = "0x29FC120", VA = "0x1829FD320", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public object ENJIOLAHKPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x6D0BA0", Offset = "0x6CF9A0", VA = "0x1806D0BA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x6D0BD0", Offset = "0x6CF9D0", VA = "0x1806D0BD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool FGKHLALNPCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x43EA5E0", Offset = "0x43E93E0", VA = "0x1843EA5E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x43EC3C0", Offset = "0x43EB1C0", VA = "0x1843EC3C0")]
	public bool KEKCLMKGJCF(T DPJGMDFEIDL, object DPODOOAHECI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x43EC4C0", Offset = "0x43EB2C0", VA = "0x1843EC4C0")]
	public bool LOFEFNLJCIF(object DPODOOAHECI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x37160F0", Offset = "0x3714EF0", VA = "0x1837160F0")]
	public void KJHAHNAAJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x43EBD40", Offset = "0x43EAB40", VA = "0x1843EBD40")]
	public bool ICLIDKMCOMO(object DPODOOAHECI, out T DPJGMDFEIDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x43EB2A0", Offset = "0x43EA0A0", VA = "0x1843EB2A0")]
	private bool DHKHCGINBHM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x43EC520", Offset = "0x43EB320", VA = "0x1843EC520")]
	public OFEJEEGHEAL()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public class NCKGPBKGCOP
{
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private static byte[] EALBAFGLJIB;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static int HJJBAIGPCIK;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private static int DMHGBIHBKDJ;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private static BigInteger HJDFPPAMGPN;

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public NCKGPBKGCOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x1FE5AE0", Offset = "0x1FE48E0", VA = "0x181FE5AE0")]
	private static string NEFLGCBJNIO(byte[] BFLEMGIJKLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x1FE5790", Offset = "0x1FE4590", VA = "0x181FE5790")]
	public static string BMCDLAKFGCG(byte[] GACPBGKAIDC, bool DFCFJJAKINH)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
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
