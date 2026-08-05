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
public class NJMIDFDOJJD : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0")]
	public NJMIDFDOJJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, KJKEKCCLIHO, BICPEEPHPEF, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6A4ED0", Offset = "0x6A38D0", VA = "0x1806A4ED0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x697FE0", Offset = "0x6969E0", VA = "0x180697FE0", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F00", Offset = "0x6A3900", VA = "0x1806A4F00", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x69E450", Offset = "0x69CE50", VA = "0x18069E450", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash FHKNDMKDLNF);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x752960", Offset = "0x751360", VA = "0x180752960")]
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
	[FGKIFCJEPII]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[FGKIFCJEPII]
	[SerializeField]
	[HideInInspector]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5E587C0", Offset = "0x5E571C0", VA = "0x185E587C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5E58780", Offset = "0x5E57180", VA = "0x185E58780")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5E58800", Offset = "0x5E57200", VA = "0x185E58800")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5E589D0", Offset = "0x5E573D0", VA = "0x185E589D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5E58940", Offset = "0x5E57340", VA = "0x185E58940")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6A5120", Offset = "0x6A3B20", VA = "0x1806A5120")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x746D00", Offset = "0x745700", VA = "0x180746D00")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5E58740", Offset = "0x5E57140", VA = "0x185E58740")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5E588B0", Offset = "0x5E572B0", VA = "0x185E588B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5E58240", Offset = "0x5E56C40", VA = "0x185E58240")]
	public void CopyBounds(SavedExtents BPKBHFMGOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5E586A0", Offset = "0x5E570A0", VA = "0x185E586A0")]
	public void SetLocalSpaceBounds(Bounds MGBINPKMHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7A1380", Offset = "0x79FD80", VA = "0x1807A1380")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5E58690", Offset = "0x5E57090", VA = "0x185E58690")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5E58270", Offset = "0x5E56C70", VA = "0x185E58270")]
	private void KIPMFPBOPEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5E58460", Offset = "0x5E56E60", VA = "0x185E58460")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5E57C00", Offset = "0x5E56600", VA = "0x185E57C00")]
	public static void CalculateLocalBoundsFor(GameObject OOAFGPFKNDK, out Bounds MGBINPKMHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5E57B40", Offset = "0x5E56540", VA = "0x185E57B40")]
	private static void ANPEKKCPBPL(Bounds KCHCODPDAGF, Color DANKALDMBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5E586C0", Offset = "0x5E570C0", VA = "0x185E586C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6983B0", Offset = "0x696DB0", VA = "0x1806983B0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7EA9B0", Offset = "0x7E93B0", VA = "0x1807EA9B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x87D690", Offset = "0x87C090", VA = "0x18087D690")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1431070", Offset = "0x142FA70", VA = "0x181431070")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "4")]
	public virtual void BOBLHGHBJEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7D07F0", Offset = "0x7CF1F0", VA = "0x1807D07F0")]
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
	[NJMIDFDOJJD]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2B92F60", Offset = "0x2B91960", VA = "0x182B92F60", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2B92690", Offset = "0x2B91090", VA = "0x182B92690", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2B934A0", Offset = "0x2B91EA0", VA = "0x182B934A0")]
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
	private sealed class BKMGFENHINM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7D07F0", Offset = "0x7CF1F0", VA = "0x1807D07F0")]
		public BKMGFENHINM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x30FF6B0", Offset = "0x30FE0B0", VA = "0x1830FF6B0")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	[NJMIDFDOJJD]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EB0", Offset = "0x6A38B0", VA = "0x1806A4EB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7CF5F0", Offset = "0x7CDFF0", VA = "0x1807CF5F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7CF620", Offset = "0x7CE020", VA = "0x1807CF620", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7CF540", Offset = "0x7CDF40", VA = "0x1807CF540", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public TVal this[TKey KFEMFMGCJPM]
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7CF570", Offset = "0x7CDF70", VA = "0x1807CF570", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7CF440", Offset = "0x7CDE40", VA = "0x1807CF440", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7CEDC0", Offset = "0x7CD7C0", VA = "0x1807CEDC0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7CE490", Offset = "0x7CCE90", VA = "0x1807CE490", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7CE3A0", Offset = "0x7CCDA0", VA = "0x1807CE3A0", Slot = "14")]
	protected virtual string AILBHFDCLLC(TKeyVal HEPIPBLAHPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7CE3D0", Offset = "0x7CCDD0", VA = "0x1807CE3D0", Slot = "4")]
	public bool ContainsKey(TKey KFEMFMGCJPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7CF330", Offset = "0x7CDD30", VA = "0x1807CF330", Slot = "5")]
	public bool TryGetValue(TKey KFEMFMGCJPM, out TVal NKJMIDIDBOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7CE400", Offset = "0x7CCE00", VA = "0x1807CE400", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7CE400", Offset = "0x7CCE00", VA = "0x1807CE400", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7CF360", Offset = "0x7CDD60", VA = "0x1807CF360")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class NBHOKHOPPMB<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class KGEAFKNPHPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7D07F0", Offset = "0x7CF1F0", VA = "0x1807D07F0")]
		public KGEAFKNPHPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2419000", Offset = "0x2417A00", VA = "0x182419000")]
		internal bool <GetSamples>b__0(global::NMBFPKNIMFB<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float JAOGEHFAINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float NHJNKDEMIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<global::NMBFPKNIMFB<float, T>> OIFOOMLCKHA;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int ACDEACHBBIK
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1E7BB00", Offset = "0x1E7A500", VA = "0x181E7BB00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1E7BC60", Offset = "0x1E7A660", VA = "0x181E7BC60")]
	public NBHOKHOPPMB(float EAKMAHAFFOE, float GDCELAOKAAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1E7B0D0", Offset = "0x1E79AD0", VA = "0x181E7B0D0")]
	public bool AIOPICGAABB(float NCBNMINDEOC, T NKJMIDIDBOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1E7BC00", Offset = "0x1E7A600", VA = "0x181E7BC00")]
	public int OEJOJLONJIH(float NCBNMINDEOC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1E7B6D0", Offset = "0x1E7A0D0", VA = "0x181E7B6D0")]
	public IEnumerable<T> BPJBNGJDEMO(float NCBNMINDEOC, [Optional] float? AGKCCIEFGPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1E7BAD0", Offset = "0x1E7A4D0", VA = "0x181E7BAD0")]
	public void LCFMPIKHEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1E7BA10", Offset = "0x1E7A410", VA = "0x181E7BA10")]
	private void DMJKJPBKJNC(float NCBNMINDEOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class NIHEPECLDGC<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct LEKHOHIPBFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T EDONKBBONCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float IIGAOICKELB;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float APJDMPONKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> LMCJDMFNKOC;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int DIGHLCFMBAK = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private LEKHOHIPBFK[] EIOACKOCJCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int NLONPJMNADC;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float IFKCAPBCNKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x761090", Offset = "0x75FA90", VA = "0x180761090")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x816320", Offset = "0x814D20", VA = "0x180816320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1FDE1D0", Offset = "0x1FDCBD0", VA = "0x181FDE1D0")]
	public NIHEPECLDGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1FDE200", Offset = "0x1FDCC00", VA = "0x181FDE200")]
	public NIHEPECLDGC(int GCDOPBGGNDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1FDD180", Offset = "0x1FDBB80", VA = "0x181FDD180")]
	public void MJIKPLNABDE(float NCBNMINDEOC, T NKJMIDIDBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1FDCD90", Offset = "0x1FDB790", VA = "0x181FDCD90")]
	public void LCFMPIKHEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1FDDDA0", Offset = "0x1FDC7A0", VA = "0x181FDDDA0")]
	public bool POMGLGAHCHI(float LCDIPLFDPHH, float ICPCGDDIBIL, out T NKJMIDIDBOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1FDD400", Offset = "0x1FDBE00", VA = "0x181FDD400")]
	public bool NBCPFBIGKEK(float LCDIPLFDPHH, float ICPCGDDIBIL, out T NKJMIDIDBOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1FDD990", Offset = "0x1FDC390", VA = "0x181FDD990")]
	public void PGKDNFLINAM(float LCDIPLFDPHH, float ICPCGDDIBIL, List<T> MFPFCCDPGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1FDCD20", Offset = "0x1FDB720", VA = "0x181FDCD20")]
	private int DLIALOOCABN(int AALGHBLPMGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1FDCD50", Offset = "0x1FDB750", VA = "0x181FDCD50")]
	private void HNOGNJBHMGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T CEAIIJKKNFK();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T PGJAJCPDHPD(T KCFHGHIJEEN, T EIBGAMBEABJ, float IEEKPPIPNKF);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T PDAOFMFPEEJ(T NKJMIDIDBOE, float IEEKPPIPNKF);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T MMJKAOKJBGK(T KCFHGHIJEEN, T EIBGAMBEABJ);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T CHJAOBEIFEF(T KCFHGHIJEEN, T EIBGAMBEABJ);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class DJKHDLNNLJC : global::NIHEPECLDGC<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xABBDD0", Offset = "0xABA7D0", VA = "0x180ABBDD0", Slot = "4")]
	protected override Vector3 CEAIIJKKNFK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xC7EC90", Offset = "0xC7D690", VA = "0x180C7EC90", Slot = "5")]
	protected override Vector3 PGJAJCPDHPD(Vector3 KCFHGHIJEEN, Vector3 EIBGAMBEABJ, float IEEKPPIPNKF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5E50960", Offset = "0x5E4F360", VA = "0x185E50960", Slot = "6")]
	protected override Vector3 PDAOFMFPEEJ(Vector3 NKJMIDIDBOE, float IEEKPPIPNKF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5E508E0", Offset = "0x5E4F2E0", VA = "0x185E508E0", Slot = "7")]
	protected override Vector3 MMJKAOKJBGK(Vector3 KCFHGHIJEEN, Vector3 EIBGAMBEABJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5E50870", Offset = "0x5E4F270", VA = "0x185E50870", Slot = "8")]
	protected override Vector3 CHJAOBEIFEF(Vector3 KCFHGHIJEEN, Vector3 EIBGAMBEABJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5E509C0", Offset = "0x5E4F3C0", VA = "0x185E509C0")]
	public DJKHDLNNLJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class EMJPLPEPDPI : global::NIHEPECLDGC<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5E50A40", Offset = "0x5E4F440", VA = "0x185E50A40")]
	public EMJPLPEPDPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5E50AB0", Offset = "0x5E4F4B0", VA = "0x185E50AB0")]
	public EMJPLPEPDPI(int GCDOPBGGNDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7DD170", Offset = "0x7DBB70", VA = "0x1807DD170", Slot = "4")]
	protected override float CEAIIJKKNFK()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3011BD0", Offset = "0x30105D0", VA = "0x183011BD0", Slot = "5")]
	protected override float PGJAJCPDHPD(float KCFHGHIJEEN, float EIBGAMBEABJ, float IEEKPPIPNKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4DCA9F0", Offset = "0x4DC93F0", VA = "0x184DCA9F0", Slot = "6")]
	protected override float PDAOFMFPEEJ(float NKJMIDIDBOE, float IEEKPPIPNKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1D0AD50", Offset = "0x1D09750", VA = "0x181D0AD50", Slot = "7")]
	protected override float MMJKAOKJBGK(float KCFHGHIJEEN, float EIBGAMBEABJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5E50A30", Offset = "0x5E4F430", VA = "0x185E50A30", Slot = "8")]
	protected override float CHJAOBEIFEF(float KCFHGHIJEEN, float EIBGAMBEABJ)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class MACDOHJBJHI
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2156330", Offset = "0x2154D30", VA = "0x182156330")]
	public static global::IMDEAKGGJKP<T1> BJHKCBAGIGH<T1>(T1 DBMMGCBBODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2603B50", Offset = "0x2602550", VA = "0x182603B50")]
	public static global::NMBFPKNIMFB<T1, T2> BJHKCBAGIGH<T1, T2>(T1 DBMMGCBBODH, T2 JOGGMBJFBMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2603BC0", Offset = "0x26025C0", VA = "0x182603BC0")]
	public static global::GOILJPOEDNK<T1, T2, T3> BJHKCBAGIGH<T1, T2, T3>(T1 DBMMGCBBODH, T2 JOGGMBJFBMF, T3 DDFHEPDNKGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1D6BE90", Offset = "0x1D6A890", VA = "0x181D6BE90")]
	public static global::AGLCNOCMIOL<T1, T2, T3, T4> BJHKCBAGIGH<T1, T2, T3, T4>(T1 DBMMGCBBODH, T2 JOGGMBJFBMF, T3 DDFHEPDNKGH, T4 AKHINBLICOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2603E90", Offset = "0x2602890", VA = "0x182603E90")]
	public static global::JDJKLKMKKCP<T1, T2, T3, T4, T5> BJHKCBAGIGH<T1, T2, T3, T4, T5>(T1 DBMMGCBBODH, T2 JOGGMBJFBMF, T3 DDFHEPDNKGH, T4 AKHINBLICOA, T5 CNIKHCBEMNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2603DE0", Offset = "0x26027E0", VA = "0x182603DE0")]
	public static global::HALMILAOCKD<T1, T2, T3, T4, T5, T6> BJHKCBAGIGH<T1, T2, T3, T4, T5, T6>(T1 DBMMGCBBODH, T2 JOGGMBJFBMF, T3 DDFHEPDNKGH, T4 AKHINBLICOA, T5 CNIKHCBEMNE, T6 JPCNDFGJJLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2603D20", Offset = "0x2602720", VA = "0x182603D20")]
	public static global::JBHMBKKPAAC<T1, T2, T3, T4, T5, T6, T7> BJHKCBAGIGH<T1, T2, T3, T4, T5, T6, T7>(T1 DBMMGCBBODH, T2 JOGGMBJFBMF, T3 DDFHEPDNKGH, T4 AKHINBLICOA, T5 CNIKHCBEMNE, T6 JPCNDFGJJLE, T7 KKONLOBLINI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2603C50", Offset = "0x2602650", VA = "0x182603C50")]
	public static global::FNADOEIJHDI<T1, T2, T3, T4, T5, T6, T7, T8> BJHKCBAGIGH<T1, T2, T3, T4, T5, T6, T7, T8>(T1 DBMMGCBBODH, T2 JOGGMBJFBMF, T3 DDFHEPDNKGH, T4 AKHINBLICOA, T5 CNIKHCBEMNE, T6 JPCNDFGJJLE, T7 KKONLOBLINI, T8 NOEGIEMCCIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x135BB50", Offset = "0x135A550", VA = "0x18135BB50")]
	[IteratorStateMachine(typeof(DELPBOAOPMJ))]
	public static IEnumerable<global::NMBFPKNIMFB<T1, T2>> KHAMHIBFILD<T1, T2>(IEnumerable<T1> LDIEPFCHCFG, IEnumerable<T2> KCHCODPDAGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x135BD30", Offset = "0x135A730", VA = "0x18135BD30")]
	[IteratorStateMachine(typeof(FANEKIPNKJI))]
	public static IEnumerable<global::GOILJPOEDNK<T1, T2, T3>> KHAMHIBFILD<T1, T2, T3>(IEnumerable<T1> LDIEPFCHCFG, IEnumerable<T2> KCHCODPDAGF, IEnumerable<T3> DANKALDMBIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1E5FF50", Offset = "0x1E5E950", VA = "0x181E5FF50")]
	internal static int CMIBAHHNNBF(int CHEHPKPJNHA, int DCADBCONACK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x388BE50", Offset = "0x388A850", VA = "0x18388BE50")]
	internal static int CMIBAHHNNBF(int CHEHPKPJNHA, int DCADBCONACK, int BICIBIMJMBI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x388BE30", Offset = "0x388A830", VA = "0x18388BE30")]
	internal static int CMIBAHHNNBF(int CHEHPKPJNHA, int DCADBCONACK, int BICIBIMJMBI, int GJNLNLOHEHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5E54F00", Offset = "0x5E53900", VA = "0x185E54F00")]
	internal static int CMIBAHHNNBF(int CHEHPKPJNHA, int DCADBCONACK, int BICIBIMJMBI, int GJNLNLOHEHB, int MODDFKBJIJC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5E54F50", Offset = "0x5E53950", VA = "0x185E54F50")]
	internal static int CMIBAHHNNBF(int CHEHPKPJNHA, int DCADBCONACK, int BICIBIMJMBI, int GJNLNLOHEHB, int MODDFKBJIJC, int MLCCCBEPHDL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5E54ED0", Offset = "0x5E538D0", VA = "0x185E54ED0")]
	internal static int CMIBAHHNNBF(int CHEHPKPJNHA, int DCADBCONACK, int BICIBIMJMBI, int GJNLNLOHEHB, int MODDFKBJIJC, int MLCCCBEPHDL, int BIMLNACFBAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5E54F20", Offset = "0x5E53920", VA = "0x185E54F20")]
	internal static int CMIBAHHNNBF(int CHEHPKPJNHA, int DCADBCONACK, int BICIBIMJMBI, int GJNLNLOHEHB, int MODDFKBJIJC, int MLCCCBEPHDL, int BIMLNACFBAH, int KIBDENEPENI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class IMDEAKGGJKP<T1> : IComparable<global::IMDEAKGGJKP<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T1 MNMOAKCMNFL;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1A58D90", Offset = "0x1A57790", VA = "0x181A58D90")]
	public IMDEAKGGJKP(T1 DBMMGCBBODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1A58BC0", Offset = "0x1A575C0", VA = "0x181A58BC0", Slot = "4")]
	public int CompareTo(global::IMDEAKGGJKP<T1> BPKBHFMGOOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1A58C30", Offset = "0x1A57630", VA = "0x181A58C30", Slot = "0")]
	public override bool Equals(object BPKBHFMGOOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x13FA2E0", Offset = "0x13F8CE0", VA = "0x1813FA2E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1A58CD0", Offset = "0x1A576D0", VA = "0x181A58CD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class NMBFPKNIMFB<T1, T2> : IComparable<global::NMBFPKNIMFB<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 MNMOAKCMNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 CDICPAENOIO;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x32D3A30", Offset = "0x32D2430", VA = "0x1832D3A30")]
	public NMBFPKNIMFB(T1 DBMMGCBBODH, T2 JOGGMBJFBMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x32D1B20", Offset = "0x32D0520", VA = "0x1832D1B20", Slot = "4")]
	public int CompareTo(global::NMBFPKNIMFB<T1, T2> BPKBHFMGOOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x32D24C0", Offset = "0x32D0EC0", VA = "0x1832D24C0", Slot = "0")]
	public override bool Equals(object BPKBHFMGOOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x32D2D10", Offset = "0x32D1710", VA = "0x1832D2D10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x32D3320", Offset = "0x32D1D20", VA = "0x1832D3320", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class GOILJPOEDNK<T1, T2, T3> : IComparable<global::GOILJPOEDNK<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T1 MNMOAKCMNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T2 CDICPAENOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T3 MNONKFKOFDC;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2B22460", Offset = "0x2B20E60", VA = "0x182B22460")]
	public GOILJPOEDNK(T1 DBMMGCBBODH, T2 JOGGMBJFBMF, T3 DDFHEPDNKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2B21D50", Offset = "0x2B20750", VA = "0x182B21D50", Slot = "4")]
	public int CompareTo(global::GOILJPOEDNK<T1, T2, T3> BPKBHFMGOOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2B21E50", Offset = "0x2B20850", VA = "0x182B21E50", Slot = "0")]
	public override bool Equals(object BPKBHFMGOOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2B220B0", Offset = "0x2B20AB0", VA = "0x182B220B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2B222B0", Offset = "0x2B20CB0", VA = "0x182B222B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class AGLCNOCMIOL<T1, T2, T3, T4> : IComparable<global::AGLCNOCMIOL<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T1 MNMOAKCMNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T2 CDICPAENOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T3 MNONKFKOFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T4 DBFAIJDALPO;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2023D00", Offset = "0x2022700", VA = "0x182023D00")]
	public AGLCNOCMIOL(T1 DBMMGCBBODH, T2 JOGGMBJFBMF, T3 DDFHEPDNKGH, T4 AKHINBLICOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x20238B0", Offset = "0x20222B0", VA = "0x1820238B0", Slot = "4")]
	public int CompareTo(global::AGLCNOCMIOL<T1, T2, T3, T4> BPKBHFMGOOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x20239F0", Offset = "0x20223F0", VA = "0x1820239F0", Slot = "0")]
	public override bool Equals(object BPKBHFMGOOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2023B10", Offset = "0x2022510", VA = "0x182023B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2023BD0", Offset = "0x20225D0", VA = "0x182023BD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class JDJKLKMKKCP<T1, T2, T3, T4, T5> : IComparable<global::JDJKLKMKKCP<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T1 MNMOAKCMNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T2 CDICPAENOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T3 MNONKFKOFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T4 DBFAIJDALPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T5 MJOLLJPEIEJ;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1C1A630", Offset = "0x1C19030", VA = "0x181C1A630")]
	public JDJKLKMKKCP(T1 DBMMGCBBODH, T2 JOGGMBJFBMF, T3 DDFHEPDNKGH, T4 AKHINBLICOA, T5 CNIKHCBEMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1C1A120", Offset = "0x1C18B20", VA = "0x181C1A120", Slot = "4")]
	public int CompareTo(global::JDJKLKMKKCP<T1, T2, T3, T4, T5> BPKBHFMGOOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1C1A2A0", Offset = "0x1C18CA0", VA = "0x181C1A2A0", Slot = "0")]
	public override bool Equals(object BPKBHFMGOOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1C1A3E0", Offset = "0x1C18DE0", VA = "0x181C1A3E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1C1A4E0", Offset = "0x1C18EE0", VA = "0x181C1A4E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class HALMILAOCKD<T1, T2, T3, T4, T5, T6> : IComparable<global::HALMILAOCKD<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T1 MNMOAKCMNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T2 CDICPAENOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T3 MNONKFKOFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T4 DBFAIJDALPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T5 MJOLLJPEIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T6 AMNLMAFDODK;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2668540", Offset = "0x2666F40", VA = "0x182668540")]
	public HALMILAOCKD(T1 DBMMGCBBODH, T2 JOGGMBJFBMF, T3 DDFHEPDNKGH, T4 AKHINBLICOA, T5 CNIKHCBEMNE, T6 JPCNDFGJJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2667F80", Offset = "0x2666980", VA = "0x182667F80", Slot = "4")]
	public int CompareTo(global::HALMILAOCKD<T1, T2, T3, T4, T5, T6> BPKBHFMGOOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2668140", Offset = "0x2666B40", VA = "0x182668140", Slot = "0")]
	public override bool Equals(object BPKBHFMGOOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x26682B0", Offset = "0x2666CB0", VA = "0x1826682B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x26683D0", Offset = "0x2666DD0", VA = "0x1826683D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class JBHMBKKPAAC<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::JBHMBKKPAAC<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T1 MNMOAKCMNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T2 CDICPAENOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T3 MNONKFKOFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T4 DBFAIJDALPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T5 MJOLLJPEIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T6 AMNLMAFDODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T7 AIDHHPOKGAL;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x1C12A30", Offset = "0x1C11430", VA = "0x181C12A30")]
	public JBHMBKKPAAC(T1 DBMMGCBBODH, T2 JOGGMBJFBMF, T3 DDFHEPDNKGH, T4 AKHINBLICOA, T5 CNIKHCBEMNE, T6 JPCNDFGJJLE, T7 KKONLOBLINI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x1C123B0", Offset = "0x1C10DB0", VA = "0x181C123B0", Slot = "4")]
	public int CompareTo(global::JBHMBKKPAAC<T1, T2, T3, T4, T5, T6, T7> BPKBHFMGOOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x1C125B0", Offset = "0x1C10FB0", VA = "0x181C125B0", Slot = "0")]
	public override bool Equals(object BPKBHFMGOOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x1C12750", Offset = "0x1C11150", VA = "0x181C12750", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x1C128A0", Offset = "0x1C112A0", VA = "0x181C128A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FNADOEIJHDI<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::FNADOEIJHDI<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T1 MNMOAKCMNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T2 CDICPAENOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T3 MNONKFKOFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T4 DBFAIJDALPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T5 MJOLLJPEIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T6 AMNLMAFDODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly T7 AIDHHPOKGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly T8 IHJBHAONOHH;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x1DE2A90", Offset = "0x1DE1490", VA = "0x181DE2A90")]
	public FNADOEIJHDI(T1 DBMMGCBBODH, T2 JOGGMBJFBMF, T3 DDFHEPDNKGH, T4 AKHINBLICOA, T5 CNIKHCBEMNE, T6 JPCNDFGJJLE, T7 KKONLOBLINI, T8 NOEGIEMCCIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x1DE2360", Offset = "0x1DE0D60", VA = "0x181DE2360", Slot = "4")]
	public int CompareTo(global::FNADOEIJHDI<T1, T2, T3, T4, T5, T6, T7, T8> BPKBHFMGOOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x1DE25B0", Offset = "0x1DE0FB0", VA = "0x181DE25B0", Slot = "0")]
	public override bool Equals(object BPKBHFMGOOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x1DE2770", Offset = "0x1DE1170", VA = "0x181DE2770", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x1DE28E0", Offset = "0x1DE12E0", VA = "0x181DE28E0", Slot = "3")]
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
	public T EDONKBBONCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x100E650", Offset = "0x100D050", VA = "0x18100E650")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x36473E0", Offset = "0x3645DE0", VA = "0x1836473E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float PFAAHKNOGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6DE260", Offset = "0x6DCC60", VA = "0x1806DE260")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3647680", Offset = "0x3646080", VA = "0x183647680")]
	public T ONPPFEKIEAC(float IEEKPPIPNKF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3647350", Offset = "0x3645D50", VA = "0x183647350")]
	public T IEBCFPCDHJF(float IEEKPPIPNKF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T PGJAJCPDHPD(T KCFHGHIJEEN, T EIBGAMBEABJ, float IEEKPPIPNKF);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7D07F0", Offset = "0x7CF1F0", VA = "0x1807D07F0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3011BD0", Offset = "0x30105D0", VA = "0x183011BD0", Slot = "4")]
	protected override float PGJAJCPDHPD(float KCFHGHIJEEN, float EIBGAMBEABJ, float IEEKPPIPNKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5E50DB0", Offset = "0x5E4F7B0", VA = "0x185E50DB0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0xC7EC90", Offset = "0xC7D690", VA = "0x180C7EC90", Slot = "4")]
	protected override Vector3 PGJAJCPDHPD(Vector3 KCFHGHIJEEN, Vector3 EIBGAMBEABJ, float IEEKPPIPNKF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5E59960", Offset = "0x5E58360", VA = "0x185E59960")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5E50580", Offset = "0x5E4EF80", VA = "0x185E50580", Slot = "4")]
	protected override Color PGJAJCPDHPD(Color KCFHGHIJEEN, Color EIBGAMBEABJ, float IEEKPPIPNKF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5E505D0", Offset = "0x5E4EFD0", VA = "0x185E505D0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class HJPALAGOOBJ : global::CIIOIHDFIII<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5E51660", Offset = "0x5E50060", VA = "0x185E51660")]
	public HJPALAGOOBJ(int CDECJIFLFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5E51600", Offset = "0x5E50000", VA = "0x185E51600")]
	public HJPALAGOOBJ(NGLFPLJDMCB[] LGNGGLCFNPH, bool LMKOBMIEEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5E51590", Offset = "0x5E4FF90", VA = "0x185E51590", Slot = "6")]
	protected override uint LJCNMFHCHOH(uint FHKNDMKDLNF, string NKJMIDIDBOE)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class OKIGFPIBACA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly IDisposable BLPHKNHCNDJ;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public OKIGFPIBACA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct MOLBGKGLHEO
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class AMBGPOBAIOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public TaskCompletionSource<FIGHGNFLDFK> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public AMBGPOBAIOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5E4FB20", Offset = "0x5E4E520", VA = "0x185E4FB20")]
		internal void <StartRequest>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<FIGHGNFLDFK>> EBLMEIKHFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int IJPONLFIJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int DNGJLBGLDDP;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1A5D000", Offset = "0x1A5BA00", VA = "0x181A5D000")]
	private MOLBGKGLHEO(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<FIGHGNFLDFK>> EOHJNLCAILK, int NPBBMPMBNJA, int PFFJGCGMEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5E55530", Offset = "0x5E53F30", VA = "0x185E55530")]
	public static MOLBGKGLHEO NDGDIJBCNJC()
	{
		return default(MOLBGKGLHEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5E555B0", Offset = "0x5E53FB0", VA = "0x185E555B0")]
	public (int, int, Task) NNBCGGHAPBE(int NAPNJBCBGJA, [Optional] CancellationToken OGOJJPCADFI)
	{
		return default((int, int, Task));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5E55450", Offset = "0x5E53E50", VA = "0x185E55450")]
	public void JPPHAPNEHGB(int NAPNJBCBGJA, int PFFJGCGMEDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[DefaultMember("Item")]
public class GKNBOCDOHFP<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Dictionary<TKey, TVal> GKMACCMGDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Dictionary<TVal, TKey> OCDMJMFBAGN;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int OABDNEKKKBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x1638810", Offset = "0x1637210", VA = "0x181638810", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool PDKIMMAFNIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x69D720", Offset = "0x69C120", VA = "0x18069D720", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> GKCGGGFKFJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x1F5D850", Offset = "0x1F5C250", VA = "0x181F5D850", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> MCNBMFPFFBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2471BB0", Offset = "0x24705B0", VA = "0x182471BB0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal GMLDPDCPAEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x1DCA4F0", Offset = "0x1DC8EF0", VA = "0x181DCA4F0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x23C5A20", Offset = "0x23C4420", VA = "0x1823C5A20", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey GMLDPDCPAEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2B10070", Offset = "0x2B0EA70", VA = "0x182B10070")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B0F970", Offset = "0x2B0E370", VA = "0x182B0F970")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2B0FA50", Offset = "0x2B0E450", VA = "0x182B0FA50", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2B10180", Offset = "0x2B0EB80", VA = "0x182B10180", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1A60250", Offset = "0x1A5EC50", VA = "0x181A60250", Slot = "9")]
	public void Add(TKey KFEMFMGCJPM, TVal NKJMIDIDBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2B0F910", Offset = "0x2B0E310", VA = "0x182B0F910", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> LPGHMHLAPGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2B0FAB0", Offset = "0x2B0E4B0", VA = "0x182B0FAB0", Slot = "8")]
	public bool ContainsKey(TKey KFEMFMGCJPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x25B09B0", Offset = "0x25AF3B0", VA = "0x1825B09B0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> LPGHMHLAPGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2B100D0", Offset = "0x2B0EAD0", VA = "0x182B100D0", Slot = "10")]
	public bool Remove(TKey KFEMFMGCJPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2B100D0", Offset = "0x2B0EAD0", VA = "0x182B100D0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> LPGHMHLAPGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1C12CB0", Offset = "0x1C116B0", VA = "0x181C12CB0", Slot = "11")]
	public bool TryGetValue(TKey KFEMFMGCJPM, out TVal NKJMIDIDBOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2B0FC80", Offset = "0x2B0E680", VA = "0x182B0FC80", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2B0FB10", Offset = "0x2B0E510", VA = "0x182B0FB10", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] EIOACKOCJCB, int CJMIFBGEMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2B0FFD0", Offset = "0x2B0E9D0", VA = "0x182B0FFD0")]
	public void MJIKPLNABDE(TVal MAINGDDHDKB, TKey KFEMFMGCJPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2B0FF90", Offset = "0x2B0E990", VA = "0x182B0FF90")]
	public void MJIKPLNABDE(KeyValuePair<TVal, TKey> LPGHMHLAPGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2B10010", Offset = "0x2B0EA10", VA = "0x182B10010")]
	public bool NGKIGKNCONM(TVal KFEMFMGCJPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2B0F9F0", Offset = "0x2B0E3F0", VA = "0x182B0F9F0")]
	public bool CLJNJIAEHOP(KeyValuePair<TVal, TKey> LPGHMHLAPGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x1B54E90", Offset = "0x1B53890", VA = "0x181B54E90")]
	public bool OMBMHDCIFDM(TVal KFEMFMGCJPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x1B54E90", Offset = "0x1B53890", VA = "0x181B54E90")]
	public bool OMBMHDCIFDM(KeyValuePair<TVal, TKey> LPGHMHLAPGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2B10040", Offset = "0x2B0EA40", VA = "0x182B10040")]
	public bool OHBNCLEBFJI(TVal KFEMFMGCJPM, out TKey NKJMIDIDBOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2B0FD00", Offset = "0x2B0E700", VA = "0x182B0FD00")]
	public IEnumerator<KeyValuePair<TVal, TKey>> HACHDKIMFNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2B0FB70", Offset = "0x2B0E570", VA = "0x182B0FB70")]
	private void GJNIGBFLIKN(TKey KFEMFMGCJPM, TVal MAINGDDHDKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2B0FEA0", Offset = "0x2B0E8A0", VA = "0x182B0FEA0")]
	private void KCKDCEELHMA(TKey KFEMFMGCJPM, TVal MAINGDDHDKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2B0F6D0", Offset = "0x2B0E0D0", VA = "0x182B0F6D0")]
	private bool ANFDLJHCCNH(TKey KFEMFMGCJPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2B0F610", Offset = "0x2B0E010", VA = "0x182B0F610")]
	private bool ANFDLJHCCNH(TVal MAINGDDHDKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2B101D0", Offset = "0x2B0EBD0", VA = "0x182B101D0")]
	public GKNBOCDOHFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[DefaultMember("Item")]
public class BPPLIICPNFL<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private global::BPPLIICPNFL<T> buffer;

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
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x6A4EB0", Offset = "0x6A38B0", VA = "0x1806A4EB0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x27DFC80", Offset = "0x27DE680", VA = "0x1827DFC80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2786A30", Offset = "0x2785430", VA = "0x182786A30")]
		public Enumerator(global::BPPLIICPNFL<T> MFPFCCDPGDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x27DD000", Offset = "0x27DBA00", VA = "0x1827DD000", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x27DD560", Offset = "0x27DBF60", VA = "0x1827DD560", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x27DAA70", Offset = "0x27D9470", VA = "0x1827DAA70")]
		private void DIAEACKMDGN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private T[] PFPNEPOJCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private int DAKLCPMDBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private int PCFGMBEPFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private int FDLOHCDDBIM;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int OABDNEKKKBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x1DF1A80", Offset = "0x1DF0480", VA = "0x181DF1A80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T GMLDPDCPAEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x1DF3140", Offset = "0x1DF1B40", VA = "0x181DF3140")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x1DF1C30", Offset = "0x1DF0630", VA = "0x181DF1C30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x1DF3480", Offset = "0x1DF1E80", VA = "0x181DF3480")]
	public BPPLIICPNFL(int CDECJIFLFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x1DF3030", Offset = "0x1DF1A30", VA = "0x181DF3030")]
	public void MJIKPLNABDE(T IEEKPPIPNKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x1DF1CB0", Offset = "0x1DF06B0", VA = "0x181DF1CB0")]
	public void HMOHCCLKEOM(IEnumerable<T> HGCLMOOEAJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x1DF2DB0", Offset = "0x1DF17B0", VA = "0x181DF2DB0")]
	public void LCFMPIKHEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x1DF2960", Offset = "0x1DF1360", VA = "0x181DF2960")]
	public void JFEMCGKHPIA(int OOJKDAEFAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x1DF3270", Offset = "0x1DF1C70", VA = "0x181DF3270")]
	public void PBJLDDMFPML(int OOJKDAEFAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x1DF1930", Offset = "0x1DF0330", VA = "0x181DF1930")]
	public void APHLMFLHBNP(T[] EIOACKOCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x1DF28B0", Offset = "0x1DF12B0", VA = "0x181DF28B0")]
	public Enumerator ICBJEBDOHAE()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x1DF3300", Offset = "0x1DF1D00", VA = "0x181DF3300", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x1DF3300", Offset = "0x1DF1D00", VA = "0x181DF3300", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x1DF2AE0", Offset = "0x1DF14E0", VA = "0x181DF2AE0")]
	private int JMGCBJJCJFH(int NENMOOINMCH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x1DF2DD0", Offset = "0x1DF17D0", VA = "0x181DF2DD0")]
	private int MGEKODBLAPN(int NENMOOINMCH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public class BEFFJHFNOMB<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Func<Internal, External> AGPOHFNPPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Func<External, Internal> BECPDLCBILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private IList<Internal> AMMGMIDPNEP;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IList<Internal> GLPHPMFJMJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x697FE0", Offset = "0x6969E0", VA = "0x180697FE0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F00", Offset = "0x6A3900", VA = "0x1806A4F00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool PDKIMMAFNIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x799F80", Offset = "0x798980", VA = "0x180799F80", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x799F70", Offset = "0x798970", VA = "0x180799F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public External GMLDPDCPAEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x25B49F0", Offset = "0x25B33F0", VA = "0x1825B49F0", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x25B4A90", Offset = "0x25B3490", VA = "0x1825B4A90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int OABDNEKKKBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x25B4990", Offset = "0x25B3390", VA = "0x1825B4990", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x25B4900", Offset = "0x25B3300", VA = "0x1825B4900")]
	public BEFFJHFNOMB(Func<Internal, External> AGPOHFNPPAE, Func<External, Internal> BECPDLCBILG, bool FMOAHOIEJLP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x25B4620", Offset = "0x25B3020", VA = "0x1825B4620", Slot = "6")]
	public int IndexOf(External LPGHMHLAPGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x25B42A0", Offset = "0x25B2CA0", VA = "0x1825B42A0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x25B4300", Offset = "0x25B2D00", VA = "0x1825B4300", Slot = "13")]
	public bool Contains(External LPGHMHLAPGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x25B4390", Offset = "0x25B2D90", VA = "0x1825B4390", Slot = "14")]
	public void CopyTo(External[] EIOACKOCJCB, int CJMIFBGEMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x25B41B0", Offset = "0x25B2BB0", VA = "0x1825B41B0", Slot = "11")]
	public void Add(External LPGHMHLAPGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x25B4710", Offset = "0x25B3110", VA = "0x1825B4710", Slot = "7")]
	public void Insert(int NENMOOINMCH, External LPGHMHLAPGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x25B4870", Offset = "0x25B3270", VA = "0x1825B4870", Slot = "15")]
	public bool Remove(External LPGHMHLAPGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x25B47B0", Offset = "0x25B31B0", VA = "0x1825B47B0", Slot = "8")]
	public void RemoveAt(int NENMOOINMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x25B45B0", Offset = "0x25B2FB0", VA = "0x1825B45B0", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x1C10D20", Offset = "0x1C0F720", VA = "0x181C10D20", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class KKOBIPOHPCI<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly Func<Internal, External> AGPOHFNPPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private IReadOnlyList<Internal> AMMGMIDPNEP;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyList<Internal> GLPHPMFJMJB
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6A4ED0", Offset = "0x6A38D0", VA = "0x1806A4ED0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool PDKIMMAFNIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6A32E0", Offset = "0x6A1CE0", VA = "0x1806A32E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public External GMLDPDCPAEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x27C89A0", Offset = "0x27C73A0", VA = "0x1827C89A0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int OABDNEKKKBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x27C8940", Offset = "0x27C7340", VA = "0x1827C8940", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x1A58D90", Offset = "0x1A57790", VA = "0x181A58D90")]
	public KKOBIPOHPCI(Func<Internal, External> AGPOHFNPPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x27C88F0", Offset = "0x27C72F0", VA = "0x1827C88F0")]
	public KKOBIPOHPCI(IReadOnlyList<Internal> AMMGMIDPNEP, Func<Internal, External> AGPOHFNPPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x27C8660", Offset = "0x27C7060", VA = "0x1827C8660")]
	public void APHLMFLHBNP(External[] EIOACKOCJCB, int CJMIFBGEMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x27C8880", Offset = "0x27C7280", VA = "0x1827C8880", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x1A65E00", Offset = "0x1A64800", VA = "0x181A65E00", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class JBBGPNNAONP<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private IReadOnlyList<Internal> AMMGMIDPNEP;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IReadOnlyList<Internal> GLPHPMFJMJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EB0", Offset = "0x6A38B0", VA = "0x1806A4EB0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EA0", Offset = "0x6A38A0", VA = "0x1806A4EA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool PDKIMMAFNIE
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6A32E0", Offset = "0x6A1CE0", VA = "0x1806A32E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public External GMLDPDCPAEM
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x1C10DB0", Offset = "0x1C0F7B0", VA = "0x181C10DB0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int OABDNEKKKBL
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x1C10D50", Offset = "0x1C0F750", VA = "0x181C10D50", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x1A58D90", Offset = "0x1A57790", VA = "0x181A58D90")]
	public JBBGPNNAONP(IReadOnlyList<Internal> AMMGMIDPNEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x1C10C10", Offset = "0x1C0F610", VA = "0x181C10C10")]
	public bool CLJNJIAEHOP(External LPGHMHLAPGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x1C109E0", Offset = "0x1C0F3E0", VA = "0x181C109E0")]
	public void APHLMFLHBNP(External[] EIOACKOCJCB, int CJMIFBGEMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x1C10CB0", Offset = "0x1C0F6B0", VA = "0x181C10CB0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1C10D20", Offset = "0x1C0F720", VA = "0x181C10D20", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class CBEFJKABGAB
{
	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void DCGEFDDBNLM(object[] GBGLLILEMPG);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	protected CBEFJKABGAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public abstract class NFOHNIOKLND<T> : CBEFJKABGAB
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	protected struct BMEPEGMFKLL
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public enum ENAAOIDAECL
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
		public ENAAOIDAECL NFMPIOLJBMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public T LBPAPOGAAHD;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int MNOCFBHHEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly bool ABGGLDKFFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	protected readonly bool NMPFPKHLENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	protected List<T> CLLPFDGNLGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<BMEPEGMFKLL> HGGCHELIPAB;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool HJKEIDFBJOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x1FDB6A0", Offset = "0x1FDA0A0", VA = "0x181FDB6A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x1FDB820", Offset = "0x1FDA220", VA = "0x181FDB820")]
	protected NFOHNIOKLND(bool NMPFPKHLENP, bool ABGGLDKFFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x1FDB3B0", Offset = "0x1FD9DB0", VA = "0x181FDB3B0")]
	protected bool DPCPJENLIJB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x1FDB140", Offset = "0x1FD9B40", VA = "0x181FDB140")]
	protected void AKNNDOBDIHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x1FDB200", Offset = "0x1FD9C00", VA = "0x181FDB200")]
	protected void DPCNMLJHFDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x15994E0", Offset = "0x1597EE0", VA = "0x1815994E0")]
	private static void FBLHEDKNEIO<U>(ref List<U> AMMGMIDPNEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x1FDB540", Offset = "0x1FD9F40", VA = "0x181FDB540", Slot = "5")]
	public void MJIKPLNABDE(T LBPAPOGAAHD, bool HNKFJFNDMKD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x1FDB6E0", Offset = "0x1FDA0E0", VA = "0x181FDB6E0", Slot = "6")]
	public void OMBMHDCIFDM(T LBPAPOGAAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x1FDB430", Offset = "0x1FD9E30", VA = "0x181FDB430")]
	public void LCFMPIKHEBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface CIBJPEJNEFL
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MJIKPLNABDE(Action LBPAPOGAAHD, bool HNKFJFNDMKD = false);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OMBMHDCIFDM(Action LBPAPOGAAHD);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class HOEGAMEJKFN : global::NFOHNIOKLND<Action>, CIBJPEJNEFL
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5E51C20", Offset = "0x5E50620", VA = "0x185E51C20")]
	public HOEGAMEJKFN(bool NMPFPKHLENP = false, bool ABGGLDKFFPJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5E51A10", Offset = "0x5E50410", VA = "0x185E51A10")]
	public void NMKHCPGLDLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5E518E0", Offset = "0x5E502E0", VA = "0x185E518E0", Slot = "4")]
	public override void DCGEFDDBNLM(object[] GBGLLILEMPG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5E51950", Offset = "0x5E50350", VA = "0x185E51950")]
	public static HOEGAMEJKFN HFHDNGEDPOA(HOEGAMEJKFN KNHKOANOCIL, Action LBPAPOGAAHD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5E519B0", Offset = "0x5E503B0", VA = "0x185E519B0")]
	public static HOEGAMEJKFN JMHLHCOHHFJ(HOEGAMEJKFN KNHKOANOCIL, Action LBPAPOGAAHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface DCGPLFJNBHK<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MJIKPLNABDE(Action<T> LBPAPOGAAHD, bool HNKFJFNDMKD = false);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OMBMHDCIFDM(Action<T> LBPAPOGAAHD);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class DGAFBCMAOFI<T> : global::NFOHNIOKLND<Action<T>>, global::DCGPLFJNBHK<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x1B7F4A0", Offset = "0x1B7DEA0", VA = "0x181B7F4A0")]
	public DGAFBCMAOFI(bool NMPFPKHLENP = false, bool ABGGLDKFFPJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x1FCBAE0", Offset = "0x1FCA4E0", VA = "0x181FCBAE0")]
	public void NMKHCPGLDLL(T IEEKPPIPNKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x1FCA270", Offset = "0x1FC8C70", VA = "0x181FCA270", Slot = "4")]
	public override void DCGEFDDBNLM(object[] GBGLLILEMPG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB9A0", Offset = "0x1FCA3A0", VA = "0x181FCB9A0")]
	public static global::DGAFBCMAOFI<T> HFHDNGEDPOA(global::DGAFBCMAOFI<T> KNHKOANOCIL, Action<T> LBPAPOGAAHD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1FCBA40", Offset = "0x1FCA440", VA = "0x181FCBA40")]
	public static global::DGAFBCMAOFI<T> JMHLHCOHHFJ(global::DGAFBCMAOFI<T> KNHKOANOCIL, Action<T> LBPAPOGAAHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface DLDMBFNIDLH<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MJIKPLNABDE(Action<T, U> LBPAPOGAAHD, bool HNKFJFNDMKD = false);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OMBMHDCIFDM(Action<T, U> LBPAPOGAAHD);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class KPOAKAINNON<T, U> : global::NFOHNIOKLND<Action<T, U>>, global::DLDMBFNIDLH<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x1B7F4A0", Offset = "0x1B7DEA0", VA = "0x181B7F4A0")]
	public KPOAKAINNON(bool NMPFPKHLENP = false, bool ABGGLDKFFPJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x27D7460", Offset = "0x27D5E60", VA = "0x1827D7460")]
	public void NMKHCPGLDLL(T IEEKPPIPNKF, U HPHDMDPPHPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x27D4EA0", Offset = "0x27D38A0", VA = "0x1827D4EA0", Slot = "4")]
	public override void DCGEFDDBNLM(object[] GBGLLILEMPG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x27D6A10", Offset = "0x27D5410", VA = "0x1827D6A10")]
	public static global::KPOAKAINNON<T, U> HFHDNGEDPOA(global::KPOAKAINNON<T, U> KNHKOANOCIL, Action<T, U> LBPAPOGAAHD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x27D6AB0", Offset = "0x27D54B0", VA = "0x1827D6AB0")]
	public static global::KPOAKAINNON<T, U> JMHLHCOHHFJ(global::KPOAKAINNON<T, U> KNHKOANOCIL, Action<T, U> LBPAPOGAAHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface EKIFMMKBNNC<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MJIKPLNABDE(Action<T, U, V> LBPAPOGAAHD, bool HNKFJFNDMKD = false);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OMBMHDCIFDM(Action<T, U, V> LBPAPOGAAHD);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class EOKHNCLKHDO<T, U, V> : global::NFOHNIOKLND<Action<T, U, V>>, global::EKIFMMKBNNC<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x1B7F4A0", Offset = "0x1B7DEA0", VA = "0x181B7F4A0")]
	public EOKHNCLKHDO(bool NMPFPKHLENP = false, bool ABGGLDKFFPJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x2C41120", Offset = "0x2C3FB20", VA = "0x182C41120")]
	public void NMKHCPGLDLL(T IEEKPPIPNKF, U HPHDMDPPHPC, V LNKDDMNNFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x2C3F5E0", Offset = "0x2C3DFE0", VA = "0x182C3F5E0", Slot = "4")]
	public override void DCGEFDDBNLM(object[] GBGLLILEMPG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x2C40060", Offset = "0x2C3EA60", VA = "0x182C40060")]
	public static global::EOKHNCLKHDO<T, U, V> HFHDNGEDPOA(global::EOKHNCLKHDO<T, U, V> KNHKOANOCIL, Action<T, U, V> LBPAPOGAAHD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x2C40100", Offset = "0x2C3EB00", VA = "0x182C40100")]
	public static global::EOKHNCLKHDO<T, U, V> JMHLHCOHHFJ(global::EOKHNCLKHDO<T, U, V> KNHKOANOCIL, Action<T, U, V> LBPAPOGAAHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface OBLIMOPAMPA<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MJIKPLNABDE(Action<T, U, V, W> LBPAPOGAAHD, bool HNKFJFNDMKD = false);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OMBMHDCIFDM(Action<T, U, V, W> LBPAPOGAAHD);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class JHOJJNCHIAH<T, U, V, W> : global::NFOHNIOKLND<Action<T, U, V, W>>, global::OBLIMOPAMPA<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x1B7F4A0", Offset = "0x1B7DEA0", VA = "0x181B7F4A0")]
	public JHOJJNCHIAH(bool NMPFPKHLENP = false, bool ABGGLDKFFPJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x1C2D4E0", Offset = "0x1C2BEE0", VA = "0x181C2D4E0")]
	public void NMKHCPGLDLL(T IEEKPPIPNKF, U HPHDMDPPHPC, V LNKDDMNNFGJ, W HMBPKDIMEHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x1C2C920", Offset = "0x1C2B320", VA = "0x181C2C920", Slot = "4")]
	public override void DCGEFDDBNLM(object[] GBGLLILEMPG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x1C2CE10", Offset = "0x1C2B810", VA = "0x181C2CE10")]
	public static global::JHOJJNCHIAH<T, U, V, W> HFHDNGEDPOA(global::JHOJJNCHIAH<T, U, V, W> KNHKOANOCIL, Action<T, U, V, W> LBPAPOGAAHD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x1C2CEB0", Offset = "0x1C2B8B0", VA = "0x181C2CEB0")]
	public static global::JHOJJNCHIAH<T, U, V, W> JMHLHCOHHFJ(global::JHOJJNCHIAH<T, U, V, W> KNHKOANOCIL, Action<T, U, V, W> LBPAPOGAAHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface APKFEOIEHGL<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MJIKPLNABDE(Action<T, U, V, W, X> LBPAPOGAAHD, bool HNKFJFNDMKD = false);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OMBMHDCIFDM(Action<T, U, V, W, X> LBPAPOGAAHD);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class NKLIGNHBKKG<T, U, V, W, X> : global::NFOHNIOKLND<Action<T, U, V, W, X>>, global::APKFEOIEHGL<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x1B7F4A0", Offset = "0x1B7DEA0", VA = "0x181B7F4A0")]
	public NKLIGNHBKKG(bool NMPFPKHLENP = false, bool ABGGLDKFFPJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x1FEC310", Offset = "0x1FEAD10", VA = "0x181FEC310")]
	public void NMKHCPGLDLL(T IEEKPPIPNKF, U HPHDMDPPHPC, V LNKDDMNNFGJ, W HMBPKDIMEHE, X GKGDNAPOGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x1FEB890", Offset = "0x1FEA290", VA = "0x181FEB890", Slot = "4")]
	public override void DCGEFDDBNLM(object[] GBGLLILEMPG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x1FEBEA0", Offset = "0x1FEA8A0", VA = "0x181FEBEA0")]
	public static global::NKLIGNHBKKG<T, U, V, W, X> HFHDNGEDPOA(global::NKLIGNHBKKG<T, U, V, W, X> KNHKOANOCIL, Action<T, U, V, W, X> LBPAPOGAAHD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x1FEBF40", Offset = "0x1FEA940", VA = "0x181FEBF40")]
	public static global::NKLIGNHBKKG<T, U, V, W, X> JMHLHCOHHFJ(global::NKLIGNHBKKG<T, U, V, W, X> KNHKOANOCIL, Action<T, U, V, W, X> LBPAPOGAAHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface MGAEEDLJECA<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MJIKPLNABDE(Action<T, U, V, W, X, Y> LBPAPOGAAHD, bool HNKFJFNDMKD = false);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OMBMHDCIFDM(Action<T, U, V, W, X, Y> LBPAPOGAAHD);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class DBGKBNDMHBK<T, U, V, W, X, Y> : global::NFOHNIOKLND<Action<T, U, V, W, X, Y>>, global::MGAEEDLJECA<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x1B7F4A0", Offset = "0x1B7DEA0", VA = "0x181B7F4A0")]
	public DBGKBNDMHBK(bool NMPFPKHLENP = false, bool ABGGLDKFFPJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x1FBFF60", Offset = "0x1FBE960", VA = "0x181FBFF60")]
	public void NMKHCPGLDLL(T IEEKPPIPNKF, U HPHDMDPPHPC, V LNKDDMNNFGJ, W HMBPKDIMEHE, X GKGDNAPOGPF, Y JLKLDCLDEEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF510", Offset = "0x1FBDF10", VA = "0x181FBF510", Slot = "4")]
	public override void DCGEFDDBNLM(object[] GBGLLILEMPG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF850", Offset = "0x1FBE250", VA = "0x181FBF850")]
	public static global::DBGKBNDMHBK<T, U, V, W, X, Y> HFHDNGEDPOA(global::DBGKBNDMHBK<T, U, V, W, X, Y> KNHKOANOCIL, Action<T, U, V, W, X, Y> LBPAPOGAAHD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF8F0", Offset = "0x1FBE2F0", VA = "0x181FBF8F0")]
	public static global::DBGKBNDMHBK<T, U, V, W, X, Y> JMHLHCOHHFJ(global::DBGKBNDMHBK<T, U, V, W, X, Y> KNHKOANOCIL, Action<T, U, V, W, X, Y> LBPAPOGAAHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class AJDMLENAJAJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public readonly struct GIMEPLEMMFA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly global::AJDMLENAJAJ<T> AKJHLACANBH;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public T EDONKBBONCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x1CC5C20", Offset = "0x1CC4620", VA = "0x181CC5C20")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x1CC5BF0", Offset = "0x1CC45F0", VA = "0x181CC5BF0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EC0", Offset = "0x6A38C0", VA = "0x1806A4EC0")]
		public GIMEPLEMMFA(global::AJDMLENAJAJ<T> AKJHLACANBH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct HKPOLHIBEAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder<GIMEPLEMMFA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public global::AJDMLENAJAJ<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x23D1960", Offset = "0x23D0360", VA = "0x1823D1960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x162B2C0", Offset = "0x1629CC0", VA = "0x18162B2C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct EEINAOLGHMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AsyncTaskMethodBuilder<GIMEPLEMMFA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public global::AJDMLENAJAJ<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x361A0E0", Offset = "0x3618AE0", VA = "0x18361A0E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x162B2C0", Offset = "0x1629CC0", VA = "0x18162B2C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly SemaphoreSlim PGIKOIJJGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private T OEMIHDALHLO;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int LNNMJFNPEKB
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2025100", Offset = "0x2023B00", VA = "0x182025100")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x2025760", Offset = "0x2024160", VA = "0x182025760")]
	public AJDMLENAJAJ(in T OEMIHDALHLO, int ALPBCPACKLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2025800", Offset = "0x2024200", VA = "0x182025800")]
	public AJDMLENAJAJ(in T OEMIHDALHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x20250C0", Offset = "0x2023AC0", VA = "0x1820250C0")]
	public GIMEPLEMMFA ACIHCHJBMLK()
	{
		return default(GIMEPLEMMFA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x2025080", Offset = "0x2023A80", VA = "0x182025080")]
	public GIMEPLEMMFA ACIHCHJBMLK(CancellationToken OGOJJPCADFI)
	{
		return default(GIMEPLEMMFA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2025400", Offset = "0x2023E00", VA = "0x182025400")]
	[AsyncStateMachine(typeof(global::AJDMLENAJAJ<>.HKPOLHIBEAK))]
	public Task<GIMEPLEMMFA> KIJONBJCLKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x2025290", Offset = "0x2023C90", VA = "0x182025290")]
	[AsyncStateMachine(typeof(global::AJDMLENAJAJ<>.EEINAOLGHMD))]
	public Task<GIMEPLEMMFA> KIJONBJCLKG(CancellationToken OGOJJPCADFI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class LGFLEFDJEMF
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5E546B0", Offset = "0x5E530B0", VA = "0x185E546B0")]
	public static global::AJDMLENAJAJ<FIGHGNFLDFK> NDGDIJBCNJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5E54640", Offset = "0x5E53040", VA = "0x185E54640")]
	public static global::AJDMLENAJAJ<FIGHGNFLDFK> NDGDIJBCNJC(int ALPBCPACKLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2156330", Offset = "0x2154D30", VA = "0x182156330")]
	public static global::AJDMLENAJAJ<T> NDGDIJBCNJC<T>(in T OEMIHDALHLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x24E0430", Offset = "0x24DEE30", VA = "0x1824E0430")]
	public static global::AJDMLENAJAJ<T> NDGDIJBCNJC<T>(in T OEMIHDALHLO, int ALPBCPACKLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class ODGHJMHABMI<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public delegate Task<TResult> GOFMJAJMNFA(TRequest KDMHFDGDHMP, CancellationToken OGOJJPCADFI);

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public enum JBJHPLBMCNB
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class BJAGPEDDDDC
	{
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private const float GIIPKIKBDNO = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TimeSpan KIJGGCPNDMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int HDEJKCNIOBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public JBJHPLBMCNB MLINMLDPHJL;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly BJAGPEDDDDC MHJMHHILEFG;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float NBGOPAJHKAH
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x25B8350", Offset = "0x25B6D50", VA = "0x1825B8350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TimeSpan APHNOHLNDCF
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x6A4EB0", Offset = "0x6A38B0", VA = "0x1806A4EB0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x25B8430", Offset = "0x25B6E30", VA = "0x1825B8430")]
		public BJAGPEDDDDC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private readonly struct AOJMHKPJIGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly TRequest KDMHFDGDHMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public readonly CancellationToken OGOJJPCADFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public readonly TaskCompletionSource<TResult> GAMMJONLBLO;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2035330", Offset = "0x2033D30", VA = "0x182035330")]
		public AOJMHKPJIGF(TRequest KDMHFDGDHMP, TaskCompletionSource<TResult> GAMMJONLBLO, CancellationToken OGOJJPCADFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class FAKNCKPCBNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7D07F0", Offset = "0x7CF1F0", VA = "0x1807D07F0")]
		public FAKNCKPCBNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x1638810", Offset = "0x1637210", VA = "0x181638810")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct DMENNFMPJPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public global::ODGHJMHABMI<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3579630", Offset = "0x3578030", VA = "0x183579630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x795F10", Offset = "0x794910", VA = "0x180795F10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct MDDONECEAON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public global::ODGHJMHABMI<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private AOJMHKPJIGF <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3D173F0", Offset = "0x3D15DF0", VA = "0x183D173F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x795F10", Offset = "0x794910", VA = "0x180795F10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CancellationTokenSource AMOMJJPOCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly List<AOJMHKPJIGF> GDAELDAOCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly BJAGPEDDDDC DHANHCICCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly GOFMJAJMNFA ALIEDGEICJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Task INKGBMFHPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int BNLPAKBHIGI;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2460C00", Offset = "0x245F600", VA = "0x182460C00")]
	public ODGHJMHABMI(GOFMJAJMNFA ALIEDGEICJB, [Optional] BJAGPEDDDDC DHANHCICCND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x245F310", Offset = "0x245DD10", VA = "0x18245F310")]
	public Task<TResult> ABKJCOMCMIB(TRequest KDMHFDGDHMP, CancellationToken OGOJJPCADFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x24605A0", Offset = "0x245EFA0", VA = "0x1824605A0")]
	private void MOGHMJENPLG(AOJMHKPJIGF BMBKLECFNKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2460260", Offset = "0x245EC60", VA = "0x182460260")]
	[AsyncStateMachine(typeof(global::ODGHJMHABMI<, >.DMENNFMPJPD))]
	private Task JDFCHGHEEFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x245FA60", Offset = "0x245E460", VA = "0x18245FA60")]
	private AOJMHKPJIGF IOGBOJIDEEL()
	{
		return default(AOJMHKPJIGF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2460AE0", Offset = "0x245F4E0", VA = "0x182460AE0")]
	[AsyncStateMachine(typeof(global::ODGHJMHABMI<, >.MDDONECEAON))]
	private Task ONJAPOHNIDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x24607D0", Offset = "0x245F1D0", VA = "0x1824607D0")]
	private void OLLCPPJBCJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x245FA20", Offset = "0x245E420", VA = "0x18245FA20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class PIIMHAEGBEN<TKey, TVal> : global::POMJCCIHPKM<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int PLPGMMJKIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	internal Dictionary<TKey, (TVal value, int size)> KIFLOLJDCMH;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	internal override int NCNMIKGAGAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2F59080", Offset = "0x2F57A80", VA = "0x182F59080", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal int NIPMKPJBNCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2F58F40", Offset = "0x2F57940", VA = "0x182F58F40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public override int OABDNEKKKBL
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2F58AA0", Offset = "0x2F574A0", VA = "0x182F58AA0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x2F59150", Offset = "0x2F57B50", VA = "0x182F59150")]
	public PIIMHAEGBEN(int CDECJIFLFKI, [Optional] JDNJOEOPMEI AOEDNHCIAIB, [Optional] IEqualityComparer<TKey> AOCJPLLACBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x2F58F70", Offset = "0x2F57970", VA = "0x182F58F70")]
	public void KCHJHKIECBA(TKey KFEMFMGCJPM, TVal NKJMIDIDBOE, bool BCMGGNFODKC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x2F58B00", Offset = "0x2F57500", VA = "0x182F58B00")]
	public bool FOCGAFLFKNJ(TKey KFEMFMGCJPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x2F590B0", Offset = "0x2F57AB0", VA = "0x182F590B0", Slot = "6")]
	public override bool OHBNCLEBFJI(TKey BPOHIMFMDPD, out TVal NKJMIDIDBOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x2F58C90", Offset = "0x2F57690", VA = "0x182F58C90")]
	public bool GJJAJEHIJEK(TKey KFEMFMGCJPM, TVal NKJMIDIDBOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x2F58B80", Offset = "0x2F57580", VA = "0x182F58B80")]
	public bool GBPPMCGCIDN(TKey KFEMFMGCJPM, TVal NKJMIDIDBOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x2F59010", Offset = "0x2F57A10", VA = "0x182F59010", Slot = "7")]
	public override void LCFMPIKHEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x2F58EA0", Offset = "0x2F578A0", VA = "0x182F58EA0")]
	private bool HMAHDINHENH(TKey KFEMFMGCJPM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[DefaultMember("Item")]
public class POMJCCIHPKM<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public delegate int JDNJOEOPMEI(TKey KFEMFMGCJPM, TVal NKJMIDIDBOE);

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class NPPGNBEBGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public TKey LACLKBJNDBD
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x9C65F0", Offset = "0x9C4FF0", VA = "0x1809C65F0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public TVal EDONKBBONCD
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x697FE0", Offset = "0x6969E0", VA = "0x180697FE0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x6A4F00", Offset = "0x6A3900", VA = "0x1806A4F00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public int NJPPBNLGLIE
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x6E1520", Offset = "0x6DFF20", VA = "0x1806E1520")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0xB81BC0", Offset = "0xB805C0", VA = "0x180B81BC0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public DateTime IKDDIMDGPKK
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x6B0CF0", Offset = "0x6AF6F0", VA = "0x1806B0CF0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xBFC470", Offset = "0xBFAE70", VA = "0x180BFC470")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x32ED450", Offset = "0x32EBE50", VA = "0x1832ED450")]
		public NPPGNBEBGCJ(TKey KFEMFMGCJPM, TVal MAINGDDHDKB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public const int GMJDBOHKMGE = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly Dictionary<TKey, LinkedListNode<NPPGNBEBGCJ>> JBGJLNJMOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly LinkedList<NPPGNBEBGCJ> OENHNOFLFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	protected readonly JDNJOEOPMEI AOEDNHCIAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly TimeSpan KMECHBKMHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly LPDHILIFCGI KDNDCNFMKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int JGAMOKIAMAB;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int KKMBALGBKLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x75E040", Offset = "0x75CA40", VA = "0x18075E040")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private bool GDDKGDDIHIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x253B3E0", Offset = "0x2539DE0", VA = "0x18253B3E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal virtual int NCNMIKGAGAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x751830", Offset = "0x750230", VA = "0x180751830", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private int OOJKDAEFAHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x1CC3A20", Offset = "0x1CC2420", VA = "0x181CC3A20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public virtual int OABDNEKKKBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x1C0A3A0", Offset = "0x1C08DA0", VA = "0x181C0A3A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public IEnumerable<TKey> GKCGGGFKFJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x253B470", Offset = "0x2539E70", VA = "0x18253B470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public TVal GMLDPDCPAEM
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3A05150", Offset = "0x3A03B50", VA = "0x183A05150")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x355FB20", Offset = "0x355E520", VA = "0x18355FB20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x3A05880", Offset = "0x3A04280", VA = "0x183A05880")]
	public POMJCCIHPKM(int CDECJIFLFKI, [Optional] JDNJOEOPMEI AOEDNHCIAIB, [Optional] IEqualityComparer<TKey> AOCJPLLACBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x253BC70", Offset = "0x253A670", VA = "0x18253BC70")]
	public POMJCCIHPKM(TimeSpan KMECHBKMHBN, [Optional] IEqualityComparer<TKey> AOCJPLLACBB, [Optional] LPDHILIFCGI KDNDCNFMKEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x253BC20", Offset = "0x253A620", VA = "0x18253BC20")]
	public POMJCCIHPKM(int CDECJIFLFKI, TimeSpan KMECHBKMHBN, [Optional] IEqualityComparer<TKey> AOCJPLLACBB, [Optional] LPDHILIFCGI KDNDCNFMKEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x3A05BD0", Offset = "0x3A045D0", VA = "0x183A05BD0")]
	public POMJCCIHPKM(int CDECJIFLFKI, JDNJOEOPMEI AOEDNHCIAIB, TimeSpan KMECHBKMHBN, [Optional] IEqualityComparer<TKey> AOCJPLLACBB, [Optional] LPDHILIFCGI KDNDCNFMKEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x3A04BB0", Offset = "0x3A035B0", VA = "0x183A04BB0")]
	public void MCKAAIFOLME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x3A04960", Offset = "0x3A03360", VA = "0x183A04960")]
	public void LMCGMFHIJLB(TKey KFEMFMGCJPM, TVal NKJMIDIDBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x3A052F0", Offset = "0x3A03CF0", VA = "0x183A052F0")]
	public bool OMBMHDCIFDM(TKey KFEMFMGCJPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x3A04570", Offset = "0x3A02F70", VA = "0x183A04570")]
	private TVal DNANCALJAPO(TKey BPOHIMFMDPD)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x3A04FE0", Offset = "0x3A039E0", VA = "0x183A04FE0", Slot = "6")]
	public virtual bool OHBNCLEBFJI(TKey BPOHIMFMDPD, out TVal NKJMIDIDBOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x253B690", Offset = "0x253A090", VA = "0x18253B690", Slot = "7")]
	public virtual void LCFMPIKHEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x3A03D20", Offset = "0x3A02720", VA = "0x183A03D20")]
	private bool BLFKBJCOPBD(NPPGNBEBGCJ CDFMANCOIOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x3A040E0", Offset = "0x3A02AE0", VA = "0x183A040E0")]
	private void CLKBFOJOOEG(LinkedListNode<NPPGNBEBGCJ> ANHBEMDLKPK, TVal MIIOPMDNGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x3A031A0", Offset = "0x3A01BA0", VA = "0x183A031A0")]
	private void AMDGDCEIFKL(TKey KFEMFMGCJPM, TVal NKJMIDIDBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x3A03AC0", Offset = "0x3A024C0", VA = "0x183A03AC0")]
	private void BBBNFHANHGE(NPPGNBEBGCJ CDFMANCOIOJ, TVal MIIOPMDNGOD, int IOLCDLDDODH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[DefaultMember("Item")]
public class FGDBIIAPKKP<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly List<T> AMMGMIDPNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private HashSet<T> DOFIEPFEACK;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int OABDNEKKKBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x1638810", Offset = "0x1637210", VA = "0x181638810", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool PDKIMMAFNIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x69D720", Offset = "0x69C120", VA = "0x18069D720", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public T GMLDPDCPAEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x17A13D0", Offset = "0x179FDD0", VA = "0x1817A13D0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x1DCAB30", Offset = "0x1DC9530", VA = "0x181DCAB30", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x1DCA140", Offset = "0x1DC8B40", VA = "0x181DCA140", Slot = "11")]
	public void Add(T LPGHMHLAPGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x1DCA200", Offset = "0x1DC8C00", VA = "0x181DCA200")]
	public bool GIOPALFLCJI(T LPGHMHLAPGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x1DCA910", Offset = "0x1DC9310", VA = "0x181DCA910", Slot = "15")]
	public bool Remove(T LPGHMHLAPGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x1C12BF0", Offset = "0x1C115F0", VA = "0x181C12BF0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x1B6B4E0", Offset = "0x1B69EE0", VA = "0x181B6B4E0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x1DCA170", Offset = "0x1DC8B70", VA = "0x181DCA170", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x1B587A0", Offset = "0x1B571A0", VA = "0x181B587A0", Slot = "13")]
	public bool Contains(T LPGHMHLAPGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x1DCA1D0", Offset = "0x1DC8BD0", VA = "0x181DCA1D0", Slot = "14")]
	public void CopyTo(T[] EIOACKOCJCB, int CJMIFBGEMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x1DCA4F0", Offset = "0x1DC8EF0", VA = "0x181DCA4F0", Slot = "6")]
	public int IndexOf(T LPGHMHLAPGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x1DCA5F0", Offset = "0x1DC8FF0", VA = "0x181DCA5F0", Slot = "7")]
	public void Insert(int NENMOOINMCH, T LPGHMHLAPGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x1DCA6E0", Offset = "0x1DC90E0", VA = "0x181DCA6E0", Slot = "8")]
	public void RemoveAt(int NENMOOINMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x1DCA420", Offset = "0x1DC8E20", VA = "0x181DCA420")]
	public void HEKPPFBGEEB(Predicate<T> ABOIPOGNGBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x1DCA6B0", Offset = "0x1DC90B0", VA = "0x181DCA6B0")]
	public void LKDJBHFCBAF(Comparison<T> DGDMNGHKBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x1DCA990", Offset = "0x1DC9390", VA = "0x181DCA990")]
	public FGDBIIAPKKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class IGGIOGOOIIA
{
	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x5E52DF0", Offset = "0x5E517F0", VA = "0x185E52DF0")]
	public static Vector3 CMDOPKAOHHA(this GameObject OOAFGPFKNDK, float JPOABDHAPOJ)
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
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x1867310", Offset = "0x1865D10", VA = "0x181867310")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x5E58F40", Offset = "0x5E57940", VA = "0x185E58F40")]
		public SerializedGuid(in Guid CAPPBFKKCMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x5E58A60", Offset = "0x5E57460", VA = "0x185E58A60")]
		public static SerializedGuid ANPIMDACOGH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x5E58B20", Offset = "0x5E57520", VA = "0x185E58B20")]
		public static SerializedGuid ECPMJDFFBJC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x5E58BB0", Offset = "0x5E575B0", VA = "0x185E58BB0")]
		public bool EJJLMPDOEGL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x5E58F10", Offset = "0x5E57910", VA = "0x185E58F10", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x5E58E70", Offset = "0x5E57870", VA = "0x185E58E70", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x5E58DE0", Offset = "0x5E577E0", VA = "0x185E58DE0")]
		public bool JEJFAEMEMPN(in Guid CAPPBFKKCMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x5E58C40", Offset = "0x5E57640", VA = "0x185E58C40", Slot = "7")]
		public bool Equals(SerializedGuid BPKBHFMGOOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x5E58CF0", Offset = "0x5E576F0", VA = "0x185E58CF0", Slot = "0")]
		public override bool Equals(object PDHKCBEBPNG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x5E58DD0", Offset = "0x5E577D0", VA = "0x185E58DD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x5E58AF0", Offset = "0x5E574F0", VA = "0x185E58AF0", Slot = "6")]
		public int CompareTo(SerializedGuid BPKBHFMGOOF)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class IGNHEBFCOFK : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly Type ONDMEHFIMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly string LLPKOEMOICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly bool MLMGIKIEINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly bool BJHCMBDLKLB;

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x5E530C0", Offset = "0x5E51AC0", VA = "0x185E530C0")]
	public IGNHEBFCOFK(Type MKOMOEKDCEA, string EHKGGDOJGIM, bool AAKDICINIME = false, bool HIBOLCPCGJK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface KCMHNFBANDM
{
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface JMANJKFENDF<T> : KCMHNFBANDM
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	T EDONKBBONCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool BLCDGKCFIKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	string EOLOBJLLIFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::JMANJKFENDF<T> PKKODHLHPCI(Action<T> IAIDEFNDPEM);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::JMANJKFENDF<T> ELCLFDGBNDD(Action<T> IAIDEFNDPEM);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::JMANJKFENDF<T> JMEIIEDEOIC(Action<T, T> JKONCCMDENL);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::JMANJKFENDF<T> OKEIAHHKPAO(Action<T, T> JKONCCMDENL);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::JMANJKFENDF<T> JAOHDPNMIKK(Action<string> DFKKLDMCAIC);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::JMANJKFENDF<T> LGGMOPDGPPH(Action<string> DFKKLDMCAIC);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class AHKMHEIKIDA<T> : global::JMANJKFENDF<T>, KCMHNFBANDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private global::KPOAKAINNON<T, T> EJBNAANHELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private global::DGAFBCMAOFI<T> AHNNDLIAPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private global::DGAFBCMAOFI<string> PHLKPLCGOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private string HENMPJPHDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private T HHGIFHKDCCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool PIBEILCGHPH;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public T EDONKBBONCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6B0CF0", Offset = "0x6AF6F0", VA = "0x1806B0CF0", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x1725020", Offset = "0x1723A20", VA = "0x181725020", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool BLCDGKCFIKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x7F1260", Offset = "0x7EFC60", VA = "0x1807F1260", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string EOLOBJLLIFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6AEB10", Offset = "0x6AD510", VA = "0x1806AEB10", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x19EC120", Offset = "0x19EAB20", VA = "0x1819EC120", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x2023F80", Offset = "0x2022980", VA = "0x182023F80")]
	private void JMGKCIJFKOF(T IKLIFLGKEBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x2024020", Offset = "0x2022A20", VA = "0x182024020")]
	private void KKDOMCPFBLC(string PJJGOJBLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x2023DE0", Offset = "0x20227E0", VA = "0x182023DE0")]
	public void FFPBPCNLABI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x2023F30", Offset = "0x2022930", VA = "0x182023F30", Slot = "6")]
	public global::JMANJKFENDF<T> JMEIIEDEOIC(Action<T, T> JKONCCMDENL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x2024140", Offset = "0x2022B40", VA = "0x182024140", Slot = "7")]
	public global::JMANJKFENDF<T> OKEIAHHKPAO(Action<T, T> JKONCCMDENL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x2024190", Offset = "0x2022B90", VA = "0x182024190", Slot = "4")]
	public global::JMANJKFENDF<T> PKKODHLHPCI(Action<T> JKONCCMDENL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x2023D90", Offset = "0x2022790", VA = "0x182023D90", Slot = "5")]
	public global::JMANJKFENDF<T> ELCLFDGBNDD(Action<T> IAIDEFNDPEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x2023E90", Offset = "0x2022890", VA = "0x182023E90", Slot = "8")]
	public global::JMANJKFENDF<T> JAOHDPNMIKK(Action<string> DFKKLDMCAIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x20240D0", Offset = "0x2022AD0", VA = "0x1820240D0", Slot = "9")]
	public global::JMANJKFENDF<T> LGGMOPDGPPH(Action<string> DFKKLDMCAIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x2024220", Offset = "0x2022C20", VA = "0x182024220")]
	public AHKMHEIKIDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class OFDKHPCONEK
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class HAFFODLKEOP<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public global::JMANJKFENDF<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public global::MDACBOHDAAC<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x7D07F0", Offset = "0x7CF1F0", VA = "0x1807D07F0")]
		public HAFFODLKEOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x2666D10", Offset = "0x2665710", VA = "0x182666D10")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x2213BD0", Offset = "0x22125D0", VA = "0x182213BD0")]
	public static global::LFIHKJLGIGB<T> OBNJJMDABHD<T>(this global::JMANJKFENDF<T> CDDCAGBNIEI, Action<T> MLFGBBGKHEO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class JFIGLCAFHNI<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public readonly struct EJNPDGGFBKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public readonly long PHHGMDLMOOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public readonly long AEFPLHDHJNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public readonly int BLNBECLFKMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public readonly int NEBBMJKDKBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public readonly bool OLFHKGKGIGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly string KCOCNHJPFNM;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x268B810", Offset = "0x268A210", VA = "0x18268B810")]
		public EJNPDGGFBKP(long PHHGMDLMOOK, int BLNBECLFKMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x268B880", Offset = "0x268A280", VA = "0x18268B880")]
		public EJNPDGGFBKP(long PHHGMDLMOOK, long AEFPLHDHJNL, int BLNBECLFKMO, int NEBBMJKDKBC, bool OLFHKGKGIGE, string KCOCNHJPFNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x268B7A0", Offset = "0x268A1A0", VA = "0x18268B7A0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void NIOCADJHNIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x268B630", Offset = "0x268A030", VA = "0x18268B630")]
		public int FFHKLMFKEHK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x268B780", Offset = "0x268A180", VA = "0x18268B780")]
		public int KJAPKEDBHEO(int HCOKHAONFFB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x268B680", Offset = "0x268A080", VA = "0x18268B680")]
		public double GNLJEELJNNJ()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x268B6F0", Offset = "0x268A0F0", VA = "0x18268B6F0")]
		public EJNPDGGFBKP KDGIJNBEIAM(long AEFPLHDHJNL, int NEBBMJKDKBC)
		{
			return default(EJNPDGGFBKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class LCHNHFGOJFL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly TKey LACLKBJNDBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly global::JFIGLCAFHNI<TKey> GHKHAEFLPLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private List<LCHNHFGOJFL> LLBLJHKGLCA;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string KAMEIBABLGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x1A8C3D0", Offset = "0x1A8ADD0", VA = "0x181A8C3D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x1B6BDF0", Offset = "0x1B6A7F0", VA = "0x181B6BDF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public IEnumerable<LCHNHFGOJFL> CAGHDNHGGHO
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x1B6BE50", Offset = "0x1B6A850", VA = "0x181B6BE50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public EJNPDGGFBKP EGBNIFKPDAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0xDCE640", Offset = "0xDCD040", VA = "0x180DCE640")]
			[CompilerGenerated]
			get
			{
				return default(EJNPDGGFBKP);
			}
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x1B6BE20", Offset = "0x1B6A820", VA = "0x181B6BE20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x1B6BE70", Offset = "0x1B6A870", VA = "0x181B6BE70")]
		internal LCHNHFGOJFL(global::JFIGLCAFHNI<TKey> GHKHAEFLPLO, TKey KFEMFMGCJPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x1B6BA50", Offset = "0x1B6A450", VA = "0x181B6BA50")]
		public LCHNHFGOJFL ADEJLKDNIKJ(TKey KFEMFMGCJPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x1B6BB60", Offset = "0x1B6A560", VA = "0x181B6BB60")]
		public void BPHCGGFJBHI(TKey KFEMFMGCJPM, Action<LCHNHFGOJFL> LBPAPOGAAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x275F120", Offset = "0x275DB20", VA = "0x18275F120")]
		public T BPHCGGFJBHI<T>(TKey KFEMFMGCJPM, Func<LCHNHFGOJFL, T> JJOLPBJPMMN)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x275F210", Offset = "0x275DC10", VA = "0x18275F210")]
		[AsyncStateMachine(typeof(BGEDENCDKAN))]
		public Task<T> GBFHBHFMGHM<T>(TKey KFEMFMGCJPM, Func<LCHNHFGOJFL, Task<T>> JJOLPBJPMMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x1B6BC40", Offset = "0x1B6A640", VA = "0x181B6BC40", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class PDFLKAAKIPJ : IEnumerable<(TKey, List<TKey>, EJNPDGGFBKP)>, IEnumerable, IEnumerator<(TKey, List<TKey>, EJNPDGGFBKP)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private (TKey key, List<TKey> path, EJNPDGGFBKP timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public global::JFIGLCAFHNI<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private IEnumerator<(TKey key, List<TKey> path, EJNPDGGFBKP timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		private (TKey, List<TKey>, EJNPDGGFBKP) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x23D1550", Offset = "0x23CFF50", VA = "0x1823D1550", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, EJNPDGGFBKP));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x2B77CE0", Offset = "0x2B766E0", VA = "0x182B77CE0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x23D1920", Offset = "0x23D0320", VA = "0x1823D1920")]
		[DebuggerHidden]
		public PDFLKAAKIPJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x1B5E550", Offset = "0x1B5CF50", VA = "0x181B5E550", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x2B77930", Offset = "0x2B76330", VA = "0x182B77930", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x2B77D40", Offset = "0x2B76740", VA = "0x182B77D40")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x2B77CA0", Offset = "0x2B766A0", VA = "0x182B77CA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x2B77BE0", Offset = "0x2B765E0", VA = "0x182B77BE0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, EJNPDGGFBKP)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x20C8E60", Offset = "0x20C7860", VA = "0x1820C8E60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class KFABMIFCNKB : IEnumerable<(TKey, List<TKey>, EJNPDGGFBKP)>, IEnumerable, IEnumerator<(TKey, List<TKey>, EJNPDGGFBKP)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private (TKey key, List<TKey> path, EJNPDGGFBKP timerEntry) <>2__current;

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
		private LCHNHFGOJFL timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public LCHNHFGOJFL <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public global::JFIGLCAFHNI<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private IEnumerator<LCHNHFGOJFL> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private IEnumerator<(TKey key, List<TKey> path, EJNPDGGFBKP timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		private (TKey, List<TKey>, EJNPDGGFBKP) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x23D1550", Offset = "0x23CFF50", VA = "0x1823D1550", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, EJNPDGGFBKP));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x2416B60", Offset = "0x2415560", VA = "0x182416B60", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x23D1920", Offset = "0x23D0320", VA = "0x1823D1920")]
		[DebuggerHidden]
		public KFABMIFCNKB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x2416BC0", Offset = "0x24155C0", VA = "0x182416BC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x24164D0", Offset = "0x2414ED0", VA = "0x1824164D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x2416C60", Offset = "0x2415660", VA = "0x182416C60")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x2416CC0", Offset = "0x24156C0", VA = "0x182416CC0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x2416B20", Offset = "0x2415520", VA = "0x182416B20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x2416A10", Offset = "0x2415410", VA = "0x182416A10", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, EJNPDGGFBKP)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x2416AF0", Offset = "0x24154F0", VA = "0x182416AF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Action<TKey, EJNPDGGFBKP> BHOPLHPGHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Action<TKey, EJNPDGGFBKP> EMEBFHPNIIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly Action<global::JFIGLCAFHNI<TKey>> ONLGPAJECDO;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private const string NOBEFBKJDGE = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly LCHNHFGOJFL ILNBMMJEIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool KHOMFNMOLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private int BPPKENNEIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly Stopwatch ALBCGGNCPGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly int MPBPPKICEIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private string IBLMKKHICEO;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public LCHNHFGOJFL GGPCMOMMNKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6AEB10", Offset = "0x6AD510", VA = "0x1806AEB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	[NotNull]
	public string KAMEIBABLGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x6AFD80", Offset = "0x6AE780", VA = "0x1806AFD80")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x1C23950", Offset = "0x1C22350", VA = "0x181C23950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public long IAODMPKMMIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x1C23BB0", Offset = "0x1C225B0", VA = "0x181C23BB0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int NIDGJELEPHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x1C23BD0", Offset = "0x1C225D0", VA = "0x181C23BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x1C23C00", Offset = "0x1C22600", VA = "0x181C23C00")]
	public JFIGLCAFHNI(TKey HOAPFOGAJBP, [Optional] int? BLNBECLFKMO, [Optional][CanBeNull] Stopwatch ALBCGGNCPGG, [Optional] Action<TKey, EJNPDGGFBKP> BHOPLHPGHLK, [Optional] Action<TKey, EJNPDGGFBKP> EMEBFHPNIIO, [Optional] Action<global::JFIGLCAFHNI<TKey>> ONLGPAJECDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x1C238C0", Offset = "0x1C222C0", VA = "0x181C238C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x1C239B0", Offset = "0x1C223B0", VA = "0x181C239B0")]
	public void FMIHGPCNEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x1C238A0", Offset = "0x1C222A0", VA = "0x181C238A0")]
	public void BINKCANJMAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x1C23AA0", Offset = "0x1C224A0", VA = "0x181C23AA0")]
	[IteratorStateMachine(typeof(global::JFIGLCAFHNI<>.PDFLKAAKIPJ))]
	public IEnumerable<(TKey, List<TKey>, EJNPDGGFBKP)> HLNJOOJCJGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x1C239D0", Offset = "0x1C223D0", VA = "0x181C239D0")]
	[IteratorStateMachine(typeof(global::JFIGLCAFHNI<>.KFABMIFCNKB))]
	private IEnumerable<(TKey, List<TKey>, EJNPDGGFBKP)> HLNJOOJCJGD(List<TKey> EDPDIONNDAP, LCHNHFGOJFL ALADLDBICNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x1C23B30", Offset = "0x1C22530", VA = "0x181C23B30")]
	private (long, int) HPAEKPGPMKJ()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class JKABNAAPDEI<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut CHGPFGCADDK(global::JFIGLCAFHNI<TKey> GHKHAEFLPLO);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x7D07F0", Offset = "0x7CF1F0", VA = "0x1807D07F0")]
	protected JKABNAAPDEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class MAKIFHINGNN<TKey> : global::JKABNAAPDEI<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate string GDEBBFJCHPI(TKey KFEMFMGCJPM);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x3192ED0", Offset = "0x31918D0", VA = "0x183192ED0")]
	protected string KMGGMKHJPBM(double ADMKHPJAHKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x3192E30", Offset = "0x3191830", VA = "0x183192E30")]
	protected string FCMIPCEPOKA(int HJANAMECDOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x3192E90", Offset = "0x3191890", VA = "0x183192E90")]
	private static string FICPDALFOEJ(TKey KFEMFMGCJPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x3192C50", Offset = "0x3191650", VA = "0x183192C50", Slot = "4")]
	public override string CHGPFGCADDK(global::JFIGLCAFHNI<TKey> GHKHAEFLPLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x3192D00", Offset = "0x3191700", VA = "0x183192D00")]
	public string CHGPFGCADDK(global::JFIGLCAFHNI<TKey> GHKHAEFLPLO, [NotNull] GDEBBFJCHPI JJCDBGKBNGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string BFLFAIPIGHA(global::JFIGLCAFHNI<TKey> GHKHAEFLPLO, [NotNull] GDEBBFJCHPI JJCDBGKBNGI);

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x1C10D20", Offset = "0x1C0F720", VA = "0x181C10D20")]
	protected MAKIFHINGNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class GKJLOKDCNOG<TKey> : global::JKABNAAPDEI<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public delegate string OPJJALIDKNC(TKey KFEMFMGCJPM);

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private const int BHFJAKCFDIP = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly string FAGDBNMCCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly double IBEKDEDIKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly bool NFBGOPIIEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly int BMPDGMDGMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly ISet<string> LGICHBEGOCI;

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x2B0F2B0", Offset = "0x2B0DCB0", VA = "0x182B0F2B0")]
	private static string FICPDALFOEJ(TKey KFEMFMGCJPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x2B0F580", Offset = "0x2B0DF80", VA = "0x182B0F580")]
	public GKJLOKDCNOG(string FAGDBNMCCLK = "F2", double IBEKDEDIKAB = double.MaxValue, bool NFBGOPIIEKA = false, int BMPDGMDGMIF = int.MaxValue, [Optional] ISet<string> LGICHBEGOCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x2B0F200", Offset = "0x2B0DC00", VA = "0x182B0F200", Slot = "4")]
	public override Dictionary<string, string> CHGPFGCADDK(global::JFIGLCAFHNI<TKey> GHKHAEFLPLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x2B0F2F0", Offset = "0x2B0DCF0", VA = "0x182B0F2F0")]
	private bool GGJDBMPHDDK(string BIMNEHGEAKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x2B0ECC0", Offset = "0x2B0D6C0", VA = "0x182B0ECC0")]
	public Dictionary<string, string> CHGPFGCADDK(global::JFIGLCAFHNI<TKey> GHKHAEFLPLO, OPJJALIDKNC JJCDBGKBNGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x2B0F3D0", Offset = "0x2B0DDD0", VA = "0x182B0F3D0")]
	private string NCEKMPFPDPJ(StringBuilder CMPAAKNBMCE, List<TKey> LHGIKAHFHFD, OPJJALIDKNC JJCDBGKBNGI, bool LGIIHMNJKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x2B0EB40", Offset = "0x2B0D540", VA = "0x182B0EB40")]
	private static void BOJBGANNLCH(StringBuilder KAJHLFEFCNL, string IJDGNCMJDHN, bool HCMAOHPNKME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class CPANNJPAAGF<TKey> : global::MAKIFHINGNN<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct PKKHKJDOKIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public GDEBBFJCHPI keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static global::CPANNJPAAGF<TKey> BLPHKNHCNDJ;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private const int HLELFFCHIAL = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly string[] JEHDLANILGA;

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x22A6A50", Offset = "0x22A5450", VA = "0x1822A6A50")]
	private CPANNJPAAGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x22A5920", Offset = "0x22A4320", VA = "0x1822A5920", Slot = "5")]
	protected override string BFLFAIPIGHA(global::JFIGLCAFHNI<TKey> GHKHAEFLPLO, GDEBBFJCHPI JJCDBGKBNGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x22A6860", Offset = "0x22A5260", VA = "0x1822A6860")]
	[CompilerGenerated]
	internal static string PEOBDENLKEK(string PLKNPCHAPEB, TKey KFEMFMGCJPM, ref PKKHKJDOKIC P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class KFPPDMGILJJ<TKey> : global::MAKIFHINGNN<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class IFIGMABFPBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public GDEBBFJCHPI keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x7D07F0", Offset = "0x7CF1F0", VA = "0x1807D07F0")]
		public IFIGMABFPBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x1725190", Offset = "0x1723B90", VA = "0x181725190")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x2418700", Offset = "0x2417100", VA = "0x182418700", Slot = "5")]
	protected override string BFLFAIPIGHA(global::JFIGLCAFHNI<TKey> GHKHAEFLPLO, GDEBBFJCHPI JJCDBGKBNGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x1C12DD0", Offset = "0x1C117D0", VA = "0x181C12DD0")]
	public KFPPDMGILJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public sealed class HLNEBLCBAJI : global::JFIGLCAFHNI<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class KGJEDNEFBHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public Action<HLNEBLCBAJI> callback;

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public KGJEDNEFBHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x5E53470", Offset = "0x5E51E70", VA = "0x185E53470")]
		internal void <Wrap>b__0(global::JFIGLCAFHNI<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x5E51790", Offset = "0x5E50190", VA = "0x185E51790")]
	public HLNEBLCBAJI([Optional] string MABFBMGNCGB, [Optional] int? BLNBECLFKMO, [Optional] Stopwatch ALBCGGNCPGG, [Optional] Action<string, EJNPDGGFBKP> BHOPLHPGHLK, [Optional] Action<string, EJNPDGGFBKP> EMEBFHPNIIO, [Optional] Action<HLNEBLCBAJI> ONLGPAJECDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x5E516B0", Offset = "0x5E500B0", VA = "0x185E516B0")]
	private static Action<global::JFIGLCAFHNI<string>> BPHCGGFJBHI(Action<HLNEBLCBAJI> MLFGBBGKHEO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public abstract class LPDHILIFCGI
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private class MHHNDOMLBHK : LPDHILIFCGI
	{
		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public static LPDHILIFCGI BLPHKNHCNDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x5E54FC0", Offset = "0x5E539C0", VA = "0x185E54FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public override DateTime IONMLMFJHGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x5E55030", Offset = "0x5E53A30", VA = "0x185E55030", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public override float DMBHACHDKDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x5E55020", Offset = "0x5E53A20", VA = "0x185E55020", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x5E55120", Offset = "0x5E53B20", VA = "0x185E55120")]
		public MHHNDOMLBHK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static LPDHILIFCGI GNBIJMHDFLK;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static LPDHILIFCGI MHJMHHILEFG
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x5E54D40", Offset = "0x5E53740", VA = "0x185E54D40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public abstract DateTime IONMLMFJHGA
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public abstract float DMBHACHDKDL
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	protected LPDHILIFCGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class CILFBCDMPJJ : global::BJCJIHIABND<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x5E502C0", Offset = "0x5E4ECC0", VA = "0x185E502C0")]
	public CILFBCDMPJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class BJCJIHIABND<T> : global::OMCDEADEKKP<T>, FIDOMAHEGPC, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Task<T> FKIHDMGLDOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EB0", Offset = "0x6A38B0", VA = "0x1806A4EB0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private Task JDEPPPCNFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xC63980", Offset = "0xC62380", VA = "0x180C63980", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public global::LFIHKJLGIGB<T> HFBCDEFDEHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	private JFOAFMPHLMG COPFDEKBILC
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x19EB120", Offset = "0x19E9B20", VA = "0x1819EB120", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x25B8730", Offset = "0x25B7130", VA = "0x1825B8730")]
	public BJCJIHIABND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class MBJCKOMGNIA : global::HAJLBJMBICC<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x5E54F70", Offset = "0x5E53970", VA = "0x185E54F70")]
	public MBJCKOMGNIA(Exception OIBINBJMLDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class HAJLBJMBICC<T> : global::OMCDEADEKKP<T>, FIDOMAHEGPC, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public Task<T> FKIHDMGLDOE
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EB0", Offset = "0x6A38B0", VA = "0x1806A4EB0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	private Task JDEPPPCNFLI
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0xC63980", Offset = "0xC62380", VA = "0x180C63980", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public global::LFIHKJLGIGB<T> HFBCDEFDEHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	private JFOAFMPHLMG COPFDEKBILC
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x19EB120", Offset = "0x19E9B20", VA = "0x1819EB120", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x2666E10", Offset = "0x2665810", VA = "0x182666E10")]
	public HAJLBJMBICC(Exception OIBINBJMLDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface FIDOMAHEGPC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000069")]
	[NotNull]
	Task FKIHDMGLDOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	[NotNull]
	JFOAFMPHLMG HFBCDEFDEHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface OMCDEADEKKP<T> : FIDOMAHEGPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	[NotNull]
	new Task<T> FKIHDMGLDOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	[NotNull]
	new global::LFIHKJLGIGB<T> HFBCDEFDEHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public abstract class CPGFACBPALE<TTask, T> : global::OMCDEADEKKP<T>, FIDOMAHEGPC, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class JAKOJBPCAND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public global::CPGFACBPALE<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7D07F0", Offset = "0x7CF1F0", VA = "0x1807D07F0")]
		public JAKOJBPCAND()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static bool EOMKLIPFKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly Task<T> EFILJAJGOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	protected readonly CancellationTokenSource LOKGJLPIJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private bool KHOMFNMOLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private SynchronizationContext MFOJLBAJDKM;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Task<T> FKIHDMGLDOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EB0", Offset = "0x6A38B0", VA = "0x1806A4EB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	private Task JDEPPPCNFLI
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EB0", Offset = "0x6A38B0", VA = "0x1806A4EB0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public global::LFIHKJLGIGB<T> HFBCDEFDEHD
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	private JFOAFMPHLMG COPFDEKBILC
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x19F9130", Offset = "0x19F7B30", VA = "0x1819F9130", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool MMGCNOGJJID
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x799F80", Offset = "0x798980", VA = "0x180799F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x28D9B20", Offset = "0x28D8520", VA = "0x1828D9B20")]
	static CPGFACBPALE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x28D9C90", Offset = "0x28D8690", VA = "0x1828D9C90")]
	protected CPGFACBPALE(TTask EFILJAJGOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x28D98F0", Offset = "0x28D82F0", VA = "0x1828D98F0", Slot = "1")]
	~CPGFACBPALE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x28D98C0", Offset = "0x28D82C0", VA = "0x1828D98C0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x28D95E0", Offset = "0x28D7FE0", VA = "0x1828D95E0")]
	private void DMDPJFLHNDF(bool KDHHOOIHGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T BBIOBBDFFHB(TTask FKMPIAOONCE);

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void CLEJIDJMMBN();

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x28D9960", Offset = "0x28D8360", VA = "0x1828D9960")]
	[CompilerGenerated]
	private void GAKOLHLKGDJ(object HOCPDJAJOIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public interface DKIEPLBLNLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000072")]
	float LIEOIMBDBNP
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event KBHLABHOPOK ODEJPIHGIBI;
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class OBFGNGJNDGA : DKIEPLBLNLJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public readonly struct MNPOFIDGJCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public readonly float LOIIHJFIPMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public readonly float KEIPKFCBICO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		internal readonly bool CHKFJDOKALL;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public float NJPPBNLGLIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x5E55180", Offset = "0x5E53B80", VA = "0x185E55180")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x5E55310", Offset = "0x5E53D10", VA = "0x185E55310")]
		public MNPOFIDGJCM(float NJEPHEABALF, float AFPKKIJINFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x5E55190", Offset = "0x5E53B90", VA = "0x185E55190", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class JPMKFHPJBMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public OBFGNGJNDGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public JPMKFHPJBMN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly int CDECJIFLFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private int BBOAGHGFBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly DKIEPLBLNLJ[] KKPKNFJKHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly KBHLABHOPOK[] MGOGCFMPFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly MNPOFIDGJCM[] LANMOLPIPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private MNPOFIDGJCM EMNOMACDIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly GJDPCDJGBGH MBINHJNJMDA;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public MNPOFIDGJCM BHJELJAFJCH
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x27CBB40", Offset = "0x27CA540", VA = "0x1827CBB40")]
		get
		{
			return default(MNPOFIDGJCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float LIEOIMBDBNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x5E56500", Offset = "0x5E54F00", VA = "0x185E56500", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event KBHLABHOPOK ODEJPIHGIBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x5E56CF0", Offset = "0x5E556F0", VA = "0x185E56CF0", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x5E56570", Offset = "0x5E54F70", VA = "0x185E56570", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x5E56DB0", Offset = "0x5E557B0", VA = "0x185E56DB0")]
	public OBFGNGJNDGA(int CDECJIFLFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x5E56C60", Offset = "0x5E55660", VA = "0x185E56C60")]
	public GJDPCDJGBGH INNNNBLPHIB(MNPOFIDGJCM HGCLMOOEAJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x5E56810", Offset = "0x5E55210", VA = "0x185E56810")]
	public void FEOHGCFBECJ(DKIEPLBLNLJ BADKJBDNOLH, [Optional] MNPOFIDGJCM KEAEFHOGGBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x5E567C0", Offset = "0x5E551C0", VA = "0x185E567C0")]
	internal int FAPJKNPKKHA(DKIEPLBLNLJ ELDOFOIAHHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x5E56520", Offset = "0x5E54F20", VA = "0x185E56520")]
	internal MNPOFIDGJCM AJOHLAOLHFG(int NENMOOINMCH)
	{
		return default(MNPOFIDGJCM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x5E56630", Offset = "0x5E55030", VA = "0x185E56630", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public delegate void KBHLABHOPOK(float CLFBAOMLLGK);
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal static class AOGEJCNAPIL
{
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	internal const float PFOAEMCBGCI = 0.0001f;
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public static class FGIICDLJGHN
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private class DHBBDCLJCKC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private readonly DKIEPLBLNLJ ELDOFOIAHHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private readonly KBHLABHOPOK MLFGBBGKHEO;

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x5E50700", Offset = "0x5E4F100", VA = "0x185E50700")]
		public DHBBDCLJCKC(DKIEPLBLNLJ ELDOFOIAHHC, KBHLABHOPOK MLFGBBGKHEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x5E506B0", Offset = "0x5E4F0B0", VA = "0x185E506B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x5E50D30", Offset = "0x5E4F730", VA = "0x185E50D30")]
	internal static bool PEAAIONDCAE(float LDIEPFCHCFG, float KCHCODPDAGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x45D6450", Offset = "0x45D4E50", VA = "0x1845D6450")]
	internal static float HOLJAHMNLBC(float LDIEPFCHCFG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x5E50C70", Offset = "0x5E4F670", VA = "0x185E50C70")]
	public static IDisposable GKIKPHNHKND(this DKIEPLBLNLJ ELDOFOIAHHC, KBHLABHOPOK MLFGBBGKHEO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class GJDPCDJGBGH : DKIEPLBLNLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private float CLFBAOMLLGK;

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float LIEOIMBDBNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x6A5120", Offset = "0x6A3B20", VA = "0x1806A5120", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x5E50E90", Offset = "0x5E4F890", VA = "0x185E50E90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event KBHLABHOPOK ODEJPIHGIBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x5E50F50", Offset = "0x5E4F950", VA = "0x185E50F50", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x5E50DF0", Offset = "0x5E4F7F0", VA = "0x185E50DF0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public GJDPCDJGBGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public static class HIGNGJIMEEJ
{
	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x5E511F0", Offset = "0x5E4FBF0", VA = "0x185E511F0")]
	[NotNull]
	public static byte[] MGHAGBCFMJP(this KJKEKCCLIHO DIBANFPIHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x5E51180", Offset = "0x5E4FB80", VA = "0x185E51180")]
	[NotNull]
	public static byte[] MGHAGBCFMJP(this KJKEKCCLIHO DIBANFPIHNN, HashAlgorithmName GLBCCLBDIIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x5E51400", Offset = "0x5E4FE00", VA = "0x185E51400")]
	public static bool NFPPKPEENBJ([CanBeNull] this KJKEKCCLIHO DIBANFPIHNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x5E51260", Offset = "0x5E4FC60", VA = "0x185E51260")]
	public static bool NFPPKPEENBJ([CanBeNull] this KJKEKCCLIHO DIBANFPIHNN, out string HENMPJPHDDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x5E51110", Offset = "0x5E4FB10", VA = "0x185E51110")]
	private static string GIJDNKOJMCD([CanBeNull] byte[] GHEBPHBJKNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x5E50FF0", Offset = "0x5E4F9F0", VA = "0x185E50FF0")]
	private static bool AAGFHKNJKEP([NotNull] KJKEKCCLIHO DIBANFPIHNN, [CanBeNull] out byte[] AFBAHHDNMCI, [CanBeNull] out byte[] PAPJCLCELGB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class CGNOJBCLEMJ
{
	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x5E50280", Offset = "0x5E4EC80", VA = "0x185E50280")]
	[NotNull]
	public static byte[] MGHAGBCFMJP(this BICPEEPHPEF MIEJMBNKMEN, byte[] IKPCPHEOKJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x5E50050", Offset = "0x5E4EA50", VA = "0x185E50050")]
	[NotNull]
	public static byte[] MGHAGBCFMJP(this BICPEEPHPEF MIEJMBNKMEN, HashAlgorithmName GLBCCLBDIIH, byte[] IKPCPHEOKJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public interface BICPEEPHPEF
{
	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash FHKNDMKDLNF);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface KJKEKCCLIHO : BICPEEPHPEF
{
	[Cpp2IlInjected.Token(Token = "0x17000077")]
	[CanBeNull]
	byte[] IDDOMLJJNCO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	[CanBeNull]
	byte[] KPLOHNDFCKH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	UnityEngine.Object FJCPCAEKCDE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public static class IBIEIHIEEGP
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private class DIBPNJPKLFF : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x5E507F0", Offset = "0x5E4F1F0", VA = "0x185E507F0")]
		public DIBPNJPKLFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x5E50790", Offset = "0x5E4F190", VA = "0x185E50790", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private const byte OFNBLPHPPLJ = 1;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private const byte JHAGDDEFEJK = 0;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static readonly ArrayPool<byte> OOFENJMOPNA;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static bool IJDJFLLHHMH;

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x1D64D50", Offset = "0x1D63750", VA = "0x181D64D50")]
	[Conditional("UNITY_EDITOR")]
	private static void NNPEHEFJDEJ<T>(params T[] LOCMKFNPEFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x5E527A0", Offset = "0x5E511A0", VA = "0x185E527A0")]
	public static IDisposable KCOJFMDCNGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x5E528B0", Offset = "0x5E512B0", VA = "0x185E528B0")]
	public static void LMDJCPNEKNP(this IncrementalHash MLGIPANMEEC, [CanBeNull] GameObject OOAFGPFKNDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x1D64820", Offset = "0x1D63220", VA = "0x181D64820")]
	public static void LMDJCPNEKNP<T>(this IncrementalHash MLGIPANMEEC, [CanBeNull] T PAHLILOLPHD) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x1D64790", Offset = "0x1D63190", VA = "0x181D64790")]
	public static void LLAODPOMACD<T>(this IncrementalHash MLGIPANMEEC, [CanBeNull] T MIEJMBNKMEN) where T : BICPEEPHPEF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x1D648F0", Offset = "0x1D632F0", VA = "0x181D648F0")]
	public static void NCPFNDNAOPE<T>(this IncrementalHash MLGIPANMEEC, [CanBeNull] IList<T> BKLMOFMOBMF) where T : BICPEEPHPEF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x5E51F80", Offset = "0x5E50980", VA = "0x185E51F80")]
	private static bool DEEEGMMLCNE([CanBeNull] BICPEEPHPEF MIEJMBNKMEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x5E52010", Offset = "0x5E50A10", VA = "0x185E52010")]
	public static void EEJHHICEIEI(this IncrementalHash FHKNDMKDLNF, [CanBeNull] string OPCIIKDLGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x5E529A0", Offset = "0x5E513A0", VA = "0x185E529A0")]
	public static void MAGDKMGEJCI(this IncrementalHash FHKNDMKDLNF, long HONNBHOIIID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E51CE0", Offset = "0x5E506E0", VA = "0x185E51CE0")]
	public static void AJHGNGHBHIC(this IncrementalHash FHKNDMKDLNF, int OKIMBHHCMDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x5E52570", Offset = "0x5E50F70", VA = "0x185E52570")]
	public static void JIGOAPDDFNA(this IncrementalHash FHKNDMKDLNF, short BIBGKDLBIMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x5E52230", Offset = "0x5E50C30", VA = "0x185E52230")]
	public static void GHFPFEABIOP(this IncrementalHash FHKNDMKDLNF, byte AALCPCKNMJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x5E523A0", Offset = "0x5E50DA0", VA = "0x185E523A0")]
	public static void JGACIMIDOIG(this IncrementalHash FHKNDMKDLNF, bool NGDPHABCCLL, bool MBPAKODMICI = false, bool NODOCDDGHPE = false, bool GLNIMAMDKNI = false, bool GCPLIOMJMOP = false, bool KKIFMHEAHJD = false, bool LKHNNHMCAHM = false, bool POOGJLOHNIJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x1D640A0", Offset = "0x1D62AA0", VA = "0x181D640A0")]
	public static void ABOBHPEFELL<T>(this IncrementalHash FHKNDMKDLNF, T FPANNNNHFNG) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x5E51F20", Offset = "0x5E50920", VA = "0x185E51F20")]
	public static void CMOOIPDNCBL(this IncrementalHash FHKNDMKDLNF, float PPPFGEOBPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x5E52740", Offset = "0x5E51140", VA = "0x185E52740")]
	public static void JOGAOBENIIG(this IncrementalHash FHKNDMKDLNF, double OOBCJIAOHHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x5E51EB0", Offset = "0x5E508B0", VA = "0x185E51EB0")]
	public static void AOOBPCLFKDH(this IncrementalHash FHKNDMKDLNF, ulong BLKBAMDFIDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x5E51C80", Offset = "0x5E50680", VA = "0x185E51C80")]
	public static void AHALMDEAKKH(this IncrementalHash FHKNDMKDLNF, uint FLKFNNLPOIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x5E52840", Offset = "0x5E51240", VA = "0x185E52840")]
	public static void LJIPLEKIGAK(this IncrementalHash FHKNDMKDLNF, ushort KIOLCDENGKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x5E52B70", Offset = "0x5E51570", VA = "0x185E52B70")]
	public static void PFBMNILILKJ(this IncrementalHash FHKNDMKDLNF, Vector3 FEGMCEJHLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x5E52070", Offset = "0x5E50A70", VA = "0x185E52070")]
	public static void GEOOMKAPDBA(this IncrementalHash FHKNDMKDLNF, Quaternion GMKDMJEFPFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class FDDCPDNFOGI : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public readonly Type ONDMEHFIMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly string LLPKOEMOICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public readonly bool MLMGIKIEINK;

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x5E50C10", Offset = "0x5E4F610", VA = "0x185E50C10")]
	public FDDCPDNFOGI(Type MKOMOEKDCEA, string EHKGGDOJGIM, bool AAKDICINIME = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class FAFPBCDLLDC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x5E50BA0", Offset = "0x5E4F5A0", VA = "0x185E50BA0")]
	public FAFPBCDLLDC(string PJJGOJBLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x5E50B20", Offset = "0x5E4F520", VA = "0x185E50B20")]
	public FAFPBCDLLDC(string PJJGOJBLNDL, Exception CHGHPAOIAKG)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
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
			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x6983B0", Offset = "0x696DB0", VA = "0x1806983B0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x7DBB10", Offset = "0x7DA510", VA = "0x1807DBB10")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public T this[int JEBAMNOFEGN, int LHEEKHIELHG]
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x3078AC0", Offset = "0x30774C0", VA = "0x183078AC0")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x3078B60", Offset = "0x3077560", VA = "0x183078B60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x3078A30", Offset = "0x3077430", VA = "0x183078A30")]
		public Array2D(uint KAJKGOBCCGF, uint FOAFPMPLOCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x30789B0", Offset = "0x30773B0", VA = "0x1830789B0")]
		public void LCFMPIKHEBH()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x5E4FFF0", Offset = "0x5E4E9F0", VA = "0x185E4FFF0")]
		public Array2DVector3(uint KAJKGOBCCGF, uint FOAFPMPLOCB)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal static class IJFFFMLAJPG
{
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public const int HBDBIOPOONN = -1;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public const int OFEBEJHJMKI = 0;
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[DefaultMember("Item")]
public class FBHHCKKAPBO<THandle, TValue> : IDisposable where THandle : struct, AMGKOAKLCKE where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private readonly List<THandle> CGCONEFBPBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly List<TValue> NDJFILOEBCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly Func<TValue> EGHKBKAMMKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly Action<TValue> LLAJKLGMNBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private int IPLHCCFEFGN;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public TValue GMLDPDCPAEM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x1B54E90", Offset = "0x1B53890", VA = "0x181B54E90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x1B55060", Offset = "0x1B53A60", VA = "0x181B55060")]
	public FBHHCKKAPBO(Action<TValue> LLAJKLGMNBG, [Optional] Func<TValue> EGHKBKAMMKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x1B546E0", Offset = "0x1B530E0", VA = "0x181B546E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x1B544B0", Offset = "0x1B52EB0", VA = "0x181B544B0")]
	public THandle BJHKCBAGIGH()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x1B54DE0", Offset = "0x1B537E0", VA = "0x181B54DE0")]
	public THandle MJIKPLNABDE(TValue NKJMIDIDBOE)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x1B54EC0", Offset = "0x1B538C0", VA = "0x181B54EC0")]
	public bool OMBMHDCIFDM(THandle LGNELGFKAEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x1B54D10", Offset = "0x1B53710", VA = "0x181B54D10")]
	public bool LGJCJPODOEB(THandle LGNELGFKAEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x1B54880", Offset = "0x1B53280", VA = "0x181B54880")]
	public bool FJMGOOAKNCK(THandle LGNELGFKAEP, out TValue NKJMIDIDBOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x1B54690", Offset = "0x1B53090", VA = "0x181B54690")]
	public TValue DNANCALJAPO(THandle LGNELGFKAEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x1B54980", Offset = "0x1B53380", VA = "0x181B54980")]
	public bool HHAMBKOEDIN(THandle LGNELGFKAEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x1B55030", Offset = "0x1B53A30", VA = "0x181B55030")]
	private THandle PJKALBPKJHP(int NENMOOINMCH)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x1B54E60", Offset = "0x1B53860", VA = "0x181B54E60")]
	private TValue OBNJJMDABHD(int NENMOOINMCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x1B54F70", Offset = "0x1B53970", VA = "0x181B54F70")]
	private void PDAADEIJPBL(int NENMOOINMCH, in THandle LGNELGFKAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x1B54BB0", Offset = "0x1B535B0", VA = "0x181B54BB0")]
	private void JMGKCIJFKOF(int NENMOOINMCH, in TValue NKJMIDIDBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x1B54C00", Offset = "0x1B53600", VA = "0x181B54C00")]
	private THandle LFKNCGPEHHB()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x1B54B00", Offset = "0x1B53500", VA = "0x181B54B00")]
	private void JEGLOHBOMIA(THandle LGNELGFKAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x1B54BF0", Offset = "0x1B535F0", VA = "0x181B54BF0")]
	private int LBPFIIAMOEE(int FDLOHCDDBIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x1B54E50", Offset = "0x1B53850", VA = "0x181B54E50")]
	private bool NFCOLMCPHBL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0xAE73C0", Offset = "0xAE5DC0", VA = "0x180AE73C0")]
	private void GPINJNGFNIO(THandle LGNELGFKAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x1B54FB0", Offset = "0x1B539B0", VA = "0x181B54FB0")]
	private bool PEPKBJGANLD(out THandle LGNELGFKAEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x1B54A30", Offset = "0x1B53430", VA = "0x181B54A30")]
	private bool JBGIJCKAMNC(out THandle LGNELGFKAEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x1B54920", Offset = "0x1B53320", VA = "0x181B54920")]
	private void FPGKHOGHLOJ(THandle LGNELGFKAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x1B54760", Offset = "0x1B53160", VA = "0x181B54760")]
	private void EFDKGMACION()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public interface AMGKOAKLCKE
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	int HMIPEGLEEME
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	int MIEMBAEOINL
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public interface MDCCNADMIFA<T> : AMGKOAKLCKE, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class KPPALADDOLC
{
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x25E96F0", Offset = "0x25E80F0", VA = "0x1825E96F0")]
	public static bool OOFIFCCLGLC<T>(this T LGNELGFKAEP, T BPKBHFMGOOF) where T : struct, AMGKOAKLCKE
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x25E96E0", Offset = "0x25E80E0", VA = "0x1825E96E0")]
	public static bool CHKFJDOKALL<T>(this T LGNELGFKAEP) where T : struct, AMGKOAKLCKE
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x5E54530", Offset = "0x5E52F30", VA = "0x185E54530")]
	public static string OCJHCEOMDMD(this AMGKOAKLCKE LGNELGFKAEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class KKJFPDNJBDE
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private enum NKEDIDCCNCC : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private int FHKNDMKDLNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private bool IGOIKDLHJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private NKEDIDCCNCC LPLEHOMFOKG;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public bool PHKKCFBKMDE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x5E53980", Offset = "0x5E52380", VA = "0x185E53980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool IEJBCMEEAGL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x5E53A00", Offset = "0x5E52400", VA = "0x185E53A00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x5E54500", Offset = "0x5E52F00", VA = "0x185E54500")]
	public KKJFPDNJBDE(bool IGOIKDLHJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x5E53C80", Offset = "0x5E52680", VA = "0x185E53C80")]
	public void GEEJEKBCIMC(object PDHKCBEBPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x5E54300", Offset = "0x5E52D00", VA = "0x185E54300")]
	public void IADNEGFOBMJ(int NKJMIDIDBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x5E543F0", Offset = "0x5E52DF0", VA = "0x185E543F0")]
	public void LOMPANMAKDI(uint HMABADJNBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x5E54400", Offset = "0x5E52E00", VA = "0x185E54400")]
	public void NGFHANAKDCO(bool MNPIDGKHHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x5E53B10", Offset = "0x5E52510", VA = "0x185E53B10")]
	public void FNLAONEHJIN(long NCBEMLBLFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x5E543A0", Offset = "0x5E52DA0", VA = "0x185E543A0")]
	public void IGJJPHPLNGL(ulong AGOFHLKBCCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x5E54420", Offset = "0x5E52E20", VA = "0x185E54420")]
	public void NPIFGDLOMGM(string LGPJCGCMKAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x5E53A80", Offset = "0x5E52480", VA = "0x185E53A80")]
	public void EOMPOAGGJFO(Enum OIBINBJMLDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x5E53B50", Offset = "0x5E52550", VA = "0x185E53B50")]
	public void FPGKCHFBGBF(IList AMMGMIDPNEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x25E5490", Offset = "0x25E3E90", VA = "0x1825E5490")]
	public void GOCNMHCDMDO<T, U>(Dictionary<T, U> KOACBOJKGLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x5E53610", Offset = "0x5E52010", VA = "0x185E53610")]
	private void AAAAIMAEEGN(IDictionary KOACBOJKGLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x5E53A10", Offset = "0x5E52410", VA = "0x185E53A10")]
	public int DGOKKBLHLNK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x5E54490", Offset = "0x5E52E90", VA = "0x185E54490")]
	public short OBIGKGMICPM()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x5E543E0", Offset = "0x5E52DE0", VA = "0x185E543E0")]
	public void LCFMPIKHEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x5E53990", Offset = "0x5E52390", VA = "0x185E53990")]
	private void CFHFFLGIKMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public abstract class JFHLMPCINNM<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	internal class ACPFBHALPHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public TNode NMDJDCEFNDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public TNode EGNCPOLPGCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public MJPIMBAANOA IBIJJOHHONN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public List<MJPIMBAANOA> DHFBFGBGDNA;

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x7D07F0", Offset = "0x7CF1F0", VA = "0x1807D07F0")]
		public ACPFBHALPHJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	internal struct MJPIMBAANOA : IComparable<MJPIMBAANOA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public int NKLKLHAEGOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public TClaimant CNCNLFCGBBI;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xB64D40", Offset = "0xB63740", VA = "0x180B64D40")]
		public MJPIMBAANOA(int NKLKLHAEGOD, TClaimant CNCNLFCGBBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x1A8D100", Offset = "0x1A8BB00", VA = "0x181A8D100")]
		public bool IKHBKLAPGMP(in MJPIMBAANOA BPKBHFMGOOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x1A8D0F0", Offset = "0x1A8BAF0", VA = "0x181A8D0F0")]
		public bool FCCKKMLBPHI(in MJPIMBAANOA BPKBHFMGOOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x1A8D0E0", Offset = "0x1A8BAE0", VA = "0x181A8D0E0", Slot = "4")]
		public int CompareTo(MJPIMBAANOA BPKBHFMGOOF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x1A8D160", Offset = "0x1A8BB60", VA = "0x181A8D160", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public enum BICKBHJOLAB
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class EDIIIIJHIJL : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public global::JFHLMPCINNM<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x1A55B80", Offset = "0x1A54580", VA = "0x181A55B80")]
		[DebuggerHidden]
		public EDIIIIJHIJL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x36165F0", Offset = "0x3614FF0", VA = "0x1836165F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x36167B0", Offset = "0x36151B0", VA = "0x1836167B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x36166D0", Offset = "0x36150D0", VA = "0x1836166D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x17166E0", Offset = "0x17150E0", VA = "0x1817166E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly global::BOJONLOLBOA<ACPFBHALPHJ> GKAAGDFHELF;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly global::BOJONLOLBOA<List<MJPIMBAANOA>> NOGHLKDKKGH;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static int EPEPOCOKFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	internal readonly Dictionary<TClaimant, TNode> DFCDHPNFPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	internal readonly Dictionary<TNode, ACPFBHALPHJ> JJNPLFENEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private BICKBHJOLAB CCHMICPAKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private bool HHKBONGDECE;

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode INMLOHDEIIC(TNode CPEGANFPGPI);

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void MNEKCOJMIIN(TNode CPEGANFPGPI, TClaimant LDLPLCCMDHE, TClaimant CECHKGAJNHJ);

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x1C236E0", Offset = "0x1C220E0", VA = "0x181C236E0")]
	public JFHLMPCINNM(BICKBHJOLAB CCHMICPAKBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x1C221C0", Offset = "0x1C20BC0", VA = "0x181C221C0")]
	public void DAECKJLJODK(TNode CPEGANFPGPI, TNode CLJJCFEFLNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x1C22810", Offset = "0x1C21210", VA = "0x181C22810")]
	public void FGLENMMKOBN(TClaimant CNCNLFCGBBI, TNode GEIMHOFLJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x1C22240", Offset = "0x1C20C40", VA = "0x181C22240", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x1C21F90", Offset = "0x1C20990", VA = "0x181C21F90")]
	private void ANPHGEAHFBP(TClaimant CNCNLFCGBBI, TNode HMEDCCBPKFP, TNode GEIMHOFLJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x1C23410", Offset = "0x1C21E10", VA = "0x181C23410")]
	private int MJGKKPHONEF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x1C22910", Offset = "0x1C21310", VA = "0x181C22910")]
	private void HKMCGAFBOCC(TClaimant CNCNLFCGBBI, TNode LGHINCMNCIA, TNode HBDJLMFKBLF, int FEPBLOKAAON = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x1C231F0", Offset = "0x1C21BF0", VA = "0x181C231F0")]
	private void LOAGGDKNFKL(MJPIMBAANOA BBKNPODOHBO, ACPFBHALPHJ PGAEIMKMJEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x1C224A0", Offset = "0x1C20EA0", VA = "0x181C224A0")]
	private void EPFFHDBMHNI(TClaimant CNCNLFCGBBI, TNode LGHINCMNCIA, TNode HBDJLMFKBLF, int FEPBLOKAAON = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x1C23470", Offset = "0x1C21E70", VA = "0x181C23470")]
	private void OLHPANOIKJC(MJPIMBAANOA BBKNPODOHBO, TNode CPEGANFPGPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x1C230F0", Offset = "0x1C21AF0", VA = "0x181C230F0")]
	private void KAAPKBBEGFA(MJPIMBAANOA BBKNPODOHBO, ACPFBHALPHJ PGAEIMKMJEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x1C22700", Offset = "0x1C21100", VA = "0x181C22700")]
	private void FCPJOGINBGB(ACPFBHALPHJ PGAEIMKMJEI, bool LPADDMJJCBO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x1C22D80", Offset = "0x1C21780", VA = "0x181C22D80")]
	private void JHOFFGJBHID(ACPFBHALPHJ PGAEIMKMJEI, TNode CLJJCFEFLNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x1C22030", Offset = "0x1C20A30", VA = "0x181C22030")]
	[IteratorStateMachine(typeof(global::JFHLMPCINNM<, >.EDIIIIJHIJL))]
	private IEnumerable<TNode> APOHMLNCBAO(TNode LGHINCMNCIA, TNode HBDJLMFKBLF, bool ELBMPADOKOB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x1C22100", Offset = "0x1C20B00", VA = "0x181C22100")]
	private ACPFBHALPHJ BKIJFCLFJIO(TNode CPEGANFPGPI, TNode EGNCPOLPGCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x1C23280", Offset = "0x1C21C80", VA = "0x181C23280")]
	private ACPFBHALPHJ MGLGMIHPFAO(TNode CPEGANFPGPI, TNode EGNCPOLPGCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x1C22BC0", Offset = "0x1C215C0", VA = "0x181C22BC0")]
	private void ILBDHCOEIBE(ACPFBHALPHJ PGAEIMKMJEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public class CIIOIHDFIII<T> : IEnumerable<global::CIIOIHDFIII<T>.NGLFPLJDMCB>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public struct NGLFPLJDMCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public T NKJMIDIDBOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public int NENMOOINMCH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class CDHKJCKBMGG : IEnumerator<NGLFPLJDMCB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private global::CIIOIHDFIII<T> BINBGBCIPDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private int NENMOOINMCH;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x7CFB40", Offset = "0x7CE540", VA = "0x1807CFB40", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public NGLFPLJDMCB OLJIKHALPAK
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x21DCDE0", Offset = "0x21DB7E0", VA = "0x1821DCDE0", Slot = "4")]
			get
			{
				return default(NGLFPLJDMCB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x1CC6B40", Offset = "0x1CC5540", VA = "0x181CC6B40")]
		public CDHKJCKBMGG(global::CIIOIHDFIII<T> BINBGBCIPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x21DCCA0", Offset = "0x21DB6A0", VA = "0x1821DCCA0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xB90C70", Offset = "0xB8F670", VA = "0x180B90C70", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x8A3AA0", Offset = "0x8A24A0", VA = "0x1808A3AA0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	private struct HDJMCECDJKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public bool LCDBALCPFLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public T NKJMIDIDBOE;
	}

	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private const int KDGIIAKGDGN = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly Dictionary<T, int> GNBFOJPNDKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private HDJMCECDJKG[] ALLOPNAILGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private int IJFIIPFBBEE;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int ENOOOLPDLGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xA78EF0", Offset = "0xA778F0", VA = "0x180A78EF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x1004F30", Offset = "0x1003930", VA = "0x181004F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int OABDNEKKKBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x1638810", Offset = "0x1637210", VA = "0x181638810")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x228C970", Offset = "0x228B370", VA = "0x18228C970")]
	public CIIOIHDFIII(int CDECJIFLFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x228CA50", Offset = "0x228B450", VA = "0x18228CA50")]
	public CIIOIHDFIII(NGLFPLJDMCB[] LGNGGLCFNPH, bool LMKOBMIEEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x228BF70", Offset = "0x228A970", VA = "0x18228BF70")]
	public int GGHFIAPPPNE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x228BAC0", Offset = "0x228A4C0", VA = "0x18228BAC0")]
	private int FLHKOALIMIG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x228C550", Offset = "0x228AF50", VA = "0x18228C550", Slot = "6")]
	protected virtual uint LJCNMFHCHOH(uint FHKNDMKDLNF, T NKJMIDIDBOE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x228C5A0", Offset = "0x228AFA0", VA = "0x18228C5A0")]
	public bool LNADEAMMFJL(T NKJMIDIDBOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x228C680", Offset = "0x228B080", VA = "0x18228C680")]
	public bool NHKKEEFJKCC(int NENMOOINMCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x228B800", Offset = "0x228A200", VA = "0x18228B800")]
	public bool CLJNJIAEHOP(Func<T, bool> DOFNLMHADCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x228B6A0", Offset = "0x228A0A0", VA = "0x18228B6A0")]
	public int BOAFICCLJJD(T NKJMIDIDBOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x228C780", Offset = "0x228B180", VA = "0x18228C780")]
	public T OBNJJMDABHD(int NENMOOINMCH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x228C4A0", Offset = "0x228AEA0", VA = "0x18228C4A0")]
	public void LCFMPIKHEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x228C1E0", Offset = "0x228ABE0", VA = "0x18228C1E0")]
	public bool GIOPALFLCJI(T NKJMIDIDBOE, bool PHJADIFGFIE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x228BFE0", Offset = "0x228A9E0", VA = "0x18228BFE0")]
	public bool GIOPALFLCJI(T NKJMIDIDBOE, int NENMOOINMCH, bool PHJADIFGFIE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x228C860", Offset = "0x228B260", VA = "0x18228C860")]
	public bool OMBMHDCIFDM(T NKJMIDIDBOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x228C450", Offset = "0x228AE50", VA = "0x18228C450")]
	public bool JIOCFBKPOPN(int NENMOOINMCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x228B4D0", Offset = "0x2289ED0", VA = "0x18228B4D0")]
	private void ANFDLJHCCNH(int NENMOOINMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x228BE30", Offset = "0x228A830", VA = "0x18228BE30")]
	public NGLFPLJDMCB[] FNLPBIFGABO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x228C5E0", Offset = "0x228AFE0", VA = "0x18228C5E0")]
	private int NDLNNCIOFPD(int DAKLCPMDBMG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x228C8F0", Offset = "0x228B2F0", VA = "0x18228C8F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x228C8F0", Offset = "0x228B2F0", VA = "0x18228C8F0", Slot = "4")]
	private IEnumerator<NGLFPLJDMCB> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct HMFEHEODEFI<Handle> where Handle : AMGKOAKLCKE, new()
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private struct FIPICPDKKLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private readonly global::HMFEHEODEFI<Handle> AHHNHLOFGGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private int NENMOOINMCH;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public int EGGKAABGGPH
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x1DD7250", Offset = "0x1DD5C50", VA = "0x181DD7250")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public Handle KLIDMHOEMDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x1DD6FF0", Offset = "0x1DD59F0", VA = "0x181DD6FF0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7C50", Offset = "0x1DD6650", VA = "0x181DD7C50")]
		public FIPICPDKKLB(global::HMFEHEODEFI<Handle> AHHNHLOFGGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x1DD75F0", Offset = "0x1DD5FF0", VA = "0x181DD75F0")]
		public LMPEDJBLFNA NDGDIJBCNJC(in LMPEDJBLFNA FFJJMLKNOBA)
		{
			return default(LMPEDJBLFNA);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7550", Offset = "0x1DD5F50", VA = "0x181DD7550")]
		public PFJJCLMCOHH NDGDIJBCNJC(in PFJJCLMCOHH FFJJMLKNOBA)
		{
			return default(PFJJCLMCOHH);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7B30", Offset = "0x1DD6530", VA = "0x181DD7B30")]
		public bool NPAOPILPJKP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x1DD6A90", Offset = "0x1DD5490", VA = "0x181DD6A90")]
		private int HJJINDCEODI(string PJJGOJBLNDL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7730", Offset = "0x1DD6130", VA = "0x181DD7730")]
		private Handle NEJEEAPEHIB(string PJJGOJBLNDL)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public struct LMPEDJBLFNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private FIPICPDKKLB CHNFGIPJOHG;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public int OLJIKHALPAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x2744CA0", Offset = "0x27436A0", VA = "0x182744CA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x23E66D0", Offset = "0x23E50D0", VA = "0x1823E66D0")]
		public LMPEDJBLFNA(global::HMFEHEODEFI<Handle> AHHNHLOFGGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x23E6650", Offset = "0x23E5050", VA = "0x1823E6650")]
		public bool NPAOPILPJKP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x2744BE0", Offset = "0x27435E0", VA = "0x182744BE0")]
		public LMPEDJBLFNA ICBJEBDOHAE()
		{
			return default(LMPEDJBLFNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public struct PFJJCLMCOHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private FIPICPDKKLB CHNFGIPJOHG;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Handle OLJIKHALPAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x23E6550", Offset = "0x23E4F50", VA = "0x1823E6550")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x23E66D0", Offset = "0x23E50D0", VA = "0x1823E66D0")]
		public PFJJCLMCOHH(global::HMFEHEODEFI<Handle> AHHNHLOFGGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x23E6650", Offset = "0x23E5050", VA = "0x1823E6650")]
		public bool NPAOPILPJKP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x23E6450", Offset = "0x23E4E50", VA = "0x1823E6450")]
		public PFJJCLMCOHH ICBJEBDOHAE()
		{
			return default(PFJJCLMCOHH);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private NativeList<int> JLDIOHJPMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private NativeList<int> JPAIMPAELJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private int KMHLIDOKNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private int LLMACPOPCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private bool DMIOMEPIFKN;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool CIADPHNANDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x799F80", Offset = "0x798980", VA = "0x180799F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int KKMBALGBKLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x23D4E00", Offset = "0x23D3800", VA = "0x1823D4E00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int KDDCDGADMON
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x6E5670", Offset = "0x6E4070", VA = "0x1806E5670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int JNHBAFNIPDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x6E5670", Offset = "0x6E4070", VA = "0x1806E5670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public LMPEDJBLFNA EHJOBAMEEDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x23D7010", Offset = "0x23D5A10", VA = "0x1823D7010")]
		get
		{
			return default(LMPEDJBLFNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public PFJJCLMCOHH GOFAKMAHMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x23D4E80", Offset = "0x23D3880", VA = "0x1823D4E80")]
		get
		{
			return default(PFJJCLMCOHH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x23D7510", Offset = "0x23D5F10", VA = "0x1823D7510")]
	public HMFEHEODEFI(int AGPBFEDGALB, Allocator FAMNMGKAFPB = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x23D4260", Offset = "0x23D2C60", VA = "0x1823D4260")]
	public void DMDPJFLHNDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x80FA40", Offset = "0x80E440", VA = "0x18080FA40")]
	public static int LBPFIIAMOEE(int LNKDDMNNFGJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x23D72B0", Offset = "0x23D5CB0", VA = "0x1823D72B0")]
	public static bool PCMJGOOMPLB(int LNKDDMNNFGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x23D72C0", Offset = "0x23D5CC0", VA = "0x1823D72C0")]
	public static bool PKNOGIDCKLG(int LNKDDMNNFGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x23D4A20", Offset = "0x23D3420", VA = "0x1823D4A20")]
	public bool DNBGJAFPAMC(int NENMOOINMCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x23D3170", Offset = "0x23D1B70", VA = "0x1823D3170")]
	public bool AFIFOMCGPFF(int NENMOOINMCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x23D5A60", Offset = "0x23D4460", VA = "0x1823D5A60")]
	public bool KNKGNPAIHJE(Handle LGNELGFKAEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x23D3420", Offset = "0x23D1E20", VA = "0x1823D3420")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void CBJEJPGBEJO(Handle LGNELGFKAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x23D5F20", Offset = "0x23D4920", VA = "0x1823D5F20")]
	public Handle LDFPCLDKFOG()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x23D63E0", Offset = "0x23D4DE0", VA = "0x1823D63E0")]
	public void MHFPPMLFPMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x23D7130", Offset = "0x23D5B30", VA = "0x1823D7130")]
	public void PAOGIFGDAGC(Handle LGNELGFKAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x23D51E0", Offset = "0x23D3BE0", VA = "0x1823D51E0")]
	public bool ICIEMIDKDBB(Handle LGNELGFKAEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x799F80", Offset = "0x798980", VA = "0x180799F80")]
	private bool BFPILMLFKCJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x23D6380", Offset = "0x23D4D80", VA = "0x1823D6380")]
	private bool LDMOOCPFJPD(int NENMOOINMCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x23D54A0", Offset = "0x23D3EA0", VA = "0x1823D54A0")]
	private void JDPKBMPJLHH(out int NENMOOINMCH, out int FDLOHCDDBIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x23D44A0", Offset = "0x23D2EA0", VA = "0x1823D44A0")]
	private void DMIPDLNPDIN(Handle LGNELGFKAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x23D4150", Offset = "0x23D2B50", VA = "0x1823D4150")]
	private void DEFLDJGFFFI(int NENMOOINMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x23D5080", Offset = "0x23D3A80", VA = "0x1823D5080")]
	private bool HKDBJNPCAKH(out int NENMOOINMCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x23D3290", Offset = "0x23D1C90", VA = "0x1823D3290")]
	private static Handle AOAJBMGOCGJ(int NENMOOINMCH, int FDLOHCDDBIM)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[DefaultMember("Item")]
public struct ABDMDAMINJC<Handle, T> where Handle : AMGKOAKLCKE, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private global::HMFEHEODEFI<Handle> LDNFOIBJJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private T[] PFCCNKENCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private Action<T> NKCKENOCBCK;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool CIADPHNANDI
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x2E53930", Offset = "0x2E52330", VA = "0x182E53930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public int KKMBALGBKLD
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x2E53CD0", Offset = "0x2E526D0", VA = "0x182E53CD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public int OABDNEKKKBL
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x2E53960", Offset = "0x2E52360", VA = "0x182E53960")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public T GMLDPDCPAEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x2E561A0", Offset = "0x2E54BA0", VA = "0x182E561A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x2E56D20", Offset = "0x2E55720", VA = "0x182E56D20")]
	public ABDMDAMINJC(int AGPBFEDGALB, [Optional] Action<T> NKCKENOCBCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x2E53A20", Offset = "0x2E52420", VA = "0x182E53A20")]
	public void DMDPJFLHNDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x2E55850", Offset = "0x2E54250", VA = "0x182E55850")]
	public bool KNKGNPAIHJE(Handle LGNELGFKAEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void CBJEJPGBEJO(Handle LGNELGFKAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x2E53BD0", Offset = "0x2E525D0", VA = "0x182E53BD0")]
	public T DNANCALJAPO(Handle LGNELGFKAEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x2E54500", Offset = "0x2E52F00", VA = "0x182E54500")]
	public bool FJMGOOAKNCK(Handle LGNELGFKAEP, out T PDHKCBEBPNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x2E55AB0", Offset = "0x2E544B0", VA = "0x182E55AB0")]
	public void LMCGMFHIJLB(Handle LGNELGFKAEP, T BFKDFDABDAG, out T BJFDIELLGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x2E55990", Offset = "0x2E54390", VA = "0x182E55990")]
	public void LMCGMFHIJLB(Handle LGNELGFKAEP, T BFKDFDABDAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x2E53E80", Offset = "0x2E52880", VA = "0x182E53E80")]
	public bool FAKGIPPGMHD(Handle LGNELGFKAEP, T BFKDFDABDAG, out T BJFDIELLGFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x2E54140", Offset = "0x2E52B40", VA = "0x182E54140")]
	public bool FAKGIPPGMHD(Handle LGNELGFKAEP, T BFKDFDABDAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x2E55FA0", Offset = "0x2E549A0", VA = "0x182E55FA0")]
	public Handle MJIKPLNABDE(T PDHKCBEBPNG)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x2E547F0", Offset = "0x2E531F0", VA = "0x182E547F0")]
	public void HEKPPFBGEEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x2E56500", Offset = "0x2E54F00", VA = "0x182E56500")]
	public void OMBMHDCIFDM(Handle LGNELGFKAEP, out T BJFDIELLGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x2E56430", Offset = "0x2E54E30", VA = "0x182E56430")]
	public void OMBMHDCIFDM(Handle LGNELGFKAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x2E55630", Offset = "0x2E54030", VA = "0x182E55630")]
	public bool HMCKBFGFDDI(Handle LGNELGFKAEP, out T BJFDIELLGFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x2E55270", Offset = "0x2E53C70", VA = "0x182E55270")]
	public bool HMCKBFGFDDI(Handle LGNELGFKAEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x2E557F0", Offset = "0x2E541F0", VA = "0x182E557F0")]
	private T JIOCFBKPOPN(int NENMOOINMCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x2E56950", Offset = "0x2E55350", VA = "0x182E56950")]
	private void ONAECMHLPGP(int LLCJPPJIBIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public class BOJONLOLBOA<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Stack<T> AHHNHLOFGGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly List<T> BFDJKPCNHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly int CLBOEGGICNE;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public int PHEGKLAFMLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x1A8C3D0", Offset = "0x1A8ADD0", VA = "0x181A8C3D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int OGKIELJHECC
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x1A65F10", Offset = "0x1A64910", VA = "0x181A65F10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x1DE5EC0", Offset = "0x1DE48C0", VA = "0x181DE5EC0")]
	public static global::BOJONLOLBOA<T> AAAACIHAIOE(int CDECJIFLFKI = 0, int CLBOEGGICNE = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x1DE65E0", Offset = "0x1DE4FE0", VA = "0x181DE65E0")]
	public static global::BOJONLOLBOA<T> PJHAJAFJMBN(int CDECJIFLFKI = 0, int CLBOEGGICNE = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x1DE66B0", Offset = "0x1DE50B0", VA = "0x181DE66B0")]
	public BOJONLOLBOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x1DE66F0", Offset = "0x1DE50F0", VA = "0x181DE66F0")]
	public BOJONLOLBOA(int CDECJIFLFKI, int CLBOEGGICNE = int.MaxValue, bool FNDPELFDOGF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x1DE5F90", Offset = "0x1DE4990", VA = "0x181DE5F90")]
	public T AFEMDJLNONJ()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x1DE64A0", Offset = "0x1DE4EA0", VA = "0x181DE64A0")]
	public void NDOILGDBOAD(T NKJMIDIDBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x1DE63D0", Offset = "0x1DE4DD0", VA = "0x181DE63D0")]
	private void MEKABCBADMH(T NKJMIDIDBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x1DE6210", Offset = "0x1DE4C10", VA = "0x181DE6210")]
	private void KLFLIFGFBCF(T NKJMIDIDBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x1DE6190", Offset = "0x1DE4B90", VA = "0x181DE6190")]
	[Conditional("DEBUG_BUILD")]
	private void FMGLIIGMPDL(T LGFDBCHHHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x1DE6550", Offset = "0x1DE4F50", VA = "0x181DE6550")]
	[Conditional("DEBUG_BUILD")]
	private void OFMJDANODFC(T LGFDBCHHHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x1DE60A0", Offset = "0x1DE4AA0", VA = "0x181DE60A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x1DE6230", Offset = "0x1DE4C30", VA = "0x181DE6230")]
	private void LLFKHCFHJML(IEnumerable<T> NDJFILOEBCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class FAKCFDFIHLB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private Dictionary<int, T> GDPKGEAEOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private T CGLNOHEKKFC;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public virtual T OOGIFJFPIAI
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x6A4ED0", Offset = "0x6A38D0", VA = "0x1806A4ED0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool HBMGLBINGKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x1B53610", Offset = "0x1B52010", VA = "0x181B53610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x1B535B0", Offset = "0x1B51FB0", VA = "0x181B535B0")]
	public bool AMDGDCEIFKL(T NKJMIDIDBOE, int NKLKLHAEGOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x1B53650", Offset = "0x1B52050", VA = "0x181B53650")]
	public bool DEIALELIJGP(int NKLKLHAEGOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x1B53A50", Offset = "0x1B52450", VA = "0x181B53A50")]
	public T IGJIDDKHAIJ(int POEIHOGFJHH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x1B53C40", Offset = "0x1B52640", VA = "0x181B53C40")]
	public void LCFMPIKHEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x1B536B0", Offset = "0x1B520B0", VA = "0x181B536B0")]
	private bool GCAJHBINBNE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x1B53CA0", Offset = "0x1B526A0", VA = "0x181B53CA0")]
	public bool OHBNCLEBFJI(int NKLKLHAEGOD, out T NKJMIDIDBOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x1B53CD0", Offset = "0x1B526D0", VA = "0x181B53CD0")]
	public FAKCFDFIHLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public class BGCCBAJHOML<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	protected struct FOMAJPLBNLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public T EDONKBBONCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public int DPADGBLCMNH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	protected readonly List<FOMAJPLBNLB> PFPNEPOJCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private T MLLFDDJJPEA;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int OABDNEKKKBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x1638810", Offset = "0x1637210", VA = "0x181638810")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x25B6BB0", Offset = "0x25B55B0", VA = "0x1825B6BB0")]
	public bool CLJNJIAEHOP(T NKJMIDIDBOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x25B6F00", Offset = "0x25B5900", VA = "0x1825B6F00")]
	public void MJIKPLNABDE(T NKJMIDIDBOE, int NKLKLHAEGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x25B6FA0", Offset = "0x25B59A0", VA = "0x1825B6FA0")]
	public bool OMBMHDCIFDM(T NKJMIDIDBOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x25B6EA0", Offset = "0x25B58A0", VA = "0x1825B6EA0")]
	public void LCFMPIKHEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x25B6E30", Offset = "0x25B5830", VA = "0x1825B6E30")]
	public T KMIAJNOJLLF()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x25B6DC0", Offset = "0x25B57C0", VA = "0x1825B6DC0")]
	public T IOGBOJIDEEL()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x25B69F0", Offset = "0x25B53F0", VA = "0x1825B69F0")]
	private void CKPDBIOCNJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x25B70C0", Offset = "0x25B5AC0", VA = "0x1825B70C0")]
	public BGCCBAJHOML()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		[SerializeField]
		[OBEBELAGOGC(FDCMDMMJJJI.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x5E575C0", Offset = "0x5E55FC0", VA = "0x185E575C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x5E57950", Offset = "0x5E56350", VA = "0x185E57950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x5E577D0", Offset = "0x5E561D0", VA = "0x185E577D0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x5E57AB0", Offset = "0x5E564B0", VA = "0x185E57AB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x5E574E0", Offset = "0x5E55EE0", VA = "0x185E574E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x5E57870", Offset = "0x5E56270", VA = "0x185E57870")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x5E576F0", Offset = "0x5E560F0", VA = "0x185E576F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x5E57490", Offset = "0x5E55E90", VA = "0x185E57490")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public interface BGDELJLPHJK
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public abstract class ResourcePrefabReference<T> : BGDELJLPHJK where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x22BB050", Offset = "0x22B9A50", VA = "0x1822BB050", Slot = "4")]
		public virtual T HFFNNKNPFDL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x7D07F0", Offset = "0x7CF1F0", VA = "0x1807D07F0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class NHIDNPLCBIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private readonly Dictionary<byte, AMDOIMGFNFM> PBHNCLKLAKK;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public AMDOIMGFNFM CEOKGBFMGAE
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EB0", Offset = "0x6A38B0", VA = "0x1806A4EB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EA0", Offset = "0x6A38A0", VA = "0x1806A4EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector2 GIANPFNDCLE
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xF611E0", Offset = "0xF5FBE0", VA = "0x180F611E0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0xB261C0", Offset = "0xB24BC0", VA = "0x180B261C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector2 FPLGMGLEKFI
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x1731B90", Offset = "0x1730590", VA = "0x181731B90")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xC72660", Offset = "0xC71060", VA = "0x180C72660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector2 BMKMKELAEKO
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x5E56060", Offset = "0x5E54A60", VA = "0x185E56060")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xF4B050", Offset = "0xF49A50", VA = "0x180F4B050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int LNCJCFHLNGO
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xAE4570", Offset = "0xAE2F70", VA = "0x180AE4570")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0xAE73C0", Offset = "0xAE5DC0", VA = "0x180AE73C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x5E560A0", Offset = "0x5E54AA0", VA = "0x185E560A0")]
	public NHIDNPLCBIB(Bounds ILIBLGGECFL, Vector2[] CDJNMFADFGA, int DNHHDPGPEME, byte DAKLCPMDBMG, float EOAFLPFDJAM = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5E559A0", Offset = "0x5E543A0", VA = "0x185E559A0")]
	public AMDOIMGFNFM APMOOGNJPLA(byte NENMOOINMCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x5E55B60", Offset = "0x5E54560", VA = "0x185E55B60")]
	public void BFIHCBDFKID(Vector3 NHDHEIIIBBI, float BOFOJFJCADI, float NCLEIKDBHBH, ref List<byte> FBHGOGPAFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x5E56080", Offset = "0x5E54A80", VA = "0x185E56080")]
	public void MBPBCOJKLIF(AMDOIMGFNFM.IJFLCMALFBL BMFKFLPJLHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x5E55A00", Offset = "0x5E54400", VA = "0x185E55A00")]
	private AMDOIMGFNFM BAFMJNMECPM(byte NENMOOINMCH, AMDOIMGFNFM.IFHAOBMCEDN ECFBLHNMELH, AMDOIMGFNFM EGNCPOLPGCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x5E55C60", Offset = "0x5E54660", VA = "0x185E55C60")]
	private void GNHGHOPNIJC(AMDOIMGFNFM EGNCPOLPGCD, Vector2[] CDJNMFADFGA, int IOJGFKNEPHK, int DNJFJCAEPGA, int MIOIJGFLABC, int BGPBABMECLC, float EOAFLPFDJAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public class AMDOIMGFNFM
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public enum IFHAOBMCEDN
	{
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public enum IJFLCMALFBL
	{
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public byte PNNCAGKBOGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public Vector3 CIMLNHAINPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public Vector3 NJPPBNLGLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public Vector3 FAKIPDAIEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public Vector3 GKPJEBKBAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public IFHAOBMCEDN OHHNEJLAOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public AMDOIMGFNFM JGBBHLPMGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public List<AMDOIMGFNFM> IFOOKNKELFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public bool LGNDBJLCHOK;

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x5E4FFD0", Offset = "0x5E4E9D0", VA = "0x185E4FFD0")]
	public AMDOIMGFNFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x5E4FF70", Offset = "0x5E4E970", VA = "0x185E4FF70")]
	public AMDOIMGFNFM(byte ENFGKNDHLNI, IFHAOBMCEDN ECFBLHNMELH, AMDOIMGFNFM EGNCPOLPGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x5E4FE60", Offset = "0x5E4E860", VA = "0x185E4FE60")]
	public void HNICBHANMKL(AMDOIMGFNFM AHDACGEMPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
	public void MBPBCOJKLIF(int KMIJIFCGPMC, IJFLCMALFBL BMFKFLPJLHI, int OOGMNOBEJFA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x5E4FB70", Offset = "0x5E4E570", VA = "0x185E4FB70")]
	public void BFIHCBDFKID(List<byte> FBHGOGPAFIL, Vector3 NHDHEIIIBBI, float BOFOJFJCADI, float NCLEIKDBHBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x5E4FF20", Offset = "0x5E4E920", VA = "0x185E4FF20")]
	public bool HPECCFPJJBP(Vector3 OLLEMKHHKDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x5E4FE20", Offset = "0x5E4E820", VA = "0x185E4FE20")]
	public bool HDFCHAIIGOA(Vector3 OLLEMKHHKDM, float PBHOIHAKKCG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class DKMABJBIKEJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private readonly Dictionary<T, object> PILBCPPNLFL;

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x1725190", Offset = "0x1723B90", VA = "0x181725190")]
	public bool OBMIPDODLPG(T GDEJCOPCNNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x41C2F40", Offset = "0x41C1940", VA = "0x1841C2F40")]
	public bool OBMIPDODLPG(T GDEJCOPCNNE, object KBCPLDFOJJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x41C2EE0", Offset = "0x41C18E0", VA = "0x1841C2EE0")]
	public bool OBMIPDODLPG(T GDEJCOPCNNE, object KBCPLDFOJJL, out object OCDAAMLAEFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x41C2E60", Offset = "0x41C1860", VA = "0x1841C2E60")]
	public bool HFFMMHJBIOO(T GDEJCOPCNNE, object KBCPLDFOJJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x41C2EA0", Offset = "0x41C18A0", VA = "0x1841C2EA0")]
	public bool NCFJPMLMDAP(T GDEJCOPCNNE, object KBCPLDFOJJL, out object OCDAAMLAEFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x41C2DD0", Offset = "0x41C17D0", VA = "0x1841C2DD0")]
	public bool HFFMMHJBIOO(T GDEJCOPCNNE, object KBCPLDFOJJL, out object OCDAAMLAEFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x41C2F80", Offset = "0x41C1980", VA = "0x1841C2F80")]
	public void PEKBCIPGKEF(T GDEJCOPCNNE, object KBCPLDFOJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x41C2D30", Offset = "0x41C1730", VA = "0x1841C2D30")]
	public void CGICEGLFPIB(T GDEJCOPCNNE, object KBCPLDFOJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x41C2FB0", Offset = "0x41C19B0", VA = "0x1841C2FB0")]
	public DKMABJBIKEJ()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x20000AB")]
		public struct JPMJPHBGCPF<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			private readonly List<Component> AMMGMIDPNEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			private readonly bool EALHJDMPAPL;

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0xB13BF0", Offset = "0xB125F0", VA = "0x180B13BF0")]
			public JPMJPHBGCPF(List<Component> AMMGMIDPNEP, bool EALHJDMPAPL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x24053F0", Offset = "0x2403DF0", VA = "0x1824053F0")]
			public FLPCAPFIHHA<T> ICBJEBDOHAE()
			{
				return default(FLPCAPFIHHA<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x2405460", Offset = "0x2403E60", VA = "0x182405460", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x2405460", Offset = "0x2403E60", VA = "0x182405460", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AC")]
		public struct FLPCAPFIHHA<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			private readonly List<Component> AMMGMIDPNEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			private readonly bool EALHJDMPAPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			private int NENMOOINMCH;

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public T OLJIKHALPAK
			{
				[Cpp2IlInjected.Token(Token = "0x60003E1")]
				[Cpp2IlInjected.Address(RVA = "0x1DDF520", Offset = "0x1DDDF20", VA = "0x181DDF520", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003E2")]
				[Cpp2IlInjected.Address(RVA = "0x1DDF4B0", Offset = "0x1DDDEB0", VA = "0x181DDF4B0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x1DDF4F0", Offset = "0x1DDDEF0", VA = "0x181DDF4F0")]
			public FLPCAPFIHHA(List<Component> AMMGMIDPNEP, bool EALHJDMPAPL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x1DDF3F0", Offset = "0x1DDDDF0", VA = "0x181DDF3F0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x1DDF400", Offset = "0x1DDDE00", VA = "0x181DDF400", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x1A5CD70", Offset = "0x1A5B770", VA = "0x181A5CD70", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x5E59800", Offset = "0x5E58200", VA = "0x185E59800")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x5E597C0", Offset = "0x5E581C0", VA = "0x185E597C0")]
		public ToolHierarchyCache(GameObject HDDFHLGDPFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x5E593C0", Offset = "0x5E57DC0", VA = "0x185E593C0")]
		private void GICNDCMAEJH(GameObject HDDFHLGDPFJ, bool KPPPANMEOGF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x5E59330", Offset = "0x5E57D30", VA = "0x185E59330")]
		public static void GICNDCMAEJH(GameObject HDDFHLGDPFJ, ref ToolHierarchyCache LBCFFIBPFAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x5E592A0", Offset = "0x5E57CA0", VA = "0x185E592A0")]
		public void EKJMAOOKDBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x5E59620", Offset = "0x5E58020", VA = "0x185E59620")]
		public void MFGIDIOAFCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x272A350", Offset = "0x2728D50", VA = "0x18272A350")]
		public void DCIKGOBPDBG<T>(Action<T> LBPAPOGAAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x5E59670", Offset = "0x5E58070", VA = "0x185E59670")]
		public Component OGBMCGICKKF(Type NFMPIOLJBMO, bool EALHJDMPAPL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x272A6B0", Offset = "0x27290B0", VA = "0x18272A6B0")]
		public T OGBMCGICKKF<T>(bool EALHJDMPAPL = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x5E595A0", Offset = "0x5E57FA0", VA = "0x185E595A0")]
		public JPMJPHBGCPF<Component> HCFLCOCBFED(Type NFMPIOLJBMO, bool EALHJDMPAPL = false)
		{
			return default(JPMJPHBGCPF<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x272A5E0", Offset = "0x2728FE0", VA = "0x18272A5E0")]
		public JPMJPHBGCPF<T> HCFLCOCBFED<T>(bool EALHJDMPAPL = false) where T : class
		{
			return default(JPMJPHBGCPF<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x5E58F70", Offset = "0x5E57970", VA = "0x185E58F70")]
		public List<Component> BLACANEIMJL(Type NFMPIOLJBMO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x5E592B0", Offset = "0x5E57CB0", VA = "0x185E592B0", Slot = "4")]
		public bool Equals(ToolHierarchyCache GKGDNAPOGPF, ToolHierarchyCache JLKLDCLDEEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x5E59520", Offset = "0x5E57F20", VA = "0x185E59520", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache PDHKCBEBPNG)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public class PNHIHBJDAMJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private int CDECJIFLFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private int CKNMNKKBMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private List<T> BKLDDIKBPBA;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public int OABDNEKKKBL
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x1A8C3D0", Offset = "0x1A8ADD0", VA = "0x181A8C3D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public T APADFNANIAM
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x39FF470", Offset = "0x39FDE70", VA = "0x1839FF470")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public T PPOBEJNJDIM
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x39FF2D0", Offset = "0x39FDCD0", VA = "0x1839FF2D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public T BOIHJOGOBOB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x39FF230", Offset = "0x39FDC30", VA = "0x1839FF230")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x39FF730", Offset = "0x39FE130", VA = "0x1839FF730")]
	public PNHIHBJDAMJ(int CDECJIFLFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x39FF580", Offset = "0x39FDF80", VA = "0x1839FF580")]
	public void MJIKPLNABDE(T JFCOPCKANCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x39FF420", Offset = "0x39FDE20", VA = "0x1839FF420")]
	public void LCFMPIKHEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x39FF380", Offset = "0x39FDD80", VA = "0x1839FF380")]
	public void IJIAKJNJLFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x39FF330", Offset = "0x39FDD30", VA = "0x1839FF330")]
	public void HJLDDBMPHDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x39FF460", Offset = "0x39FDE60", VA = "0x1839FF460")]
	public void LCGPDALGIPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public class DEJNBOBEODH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private bool NGDDFBKLFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private Action LBPAPOGAAHD;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public static DEJNBOBEODH KONFIFAHDBE
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x5E50630", Offset = "0x5E4F030", VA = "0x185E50630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool DGLBIIJHPBN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x7DBB30", Offset = "0x7DA530", VA = "0x1807DBB30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x1E5EAA0", Offset = "0x1E5D4A0", VA = "0x181E5EAA0")]
	public DEJNBOBEODH(Action LBPAPOGAAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x5E50610", Offset = "0x5E4F010", VA = "0x185E50610")]
	public void MHGOHAICKEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x5E50610", Offset = "0x5E4F010", VA = "0x185E50610", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public static class IKGOKBLPEGB
{
	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x5E53130", Offset = "0x5E51B30", VA = "0x185E53130")]
	public static void IAGADFJECGG(OHIAKIMOJDN JMHNKLGJEJK, string PAGOJBHFOHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
	public static void IAGADFJECGG(IEnumerable<object> FPKBPOKFAHB, string PAGOJBHFOHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public class BLFNJIHKKEI<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private struct NGDPAPFGLPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public int DPADGBLCMNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public T EDONKBBONCD;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private readonly Dictionary<object, NGDPAPFGLPA> GDPKGEAEOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private readonly EqualityComparer<T> NCAKGPMCBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private T CGLNOHEKKFC;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public virtual T OOGIFJFPIAI
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x94F170", Offset = "0x94DB70", VA = "0x18094F170", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x2421CB0", Offset = "0x24206B0", VA = "0x182421CB0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool HBMGLBINGKA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x31040E0", Offset = "0x3102AE0", VA = "0x1831040E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public object JLEEGPJKJIC
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x6B0CF0", Offset = "0x6AF6F0", VA = "0x1806B0CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x7939F0", Offset = "0x7923F0", VA = "0x1807939F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x3103D50", Offset = "0x3102750", VA = "0x183103D50")]
	public bool AMDGDCEIFKL(T NKJMIDIDBOE, object KBCPLDFOJJL, int NKLKLHAEGOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x3104110", Offset = "0x3102B10", VA = "0x183104110")]
	public bool DEIALELIJGP(object KBCPLDFOJJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x3108290", Offset = "0x3106C90", VA = "0x183108290")]
	public bool OHBNCLEBFJI(object KBCPLDFOJJL, out T NKJMIDIDBOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x2417A60", Offset = "0x2416460", VA = "0x182417A60")]
	public void LCFMPIKHEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x31047A0", Offset = "0x31031A0", VA = "0x1831047A0")]
	private bool GCAJHBINBNE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x31088B0", Offset = "0x31072B0", VA = "0x1831088B0")]
	public BLFNJIHKKEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public class CMMKCCILOEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private Dictionary<object, float> GDPKGEAEOMB;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float OACODLHAMNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x6A5120", Offset = "0x6A3B20", VA = "0x1806A5120")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x1091880", Offset = "0x1090280", VA = "0x181091880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x5E50300", Offset = "0x5E4ED00", VA = "0x185E50300")]
	public void AMDGDCEIFKL(float NKJMIDIDBOE, object KBCPLDFOJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x5E50370", Offset = "0x5E4ED70", VA = "0x185E50370")]
	public void DEIALELIJGP(object KBCPLDFOJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x5E503E0", Offset = "0x5E4EDE0", VA = "0x185E503E0")]
	private void PEBHJKOODOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x5E50500", Offset = "0x5E4EF00", VA = "0x185E50500")]
	public CMMKCCILOEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public class KHIHBNHOKEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public readonly string FGCHEHPGGPC;

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x6B6EE0", Offset = "0x6B58E0", VA = "0x1806B6EE0")]
	public KHIHBNHOKEC(string BIHLJIGDBAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x5E53550", Offset = "0x5E51F50", VA = "0x185E53550")]
	public KHIHBNHOKEC(UnityEngine.Object JIOLDHOKFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x5E53500", Offset = "0x5E51F00", VA = "0x185E53500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public sealed class OHIAKIMOJDN
{
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class JBMFGKLDDAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public JBMFGKLDDAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x5E532B0", Offset = "0x5E51CB0", VA = "0x185E532B0")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private HashSet<object> FPKBPOKFAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private int AJLEEIKNCNJ;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public IReadOnlyCollection<object> NNJDOMAIMHE
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x5E57100", Offset = "0x5E55B00", VA = "0x185E57100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool JOCENPKCKJP
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x5E57000", Offset = "0x5E55A00", VA = "0x185E57000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public int OABDNEKKKBL
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x748B70", Offset = "0x747570", VA = "0x180748B70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x5E57010", Offset = "0x5E55A10", VA = "0x185E57010")]
	public bool MJIKPLNABDE(object KBCPLDFOJJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x5E571D0", Offset = "0x5E55BD0", VA = "0x185E571D0")]
	public bool OMBMHDCIFDM(object KBCPLDFOJJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x5E56F30", Offset = "0x5E55930", VA = "0x185E56F30")]
	public bool CLJNJIAEHOP(object KBCPLDFOJJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x5E56F90", Offset = "0x5E55990", VA = "0x185E56F90")]
	public void DNCDBMFIEKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x5E57270", Offset = "0x5E55C70", VA = "0x185E57270", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public OHIAKIMOJDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public class MAOMCDGAAJM<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	private struct FKNPDHDBFCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public float IIGAOICKELB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public T EDONKBBONCD;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private Dictionary<object, FKNPDHDBFCJ> GDPKGEAEOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private T GPHNCAACPNO;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public virtual T BMENHCJBHGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0xC3CF80", Offset = "0xC3B980", VA = "0x180C3CF80", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0xDCF130", Offset = "0xDCDB30", VA = "0x180DCF130", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public object PLCNFCEBODH
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x697FE0", Offset = "0x6969E0", VA = "0x180697FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x7939F0", Offset = "0x7923F0", VA = "0x1807939F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool HBMGLBINGKA
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x31935F0", Offset = "0x3191FF0", VA = "0x1831935F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x31934F0", Offset = "0x3191EF0", VA = "0x1831934F0")]
	public bool AMDGDCEIFKL(T NKJMIDIDBOE, object KBCPLDFOJJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x3193630", Offset = "0x3192030", VA = "0x183193630")]
	public bool DEIALELIJGP(object KBCPLDFOJJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x2417A60", Offset = "0x2416460", VA = "0x182417A60")]
	public void LCFMPIKHEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x3194CF0", Offset = "0x31936F0", VA = "0x183194CF0")]
	public bool OHBNCLEBFJI(object KBCPLDFOJJL, out T NKJMIDIDBOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x3194380", Offset = "0x3192D80", VA = "0x183194380")]
	private bool GCAJHBINBNE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x3194F60", Offset = "0x3193960", VA = "0x183194F60")]
	public MAOMCDGAAJM()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public class LHIPOBGMLKE
{
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private static byte[] PNBNOGIJBMC;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private static int DGEFGPNJFGJ;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private static int GBGLKCBJBIA;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static BigInteger EPCGLFJDNLL;

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public LHIPOBGMLKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x5E54710", Offset = "0x5E53110", VA = "0x185E54710")]
	private static string GKOJACPJHAL(byte[] KCHCODPDAGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x5E54820", Offset = "0x5E53220", VA = "0x185E54820")]
	public static string MEDIDALCMKC(byte[] GHEBPHBJKNK, bool FPEGHFMMINI)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x20000BA")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
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
