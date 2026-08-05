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
	[Cpp2IlInjected.Address(RVA = "0x746C20", Offset = "0x745C20", VA = "0x180746C20")]
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
		[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6FF140", Offset = "0x6FE140", VA = "0x1806FF140", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6E0120", Offset = "0x6DF120", VA = "0x1806E0120", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6E0130", Offset = "0x6DF130", VA = "0x1806E0130", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7FDE20", Offset = "0x7FCE20", VA = "0x1807FDE20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash ADPFJJODLPO);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xE23C60", Offset = "0xE22C60", VA = "0x180E23C60")]
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
		[Cpp2IlInjected.Address(RVA = "0x6531FC0", Offset = "0x6530FC0", VA = "0x186531FC0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6531F80", Offset = "0x6530F80", VA = "0x186531F80")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6532000", Offset = "0x6531000", VA = "0x186532000")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x65321D0", Offset = "0x65311D0", VA = "0x1865321D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6532140", Offset = "0x6531140", VA = "0x186532140")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x11E0800", Offset = "0x11DF800", VA = "0x1811E0800")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1145CE0", Offset = "0x1144CE0", VA = "0x181145CE0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6531F40", Offset = "0x6530F40", VA = "0x186531F40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x65320B0", Offset = "0x65310B0", VA = "0x1865320B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6531B70", Offset = "0x6530B70", VA = "0x186531B70")]
	public void CopyBounds(SavedExtents JHMCLPBFJBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6531EA0", Offset = "0x6530EA0", VA = "0x186531EA0")]
	public void SetLocalSpaceBounds(Bounds BMGINPIJPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0xFBDCA0", Offset = "0xFBCCA0", VA = "0x180FBDCA0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6531E90", Offset = "0x6530E90", VA = "0x186531E90")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6531340", Offset = "0x6530340", VA = "0x186531340")]
	private void BEHICECBOIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6531C60", Offset = "0x6530C60", VA = "0x186531C60")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6531530", Offset = "0x6530530", VA = "0x186531530")]
	public static void CalculateLocalBoundsFor(GameObject BLPBCMIHDMD, out Bounds BMGINPIJPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6531BA0", Offset = "0x6530BA0", VA = "0x186531BA0")]
	private static void EMJFIEPIHDJ(Bounds ICPOAGANOLH, Color FILONMPFNJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6531EC0", Offset = "0x6530EC0", VA = "0x186531EC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6DF040", Offset = "0x6DE040", VA = "0x1806DF040")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6FFF30", Offset = "0x6FEF30", VA = "0x1806FFF30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1527C80", Offset = "0x1526C80", VA = "0x181527C80")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA9B820", Offset = "0xA9A820", VA = "0x180A9B820")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "4")]
	public virtual void HMKJNNDCPHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x10FDE40", Offset = "0x10FCE40", VA = "0x1810FDE40")]
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
	[Cpp2IlInjected.Address(RVA = "0x3030BA0", Offset = "0x302FBA0", VA = "0x183030BA0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x30302D0", Offset = "0x302F2D0", VA = "0x1830302D0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x30310E0", Offset = "0x30300E0", VA = "0x1830310E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x10FDE40", Offset = "0x10FCE40", VA = "0x1810FDE40")]
		public NHJJKFNDJHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x23C2460", Offset = "0x23C1460", VA = "0x1823C2460")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x14A8EB0", Offset = "0x14A7EB0", VA = "0x1814A8EB0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x14A8EE0", Offset = "0x14A7EE0", VA = "0x1814A8EE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x14A8E00", Offset = "0x14A7E00", VA = "0x1814A8E00", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public TVal this[TKey EBOIOCBODNI]
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x14A8E60", Offset = "0x14A7E60", VA = "0x1814A8E60", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x14A8D00", Offset = "0x14A7D00", VA = "0x1814A8D00", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x14A8850", Offset = "0x14A7850", VA = "0x1814A8850", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x14A8070", Offset = "0x14A7070", VA = "0x1814A8070", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x14A7C60", Offset = "0x14A6C60", VA = "0x1814A7C60", Slot = "14")]
	protected virtual string BKGFCOPCAIK(TKeyVal IOOAILEEPEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x14A7C90", Offset = "0x14A6C90", VA = "0x1814A7C90", Slot = "4")]
	public bool ContainsKey(TKey EBOIOCBODNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x14A8BF0", Offset = "0x14A7BF0", VA = "0x1814A8BF0", Slot = "5")]
	public bool TryGetValue(TKey EBOIOCBODNI, out TVal KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x14A7CC0", Offset = "0x14A6CC0", VA = "0x1814A7CC0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x14A7CC0", Offset = "0x14A6CC0", VA = "0x1814A7CC0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x14A8C20", Offset = "0x14A7C20", VA = "0x1814A8C20")]
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
		[Cpp2IlInjected.Address(RVA = "0x10FDE40", Offset = "0x10FCE40", VA = "0x1810FDE40")]
		public CJJNMHKEOEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2EE76C0", Offset = "0x2EE66C0", VA = "0x182EE76C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x347BB20", Offset = "0x347AB20", VA = "0x18347BB20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x347BCC0", Offset = "0x347ACC0", VA = "0x18347BCC0")]
	public PMIMCGMLPMC(float CDFADGCIFIL, float LDCDBEDKDGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x347B940", Offset = "0x347A940", VA = "0x18347B940")]
	public bool GDCCGFCJPMK(float PPIFMHEDLGN, T KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x347BBA0", Offset = "0x347ABA0", VA = "0x18347BBA0")]
	public int MOCJGKGBBLI(float PPIFMHEDLGN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x347B470", Offset = "0x347A470", VA = "0x18347B470")]
	public IEnumerable<T> FNMBIENDFGF(float PPIFMHEDLGN, [Optional] float? DPADAHKKLIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x347B7B0", Offset = "0x347A7B0", VA = "0x18347B7B0")]
	public void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x347BC00", Offset = "0x347AC00", VA = "0x18347BC00")]
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
		[Cpp2IlInjected.Address(RVA = "0xF5B860", Offset = "0xF5A860", VA = "0x180F5B860")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xF5B840", Offset = "0xF5A840", VA = "0x180F5B840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2B24D60", Offset = "0x2B23D60", VA = "0x182B24D60")]
	public PFHFKKKBKLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2B24D90", Offset = "0x2B23D90", VA = "0x182B24D90")]
	public PFHFKKKBKLN(int MKMGHJFMNMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2B246F0", Offset = "0x2B236F0", VA = "0x182B246F0")]
	public void GBJBCHALJOG(float PPIFMHEDLGN, T KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2B244C0", Offset = "0x2B234C0", VA = "0x182B244C0")]
	public void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2B238E0", Offset = "0x2B228E0", VA = "0x182B238E0")]
	public bool BLDOHDGOCMI(float ADFLOADHGMB, float LLEHFFKCDCM, out T KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2B24890", Offset = "0x2B23890", VA = "0x182B24890")]
	public bool INEKBLAMBGB(float ADFLOADHGMB, float LLEHFFKCDCM, out T KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2B23E70", Offset = "0x2B22E70", VA = "0x182B23E70")]
	public void CJOLHCFBPLF(float ADFLOADHGMB, float LLEHFFKCDCM, List<T> BFNDINBALAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2B238B0", Offset = "0x2B228B0", VA = "0x182B238B0")]
	private int ADFEMDHGOGE(int FLGOBCNGCEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2B241E0", Offset = "0x2B231E0", VA = "0x182B241E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x163AE90", Offset = "0x1639E90", VA = "0x18163AE90", Slot = "4")]
	protected override Vector3 CDJAAOALCOI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1EE5760", Offset = "0x1EE4760", VA = "0x181EE5760", Slot = "5")]
	protected override Vector3 FBNCENACCMJ(Vector3 AJDPMFOKMPC, Vector3 DAAPHBHBHCO, float JELHNILOKLO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x652CD60", Offset = "0x652BD60", VA = "0x18652CD60", Slot = "6")]
	protected override Vector3 PMDLMCAOIJA(Vector3 KPPLMEOMNGF, float JELHNILOKLO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x652CCE0", Offset = "0x652BCE0", VA = "0x18652CCE0", Slot = "7")]
	protected override Vector3 CAOPPAICFBM(Vector3 AJDPMFOKMPC, Vector3 DAAPHBHBHCO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x652CC70", Offset = "0x652BC70", VA = "0x18652CC70", Slot = "8")]
	protected override Vector3 BEDFHIHFBNM(Vector3 AJDPMFOKMPC, Vector3 DAAPHBHBHCO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x652CDC0", Offset = "0x652BDC0", VA = "0x18652CDC0")]
	public KJDHLHGEMIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class IPOEAJMHMJD : global::PFHFKKKBKLN<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x652C5C0", Offset = "0x652B5C0", VA = "0x18652C5C0")]
	public IPOEAJMHMJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x652C630", Offset = "0x652B630", VA = "0x18652C630")]
	public IPOEAJMHMJD(int MKMGHJFMNMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x130EAF0", Offset = "0x130DAF0", VA = "0x18130EAF0", Slot = "4")]
	protected override float CDJAAOALCOI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3B2EEC0", Offset = "0x3B2DEC0", VA = "0x183B2EEC0", Slot = "5")]
	protected override float FBNCENACCMJ(float AJDPMFOKMPC, float DAAPHBHBHCO, float JELHNILOKLO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x535D8C0", Offset = "0x535C8C0", VA = "0x18535D8C0", Slot = "6")]
	protected override float PMDLMCAOIJA(float KPPLMEOMNGF, float JELHNILOKLO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x27C5C30", Offset = "0x27C4C30", VA = "0x1827C5C30", Slot = "7")]
	protected override float CAOPPAICFBM(float AJDPMFOKMPC, float DAAPHBHBHCO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x652C5B0", Offset = "0x652B5B0", VA = "0x18652C5B0", Slot = "8")]
	protected override float BEDFHIHFBNM(float AJDPMFOKMPC, float DAAPHBHBHCO)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class AACNLNMMMPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1764620", Offset = "0x1763620", VA = "0x181764620")]
	public static global::BDEALKJAGJG<T1> BMDGCEOIEEG<T1>(T1 HGKONLGNKBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x17640B0", Offset = "0x17630B0", VA = "0x1817640B0")]
	public static global::LPBEACKBGAJ<T1, T2> BMDGCEOIEEG<T1, T2>(T1 HGKONLGNKBC, T2 HKMBMNOCDFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1764120", Offset = "0x1763120", VA = "0x181764120")]
	public static global::BFNLPGJCKII<T1, T2, T3> BMDGCEOIEEG<T1, T2, T3>(T1 HGKONLGNKBC, T2 HKMBMNOCDFA, T3 KMLGBJGMLJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1764490", Offset = "0x1763490", VA = "0x181764490")]
	public static global::OMICBLPCIPK<T1, T2, T3, T4> BMDGCEOIEEG<T1, T2, T3, T4>(T1 HGKONLGNKBC, T2 HKMBMNOCDFA, T3 KMLGBJGMLJK, T4 HGDCKNMELAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x17643F0", Offset = "0x17633F0", VA = "0x1817643F0")]
	public static global::PMLDPGBCBBM<T1, T2, T3, T4, T5> BMDGCEOIEEG<T1, T2, T3, T4, T5>(T1 HGKONLGNKBC, T2 HKMBMNOCDFA, T3 KMLGBJGMLJK, T4 HGDCKNMELAP, T5 AIHPPCMMAHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1764340", Offset = "0x1763340", VA = "0x181764340")]
	public static global::JCAENOHEBIJ<T1, T2, T3, T4, T5, T6> BMDGCEOIEEG<T1, T2, T3, T4, T5, T6>(T1 HGKONLGNKBC, T2 HKMBMNOCDFA, T3 KMLGBJGMLJK, T4 HGDCKNMELAP, T5 AIHPPCMMAHE, T6 CFEEGONNJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1764280", Offset = "0x1763280", VA = "0x181764280")]
	public static global::MMPCFCLPGPB<T1, T2, T3, T4, T5, T6, T7> BMDGCEOIEEG<T1, T2, T3, T4, T5, T6, T7>(T1 HGKONLGNKBC, T2 HKMBMNOCDFA, T3 KMLGBJGMLJK, T4 HGDCKNMELAP, T5 AIHPPCMMAHE, T6 CFEEGONNJAE, T7 GLAGMGDCJBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x17641B0", Offset = "0x17631B0", VA = "0x1817641B0")]
	public static global::COIHFPAEHGJ<T1, T2, T3, T4, T5, T6, T7, T8> BMDGCEOIEEG<T1, T2, T3, T4, T5, T6, T7, T8>(T1 HGKONLGNKBC, T2 HKMBMNOCDFA, T3 KMLGBJGMLJK, T4 HGDCKNMELAP, T5 AIHPPCMMAHE, T6 CFEEGONNJAE, T7 GLAGMGDCJBC, T8 FNLFFJIGFDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1764740", Offset = "0x1763740", VA = "0x181764740")]
	[IteratorStateMachine(typeof(FNFGNPHMGHM))]
	public static IEnumerable<global::LPBEACKBGAJ<T1, T2>> OONMMHOFCKM<T1, T2>(IEnumerable<T1> BECDKHGLGNB, IEnumerable<T2> ICPOAGANOLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1764680", Offset = "0x1763680", VA = "0x181764680")]
	[IteratorStateMachine(typeof(IJCFJLHFONC))]
	public static IEnumerable<global::BFNLPGJCKII<T1, T2, T3>> OONMMHOFCKM<T1, T2, T3>(IEnumerable<T1> BECDKHGLGNB, IEnumerable<T2> ICPOAGANOLH, IEnumerable<T3> FILONMPFNJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x87AE90", Offset = "0x879E90", VA = "0x18087AE90")]
	internal static int GHLFNCFCEGG(int OMKLKEFFEPP, int CINIALNDCMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x87AE60", Offset = "0x879E60", VA = "0x18087AE60")]
	internal static int GHLFNCFCEGG(int OMKLKEFFEPP, int CINIALNDCMO, int PADPCIPKDPJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x87AE40", Offset = "0x879E40", VA = "0x18087AE40")]
	internal static int GHLFNCFCEGG(int OMKLKEFFEPP, int CINIALNDCMO, int PADPCIPKDPJ, int NKEKMHBHAGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x87AE70", Offset = "0x879E70", VA = "0x18087AE70")]
	internal static int GHLFNCFCEGG(int OMKLKEFFEPP, int CINIALNDCMO, int PADPCIPKDPJ, int NKEKMHBHAGD, int AMPKOIOBOLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6529010", Offset = "0x6528010", VA = "0x186529010")]
	internal static int GHLFNCFCEGG(int OMKLKEFFEPP, int CINIALNDCMO, int PADPCIPKDPJ, int NKEKMHBHAGD, int AMPKOIOBOLH, int APKFOMOBKED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6528FB0", Offset = "0x6527FB0", VA = "0x186528FB0")]
	internal static int GHLFNCFCEGG(int OMKLKEFFEPP, int CINIALNDCMO, int PADPCIPKDPJ, int NKEKMHBHAGD, int AMPKOIOBOLH, int APKFOMOBKED, int FIJGFGCGDLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6528FE0", Offset = "0x6527FE0", VA = "0x186528FE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x20293C0", Offset = "0x20283C0", VA = "0x1820293C0")]
	public BDEALKJAGJG(T1 HGKONLGNKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x29FD520", Offset = "0x29FC520", VA = "0x1829FD520", Slot = "4")]
	public int CompareTo(global::BDEALKJAGJG<T1> JHMCLPBFJBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x29FD590", Offset = "0x29FC590", VA = "0x1829FD590", Slot = "0")]
	public override bool Equals(object JHMCLPBFJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x92B470", Offset = "0x92A470", VA = "0x18092B470", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x29FD630", Offset = "0x29FC630", VA = "0x1829FD630", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x24EFBE0", Offset = "0x24EEBE0", VA = "0x1824EFBE0")]
	public LPBEACKBGAJ(T1 HGKONLGNKBC, T2 HKMBMNOCDFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3318450", Offset = "0x3317450", VA = "0x183318450", Slot = "4")]
	public int CompareTo(global::LPBEACKBGAJ<T1, T2> JHMCLPBFJBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3318F10", Offset = "0x3317F10", VA = "0x183318F10", Slot = "0")]
	public override bool Equals(object JHMCLPBFJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x33194E0", Offset = "0x33184E0", VA = "0x1833194E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3319950", Offset = "0x3318950", VA = "0x183319950", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FFC40", Offset = "0x29FEC40", VA = "0x1829FFC40")]
	public BFNLPGJCKII(T1 HGKONLGNKBC, T2 HKMBMNOCDFA, T3 KMLGBJGMLJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x29FF430", Offset = "0x29FE430", VA = "0x1829FF430", Slot = "4")]
	public int CompareTo(global::BFNLPGJCKII<T1, T2, T3> JHMCLPBFJBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x29FF720", Offset = "0x29FE720", VA = "0x1829FF720", Slot = "0")]
	public override bool Equals(object JHMCLPBFJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x29FF890", Offset = "0x29FE890", VA = "0x1829FF890", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x29FFA90", Offset = "0x29FEA90", VA = "0x1829FFA90", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1115210", Offset = "0x1114210", VA = "0x181115210")]
	public OMICBLPCIPK(T1 HGKONLGNKBC, T2 HKMBMNOCDFA, T3 KMLGBJGMLJK, T4 HGDCKNMELAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x25212A0", Offset = "0x25202A0", VA = "0x1825212A0", Slot = "4")]
	public int CompareTo(global::OMICBLPCIPK<T1, T2, T3, T4> JHMCLPBFJBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x25213E0", Offset = "0x25203E0", VA = "0x1825213E0", Slot = "0")]
	public override bool Equals(object JHMCLPBFJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2521500", Offset = "0x2520500", VA = "0x182521500", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x25215C0", Offset = "0x25205C0", VA = "0x1825215C0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x24EC040", Offset = "0x24EB040", VA = "0x1824EC040")]
	public PMLDPGBCBBM(T1 HGKONLGNKBC, T2 HKMBMNOCDFA, T3 KMLGBJGMLJK, T4 HGDCKNMELAP, T5 AIHPPCMMAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x347BD70", Offset = "0x347AD70", VA = "0x18347BD70", Slot = "4")]
	public int CompareTo(global::PMLDPGBCBBM<T1, T2, T3, T4, T5> JHMCLPBFJBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x347BEF0", Offset = "0x347AEF0", VA = "0x18347BEF0", Slot = "0")]
	public override bool Equals(object JHMCLPBFJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x347C030", Offset = "0x347B030", VA = "0x18347C030", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x347C130", Offset = "0x347B130", VA = "0x18347C130", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B41C00", Offset = "0x2B40C00", VA = "0x182B41C00")]
	public JCAENOHEBIJ(T1 HGKONLGNKBC, T2 HKMBMNOCDFA, T3 KMLGBJGMLJK, T4 HGDCKNMELAP, T5 AIHPPCMMAHE, T6 CFEEGONNJAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2B41640", Offset = "0x2B40640", VA = "0x182B41640", Slot = "4")]
	public int CompareTo(global::JCAENOHEBIJ<T1, T2, T3, T4, T5, T6> JHMCLPBFJBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2B41800", Offset = "0x2B40800", VA = "0x182B41800", Slot = "0")]
	public override bool Equals(object JHMCLPBFJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2B41970", Offset = "0x2B40970", VA = "0x182B41970", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2B41A90", Offset = "0x2B40A90", VA = "0x182B41A90", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x3580810", Offset = "0x357F810", VA = "0x183580810")]
	public MMPCFCLPGPB(T1 HGKONLGNKBC, T2 HKMBMNOCDFA, T3 KMLGBJGMLJK, T4 HGDCKNMELAP, T5 AIHPPCMMAHE, T6 CFEEGONNJAE, T7 GLAGMGDCJBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3580190", Offset = "0x357F190", VA = "0x183580190", Slot = "4")]
	public int CompareTo(global::MMPCFCLPGPB<T1, T2, T3, T4, T5, T6, T7> JHMCLPBFJBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3580390", Offset = "0x357F390", VA = "0x183580390", Slot = "0")]
	public override bool Equals(object JHMCLPBFJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3580530", Offset = "0x357F530", VA = "0x183580530", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3580680", Offset = "0x357F680", VA = "0x183580680", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x2EEEB40", Offset = "0x2EEDB40", VA = "0x182EEEB40")]
	public COIHFPAEHGJ(T1 HGKONLGNKBC, T2 HKMBMNOCDFA, T3 KMLGBJGMLJK, T4 HGDCKNMELAP, T5 AIHPPCMMAHE, T6 CFEEGONNJAE, T7 GLAGMGDCJBC, T8 FNLFFJIGFDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2EEE410", Offset = "0x2EED410", VA = "0x182EEE410", Slot = "4")]
	public int CompareTo(global::COIHFPAEHGJ<T1, T2, T3, T4, T5, T6, T7, T8> JHMCLPBFJBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x2EEE660", Offset = "0x2EED660", VA = "0x182EEE660", Slot = "0")]
	public override bool Equals(object JHMCLPBFJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2EEE820", Offset = "0x2EED820", VA = "0x182EEE820", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2EEE990", Offset = "0x2EED990", VA = "0x182EEE990", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D014E0", Offset = "0x3D004E0", VA = "0x183D014E0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x4616410", Offset = "0x4615410", VA = "0x184616410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float GOKCMFCKLIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x11C4AC0", Offset = "0x11C3AC0", VA = "0x1811C4AC0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4616660", Offset = "0x4615660", VA = "0x184616660")]
	public T OBIMOCJCILN(float JELHNILOKLO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4616520", Offset = "0x4615520", VA = "0x184616520")]
	public T HPKELBELJCC(float JELHNILOKLO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T FBNCENACCMJ(T AJDPMFOKMPC, T DAAPHBHBHCO, float JELHNILOKLO);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x10FDE40", Offset = "0x10FCE40", VA = "0x1810FDE40")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3B2EEC0", Offset = "0x3B2DEC0", VA = "0x183B2EEC0", Slot = "4")]
	protected override float FBNCENACCMJ(float AJDPMFOKMPC, float DAAPHBHBHCO, float JELHNILOKLO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x652B330", Offset = "0x652A330", VA = "0x18652B330")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1EE5760", Offset = "0x1EE4760", VA = "0x181EE5760", Slot = "4")]
	protected override Vector3 FBNCENACCMJ(Vector3 AJDPMFOKMPC, Vector3 DAAPHBHBHCO, float JELHNILOKLO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6533180", Offset = "0x6532180", VA = "0x186533180")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6529890", Offset = "0x6528890", VA = "0x186529890", Slot = "4")]
	protected override Color FBNCENACCMJ(Color AJDPMFOKMPC, Color DAAPHBHBHCO, float JELHNILOKLO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x65298E0", Offset = "0x65288E0", VA = "0x1865298E0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class GEGGMHAEBAH : global::LCOFNCIAACG<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x652B4B0", Offset = "0x652A4B0", VA = "0x18652B4B0")]
	public GEGGMHAEBAH(int KNECCHHDDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x652B450", Offset = "0x652A450", VA = "0x18652B450")]
	public GEGGMHAEBAH(IPLKBGDEEHK[] PMGFKBCECNF, bool KDADMDNMJNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x652B3E0", Offset = "0x652A3E0", VA = "0x18652B3E0", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x10FDE40", Offset = "0x10FCE40", VA = "0x1810FDE40")]
		public JFFCGJAMLLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B4CCF0", Offset = "0x2B4BCF0", VA = "0x182B4CCF0")]
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
	[Cpp2IlInjected.Address(RVA = "0xC2BE90", Offset = "0xC2AE90", VA = "0x180C2BE90")]
	private FALBIMIGIKD(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> CELMDPLFPMB, int OEDJAIJJCOB, int ONBCMLEDAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x41E7340", Offset = "0x41E6340", VA = "0x1841E7340")]
	public static global::FALBIMIGIKD<T> CCFMECMIHDM()
	{
		return default(global::FALBIMIGIKD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x41E7B60", Offset = "0x41E6B60", VA = "0x1841E7B60")]
	public (int, int, Task<T>) EHFCLOLAJBJ(int EOFJKMCNNHP, [Optional] CancellationToken ANIIOKLMHLI, double FCCAADEIJOC = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x41E8B60", Offset = "0x41E7B60", VA = "0x1841E8B60")]
	public void NOAAFBHFAKJ(int EOFJKMCNNHP, int ONBCMLEDAKN, in T GPPHCPBMODE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class HPONANPEGDP
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x652C210", Offset = "0x652B210", VA = "0x18652C210")]
	public static global::FALBIMIGIKD<ADEHAJBPFKB> CCFMECMIHDM()
	{
		return default(global::FALBIMIGIKD<ADEHAJBPFKB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x652C260", Offset = "0x652B260", VA = "0x18652C260")]
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
		[Cpp2IlInjected.Address(RVA = "0x2029390", Offset = "0x2028390", VA = "0x182029390", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool NLCBLEMMOHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6E2D00", Offset = "0x6E1D00", VA = "0x1806E2D00", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> NPJDPOGBILC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x260C1B0", Offset = "0x260B1B0", VA = "0x18260C1B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> GDNOFJBHEGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2879980", Offset = "0x2878980", VA = "0x182879980", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3719F60", Offset = "0x3718F60", VA = "0x183719F60", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3719FA0", Offset = "0x3718FA0", VA = "0x183719FA0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3718DF0", Offset = "0x3717DF0", VA = "0x183718DF0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3719160", Offset = "0x3718160", VA = "0x183719160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3718E60", Offset = "0x3717E60", VA = "0x183718E60", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3719DE0", Offset = "0x3718DE0", VA = "0x183719DE0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3718CB0", Offset = "0x3717CB0", VA = "0x183718CB0", Slot = "9")]
	public void Add(TKey EBOIOCBODNI, TVal KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3718C40", Offset = "0x3717C40", VA = "0x183718C40", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> DKIDMLOAMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3718EC0", Offset = "0x3717EC0", VA = "0x183718EC0", Slot = "8")]
	public bool ContainsKey(TKey EBOIOCBODNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3718F20", Offset = "0x3717F20", VA = "0x183718F20", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> DKIDMLOAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3719D00", Offset = "0x3718D00", VA = "0x183719D00", Slot = "10")]
	public bool Remove(TKey EBOIOCBODNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3719D30", Offset = "0x3718D30", VA = "0x183719D30", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> DKIDMLOAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2524C00", Offset = "0x2523C00", VA = "0x182524C00", Slot = "11")]
	public bool TryGetValue(TKey EBOIOCBODNI, out TVal KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x260BD10", Offset = "0x260AD10", VA = "0x18260BD10", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3718F50", Offset = "0x3717F50", VA = "0x183718F50", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] EGIDMCNFHCK, int FMNFDAHCLKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3719290", Offset = "0x3718290", VA = "0x183719290")]
	public void GBJBCHALJOG(TVal LGHMENDDLFI, TKey EBOIOCBODNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3719310", Offset = "0x3718310", VA = "0x183719310")]
	public void GBJBCHALJOG(KeyValuePair<TVal, TKey> DKIDMLOAMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x37193C0", Offset = "0x37183C0", VA = "0x1837193C0")]
	public bool GFJJHOHDGEK(TVal EBOIOCBODNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3718DB0", Offset = "0x3717DB0", VA = "0x183718DB0")]
	public bool BNDEAHDJONI(KeyValuePair<TVal, TKey> DKIDMLOAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3719CC0", Offset = "0x3718CC0", VA = "0x183719CC0")]
	public bool PMMODKPOELK(TVal EBOIOCBODNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3719CC0", Offset = "0x3718CC0", VA = "0x183719CC0")]
	public bool PMMODKPOELK(KeyValuePair<TVal, TKey> DKIDMLOAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3719BF0", Offset = "0x3718BF0", VA = "0x183719BF0")]
	public bool OHBANFGHGGE(TVal EBOIOCBODNI, out TKey KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x37196B0", Offset = "0x37186B0", VA = "0x1837196B0")]
	public IEnumerator<KeyValuePair<TVal, TKey>> NDLLJJHKEEN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3719500", Offset = "0x3718500", VA = "0x183719500")]
	private void JKGBPLODBBA(TKey EBOIOCBODNI, TVal LGHMENDDLFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x37190C0", Offset = "0x37180C0", VA = "0x1837190C0")]
	private void DNKCPIGLHFN(TKey EBOIOCBODNI, TVal LGHMENDDLFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x37198C0", Offset = "0x37188C0", VA = "0x1837198C0")]
	private bool OCIGNPPKEFD(TKey EBOIOCBODNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3719990", Offset = "0x3718990", VA = "0x183719990")]
	private bool OCIGNPPKEFD(TVal LGHMENDDLFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x3719E80", Offset = "0x3718E80", VA = "0x183719E80")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x31EA820", Offset = "0x31E9820", VA = "0x1831EA820", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x31EBD00", Offset = "0x31EAD00", VA = "0x1831EBD00")]
		public Enumerator(global::OEMEBCEHENJ<T> BFNDINBALAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x31E8540", Offset = "0x31E7540", VA = "0x1831E8540", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x31E92D0", Offset = "0x31E82D0", VA = "0x1831E92D0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x31E6690", Offset = "0x31E5690", VA = "0x1831E6690")]
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
		[Cpp2IlInjected.Address(RVA = "0x250CFB0", Offset = "0x250BFB0", VA = "0x18250CFB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2E6D250", Offset = "0x2E6C250", VA = "0x182E6D250")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2E6DCB0", Offset = "0x2E6CCB0", VA = "0x182E6DCB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x250D070", Offset = "0x250C070", VA = "0x18250D070")]
	public OEMEBCEHENJ(int KNECCHHDDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2E6E4A0", Offset = "0x2E6D4A0", VA = "0x182E6E4A0")]
	public void GBJBCHALJOG(T JELHNILOKLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2E6D8D0", Offset = "0x2E6C8D0", VA = "0x182E6D8D0")]
	public void CMEPDJJCKOF(IEnumerable<T> ECLIJHMKGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x250CC60", Offset = "0x250BC60", VA = "0x18250CC60")]
	public void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x250CE30", Offset = "0x250BE30", VA = "0x18250CE30")]
	public void IEAKGEPKLBN(int KJAHKKMJHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x250CEC0", Offset = "0x250BEC0", VA = "0x18250CEC0")]
	public void JIFKBOCBNNG(int KJAHKKMJHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2E6DD30", Offset = "0x2E6CD30", VA = "0x182E6DD30")]
	public void FJCNJPIOPHM(T[] EGIDMCNFHCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2E6E660", Offset = "0x2E6D660", VA = "0x182E6E660")]
	public Enumerator KGLEFCHHJJI()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2E6E6A0", Offset = "0x2E6D6A0", VA = "0x182E6E6A0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2E6E6A0", Offset = "0x2E6D6A0", VA = "0x182E6E6A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2E6E210", Offset = "0x2E6D210", VA = "0x182E6E210")]
	private int GACEPCPJCDD(int EGBCAPEEJBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x250CF80", Offset = "0x250BF80", VA = "0x18250CF80")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0120", Offset = "0x6DF120", VA = "0x1806E0120")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6E0130", Offset = "0x6DF130", VA = "0x1806E0130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool NLCBLEMMOHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7CFFA0", Offset = "0x7CEFA0", VA = "0x1807CFFA0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x799190", Offset = "0x798190", VA = "0x180799190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public External IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x299F5A0", Offset = "0x299E5A0", VA = "0x18299F5A0", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x299F640", Offset = "0x299E640", VA = "0x18299F640", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int IIEJMBAKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x299F540", Offset = "0x299E540", VA = "0x18299F540", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x299F4B0", Offset = "0x299E4B0", VA = "0x18299F4B0")]
	public DDICFLKDMFA(Func<Internal, External> DKEBKHECPOH, Func<External, Internal> IICCJFLIFIF, bool BHCHPGOJODJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x299F280", Offset = "0x299E280", VA = "0x18299F280", Slot = "6")]
	public int IndexOf(External DKIDMLOAMGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x299EF00", Offset = "0x299DF00", VA = "0x18299EF00", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x299EF60", Offset = "0x299DF60", VA = "0x18299EF60", Slot = "13")]
	public bool Contains(External DKIDMLOAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x299EFF0", Offset = "0x299DFF0", VA = "0x18299EFF0", Slot = "14")]
	public void CopyTo(External[] EGIDMCNFHCK, int FMNFDAHCLKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x299EE10", Offset = "0x299DE10", VA = "0x18299EE10", Slot = "11")]
	public void Add(External DKIDMLOAMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x299F310", Offset = "0x299E310", VA = "0x18299F310", Slot = "7")]
	public void Insert(int EGBCAPEEJBF, External DKIDMLOAMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x299F420", Offset = "0x299E420", VA = "0x18299F420", Slot = "15")]
	public bool Remove(External DKIDMLOAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x299F3B0", Offset = "0x299E3B0", VA = "0x18299F3B0", Slot = "8")]
	public void RemoveAt(int EGBCAPEEJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x299F210", Offset = "0x299E210", VA = "0x18299F210", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x24CE670", Offset = "0x24CD670", VA = "0x1824CE670", Slot = "17")]
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
		[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6FF140", Offset = "0x6FE140", VA = "0x1806FF140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool NLCBLEMMOHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x700020", Offset = "0x6FF020", VA = "0x180700020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public External IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2EDB680", Offset = "0x2EDA680", VA = "0x182EDB680", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int IIEJMBAKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2EDB620", Offset = "0x2EDA620", VA = "0x182EDB620", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x20293C0", Offset = "0x20283C0", VA = "0x1820293C0")]
	public GNEPAHGNHPG(Func<Internal, External> DKEBKHECPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x2EDB5D0", Offset = "0x2EDA5D0", VA = "0x182EDB5D0")]
	public GNEPAHGNHPG(IReadOnlyList<Internal> EHJGMBFBLBN, Func<Internal, External> DKEBKHECPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2EDB340", Offset = "0x2EDA340", VA = "0x182EDB340")]
	public void FJCNJPIOPHM(External[] EGIDMCNFHCK, int FMNFDAHCLKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x2EDB560", Offset = "0x2EDA560", VA = "0x182EDB560", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x24EC330", Offset = "0x24EB330", VA = "0x1824EC330", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6FF130", Offset = "0x6FE130", VA = "0x1806FF130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool NLCBLEMMOHF
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x700020", Offset = "0x6FF020", VA = "0x180700020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public External IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x3A294F0", Offset = "0x3A284F0", VA = "0x183A294F0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int IIEJMBAKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x3A29490", Offset = "0x3A28490", VA = "0x183A29490", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x20293C0", Offset = "0x20283C0", VA = "0x1820293C0")]
	public BKNJAFJCJDE(IReadOnlyList<Internal> EHJGMBFBLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3A29150", Offset = "0x3A28150", VA = "0x183A29150")]
	public bool BNDEAHDJONI(External DKIDMLOAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3A291F0", Offset = "0x3A281F0", VA = "0x183A291F0")]
	public void FJCNJPIOPHM(External[] EGIDMCNFHCK, int FMNFDAHCLKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3A29420", Offset = "0x3A28420", VA = "0x183A29420", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x24CE670", Offset = "0x24CD670", VA = "0x1824CE670", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x28F1BE0", Offset = "0x28F0BE0", VA = "0x1828F1BE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x28F1D60", Offset = "0x28F0D60", VA = "0x1828F1D60")]
	protected GGHGPGPPBAO(bool LEGEPCDGHPF, bool OPNHNGBJAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x28F1830", Offset = "0x28F0830", VA = "0x1828F1830")]
	protected bool EJKLFLOGMML()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x28F18B0", Offset = "0x28F08B0", VA = "0x1828F18B0")]
	protected void FIIPKGDHFIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x28F1680", Offset = "0x28F0680", VA = "0x1828F1680")]
	protected void ACFMFIDCDHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x35AE9C0", Offset = "0x35AD9C0", VA = "0x1835AE9C0")]
	private static void MNLFPNCFHGO<U>(ref List<U> EHJGMBFBLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x28F1A80", Offset = "0x28F0A80", VA = "0x1828F1A80", Slot = "5")]
	public void GBJBCHALJOG(T FFBLFKDINEA, bool JBDBKMNFMEB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x28F1C20", Offset = "0x28F0C20", VA = "0x1828F1C20", Slot = "6")]
	public void PMMODKPOELK(T FFBLFKDINEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x28F1970", Offset = "0x28F0970", VA = "0x1828F1970")]
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
	[Cpp2IlInjected.Address(RVA = "0x6529450", Offset = "0x6528450", VA = "0x186529450")]
	public AMNHKKJOBOK(bool LEGEPCDGHPF = false, bool OPNHNGBJAFB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6529110", Offset = "0x6528110", VA = "0x186529110")]
	public void AFNFHFOAJEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x65293E0", Offset = "0x65283E0", VA = "0x1865293E0", Slot = "4")]
	public override void PACAOCPMOIG(object[] KCPODLJODHA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6529380", Offset = "0x6528380", VA = "0x186529380")]
	public static AMNHKKJOBOK IIADFPNECJL(AMNHKKJOBOK KJOEIKMJJCJ, Action FFBLFKDINEA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6529320", Offset = "0x6528320", VA = "0x186529320")]
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
	[Cpp2IlInjected.Address(RVA = "0x251E2B0", Offset = "0x251D2B0", VA = "0x18251E2B0")]
	public OKNKFJGELPL(bool LEGEPCDGHPF = false, bool OPNHNGBJAFB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x251AEE0", Offset = "0x2519EE0", VA = "0x18251AEE0")]
	public void AFNFHFOAJEB(T JELHNILOKLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x251C4C0", Offset = "0x251B4C0", VA = "0x18251C4C0", Slot = "4")]
	public override void PACAOCPMOIG(object[] KCPODLJODHA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x251C420", Offset = "0x251B420", VA = "0x18251C420")]
	public static global::OKNKFJGELPL<T> IIADFPNECJL(global::OKNKFJGELPL<T> KJOEIKMJJCJ, Action<T> FFBLFKDINEA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x251C380", Offset = "0x251B380", VA = "0x18251C380")]
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
	[Cpp2IlInjected.Address(RVA = "0x251E2B0", Offset = "0x251D2B0", VA = "0x18251E2B0")]
	public BJDCJLPDAMP(bool LEGEPCDGHPF = false, bool OPNHNGBJAFB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3A1FB90", Offset = "0x3A1EB90", VA = "0x183A1FB90")]
	public void AFNFHFOAJEB(T JELHNILOKLO, U JBPOPNPHJBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3A20150", Offset = "0x3A1F150", VA = "0x183A20150", Slot = "4")]
	public override void PACAOCPMOIG(object[] KCPODLJODHA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x3A200B0", Offset = "0x3A1F0B0", VA = "0x183A200B0")]
	public static global::BJDCJLPDAMP<T, U> IIADFPNECJL(global::BJDCJLPDAMP<T, U> KJOEIKMJJCJ, Action<T, U> FFBLFKDINEA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x3A20010", Offset = "0x3A1F010", VA = "0x183A20010")]
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
	[Cpp2IlInjected.Address(RVA = "0x251E2B0", Offset = "0x251D2B0", VA = "0x18251E2B0")]
	public MHKIEOOGPNK(bool LEGEPCDGHPF = false, bool OPNHNGBJAFB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x3CD42A0", Offset = "0x3CD32A0", VA = "0x183CD42A0")]
	public void AFNFHFOAJEB(T JELHNILOKLO, U JBPOPNPHJBO, V APLGHPJFDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x3CD6C30", Offset = "0x3CD5C30", VA = "0x183CD6C30", Slot = "4")]
	public override void PACAOCPMOIG(object[] KCPODLJODHA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3CD5250", Offset = "0x3CD4250", VA = "0x183CD5250")]
	public static global::MHKIEOOGPNK<T, U, V> IIADFPNECJL(global::MHKIEOOGPNK<T, U, V> KJOEIKMJJCJ, Action<T, U, V> FFBLFKDINEA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3CD51B0", Offset = "0x3CD41B0", VA = "0x183CD51B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x251E2B0", Offset = "0x251D2B0", VA = "0x18251E2B0")]
	public HIHJFNDPAIF(bool LEGEPCDGHPF = false, bool OPNHNGBJAFB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3361070", Offset = "0x3360070", VA = "0x183361070")]
	public void AFNFHFOAJEB(T JELHNILOKLO, U JBPOPNPHJBO, V APLGHPJFDAI, W GMOOOEOGNJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x33616F0", Offset = "0x33606F0", VA = "0x1833616F0", Slot = "4")]
	public override void PACAOCPMOIG(object[] KCPODLJODHA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x3361380", Offset = "0x3360380", VA = "0x183361380")]
	public static global::HIHJFNDPAIF<T, U, V, W> IIADFPNECJL(global::HIHJFNDPAIF<T, U, V, W> KJOEIKMJJCJ, Action<T, U, V, W> FFBLFKDINEA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x33612E0", Offset = "0x33602E0", VA = "0x1833612E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x251E2B0", Offset = "0x251D2B0", VA = "0x18251E2B0")]
	public DENPHMPGDBO(bool LEGEPCDGHPF = false, bool OPNHNGBJAFB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x299FC00", Offset = "0x299EC00", VA = "0x18299FC00")]
	public void AFNFHFOAJEB(T JELHNILOKLO, U JBPOPNPHJBO, V APLGHPJFDAI, W GMOOOEOGNJK, X PMEDGJGANML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x29A02F0", Offset = "0x299F2F0", VA = "0x1829A02F0", Slot = "4")]
	public override void PACAOCPMOIG(object[] KCPODLJODHA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x299FF30", Offset = "0x299EF30", VA = "0x18299FF30")]
	public static global::DENPHMPGDBO<T, U, V, W, X> IIADFPNECJL(global::DENPHMPGDBO<T, U, V, W, X> KJOEIKMJJCJ, Action<T, U, V, W, X> FFBLFKDINEA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x299FE90", Offset = "0x299EE90", VA = "0x18299FE90")]
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
	[Cpp2IlInjected.Address(RVA = "0x251E2B0", Offset = "0x251D2B0", VA = "0x18251E2B0")]
	public COOBDIJLNAL(bool LEGEPCDGHPF = false, bool OPNHNGBJAFB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2EEF2F0", Offset = "0x2EEE2F0", VA = "0x182EEF2F0")]
	public void AFNFHFOAJEB(T JELHNILOKLO, U JBPOPNPHJBO, V APLGHPJFDAI, W GMOOOEOGNJK, X PMEDGJGANML, Y NIPKEFBPNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x2EF0020", Offset = "0x2EEF020", VA = "0x182EF0020", Slot = "4")]
	public override void PACAOCPMOIG(object[] KCPODLJODHA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2EEFC10", Offset = "0x2EEEC10", VA = "0x182EEFC10")]
	public static global::COOBDIJLNAL<T, U, V, W, X, Y> IIADFPNECJL(global::COOBDIJLNAL<T, U, V, W, X, Y> KJOEIKMJJCJ, Action<T, U, V, W, X, Y> FFBLFKDINEA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x2EEFB70", Offset = "0x2EEEB70", VA = "0x182EEFB70")]
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
			[Cpp2IlInjected.Address(RVA = "0x24D09C0", Offset = "0x24CF9C0", VA = "0x1824D09C0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x24D09E0", Offset = "0x24CF9E0", VA = "0x1824D09E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8B5D70", Offset = "0x8B4D70", VA = "0x1808B5D70")]
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
		[Cpp2IlInjected.Address(RVA = "0x29FEBF0", Offset = "0x29FDBF0", VA = "0x1829FEBF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x1D57180", Offset = "0x1D56180", VA = "0x181D57180", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x347FED0", Offset = "0x347EED0", VA = "0x18347FED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x1D57180", Offset = "0x1D56180", VA = "0x181D57180", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x221AD50", Offset = "0x2219D50", VA = "0x18221AD50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x221ADA0", Offset = "0x2219DA0", VA = "0x18221ADA0")]
	public CEIIPCHPNJC(in T NDMDBDBHNJA, int AFHNPPODHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x221AD70", Offset = "0x2219D70", VA = "0x18221AD70")]
	public CEIIPCHPNJC(in T NDMDBDBHNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x221A730", Offset = "0x2219730", VA = "0x18221A730")]
	public AHLKCJLELCI CAKHMFMNJDD()
	{
		return default(AHLKCJLELCI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x221A770", Offset = "0x2219770", VA = "0x18221A770")]
	public AHLKCJLELCI CAKHMFMNJDD(CancellationToken ANIIOKLMHLI)
	{
		return default(AHLKCJLELCI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x221A7B0", Offset = "0x22197B0", VA = "0x18221A7B0")]
	[AsyncStateMachine(typeof(global::CEIIPCHPNJC<>.BFLGDBHMGND))]
	public Task<AHLKCJLELCI> IHKDHGBGKKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x221A910", Offset = "0x2219910", VA = "0x18221A910")]
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
	[Cpp2IlInjected.Address(RVA = "0x652E620", Offset = "0x652D620", VA = "0x18652E620")]
	public static global::CEIIPCHPNJC<ADEHAJBPFKB> CCFMECMIHDM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x652E5B0", Offset = "0x652D5B0", VA = "0x18652E5B0")]
	public static global::CEIIPCHPNJC<ADEHAJBPFKB> CCFMECMIHDM(int AFHNPPODHNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x1764620", Offset = "0x1763620", VA = "0x181764620")]
	public static global::CEIIPCHPNJC<T> CCFMECMIHDM<T>(in T NDMDBDBHNJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x22353F0", Offset = "0x22343F0", VA = "0x1822353F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x31D6470", Offset = "0x31D5470", VA = "0x1831D6470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TimeSpan DDHKBONDNEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x31D6550", Offset = "0x31D5550", VA = "0x1831D6550")]
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
		[Cpp2IlInjected.Address(RVA = "0x110B0E0", Offset = "0x110A0E0", VA = "0x18110B0E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x10FDE40", Offset = "0x10FCE40", VA = "0x1810FDE40")]
		public DBAOAKEEGJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2029390", Offset = "0x2028390", VA = "0x182029390")]
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
		[Cpp2IlInjected.Address(RVA = "0x24CD350", Offset = "0x24CC350", VA = "0x1824CD350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6E7320", Offset = "0x6E6320", VA = "0x1806E7320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2907D80", Offset = "0x2906D80", VA = "0x182907D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6E7320", Offset = "0x6E6320", VA = "0x1806E7320", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C73B80", Offset = "0x2C72B80", VA = "0x182C73B80")]
	public HGPOCIPMKLB(AKCHPLEKCJI MNEMHNDIPFI, [Optional] MCDIIDOFMCK GPCMGPIDCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2C73530", Offset = "0x2C72530", VA = "0x182C73530")]
	public Task<TResult> PCHHADECPGF(TRequest LPOCBPNMNHF, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2C720E0", Offset = "0x2C710E0", VA = "0x182C720E0")]
	private void CDMBJKMIJKC(ILIINFPFPPP PLNILFDALDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2C72AF0", Offset = "0x2C71AF0", VA = "0x182C72AF0")]
	[AsyncStateMachine(typeof(global::HGPOCIPMKLB<, >.AGNEIGDDGNG))]
	private Task EAJFHODJKLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2C72760", Offset = "0x2C71760", VA = "0x182C72760")]
	private ILIINFPFPPP DKMCAJNFHJB()
	{
		return default(ILIINFPFPPP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x2C72CF0", Offset = "0x2C71CF0", VA = "0x182C72CF0")]
	[AsyncStateMachine(typeof(global::HGPOCIPMKLB<, >.FJKHMBFNPNI))]
	private Task EDOBCDCADCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x2C73050", Offset = "0x2C72050", VA = "0x182C73050")]
	private void JOILBCHNAOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x2C729B0", Offset = "0x2C719B0", VA = "0x182C729B0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E97B20", Offset = "0x2E96B20", VA = "0x182E97B20", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal int KOADAMFCACE
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2E97B50", Offset = "0x2E96B50", VA = "0x182E97B50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public override int IIEJMBAKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2E97CC0", Offset = "0x2E96CC0", VA = "0x182E97CC0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x2E97FD0", Offset = "0x2E96FD0", VA = "0x182E97FD0")]
	public IBGOFOGAKAB(int KNECCHHDDJH, [Optional] CFCLNHDJEGH CGIEPPMHLMK, [Optional] IEqualityComparer<TKey> IFENNNCDFOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x2E97C20", Offset = "0x2E96C20", VA = "0x182E97C20")]
	public void MPKDOIPPJCF(TKey EBOIOCBODNI, TVal KPPLMEOMNGF, bool JPHJFEDHIFN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x2E97AA0", Offset = "0x2E96AA0", VA = "0x182E97AA0")]
	public bool ICENGNLALKG(TKey EBOIOCBODNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x2E97F30", Offset = "0x2E96F30", VA = "0x182E97F30", Slot = "6")]
	public override bool OHBANFGHGGE(TKey JAFJDPHMLKF, out TVal KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x2E97D20", Offset = "0x2E96D20", VA = "0x182E97D20")]
	public bool OABEJPGAFLB(TKey EBOIOCBODNI, TVal KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x2E97920", Offset = "0x2E96920", VA = "0x182E97920")]
	public bool DNBEMAOIKEO(TKey EBOIOCBODNI, TVal KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x2E97A30", Offset = "0x2E96A30", VA = "0x182E97A30", Slot = "7")]
	public override void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x2E97B80", Offset = "0x2E96B80", VA = "0x182E97B80")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE53C0", Offset = "0xCE43C0", VA = "0x180CE53C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E0120", Offset = "0x6DF120", VA = "0x1806E0120")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x6E0130", Offset = "0x6DF130", VA = "0x1806E0130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public int MDNIDCCLGIH
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x7011B0", Offset = "0x7001B0", VA = "0x1807011B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xA22B00", Offset = "0xA21B00", VA = "0x180A22B00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public DateTime IILOJKHJAOA
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x6F56F0", Offset = "0x6F46F0", VA = "0x1806F56F0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0xDD81D0", Offset = "0xDD71D0", VA = "0x180DD81D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x347CC10", Offset = "0x347BC10", VA = "0x18347CC10")]
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
		[Cpp2IlInjected.Address(RVA = "0x6DF020", Offset = "0x6DE020", VA = "0x1806DF020")]
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
		[Cpp2IlInjected.Address(RVA = "0x41F58F0", Offset = "0x41F48F0", VA = "0x1841F58F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal virtual int EFFHHIFFELC
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x934FD0", Offset = "0x933FD0", VA = "0x180934FD0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private int KJAHKKMJHHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x10FEAD0", Offset = "0x10FDAD0", VA = "0x1810FEAD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public virtual int IIEJMBAKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x220D890", Offset = "0x220C890", VA = "0x18220D890", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public IEnumerable<TKey> NPJDPOGBILC
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x41F7F20", Offset = "0x41F6F20", VA = "0x1841F7F20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public TVal IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x41F6100", Offset = "0x41F5100", VA = "0x1841F6100")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x29B5B80", Offset = "0x29B4B80", VA = "0x1829B5B80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x41F8FB0", Offset = "0x41F7FB0", VA = "0x1841F8FB0")]
	public FDAJJEOIJNC(int KNECCHHDDJH, [Optional] CFCLNHDJEGH CGIEPPMHLMK, [Optional] IEqualityComparer<TKey> IFENNNCDFOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x41F8DC0", Offset = "0x41F7DC0", VA = "0x1841F8DC0")]
	public FDAJJEOIJNC(TimeSpan AJHFCAAECNO, [Optional] IEqualityComparer<TKey> IFENNNCDFOA, [Optional] DBDNLIGDGMG LAOHJPNFPHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x41F8AF0", Offset = "0x41F7AF0", VA = "0x1841F8AF0")]
	public FDAJJEOIJNC(int KNECCHHDDJH, TimeSpan AJHFCAAECNO, [Optional] IEqualityComparer<TKey> IFENNNCDFOA, [Optional] DBDNLIGDGMG LAOHJPNFPHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x41F93D0", Offset = "0x41F83D0", VA = "0x1841F93D0")]
	public FDAJJEOIJNC(int KNECCHHDDJH, CFCLNHDJEGH CGIEPPMHLMK, TimeSpan AJHFCAAECNO, [Optional] IEqualityComparer<TKey> IFENNNCDFOA, [Optional] DBDNLIGDGMG LAOHJPNFPHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x41F5AF0", Offset = "0x41F4AF0", VA = "0x1841F5AF0")]
	public void AIADDINDGCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x41F7E40", Offset = "0x41F6E40", VA = "0x1841F7E40")]
	public void JPNFGACMGOG(TKey EBOIOCBODNI, TVal KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x41F8980", Offset = "0x41F7980", VA = "0x1841F8980")]
	public bool PMMODKPOELK(TKey EBOIOCBODNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x41F5E80", Offset = "0x41F4E80", VA = "0x1841F5E80")]
	private TVal BOEAFIEBIHC(TKey JAFJDPHMLKF)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x41F8140", Offset = "0x41F7140", VA = "0x1841F8140", Slot = "6")]
	public virtual bool OHBANFGHGGE(TKey JAFJDPHMLKF, out TVal KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x41F6A50", Offset = "0x41F5A50", VA = "0x1841F6A50", Slot = "7")]
	public virtual void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x41F72D0", Offset = "0x41F62D0", VA = "0x1841F72D0")]
	private bool JFMJPMOEPOM(PNHHPNLGDOL DBHMANJEIFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x41F6800", Offset = "0x41F5800", VA = "0x1841F6800")]
	private void CPAGFDKFLNO(LinkedListNode<PNHHPNLGDOL> DNJFPCMOOIN, TVal GLLAKMPHGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x41F7630", Offset = "0x41F6630", VA = "0x1841F7630")]
	private void JPJHPPMDCBA(TKey EBOIOCBODNI, TVal KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x41F6E00", Offset = "0x41F5E00", VA = "0x1841F6E00")]
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
		[Cpp2IlInjected.Address(RVA = "0x2029390", Offset = "0x2028390", VA = "0x182029390", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool NLCBLEMMOHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x6E2D00", Offset = "0x6E1D00", VA = "0x1806E2D00", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public T IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2822330", Offset = "0x2821330", VA = "0x182822330", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x29A8630", Offset = "0x29A7630", VA = "0x1829A8630", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x29A7D90", Offset = "0x29A6D90", VA = "0x1829A7D90", Slot = "11")]
	public void Add(T DKIDMLOAMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x29A7C40", Offset = "0x29A6C40", VA = "0x1829A7C40")]
	public bool APHPNPEMCLE(T DKIDMLOAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x29A8410", Offset = "0x29A7410", VA = "0x1829A8410", Slot = "15")]
	public bool Remove(T DKIDMLOAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x2524B50", Offset = "0x2523B50", VA = "0x182524B50", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x2219830", Offset = "0x2218830", VA = "0x182219830", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x29A7DC0", Offset = "0x29A6DC0", VA = "0x1829A7DC0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x23B9E20", Offset = "0x23B8E20", VA = "0x1823B9E20", Slot = "13")]
	public bool Contains(T DKIDMLOAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x29A7E20", Offset = "0x29A6E20", VA = "0x1829A7E20", Slot = "14")]
	public void CopyTo(T[] EGIDMCNFHCK, int FMNFDAHCLKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x29A7E50", Offset = "0x29A6E50", VA = "0x1829A7E50", Slot = "6")]
	public int IndexOf(T DKIDMLOAMGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x29A7E80", Offset = "0x29A6E80", VA = "0x1829A7E80", Slot = "7")]
	public void Insert(int EGBCAPEEJBF, T DKIDMLOAMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x29A81E0", Offset = "0x29A71E0", VA = "0x1829A81E0", Slot = "8")]
	public void RemoveAt(int EGBCAPEEJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x29A8010", Offset = "0x29A7010", VA = "0x1829A8010")]
	public void KCFEMAHCNFC(Predicate<T> ELLKBPHIOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x29A81B0", Offset = "0x29A71B0", VA = "0x1829A81B0")]
	public void OIEPKIMNLDG(Comparison<T> JHEBLNIDFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x29A8490", Offset = "0x29A7490", VA = "0x1829A8490")]
	public DGLBFKEJDAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class GOBHHIGLMGD
{
	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x652B820", Offset = "0x652A820", VA = "0x18652B820")]
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
			[Cpp2IlInjected.Address(RVA = "0x2FB6F30", Offset = "0x2FB5F30", VA = "0x182FB6F30")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x6532740", Offset = "0x6531740", VA = "0x186532740")]
		public SerializedGuid(in Guid DBODHDCBMLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x65324C0", Offset = "0x65314C0", VA = "0x1865324C0")]
		public static SerializedGuid IJJLMEBIKJO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x6532550", Offset = "0x6531550", VA = "0x186532550")]
		public static SerializedGuid LHLJCCBFLCJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x6532260", Offset = "0x6531260", VA = "0x186532260")]
		public bool CFLJFFCDDJL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x6532710", Offset = "0x6531710", VA = "0x186532710", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x6532670", Offset = "0x6531670", VA = "0x186532670", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x65325E0", Offset = "0x65315E0", VA = "0x1865325E0")]
		public bool OGHMKNDIAJH(in Guid DBODHDCBMLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x6532320", Offset = "0x6531320", VA = "0x186532320", Slot = "7")]
		public bool Equals(SerializedGuid JHMCLPBFJBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x65323D0", Offset = "0x65313D0", VA = "0x1865323D0", Slot = "0")]
		public override bool Equals(object AELIHOPICED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x65324B0", Offset = "0x65314B0", VA = "0x1865324B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x65322F0", Offset = "0x65312F0", VA = "0x1865322F0", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x652B370", Offset = "0x652A370", VA = "0x18652B370")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F56F0", Offset = "0x6F46F0", VA = "0x1806F56F0", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x1102ED0", Offset = "0x1101ED0", VA = "0x181102ED0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool FNEFGEAJLED
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x7AA560", Offset = "0x7A9560", VA = "0x1807AA560", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string LMOKLBIBGKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F88E0", VA = "0x1806F98E0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x1AAC180", Offset = "0x1AAB180", VA = "0x181AAC180", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x20A7C70", Offset = "0x20A6C70", VA = "0x1820A7C70")]
	private void NJAFIFNAEFP(T OBBOCNIOLOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x20A7B10", Offset = "0x20A6B10", VA = "0x1820A7B10")]
	private void HLHIGOAHNDB(string GOMILMNIGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x20A7BC0", Offset = "0x20A6BC0", VA = "0x1820A7BC0")]
	public void IKINEIFADPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x20A7A50", Offset = "0x20A6A50", VA = "0x1820A7A50", Slot = "6")]
	public global::LLIMMBAHHCD<T> BDDNKFFNJFO(Action<T, T> LDCBNEEBIEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x20A7DA0", Offset = "0x20A6DA0", VA = "0x1820A7DA0", Slot = "7")]
	public global::LLIMMBAHHCD<T> OJEBDEPAIPD(Action<T, T> LDCBNEEBIEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x20A7D10", Offset = "0x20A6D10", VA = "0x1820A7D10", Slot = "4")]
	public global::LLIMMBAHHCD<T> OINNAEPBHKF(Action<T> LDCBNEEBIEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x20A7DF0", Offset = "0x20A6DF0", VA = "0x1820A7DF0", Slot = "5")]
	public global::LLIMMBAHHCD<T> OMFFPPHPCCG(Action<T> NDDKAFJABEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x20A7E40", Offset = "0x20A6E40", VA = "0x1820A7E40", Slot = "8")]
	public global::LLIMMBAHHCD<T> PIGMIOJKHEM(Action<string> FCDNDBBKDGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x20A7AA0", Offset = "0x20A6AA0", VA = "0x1820A7AA0", Slot = "9")]
	public global::LLIMMBAHHCD<T> GHDFFHENGHJ(Action<string> FCDNDBBKDGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x20A7EE0", Offset = "0x20A6EE0", VA = "0x1820A7EE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x10FDE40", Offset = "0x10FCE40", VA = "0x1810FDE40")]
		public EHBEFKKDGKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x2E160F0", Offset = "0x2E150F0", VA = "0x182E160F0")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x2478DB0", Offset = "0x2477DB0", VA = "0x182478DB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x10FE040", Offset = "0x10FD040", VA = "0x1810FE040")]
		public IGHABDLGAKI(long DFAJCDNCKCP, int OODPELJGEFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x10FE0B0", Offset = "0x10FD0B0", VA = "0x1810FE0B0")]
		public IGHABDLGAKI(long DFAJCDNCKCP, long ACGICELBFMG, int OODPELJGEFJ, int MCIFLELHFJK, bool DAGLEMHEBPF, string PLKFKNKNNEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x10FDE80", Offset = "0x10FCE80", VA = "0x1810FDE80")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void FHKFEGDMBFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x10FDF80", Offset = "0x10FCF80", VA = "0x1810FDF80")]
		public int KAFLKCHAPLH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x10FDE60", Offset = "0x10FCE60", VA = "0x1810FDE60")]
		public int FFONFNEMCOH(int HBLDLJGGFFF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x10FDFD0", Offset = "0x10FCFD0", VA = "0x1810FDFD0")]
		public double LLJPDHFOPPP()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x10FDEF0", Offset = "0x10FCEF0", VA = "0x1810FDEF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x20B8830", Offset = "0x20B7830", VA = "0x1820B8830")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x24E8B70", Offset = "0x24E7B70", VA = "0x1824E8B70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public IEnumerable<OEPFOLMCINK> BIMGCBEFPGI
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x250D220", Offset = "0x250C220", VA = "0x18250D220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public IGHABDLGAKI IJHHPHDPOFG
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x16F5D40", Offset = "0x16F4D40", VA = "0x1816F5D40")]
			[CompilerGenerated]
			get
			{
				return default(IGHABDLGAKI);
			}
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x250D4D0", Offset = "0x250C4D0", VA = "0x18250D4D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x250D500", Offset = "0x250C500", VA = "0x18250D500")]
		internal OEPFOLMCINK(global::AOKCPNNMNJG<TKey> GGLDKMHDNCA, TKey EBOIOCBODNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x250D110", Offset = "0x250C110", VA = "0x18250D110")]
		public OEPFOLMCINK CACMKGMHMLE(TKey EBOIOCBODNI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x250D3F0", Offset = "0x250C3F0", VA = "0x18250D3F0")]
		public void MHJKIIEGCDH(TKey EBOIOCBODNI, Action<OEPFOLMCINK> FFBLFKDINEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x26387E0", Offset = "0x26377E0", VA = "0x1826387E0")]
		public T MHJKIIEGCDH<T>(TKey EBOIOCBODNI, Func<OEPFOLMCINK, T> EGHDMBPEGFF)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x2638670", Offset = "0x2637670", VA = "0x182638670")]
		[AsyncStateMachine(typeof(GJKKGOMJFCC))]
		public Task<T> LIELANMHGDA<T>(TKey EBOIOCBODNI, Func<OEPFOLMCINK, Task<T>> EGHDMBPEGFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x250D240", Offset = "0x250C240", VA = "0x18250D240", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3508670", Offset = "0x3507670", VA = "0x183508670", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x35086E0", Offset = "0x35076E0", VA = "0x1835086E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x3508790", Offset = "0x3507790", VA = "0x183508790")]
		[DebuggerHidden]
		public AAJKDHADGOI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D3F0", Offset = "0x2B3C3F0", VA = "0x182B3D3F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x3508300", Offset = "0x3507300", VA = "0x183508300", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x3508740", Offset = "0x3507740", VA = "0x183508740")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x35086A0", Offset = "0x35076A0", VA = "0x1835086A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x35085B0", Offset = "0x35075B0", VA = "0x1835085B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, IGHABDLGAKI)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x2B56C50", Offset = "0x2B55C50", VA = "0x182B56C50", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x3508670", Offset = "0x3507670", VA = "0x183508670", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x3FF0090", Offset = "0x3FEF090", VA = "0x183FF0090", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x3508790", Offset = "0x3507790", VA = "0x183508790")]
		[DebuggerHidden]
		public JOAHKLCPLMP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x3FF00F0", Offset = "0x3FEF0F0", VA = "0x183FF00F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x3FEF9D0", Offset = "0x3FEE9D0", VA = "0x183FEF9D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3FF0190", Offset = "0x3FEF190", VA = "0x183FF0190")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x3FF01F0", Offset = "0x3FEF1F0", VA = "0x183FF01F0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3FF0050", Offset = "0x3FEF050", VA = "0x183FF0050", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x3FEFF70", Offset = "0x3FEEF70", VA = "0x183FEFF70", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, IGHABDLGAKI)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x387C320", Offset = "0x387B320", VA = "0x18387C320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F88E0", VA = "0x1806F98E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6DF0D0", Offset = "0x6DE0D0", VA = "0x1806DF0D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3E257E0", Offset = "0x3E247E0", VA = "0x183E257E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public long HMOHDCAKFKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3E259A0", Offset = "0x3E249A0", VA = "0x183E259A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int GBPGLODGBJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3E25950", Offset = "0x3E24950", VA = "0x183E25950")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x3E25B20", Offset = "0x3E24B20", VA = "0x183E25B20")]
	public AOKCPNNMNJG(TKey BBHNDIDHLFD, [Optional] int? OODPELJGEFJ, [Optional][CanBeNull] Stopwatch PKADFIOHLGK, [Optional] Action<TKey, IGHABDLGAKI> NOFOBODAHNP, [Optional] Action<TKey, IGHABDLGAKI> JOGOMHAPJHK, [Optional] Action<global::AOKCPNNMNJG<TKey>> DCJCHJDICAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x3E258C0", Offset = "0x3E248C0", VA = "0x183E258C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x3E25980", Offset = "0x3E24980", VA = "0x183E25980")]
	public void JIGPOMNNKDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x3E257C0", Offset = "0x3E247C0", VA = "0x183E257C0")]
	public void BEGIGECCIDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x3E259C0", Offset = "0x3E249C0", VA = "0x183E259C0")]
	[IteratorStateMachine(typeof(global::AOKCPNNMNJG<>.AAJKDHADGOI))]
	public IEnumerable<(TKey, List<TKey>, IGHABDLGAKI)> NDCBCJJHFKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x3E25A50", Offset = "0x3E24A50", VA = "0x183E25A50")]
	[IteratorStateMachine(typeof(global::AOKCPNNMNJG<>.JOAHKLCPLMP))]
	private IEnumerable<(TKey, List<TKey>, IGHABDLGAKI)> NDCBCJJHFKI(List<TKey> NEIBENCLOEC, OEPFOLMCINK GEJGLIEIBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x3E25840", Offset = "0x3E24840", VA = "0x183E25840")]
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
	[Cpp2IlInjected.Address(RVA = "0x10FDE40", Offset = "0x10FCE40", VA = "0x1810FDE40")]
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
	[Cpp2IlInjected.Address(RVA = "0x24CE600", Offset = "0x24CD600", VA = "0x1824CE600")]
	protected string PBKBDMEPBCL(double FGPMDIPMDJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x24CE3C0", Offset = "0x24CD3C0", VA = "0x1824CE3C0")]
	protected string IJFDHBODBKK(int DKAJDLCKJED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x24CE380", Offset = "0x24CD380", VA = "0x1824CE380")]
	private static string GFOMLEKPIBK(TKey EBOIOCBODNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x24CE420", Offset = "0x24CD420", VA = "0x1824CE420", Slot = "4")]
	public override string OKCHPNFGGFF(global::AOKCPNNMNJG<TKey> GGLDKMHDNCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x24CE4D0", Offset = "0x24CD4D0", VA = "0x1824CE4D0")]
	public string OKCHPNFGGFF(global::AOKCPNNMNJG<TKey> GGLDKMHDNCA, [NotNull] KHKOOJLDACG ALPJMJFLNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string HAJMMKEECKI(global::AOKCPNNMNJG<TKey> GGLDKMHDNCA, [NotNull] KHKOOJLDACG ALPJMJFLNMM);

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x24CE670", Offset = "0x24CD670", VA = "0x1824CE670")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B5A620", Offset = "0x2B59620", VA = "0x182B5A620")]
	private static string GFOMLEKPIBK(TKey EBOIOCBODNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x2B5B060", Offset = "0x2B5A060", VA = "0x182B5B060")]
	public KMBKIIPODPF(string GJIIFDFIMGF = "F2", double FKIHNLKBPCG = double.MaxValue, bool PFKFNKFJPBK = false, int AHBDHJHHGPF = int.MaxValue, [Optional] ISet<string> JOCDABCOIJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x2B5AE00", Offset = "0x2B59E00", VA = "0x182B5AE00", Slot = "4")]
	public override Dictionary<string, string> OKCHPNFGGFF(global::AOKCPNNMNJG<TKey> GGLDKMHDNCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x2B5A660", Offset = "0x2B59660", VA = "0x182B5A660")]
	private bool JNBDBACHDKA(string KFCDEDEPPEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x2B5A8C0", Offset = "0x2B598C0", VA = "0x182B5A8C0")]
	public Dictionary<string, string> OKCHPNFGGFF(global::AOKCPNNMNJG<TKey> GGLDKMHDNCA, CFJKKNGLMPO ALPJMJFLNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x2B5AEB0", Offset = "0x2B59EB0", VA = "0x182B5AEB0")]
	private string PCAFGGEAGBB(StringBuilder JABLIKHPKOG, List<TKey> IOGLGGHMEOG, CFJKKNGLMPO ALPJMJFLNMM, bool BBANPHLKJEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x2B5A740", Offset = "0x2B59740", VA = "0x182B5A740")]
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
	[Cpp2IlInjected.Address(RVA = "0x3CD8C80", Offset = "0x3CD7C80", VA = "0x183CD8C80")]
	private MJPPDBOFGAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x3CD7BA0", Offset = "0x3CD6BA0", VA = "0x183CD7BA0", Slot = "5")]
	protected override string HAJMMKEECKI(global::AOKCPNNMNJG<TKey> GGLDKMHDNCA, KHKOOJLDACG ALPJMJFLNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x3CD8A90", Offset = "0x3CD7A90", VA = "0x183CD8A90")]
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
		[Cpp2IlInjected.Address(RVA = "0x10FDE40", Offset = "0x10FCE40", VA = "0x1810FDE40")]
		public GIKAHMJFIFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x10FE6A0", Offset = "0x10FD6A0", VA = "0x1810FE6A0")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x2B30AE0", Offset = "0x2B2FAE0", VA = "0x182B30AE0", Slot = "5")]
	protected override string HAJMMKEECKI(global::AOKCPNNMNJG<TKey> GGLDKMHDNCA, KHKOOJLDACG ALPJMJFLNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x2524D30", Offset = "0x2523D30", VA = "0x182524D30")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public EICJHCBNGDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x652A8D0", Offset = "0x65298D0", VA = "0x18652A8D0")]
		internal void <Wrap>b__0(global::AOKCPNNMNJG<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x652C3C0", Offset = "0x652B3C0", VA = "0x18652C3C0")]
	public IBLGNEAJGLI([Optional] string POIJPENPFCG, [Optional] int? OODPELJGEFJ, [Optional] Stopwatch PKADFIOHLGK, [Optional] Action<string, IGHABDLGAKI> NOFOBODAHNP, [Optional] Action<string, IGHABDLGAKI> JOGOMHAPJHK, [Optional] Action<IBLGNEAJGLI> DCJCHJDICAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x652C2E0", Offset = "0x652B2E0", VA = "0x18652C2E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x652B510", Offset = "0x652A510", VA = "0x18652B510")]
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
			[Cpp2IlInjected.Address(RVA = "0x652B570", Offset = "0x652A570", VA = "0x18652B570", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public override float AIHJKLDBDGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x652B500", Offset = "0x652A500", VA = "0x18652B500", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x652B660", Offset = "0x652A660", VA = "0x18652B660")]
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
		[Cpp2IlInjected.Address(RVA = "0x6529920", Offset = "0x6528920", VA = "0x186529920")]
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
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	protected DBDNLIGDGMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class JDMOBCIHMDG : global::MDHIPEMKMAC<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x652C6A0", Offset = "0x652B6A0", VA = "0x18652C6A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x1116660", Offset = "0x1115660", VA = "0x181116660", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public global::MLDKKGKEACN<T> AGFDPAJBNPH
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1AAC150", Offset = "0x1AAB150", VA = "0x181AAC150", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x31D6A90", Offset = "0x31D5A90", VA = "0x1831D6A90")]
	public MDHIPEMKMAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class GHDPPIGGHMN : global::HDABKLNFFOE<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x652B6C0", Offset = "0x652A6C0", VA = "0x18652B6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x1116660", Offset = "0x1115660", VA = "0x181116660", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public global::MLDKKGKEACN<T> AGFDPAJBNPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1AAC150", Offset = "0x1AAB150", VA = "0x181AAC150", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x2C6A990", Offset = "0x2C69990", VA = "0x182C6A990")]
	public HDABKLNFFOE(Exception CJDLKEIECEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x10FDE40", Offset = "0x10FCE40", VA = "0x1810FDE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	private Task OIMBOPHOMBK
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public global::MLDKKGKEACN<T> AGFDPAJBNPH
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1ABA160", Offset = "0x1AB9160", VA = "0x181ABA160", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool KCIOFPNPCCB
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x7CFFA0", Offset = "0x7CEFA0", VA = "0x1807CFFA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x222FB70", Offset = "0x222EB70", VA = "0x18222FB70")]
	static CILMDMPGCKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x222FE50", Offset = "0x222EE50", VA = "0x18222FE50")]
	protected CILMDMPGCKL(TTask JLDAGNIHKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x222F760", Offset = "0x222E760", VA = "0x18222F760", Slot = "1")]
	~CILMDMPGCKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x222F730", Offset = "0x222E730", VA = "0x18222F730", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x222F9A0", Offset = "0x222E9A0", VA = "0x18222F9A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x65300B0", Offset = "0x652F0B0", VA = "0x1865300B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x6530240", Offset = "0x652F240", VA = "0x186530240")]
		public NHIDECJNNEA(float GODLNPABGMH, float EICPOANFBCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x65300C0", Offset = "0x652F0C0", VA = "0x1865300C0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x4B8ED30", Offset = "0x4B8DD30", VA = "0x184B8ED30")]
		get
		{
			return default(NHIDECJNNEA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float PGLFPHBJPOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x652E680", Offset = "0x652D680", VA = "0x18652E680", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event KJDIACAJEOB NIBGBJMDFCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x652E940", Offset = "0x652D940", VA = "0x18652E940", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x652E880", Offset = "0x652D880", VA = "0x18652E880", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x652EF30", Offset = "0x652DF30", VA = "0x18652EF30")]
	public MNJNLMDKIDK(int KNECCHHDDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x652EA00", Offset = "0x652DA00", VA = "0x18652EA00")]
	public EMLBNLDNLCP KLKKPAABPDA(NHIDECJNNEA ECLIJHMKGIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x652EAE0", Offset = "0x652DAE0", VA = "0x18652EAE0")]
	public void LJKDJPEBNFB(LEAENOLLLJI OPJCHKIFEMC, [Optional] NHIDECJNNEA DMCKNHJGLPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x652EA90", Offset = "0x652DA90", VA = "0x18652EA90")]
	internal int LGFPODHHMBH(LEAENOLLLJI PKPPBEPNNDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x652E830", Offset = "0x652D830", VA = "0x18652E830")]
	internal NHIDECJNNEA ECGLAGFDBNO(int EGBCAPEEJBF)
	{
		return default(NHIDECJNNEA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x652E6A0", Offset = "0x652D6A0", VA = "0x18652E6A0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x6529080", Offset = "0x6528080", VA = "0x186529080")]
		public ABAAHGCFHCP(LEAENOLLLJI PKPPBEPNNDD, KJDIACAJEOB PEPHBHFBJFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x6529030", Offset = "0x6528030", VA = "0x186529030", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6529B70", Offset = "0x6528B70", VA = "0x186529B70")]
	internal static bool KNOANPICOKP(float BECDKHGLGNB, float ICPOAGANOLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x4915960", Offset = "0x4914960", VA = "0x184915960")]
	internal static float MLLOHGPPOBH(float BECDKHGLGNB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6529AB0", Offset = "0x6528AB0", VA = "0x186529AB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x11E0800", Offset = "0x11DF800", VA = "0x1811E0800", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x652AA00", Offset = "0x6529A00", VA = "0x18652AA00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event KJDIACAJEOB NIBGBJMDFCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x652AAC0", Offset = "0x6529AC0", VA = "0x18652AAC0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x652A960", Offset = "0x6529960", VA = "0x18652A960", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public EMLBNLDNLCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class PNJPFANKIGN
{
	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x6530C20", Offset = "0x652FC20", VA = "0x186530C20")]
	[NotNull]
	public static byte[] LLNJFMMLHLP(this CGDAMBLFNAM KBDMABOHOOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x6530BB0", Offset = "0x652FBB0", VA = "0x186530BB0")]
	[NotNull]
	public static byte[] LLNJFMMLHLP(this CGDAMBLFNAM KBDMABOHOOC, HashAlgorithmName CAPDDDMGJCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x6530880", Offset = "0x652F880", VA = "0x186530880")]
	public static bool DJNEPIDCIME([CanBeNull] this CGDAMBLFNAM KBDMABOHOOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x6530A10", Offset = "0x652FA10", VA = "0x186530A10")]
	public static bool DJNEPIDCIME([CanBeNull] this CGDAMBLFNAM KBDMABOHOOC, out string CNMFEBEOFOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x6530810", Offset = "0x652F810", VA = "0x186530810")]
	private static string CEKGLNDACLC([CanBeNull] byte[] FHNEBAPANCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x65306F0", Offset = "0x652F6F0", VA = "0x1865306F0")]
	private static bool BBOBJPGNAAG([NotNull] CGDAMBLFNAM KBDMABOHOOC, [CanBeNull] out byte[] ELDNFMCGGKK, [CanBeNull] out byte[] KNDBMBBODLK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public static class BDLFFABFBAO
{
	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6529510", Offset = "0x6528510", VA = "0x186529510")]
	[NotNull]
	public static byte[] LLNJFMMLHLP(this AHOCFCHKDAO POJEKDOFHBO, byte[] FEFOCPODKJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x6529550", Offset = "0x6528550", VA = "0x186529550")]
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
		[Cpp2IlInjected.Address(RVA = "0x6530030", Offset = "0x652F030", VA = "0x186530030")]
		public NBNJDPINMPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x652FFD0", Offset = "0x652EFD0", VA = "0x18652FFD0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2234450", Offset = "0x2233450", VA = "0x182234450")]
	[Conditional("UNITY_EDITOR")]
	private static void CPICBKMLIGP<T>(params T[] KEAADPCECLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x652E090", Offset = "0x652D090", VA = "0x18652E090")]
	public static IDisposable MINJHMJKJCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x652D400", Offset = "0x652C400", VA = "0x18652D400")]
	public static void ENINAIMIPFK(this IncrementalHash HMABPPNDNGC, [CanBeNull] GameObject BLPBCMIHDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x2234740", Offset = "0x2233740", VA = "0x182234740")]
	public static void ENINAIMIPFK<T>(this IncrementalHash HMABPPNDNGC, [CanBeNull] T NANIPOPDLDJ) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x2234810", Offset = "0x2233810", VA = "0x182234810")]
	public static void KGGCHJLAMBC<T>(this IncrementalHash HMABPPNDNGC, [CanBeNull] T POJEKDOFHBO) where T : AHOCFCHKDAO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x2234F90", Offset = "0x2233F90", VA = "0x182234F90")]
	public static void OMMBPEAOKHO<T>(this IncrementalHash HMABPPNDNGC, [CanBeNull] IList<T> IJMNPFBOFPM) where T : AHOCFCHKDAO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x652E300", Offset = "0x652D300", VA = "0x18652E300")]
	private static bool OHBCFIFJENL([CanBeNull] AHOCFCHKDAO POJEKDOFHBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x652D330", Offset = "0x652C330", VA = "0x18652D330")]
	public static void BLKKNPJJNCA(this IncrementalHash ADPFJJODLPO, [CanBeNull] string DONKGNOMNOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x652E130", Offset = "0x652D130", VA = "0x18652E130")]
	public static void NOFALNKKJJB(this IncrementalHash ADPFJJODLPO, long DGNBBNCNHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x652D900", Offset = "0x652C900", VA = "0x18652D900")]
	public static void IAADDELHEBL(this IncrementalHash ADPFJJODLPO, int IKPJHGONMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x652DAD0", Offset = "0x652CAD0", VA = "0x18652DAD0")]
	public static void JBBJBIOFOFE(this IncrementalHash ADPFJJODLPO, short IHNALLDMCEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x652DF20", Offset = "0x652CF20", VA = "0x18652DF20")]
	public static void MBKHPANBBOM(this IncrementalHash ADPFJJODLPO, byte KMOHBKCMBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x652D550", Offset = "0x652C550", VA = "0x18652D550")]
	public static void GKBGGKFLKOD(this IncrementalHash ADPFJJODLPO, bool MKDGJIEBIDF, bool NNNECADJFKJ = false, bool AGDMFBNKAND = false, bool AKHMHHPDILN = false, bool MDMKICLGFJE = false, bool LAILOMDDOFH = false, bool LKBMFMNDLFD = false, bool HHHJMHJGJAC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x22348A0", Offset = "0x22338A0", VA = "0x1822348A0")]
	public static void LMKNJJKGHMK<T>(this IncrementalHash ADPFJJODLPO, T GDHAKIDLDCD) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x652DEC0", Offset = "0x652CEC0", VA = "0x18652DEC0")]
	public static void LJDCDLKPGFH(this IncrementalHash ADPFJJODLPO, float FODDEKBLBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x652D4F0", Offset = "0x652C4F0", VA = "0x18652D4F0")]
	public static void GGCIPMGFLLL(this IncrementalHash ADPFJJODLPO, double IHGCLLAPGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x652D390", Offset = "0x652C390", VA = "0x18652D390")]
	public static void CJBNPILDHAG(this IncrementalHash ADPFJJODLPO, ulong ALOFFJJMPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x652DCA0", Offset = "0x652CCA0", VA = "0x18652DCA0")]
	public static void JDLDIADPNKL(this IncrementalHash ADPFJJODLPO, uint GGNDMALDLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x652D720", Offset = "0x652C720", VA = "0x18652D720")]
	public static void HCBOHHFLCDN(this IncrementalHash ADPFJJODLPO, ushort OMHPHBAEPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x652D790", Offset = "0x652C790", VA = "0x18652D790")]
	public static void HKILJCHLEMG(this IncrementalHash ADPFJJODLPO, Vector3 GMEBBEGEPED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x652DD00", Offset = "0x652CD00", VA = "0x18652DD00")]
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
	[Cpp2IlInjected.Address(RVA = "0x6530380", Offset = "0x652F380", VA = "0x186530380")]
	public NLOCMFDOIKO(Type NMHGDNOBLPL, string BEJMEINOPAL, bool OMGAKLBNBAH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class HLPIPILFNCH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x652C120", Offset = "0x652B120", VA = "0x18652C120")]
	public HLPIPILFNCH(string GOMILMNIGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x652C190", Offset = "0x652B190", VA = "0x18652C190")]
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
			[Cpp2IlInjected.Address(RVA = "0x6DF040", Offset = "0x6DE040", VA = "0x1806DF040")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x6F5790", Offset = "0x6F4790", VA = "0x1806F5790")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public T this[int BDAADCOCKII, int CENFIFAIEEN]
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x3A7B8A0", Offset = "0x3A7A8A0", VA = "0x183A7B8A0")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x3A7B940", Offset = "0x3A7A940", VA = "0x183A7B940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x3A7B810", Offset = "0x3A7A810", VA = "0x183A7B810")]
		public Array2D(uint FGOOGGEJGJK, uint NJKNCDKEMEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x3A7B790", Offset = "0x3A7A790", VA = "0x183A7B790")]
		public void FPEOCMBDEPF()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x65294B0", Offset = "0x65284B0", VA = "0x1865294B0")]
		public Array2DVector3(uint FGOOGGEJGJK, uint NJKNCDKEMEE)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct FHJIADEADDK
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public delegate bool NMBELMANIMK(string KMBONOKGLNB, FHJIADEADDK NGPBCEHEJJG);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public int GDHAKIDLDCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public string IJOLFEBFIPB;

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x652AD10", Offset = "0x6529D10", VA = "0x18652AD10")]
	public static Dictionary<string, FHJIADEADDK> JBPAJGEIGJC(Type MHCJFIOMMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x652B000", Offset = "0x652A000", VA = "0x18652B000")]
	public static Dictionary<string, FHJIADEADDK> LALPNKKJIMO(Type MHCJFIOMMAD, NMBELMANIMK EOCGFPBFKOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x652AB60", Offset = "0x6529B60", VA = "0x18652AB60")]
	public static Dictionary<int, string> GKGEKKPDPCN(Dictionary<string, FHJIADEADDK> EHNCKNECPAL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
internal static class FOJBHBODBDL
{
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public const int BIMKNFNBOBE = -1;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public const int PMMOHJIJPLI = 0;
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[DefaultMember("Item")]
public class FEPGPOIDFMK<THandle, TValue> : IDisposable where THandle : struct, LGHBPHHHPFG where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly List<THandle> IJELHBLKOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly List<TValue> GBCINMGHOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly Func<TValue> AHDNAKEDDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly Action<TValue> PEGDMCPLCCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private int IABNFHPOOJO;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public TValue IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x3719C90", Offset = "0x3718C90", VA = "0x183719C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x41FE5E0", Offset = "0x41FD5E0", VA = "0x1841FE5E0")]
	public FEPGPOIDFMK(Action<TValue> PEGDMCPLCCK, [Optional] Func<TValue> AHDNAKEDDPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x41FDE20", Offset = "0x41FCE20", VA = "0x1841FDE20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x41FDBE0", Offset = "0x41FCBE0", VA = "0x1841FDBE0")]
	public THandle BMDGCEOIEEG()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x41FDF60", Offset = "0x41FCF60", VA = "0x1841FDF60")]
	public THandle GBJBCHALJOG(TValue KPPLMEOMNGF)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x41FE530", Offset = "0x41FD530", VA = "0x1841FE530")]
	public bool PMMODKPOELK(THandle BDCLOJHOMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x41FDA60", Offset = "0x41FCA60", VA = "0x1841FDA60")]
	public bool BAFMLPIANAD(THandle BDCLOJHOMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x41FE1C0", Offset = "0x41FD1C0", VA = "0x1841FE1C0")]
	public bool LEDONIKBHEA(THandle BDCLOJHOMDK, out TValue KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x41FDDC0", Offset = "0x41FCDC0", VA = "0x1841FDDC0")]
	public TValue BOEAFIEBIHC(THandle BDCLOJHOMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x41FDB30", Offset = "0x41FCB30", VA = "0x1841FDB30")]
	public bool BKIFKBMENNF(THandle BDCLOJHOMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x41FE330", Offset = "0x41FD330", VA = "0x1841FE330")]
	private THandle MDPPCNBODBO(int EGBCAPEEJBF)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x41FE190", Offset = "0x41FD190", VA = "0x1841FE190")]
	private TValue IPFANDCPJOE(int EGBCAPEEJBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x41FE150", Offset = "0x41FD150", VA = "0x1841FE150")]
	private void IIHMNOCDCKA(int EGBCAPEEJBF, in THandle BDCLOJHOMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x41FE3E0", Offset = "0x41FD3E0", VA = "0x1841FE3E0")]
	private void NJAFIFNAEFP(int EGBCAPEEJBF, in TValue KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x41FE420", Offset = "0x41FD420", VA = "0x1841FE420")]
	private THandle PLAGHNBFHJL()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x41FDEB0", Offset = "0x41FCEB0", VA = "0x1841FDEB0")]
	private void FPGHKCICDPL(THandle BDCLOJHOMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x41FDE10", Offset = "0x41FCE10", VA = "0x1841FDE10")]
	private int DNFONJFBMEL(int LFMBJAIIPEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x41FDEA0", Offset = "0x41FCEA0", VA = "0x1841FDEA0")]
	private bool FFKCKABMHBH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x746580", Offset = "0x745580", VA = "0x180746580")]
	private void HAAAGGEBPOD(THandle BDCLOJHOMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x41FE360", Offset = "0x41FD360", VA = "0x1841FE360")]
	private bool NCDOCPDILDG(out THandle BDCLOJHOMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x41FE260", Offset = "0x41FD260", VA = "0x1841FE260")]
	private bool LLMFKEPAHFL(out THandle BDCLOJHOMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x41FE0F0", Offset = "0x41FD0F0", VA = "0x1841FE0F0")]
	private void ICLFPKAPMKA(THandle BDCLOJHOMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x41FDFD0", Offset = "0x41FCFD0", VA = "0x1841FDFD0")]
	private void IAACJGPNEEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public interface LGHBPHHHPFG
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	int NOAKOLDJPCH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	int CONDCHODOCK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public interface AOOPJGHLJBJ<T> : LGHBPHHHPFG, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class GNIBKDBAKJE
{
	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0xCFDA50", Offset = "0xCFCA50", VA = "0x180CFDA50")]
	public static bool DEONMCNMECP<T>(this T BDCLOJHOMDK, T JHMCLPBFJBC) where T : struct, LGHBPHHHPFG
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x2328340", Offset = "0x2327340", VA = "0x182328340")]
	public static bool EMBOEJCGPBA<T>(this T BDCLOJHOMDK) where T : struct, LGHBPHHHPFG
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x652B710", Offset = "0x652A710", VA = "0x18652B710")]
	public static string CNFBIAHAAKC(this LGHBPHHHPFG BDCLOJHOMDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class MPIEPKOGJFC
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private enum LEFHAKLEHDP : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private int ADPFJJODLPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private bool OKMPCICKNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private LEFHAKLEHDP KFCHBPFAEMJ;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public bool CKOAHOIJBAL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x652F290", Offset = "0x652E290", VA = "0x18652F290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool MIDIEDJGAJA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x652F380", Offset = "0x652E380", VA = "0x18652F380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x652FFA0", Offset = "0x652EFA0", VA = "0x18652FFA0")]
	public MPIEPKOGJFC(bool OKMPCICKNLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x652F540", Offset = "0x652E540", VA = "0x18652F540")]
	public void NICIPLEGDLC(object AELIHOPICED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x652F2C0", Offset = "0x652E2C0", VA = "0x18652F2C0")]
	public void IMONFMHOMCP(int KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x652F2A0", Offset = "0x652E2A0", VA = "0x18652F2A0")]
	public void DIHKLMEFADL(uint EHDHAGPCPPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x652F360", Offset = "0x652E360", VA = "0x18652F360")]
	public void JPJGHGMJOGM(bool CPFGLOGJBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x652F400", Offset = "0x652E400", VA = "0x18652F400")]
	public void LJOOBGDKIFB(long FKKIIOKEOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x652F250", Offset = "0x652E250", VA = "0x18652F250")]
	public void DBGHBAFIHEJ(ulong CAKADBMMBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x652F390", Offset = "0x652E390", VA = "0x18652F390")]
	public void KDIILHHDOHP(string OLOKIOKEPFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x652F4B0", Offset = "0x652E4B0", VA = "0x18652F4B0")]
	public void NDMIIEMIONL(Enum CJDLKEIECEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x652F0B0", Offset = "0x652E0B0", VA = "0x18652F0B0")]
	public void BGABMHAGIIA(IList EHJGMBFBLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x22498A0", Offset = "0x22488A0", VA = "0x1822498A0")]
	public void KOEBPBKOACE<T, U>(Dictionary<T, U> INAFJIMICJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x652FBC0", Offset = "0x652EBC0", VA = "0x18652FBC0")]
	private void OEJHFIAJHEF(IDictionary INAFJIMICJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x652F1E0", Offset = "0x652E1E0", VA = "0x18652F1E0")]
	public int CHAAOJHKDBM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x652F440", Offset = "0x652E440", VA = "0x18652F440")]
	public short LMJNOICPHKP()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x652F2B0", Offset = "0x652E2B0", VA = "0x18652F2B0")]
	public void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x652FF30", Offset = "0x652EF30", VA = "0x18652FF30")]
	private void PKPFJEOGHBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public abstract class ODHPIMDKJCC<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	internal class EGFFNCDLIJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public TNode AOFCPKBHFEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public TNode OKMBLMILFGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public PGHOKKPMFJN PMIFMNEAFNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public List<PGHOKKPMFJN> PNEOGCCNFPF;

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x10FDE40", Offset = "0x10FCE40", VA = "0x1810FDE40")]
		public EGFFNCDLIJJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	internal struct PGHOKKPMFJN : IComparable<PGHOKKPMFJN>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public int APLFJBIBJAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public TClaimant MPBLGGELNEO;

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x70A0B0", Offset = "0x7090B0", VA = "0x18070A0B0")]
		public PGHOKKPMFJN(int APLFJBIBJAH, TClaimant MPBLGGELNEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x2B289F0", Offset = "0x2B279F0", VA = "0x182B289F0")]
		public bool IMDKHKNCIKP(in PGHOKKPMFJN JHMCLPBFJBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x2B28A50", Offset = "0x2B27A50", VA = "0x182B28A50")]
		public bool PNJPGKOBLEP(in PGHOKKPMFJN JHMCLPBFJBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x2B289E0", Offset = "0x2B279E0", VA = "0x182B289E0", Slot = "4")]
		public int CompareTo(PGHOKKPMFJN JHMCLPBFJBC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x2B28A60", Offset = "0x2B27A60", VA = "0x182B28A60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public enum LIEHBAAFEFH
	{
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class FFECDIMBBOO : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public global::ODHPIMDKJCC<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x10F6E00", Offset = "0x10F5E00", VA = "0x1810F6E00")]
		[DebuggerHidden]
		public FFECDIMBBOO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x28FDB80", Offset = "0x28FCB80", VA = "0x1828FDB80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x28FDD40", Offset = "0x28FCD40", VA = "0x1828FDD40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x28FDC60", Offset = "0x28FCC60", VA = "0x1828FDC60", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x1AAA650", Offset = "0x1AA9650", VA = "0x181AAA650", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly global::FOHDNCAIEND<EGFFNCDLIJJ> OGFJJGOLJHK;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static readonly global::FOHDNCAIEND<List<PGHOKKPMFJN>> KPNEEFIKJHJ;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static int GJLHBIEJIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	internal readonly Dictionary<TClaimant, TNode> COKEIGCAICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	internal readonly Dictionary<TNode, EGFFNCDLIJJ> NNNGPBOEBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private LIEHBAAFEFH COAEGBJAHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private bool FLFCLOAFFCN;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode FCHNDLGHOIE(TNode BBGMDMKKHON);

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void EADMEFIPDAO(TNode BBGMDMKKHON, TClaimant KFHMLIAKJLD, TClaimant BDOKAIPMFAA);

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x2E68160", Offset = "0x2E67160", VA = "0x182E68160")]
	public ODHPIMDKJCC(LIEHBAAFEFH COAEGBJAHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x2E673F0", Offset = "0x2E663F0", VA = "0x182E673F0")]
	public void ELGLHJAHLJP(TNode BBGMDMKKHON, TNode KHLHKJKADHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x2E67660", Offset = "0x2E66660", VA = "0x182E67660")]
	public void HHGEKMHADHF(TClaimant MPBLGGELNEO, TNode ELCABFLLMBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x2E670F0", Offset = "0x2E660F0", VA = "0x182E670F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x2E67350", Offset = "0x2E66350", VA = "0x182E67350")]
	private void ECIHOJOEEOJ(TClaimant MPBLGGELNEO, TNode MEOKMLPNAKO, TNode ELCABFLLMBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x2E67600", Offset = "0x2E66600", VA = "0x182E67600")]
	private int GJCJLIKPGCN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x2E67760", Offset = "0x2E66760", VA = "0x182E67760")]
	private void IFEDAILNNJA(TClaimant MPBLGGELNEO, TNode NBOIFHKMHEN, TNode ADAJCIOPLGN, int CDGDOKEGIJM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x2E67570", Offset = "0x2E66570", VA = "0x182E67570")]
	private void FHKLLLOOHDM(PGHOKKPMFJN LNAAFNLKKMC, EGFFNCDLIJJ GPBNHLBGMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x2E66E90", Offset = "0x2E65E90", VA = "0x182E66E90")]
	private void DLCJPFHODDL(TClaimant MPBLGGELNEO, TNode NBOIFHKMHEN, TNode ADAJCIOPLGN, int CDGDOKEGIJM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x2E66A10", Offset = "0x2E65A10", VA = "0x182E66A10")]
	private void AEMAOMOBLBN(PGHOKKPMFJN LNAAFNLKKMC, TNode BBGMDMKKHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x2E67470", Offset = "0x2E66470", VA = "0x182E67470")]
	private void FBMBCACAHLO(PGHOKKPMFJN LNAAFNLKKMC, EGFFNCDLIJJ GPBNHLBGMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x2E66BF0", Offset = "0x2E65BF0", VA = "0x182E66BF0")]
	private void BJCAHJHNAML(EGFFNCDLIJJ GPBNHLBGMJP, bool DICIAPPFKEN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x2E67C90", Offset = "0x2E66C90", VA = "0x182E67C90")]
	private void NNIPCDCHEHM(EGFFNCDLIJJ GPBNHLBGMJP, TNode KHLHKJKADHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x2E66B20", Offset = "0x2E65B20", VA = "0x182E66B20")]
	[IteratorStateMachine(typeof(global::ODHPIMDKJCC<, >.FFECDIMBBOO))]
	private IEnumerable<TNode> AOILNLIAALB(TNode NBOIFHKMHEN, TNode ADAJCIOPLGN, bool FEEAHAJHAEP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x2E67BD0", Offset = "0x2E66BD0", VA = "0x182E67BD0")]
	private EGFFNCDLIJJ MDBBKOFDNDH(TNode BBGMDMKKHON, TNode OKMBLMILFGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x2E66D00", Offset = "0x2E65D00", VA = "0x182E66D00")]
	private EGFFNCDLIJJ CBGBAKIICAK(TNode BBGMDMKKHON, TNode OKMBLMILFGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x2E67A10", Offset = "0x2E66A10", VA = "0x182E67A10")]
	private void JDCNKDMLPKJ(EGFFNCDLIJJ GPBNHLBGMJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public class LCOFNCIAACG<T> : IEnumerable<global::LCOFNCIAACG<T>.IPLKBGDEEHK>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public struct IPLKBGDEEHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public T KPPLMEOMNGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public int EGBCAPEEJBF;
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public class NHKAJLDCKGM : IEnumerator<IPLKBGDEEHK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private global::LCOFNCIAACG<T> MOBIBCNEEOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private int EGBCAPEEJBF;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x143F7E0", Offset = "0x143E7E0", VA = "0x18143F7E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public IPLKBGDEEHK AGGOFNFHANI
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x23C2760", Offset = "0x23C1760", VA = "0x1823C2760", Slot = "4")]
			get
			{
				return default(IPLKBGDEEHK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x6E3060", Offset = "0x6E2060", VA = "0x1806E3060")]
		public NHKAJLDCKGM(global::LCOFNCIAACG<T> MOBIBCNEEOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x23C2620", Offset = "0x23C1620", VA = "0x1823C2620", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x6E3050", Offset = "0x6E2050", VA = "0x1806E3050", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0xC19DA0", Offset = "0xC18DA0", VA = "0x180C19DA0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	private struct ILMBPCPADEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public bool NMMAFIDOFIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public T KPPLMEOMNGF;
	}

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private const int IGDLJDCBNCB = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly Dictionary<T, int> ILEAHEOFHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private ILMBPCPADEP[] NGDIOCIIFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private int NOCMMDKHALH;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int NICKCFFOLOA
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x6FFD90", Offset = "0x6FED90", VA = "0x1806FFD90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x877CE0", Offset = "0x876CE0", VA = "0x180877CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int IIEJMBAKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x2029390", Offset = "0x2028390", VA = "0x182029390")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x20B0680", Offset = "0x20AF680", VA = "0x1820B0680")]
	public LCOFNCIAACG(int KNECCHHDDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x20B0760", Offset = "0x20AF760", VA = "0x1820B0760")]
	public LCOFNCIAACG(IPLKBGDEEHK[] PMGFKBCECNF, bool KDADMDNMJNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x20B00A0", Offset = "0x20AF0A0", VA = "0x1820B00A0")]
	public int JBDKFJNFEDP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x20AF8C0", Offset = "0x20AE8C0", VA = "0x1820AF8C0")]
	private int FAFIPPEGELG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x20AF210", Offset = "0x20AE210", VA = "0x1820AF210", Slot = "6")]
	protected virtual uint AIPAONOKHGO(uint ADPFJJODLPO, T KPPLMEOMNGF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x20B02E0", Offset = "0x20AF2E0", VA = "0x1820B02E0")]
	public bool OIMGOGOIEME(T KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x20B0450", Offset = "0x20AF450", VA = "0x1820B0450")]
	public bool PCFBFGCLBMG(int EGBCAPEEJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x20AF6A0", Offset = "0x20AE6A0", VA = "0x1820AF6A0")]
	public bool BNDEAHDJONI(Func<T, bool> COANEGMLMGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x20B0350", Offset = "0x20AF350", VA = "0x1820B0350")]
	public int OJPGMPIMIDD(T KPPLMEOMNGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x20AFFE0", Offset = "0x20AEFE0", VA = "0x1820AFFE0")]
	public T IPFANDCPJOE(int EGBCAPEEJBF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x20AFCB0", Offset = "0x20AECB0", VA = "0x1820AFCB0")]
	public void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x20AF230", Offset = "0x20AE230", VA = "0x1820AF230")]
	public bool APHPNPEMCLE(T KPPLMEOMNGF, bool FJDGIBDPCPN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x20AF470", Offset = "0x20AE470", VA = "0x1820AF470")]
	public bool APHPNPEMCLE(T KPPLMEOMNGF, int EGBCAPEEJBF, bool FJDGIBDPCPN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x20B04F0", Offset = "0x20AF4F0", VA = "0x1820B04F0")]
	public bool PMMODKPOELK(T KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x20B04A0", Offset = "0x20AF4A0", VA = "0x1820B04A0")]
	public bool PJBBGDBFNGB(int EGBCAPEEJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x20B01F0", Offset = "0x20AF1F0", VA = "0x1820B01F0")]
	private void OCIGNPPKEFD(int EGBCAPEEJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x20AFD30", Offset = "0x20AED30", VA = "0x1820AFD30")]
	public IPLKBGDEEHK[] IFPMJMGFJLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x20AF870", Offset = "0x20AE870", VA = "0x1820AF870")]
	private int EHBDKFPGGHK(int GJPBLFPOONO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x20B0600", Offset = "0x20AF600", VA = "0x1820B0600", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x20B0600", Offset = "0x20AF600", VA = "0x1820B0600", Slot = "4")]
	private IEnumerator<IPLKBGDEEHK> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct CJFIDMOEABI<Handle> where Handle : LGHBPHHHPFG, new()
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	private struct AALLACOGIBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly global::CJFIDMOEABI<Handle> DJOFPEAKDCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private int EGBCAPEEJBF;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public int ICIEAPGJPPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x35093B0", Offset = "0x35083B0", VA = "0x1835093B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public Handle ENKGMGGEEPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x3509F70", Offset = "0x3508F70", VA = "0x183509F70")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x350A370", Offset = "0x3509370", VA = "0x18350A370")]
		public AALLACOGIBO(global::CJFIDMOEABI<Handle> DJOFPEAKDCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x3509650", Offset = "0x3508650", VA = "0x183509650")]
		public GPGCMPJOKJB CCFMECMIHDM(in GPGCMPJOKJB BJBDNHBIPAI)
		{
			return default(GPGCMPJOKJB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x35095B0", Offset = "0x35085B0", VA = "0x1835095B0")]
		public KPHJNBBNHDH CCFMECMIHDM(in KPHJNBBNHDH BJBDNHBIPAI)
		{
			return default(KPHJNBBNHDH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x3509B90", Offset = "0x3508B90", VA = "0x183509B90")]
		public bool JPIMAEJBKHA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x35097E0", Offset = "0x35087E0", VA = "0x1835097E0")]
		private int JGGMKJENKPH(string GOMILMNIGIC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x350A320", Offset = "0x3509320", VA = "0x18350A320")]
		private Handle NHCCJDBNPBL(string GOMILMNIGIC)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public struct GPGCMPJOKJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private AALLACOGIBO BDCOLOBIPJG;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public int AGGOFNFHANI
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x2EDDF80", Offset = "0x2EDCF80", VA = "0x182EDDF80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x2B67300", Offset = "0x2B66300", VA = "0x182B67300")]
		public GPGCMPJOKJB(global::CJFIDMOEABI<Handle> DJOFPEAKDCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x2B67240", Offset = "0x2B66240", VA = "0x182B67240")]
		public bool JPIMAEJBKHA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x2EDE000", Offset = "0x2EDD000", VA = "0x182EDE000")]
		public GPGCMPJOKJB KGLEFCHHJJI()
		{
			return default(GPGCMPJOKJB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public struct KPHJNBBNHDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private AALLACOGIBO BDCOLOBIPJG;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Handle AGGOFNFHANI
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x2B67080", Offset = "0x2B66080", VA = "0x182B67080")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x2B67300", Offset = "0x2B66300", VA = "0x182B67300")]
		public KPHJNBBNHDH(global::CJFIDMOEABI<Handle> DJOFPEAKDCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x2B67240", Offset = "0x2B66240", VA = "0x182B67240")]
		public bool JPIMAEJBKHA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x2B67280", Offset = "0x2B66280", VA = "0x182B67280")]
		public KPHJNBBNHDH KGLEFCHHJJI()
		{
			return default(KPHJNBBNHDH);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private NativeList<int> HBAJDCHAHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private NativeList<int> KIHCHOHOEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private int LMPBCPKJEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private int EIPOHIAHJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private bool KKBKJMIDOMF;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool FAFBILBNMMN
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x7CFFA0", Offset = "0x7CEFA0", VA = "0x1807CFFA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int LFCNNPBFNIK
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x2231140", Offset = "0x2230140", VA = "0x182231140")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int AFHHDPFENDC
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x6DF010", Offset = "0x6DE010", VA = "0x1806DF010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int KKBBPMHMDHC
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x6DF010", Offset = "0x6DE010", VA = "0x1806DF010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public GPGCMPJOKJB NNICFNNBCPO
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x2231CE0", Offset = "0x2230CE0", VA = "0x182231CE0")]
		get
		{
			return default(GPGCMPJOKJB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public KPHJNBBNHDH DOMHFKCOAHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x2231C40", Offset = "0x2230C40", VA = "0x182231C40")]
		get
		{
			return default(KPHJNBBNHDH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x2232C80", Offset = "0x2231C80", VA = "0x182232C80")]
	public CJFIDMOEABI(int OOBCJODNMBL, Allocator GOLNHBOGNGC = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x2231B80", Offset = "0x2230B80", VA = "0x182231B80")]
	public void KKNPGIAABIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x10ED410", Offset = "0x10EC410", VA = "0x1810ED410")]
	public static int DNFONJFBMEL(int APLGHPJFDAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x2232C60", Offset = "0x2231C60", VA = "0x182232C60")]
	public static bool PEJFMBJOIFD(int APLGHPJFDAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x2232C70", Offset = "0x2231C70", VA = "0x182232C70")]
	public static bool PPBPJAEDOAG(int APLGHPJFDAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x2230A00", Offset = "0x222FA00", VA = "0x182230A00")]
	public bool BGHMNLEHGOP(int EGBCAPEEJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x2231500", Offset = "0x2230500", VA = "0x182231500")]
	public bool HOEBOGFEIJG(int EGBCAPEEJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x2230FF0", Offset = "0x222FFF0", VA = "0x182230FF0")]
	public bool DJIECBBOCPO(Handle BDCLOJHOMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x2232620", Offset = "0x2231620", VA = "0x182232620")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void OLGAFDEPJJH(Handle BDCLOJHOMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x2231E50", Offset = "0x2230E50", VA = "0x182231E50")]
	public Handle MHLONCNLJOA()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x2232220", Offset = "0x2231220", VA = "0x182232220")]
	public void MMHCMEAFAJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x2232520", Offset = "0x2231520", VA = "0x182232520")]
	public void MOPMNPMBKGA(Handle BDCLOJHOMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x2231740", Offset = "0x2230740", VA = "0x182231740")]
	public bool HPKJECLKMEJ(Handle BDCLOJHOMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x7CFFA0", Offset = "0x7CEFA0", VA = "0x1807CFFA0")]
	private bool GLKLBLOKILF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x2231900", Offset = "0x2230900", VA = "0x182231900")]
	private bool JHPACPFDAJN(int EGBCAPEEJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x2231180", Offset = "0x2230180", VA = "0x182231180")]
	private void GEBDJJPBIED(out int EGBCAPEEJBF, out int LFMBJAIIPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x2230C40", Offset = "0x222FC40", VA = "0x182230C40")]
	private void CDNLKKBNNEA(Handle BDCLOJHOMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x2230E40", Offset = "0x222FE40", VA = "0x182230E40")]
	private void DDAAGBEJKAI(int EGBCAPEEJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x2231960", Offset = "0x2230960", VA = "0x182231960")]
	private bool KKNGALJKEEO(out int EGBCAPEEJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x2231460", Offset = "0x2230460", VA = "0x182231460")]
	private static Handle HLLIBFIOBJD(int EGBCAPEEJBF, int LFMBJAIIPEH)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[DefaultMember("Item")]
public struct IEDFOPGJHFB<Handle, T> where Handle : LGHBPHHHPFG, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private global::CJFIDMOEABI<Handle> FLHOAAHODPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private T[] EOONDHPAEAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private Action<T> KCIOCOEEAPH;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool FAFBILBNMMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x10F4560", Offset = "0x10F3560", VA = "0x1810F4560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public int LFCNNPBFNIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x10F2DA0", Offset = "0x10F1DA0", VA = "0x1810F2DA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public int IIEJMBAKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x10F4530", Offset = "0x10F3530", VA = "0x1810F4530")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public T IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x10F2B30", Offset = "0x10F1B30", VA = "0x1810F2B30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x10F5D60", Offset = "0x10F4D60", VA = "0x1810F5D60")]
	public IEDFOPGJHFB(int OOBCJODNMBL, [Optional] Action<T> KCIOCOEEAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x10F41B0", Offset = "0x10F31B0", VA = "0x1810F41B0")]
	public void KKNPGIAABIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x10F2C70", Offset = "0x10F1C70", VA = "0x1810F2C70")]
	public bool DJIECBBOCPO(Handle BDCLOJHOMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void OLGAFDEPJJH(Handle BDCLOJHOMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x10F2A70", Offset = "0x10F1A70", VA = "0x1810F2A70")]
	public T BOEAFIEBIHC(Handle BDCLOJHOMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x10F43D0", Offset = "0x10F33D0", VA = "0x1810F43D0")]
	public bool LEDONIKBHEA(Handle BDCLOJHOMDK, out T AELIHOPICED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x10F36A0", Offset = "0x10F26A0", VA = "0x1810F36A0")]
	public void JPNFGACMGOG(Handle BDCLOJHOMDK, T JGPJKHGOEOJ, out T JKCKBFPDKPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x10F3360", Offset = "0x10F2360", VA = "0x1810F3360")]
	public void JPNFGACMGOG(Handle BDCLOJHOMDK, T JGPJKHGOEOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x10F4680", Offset = "0x10F3680", VA = "0x1810F4680")]
	public bool OGNINEINMEG(Handle BDCLOJHOMDK, T JGPJKHGOEOJ, out T JKCKBFPDKPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x10F4B40", Offset = "0x10F3B40", VA = "0x1810F4B40")]
	public bool OGNINEINMEG(Handle BDCLOJHOMDK, T JGPJKHGOEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x10F3190", Offset = "0x10F2190", VA = "0x1810F3190")]
	public Handle GBJBCHALJOG(T AELIHOPICED)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x10F3BA0", Offset = "0x10F2BA0", VA = "0x1810F3BA0")]
	public void KCFEMAHCNFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x10F50E0", Offset = "0x10F40E0", VA = "0x1810F50E0")]
	public void PMMODKPOELK(Handle BDCLOJHOMDK, out T JKCKBFPDKPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x10F4E30", Offset = "0x10F3E30", VA = "0x1810F4E30")]
	public void PMMODKPOELK(Handle BDCLOJHOMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x10F58C0", Offset = "0x10F48C0", VA = "0x1810F58C0")]
	public bool POLKLACNFNE(Handle BDCLOJHOMDK, out T JKCKBFPDKPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x10F5700", Offset = "0x10F4700", VA = "0x1810F5700")]
	public bool POLKLACNFNE(Handle BDCLOJHOMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x10F4D00", Offset = "0x10F3D00", VA = "0x1810F4D00")]
	private T PJBBGDBFNGB(int EGBCAPEEJBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x10F3290", Offset = "0x10F2290", VA = "0x1810F3290")]
	private void GJMAKOAEHLO(int OIKHEKALAGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public class FOHDNCAIEND<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly Stack<T> DJOFPEAKDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly List<T> JAGIMCDNDPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly int HNKJNJCPAMA;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public int PAHFMADMOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x20B8830", Offset = "0x20B7830", VA = "0x1820B8830")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int PGCLLLCPBAL
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x29183D0", Offset = "0x29173D0", VA = "0x1829183D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x2918510", Offset = "0x2917510", VA = "0x182918510")]
	public static global::FOHDNCAIEND<T> GLOHCHGPGED(int KNECCHHDDJH = 0, int HNKJNJCPAMA = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x2918780", Offset = "0x2917780", VA = "0x182918780")]
	public static global::FOHDNCAIEND<T> KGPFJODKEBP(int KNECCHHDDJH = 0, int HNKJNJCPAMA = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x2918D80", Offset = "0x2917D80", VA = "0x182918D80")]
	public FOHDNCAIEND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x2918BF0", Offset = "0x2917BF0", VA = "0x182918BF0")]
	public FOHDNCAIEND(int KNECCHHDDJH, int HNKJNJCPAMA = int.MaxValue, bool ECODDOAFLKA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x2918A50", Offset = "0x2917A50", VA = "0x182918A50")]
	public T NKPOHKGJHAP()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x29189A0", Offset = "0x29179A0", VA = "0x1829189A0")]
	public void NCMANBGJLOI(T KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x29188D0", Offset = "0x29178D0", VA = "0x1829188D0")]
	private void LNHINFFOOKK(T KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x2918400", Offset = "0x2917400", VA = "0x182918400")]
	private void DHHNJCDJKKL(T KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x2918850", Offset = "0x2917850", VA = "0x182918850")]
	[Conditional("DEBUG_BUILD")]
	private void LEILHONOBPL(T NKEDEDGFMMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x2918B60", Offset = "0x2917B60", VA = "0x182918B60")]
	[Conditional("DEBUG_BUILD")]
	private void OHEJMFPGJIL(T NKEDEDGFMMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x2918420", Offset = "0x2917420", VA = "0x182918420", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x29185E0", Offset = "0x29175E0", VA = "0x1829185E0")]
	private void IFHKNOMFFBP(IEnumerable<T> GBCINMGHOME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public class GNIOEMKCOGB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private Dictionary<int, T> GCMGJFGGLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private T HOFLPIIJBCP;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public virtual T CKPBNIPNFEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x6FF140", Offset = "0x6FE140", VA = "0x1806FF140", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool PLCPILPMFHD
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x2EDB720", Offset = "0x2EDA720", VA = "0x182EDB720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x2EDB820", Offset = "0x2EDA820", VA = "0x182EDB820")]
	public bool JPJHPPMDCBA(T KPPLMEOMNGF, int APLFJBIBJAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x2EDB760", Offset = "0x2EDA760", VA = "0x182EDB760")]
	public bool FHGMKIKLJLK(int APLFJBIBJAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x2EDB8E0", Offset = "0x2EDA8E0", VA = "0x182EDB8E0")]
	public T LLGDJGHBCMP(int MCBLFKHBAIO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x2EDB7C0", Offset = "0x2EDA7C0", VA = "0x182EDB7C0")]
	public void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x2EDBD00", Offset = "0x2EDAD00", VA = "0x182EDBD00")]
	private bool OOCINGAKPFJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x2EDBCD0", Offset = "0x2EDACD0", VA = "0x182EDBCD0")]
	public bool OHBANFGHGGE(int APLFJBIBJAH, out T KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x2EDBEA0", Offset = "0x2EDAEA0", VA = "0x182EDBEA0")]
	public GNIOEMKCOGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public class ONGOHDDHFBF<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	protected struct MLFDKNENDFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public T KMEGGOIFMKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public int HPIPDFCDDMO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	protected readonly List<MLFDKNENDFJ> GCEIGNCDLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private T IDLGPGOIAEM;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int IIEJMBAKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x2029390", Offset = "0x2028390", VA = "0x182029390")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x2521A90", Offset = "0x2520A90", VA = "0x182521A90")]
	public bool BNDEAHDJONI(T KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x2521FA0", Offset = "0x2520FA0", VA = "0x182521FA0")]
	public void GBJBCHALJOG(T KPPLMEOMNGF, int APLFJBIBJAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x2522040", Offset = "0x2521040", VA = "0x182522040")]
	public bool PMMODKPOELK(T KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x2521F40", Offset = "0x2520F40", VA = "0x182521F40")]
	public void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x2521ED0", Offset = "0x2520ED0", VA = "0x182521ED0")]
	public T FJOEEFHDCEB()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x2521E60", Offset = "0x2520E60", VA = "0x182521E60")]
	public T DKMCAJNFHJB()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x2521CA0", Offset = "0x2520CA0", VA = "0x182521CA0")]
	private void CMKJKBDEPEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x2522160", Offset = "0x2521160", VA = "0x182522160")]
	public ONGOHDDHFBF()
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
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		[SerializeField]
		[CBBPHEOMBGL(LNNFGJICGEC.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x6530DC0", Offset = "0x652FDC0", VA = "0x186530DC0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x6531150", Offset = "0x6530150", VA = "0x186531150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x6530FD0", Offset = "0x652FFD0", VA = "0x186530FD0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x65312B0", Offset = "0x65302B0", VA = "0x1865312B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x6530CE0", Offset = "0x652FCE0", VA = "0x186530CE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x6531070", Offset = "0x6530070", VA = "0x186531070")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x6530EF0", Offset = "0x652FEF0", VA = "0x186530EF0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x6530C90", Offset = "0x652FC90", VA = "0x186530C90")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public interface KHNJOKHFKNP
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public abstract class ResourcePrefabReference<T> : KHNJOKHFKNP where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x25C7390", Offset = "0x25C6390", VA = "0x1825C7390", Slot = "4")]
		public virtual T GAECHCAGCGA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x10FDE40", Offset = "0x10FCE40", VA = "0x1810FDE40")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public class EDJJKNMHHFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private readonly Dictionary<byte, LGOOJOOHPFF> LONMJDHJIEJ;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public LGOOJOOHPFF NGNCHOFCGKB
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x6FF130", Offset = "0x6FE130", VA = "0x1806FF130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector2 MCNOLHBMIAC
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x1A3FB00", Offset = "0x1A3EB00", VA = "0x181A3FB00")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x728D20", Offset = "0x727D20", VA = "0x180728D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector2 KBKPBMPCFKH
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x259FF20", Offset = "0x259EF20", VA = "0x18259FF20")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xA0AF60", Offset = "0xA09F60", VA = "0x180A0AF60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector2 AKCINGECEIF
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x6529FD0", Offset = "0x6528FD0", VA = "0x186529FD0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x18A6240", Offset = "0x18A5240", VA = "0x1818A6240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int GJBGPDAFMLF
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x6DF0E0", Offset = "0x6DE0E0", VA = "0x1806DF0E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x746580", Offset = "0x745580", VA = "0x180746580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x652A470", Offset = "0x6529470", VA = "0x18652A470")]
	public EDJJKNMHHFH(Bounds CJMEBEPNFND, Vector2[] CAGIGJAFGCD, int HGHIGHNMJGM, byte GJPBLFPOONO, float BFLINGBEFCG = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x6529FF0", Offset = "0x6528FF0", VA = "0x186529FF0")]
	public LGOOJOOHPFF IBKGNJPINKC(byte EGBCAPEEJBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x6529D70", Offset = "0x6528D70", VA = "0x186529D70")]
	public void BOMICGEHMKJ(Vector3 MIFJBHLKJIN, float EAAJNJJJEKF, float AACOIPAKGPD, ref List<byte> LDLLIMFPLDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x652A450", Offset = "0x6529450", VA = "0x18652A450")]
	public void LFCOKAFOIEB(LGOOJOOHPFF.HOHPONLDPEB FBADPNNDEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x6529E70", Offset = "0x6528E70", VA = "0x186529E70")]
	private LGOOJOOHPFF CHJHALNMIMA(byte EGBCAPEEJBF, LGOOJOOHPFF.GJNLKMKDPKF DPODNCNLBNN, LGOOJOOHPFF OKMBLMILFGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x652A050", Offset = "0x6529050", VA = "0x18652A050")]
	private void JOAMPIJHIFI(LGOOJOOHPFF OKMBLMILFGG, Vector2[] CAGIGJAFGCD, int BOAEGOAEELC, int OMADDDHNANE, int LIOKIGNCLCF, int MEKMNPEDEHO, float BFLINGBEFCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class LGOOJOOHPFF
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public enum GJNLKMKDPKF
	{
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public enum HOHPONLDPEB
	{
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public byte FOEPHKKCDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public Vector3 ODOBJGCHMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public Vector3 MDNIDCCLGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public Vector3 OAIBHLHNDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public Vector3 NJDCOFKJKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public GJNLKMKDPKF FENLLGGDJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public LGOOJOOHPFF AKKGLHPPJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public List<LGOOJOOHPFF> LJJJLKDCDDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public bool HMGMDLCEODG;

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x652D2B0", Offset = "0x652C2B0", VA = "0x18652D2B0")]
	public LGOOJOOHPFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x652D2D0", Offset = "0x652C2D0", VA = "0x18652D2D0")]
	public LGOOJOOHPFF(byte CLOAPFCHKDE, GJNLKMKDPKF DPODNCNLBNN, LGOOJOOHPFF OKMBLMILFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x652D1A0", Offset = "0x652C1A0", VA = "0x18652D1A0")]
	public void GFLPJLNLLDG(LGOOJOOHPFF BOGHNKLNLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
	public void LFCOKAFOIEB(int AIHCBELKABL, HOHPONLDPEB FBADPNNDEOF, int ANHIFGPPAME = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x652CEB0", Offset = "0x652BEB0", VA = "0x18652CEB0")]
	public void BOMICGEHMKJ(List<byte> LDLLIMFPLDG, Vector3 MIFJBHLKJIN, float EAAJNJJJEKF, float AACOIPAKGPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x652D260", Offset = "0x652C260", VA = "0x18652D260")]
	public bool HHJBAEOONGC(Vector3 BJNJDEBFECO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x652D160", Offset = "0x652C160", VA = "0x18652D160")]
	public bool DJGJEELAPDH(Vector3 BJNJDEBFECO, float GMKCMLABPFI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public class POJGNFGOJLM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly Dictionary<T, object> JIIDMIPCDHI;

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x10FE6A0", Offset = "0x10FD6A0", VA = "0x1810FE6A0")]
	public bool OGNFBDMEDMB(T NMAJDFEGMPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x347FB10", Offset = "0x347EB10", VA = "0x18347FB10")]
	public bool OGNFBDMEDMB(T NMAJDFEGMPM, object JAKCBCDLMLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x347FAB0", Offset = "0x347EAB0", VA = "0x18347FAB0")]
	public bool OGNFBDMEDMB(T NMAJDFEGMPM, object JAKCBCDLMLB, out object OBJPBIOGEDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x347F960", Offset = "0x347E960", VA = "0x18347F960")]
	public bool FCEHDFEJPAN(T NMAJDFEGMPM, object JAKCBCDLMLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x347FA70", Offset = "0x347EA70", VA = "0x18347FA70")]
	public bool KFJGJMBGMHG(T NMAJDFEGMPM, object JAKCBCDLMLB, out object OBJPBIOGEDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x347F8D0", Offset = "0x347E8D0", VA = "0x18347F8D0")]
	public bool FCEHDFEJPAN(T NMAJDFEGMPM, object JAKCBCDLMLB, out object OBJPBIOGEDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x347F9A0", Offset = "0x347E9A0", VA = "0x18347F9A0")]
	public void HECNMIPLCIB(T NMAJDFEGMPM, object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x347F9D0", Offset = "0x347E9D0", VA = "0x18347F9D0")]
	public void JPIJCHKEAML(T NMAJDFEGMPM, object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x347FB50", Offset = "0x347EB50", VA = "0x18347FB50")]
	public POJGNFGOJLM()
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
		public struct BPFEFLGLPJJ<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			private readonly List<Component> EHJGMBFBLBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			private readonly bool CPNIACDEHHD;

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x8ACF50", Offset = "0x8ABF50", VA = "0x1808ACF50")]
			public BPFEFLGLPJJ(List<Component> EHJGMBFBLBN, bool CPNIACDEHHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x27FA220", Offset = "0x27F9220", VA = "0x1827FA220")]
			public KPPBDNMMFJE<T> KGLEFCHHJJI()
			{
				return default(KPPBDNMMFJE<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x27FA290", Offset = "0x27F9290", VA = "0x1827FA290", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x27FA290", Offset = "0x27F9290", VA = "0x1827FA290", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AF")]
		public struct KPPBDNMMFJE<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			private readonly List<Component> EHJGMBFBLBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			private readonly bool CPNIACDEHHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			private int EGBCAPEEJBF;

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public T AGGOFNFHANI
			{
				[Cpp2IlInjected.Token(Token = "0x60003E9")]
				[Cpp2IlInjected.Address(RVA = "0x2B674F0", Offset = "0x2B664F0", VA = "0x182B674F0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003EA")]
				[Cpp2IlInjected.Address(RVA = "0x2B67480", Offset = "0x2B66480", VA = "0x182B67480", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x2B674C0", Offset = "0x2B664C0", VA = "0x182B674C0")]
			public KPPBDNMMFJE(List<Component> EHJGMBFBLBN, bool CPNIACDEHHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0x2B673C0", Offset = "0x2B663C0", VA = "0x182B673C0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0x2B673D0", Offset = "0x2B663D0", VA = "0x182B673D0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0x282AAF0", Offset = "0x2829AF0", VA = "0x18282AAF0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0x6533020", Offset = "0x6532020", VA = "0x186533020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x6532FE0", Offset = "0x6531FE0", VA = "0x186532FE0")]
		public ToolHierarchyCache(GameObject LOCIAIPOBLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x65329D0", Offset = "0x65319D0", VA = "0x1865329D0")]
		private void JHHOMPLGCBC(GameObject LOCIAIPOBLA, bool AKNNPOEHKML = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x6532B30", Offset = "0x6531B30", VA = "0x186532B30")]
		public static void JHHOMPLGCBC(GameObject LOCIAIPOBLA, ref ToolHierarchyCache DAJPKNFIFBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x65329C0", Offset = "0x65319C0", VA = "0x1865329C0")]
		public void JFDFLICPNAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x6532BC0", Offset = "0x6531BC0", VA = "0x186532BC0")]
		public void KIILEFLBIND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x3190F60", Offset = "0x318FF60", VA = "0x183190F60")]
		public void JGLBPFCCHBJ<T>(Action<T> FFBLFKDINEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x65327F0", Offset = "0x65317F0", VA = "0x1865327F0")]
		public Component ELJIOCJMALA(Type HAOFNDAEGFJ, bool CPNIACDEHHD = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x3190EE0", Offset = "0x318FEE0", VA = "0x183190EE0")]
		public T ELJIOCJMALA<T>(bool CPNIACDEHHD = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x6532770", Offset = "0x6531770", VA = "0x186532770")]
		public BPFEFLGLPJJ<Component> EDJOKFLBFNL(Type HAOFNDAEGFJ, bool CPNIACDEHHD = false)
		{
			return default(BPFEFLGLPJJ<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x3190E10", Offset = "0x318FE10", VA = "0x183190E10")]
		public BPFEFLGLPJJ<T> EDJOKFLBFNL<T>(bool CPNIACDEHHD = false) where T : class
		{
			return default(BPFEFLGLPJJ<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x6532C10", Offset = "0x6531C10", VA = "0x186532C10")]
		public List<Component> MLJKPOPLMDL(Type HAOFNDAEGFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x65328C0", Offset = "0x65318C0", VA = "0x1865328C0", Slot = "4")]
		public bool Equals(ToolHierarchyCache PMEDGJGANML, ToolHierarchyCache NIPKEFBPNPH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x6532940", Offset = "0x6531940", VA = "0x186532940", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache AELIHOPICED)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public class HFBILHMBNPG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private int KNECCHHDDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private int GOPLGHMMPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private List<T> KDCOOOFOCDB;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public int IIEJMBAKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x20B8830", Offset = "0x20B7830", VA = "0x1820B8830")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public T HODLDDNMMHG
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x2C6CB30", Offset = "0x2C6BB30", VA = "0x182C6CB30")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public T DJEBFNPLNJF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x2C6C7A0", Offset = "0x2C6B7A0", VA = "0x182C6C7A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public T LDFCEPFNNDA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x2C6CA80", Offset = "0x2C6BA80", VA = "0x182C6CA80")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x2C6CCF0", Offset = "0x2C6BCF0", VA = "0x182C6CCF0")]
	public HFBILHMBNPG(int KNECCHHDDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x2C6C950", Offset = "0x2C6B950", VA = "0x182C6C950")]
	public void GBJBCHALJOG(T NHOHPGMEPKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x2C6C840", Offset = "0x2C6B840", VA = "0x182C6C840")]
	public void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x2C6CC40", Offset = "0x2C6BC40", VA = "0x182C6CC40")]
	public void NDLDILKKODH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x2C6CAE0", Offset = "0x2C6BAE0", VA = "0x182C6CAE0")]
	public void MMAMFLHKKAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x2C6CCE0", Offset = "0x2C6BCE0", VA = "0x182C6CCE0")]
	public void OMHDMFKMFPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public class IILFIMLHJKP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private bool JCFMBKJAOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private Action FFBLFKDINEA;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public static IILFIMLHJKP JMONPJNDMAC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x652C530", Offset = "0x652B530", VA = "0x18652C530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool FFBFJBAACDM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x6E3250", Offset = "0x6E2250", VA = "0x1806E3250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0xC19D00", Offset = "0xC18D00", VA = "0x180C19D00")]
	public IILFIMLHJKP(Action FFBLFKDINEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x652C510", Offset = "0x652B510", VA = "0x18652C510")]
	public void OIEKBFPKDBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x652C510", Offset = "0x652B510", VA = "0x18652C510", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public static class DOOLBKJPJJC
{
	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x6529BF0", Offset = "0x6528BF0", VA = "0x186529BF0")]
	public static void CAEBEIKNPKP(JLNNFJHBOML OHGHGDAIFAO, string OLAMDIIMMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
	public static void CAEBEIKNPKP(IEnumerable<object> ABGEACDGIFN, string OLAMDIIMMNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public class KEFJIJAEDKB<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private struct NAJDPICCOAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public int HPIPDFCDDMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public T KMEGGOIFMKC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private readonly Dictionary<object, NAJDPICCOAD> GCMGJFGGLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private readonly EqualityComparer<T> NKGEPDNNFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private T HOFLPIIJBCP;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public virtual T CKPBNIPNFEB
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xC10C00", Offset = "0xC0FC00", VA = "0x180C10C00", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x274E340", Offset = "0x274D340", VA = "0x18274E340", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool PLCPILPMFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x28224F0", Offset = "0x28214F0", VA = "0x1828224F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public object BIJCCAJCLHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x6F56F0", Offset = "0x6F46F0", VA = "0x1806F56F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x777B00", Offset = "0x776B00", VA = "0x180777B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x28229C0", Offset = "0x28219C0", VA = "0x1828229C0")]
	public bool JPJHPPMDCBA(T KPPLMEOMNGF, object JAKCBCDLMLB, int APLFJBIBJAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x28225A0", Offset = "0x28215A0", VA = "0x1828225A0")]
	public bool FHGMKIKLJLK(object JAKCBCDLMLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x2823060", Offset = "0x2822060", VA = "0x182823060")]
	public bool OHBANFGHGGE(object JAKCBCDLMLB, out T KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x2822610", Offset = "0x2821610", VA = "0x182822610")]
	public void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x2827260", Offset = "0x2826260", VA = "0x182827260")]
	private bool OOCINGAKPFJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x2827560", Offset = "0x2826560", VA = "0x182827560")]
	public KEFJIJAEDKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public class OBFONEOHADB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private Dictionary<object, float> GCMGJFGGLEN;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float FKHGJNFOEJK
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x11E0800", Offset = "0x11DF800", VA = "0x1811E0800")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0xE07E00", Offset = "0xE06E00", VA = "0x180E07E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x6530600", Offset = "0x652F600", VA = "0x186530600")]
	public void JPJHPPMDCBA(float KPPLMEOMNGF, object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x6530470", Offset = "0x652F470", VA = "0x186530470")]
	public void FHGMKIKLJLK(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x65304E0", Offset = "0x652F4E0", VA = "0x1865304E0")]
	private void FNMEEPLOOIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x6530670", Offset = "0x652F670", VA = "0x186530670")]
	public OBFONEOHADB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public class MBGFKCALJCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public readonly string APNEBIOFCKF;

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x6DFF40", Offset = "0x6DEF40", VA = "0x1806DFF40")]
	public MBGFKCALJCF(string JNOPKIMKCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x652E4F0", Offset = "0x652D4F0", VA = "0x18652E4F0")]
	public MBGFKCALJCF(UnityEngine.Object EBODCLADMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x652E4A0", Offset = "0x652D4A0", VA = "0x18652E4A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public sealed class JLNNFJHBOML
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class BIJGLILAFEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public BIJGLILAFEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x6529780", Offset = "0x6528780", VA = "0x186529780")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private HashSet<object> ABGEACDGIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private int POPMGBNDCON;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public IReadOnlyCollection<object> KPJACHNJINE
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x652C6E0", Offset = "0x652B6E0", VA = "0x18652C6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool GNKDLLKCMAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x652C970", Offset = "0x652B970", VA = "0x18652C970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public int IIEJMBAKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x6E0BD0", Offset = "0x6DFBD0", VA = "0x1806E0BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x652C810", Offset = "0x652B810", VA = "0x18652C810")]
	public bool GBJBCHALJOG(object JAKCBCDLMLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x652C980", Offset = "0x652B980", VA = "0x18652C980")]
	public bool PMMODKPOELK(object JAKCBCDLMLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x652C7B0", Offset = "0x652B7B0", VA = "0x18652C7B0")]
	public bool BNDEAHDJONI(object JAKCBCDLMLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x652C900", Offset = "0x652B900", VA = "0x18652C900")]
	public void HFLCBPLCMNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x652CA20", Offset = "0x652BA20", VA = "0x18652CA20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public JLNNFJHBOML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public class JOJICCBKMBL<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private struct KKKIMJLGGLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public float DPGJLIDNNCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public T KMEGGOIFMKC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private Dictionary<object, KKKIMJLGGLI> GCMGJFGGLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private T EKBJBDJJNMN;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public virtual T GMKNHEMIOJN
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x10110E0", Offset = "0x10100E0", VA = "0x1810110E0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x16F6880", Offset = "0x16F5880", VA = "0x1816F6880", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public object DGJHDNMDOMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x6F56F0", Offset = "0x6F46F0", VA = "0x1806F56F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x777B00", Offset = "0x776B00", VA = "0x180777B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool PLCPILPMFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x3FF3400", Offset = "0x3FF2400", VA = "0x183FF3400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x3FF3970", Offset = "0x3FF2970", VA = "0x183FF3970")]
	public bool JPJHPPMDCBA(T KPPLMEOMNGF, object JAKCBCDLMLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x3FF3440", Offset = "0x3FF2440", VA = "0x183FF3440")]
	public bool FHGMKIKLJLK(object JAKCBCDLMLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x2822610", Offset = "0x2821610", VA = "0x182822610")]
	public void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x3FF3B30", Offset = "0x3FF2B30", VA = "0x183FF3B30")]
	public bool OHBANFGHGGE(object JAKCBCDLMLB, out T KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x3FF46B0", Offset = "0x3FF36B0", VA = "0x183FF46B0")]
	private bool OOCINGAKPFJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x3FF5340", Offset = "0x3FF4340", VA = "0x183FF5340")]
	public JOJICCBKMBL()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public class HFBMMEPCDLM
{
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private static byte[] JNCOHDGFJLD;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private static int DPLNOEOFOIM;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static int ICHAIMIBEGB;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private static BigInteger GDFBBFKEIIP;

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public HFBMMEPCDLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x652BAF0", Offset = "0x652AAF0", VA = "0x18652BAF0")]
	private static string AEHPCHKGFJE(byte[] ICPOAGANOLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x652BC00", Offset = "0x652AC00", VA = "0x18652BC00")]
	public static string PKAAKGDAGEE(byte[] FHNEBAPANCE, bool MGDFGAKHOKG)
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

		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
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
