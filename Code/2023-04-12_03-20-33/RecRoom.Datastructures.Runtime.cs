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
public class KJPLJBANABD : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x747C20", Offset = "0x747020", VA = "0x180747C20")]
	public KJPLJBANABD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, CGDAMBLFNAM, AHOCFCHKDAO, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x700140", Offset = "0x6FF540", VA = "0x180700140", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6E1120", Offset = "0x6E0520", VA = "0x1806E1120", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6E1130", Offset = "0x6E0530", VA = "0x1806E1130", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7FEE20", Offset = "0x7FE220", VA = "0x1807FEE20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash ADPFJJODLPO);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xE24C60", Offset = "0xE24060", VA = "0x180E24C60")]
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
	[NGHBEEOGMJL]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[NGHBEEOGMJL]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x65E7BE0", Offset = "0x65E6FE0", VA = "0x1865E7BE0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x65E7BA0", Offset = "0x65E6FA0", VA = "0x1865E7BA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x65E7C20", Offset = "0x65E7020", VA = "0x1865E7C20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x65E7DF0", Offset = "0x65E71F0", VA = "0x1865E7DF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x65E7D60", Offset = "0x65E7160", VA = "0x1865E7D60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x12C8520", Offset = "0x12C7920", VA = "0x1812C8520")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x107A660", Offset = "0x1079A60", VA = "0x18107A660")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x65E7B60", Offset = "0x65E6F60", VA = "0x1865E7B60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x65E7CD0", Offset = "0x65E70D0", VA = "0x1865E7CD0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x65E7790", Offset = "0x65E6B90", VA = "0x1865E7790")]
	public void CopyBounds(SavedExtents JHMCLPBFJBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x65E7AC0", Offset = "0x65E6EC0", VA = "0x1865E7AC0")]
	public void SetLocalSpaceBounds(Bounds BMGINPIJPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0xFC8BB0", Offset = "0xFC7FB0", VA = "0x180FC8BB0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x65E7AB0", Offset = "0x65E6EB0", VA = "0x1865E7AB0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x65E6F60", Offset = "0x65E6360", VA = "0x1865E6F60")]
	private void BEHICECBOIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x65E7880", Offset = "0x65E6C80", VA = "0x1865E7880")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x65E7150", Offset = "0x65E6550", VA = "0x1865E7150")]
	public static void CalculateLocalBoundsFor(GameObject BLPBCMIHDMD, out Bounds BMGINPIJPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x65E77C0", Offset = "0x65E6BC0", VA = "0x1865E77C0")]
	private static void EMJFIEPIHDJ(Bounds ICPOAGANOLH, Color FILONMPFNJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x65E7AE0", Offset = "0x65E6EE0", VA = "0x1865E7AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0040", Offset = "0x6DF440", VA = "0x1806E0040")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x700F30", Offset = "0x700330", VA = "0x180700F30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1444EB0", Offset = "0x14442B0", VA = "0x181444EB0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA9C820", Offset = "0xA9BC20", VA = "0x180A9C820")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "4")]
	public virtual void HMKJNNDCPHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x14CA560", Offset = "0x14C9960", VA = "0x1814CA560")]
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
	[KJPLJBANABD]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2FB6A30", Offset = "0x2FB5E30", VA = "0x182FB6A30", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2FB6160", Offset = "0x2FB5560", VA = "0x182FB6160", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2FB6F70", Offset = "0x2FB6370", VA = "0x182FB6F70")]
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
	private sealed class NHJJKFNDJHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x14CA560", Offset = "0x14C9960", VA = "0x1814CA560")]
		public NHJJKFNDJHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2778F20", Offset = "0x2778320", VA = "0x182778F20")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[KJPLJBANABD]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6E1AC0", Offset = "0x6E0EC0", VA = "0x1806E1AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x14FF850", Offset = "0x14FEC50", VA = "0x1814FF850", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x14FF880", Offset = "0x14FEC80", VA = "0x1814FF880", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x14FF7A0", Offset = "0x14FEBA0", VA = "0x1814FF7A0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public TVal this[TKey EBOIOCBODNI]
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x14FF800", Offset = "0x14FEC00", VA = "0x1814FF800", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x14FF6A0", Offset = "0x14FEAA0", VA = "0x1814FF6A0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x14FF1F0", Offset = "0x14FE5F0", VA = "0x1814FF1F0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x14FEA10", Offset = "0x14FDE10", VA = "0x1814FEA10", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x14FE600", Offset = "0x14FDA00", VA = "0x1814FE600", Slot = "14")]
	protected virtual string BKGFCOPCAIK(TKeyVal IOOAILEEPEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x14FE630", Offset = "0x14FDA30", VA = "0x1814FE630", Slot = "4")]
	public bool ContainsKey(TKey EBOIOCBODNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x14FF590", Offset = "0x14FE990", VA = "0x1814FF590", Slot = "5")]
	public bool TryGetValue(TKey EBOIOCBODNI, out TVal KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x14FE660", Offset = "0x14FDA60", VA = "0x1814FE660", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x14FE660", Offset = "0x14FDA60", VA = "0x1814FE660", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x14FF5C0", Offset = "0x14FE9C0", VA = "0x1814FF5C0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class PMIMCGMLPMC<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class CJJNMHKEOEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x14CA560", Offset = "0x14C9960", VA = "0x1814CA560")]
		public CJJNMHKEOEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2411410", Offset = "0x2410810", VA = "0x182411410")]
		internal bool <GetSamples>b__0(global::LPBEACKBGAJ<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float AJEFCLPAFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float EOKLCAGFAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<global::LPBEACKBGAJ<float, T>> JHPDLICKDNO;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int DCOINJIPFPP
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x33FC0F0", Offset = "0x33FB4F0", VA = "0x1833FC0F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x33FC290", Offset = "0x33FB690", VA = "0x1833FC290")]
	public PMIMCGMLPMC(float CDFADGCIFIL, float LDCDBEDKDGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x33FBF10", Offset = "0x33FB310", VA = "0x1833FBF10")]
	public bool GDCCGFCJPMK(float PPIFMHEDLGN, T KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x33FC170", Offset = "0x33FB570", VA = "0x1833FC170")]
	public int MOCJGKGBBLI(float PPIFMHEDLGN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x33FBA40", Offset = "0x33FAE40", VA = "0x1833FBA40")]
	public IEnumerable<T> FNMBIENDFGF(float PPIFMHEDLGN, [Optional] float? DPADAHKKLIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x33FBD80", Offset = "0x33FB180", VA = "0x1833FBD80")]
	public void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x33FC1D0", Offset = "0x33FB5D0", VA = "0x1833FC1D0")]
	private void NMCDOHGEPHK(float PPIFMHEDLGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class PFHFKKKBKLN<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct KLEFEMAOIHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T KMEGGOIFMKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float DPGJLIDNNCK;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float PICMMBMHCIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> LFHIMFNOPAO;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int EKMEJKPGCBP = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private KLEFEMAOIHG[] EGIDMCNFHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int ONJPKMJDKKJ;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float LGOGAEGPKLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xEDD6B0", Offset = "0xEDCAB0", VA = "0x180EDD6B0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xEDD6A0", Offset = "0xEDCAA0", VA = "0x180EDD6A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2DB5DF0", Offset = "0x2DB51F0", VA = "0x182DB5DF0")]
	public PFHFKKKBKLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2DB5E20", Offset = "0x2DB5220", VA = "0x182DB5E20")]
	public PFHFKKKBKLN(int MKMGHJFMNMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2DB5780", Offset = "0x2DB4B80", VA = "0x182DB5780")]
	public void GBJBCHALJOG(float PPIFMHEDLGN, T KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2DB5550", Offset = "0x2DB4950", VA = "0x182DB5550")]
	public void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2DB4970", Offset = "0x2DB3D70", VA = "0x182DB4970")]
	public bool BLDOHDGOCMI(float ADFLOADHGMB, float LLEHFFKCDCM, out T KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2DB5920", Offset = "0x2DB4D20", VA = "0x182DB5920")]
	public bool INEKBLAMBGB(float ADFLOADHGMB, float LLEHFFKCDCM, out T KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2DB4F00", Offset = "0x2DB4300", VA = "0x182DB4F00")]
	public void CJOLHCFBPLF(float ADFLOADHGMB, float LLEHFFKCDCM, List<T> BFNDINBALAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2DB4940", Offset = "0x2DB3D40", VA = "0x182DB4940")]
	private int ADFEMDHGOGE(int FLGOBCNGCEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2DB5270", Offset = "0x2DB4670", VA = "0x182DB5270")]
	private void ELHCGDDANGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T CDJAAOALCOI();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T FBNCENACCMJ(T AJDPMFOKMPC, T DAAPHBHBHCO, float JELHNILOKLO);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T PMDLMCAOIJA(T KPPLMEOMNGF, float JELHNILOKLO);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T CAOPPAICFBM(T AJDPMFOKMPC, T DAAPHBHBHCO);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T BEDFHIHFBNM(T AJDPMFOKMPC, T DAAPHBHBHCO);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class KJDHLHGEMIJ : global::PFHFKKKBKLN<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1626330", Offset = "0x1625730", VA = "0x181626330", Slot = "4")]
	protected override Vector3 CDJAAOALCOI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1F03130", Offset = "0x1F02530", VA = "0x181F03130", Slot = "5")]
	protected override Vector3 FBNCENACCMJ(Vector3 AJDPMFOKMPC, Vector3 DAAPHBHBHCO, float JELHNILOKLO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x65E2A10", Offset = "0x65E1E10", VA = "0x1865E2A10", Slot = "6")]
	protected override Vector3 PMDLMCAOIJA(Vector3 KPPLMEOMNGF, float JELHNILOKLO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x65E2990", Offset = "0x65E1D90", VA = "0x1865E2990", Slot = "7")]
	protected override Vector3 CAOPPAICFBM(Vector3 AJDPMFOKMPC, Vector3 DAAPHBHBHCO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x65E2920", Offset = "0x65E1D20", VA = "0x1865E2920", Slot = "8")]
	protected override Vector3 BEDFHIHFBNM(Vector3 AJDPMFOKMPC, Vector3 DAAPHBHBHCO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x65E2A70", Offset = "0x65E1E70", VA = "0x1865E2A70")]
	public KJDHLHGEMIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class IPOEAJMHMJD : global::PFHFKKKBKLN<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x65E2270", Offset = "0x65E1670", VA = "0x1865E2270")]
	public IPOEAJMHMJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x65E22E0", Offset = "0x65E16E0", VA = "0x1865E22E0")]
	public IPOEAJMHMJD(int MKMGHJFMNMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1222300", Offset = "0x1221700", VA = "0x181222300", Slot = "4")]
	protected override float CDJAAOALCOI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3B24530", Offset = "0x3B23930", VA = "0x183B24530", Slot = "5")]
	protected override float FBNCENACCMJ(float AJDPMFOKMPC, float DAAPHBHBHCO, float JELHNILOKLO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x53F8EE0", Offset = "0x53F82E0", VA = "0x1853F8EE0", Slot = "6")]
	protected override float PMDLMCAOIJA(float KPPLMEOMNGF, float JELHNILOKLO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x25163E0", Offset = "0x25157E0", VA = "0x1825163E0", Slot = "7")]
	protected override float CAOPPAICFBM(float AJDPMFOKMPC, float DAAPHBHBHCO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x65E2260", Offset = "0x65E1660", VA = "0x1865E2260", Slot = "8")]
	protected override float BEDFHIHFBNM(float AJDPMFOKMPC, float DAAPHBHBHCO)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class AACNLNMMMPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2321610", Offset = "0x2320A10", VA = "0x182321610")]
	public static global::BDEALKJAGJG<T1> BMDGCEOIEEG<T1>(T1 HGKONLGNKBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2BA3BB0", Offset = "0x2BA2FB0", VA = "0x182BA3BB0")]
	public static global::LPBEACKBGAJ<T1, T2> BMDGCEOIEEG<T1, T2>(T1 HGKONLGNKBC, T2 HKMBMNOCDFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2BA3C20", Offset = "0x2BA3020", VA = "0x182BA3C20")]
	public static global::BFNLPGJCKII<T1, T2, T3> BMDGCEOIEEG<T1, T2, T3>(T1 HGKONLGNKBC, T2 HKMBMNOCDFA, T3 KMLGBJGMLJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x231A240", Offset = "0x2319640", VA = "0x18231A240")]
	public static global::OMICBLPCIPK<T1, T2, T3, T4> BMDGCEOIEEG<T1, T2, T3, T4>(T1 HGKONLGNKBC, T2 HKMBMNOCDFA, T3 KMLGBJGMLJK, T4 HGDCKNMELAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2BA3EF0", Offset = "0x2BA32F0", VA = "0x182BA3EF0")]
	public static global::PMLDPGBCBBM<T1, T2, T3, T4, T5> BMDGCEOIEEG<T1, T2, T3, T4, T5>(T1 HGKONLGNKBC, T2 HKMBMNOCDFA, T3 KMLGBJGMLJK, T4 HGDCKNMELAP, T5 AIHPPCMMAHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2BA3E40", Offset = "0x2BA3240", VA = "0x182BA3E40")]
	public static global::JCAENOHEBIJ<T1, T2, T3, T4, T5, T6> BMDGCEOIEEG<T1, T2, T3, T4, T5, T6>(T1 HGKONLGNKBC, T2 HKMBMNOCDFA, T3 KMLGBJGMLJK, T4 HGDCKNMELAP, T5 AIHPPCMMAHE, T6 CFEEGONNJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2BA3D80", Offset = "0x2BA3180", VA = "0x182BA3D80")]
	public static global::MMPCFCLPGPB<T1, T2, T3, T4, T5, T6, T7> BMDGCEOIEEG<T1, T2, T3, T4, T5, T6, T7>(T1 HGKONLGNKBC, T2 HKMBMNOCDFA, T3 KMLGBJGMLJK, T4 HGDCKNMELAP, T5 AIHPPCMMAHE, T6 CFEEGONNJAE, T7 GLAGMGDCJBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2BA3CB0", Offset = "0x2BA30B0", VA = "0x182BA3CB0")]
	public static global::COIHFPAEHGJ<T1, T2, T3, T4, T5, T6, T7, T8> BMDGCEOIEEG<T1, T2, T3, T4, T5, T6, T7, T8>(T1 HGKONLGNKBC, T2 HKMBMNOCDFA, T3 KMLGBJGMLJK, T4 HGDCKNMELAP, T5 AIHPPCMMAHE, T6 CFEEGONNJAE, T7 GLAGMGDCJBC, T8 FNLFFJIGFDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x17E56F0", Offset = "0x17E4AF0", VA = "0x1817E56F0")]
	[IteratorStateMachine(typeof(FNFGNPHMGHM))]
	public static IEnumerable<global::LPBEACKBGAJ<T1, T2>> OONMMHOFCKM<T1, T2>(IEnumerable<T1> BECDKHGLGNB, IEnumerable<T2> ICPOAGANOLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x17E5830", Offset = "0x17E4C30", VA = "0x1817E5830")]
	[IteratorStateMachine(typeof(IJCFJLHFONC))]
	public static IEnumerable<global::BFNLPGJCKII<T1, T2, T3>> OONMMHOFCKM<T1, T2, T3>(IEnumerable<T1> BECDKHGLGNB, IEnumerable<T2> ICPOAGANOLH, IEnumerable<T3> FILONMPFNJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x87BE90", Offset = "0x87B290", VA = "0x18087BE90")]
	internal static int GHLFNCFCEGG(int OMKLKEFFEPP, int CINIALNDCMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x87BE60", Offset = "0x87B260", VA = "0x18087BE60")]
	internal static int GHLFNCFCEGG(int OMKLKEFFEPP, int CINIALNDCMO, int PADPCIPKDPJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x87BE40", Offset = "0x87B240", VA = "0x18087BE40")]
	internal static int GHLFNCFCEGG(int OMKLKEFFEPP, int CINIALNDCMO, int PADPCIPKDPJ, int NKEKMHBHAGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x87BE70", Offset = "0x87B270", VA = "0x18087BE70")]
	internal static int GHLFNCFCEGG(int OMKLKEFFEPP, int CINIALNDCMO, int PADPCIPKDPJ, int NKEKMHBHAGD, int AMPKOIOBOLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x65DF490", Offset = "0x65DE890", VA = "0x1865DF490")]
	internal static int GHLFNCFCEGG(int OMKLKEFFEPP, int CINIALNDCMO, int PADPCIPKDPJ, int NKEKMHBHAGD, int AMPKOIOBOLH, int APKFOMOBKED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x65DF430", Offset = "0x65DE830", VA = "0x1865DF430")]
	internal static int GHLFNCFCEGG(int OMKLKEFFEPP, int CINIALNDCMO, int PADPCIPKDPJ, int NKEKMHBHAGD, int AMPKOIOBOLH, int APKFOMOBKED, int FIJGFGCGDLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x65DF460", Offset = "0x65DE860", VA = "0x1865DF460")]
	internal static int GHLFNCFCEGG(int OMKLKEFFEPP, int CINIALNDCMO, int PADPCIPKDPJ, int NKEKMHBHAGD, int AMPKOIOBOLH, int APKFOMOBKED, int FIJGFGCGDLI, int MGIKFFGMNJA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class BDEALKJAGJG<T1> : IComparable<global::BDEALKJAGJG<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T1 GBGJONJMBMP;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1F8F3E0", Offset = "0x1F8E7E0", VA = "0x181F8F3E0")]
	public BDEALKJAGJG(T1 HGKONLGNKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x300DC80", Offset = "0x300D080", VA = "0x18300DC80", Slot = "4")]
	public int CompareTo(global::BDEALKJAGJG<T1> JHMCLPBFJBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x300DCF0", Offset = "0x300D0F0", VA = "0x18300DCF0", Slot = "0")]
	public override bool Equals(object JHMCLPBFJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x92C470", Offset = "0x92B870", VA = "0x18092C470", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x300DD90", Offset = "0x300D190", VA = "0x18300DD90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class LPBEACKBGAJ<T1, T2> : IComparable<global::LPBEACKBGAJ<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 GBGJONJMBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 LIMPAOHJBNO;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1655580", Offset = "0x1654980", VA = "0x181655580")]
	public LPBEACKBGAJ(T1 HGKONLGNKBC, T2 HKMBMNOCDFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x37F7960", Offset = "0x37F6D60", VA = "0x1837F7960", Slot = "4")]
	public int CompareTo(global::LPBEACKBGAJ<T1, T2> JHMCLPBFJBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x37F8420", Offset = "0x37F7820", VA = "0x1837F8420", Slot = "0")]
	public override bool Equals(object JHMCLPBFJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x37F89F0", Offset = "0x37F7DF0", VA = "0x1837F89F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x37F8E60", Offset = "0x37F8260", VA = "0x1837F8E60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class BFNLPGJCKII<T1, T2, T3> : IComparable<global::BFNLPGJCKII<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T1 GBGJONJMBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T2 LIMPAOHJBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T3 IKPEDJOHOJN;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x30103E0", Offset = "0x300F7E0", VA = "0x1830103E0")]
	public BFNLPGJCKII(T1 HGKONLGNKBC, T2 HKMBMNOCDFA, T3 KMLGBJGMLJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x300FBD0", Offset = "0x300EFD0", VA = "0x18300FBD0", Slot = "4")]
	public int CompareTo(global::BFNLPGJCKII<T1, T2, T3> JHMCLPBFJBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x300FEC0", Offset = "0x300F2C0", VA = "0x18300FEC0", Slot = "0")]
	public override bool Equals(object JHMCLPBFJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3010030", Offset = "0x300F430", VA = "0x183010030", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3010230", Offset = "0x300F630", VA = "0x183010230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class OMICBLPCIPK<T1, T2, T3, T4> : IComparable<global::OMICBLPCIPK<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T1 GBGJONJMBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T2 LIMPAOHJBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T3 IKPEDJOHOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T4 ENPNKDJHEMD;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x22742C0", Offset = "0x22736C0", VA = "0x1822742C0")]
	public OMICBLPCIPK(T1 HGKONLGNKBC, T2 HKMBMNOCDFA, T3 KMLGBJGMLJK, T4 HGDCKNMELAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x453A490", Offset = "0x4539890", VA = "0x18453A490", Slot = "4")]
	public int CompareTo(global::OMICBLPCIPK<T1, T2, T3, T4> JHMCLPBFJBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x453A5D0", Offset = "0x45399D0", VA = "0x18453A5D0", Slot = "0")]
	public override bool Equals(object JHMCLPBFJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x453A6F0", Offset = "0x4539AF0", VA = "0x18453A6F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x453A7B0", Offset = "0x4539BB0", VA = "0x18453A7B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class PMLDPGBCBBM<T1, T2, T3, T4, T5> : IComparable<global::PMLDPGBCBBM<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T1 GBGJONJMBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T2 LIMPAOHJBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T3 IKPEDJOHOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T4 ENPNKDJHEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T5 JMJBKECKLIK;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x25B2FD0", Offset = "0x25B23D0", VA = "0x1825B2FD0")]
	public PMLDPGBCBBM(T1 HGKONLGNKBC, T2 HKMBMNOCDFA, T3 KMLGBJGMLJK, T4 HGDCKNMELAP, T5 AIHPPCMMAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x33FC340", Offset = "0x33FB740", VA = "0x1833FC340", Slot = "4")]
	public int CompareTo(global::PMLDPGBCBBM<T1, T2, T3, T4, T5> JHMCLPBFJBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x33FC4C0", Offset = "0x33FB8C0", VA = "0x1833FC4C0", Slot = "0")]
	public override bool Equals(object JHMCLPBFJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x33FC600", Offset = "0x33FBA00", VA = "0x1833FC600", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x33FC700", Offset = "0x33FBB00", VA = "0x1833FC700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class JCAENOHEBIJ<T1, T2, T3, T4, T5, T6> : IComparable<global::JCAENOHEBIJ<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T1 GBGJONJMBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T2 LIMPAOHJBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T3 IKPEDJOHOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T4 ENPNKDJHEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T5 JMJBKECKLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T6 PIFDPAJOKLN;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x316E3E0", Offset = "0x316D7E0", VA = "0x18316E3E0")]
	public JCAENOHEBIJ(T1 HGKONLGNKBC, T2 HKMBMNOCDFA, T3 KMLGBJGMLJK, T4 HGDCKNMELAP, T5 AIHPPCMMAHE, T6 CFEEGONNJAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x316DE20", Offset = "0x316D220", VA = "0x18316DE20", Slot = "4")]
	public int CompareTo(global::JCAENOHEBIJ<T1, T2, T3, T4, T5, T6> JHMCLPBFJBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x316DFE0", Offset = "0x316D3E0", VA = "0x18316DFE0", Slot = "0")]
	public override bool Equals(object JHMCLPBFJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x316E150", Offset = "0x316D550", VA = "0x18316E150", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x316E270", Offset = "0x316D670", VA = "0x18316E270", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class MMPCFCLPGPB<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::MMPCFCLPGPB<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T1 GBGJONJMBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T2 LIMPAOHJBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T3 IKPEDJOHOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T4 ENPNKDJHEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T5 JMJBKECKLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T6 PIFDPAJOKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T7 OCIPLOFNDGI;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x321A250", Offset = "0x3219650", VA = "0x18321A250")]
	public MMPCFCLPGPB(T1 HGKONLGNKBC, T2 HKMBMNOCDFA, T3 KMLGBJGMLJK, T4 HGDCKNMELAP, T5 AIHPPCMMAHE, T6 CFEEGONNJAE, T7 GLAGMGDCJBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3219BD0", Offset = "0x3218FD0", VA = "0x183219BD0", Slot = "4")]
	public int CompareTo(global::MMPCFCLPGPB<T1, T2, T3, T4, T5, T6, T7> JHMCLPBFJBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3219DD0", Offset = "0x32191D0", VA = "0x183219DD0", Slot = "0")]
	public override bool Equals(object JHMCLPBFJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3219F70", Offset = "0x3219370", VA = "0x183219F70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x321A0C0", Offset = "0x32194C0", VA = "0x18321A0C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class COIHFPAEHGJ<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::COIHFPAEHGJ<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T1 GBGJONJMBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T2 LIMPAOHJBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T3 IKPEDJOHOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T4 ENPNKDJHEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T5 JMJBKECKLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T6 PIFDPAJOKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly T7 OCIPLOFNDGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly T8 JJEOCIOKDPC;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2F21EA0", Offset = "0x2F212A0", VA = "0x182F21EA0")]
	public COIHFPAEHGJ(T1 HGKONLGNKBC, T2 HKMBMNOCDFA, T3 KMLGBJGMLJK, T4 HGDCKNMELAP, T5 AIHPPCMMAHE, T6 CFEEGONNJAE, T7 GLAGMGDCJBC, T8 FNLFFJIGFDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2F21770", Offset = "0x2F20B70", VA = "0x182F21770", Slot = "4")]
	public int CompareTo(global::COIHFPAEHGJ<T1, T2, T3, T4, T5, T6, T7, T8> JHMCLPBFJBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x2F219C0", Offset = "0x2F20DC0", VA = "0x182F219C0", Slot = "0")]
	public override bool Equals(object JHMCLPBFJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2F21B80", Offset = "0x2F20F80", VA = "0x182F21B80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2F21CF0", Offset = "0x2F210F0", VA = "0x182F21CF0", Slot = "3")]
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
	public T KMEGGOIFMKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x45B6DD0", Offset = "0x45B61D0", VA = "0x1845B6DD0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x45B6DC0", Offset = "0x45B61C0", VA = "0x1845B6DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float GOKCMFCKLIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x107D960", Offset = "0x107CD60", VA = "0x18107D960")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x45B7020", Offset = "0x45B6420", VA = "0x1845B7020")]
	public T OBIMOCJCILN(float JELHNILOKLO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x45B6EE0", Offset = "0x45B62E0", VA = "0x1845B6EE0")]
	public T HPKELBELJCC(float JELHNILOKLO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T FBNCENACCMJ(T AJDPMFOKMPC, T DAAPHBHBHCO, float JELHNILOKLO);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x14CA560", Offset = "0x14C9960", VA = "0x1814CA560")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3B24530", Offset = "0x3B23930", VA = "0x183B24530", Slot = "4")]
	protected override float FBNCENACCMJ(float AJDPMFOKMPC, float DAAPHBHBHCO, float JELHNILOKLO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x65E0FE0", Offset = "0x65E03E0", VA = "0x1865E0FE0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1F03130", Offset = "0x1F02530", VA = "0x181F03130", Slot = "4")]
	protected override Vector3 FBNCENACCMJ(Vector3 AJDPMFOKMPC, Vector3 DAAPHBHBHCO, float JELHNILOKLO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x65E8D00", Offset = "0x65E8100", VA = "0x1865E8D00")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x65DFD10", Offset = "0x65DF110", VA = "0x1865DFD10", Slot = "4")]
	protected override Color FBNCENACCMJ(Color AJDPMFOKMPC, Color DAAPHBHBHCO, float JELHNILOKLO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x65DFD60", Offset = "0x65DF160", VA = "0x1865DFD60")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class GEGGMHAEBAH : global::LCOFNCIAACG<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x65E1160", Offset = "0x65E0560", VA = "0x1865E1160")]
	public GEGGMHAEBAH(int KNECCHHDDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x65E1100", Offset = "0x65E0500", VA = "0x1865E1100")]
	public GEGGMHAEBAH(IPLKBGDEEHK[] PMGFKBCECNF, bool KDADMDNMJNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x65E1090", Offset = "0x65E0490", VA = "0x1865E1090", Slot = "6")]
	protected override uint AIPAONOKHGO(uint ADPFJJODLPO, string KPPLMEOMNGF)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class CCMFNEDMEKM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly IDisposable FDNKALDKIIB;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public CCMFNEDMEKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct FALBIMIGIKD<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class JFFCGJAMLLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x14CA560", Offset = "0x14C9960", VA = "0x1814CA560")]
		public JFFCGJAMLLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x317AF50", Offset = "0x317A350", VA = "0x18317AF50")]
		internal void <StartRequest>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> DNBHLHECBEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int PAIHCOABGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int OADJGNCOFLM;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0xC2CE90", Offset = "0xC2C290", VA = "0x180C2CE90")]
	private FALBIMIGIKD(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> CELMDPLFPMB, int OEDJAIJJCOB, int ONBCMLEDAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4556DF0", Offset = "0x45561F0", VA = "0x184556DF0")]
	public static global::FALBIMIGIKD<T> CCFMECMIHDM()
	{
		return default(global::FALBIMIGIKD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4557610", Offset = "0x4556A10", VA = "0x184557610")]
	public (int, int, Task<T>) EHFCLOLAJBJ(int EOFJKMCNNHP, [Optional] CancellationToken ANIIOKLMHLI, double FCCAADEIJOC = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4558610", Offset = "0x4557A10", VA = "0x184558610")]
	public void NOAAFBHFAKJ(int EOFJKMCNNHP, int ONBCMLEDAKN, in T GPPHCPBMODE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class HPONANPEGDP
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x65E1EC0", Offset = "0x65E12C0", VA = "0x1865E1EC0")]
	public static global::FALBIMIGIKD<ADEHAJBPFKB> CCFMECMIHDM()
	{
		return default(global::FALBIMIGIKD<ADEHAJBPFKB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x65E1F10", Offset = "0x65E1310", VA = "0x1865E1F10")]
	public static void NOAAFBHFAKJ(this in global::FALBIMIGIKD<ADEHAJBPFKB> AOFCPKBHFEM, int EOFJKMCNNHP, int ONBCMLEDAKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[DefaultMember("Item")]
public class HAIKLLMLFID<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Dictionary<TKey, TVal> KCEFCDPEMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Dictionary<TVal, TKey> NGIFKNHAAGB;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int IIEJMBAKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x1F8F3B0", Offset = "0x1F8E7B0", VA = "0x181F8F3B0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool NLCBLEMMOHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6E3D00", Offset = "0x6E3100", VA = "0x1806E3D00", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> NPJDPOGBILC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2745B20", Offset = "0x2744F20", VA = "0x182745B20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> GDNOFJBHEGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2745B50", Offset = "0x2744F50", VA = "0x182745B50", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x37B7BC0", Offset = "0x37B6FC0", VA = "0x1837B7BC0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x37B7C00", Offset = "0x37B7000", VA = "0x1837B7C00", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x37B7660", Offset = "0x37B6A60", VA = "0x1837B7660")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x37B7770", Offset = "0x37B6B70", VA = "0x1837B7770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2744E30", Offset = "0x2744230", VA = "0x182744E30", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x37B7B70", Offset = "0x37B6F70", VA = "0x1837B7B70", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x37B75E0", Offset = "0x37B69E0", VA = "0x1837B75E0", Slot = "9")]
	public void Add(TKey EBOIOCBODNI, TVal KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x37B75A0", Offset = "0x37B69A0", VA = "0x1837B75A0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> DKIDMLOAMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2744E90", Offset = "0x2744290", VA = "0x182744E90", Slot = "8")]
	public bool ContainsKey(TKey EBOIOCBODNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x37B76A0", Offset = "0x37B6AA0", VA = "0x1837B76A0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> DKIDMLOAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x27458E0", Offset = "0x2744CE0", VA = "0x1827458E0", Slot = "10")]
	public bool Remove(TKey EBOIOCBODNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x37B7B40", Offset = "0x37B6F40", VA = "0x1837B7B40", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> DKIDMLOAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x27459E0", Offset = "0x2744DE0", VA = "0x1827459E0", Slot = "11")]
	public bool TryGetValue(TKey EBOIOCBODNI, out TVal KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2745230", Offset = "0x2744630", VA = "0x182745230", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2744F20", Offset = "0x2744320", VA = "0x182744F20", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] EGIDMCNFHCK, int FMNFDAHCLKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x37B77B0", Offset = "0x37B6BB0", VA = "0x1837B77B0")]
	public void GBJBCHALJOG(TVal LGHMENDDLFI, TKey EBOIOCBODNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x37B77F0", Offset = "0x37B6BF0", VA = "0x1837B77F0")]
	public void GBJBCHALJOG(KeyValuePair<TVal, TKey> DKIDMLOAMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x37B7830", Offset = "0x37B6C30", VA = "0x1837B7830")]
	public bool GFJJHOHDGEK(TVal EBOIOCBODNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x37B7620", Offset = "0x37B6A20", VA = "0x1837B7620")]
	public bool BNDEAHDJONI(KeyValuePair<TVal, TKey> DKIDMLOAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x37B7B00", Offset = "0x37B6F00", VA = "0x1837B7B00")]
	public bool PMMODKPOELK(TVal EBOIOCBODNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x37B7B00", Offset = "0x37B6F00", VA = "0x1837B7B00")]
	public bool PMMODKPOELK(KeyValuePair<TVal, TKey> DKIDMLOAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x37B7AC0", Offset = "0x37B6EC0", VA = "0x1837B7AC0")]
	public bool OHBANFGHGGE(TVal EBOIOCBODNI, out TKey KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x27454C0", Offset = "0x27448C0", VA = "0x1827454C0")]
	public IEnumerator<KeyValuePair<TVal, TKey>> NDLLJJHKEEN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x37B7870", Offset = "0x37B6C70", VA = "0x1837B7870")]
	private void JKGBPLODBBA(TKey EBOIOCBODNI, TVal LGHMENDDLFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x37B76D0", Offset = "0x37B6AD0", VA = "0x1837B76D0")]
	private void DNKCPIGLHFN(TKey EBOIOCBODNI, TVal LGHMENDDLFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x37B7910", Offset = "0x37B6D10", VA = "0x1837B7910")]
	private bool OCIGNPPKEFD(TKey EBOIOCBODNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x37B79E0", Offset = "0x37B6DE0", VA = "0x1837B79E0")]
	private bool OCIGNPPKEFD(TVal LGHMENDDLFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2745A10", Offset = "0x2744E10", VA = "0x182745A10")]
	public HAIKLLMLFID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[DefaultMember("Item")]
public class OEMEBCEHENJ<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private global::OEMEBCEHENJ<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x6E1AC0", Offset = "0x6E0EC0", VA = "0x1806E1AC0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x332B840", Offset = "0x332AC40", VA = "0x18332B840", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x332CB00", Offset = "0x332BF00", VA = "0x18332CB00")]
		public Enumerator(global::OEMEBCEHENJ<T> BFNDINBALAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x33297A0", Offset = "0x3328BA0", VA = "0x1833297A0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x332A430", Offset = "0x3329830", VA = "0x18332A430", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3327820", Offset = "0x3326C20", VA = "0x183327820")]
		private void JJPKAKJPAOO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private T[] GCEIGNCDLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private int GJPBLFPOONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private int DGKBJMLJKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private int LFMBJAIIPEH;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int IIEJMBAKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC350", Offset = "0x2BCB750", VA = "0x182BCC350")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2BCA630", Offset = "0x2BC9A30", VA = "0x182BCA630")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB4C0", Offset = "0x2BCA8C0", VA = "0x182BCB4C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2BCC510", Offset = "0x2BCB910", VA = "0x182BCC510")]
	public OEMEBCEHENJ(int KNECCHHDDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2BCBFD0", Offset = "0x2BCB3D0", VA = "0x182BCBFD0")]
	public void GBJBCHALJOG(T JELHNILOKLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2BCAD30", Offset = "0x2BCA130", VA = "0x182BCAD30")]
	public void CMEPDJJCKOF(IEnumerable<T> ECLIJHMKGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2BCBA80", Offset = "0x2BCAE80", VA = "0x182BCBA80")]
	public void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2BCC150", Offset = "0x2BCB550", VA = "0x182BCC150")]
	public void IEAKGEPKLBN(int KJAHKKMJHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2BCC1E0", Offset = "0x2BCB5E0", VA = "0x182BCC1E0")]
	public void JIFKBOCBNNG(int KJAHKKMJHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2BCB540", Offset = "0x2BCA940", VA = "0x182BCB540")]
	public void FJCNJPIOPHM(T[] EGIDMCNFHCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2BCC2E0", Offset = "0x2BCB6E0", VA = "0x182BCC2E0")]
	public Enumerator KGLEFCHHJJI()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2BCC390", Offset = "0x2BCB790", VA = "0x182BCC390", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2BCC390", Offset = "0x2BCB790", VA = "0x182BCC390", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2BCBB90", Offset = "0x2BCAF90", VA = "0x182BCBB90")]
	private int GACEPCPJCDD(int EGBCAPEEJBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2BCC320", Offset = "0x2BCB720", VA = "0x182BCC320")]
	private int MKCBOAAOGCB(int EGBCAPEEJBF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class DDICFLKDMFA<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Func<Internal, External> DKEBKHECPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Func<External, Internal> IICCJFLIFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private IList<Internal> EHJGMBFBLBN;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IList<Internal> NPJONDNHBHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6E1120", Offset = "0x6E0520", VA = "0x1806E1120")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6E1130", Offset = "0x6E0530", VA = "0x1806E1130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool NLCBLEMMOHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7D0FA0", Offset = "0x7D03A0", VA = "0x1807D0FA0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x79A190", Offset = "0x799590", VA = "0x18079A190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public External IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2FEB840", Offset = "0x2FEAC40", VA = "0x182FEB840", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2FEB8E0", Offset = "0x2FEACE0", VA = "0x182FEB8E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int IIEJMBAKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2FEB7E0", Offset = "0x2FEABE0", VA = "0x182FEB7E0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x29C15C0", Offset = "0x29C09C0", VA = "0x1829C15C0")]
	public DDICFLKDMFA(Func<Internal, External> DKEBKHECPOH, Func<External, Internal> IICCJFLIFIF, bool BHCHPGOJODJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2FEB5B0", Offset = "0x2FEA9B0", VA = "0x182FEB5B0", Slot = "6")]
	public int IndexOf(External DKIDMLOAMGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2FEB230", Offset = "0x2FEA630", VA = "0x182FEB230", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2FEB290", Offset = "0x2FEA690", VA = "0x182FEB290", Slot = "13")]
	public bool Contains(External DKIDMLOAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2FEB320", Offset = "0x2FEA720", VA = "0x182FEB320", Slot = "14")]
	public void CopyTo(External[] EGIDMCNFHCK, int FMNFDAHCLKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2FEB140", Offset = "0x2FEA540", VA = "0x182FEB140", Slot = "11")]
	public void Add(External DKIDMLOAMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2FEB640", Offset = "0x2FEAA40", VA = "0x182FEB640", Slot = "7")]
	public void Insert(int EGBCAPEEJBF, External DKIDMLOAMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2FEB750", Offset = "0x2FEAB50", VA = "0x182FEB750", Slot = "15")]
	public bool Remove(External DKIDMLOAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2FEB6E0", Offset = "0x2FEAAE0", VA = "0x182FEB6E0", Slot = "8")]
	public void RemoveAt(int EGBCAPEEJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2FEB540", Offset = "0x2FEA940", VA = "0x182FEB540", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2594E20", Offset = "0x2594220", VA = "0x182594E20", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class GNEPAHGNHPG<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly Func<Internal, External> DKEBKHECPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private IReadOnlyList<Internal> EHJGMBFBLBN;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyList<Internal> NPJONDNHBHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x700140", Offset = "0x6FF540", VA = "0x180700140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool NLCBLEMMOHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x701020", Offset = "0x700420", VA = "0x180701020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public External IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2AD6330", Offset = "0x2AD5730", VA = "0x182AD6330", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int IIEJMBAKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2AD62D0", Offset = "0x2AD56D0", VA = "0x182AD62D0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x1F8F3E0", Offset = "0x1F8E7E0", VA = "0x181F8F3E0")]
	public GNEPAHGNHPG(Func<Internal, External> DKEBKHECPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x2AD6280", Offset = "0x2AD5680", VA = "0x182AD6280")]
	public GNEPAHGNHPG(IReadOnlyList<Internal> EHJGMBFBLBN, Func<Internal, External> DKEBKHECPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2AD5FF0", Offset = "0x2AD53F0", VA = "0x182AD5FF0")]
	public void FJCNJPIOPHM(External[] EGIDMCNFHCK, int FMNFDAHCLKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x2AD6210", Offset = "0x2AD5610", VA = "0x182AD6210", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2277660", Offset = "0x2276A60", VA = "0x182277660", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[DefaultMember("Item")]
public class BKNJAFJCJDE<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private IReadOnlyList<Internal> EHJGMBFBLBN;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IReadOnlyList<Internal> NPJONDNHBHH
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6E1AC0", Offset = "0x6E0EC0", VA = "0x1806E1AC0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x700130", Offset = "0x6FF530", VA = "0x180700130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool NLCBLEMMOHF
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x701020", Offset = "0x700420", VA = "0x180701020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public External IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x3AC0480", Offset = "0x3ABF880", VA = "0x183AC0480", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int IIEJMBAKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x3AC0420", Offset = "0x3ABF820", VA = "0x183AC0420", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x1F8F3E0", Offset = "0x1F8E7E0", VA = "0x181F8F3E0")]
	public BKNJAFJCJDE(IReadOnlyList<Internal> EHJGMBFBLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3AC00E0", Offset = "0x3ABF4E0", VA = "0x183AC00E0")]
	public bool BNDEAHDJONI(External DKIDMLOAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3AC0180", Offset = "0x3ABF580", VA = "0x183AC0180")]
	public void FJCNJPIOPHM(External[] EGIDMCNFHCK, int FMNFDAHCLKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3AC03B0", Offset = "0x3ABF7B0", VA = "0x183AC03B0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x2594E20", Offset = "0x2594220", VA = "0x182594E20", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public abstract class KMFPNHHLOKC
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void PACAOCPMOIG(object[] KCPODLJODHA);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	protected KMFPNHHLOKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public abstract class GGHGPGPPBAO<T> : KMFPNHHLOKC
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	protected struct NMHEPBDAAAP
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public enum IEKLEMGMLOG
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
		public IEKLEMGMLOG HAOFNDAEGFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public T FFBLFKDINEA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int ACJDDHCLICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly bool OPNHNGBJAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	protected readonly bool LEGEPCDGHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	protected List<T> GOCJJGCGAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<NMHEPBDAAAP> MAHKMHHNDAE;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool IPHPDBNLADP
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x3184CD0", Offset = "0x31840D0", VA = "0x183184CD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3184E50", Offset = "0x3184250", VA = "0x183184E50")]
	protected GGHGPGPPBAO(bool LEGEPCDGHPF, bool OPNHNGBJAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3184920", Offset = "0x3183D20", VA = "0x183184920")]
	protected bool EJKLFLOGMML()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x31849A0", Offset = "0x3183DA0", VA = "0x1831849A0")]
	protected void FIIPKGDHFIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3184770", Offset = "0x3183B70", VA = "0x183184770")]
	protected void ACFMFIDCDHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x2B97700", Offset = "0x2B96B00", VA = "0x182B97700")]
	private static void MNLFPNCFHGO<U>(ref List<U> EHJGMBFBLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3184B70", Offset = "0x3183F70", VA = "0x183184B70", Slot = "5")]
	public void GBJBCHALJOG(T FFBLFKDINEA, bool JBDBKMNFMEB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x3184D10", Offset = "0x3184110", VA = "0x183184D10", Slot = "6")]
	public void PMMODKPOELK(T FFBLFKDINEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3184A60", Offset = "0x3183E60", VA = "0x183184A60")]
	public void FPEOCMBDEPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface CBPENPCIKDH
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GBJBCHALJOG(Action FFBLFKDINEA, bool JBDBKMNFMEB = false);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PMMODKPOELK(Action FFBLFKDINEA);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public sealed class AMNHKKJOBOK : global::GGHGPGPPBAO<Action>, CBPENPCIKDH
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x65DF8D0", Offset = "0x65DECD0", VA = "0x1865DF8D0")]
	public AMNHKKJOBOK(bool LEGEPCDGHPF = false, bool OPNHNGBJAFB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x65DF590", Offset = "0x65DE990", VA = "0x1865DF590")]
	public void AFNFHFOAJEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x65DF860", Offset = "0x65DEC60", VA = "0x1865DF860", Slot = "4")]
	public override void PACAOCPMOIG(object[] KCPODLJODHA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x65DF800", Offset = "0x65DEC00", VA = "0x1865DF800")]
	public static AMNHKKJOBOK IIADFPNECJL(AMNHKKJOBOK KJOEIKMJJCJ, Action FFBLFKDINEA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x65DF7A0", Offset = "0x65DEBA0", VA = "0x1865DF7A0")]
	public static AMNHKKJOBOK DIGOKFOGMGH(AMNHKKJOBOK KJOEIKMJJCJ, Action FFBLFKDINEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface KADOOBCMLAM<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GBJBCHALJOG(Action<T> FFBLFKDINEA, bool JBDBKMNFMEB = false);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PMMODKPOELK(Action<T> FFBLFKDINEA);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class OKNKFJGELPL<T> : global::GGHGPGPPBAO<Action<T>>, global::KADOOBCMLAM<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x285F0E0", Offset = "0x285E4E0", VA = "0x18285F0E0")]
	public OKNKFJGELPL(bool LEGEPCDGHPF = false, bool OPNHNGBJAFB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x2BD8870", Offset = "0x2BD7C70", VA = "0x182BD8870")]
	public void AFNFHFOAJEB(T JELHNILOKLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9E50", Offset = "0x2BD9250", VA = "0x182BD9E50", Slot = "4")]
	public override void PACAOCPMOIG(object[] KCPODLJODHA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9DB0", Offset = "0x2BD91B0", VA = "0x182BD9DB0")]
	public static global::OKNKFJGELPL<T> IIADFPNECJL(global::OKNKFJGELPL<T> KJOEIKMJJCJ, Action<T> FFBLFKDINEA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9D10", Offset = "0x2BD9110", VA = "0x182BD9D10")]
	public static global::OKNKFJGELPL<T> DIGOKFOGMGH(global::OKNKFJGELPL<T> KJOEIKMJJCJ, Action<T> FFBLFKDINEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface LDDJKOKKNKN<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GBJBCHALJOG(Action<T, U> FFBLFKDINEA, bool JBDBKMNFMEB = false);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PMMODKPOELK(Action<T, U> FFBLFKDINEA);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class BJDCJLPDAMP<T, U> : global::GGHGPGPPBAO<Action<T, U>>, global::LDDJKOKKNKN<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x285F0E0", Offset = "0x285E4E0", VA = "0x18285F0E0")]
	public BJDCJLPDAMP(bool LEGEPCDGHPF = false, bool OPNHNGBJAFB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3AB6970", Offset = "0x3AB5D70", VA = "0x183AB6970")]
	public void AFNFHFOAJEB(T JELHNILOKLO, U JBPOPNPHJBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3AB6F30", Offset = "0x3AB6330", VA = "0x183AB6F30", Slot = "4")]
	public override void PACAOCPMOIG(object[] KCPODLJODHA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x3AB6E90", Offset = "0x3AB6290", VA = "0x183AB6E90")]
	public static global::BJDCJLPDAMP<T, U> IIADFPNECJL(global::BJDCJLPDAMP<T, U> KJOEIKMJJCJ, Action<T, U> FFBLFKDINEA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x3AB6DF0", Offset = "0x3AB61F0", VA = "0x183AB6DF0")]
	public static global::BJDCJLPDAMP<T, U> DIGOKFOGMGH(global::BJDCJLPDAMP<T, U> KJOEIKMJJCJ, Action<T, U> FFBLFKDINEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface DBKHFMCLHCG<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GBJBCHALJOG(Action<T, U, V> FFBLFKDINEA, bool JBDBKMNFMEB = false);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PMMODKPOELK(Action<T, U, V> FFBLFKDINEA);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class MHKIEOOGPNK<T, U, V> : global::GGHGPGPPBAO<Action<T, U, V>>, global::DBKHFMCLHCG<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x285F0E0", Offset = "0x285E4E0", VA = "0x18285F0E0")]
	public MHKIEOOGPNK(bool LEGEPCDGHPF = false, bool OPNHNGBJAFB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x36F2EC0", Offset = "0x36F22C0", VA = "0x1836F2EC0")]
	public void AFNFHFOAJEB(T JELHNILOKLO, U JBPOPNPHJBO, V APLGHPJFDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x36F5850", Offset = "0x36F4C50", VA = "0x1836F5850", Slot = "4")]
	public override void PACAOCPMOIG(object[] KCPODLJODHA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x36F3E70", Offset = "0x36F3270", VA = "0x1836F3E70")]
	public static global::MHKIEOOGPNK<T, U, V> IIADFPNECJL(global::MHKIEOOGPNK<T, U, V> KJOEIKMJJCJ, Action<T, U, V> FFBLFKDINEA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x36F3DD0", Offset = "0x36F31D0", VA = "0x1836F3DD0")]
	public static global::MHKIEOOGPNK<T, U, V> DIGOKFOGMGH(global::MHKIEOOGPNK<T, U, V> KJOEIKMJJCJ, Action<T, U, V> FFBLFKDINEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface ILPJEEDJMDA<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GBJBCHALJOG(Action<T, U, V, W> FFBLFKDINEA, bool JBDBKMNFMEB = false);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PMMODKPOELK(Action<T, U, V, W> FFBLFKDINEA);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class HIHJFNDPAIF<T, U, V, W> : global::GGHGPGPPBAO<Action<T, U, V, W>>, global::ILPJEEDJMDA<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x285F0E0", Offset = "0x285E4E0", VA = "0x18285F0E0")]
	public HIHJFNDPAIF(bool LEGEPCDGHPF = false, bool OPNHNGBJAFB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x2C0A940", Offset = "0x2C09D40", VA = "0x182C0A940")]
	public void AFNFHFOAJEB(T JELHNILOKLO, U JBPOPNPHJBO, V APLGHPJFDAI, W GMOOOEOGNJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x2C0AFC0", Offset = "0x2C0A3C0", VA = "0x182C0AFC0", Slot = "4")]
	public override void PACAOCPMOIG(object[] KCPODLJODHA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x2C0AC50", Offset = "0x2C0A050", VA = "0x182C0AC50")]
	public static global::HIHJFNDPAIF<T, U, V, W> IIADFPNECJL(global::HIHJFNDPAIF<T, U, V, W> KJOEIKMJJCJ, Action<T, U, V, W> FFBLFKDINEA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x2C0ABB0", Offset = "0x2C09FB0", VA = "0x182C0ABB0")]
	public static global::HIHJFNDPAIF<T, U, V, W> DIGOKFOGMGH(global::HIHJFNDPAIF<T, U, V, W> KJOEIKMJJCJ, Action<T, U, V, W> FFBLFKDINEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface GLCIBCJHOBB<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GBJBCHALJOG(Action<T, U, V, W, X> FFBLFKDINEA, bool JBDBKMNFMEB = false);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PMMODKPOELK(Action<T, U, V, W, X> FFBLFKDINEA);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class DENPHMPGDBO<T, U, V, W, X> : global::GGHGPGPPBAO<Action<T, U, V, W, X>>, global::GLCIBCJHOBB<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x285F0E0", Offset = "0x285E4E0", VA = "0x18285F0E0")]
	public DENPHMPGDBO(bool LEGEPCDGHPF = false, bool OPNHNGBJAFB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x2FEBEA0", Offset = "0x2FEB2A0", VA = "0x182FEBEA0")]
	public void AFNFHFOAJEB(T JELHNILOKLO, U JBPOPNPHJBO, V APLGHPJFDAI, W GMOOOEOGNJK, X PMEDGJGANML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x2FEC590", Offset = "0x2FEB990", VA = "0x182FEC590", Slot = "4")]
	public override void PACAOCPMOIG(object[] KCPODLJODHA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x2FEC1D0", Offset = "0x2FEB5D0", VA = "0x182FEC1D0")]
	public static global::DENPHMPGDBO<T, U, V, W, X> IIADFPNECJL(global::DENPHMPGDBO<T, U, V, W, X> KJOEIKMJJCJ, Action<T, U, V, W, X> FFBLFKDINEA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x2FEC130", Offset = "0x2FEB530", VA = "0x182FEC130")]
	public static global::DENPHMPGDBO<T, U, V, W, X> DIGOKFOGMGH(global::DENPHMPGDBO<T, U, V, W, X> KJOEIKMJJCJ, Action<T, U, V, W, X> FFBLFKDINEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface GBBHLCEBCOM<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GBJBCHALJOG(Action<T, U, V, W, X, Y> FFBLFKDINEA, bool JBDBKMNFMEB = false);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PMMODKPOELK(Action<T, U, V, W, X, Y> FFBLFKDINEA);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class COOBDIJLNAL<T, U, V, W, X, Y> : global::GGHGPGPPBAO<Action<T, U, V, W, X, Y>>, global::GBBHLCEBCOM<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x285F0E0", Offset = "0x285E4E0", VA = "0x18285F0E0")]
	public COOBDIJLNAL(bool LEGEPCDGHPF = false, bool OPNHNGBJAFB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2F22650", Offset = "0x2F21A50", VA = "0x182F22650")]
	public void AFNFHFOAJEB(T JELHNILOKLO, U JBPOPNPHJBO, V APLGHPJFDAI, W GMOOOEOGNJK, X PMEDGJGANML, Y NIPKEFBPNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x2F23380", Offset = "0x2F22780", VA = "0x182F23380", Slot = "4")]
	public override void PACAOCPMOIG(object[] KCPODLJODHA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2F22F70", Offset = "0x2F22370", VA = "0x182F22F70")]
	public static global::COOBDIJLNAL<T, U, V, W, X, Y> IIADFPNECJL(global::COOBDIJLNAL<T, U, V, W, X, Y> KJOEIKMJJCJ, Action<T, U, V, W, X, Y> FFBLFKDINEA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x2F22ED0", Offset = "0x2F222D0", VA = "0x182F22ED0")]
	public static global::COOBDIJLNAL<T, U, V, W, X, Y> DIGOKFOGMGH(global::COOBDIJLNAL<T, U, V, W, X, Y> KJOEIKMJJCJ, Action<T, U, V, W, X, Y> FFBLFKDINEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class CEIIPCHPNJC<T>
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public readonly struct AHLKCJLELCI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly global::CEIIPCHPNJC<T> ELPNDIMJFJD;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public T KMEGGOIFMKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x2597450", Offset = "0x2596850", VA = "0x182597450")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2597470", Offset = "0x2596870", VA = "0x182597470", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8B6D70", Offset = "0x8B6170", VA = "0x1808B6D70")]
		public AHLKCJLELCI(global::CEIIPCHPNJC<T> ELPNDIMJFJD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct BFLGDBHMGND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder<AHLKCJLELCI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public global::CEIIPCHPNJC<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x300F390", Offset = "0x300E790", VA = "0x18300F390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x1E366A0", Offset = "0x1E35AA0", VA = "0x181E366A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct PONLLNBKLMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AsyncTaskMethodBuilder<AHLKCJLELCI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public global::CEIIPCHPNJC<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x33FFDF0", Offset = "0x33FF1F0", VA = "0x1833FFDF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x1E366A0", Offset = "0x1E35AA0", VA = "0x181E366A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly SemaphoreSlim MGADMBNMLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private T NDMDBDBHNJA;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int GMPJJFMGIFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x23F6B60", Offset = "0x23F5F60", VA = "0x1823F6B60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x23F6BB0", Offset = "0x23F5FB0", VA = "0x1823F6BB0")]
	public CEIIPCHPNJC(in T NDMDBDBHNJA, int AFHNPPODHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x23F6B80", Offset = "0x23F5F80", VA = "0x1823F6B80")]
	public CEIIPCHPNJC(in T NDMDBDBHNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x23F6540", Offset = "0x23F5940", VA = "0x1823F6540")]
	public AHLKCJLELCI CAKHMFMNJDD()
	{
		return default(AHLKCJLELCI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x23F6580", Offset = "0x23F5980", VA = "0x1823F6580")]
	public AHLKCJLELCI CAKHMFMNJDD(CancellationToken ANIIOKLMHLI)
	{
		return default(AHLKCJLELCI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x23F65C0", Offset = "0x23F59C0", VA = "0x1823F65C0")]
	[AsyncStateMachine(typeof(global::CEIIPCHPNJC<>.BFLGDBHMGND))]
	public Task<AHLKCJLELCI> IHKDHGBGKKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x23F6720", Offset = "0x23F5B20", VA = "0x1823F6720")]
	[AsyncStateMachine(typeof(global::CEIIPCHPNJC<>.PONLLNBKLMM))]
	public Task<AHLKCJLELCI> IHKDHGBGKKJ(CancellationToken ANIIOKLMHLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class MCAILHPOCAF
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x65E42D0", Offset = "0x65E36D0", VA = "0x1865E42D0")]
	public static global::CEIIPCHPNJC<ADEHAJBPFKB> CCFMECMIHDM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x65E4260", Offset = "0x65E3660", VA = "0x1865E4260")]
	public static global::CEIIPCHPNJC<ADEHAJBPFKB> CCFMECMIHDM(int AFHNPPODHNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2321610", Offset = "0x2320A10", VA = "0x182321610")]
	public static global::CEIIPCHPNJC<T> CCFMECMIHDM<T>(in T NDMDBDBHNJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x231A0B0", Offset = "0x23194B0", VA = "0x18231A0B0")]
	public static global::CEIIPCHPNJC<T> CCFMECMIHDM<T>(in T NDMDBDBHNJA, int AFHNPPODHNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class HGPOCIPMKLB<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public delegate Task<TResult> AKCHPLEKCJI(TRequest LPOCBPNMNHF, CancellationToken ANIIOKLMHLI);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public enum AAIEDIBJBCO
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class MCDIIDOFMCK
	{
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private const float ODMAAPDOFMA = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TimeSpan MPDIAFHBDBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int DBGAKGDADNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public AAIEDIBJBCO FFOGGNOCKAI;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly MCDIIDOFMCK LMPNKNOCBFL;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float PNFHDNAPDBG
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x30B2180", Offset = "0x30B1580", VA = "0x1830B2180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TimeSpan DDHKBONDNEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x6E1AC0", Offset = "0x6E0EC0", VA = "0x1806E1AC0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x30B2260", Offset = "0x30B1660", VA = "0x1830B2260")]
		public MCDIIDOFMCK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private readonly struct ILIINFPFPPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly TRequest LPOCBPNMNHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public readonly CancellationToken ANIIOKLMHLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public readonly TaskCompletionSource<TResult> LOGPJLDPMEJ;

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x226A370", Offset = "0x2269770", VA = "0x18226A370")]
		public ILIINFPFPPP(TRequest LPOCBPNMNHF, TaskCompletionSource<TResult> LOGPJLDPMEJ, CancellationToken ANIIOKLMHLI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class DBAOAKEEGJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x14CA560", Offset = "0x14C9960", VA = "0x1814CA560")]
		public DBAOAKEEGJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x1F8F3B0", Offset = "0x1F8E7B0", VA = "0x181F8F3B0")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct AGNEIGDDGNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public global::HGPOCIPMKLB<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2593B00", Offset = "0x2592F00", VA = "0x182593B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct FJKHMBFNPNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public global::HGPOCIPMKLB<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private ILIINFPFPPP <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2AB1900", Offset = "0x2AB0D00", VA = "0x182AB1900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CancellationTokenSource HECDCLJAOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly List<ILIINFPFPPP> DEHOEMIKPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly MCDIIDOFMCK GPCMGPIDCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly AKCHPLEKCJI MNEMHNDIPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Task LDPHFIMKCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int GGJPCKGKICB;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x275CB50", Offset = "0x275BF50", VA = "0x18275CB50")]
	public HGPOCIPMKLB(AKCHPLEKCJI MNEMHNDIPFI, [Optional] MCDIIDOFMCK GPCMGPIDCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x275C500", Offset = "0x275B900", VA = "0x18275C500")]
	public Task<TResult> PCHHADECPGF(TRequest LPOCBPNMNHF, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x275B0B0", Offset = "0x275A4B0", VA = "0x18275B0B0")]
	private void CDMBJKMIJKC(ILIINFPFPPP PLNILFDALDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x275BAC0", Offset = "0x275AEC0", VA = "0x18275BAC0")]
	[AsyncStateMachine(typeof(global::HGPOCIPMKLB<, >.AGNEIGDDGNG))]
	private Task EAJFHODJKLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x275B730", Offset = "0x275AB30", VA = "0x18275B730")]
	private ILIINFPFPPP DKMCAJNFHJB()
	{
		return default(ILIINFPFPPP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x275BCC0", Offset = "0x275B0C0", VA = "0x18275BCC0")]
	[AsyncStateMachine(typeof(global::HGPOCIPMKLB<, >.FJKHMBFNPNI))]
	private Task EDOBCDCADCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x275C020", Offset = "0x275B420", VA = "0x18275C020")]
	private void JOILBCHNAOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x275B980", Offset = "0x275AD80", VA = "0x18275B980", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class IBGOFOGAKAB<TKey, TVal> : global::FDAJJEOIJNC<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int CDCFNMHMBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	internal Dictionary<TKey, (TVal value, int size)> KMMHKAEHMLD;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	internal override int EFFHHIFFELC
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x1654410", Offset = "0x1653810", VA = "0x181654410", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal int KOADAMFCACE
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x1654440", Offset = "0x1653840", VA = "0x181654440")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public override int IIEJMBAKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x16545B0", Offset = "0x16539B0", VA = "0x1816545B0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x16548C0", Offset = "0x1653CC0", VA = "0x1816548C0")]
	public IBGOFOGAKAB(int KNECCHHDDJH, [Optional] CFCLNHDJEGH CGIEPPMHLMK, [Optional] IEqualityComparer<TKey> IFENNNCDFOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x1654510", Offset = "0x1653910", VA = "0x181654510")]
	public void MPKDOIPPJCF(TKey EBOIOCBODNI, TVal KPPLMEOMNGF, bool JPHJFEDHIFN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x1654390", Offset = "0x1653790", VA = "0x181654390")]
	public bool ICENGNLALKG(TKey EBOIOCBODNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x1654820", Offset = "0x1653C20", VA = "0x181654820", Slot = "6")]
	public override bool OHBANFGHGGE(TKey JAFJDPHMLKF, out TVal KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x1654610", Offset = "0x1653A10", VA = "0x181654610")]
	public bool OABEJPGAFLB(TKey EBOIOCBODNI, TVal KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x1654210", Offset = "0x1653610", VA = "0x181654210")]
	public bool DNBEMAOIKEO(TKey EBOIOCBODNI, TVal KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x1654320", Offset = "0x1653720", VA = "0x181654320", Slot = "7")]
	public override void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x1654470", Offset = "0x1653870", VA = "0x181654470")]
	private bool MLBFBMDKBNM(TKey EBOIOCBODNI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[DefaultMember("Item")]
public class FDAJJEOIJNC<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public delegate int CFCLNHDJEGH(TKey EBOIOCBODNI, TVal KPPLMEOMNGF);

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class PNHHPNLGDOL
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public TKey BJHDKAELIBE
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xCE63C0", Offset = "0xCE57C0", VA = "0x180CE63C0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public TVal KMEGGOIFMKC
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x6E1120", Offset = "0x6E0520", VA = "0x1806E1120")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x6E1130", Offset = "0x6E0530", VA = "0x1806E1130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public int MDNIDCCLGIH
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x7021B0", Offset = "0x7015B0", VA = "0x1807021B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xA23B00", Offset = "0xA22F00", VA = "0x180A23B00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public DateTime IILOJKHJAOA
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x6F66F0", Offset = "0x6F5AF0", VA = "0x1806F66F0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0xDD91D0", Offset = "0xDD85D0", VA = "0x180DD91D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x33FCB30", Offset = "0x33FBF30", VA = "0x1833FCB30")]
		public PNHHPNLGDOL(TKey EBOIOCBODNI, TVal LGHMENDDLFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public const int NHPOCDLHNNJ = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly Dictionary<TKey, LinkedListNode<PNHHPNLGDOL>> GNIHKFCAFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly LinkedList<PNHHPNLGDOL> CGPBAPMDJDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	protected readonly CFCLNHDJEGH CGIEPPMHLMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly TimeSpan AJHFCAAECNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly DBDNLIGDGMG LAOHJPNFPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int NOGIKENPABJ;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int LFCNNPBFNIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6E0020", Offset = "0x6DF420", VA = "0x1806E0020")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private bool BGHDDIHNPMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x45657B0", Offset = "0x4564BB0", VA = "0x1845657B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal virtual int EFFHHIFFELC
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x935FD0", Offset = "0x9353D0", VA = "0x180935FD0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private int KJAHKKMJHHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x166F160", Offset = "0x166E560", VA = "0x18166F160")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public virtual int IIEJMBAKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x2591D70", Offset = "0x2591170", VA = "0x182591D70", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public IEnumerable<TKey> NPJDPOGBILC
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x4567DE0", Offset = "0x45671E0", VA = "0x184567DE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public TVal IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x4565FC0", Offset = "0x45653C0", VA = "0x184565FC0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3004520", Offset = "0x3003920", VA = "0x183004520")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x4568E70", Offset = "0x4568270", VA = "0x184568E70")]
	public FDAJJEOIJNC(int KNECCHHDDJH, [Optional] CFCLNHDJEGH CGIEPPMHLMK, [Optional] IEqualityComparer<TKey> IFENNNCDFOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x4568C80", Offset = "0x4568080", VA = "0x184568C80")]
	public FDAJJEOIJNC(TimeSpan AJHFCAAECNO, [Optional] IEqualityComparer<TKey> IFENNNCDFOA, [Optional] DBDNLIGDGMG LAOHJPNFPHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x45689B0", Offset = "0x4567DB0", VA = "0x1845689B0")]
	public FDAJJEOIJNC(int KNECCHHDDJH, TimeSpan AJHFCAAECNO, [Optional] IEqualityComparer<TKey> IFENNNCDFOA, [Optional] DBDNLIGDGMG LAOHJPNFPHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x4569290", Offset = "0x4568690", VA = "0x184569290")]
	public FDAJJEOIJNC(int KNECCHHDDJH, CFCLNHDJEGH CGIEPPMHLMK, TimeSpan AJHFCAAECNO, [Optional] IEqualityComparer<TKey> IFENNNCDFOA, [Optional] DBDNLIGDGMG LAOHJPNFPHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x45659B0", Offset = "0x4564DB0", VA = "0x1845659B0")]
	public void AIADDINDGCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x4567D00", Offset = "0x4567100", VA = "0x184567D00")]
	public void JPNFGACMGOG(TKey EBOIOCBODNI, TVal KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x4568840", Offset = "0x4567C40", VA = "0x184568840")]
	public bool PMMODKPOELK(TKey EBOIOCBODNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x4565D40", Offset = "0x4565140", VA = "0x184565D40")]
	private TVal BOEAFIEBIHC(TKey JAFJDPHMLKF)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x4568000", Offset = "0x4567400", VA = "0x184568000", Slot = "6")]
	public virtual bool OHBANFGHGGE(TKey JAFJDPHMLKF, out TVal KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x4566910", Offset = "0x4565D10", VA = "0x184566910", Slot = "7")]
	public virtual void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x4567190", Offset = "0x4566590", VA = "0x184567190")]
	private bool JFMJPMOEPOM(PNHHPNLGDOL DBHMANJEIFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x45666C0", Offset = "0x4565AC0", VA = "0x1845666C0")]
	private void CPAGFDKFLNO(LinkedListNode<PNHHPNLGDOL> DNJFPCMOOIN, TVal GLLAKMPHGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x45674F0", Offset = "0x45668F0", VA = "0x1845674F0")]
	private void JPJHPPMDCBA(TKey EBOIOCBODNI, TVal KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x4566CC0", Offset = "0x45660C0", VA = "0x184566CC0")]
	private void GIIKGBOBGKH(PNHHPNLGDOL DBHMANJEIFC, TVal GLLAKMPHGJD, int JOGABEMONJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[DefaultMember("Item")]
public class DGLBFKEJDAB<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly List<T> EHJGMBFBLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private HashSet<T> FIKNOHMIHMG;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int IIEJMBAKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x1F8F3B0", Offset = "0x1F8E7B0", VA = "0x181F8F3B0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool NLCBLEMMOHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x6E3D00", Offset = "0x6E3100", VA = "0x1806E3D00", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public T IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x284E330", Offset = "0x284D730", VA = "0x18284E330", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2FF4220", Offset = "0x2FF3620", VA = "0x182FF4220", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x2FF3930", Offset = "0x2FF2D30", VA = "0x182FF3930", Slot = "11")]
	public void Add(T DKIDMLOAMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x2FF37E0", Offset = "0x2FF2BE0", VA = "0x182FF37E0")]
	public bool APHPNPEMCLE(T DKIDMLOAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x2FF4000", Offset = "0x2FF3400", VA = "0x182FF4000", Slot = "15")]
	public bool Remove(T DKIDMLOAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x2FF39F0", Offset = "0x2FF2DF0", VA = "0x182FF39F0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x23F5640", Offset = "0x23F4A40", VA = "0x1823F5640", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x2FF3960", Offset = "0x2FF2D60", VA = "0x182FF3960", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x2770BC0", Offset = "0x276FFC0", VA = "0x182770BC0", Slot = "13")]
	public bool Contains(T DKIDMLOAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x2FF39C0", Offset = "0x2FF2DC0", VA = "0x182FF39C0", Slot = "14")]
	public void CopyTo(T[] EGIDMCNFHCK, int FMNFDAHCLKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x2745AF0", Offset = "0x2744EF0", VA = "0x182745AF0", Slot = "6")]
	public int IndexOf(T DKIDMLOAMGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x2FF3A70", Offset = "0x2FF2E70", VA = "0x182FF3A70", Slot = "7")]
	public void Insert(int EGBCAPEEJBF, T DKIDMLOAMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x2FF3DD0", Offset = "0x2FF31D0", VA = "0x182FF3DD0", Slot = "8")]
	public void RemoveAt(int EGBCAPEEJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x2FF3C00", Offset = "0x2FF3000", VA = "0x182FF3C00")]
	public void KCFEMAHCNFC(Predicate<T> ELLKBPHIOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x2FF3DA0", Offset = "0x2FF31A0", VA = "0x182FF3DA0")]
	public void OIEPKIMNLDG(Comparison<T> JHEBLNIDFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x2FF4080", Offset = "0x2FF3480", VA = "0x182FF4080")]
	public DGLBFKEJDAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class GOBHHIGLMGD
{
	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x65E14D0", Offset = "0x65E08D0", VA = "0x1865E14D0")]
	public static Vector3 KIEFAECENPP(this GameObject BLPBCMIHDMD, float PEMFPEMMLNF)
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
			[Cpp2IlInjected.Address(RVA = "0x2CD0EE0", Offset = "0x2CD02E0", VA = "0x182CD0EE0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x65D6590", Offset = "0x65D5990", VA = "0x1865D6590")]
		public SerializedGuid(in Guid DBODHDCBMLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x65E80A0", Offset = "0x65E74A0", VA = "0x1865E80A0")]
		public static SerializedGuid IJJLMEBIKJO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x65E8130", Offset = "0x65E7530", VA = "0x1865E8130")]
		public static SerializedGuid LHLJCCBFLCJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x65E7E80", Offset = "0x65E7280", VA = "0x1865E7E80")]
		public bool CFLJFFCDDJL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x65D6560", Offset = "0x65D5960", VA = "0x1865D6560", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x65E8250", Offset = "0x65E7650", VA = "0x1865E8250", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x65E81C0", Offset = "0x65E75C0", VA = "0x1865E81C0")]
		public bool OGHMKNDIAJH(in Guid DBODHDCBMLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x65E7F10", Offset = "0x65E7310", VA = "0x1865E7F10", Slot = "7")]
		public bool Equals(SerializedGuid JHMCLPBFJBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x65E7FC0", Offset = "0x65E73C0", VA = "0x1865E7FC0", Slot = "0")]
		public override bool Equals(object AELIHOPICED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x65D64B0", Offset = "0x65D58B0", VA = "0x1865D64B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x65D62F0", Offset = "0x65D56F0", VA = "0x1865D62F0", Slot = "6")]
		public int CompareTo(SerializedGuid JHMCLPBFJBC)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class GDOCEKKICHK : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly Type DPOLLFJHGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly string EFIFIOFOCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly bool ELNIHDIALNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly bool OCPIIFDMLIH;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x65E1020", Offset = "0x65E0420", VA = "0x1865E1020")]
	public GDOCEKKICHK(Type NMHGDNOBLPL, string BEJMEINOPAL, bool OMGAKLBNBAH = false, bool FNMEJKLGGOD = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface GJNIPDHKKKL
{
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface LLIMMBAHHCD<T> : GJNIPDHKKKL
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	T KMEGGOIFMKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool FNEFGEAJLED
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	string LMOKLBIBGKI
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
	global::LLIMMBAHHCD<T> OINNAEPBHKF(Action<T> NDDKAFJABEI);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::LLIMMBAHHCD<T> OMFFPPHPCCG(Action<T> NDDKAFJABEI);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::LLIMMBAHHCD<T> BDDNKFFNJFO(Action<T, T> LDCBNEEBIEN);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::LLIMMBAHHCD<T> OJEBDEPAIPD(Action<T, T> LDCBNEEBIEN);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::LLIMMBAHHCD<T> PIGMIOJKHEM(Action<string> FCDNDBBKDGJ);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::LLIMMBAHHCD<T> GHDFFHENGHJ(Action<string> FCDNDBBKDGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class LAFJDMFECBM<T> : global::LLIMMBAHHCD<T>, GJNIPDHKKKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private global::BJDCJLPDAMP<T, T> INICELMJPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private global::OKNKFJGELPL<T> NBNIPAJCKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private global::OKNKFJGELPL<string> JHLHBHPJJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private string CNMFEBEOFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private T GPPHCPBMODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool JKHHIPCDFLG;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public T KMEGGOIFMKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6F66F0", Offset = "0x6F5AF0", VA = "0x1806F66F0", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x1673710", Offset = "0x1672B10", VA = "0x181673710", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool FNEFGEAJLED
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x7AB560", Offset = "0x7AA960", VA = "0x1807AB560", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string LMOKLBIBGKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x6FA8E0", Offset = "0x6F9CE0", VA = "0x1806FA8E0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x1B93D00", Offset = "0x1B93100", VA = "0x181B93D00", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x26B0D10", Offset = "0x26B0110", VA = "0x1826B0D10")]
	private void NJAFIFNAEFP(T OBBOCNIOLOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x26B0BB0", Offset = "0x26AFFB0", VA = "0x1826B0BB0")]
	private void HLHIGOAHNDB(string GOMILMNIGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x26B0C60", Offset = "0x26B0060", VA = "0x1826B0C60")]
	public void IKINEIFADPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x26B0AF0", Offset = "0x26AFEF0", VA = "0x1826B0AF0", Slot = "6")]
	public global::LLIMMBAHHCD<T> BDDNKFFNJFO(Action<T, T> LDCBNEEBIEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x26B0E40", Offset = "0x26B0240", VA = "0x1826B0E40", Slot = "7")]
	public global::LLIMMBAHHCD<T> OJEBDEPAIPD(Action<T, T> LDCBNEEBIEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x26B0DB0", Offset = "0x26B01B0", VA = "0x1826B0DB0", Slot = "4")]
	public global::LLIMMBAHHCD<T> OINNAEPBHKF(Action<T> LDCBNEEBIEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x26B0E90", Offset = "0x26B0290", VA = "0x1826B0E90", Slot = "5")]
	public global::LLIMMBAHHCD<T> OMFFPPHPCCG(Action<T> NDDKAFJABEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x26B0EE0", Offset = "0x26B02E0", VA = "0x1826B0EE0", Slot = "8")]
	public global::LLIMMBAHHCD<T> PIGMIOJKHEM(Action<string> FCDNDBBKDGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x26B0B40", Offset = "0x26AFF40", VA = "0x1826B0B40", Slot = "9")]
	public global::LLIMMBAHHCD<T> GHDFFHENGHJ(Action<string> FCDNDBBKDGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x26B0F80", Offset = "0x26B0380", VA = "0x1826B0F80")]
	public LAFJDMFECBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class OIJBFOODIPH
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class EHBEFKKDGKA<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public global::LLIMMBAHHCD<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public global::BLIGMBCADIE<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x14CA560", Offset = "0x14C9960", VA = "0x1814CA560")]
		public EHBEFKKDGKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x29C4860", Offset = "0x29C3C60", VA = "0x1829C4860")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x2A456B0", Offset = "0x2A44AB0", VA = "0x182A456B0")]
	public static global::MLDKKGKEACN<T> IPFANDCPJOE<T>(this global::LLIMMBAHHCD<T> PEAIKAIKMLJ, Action<T> PEPHBHFBJFE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class AOKCPNNMNJG<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public readonly struct IGHABDLGAKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public readonly long DFAJCDNCKCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public readonly long ACGICELBFMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public readonly int OODPELJGEFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public readonly int MCIFLELHFJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public readonly bool DAGLEMHEBPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly string PLKFKNKNNEP;

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x166EA90", Offset = "0x166DE90", VA = "0x18166EA90")]
		public IGHABDLGAKI(long DFAJCDNCKCP, int OODPELJGEFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x166EB00", Offset = "0x166DF00", VA = "0x18166EB00")]
		public IGHABDLGAKI(long DFAJCDNCKCP, long ACGICELBFMG, int OODPELJGEFJ, int MCIFLELHFJK, bool DAGLEMHEBPF, string PLKFKNKNNEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x166E8D0", Offset = "0x166DCD0", VA = "0x18166E8D0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void FHKFEGDMBFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x166E9D0", Offset = "0x166DDD0", VA = "0x18166E9D0")]
		public int KAFLKCHAPLH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x166E8B0", Offset = "0x166DCB0", VA = "0x18166E8B0")]
		public int FFONFNEMCOH(int HBLDLJGGFFF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x166EA20", Offset = "0x166DE20", VA = "0x18166EA20")]
		public double LLJPDHFOPPP()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x166E940", Offset = "0x166DD40", VA = "0x18166E940")]
		public IGHABDLGAKI HOBFECFFPHL(long ACGICELBFMG, int MCIFLELHFJK)
		{
			return default(IGHABDLGAKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class OEPFOLMCINK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly TKey BJHDKAELIBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly global::AOKCPNNMNJG<TKey> GGLDKMHDNCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private List<OEPFOLMCINK> IDMJDFIHEAE;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string EAOLLMAHIGO
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x25B04F0", Offset = "0x25AF8F0", VA = "0x1825B04F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x25AFED0", Offset = "0x25AF2D0", VA = "0x1825AFED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public IEnumerable<OEPFOLMCINK> BIMGCBEFPGI
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x2BCC6C0", Offset = "0x2BCBAC0", VA = "0x182BCC6C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public IGHABDLGAKI IJHHPHDPOFG
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x16AD9D0", Offset = "0x16ACDD0", VA = "0x1816AD9D0")]
			[CompilerGenerated]
			get
			{
				return default(IGHABDLGAKI);
			}
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x2BCC970", Offset = "0x2BCBD70", VA = "0x182BCC970")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC9A0", Offset = "0x2BCBDA0", VA = "0x182BCC9A0")]
		internal OEPFOLMCINK(global::AOKCPNNMNJG<TKey> GGLDKMHDNCA, TKey EBOIOCBODNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC5B0", Offset = "0x2BCB9B0", VA = "0x182BCC5B0")]
		public OEPFOLMCINK CACMKGMHMLE(TKey EBOIOCBODNI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC890", Offset = "0x2BCBC90", VA = "0x182BCC890")]
		public void MHJKIIEGCDH(TKey EBOIOCBODNI, Action<OEPFOLMCINK> FFBLFKDINEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x26F19F0", Offset = "0x26F0DF0", VA = "0x1826F19F0")]
		public T MHJKIIEGCDH<T>(TKey EBOIOCBODNI, Func<OEPFOLMCINK, T> EGHDMBPEGFF)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x26F1880", Offset = "0x26F0C80", VA = "0x1826F1880")]
		[AsyncStateMachine(typeof(GJKKGOMJFCC))]
		public Task<T> LIELANMHGDA<T>(TKey EBOIOCBODNI, Func<OEPFOLMCINK, Task<T>> EGHDMBPEGFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC6E0", Offset = "0x2BCBAE0", VA = "0x182BCC6E0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class AAJKDHADGOI : IEnumerable<(TKey, List<TKey>, IGHABDLGAKI)>, IEnumerable, IEnumerator<(TKey, List<TKey>, IGHABDLGAKI)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private (TKey key, List<TKey> path, IGHABDLGAKI timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public global::AOKCPNNMNJG<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private IEnumerator<(TKey key, List<TKey> path, IGHABDLGAKI timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		private (TKey, List<TKey>, IGHABDLGAKI) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x354F400", Offset = "0x354E800", VA = "0x18354F400", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, IGHABDLGAKI));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x35C1CA0", Offset = "0x35C10A0", VA = "0x1835C1CA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x35C1D50", Offset = "0x35C1150", VA = "0x1835C1D50")]
		[DebuggerHidden]
		public AAJKDHADGOI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x32B8820", Offset = "0x32B7C20", VA = "0x1832B8820", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x35C18F0", Offset = "0x35C0CF0", VA = "0x1835C18F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x35C1D00", Offset = "0x35C1100", VA = "0x1835C1D00")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x35C1C60", Offset = "0x35C1060", VA = "0x1835C1C60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x35C1BA0", Offset = "0x35C0FA0", VA = "0x1835C1BA0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, IGHABDLGAKI)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x27E12F0", Offset = "0x27E06F0", VA = "0x1827E12F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class JOAHKLCPLMP : IEnumerable<(TKey, List<TKey>, IGHABDLGAKI)>, IEnumerable, IEnumerator<(TKey, List<TKey>, IGHABDLGAKI)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private (TKey key, List<TKey> path, IGHABDLGAKI timerEntry) <>2__current;

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
		private OEPFOLMCINK timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public OEPFOLMCINK <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public global::AOKCPNNMNJG<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private IEnumerator<OEPFOLMCINK> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private IEnumerator<(TKey key, List<TKey> path, IGHABDLGAKI timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		private (TKey, List<TKey>, IGHABDLGAKI) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x354F400", Offset = "0x354E800", VA = "0x18354F400", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, IGHABDLGAKI));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x36183A0", Offset = "0x36177A0", VA = "0x1836183A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x35C1D50", Offset = "0x35C1150", VA = "0x1835C1D50")]
		[DebuggerHidden]
		public JOAHKLCPLMP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x3618400", Offset = "0x3617800", VA = "0x183618400", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x3617CB0", Offset = "0x36170B0", VA = "0x183617CB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x36184A0", Offset = "0x36178A0", VA = "0x1836184A0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x3618500", Offset = "0x3617900", VA = "0x183618500")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3618360", Offset = "0x3617760", VA = "0x183618360", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x3618250", Offset = "0x3617650", VA = "0x183618250", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, IGHABDLGAKI)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x3618330", Offset = "0x3617730", VA = "0x183618330", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Action<TKey, IGHABDLGAKI> NOFOBODAHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Action<TKey, IGHABDLGAKI> JOGOMHAPJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly Action<global::AOKCPNNMNJG<TKey>> DCJCHJDICAH;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private const string ADGHCOHPGJP = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly OEPFOLMCINK GGDMPLMHJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool LJINJAFAKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private int KINDIJCEDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly Stopwatch PKADFIOHLGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly int BHDDKGOMEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private string OEFOCGPPBNK;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public OEPFOLMCINK IFHJOOKGNBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6FA8E0", Offset = "0x6F9CE0", VA = "0x1806FA8E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	[NotNull]
	public string EAOLLMAHIGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x6E00D0", Offset = "0x6DF4D0", VA = "0x1806E00D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x38A4740", Offset = "0x38A3B40", VA = "0x1838A4740")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public long HMOHDCAKFKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x38A4900", Offset = "0x38A3D00", VA = "0x1838A4900")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int GBPGLODGBJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x38A48B0", Offset = "0x38A3CB0", VA = "0x1838A48B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x38A4A80", Offset = "0x38A3E80", VA = "0x1838A4A80")]
	public AOKCPNNMNJG(TKey BBHNDIDHLFD, [Optional] int? OODPELJGEFJ, [Optional][CanBeNull] Stopwatch PKADFIOHLGK, [Optional] Action<TKey, IGHABDLGAKI> NOFOBODAHNP, [Optional] Action<TKey, IGHABDLGAKI> JOGOMHAPJHK, [Optional] Action<global::AOKCPNNMNJG<TKey>> DCJCHJDICAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x38A4820", Offset = "0x38A3C20", VA = "0x1838A4820", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x38A48E0", Offset = "0x38A3CE0", VA = "0x1838A48E0")]
	public void JIGPOMNNKDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x38A4720", Offset = "0x38A3B20", VA = "0x1838A4720")]
	public void BEGIGECCIDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x38A4920", Offset = "0x38A3D20", VA = "0x1838A4920")]
	[IteratorStateMachine(typeof(global::AOKCPNNMNJG<>.AAJKDHADGOI))]
	public IEnumerable<(TKey, List<TKey>, IGHABDLGAKI)> NDCBCJJHFKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x38A49B0", Offset = "0x38A3DB0", VA = "0x1838A49B0")]
	[IteratorStateMachine(typeof(global::AOKCPNNMNJG<>.JOAHKLCPLMP))]
	private IEnumerable<(TKey, List<TKey>, IGHABDLGAKI)> NDCBCJJHFKI(List<TKey> NEIBENCLOEC, OEPFOLMCINK GEJGLIEIBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x38A47A0", Offset = "0x38A3BA0", VA = "0x1838A47A0")]
	private (long, int) DHIFFJLCEFF()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class HDGLHOIEEBG<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut OKCHPNFGGFF(global::AOKCPNNMNJG<TKey> GGLDKMHDNCA);

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x14CA560", Offset = "0x14C9960", VA = "0x1814CA560")]
	protected HDGLHOIEEBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public abstract class AHGHOLJBPEN<TKey> : global::HDGLHOIEEBG<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate string KHKOOJLDACG(TKey EBOIOCBODNI);

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x2594DB0", Offset = "0x25941B0", VA = "0x182594DB0")]
	protected string PBKBDMEPBCL(double FGPMDIPMDJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x2594B70", Offset = "0x2593F70", VA = "0x182594B70")]
	protected string IJFDHBODBKK(int DKAJDLCKJED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x2594B30", Offset = "0x2593F30", VA = "0x182594B30")]
	private static string GFOMLEKPIBK(TKey EBOIOCBODNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x2594BD0", Offset = "0x2593FD0", VA = "0x182594BD0", Slot = "4")]
	public override string OKCHPNFGGFF(global::AOKCPNNMNJG<TKey> GGLDKMHDNCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x2594C80", Offset = "0x2594080", VA = "0x182594C80")]
	public string OKCHPNFGGFF(global::AOKCPNNMNJG<TKey> GGLDKMHDNCA, [NotNull] KHKOOJLDACG ALPJMJFLNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string HAJMMKEECKI(global::AOKCPNNMNJG<TKey> GGLDKMHDNCA, [NotNull] KHKOOJLDACG ALPJMJFLNMM);

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x2594E20", Offset = "0x2594220", VA = "0x182594E20")]
	protected AHGHOLJBPEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class KMBKIIPODPF<TKey> : global::HDGLHOIEEBG<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public delegate string CFJKKNGLMPO(TKey EBOIOCBODNI);

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private const int EFOBJKDIAKK = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly string GJIIFDFIMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly double FKIHNLKBPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly bool PFKFNKFJPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly int AHBDHJHHGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly ISet<string> JOCDABCOIJF;

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x3693830", Offset = "0x3692C30", VA = "0x183693830")]
	private static string GFOMLEKPIBK(TKey EBOIOCBODNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x3694270", Offset = "0x3693670", VA = "0x183694270")]
	public KMBKIIPODPF(string GJIIFDFIMGF = "F2", double FKIHNLKBPCG = double.MaxValue, bool PFKFNKFJPBK = false, int AHBDHJHHGPF = int.MaxValue, [Optional] ISet<string> JOCDABCOIJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x3694010", Offset = "0x3693410", VA = "0x183694010", Slot = "4")]
	public override Dictionary<string, string> OKCHPNFGGFF(global::AOKCPNNMNJG<TKey> GGLDKMHDNCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x3693870", Offset = "0x3692C70", VA = "0x183693870")]
	private bool JNBDBACHDKA(string KFCDEDEPPEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x3693AD0", Offset = "0x3692ED0", VA = "0x183693AD0")]
	public Dictionary<string, string> OKCHPNFGGFF(global::AOKCPNNMNJG<TKey> GGLDKMHDNCA, CFJKKNGLMPO ALPJMJFLNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x36940C0", Offset = "0x36934C0", VA = "0x1836940C0")]
	private string PCAFGGEAGBB(StringBuilder JABLIKHPKOG, List<TKey> IOGLGGHMEOG, CFJKKNGLMPO ALPJMJFLNMM, bool BBANPHLKJEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x3693950", Offset = "0x3692D50", VA = "0x183693950")]
	private static void NMDPHEBDOHK(StringBuilder CLGIMLELGDH, string DLPPCFPAFBE, bool KEMCDADBIKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class MJPPDBOFGAB<TKey> : global::AHGHOLJBPEN<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct KDKGHJDIKHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public KHKOOJLDACG keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static global::MJPPDBOFGAB<TKey> FDNKALDKIIB;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private const int KBOKGDKAJAE = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly string[] NILJODCHNBF;

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x36F7770", Offset = "0x36F6B70", VA = "0x1836F7770")]
	private MJPPDBOFGAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x36F6690", Offset = "0x36F5A90", VA = "0x1836F6690", Slot = "5")]
	protected override string HAJMMKEECKI(global::AOKCPNNMNJG<TKey> GGLDKMHDNCA, KHKOOJLDACG ALPJMJFLNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x36F7580", Offset = "0x36F6980", VA = "0x1836F7580")]
	[CompilerGenerated]
	internal static string PNPOCGFMCIP(string AIPELKIJKOH, TKey EBOIOCBODNI, ref KDKGHJDIKHG P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class PIBKDNEJLMN<TKey> : global::AHGHOLJBPEN<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class GIKAHMJFIFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public KHKOOJLDACG keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x14CA560", Offset = "0x14C9960", VA = "0x1814CA560")]
		public GIKAHMJFIFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x166EC40", Offset = "0x166E040", VA = "0x18166EC40")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x2DC0AA0", Offset = "0x2DBFEA0", VA = "0x182DC0AA0", Slot = "5")]
	protected override string HAJMMKEECKI(global::AOKCPNNMNJG<TKey> GGLDKMHDNCA, KHKOOJLDACG ALPJMJFLNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x29C1590", Offset = "0x29C0990", VA = "0x1829C1590")]
	public PIBKDNEJLMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public sealed class IBLGNEAJGLI : global::AOKCPNNMNJG<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class EICJHCBNGDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public Action<IBLGNEAJGLI> callback;

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public EICJHCBNGDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x65E0D50", Offset = "0x65E0150", VA = "0x1865E0D50")]
		internal void <Wrap>b__0(global::AOKCPNNMNJG<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x65E2070", Offset = "0x65E1470", VA = "0x1865E2070")]
	public IBLGNEAJGLI([Optional] string POIJPENPFCG, [Optional] int? OODPELJGEFJ, [Optional] Stopwatch PKADFIOHLGK, [Optional] Action<string, IGHABDLGAKI> NOFOBODAHNP, [Optional] Action<string, IGHABDLGAKI> JOGOMHAPJHK, [Optional] Action<IBLGNEAJGLI> DCJCHJDICAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x65E1F90", Offset = "0x65E1390", VA = "0x1865E1F90")]
	private static Action<global::AOKCPNNMNJG<string>> MHJKIIEGCDH(Action<IBLGNEAJGLI> PEPHBHFBJFE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class DBDNLIGDGMG
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private class GGKMJJKJGDJ : DBDNLIGDGMG
	{
		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public static DBDNLIGDGMG FDNKALDKIIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x65E11C0", Offset = "0x65E05C0", VA = "0x1865E11C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public override DateTime GBDLIBNLECF
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x65E1220", Offset = "0x65E0620", VA = "0x1865E1220", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public override float AIHJKLDBDGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x65E11B0", Offset = "0x65E05B0", VA = "0x1865E11B0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x65E1310", Offset = "0x65E0710", VA = "0x1865E1310")]
		public GGKMJJKJGDJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static DBDNLIGDGMG JGLCIFAJHCB;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static DBDNLIGDGMG LMPNKNOCBFL
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x65DFDA0", Offset = "0x65DF1A0", VA = "0x1865DFDA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public abstract DateTime GBDLIBNLECF
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public abstract float AIHJKLDBDGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	protected DBDNLIGDGMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class JDMOBCIHMDG : global::MDHIPEMKMAC<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x65E2350", Offset = "0x65E1750", VA = "0x1865E2350")]
	public JDMOBCIHMDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class MDHIPEMKMAC<T> : global::NJBAAHLOPDA<T>, FAHDDFNNICN, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Task<T> MFDHKKLKDJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x6E1AC0", Offset = "0x6E0EC0", VA = "0x1806E1AC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private Task OIMBOPHOMBK
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x14CA010", Offset = "0x14C9410", VA = "0x1814CA010", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public global::MLDKKGKEACN<T> AGFDPAJBNPH
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	private LLEFGLIPMKI ECPNNNBDLMG
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x1B93CD0", Offset = "0x1B930D0", VA = "0x181B93CD0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x30B27A0", Offset = "0x30B1BA0", VA = "0x1830B27A0")]
	public MDHIPEMKMAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class GHDPPIGGHMN : global::HDABKLNFFOE<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x65E1370", Offset = "0x65E0770", VA = "0x1865E1370")]
	public GHDPPIGGHMN(Exception CJDLKEIECEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class HDABKLNFFOE<T> : global::NJBAAHLOPDA<T>, FAHDDFNNICN, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public Task<T> MFDHKKLKDJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x6E1AC0", Offset = "0x6E0EC0", VA = "0x1806E1AC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	private Task OIMBOPHOMBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x14CA010", Offset = "0x14C9410", VA = "0x1814CA010", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public global::MLDKKGKEACN<T> AGFDPAJBNPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	private LLEFGLIPMKI ECPNNNBDLMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x1B93CD0", Offset = "0x1B930D0", VA = "0x181B93CD0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x2752E60", Offset = "0x2752260", VA = "0x182752E60")]
	public HDABKLNFFOE(Exception CJDLKEIECEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface FAHDDFNNICN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000069")]
	[NotNull]
	Task MFDHKKLKDJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	[NotNull]
	LLEFGLIPMKI AGFDPAJBNPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public interface NJBAAHLOPDA<T> : FAHDDFNNICN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	[NotNull]
	new Task<T> MFDHKKLKDJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	[NotNull]
	new global::MLDKKGKEACN<T> AGFDPAJBNPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public abstract class CILMDMPGCKL<TTask, T> : global::NJBAAHLOPDA<T>, FAHDDFNNICN, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private sealed class GDFGJCDJGBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public global::CILMDMPGCKL<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x14CA560", Offset = "0x14C9960", VA = "0x1814CA560")]
		public GDFGJCDJGBB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static bool HDNPMIHACGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly Task<T> JLDAGNIHKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	protected readonly CancellationTokenSource NIMBFKEGFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private bool LJINJAFAKDG;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Task<T> MFDHKKLKDJC
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6E1AC0", Offset = "0x6E0EC0", VA = "0x1806E1AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	private Task OIMBOPHOMBK
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6E1AC0", Offset = "0x6E0EC0", VA = "0x1806E1AC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public global::MLDKKGKEACN<T> AGFDPAJBNPH
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	private LLEFGLIPMKI ECPNNNBDLMG
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x1BA1CE0", Offset = "0x1BA10E0", VA = "0x181BA1CE0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool KCIOFPNPCCB
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x7D0FA0", Offset = "0x7D03A0", VA = "0x1807D0FA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x240BDC0", Offset = "0x240B1C0", VA = "0x18240BDC0")]
	static CILMDMPGCKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x240C0A0", Offset = "0x240B4A0", VA = "0x18240C0A0")]
	protected CILMDMPGCKL(TTask JLDAGNIHKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x240B9B0", Offset = "0x240ADB0", VA = "0x18240B9B0", Slot = "1")]
	~CILMDMPGCKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x240B980", Offset = "0x240AD80", VA = "0x18240B980", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x240BBF0", Offset = "0x240AFF0", VA = "0x18240BBF0")]
	private void KKNPGIAABIF(bool PKMPOBPHCDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T CMGGCJBKEMK(TTask FCFLOLIPPMP);

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void PHJKCCHBMMM();
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface LEAENOLLLJI
{
	[Cpp2IlInjected.Token(Token = "0x17000072")]
	float PGLFPHBJPOA
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event KJDIACAJEOB NIBGBJMDFCH;
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class MNJNLMDKIDK : LEAENOLLLJI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public readonly struct NHIDECJNNEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public readonly float FENBOPOOPIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public readonly float FDBCEIOJCMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		internal readonly bool EMBOEJCGPBA;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public float MDNIDCCLGIH
		{
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x65E5D60", Offset = "0x65E5160", VA = "0x1865E5D60")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x65E5EF0", Offset = "0x65E52F0", VA = "0x1865E5EF0")]
		public NHIDECJNNEA(float GODLNPABGMH, float EICPOANFBCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x65E5D70", Offset = "0x65E5170", VA = "0x1865E5D70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class KAGDANIMGHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public MNJNLMDKIDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public KAGDANIMGHM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly int KNECCHHDDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int IOONDCGLPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly LEAENOLLLJI[] NNHCEFHMIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly KJDIACAJEOB[] JPJNJBPAHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly NHIDECJNNEA[] AGILHINCFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private NHIDECJNNEA BOPLFFAJCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly EMLBNLDNLCP LDPGNOJBMHE;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public NHIDECJNNEA NCEALAJDLHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x16937D0", Offset = "0x1692BD0", VA = "0x1816937D0")]
		get
		{
			return default(NHIDECJNNEA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float PGLFPHBJPOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x65E4330", Offset = "0x65E3730", VA = "0x1865E4330", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event KJDIACAJEOB NIBGBJMDFCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x65E45F0", Offset = "0x65E39F0", VA = "0x1865E45F0", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x65E4530", Offset = "0x65E3930", VA = "0x1865E4530", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x65E4BE0", Offset = "0x65E3FE0", VA = "0x1865E4BE0")]
	public MNJNLMDKIDK(int KNECCHHDDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x65E46B0", Offset = "0x65E3AB0", VA = "0x1865E46B0")]
	public EMLBNLDNLCP KLKKPAABPDA(NHIDECJNNEA ECLIJHMKGIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x65E4790", Offset = "0x65E3B90", VA = "0x1865E4790")]
	public void LJKDJPEBNFB(LEAENOLLLJI OPJCHKIFEMC, [Optional] NHIDECJNNEA DMCKNHJGLPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x65E4740", Offset = "0x65E3B40", VA = "0x1865E4740")]
	internal int LGFPODHHMBH(LEAENOLLLJI PKPPBEPNNDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x65E44E0", Offset = "0x65E38E0", VA = "0x1865E44E0")]
	internal NHIDECJNNEA ECGLAGFDBNO(int EGBCAPEEJBF)
	{
		return default(NHIDECJNNEA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x65E4350", Offset = "0x65E3750", VA = "0x1865E4350", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public delegate void KJDIACAJEOB(float FNGPKJAFAIE);
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal static class NHHICBFCLMD
{
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	internal const float DJBAIANFENH = 0.0001f;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public static class DHOGGGINPHE
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private class ABAAHGCFHCP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly LEAENOLLLJI PKPPBEPNNDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private readonly KJDIACAJEOB PEPHBHFBJFE;

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x65DF500", Offset = "0x65DE900", VA = "0x1865DF500")]
		public ABAAHGCFHCP(LEAENOLLLJI PKPPBEPNNDD, KJDIACAJEOB PEPHBHFBJFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x65DF4B0", Offset = "0x65DE8B0", VA = "0x1865DF4B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x65DFFF0", Offset = "0x65DF3F0", VA = "0x1865DFFF0")]
	internal static bool KNOANPICOKP(float BECDKHGLGNB, float ICPOAGANOLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x49CBD30", Offset = "0x49CB130", VA = "0x1849CBD30")]
	internal static float MLLOHGPPOBH(float BECDKHGLGNB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x65DFF30", Offset = "0x65DF330", VA = "0x1865DFF30")]
	public static IDisposable FPCCOCDEMHF(this LEAENOLLLJI PKPPBEPNNDD, KJDIACAJEOB PEPHBHFBJFE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class EMLBNLDNLCP : LEAENOLLLJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private float FNGPKJAFAIE;

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float PGLFPHBJPOA
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x12C8520", Offset = "0x12C7920", VA = "0x1812C8520", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x65E0E80", Offset = "0x65E0280", VA = "0x1865E0E80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event KJDIACAJEOB NIBGBJMDFCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x65E0F40", Offset = "0x65E0340", VA = "0x1865E0F40", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x65E0DE0", Offset = "0x65E01E0", VA = "0x1865E0DE0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public EMLBNLDNLCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class PNJPFANKIGN
{
	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x65E6840", Offset = "0x65E5C40", VA = "0x1865E6840")]
	[NotNull]
	public static byte[] LLNJFMMLHLP(this CGDAMBLFNAM KBDMABOHOOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x65E67D0", Offset = "0x65E5BD0", VA = "0x1865E67D0")]
	[NotNull]
	public static byte[] LLNJFMMLHLP(this CGDAMBLFNAM KBDMABOHOOC, HashAlgorithmName CAPDDDMGJCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x65E64A0", Offset = "0x65E58A0", VA = "0x1865E64A0")]
	public static bool DJNEPIDCIME([CanBeNull] this CGDAMBLFNAM KBDMABOHOOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x65E6630", Offset = "0x65E5A30", VA = "0x1865E6630")]
	public static bool DJNEPIDCIME([CanBeNull] this CGDAMBLFNAM KBDMABOHOOC, out string CNMFEBEOFOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x65E6430", Offset = "0x65E5830", VA = "0x1865E6430")]
	private static string CEKGLNDACLC([CanBeNull] byte[] FHNEBAPANCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x65E6310", Offset = "0x65E5710", VA = "0x1865E6310")]
	private static bool BBOBJPGNAAG([NotNull] CGDAMBLFNAM KBDMABOHOOC, [CanBeNull] out byte[] ELDNFMCGGKK, [CanBeNull] out byte[] KNDBMBBODLK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public static class BDLFFABFBAO
{
	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x65DF990", Offset = "0x65DED90", VA = "0x1865DF990")]
	[NotNull]
	public static byte[] LLNJFMMLHLP(this AHOCFCHKDAO POJEKDOFHBO, byte[] FEFOCPODKJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x65DF9D0", Offset = "0x65DEDD0", VA = "0x1865DF9D0")]
	[NotNull]
	public static byte[] LLNJFMMLHLP(this AHOCFCHKDAO POJEKDOFHBO, HashAlgorithmName CAPDDDMGJCI, byte[] FEFOCPODKJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface AHOCFCHKDAO
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash ADPFJJODLPO);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface CGDAMBLFNAM : AHOCFCHKDAO
{
	[Cpp2IlInjected.Token(Token = "0x17000077")]
	[CanBeNull]
	byte[] JKBKHOGJCBH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	[CanBeNull]
	byte[] IEPGDMLDLCG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	UnityEngine.Object BEEEOOCOOKA
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public static class MBFFNMHHNDI
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private class NBNJDPINMPF : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x65E5CE0", Offset = "0x65E50E0", VA = "0x1865E5CE0")]
		public NBNJDPINMPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x65E5C80", Offset = "0x65E5080", VA = "0x1865E5C80", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private const byte CIMINEIGMCP = 1;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private const byte FBLKOECIINL = 0;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private static readonly ArrayPool<byte> EKDPIDAPBFK;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static bool BBLCBHGCOGK;

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x29E7B30", Offset = "0x29E6F30", VA = "0x1829E7B30")]
	[Conditional("UNITY_EDITOR")]
	private static void CPICBKMLIGP<T>(params T[] KEAADPCECLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x65E3D40", Offset = "0x65E3140", VA = "0x1865E3D40")]
	public static IDisposable MINJHMJKJCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x65E30B0", Offset = "0x65E24B0", VA = "0x1865E30B0")]
	public static void ENINAIMIPFK(this IncrementalHash HMABPPNDNGC, [CanBeNull] GameObject BLPBCMIHDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x29E7E20", Offset = "0x29E7220", VA = "0x1829E7E20")]
	public static void ENINAIMIPFK<T>(this IncrementalHash HMABPPNDNGC, [CanBeNull] T NANIPOPDLDJ) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x29E7EF0", Offset = "0x29E72F0", VA = "0x1829E7EF0")]
	public static void KGGCHJLAMBC<T>(this IncrementalHash HMABPPNDNGC, [CanBeNull] T POJEKDOFHBO) where T : AHOCFCHKDAO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x29E8670", Offset = "0x29E7A70", VA = "0x1829E8670")]
	public static void OMMBPEAOKHO<T>(this IncrementalHash HMABPPNDNGC, [CanBeNull] IList<T> IJMNPFBOFPM) where T : AHOCFCHKDAO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x65E3FB0", Offset = "0x65E33B0", VA = "0x1865E3FB0")]
	private static bool OHBCFIFJENL([CanBeNull] AHOCFCHKDAO POJEKDOFHBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x65E2FE0", Offset = "0x65E23E0", VA = "0x1865E2FE0")]
	public static void BLKKNPJJNCA(this IncrementalHash ADPFJJODLPO, [CanBeNull] string DONKGNOMNOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x65E3DE0", Offset = "0x65E31E0", VA = "0x1865E3DE0")]
	public static void NOFALNKKJJB(this IncrementalHash ADPFJJODLPO, long DGNBBNCNHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x65E35B0", Offset = "0x65E29B0", VA = "0x1865E35B0")]
	public static void IAADDELHEBL(this IncrementalHash ADPFJJODLPO, int IKPJHGONMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x65E3780", Offset = "0x65E2B80", VA = "0x1865E3780")]
	public static void JBBJBIOFOFE(this IncrementalHash ADPFJJODLPO, short IHNALLDMCEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x65E3BD0", Offset = "0x65E2FD0", VA = "0x1865E3BD0")]
	public static void MBKHPANBBOM(this IncrementalHash ADPFJJODLPO, byte KMOHBKCMBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x65E3200", Offset = "0x65E2600", VA = "0x1865E3200")]
	public static void GKBGGKFLKOD(this IncrementalHash ADPFJJODLPO, bool MKDGJIEBIDF, bool NNNECADJFKJ = false, bool AGDMFBNKAND = false, bool AKHMHHPDILN = false, bool MDMKICLGFJE = false, bool LAILOMDDOFH = false, bool LKBMFMNDLFD = false, bool HHHJMHJGJAC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x29E7F80", Offset = "0x29E7380", VA = "0x1829E7F80")]
	public static void LMKNJJKGHMK<T>(this IncrementalHash ADPFJJODLPO, T GDHAKIDLDCD) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x65E3B70", Offset = "0x65E2F70", VA = "0x1865E3B70")]
	public static void LJDCDLKPGFH(this IncrementalHash ADPFJJODLPO, float FODDEKBLBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x65E31A0", Offset = "0x65E25A0", VA = "0x1865E31A0")]
	public static void GGCIPMGFLLL(this IncrementalHash ADPFJJODLPO, double IHGCLLAPGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x65E3040", Offset = "0x65E2440", VA = "0x1865E3040")]
	public static void CJBNPILDHAG(this IncrementalHash ADPFJJODLPO, ulong ALOFFJJMPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x65E3950", Offset = "0x65E2D50", VA = "0x1865E3950")]
	public static void JDLDIADPNKL(this IncrementalHash ADPFJJODLPO, uint GGNDMALDLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x65E33D0", Offset = "0x65E27D0", VA = "0x1865E33D0")]
	public static void HCBOHHFLCDN(this IncrementalHash ADPFJJODLPO, ushort OMHPHBAEPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x65E3440", Offset = "0x65E2840", VA = "0x1865E3440")]
	public static void HKILJCHLEMG(this IncrementalHash ADPFJJODLPO, Vector3 GMEBBEGEPED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x65E39B0", Offset = "0x65E2DB0", VA = "0x1865E39B0")]
	public static void JEHHNGNICHI(this IncrementalHash ADPFJJODLPO, Quaternion LDLLMNMFAIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class NLOCMFDOIKO : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public readonly Type DPOLLFJHGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public readonly string EFIFIOFOCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly bool ELNIHDIALNG;

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x65E6030", Offset = "0x65E5430", VA = "0x1865E6030")]
	public NLOCMFDOIKO(Type NMHGDNOBLPL, string BEJMEINOPAL, bool OMGAKLBNBAH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class HLPIPILFNCH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x65E1DD0", Offset = "0x65E11D0", VA = "0x1865E1DD0")]
	public HLPIPILFNCH(string GOMILMNIGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x65E1E40", Offset = "0x65E1240", VA = "0x1865E1E40")]
	public HLPIPILFNCH(string GOMILMNIGIC, Exception OBABKGKEJFI)
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
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x6E0040", Offset = "0x6DF440", VA = "0x1806E0040")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x6F6790", Offset = "0x6F5B90", VA = "0x1806F6790")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public T this[int BDAADCOCKII, int CENFIFAIEEN]
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x3822C30", Offset = "0x3822030", VA = "0x183822C30")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x3822CD0", Offset = "0x38220D0", VA = "0x183822CD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x3822BA0", Offset = "0x3821FA0", VA = "0x183822BA0")]
		public Array2D(uint FGOOGGEJGJK, uint NJKNCDKEMEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x3822B20", Offset = "0x3821F20", VA = "0x183822B20")]
		public void FPEOCMBDEPF()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x65DF930", Offset = "0x65DED30", VA = "0x1865DF930")]
		public Array2DVector3(uint FGOOGGEJGJK, uint NJKNCDKEMEE)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
internal static class FOJBHBODBDL
{
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public const int BIMKNFNBOBE = -1;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public const int PMMOHJIJPLI = 0;
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[DefaultMember("Item")]
public class FEPGPOIDFMK<THandle, TValue> : IDisposable where THandle : struct, LGHBPHHHPFG where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private readonly List<THandle> IJELHBLKOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private readonly List<TValue> GBCINMGHOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly Func<TValue> AHDNAKEDDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly Action<TValue> PEGDMCPLCCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private int IABNFHPOOJO;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public TValue IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x27458B0", Offset = "0x2744CB0", VA = "0x1827458B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x2AA8660", Offset = "0x2AA7A60", VA = "0x182AA8660")]
	public FEPGPOIDFMK(Action<TValue> PEGDMCPLCCK, [Optional] Func<TValue> AHDNAKEDDPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x2AA7EA0", Offset = "0x2AA72A0", VA = "0x182AA7EA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x2AA7C60", Offset = "0x2AA7060", VA = "0x182AA7C60")]
	public THandle BMDGCEOIEEG()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x2AA7FE0", Offset = "0x2AA73E0", VA = "0x182AA7FE0")]
	public THandle GBJBCHALJOG(TValue KPPLMEOMNGF)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x2AA85B0", Offset = "0x2AA79B0", VA = "0x182AA85B0")]
	public bool PMMODKPOELK(THandle BDCLOJHOMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x2AA7AE0", Offset = "0x2AA6EE0", VA = "0x182AA7AE0")]
	public bool BAFMLPIANAD(THandle BDCLOJHOMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x2AA8240", Offset = "0x2AA7640", VA = "0x182AA8240")]
	public bool LEDONIKBHEA(THandle BDCLOJHOMDK, out TValue KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x2AA7E40", Offset = "0x2AA7240", VA = "0x182AA7E40")]
	public TValue BOEAFIEBIHC(THandle BDCLOJHOMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x2AA7BB0", Offset = "0x2AA6FB0", VA = "0x182AA7BB0")]
	public bool BKIFKBMENNF(THandle BDCLOJHOMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x2AA83B0", Offset = "0x2AA77B0", VA = "0x182AA83B0")]
	private THandle MDPPCNBODBO(int EGBCAPEEJBF)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x2AA8210", Offset = "0x2AA7610", VA = "0x182AA8210")]
	private TValue IPFANDCPJOE(int EGBCAPEEJBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x2AA81D0", Offset = "0x2AA75D0", VA = "0x182AA81D0")]
	private void IIHMNOCDCKA(int EGBCAPEEJBF, in THandle BDCLOJHOMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x2AA8460", Offset = "0x2AA7860", VA = "0x182AA8460")]
	private void NJAFIFNAEFP(int EGBCAPEEJBF, in TValue KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x2AA84A0", Offset = "0x2AA78A0", VA = "0x182AA84A0")]
	private THandle PLAGHNBFHJL()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x2AA7F30", Offset = "0x2AA7330", VA = "0x182AA7F30")]
	private void FPGHKCICDPL(THandle BDCLOJHOMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x2AA7E90", Offset = "0x2AA7290", VA = "0x182AA7E90")]
	private int DNFONJFBMEL(int LFMBJAIIPEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x2AA7F20", Offset = "0x2AA7320", VA = "0x182AA7F20")]
	private bool FFKCKABMHBH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x747580", Offset = "0x746980", VA = "0x180747580")]
	private void HAAAGGEBPOD(THandle BDCLOJHOMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x2AA83E0", Offset = "0x2AA77E0", VA = "0x182AA83E0")]
	private bool NCDOCPDILDG(out THandle BDCLOJHOMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x2AA82E0", Offset = "0x2AA76E0", VA = "0x182AA82E0")]
	private bool LLMFKEPAHFL(out THandle BDCLOJHOMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x2AA8170", Offset = "0x2AA7570", VA = "0x182AA8170")]
	private void ICLFPKAPMKA(THandle BDCLOJHOMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x2AA8050", Offset = "0x2AA7450", VA = "0x182AA8050")]
	private void IAACJGPNEEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public interface LGHBPHHHPFG
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	int NOAKOLDJPCH
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	int CONDCHODOCK
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public interface AOOPJGHLJBJ<T> : LGHBPHHHPFG, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class GNIBKDBAKJE
{
	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0xCFEA50", Offset = "0xCFDE50", VA = "0x180CFEA50")]
	public static bool DEONMCNMECP<T>(this T BDCLOJHOMDK, T JHMCLPBFJBC) where T : struct, LGHBPHHHPFG
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x2398090", Offset = "0x2397490", VA = "0x182398090")]
	public static bool EMBOEJCGPBA<T>(this T BDCLOJHOMDK) where T : struct, LGHBPHHHPFG
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x65E13C0", Offset = "0x65E07C0", VA = "0x1865E13C0")]
	public static string CNFBIAHAAKC(this LGHBPHHHPFG BDCLOJHOMDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class MPIEPKOGJFC
{
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	private enum LEFHAKLEHDP : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private int ADPFJJODLPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private bool OKMPCICKNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private LEFHAKLEHDP KFCHBPFAEMJ;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public bool CKOAHOIJBAL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x65E4F40", Offset = "0x65E4340", VA = "0x1865E4F40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool MIDIEDJGAJA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x65E5030", Offset = "0x65E4430", VA = "0x1865E5030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x65E5C50", Offset = "0x65E5050", VA = "0x1865E5C50")]
	public MPIEPKOGJFC(bool OKMPCICKNLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x65E51F0", Offset = "0x65E45F0", VA = "0x1865E51F0")]
	public void NICIPLEGDLC(object AELIHOPICED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x65E4F70", Offset = "0x65E4370", VA = "0x1865E4F70")]
	public void IMONFMHOMCP(int KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x65E4F50", Offset = "0x65E4350", VA = "0x1865E4F50")]
	public void DIHKLMEFADL(uint EHDHAGPCPPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x65E5010", Offset = "0x65E4410", VA = "0x1865E5010")]
	public void JPJGHGMJOGM(bool CPFGLOGJBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x65E50B0", Offset = "0x65E44B0", VA = "0x1865E50B0")]
	public void LJOOBGDKIFB(long FKKIIOKEOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x65E4F00", Offset = "0x65E4300", VA = "0x1865E4F00")]
	public void DBGHBAFIHEJ(ulong CAKADBMMBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x65E5040", Offset = "0x65E4440", VA = "0x1865E5040")]
	public void KDIILHHDOHP(string OLOKIOKEPFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x65E5160", Offset = "0x65E4560", VA = "0x1865E5160")]
	public void NDMIIEMIONL(Enum CJDLKEIECEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x65E4D60", Offset = "0x65E4160", VA = "0x1865E4D60")]
	public void BGABMHAGIIA(IList EHJGMBFBLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x24B1DD0", Offset = "0x24B11D0", VA = "0x1824B1DD0")]
	public void KOEBPBKOACE<T, U>(Dictionary<T, U> INAFJIMICJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x65E5870", Offset = "0x65E4C70", VA = "0x1865E5870")]
	private void OEJHFIAJHEF(IDictionary INAFJIMICJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x65E4E90", Offset = "0x65E4290", VA = "0x1865E4E90")]
	public int CHAAOJHKDBM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x65E50F0", Offset = "0x65E44F0", VA = "0x1865E50F0")]
	public short LMJNOICPHKP()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x65E4F60", Offset = "0x65E4360", VA = "0x1865E4F60")]
	public void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x65E5BE0", Offset = "0x65E4FE0", VA = "0x1865E5BE0")]
	private void PKPFJEOGHBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public abstract class ODHPIMDKJCC<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	internal class EGFFNCDLIJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public TNode AOFCPKBHFEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public TNode OKMBLMILFGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public PGHOKKPMFJN PMIFMNEAFNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public List<PGHOKKPMFJN> PNEOGCCNFPF;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x14CA560", Offset = "0x14C9960", VA = "0x1814CA560")]
		public EGFFNCDLIJJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	internal struct PGHOKKPMFJN : IComparable<PGHOKKPMFJN>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public int APLFJBIBJAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public TClaimant MPBLGGELNEO;

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x70B0B0", Offset = "0x70A4B0", VA = "0x18070B0B0")]
		public PGHOKKPMFJN(int APLFJBIBJAH, TClaimant MPBLGGELNEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x2DB8920", Offset = "0x2DB7D20", VA = "0x182DB8920")]
		public bool IMDKHKNCIKP(in PGHOKKPMFJN JHMCLPBFJBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x2DB8980", Offset = "0x2DB7D80", VA = "0x182DB8980")]
		public bool PNJPGKOBLEP(in PGHOKKPMFJN JHMCLPBFJBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x2DB8910", Offset = "0x2DB7D10", VA = "0x182DB8910", Slot = "4")]
		public int CompareTo(PGHOKKPMFJN JHMCLPBFJBC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x2DB8990", Offset = "0x2DB7D90", VA = "0x182DB8990", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public enum LIEHBAAFEFH
	{
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class FFECDIMBBOO : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public global::ODHPIMDKJCC<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x1667550", Offset = "0x1666950", VA = "0x181667550")]
		[DebuggerHidden]
		public FFECDIMBBOO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8950", Offset = "0x2AA7D50", VA = "0x182AA8950", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8B10", Offset = "0x2AA7F10", VA = "0x182AA8B10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8A30", Offset = "0x2AA7E30", VA = "0x182AA8A30", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x1652950", Offset = "0x1651D50", VA = "0x181652950", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static readonly global::FOHDNCAIEND<EGFFNCDLIJJ> OGFJJGOLJHK;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly global::FOHDNCAIEND<List<PGHOKKPMFJN>> KPNEEFIKJHJ;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static int GJLHBIEJIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	internal readonly Dictionary<TClaimant, TNode> COKEIGCAICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	internal readonly Dictionary<TNode, EGFFNCDLIJJ> NNNGPBOEBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private LIEHBAAFEFH COAEGBJAHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private bool FLFCLOAFFCN;

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode FCHNDLGHOIE(TNode BBGMDMKKHON);

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void EADMEFIPDAO(TNode BBGMDMKKHON, TClaimant KFHMLIAKJLD, TClaimant BDOKAIPMFAA);

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x2BC51B0", Offset = "0x2BC45B0", VA = "0x182BC51B0")]
	public ODHPIMDKJCC(LIEHBAAFEFH COAEGBJAHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x2BC4440", Offset = "0x2BC3840", VA = "0x182BC4440")]
	public void ELGLHJAHLJP(TNode BBGMDMKKHON, TNode KHLHKJKADHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x2BC46B0", Offset = "0x2BC3AB0", VA = "0x182BC46B0")]
	public void HHGEKMHADHF(TClaimant MPBLGGELNEO, TNode ELCABFLLMBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x2BC4140", Offset = "0x2BC3540", VA = "0x182BC4140", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x2BC43A0", Offset = "0x2BC37A0", VA = "0x182BC43A0")]
	private void ECIHOJOEEOJ(TClaimant MPBLGGELNEO, TNode MEOKMLPNAKO, TNode ELCABFLLMBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x2BC4650", Offset = "0x2BC3A50", VA = "0x182BC4650")]
	private int GJCJLIKPGCN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x2BC47B0", Offset = "0x2BC3BB0", VA = "0x182BC47B0")]
	private void IFEDAILNNJA(TClaimant MPBLGGELNEO, TNode NBOIFHKMHEN, TNode ADAJCIOPLGN, int CDGDOKEGIJM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x2BC45C0", Offset = "0x2BC39C0", VA = "0x182BC45C0")]
	private void FHKLLLOOHDM(PGHOKKPMFJN LNAAFNLKKMC, EGFFNCDLIJJ GPBNHLBGMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x2BC3EE0", Offset = "0x2BC32E0", VA = "0x182BC3EE0")]
	private void DLCJPFHODDL(TClaimant MPBLGGELNEO, TNode NBOIFHKMHEN, TNode ADAJCIOPLGN, int CDGDOKEGIJM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x2BC3A60", Offset = "0x2BC2E60", VA = "0x182BC3A60")]
	private void AEMAOMOBLBN(PGHOKKPMFJN LNAAFNLKKMC, TNode BBGMDMKKHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x2BC44C0", Offset = "0x2BC38C0", VA = "0x182BC44C0")]
	private void FBMBCACAHLO(PGHOKKPMFJN LNAAFNLKKMC, EGFFNCDLIJJ GPBNHLBGMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x2BC3C40", Offset = "0x2BC3040", VA = "0x182BC3C40")]
	private void BJCAHJHNAML(EGFFNCDLIJJ GPBNHLBGMJP, bool DICIAPPFKEN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x2BC4CE0", Offset = "0x2BC40E0", VA = "0x182BC4CE0")]
	private void NNIPCDCHEHM(EGFFNCDLIJJ GPBNHLBGMJP, TNode KHLHKJKADHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x2BC3B70", Offset = "0x2BC2F70", VA = "0x182BC3B70")]
	[IteratorStateMachine(typeof(global::ODHPIMDKJCC<, >.FFECDIMBBOO))]
	private IEnumerable<TNode> AOILNLIAALB(TNode NBOIFHKMHEN, TNode ADAJCIOPLGN, bool FEEAHAJHAEP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x2BC4C20", Offset = "0x2BC4020", VA = "0x182BC4C20")]
	private EGFFNCDLIJJ MDBBKOFDNDH(TNode BBGMDMKKHON, TNode OKMBLMILFGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x2BC3D50", Offset = "0x2BC3150", VA = "0x182BC3D50")]
	private EGFFNCDLIJJ CBGBAKIICAK(TNode BBGMDMKKHON, TNode OKMBLMILFGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x2BC4A60", Offset = "0x2BC3E60", VA = "0x182BC4A60")]
	private void JDCNKDMLPKJ(EGFFNCDLIJJ GPBNHLBGMJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public class LCOFNCIAACG<T> : IEnumerable<global::LCOFNCIAACG<T>.IPLKBGDEEHK>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public struct IPLKBGDEEHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public T KPPLMEOMNGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public int EGBCAPEEJBF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public class NHKAJLDCKGM : IEnumerator<IPLKBGDEEHK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private global::LCOFNCIAACG<T> MOBIBCNEEOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private int EGBCAPEEJBF;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x14C88E0", Offset = "0x14C7CE0", VA = "0x1814C88E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public IPLKBGDEEHK AGGOFNFHANI
		{
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x2779220", Offset = "0x2778620", VA = "0x182779220", Slot = "4")]
			get
			{
				return default(IPLKBGDEEHK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x6E4060", Offset = "0x6E3460", VA = "0x1806E4060")]
		public NHKAJLDCKGM(global::LCOFNCIAACG<T> MOBIBCNEEOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x27790E0", Offset = "0x27784E0", VA = "0x1827790E0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x6E4050", Offset = "0x6E3450", VA = "0x1806E4050", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xC1ADA0", Offset = "0xC1A1A0", VA = "0x180C1ADA0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private struct ILMBPCPADEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public bool NMMAFIDOFIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public T KPPLMEOMNGF;
	}

	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private const int IGDLJDCBNCB = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private readonly Dictionary<T, int> ILEAHEOFHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private ILMBPCPADEP[] NGDIOCIIFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private int NOCMMDKHALH;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int NICKCFFOLOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x700D90", Offset = "0x700190", VA = "0x180700D90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x878CE0", Offset = "0x8780E0", VA = "0x180878CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int IIEJMBAKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x1F8F3B0", Offset = "0x1F8E7B0", VA = "0x181F8F3B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x26B9990", Offset = "0x26B8D90", VA = "0x1826B9990")]
	public LCOFNCIAACG(int KNECCHHDDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x26B9A70", Offset = "0x26B8E70", VA = "0x1826B9A70")]
	public LCOFNCIAACG(IPLKBGDEEHK[] PMGFKBCECNF, bool KDADMDNMJNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x26B93B0", Offset = "0x26B87B0", VA = "0x1826B93B0")]
	public int JBDKFJNFEDP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x26B8BD0", Offset = "0x26B7FD0", VA = "0x1826B8BD0")]
	private int FAFIPPEGELG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x26B8520", Offset = "0x26B7920", VA = "0x1826B8520", Slot = "6")]
	protected virtual uint AIPAONOKHGO(uint ADPFJJODLPO, T KPPLMEOMNGF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x26B95F0", Offset = "0x26B89F0", VA = "0x1826B95F0")]
	public bool OIMGOGOIEME(T KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x26B9760", Offset = "0x26B8B60", VA = "0x1826B9760")]
	public bool PCFBFGCLBMG(int EGBCAPEEJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x26B89B0", Offset = "0x26B7DB0", VA = "0x1826B89B0")]
	public bool BNDEAHDJONI(Func<T, bool> COANEGMLMGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x26B9660", Offset = "0x26B8A60", VA = "0x1826B9660")]
	public int OJPGMPIMIDD(T KPPLMEOMNGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x26B92F0", Offset = "0x26B86F0", VA = "0x1826B92F0")]
	public T IPFANDCPJOE(int EGBCAPEEJBF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x26B8FC0", Offset = "0x26B83C0", VA = "0x1826B8FC0")]
	public void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x26B8540", Offset = "0x26B7940", VA = "0x1826B8540")]
	public bool APHPNPEMCLE(T KPPLMEOMNGF, bool FJDGIBDPCPN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x26B8780", Offset = "0x26B7B80", VA = "0x1826B8780")]
	public bool APHPNPEMCLE(T KPPLMEOMNGF, int EGBCAPEEJBF, bool FJDGIBDPCPN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x26B9800", Offset = "0x26B8C00", VA = "0x1826B9800")]
	public bool PMMODKPOELK(T KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x26B97B0", Offset = "0x26B8BB0", VA = "0x1826B97B0")]
	public bool PJBBGDBFNGB(int EGBCAPEEJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x26B9500", Offset = "0x26B8900", VA = "0x1826B9500")]
	private void OCIGNPPKEFD(int EGBCAPEEJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x26B9040", Offset = "0x26B8440", VA = "0x1826B9040")]
	public IPLKBGDEEHK[] IFPMJMGFJLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x26B8B80", Offset = "0x26B7F80", VA = "0x1826B8B80")]
	private int EHBDKFPGGHK(int GJPBLFPOONO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x26B9910", Offset = "0x26B8D10", VA = "0x1826B9910", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x26B9910", Offset = "0x26B8D10", VA = "0x1826B9910", Slot = "4")]
	private IEnumerator<IPLKBGDEEHK> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct CJFIDMOEABI<Handle> where Handle : LGHBPHHHPFG, new()
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	private struct AALLACOGIBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private readonly global::CJFIDMOEABI<Handle> DJOFPEAKDCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private int EGBCAPEEJBF;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public int ICIEAPGJPPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x35C2970", Offset = "0x35C1D70", VA = "0x1835C2970")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public Handle ENKGMGGEEPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x35C3530", Offset = "0x35C2930", VA = "0x1835C3530")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x35C3930", Offset = "0x35C2D30", VA = "0x1835C3930")]
		public AALLACOGIBO(global::CJFIDMOEABI<Handle> DJOFPEAKDCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x35C2C10", Offset = "0x35C2010", VA = "0x1835C2C10")]
		public GPGCMPJOKJB CCFMECMIHDM(in GPGCMPJOKJB BJBDNHBIPAI)
		{
			return default(GPGCMPJOKJB);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x35C2B70", Offset = "0x35C1F70", VA = "0x1835C2B70")]
		public KPHJNBBNHDH CCFMECMIHDM(in KPHJNBBNHDH BJBDNHBIPAI)
		{
			return default(KPHJNBBNHDH);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x35C3150", Offset = "0x35C2550", VA = "0x1835C3150")]
		public bool JPIMAEJBKHA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x35C2DA0", Offset = "0x35C21A0", VA = "0x1835C2DA0")]
		private int JGGMKJENKPH(string GOMILMNIGIC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x35C38E0", Offset = "0x35C2CE0", VA = "0x1835C38E0")]
		private Handle NHCCJDBNPBL(string GOMILMNIGIC)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public struct GPGCMPJOKJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private AALLACOGIBO BDCOLOBIPJG;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public int AGGOFNFHANI
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x2AD8C70", Offset = "0x2AD8070", VA = "0x182AD8C70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x2AD8E70", Offset = "0x2AD8270", VA = "0x182AD8E70")]
		public GPGCMPJOKJB(global::CJFIDMOEABI<Handle> DJOFPEAKDCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x2AD8DB0", Offset = "0x2AD81B0", VA = "0x182AD8DB0")]
		public bool JPIMAEJBKHA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x2AD8DF0", Offset = "0x2AD81F0", VA = "0x182AD8DF0")]
		public GPGCMPJOKJB KGLEFCHHJJI()
		{
			return default(GPGCMPJOKJB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public struct KPHJNBBNHDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private AALLACOGIBO BDCOLOBIPJG;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Handle AGGOFNFHANI
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x36A1CB0", Offset = "0x36A10B0", VA = "0x1836A1CB0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x2AD8E70", Offset = "0x2AD8270", VA = "0x182AD8E70")]
		public KPHJNBBNHDH(global::CJFIDMOEABI<Handle> DJOFPEAKDCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x2AD8DB0", Offset = "0x2AD81B0", VA = "0x182AD8DB0")]
		public bool JPIMAEJBKHA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x36A1DB0", Offset = "0x36A11B0", VA = "0x1836A1DB0")]
		public KPHJNBBNHDH KGLEFCHHJJI()
		{
			return default(KPHJNBBNHDH);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private NativeList<int> HBAJDCHAHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private NativeList<int> KIHCHOHOEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private int LMPBCPKJEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private int EIPOHIAHJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private bool KKBKJMIDOMF;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool FAFBILBNMMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x7D0FA0", Offset = "0x7D03A0", VA = "0x1807D0FA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int LFCNNPBFNIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x240DBF0", Offset = "0x240CFF0", VA = "0x18240DBF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int AFHHDPFENDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x6E0010", Offset = "0x6DF410", VA = "0x1806E0010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int KKBBPMHMDHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x6E0010", Offset = "0x6DF410", VA = "0x1806E0010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public GPGCMPJOKJB NNICFNNBCPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x240F2A0", Offset = "0x240E6A0", VA = "0x18240F2A0")]
		get
		{
			return default(GPGCMPJOKJB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public KPHJNBBNHDH DOMHFKCOAHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x240F200", Offset = "0x240E600", VA = "0x18240F200")]
		get
		{
			return default(KPHJNBBNHDH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x2411110", Offset = "0x2410510", VA = "0x182411110")]
	public CJFIDMOEABI(int OOBCJODNMBL, Allocator GOLNHBOGNGC = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x240F080", Offset = "0x240E480", VA = "0x18240F080")]
	public void KKNPGIAABIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x1101240", Offset = "0x1100640", VA = "0x181101240")]
	public static int DNFONJFBMEL(int APLGHPJFDAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x24110F0", Offset = "0x24104F0", VA = "0x1824110F0")]
	public static bool PEJFMBJOIFD(int APLGHPJFDAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x2411100", Offset = "0x2410500", VA = "0x182411100")]
	public static bool PPBPJAEDOAG(int APLGHPJFDAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x240CC50", Offset = "0x240C050", VA = "0x18240CC50")]
	public bool BGHMNLEHGOP(int EGBCAPEEJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x240E4A0", Offset = "0x240D8A0", VA = "0x18240E4A0")]
	public bool HOEBOGFEIJG(int EGBCAPEEJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x240DA20", Offset = "0x240CE20", VA = "0x18240DA20")]
	public bool DJIECBBOCPO(Handle BDCLOJHOMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x2410790", Offset = "0x240FB90", VA = "0x182410790")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void OLGAFDEPJJH(Handle BDCLOJHOMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x240F5B0", Offset = "0x240E9B0", VA = "0x18240F5B0")]
	public Handle MHLONCNLJOA()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x240FFB0", Offset = "0x240F3B0", VA = "0x18240FFB0")]
	public void MMHCMEAFAJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x24102B0", Offset = "0x240F6B0", VA = "0x1824102B0")]
	public void MOPMNPMBKGA(Handle BDCLOJHOMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x240E8B0", Offset = "0x240DCB0", VA = "0x18240E8B0")]
	public bool HPKJECLKMEJ(Handle BDCLOJHOMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x7D0FA0", Offset = "0x7D03A0", VA = "0x1807D0FA0")]
	private bool GLKLBLOKILF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x240EB20", Offset = "0x240DF20", VA = "0x18240EB20")]
	private bool JHPACPFDAJN(int EGBCAPEEJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x240DF10", Offset = "0x240D310", VA = "0x18240DF10")]
	private void GEBDJJPBIED(out int EGBCAPEEJBF, out int LFMBJAIIPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x240D230", Offset = "0x240C630", VA = "0x18240D230")]
	private void CDNLKKBNNEA(Handle BDCLOJHOMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x240D580", Offset = "0x240C980", VA = "0x18240D580")]
	private void DDAAGBEJKAI(int EGBCAPEEJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x240EC40", Offset = "0x240E040", VA = "0x18240EC40")]
	private bool KKNGALJKEEO(out int EGBCAPEEJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x240E2E0", Offset = "0x240D6E0", VA = "0x18240E2E0")]
	private static Handle HLLIBFIOBJD(int EGBCAPEEJBF, int LFMBJAIIPEH)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[DefaultMember("Item")]
public struct IEDFOPGJHFB<Handle, T> where Handle : LGHBPHHHPFG, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private global::CJFIDMOEABI<Handle> FLHOAAHODPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private T[] EOONDHPAEAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private Action<T> KCIOCOEEAPH;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool FAFBILBNMMN
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x1664CB0", Offset = "0x16640B0", VA = "0x181664CB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public int LFCNNPBFNIK
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x16634F0", Offset = "0x16628F0", VA = "0x1816634F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public int IIEJMBAKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x1664C80", Offset = "0x1664080", VA = "0x181664C80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public T IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x1663280", Offset = "0x1662680", VA = "0x181663280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x16664B0", Offset = "0x16658B0", VA = "0x1816664B0")]
	public IEDFOPGJHFB(int OOBCJODNMBL, [Optional] Action<T> KCIOCOEEAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x1664900", Offset = "0x1663D00", VA = "0x181664900")]
	public void KKNPGIAABIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x16633C0", Offset = "0x16627C0", VA = "0x1816633C0")]
	public bool DJIECBBOCPO(Handle BDCLOJHOMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void OLGAFDEPJJH(Handle BDCLOJHOMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x16631C0", Offset = "0x16625C0", VA = "0x1816631C0")]
	public T BOEAFIEBIHC(Handle BDCLOJHOMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x1664B20", Offset = "0x1663F20", VA = "0x181664B20")]
	public bool LEDONIKBHEA(Handle BDCLOJHOMDK, out T AELIHOPICED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x1663DF0", Offset = "0x16631F0", VA = "0x181663DF0")]
	public void JPNFGACMGOG(Handle BDCLOJHOMDK, T JGPJKHGOEOJ, out T JKCKBFPDKPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x1663AB0", Offset = "0x1662EB0", VA = "0x181663AB0")]
	public void JPNFGACMGOG(Handle BDCLOJHOMDK, T JGPJKHGOEOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x1664DD0", Offset = "0x16641D0", VA = "0x181664DD0")]
	public bool OGNINEINMEG(Handle BDCLOJHOMDK, T JGPJKHGOEOJ, out T JKCKBFPDKPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x1665290", Offset = "0x1664690", VA = "0x181665290")]
	public bool OGNINEINMEG(Handle BDCLOJHOMDK, T JGPJKHGOEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x16638E0", Offset = "0x1662CE0", VA = "0x1816638E0")]
	public Handle GBJBCHALJOG(T AELIHOPICED)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x16642F0", Offset = "0x16636F0", VA = "0x1816642F0")]
	public void KCFEMAHCNFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x1665830", Offset = "0x1664C30", VA = "0x181665830")]
	public void PMMODKPOELK(Handle BDCLOJHOMDK, out T JKCKBFPDKPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x1665580", Offset = "0x1664980", VA = "0x181665580")]
	public void PMMODKPOELK(Handle BDCLOJHOMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x1666010", Offset = "0x1665410", VA = "0x181666010")]
	public bool POLKLACNFNE(Handle BDCLOJHOMDK, out T JKCKBFPDKPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x1665E50", Offset = "0x1665250", VA = "0x181665E50")]
	public bool POLKLACNFNE(Handle BDCLOJHOMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x1665450", Offset = "0x1664850", VA = "0x181665450")]
	private T PJBBGDBFNGB(int EGBCAPEEJBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x16639E0", Offset = "0x1662DE0", VA = "0x1816639E0")]
	private void GJMAKOAEHLO(int OIKHEKALAGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class FOHDNCAIEND<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly Stack<T> DJOFPEAKDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly List<T> JAGIMCDNDPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly int HNKJNJCPAMA;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public int PAHFMADMOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x25B04F0", Offset = "0x25AF8F0", VA = "0x1825B04F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int PGCLLLCPBAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x2277770", Offset = "0x2276B70", VA = "0x182277770")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x32363C0", Offset = "0x32357C0", VA = "0x1832363C0")]
	public static global::FOHDNCAIEND<T> GLOHCHGPGED(int KNECCHHDDJH = 0, int HNKJNJCPAMA = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x3236630", Offset = "0x3235A30", VA = "0x183236630")]
	public static global::FOHDNCAIEND<T> KGPFJODKEBP(int KNECCHHDDJH = 0, int HNKJNJCPAMA = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x3236C30", Offset = "0x3236030", VA = "0x183236C30")]
	public FOHDNCAIEND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x3236AA0", Offset = "0x3235EA0", VA = "0x183236AA0")]
	public FOHDNCAIEND(int KNECCHHDDJH, int HNKJNJCPAMA = int.MaxValue, bool ECODDOAFLKA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x3236900", Offset = "0x3235D00", VA = "0x183236900")]
	public T NKPOHKGJHAP()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x3236850", Offset = "0x3235C50", VA = "0x183236850")]
	public void NCMANBGJLOI(T KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x3236780", Offset = "0x3235B80", VA = "0x183236780")]
	private void LNHINFFOOKK(T KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x32362B0", Offset = "0x32356B0", VA = "0x1832362B0")]
	private void DHHNJCDJKKL(T KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x3236700", Offset = "0x3235B00", VA = "0x183236700")]
	[Conditional("DEBUG_BUILD")]
	private void LEILHONOBPL(T NKEDEDGFMMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x3236A10", Offset = "0x3235E10", VA = "0x183236A10")]
	[Conditional("DEBUG_BUILD")]
	private void OHEJMFPGJIL(T NKEDEDGFMMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x32362D0", Offset = "0x32356D0", VA = "0x1832362D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x3236490", Offset = "0x3235890", VA = "0x183236490")]
	private void IFHKNOMFFBP(IEnumerable<T> GBCINMGHOME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public class GNIOEMKCOGB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private Dictionary<int, T> GCMGJFGGLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private T HOFLPIIJBCP;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public virtual T CKPBNIPNFEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x700140", Offset = "0x6FF540", VA = "0x180700140", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool PLCPILPMFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x2AD63D0", Offset = "0x2AD57D0", VA = "0x182AD63D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x2AD64D0", Offset = "0x2AD58D0", VA = "0x182AD64D0")]
	public bool JPJHPPMDCBA(T KPPLMEOMNGF, int APLFJBIBJAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x2AD6410", Offset = "0x2AD5810", VA = "0x182AD6410")]
	public bool FHGMKIKLJLK(int APLFJBIBJAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x2AD6590", Offset = "0x2AD5990", VA = "0x182AD6590")]
	public T LLGDJGHBCMP(int MCBLFKHBAIO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x2AD6470", Offset = "0x2AD5870", VA = "0x182AD6470")]
	public void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x2AD69B0", Offset = "0x2AD5DB0", VA = "0x182AD69B0")]
	private bool OOCINGAKPFJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x2AD6980", Offset = "0x2AD5D80", VA = "0x182AD6980")]
	public bool OHBANFGHGGE(int APLFJBIBJAH, out T KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x2AD6B50", Offset = "0x2AD5F50", VA = "0x182AD6B50")]
	public GNIOEMKCOGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public class ONGOHDDHFBF<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	protected struct MLFDKNENDFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public T KMEGGOIFMKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public int HPIPDFCDDMO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	protected readonly List<MLFDKNENDFJ> GCEIGNCDLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private T IDLGPGOIAEM;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int IIEJMBAKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x1F8F3B0", Offset = "0x1F8E7B0", VA = "0x181F8F3B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x453AED0", Offset = "0x453A2D0", VA = "0x18453AED0")]
	public bool BNDEAHDJONI(T KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x453B3E0", Offset = "0x453A7E0", VA = "0x18453B3E0")]
	public void GBJBCHALJOG(T KPPLMEOMNGF, int APLFJBIBJAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x453B480", Offset = "0x453A880", VA = "0x18453B480")]
	public bool PMMODKPOELK(T KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x453B380", Offset = "0x453A780", VA = "0x18453B380")]
	public void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x453B310", Offset = "0x453A710", VA = "0x18453B310")]
	public T FJOEEFHDCEB()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x453B2A0", Offset = "0x453A6A0", VA = "0x18453B2A0")]
	public T DKMCAJNFHJB()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x453B0E0", Offset = "0x453A4E0", VA = "0x18453B0E0")]
	private void CMKJKBDEPEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x453B5A0", Offset = "0x453A9A0", VA = "0x18453B5A0")]
	public ONGOHDDHFBF()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		[SerializeField]
		[CBBPHEOMBGL(LNNFGJICGEC.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x65E69E0", Offset = "0x65E5DE0", VA = "0x1865E69E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x65E6D70", Offset = "0x65E6170", VA = "0x1865E6D70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x65E6BF0", Offset = "0x65E5FF0", VA = "0x1865E6BF0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x65E6ED0", Offset = "0x65E62D0", VA = "0x1865E6ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x65E6900", Offset = "0x65E5D00", VA = "0x1865E6900")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x65E6C90", Offset = "0x65E6090", VA = "0x1865E6C90")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x65E6B10", Offset = "0x65E5F10", VA = "0x1865E6B10")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x65E68B0", Offset = "0x65E5CB0", VA = "0x1865E68B0")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public interface KHNJOKHFKNP
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public abstract class ResourcePrefabReference<T> : KHNJOKHFKNP where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x26807E0", Offset = "0x267FBE0", VA = "0x1826807E0", Slot = "4")]
		public virtual T GAECHCAGCGA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x14CA560", Offset = "0x14C9960", VA = "0x1814CA560")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public class EDJJKNMHHFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private readonly Dictionary<byte, LGOOJOOHPFF> LONMJDHJIEJ;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public LGOOJOOHPFF NGNCHOFCGKB
	{
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x6E1AC0", Offset = "0x6E0EC0", VA = "0x1806E1AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x700130", Offset = "0x6FF530", VA = "0x180700130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector2 MCNOLHBMIAC
	{
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x1A9DA10", Offset = "0x1A9CE10", VA = "0x181A9DA10")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x729D20", Offset = "0x729120", VA = "0x180729D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector2 KBKPBMPCFKH
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x2853530", Offset = "0x2852930", VA = "0x182853530")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xA0BF60", Offset = "0xA0B360", VA = "0x180A0BF60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector2 AKCINGECEIF
	{
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x65E0450", Offset = "0x65DF850", VA = "0x1865E0450")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xE99190", Offset = "0xE98590", VA = "0x180E99190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int GJBGPDAFMLF
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x6E00E0", Offset = "0x6DF4E0", VA = "0x1806E00E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x747580", Offset = "0x746980", VA = "0x180747580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x65E08F0", Offset = "0x65DFCF0", VA = "0x1865E08F0")]
	public EDJJKNMHHFH(Bounds CJMEBEPNFND, Vector2[] CAGIGJAFGCD, int HGHIGHNMJGM, byte GJPBLFPOONO, float BFLINGBEFCG = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x65E0470", Offset = "0x65DF870", VA = "0x1865E0470")]
	public LGOOJOOHPFF IBKGNJPINKC(byte EGBCAPEEJBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x65E01F0", Offset = "0x65DF5F0", VA = "0x1865E01F0")]
	public void BOMICGEHMKJ(Vector3 MIFJBHLKJIN, float EAAJNJJJEKF, float AACOIPAKGPD, ref List<byte> LDLLIMFPLDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x65E08D0", Offset = "0x65DFCD0", VA = "0x1865E08D0")]
	public void LFCOKAFOIEB(LGOOJOOHPFF.HOHPONLDPEB FBADPNNDEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x65E02F0", Offset = "0x65DF6F0", VA = "0x1865E02F0")]
	private LGOOJOOHPFF CHJHALNMIMA(byte EGBCAPEEJBF, LGOOJOOHPFF.GJNLKMKDPKF DPODNCNLBNN, LGOOJOOHPFF OKMBLMILFGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x65E04D0", Offset = "0x65DF8D0", VA = "0x1865E04D0")]
	private void JOAMPIJHIFI(LGOOJOOHPFF OKMBLMILFGG, Vector2[] CAGIGJAFGCD, int BOAEGOAEELC, int OMADDDHNANE, int LIOKIGNCLCF, int MEKMNPEDEHO, float BFLINGBEFCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public class LGOOJOOHPFF
{
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public enum GJNLKMKDPKF
	{
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public enum HOHPONLDPEB
	{
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	public byte FOEPHKKCDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public Vector3 ODOBJGCHMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public Vector3 MDNIDCCLGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public Vector3 OAIBHLHNDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public Vector3 NJDCOFKJKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public GJNLKMKDPKF FENLLGGDJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public LGOOJOOHPFF AKKGLHPPJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public List<LGOOJOOHPFF> LJJJLKDCDDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public bool HMGMDLCEODG;

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x65E2F60", Offset = "0x65E2360", VA = "0x1865E2F60")]
	public LGOOJOOHPFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x65E2F80", Offset = "0x65E2380", VA = "0x1865E2F80")]
	public LGOOJOOHPFF(byte CLOAPFCHKDE, GJNLKMKDPKF DPODNCNLBNN, LGOOJOOHPFF OKMBLMILFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x65E2E50", Offset = "0x65E2250", VA = "0x1865E2E50")]
	public void GFLPJLNLLDG(LGOOJOOHPFF BOGHNKLNLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
	public void LFCOKAFOIEB(int AIHCBELKABL, HOHPONLDPEB FBADPNNDEOF, int ANHIFGPPAME = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x65E2B60", Offset = "0x65E1F60", VA = "0x1865E2B60")]
	public void BOMICGEHMKJ(List<byte> LDLLIMFPLDG, Vector3 MIFJBHLKJIN, float EAAJNJJJEKF, float AACOIPAKGPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x65E2F10", Offset = "0x65E2310", VA = "0x1865E2F10")]
	public bool HHJBAEOONGC(Vector3 BJNJDEBFECO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x65E2E10", Offset = "0x65E2210", VA = "0x1865E2E10")]
	public bool DJGJEELAPDH(Vector3 BJNJDEBFECO, float GMKCMLABPFI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public class POJGNFGOJLM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private readonly Dictionary<T, object> JIIDMIPCDHI;

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x166EC40", Offset = "0x166E040", VA = "0x18166EC40")]
	public bool OGNFBDMEDMB(T NMAJDFEGMPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x33FFA30", Offset = "0x33FEE30", VA = "0x1833FFA30")]
	public bool OGNFBDMEDMB(T NMAJDFEGMPM, object JAKCBCDLMLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x33FF9D0", Offset = "0x33FEDD0", VA = "0x1833FF9D0")]
	public bool OGNFBDMEDMB(T NMAJDFEGMPM, object JAKCBCDLMLB, out object OBJPBIOGEDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x33FF880", Offset = "0x33FEC80", VA = "0x1833FF880")]
	public bool FCEHDFEJPAN(T NMAJDFEGMPM, object JAKCBCDLMLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x33FF990", Offset = "0x33FED90", VA = "0x1833FF990")]
	public bool KFJGJMBGMHG(T NMAJDFEGMPM, object JAKCBCDLMLB, out object OBJPBIOGEDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x33FF7F0", Offset = "0x33FEBF0", VA = "0x1833FF7F0")]
	public bool FCEHDFEJPAN(T NMAJDFEGMPM, object JAKCBCDLMLB, out object OBJPBIOGEDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x33FF8C0", Offset = "0x33FECC0", VA = "0x1833FF8C0")]
	public void HECNMIPLCIB(T NMAJDFEGMPM, object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x33FF8F0", Offset = "0x33FECF0", VA = "0x1833FF8F0")]
	public void JPIJCHKEAML(T NMAJDFEGMPM, object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x33FFA70", Offset = "0x33FEE70", VA = "0x1833FFA70")]
	public POJGNFGOJLM()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x20000AC")]
		public struct BPFEFLGLPJJ<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			private readonly List<Component> EHJGMBFBLBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			private readonly bool CPNIACDEHHD;

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x8ADF50", Offset = "0x8AD350", VA = "0x1808ADF50")]
			public BPFEFLGLPJJ(List<Component> EHJGMBFBLBN, bool CPNIACDEHHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x2965770", Offset = "0x2964B70", VA = "0x182965770")]
			public KPPBDNMMFJE<T> KGLEFCHHJJI()
			{
				return default(KPPBDNMMFJE<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x29657E0", Offset = "0x2964BE0", VA = "0x1829657E0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x29657E0", Offset = "0x2964BE0", VA = "0x1829657E0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AD")]
		public struct KPPBDNMMFJE<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			private readonly List<Component> EHJGMBFBLBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			private readonly bool CPNIACDEHHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			private int EGBCAPEEJBF;

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public T AGGOFNFHANI
			{
				[Cpp2IlInjected.Token(Token = "0x60003E2")]
				[Cpp2IlInjected.Address(RVA = "0x36A1F60", Offset = "0x36A1360", VA = "0x1836A1F60", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003E3")]
				[Cpp2IlInjected.Address(RVA = "0x36A1EF0", Offset = "0x36A12F0", VA = "0x1836A1EF0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003E1")]
			[Cpp2IlInjected.Address(RVA = "0x36A1F30", Offset = "0x36A1330", VA = "0x1836A1F30")]
			public KPPBDNMMFJE(List<Component> EHJGMBFBLBN, bool CPNIACDEHHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x36A1E30", Offset = "0x36A1230", VA = "0x1836A1E30", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x36A1E40", Offset = "0x36A1240", VA = "0x1836A1E40", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x2856CB0", Offset = "0x28560B0", VA = "0x182856CB0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0x65E8BA0", Offset = "0x65E7FA0", VA = "0x1865E8BA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x65E8B60", Offset = "0x65E7F60", VA = "0x1865E8B60")]
		public ToolHierarchyCache(GameObject LOCIAIPOBLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x65E8550", Offset = "0x65E7950", VA = "0x1865E8550")]
		private void JHHOMPLGCBC(GameObject LOCIAIPOBLA, bool AKNNPOEHKML = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x65E86B0", Offset = "0x65E7AB0", VA = "0x1865E86B0")]
		public static void JHHOMPLGCBC(GameObject LOCIAIPOBLA, ref ToolHierarchyCache DAJPKNFIFBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x65E8540", Offset = "0x65E7940", VA = "0x1865E8540")]
		public void JFDFLICPNAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x65E8740", Offset = "0x65E7B40", VA = "0x1865E8740")]
		public void KIILEFLBIND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x4160A70", Offset = "0x415FE70", VA = "0x184160A70")]
		public void JGLBPFCCHBJ<T>(Action<T> FFBLFKDINEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x65E8370", Offset = "0x65E7770", VA = "0x1865E8370")]
		public Component ELJIOCJMALA(Type HAOFNDAEGFJ, bool CPNIACDEHHD = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x41609F0", Offset = "0x415FDF0", VA = "0x1841609F0")]
		public T ELJIOCJMALA<T>(bool CPNIACDEHHD = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x65E82F0", Offset = "0x65E76F0", VA = "0x1865E82F0")]
		public BPFEFLGLPJJ<Component> EDJOKFLBFNL(Type HAOFNDAEGFJ, bool CPNIACDEHHD = false)
		{
			return default(BPFEFLGLPJJ<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x4160920", Offset = "0x415FD20", VA = "0x184160920")]
		public BPFEFLGLPJJ<T> EDJOKFLBFNL<T>(bool CPNIACDEHHD = false) where T : class
		{
			return default(BPFEFLGLPJJ<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x65E8790", Offset = "0x65E7B90", VA = "0x1865E8790")]
		public List<Component> MLJKPOPLMDL(Type HAOFNDAEGFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x65E8440", Offset = "0x65E7840", VA = "0x1865E8440", Slot = "4")]
		public bool Equals(ToolHierarchyCache PMEDGJGANML, ToolHierarchyCache NIPKEFBPNPH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x65E84C0", Offset = "0x65E78C0", VA = "0x1865E84C0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache AELIHOPICED)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public class HFBILHMBNPG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private int KNECCHHDDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private int GOPLGHMMPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private List<T> KDCOOOFOCDB;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public int IIEJMBAKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x25B04F0", Offset = "0x25AF8F0", VA = "0x1825B04F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public T HODLDDNMMHG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x2754B70", Offset = "0x2753F70", VA = "0x182754B70")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public T DJEBFNPLNJF
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x27547E0", Offset = "0x2753BE0", VA = "0x1827547E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public T LDFCEPFNNDA
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x2754AC0", Offset = "0x2753EC0", VA = "0x182754AC0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x2754D30", Offset = "0x2754130", VA = "0x182754D30")]
	public HFBILHMBNPG(int KNECCHHDDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x2754990", Offset = "0x2753D90", VA = "0x182754990")]
	public void GBJBCHALJOG(T NHOHPGMEPKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x2754880", Offset = "0x2753C80", VA = "0x182754880")]
	public void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x2754C80", Offset = "0x2754080", VA = "0x182754C80")]
	public void NDLDILKKODH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x2754B20", Offset = "0x2753F20", VA = "0x182754B20")]
	public void MMAMFLHKKAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x2754D20", Offset = "0x2754120", VA = "0x182754D20")]
	public void OMHDMFKMFPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public class IILFIMLHJKP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private bool JCFMBKJAOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private Action FFBLFKDINEA;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public static IILFIMLHJKP JMONPJNDMAC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x65E21E0", Offset = "0x65E15E0", VA = "0x1865E21E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool FFBFJBAACDM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x6E4250", Offset = "0x6E3650", VA = "0x1806E4250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0xC1AD00", Offset = "0xC1A100", VA = "0x180C1AD00")]
	public IILFIMLHJKP(Action FFBLFKDINEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x65E21C0", Offset = "0x65E15C0", VA = "0x1865E21C0")]
	public void OIEKBFPKDBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x65E21C0", Offset = "0x65E15C0", VA = "0x1865E21C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public static class DOOLBKJPJJC
{
	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x65E0070", Offset = "0x65DF470", VA = "0x1865E0070")]
	public static void CAEBEIKNPKP(JLNNFJHBOML OHGHGDAIFAO, string OLAMDIIMMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
	public static void CAEBEIKNPKP(IEnumerable<object> ABGEACDGIFN, string OLAMDIIMMNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public class KEFJIJAEDKB<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	private struct NAJDPICCOAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public int HPIPDFCDDMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public T KMEGGOIFMKC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private readonly Dictionary<object, NAJDPICCOAD> GCMGJFGGLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private readonly EqualityComparer<T> NKGEPDNNFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private T HOFLPIIJBCP;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public virtual T CKPBNIPNFEB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0xC11C00", Offset = "0xC11000", VA = "0x180C11C00", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x2603970", Offset = "0x2602D70", VA = "0x182603970", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool PLCPILPMFHD
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x284E4F0", Offset = "0x284D8F0", VA = "0x18284E4F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public object BIJCCAJCLHE
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x6F66F0", Offset = "0x6F5AF0", VA = "0x1806F66F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x778B00", Offset = "0x777F00", VA = "0x180778B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x284E9C0", Offset = "0x284DDC0", VA = "0x18284E9C0")]
	public bool JPJHPPMDCBA(T KPPLMEOMNGF, object JAKCBCDLMLB, int APLFJBIBJAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x284E5A0", Offset = "0x284D9A0", VA = "0x18284E5A0")]
	public bool FHGMKIKLJLK(object JAKCBCDLMLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x284F060", Offset = "0x284E460", VA = "0x18284F060")]
	public bool OHBANFGHGGE(object JAKCBCDLMLB, out T KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x284E610", Offset = "0x284DA10", VA = "0x18284E610")]
	public void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x2853260", Offset = "0x2852660", VA = "0x182853260")]
	private bool OOCINGAKPFJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x2853580", Offset = "0x2852980", VA = "0x182853580")]
	public KEFJIJAEDKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public class OBFONEOHADB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private Dictionary<object, float> GCMGJFGGLEN;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float FKHGJNFOEJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x12C8520", Offset = "0x12C7920", VA = "0x1812C8520")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0xE08E00", Offset = "0xE08200", VA = "0x180E08E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x65E6220", Offset = "0x65E5620", VA = "0x1865E6220")]
	public void JPJHPPMDCBA(float KPPLMEOMNGF, object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x65E6090", Offset = "0x65E5490", VA = "0x1865E6090")]
	public void FHGMKIKLJLK(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x65E6100", Offset = "0x65E5500", VA = "0x1865E6100")]
	private void FNMEEPLOOIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x65E6290", Offset = "0x65E5690", VA = "0x1865E6290")]
	public OBFONEOHADB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public class MBGFKCALJCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public readonly string APNEBIOFCKF;

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x6E0F40", Offset = "0x6E0340", VA = "0x1806E0F40")]
	public MBGFKCALJCF(string JNOPKIMKCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x65E41A0", Offset = "0x65E35A0", VA = "0x1865E41A0")]
	public MBGFKCALJCF(UnityEngine.Object EBODCLADMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x65E4150", Offset = "0x65E3550", VA = "0x1865E4150", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public sealed class JLNNFJHBOML
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private sealed class BIJGLILAFEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public BIJGLILAFEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x65DFC00", Offset = "0x65DF000", VA = "0x1865DFC00")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private HashSet<object> ABGEACDGIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private int POPMGBNDCON;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public IReadOnlyCollection<object> KPJACHNJINE
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x65E2390", Offset = "0x65E1790", VA = "0x1865E2390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool GNKDLLKCMAB
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x65E2620", Offset = "0x65E1A20", VA = "0x1865E2620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public int IIEJMBAKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x6E1BD0", Offset = "0x6E0FD0", VA = "0x1806E1BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x65E24C0", Offset = "0x65E18C0", VA = "0x1865E24C0")]
	public bool GBJBCHALJOG(object JAKCBCDLMLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x65E2630", Offset = "0x65E1A30", VA = "0x1865E2630")]
	public bool PMMODKPOELK(object JAKCBCDLMLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x65E2460", Offset = "0x65E1860", VA = "0x1865E2460")]
	public bool BNDEAHDJONI(object JAKCBCDLMLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x65E25B0", Offset = "0x65E19B0", VA = "0x1865E25B0")]
	public void HFLCBPLCMNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x65E26D0", Offset = "0x65E1AD0", VA = "0x1865E26D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public JLNNFJHBOML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public class JOJICCBKMBL<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	private struct KKKIMJLGGLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public float DPGJLIDNNCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public T KMEGGOIFMKC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private Dictionary<object, KKKIMJLGGLI> GCMGJFGGLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private T EKBJBDJJNMN;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public virtual T GMKNHEMIOJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x126FA20", Offset = "0x126EE20", VA = "0x18126FA20", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x16AE510", Offset = "0x16AD910", VA = "0x1816AE510", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public object DGJHDNMDOMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x6F66F0", Offset = "0x6F5AF0", VA = "0x1806F66F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x778B00", Offset = "0x777F00", VA = "0x180778B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool PLCPILPMFHD
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x361BC00", Offset = "0x361B000", VA = "0x18361BC00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x361C170", Offset = "0x361B570", VA = "0x18361C170")]
	public bool JPJHPPMDCBA(T KPPLMEOMNGF, object JAKCBCDLMLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x361BC40", Offset = "0x361B040", VA = "0x18361BC40")]
	public bool FHGMKIKLJLK(object JAKCBCDLMLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x284E610", Offset = "0x284DA10", VA = "0x18284E610")]
	public void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x361C330", Offset = "0x361B730", VA = "0x18361C330")]
	public bool OHBANFGHGGE(object JAKCBCDLMLB, out T KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x361CEB0", Offset = "0x361C2B0", VA = "0x18361CEB0")]
	private bool OOCINGAKPFJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x361DB40", Offset = "0x361CF40", VA = "0x18361DB40")]
	public JOJICCBKMBL()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public class HFBMMEPCDLM
{
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private static byte[] JNCOHDGFJLD;

	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private static int DPLNOEOFOIM;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private static int ICHAIMIBEGB;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private static BigInteger GDFBBFKEIIP;

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public HFBMMEPCDLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x65E17A0", Offset = "0x65E0BA0", VA = "0x1865E17A0")]
	private static string AEHPCHKGFJE(byte[] ICPOAGANOLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x65E18B0", Offset = "0x65E0CB0", VA = "0x1865E18B0")]
	public static string PKAAKGDAGEE(byte[] FHNEBAPANCE, bool MGDFGAKHOKG)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x20000BB")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
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
