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
public class PPLOEFIENCI : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7A0100", Offset = "0x79F500", VA = "0x1807A0100")]
	public PPLOEFIENCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, HMNPLIJJNLD, BEELAICIKML, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x792A30", Offset = "0x791E30", VA = "0x180792A30", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x796850", Offset = "0x795C50", VA = "0x180796850", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x792A40", Offset = "0x791E40", VA = "0x180792A40", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x872DE0", Offset = "0x8721E0", VA = "0x180872DE0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash IJEJDFGCCLC);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x81D4D0", Offset = "0x81C8D0", VA = "0x18081D4D0")]
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
	[COKEKFPGOHF]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[COKEKFPGOHF]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5FE5580", Offset = "0x5FE4980", VA = "0x185FE5580")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5FE5540", Offset = "0x5FE4940", VA = "0x185FE5540")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5FE55C0", Offset = "0x5FE49C0", VA = "0x185FE55C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5FE5770", Offset = "0x5FE4B70", VA = "0x185FE5770")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5FE56E0", Offset = "0x5FE4AE0", VA = "0x185FE56E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8A0F70", Offset = "0x8A0370", VA = "0x1808A0F70")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x968470", Offset = "0x967870", VA = "0x180968470")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5FE5500", Offset = "0x5FE4900", VA = "0x185FE5500")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5FE5650", Offset = "0x5FE4A50", VA = "0x185FE5650")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5FE5130", Offset = "0x5FE4530", VA = "0x185FE5130")]
	public void CopyBounds(SavedExtents JLCJEDAFKJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5FE5450", Offset = "0x5FE4850", VA = "0x185FE5450")]
	public void SetLocalSpaceBounds(Bounds ADNAAGHHINB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x97C1D0", Offset = "0x97B5D0", VA = "0x18097C1D0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5FE5440", Offset = "0x5FE4840", VA = "0x185FE5440")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5FE4900", Offset = "0x5FE3D00", VA = "0x185FE4900")]
	private void ACJJLMCDOEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5FE5220", Offset = "0x5FE4620", VA = "0x185FE5220")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5FE4AC0", Offset = "0x5FE3EC0", VA = "0x185FE4AC0")]
	public static void CalculateLocalBoundsFor(GameObject IFGJJHCIEPA, [Out] Bounds ADNAAGHHINB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5FE5160", Offset = "0x5FE4560", VA = "0x185FE5160")]
	private static void IFHKKMHJGHD(Bounds BLEBDLHLENH, Color KGDDDEENGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5FE5470", Offset = "0x5FE4870", VA = "0x185FE5470")]
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
		[Cpp2IlInjected.Address(RVA = "0x78F180", Offset = "0x78E580", VA = "0x18078F180")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x79D9F0", Offset = "0x79CDF0", VA = "0x18079D9F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xDB76D0", Offset = "0xDB6AD0", VA = "0x180DB76D0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4260F90", Offset = "0x4260390", VA = "0x184260F90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "4")]
	public virtual void CCFLKONPDJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
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
	[PPLOEFIENCI]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4260B70", Offset = "0x425FF70", VA = "0x184260B70", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x425F810", Offset = "0x425EC10", VA = "0x18425F810", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4260EC0", Offset = "0x42602C0", VA = "0x184260EC0")]
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
	private sealed class ODMCLCLLDFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public ODMCLCLLDFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3F86A20", Offset = "0x3F85E20", VA = "0x183F86A20")]
		internal int FLJEJFCDFLH(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[PPLOEFIENCI]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x32FD720", Offset = "0x32FCB20", VA = "0x1832FD720", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x32FD770", Offset = "0x32FCB70", VA = "0x1832FD770", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x32FD620", Offset = "0x32FCA20", VA = "0x1832FD620", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey CONEAMPCFEL]
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x32FD6C0", Offset = "0x32FCAC0", VA = "0x1832FD6C0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x32FD500", Offset = "0x32FC900", VA = "0x1832FD500", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x32FD220", Offset = "0x32FC620", VA = "0x1832FD220", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x32FC6C0", Offset = "0x32FBAC0", VA = "0x1832FC6C0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x32FC630", Offset = "0x32FBA30", VA = "0x1832FC630", Slot = "14")]
	protected virtual string MDPKPEGGFBF(TKeyVal KLCGGOMOBHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x32FC540", Offset = "0x32FB940", VA = "0x1832FC540", Slot = "4")]
	public bool ContainsKey(TKey CONEAMPCFEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x32FD3C0", Offset = "0x32FC7C0", VA = "0x1832FD3C0", Slot = "5")]
	public bool TryGetValue(TKey CONEAMPCFEL, [Out] TVal PAHKKNONPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x32FC590", Offset = "0x32FB990", VA = "0x1832FC590", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x32FC590", Offset = "0x32FB990", VA = "0x1832FC590", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x32FD410", Offset = "0x32FC810", VA = "0x1832FD410")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class KCDCMKMMFHD<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class FKGNDACLJIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public FKGNDACLJIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x36B69F0", Offset = "0x36B5DF0", VA = "0x1836B69F0")]
		internal bool DKPDFFGAOHE(PJEPJKBJEFI<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float JKFOOFPMGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float LHJHOEMPEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<PJEPJKBJEFI<float, T>> MLBFJBOAMBE;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int EKBIFPCEHIH
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3B2B230", Offset = "0x3B2A630", VA = "0x183B2B230")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3B2BC80", Offset = "0x3B2B080", VA = "0x183B2BC80")]
	public KCDCMKMMFHD(float JPMDNDEMHBA, float AEMBACGOFGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3B2B310", Offset = "0x3B2A710", VA = "0x183B2B310")]
	public bool CDDJANEMLMA(float HKJHKEPHGIB, T PAHKKNONPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3B2B630", Offset = "0x3B2AA30", VA = "0x183B2B630")]
	public IEnumerable<T> DDCDAKHFEAI(float HKJHKEPHGIB, [Optional] float? LNDBDFHLACG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3B2BC50", Offset = "0x3B2B050", VA = "0x183B2BC50")]
	public void EKABOMHIFDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3B2B150", Offset = "0x3B2A550", VA = "0x183B2B150")]
	private void AGJHEAIBGHI(float HKJHKEPHGIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class KMGELJHIBHA<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct FICNHEILLMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T BFBAIKCHJBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float FGAALGIIBJH;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float ILPAEKBIMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> AFNMACFDMHG;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int EHJFFLAHCNN = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private FICNHEILLMJ[] CBCBEPHCJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int KDAPKNPNJKM;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float EFPGECLCNDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xB522E0", Offset = "0xB516E0", VA = "0x180B522E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xB52300", Offset = "0xB51700", VA = "0x180B52300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3B74A20", Offset = "0x3B73E20", VA = "0x183B74A20")]
	public KMGELJHIBHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3B74A40", Offset = "0x3B73E40", VA = "0x183B74A40")]
	public KMGELJHIBHA(int KKEOKHMHDHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3B73B40", Offset = "0x3B72F40", VA = "0x183B73B40")]
	public void DEAIBIAHPPK(float HKJHKEPHGIB, T PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3B74080", Offset = "0x3B73480", VA = "0x183B74080")]
	public void EKABOMHIFDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3B747C0", Offset = "0x3B73BC0", VA = "0x183B747C0")]
	public bool NHLAAJPINHH(float NLBCFDHNMGL, float LMJGJCAPHOP, [Out] T PAHKKNONPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3B73CC0", Offset = "0x3B730C0", VA = "0x183B73CC0")]
	public bool EEJJFBJHNOK(float NLBCFDHNMGL, float LMJGJCAPHOP, [Out] T PAHKKNONPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3B74260", Offset = "0x3B73660", VA = "0x183B74260")]
	public void FBAHAGAIGLF(float NLBCFDHNMGL, float LMJGJCAPHOP, List<T> NKGLIMPLOMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3B74050", Offset = "0x3B73450", VA = "0x183B74050")]
	private int EJEDOLFMJFP(int HPJDOKAJION)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3B744F0", Offset = "0x3B738F0", VA = "0x183B744F0")]
	private void FFBPFBBNEFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T JCGFKCLPPBH();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T PDJIIHOINMA(T PAHKKNONPEO, float DMIDIFJGAKP);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T DAOIFMCLKEI(T KKNFIGGNDFK, T PPBIBECNBNN);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T EHDNFPOBNFK(T KKNFIGGNDFK, T PPBIBECNBNN);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class GFDAFLNPDJP : KMGELJHIBHA<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7A0990", Offset = "0x79FD90", VA = "0x1807A0990", Slot = "4")]
	protected override Vector3 JCGFKCLPPBH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5FE1D90", Offset = "0x5FE1190", VA = "0x185FE1D90", Slot = "5")]
	protected override Vector3 PDJIIHOINMA(Vector3 PAHKKNONPEO, float DMIDIFJGAKP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5FE1CC0", Offset = "0x5FE10C0", VA = "0x185FE1CC0", Slot = "6")]
	protected override Vector3 DAOIFMCLKEI(Vector3 KKNFIGGNDFK, Vector3 PPBIBECNBNN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5FE1D10", Offset = "0x5FE1110", VA = "0x185FE1D10", Slot = "7")]
	protected override Vector3 EHDNFPOBNFK(Vector3 KKNFIGGNDFK, Vector3 PPBIBECNBNN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5FE1DD0", Offset = "0x5FE11D0", VA = "0x185FE1DD0")]
	public GFDAFLNPDJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class PHAIMHDKBAE
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x27981F0", Offset = "0x27975F0", VA = "0x1827981F0")]
	public static PJEPJKBJEFI<T1, T2> CNMCABBAMHK<T1, T2>(T1 KKCHMGCBPBI, T2 FPKDGLFPGGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2798270", Offset = "0x2797670", VA = "0x182798270")]
	public static HCDPNLMBIIP<T1, T2, T3> CNMCABBAMHK<T1, T2, T3>(T1 KKCHMGCBPBI, T2 FPKDGLFPGGL, T3 EDCCKELHKIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3E56EB0", Offset = "0x3E562B0", VA = "0x183E56EB0")]
	internal static int NGGPAICLDPI(int FFGCDCPIGBL, int CBNFJJELJMJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x544A560", Offset = "0x5449960", VA = "0x18544A560")]
	internal static int NGGPAICLDPI(int FFGCDCPIGBL, int CBNFJJELJMJ, int DIGDCCKCEED)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class PJEPJKBJEFI<T1, T2> : IComparable<PJEPJKBJEFI<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T1 NBBCKFAHONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T2 IHCBAEOEKNL;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x405AEC0", Offset = "0x405A2C0", VA = "0x18405AEC0")]
	public PJEPJKBJEFI(T1 KKCHMGCBPBI, T2 FPKDGLFPGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x40591F0", Offset = "0x40585F0", VA = "0x1840591F0", Slot = "4")]
	public int CompareTo(PJEPJKBJEFI<T1, T2> JLCJEDAFKJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x40599F0", Offset = "0x4058DF0", VA = "0x1840599F0", Slot = "0")]
	public override bool Equals(object JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x405A230", Offset = "0x4059630", VA = "0x18405A230", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x405A5F0", Offset = "0x40599F0", VA = "0x18405A5F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class HCDPNLMBIIP<T1, T2, T3> : IComparable<HCDPNLMBIIP<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T1 NBBCKFAHONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T2 IHCBAEOEKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly T3 EIPCDHBGABO;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3808330", Offset = "0x3807730", VA = "0x183808330")]
	public HCDPNLMBIIP(T1 KKCHMGCBPBI, T2 FPKDGLFPGGL, T3 EDCCKELHKIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x38079F0", Offset = "0x3806DF0", VA = "0x1838079F0", Slot = "4")]
	public int CompareTo(HCDPNLMBIIP<T1, T2, T3> JLCJEDAFKJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3807D80", Offset = "0x3807180", VA = "0x183807D80", Slot = "0")]
	public override bool Equals(object JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3807F30", Offset = "0x3807330", VA = "0x183807F30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3808060", Offset = "0x3807460", VA = "0x183808060", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T BFBAIKCHJBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2024EF0", Offset = "0x20242F0", VA = "0x182024EF0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2024E00", Offset = "0x2024200", VA = "0x182024E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float FLPHHFALDDO
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x81D5B0", Offset = "0x81C9B0", VA = "0x18081D5B0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4476830", Offset = "0x4475C30", VA = "0x184476830")]
	public T AKDCIAEMEIN(float DMIDIFJGAKP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4476A70", Offset = "0x4475E70", VA = "0x184476A70")]
	public T LLGAPEDJIOG(float DMIDIFJGAKP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T AGJNFHCGOMO(T KKNFIGGNDFK, T PPBIBECNBNN, float DMIDIFJGAKP);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5FE1C40", Offset = "0x5FE1040", VA = "0x185FE1C40", Slot = "4")]
	protected override float AGJNFHCGOMO(float KKNFIGGNDFK, float PPBIBECNBNN, float DMIDIFJGAKP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5FE1C80", Offset = "0x5FE1080", VA = "0x185FE1C80")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xC58120", Offset = "0xC57520", VA = "0x180C58120", Slot = "4")]
	protected override Vector3 AGJNFHCGOMO(Vector3 KKNFIGGNDFK, Vector3 PPBIBECNBNN, float DMIDIFJGAKP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5FE6480", Offset = "0x5FE5880", VA = "0x185FE6480")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5FE1120", Offset = "0x5FE0520", VA = "0x185FE1120", Slot = "4")]
	protected override Color AGJNFHCGOMO(Color KKNFIGGNDFK, Color PPBIBECNBNN, float DMIDIFJGAKP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5FE11E0", Offset = "0x5FE05E0", VA = "0x185FE11E0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FNIMJHNKMEM : PAAEEHDJNOM<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5FE1930", Offset = "0x5FE0D30", VA = "0x185FE1930")]
	public FNIMJHNKMEM(int BPEPAFIGLCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5FE18C0", Offset = "0x5FE0CC0", VA = "0x185FE18C0", Slot = "6")]
	protected override uint GMJFIINNEKG(uint IJEJDFGCCLC, string PAHKKNONPEO)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class FOHMIGAEBAK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly IDisposable OKALMGBNAPE;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public FOHMIGAEBAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct HNJEMBMNEDK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> AIBDBLHGKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int HCECCHOEHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int OMHJHADOPDC;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1D1A5B0", Offset = "0x1D199B0", VA = "0x181D1A5B0")]
	private HNJEMBMNEDK(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> FCIGKAJGACI, int DJOCNMCDIKA, int MPBLJIGCKLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3837440", Offset = "0x3836840", VA = "0x183837440")]
	public static HNJEMBMNEDK<T> PIJMMFMEPKL()
	{
		return default(HNJEMBMNEDK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3836180", Offset = "0x3835580", VA = "0x183836180")]
	public (int, int, Task<T>) FIEEDDKGKPI(int JAPMLPNPKOP, [Optional] CancellationToken HHHPDCGPCML, double PPLAIKBLALP = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x38370B0", Offset = "0x38364B0", VA = "0x1838370B0")]
	public void KDKFMKKODKG(int JAPMLPNPKOP, int MPBLJIGCKLO, [In] T APCONDCGDJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class LKOFLIDLCHJ
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5FE3590", Offset = "0x5FE2990", VA = "0x185FE3590")]
	public static HNJEMBMNEDK<JDDDAABNCFI> PIJMMFMEPKL()
	{
		return default(HNJEMBMNEDK<JDDDAABNCFI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5FE3510", Offset = "0x5FE2910", VA = "0x185FE3510")]
	public static void KDKFMKKODKG([In] this HNJEMBMNEDK<JDDDAABNCFI> LHCHBOKBAPK, int JAPMLPNPKOP, int MPBLJIGCKLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[DefaultMember("Item")]
public class LHDNFCLIBIN<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TKey, TVal> DMIDAKFNLFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly Dictionary<TVal, TKey> KCGOFIMKAKK;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int IGPGGFCOPJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3073330", Offset = "0x3072730", VA = "0x183073330", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool JMFGLNFGMFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ICollection<TKey> MPIHEDMFMMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x32B1410", Offset = "0x32B0810", VA = "0x1832B1410", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ICollection<TVal> DBCDJIFOCAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3C15580", Offset = "0x3C14980", VA = "0x183C15580", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TVal GDDPFDKAEND
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3C15520", Offset = "0x3C14920", VA = "0x183C15520", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3C155C0", Offset = "0x3C149C0", VA = "0x183C155C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey GDDPFDKAEND
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3C14A00", Offset = "0x3C13E00", VA = "0x183C14A00")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3C14800", Offset = "0x3C13C00", VA = "0x183C14800", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3C152B0", Offset = "0x3C146B0", VA = "0x183C152B0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3C147D0", Offset = "0x3C13BD0", VA = "0x183C147D0", Slot = "9")]
	public void Add(TKey CONEAMPCFEL, TVal PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3C14780", Offset = "0x3C13B80", VA = "0x183C14780", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> JCBFPBHHLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3C14860", Offset = "0x3C13C60", VA = "0x183C14860", Slot = "8")]
	public bool ContainsKey(TKey CONEAMPCFEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3C14900", Offset = "0x3C13D00", VA = "0x183C14900", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> JCBFPBHHLOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3C15220", Offset = "0x3C14620", VA = "0x183C15220", Slot = "10")]
	public bool Remove(TKey CONEAMPCFEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3C15250", Offset = "0x3C14650", VA = "0x183C15250", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> JCBFPBHHLOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3C153A0", Offset = "0x3C147A0", VA = "0x183C153A0", Slot = "11")]
	public bool TryGetValue(TKey CONEAMPCFEL, [Out] TVal PAHKKNONPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3C14A50", Offset = "0x3C13E50", VA = "0x183C14A50", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3C14930", Offset = "0x3C13D30", VA = "0x183C14930", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] CBCBEPHCJOP, int LNMJODKMHJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3C14BD0", Offset = "0x3C13FD0", VA = "0x183C14BD0")]
	public bool KDHJGKFFEEJ(TVal CONEAMPCFEL, [Out] TKey PAHKKNONPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3C14FC0", Offset = "0x3C143C0", VA = "0x183C14FC0")]
	private void NANJAPNPFBJ(TKey CONEAMPCFEL, TVal OFNBMJMBJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3C15060", Offset = "0x3C14460", VA = "0x183C15060")]
	private void NLBLKJAIHFG(TKey CONEAMPCFEL, TVal OFNBMJMBJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3C14DC0", Offset = "0x3C141C0", VA = "0x183C14DC0")]
	private bool KNJEJHMMHNE(TKey CONEAMPCFEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3C153E0", Offset = "0x3C147E0", VA = "0x183C153E0")]
	public LHDNFCLIBIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DefaultMember("Item")]
public class FDGBIIKLEDD<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private FDGBIIKLEDD<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x3345E80", Offset = "0x3345280", VA = "0x183345E80", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x334A410", Offset = "0x3349810", VA = "0x18334A410", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x334B480", Offset = "0x334A880", VA = "0x18334B480")]
		public Enumerator(FDGBIIKLEDD<T> NKGLIMPLOMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3346CC0", Offset = "0x33460C0", VA = "0x183346CC0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x3348AB0", Offset = "0x3347EB0", VA = "0x183348AB0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x3345FB0", Offset = "0x33453B0", VA = "0x183345FB0")]
		private void KNPFOHEIGDO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private T[] FIBPHGGLCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int PNHIOPPHDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int OAEPNHOINLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int IEOKPDEFBIP;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int IGPGGFCOPJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x364A890", Offset = "0x3649C90", VA = "0x18364A890")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T GDDPFDKAEND
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x3649830", Offset = "0x3648C30", VA = "0x183649830")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x364A6D0", Offset = "0x3649AD0", VA = "0x18364A6D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x364AB10", Offset = "0x3649F10", VA = "0x18364AB10")]
	public FDGBIIKLEDD(int BPEPAFIGLCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3649C00", Offset = "0x3649000", VA = "0x183649C00")]
	public void DEAIBIAHPPK(T DMIDIFJGAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x364A500", Offset = "0x3649900", VA = "0x18364A500")]
	public void EKABOMHIFDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3649180", Offset = "0x3648580", VA = "0x183649180")]
	public void AIPHNEPOGPB(int GNHCGOJHAJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x364A220", Offset = "0x3649620", VA = "0x18364A220")]
	public void EJNCEKGIGCG(T[] CBCBEPHCJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x364A7F0", Offset = "0x3649BF0", VA = "0x18364A7F0")]
	public Enumerator FPDPCEFPILF()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x364A950", Offset = "0x3649D50", VA = "0x18364A950", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x364A950", Offset = "0x3649D50", VA = "0x18364A950", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3649230", Offset = "0x3648630", VA = "0x183649230")]
	private int BNFAKOAAEIJ(int FGBBDGJMFEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x364A860", Offset = "0x3649C60", VA = "0x18364A860")]
	private int KKBDGBCGFMD(int FGBBDGJMFEH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class MKAGEIPJFCB<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Func<Internal, External> HDAIKGKMNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private IReadOnlyList<Internal> EPAFMCCJAFF;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public External GDDPFDKAEND
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x3E0C6E0", Offset = "0x3E0BAE0", VA = "0x183E0C6E0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int IGPGGFCOPJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3E0C690", Offset = "0x3E0BA90", VA = "0x183E0C690", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7967D0", Offset = "0x795BD0", VA = "0x1807967D0")]
	public MKAGEIPJFCB(Func<Internal, External> HDAIKGKMNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3E0C640", Offset = "0x3E0BA40", VA = "0x183E0C640")]
	public MKAGEIPJFCB(IReadOnlyList<Internal> EPAFMCCJAFF, Func<Internal, External> HDAIKGKMNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3E0C5C0", Offset = "0x3E0B9C0", VA = "0x183E0C5C0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x34BB1C0", Offset = "0x34BA5C0", VA = "0x1834BB1C0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class BDCFIAJLFPB<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate Task<TResult> KECAJIBAHNJ(TRequest MGFKAMLOFJH, CancellationToken HHHPDCGPCML);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public enum LLDKDKDPBMN
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class KKHDHMAOMOM
	{
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private const float MDNKNGEGENH = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TimeSpan PIHDDIPEJLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int HDFMLONEGFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public LLDKDKDPBMN AELCICIKOBH;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public static readonly KKHDHMAOMOM DBFALPAOJDK;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float CBOGGBHDELI
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x3B56680", Offset = "0x3B55A80", VA = "0x183B56680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TimeSpan LALPMJFAHME
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x793920", Offset = "0x792D20", VA = "0x180793920")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x3B566F0", Offset = "0x3B55AF0", VA = "0x183B566F0")]
		public KKHDHMAOMOM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private readonly struct OAAHAJMNJND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public readonly TRequest MGFKAMLOFJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public readonly CancellationToken HHHPDCGPCML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly TaskCompletionSource<TResult> HKIDIBCINJK;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3F774D0", Offset = "0x3F768D0", VA = "0x183F774D0")]
		public OAAHAJMNJND(TRequest MGFKAMLOFJH, TaskCompletionSource<TResult> HKIDIBCINJK, CancellationToken HHHPDCGPCML)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct BAFPBOLBKEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public BDCFIAJLFPB<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x46AC9A0", Offset = "0x46ABDA0", VA = "0x1846AC9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x46ACD80", Offset = "0x46AC180", VA = "0x1846ACD80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct CLKEPHDECPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public BDCFIAJLFPB<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private OAAHAJMNJND <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x4BB42D0", Offset = "0x4BB36D0", VA = "0x184BB42D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4BB48D0", Offset = "0x4BB3CD0", VA = "0x184BB48D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly CancellationTokenSource OAACFJLAIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly List<OAAHAJMNJND> CBFCNMODOEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly KKHDHMAOMOM BEIMBNOAAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly KECAJIBAHNJ NMNFEEALHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Task HPGFPKIHHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private int ODIBFCPCIPN;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x46C6F40", Offset = "0x46C6340", VA = "0x1846C6F40")]
	public BDCFIAJLFPB(KECAJIBAHNJ NMNFEEALHOE, [Optional] KKHDHMAOMOM BEIMBNOAAOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x46C5E10", Offset = "0x46C5210", VA = "0x1846C5E10")]
	public Task<TResult> DPHADMNBCDG(TRequest MGFKAMLOFJH, CancellationToken HHHPDCGPCML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x46C5920", Offset = "0x46C4D20", VA = "0x1846C5920")]
	private void DNIEKHEOEFM(OAAHAJMNJND GCOCEAFGOIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x46C5560", Offset = "0x46C4960", VA = "0x1846C5560")]
	[AsyncStateMachine(typeof(BDCFIAJLFPB<, >.BAFPBOLBKEL))]
	private Task CAEPMAHILFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x46C65A0", Offset = "0x46C59A0", VA = "0x1846C65A0")]
	private OAAHAJMNJND JHCJLDADCBK()
	{
		return default(OAAHAJMNJND);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x46C6BD0", Offset = "0x46C5FD0", VA = "0x1846C6BD0")]
	[AsyncStateMachine(typeof(BDCFIAJLFPB<, >.CLKEPHDECPN))]
	private Task KOOHBCACHPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x46C6130", Offset = "0x46C5530", VA = "0x1846C6130")]
	private void GIAADGNDEJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x46C6000", Offset = "0x46C5400", VA = "0x1846C6000", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[DefaultMember("Item")]
public class GLLELFELNJJ<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly List<T> EPAFMCCJAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private HashSet<T> PBEGIOEGBGD;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int IGPGGFCOPJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3073330", Offset = "0x3072730", VA = "0x183073330", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool JMFGLNFGMFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T GDDPFDKAEND
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x37BCB90", Offset = "0x37BBF90", VA = "0x1837BCB90", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x37BCBD0", Offset = "0x37BBFD0", VA = "0x1837BCBD0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x36E50A0", Offset = "0x36E44A0", VA = "0x1836E50A0", Slot = "11")]
	public void Add(T JCBFPBHHLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x37BC5F0", Offset = "0x37BB9F0", VA = "0x1837BC5F0")]
	public bool NCEOJDBHMGD(T JCBFPBHHLOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x37BC960", Offset = "0x37BBD60", VA = "0x1837BC960", Slot = "15")]
	public bool Remove(T JCBFPBHHLOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3781140", Offset = "0x3780540", VA = "0x183781140", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3614460", Offset = "0x3613860", VA = "0x183614460", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x37BC310", Offset = "0x37BB710", VA = "0x1837BC310", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x37BC370", Offset = "0x37BB770", VA = "0x1837BC370", Slot = "13")]
	public bool Contains(T JCBFPBHHLOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x37BC3B0", Offset = "0x37BB7B0", VA = "0x1837BC3B0", Slot = "14")]
	public void CopyTo(T[] CBCBEPHCJOP, int LNMJODKMHJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x37BC3E0", Offset = "0x37BB7E0", VA = "0x1837BC3E0", Slot = "6")]
	public int IndexOf(T JCBFPBHHLOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x37BC510", Offset = "0x37BB910", VA = "0x1837BC510", Slot = "7")]
	public void Insert(int FGBBDGJMFEH, T JCBFPBHHLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x37BC770", Offset = "0x37BBB70", VA = "0x1837BC770", Slot = "8")]
	public void RemoveAt(int FGBBDGJMFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x37BCAA0", Offset = "0x37BBEA0", VA = "0x1837BCAA0")]
	public GLLELFELNJJ()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x1E75900", Offset = "0x1E74D00", VA = "0x181E75900")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5FE5B10", Offset = "0x5FE4F10", VA = "0x185FE5B10")]
		public SerializedGuid([In] Guid EFNPBHMDENF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5FE59E0", Offset = "0x5FE4DE0", VA = "0x185FE59E0")]
		public static SerializedGuid MKOHBFEPLFM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5FE5960", Offset = "0x5FE4D60", VA = "0x185FE5960")]
		public static SerializedGuid FNPGNKENJGE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5FE5830", Offset = "0x5FE4C30", VA = "0x185FE5830")]
		public bool DCKNEPLMKNC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5FE5AE0", Offset = "0x5FE4EE0", VA = "0x185FE5AE0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5FE5A60", Offset = "0x5FE4E60", VA = "0x185FE5A60", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5FE5890", Offset = "0x5FE4C90", VA = "0x185FE5890", Slot = "7")]
		public bool Equals(SerializedGuid JLCJEDAFKJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5FE58D0", Offset = "0x5FE4CD0", VA = "0x185FE58D0", Slot = "0")]
		public override bool Equals(object DFFBALIDCLL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5FE59D0", Offset = "0x5FE4DD0", VA = "0x185FE59D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5FE5800", Offset = "0x5FE4C00", VA = "0x185FE5800", Slot = "6")]
		public int CompareTo(SerializedGuid JLCJEDAFKJL)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class GMOMDMBIJDN : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly Type PMIIMMKBNJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly string NNFBBHHKKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly bool NCNCCFPMMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly bool GNANECBHOLC;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5FE1E30", Offset = "0x5FE1230", VA = "0x185FE1E30")]
	public GMOMDMBIJDN(Type ILEDNGAEJNP, string CIICKANAJDH, bool FEAFEDGMPIE = false, bool GOINHIGKJFM = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class CMHFDFEDOCF<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public readonly struct LMOCBEFMENJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public readonly long GIKIHCLGCJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public readonly long INMJICDGIKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly int FNLLMDOJJJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly int HGCOGEDHBDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly bool FLNLBDENHAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly string NINOFAAKGOK;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3C3A5C0", Offset = "0x3C399C0", VA = "0x183C3A5C0")]
		public LMOCBEFMENJ(long GIKIHCLGCJM, int FNLLMDOJJJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3C3A630", Offset = "0x3C39A30", VA = "0x183C3A630")]
		public LMOCBEFMENJ(long GIKIHCLGCJM, long INMJICDGIKM, int FNLLMDOJJJK, int HGCOGEDHBDA, bool FLNLBDENHAC, string NINOFAAKGOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3C3A4B0", Offset = "0x3C398B0", VA = "0x183C3A4B0")]
		public int DBPEKLIGCIP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3C3A500", Offset = "0x3C39900", VA = "0x183C3A500")]
		public int KHICDKKGMKP(int KKDMKHCLOEN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3C3A450", Offset = "0x3C39850", VA = "0x183C3A450")]
		public double BNOPGFBKBAI()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3C3A520", Offset = "0x3C39920", VA = "0x183C3A520")]
		public LMOCBEFMENJ PLOHHKADBNB(long INMJICDGIKM, int HGCOGEDHBDA)
		{
			return default(LMOCBEFMENJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class NHIEDOHKMHG : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private struct PCIJDLLBHED<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public NHIEDOHKMHG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public Func<NHIEDOHKMHG, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private NHIEDOHKMHG <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x4047770", Offset = "0x4046B70", VA = "0x184047770", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x3B75300", Offset = "0x3B74700", VA = "0x183B75300", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly TKey EALKNHCDKOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly CMHFDFEDOCF<TKey> DBIAGNOCLNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly KBKFCGENGMC ADLBEINOKAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private List<NHIEDOHKMHG> INHEAIKFLJK;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string IAFDABNMKKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x3E92E50", Offset = "0x3E92250", VA = "0x183E92E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IEnumerable<NHIEDOHKMHG> PAEHHBBCFEO
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x3E93030", Offset = "0x3E92430", VA = "0x183E93030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public LMOCBEFMENJ KKLOBOIKIOF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x3E92FE0", Offset = "0x3E923E0", VA = "0x183E92FE0")]
			[CompilerGenerated]
			get
			{
				return default(LMOCBEFMENJ);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x3E93000", Offset = "0x3E92400", VA = "0x183E93000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3E93070", Offset = "0x3E92470", VA = "0x183E93070")]
		internal NHIEDOHKMHG(CMHFDFEDOCF<TKey> DBIAGNOCLNI, TKey CONEAMPCFEL, KBKFCGENGMC ADLBEINOKAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3E92E80", Offset = "0x3E92280", VA = "0x183E92E80")]
		public NHIEDOHKMHG GNCJILEBHEF(TKey CONEAMPCFEL, [Optional] KBKFCGENGMC? AJPHIHIMECC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x253D7C0", Offset = "0x253CBC0", VA = "0x18253D7C0")]
		[AsyncStateMachine(typeof(PCIJDLLBHED<>))]
		public Task<T> JPBHPLPHAEN<T>(TKey CONEAMPCFEL, Func<NHIEDOHKMHG, Task<T>> HHLGGDGPLKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3E92C50", Offset = "0x3E92050", VA = "0x183E92C50", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class EFGBCCACPFO : IEnumerable<(TKey, List<TKey>, LMOCBEFMENJ)>, IEnumerable, IEnumerator<(TKey, List<TKey>, LMOCBEFMENJ)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private (TKey key, List<TKey> path, LMOCBEFMENJ timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public CMHFDFEDOCF<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private IEnumerator<(TKey key, List<TKey> path, LMOCBEFMENJ timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, LMOCBEFMENJ) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x1E6DAB0", Offset = "0x1E6CEB0", VA = "0x181E6DAB0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, LMOCBEFMENJ));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x32B3130", Offset = "0x32B2530", VA = "0x1832B3130", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x1E6DBA0", Offset = "0x1E6CFA0", VA = "0x181E6DBA0")]
		[DebuggerHidden]
		public EFGBCCACPFO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x32B3190", Offset = "0x32B2590", VA = "0x1832B3190", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x32B2C00", Offset = "0x32B2000", VA = "0x1832B2C00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x32B2FA0", Offset = "0x32B23A0", VA = "0x1832B2FA0")]
		private void OPFNICOLGEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x32B30E0", Offset = "0x32B24E0", VA = "0x1832B30E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x32B2FF0", Offset = "0x32B23F0", VA = "0x1832B2FF0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, LMOCBEFMENJ)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x32B30B0", Offset = "0x32B24B0", VA = "0x1832B30B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class MINAADOKLBH : IEnumerable<(TKey, List<TKey>, LMOCBEFMENJ)>, IEnumerable, IEnumerator<(TKey, List<TKey>, LMOCBEFMENJ)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private (TKey key, List<TKey> path, LMOCBEFMENJ timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private NHIEDOHKMHG timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public NHIEDOHKMHG <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public CMHFDFEDOCF<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private IEnumerator<NHIEDOHKMHG> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private IEnumerator<(TKey key, List<TKey> path, LMOCBEFMENJ timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private (TKey, List<TKey>, LMOCBEFMENJ) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x1E6DAB0", Offset = "0x1E6CEB0", VA = "0x181E6DAB0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, LMOCBEFMENJ));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x3E0B470", Offset = "0x3E0A870", VA = "0x183E0B470", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x1E6DBA0", Offset = "0x1E6CFA0", VA = "0x181E6DBA0")]
		[DebuggerHidden]
		public MINAADOKLBH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3E0B4D0", Offset = "0x3E0A8D0", VA = "0x183E0B4D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3E0AB00", Offset = "0x3E09F00", VA = "0x183E0AB00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3E0B2B0", Offset = "0x3E0A6B0", VA = "0x183E0B2B0")]
		private void OPFNICOLGEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3E0AAA0", Offset = "0x3E09EA0", VA = "0x183E0AAA0")]
		private void JJCMEKBDGNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3E0B420", Offset = "0x3E0A820", VA = "0x183E0B420", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x3E0B310", Offset = "0x3E0A710", VA = "0x183E0B310", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, LMOCBEFMENJ)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3E0B3F0", Offset = "0x3E0A7F0", VA = "0x183E0B3F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly Action<TKey, LMOCBEFMENJ, KBKFCGENGMC> DNAJKELMEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly Action<TKey, LMOCBEFMENJ, KBKFCGENGMC> LMEOFNIFPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly Action<CMHFDFEDOCF<TKey>, KBKFCGENGMC> BALFNCKJDPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly KBKFCGENGMC ADLBEINOKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly NHIEDOHKMHG GMBOFDODNBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private bool ENCMOAFILAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private int MBAPNCHOFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Stopwatch MKFFMOIPFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public readonly int ABCFMIHFBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private string MHKMCDLLBPK;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public NHIEDOHKMHG MDOJFEBCGOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x793FD0", Offset = "0x7933D0", VA = "0x180793FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[NotNull]
	public string IAFDABNMKKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x792F30", Offset = "0x792330", VA = "0x180792F30")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x4BB5AD0", Offset = "0x4BB4ED0", VA = "0x184BB5AD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4BB5D10", Offset = "0x4BB5110", VA = "0x184BB5D10")]
	public CMHFDFEDOCF(TKey FPDKIPJOLNI, KBKFCGENGMC ADLBEINOKAL, [Optional] int? FNLLMDOJJJK, [Optional][CanBeNull] Stopwatch MKFFMOIPFPL, [Optional] Action<TKey, LMOCBEFMENJ, KBKFCGENGMC> DNAJKELMEMF, [Optional] Action<TKey, LMOCBEFMENJ, KBKFCGENGMC> LMEOFNIFPDE, [Optional] Action<CMHFDFEDOCF<TKey>, KBKFCGENGMC> BALFNCKJDPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4BB5A40", Offset = "0x4BB4E40", VA = "0x184BB5A40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4BB5C00", Offset = "0x4BB5000", VA = "0x184BB5C00")]
	[IteratorStateMachine(typeof(CMHFDFEDOCF<>.EFGBCCACPFO))]
	public IEnumerable<(TKey, List<TKey>, LMOCBEFMENJ)> EOBCIDIKCGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4BB5B30", Offset = "0x4BB4F30", VA = "0x184BB5B30")]
	[IteratorStateMachine(typeof(CMHFDFEDOCF<>.MINAADOKLBH))]
	private IEnumerable<(TKey, List<TKey>, LMOCBEFMENJ)> EOBCIDIKCGG(List<TKey> DEOINHDHAIA, NHIEDOHKMHG KIMPIOIMPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x4BB5C90", Offset = "0x4BB5090", VA = "0x184BB5C90")]
	private (long, int) GDLGKCJDJIP()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public abstract class IOKDPCMFPMF<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut EGINLJPMFJK(CMHFDFEDOCF<TKey> DBIAGNOCLNI);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	protected IOKDPCMFPMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public abstract class DFBOCAHCCFN<TKey> : IOKDPCMFPMF<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate string KNJCOHOLCHF(TKey CONEAMPCFEL);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x4F92A90", Offset = "0x4F91E90", VA = "0x184F92A90")]
	private static string OBKKLJMHNBO(TKey CONEAMPCFEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x4F92880", Offset = "0x4F91C80", VA = "0x184F92880", Slot = "4")]
	public override string EGINLJPMFJK(CMHFDFEDOCF<TKey> DBIAGNOCLNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x4F92940", Offset = "0x4F91D40", VA = "0x184F92940")]
	public string EGINLJPMFJK(CMHFDFEDOCF<TKey> DBIAGNOCLNI, [NotNull] KNJCOHOLCHF LFABAPEEHIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string DLGIOEJBOHN(CMHFDFEDOCF<TKey> DBIAGNOCLNI, [NotNull] KNJCOHOLCHF LFABAPEEHIH);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x392F210", Offset = "0x392E610", VA = "0x18392F210")]
	protected DFBOCAHCCFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class GKGNLOKKNAI<TKey> : IOKDPCMFPMF<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public delegate string GFJCPNHMGNE(TKey CONEAMPCFEL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly string BHLIDLHPLBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly double JDEPDFCAIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly bool FMGDFLFIOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly int OKFCMMMJHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly ISet<string> MOPCDIHMELK;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x37B4280", Offset = "0x37B3680", VA = "0x1837B4280")]
	private static string OBKKLJMHNBO(TKey CONEAMPCFEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x37B42C0", Offset = "0x37B36C0", VA = "0x1837B42C0")]
	public GKGNLOKKNAI(string BHLIDLHPLBB = "F2", double JDEPDFCAIFI = double.MaxValue, bool FMGDFLFIOCE = false, int OKFCMMMJHEI = int.MaxValue, [Optional] ISet<string> MOPCDIHMELK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x37B3990", Offset = "0x37B2D90", VA = "0x1837B3990", Slot = "4")]
	public override Dictionary<string, string> EGINLJPMFJK(CMHFDFEDOCF<TKey> DBIAGNOCLNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x37B38B0", Offset = "0x37B2CB0", VA = "0x1837B38B0")]
	private bool CAKDOIKEOOE(string AFCNIBPAPOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x37B3A50", Offset = "0x37B2E50", VA = "0x1837B3A50")]
	public Dictionary<string, string> EGINLJPMFJK(CMHFDFEDOCF<TKey> DBIAGNOCLNI, GFJCPNHMGNE LFABAPEEHIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x37B4040", Offset = "0x37B3440", VA = "0x1837B4040")]
	private string GEHDCKHBGLO(StringBuilder KIGCIOFFGFI, List<TKey> KMAPKGJIGHB, GFJCPNHMGNE LFABAPEEHIH, bool KCDCPJHIFLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x37B3750", Offset = "0x37B2B50", VA = "0x1837B3750")]
	private static void BAGHEFJOILG(StringBuilder FKIAENMMGOP, string KCENENIKJAN, bool DBIKOALGFAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class JLBGEFEHPHD<TKey> : DFBOCAHCCFN<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct NDKKFEHHOLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public KNJCOHOLCHF keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static JLBGEFEHPHD<TKey> OKALMGBNAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly string[] JIMPGFOONDM;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3ADA240", Offset = "0x3AD9640", VA = "0x183ADA240")]
	private JLBGEFEHPHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3AD9140", Offset = "0x3AD8540", VA = "0x183AD9140", Slot = "5")]
	protected override string DLGIOEJBOHN(CMHFDFEDOCF<TKey> DBIAGNOCLNI, KNJCOHOLCHF LFABAPEEHIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3ADA010", Offset = "0x3AD9410", VA = "0x183ADA010")]
	[CompilerGenerated]
	internal static string MGLCKOJJFND(string LLDKMDNCHOA, TKey CONEAMPCFEL, NDKKFEHHOLO P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class DDLBNAOMFPB : CMHFDFEDOCF<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class KBHIIFEHFHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Action<DDLBNAOMFPB, KBKFCGENGMC> callback;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public KBHIIFEHFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5FE2520", Offset = "0x5FE1920", VA = "0x185FE2520")]
		internal void MCGFLMDEGOJ(CMHFDFEDOCF<string> timer, KBKFCGENGMC log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5FE12E0", Offset = "0x5FE06E0", VA = "0x185FE12E0")]
	public DDLBNAOMFPB(KBKFCGENGMC ADLBEINOKAL, [Optional] string HHKIMGHMAFB, [Optional] int? FNLLMDOJJJK, [Optional] Stopwatch MKFFMOIPFPL, [Optional] Action<string, LMOCBEFMENJ, KBKFCGENGMC> DNAJKELMEMF, [Optional] Action<string, LMOCBEFMENJ, KBKFCGENGMC> LMEOFNIFPDE, [Optional] Action<DDLBNAOMFPB, KBKFCGENGMC> BALFNCKJDPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5FE1220", Offset = "0x5FE0620", VA = "0x185FE1220")]
	private static Action<CMHFDFEDOCF<string>, KBKFCGENGMC> KDGCJGCAJBM(Action<DDLBNAOMFPB, KBKFCGENGMC> COPFOFGFOAL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public abstract class AJJFEBNNGKK
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private class HIHGNHFPIOO : AJJFEBNNGKK
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static AJJFEBNNGKK OKALMGBNAPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x5FE1EA0", Offset = "0x5FE12A0", VA = "0x185FE1EA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override float IDPGMECDFGG
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x1CF04B0", Offset = "0x1CEF8B0", VA = "0x181CF04B0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x5FE1FA0", Offset = "0x5FE13A0", VA = "0x185FE1FA0")]
		public HIHGNHFPIOO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static AJJFEBNNGKK KDHAJGKIDOP;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static AJJFEBNNGKK DBFALPAOJDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0FB0", Offset = "0x5FE03B0", VA = "0x185FE0FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public abstract float IDPGMECDFGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	protected AJJFEBNNGKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class CFJIPDDBOFM<T> : KGDNCOOHBFB<T> where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public override Task<T> BNHODFLCFCA
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public override BIDJOPNIEEO<T> PEGKPMIADNF
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x796850", Offset = "0x795C50", VA = "0x180796850", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x49CC780", Offset = "0x49CBB80", VA = "0x1849CC780")]
	public CFJIPDDBOFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "10")]
	protected override void MAGIBGLJIBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class ADLIFHHOAMA<T> : KGDNCOOHBFB<T> where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public override Task<T> BNHODFLCFCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public override BIDJOPNIEEO<T> PEGKPMIADNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x796850", Offset = "0x795C50", VA = "0x180796850", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3723CB0", Offset = "0x37230B0", VA = "0x183723CB0")]
	public ADLIFHHOAMA(Exception CFJCPBMIHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "10")]
	protected override void MAGIBGLJIBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface KDJMNIAMELP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool NABJPIJAAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface ILOEBLPKELJ<T> : KDJMNIAMELP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	[NotNull]
	Task<T> BNHODFLCFCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	[NotNull]
	BIDJOPNIEEO<T> PEGKPMIADNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public abstract class KGDNCOOHBFB<T> : ILOEBLPKELJ<T>, KDJMNIAMELP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly FNFBFDKENLK IBLPAMDJCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private bool ENCMOAFILAH;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool NABJPIJAAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x97ED20", Offset = "0x97E120", VA = "0x18097ED20", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public abstract Task<T> BNHODFLCFCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public abstract BIDJOPNIEEO<T> PEGKPMIADNF
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3B37550", Offset = "0x3B36950", VA = "0x183B37550")]
	public KGDNCOOHBFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x3B373D0", Offset = "0x3B367D0", VA = "0x183B373D0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void MAGIBGLJIBG();
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public abstract class FDOPDBKJEJA<TTask, T> : KGDNCOOHBFB<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class NIJJBPCDKMF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public NIJJBPCDKMF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x3063430", Offset = "0x3062830", VA = "0x183063430", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x30639D0", Offset = "0x3062DD0", VA = "0x1830639D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public FDOPDBKJEJA<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public NIJJBPCDKMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x3E9B550", Offset = "0x3E9A950", VA = "0x183E9B550")]
		[AsyncStateMachine(typeof(FDOPDBKJEJA<, >.NIJJBPCDKMF.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> CBHIBPOMNMD(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly Task<T> ADFIKOFONEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	protected readonly CancellationTokenSource BPEHJEDJCHB;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public override Task<T> BNHODFLCFCA
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public override BIDJOPNIEEO<T> PEGKPMIADNF
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x796850", Offset = "0x795C50", VA = "0x180796850", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x364B830", Offset = "0x364AC30", VA = "0x18364B830")]
	protected FDOPDBKJEJA(TTask ADFIKOFONEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x364B4A0", Offset = "0x364A8A0", VA = "0x18364B4A0", Slot = "10")]
	protected override void MAGIBGLJIBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T LENGPFNOBJC(TTask ADPBGDELHKL);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void DDANGDLIKOG();
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class BGIHIKMJGPI<T> : KGDNCOOHBFB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly LPCLHFEGNKE<Task<T>> OKOICHAEMAB;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public override Task<T> BNHODFLCFCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x32B36E0", Offset = "0x32B2AE0", VA = "0x1832B36E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public override BIDJOPNIEEO<T> PEGKPMIADNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x796850", Offset = "0x795C50", VA = "0x180796850", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x47097F0", Offset = "0x4708BF0", VA = "0x1847097F0")]
	public BGIHIKMJGPI(LPCLHFEGNKE<Task<T>> DNJHPIILGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x47097D0", Offset = "0x4708BD0", VA = "0x1847097D0", Slot = "10")]
	protected override void MAGIBGLJIBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class HJDJKNKNENE
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5FE1FF0", Offset = "0x5FE13F0", VA = "0x185FE1FF0")]
	[NotNull]
	public static byte[] AMENLDIBJHL(this HMNPLIJJNLD DALMBFFFKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5FE2060", Offset = "0x5FE1460", VA = "0x185FE2060")]
	[NotNull]
	public static byte[] AMENLDIBJHL(this HMNPLIJJNLD DALMBFFFKAN, HashAlgorithmName LGFEBBDLJBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5FE20D0", Offset = "0x5FE14D0", VA = "0x185FE20D0")]
	public static bool BOBBPHNNGCD([CanBeNull] this HMNPLIJJNLD DALMBFFFKAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5FE2260", Offset = "0x5FE1660", VA = "0x185FE2260")]
	public static bool BOBBPHNNGCD([CanBeNull] this HMNPLIJJNLD DALMBFFFKAN, [Out] string HNINMPIFBCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5FE2400", Offset = "0x5FE1800", VA = "0x185FE2400")]
	private static bool KJDPJLCCALO([NotNull] HMNPLIJJNLD DALMBFFFKAN, [Out][CanBeNull] byte[] PMNHOCPLCBP, [Out][CanBeNull] byte[] OHDCONKGEDC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class FONPCMFGPEC
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5FE1A00", Offset = "0x5FE0E00", VA = "0x185FE1A00")]
	[NotNull]
	public static byte[] AMENLDIBJHL(this BEELAICIKML NIFOBMFPHDD, HashAlgorithmName LGFEBBDLJBH, byte[] ANBDHFCMFDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface BEELAICIKML
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash IJEJDFGCCLC);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface HMNPLIJJNLD : BEELAICIKML
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	[CanBeNull]
	byte[] ANDAPKJPAEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	[CanBeNull]
	byte[] JABEPAEFCCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class MKHEDCOLHOD
{
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static readonly ArrayPool<byte> OJJHNFDHIBB;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static bool FJIMHPJMGPE;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5FE3C60", Offset = "0x5FE3060", VA = "0x185FE3C60")]
	public static void KCHIFNHHDEF(this IncrementalHash JLMBIGINLJM, [CanBeNull] GameObject IFGJJHCIEPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x26F4600", Offset = "0x26F3A00", VA = "0x1826F4600")]
	public static void KCHIFNHHDEF<T>(this IncrementalHash JLMBIGINLJM, [CanBeNull] T GHPJMKBNPML) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x26F4570", Offset = "0x26F3970", VA = "0x1826F4570")]
	public static void JJCMOLLDAPC<T>(this IncrementalHash JLMBIGINLJM, [CanBeNull] T NIFOBMFPHDD) where T : BEELAICIKML
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x26F3A20", Offset = "0x26F2E20", VA = "0x1826F3A20")]
	public static void BOOAMMGHJIE<T>(this IncrementalHash JLMBIGINLJM, [CanBeNull] IList<T> OKHGKBLKMNI) where T : BEELAICIKML
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5FE3B70", Offset = "0x5FE2F70", VA = "0x185FE3B70")]
	private static bool IOELEBAHEPF([CanBeNull] BEELAICIKML NIFOBMFPHDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5FE3810", Offset = "0x5FE2C10", VA = "0x185FE3810")]
	public static void IBGLBMJPOOB(this IncrementalHash IJEJDFGCCLC, [CanBeNull] string NDKIIGBCPNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5FE39A0", Offset = "0x5FE2DA0", VA = "0x185FE39A0")]
	public static void ILICBKFINGI(this IncrementalHash IJEJDFGCCLC, long OPBPBKICGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5FE3EB0", Offset = "0x5FE32B0", VA = "0x185FE3EB0")]
	public static void NDOHMOJGHKL(this IncrementalHash IJEJDFGCCLC, int LEEPPHOGNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5FE4080", Offset = "0x5FE3480", VA = "0x185FE4080")]
	public static void NKNDIJFNGAP(this IncrementalHash IJEJDFGCCLC, short IBFAKNOEMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5FE3700", Offset = "0x5FE2B00", VA = "0x185FE3700")]
	public static void FPENMMEMBCD(this IncrementalHash IJEJDFGCCLC, byte KCBKOCEMJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5FE3D40", Offset = "0x5FE3140", VA = "0x185FE3D40")]
	public static void KNIHHDAHNJD(this IncrementalHash IJEJDFGCCLC, bool FEKDIGDANAN, bool GKLPJGAHMGP = false, bool HKACOIMJJGJ = false, bool JCLLGLKNFAI = false, bool HIBFBLNLMBF = false, bool LOHIIKKJKEP = false, bool FGOGENCJDDO = false, bool GMEBHCKJEHG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x26F3F40", Offset = "0x26F3340", VA = "0x1826F3F40")]
	public static void HCBEHFPHAHJ<T>(this IncrementalHash IJEJDFGCCLC, T ADBOOOJIIPK) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5FE35E0", Offset = "0x5FE29E0", VA = "0x185FE35E0")]
	public static void BOJIKGMIOJN(this IncrementalHash IJEJDFGCCLC, float CEEELFFBOOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5FE3C00", Offset = "0x5FE3000", VA = "0x185FE3C00")]
	public static void JCBNJAGDCFE(this IncrementalHash IJEJDFGCCLC, ulong CHODIIILPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5FE3640", Offset = "0x5FE2A40", VA = "0x185FE3640")]
	public static void CMHLDOIDNJB(this IncrementalHash IJEJDFGCCLC, uint MPOGACCIHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5FE36A0", Offset = "0x5FE2AA0", VA = "0x185FE36A0")]
	public static void FBHJCFCBOFE(this IncrementalHash IJEJDFGCCLC, ushort HACFFDCMAAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5FE3870", Offset = "0x5FE2C70", VA = "0x185FE3870")]
	public static void IHLMJGHDFNP(this IncrementalHash IJEJDFGCCLC, Vector3 DLEGHCBGDHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class OBOLBBJFNNB : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5FE4360", Offset = "0x5FE3760", VA = "0x185FE4360")]
	public OBOLBBJFNNB(string AGOKDCAFCLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public abstract class NCFEGIDBCFM<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal class MLIGIHGBGOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public TNode LHCHBOKBAPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public TNode AOGBEAODJPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public HPKGEHLPMPO FPABAMILOJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public List<HPKGEHLPMPO> KHPMPLKCFAA;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public MLIGIHGBGOA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	internal struct HPKGEHLPMPO : IComparable<HPKGEHLPMPO>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int OLBHFMHNDAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public TClaimant LKDNFCEJENM;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xB97A80", Offset = "0xB96E80", VA = "0x180B97A80")]
		public HPKGEHLPMPO(int OLBHFMHNDAL, TClaimant LKDNFCEJENM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3840000", Offset = "0x383F400", VA = "0x183840000")]
		public bool LMIHNHLNHLD([In] HPKGEHLPMPO JLCJEDAFKJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x383FFF0", Offset = "0x383F3F0", VA = "0x18383FFF0")]
		public bool JKHGKCMFGEB([In] HPKGEHLPMPO JLCJEDAFKJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x383FFE0", Offset = "0x383F3E0", VA = "0x18383FFE0", Slot = "4")]
		public int CompareTo(HPKGEHLPMPO JLCJEDAFKJL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3840060", Offset = "0x383F460", VA = "0x183840060", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public enum DJOEMLNFFAL
	{
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class OHEOMPIMCOI : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public NCFEGIDBCFM<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x9345C0", Offset = "0x9339C0", VA = "0x1809345C0")]
		[DebuggerHidden]
		public OHEOMPIMCOI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3F98EE0", Offset = "0x3F982E0", VA = "0x183F98EE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3F990A0", Offset = "0x3F984A0", VA = "0x183F990A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3F98FC0", Offset = "0x3F983C0", VA = "0x183F98FC0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x34B6BF0", Offset = "0x34B5FF0", VA = "0x1834B6BF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly PDCINIJGAAF<MLIGIHGBGOA> OFDHKFLBAAB;

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static readonly PDCINIJGAAF<List<HPKGEHLPMPO>> PEEHCEEDCPM;

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static int IDCHLNOBICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	internal readonly Dictionary<TClaimant, TNode> LEKPFOEOBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	internal readonly Dictionary<TNode, MLIGIHGBGOA> OGFEGMODFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private DJOEMLNFFAL PEOLLHJDPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private bool BIPKAKIEIHN;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode EMHBODDIPIM(TNode LJOKPMONGEA);

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void BNNHBBGIMLA(TNode LJOKPMONGEA, TClaimant FKFPLANMCEI, TClaimant CFEIJDHECKF);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x3E82AE0", Offset = "0x3E81EE0", VA = "0x183E82AE0")]
	public NCFEGIDBCFM(DJOEMLNFFAL PEOLLHJDPED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x3E81D10", Offset = "0x3E81110", VA = "0x183E81D10")]
	public void FIMMMMHLGNB(TNode LJOKPMONGEA, TNode JOPIDNPFKKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x3E821F0", Offset = "0x3E815F0", VA = "0x183E821F0")]
	public void HICOAHBDDOC(TClaimant LKDNFCEJENM, TNode CLBPNGEIIJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3E81B40", Offset = "0x3E80F40", VA = "0x183E81B40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3E81670", Offset = "0x3E80A70", VA = "0x183E81670")]
	private void AKOPCPGMIDK(TClaimant LKDNFCEJENM, TNode HEEHKEMLOFH, TNode CLBPNGEIIJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3E81600", Offset = "0x3E80A00", VA = "0x183E81600")]
	private int ADPHJBFCCIH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3E812C0", Offset = "0x3E806C0", VA = "0x183E812C0")]
	private void AALIFPJNKIL(TClaimant LKDNFCEJENM, TNode PNEPFILBMIA, TNode JCCGNJNAHGH, int OHLGCDGIBFK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3E82310", Offset = "0x3E81710", VA = "0x183E82310")]
	private void KBOLCHHJDEO(HPKGEHLPMPO GJBPAAIPGBE, MLIGIHGBGOA HGKLPPPBEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3E81F10", Offset = "0x3E81310", VA = "0x183E81F10")]
	private void GNNEDGGNHNL(TClaimant LKDNFCEJENM, TNode PNEPFILBMIA, TNode JCCGNJNAHGH, int OHLGCDGIBFK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3E82570", Offset = "0x3E81970", VA = "0x183E82570")]
	private void MEBKOPBGNLH(HPKGEHLPMPO GJBPAAIPGBE, TNode LJOKPMONGEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3E81A50", Offset = "0x3E80E50", VA = "0x183E81A50")]
	private void CEBHHGAICCG(HPKGEHLPMPO GJBPAAIPGBE, MLIGIHGBGOA HGKLPPPBEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3E82680", Offset = "0x3E81A80", VA = "0x183E82680")]
	private void MKKEGGEECAB(MLIGIHGBGOA HGKLPPPBEHG, bool COOCIFIIKEM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3E81710", Offset = "0x3E80B10", VA = "0x183E81710")]
	private void CBOBLILJKME(MLIGIHGBGOA HGKLPPPBEHG, TNode JOPIDNPFKKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3E82490", Offset = "0x3E81890", VA = "0x183E82490")]
	[IteratorStateMachine(typeof(NCFEGIDBCFM<, >.OHEOMPIMCOI))]
	private IEnumerable<TNode> KPKELAGKEBB(TNode PNEPFILBMIA, TNode JCCGNJNAHGH, bool GFIMJINPMMP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x3E823A0", Offset = "0x3E817A0", VA = "0x183E823A0")]
	private MLIGIHGBGOA KNBNPHHBFLO(TNode LJOKPMONGEA, TNode AOGBEAODJPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x3E81DA0", Offset = "0x3E811A0", VA = "0x183E81DA0")]
	private MLIGIHGBGOA FPDHNGOCGNL(TNode LJOKPMONGEA, TNode AOGBEAODJPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3E827B0", Offset = "0x3E81BB0", VA = "0x183E827B0")]
	private void MPKOPNOFAGM(MLIGIHGBGOA HGKLPPPBEHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class PAAEEHDJNOM<T> : IEnumerable<PAAEEHDJNOM<T>.CCLDKDKKAFG>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public struct CCLDKDKKAFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public T PAHKKNONPEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public int FGBBDGJMFEH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class LOPKECEEDOF : IEnumerator<CCLDKDKKAFG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private PAAEEHDJNOM<T> NODLFLFFLNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int FGBBDGJMFEH;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x32FE0D0", Offset = "0x32FD4D0", VA = "0x1832FE0D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public CCLDKDKKAFG POOCHKNOAMB
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x3C469D0", Offset = "0x3C45DD0", VA = "0x183C469D0", Slot = "4")]
			get
			{
				return default(CCLDKDKKAFG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3C468E0", Offset = "0x3C45CE0", VA = "0x183C468E0")]
		public LOPKECEEDOF(PAAEEHDJNOM<T> NODLFLFFLNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3C467E0", Offset = "0x3C45BE0", VA = "0x183C467E0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3351760", Offset = "0x3350B60", VA = "0x183351760", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x1B72050", Offset = "0x1B71450", VA = "0x181B72050", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct HHOKPCNMELC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public bool HFOLMIDNIFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public T PAHKKNONPEO;
	}

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private const int FCIGHEEECDP = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly Dictionary<T, int> KPJKDGEJGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private HHOKPCNMELC[] LMOPKECBHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private int KJDNKGCMHGO;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int CDDKNOEFGGG
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7CF690", Offset = "0x7CEA90", VA = "0x1807CF690")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7CED20", Offset = "0x7CE120", VA = "0x1807CED20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int IGPGGFCOPJC
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3073330", Offset = "0x3072730", VA = "0x183073330")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x40379B0", Offset = "0x4036DB0", VA = "0x1840379B0")]
	public PAAEEHDJNOM(int BPEPAFIGLCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x40375E0", Offset = "0x40369E0", VA = "0x1840375E0")]
	public PAAEEHDJNOM(CCLDKDKKAFG[] LGANHOMJMHN, bool MPMGHGFMDFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x4036E50", Offset = "0x4036250", VA = "0x184036E50")]
	public int ICJCFPDFKFB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x4036B60", Offset = "0x4035F60", VA = "0x184036B60")]
	private int DFCCAJNNCAC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x4036E20", Offset = "0x4036220", VA = "0x184036E20", Slot = "6")]
	protected virtual uint GMJFIINNEKG(uint IJEJDFGCCLC, T PAHKKNONPEO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x40374C0", Offset = "0x40368C0", VA = "0x1840374C0")]
	public bool NKJLOECGEEK(T PAHKKNONPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x4036EE0", Offset = "0x40362E0", VA = "0x184036EE0")]
	public int NAJBEKECBEB(T PAHKKNONPEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x40368B0", Offset = "0x4035CB0", VA = "0x1840368B0")]
	public T BLMBCPBHMDH(int FGBBDGJMFEH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x4037420", Offset = "0x4036820", VA = "0x184037420")]
	public bool NCEOJDBHMGD(T PAHKKNONPEO, bool FAHANDNBNLB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x4036FB0", Offset = "0x40363B0", VA = "0x184036FB0")]
	public bool NCEOJDBHMGD(T PAHKKNONPEO, int FGBBDGJMFEH, bool FAHANDNBNLB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x4036D50", Offset = "0x4036150", VA = "0x184036D50")]
	private int FCHFOONKMIF(int PNHIOPPHDJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x4037560", Offset = "0x4036960", VA = "0x184037560", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x4037560", Offset = "0x4036960", VA = "0x184037560", Slot = "4")]
	private IEnumerator<CCLDKDKKAFG> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class PDCINIJGAAF<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Stack<T> MIKOEJMEKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly List<T> MCPABMACHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly int EFIJOPPDOPI;

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x4048240", Offset = "0x4047640", VA = "0x184048240")]
	public static PDCINIJGAAF<T> EBHLDLJNKMJ(int BPEPAFIGLCD = 0, int EFIJOPPDOPI = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x4048570", Offset = "0x4047970", VA = "0x184048570")]
	public PDCINIJGAAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x40485A0", Offset = "0x40479A0", VA = "0x1840485A0")]
	public PDCINIJGAAF(int BPEPAFIGLCD, int EFIJOPPDOPI = int.MaxValue, bool IEACPHBKGGB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x40483F0", Offset = "0x40477F0", VA = "0x1840483F0")]
	public T KLOHDFEJPKC()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x4048320", Offset = "0x4047720", VA = "0x184048320")]
	public void FEPCPPOBHNL(T PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x4047E00", Offset = "0x4047200", VA = "0x184047E00")]
	private void BFACMFJGPHO(T PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x4047EE0", Offset = "0x40472E0", VA = "0x184047EE0")]
	private void DDBKKAKDGBD(T PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x4048100", Offset = "0x4047500", VA = "0x184048100", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x4047F00", Offset = "0x4047300", VA = "0x184047F00")]
	private void DDLOKLIKIJJ(IEnumerable<T> HHMCIHBKJAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class GEKMCBJFMKD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Dictionary<int, T> LOKAOHHOFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private T HCFDNBEMFPM;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual T GHGPMHKDPHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x792A30", Offset = "0x791E30", VA = "0x180792A30", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x3775400", Offset = "0x3774800", VA = "0x183775400")]
	public bool HNKEHLMINJB(T PAHKKNONPEO, int OLBHFMHNDAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x3775170", Offset = "0x3774570", VA = "0x183775170")]
	public bool EMCDLAEMKII(int OLBHFMHNDAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x3774D90", Offset = "0x3774190", VA = "0x183774D90")]
	public T ANEHLAFGKLD(int NBCKFGANKDB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x37751E0", Offset = "0x37745E0", VA = "0x1837751E0")]
	private bool FNEAALJKELJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x3775480", Offset = "0x3774880", VA = "0x183775480")]
	public bool KDHJGKFFEEJ(int OLBHFMHNDAL, [Out] T PAHKKNONPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x37754D0", Offset = "0x37748D0", VA = "0x1837754D0")]
	public GEKMCBJFMKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class EFBKAPGMNCA<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	protected struct MFDMEPPJDOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public T BFBAIKCHJBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public int KMBAHPHBNHB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	protected readonly List<MFDMEPPJDOK> FIBPHGGLCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private T AMPBGFOHJEN;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int IGPGGFCOPJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3073330", Offset = "0x3072730", VA = "0x183073330")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x32B0630", Offset = "0x32AFA30", VA = "0x1832B0630")]
	public bool GHNKANFLKPF(T PAHKKNONPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x32B03E0", Offset = "0x32AF7E0", VA = "0x1832B03E0")]
	public void DEAIBIAHPPK(T PAHKKNONPEO, int OLBHFMHNDAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x32B04E0", Offset = "0x32AF8E0", VA = "0x1832B04E0")]
	public bool FKMFNEFKHJM(T PAHKKNONPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x32B0480", Offset = "0x32AF880", VA = "0x1832B0480")]
	public void EKABOMHIFDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x32B07B0", Offset = "0x32AFBB0", VA = "0x1832B07B0")]
	public T NHONCCFEFIH()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x32B0280", Offset = "0x32AF680", VA = "0x1832B0280")]
	private void BHNMABEJMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x32B0830", Offset = "0x32AFC30", VA = "0x1832B0830")]
	public EFBKAPGMNCA()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[CEJHJKODPLN(ELJJCPAPFEG.Self, false, false, false)]
		[SerializeField]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x5FE4500", Offset = "0x5FE3900", VA = "0x185FE4500")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x5FE47D0", Offset = "0x5FE3BD0", VA = "0x185FE47D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x5FE46E0", Offset = "0x5FE3AE0", VA = "0x185FE46E0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x5FE4450", Offset = "0x5FE3850", VA = "0x185FE4450")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x5FE4720", Offset = "0x5FE3B20", VA = "0x185FE4720")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x5FE4630", Offset = "0x5FE3A30", VA = "0x185FE4630")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x5FE43C0", Offset = "0x5FE37C0", VA = "0x185FE43C0")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x4226CA0", Offset = "0x42260A0", VA = "0x184226CA0", Slot = "4")]
		public virtual T GICANGMOCFE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class LEHBOEDEAJD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly Dictionary<byte, DGCKGJKNJJA> KFIHGAGCCLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly PDCINIJGAAF<DGCKGJKNJJA> GCHBPDEJIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private readonly bool HFKOHCGPKFF;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public DGCKGJKNJJA PLHLFCPCPPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x793920", Offset = "0x792D20", VA = "0x180793920")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x793930", Offset = "0x792D30", VA = "0x180793930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public Vector2 JDENEMDFNKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xB24BC0", Offset = "0xB23FC0", VA = "0x180B24BC0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xE0E190", Offset = "0xE0D590", VA = "0x180E0E190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private Vector2 GLACLGMPHJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xE39570", Offset = "0xE38970", VA = "0x180E39570")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public Vector2 HDCOHBFLHAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5FE2CF0", Offset = "0x5FE20F0", VA = "0x185FE2CF0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x794110", Offset = "0x793510", VA = "0x180794110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public int JEMFEFNCGFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x79A730", Offset = "0x799B30", VA = "0x18079A730")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x79AAD0", Offset = "0x799ED0", VA = "0x18079AAD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x5FE3080", Offset = "0x5FE2480", VA = "0x185FE3080")]
	public LEHBOEDEAJD(Bounds BLCGNDGBIHF, Vector2[] JEKLLIKIFMK, int PNGKIOJKLJP, byte PNHIOPPHDJO, float JGDDICBELEF = 0f, [Optional] PDCINIJGAAF<DGCKGJKNJJA> GCHBPDEJIOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x5FE2C90", Offset = "0x5FE2090", VA = "0x185FE2C90")]
	public DGCKGJKNJJA FJIEMGCMHCH(byte FGBBDGJMFEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x5FE27B0", Offset = "0x5FE1BB0", VA = "0x185FE27B0")]
	public void AJBJNEHOCHH(Vector3 BCGGHPIMKDA, float GFFBBKNGJAG, float JKLLKFBCBOJ, List<byte> OGKHJGDANHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x5CFFF00", Offset = "0x5CFF300", VA = "0x185CFFF00")]
	public void LILOMIFFBNP(DGCKGJKNJJA.FBAPNKLIDOO BNJCPLLOEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5FE2D70", Offset = "0x5FE2170", VA = "0x185FE2D70")]
	public static int JJKOMMANCJJ(Vector2[] JEKLLIKIFMK, int PNGKIOJKLJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5FE25B0", Offset = "0x5FE19B0", VA = "0x185FE25B0")]
	private DGCKGJKNJJA AFLIBEOMIPP(byte FGBBDGJMFEH, DGCKGJKNJJA.CBHOLGFDNGK GJAFPAGFNHP, DGCKGJKNJJA AOGBEAODJPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x5FE2880", Offset = "0x5FE1C80", VA = "0x185FE2880")]
	private void AKAKFPFILCC(DGCKGJKNJJA AOGBEAODJPP, Vector2[] JEKLLIKIFMK, int HOBNJNIFHEB, int ILBHPLFCJBD, int LOFCHHLDAAN, int GIJIKENEMMM, float JGDDICBELEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x5FE2E60", Offset = "0x5FE2260", VA = "0x185FE2E60")]
	private void LAPLBIMMGOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x5FE2C30", Offset = "0x5FE2030", VA = "0x185FE2C30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x5FE2D10", Offset = "0x5FE2110", VA = "0x185FE2D10", Slot = "1")]
	~LEHBOEDEAJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class DGCKGJKNJJA
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public enum CBHOLGFDNGK
	{
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public enum FBAPNKLIDOO
	{
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public byte POIIBGFPHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public Vector3 EPFIPGFJLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public Vector3 KKKENMPFNFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public Vector3 OFCEHPJGDKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public Vector3 EEIPAOJIDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public CBHOLGFDNGK LGDPEBOJLOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public DGCKGJKNJJA PDLABICHIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public List<DGCKGJKNJJA> OGABOEHIEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public bool HOADDLJDMCP;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x5FE18A0", Offset = "0x5FE0CA0", VA = "0x185FE18A0")]
	public DGCKGJKNJJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x5FE1780", Offset = "0x5FE0B80", VA = "0x185FE1780")]
	public void HOIHJCNCDNK(DGCKGJKNJJA KDABCDIIADN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440")]
	public void LILOMIFFBNP(int HCINMICEAEI, FBAPNKLIDOO BNJCPLLOEML, int KKDOPNDIFNM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x5FE1430", Offset = "0x5FE0830", VA = "0x185FE1430")]
	public void AJBJNEHOCHH(List<byte> OGKHJGDANHA, Vector3 BCGGHPIMKDA, float GFFBBKNGJAG, float JKLLKFBCBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x5FE1750", Offset = "0x5FE0B50", VA = "0x185FE1750")]
	public bool GMFJBCEEHIK(Vector3 OBBJCDANAFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x5FE1690", Offset = "0x5FE0A90", VA = "0x185FE1690")]
	public bool FDEIECIOKEH(Vector3 OBBJCDANAFL, float GDEEBLIAELL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5FE16C0", Offset = "0x5FE0AC0", VA = "0x185FE16C0")]
	public void FILODNFGCKM()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		public struct KMAMHHBAKDE<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private readonly List<Component> EPAFMCCJAFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private readonly bool PLGLILLKHCM;

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x38D97F0", Offset = "0x38D8BF0", VA = "0x1838D97F0")]
			public KMAMHHBAKDE(List<Component> EPAFMCCJAFF, bool PLGLILLKHCM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x3B70510", Offset = "0x3B6F910", VA = "0x183B70510")]
			public ONDBOKLCCJA<T> FPDPCEFPILF()
			{
				return default(ONDBOKLCCJA<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x3B70580", Offset = "0x3B6F980", VA = "0x183B70580", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x3B70580", Offset = "0x3B6F980", VA = "0x183B70580", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		public struct ONDBOKLCCJA<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private readonly List<Component> EPAFMCCJAFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private readonly bool PLGLILLKHCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private int FGBBDGJMFEH;

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			public T POOCHKNOAMB
			{
				[Cpp2IlInjected.Token(Token = "0x60001EB")]
				[Cpp2IlInjected.Address(RVA = "0x3FAA780", Offset = "0x3FA9B80", VA = "0x183FAA780", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001EC")]
				[Cpp2IlInjected.Address(RVA = "0x3FAA710", Offset = "0x3FA9B10", VA = "0x183FAA710", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x3FAA750", Offset = "0x3FA9B50", VA = "0x183FAA750")]
			public ONDBOKLCCJA(List<Component> EPAFMCCJAFF, bool PLGLILLKHCM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x3FAA650", Offset = "0x3FA9A50", VA = "0x183FAA650", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x3FAA660", Offset = "0x3FA9A60", VA = "0x183FAA660", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x1D1A550", Offset = "0x1D19950", VA = "0x181D1A550", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5FE5BC0", Offset = "0x5FE4FC0", VA = "0x185FE5BC0")]
		private void FILODNFGCKM(GameObject HDHABPIEJIF, bool LHIOHICKLJF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5FE5D30", Offset = "0x5FE5130", VA = "0x185FE5D30")]
		public static void FILODNFGCKM(GameObject HDHABPIEJIF, ToolHierarchyCache JILCDALCFCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x28DEB60", Offset = "0x28DDF60", VA = "0x1828DEB60")]
		public void DMPFPFBLKMJ<T>(Action<T> EEEBGEOHFMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x28DEAF0", Offset = "0x28DDEF0", VA = "0x1828DEAF0")]
		public T BAMDHNOFGPA<T>(bool PLGLILLKHCM = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x28DED80", Offset = "0x28DE180", VA = "0x1828DED80")]
		public KMAMHHBAKDE<T> GGJBEEBAJNM<T>(bool PLGLILLKHCM = false) where T : class
		{
			return default(KMAMHHBAKDE<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x5FE5F60", Offset = "0x5FE5360", VA = "0x185FE5F60")]
		public List<Component> PHELBMLFABK(Type KHENBEDBKDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5FE5B40", Offset = "0x5FE4F40", VA = "0x185FE5B40", Slot = "4")]
		public bool Equals(ToolHierarchyCache FHDILOGEHPC, ToolHierarchyCache ICKJJDCCMFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5FE5EF0", Offset = "0x5FE52F0", VA = "0x185FE5EF0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache DFFBALIDCLL)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class EFHDKONKFNH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private int BPEPAFIGLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private int FBPJEODEMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private List<T> KHBDFCDIBGP;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int IGPGGFCOPJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x32B36E0", Offset = "0x32B2AE0", VA = "0x1832B36E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public T PBNNGCBPFCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x32B37D0", Offset = "0x32B2BD0", VA = "0x1832B37D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public T OIGOOEDIGJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x32B34F0", Offset = "0x32B28F0", VA = "0x1832B34F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public T OLDDOLBFPDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x32B3620", Offset = "0x32B2A20", VA = "0x1832B3620")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x32B38F0", Offset = "0x32B2CF0", VA = "0x1832B38F0")]
	public EFHDKONKFNH(int BPEPAFIGLCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x32B3300", Offset = "0x32B2700", VA = "0x1832B3300")]
	public void DEAIBIAHPPK(T BEAALMFIDPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x32B36A0", Offset = "0x32B2AA0", VA = "0x1832B36A0")]
	public void EKABOMHIFDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x32B3230", Offset = "0x32B2630", VA = "0x1832B3230")]
	public void CDAMLGDHNGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x32B3890", Offset = "0x32B2C90", VA = "0x1832B3890")]
	public void PPCNIAMAKLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x32B3220", Offset = "0x32B2620", VA = "0x1832B3220")]
	public void BAGHFALKJCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class EEIHPOEIPJJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private struct EDGGACNLFGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int KMBAHPHBNHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public T BFBAIKCHJBC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly Dictionary<object, EDGGACNLFGP> LOKAOHHOFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly EqualityComparer<T> GOENPGKDJCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private T HCFDNBEMFPM;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public virtual T GHGPMHKDPHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xF028F0", Offset = "0xF01CF0", VA = "0x180F028F0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x32AF5D0", Offset = "0x32AE9D0", VA = "0x1832AF5D0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool HAFMNCCMIFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x32AE470", Offset = "0x32AD870", VA = "0x1832AE470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public object KHCAFDOPONP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x793FD0", Offset = "0x7933D0", VA = "0x180793FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x796860", Offset = "0x795C60", VA = "0x180796860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x32AE6D0", Offset = "0x32ADAD0", VA = "0x1832AE6D0")]
	public bool HNKEHLMINJB(T PAHKKNONPEO, object KNOHBODGPLL, int OLBHFMHNDAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x32ABA80", Offset = "0x32AAE80", VA = "0x1832ABA80")]
	public bool EMCDLAEMKII(object KNOHBODGPLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x32AF000", Offset = "0x32AE400", VA = "0x1832AF000")]
	public bool KDHJGKFFEEJ(object KNOHBODGPLL, [Out] T PAHKKNONPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x32ABA50", Offset = "0x32AAE50", VA = "0x1832ABA50")]
	public void EKABOMHIFDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x32ABB10", Offset = "0x32AAF10", VA = "0x1832ABB10")]
	private bool FNEAALJKELJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x32AF610", Offset = "0x32AEA10", VA = "0x1832AF610")]
	public EEIHPOEIPJJ()
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
