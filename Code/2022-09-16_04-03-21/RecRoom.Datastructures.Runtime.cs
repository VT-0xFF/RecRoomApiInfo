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
public class AJJKGPAMOCE : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6BDE50", Offset = "0x6BC650", VA = "0x1806BDE50")]
	public AJJKGPAMOCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, EMBDJDNPLDB, HILOHFKFDJI, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x643F60", Offset = "0x642760", VA = "0x180643F60", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6186B0", Offset = "0x616EB0", VA = "0x1806186B0", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x639660", Offset = "0x637E60", VA = "0x180639660", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x86BBC0", Offset = "0x86A3C0", VA = "0x18086BBC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash KEMMPLOELNM);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7BE260", Offset = "0x7BCA60", VA = "0x1807BE260")]
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
	[FHMCECCDLGM]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[SerializeField]
	[HideInInspector]
	[FHMCECCDLGM]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4067EF0", Offset = "0x40666F0", VA = "0x184067EF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4067EB0", Offset = "0x40666B0", VA = "0x184067EB0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4067F30", Offset = "0x4066730", VA = "0x184067F30")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4068140", Offset = "0x4066940", VA = "0x184068140")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x40680B0", Offset = "0x40668B0", VA = "0x1840680B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x718FB0", Offset = "0x7177B0", VA = "0x180718FB0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x771B30", Offset = "0x770330", VA = "0x180771B30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4067E70", Offset = "0x4066670", VA = "0x184067E70")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4068020", Offset = "0x4066820", VA = "0x184068020")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4067AB0", Offset = "0x40662B0", VA = "0x184067AB0")]
	public void CopyBounds(SavedExtents ALBOAABJIJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4067DE0", Offset = "0x40665E0", VA = "0x184067DE0")]
	public void SetLocalSpaceBounds(Bounds DMINLKHNPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7114B0", Offset = "0x70FCB0", VA = "0x1807114B0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4067DD0", Offset = "0x40665D0", VA = "0x184067DD0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x40672E0", Offset = "0x4065AE0", VA = "0x1840672E0")]
	private void BAEGDPCOFNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4067BA0", Offset = "0x40663A0", VA = "0x184067BA0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x40674F0", Offset = "0x4065CF0", VA = "0x1840674F0")]
	public static void CalculateLocalBoundsFor(GameObject KFNNOPCEBCG, out Bounds DMINLKHNPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4067AE0", Offset = "0x40662E0", VA = "0x184067AE0")]
	private static void LPNGLEIFKKC(Bounds FLEBMPFFCAA, Color AFHPHPIIHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4067E00", Offset = "0x4066600", VA = "0x184067E00")]
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
		[Cpp2IlInjected.Address(RVA = "0x5FD1C0", Offset = "0x5FB9C0", VA = "0x1805FD1C0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6AD150", Offset = "0x6AB950", VA = "0x1806AD150")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x643F60", Offset = "0x642760", VA = "0x180643F60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "4")]
	public virtual void NBOBGFKIEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69000", VA = "0x180B6A800")]
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
	[AJJKGPAMOCE]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x12084D0", Offset = "0x1206CD0", VA = "0x1812084D0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1207DA0", Offset = "0x12065A0", VA = "0x181207DA0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1208DD0", Offset = "0x12075D0", VA = "0x181208DD0")]
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
	private sealed class EFDBDNHEPFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69000", VA = "0x180B6A800")]
		public EFDBDNHEPFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5678780", Offset = "0x5676F80", VA = "0x185678780")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[AJJKGPAMOCE]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5FD1C0", Offset = "0x5FB9C0", VA = "0x1805FD1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x567B230", Offset = "0x5679A30", VA = "0x18567B230", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x567B260", Offset = "0x5679A60", VA = "0x18567B260", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x567B180", Offset = "0x5679980", VA = "0x18567B180", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public TVal this[TKey BAGMDNPKAJL]
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x567B1B0", Offset = "0x56799B0", VA = "0x18567B1B0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x567B080", Offset = "0x5679880", VA = "0x18567B080", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x567A8E0", Offset = "0x56790E0", VA = "0x18567A8E0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x567A250", Offset = "0x5678A50", VA = "0x18567A250", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5679EB0", Offset = "0x56786B0", VA = "0x185679EB0", Slot = "14")]
	protected virtual string KBFIHPFGLDH(TKeyVal EJEEFLKFOII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5099C20", Offset = "0x5098420", VA = "0x185099C20", Slot = "4")]
	public bool ContainsKey(TKey BAGMDNPKAJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x567AF70", Offset = "0x5679770", VA = "0x18567AF70", Slot = "5")]
	public bool TryGetValue(TKey BAGMDNPKAJL, out TVal CJMMBFLIBMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5679DC0", Offset = "0x56785C0", VA = "0x185679DC0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5679DC0", Offset = "0x56785C0", VA = "0x185679DC0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x567AFA0", Offset = "0x56797A0", VA = "0x18567AFA0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class FAMBMJFGKED<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class CEKDBCNKENK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69000", VA = "0x180B6A800")]
		public CEKDBCNKENK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x56332C0", Offset = "0x5631AC0", VA = "0x1856332C0")]
		internal bool <GetSamples>b__0(global::EHLFBNJONJP<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float LAMBFAOFGHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float GFEEACLAPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<global::EHLFBNJONJP<float, T>> IJHBOPELDAI;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int PEDMGBLCHKO
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5635370", Offset = "0x5633B70", VA = "0x185635370")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x56356E0", Offset = "0x5633EE0", VA = "0x1856356E0")]
	public FAMBMJFGKED(float BBNDMKDOLBK, float CMKKEAIOJNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5635550", Offset = "0x5633D50", VA = "0x185635550")]
	public bool HALLJCNLIOC(float BNNFMCILBEJ, T CJMMBFLIBMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x56351D0", Offset = "0x56339D0", VA = "0x1856351D0")]
	public int CGNHLEOHDBO(float BNNFMCILBEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5634E90", Offset = "0x5633690", VA = "0x185634E90")]
	public IEnumerable<T> AJPDMEPMCMM(float BNNFMCILBEJ, [Optional] float? CCDKADADCHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x56356B0", Offset = "0x5633EB0", VA = "0x1856356B0")]
	public void IDPJIGKEBOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5635230", Offset = "0x5633A30", VA = "0x185635230")]
	private void EOBKPGJKHKK(float BNNFMCILBEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class CMAKMGMLINA<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct OENFPAGGOCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T EJFMLMNCFJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float KGKIMJCCAAB;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float EDENOLKIKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> LEFOLODOLDA;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int DBEKMILHKHL = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private OENFPAGGOCK[] FPMNAPBFAMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int BEALBNLCOFB;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float ELMFBJJDEJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA44350", Offset = "0xA42B50", VA = "0x180A44350")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xCA5BC0", Offset = "0xCA43C0", VA = "0x180CA5BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x55A8CF0", Offset = "0x55A74F0", VA = "0x1855A8CF0")]
	public CMAKMGMLINA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x55A8D20", Offset = "0x55A7520", VA = "0x1855A8D20")]
	public CMAKMGMLINA(int OCAKIKBDFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x55A8630", Offset = "0x55A6E30", VA = "0x1855A8630")]
	public void NLKJJINIDJF(float BNNFMCILBEJ, T CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x55A7F20", Offset = "0x55A6720", VA = "0x1855A7F20")]
	public void IDPJIGKEBOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x55A88C0", Offset = "0x55A70C0", VA = "0x1855A88C0")]
	public bool PMIHKINDPPP(float DOMJLOMMHIO, float EFKNPEEDJFC, out T CJMMBFLIBMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x55A7AD0", Offset = "0x55A62D0", VA = "0x1855A7AD0")]
	public bool CBNHPEMHLNK(float DOMJLOMMHIO, float EFKNPEEDJFC, out T CJMMBFLIBMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x55A80A0", Offset = "0x55A68A0", VA = "0x1855A80A0")]
	public void MHFONILMIFM(float DOMJLOMMHIO, float EFKNPEEDJFC, List<T> POKOCMHLPLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x55A8070", Offset = "0x55A6870", VA = "0x1855A8070")]
	private int KDELBBALPFC(int PACIDOFKIHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x55A7C40", Offset = "0x55A6440", VA = "0x1855A7C40")]
	private void HDLHCBOKIGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T KBJNMNFIAFM();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T CEBPAJKBEOB(T MEHHMGBDHKJ, T MLOFKBADEJB, float JFBIOCFAFEC);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T GBOHJJOBPEE(T CJMMBFLIBMO, float JFBIOCFAFEC);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T KJNKPMOONLM(T MEHHMGBDHKJ, T MLOFKBADEJB);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T HPJFOAHHJAN(T MEHHMGBDHKJ, T MLOFKBADEJB);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class AIGNHMAALOE : global::CMAKMGMLINA<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x405F520", Offset = "0x405DD20", VA = "0x18405F520", Slot = "4")]
	protected override Vector3 KBJNMNFIAFM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x405F350", Offset = "0x405DB50", VA = "0x18405F350", Slot = "5")]
	protected override Vector3 CEBPAJKBEOB(Vector3 MEHHMGBDHKJ, Vector3 MLOFKBADEJB, float JFBIOCFAFEC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x405F410", Offset = "0x405DC10", VA = "0x18405F410", Slot = "6")]
	protected override Vector3 GBOHJJOBPEE(Vector3 CJMMBFLIBMO, float JFBIOCFAFEC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x405F590", Offset = "0x405DD90", VA = "0x18405F590", Slot = "7")]
	protected override Vector3 KJNKPMOONLM(Vector3 MEHHMGBDHKJ, Vector3 MLOFKBADEJB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x405F4B0", Offset = "0x405DCB0", VA = "0x18405F4B0", Slot = "8")]
	protected override Vector3 HPJFOAHHJAN(Vector3 MEHHMGBDHKJ, Vector3 MLOFKBADEJB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x405F640", Offset = "0x405DE40", VA = "0x18405F640")]
	public AIGNHMAALOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class EOGBFKIKINA : global::CMAKMGMLINA<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4060850", Offset = "0x405F050", VA = "0x184060850")]
	public EOGBFKIKINA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x40608B0", Offset = "0x405F0B0", VA = "0x1840608B0")]
	public EOGBFKIKINA(int OCAKIKBDFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x81E9A0", Offset = "0x81D1A0", VA = "0x18081E9A0", Slot = "4")]
	protected override float KBJNMNFIAFM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x40607B0", Offset = "0x405EFB0", VA = "0x1840607B0", Slot = "5")]
	protected override float CEBPAJKBEOB(float MEHHMGBDHKJ, float MLOFKBADEJB, float JFBIOCFAFEC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2AE73E0", Offset = "0x2AE5BE0", VA = "0x182AE73E0", Slot = "6")]
	protected override float GBOHJJOBPEE(float CJMMBFLIBMO, float JFBIOCFAFEC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4060840", Offset = "0x405F040", VA = "0x184060840", Slot = "7")]
	protected override float KJNKPMOONLM(float MEHHMGBDHKJ, float MLOFKBADEJB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4060830", Offset = "0x405F030", VA = "0x184060830", Slot = "8")]
	protected override float HPJFOAHHJAN(float MEHHMGBDHKJ, float MLOFKBADEJB)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class NHGDLNIPBGF
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xC75D40", Offset = "0xC74540", VA = "0x180C75D40")]
	public static global::PGNNDJLANDN<T1> BHNJDAHDLKD<T1>(T1 EPKEEPFIJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x525DFD0", Offset = "0x525C7D0", VA = "0x18525DFD0")]
	public static global::EHLFBNJONJP<T1, T2> BHNJDAHDLKD<T1, T2>(T1 EPKEEPFIJAA, T2 DCIOHIBOLPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x525E040", Offset = "0x525C840", VA = "0x18525E040")]
	public static global::IFCOOCOEGJH<T1, T2, T3> BHNJDAHDLKD<T1, T2, T3>(T1 EPKEEPFIJAA, T2 DCIOHIBOLPC, T3 GOFKDHPJGHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1197540", Offset = "0x1195D40", VA = "0x181197540")]
	public static global::IBOINEKJKDB<T1, T2, T3, T4> BHNJDAHDLKD<T1, T2, T3, T4>(T1 EPKEEPFIJAA, T2 DCIOHIBOLPC, T3 GOFKDHPJGHC, T4 PGOENIEDPIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xDAE580", Offset = "0xDACD80", VA = "0x180DAE580")]
	public static global::LFNHHEMGNBD<T1, T2, T3, T4, T5> BHNJDAHDLKD<T1, T2, T3, T4, T5>(T1 EPKEEPFIJAA, T2 DCIOHIBOLPC, T3 GOFKDHPJGHC, T4 PGOENIEDPIG, T5 COJKPPDCFKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xDAE4D0", Offset = "0xDACCD0", VA = "0x180DAE4D0")]
	public static global::NBNJONFLCBO<T1, T2, T3, T4, T5, T6> BHNJDAHDLKD<T1, T2, T3, T4, T5, T6>(T1 EPKEEPFIJAA, T2 DCIOHIBOLPC, T3 GOFKDHPJGHC, T4 PGOENIEDPIG, T5 COJKPPDCFKI, T6 MAPKLICCNAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1198300", Offset = "0x1196B00", VA = "0x181198300")]
	public static global::EANGBGPEFHN<T1, T2, T3, T4, T5, T6, T7> BHNJDAHDLKD<T1, T2, T3, T4, T5, T6, T7>(T1 EPKEEPFIJAA, T2 DCIOHIBOLPC, T3 GOFKDHPJGHC, T4 PGOENIEDPIG, T5 COJKPPDCFKI, T6 MAPKLICCNAM, T7 LGLMPNJIKKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xDAE400", Offset = "0xDACC00", VA = "0x180DAE400")]
	public static global::PMLPPBMGFHB<T1, T2, T3, T4, T5, T6, T7, T8> BHNJDAHDLKD<T1, T2, T3, T4, T5, T6, T7, T8>(T1 EPKEEPFIJAA, T2 DCIOHIBOLPC, T3 GOFKDHPJGHC, T4 PGOENIEDPIG, T5 COJKPPDCFKI, T6 MAPKLICCNAM, T7 LGLMPNJIKKB, T8 CDENBCFDGEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8EFDE0", Offset = "0x8EE5E0", VA = "0x1808EFDE0")]
	[IteratorStateMachine(typeof(KMMBPHDNHLH))]
	public static IEnumerable<global::EHLFBNJONJP<T1, T2>> HIPLNHCCKHJ<T1, T2>(IEnumerable<T1> DKLHMFCLOAB, IEnumerable<T2> FLEBMPFFCAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8F20B0", Offset = "0x8F08B0", VA = "0x1808F20B0")]
	[IteratorStateMachine(typeof(LKHMOIKGMCE))]
	public static IEnumerable<global::IFCOOCOEGJH<T1, T2, T3>> HIPLNHCCKHJ<T1, T2, T3>(IEnumerable<T1> DKLHMFCLOAB, IEnumerable<T2> FLEBMPFFCAA, IEnumerable<T3> AFHPHPIIHBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1848850", Offset = "0x1847050", VA = "0x181848850")]
	internal static int JCLLOIOFKNB(int AMKACKDJHCJ, int PKDNCCGKDNK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x27E6EF0", Offset = "0x27E56F0", VA = "0x1827E6EF0")]
	internal static int JCLLOIOFKNB(int AMKACKDJHCJ, int PKDNCCGKDNK, int KJLEBLIIPGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x27E6F00", Offset = "0x27E5700", VA = "0x1827E6F00")]
	internal static int JCLLOIOFKNB(int AMKACKDJHCJ, int PKDNCCGKDNK, int KJLEBLIIPGI, int LNMOJJILMGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4064CD0", Offset = "0x40634D0", VA = "0x184064CD0")]
	internal static int JCLLOIOFKNB(int AMKACKDJHCJ, int PKDNCCGKDNK, int KJLEBLIIPGI, int LNMOJJILMGM, int KHJJAJBGJGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4064CF0", Offset = "0x40634F0", VA = "0x184064CF0")]
	internal static int JCLLOIOFKNB(int AMKACKDJHCJ, int PKDNCCGKDNK, int KJLEBLIIPGI, int LNMOJJILMGM, int KHJJAJBGJGA, int PPJLOAALOMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4064CA0", Offset = "0x40634A0", VA = "0x184064CA0")]
	internal static int JCLLOIOFKNB(int AMKACKDJHCJ, int PKDNCCGKDNK, int KJLEBLIIPGI, int LNMOJJILMGM, int KHJJAJBGJGA, int PPJLOAALOMD, int HECCNJOHPBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4064C70", Offset = "0x4063470", VA = "0x184064C70")]
	internal static int JCLLOIOFKNB(int AMKACKDJHCJ, int PKDNCCGKDNK, int KJLEBLIIPGI, int LNMOJJILMGM, int KHJJAJBGJGA, int PPJLOAALOMD, int HECCNJOHPBB, int FLFFLDLJEOL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class PGNNDJLANDN<T1> : IComparable<global::PGNNDJLANDN<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T1 EGDOBBGFFMJ;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xE2F290", Offset = "0xE2DA90", VA = "0x180E2F290")]
	public PGNNDJLANDN(T1 EPKEEPFIJAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4F976C0", Offset = "0x4F95EC0", VA = "0x184F976C0", Slot = "4")]
	public int CompareTo(global::PGNNDJLANDN<T1> ALBOAABJIJF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4F97730", Offset = "0x4F95F30", VA = "0x184F97730", Slot = "0")]
	public override bool Equals(object ALBOAABJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x9A5F90", Offset = "0x9A4790", VA = "0x1809A5F90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4F977D0", Offset = "0x4F95FD0", VA = "0x184F977D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class EHLFBNJONJP<T1, T2> : IComparable<global::EHLFBNJONJP<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 EGDOBBGFFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 LDBFKBAFPII;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5666530", Offset = "0x5664D30", VA = "0x185666530")]
	public EHLFBNJONJP(T1 EPKEEPFIJAA, T2 DCIOHIBOLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5664AB0", Offset = "0x56632B0", VA = "0x185664AB0", Slot = "4")]
	public int CompareTo(global::EHLFBNJONJP<T1, T2> ALBOAABJIJF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x56653D0", Offset = "0x5663BD0", VA = "0x1856653D0", Slot = "0")]
	public override bool Equals(object ALBOAABJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x56657E0", Offset = "0x5663FE0", VA = "0x1856657E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5665D20", Offset = "0x5664520", VA = "0x185665D20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class IFCOOCOEGJH<T1, T2, T3> : IComparable<global::IFCOOCOEGJH<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T1 EGDOBBGFFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T2 LDBFKBAFPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T3 HMMFBINJKDI;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x549DCA0", Offset = "0x549C4A0", VA = "0x18549DCA0")]
	public IFCOOCOEGJH(T1 EPKEEPFIJAA, T2 DCIOHIBOLPC, T3 GOFKDHPJGHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x549D5C0", Offset = "0x549BDC0", VA = "0x18549D5C0", Slot = "4")]
	public int CompareTo(global::IFCOOCOEGJH<T1, T2, T3> ALBOAABJIJF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x549D6C0", Offset = "0x549BEC0", VA = "0x18549D6C0", Slot = "0")]
	public override bool Equals(object ALBOAABJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x549D9B0", Offset = "0x549C1B0", VA = "0x18549D9B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x549DA20", Offset = "0x549C220", VA = "0x18549DA20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class IBOINEKJKDB<T1, T2, T3, T4> : IComparable<global::IBOINEKJKDB<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T1 EGDOBBGFFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T2 LDBFKBAFPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T3 HMMFBINJKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T4 AJMIJBNDOOD;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xE2C980", Offset = "0xE2B180", VA = "0x180E2C980")]
	public IBOINEKJKDB(T1 EPKEEPFIJAA, T2 DCIOHIBOLPC, T3 GOFKDHPJGHC, T4 PGOENIEDPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x535F1C0", Offset = "0x535D9C0", VA = "0x18535F1C0", Slot = "4")]
	public int CompareTo(global::IBOINEKJKDB<T1, T2, T3, T4> ALBOAABJIJF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x535F300", Offset = "0x535DB00", VA = "0x18535F300", Slot = "0")]
	public override bool Equals(object ALBOAABJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x535F420", Offset = "0x535DC20", VA = "0x18535F420", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x535F4E0", Offset = "0x535DCE0", VA = "0x18535F4E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class LFNHHEMGNBD<T1, T2, T3, T4, T5> : IComparable<global::LFNHHEMGNBD<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T1 EGDOBBGFFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T2 LDBFKBAFPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T3 HMMFBINJKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T4 AJMIJBNDOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T5 IBCHDMNEPCI;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x546E100", Offset = "0x546C900", VA = "0x18546E100")]
	public LFNHHEMGNBD(T1 EPKEEPFIJAA, T2 DCIOHIBOLPC, T3 GOFKDHPJGHC, T4 PGOENIEDPIG, T5 COJKPPDCFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x546DC10", Offset = "0x546C410", VA = "0x18546DC10", Slot = "4")]
	public int CompareTo(global::LFNHHEMGNBD<T1, T2, T3, T4, T5> ALBOAABJIJF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x546DD90", Offset = "0x546C590", VA = "0x18546DD90", Slot = "0")]
	public override bool Equals(object ALBOAABJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x546DED0", Offset = "0x546C6D0", VA = "0x18546DED0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x546DFD0", Offset = "0x546C7D0", VA = "0x18546DFD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class NBNJONFLCBO<T1, T2, T3, T4, T5, T6> : IComparable<global::NBNJONFLCBO<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T1 EGDOBBGFFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T2 LDBFKBAFPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T3 HMMFBINJKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T4 AJMIJBNDOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T5 IBCHDMNEPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T6 GKEIIHOAEEB;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5780010", Offset = "0x577E810", VA = "0x185780010")]
	public NBNJONFLCBO(T1 EPKEEPFIJAA, T2 DCIOHIBOLPC, T3 GOFKDHPJGHC, T4 PGOENIEDPIG, T5 COJKPPDCFKI, T6 MAPKLICCNAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x577FA70", Offset = "0x577E270", VA = "0x18577FA70", Slot = "4")]
	public int CompareTo(global::NBNJONFLCBO<T1, T2, T3, T4, T5, T6> ALBOAABJIJF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x577FC30", Offset = "0x577E430", VA = "0x18577FC30", Slot = "0")]
	public override bool Equals(object ALBOAABJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x577FDA0", Offset = "0x577E5A0", VA = "0x18577FDA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x577FEC0", Offset = "0x577E6C0", VA = "0x18577FEC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class EANGBGPEFHN<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::EANGBGPEFHN<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T1 EGDOBBGFFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T2 LDBFKBAFPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T3 HMMFBINJKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T4 AJMIJBNDOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T5 IBCHDMNEPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T6 GKEIIHOAEEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T7 JKLEEPOOOBB;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5417F80", Offset = "0x5416780", VA = "0x185417F80")]
	public EANGBGPEFHN(T1 EPKEEPFIJAA, T2 DCIOHIBOLPC, T3 GOFKDHPJGHC, T4 PGOENIEDPIG, T5 COJKPPDCFKI, T6 MAPKLICCNAM, T7 LGLMPNJIKKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5417920", Offset = "0x5416120", VA = "0x185417920", Slot = "4")]
	public int CompareTo(global::EANGBGPEFHN<T1, T2, T3, T4, T5, T6, T7> ALBOAABJIJF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5417B20", Offset = "0x5416320", VA = "0x185417B20", Slot = "0")]
	public override bool Equals(object ALBOAABJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5417CC0", Offset = "0x54164C0", VA = "0x185417CC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5417E10", Offset = "0x5416610", VA = "0x185417E10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class PMLPPBMGFHB<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::PMLPPBMGFHB<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T1 EGDOBBGFFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T2 LDBFKBAFPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T3 HMMFBINJKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T4 AJMIJBNDOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T5 IBCHDMNEPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T6 GKEIIHOAEEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly T7 JKLEEPOOOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly T8 BEOIKLDGEAB;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4FA1D10", Offset = "0x4FA0510", VA = "0x184FA1D10")]
	public PMLPPBMGFHB(T1 EPKEEPFIJAA, T2 DCIOHIBOLPC, T3 GOFKDHPJGHC, T4 PGOENIEDPIG, T5 COJKPPDCFKI, T6 MAPKLICCNAM, T7 LGLMPNJIKKB, T8 CDENBCFDGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4FA1600", Offset = "0x4F9FE00", VA = "0x184FA1600", Slot = "4")]
	public int CompareTo(global::PMLPPBMGFHB<T1, T2, T3, T4, T5, T6, T7, T8> ALBOAABJIJF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4FA1850", Offset = "0x4FA0050", VA = "0x184FA1850", Slot = "0")]
	public override bool Equals(object ALBOAABJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4FA1A10", Offset = "0x4FA0210", VA = "0x184FA1A10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4FA1B80", Offset = "0x4FA0380", VA = "0x184FA1B80", Slot = "3")]
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
	public T EJFMLMNCFJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x638B30", Offset = "0x637330", VA = "0x180638B30")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x671B60", Offset = "0x670360", VA = "0x180671B60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float GFMEIJHKOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x771B20", Offset = "0x770320", VA = "0x180771B20")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2DF6AB0", Offset = "0x2DF52B0", VA = "0x182DF6AB0")]
	public T DFIDBJFBJMM(float JFBIOCFAFEC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2DF6B70", Offset = "0x2DF5370", VA = "0x182DF6B70")]
	public T EHAFCACPFHH(float JFBIOCFAFEC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T CEBPAJKBEOB(T MEHHMGBDHKJ, T MLOFKBADEJB, float JFBIOCFAFEC);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69000", VA = "0x180B6A800")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4060980", Offset = "0x405F180", VA = "0x184060980", Slot = "4")]
	protected override float CEBPAJKBEOB(float MEHHMGBDHKJ, float MLOFKBADEJB, float JFBIOCFAFEC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4060A00", Offset = "0x405F200", VA = "0x184060A00")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x40690A0", Offset = "0x40678A0", VA = "0x1840690A0", Slot = "4")]
	protected override Vector3 CEBPAJKBEOB(Vector3 MEHHMGBDHKJ, Vector3 MLOFKBADEJB, float JFBIOCFAFEC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4069160", Offset = "0x4067960", VA = "0x184069160")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4060000", Offset = "0x405E800", VA = "0x184060000", Slot = "4")]
	protected override Color CEBPAJKBEOB(Color MEHHMGBDHKJ, Color MLOFKBADEJB, float JFBIOCFAFEC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4060050", Offset = "0x405E850", VA = "0x184060050")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class MMDMFPOGLEM : global::NAPMFIKNDHI<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4064C20", Offset = "0x4063420", VA = "0x184064C20")]
	public MMDMFPOGLEM(int JPMPKCEDKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4064BC0", Offset = "0x40633C0", VA = "0x184064BC0")]
	public MMDMFPOGLEM(BBADLLOEOEA[] LAMLPNDDOBD, bool NPPLGDPAHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4064B50", Offset = "0x4063350", VA = "0x184064B50", Slot = "6")]
	protected override uint GJJGBGCGDBC(uint KEMMPLOELNM, string CJMMBFLIBMO)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class GKHKJNKHLJM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly IDisposable AAMGPJBHPCK;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public GKHKJNKHLJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DebuggerTypeProxy(typeof(global::PNEFGFFBMJN<>.AOAMAEFEOJL))]
[DefaultMember("Item")]
public sealed class PNEFGFFBMJN<T> : IDisposable, global::MDLPPIBKKCG<T>, DANHMCCPOCB, global::MHAAIADGNFP<T, global::PNEFGFFBMJN<T>.NDKINIFJAKC>, global::BKCBENEOFGP<T>, global::FGDDHFELANO<T, global::PNEFGFFBMJN<T>.NDKINIFJAKC>, global::EPEFAELFJAF<T>, global::EEBGDDHEMEI<T, global::PNEFGFFBMJN<T>.NDKINIFJAKC>, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public struct NDKINIFJAKC : DANHMCCPOCB, global::PFEHJNIIGHF<T>, global::INPNLBBHJMP<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly global::PNEFGFFBMJN<T> HGOACAIFHND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private int GPJLIKKKBFE;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int KKHILPEBPDN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x4E869E0", Offset = "0x4E851E0", VA = "0x184E869E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public T HLHDNNKPFLO
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x4F96A60", Offset = "0x4F95260", VA = "0x184F96A60", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private T NNGNHDOFFPK
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x4F96370", Offset = "0x4F94B70", VA = "0x184F96370", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x4F966E0", Offset = "0x4F94EE0", VA = "0x184F966E0", Slot = "7")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x4F968D0", Offset = "0x4F950D0", VA = "0x184F968D0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x217A280", Offset = "0x2178A80", VA = "0x18217A280")]
		private NDKINIFJAKC(global::PNEFGFFBMJN<T> KBMECNBEFEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x4F96430", Offset = "0x4F94C30", VA = "0x184F96430")]
		public static NDKINIFJAKC DKPJNJAIMAF(global::PNEFGFFBMJN<T> KBMECNBEFEN)
		{
			return default(NDKINIFJAKC);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x4F96490", Offset = "0x4F94C90", VA = "0x184F96490", Slot = "9")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x217A120", Offset = "0x2178920", VA = "0x18217A120", Slot = "11")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "8")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class AOAMAEFEOJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly global::PNEFGFFBMJN<T> HGOACAIFHND;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public int KKHILPEBPDN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xE2A530", Offset = "0xE28D30", VA = "0x180E2A530")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public T[] GBOKIJNALFI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x4F92420", Offset = "0x4F90C20", VA = "0x184F92420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool JAADKEOKHCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x4F92360", Offset = "0x4F90B60", VA = "0x184F92360")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xE2F290", Offset = "0xE2DA90", VA = "0x180E2F290")]
		public AOAMAEFEOJL(global::PNEFGFFBMJN<T> KBMECNBEFEN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly LOHIPHPIABC BHICKHAMAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private T[] BFIJGJMKNMM;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int KKHILPEBPDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x653E50", Offset = "0x652650", VA = "0x180653E50", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6FEC10", Offset = "0x6FD410", VA = "0x1806FEC10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Span<T> GBOKIJNALFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4FA36E0", Offset = "0x4FA1EE0", VA = "0x184FA36E0")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T PPDDKLFCHKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x4FA1EE0", Offset = "0x4FA06E0", VA = "0x184FA1EE0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public T EEBALKKHLJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x4FA1EE0", Offset = "0x4FA06E0", VA = "0x184FA1EE0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public T NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x4FA1EA0", Offset = "0x4FA06A0", VA = "0x184FA1EA0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4FA1FC0", Offset = "0x4FA07C0", VA = "0x184FA1FC0")]
	public static global::PNEFGFFBMJN<T> DKPJNJAIMAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4FA2CC0", Offset = "0x4FA14C0", VA = "0x184FA2CC0")]
	public static global::PNEFGFFBMJN<T> KNBKNFEEMOG(int JPMPKCEDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4FA4860", Offset = "0x4FA3060", VA = "0x184FA4860")]
	internal PNEFGFFBMJN(T[] DPIAJOPMEKF, int FKDPJOHPNNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4FA21C0", Offset = "0x4FA09C0", VA = "0x184FA21C0", Slot = "5")]
	public T HLLKGMNONNE(int GDBELOJNNFN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4FA2100", Offset = "0x4FA0900", VA = "0x184FA2100", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4FA34D0", Offset = "0x4FA1CD0", VA = "0x184FA34D0")]
	public void NLKJJINIDJF(in T CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4FA2A60", Offset = "0x4FA1260", VA = "0x184FA2A60")]
	public void JKMEJHNIIKP(int AKLHCIJHJKB, in T CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x4FA3350", Offset = "0x4FA1B50", VA = "0x184FA3350")]
	public void NGEIKIGMGGE(int AKLHCIJHJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4FA4170", Offset = "0x4FA2970", VA = "0x184FA4170")]
	public void PJIGHCEIKLK(int OCAKIKBDFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x4FA2220", Offset = "0x4FA0A20", VA = "0x184FA2220")]
	private void IOHKIBCLCNA(int JPMPKCEDKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4FA21F0", Offset = "0x4FA09F0", VA = "0x184FA21F0")]
	public void IDPJIGKEBOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x4FA2FD0", Offset = "0x4FA17D0", VA = "0x184FA2FD0")]
	public global::PNEFGFFBMJN<T> LGOGCJIBEJA(global::DGIDCCJAHGO<T, T> KICAKNDCIIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4FA2180", Offset = "0x4FA0980", VA = "0x184FA2180", Slot = "11")]
	public NDKINIFJAKC GetEnumerator()
	{
		return default(NDKINIFJAKC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4FA1F40", Offset = "0x4FA0740", VA = "0x184FA1F40", Slot = "8")]
	private global::PFEHJNIIGHF<T> IJKHLMPOKMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4FA1F40", Offset = "0x4FA0740", VA = "0x184FA1F40", Slot = "10")]
	private global::INPNLBBHJMP<T> COAKAMGDBHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4FA1F40", Offset = "0x4FA0740", VA = "0x184FA1F40", Slot = "12")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4FA1F40", Offset = "0x4FA0740", VA = "0x184FA1F40", Slot = "13")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class PGODOIAFILI
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0xFA8370", Offset = "0xFA6B70", VA = "0x180FA8370")]
	public static bool NHMHJBCNECA<T>(this global::PNEFGFFBMJN<T> KBMECNBEFEN, in T CJMMBFLIBMO) where T : global::AGGNMDONOEO<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct KILKCEBEMPC
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class OHHJGKMDIIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public TaskCompletionSource<OKGJCEGJEIG> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public OHHJGKMDIIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x4066040", Offset = "0x4064840", VA = "0x184066040")]
		internal void <StartRequest>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<OKGJCEGJEIG>> BAHMBAIPKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private int CAAKNEIEFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private int NFLCAJHGHBB;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x15909C0", Offset = "0x158F1C0", VA = "0x1815909C0")]
	private KILKCEBEMPC(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<OKGJCEGJEIG>> DNBGOPGIMDJ, int DGJDIIFJKKG, int PGEOIOKCFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4062610", Offset = "0x4060E10", VA = "0x184062610")]
	public static KILKCEBEMPC DKPJNJAIMAF()
	{
		return default(KILKCEBEMPC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4062740", Offset = "0x4060F40", VA = "0x184062740")]
	public (int, int, Task) OJOMCFGOIBC(int BLIBBDMMEKO, [Optional] CancellationToken NFKHAKHIBIO)
	{
		return default((int, int, Task));
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4062690", Offset = "0x4060E90", VA = "0x184062690")]
	public void JLAKIGOGDOE(int BLIBBDMMEKO, int PGEOIOKCFAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class ILJNFINGOEI<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly Dictionary<TKey, TVal> FHJEIHMBHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly Dictionary<TVal, TKey> IKBMJKEGJFF;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int KKHILPEBPDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xE2A530", Offset = "0xE28D30", VA = "0x180E2A530", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool FKKNEPJPEKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x604020", Offset = "0x602820", VA = "0x180604020", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public ICollection<TKey> CFIPAICBBJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3053170", Offset = "0x3051970", VA = "0x183053170", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public ICollection<TVal> JLADKMKLLAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xE2A9E0", Offset = "0xE291E0", VA = "0x180E2A9E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public TVal NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x50FC4C0", Offset = "0x50FACC0", VA = "0x1850FC4C0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x50FC4F0", Offset = "0x50FACF0", VA = "0x1850FC4F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public TKey NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x50FB770", Offset = "0x50F9F70", VA = "0x1850FB770")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x50FB7A0", Offset = "0x50F9FA0", VA = "0x1850FB7A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x50FB9C0", Offset = "0x50FA1C0", VA = "0x1850FB9C0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x50FC340", Offset = "0x50FAB40", VA = "0x1850FC340", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x50FB820", Offset = "0x50FA020", VA = "0x1850FB820", Slot = "9")]
	public void Add(TKey BAGMDNPKAJL, TVal CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x50FB850", Offset = "0x50FA050", VA = "0x1850FB850", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> FJMIPHLNAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x1F91950", Offset = "0x1F90150", VA = "0x181F91950", Slot = "8")]
	public bool ContainsKey(TKey BAGMDNPKAJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0xE2AD50", Offset = "0xE29550", VA = "0x180E2AD50", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> FJMIPHLNAEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x50FC2E0", Offset = "0x50FAAE0", VA = "0x1850FC2E0", Slot = "10")]
	public bool Remove(TKey BAGMDNPKAJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x50FC2E0", Offset = "0x50FAAE0", VA = "0x1850FC2E0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> FJMIPHLNAEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0xE2AAA0", Offset = "0xE292A0", VA = "0x180E2AAA0", Slot = "11")]
	public bool TryGetValue(TKey BAGMDNPKAJL, out TVal CJMMBFLIBMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x50FBB30", Offset = "0x50FA330", VA = "0x1850FBB30", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x50FBA50", Offset = "0x50FA250", VA = "0x1850FBA50", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] FPMNAPBFAMJ, int DDFINIJOFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x50FC160", Offset = "0x50FA960", VA = "0x1850FC160")]
	public void NLKJJINIDJF(TVal OKHMGJIMEEL, TKey BAGMDNPKAJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x50FC120", Offset = "0x50FA920", VA = "0x1850FC120")]
	public void NLKJJINIDJF(KeyValuePair<TVal, TKey> FJMIPHLNAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x50FBF10", Offset = "0x50FA710", VA = "0x1850FBF10")]
	public bool LDBAKCLKFMM(TVal BAGMDNPKAJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x50FBEB0", Offset = "0x50FA6B0", VA = "0x1850FBEB0")]
	public bool JNEGJNMGLPF(KeyValuePair<TVal, TKey> FJMIPHLNAEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x50FC050", Offset = "0x50FA850", VA = "0x1850FC050")]
	public bool NHIAFFMKOAF(TVal BAGMDNPKAJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x50FC050", Offset = "0x50FA850", VA = "0x1850FC050")]
	public bool NHIAFFMKOAF(KeyValuePair<TVal, TKey> FJMIPHLNAEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x50FC2B0", Offset = "0x50FAAB0", VA = "0x1850FC2B0")]
	public bool PJOHNGKNBEM(TVal BAGMDNPKAJL, out TKey CJMMBFLIBMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x50FB940", Offset = "0x50FA140", VA = "0x1850FB940")]
	public IEnumerator<KeyValuePair<TVal, TKey>> BCGMHIIOJNF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x50FBFD0", Offset = "0x50FA7D0", VA = "0x1850FBFD0")]
	private void LIPNAANBLFK(TKey BAGMDNPKAJL, TVal OKHMGJIMEEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x50FC230", Offset = "0x50FAA30", VA = "0x1850FC230")]
	private void PBHMLICHMOF(TKey BAGMDNPKAJL, TVal OKHMGJIMEEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x50FBBB0", Offset = "0x50FA3B0", VA = "0x1850FBBB0")]
	private bool HADBHECFFLJ(TKey BAGMDNPKAJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x50FBD30", Offset = "0x50FA530", VA = "0x1850FBD30")]
	private bool HADBHECFFLJ(TVal OKHMGJIMEEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x50FC3E0", Offset = "0x50FABE0", VA = "0x1850FC3E0")]
	public ILJNFINGOEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class OMAPCCJFDJJ<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private global::OMAPCCJFDJJ<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xA44350", Offset = "0xA42B50", VA = "0x180A44350", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x55C8650", Offset = "0x55C6E50", VA = "0x1855C8650", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x55C8A10", Offset = "0x55C7210", VA = "0x1855C8A10")]
		public Enumerator(global::OMAPCCJFDJJ<T> POKOCMHLPLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x55C7E10", Offset = "0x55C6610", VA = "0x1855C7E10", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x55C8410", Offset = "0x55C6C10", VA = "0x1855C8410", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x55C81C0", Offset = "0x55C69C0", VA = "0x1855C81C0")]
		private void NNMGBNHHHIL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private T[] CMBMOFEOOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private int DABGAKHOBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private int IGJEBLJGMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private int KAGEGNEPBEI;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int KKHILPEBPDN
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x55DA560", Offset = "0x55D8D60", VA = "0x1855DA560")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public T NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x55D9100", Offset = "0x55D7900", VA = "0x1855D9100")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x55D92C0", Offset = "0x55D7AC0", VA = "0x1855D92C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x55DB050", Offset = "0x55D9850", VA = "0x1855DB050")]
	public OMAPCCJFDJJ(int JPMPKCEDKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x55DAC50", Offset = "0x55D9450", VA = "0x1855DAC50")]
	public void NLKJJINIDJF(T JFBIOCFAFEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x55DA100", Offset = "0x55D8900", VA = "0x1855DA100")]
	public void JBOKHFIKBGN(IEnumerable<T> PPFAJDNMMKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x55D97C0", Offset = "0x55D7FC0", VA = "0x1855D97C0")]
	public void IDPJIGKEBOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x55D9730", Offset = "0x55D7F30", VA = "0x1855D9730")]
	public void FIODMJKFHME(int FKDPJOHPNNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x55DADD0", Offset = "0x55D95D0", VA = "0x1855DADD0")]
	public void ONIIDLADAMH(int FKDPJOHPNNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x55DA990", Offset = "0x55D9190", VA = "0x1855DA990")]
	public void MMLIBPLAGIG(T[] FPMNAPBFAMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x55DA400", Offset = "0x55D8C00", VA = "0x1855DA400")]
	public Enumerator JMGPEBMNFFJ()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x55DAF10", Offset = "0x55D9710", VA = "0x1855DAF10", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x55DAF10", Offset = "0x55D9710", VA = "0x1855DAF10", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x55D9340", Offset = "0x55D7B40", VA = "0x1855D9340")]
	private int BFLFKNHIKDD(int AKLHCIJHJKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x55D9700", Offset = "0x55D7F00", VA = "0x1855D9700")]
	private int CPGNDLDAMPN(int AKLHCIJHJKB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct DMIAHMNGIBK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly IDisposable[] BFIJGJMKNMM;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6DA260", Offset = "0x6D8A60", VA = "0x1806DA260")]
	public DMIAHMNGIBK(params IDisposable[] DPIAJOPMEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x19F9770", Offset = "0x19F7F70", VA = "0x1819F9770")]
	public static DMIAHMNGIBK DKPJNJAIMAF(params IDisposable[] DPIAJOPMEKF)
	{
		return default(DMIAHMNGIBK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x4060690", Offset = "0x405EE90", VA = "0x184060690", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct KIBOKJEDDDG<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly IDisposable AOKBBEFJPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public T EJFMLMNCFJG;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x53F35D0", Offset = "0x53F1DD0", VA = "0x1853F35D0")]
	public KIBOKJEDDDG(IDisposable MHMHPHOEJMA, in T CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0xDAB750", Offset = "0xDA9F50", VA = "0x180DAB750")]
	public static global::KIBOKJEDDDG<U> MOHGDJNMEBB<U>(in global::KIBOKJEDDDG<T> MHMHPHOEJMA, in U CJMMBFLIBMO)
	{
		return default(global::KIBOKJEDDDG<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0xDA5F60", Offset = "0xDA4760", VA = "0x180DA5F60")]
	public global::KIBOKJEDDDG<U> HHFJFBBBDEP<U>(in U CJMMBFLIBMO)
	{
		return default(global::KIBOKJEDDDG<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0xDAB4F0", Offset = "0xDA9CF0", VA = "0x180DAB4F0")]
	public static global::KIBOKJEDDDG<(T, U)> BDMLPPGAILE<U>(in global::KIBOKJEDDDG<T> DKLHMFCLOAB, in global::KIBOKJEDDDG<U> FLEBMPFFCAA)
	{
		return default(global::KIBOKJEDDDG<(T, U)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x55E82D0", Offset = "0x55E6AD0", VA = "0x1855E82D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class JPBHCBAGFON
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0xDA5F10", Offset = "0xDA4710", VA = "0x180DA5F10")]
	public static global::KIBOKJEDDDG<T> DKPJNJAIMAF<T>(IDisposable MHMHPHOEJMA, in T CJMMBFLIBMO)
	{
		return default(global::KIBOKJEDDDG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0xDA5F60", Offset = "0xDA4760", VA = "0x180DA5F60")]
	public static global::KIBOKJEDDDG<U> MOHGDJNMEBB<U, T>(in global::KIBOKJEDDDG<T> NLBMJKMKDLE, in U CJMMBFLIBMO)
	{
		return default(global::KIBOKJEDDDG<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0xDA5E90", Offset = "0xDA4690", VA = "0x180DA5E90")]
	public static global::KIBOKJEDDDG<(T, U)> BDMLPPGAILE<T, U>(in global::KIBOKJEDDDG<T> DKLHMFCLOAB, in global::KIBOKJEDDDG<U> FLEBMPFFCAA)
	{
		return default(global::KIBOKJEDDDG<(T, U)>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct LOHIPHPIABC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x604020", Offset = "0x602820", VA = "0x180604020")]
	public static LOHIPHPIABC ACNIJINECFL<T>([Optional] string NKADKCHBFCF, [Optional] string ADGLEPOFGHE, bool PNMEBKBEFCE = false)
	{
		return default(LOHIPHPIABC);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[DefaultMember("Item")]
public readonly struct HCFHINHLMAP<T> : global::FGDDHFELANO<T, global::HCFHINHLMAP<T>.EELOPAIONCM>, global::EPEFAELFJAF<T>, global::EEBGDDHEMEI<T, global::HCFHINHLMAP<T>.EELOPAIONCM>, IEnumerable<T>, IEnumerable, global::MDLPPIBKKCG<T>, DANHMCCPOCB
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct EELOPAIONCM : DANHMCCPOCB, global::INPNLBBHJMP<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly T[] HGOACAIFHND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int GPJLIKKKBFE;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public int KKHILPEBPDN
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xF652E0", Offset = "0xF63AE0", VA = "0x180F652E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public T HLHDNNKPFLO
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x53580C0", Offset = "0x53568C0", VA = "0x1853580C0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x5358070", Offset = "0x5356870", VA = "0x185358070", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x5358070", Offset = "0x5356870", VA = "0x185358070", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x650EA0", Offset = "0x64F6A0", VA = "0x180650EA0")]
		private EELOPAIONCM(T[] KBMECNBEFEN, int AKLHCIJHJKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x4F96430", Offset = "0x4F94C30", VA = "0x184F96430")]
		public static EELOPAIONCM DKPJNJAIMAF(T[] KBMECNBEFEN)
		{
			return default(EELOPAIONCM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x4219D20", Offset = "0x4218520", VA = "0x184219D20", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x217A120", Offset = "0x2178920", VA = "0x18217A120", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly T[] GBHHKDIFIBB;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int KJDFLCMLCGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xF652E0", Offset = "0xF63AE0", VA = "0x180F652E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int KKHILPEBPDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x535CF20", Offset = "0x535B720", VA = "0x18535CF20", Slot = "10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public T NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x51920B0", Offset = "0x51908B0", VA = "0x1851920B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6DA260", Offset = "0x6D8A60", VA = "0x1806DA260")]
	internal HCFHINHLMAP(T[] FPMNAPBFAMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x535CCE0", Offset = "0x535B4E0", VA = "0x18535CCE0")]
	public static global::HCFHINHLMAP<T> EDPKODLEAFK()
	{
		return default(global::HCFHINHLMAP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x535CEC0", Offset = "0x535B6C0", VA = "0x18535CEC0", Slot = "9")]
	public T HLLKGMNONNE(int AKLHCIJHJKB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x56ACB60", Offset = "0x56AB360", VA = "0x1856ACB60", Slot = "6")]
	public EELOPAIONCM GetEnumerator()
	{
		return default(EELOPAIONCM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x56ACA60", Offset = "0x56AB260", VA = "0x1856ACA60", Slot = "5")]
	private global::INPNLBBHJMP<T> COAKAMGDBHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x56ACA60", Offset = "0x56AB260", VA = "0x1856ACA60", Slot = "7")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x56ACA60", Offset = "0x56AB260", VA = "0x1856ACA60", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class MJLACHAADMB
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0xDA0CE0", Offset = "0xD9F4E0", VA = "0x180DA0CE0")]
	public static global::HCFHINHLMAP<T> DKPJNJAIMAF<T>(T[] FPMNAPBFAMJ)
	{
		return default(global::HCFHINHLMAP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x86AEA0", Offset = "0x8696A0", VA = "0x18086AEA0")]
	public static global::HCFHINHLMAP<T> DPBNKKGLDMD<T>(this T[] KBMECNBEFEN)
	{
		return default(global::HCFHINHLMAP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0xA84210", Offset = "0xA82A10", VA = "0x180A84210")]
	public static global::HCFHINHLMAP<T>.EELOPAIONCM AANNPJGKPBK<T>(this T[] KBMECNBEFEN)
	{
		return default(global::HCFHINHLMAP<T>.EELOPAIONCM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x86AEA0", Offset = "0x8696A0", VA = "0x18086AEA0")]
	public static global::HCFHINHLMAP<T> HNCJAMIFCIN<T>(this T[] KBMECNBEFEN)
	{
		return default(global::HCFHINHLMAP<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct PMNIKMPDGNC<T, U> : global::FGDDHFELANO<T, U>, global::EPEFAELFJAF<T>, global::EEBGDDHEMEI<T, U>, IEnumerable<T>, IEnumerable where U : global::INPNLBBHJMP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly U ENHHNPMIICA;

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x4FA1E10", Offset = "0x4FA0610", VA = "0x184FA1E10")]
	internal PMNIKMPDGNC(in U PBDDMPLIKAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x66E700", Offset = "0x66CF00", VA = "0x18066E700", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x4FA1DE0", Offset = "0x4FA05E0", VA = "0x184FA1DE0", Slot = "5")]
	private global::INPNLBBHJMP<T> COAKAMGDBHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x4FA1DE0", Offset = "0x4FA05E0", VA = "0x184FA1DE0", Slot = "7")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x4FA1DE0", Offset = "0x4FA05E0", VA = "0x184FA1DE0", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class PAHEIEKDHOE<T>
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0xDA57A0", Offset = "0xDA3FA0", VA = "0x180DA57A0")]
	public static global::PMNIKMPDGNC<T, U> DKPJNJAIMAF<U>(in U PBDDMPLIKAI) where U : global::INPNLBBHJMP<T>
	{
		return default(global::PMNIKMPDGNC<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class JINHEMEJEBA<TResult, TResultEnumerator> where TResultEnumerator : global::INPNLBBHJMP<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0xDA5740", Offset = "0xDA3F40", VA = "0x180DA5740")]
	public static global::LCHDHBHJJHB<TSourceEnumerator, TResultEnumerator, TResult> DAAHFPHBLPI<TSourceEnumerator>(in TSourceEnumerator KBMECNBEFEN) where TSourceEnumerator : IEnumerator<TResultEnumerator>
	{
		return default(global::LCHDHBHJJHB<TSourceEnumerator, TResultEnumerator, TResult>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct LCHDHBHJJHB<TSourceEnumerator, TResultEnumerator, TResult> : global::INPNLBBHJMP<TResult>, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : IEnumerator<TResultEnumerator> where TResultEnumerator : global::INPNLBBHJMP<TResult>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private TSourceEnumerator HGOACAIFHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private TResultEnumerator KOCIPEFGNOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private bool JKKAODEBNBD;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public TResult HLHDNNKPFLO
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x5584060", Offset = "0x5582860", VA = "0x185584060", Slot = "4")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	TResult IEnumerator<TResult>.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x5583FC0", Offset = "0x55827C0", VA = "0x185583FC0", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x5583FC0", Offset = "0x55827C0", VA = "0x185583FC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5584010", Offset = "0x5582810", VA = "0x185584010")]
	internal LCHDHBHJJHB(in TSourceEnumerator KBMECNBEFEN, in TResultEnumerator AGCHKJIMGNN, bool BGHDKINAFAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5583E40", Offset = "0x5582640", VA = "0x185583E40", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5583F70", Offset = "0x5582770", VA = "0x185583F70", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5583DF0", Offset = "0x55825F0", VA = "0x185583DF0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct NJKGNIPOPKI<TSourceEnumerator, TSource, TResult> : DANHMCCPOCB, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : DANHMCCPOCB, global::INPNLBBHJMP<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private TSourceEnumerator HGOACAIFHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly global::DGIDCCJAHGO<TSource, TResult> OFGOBBFPDBM;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int KKHILPEBPDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x54CD7A0", Offset = "0x54CBFA0", VA = "0x1854CD7A0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public TResult HLHDNNKPFLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x54CDE30", Offset = "0x54CC630", VA = "0x1854CDE30", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x54CDD30", Offset = "0x54CC530", VA = "0x1854CDD30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0xECDCC0", Offset = "0xECC4C0", VA = "0x180ECDCC0")]
	internal NJKGNIPOPKI(in TSourceEnumerator KBMECNBEFEN, global::DGIDCCJAHGO<TSource, TResult> AEPGLGEKHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x54CD9D0", Offset = "0x54CC1D0", VA = "0x1854CD9D0", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x54CDC00", Offset = "0x54CC400", VA = "0x1854CDC00", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x54CD480", Offset = "0x54CBC80", VA = "0x1854CD480", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct JKDADPMGBGI<TSourceEnumerator, TSource, TResultEnumerator, TResult> : global::INPNLBBHJMP<TResult>, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : global::INPNLBBHJMP<TSource> where TResultEnumerator : global::INPNLBBHJMP<TResult>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private TSourceEnumerator HGOACAIFHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private TResultEnumerator KOCIPEFGNOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly global::DGIDCCJAHGO<TSource, TResultEnumerator> OFGOBBFPDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private bool JKKAODEBNBD;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public TResult HLHDNNKPFLO
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x562BCE0", Offset = "0x562A4E0", VA = "0x18562BCE0", Slot = "4")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	TResult IEnumerator<TResult>.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x562BBF0", Offset = "0x562A3F0", VA = "0x18562BBF0", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x562BBF0", Offset = "0x562A3F0", VA = "0x18562BBF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x562BC80", Offset = "0x562A480", VA = "0x18562BC80")]
	internal JKDADPMGBGI(in TSourceEnumerator KBMECNBEFEN, in TResultEnumerator AGCHKJIMGNN, global::DGIDCCJAHGO<TSource, TResultEnumerator> AEPGLGEKHNA, bool BGHDKINAFAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x562BA10", Offset = "0x562A210", VA = "0x18562BA10", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x562BBA0", Offset = "0x562A3A0", VA = "0x18562BBA0", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x562B9C0", Offset = "0x562A1C0", VA = "0x18562B9C0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct BKMLACKGICA<TSource1Enumerator, TSource1, TSource2Enumerator, TSource2> : DANHMCCPOCB, IEnumerator<(TSource1, TSource2)>, IEnumerator, IDisposable where TSource1Enumerator : DANHMCCPOCB, global::INPNLBBHJMP<TSource1> where TSource2Enumerator : DANHMCCPOCB, global::INPNLBBHJMP<TSource2>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private TSource1Enumerator BIACMJNPGHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private TSource2Enumerator FCDPGJOPAAM;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int KKHILPEBPDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x53F3920", Offset = "0x53F2120", VA = "0x1853F3920", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public (TSource1, TSource2) HLHDNNKPFLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x53F3B80", Offset = "0x53F2380", VA = "0x1853F3B80", Slot = "5")]
		get
		{
			return default((TSource1, TSource2));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x53F3AA0", Offset = "0x53F22A0", VA = "0x1853F3AA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x53F3B40", Offset = "0x53F2340", VA = "0x1853F3B40")]
	internal BKMLACKGICA(in TSource1Enumerator LEGJGFOJPLE, in TSource2Enumerator MAGICKOIJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x53F39C0", Offset = "0x53F21C0", VA = "0x1853F39C0", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x53F3A30", Offset = "0x53F2230", VA = "0x1853F3A30", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x53F38C0", Offset = "0x53F20C0", VA = "0x1853F38C0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public readonly struct KIJIPFHNLCI<T, U> : global::EEBGDDHEMEI<T, U>, IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly U ENHHNPMIICA;

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x1F64C80", Offset = "0x1F63480", VA = "0x181F64C80")]
	internal KIJIPFHNLCI(in U PBDDMPLIKAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0xECE410", Offset = "0xECCC10", VA = "0x180ECE410", Slot = "4")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x55E8E70", Offset = "0x55E7670", VA = "0x1855E8E70", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x55E8E70", Offset = "0x55E7670", VA = "0x1855E8E70", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class JNMFMKMNBGI<T>
{
	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0xDA57D0", Offset = "0xDA3FD0", VA = "0x180DA57D0")]
	public static global::KIJIPFHNLCI<T, U> DKPJNJAIMAF<U>(in U PBDDMPLIKAI) where U : IEnumerator<T>
	{
		return default(global::KIJIPFHNLCI<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct JNMKADIHBKN<TSourceEnumerator, TSource, TResult> : DANHMCCPOCB, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : DANHMCCPOCB, IEnumerator<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private TSourceEnumerator HGOACAIFHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly Func<TSource, TResult> OFGOBBFPDBM;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public int KKHILPEBPDN
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x518A540", Offset = "0x5188D40", VA = "0x18518A540", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public TResult HLHDNNKPFLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x518A710", Offset = "0x5188F10", VA = "0x18518A710", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x518A690", Offset = "0x5188E90", VA = "0x18518A690", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x518A6D0", Offset = "0x5188ED0", VA = "0x18518A6D0")]
	internal JNMKADIHBKN(in TSourceEnumerator KBMECNBEFEN, Func<TSource, TResult> AEPGLGEKHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x518A590", Offset = "0x5188D90", VA = "0x18518A590", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x518A640", Offset = "0x5188E40", VA = "0x18518A640", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x518A4F0", Offset = "0x5188CF0", VA = "0x18518A4F0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class BADIMNDHMDH
{
	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x17835E0", Offset = "0x1781DE0", VA = "0x1817835E0")]
	public static bool JJFICCOMIDC<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator KBMECNBEFEN, in TArgs MIOMNNIBEOC, in global::HOFFMAKGJLC<TArgs, TSource, bool> CKGFBEPPFFD) where TSourceEnumerator : global::INPNLBBHJMP<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x4FE08C0", Offset = "0x4FDF0C0", VA = "0x184FE08C0")]
	public static int OGGGCLNPDIH<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator KBMECNBEFEN, in TArgs MIOMNNIBEOC, global::HOFFMAKGJLC<TArgs, TSource, bool> CKGFBEPPFFD) where TSourceEnumerator : global::INPNLBBHJMP<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x1783500", Offset = "0x1781D00", VA = "0x181783500")]
	public static bool EBPFBOCKOMI<TSourceEnumerator, TSource>(this TSourceEnumerator KBMECNBEFEN, in TSource FJMIPHLNAEC) where TSourceEnumerator : global::INPNLBBHJMP<TSource> where TSource : global::AGGNMDONOEO<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x4FE05A0", Offset = "0x4FDEDA0", VA = "0x184FE05A0")]
	public static int MKMBCOBIKIH<TSourceEnumerator, TSource>(this TSourceEnumerator KBMECNBEFEN, in TSource CJMMBFLIBMO) where TSourceEnumerator : global::INPNLBBHJMP<TSource> where TSource : global::AGGNMDONOEO<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0xDA0C40", Offset = "0xD9F440", VA = "0x180DA0C40")]
	public static global::NJKGNIPOPKI<TSourceEnumerator, TSource, TResult> LCLBNHPPIDI<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator KBMECNBEFEN, global::DGIDCCJAHGO<TSource, TResult> AEPGLGEKHNA) where TSourceEnumerator : DANHMCCPOCB, global::INPNLBBHJMP<TSource>
	{
		return default(global::NJKGNIPOPKI<TSourceEnumerator, TSource, TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0xDA0C90", Offset = "0xD9F490", VA = "0x180DA0C90")]
	public static global::JNMKADIHBKN<TSourceEnumerator, TSource, TResult> MALNJONGLME<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator KBMECNBEFEN, Func<TSource, TResult> AEPGLGEKHNA) where TSourceEnumerator : DANHMCCPOCB, IEnumerator<TSource>
	{
		return default(global::JNMKADIHBKN<TSourceEnumerator, TSource, TResult>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class ECLIIGONPEA<T>
{
	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x1788E90", Offset = "0x1787690", VA = "0x181788E90")]
	public static bool MMPOEBCHBDO<TSourceEnumerator>(TSourceEnumerator KBMECNBEFEN) where TSourceEnumerator : IEnumerator<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0xD4B550", Offset = "0xD49D50", VA = "0x180D4B550")]
	public static T PGNONNNPKAE<TSourceEnumerator>(TSourceEnumerator KBMECNBEFEN) where TSourceEnumerator : global::INPNLBBHJMP<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x524A9C0", Offset = "0x52491C0", VA = "0x18524A9C0")]
	public static global::JKDADPMGBGI<TSourceEnumerator, TSource, TResultEnumerator, T> HAEOBMFHPED<TSourceEnumerator, TSource, TResultEnumerator>(in TSourceEnumerator KBMECNBEFEN, global::DGIDCCJAHGO<TSource, TResultEnumerator> AEPGLGEKHNA) where TSourceEnumerator : global::INPNLBBHJMP<TSource> where TResultEnumerator : global::INPNLBBHJMP<T>
	{
		return default(global::JKDADPMGBGI<TSourceEnumerator, TSource, TResultEnumerator, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x4F53250", Offset = "0x4F51A50", VA = "0x184F53250")]
	public static string IIMGJLOMPPG<TSourceEnumerator>(TSourceEnumerator KBMECNBEFEN) where TSourceEnumerator : IEnumerator<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x25DFBD0", Offset = "0x25DE3D0", VA = "0x1825DFBD0")]
	public static T[] BINJNAJBKBB<TSourceEnumerator>(TSourceEnumerator KBMECNBEFEN) where TSourceEnumerator : DANHMCCPOCB, IEnumerator<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x1C32C40", Offset = "0x1C31440", VA = "0x181C32C40")]
	public static T BONECBLBPHO<TSourceEnumerator>(TSourceEnumerator KBMECNBEFEN) where TSourceEnumerator : IEnumerator<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x1788D60", Offset = "0x1787560", VA = "0x181788D60")]
	public static bool FIEHNBABKNE<TSourceEnumerator>(TSourceEnumerator KBMECNBEFEN) where TSourceEnumerator : IEnumerator<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class FGHFHADEAIL<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x4F46A50", Offset = "0x4F45250", VA = "0x184F46A50")]
	public static global::BKMLACKGICA<TSource1Enumerator, T, TSource2Enumerator, U> IBLJPEBJEFC<TSource1Enumerator, TSource2Enumerator>(in TSource1Enumerator LEGJGFOJPLE, in TSource2Enumerator MAGICKOIJKO) where TSource1Enumerator : DANHMCCPOCB, global::INPNLBBHJMP<T> where TSource2Enumerator : DANHMCCPOCB, global::INPNLBBHJMP<U>
	{
		return default(global::BKMLACKGICA<TSource1Enumerator, T, TSource2Enumerator, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface EPEFAELFJAF<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::INPNLBBHJMP<T> GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface FGDDHFELANO<T, TEnumerator> : global::EPEFAELFJAF<T>, global::EEBGDDHEMEI<T, TEnumerator>, IEnumerable<T>, IEnumerable where TEnumerator : global::INPNLBBHJMP<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new TEnumerator GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface INPNLBBHJMP<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	T HLHDNNKPFLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface MDLPPIBKKCG<T> : DANHMCCPOCB
{
	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T HLLKGMNONNE(int GDBELOJNNFN);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface EEBGDDHEMEI<T, TEnumerator> : IEnumerable<T>, IEnumerable where TEnumerator : IEnumerator<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new TEnumerator GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface DANHMCCPOCB
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	int KKHILPEBPDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface AGGNMDONOEO<T>
{
	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BCFOCJDENEF(in T ALBOAABJIJF);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface BKCBENEOFGP<T>
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::PFEHJNIIGHF<T> GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface MHAAIADGNFP<T, TEnumerator> : global::BKCBENEOFGP<T>, global::FGDDHFELANO<T, TEnumerator>, global::EPEFAELFJAF<T>, global::EEBGDDHEMEI<T, TEnumerator>, IEnumerable<T>, IEnumerable where TEnumerator : global::PFEHJNIIGHF<T>
{
	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new TEnumerator GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface PFEHJNIIGHF<T> : global::INPNLBBHJMP<T>, IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	new T HLHDNNKPFLO
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public delegate void HJKLMGAJAMI<T>(in T OGMKAFPDGJD);
[Cpp2IlInjected.Token(Token = "0x200004A")]
public delegate void CFJKEONNABE<T1, T2>(in T1 AFBAHCPPMDA, in T2 JPENMCHPEFB);
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class GFPFOKDCBHO
{
	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x178C1C0", Offset = "0x178A9C0", VA = "0x18178C1C0")]
	public static bool GOHDGPHEPFE<T, U>(this T KBMECNBEFEN, in U DEGGOOGCHFA) where T : global::AGGNMDONOEO<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public delegate TResult DGIDCCJAHGO<T, out TResult>(in T OGMKAFPDGJD);
[Cpp2IlInjected.Token(Token = "0x200004D")]
public delegate TResult HOFFMAKGJLC<T1, T2, out TResult>(in T1 AFBAHCPPMDA, in T2 JPENMCHPEFB);
[Cpp2IlInjected.Token(Token = "0x200004E")]
public delegate TResult DEPNPLEBBFD<T1, T2, T3, out TResult>(in T1 AFBAHCPPMDA, in T2 JPENMCHPEFB, in T3 BEFCFEAEAHM);
[Cpp2IlInjected.Token(Token = "0x200004F")]
public delegate TResult EFBMFCJHHOG<T1, T2, T3, T4, out TResult>(in T1 AFBAHCPPMDA, in T2 JPENMCHPEFB, in T3 BEFCFEAEAHM, in T4 OINOBNEPOEL);
[Cpp2IlInjected.Token(Token = "0x2000050")]
public delegate TResult PGCJDBJDOJK<T1, T2, T3, T4, T5, out TResult>(in T1 AFBAHCPPMDA, in T2 JPENMCHPEFB, in T3 BEFCFEAEAHM, in T4 OINOBNEPOEL, in T5 ELPNCNOIAGK);
[Cpp2IlInjected.Token(Token = "0x2000051")]
public delegate TResult BPKJLCDIFDB<T, TResult>(in T OGMKAFPDGJD);
[Cpp2IlInjected.Token(Token = "0x2000052")]
public delegate TResult KDBMBFDKPJM<T1, T2, TResult>(in T1 AFBAHCPPMDA, in T2 JPENMCHPEFB);
[Cpp2IlInjected.Token(Token = "0x2000053")]
public delegate TResult DENIMPMGLOM<T1, T2, T3, TResult>(in T1 AFBAHCPPMDA, in T2 JPENMCHPEFB, in T3 BEFCFEAEAHM);
[Cpp2IlInjected.Token(Token = "0x2000054")]
[DefaultMember("Item")]
public struct HPFBPAMJPEK<T> : global::MHAAIADGNFP<T, global::HPFBPAMJPEK<T>.DBNFFCKIBOJ>, global::BKCBENEOFGP<T>, global::FGDDHFELANO<T, global::HPFBPAMJPEK<T>.DBNFFCKIBOJ>, global::EPEFAELFJAF<T>, global::EEBGDDHEMEI<T, global::HPFBPAMJPEK<T>.DBNFFCKIBOJ>, IEnumerable<T>, IEnumerable, global::MDLPPIBKKCG<T>, DANHMCCPOCB
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct DBNFFCKIBOJ : DANHMCCPOCB, global::PFEHJNIIGHF<T>, global::INPNLBBHJMP<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private T[] HGOACAIFHND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int GPJLIKKKBFE;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public int KKHILPEBPDN
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0xF652E0", Offset = "0xF63AE0", VA = "0x180F652E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public T HLHDNNKPFLO
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x53580C0", Offset = "0x53568C0", VA = "0x1853580C0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		private T NNGNHDOFFPK
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x5358020", Offset = "0x5356820", VA = "0x185358020", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x5358070", Offset = "0x5356870", VA = "0x185358070", Slot = "7")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x5358070", Offset = "0x5356870", VA = "0x185358070", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x650EA0", Offset = "0x64F6A0", VA = "0x180650EA0")]
		private DBNFFCKIBOJ(T[] KBMECNBEFEN, int AKLHCIJHJKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x4F96430", Offset = "0x4F94C30", VA = "0x184F96430")]
		public static DBNFFCKIBOJ DKPJNJAIMAF(T[] KBMECNBEFEN)
		{
			return default(DBNFFCKIBOJ);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x4219D20", Offset = "0x4218520", VA = "0x184219D20", Slot = "9")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x217A120", Offset = "0x2178920", VA = "0x18217A120", Slot = "11")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "8")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private T[] GBHHKDIFIBB;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public int KJDFLCMLCGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xF652E0", Offset = "0xF63AE0", VA = "0x180F652E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int KKHILPEBPDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x535CF20", Offset = "0x535B720", VA = "0x18535CF20", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public T NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x51920B0", Offset = "0x51908B0", VA = "0x1851920B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6DA260", Offset = "0x6D8A60", VA = "0x1806DA260")]
	internal HPFBPAMJPEK(T[] FPMNAPBFAMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x535CCE0", Offset = "0x535B4E0", VA = "0x18535CCE0")]
	public static global::HPFBPAMJPEK<T> EDPKODLEAFK()
	{
		return default(global::HPFBPAMJPEK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x535CEC0", Offset = "0x535B6C0", VA = "0x18535CEC0", Slot = "11")]
	public T HLLKGMNONNE(int AKLHCIJHJKB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x535CDA0", Offset = "0x535B5A0", VA = "0x18535CDA0")]
	public global::HCFHINHLMAP<T> GBONEOIGKJB()
	{
		return default(global::HCFHINHLMAP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x535CE20", Offset = "0x535B620", VA = "0x18535CE20", Slot = "8")]
	public DBNFFCKIBOJ GetEnumerator()
	{
		return default(DBNFFCKIBOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x535CBE0", Offset = "0x535B3E0", VA = "0x18535CBE0", Slot = "5")]
	private global::PFEHJNIIGHF<T> IJKHLMPOKMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x535CBE0", Offset = "0x535B3E0", VA = "0x18535CBE0", Slot = "7")]
	private global::INPNLBBHJMP<T> COAKAMGDBHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x535CBE0", Offset = "0x535B3E0", VA = "0x18535CBE0", Slot = "9")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x535CBE0", Offset = "0x535B3E0", VA = "0x18535CBE0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class FBPLLJGDNDC
{
	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0xDA0CE0", Offset = "0xD9F4E0", VA = "0x180DA0CE0")]
	public static global::HPFBPAMJPEK<T> DKPJNJAIMAF<T>(T[] FPMNAPBFAMJ)
	{
		return default(global::HPFBPAMJPEK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x86AEA0", Offset = "0x8696A0", VA = "0x18086AEA0")]
	public static global::HPFBPAMJPEK<T> MFHKGDBNENB<T>(this T[] KBMECNBEFEN)
	{
		return default(global::HPFBPAMJPEK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0xA84210", Offset = "0xA82A10", VA = "0x180A84210")]
	public static global::HPFBPAMJPEK<T>.DBNFFCKIBOJ POPPFDLIEMH<T>(this T[] KBMECNBEFEN)
	{
		return default(global::HPFBPAMJPEK<T>.DBNFFCKIBOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x86AEA0", Offset = "0x8696A0", VA = "0x18086AEA0")]
	public static global::HPFBPAMJPEK<T> EAOOGDIDAAN<T>(this T[] KBMECNBEFEN)
	{
		return default(global::HPFBPAMJPEK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public readonly struct NKBGKIKKONL<T, U> : global::MHAAIADGNFP<T, U>, global::BKCBENEOFGP<T>, global::FGDDHFELANO<T, U>, global::EPEFAELFJAF<T>, global::EEBGDDHEMEI<T, U>, IEnumerable<T>, IEnumerable where U : global::PFEHJNIIGHF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly U ENHHNPMIICA;

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x4FA1E10", Offset = "0x4FA0610", VA = "0x184FA1E10")]
	internal NKBGKIKKONL(in U PBDDMPLIKAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x66E700", Offset = "0x66CF00", VA = "0x18066E700", Slot = "8")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x4FA1DE0", Offset = "0x4FA05E0", VA = "0x184FA1DE0", Slot = "5")]
	private global::PFEHJNIIGHF<T> IJKHLMPOKMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x4FA1DE0", Offset = "0x4FA05E0", VA = "0x184FA1DE0", Slot = "7")]
	private global::INPNLBBHJMP<T> COAKAMGDBHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x4FA1DE0", Offset = "0x4FA05E0", VA = "0x184FA1DE0", Slot = "9")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x4FA1DE0", Offset = "0x4FA05E0", VA = "0x184FA1DE0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class JMMBHEKPNMA<T>
{
	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0xDA57A0", Offset = "0xDA3FA0", VA = "0x180DA57A0")]
	public static global::NKBGKIKKONL<T, U> DKPJNJAIMAF<U>(in U PBDDMPLIKAI) where U : global::PFEHJNIIGHF<T>
	{
		return default(global::NKBGKIKKONL<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[DefaultMember("Item")]
public class PNJCDONFIKD<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly Func<Internal, External> NOAHEACFGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly Func<External, Internal> FCOMJEEDKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private IList<Internal> BAKFHBILFME;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public IList<Internal> GOEBEIHGGEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x6186B0", Offset = "0x616EB0", VA = "0x1806186B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x639660", Offset = "0x637E60", VA = "0x180639660")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool FKKNEPJPEKA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7294F0", Offset = "0x727CF0", VA = "0x1807294F0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x729510", Offset = "0x727D10", VA = "0x180729510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public External NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x57A7B40", Offset = "0x57A6340", VA = "0x1857A7B40", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x57A7BE0", Offset = "0x57A63E0", VA = "0x1857A7BE0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public int KKHILPEBPDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x57A7AE0", Offset = "0x57A62E0", VA = "0x1857A7AE0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x55DB4A0", Offset = "0x55D9CA0", VA = "0x1855DB4A0")]
	public PNJCDONFIKD(Func<Internal, External> NOAHEACFGIF, Func<External, Internal> FCOMJEEDKKP, bool OCJHDMOBOMD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x57A77F0", Offset = "0x57A5FF0", VA = "0x1857A77F0", Slot = "6")]
	public int IndexOf(External FJMIPHLNAEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x57A7420", Offset = "0x57A5C20", VA = "0x1857A7420", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x57A74D0", Offset = "0x57A5CD0", VA = "0x1857A74D0", Slot = "13")]
	public bool Contains(External FJMIPHLNAEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x57A7560", Offset = "0x57A5D60", VA = "0x1857A7560", Slot = "14")]
	public void CopyTo(External[] FPMNAPBFAMJ, int DDFINIJOFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x57A7330", Offset = "0x57A5B30", VA = "0x1857A7330", Slot = "11")]
	public void Add(External FJMIPHLNAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x57A78E0", Offset = "0x57A60E0", VA = "0x1857A78E0", Slot = "7")]
	public void Insert(int AKLHCIJHJKB, External FJMIPHLNAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x57A7A50", Offset = "0x57A6250", VA = "0x1857A7A50", Slot = "15")]
	public bool Remove(External FJMIPHLNAEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x57A7980", Offset = "0x57A6180", VA = "0x1857A7980", Slot = "8")]
	public void RemoveAt(int AKLHCIJHJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x57A7780", Offset = "0x57A5F80", VA = "0x1857A7780", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x2578670", Offset = "0x2576E70", VA = "0x182578670", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[DefaultMember("Item")]
public class AGIBECGAPCC<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Func<Internal, External> NOAHEACFGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private IReadOnlyList<Internal> BAKFHBILFME;

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public IReadOnlyList<Internal> GOEBEIHGGEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x643F60", Offset = "0x642760", VA = "0x180643F60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public bool FKKNEPJPEKA
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x6120B0", Offset = "0x6108B0", VA = "0x1806120B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public External NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xE2F380", Offset = "0xE2DB80", VA = "0x180E2F380", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public int KKHILPEBPDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xE2F320", Offset = "0xE2DB20", VA = "0x180E2F320", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0xE2F290", Offset = "0xE2DA90", VA = "0x180E2F290")]
	public AGIBECGAPCC(Func<Internal, External> NOAHEACFGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0xE2F2D0", Offset = "0xE2DAD0", VA = "0x180E2F2D0")]
	public AGIBECGAPCC(IReadOnlyList<Internal> BAKFHBILFME, Func<Internal, External> NOAHEACFGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0xE2F040", Offset = "0xE2D840", VA = "0x180E2F040")]
	public void MMLIBPLAGIG(External[] FPMNAPBFAMJ, int DDFINIJOFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0xE2EFD0", Offset = "0xE2D7D0", VA = "0x180E2EFD0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0xE2F260", Offset = "0xE2DA60", VA = "0x180E2F260", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[DefaultMember("Item")]
public class POOFKAFAOBE<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private IReadOnlyList<Internal> BAKFHBILFME;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public IReadOnlyList<Internal> GOEBEIHGGEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x5FD1C0", Offset = "0x5FB9C0", VA = "0x1805FD1C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x5F6790", Offset = "0x5F4F90", VA = "0x1805F6790")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool FKKNEPJPEKA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6120B0", Offset = "0x6108B0", VA = "0x1806120B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public External NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x57A80F0", Offset = "0x57A68F0", VA = "0x1857A80F0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int KKHILPEBPDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x57A8090", Offset = "0x57A6890", VA = "0x1857A8090", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0xE2F290", Offset = "0xE2DA90", VA = "0x180E2F290")]
	public POOFKAFAOBE(IReadOnlyList<Internal> BAKFHBILFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x57A7DC0", Offset = "0x57A65C0", VA = "0x1857A7DC0")]
	public bool JNEGJNMGLPF(External FJMIPHLNAEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x57A7E60", Offset = "0x57A6660", VA = "0x1857A7E60")]
	public void MMLIBPLAGIG(External[] FPMNAPBFAMJ, int DDFINIJOFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x57A7D50", Offset = "0x57A6550", VA = "0x1857A7D50", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x2578670", Offset = "0x2576E70", VA = "0x182578670", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public abstract class DKKBAEIMAGA
{
	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void CIIFFFIMJAK(object[] MIOMNNIBEOC);

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	protected DKKBAEIMAGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class DEIJAFEHONM<T> : DKKBAEIMAGA
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	protected struct KNFLIKJHAKD
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public enum NIHEDHANHIE
		{
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public NIHEDHANHIE BKDBLJPNPPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public T MJHIGMCCOPA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int FLIHMMBKMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly bool MNGOJPMKACH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	protected readonly bool FMEBOELOIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	protected List<T> AIACKAKCMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private List<KNFLIKJHAKD> NMFOGHCHIAE;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public bool OFPMBIHDFGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x52D2640", Offset = "0x52D0E40", VA = "0x1852D2640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x52D2CE0", Offset = "0x52D14E0", VA = "0x1852D2CE0")]
	protected DEIJAFEHONM(bool FMEBOELOIJK, bool MNGOJPMKACH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x52D2960", Offset = "0x52D1160", VA = "0x1852D2960")]
	protected bool MAHODNFNFFJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x52D2560", Offset = "0x52D0D60", VA = "0x1852D2560")]
	protected void AMPKGKNDGOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x52D2680", Offset = "0x52D0E80", VA = "0x1852D2680")]
	protected void HLGCDOJIGMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0xB54610", Offset = "0xB52E10", VA = "0x180B54610")]
	private static void HGHKJNHPOOB<U>(ref List<U> BAKFHBILFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x52D2B60", Offset = "0x52D1360", VA = "0x1852D2B60", Slot = "5")]
	public void NLKJJINIDJF(T MJHIGMCCOPA, bool PBNPPHGMHEM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x52D2A00", Offset = "0x52D1200", VA = "0x1852D2A00", Slot = "6")]
	public void NHIAFFMKOAF(T MJHIGMCCOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x52D2830", Offset = "0x52D1030", VA = "0x1852D2830")]
	public void IDPJIGKEBOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface IOJIBGFODJC
{
	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NLKJJINIDJF(Action MJHIGMCCOPA, bool PBNPPHGMHEM = false);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NHIAFFMKOAF(Action MJHIGMCCOPA);
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public sealed class DAPLAJJDDGM : global::DEIJAFEHONM<Action>, IOJIBGFODJC
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x4060630", Offset = "0x405EE30", VA = "0x184060630")]
	public DAPLAJJDDGM(bool FMEBOELOIJK = false, bool MNGOJPMKACH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x4060410", Offset = "0x405EC10", VA = "0x184060410")]
	public void HJEIFCIIAIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x4060330", Offset = "0x405EB30", VA = "0x184060330", Slot = "4")]
	public override void CIIFFFIMJAK(object[] MIOMNNIBEOC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x40603B0", Offset = "0x405EBB0", VA = "0x1840603B0")]
	public static DAPLAJJDDGM GAHCJAADICN(DAPLAJJDDGM ABCDLPCDENA, Action MJHIGMCCOPA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x40605D0", Offset = "0x405EDD0", VA = "0x1840605D0")]
	public static DAPLAJJDDGM KKLEEKEHGNM(DAPLAJJDDGM ABCDLPCDENA, Action MJHIGMCCOPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface KKMHFHMMDCJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NLKJJINIDJF(Action<T> MJHIGMCCOPA, bool PBNPPHGMHEM = false);

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NHIAFFMKOAF(Action<T> MJHIGMCCOPA);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public sealed class DPAEMCAKAEJ<T> : global::DEIJAFEHONM<Action<T>>, global::KKMHFHMMDCJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x511DBF0", Offset = "0x511C3F0", VA = "0x18511DBF0")]
	public DPAEMCAKAEJ(bool FMEBOELOIJK = false, bool MNGOJPMKACH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x5412140", Offset = "0x5410940", VA = "0x185412140")]
	public void HJEIFCIIAIC(T JFBIOCFAFEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x5410810", Offset = "0x540F010", VA = "0x185410810", Slot = "4")]
	public override void CIIFFFIMJAK(object[] MIOMNNIBEOC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x5411260", Offset = "0x540FA60", VA = "0x185411260")]
	public static global::DPAEMCAKAEJ<T> GAHCJAADICN(global::DPAEMCAKAEJ<T> ABCDLPCDENA, Action<T> MJHIGMCCOPA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x5414660", Offset = "0x5412E60", VA = "0x185414660")]
	public static global::DPAEMCAKAEJ<T> KKLEEKEHGNM(global::DPAEMCAKAEJ<T> ABCDLPCDENA, Action<T> MJHIGMCCOPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface GOFKIMBOMPI<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NLKJJINIDJF(Action<T, U> MJHIGMCCOPA, bool PBNPPHGMHEM = false);

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NHIAFFMKOAF(Action<T, U> MJHIGMCCOPA);
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public sealed class CAFBCHKGCBG<T, U> : global::DEIJAFEHONM<Action<T, U>>, global::GOFKIMBOMPI<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x511DBF0", Offset = "0x511C3F0", VA = "0x18511DBF0")]
	public CAFBCHKGCBG(bool FMEBOELOIJK = false, bool MNGOJPMKACH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x56167E0", Offset = "0x5614FE0", VA = "0x1856167E0")]
	public void HJEIFCIIAIC(T JFBIOCFAFEC, U BLBINEIGPNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x5613620", Offset = "0x5611E20", VA = "0x185613620", Slot = "4")]
	public override void CIIFFFIMJAK(object[] MIOMNNIBEOC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x5614D40", Offset = "0x5613540", VA = "0x185614D40")]
	public static global::CAFBCHKGCBG<T, U> GAHCJAADICN(global::CAFBCHKGCBG<T, U> ABCDLPCDENA, Action<T, U> MJHIGMCCOPA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x5618BF0", Offset = "0x56173F0", VA = "0x185618BF0")]
	public static global::CAFBCHKGCBG<T, U> KKLEEKEHGNM(global::CAFBCHKGCBG<T, U> ABCDLPCDENA, Action<T, U> MJHIGMCCOPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface OCAHBCEBHGD<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NLKJJINIDJF(Action<T, U, V> MJHIGMCCOPA, bool PBNPPHGMHEM = false);

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NHIAFFMKOAF(Action<T, U, V> MJHIGMCCOPA);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public sealed class NPHKDDPOLJC<T, U, V> : global::DEIJAFEHONM<Action<T, U, V>>, global::OCAHBCEBHGD<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x511DBF0", Offset = "0x511C3F0", VA = "0x18511DBF0")]
	public NPHKDDPOLJC(bool FMEBOELOIJK = false, bool MNGOJPMKACH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x54D31A0", Offset = "0x54D19A0", VA = "0x1854D31A0")]
	public void HJEIFCIIAIC(T JFBIOCFAFEC, U BLBINEIGPNI, V BKEAIPINHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x54D2490", Offset = "0x54D0C90", VA = "0x1854D2490", Slot = "4")]
	public override void CIIFFFIMJAK(object[] MIOMNNIBEOC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x54D3100", Offset = "0x54D1900", VA = "0x1854D3100")]
	public static global::NPHKDDPOLJC<T, U, V> GAHCJAADICN(global::NPHKDDPOLJC<T, U, V> ABCDLPCDENA, Action<T, U, V> MJHIGMCCOPA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x54D5360", Offset = "0x54D3B60", VA = "0x1854D5360")]
	public static global::NPHKDDPOLJC<T, U, V> KKLEEKEHGNM(global::NPHKDDPOLJC<T, U, V> ABCDLPCDENA, Action<T, U, V> MJHIGMCCOPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface PBBCIPBHIFD<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NLKJJINIDJF(Action<T, U, V, W> MJHIGMCCOPA, bool PBNPPHGMHEM = false);

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NHIAFFMKOAF(Action<T, U, V, W> MJHIGMCCOPA);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public sealed class DOBJMMNIBNJ<T, U, V, W> : global::DEIJAFEHONM<Action<T, U, V, W>>, global::PBBCIPBHIFD<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x511DBF0", Offset = "0x511C3F0", VA = "0x18511DBF0")]
	public DOBJMMNIBNJ(bool FMEBOELOIJK = false, bool MNGOJPMKACH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x52DAED0", Offset = "0x52D96D0", VA = "0x1852DAED0")]
	public void HJEIFCIIAIC(T JFBIOCFAFEC, U BLBINEIGPNI, V BKEAIPINHOO, W JCMJAPLEPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x52D9C80", Offset = "0x52D8480", VA = "0x1852D9C80", Slot = "4")]
	public override void CIIFFFIMJAK(object[] MIOMNNIBEOC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x52DABA0", Offset = "0x52D93A0", VA = "0x1852DABA0")]
	public static global::DOBJMMNIBNJ<T, U, V, W> GAHCJAADICN(global::DOBJMMNIBNJ<T, U, V, W> ABCDLPCDENA, Action<T, U, V, W> MJHIGMCCOPA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x52DBF40", Offset = "0x52DA740", VA = "0x1852DBF40")]
	public static global::DOBJMMNIBNJ<T, U, V, W> KKLEEKEHGNM(global::DOBJMMNIBNJ<T, U, V, W> ABCDLPCDENA, Action<T, U, V, W> MJHIGMCCOPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface DHCGLCAEFFL<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NLKJJINIDJF(Action<T, U, V, W, X> MJHIGMCCOPA, bool PBNPPHGMHEM = false);

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NHIAFFMKOAF(Action<T, U, V, W, X> MJHIGMCCOPA);
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public sealed class ENBMOCJBDMN<T, U, V, W, X> : global::DEIJAFEHONM<Action<T, U, V, W, X>>, global::DHCGLCAEFFL<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x511DBF0", Offset = "0x511C3F0", VA = "0x18511DBF0")]
	public ENBMOCJBDMN(bool FMEBOELOIJK = false, bool MNGOJPMKACH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x56745E0", Offset = "0x5672DE0", VA = "0x1856745E0")]
	public void HJEIFCIIAIC(T JFBIOCFAFEC, U BLBINEIGPNI, V BKEAIPINHOO, W JCMJAPLEPMJ, X FGCAOGJDCFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x5673C20", Offset = "0x5672420", VA = "0x185673C20", Slot = "4")]
	public override void CIIFFFIMJAK(object[] MIOMNNIBEOC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x5674230", Offset = "0x5672A30", VA = "0x185674230")]
	public static global::ENBMOCJBDMN<T, U, V, W, X> GAHCJAADICN(global::ENBMOCJBDMN<T, U, V, W, X> ABCDLPCDENA, Action<T, U, V, W, X> MJHIGMCCOPA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x5674880", Offset = "0x5673080", VA = "0x185674880")]
	public static global::ENBMOCJBDMN<T, U, V, W, X> KKLEEKEHGNM(global::ENBMOCJBDMN<T, U, V, W, X> ABCDLPCDENA, Action<T, U, V, W, X> MJHIGMCCOPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public interface IHDJJCKKCEN<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NLKJJINIDJF(Action<T, U, V, W, X, Y> MJHIGMCCOPA, bool PBNPPHGMHEM = false);

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NHIAFFMKOAF(Action<T, U, V, W, X, Y> MJHIGMCCOPA);
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public sealed class ICFJLGHAIEC<T, U, V, W, X, Y> : global::DEIJAFEHONM<Action<T, U, V, W, X, Y>>, global::IHDJJCKKCEN<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x511DBF0", Offset = "0x511C3F0", VA = "0x18511DBF0")]
	public ICFJLGHAIEC(bool FMEBOELOIJK = false, bool MNGOJPMKACH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x5360090", Offset = "0x535E890", VA = "0x185360090")]
	public void HJEIFCIIAIC(T JFBIOCFAFEC, U BLBINEIGPNI, V BKEAIPINHOO, W JCMJAPLEPMJ, X FGCAOGJDCFC, Y JGCHHJHFEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x535FCB0", Offset = "0x535E4B0", VA = "0x18535FCB0", Slot = "4")]
	public override void CIIFFFIMJAK(object[] MIOMNNIBEOC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x535FFF0", Offset = "0x535E7F0", VA = "0x18535FFF0")]
	public static global::ICFJLGHAIEC<T, U, V, W, X, Y> GAHCJAADICN(global::ICFJLGHAIEC<T, U, V, W, X, Y> ABCDLPCDENA, Action<T, U, V, W, X, Y> MJHIGMCCOPA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x5360920", Offset = "0x535F120", VA = "0x185360920")]
	public static global::ICFJLGHAIEC<T, U, V, W, X, Y> KKLEEKEHGNM(global::ICFJLGHAIEC<T, U, V, W, X, Y> ABCDLPCDENA, Action<T, U, V, W, X, Y> MJHIGMCCOPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public sealed class KIHJCPNIPKF<T>
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public readonly struct GPEOGFEOGLE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly global::KIHJCPNIPKF<T> ABPCJFPKCGN;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public T EJFMLMNCFJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x55DDB90", Offset = "0x55DC390", VA = "0x1855DDB90")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x55DDBB0", Offset = "0x55DC3B0", VA = "0x1855DDBB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x6DA260", Offset = "0x6D8A60", VA = "0x1806DA260")]
		public GPEOGFEOGLE(global::KIHJCPNIPKF<T> ABPCJFPKCGN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct JNKMEKECPHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncTaskMethodBuilder<GPEOGFEOGLE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public global::KIHJCPNIPKF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x55DDD30", Offset = "0x55DC530", VA = "0x1855DDD30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x55DDB40", Offset = "0x55DC340", VA = "0x1855DDB40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct GHLFGPHLMLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public AsyncTaskMethodBuilder<GPEOGFEOGLE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public global::KIHJCPNIPKF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x55DD970", Offset = "0x55DC170", VA = "0x1855DD970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x55DDB40", Offset = "0x55DC340", VA = "0x1855DDB40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly SemaphoreSlim FLNJFOENNOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private T KMOHLNGKHNE;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int HAACBOGPPIG
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x55E8C50", Offset = "0x55E7450", VA = "0x1855E8C50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x55E8CA0", Offset = "0x55E74A0", VA = "0x1855E8CA0")]
	public KIHJCPNIPKF(in T KMOHLNGKHNE, int IGMJAKEAHEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x55E8C70", Offset = "0x55E7470", VA = "0x1855E8C70")]
	public KIHJCPNIPKF(in T KMOHLNGKHNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x55E8BD0", Offset = "0x55E73D0", VA = "0x1855E8BD0")]
	public GPEOGFEOGLE BGICAGBKJGA()
	{
		return default(GPEOGFEOGLE);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x55E8C10", Offset = "0x55E7410", VA = "0x1855E8C10")]
	public GPEOGFEOGLE BGICAGBKJGA(CancellationToken NFKHAKHIBIO)
	{
		return default(GPEOGFEOGLE);
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x55E8A70", Offset = "0x55E7270", VA = "0x1855E8A70")]
	[AsyncStateMachine(typeof(global::KIHJCPNIPKF<>.JNKMEKECPHH))]
	public Task<GPEOGFEOGLE> AAGNKHGCMAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x55E8610", Offset = "0x55E6E10", VA = "0x1855E8610")]
	[AsyncStateMachine(typeof(global::KIHJCPNIPKF<>.GHLFGPHLMLE))]
	public Task<GPEOGFEOGLE> AAGNKHGCMAD(CancellationToken NFKHAKHIBIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class GJHOOBHNKIN
{
	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x4060A80", Offset = "0x405F280", VA = "0x184060A80")]
	public static global::KIHJCPNIPKF<OKGJCEGJEIG> DKPJNJAIMAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x4060AE0", Offset = "0x405F2E0", VA = "0x184060AE0")]
	public static global::KIHJCPNIPKF<OKGJCEGJEIG> DKPJNJAIMAF(int IGMJAKEAHEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0xC75D40", Offset = "0xC74540", VA = "0x180C75D40")]
	public static global::KIHJCPNIPKF<T> DKPJNJAIMAF<T>(in T KMOHLNGKHNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0xDA2B60", Offset = "0xDA1360", VA = "0x180DA2B60")]
	public static global::KIHJCPNIPKF<T> DKPJNJAIMAF<T>(in T KMOHLNGKHNE, int IGMJAKEAHEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class LJOEHJLDFGB<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public delegate Task<TResult> FFBGIAAFKJI(TRequest GMJOOGMAMPH, CancellationToken NFKHAKHIBIO);

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public enum MKEMMHIOHDF
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class KHPNNGPPHBL
	{
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private const float GIMJOKHNEHL = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private TimeSpan MKHGGFAIOIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public int OJEIJNDJANG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public MKEMMHIOHDF CKNBEJLMKGJ;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public static readonly KHPNNGPPHBL JBGJKCAJAOI;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public float BPLACFELJEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x55AEA90", Offset = "0x55AD290", VA = "0x1855AEA90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public TimeSpan ACHOOJBCNPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x5FD1C0", Offset = "0x5FB9C0", VA = "0x1805FD1C0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x55AEBE0", Offset = "0x55AD3E0", VA = "0x1855AEBE0")]
		public KHPNNGPPHBL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private readonly struct PJPELFKIIOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public readonly TRequest GMJOOGMAMPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public readonly CancellationToken NFKHAKHIBIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public readonly TaskCompletionSource<TResult> CIIKMPOFNNA;

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x55C67F0", Offset = "0x55C4FF0", VA = "0x1855C67F0")]
		public PJPELFKIIOF(TRequest GMJOOGMAMPH, TaskCompletionSource<TResult> CIIKMPOFNNA, CancellationToken NFKHAKHIBIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class AJJOAPPODHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69000", VA = "0x180B6A800")]
		public AJJOAPPODHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xE2A530", Offset = "0xE28D30", VA = "0x180E2A530")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private struct MCMAFACCKBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public global::LJOEHJLDFGB<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x55C5DA0", Offset = "0x55C45A0", VA = "0x1855C5DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private struct GNBECOPBFMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public global::LJOEHJLDFGB<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private PJPELFKIIOF <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x55AE520", Offset = "0x55ACD20", VA = "0x1855AE520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly CancellationTokenSource OJIOJCLMGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private readonly List<PJPELFKIIOF> NHFAEMMKDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly KHPNNGPPHBL EHDJLKHIEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly FFBGIAAFKJI IEJOOEPMMEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private Task ALOHHDMPGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int BMMOJKCEAAB;

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x55B0820", Offset = "0x55AF020", VA = "0x1855B0820")]
	public LJOEHJLDFGB(FFBGIAAFKJI IEJOOEPMMEH, [Optional] KHPNNGPPHBL EHDJLKHIEKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x55AEE90", Offset = "0x55AD690", VA = "0x1855AEE90")]
	public Task<TResult> DADGGCIFLJL(TRequest GMJOOGMAMPH, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x55AECC0", Offset = "0x55AD4C0", VA = "0x1855AECC0")]
	private void AGNGCBBKLEG(PJPELFKIIOF HNNKBMKLJLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x55B0450", Offset = "0x55AEC50", VA = "0x1855B0450")]
	[AsyncStateMachine(typeof(global::LJOEHJLDFGB<, >.MCMAFACCKBO))]
	private Task MCAEMKOOFKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x55AFD70", Offset = "0x55AE570", VA = "0x1855AFD70")]
	private PJPELFKIIOF GGOAIGKHAON()
	{
		return default(PJPELFKIIOF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x55B0210", Offset = "0x55AEA10", VA = "0x1855B0210")]
	[AsyncStateMachine(typeof(global::LJOEHJLDFGB<, >.GNBECOPBFMH))]
	private Task IIGMIMDNGAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x55AF600", Offset = "0x55ADE00", VA = "0x1855AF600")]
	private void EEMJDJGHOEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x55AF5C0", Offset = "0x55ADDC0", VA = "0x1855AF5C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class BFONKDFPGEI<TKey, TVal> : global::KKGGIKMMPOC<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int IOHBMLNKBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	internal Dictionary<TKey, (TVal value, int size)> HHGDIOAGIPM;

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	internal override int FFBIGAAFPEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x53ED8E0", Offset = "0x53EC0E0", VA = "0x1853ED8E0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	internal int GBAPCCCLAJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x53ED850", Offset = "0x53EC050", VA = "0x1853ED850")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public override int KKHILPEBPDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x53ED880", Offset = "0x53EC080", VA = "0x1853ED880", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x53ED9C0", Offset = "0x53EC1C0", VA = "0x1853ED9C0")]
	public BFONKDFPGEI(int JPMPKCEDKPJ, [Optional] NCIABKPNHJO LPEPPNGGJNN, [Optional] IEqualityComparer<TKey> OJKBEMJIADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x53ED620", Offset = "0x53EBE20", VA = "0x1853ED620")]
	public void EJFLNHJPAAE(TKey BAGMDNPKAJL, TVal CJMMBFLIBMO, bool BDGIAGLFBEA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x53ED7D0", Offset = "0x53EBFD0", VA = "0x1853ED7D0")]
	public bool JDCJNKIGIHP(TKey BAGMDNPKAJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x53ED910", Offset = "0x53EC110", VA = "0x1853ED910", Slot = "6")]
	public override bool PJOHNGKNBEM(TKey DBHNDNJAPJG, out TVal CJMMBFLIBMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x53ED3F0", Offset = "0x53EBBF0", VA = "0x1853ED3F0")]
	public bool DNPEJELHGEO(TKey BAGMDNPKAJL, TVal CJMMBFLIBMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x53ED2E0", Offset = "0x53EBAE0", VA = "0x1853ED2E0")]
	public bool BNEKMBDBJCP(TKey BAGMDNPKAJL, TVal CJMMBFLIBMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x53ED760", Offset = "0x53EBF60", VA = "0x1853ED760", Slot = "7")]
	public override void IDPJIGKEBOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x53ED6C0", Offset = "0x53EBEC0", VA = "0x1853ED6C0")]
	private bool FMGPAAAMLIG(TKey BAGMDNPKAJL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[DefaultMember("Item")]
public class KKGGIKMMPOC<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public delegate int NCIABKPNHJO(TKey BAGMDNPKAJL, TVal CJMMBFLIBMO);

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private class HNMOGAABDEM
	{
		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public TKey HMKHOIFGHNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x6348F0", Offset = "0x6330F0", VA = "0x1806348F0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public TVal EJFMLMNCFJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x643F60", Offset = "0x642760", VA = "0x180643F60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public int JKPGEJFPGLG
		{
			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x653E50", Offset = "0x652650", VA = "0x180653E50")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0x6FEC10", Offset = "0x6FD410", VA = "0x1806FEC10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public DateTime HAMHJLHPKCL
		{
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x6186A0", Offset = "0x616EA0", VA = "0x1806186A0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x83CC40", Offset = "0x83B440", VA = "0x18083CC40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x56D0330", Offset = "0x56CEB30", VA = "0x1856D0330")]
		public HNMOGAABDEM(TKey BAGMDNPKAJL, TVal OKHMGJIMEEL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public const int ONOBNMJPPEO = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<TKey, LinkedListNode<HNMOGAABDEM>> MIPBABDCJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly LinkedList<HNMOGAABDEM> OLOADNDKNAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	protected readonly NCIABKPNHJO LPEPPNGGJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly TimeSpan BEGJCGPBKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly BPFONJAHHJO CPCEGKCCKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private int PGCBHANJALN;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public int JKGEEOBIBFN
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6B3BD0", Offset = "0x6B23D0", VA = "0x1806B3BD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	private bool KHNILCOGIHN
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x56D1E80", Offset = "0x56D0680", VA = "0x1856D1E80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	internal virtual int FFBIGAAFPEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xCD6690", Offset = "0xCD4E90", VA = "0x180CD6690", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	private int FKDPJOHPNNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xD4A860", Offset = "0xD49060", VA = "0x180D4A860")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public virtual int KKHILPEBPDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xB7EBE0", Offset = "0xB7D3E0", VA = "0x180B7EBE0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public IEnumerable<TKey> CFIPAICBBJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x56D0A60", Offset = "0x56CF260", VA = "0x1856D0A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public TVal NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x127D7B0", Offset = "0x127BFB0", VA = "0x18127D7B0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x5636420", Offset = "0x5634C20", VA = "0x185636420")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x56D3370", Offset = "0x56D1B70", VA = "0x1856D3370")]
	public KKGGIKMMPOC(int JPMPKCEDKPJ, [Optional] NCIABKPNHJO LPEPPNGGJNN, [Optional] IEqualityComparer<TKey> OJKBEMJIADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x56D2EF0", Offset = "0x56D16F0", VA = "0x1856D2EF0")]
	public KKGGIKMMPOC(TimeSpan BEGJCGPBKIH, [Optional] IEqualityComparer<TKey> OJKBEMJIADI, [Optional] BPFONJAHHJO CPCEGKCCKJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x56D3010", Offset = "0x56D1810", VA = "0x1856D3010")]
	public KKGGIKMMPOC(int JPMPKCEDKPJ, TimeSpan BEGJCGPBKIH, [Optional] IEqualityComparer<TKey> OJKBEMJIADI, [Optional] BPFONJAHHJO CPCEGKCCKJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x56D2A70", Offset = "0x56D1270", VA = "0x1856D2A70")]
	public KKGGIKMMPOC(int JPMPKCEDKPJ, NCIABKPNHJO LPEPPNGGJNN, TimeSpan BEGJCGPBKIH, [Optional] IEqualityComparer<TKey> OJKBEMJIADI, [Optional] BPFONJAHHJO CPCEGKCCKJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x56D1D10", Offset = "0x56D0510", VA = "0x1856D1D10")]
	public void INDPIDFNCMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x56D19B0", Offset = "0x56D01B0", VA = "0x1856D19B0")]
	public void HEMBJNPDPPJ(TKey BAGMDNPKAJL, TVal CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x56D2150", Offset = "0x56D0950", VA = "0x1856D2150")]
	public bool NHIAFFMKOAF(TKey BAGMDNPKAJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x56D2570", Offset = "0x56D0D70", VA = "0x1856D2570")]
	private TVal NOBGIOELFLB(TKey DBHNDNJAPJG)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x56D2660", Offset = "0x56D0E60", VA = "0x1856D2660", Slot = "6")]
	public virtual bool PJOHNGKNBEM(TKey DBHNDNJAPJG, out TVal CJMMBFLIBMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x56D1B30", Offset = "0x56D0330", VA = "0x1856D1B30", Slot = "7")]
	public virtual void IDPJIGKEBOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x56D2090", Offset = "0x56D0890", VA = "0x1856D2090")]
	private bool NBFDACAFKPN(HNMOGAABDEM EFDICCMNFOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x56D0EC0", Offset = "0x56CF6C0", VA = "0x1856D0EC0")]
	private void EBJNELOFNKA(LinkedListNode<HNMOGAABDEM> OKDNKLAIGKE, TVal JFBNMEBIPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x56D1340", Offset = "0x56CFB40", VA = "0x1856D1340")]
	private void HDHHHNOANJM(TKey BAGMDNPKAJL, TVal CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x56D08C0", Offset = "0x56CF0C0", VA = "0x1856D08C0")]
	private void BGPPMECPCGD(HNMOGAABDEM EFDICCMNFOI, TVal JFBNMEBIPAN, int LPHOEMHGGLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[DefaultMember("Item")]
public class MFKFCECBPIP<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly List<T> BAKFHBILFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private HashSet<T> LAHCDJIBMHM;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public int KKHILPEBPDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xE2A530", Offset = "0xE28D30", VA = "0x180E2A530", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public bool FKKNEPJPEKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x604020", Offset = "0x602820", VA = "0x180604020", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public T NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0xE2A650", Offset = "0xE28E50", VA = "0x180E2A650", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x5443F40", Offset = "0x5442740", VA = "0x185443F40", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x51061F0", Offset = "0x51049F0", VA = "0x1851061F0", Slot = "11")]
	public void Add(T FJMIPHLNAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x5443800", Offset = "0x5442000", VA = "0x185443800")]
	public bool JLDJGOPCJNK(T FJMIPHLNAEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x5443C90", Offset = "0x5442490", VA = "0x185443C90", Slot = "15")]
	public bool Remove(T FJMIPHLNAEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x54435F0", Offset = "0x5441DF0", VA = "0x1854435F0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x120B470", Offset = "0x1209C70", VA = "0x18120B470", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x5443590", Offset = "0x5441D90", VA = "0x185443590", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x3397170", Offset = "0x3395970", VA = "0x183397170", Slot = "13")]
	public bool Contains(T FJMIPHLNAEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0xE2A9B0", Offset = "0xE291B0", VA = "0x180E2A9B0", Slot = "14")]
	public void CopyTo(T[] FPMNAPBFAMJ, int DDFINIJOFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x50FC4C0", Offset = "0x50FACC0", VA = "0x1850FC4C0", Slot = "6")]
	public int IndexOf(T FJMIPHLNAEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x5443670", Offset = "0x5441E70", VA = "0x185443670", Slot = "7")]
	public void Insert(int AKLHCIJHJKB, T FJMIPHLNAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x5443BC0", Offset = "0x54423C0", VA = "0x185443BC0", Slot = "8")]
	public void RemoveAt(int AKLHCIJHJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x5443A20", Offset = "0x5442220", VA = "0x185443A20")]
	public void LLAJDDJPKOB(Predicate<T> KCGBAGCENOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x5443560", Offset = "0x5441D60", VA = "0x185443560")]
	public void ANGKOBPJIOL(Comparison<T> DJEMCDIOHKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x5443DA0", Offset = "0x54425A0", VA = "0x185443DA0")]
	public MFKFCECBPIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public static class PAJOMDPMFDE
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x4066090", Offset = "0x4064890", VA = "0x184066090")]
	public static Vector3 JDPOBBEKEKL(this GameObject KFNNOPCEBCG, float JFNPIJOFCII)
	{
		return default(Vector3);
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0xDEB880", Offset = "0xDEA080", VA = "0x180DEB880")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x4068680", Offset = "0x4066E80", VA = "0x184068680")]
		public SerializedGuid(in Guid NKEBGFDENCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x4068390", Offset = "0x4066B90", VA = "0x184068390")]
		public static SerializedGuid LOGFHOEBANF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x40684A0", Offset = "0x4066CA0", VA = "0x1840684A0")]
		public static SerializedGuid OBBBANLPIPC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x4068410", Offset = "0x4066C10", VA = "0x184068410")]
		public bool MFEILNJHDIN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x4068650", Offset = "0x4066E50", VA = "0x184068650", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x40685B0", Offset = "0x4066DB0", VA = "0x1840685B0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x4068520", Offset = "0x4066D20", VA = "0x184068520")]
		public bool OIFFJDEDINI(in Guid NKEBGFDENCD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x4068200", Offset = "0x4066A00", VA = "0x184068200", Slot = "7")]
		public bool Equals(SerializedGuid ALBOAABJIJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x40682A0", Offset = "0x4066AA0", VA = "0x1840682A0", Slot = "0")]
		public override bool Equals(object DEGGOOGCHFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x4068380", Offset = "0x4066B80", VA = "0x184068380", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x40681D0", Offset = "0x40669D0", VA = "0x1840681D0", Slot = "6")]
		public int CompareTo(SerializedGuid ALBOAABJIJF)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class IOINJMLBOHD : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public readonly Type LPFDAKLBBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public readonly string GOOPPIBMCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public readonly bool BJAOPEDCJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public readonly bool KJNAGMKBFCA;

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x4062150", Offset = "0x4060950", VA = "0x184062150")]
	public IOINJMLBOHD(Type GAPOGJMNAMN, string BKIBMOKEBOG, bool GGHGKNNIMHH = false, bool HNNMBEJHEAA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public interface CBLLDBCKGCL
{
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public interface BOFJIMGLGKG<T> : CBLLDBCKGCL
{
	[Cpp2IlInjected.Token(Token = "0x17000078")]
	T EJFMLMNCFJG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	bool NFDCFGJGBGH
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	string JHGMBMNBLEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::BOFJIMGLGKG<T> IPGDOGECEOA(Action<T> EGCMBEIEHCE);

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::BOFJIMGLGKG<T> IGJIMCHADNJ(Action<T> EGCMBEIEHCE);

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::BOFJIMGLGKG<T> NEJBPKPHNJP(Action<T, T> ELKGCLKOMKF);

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::BOFJIMGLGKG<T> OANIDAPLJJG(Action<T, T> ELKGCLKOMKF);

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::BOFJIMGLGKG<T> DOFHPOCLEMA(Action<string> LIEIMHDKACC);

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::BOFJIMGLGKG<T> BOPJAHBDDAO(Action<string> LIEIMHDKACC);
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class GGMJIJDHKGB<T> : global::BOFJIMGLGKG<T>, CBLLDBCKGCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private global::CAFBCHKGCBG<T, T> DOBCNGGEIAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private global::DPAEMCAKAEJ<T> KDDHFMDLGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private global::DPAEMCAKAEJ<string> IMNCOEDHPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private string CKOAJFDEIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private T FNPLEFBJGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private bool LHBPDMJGGEN;

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public T EJFMLMNCFJG
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x638B30", Offset = "0x637330", VA = "0x180638B30", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x127EB50", Offset = "0x127D350", VA = "0x18127EB50", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool NFDCFGJGBGH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x630480", Offset = "0x62EC80", VA = "0x180630480", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public string JHGMBMNBLEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x6186A0", Offset = "0x616EA0", VA = "0x1806186A0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x2DF0E10", Offset = "0x2DEF610", VA = "0x182DF0E10", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x53CCC70", Offset = "0x53CB470", VA = "0x1853CCC70")]
	private void AHEEJAHFBBB(T KDGHFFBPFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x53CCD10", Offset = "0x53CB510", VA = "0x1853CCD10")]
	private void BOEFOJBLIKD(string MEKFJFMIPGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x53CCF90", Offset = "0x53CB790", VA = "0x1853CCF90")]
	public void LCAEFMHIJAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x53CD040", Offset = "0x53CB840", VA = "0x1853CD040", Slot = "6")]
	public global::BOFJIMGLGKG<T> NEJBPKPHNJP(Action<T, T> ELKGCLKOMKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x53CD090", Offset = "0x53CB890", VA = "0x1853CD090", Slot = "7")]
	public global::BOFJIMGLGKG<T> OANIDAPLJJG(Action<T, T> ELKGCLKOMKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x53CCF00", Offset = "0x53CB700", VA = "0x1853CCF00", Slot = "4")]
	public global::BOFJIMGLGKG<T> IPGDOGECEOA(Action<T> ELKGCLKOMKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x53CCEB0", Offset = "0x53CB6B0", VA = "0x1853CCEB0", Slot = "5")]
	public global::BOFJIMGLGKG<T> IGJIMCHADNJ(Action<T> EGCMBEIEHCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x53CCE20", Offset = "0x53CB620", VA = "0x1853CCE20", Slot = "8")]
	public global::BOFJIMGLGKG<T> DOFHPOCLEMA(Action<string> LIEIMHDKACC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x53CCDB0", Offset = "0x53CB5B0", VA = "0x1853CCDB0", Slot = "9")]
	public global::BOFJIMGLGKG<T> BOPJAHBDDAO(Action<string> LIEIMHDKACC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x53CD0E0", Offset = "0x53CB8E0", VA = "0x1853CD0E0")]
	public GGMJIJDHKGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public static class LNFMMLNLNKK
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class AOBKKAIPGGI<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public global::BOFJIMGLGKG<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public global::HDCMNDPJECI<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69000", VA = "0x180B6A800")]
		public AOBKKAIPGGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x55AD040", Offset = "0x55AB840", VA = "0x1855AD040")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x4F28A50", Offset = "0x4F27250", VA = "0x184F28A50")]
	public static global::DCBCPMGHAFG<T> JPOEPEFFBGI<T>(this global::BOFJIMGLGKG<T> DALBFILBPND, Action<T> LABDBOEIJFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class FEGLKKODBFL<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public readonly struct HBPLIHPAAKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public readonly long HNPDPNHFFCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public readonly long ABLEEOMMMMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public readonly int NOCGNCOJKDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public readonly int GILDNGMLMIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public readonly bool CCMMJKBLGCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private readonly string NGCKNKAJFFE;

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x509ED10", Offset = "0x509D510", VA = "0x18509ED10")]
		public HBPLIHPAAKF(long HNPDPNHFFCE, int NOCGNCOJKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x509ECE0", Offset = "0x509D4E0", VA = "0x18509ECE0")]
		public HBPLIHPAAKF(long HNPDPNHFFCE, long ABLEEOMMMMK, int NOCGNCOJKDH, int GILDNGMLMIO, bool CCMMJKBLGCN, string NGCKNKAJFFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x509EB60", Offset = "0x509D360", VA = "0x18509EB60")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void IKHGPJBMANC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x509EC90", Offset = "0x509D490", VA = "0x18509EC90")]
		public int PGELFINOHNN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x509EAD0", Offset = "0x509D2D0", VA = "0x18509EAD0")]
		public int EOEEENJMCIB(int MHDAIANCOMG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x509EAF0", Offset = "0x509D2F0", VA = "0x18509EAF0")]
		public double FPNMABPJOBN()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x509EBD0", Offset = "0x509D3D0", VA = "0x18509EBD0")]
		public HBPLIHPAAKF LBGOPOJKPCF(long ABLEEOMMMMK, int GILDNGMLMIO)
		{
			return default(HBPLIHPAAKF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class GBCJCBAKIDH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public readonly TKey HMKHOIFGHNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private readonly global::FEGLKKODBFL<TKey> MGJEIEDBIEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private List<GBCJCBAKIDH> HKPIGPNNDJH;

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public string PEDGLBMMGDO
		{
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x4F99100", Offset = "0x4F97900", VA = "0x184F99100")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x4F98840", Offset = "0x4F97040", VA = "0x184F98840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public IEnumerable<GBCJCBAKIDH> EJJNHBDBKNH
		{
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x509E160", Offset = "0x509C960", VA = "0x18509E160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public HBPLIHPAAKF ACMKLHNINLA
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x62FCB0", Offset = "0x62E4B0", VA = "0x18062FCB0")]
			[CompilerGenerated]
			get
			{
				return default(HBPLIHPAAKF);
			}
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x509E130", Offset = "0x509C930", VA = "0x18509E130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x509E550", Offset = "0x509CD50", VA = "0x18509E550")]
		internal GBCJCBAKIDH(global::FEGLKKODBFL<TKey> MGJEIEDBIEE, TKey BAGMDNPKAJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x509E440", Offset = "0x509CC40", VA = "0x18509E440")]
		public GBCJCBAKIDH ILPBPAONNPL(TKey BAGMDNPKAJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x509E340", Offset = "0x509CB40", VA = "0x18509E340")]
		public void EOLMMFNEBBN(TKey BAGMDNPKAJL, Action<GBCJCBAKIDH> MJHIGMCCOPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x1C346F0", Offset = "0x1C32EF0", VA = "0x181C346F0")]
		public T EOLMMFNEBBN<T>(TKey BAGMDNPKAJL, Func<GBCJCBAKIDH, T> PNAJEALMIDD)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x4F5A770", Offset = "0x4F58F70", VA = "0x184F5A770")]
		[AsyncStateMachine(typeof(HBIIFLAIGGD))]
		public Task<T> BDJIHBOBFNP<T>(TKey BAGMDNPKAJL, Func<GBCJCBAKIDH, Task<T>> PNAJEALMIDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x509E180", Offset = "0x509C980", VA = "0x18509E180", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class ACHKOPKOKBP : IEnumerable<(TKey, List<TKey>, HBPLIHPAAKF)>, IEnumerable, IEnumerator<(TKey, List<TKey>, HBPLIHPAAKF)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private (TKey key, List<TKey> path, HBPLIHPAAKF timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public global::FEGLKKODBFL<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private IEnumerator<(TKey key, List<TKey> path, HBPLIHPAAKF timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		private (TKey, List<TKey>, HBPLIHPAAKF) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x288BBD0", Offset = "0x288A3D0", VA = "0x18288BBD0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, HBPLIHPAAKF));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x5093E00", Offset = "0x5092600", VA = "0x185093E00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x5093F30", Offset = "0x5092730", VA = "0x185093F30")]
		[DebuggerHidden]
		public ACHKOPKOKBP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x5093E60", Offset = "0x5092660", VA = "0x185093E60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x5093A80", Offset = "0x5092280", VA = "0x185093A80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x5093EE0", Offset = "0x50926E0", VA = "0x185093EE0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x5093DB0", Offset = "0x50925B0", VA = "0x185093DB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x5093CF0", Offset = "0x50924F0", VA = "0x185093CF0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, HBPLIHPAAKF)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x257EDA0", Offset = "0x257D5A0", VA = "0x18257EDA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class HNOCGGFBGON : IEnumerable<(TKey, List<TKey>, HBPLIHPAAKF)>, IEnumerable, IEnumerator<(TKey, List<TKey>, HBPLIHPAAKF)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private (TKey key, List<TKey> path, HBPLIHPAAKF timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private GBCJCBAKIDH timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public GBCJCBAKIDH <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public global::FEGLKKODBFL<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private IEnumerator<GBCJCBAKIDH> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private IEnumerator<(TKey key, List<TKey> path, HBPLIHPAAKF timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		private (TKey, List<TKey>, HBPLIHPAAKF) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x288BBD0", Offset = "0x288A3D0", VA = "0x18288BBD0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, HBPLIHPAAKF));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x509F980", Offset = "0x509E180", VA = "0x18509F980", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x5093F30", Offset = "0x5092730", VA = "0x185093F30")]
		[DebuggerHidden]
		public HNOCGGFBGON(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x509F9E0", Offset = "0x509E1E0", VA = "0x18509F9E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x509F320", Offset = "0x509DB20", VA = "0x18509F320", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x509FAB0", Offset = "0x509E2B0", VA = "0x18509FAB0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x509FB00", Offset = "0x509E300", VA = "0x18509FB00")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x509F930", Offset = "0x509E130", VA = "0x18509F930", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x509F860", Offset = "0x509E060", VA = "0x18509F860", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, HBPLIHPAAKF)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x25BC560", Offset = "0x25BAD60", VA = "0x1825BC560", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly Action<TKey, HBPLIHPAAKF> MDLCBOBGDHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly Action<TKey, HBPLIHPAAKF> EODHJDHKPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly Action<global::FEGLKKODBFL<TKey>> MCFOKLKANMH;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private const string PGFOBJOAKJC = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly GBCJCBAKIDH MGGNPMHOHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private bool FNFCOIPJPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private int FJJMOJLHKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly Stopwatch JCFPNGJPFLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public readonly int BLIPOHCIGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private string HGMLDFBPEJE;

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public GBCJCBAKIDH MDEAJCFFCEC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x6186A0", Offset = "0x616EA0", VA = "0x1806186A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	[NotNull]
	public string PEDGLBMMGDO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x638B60", Offset = "0x637360", VA = "0x180638B60")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x50986A0", Offset = "0x5096EA0", VA = "0x1850986A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public long CPHJFCHNKHL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x5098640", Offset = "0x5096E40", VA = "0x185098640")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public int GGPOANHHKPA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x5098390", Offset = "0x5096B90", VA = "0x185098390")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x5098700", Offset = "0x5096F00", VA = "0x185098700")]
	public FEGLKKODBFL(TKey OPOHIBGONIJ, [Optional] int? NOCGNCOJKDH, [Optional][CanBeNull] Stopwatch JCFPNGJPFLE, [Optional] Action<TKey, HBPLIHPAAKF> MDLCBOBGDHL, [Optional] Action<TKey, HBPLIHPAAKF> EODHJDHKPCA, [Optional] Action<global::FEGLKKODBFL<TKey>> MCFOKLKANMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x5098450", Offset = "0x5096C50", VA = "0x185098450", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x5098680", Offset = "0x5096E80", VA = "0x185098680")]
	public void JGAJKPCMKMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x5098660", Offset = "0x5096E60", VA = "0x185098660")]
	public void IJFDAPJNEMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x50984E0", Offset = "0x5096CE0", VA = "0x1850984E0")]
	[IteratorStateMachine(typeof(global::FEGLKKODBFL<>.ACHKOPKOKBP))]
	public IEnumerable<(TKey, List<TKey>, HBPLIHPAAKF)> EENFKKADAKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x5098570", Offset = "0x5096D70", VA = "0x185098570")]
	[IteratorStateMachine(typeof(global::FEGLKKODBFL<>.HNOCGGFBGON))]
	private IEnumerable<(TKey, List<TKey>, HBPLIHPAAKF)> EENFKKADAKG(List<TKey> BGKDPPEDMBJ, GBCJCBAKIDH BMEDFGAICAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x50983C0", Offset = "0x5096BC0", VA = "0x1850983C0")]
	private (long, int) CEILKNOFDBM()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public abstract class GKLIAGEOJEJ<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut GEFFLLLEJNI(global::FEGLKKODBFL<TKey> MGJEIEDBIEE);

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69000", VA = "0x180B6A800")]
	protected GKLIAGEOJEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public abstract class EHFGJCOJNEK<TKey> : global::GKLIAGEOJEJ<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public delegate string AHHNEEKGPLD(TKey BAGMDNPKAJL);

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x5664590", Offset = "0x5662D90", VA = "0x185664590")]
	protected string ABPPMBNNHID(double IDHIBHHDMCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x5664800", Offset = "0x5663000", VA = "0x185664800")]
	protected string NNDAKCFPOGO(int HDBIDBBOLDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x56645F0", Offset = "0x5662DF0", VA = "0x1856645F0")]
	private static string ECBAONDIJCD(TKey BAGMDNPKAJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x5664630", Offset = "0x5662E30", VA = "0x185664630", Slot = "4")]
	public override string GEFFLLLEJNI(global::FEGLKKODBFL<TKey> MGJEIEDBIEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x56646E0", Offset = "0x5662EE0", VA = "0x1856646E0")]
	public string GEFFLLLEJNI(global::FEGLKKODBFL<TKey> MGJEIEDBIEE, [NotNull] AHHNEEKGPLD LEGPNDJMCKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string FEDKFNOLPBI(global::FEGLKKODBFL<TKey> MGJEIEDBIEE, [NotNull] AHHNEEKGPLD LEGPNDJMCKC);

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x2578670", Offset = "0x2576E70", VA = "0x182578670")]
	protected EHFGJCOJNEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class COKBGOHKDOI<TKey> : global::GKLIAGEOJEJ<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public delegate string DEPLDMLGBPF(TKey BAGMDNPKAJL);

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int LAMJGFNLMAP = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly string FPJGELIDHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly double BKECPBJCDJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly bool GCBMJAHPINF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly int EBEPBOAMBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly ISet<string> KKIPBNNEDAK;

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x564BFD0", Offset = "0x564A7D0", VA = "0x18564BFD0")]
	private static string ECBAONDIJCD(TKey BAGMDNPKAJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x564C560", Offset = "0x564AD60", VA = "0x18564C560")]
	public COKBGOHKDOI(string FPJGELIDHAH = "F2", double BKECPBJCDJI = double.MaxValue, bool GCBMJAHPINF = false, int EBEPBOAMBPG = int.MaxValue, [Optional] ISet<string> KKIPBNNEDAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x564C010", Offset = "0x564A810", VA = "0x18564C010", Slot = "4")]
	public override Dictionary<string, string> GEFFLLLEJNI(global::FEGLKKODBFL<TKey> MGJEIEDBIEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x564BD40", Offset = "0x564A540", VA = "0x18564BD40")]
	private bool CJHGHNCIABE(string MMCMNFBAHNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x564C0C0", Offset = "0x564A8C0", VA = "0x18564C0C0")]
	public Dictionary<string, string> GEFFLLLEJNI(global::FEGLKKODBFL<TKey> MGJEIEDBIEE, DEPLDMLGBPF LEGPNDJMCKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x564BE20", Offset = "0x564A620", VA = "0x18564BE20")]
	private string CMOLKCJCGLB(StringBuilder JCMDJGIOFDB, List<TKey> PCBMEAICPOA, DEPLDMLGBPF LEGPNDJMCKC, bool EPEAFALCBFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x564BBE0", Offset = "0x564A3E0", VA = "0x18564BBE0")]
	private static void CFIJLNNIGPG(StringBuilder IGOIFGLEICM, string OJFNOEEFJLF, bool BLDJFPGNHAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public class PMEJDHDLIFO<TKey> : global::EHFGJCOJNEK<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct APAMPMBMLAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public AHHNEEKGPLD keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static global::PMEJDHDLIFO<TKey> AAMGPJBHPCK;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private const int MIMHOAHMKBG = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly string[] NGNIECOAMIP;

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x4FA0570", Offset = "0x4F9ED70", VA = "0x184FA0570")]
	private PMEJDHDLIFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x4F9F650", Offset = "0x4F9DE50", VA = "0x184F9F650", Slot = "5")]
	protected override string FEDKFNOLPBI(global::FEGLKKODBFL<TKey> MGJEIEDBIEE, AHHNEEKGPLD LEGPNDJMCKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x4F9F570", Offset = "0x4F9DD70", VA = "0x184F9F570")]
	[CompilerGenerated]
	internal static string CEPGDCDJJPL(string AGOJALIGEPM, TKey BAGMDNPKAJL, ref APAMPMBMLAP P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public class OBMPHJPPEIK<TKey> : global::EHFGJCOJNEK<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class LHNHKGCHMLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public AHHNEEKGPLD keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69000", VA = "0x180B6A800")]
		public LHNHKGCHMLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x3402210", Offset = "0x3400A10", VA = "0x183402210")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x55027F0", Offset = "0x5500FF0", VA = "0x1855027F0", Slot = "5")]
	protected override string FEDKFNOLPBI(global::FEGLKKODBFL<TKey> MGJEIEDBIEE, AHHNEEKGPLD LEGPNDJMCKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x5502F40", Offset = "0x5501740", VA = "0x185502F40")]
	public OBMPHJPPEIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public sealed class ABBNOCFJJFG : global::FEGLKKODBFL<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class LAIIICANJGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public Action<ABBNOCFJJFG> callback;

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public LAIIICANJGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x4062B70", Offset = "0x4061370", VA = "0x184062B70")]
		internal void <Wrap>b__0(global::FEGLKKODBFL<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x405F1E0", Offset = "0x405D9E0", VA = "0x18405F1E0")]
	public ABBNOCFJJFG([Optional] string KCHGMILCNAL, [Optional] int? NOCGNCOJKDH, [Optional] Stopwatch JCFPNGJPFLE, [Optional] Action<string, HBPLIHPAAKF> MDLCBOBGDHL, [Optional] Action<string, HBPLIHPAAKF> EODHJDHKPCA, [Optional] Action<ABBNOCFJJFG> MCFOKLKANMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x405F120", Offset = "0x405D920", VA = "0x18405F120")]
	private static Action<global::FEGLKKODBFL<string>> EOLMMFNEBBN(Action<ABBNOCFJJFG> LABDBOEIJFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public abstract class BPFONJAHHJO
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	private class GPPJLOCPMBH : BPFONJAHHJO
	{
		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public static BPFONJAHHJO AAMGPJBHPCK
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x4061DD0", Offset = "0x40605D0", VA = "0x184061DD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public override DateTime GMBNIGPCOEP
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x4061E30", Offset = "0x4060630", VA = "0x184061E30", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public override float LNAKJIJBIIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x4061DC0", Offset = "0x40605C0", VA = "0x184061DC0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x4061F20", Offset = "0x4060720", VA = "0x184061F20")]
		public GPPJLOCPMBH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static BPFONJAHHJO CMOJIMNPOLP;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public static BPFONJAHHJO JBGJKCAJAOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x405FDE0", Offset = "0x405E5E0", VA = "0x18405FDE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public abstract DateTime GMBNIGPCOEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public abstract float LNAKJIJBIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	protected BPFONJAHHJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class GFPBIABEGPJ : global::JJCOPFGMAGL<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x4060A40", Offset = "0x405F240", VA = "0x184060A40")]
	public GFPBIABEGPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public class JJCOPFGMAGL<T> : global::CNAGBPIDIJA<T>, CGIHEBJPAIO, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public Task<T> HCDKCGBHFDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x5FD1C0", Offset = "0x5FB9C0", VA = "0x1805FD1C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private Task HGFLGGOIGFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x11F76D0", Offset = "0x11F5ED0", VA = "0x1811F76D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public global::DCBCPMGHAFG<T> ALAEDPIMNJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private JFMFFKHCJLK ABJGJEKFMJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x11F75A0", Offset = "0x11F5DA0", VA = "0x1811F75A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x562B8E0", Offset = "0x562A0E0", VA = "0x18562B8E0")]
	public JJCOPFGMAGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public class AGEALLNFENG : global::AHNMPECBKKB<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x405F300", Offset = "0x405DB00", VA = "0x18405F300")]
	public AGEALLNFENG(Exception HFHIFPILNEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class AHNMPECBKKB<T> : global::CNAGBPIDIJA<T>, CGIHEBJPAIO, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public Task<T> HCDKCGBHFDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x5FD1C0", Offset = "0x5FB9C0", VA = "0x1805FD1C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private Task HGFLGGOIGFF
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x11F76D0", Offset = "0x11F5ED0", VA = "0x1811F76D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public global::DCBCPMGHAFG<T> ALAEDPIMNJH
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private JFMFFKHCJLK ABJGJEKFMJA
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x11F75A0", Offset = "0x11F5DA0", VA = "0x1811F75A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x53FB740", Offset = "0x53F9F40", VA = "0x1853FB740")]
	public AHNMPECBKKB(Exception HFHIFPILNEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public interface CGIHEBJPAIO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000097")]
	[NotNull]
	Task HCDKCGBHFDG
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	[NotNull]
	JFMFFKHCJLK ALAEDPIMNJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public interface CNAGBPIDIJA<T> : CGIHEBJPAIO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000099")]
	[NotNull]
	new Task<T> HCDKCGBHFDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	[NotNull]
	new global::DCBCPMGHAFG<T> ALAEDPIMNJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public abstract class GBIILBJOLNE<TTask, T> : global::CNAGBPIDIJA<T>, CGIHEBJPAIO, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class JINKLNOPBHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public global::GBIILBJOLNE<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69000", VA = "0x180B6A800")]
		public JINKLNOPBHE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private static bool FAPOCEFEGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly Task<T> ACDNGKCJBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	protected readonly CancellationTokenSource GKPFEEDCFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private bool FNFCOIPJPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private SynchronizationContext GABPLBNELFA;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Task<T> HCDKCGBHFDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x5FD1C0", Offset = "0x5FB9C0", VA = "0x1805FD1C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	private Task HGFLGGOIGFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x5FD1C0", Offset = "0x5FB9C0", VA = "0x1805FD1C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public global::DCBCPMGHAFG<T> ALAEDPIMNJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	private JFMFFKHCJLK ABJGJEKFMJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x17344A0", Offset = "0x1732CA0", VA = "0x1817344A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool JAADKEOKHCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x7294F0", Offset = "0x727CF0", VA = "0x1807294F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x5715320", Offset = "0x5713B20", VA = "0x185715320")]
	static GBIILBJOLNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x5715640", Offset = "0x5713E40", VA = "0x185715640")]
	protected GBIILBJOLNE(TTask ACDNGKCJBDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x5714DE0", Offset = "0x57135E0", VA = "0x185714DE0", Slot = "1")]
	~GBIILBJOLNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x5714D10", Offset = "0x5713510", VA = "0x185714D10", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x5715040", Offset = "0x5713840", VA = "0x185715040")]
	private void KFAGLIPHBHL(bool IPEPNCHPHFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T OGACAMFHBKA(TTask NNJJDFEDIJE);

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void AFNGNAPODCM();

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x5714E80", Offset = "0x5713680", VA = "0x185714E80")]
	[CompilerGenerated]
	private void JKNKOOBNIAB(object PIBKCCAKALF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public interface KJKGGHJEOPG
{
	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	float LMHGPJIJACB
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event BNKGINJJLJB IGGAOHPLPBO;
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public class NIJMJBHMJAM : KJKGGHJEOPG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public readonly struct DAICJFJFIBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public readonly float OMIJOPHAOIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public readonly float ODLFFKDIKBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		internal readonly bool CPNLIKCPMHB;

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public float JKPGEJFPGLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x4060090", Offset = "0x405E890", VA = "0x184060090")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x4060200", Offset = "0x405EA00", VA = "0x184060200")]
		public DAICJFJFIBN(float MMECDMIFJKL, float NOOMMODKENI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x40600A0", Offset = "0x405E8A0", VA = "0x1840600A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private sealed class KELHBNMCBML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public NIJMJBHMJAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public KELHBNMCBML()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private readonly int JPMPKCEDKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private int HMNDBGNHMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly KJKGGHJEOPG[] HCAHMBBGECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly BNKGINJJLJB[] AGONKCODOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly DAICJFJFIBN[] OKLGHGPCHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private DAICJFJFIBN FPCPBNHDADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly BBGKOPIDFHO NDIOBEDKFFG;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public DAICJFJFIBN ODGCMEMLBCN
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x1DDE700", Offset = "0x1DDCF00", VA = "0x181DDE700")]
		get
		{
			return default(DAICJFJFIBN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float LMHGPJIJACB
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x4065970", Offset = "0x4064170", VA = "0x184065970", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event BNKGINJJLJB IGGAOHPLPBO
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x40658B0", Offset = "0x40640B0", VA = "0x1840658B0", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x4065410", Offset = "0x4063C10", VA = "0x184065410", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x4065990", Offset = "0x4064190", VA = "0x184065990")]
	public NIJMJBHMJAM(int JPMPKCEDKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x40651B0", Offset = "0x40639B0", VA = "0x1840651B0")]
	public BBGKOPIDFHO DCADGEOKFJF(DAICJFJFIBN PPFAJDNMMKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x40654D0", Offset = "0x4063CD0", VA = "0x1840654D0")]
	public void GNFPCMHLMFJ(KJKGGHJEOPG GNHOMAPPDIM, [Optional] DAICJFJFIBN IFFGKONJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x4065230", Offset = "0x4063A30", VA = "0x184065230")]
	internal int DCILMOLDEAH(KJKGGHJEOPG DOGEDDEOJJN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x4065160", Offset = "0x4063960", VA = "0x184065160")]
	internal DAICJFJFIBN ANGBDCHPFNM(int AKLHCIJHJKB)
	{
		return default(DAICJFJFIBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x4065280", Offset = "0x4063A80", VA = "0x184065280", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public delegate void BNKGINJJLJB(float FGDGAGBGCFJ);
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal static class HPKIFKKAJAP
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	internal const float JIKKJEMEPHN = 0.0001f;
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public static class JEIPFMDAAFE
{
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	private class KPKHLAHLLCG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private readonly KJKGGHJEOPG DOGEDDEOJJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private readonly BNKGINJJLJB LABDBOEIJFO;

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x4062AE0", Offset = "0x40612E0", VA = "0x184062AE0")]
		public KPKHLAHLLCG(KJKGGHJEOPG DOGEDDEOJJN, BNKGINJJLJB LABDBOEIJFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x4062A90", Offset = "0x4061290", VA = "0x184062A90", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x4062280", Offset = "0x4060A80", VA = "0x184062280")]
	internal static bool AOPMEHJEFHB(float DKLHMFCLOAB, float FLEBMPFFCAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x2515340", Offset = "0x2513B40", VA = "0x182515340")]
	internal static float LFOMNGNKFAD(float DKLHMFCLOAB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x40621C0", Offset = "0x40609C0", VA = "0x1840621C0")]
	public static IDisposable AHPCMHHCHFD(this KJKGGHJEOPG DOGEDDEOJJN, BNKGINJJLJB LABDBOEIJFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public class BBGKOPIDFHO : KJKGGHJEOPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private float FGDGAGBGCFJ;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public float LMHGPJIJACB
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x718FB0", Offset = "0x7177B0", VA = "0x180718FB0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x405F840", Offset = "0x405E040", VA = "0x18405F840")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event BNKGINJJLJB IGGAOHPLPBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x405F7A0", Offset = "0x405DFA0", VA = "0x18405F7A0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x405F700", Offset = "0x405DF00", VA = "0x18405F700", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public BBGKOPIDFHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public static class NMMIHLOPCIC
{
	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x4065AD0", Offset = "0x40642D0", VA = "0x184065AD0")]
	[NotNull]
	public static byte[] CFFAGEMPDME(this EMBDJDNPLDB HKANAKHJKFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x4065B40", Offset = "0x4064340", VA = "0x184065B40")]
	[NotNull]
	public static byte[] CFFAGEMPDME(this EMBDJDNPLDB HKANAKHJKFA, HashAlgorithmName MOKDBILMLHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x4065C20", Offset = "0x4064420", VA = "0x184065C20")]
	public static bool HKIOCMABMJP([CanBeNull] this EMBDJDNPLDB HKANAKHJKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x4065D90", Offset = "0x4064590", VA = "0x184065D90")]
	public static bool HKIOCMABMJP([CanBeNull] this EMBDJDNPLDB HKANAKHJKFA, out string CKOAJFDEIBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x4065BB0", Offset = "0x40643B0", VA = "0x184065BB0")]
	private static string HBMGBGLHPBL([CanBeNull] byte[] FCDIIMLAMIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x4065F10", Offset = "0x4064710", VA = "0x184065F10")]
	private static bool ODEMJGGFDLO([NotNull] EMBDJDNPLDB HKANAKHJKFA, [CanBeNull] out byte[] LCLMALFJLIP, [CanBeNull] out byte[] IHEOEOGILIF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public static class JGNAEEFKAFI
{
	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x4062300", Offset = "0x4060B00", VA = "0x184062300")]
	[NotNull]
	public static byte[] CFFAGEMPDME(this HILOHFKFDJI GBKNEJPCKAC, byte[] PFPMENDCEMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x4062340", Offset = "0x4060B40", VA = "0x184062340")]
	[NotNull]
	public static byte[] CFFAGEMPDME(this HILOHFKFDJI GBKNEJPCKAC, HashAlgorithmName MOKDBILMLHA, byte[] PFPMENDCEMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public interface HILOHFKFDJI
{
	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash KEMMPLOELNM);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public interface EMBDJDNPLDB : HILOHFKFDJI
{
	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	[CanBeNull]
	byte[] FNLLNDIADCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	[CanBeNull]
	byte[] EPEAFJEEGDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	UnityEngine.Object JBLKPIEBFEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public static class GKPKKDJNCDP
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class IKIDHNLKPBP : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x40620D0", Offset = "0x40608D0", VA = "0x1840620D0")]
		public IKIDHNLKPBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x4062070", Offset = "0x4060870", VA = "0x184062070", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private const byte BLEMADKMIDN = 1;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private const byte ONMFDCHLPHD = 0;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly ArrayPool<byte> IDMJINOAFIF;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private static bool PPDHLMCKBMC;

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x315FDF0", Offset = "0x315E5F0", VA = "0x18315FDF0")]
	[Conditional("UNITY_EDITOR")]
	private static void CKAGDCKDPJL<T>(params T[] PBOKKELNLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x4060E00", Offset = "0x405F600", VA = "0x184060E00")]
	public static IDisposable CNBDKKHHJGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x4061490", Offset = "0x405FC90", VA = "0x184061490")]
	public static void MKAINKFNJGB(this IncrementalHash OPMPPFKMPMJ, [CanBeNull] GameObject KFNNOPCEBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x3160C10", Offset = "0x315F410", VA = "0x183160C10")]
	public static void MKAINKFNJGB<T>(this IncrementalHash OPMPPFKMPMJ, [CanBeNull] T CFCFGDKOLFC) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x31600B0", Offset = "0x315E8B0", VA = "0x1831600B0")]
	public static void FNENKLFPANE<T>(this IncrementalHash OPMPPFKMPMJ, [CanBeNull] T GBKNEJPCKAC) where T : HILOHFKFDJI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x31607B0", Offset = "0x315EFB0", VA = "0x1831607B0")]
	public static void IJFFOPJDHBI<T>(this IncrementalHash OPMPPFKMPMJ, [CanBeNull] IList<T> KMPONANPJOB) where T : HILOHFKFDJI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x40613E0", Offset = "0x405FBE0", VA = "0x1840613E0")]
	private static bool LOEJJJCJGKC([CanBeNull] HILOHFKFDJI GBKNEJPCKAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x4060DA0", Offset = "0x405F5A0", VA = "0x184060DA0")]
	public static void AIKKJGLEDND(this IncrementalHash KEMMPLOELNM, [CanBeNull] string JPNJJFEGCLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x4060EA0", Offset = "0x405F6A0", VA = "0x184060EA0")]
	public static void EINDOLIBHMB(this IncrementalHash KEMMPLOELNM, long LIHFBFBMMGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x4061A70", Offset = "0x4060270", VA = "0x184061A70")]
	public static void PDBEMMHLELC(this IncrementalHash KEMMPLOELNM, int MHBHIDMOPFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x4060BB0", Offset = "0x405F3B0", VA = "0x184060BB0")]
	public static void ABFBABLBAMI(this IncrementalHash KEMMPLOELNM, short CFKAEBHBJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x40616F0", Offset = "0x405FEF0", VA = "0x1840616F0")]
	public static void OACFEHKCIBM(this IncrementalHash KEMMPLOELNM, byte HMMHJMBLMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x4061880", Offset = "0x4060080", VA = "0x184061880")]
	public static void PADPBBMADCM(this IncrementalHash KEMMPLOELNM, bool CDPJOOEHOIK, bool EOJNHPMJLDH = false, bool BIAHEBBIDPJ = false, bool FKECDEPJGEE = false, bool FKLKHMOHOFB = false, bool BGAHHKFFDIG = false, bool NJADFBLHGEM = false, bool IBPLOFPDPBA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x3160140", Offset = "0x315E940", VA = "0x183160140")]
	public static void HJGJOKBGMOO<T>(this IncrementalHash KEMMPLOELNM, T DJAGHDAFJEC) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x40612B0", Offset = "0x405FAB0", VA = "0x1840612B0")]
	public static void GKEBIBHPNCF(this IncrementalHash KEMMPLOELNM, float IEENOJAFDNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x4061380", Offset = "0x405FB80", VA = "0x184061380")]
	public static void IOIKOGGKJOI(this IncrementalHash KEMMPLOELNM, double BHFMNDCAPED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x4061310", Offset = "0x405FB10", VA = "0x184061310")]
	public static void HGHFAFBGMJJ(this IncrementalHash KEMMPLOELNM, ulong BBBOBDMGLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x4061C60", Offset = "0x4060460", VA = "0x184061C60")]
	public static void PKMJFNGFACO(this IncrementalHash KEMMPLOELNM, uint IJBAFPEGANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x4061240", Offset = "0x405FA40", VA = "0x184061240")]
	public static void GIFFPBKAEIF(this IncrementalHash KEMMPLOELNM, ushort HHADNNLJKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x4061570", Offset = "0x405FD70", VA = "0x184061570")]
	public static void NNKAEFHBKEC(this IncrementalHash KEMMPLOELNM, Vector3 EBHGKFNDHPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x4061090", Offset = "0x405F890", VA = "0x184061090")]
	public static void FKDMLLGGOEK(this IncrementalHash KEMMPLOELNM, Quaternion GENHJIFMENH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public class FAMPKMCDHEB : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public readonly Type LPFDAKLBBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public readonly string GOOPPIBMCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public readonly bool BJAOPEDCJBC;

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x4060920", Offset = "0x405F120", VA = "0x184060920")]
	public FAMPKMCDHEB(Type GAPOGJMNAMN, string BKIBMOKEBOG, bool GGHGKNNIMHH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public class HIKOFFIOPIA : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x4061F80", Offset = "0x4060780", VA = "0x184061F80")]
	public HIKOFFIOPIA(string MEKFJFMIPGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x4061FF0", Offset = "0x40607F0", VA = "0x184061FF0")]
	public HIKOFFIOPIA(string MEKFJFMIPGK, Exception GMIHELLOACL)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x6348F0", Offset = "0x6330F0", VA = "0x1806348F0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x6866E0", Offset = "0x684EE0", VA = "0x1806866E0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public T this[int GDBELOJNNFN, int CMOFKOLEDBO]
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x541E320", Offset = "0x541CB20", VA = "0x18541E320")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x541E3C0", Offset = "0x541CBC0", VA = "0x18541E3C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x541E290", Offset = "0x541CA90", VA = "0x18541E290")]
		public Array2D(uint AEHBFLGCOBN, uint ELIOJOIGIEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x541E210", Offset = "0x541CA10", VA = "0x18541E210")]
		public void IDPJIGKEBOL()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x405F6A0", Offset = "0x405DEA0", VA = "0x18405F6A0")]
		public Array2DVector3(uint AEHBFLGCOBN, uint ELIOJOIGIEI)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal static class LEKFFPGCBLO
{
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public const int ECHPHINCHOA = -1;

	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public const int JJCBBGPHHKK = 0;
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[DefaultMember("Item")]
public class NBHCCKKMIHD<THandle, TValue> : IDisposable where THandle : struct, ECOGJIGKDHI where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private readonly List<THandle> CEOIMONPOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private readonly List<TValue> MLKKKEDBGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private readonly Func<TValue> AFLMIPHNLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly Action<TValue> KDALBAAPDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private int FINDAIKFAHL;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public TValue NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x50FC050", Offset = "0x50FA850", VA = "0x1850FC050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x577F780", Offset = "0x577DF80", VA = "0x18577F780")]
	public NBHCCKKMIHD(Action<TValue> KDALBAAPDHE, [Optional] Func<TValue> AFLMIPHNLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x577F0E0", Offset = "0x577D8E0", VA = "0x18577F0E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x577EE30", Offset = "0x577D630", VA = "0x18577EE30")]
	public THandle BHNJDAHDLKD()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x577F6C0", Offset = "0x577DEC0", VA = "0x18577F6C0")]
	public THandle NLKJJINIDJF(TValue CJMMBFLIBMO)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x577F560", Offset = "0x577DD60", VA = "0x18577F560")]
	public bool NHIAFFMKOAF(THandle LPPHLKEKIOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x577F440", Offset = "0x577DC40", VA = "0x18577F440")]
	public bool LIPJKPPEBGH(THandle LPPHLKEKIOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x577ED90", Offset = "0x577D590", VA = "0x18577ED90")]
	public bool APHJBAJPDLG(THandle LPPHLKEKIOC, out TValue CJMMBFLIBMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x577F730", Offset = "0x577DF30", VA = "0x18577F730")]
	public TValue NOBGIOELFLB(THandle LPPHLKEKIOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x577F610", Offset = "0x577DE10", VA = "0x18577F610")]
	public bool NKBMJECLOCI(THandle LPPHLKEKIOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x577F530", Offset = "0x577DD30", VA = "0x18577F530")]
	private THandle MIEEEJKJLBE(int AKLHCIJHJKB)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x577F2B0", Offset = "0x577DAB0", VA = "0x18577F2B0")]
	private TValue JPOEPEFFBGI(int AKLHCIJHJKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x577F400", Offset = "0x577DC00", VA = "0x18577F400")]
	private void LGCGMPGIPCP(int AKLHCIJHJKB, in THandle LPPHLKEKIOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x577ECF0", Offset = "0x577D4F0", VA = "0x18577ECF0")]
	private void AHEEJAHFBBB(int AKLHCIJHJKB, in TValue CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x577EBE0", Offset = "0x577D3E0", VA = "0x18577EBE0")]
	private THandle AAMIEGMHDOD()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x577F010", Offset = "0x577D810", VA = "0x18577F010")]
	private void CAKFGIAAPKO(THandle LPPHLKEKIOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x577F520", Offset = "0x577DD20", VA = "0x18577F520")]
	private int MADCAHEFGNI(int KAGEGNEPBEI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x577F0D0", Offset = "0x577D8D0", VA = "0x18577F0D0")]
	private bool DLLAODNCHKL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x628C90", Offset = "0x627490", VA = "0x180628C90")]
	private void CCLMHHOIDDB(THandle LPPHLKEKIOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x577F230", Offset = "0x577DA30", VA = "0x18577F230")]
	private bool GCEPOJCDNDG(out THandle LPPHLKEKIOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x577F160", Offset = "0x577D960", VA = "0x18577F160")]
	private bool EGIPOFPNKHK(out THandle LPPHLKEKIOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x577ED30", Offset = "0x577D530", VA = "0x18577ED30")]
	private void AJAHKHDGMNA(THandle LPPHLKEKIOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x577F2E0", Offset = "0x577DAE0", VA = "0x18577F2E0")]
	private void LAGMJCFEDIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public interface ECOGJIGKDHI
{
	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	int PDGADEKDACK
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	int JLICIKJPFHO
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public interface KDFMKIHLJFP<T> : ECOGJIGKDHI, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public static class PGFDJFFAKEF
{
	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0xFA8350", Offset = "0xFA6B50", VA = "0x180FA8350")]
	public static bool JPEPGILAHON<T>(this T LPPHLKEKIOC, T ALBOAABJIJF) where T : struct, ECOGJIGKDHI
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0xFA8340", Offset = "0xFA6B40", VA = "0x180FA8340")]
	public static bool CPNLIKCPMHB<T>(this T LPPHLKEKIOC) where T : struct, ECOGJIGKDHI
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x4066320", Offset = "0x4064B20", VA = "0x184066320")]
	public static string GLDHNLDLCDN(this ECOGJIGKDHI LPPHLKEKIOC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public class LIODEKJGIHA
{
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private enum IEKAPHNIFDK : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private int KEMMPLOELNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private bool KFGCPDALGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private IEKAPHNIFDK KCDMBPDEAMJ;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool EDPKODLEAFK
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x40639C0", Offset = "0x40621C0", VA = "0x1840639C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool ODCPKEEFJCH
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x4063B80", Offset = "0x4062380", VA = "0x184063B80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x40647A0", Offset = "0x4062FA0", VA = "0x1840647A0")]
	public LIODEKJGIHA(bool KFGCPDALGCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x4063C00", Offset = "0x4062400", VA = "0x184063C00")]
	public void GPAAFMIHPEH(object DEGGOOGCHFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x4064190", Offset = "0x4062990", VA = "0x184064190")]
	public void HOKPJGIJFJC(int CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x4063AF0", Offset = "0x40622F0", VA = "0x184063AF0")]
	public void CHKCOLBDEMN(uint KFJHPJNDOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x40642C0", Offset = "0x4062AC0", VA = "0x1840642C0")]
	public void MKGMCMPMPFK(bool DFGGCHCFKAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x4063B40", Offset = "0x4062340", VA = "0x184063B40")]
	public void DMGJOANGFNE(long JNGACMFKCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x4063B00", Offset = "0x4062300", VA = "0x184063B00")]
	public void DBLMFGMPHDP(ulong DNIDLEKJBBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x4064120", Offset = "0x4062920", VA = "0x184064120")]
	public void HCAHKDNCDGC(string KHFJLLEIAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x4064710", Offset = "0x4062F10", VA = "0x184064710")]
	public void PINOONDCDPC(Enum HFHIFPILNEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x40639D0", Offset = "0x40621D0", VA = "0x1840639D0")]
	public void CCJCGKKPLLO(IList BAKFHBILFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0xC5FDC0", Offset = "0xC5E5C0", VA = "0x180C5FDC0")]
	public void IFFDHGOAKPM<T, U>(Dictionary<T, U> MOCACMHDFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x40642E0", Offset = "0x4062AE0", VA = "0x1840642E0")]
	private void NPKHKCAADMB(IDictionary MOCACMHDFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x4063B90", Offset = "0x4062390", VA = "0x184063B90")]
	public int EPKPPLIGEND()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x4064250", Offset = "0x4062A50", VA = "0x184064250")]
	public short KABDHNCFHJP()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x4064240", Offset = "0x4062A40", VA = "0x184064240")]
	public void IDPJIGKEBOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x40646A0", Offset = "0x4062EA0", VA = "0x1840646A0")]
	private void OHKBGPKFCBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public abstract class CAIANKNOMLO<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	internal class FGBOENKPGKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public TNode KBMECNBEFEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public TNode CELKNCFBAOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public KFAPEALABFA MHMHPHOEJMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public List<KFAPEALABFA> OKGEGHGKDKB;

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69000", VA = "0x180B6A800")]
		public FGBOENKPGKD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	internal struct KFAPEALABFA : IComparable<KFAPEALABFA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public int BMGHFFAGJHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public TClaimant CGHICMMNIDA;

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0xB2EA40", Offset = "0xB2D240", VA = "0x180B2EA40")]
		public KFAPEALABFA(int BMGHFFAGJHI, TClaimant CGHICMMNIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x561DDF0", Offset = "0x561C5F0", VA = "0x18561DDF0")]
		public bool IPJECGIPGOB(in KFAPEALABFA ALBOAABJIJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x561DE50", Offset = "0x561C650", VA = "0x18561DE50")]
		public bool JCDCKLCOCIK(in KFAPEALABFA ALBOAABJIJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x561DDE0", Offset = "0x561C5E0", VA = "0x18561DDE0", Slot = "4")]
		public int CompareTo(KFAPEALABFA ALBOAABJIJF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x561DE60", Offset = "0x561C660", VA = "0x18561DE60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public enum DNKCAECAABH
	{
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private sealed class PJCDPEAPPAG : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public global::CAIANKNOMLO<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003FC")]
			[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x120A250", Offset = "0x1208A50", VA = "0x18120A250")]
		[DebuggerHidden]
		public PJCDPEAPPAG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x5621FB0", Offset = "0x56207B0", VA = "0x185621FB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x5622170", Offset = "0x5620970", VA = "0x185622170", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x5622090", Offset = "0x5620890", VA = "0x185622090", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x2554F70", Offset = "0x2553770", VA = "0x182554F70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private static readonly global::LFLENPAOPHG<FGBOENKPGKD> CMHAGKAEBDK;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private static readonly global::LFLENPAOPHG<List<KFAPEALABFA>> ONGNNPJMJDM;

	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private static int PBJMAOGOJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	internal readonly Dictionary<TClaimant, TNode> OHGGMJGOLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	internal readonly Dictionary<TNode, FGBOENKPGKD> HEJBKIILKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private DNKCAECAABH CHFDMDJDKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private bool NMANPNFCCCL;

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode MOLCNOANCBK(TNode MHNJKLLCLHP);

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void KGPIPKCHFLA(TNode MHNJKLLCLHP, TClaimant AAFMIKICFAO, TClaimant NBBNBDCIGLH);

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x561A4F0", Offset = "0x5618CF0", VA = "0x18561A4F0")]
	public CAIANKNOMLO(DNKCAECAABH CHFDMDJDKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x5619630", Offset = "0x5617E30", VA = "0x185619630")]
	public void JKCBFHPFBGK(TNode MHNJKLLCLHP, TNode ACODEJEKDBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x5618C90", Offset = "0x5617490", VA = "0x185618C90")]
	public void BINFDGNEDFM(TClaimant CGHICMMNIDA, TNode BJLMDOKLEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x5618E90", Offset = "0x5617690", VA = "0x185618E90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x5619C20", Offset = "0x5618420", VA = "0x185619C20")]
	private void NBFHMBIOIBA(TClaimant CGHICMMNIDA, TNode AGHNLADIECO, TNode BJLMDOKLEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x5619CC0", Offset = "0x56184C0", VA = "0x185619CC0")]
	private int NKAKGBJDDGC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x56190F0", Offset = "0x56178F0", VA = "0x1856190F0")]
	private void FPCICLMLCGM(TClaimant CGHICMMNIDA, TNode JPGGAAAKKFF, TNode ELKNCMDOGDP, int KHBGGCECLCC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x5619D30", Offset = "0x5618530", VA = "0x185619D30")]
	private void OEGAGIMHEEJ(KFAPEALABFA BPJGHOOHJBP, FGBOENKPGKD CLKJKCAJGNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x5619770", Offset = "0x5617F70", VA = "0x185619770")]
	private void KBMJCKBIGJO(TClaimant CGHICMMNIDA, TNode JPGGAAAKKFF, TNode ELKNCMDOGDP, int KHBGGCECLCC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x56199E0", Offset = "0x56181E0", VA = "0x1856199E0")]
	private void KCCEJCHCHOE(KFAPEALABFA BPJGHOOHJBP, TNode MHNJKLLCLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x5618D90", Offset = "0x5617590", VA = "0x185618D90")]
	private void DOBOKCFLDNB(KFAPEALABFA BPJGHOOHJBP, FGBOENKPGKD CLKJKCAJGNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x5619AE0", Offset = "0x56182E0", VA = "0x185619AE0")]
	private void KHCLPKGEEKA(FGBOENKPGKD CLKJKCAJGNJ, bool MJHNAGHAKDC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x5619DC0", Offset = "0x56185C0", VA = "0x185619DC0")]
	private void PEOEHLDPHMD(FGBOENKPGKD CLKJKCAJGNJ, TNode ACODEJEKDBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x5619560", Offset = "0x5617D60", VA = "0x185619560")]
	[IteratorStateMachine(typeof(global::CAIANKNOMLO<, >.PJCDPEAPPAG))]
	private IEnumerable<TNode> IFNNDCKAPMA(TNode JPGGAAAKKFF, TNode ELKNCMDOGDP, bool NJCDPBDLKDL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x56196B0", Offset = "0x5617EB0", VA = "0x1856196B0")]
	private FGBOENKPGKD JOFLLNNIFEE(TNode MHNJKLLCLHP, TNode CELKNCFBAOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x561A200", Offset = "0x5618A00", VA = "0x18561A200")]
	private FGBOENKPGKD PIJBOBHMNIF(TNode MHNJKLLCLHP, TNode CELKNCFBAOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x56193A0", Offset = "0x5617BA0", VA = "0x1856193A0")]
	private void HEOPKPCIPDA(FGBOENKPGKD CLKJKCAJGNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public class NAPMFIKNDHI<T> : IEnumerable<global::NAPMFIKNDHI<T>.BBADLLOEOEA>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public struct BBADLLOEOEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public T CJMMBFLIBMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public int AKLHCIJHJKB;
	}

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public class DGJMAOOKIFM : IEnumerator<BBADLLOEOEA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private global::NAPMFIKNDHI<T> OMEFEABFKAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private int AKLHCIJHJKB;

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0x150A050", Offset = "0x1508850", VA = "0x18150A050", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		public BBADLLOEOEA HLHDNNKPFLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0x5771010", Offset = "0x576F810", VA = "0x185771010", Slot = "4")]
			get
			{
				return default(BBADLLOEOEA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x16847C0", Offset = "0x1682FC0", VA = "0x1816847C0")]
		public DGJMAOOKIFM(global::NAPMFIKNDHI<T> OMEFEABFKAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x5770E90", Offset = "0x576F690", VA = "0x185770E90", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x16847B0", Offset = "0x1682FB0", VA = "0x1816847B0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x1944F10", Offset = "0x1943710", VA = "0x181944F10", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	private struct CPLGGIHGGCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public bool NAGKKIAKCDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public T CJMMBFLIBMO;
	}

	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private const int EEJMBGBFEJN = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private readonly Dictionary<T, int> FCNOAPJKBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private CPLGGIHGGCC[] NGGGNFACAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private int FNIGNFHKPAM;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public int MDAHEGOEMDH
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x6C1960", Offset = "0x6C0160", VA = "0x1806C1960")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xD244E0", Offset = "0xD22CE0", VA = "0x180D244E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public int KKHILPEBPDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xE2A530", Offset = "0xE28D30", VA = "0x180E2A530")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x577E320", Offset = "0x577CB20", VA = "0x18577E320")]
	public NAPMFIKNDHI(int JPMPKCEDKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x577E7F0", Offset = "0x577CFF0", VA = "0x18577E7F0")]
	public NAPMFIKNDHI(BBADLLOEOEA[] LAMLPNDDOBD, bool NPPLGDPAHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x577CD70", Offset = "0x577B570", VA = "0x18577CD70")]
	public int FMILPBEIFKD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x577D250", Offset = "0x577BA50", VA = "0x18577D250")]
	private int HMMBFBMAHDJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x577CDE0", Offset = "0x577B5E0", VA = "0x18577CDE0", Slot = "6")]
	protected virtual uint GJJGBGCGDBC(uint KEMMPLOELNM, T CJMMBFLIBMO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x577D530", Offset = "0x577BD30", VA = "0x18577D530")]
	public bool IMDLEPIHNKP(T CJMMBFLIBMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x577E040", Offset = "0x577C840", VA = "0x18577E040")]
	public bool MOHKGMDDNMO(int AKLHCIJHJKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x577DD70", Offset = "0x577C570", VA = "0x18577DD70")]
	public bool JNEGJNMGLPF(Func<T, bool> LNGJAMBEIJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x577CCC0", Offset = "0x577B4C0", VA = "0x18577CCC0")]
	public int AOHNFMFLLBI(T CJMMBFLIBMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x577DEF0", Offset = "0x577C6F0", VA = "0x18577DEF0")]
	public T JPOEPEFFBGI(int AKLHCIJHJKB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x577D4B0", Offset = "0x577BCB0", VA = "0x18577D4B0")]
	public void IDPJIGKEBOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x577DD30", Offset = "0x577C530", VA = "0x18577DD30")]
	public bool JLDJGOPCJNK(T CJMMBFLIBMO, bool OFPHCOGMDHD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x577D850", Offset = "0x577C050", VA = "0x18577D850")]
	public bool JLDJGOPCJNK(T CJMMBFLIBMO, int AKLHCIJHJKB, bool OFPHCOGMDHD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x577E170", Offset = "0x577C970", VA = "0x18577E170")]
	public bool NHIAFFMKOAF(T CJMMBFLIBMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x577E0A0", Offset = "0x577C8A0", VA = "0x18577E0A0")]
	public bool NGEIKIGMGGE(int AKLHCIJHJKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x577CF10", Offset = "0x577B710", VA = "0x18577CF10")]
	private void HADBHECFFLJ(int AKLHCIJHJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x577D5A0", Offset = "0x577BDA0", VA = "0x18577D5A0")]
	public BBADLLOEOEA[] JKBLAANMFMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x577E250", Offset = "0x577CA50", VA = "0x18577E250")]
	private int PHAODAABLEA(int DABGAKHOBBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x577E2A0", Offset = "0x577CAA0", VA = "0x18577E2A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x577E2A0", Offset = "0x577CAA0", VA = "0x18577E2A0", Slot = "4")]
	private IEnumerator<BBADLLOEOEA> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public struct HICLOFGCMMI<Handle> where Handle : ECOGJIGKDHI, new()
{
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	private struct BGGKOCPJOPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private readonly global::HICLOFGCMMI<Handle> LEMOBIBGKMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private int AKLHCIJHJKB;

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public int BJMJMDEMPEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000439")]
			[Cpp2IlInjected.Address(RVA = "0x5552B20", Offset = "0x5551320", VA = "0x185552B20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public Handle OODCGIJOPFD
		{
			[Cpp2IlInjected.Token(Token = "0x600043A")]
			[Cpp2IlInjected.Address(RVA = "0x55528E0", Offset = "0x55510E0", VA = "0x1855528E0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x5552C00", Offset = "0x5551400", VA = "0x185552C00")]
		public BGGKOCPJOPB(global::HICLOFGCMMI<Handle> LEMOBIBGKMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x5552810", Offset = "0x5551010", VA = "0x185552810")]
		public EJEBMAOFHJD DKPJNJAIMAF(in EJEBMAOFHJD IIFJOCIBPGA)
		{
			return default(EJEBMAOFHJD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x5552740", Offset = "0x5550F40", VA = "0x185552740")]
		public JNHLLHDHKIH DKPJNJAIMAF(in JNHLLHDHKIH IIFJOCIBPGA)
		{
			return default(JNHLLHDHKIH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x5552A40", Offset = "0x5551240", VA = "0x185552A40")]
		public bool ELGPOGANPAO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x55526E0", Offset = "0x5550EE0", VA = "0x1855526E0")]
		private int DGBEIBOJBAB(string MEKFJFMIPGK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x5552680", Offset = "0x5550E80", VA = "0x185552680")]
		private Handle AGIAKNIODHK(string MEKFJFMIPGK)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public struct EJEBMAOFHJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private BGGKOCPJOPB NNPKNNGLNGF;

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public int HLHDNNKPFLO
		{
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0x568D660", Offset = "0x568BE60", VA = "0x18568D660")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x568D700", Offset = "0x568BF00", VA = "0x18568D700")]
		public EJEBMAOFHJD(global::HICLOFGCMMI<Handle> LEMOBIBGKMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x568D350", Offset = "0x568BB50", VA = "0x18568D350")]
		public bool ELGPOGANPAO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x568D530", Offset = "0x568BD30", VA = "0x18568D530")]
		public EJEBMAOFHJD JMGPEBMNFFJ()
		{
			return default(EJEBMAOFHJD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public struct JNHLLHDHKIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private BGGKOCPJOPB NNPKNNGLNGF;

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public Handle HLHDNNKPFLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000442")]
			[Cpp2IlInjected.Address(RVA = "0x5698F50", Offset = "0x5697750", VA = "0x185698F50")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x568D700", Offset = "0x568BF00", VA = "0x18568D700")]
		public JNHLLHDHKIH(global::HICLOFGCMMI<Handle> LEMOBIBGKMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x568D350", Offset = "0x568BB50", VA = "0x18568D350")]
		public bool ELGPOGANPAO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x5698E20", Offset = "0x5697620", VA = "0x185698E20")]
		public JNHLLHDHKIH JMGPEBMNFFJ()
		{
			return default(JNHLLHDHKIH);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private NativeList<int> BBJJGPDOCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private NativeList<int> PDDACNLKCAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private int IDNKKFDMNCC;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool JCLGOONBLNF
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x56901C0", Offset = "0x568E9C0", VA = "0x1856901C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public int JKGEEOBIBFN
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x5690300", Offset = "0x568EB00", VA = "0x185690300")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public int CPCMDNLGEPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x653E50", Offset = "0x652650", VA = "0x180653E50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public int OEOBCGFOLDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x653E50", Offset = "0x652650", VA = "0x180653E50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public EJEBMAOFHJD KDIKNGIHGKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x568F870", Offset = "0x568E070", VA = "0x18568F870")]
		get
		{
			return default(EJEBMAOFHJD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public JNHLLHDHKIH BGNHEMBAPOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x568EFD0", Offset = "0x568D7D0", VA = "0x18568EFD0")]
		get
		{
			return default(JNHLLHDHKIH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x5691B90", Offset = "0x5690390", VA = "0x185691B90")]
	public HICLOFGCMMI(int JMOOFNGCBCI, Allocator DDJPHGFEOFF = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x568FBC0", Offset = "0x568E3C0", VA = "0x18568FBC0")]
	public void KFAGLIPHBHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x45B0C40", Offset = "0x45AF440", VA = "0x1845B0C40")]
	public static int MADCAHEFGNI(int BKEAIPINHOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x568F7A0", Offset = "0x568DFA0", VA = "0x18568F7A0")]
	public static bool IADLLMEOMMC(int BKEAIPINHOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x568F7B0", Offset = "0x568DFB0", VA = "0x18568F7B0")]
	public static bool IBDCDFPAEOG(int BKEAIPINHOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x568FE80", Offset = "0x568E680", VA = "0x18568FE80")]
	public bool KNBGOMFNBCK(int AKLHCIJHJKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x568DA70", Offset = "0x568C270", VA = "0x18568DA70")]
	public bool AEONJEPFBCC(int AKLHCIJHJKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x56917E0", Offset = "0x568FFE0", VA = "0x1856917E0")]
	public bool PEKNHIPKOLL(Handle LPPHLKEKIOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x5690B60", Offset = "0x568F360", VA = "0x185690B60")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void NNOFMABIMMN(Handle LPPHLKEKIOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x568D7B0", Offset = "0x568BFB0", VA = "0x18568D7B0")]
	public Handle ABMKGCMGDIJ()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x568E270", Offset = "0x568CA70", VA = "0x18568E270")]
	public void DKILDAPODGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x56900D0", Offset = "0x568E8D0", VA = "0x1856900D0")]
	public void LBOALIBIFAA(Handle LPPHLKEKIOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x568DF10", Offset = "0x568C710", VA = "0x18568DF10")]
	public bool BICCFCPDMPG(Handle LPPHLKEKIOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x568F140", Offset = "0x568D940", VA = "0x18568F140")]
	private bool GKDGFBGFFEK(int AKLHCIJHJKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x568F3B0", Offset = "0x568DBB0", VA = "0x18568F3B0")]
	private void GLHNKIOIPMM(out int AKLHCIJHJKB, out int KAGEGNEPBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x56913A0", Offset = "0x568FBA0", VA = "0x1856913A0")]
	private void OANFHFODNNJ(Handle LPPHLKEKIOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x56914F0", Offset = "0x568FCF0", VA = "0x1856914F0")]
	private void PDCHOEIMKEB(int AKLHCIJHJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x5690460", Offset = "0x568EC60", VA = "0x185690460")]
	private bool NMGMPAOKPBE(out int AKLHCIJHJKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x568E0F0", Offset = "0x568C8F0", VA = "0x18568E0F0")]
	private static Handle DILHIIGJFID(int AKLHCIJHJKB, int KAGEGNEPBEI)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[DefaultMember("Item")]
public struct JPGJBKNMCEO<Handle, T> where Handle : ECOGJIGKDHI, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private global::HICLOFGCMMI<Handle> KIGPBDGJPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private T[] MLPFLGFOFNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private Action<T> PFJLBPMKLIN;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public bool JCLGOONBLNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x518B720", Offset = "0x5189F20", VA = "0x18518B720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public int JKGEEOBIBFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x518C060", Offset = "0x518A860", VA = "0x18518C060")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public int KKHILPEBPDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x518C160", Offset = "0x518A960", VA = "0x18518C160")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public T NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x518A8E0", Offset = "0x51890E0", VA = "0x18518A8E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x518E0F0", Offset = "0x518C8F0", VA = "0x18518E0F0")]
	public JPGJBKNMCEO(int JMOOFNGCBCI, [Optional] Action<T> PFJLBPMKLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x518B3E0", Offset = "0x5189BE0", VA = "0x18518B3E0")]
	public void KFAGLIPHBHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x518DD50", Offset = "0x518C550", VA = "0x18518DD50")]
	public bool PEKNHIPKOLL(Handle LPPHLKEKIOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	public void NNOFMABIMMN(Handle LPPHLKEKIOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x518D500", Offset = "0x518BD00", VA = "0x18518D500")]
	public T NOBGIOELFLB(Handle LPPHLKEKIOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x518A990", Offset = "0x5189190", VA = "0x18518A990")]
	public bool APHJBAJPDLG(Handle LPPHLKEKIOC, out T DEGGOOGCHFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x518AE70", Offset = "0x5189670", VA = "0x18518AE70")]
	public void HEMBJNPDPPJ(Handle LPPHLKEKIOC, T KOGDCLLODOD, out T BKFAAAAIDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x518AD50", Offset = "0x5189550", VA = "0x18518AD50")]
	public void HEMBJNPDPPJ(Handle LPPHLKEKIOC, T KOGDCLLODOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x518DBC0", Offset = "0x518C3C0", VA = "0x18518DBC0")]
	public bool OOADHAOIIHO(Handle LPPHLKEKIOC, T KOGDCLLODOD, out T BKFAAAAIDKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x518D540", Offset = "0x518BD40", VA = "0x18518D540")]
	public bool OOADHAOIIHO(Handle LPPHLKEKIOC, T KOGDCLLODOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x518D380", Offset = "0x518BB80", VA = "0x18518D380")]
	public Handle NLKJJINIDJF(T DEGGOOGCHFA)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x518BC00", Offset = "0x518A400", VA = "0x18518BC00")]
	public void LLAJDDJPKOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x518CA30", Offset = "0x518B230", VA = "0x18518CA30")]
	public void NHIAFFMKOAF(Handle LPPHLKEKIOC, out T BKFAAAAIDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x518CB10", Offset = "0x518B310", VA = "0x18518CB10")]
	public void NHIAFFMKOAF(Handle LPPHLKEKIOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x518C600", Offset = "0x518AE00", VA = "0x18518C600")]
	public bool MKMGEALKDOC(Handle LPPHLKEKIOC, out T BKFAAAAIDKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x518C190", Offset = "0x518A990", VA = "0x18518C190")]
	public bool MKMGEALKDOC(Handle LPPHLKEKIOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x518C900", Offset = "0x518B100", VA = "0x18518C900")]
	private T NGEIKIGMGGE(int AKLHCIJHJKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x518AFE0", Offset = "0x51897E0", VA = "0x18518AFE0")]
	private void IOHKIBCLCNA(int GOOFOFMKFBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class LFLENPAOPHG<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly Stack<T> LEMOBIBGKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly List<T> OAGIFCPHDCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly int CAOMGMEBNBF;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public int LDKELOHDGJH
	{
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x4F99100", Offset = "0x4F97900", VA = "0x184F99100")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int AIFCCBFJLBB
	{
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x25474E0", Offset = "0x2545CE0", VA = "0x1825474E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x5585120", Offset = "0x5583920", VA = "0x185585120")]
	public static global::LFLENPAOPHG<T> FKAJMHFHCLM(int JPMPKCEDKPJ = 0, int CAOMGMEBNBF = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x5585320", Offset = "0x5583B20", VA = "0x185585320")]
	public static global::LFLENPAOPHG<T> KIAFCEACIKB(int JPMPKCEDKPJ = 0, int CAOMGMEBNBF = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x5585620", Offset = "0x5583E20", VA = "0x185585620")]
	public LFLENPAOPHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x5585660", Offset = "0x5583E60", VA = "0x185585660")]
	public LFLENPAOPHG(int JPMPKCEDKPJ, int CAOMGMEBNBF = int.MaxValue, bool PNHMANLHKFO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x55851F0", Offset = "0x55839F0", VA = "0x1855851F0")]
	public T IAFOJPBAIIN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x5585560", Offset = "0x5583D60", VA = "0x185585560")]
	public void OIFOPNNBDMP(T CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x55854A0", Offset = "0x5583CA0", VA = "0x1855854A0")]
	private void NOOCMBBNNHJ(T CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x5585100", Offset = "0x5583900", VA = "0x185585100")]
	private void EGNDABIADFF(T CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x5584D90", Offset = "0x5583590", VA = "0x185584D90")]
	[Conditional("DEBUG_BUILD")]
	private void CIONKEKBLAN(T CENEMJHOLAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x55853F0", Offset = "0x5583BF0", VA = "0x1855853F0")]
	[Conditional("DEBUG_BUILD")]
	private void NCJKLDNHDGJ(T CENEMJHOLAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x5584FF0", Offset = "0x55837F0", VA = "0x185584FF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x5584E30", Offset = "0x5583630", VA = "0x185584E30")]
	private void DLIFDGKKAMG(IEnumerable<T> MLKKKEDBGKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class JGDIGCLCHJO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private Dictionary<int, T> GELILFJCNMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private T NLOJLLPKMID;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public virtual T HBLLEIONEEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x643F60", Offset = "0x642760", VA = "0x180643F60", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool HJCLHDLOCDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x5371280", Offset = "0x536FA80", VA = "0x185371280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x5371320", Offset = "0x536FB20", VA = "0x185371320")]
	public bool HDHHHNOANJM(T CJMMBFLIBMO, int BMGHFFAGJHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x53718B0", Offset = "0x53700B0", VA = "0x1853718B0")]
	public bool OCGOEKCFMJN(int BMGHFFAGJHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x53713E0", Offset = "0x536FBE0", VA = "0x1853713E0")]
	public T LNMPNPNANBD(int GIMOJONNGHJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x5371380", Offset = "0x536FB80", VA = "0x185371380")]
	public void IDPJIGKEBOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x53711F0", Offset = "0x536F9F0", VA = "0x1853711F0")]
	private bool ALBMPMIJINA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x5371910", Offset = "0x5370110", VA = "0x185371910")]
	public bool PJOHNGKNBEM(int BMGHFFAGJHI, out T CJMMBFLIBMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x5371940", Offset = "0x5370140", VA = "0x185371940")]
	public JGDIGCLCHJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class KEPDKLMBLKD<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	protected struct HGCFPMOPJAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public T EJFMLMNCFJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public int GJLGJNGLMHL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	protected readonly List<HGCFPMOPJAO> CMBMOFEOOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private T AAPHGMKLJHA;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public int KKHILPEBPDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0xE2A530", Offset = "0xE28D30", VA = "0x180E2A530")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x5191B40", Offset = "0x5190340", VA = "0x185191B40")]
	public bool JNEGJNMGLPF(T CJMMBFLIBMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x5191EB0", Offset = "0x51906B0", VA = "0x185191EB0")]
	public void NLKJJINIDJF(T CJMMBFLIBMO, int BMGHFFAGJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x5191D90", Offset = "0x5190590", VA = "0x185191D90")]
	public bool NHIAFFMKOAF(T CJMMBFLIBMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x5191AE0", Offset = "0x51902E0", VA = "0x185191AE0")]
	public void IDPJIGKEBOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x5191F50", Offset = "0x5190750", VA = "0x185191F50")]
	public T PDOMBMLGLML()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x5191A70", Offset = "0x5190270", VA = "0x185191A70")]
	public T GGOAIGKHAON()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x5191860", Offset = "0x5190060", VA = "0x185191860")]
	private void GAPBKNLNPCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x5191FE0", Offset = "0x51907E0", VA = "0x185191FE0")]
	public KEPDKLMBLKD()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		[AFEANLAOHEH(BOGMEFLEKOL.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x600047C")]
			[Cpp2IlInjected.Address(RVA = "0x4066BE0", Offset = "0x40653E0", VA = "0x184066BE0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600047D")]
			[Cpp2IlInjected.Address(RVA = "0x40670B0", Offset = "0x40658B0", VA = "0x1840670B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x600047E")]
			[Cpp2IlInjected.Address(RVA = "0x4066ED0", Offset = "0x40656D0", VA = "0x184066ED0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600047F")]
			[Cpp2IlInjected.Address(RVA = "0x4067250", Offset = "0x4065A50", VA = "0x184067250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x6000480")]
			[Cpp2IlInjected.Address(RVA = "0x4066AA0", Offset = "0x40652A0", VA = "0x184066AA0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000481")]
			[Cpp2IlInjected.Address(RVA = "0x4066F70", Offset = "0x4065770", VA = "0x184066F70")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000482")]
			[Cpp2IlInjected.Address(RVA = "0x4066D90", Offset = "0x4065590", VA = "0x184066D90")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x4066A00", Offset = "0x4065200", VA = "0x184066A00")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public interface JECBAIPIMJN
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	public abstract class ResourcePrefabReference<T> : JECBAIPIMJN where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x542F100", Offset = "0x542D900", VA = "0x18542F100", Slot = "4")]
		public virtual T FBIELHDMKIK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69000", VA = "0x180B6A800")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public class LFJKIDOMEAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly Dictionary<byte, NHMOIGNEPMI> BMKJIHICOIH;

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public NHMOIGNEPMI AOCEEBNDOAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x5FD1C0", Offset = "0x5FB9C0", VA = "0x1805FD1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x5F6790", Offset = "0x5F4F90", VA = "0x1805F6790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public Vector2 LHABDHNAMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x605310", Offset = "0x603B10", VA = "0x180605310")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x25C46C0", Offset = "0x25C2EC0", VA = "0x1825C46C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public Vector2 FOLKABEADKA
	{
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0xA59CE0", Offset = "0xA584E0", VA = "0x180A59CE0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0xAD3F30", Offset = "0xAD2730", VA = "0x180AD3F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public Vector2 NCHBBNELJJN
	{
		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x4063480", Offset = "0x4061C80", VA = "0x184063480")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x4063240", Offset = "0x4061A40", VA = "0x184063240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public int OPJGEIMGFBG
	{
		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x628F90", Offset = "0x627790", VA = "0x180628F90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x628C90", Offset = "0x627490", VA = "0x180628C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x40634A0", Offset = "0x4061CA0", VA = "0x1840634A0")]
	public LFJKIDOMEAE(Bounds CCJEIAEEBNF, Vector2[] IIIJKPGNBEI, int OCAJAHBMCKJ, byte DABGAKHOBBF, float OKKFFEBOAMK = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x4062CA0", Offset = "0x40614A0", VA = "0x184062CA0")]
	public NHMOIGNEPMI AHLKJNIHNAN(byte AKLHCIJHJKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x4063260", Offset = "0x4061A60", VA = "0x184063260")]
	public void KFFFKCIJHHD(Vector3 BAFCICKIIDG, float MMLBLKGJJDL, float CBFEOPEPHAE, ref List<byte> OKCECHCEGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x4063220", Offset = "0x4061A20", VA = "0x184063220")]
	public void FGFMAMABAAM(NHMOIGNEPMI.PKPHBFJLBJF IIIOLHFJOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x4063350", Offset = "0x4061B50", VA = "0x184063350")]
	private NHMOIGNEPMI NMPCNFOKELJ(byte AKLHCIJHJKB, NHMOIGNEPMI.GIACDBLPFBM CDJFGCCMLJH, NHMOIGNEPMI CELKNCFBAOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x4062D00", Offset = "0x4061500", VA = "0x184062D00")]
	private void DOPPJPDPEAI(NHMOIGNEPMI CELKNCFBAOE, Vector2[] IIIJKPGNBEI, int NEOHCNGFANF, int ABDIGPLJCEB, int MNKNIIPAMJL, int JHFKOLGDOBJ, float OKKFFEBOAMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public class NHMOIGNEPMI
{
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public enum GIACDBLPFBM
	{
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	public enum PKPHBFJLBJF
	{
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public byte ECMPPMHPHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public Vector3 KDIDBDDGDIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public Vector3 JKPGEJFPGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public Vector3 LPLFPKCMDKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public Vector3 AIIOPOEPGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public GIACDBLPFBM FLOLLDNBCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public NHMOIGNEPMI OLJDFKOJMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public List<NHMOIGNEPMI> DLMDOEOBGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public bool KEFBNFEAFGD;

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x4065140", Offset = "0x4063940", VA = "0x184065140")]
	public NHMOIGNEPMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x40650E0", Offset = "0x40638E0", VA = "0x1840650E0")]
	public NHMOIGNEPMI(byte OCNCOBFEOBE, GIACDBLPFBM CDJFGCCMLJH, NHMOIGNEPMI CELKNCFBAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x4065040", Offset = "0x4063840", VA = "0x184065040")]
	public void MJKBAJJOIOF(NHMOIGNEPMI CPANDONOICF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
	public void FGFMAMABAAM(int HLPAOKMHGDE, PKPHBFJLBJF IIIOLHFJOKF, int OHFNKEKFFNP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x4064DB0", Offset = "0x40635B0", VA = "0x184064DB0")]
	public void KFFFKCIJHHD(List<byte> OKCECHCEGJD, Vector3 BAFCICKIIDG, float MMLBLKGJJDL, float CBFEOPEPHAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x4064D50", Offset = "0x4063550", VA = "0x184064D50")]
	public bool HGJHJHGKCCN(Vector3 DLEJHBBJLMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x4064D10", Offset = "0x4063510", VA = "0x184064D10")]
	public bool BPODCJEBPFI(Vector3 DLEJHBBJLMH, float HADIACAPCIJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public class ELJBHFPNKAE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private readonly Dictionary<T, object> NMBBPMGMBFP;

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x3402210", Offset = "0x3400A10", VA = "0x183402210")]
	public bool HLPIDJOOMFE(T JGJBELNHINP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x5671AC0", Offset = "0x56702C0", VA = "0x185671AC0")]
	public bool HLPIDJOOMFE(T JGJBELNHINP, object HMOHICKINOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x5671A60", Offset = "0x5670260", VA = "0x185671A60")]
	public bool HLPIDJOOMFE(T JGJBELNHINP, object HMOHICKINOJ, out object BGMKIDEBMLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x5671990", Offset = "0x5670190", VA = "0x185671990")]
	public bool CGMDMHPDOGN(T JGJBELNHINP, object HMOHICKINOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x5671B00", Offset = "0x5670300", VA = "0x185671B00")]
	public bool LKEHBNBAEEP(T JGJBELNHINP, object HMOHICKINOJ, out object BGMKIDEBMLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x56719D0", Offset = "0x56701D0", VA = "0x1856719D0")]
	public bool CGMDMHPDOGN(T JGJBELNHINP, object HMOHICKINOJ, out object BGMKIDEBMLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0xE2A440", Offset = "0xE28C40", VA = "0x180E2A440")]
	public void FPJOFCJIDPF(T JGJBELNHINP, object HMOHICKINOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x56718F0", Offset = "0x56700F0", VA = "0x1856718F0")]
	public void CFDEDFJNMIK(T JGJBELNHINP, object HMOHICKINOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x5671B40", Offset = "0x5670340", VA = "0x185671B40")]
	public ELJBHFPNKAE()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x20000DD")]
		public struct KLGBKMDMECD<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			private readonly List<Component> BAKFHBILFME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			private readonly bool DMNGGBPMAJI;

			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0xECDA40", Offset = "0xECC240", VA = "0x180ECDA40")]
			public KLGBKMDMECD(List<Component> BAKFHBILFME, bool DMNGGBPMAJI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0x5422B60", Offset = "0x5421360", VA = "0x185422B60")]
			public AJOLDLDCNPD<T> JMGPEBMNFFJ()
			{
				return default(AJOLDLDCNPD<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0x5422BD0", Offset = "0x54213D0", VA = "0x185422BD0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(RVA = "0x5422BD0", Offset = "0x54213D0", VA = "0x185422BD0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000DE")]
		public struct AJOLDLDCNPD<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			private readonly List<Component> BAKFHBILFME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			private readonly bool DMNGGBPMAJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			private int AKLHCIJHJKB;

			[Cpp2IlInjected.Token(Token = "0x170000D4")]
			public T HLHDNNKPFLO
			{
				[Cpp2IlInjected.Token(Token = "0x60004BB")]
				[Cpp2IlInjected.Address(RVA = "0x541DCD0", Offset = "0x541C4D0", VA = "0x18541DCD0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D5")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60004BC")]
				[Cpp2IlInjected.Address(RVA = "0x541DC60", Offset = "0x541C460", VA = "0x18541DC60", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0x541DCA0", Offset = "0x541C4A0", VA = "0x18541DCA0")]
			public AJOLDLDCNPD(List<Component> BAKFHBILFME, bool DMNGGBPMAJI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0x541DBA0", Offset = "0x541C3A0", VA = "0x18541DBA0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(RVA = "0x541DBB0", Offset = "0x541C3B0", VA = "0x18541DBB0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0x2FBAAF0", Offset = "0x2FB92F0", VA = "0x182FBAAF0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60004A6")]
			[Cpp2IlInjected.Address(RVA = "0x4068F10", Offset = "0x4067710", VA = "0x184068F10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x4068ED0", Offset = "0x40676D0", VA = "0x184068ED0")]
		public ToolHierarchyCache(GameObject GHKIFELJLOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x4068BF0", Offset = "0x40673F0", VA = "0x184068BF0")]
		private void LGHMODLDJCJ(GameObject GHKIFELJLOB, bool PDHIMENFOOC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x4068D10", Offset = "0x4067510", VA = "0x184068D10")]
		public static void LGHMODLDJCJ(GameObject GHKIFELJLOB, ref ToolHierarchyCache ABKIIIEHBJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x4068DA0", Offset = "0x40675A0", VA = "0x184068DA0")]
		public void LOBOPEFDCIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x4068B10", Offset = "0x4067310", VA = "0x184068B10")]
		public void IFJLKKKJODB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x500C540", Offset = "0x500AD40", VA = "0x18500C540")]
		public void MKNJHIDHGOJ<T>(Action<T> MJHIGMCCOPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x4068A50", Offset = "0x4067250", VA = "0x184068A50")]
		public Component HAPOCLPLCPD(Type BKDBLJPNPPJ, bool DMNGGBPMAJI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0xA8F9A0", Offset = "0xA8E1A0", VA = "0x180A8F9A0")]
		public T HAPOCLPLCPD<T>(bool DMNGGBPMAJI = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x4068B60", Offset = "0x4067360", VA = "0x184068B60")]
		public KLGBKMDMECD<Component> IPPHHMPNKMB(Type BKDBLJPNPPJ, bool DMNGGBPMAJI = false)
		{
			return default(KLGBKMDMECD<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0xDAFD30", Offset = "0xDAE530", VA = "0x180DAFD30")]
		public KLGBKMDMECD<T> IPPHHMPNKMB<T>(bool DMNGGBPMAJI = false) where T : class
		{
			return default(KLGBKMDMECD<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x4068730", Offset = "0x4066F30", VA = "0x184068730")]
		public List<Component> GAFCJHFCGPE(Type BKDBLJPNPPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x40686B0", Offset = "0x4066EB0", VA = "0x1840686B0", Slot = "4")]
		public bool Equals(ToolHierarchyCache FGCAOGJDCFC, ToolHierarchyCache JGCHHJHFEGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x40689E0", Offset = "0x40671E0", VA = "0x1840689E0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache DEGGOOGCHFA)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public class BEOOOEEBLMA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private int JPMPKCEDKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private int CFIMMNGANNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private List<T> HPGJMGNMMCF;

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public int KKHILPEBPDN
	{
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x4F99100", Offset = "0x4F97900", VA = "0x184F99100")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public T BDDFGPIEACK
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x5409B40", Offset = "0x5408340", VA = "0x185409B40")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public T BLBLMCFIPFM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x54096B0", Offset = "0x5407EB0", VA = "0x1854096B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public T PKHHKADAOIK
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x54096F0", Offset = "0x5407EF0", VA = "0x1854096F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x5409BC0", Offset = "0x54083C0", VA = "0x185409BC0")]
	public BEOOOEEBLMA(int JPMPKCEDKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x54098F0", Offset = "0x54080F0", VA = "0x1854098F0")]
	public void NLKJJINIDJF(T INPMLDAEHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x54098B0", Offset = "0x54080B0", VA = "0x1854098B0")]
	public void IDPJIGKEBOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x54097B0", Offset = "0x5407FB0", VA = "0x1854097B0")]
	public void EJCLLKFOAEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x5409860", Offset = "0x5408060", VA = "0x185409860")]
	public void HBMNEKCPFGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x5409850", Offset = "0x5408050", VA = "0x185409850")]
	public void GCKCDCCNHOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public class CDDHAGIFHIA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private bool DNGFGIBPKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private Action MJHIGMCCOPA;

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public static CDDHAGIFHIA MDDPKFAKKEL
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x405FF80", Offset = "0x405E780", VA = "0x18405FF80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool NAEFKJMGHME
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x6358A0", Offset = "0x6340A0", VA = "0x1806358A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0xEF31B0", Offset = "0xEF19B0", VA = "0x180EF31B0")]
	public CDDHAGIFHIA(Action MJHIGMCCOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x405FF60", Offset = "0x405E760", VA = "0x18405FF60")]
	public void DOLHECDOMGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x405FF60", Offset = "0x405E760", VA = "0x18405FF60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public static class KMIJKEIHKNF
{
	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
	public static void OPHHEGADCAG(BEGDNEKLHBE FNBJDMBIOKK, string MNCJGBGNCFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public class LHBHDKCNGPK<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	private struct KDFLBCDLCDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public int GJLGJNGLMHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public T EJFMLMNCFJG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private readonly Dictionary<object, KDFLBCDLCDF> GELILFJCNMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private T NLOJLLPKMID;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public virtual T HBLLEIONEEP
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x605310", Offset = "0x603B10", VA = "0x180605310", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x25C46C0", Offset = "0x25C2EC0", VA = "0x1825C46C0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public bool HJCLHDLOCDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x54747C0", Offset = "0x5472FC0", VA = "0x1854747C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public object NPMFOOFBFJL
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x6186B0", Offset = "0x616EB0", VA = "0x1806186B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x639660", Offset = "0x637E60", VA = "0x180639660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x5474FB0", Offset = "0x54737B0", VA = "0x185474FB0")]
	public bool HDHHHNOANJM(T CJMMBFLIBMO, object HMOHICKINOJ, int BMGHFFAGJHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x54750B0", Offset = "0x54738B0", VA = "0x1854750B0")]
	public bool OCGOEKCFMJN(object HMOHICKINOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x54751F0", Offset = "0x54739F0", VA = "0x1854751F0")]
	public bool PJOHNGKNBEM(object HMOHICKINOJ, out T CJMMBFLIBMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x254A050", Offset = "0x2548850", VA = "0x18254A050")]
	public void IDPJIGKEBOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x54719F0", Offset = "0x54701F0", VA = "0x1854719F0")]
	private bool ALBMPMIJINA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x5371940", Offset = "0x5370140", VA = "0x185371940")]
	public LHBHDKCNGPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public class LOCBKIMANPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private Dictionary<object, float> GELILFJCNMC;

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public float OCBOFNDCEJI
	{
		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x718FB0", Offset = "0x7177B0", VA = "0x180718FB0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x718FC0", Offset = "0x7177C0", VA = "0x180718FC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x40648F0", Offset = "0x40630F0", VA = "0x1840648F0")]
	public void HDHHHNOANJM(float CJMMBFLIBMO, object HMOHICKINOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x4064960", Offset = "0x4063160", VA = "0x184064960")]
	public void OCGOEKCFMJN(object HMOHICKINOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x40647D0", Offset = "0x4062FD0", VA = "0x1840647D0")]
	private void DKIPNMCBPBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x40649D0", Offset = "0x40631D0", VA = "0x1840649D0")]
	public LOCBKIMANPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public class MBHEGBJDEAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public readonly string DODGBGMGHLE;

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x60E9F0", Offset = "0x60D1F0", VA = "0x18060E9F0")]
	public MBHEGBJDEAH(string KJEMDEKDGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x4064AA0", Offset = "0x40632A0", VA = "0x184064AA0")]
	public MBHEGBJDEAH(UnityEngine.Object HMMPGMMJHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x4064A50", Offset = "0x4063250", VA = "0x184064A50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public sealed class BEGDNEKLHBE
{
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private sealed class LBAKKPLLNBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public LBAKKPLLNBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x4062BF0", Offset = "0x40613F0", VA = "0x184062BF0")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private HashSet<object> ODEGDGKNMEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private int ECAENEBDBDM;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public IReadOnlyCollection<object> LIKHIIFCKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x405F910", Offset = "0x405E110", VA = "0x18405F910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public bool BIGPDJPEMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x405FAA0", Offset = "0x405E2A0", VA = "0x18405FAA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public int KKHILPEBPDN
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x6EFB50", Offset = "0x6EE350", VA = "0x1806EFB50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x405FB40", Offset = "0x405E340", VA = "0x18405FB40")]
	public bool NLKJJINIDJF(object HMOHICKINOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x405FAB0", Offset = "0x405E2B0", VA = "0x18405FAB0")]
	public bool NHIAFFMKOAF(object HMOHICKINOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x405F9E0", Offset = "0x405E1E0", VA = "0x18405F9E0")]
	public bool JNEGJNMGLPF(object HMOHICKINOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x405FA40", Offset = "0x405E240", VA = "0x18405FA40")]
	public void MONCAFAALLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x405FC00", Offset = "0x405E400", VA = "0x18405FC00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public BEGDNEKLHBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public class NNMNEIACFFL<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	private struct KAFKENFLAPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public float KGKIMJCCAAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public T EJFMLMNCFJG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private Dictionary<object, KAFKENFLAPF> GELILFJCNMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private T PBADOAJFLNG;

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public virtual T ONBCFKGGHBG
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0xECAF20", Offset = "0xEC9720", VA = "0x180ECAF20", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x4A68020", Offset = "0x4A66820", VA = "0x184A68020", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public object OJCLDKKNLGG
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x6186B0", Offset = "0x616EB0", VA = "0x1806186B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x671B60", Offset = "0x670360", VA = "0x180671B60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public bool HJCLHDLOCDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x54D0750", Offset = "0x54CEF50", VA = "0x1854D0750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x54D0B90", Offset = "0x54CF390", VA = "0x1854D0B90")]
	public bool HDHHHNOANJM(T CJMMBFLIBMO, object HMOHICKINOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x54D0D60", Offset = "0x54CF560", VA = "0x1854D0D60")]
	public bool OCGOEKCFMJN(object HMOHICKINOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x254A050", Offset = "0x2548850", VA = "0x18254A050")]
	public void IDPJIGKEBOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x54D0E20", Offset = "0x54CF620", VA = "0x1854D0E20")]
	public bool PJOHNGKNBEM(object HMOHICKINOJ, out T CJMMBFLIBMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x54CF270", Offset = "0x54CDA70", VA = "0x1854CF270")]
	private bool ALBMPMIJINA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x54D1040", Offset = "0x54CF840", VA = "0x1854D1040")]
	public NNMNEIACFFL()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public class PGKFNNKCMAN
{
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private static byte[] EGKMOPGLIPA;

	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private static int JGABFFAEPHC;

	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private static int OCNADIFHHML;

	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private static BigInteger GACCCDCMEHO;

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public PGKFNNKCMAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x4066410", Offset = "0x4064C10", VA = "0x184066410")]
	private static string HDJAHDEMDDI(byte[] FLEBMPFFCAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x4066510", Offset = "0x4064D10", VA = "0x184066510")]
	public static string OMJPKAOBENG(byte[] FCDIIMLAMIO, bool PCFPPGPONLG)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x20000EC")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
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
