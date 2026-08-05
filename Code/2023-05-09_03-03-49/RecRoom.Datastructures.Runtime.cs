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
public class PECNOFLGPHJ : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1C0", Offset = "0x7FCBC0", VA = "0x1807FE1C0")]
	public PECNOFLGPHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, KPEAOLIIHNP, NEFAFJJHHOP, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D2590", Offset = "0x7D0F90", VA = "0x1807D2590", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6F0", Offset = "0x7AE0F0", VA = "0x1807AF6F0", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x831AC0", Offset = "0x8304C0", VA = "0x180831AC0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8426B0", Offset = "0x8410B0", VA = "0x1808426B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash OGHEGNBLHPM);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x961520", Offset = "0x95FF20", VA = "0x180961520")]
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
	[PLGBBEBNKCO]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[PLGBBEBNKCO]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E4F0", Offset = "0x6A6CEF0", VA = "0x186A6E4F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E4B0", Offset = "0x6A6CEB0", VA = "0x186A6E4B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E530", Offset = "0x6A6CF30", VA = "0x186A6E530")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E700", Offset = "0x6A6D100", VA = "0x186A6E700")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E670", Offset = "0x6A6D070", VA = "0x186A6E670")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xAEC0F0", Offset = "0xAEAAF0", VA = "0x180AEC0F0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x856FB0", Offset = "0x8559B0", VA = "0x180856FB0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E470", Offset = "0x6A6CE70", VA = "0x186A6E470")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E5E0", Offset = "0x6A6CFE0", VA = "0x186A6E5E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6A6DEB0", Offset = "0x6A6C8B0", VA = "0x186A6DEB0")]
	public void CopyBounds(SavedExtents EHBPAFKHADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6A6E3D0", Offset = "0x6A6CDD0", VA = "0x186A6E3D0")]
	public void SetLocalSpaceBounds(Bounds ONFIBFJAMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0xDC9FC0", Offset = "0xDC89C0", VA = "0x180DC9FC0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6A6E3C0", Offset = "0x6A6CDC0", VA = "0x186A6E3C0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6A6DEE0", Offset = "0x6A6C8E0", VA = "0x186A6DEE0")]
	private void HLLFGKBIHDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6A6E190", Offset = "0x6A6CB90", VA = "0x186A6E190")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6A6D870", Offset = "0x6A6C270", VA = "0x186A6D870")]
	public static void CalculateLocalBoundsFor(GameObject OJBDJCCAFCN, out Bounds ONFIBFJAMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6A6E0D0", Offset = "0x6A6CAD0", VA = "0x186A6E0D0")]
	private static void LGAHFPOCDJM(Bounds LPDJCHOFJLE, Color JGGDAPAPFDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6A6E3F0", Offset = "0x6A6CDF0", VA = "0x186A6E3F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x755A00", Offset = "0x754400", VA = "0x180755A00")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x80B370", Offset = "0x809D70", VA = "0x18080B370")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xC62270", Offset = "0xC60C70", VA = "0x180C62270")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1542BE0", Offset = "0x15415E0", VA = "0x181542BE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "4")]
	public virtual void EKBKDJENDBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x25118A0", Offset = "0x25102A0", VA = "0x1825118A0")]
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
	[PECNOFLGPHJ]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x46B4180", Offset = "0x46B2B80", VA = "0x1846B4180", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x46B38B0", Offset = "0x46B22B0", VA = "0x1846B38B0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x46B46C0", Offset = "0x46B30C0", VA = "0x1846B46C0")]
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
	private sealed class OKBPKBKFBHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x25118A0", Offset = "0x25102A0", VA = "0x1825118A0")]
		public OKBPKBKFBHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3EDE490", Offset = "0x3EDCE90", VA = "0x183EDE490")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[PECNOFLGPHJ]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x31667D0", Offset = "0x31651D0", VA = "0x1831667D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3166800", Offset = "0x3165200", VA = "0x183166800", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3166720", Offset = "0x3165120", VA = "0x183166720", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public TVal this[TKey IGFDDANAMMH]
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3166780", Offset = "0x3165180", VA = "0x183166780", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3166620", Offset = "0x3165020", VA = "0x183166620", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3166170", Offset = "0x3164B70", VA = "0x183166170", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3165990", Offset = "0x3164390", VA = "0x183165990", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3165640", Offset = "0x3164040", VA = "0x183165640", Slot = "14")]
	protected virtual string KJKPFADLKHB(TKeyVal ILIEGOCMBAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3155D00", Offset = "0x3154700", VA = "0x183155D00", Slot = "4")]
	public bool ContainsKey(TKey IGFDDANAMMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3166510", Offset = "0x3164F10", VA = "0x183166510", Slot = "5")]
	public bool TryGetValue(TKey IGFDDANAMMH, out TVal MFBGAMJDOKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3165550", Offset = "0x3163F50", VA = "0x183165550", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3165550", Offset = "0x3163F50", VA = "0x183165550", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3166540", Offset = "0x3164F40", VA = "0x183166540")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class PHFHKCMDMDF<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class AOCNLEDCDIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x25118A0", Offset = "0x25102A0", VA = "0x1825118A0")]
		public AOCNLEDCDIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4758F10", Offset = "0x4757910", VA = "0x184758F10")]
		internal bool <GetSamples>b__0(global::FNNHCANPJHO<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float ACCAKCLFOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float FDOCKAPFPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<global::FNNHCANPJHO<float, T>> IHOOMKNCBBA;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int GOJKDADJFON
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x43D3AC0", Offset = "0x43D24C0", VA = "0x1843D3AC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x43D4250", Offset = "0x43D2C50", VA = "0x1843D4250")]
	public PHFHKCMDMDF(float JGHHCFGINJB, float ECIHIMKGPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x43D38E0", Offset = "0x43D22E0", VA = "0x1843D38E0")]
	public bool BIJDDHFCKCI(float DCICKGKMGLG, T MFBGAMJDOKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x43D41C0", Offset = "0x43D2BC0", VA = "0x1843D41C0")]
	public int OKCMCDJCJJC(float DCICKGKMGLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x43D3B40", Offset = "0x43D2540", VA = "0x1843D3B40")]
	public IEnumerable<T> NKKMJDHFAAI(float DCICKGKMGLG, [Optional] float? IKKJPOMJPNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x43D4220", Offset = "0x43D2C20", VA = "0x1843D4220")]
	public void PDOAHDCGLGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x43D36C0", Offset = "0x43D20C0", VA = "0x1843D36C0")]
	private void BAJMMLKCINB(float DCICKGKMGLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class BLJLAKJFPKA<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct KPGIGJKABDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T ONBMIOJBCHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float IFBAKPAONCI;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float PLJJGNALGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> FDHBCGNDOKF;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int JALHCJBDPIG = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private KPGIGJKABDH[] HPOICFFOIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int MKMGPMJKLGM;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float DHEOLMIGOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xC61AC0", Offset = "0xC604C0", VA = "0x180C61AC0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xC61B50", Offset = "0xC60550", VA = "0x180C61B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x488C370", Offset = "0x488AD70", VA = "0x18488C370")]
	public BLJLAKJFPKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x488C290", Offset = "0x488AC90", VA = "0x18488C290")]
	public BLJLAKJFPKA(int IMMPKDAEONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x488BD70", Offset = "0x488A770", VA = "0x18488BD70")]
	public void IFPOOIAJHAI(float DCICKGKMGLG, T MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x488BE50", Offset = "0x488A850", VA = "0x18488BE50")]
	public void PDOAHDCGLGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x488B1B0", Offset = "0x4889BB0", VA = "0x18488B1B0")]
	public bool EENLJGEHIBK(float FCHMDEEIDME, float PLJKNFOHMHF, out T MFBGAMJDOKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x488B750", Offset = "0x488A150", VA = "0x18488B750")]
	public bool HPCPOMCPPLF(float FCHMDEEIDME, float PLJKNFOHMHF, out T MFBGAMJDOKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x488B480", Offset = "0x4889E80", VA = "0x18488B480")]
	public void FCKKCEOFNGP(float FCHMDEEIDME, float PLJKNFOHMHF, List<T> CKDPLHPNFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x488B720", Offset = "0x488A120", VA = "0x18488B720")]
	private int HCDBPDIMIKE(int MDCEPHOJNEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x488B6E0", Offset = "0x488A0E0", VA = "0x18488B6E0")]
	private void GDOBOJODHJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T KJOIGBHNEKN();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T GIPAAOKDAFF(T OLGHNLLKLDL, T JPDHFMDKHGF, float ENLKJOJFGLO);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T PEMIOODAJKI(T MFBGAMJDOKA, float ENLKJOJFGLO);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T JBNNAPMKFOA(T OLGHNLLKLDL, T JPDHFMDKHGF);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T OMOEIKFAABF(T OLGHNLLKLDL, T JPDHFMDKHGF);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class FEMKPALOFML : global::BLJLAKJFPKA<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x229BAE0", Offset = "0x229A4E0", VA = "0x18229BAE0", Slot = "4")]
	protected override Vector3 KJOIGBHNEKN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2600", Offset = "0x2AF1000", VA = "0x182AF2600", Slot = "5")]
	protected override Vector3 GIPAAOKDAFF(Vector3 OLGHNLLKLDL, Vector3 JPDHFMDKHGF, float ENLKJOJFGLO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6A68EE0", Offset = "0x6A678E0", VA = "0x186A68EE0", Slot = "6")]
	protected override Vector3 PEMIOODAJKI(Vector3 MFBGAMJDOKA, float ENLKJOJFGLO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6A68DF0", Offset = "0x6A677F0", VA = "0x186A68DF0", Slot = "7")]
	protected override Vector3 JBNNAPMKFOA(Vector3 OLGHNLLKLDL, Vector3 JPDHFMDKHGF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6A68E70", Offset = "0x6A67870", VA = "0x186A68E70", Slot = "8")]
	protected override Vector3 OMOEIKFAABF(Vector3 OLGHNLLKLDL, Vector3 JPDHFMDKHGF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6A68F40", Offset = "0x6A67940", VA = "0x186A68F40")]
	public FEMKPALOFML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class AOIAJBMACCI : global::BLJLAKJFPKA<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6A67DC0", Offset = "0x6A667C0", VA = "0x186A67DC0")]
	public AOIAJBMACCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6A67E30", Offset = "0x6A66830", VA = "0x186A67E30")]
	public AOIAJBMACCI(int IMMPKDAEONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xAEEA90", Offset = "0xAED490", VA = "0x180AEEA90", Slot = "4")]
	protected override float KJOIGBHNEKN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4803DE0", Offset = "0x48027E0", VA = "0x184803DE0", Slot = "5")]
	protected override float GIPAAOKDAFF(float OLGHNLLKLDL, float JPDHFMDKHGF, float ENLKJOJFGLO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5B9A250", Offset = "0x5B98C50", VA = "0x185B9A250", Slot = "6")]
	protected override float PEMIOODAJKI(float MFBGAMJDOKA, float ENLKJOJFGLO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4EF7E00", Offset = "0x4EF6800", VA = "0x184EF7E00", Slot = "7")]
	protected override float JBNNAPMKFOA(float OLGHNLLKLDL, float JPDHFMDKHGF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6A67DB0", Offset = "0x6A667B0", VA = "0x186A67DB0", Slot = "8")]
	protected override float OMOEIKFAABF(float OLGHNLLKLDL, float JPDHFMDKHGF)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class GNLGFHPEGHH
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2918CA0", Offset = "0x29176A0", VA = "0x182918CA0")]
	public static global::JELFILFMHDJ<T1> KMLFLFAGFOK<T1>(T1 DMDGDAJKBNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x30DA990", Offset = "0x30D9390", VA = "0x1830DA990")]
	public static global::FNNHCANPJHO<T1, T2> KMLFLFAGFOK<T1, T2>(T1 DMDGDAJKBNG, T2 MJFNNODLGDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x30DAA00", Offset = "0x30D9400", VA = "0x1830DAA00")]
	public static global::MGIBBFMFGPI<T1, T2, T3> KMLFLFAGFOK<T1, T2, T3>(T1 DMDGDAJKBNG, T2 MJFNNODLGDH, T3 HPGBLELFOKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x30DAD70", Offset = "0x30D9770", VA = "0x1830DAD70")]
	public static global::LPHFCNKIJKA<T1, T2, T3, T4> KMLFLFAGFOK<T1, T2, T3, T4>(T1 DMDGDAJKBNG, T2 MJFNNODLGDH, T3 HPGBLELFOKH, T4 DEJELCJFPOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x30DACD0", Offset = "0x30D96D0", VA = "0x1830DACD0")]
	public static global::BANDDBJJDCG<T1, T2, T3, T4, T5> KMLFLFAGFOK<T1, T2, T3, T4, T5>(T1 DMDGDAJKBNG, T2 MJFNNODLGDH, T3 HPGBLELFOKH, T4 DEJELCJFPOK, T5 HCFNECGLCMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x30DAC20", Offset = "0x30D9620", VA = "0x1830DAC20")]
	public static global::JJMMGIFGMEF<T1, T2, T3, T4, T5, T6> KMLFLFAGFOK<T1, T2, T3, T4, T5, T6>(T1 DMDGDAJKBNG, T2 MJFNNODLGDH, T3 HPGBLELFOKH, T4 DEJELCJFPOK, T5 HCFNECGLCMA, T6 NFPHGOMJCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x30DAB60", Offset = "0x30D9560", VA = "0x1830DAB60")]
	public static global::LJLCHIEKDGD<T1, T2, T3, T4, T5, T6, T7> KMLFLFAGFOK<T1, T2, T3, T4, T5, T6, T7>(T1 DMDGDAJKBNG, T2 MJFNNODLGDH, T3 HPGBLELFOKH, T4 DEJELCJFPOK, T5 HCFNECGLCMA, T6 NFPHGOMJCHJ, T7 HCDKNDAMJEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x30DAA90", Offset = "0x30D9490", VA = "0x1830DAA90")]
	public static global::LEHIDIJBPFL<T1, T2, T3, T4, T5, T6, T7, T8> KMLFLFAGFOK<T1, T2, T3, T4, T5, T6, T7, T8>(T1 DMDGDAJKBNG, T2 MJFNNODLGDH, T3 HPGBLELFOKH, T4 DEJELCJFPOK, T5 HCFNECGLCMA, T6 NFPHGOMJCHJ, T7 HCDKNDAMJEA, T8 ABFFPDICEJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x294F7D0", Offset = "0x294E1D0", VA = "0x18294F7D0")]
	[IteratorStateMachine(typeof(FMGHKGEPFHC))]
	public static IEnumerable<global::FNNHCANPJHO<T1, T2>> BIJEICNMLJN<T1, T2>(IEnumerable<T1> MGFKDMJBGAK, IEnumerable<T2> LPDJCHOFJLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x294F910", Offset = "0x294E310", VA = "0x18294F910")]
	[IteratorStateMachine(typeof(CKKAPBOIFBD))]
	public static IEnumerable<global::MGIBBFMFGPI<T1, T2, T3>> BIJEICNMLJN<T1, T2, T3>(IEnumerable<T1> MGFKDMJBGAK, IEnumerable<T2> LPDJCHOFJLE, IEnumerable<T3> JGGDAPAPFDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1085CE0", Offset = "0x10846E0", VA = "0x181085CE0")]
	internal static int HMACFDILCFO(int IJJIPLIEEMI, int CGDHNIBLOCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1085CB0", Offset = "0x10846B0", VA = "0x181085CB0")]
	internal static int HMACFDILCFO(int IJJIPLIEEMI, int CGDHNIBLOCF, int CAKJIINBBBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1085C90", Offset = "0x1084690", VA = "0x181085C90")]
	internal static int HMACFDILCFO(int IJJIPLIEEMI, int CGDHNIBLOCF, int CAKJIINBBBP, int ECICGABLOEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1085CC0", Offset = "0x10846C0", VA = "0x181085CC0")]
	internal static int HMACFDILCFO(int IJJIPLIEEMI, int CGDHNIBLOCF, int CAKJIINBBBP, int ECICGABLOEA, int DHKPKKIONAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6A691D0", Offset = "0x6A67BD0", VA = "0x186A691D0")]
	internal static int HMACFDILCFO(int IJJIPLIEEMI, int CGDHNIBLOCF, int CAKJIINBBBP, int ECICGABLOEA, int DHKPKKIONAJ, int CFMPBAKJFPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6A691A0", Offset = "0x6A67BA0", VA = "0x186A691A0")]
	internal static int HMACFDILCFO(int IJJIPLIEEMI, int CGDHNIBLOCF, int CAKJIINBBBP, int ECICGABLOEA, int DHKPKKIONAJ, int CFMPBAKJFPP, int DGBIAGIKBLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6A691F0", Offset = "0x6A67BF0", VA = "0x186A691F0")]
	internal static int HMACFDILCFO(int IJJIPLIEEMI, int CGDHNIBLOCF, int CAKJIINBBBP, int ECICGABLOEA, int DHKPKKIONAJ, int CFMPBAKJFPP, int DGBIAGIKBLI, int JLBKBMOLEJD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class JELFILFMHDJ<T1> : IComparable<global::JELFILFMHDJ<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T1 HAFJBMKPGFJ;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x34E7CA0", Offset = "0x34E66A0", VA = "0x1834E7CA0")]
	public JELFILFMHDJ(T1 DMDGDAJKBNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3FC35D0", Offset = "0x3FC1FD0", VA = "0x183FC35D0", Slot = "4")]
	public int CompareTo(global::JELFILFMHDJ<T1> EHBPAFKHADK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3FC3640", Offset = "0x3FC2040", VA = "0x183FC3640", Slot = "0")]
	public override bool Equals(object EHBPAFKHADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x9B3160", Offset = "0x9B1B60", VA = "0x1809B3160", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3FC36E0", Offset = "0x3FC20E0", VA = "0x183FC36E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class FNNHCANPJHO<T1, T2> : IComparable<global::FNNHCANPJHO<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 HAFJBMKPGFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 PPJIOKNKFCH;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3278650", Offset = "0x3277050", VA = "0x183278650")]
	public FNNHCANPJHO(T1 DMDGDAJKBNG, T2 MJFNNODLGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x36246B0", Offset = "0x36230B0", VA = "0x1836246B0", Slot = "4")]
	public int CompareTo(global::FNNHCANPJHO<T1, T2> EHBPAFKHADK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3624770", Offset = "0x3623170", VA = "0x183624770", Slot = "0")]
	public override bool Equals(object EHBPAFKHADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3624920", Offset = "0x3623320", VA = "0x183624920", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x36249F0", Offset = "0x36233F0", VA = "0x1836249F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class MGIBBFMFGPI<T1, T2, T3> : IComparable<global::MGIBBFMFGPI<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T1 HAFJBMKPGFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T2 PPJIOKNKFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T3 GALBMGONGJI;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4EA7550", Offset = "0x4EA5F50", VA = "0x184EA7550")]
	public MGIBBFMFGPI(T1 DMDGDAJKBNG, T2 MJFNNODLGDH, T3 HPGBLELFOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4EA6D40", Offset = "0x4EA5740", VA = "0x184EA6D40", Slot = "4")]
	public int CompareTo(global::MGIBBFMFGPI<T1, T2, T3> EHBPAFKHADK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4EA6F40", Offset = "0x4EA5940", VA = "0x184EA6F40", Slot = "0")]
	public override bool Equals(object EHBPAFKHADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4EA71A0", Offset = "0x4EA5BA0", VA = "0x184EA71A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4EA7290", Offset = "0x4EA5C90", VA = "0x184EA7290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class LPHFCNKIJKA<T1, T2, T3, T4> : IComparable<global::LPHFCNKIJKA<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T1 HAFJBMKPGFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T2 PPJIOKNKFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T3 GALBMGONGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T4 FJHODGNDLEF;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3153460", Offset = "0x3151E60", VA = "0x183153460")]
	public LPHFCNKIJKA(T1 DMDGDAJKBNG, T2 MJFNNODLGDH, T3 HPGBLELFOKH, T4 DEJELCJFPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x44BB480", Offset = "0x44B9E80", VA = "0x1844BB480", Slot = "4")]
	public int CompareTo(global::LPHFCNKIJKA<T1, T2, T3, T4> EHBPAFKHADK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x44BB5C0", Offset = "0x44B9FC0", VA = "0x1844BB5C0", Slot = "0")]
	public override bool Equals(object EHBPAFKHADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x44BB6E0", Offset = "0x44BA0E0", VA = "0x1844BB6E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x44BB7A0", Offset = "0x44BA1A0", VA = "0x1844BB7A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class BANDDBJJDCG<T1, T2, T3, T4, T5> : IComparable<global::BANDDBJJDCG<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T1 HAFJBMKPGFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T2 PPJIOKNKFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T3 GALBMGONGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T4 FJHODGNDLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T5 HKPBJCPGLFM;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3AA86E0", Offset = "0x3AA70E0", VA = "0x183AA86E0")]
	public BANDDBJJDCG(T1 DMDGDAJKBNG, T2 MJFNNODLGDH, T3 HPGBLELFOKH, T4 DEJELCJFPOK, T5 HCFNECGLCMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x469B080", Offset = "0x4699A80", VA = "0x18469B080", Slot = "4")]
	public int CompareTo(global::BANDDBJJDCG<T1, T2, T3, T4, T5> EHBPAFKHADK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x469B200", Offset = "0x4699C00", VA = "0x18469B200", Slot = "0")]
	public override bool Equals(object EHBPAFKHADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x469B340", Offset = "0x4699D40", VA = "0x18469B340", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x469B440", Offset = "0x4699E40", VA = "0x18469B440", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class JJMMGIFGMEF<T1, T2, T3, T4, T5, T6> : IComparable<global::JJMMGIFGMEF<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T1 HAFJBMKPGFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T2 PPJIOKNKFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T3 GALBMGONGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T4 FJHODGNDLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T5 HKPBJCPGLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T6 BDLICCOACJE;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3FD1B10", Offset = "0x3FD0510", VA = "0x183FD1B10")]
	public JJMMGIFGMEF(T1 DMDGDAJKBNG, T2 MJFNNODLGDH, T3 HPGBLELFOKH, T4 DEJELCJFPOK, T5 HCFNECGLCMA, T6 NFPHGOMJCHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3FD1550", Offset = "0x3FCFF50", VA = "0x183FD1550", Slot = "4")]
	public int CompareTo(global::JJMMGIFGMEF<T1, T2, T3, T4, T5, T6> EHBPAFKHADK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3FD1710", Offset = "0x3FD0110", VA = "0x183FD1710", Slot = "0")]
	public override bool Equals(object EHBPAFKHADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3FD1880", Offset = "0x3FD0280", VA = "0x183FD1880", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3FD19A0", Offset = "0x3FD03A0", VA = "0x183FD19A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class LJLCHIEKDGD<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::LJLCHIEKDGD<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T1 HAFJBMKPGFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T2 PPJIOKNKFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T3 GALBMGONGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T4 FJHODGNDLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T5 HKPBJCPGLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T6 BDLICCOACJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T7 GKIOPFCKHJG;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x444D6F0", Offset = "0x444C0F0", VA = "0x18444D6F0")]
	public LJLCHIEKDGD(T1 DMDGDAJKBNG, T2 MJFNNODLGDH, T3 HPGBLELFOKH, T4 DEJELCJFPOK, T5 HCFNECGLCMA, T6 NFPHGOMJCHJ, T7 HCDKNDAMJEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x444D070", Offset = "0x444BA70", VA = "0x18444D070", Slot = "4")]
	public int CompareTo(global::LJLCHIEKDGD<T1, T2, T3, T4, T5, T6, T7> EHBPAFKHADK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x444D270", Offset = "0x444BC70", VA = "0x18444D270", Slot = "0")]
	public override bool Equals(object EHBPAFKHADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x444D410", Offset = "0x444BE10", VA = "0x18444D410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x444D560", Offset = "0x444BF60", VA = "0x18444D560", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class LEHIDIJBPFL<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::LEHIDIJBPFL<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T1 HAFJBMKPGFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T2 PPJIOKNKFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T3 GALBMGONGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T4 FJHODGNDLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T5 HKPBJCPGLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T6 BDLICCOACJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly T7 GKIOPFCKHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly T8 KJAHOKPDJEK;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2A09520", Offset = "0x2A07F20", VA = "0x182A09520")]
	public LEHIDIJBPFL(T1 DMDGDAJKBNG, T2 MJFNNODLGDH, T3 HPGBLELFOKH, T4 DEJELCJFPOK, T5 HCFNECGLCMA, T6 NFPHGOMJCHJ, T7 HCDKNDAMJEA, T8 ABFFPDICEJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2A08DF0", Offset = "0x2A077F0", VA = "0x182A08DF0", Slot = "4")]
	public int CompareTo(global::LEHIDIJBPFL<T1, T2, T3, T4, T5, T6, T7, T8> EHBPAFKHADK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x2A09040", Offset = "0x2A07A40", VA = "0x182A09040", Slot = "0")]
	public override bool Equals(object EHBPAFKHADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2A09200", Offset = "0x2A07C00", VA = "0x182A09200", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2A09370", Offset = "0x2A07D70", VA = "0x182A09370", Slot = "3")]
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
	public T ONBMIOJBCHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x12CA910", Offset = "0x12C9310", VA = "0x1812CA910")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x12CA990", Offset = "0x12C9390", VA = "0x1812CA990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float HIGCMIPPLHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9D1A40", Offset = "0x9D0440", VA = "0x1809D1A40")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4A96950", Offset = "0x4A95350", VA = "0x184A96950")]
	public T NCJEPKPGCOM(float ENLKJOJFGLO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4A96790", Offset = "0x4A95190", VA = "0x184A96790")]
	public T IGKKDNKAFOK(float ENLKJOJFGLO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T GIPAAOKDAFF(T OLGHNLLKLDL, T JPDHFMDKHGF, float ENLKJOJFGLO);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x25118A0", Offset = "0x25102A0", VA = "0x1825118A0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4803DE0", Offset = "0x48027E0", VA = "0x184803DE0", Slot = "4")]
	protected override float GIPAAOKDAFF(float OLGHNLLKLDL, float JPDHFMDKHGF, float ENLKJOJFGLO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6A69160", Offset = "0x6A67B60", VA = "0x186A69160")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2600", Offset = "0x2AF1000", VA = "0x182AF2600", Slot = "4")]
	protected override Vector3 GIPAAOKDAFF(Vector3 OLGHNLLKLDL, Vector3 JPDHFMDKHGF, float ENLKJOJFGLO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6A6F610", Offset = "0x6A6E010", VA = "0x186A6F610")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1DDAAE0", Offset = "0x1DD94E0", VA = "0x181DDAAE0", Slot = "4")]
	protected override Color GIPAAOKDAFF(Color OLGHNLLKLDL, Color JPDHFMDKHGF, float ENLKJOJFGLO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6A68A60", Offset = "0x6A67460", VA = "0x186A68A60")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class EEEDLNDGENH : global::OEONMLAGOJM<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6A68C90", Offset = "0x6A67690", VA = "0x186A68C90")]
	public EEEDLNDGENH(int ICKPJJPJOOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6A68C30", Offset = "0x6A67630", VA = "0x186A68C30")]
	public EEEDLNDGENH(NPHBOOBJJCM[] AFFMHGOJMAM, bool JNKOLMMKOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6A68BC0", Offset = "0x6A675C0", VA = "0x186A68BC0", Slot = "6")]
	protected override uint BOOCIAKGDKJ(uint OGHEGNBLHPM, string MFBGAMJDOKA)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class PIJBIMAKNFG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly IDisposable FINLHCLDLDF;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public PIJBIMAKNFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct FLJCHPFJKBB<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class PLLFJOHCDDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x25118A0", Offset = "0x25102A0", VA = "0x1825118A0")]
		public PLLFJOHCDDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x4330100", Offset = "0x432EB00", VA = "0x184330100")]
		internal void <StartRequest>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> KJNHIIDMDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int GDFABFJEKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int ENACCBNDFJD;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0xDC1380", Offset = "0xDBFD80", VA = "0x180DC1380")]
	private FLJCHPFJKBB(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> PJGEPCGBEPG, int LIHIHMENNGM, int KILPMMGIGPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3613870", Offset = "0x3612270", VA = "0x183613870")]
	public static global::FLJCHPFJKBB<T> IDLIIDOEAFG()
	{
		return default(global::FLJCHPFJKBB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x36122E0", Offset = "0x3610CE0", VA = "0x1836122E0")]
	public (int, int, Task<T>) ABMJJLFFIAI(int LFEHPMJHPFJ, [Optional] CancellationToken FAPLHFKLMOL, double GOMMNCLFDIF = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3613960", Offset = "0x3612360", VA = "0x183613960")]
	public void OJMOBHINMLL(int LFEHPMJHPFJ, int KILPMMGIGPO, in T MIMDGHHHHPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class LIKLBPACEAM
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6A6C3C0", Offset = "0x6A6ADC0", VA = "0x186A6C3C0")]
	public static global::FLJCHPFJKBB<LEKKGHCNCEK> IDLIIDOEAFG()
	{
		return default(global::FLJCHPFJKBB<LEKKGHCNCEK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6A6C410", Offset = "0x6A6AE10", VA = "0x186A6C410")]
	public static void OJMOBHINMLL(this in global::FLJCHPFJKBB<LEKKGHCNCEK> IKHBPJOEIEB, int LFEHPMJHPFJ, int KILPMMGIGPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[DefaultMember("Item")]
public class AHFCLFBIBIJ<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Dictionary<TKey, TVal> NLPJINNLKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Dictionary<TVal, TKey> AJBFPEPNNAE;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int GNKNLJGDNJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2A08AA0", Offset = "0x2A074A0", VA = "0x182A08AA0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool GOJJAFPEPMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7373D0", Offset = "0x735DD0", VA = "0x1807373D0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> HENGLELCHAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x3148250", Offset = "0x3146C50", VA = "0x183148250", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> FBMMJKJNBLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x3276CC0", Offset = "0x32756C0", VA = "0x183276CC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal KBLKMCBLENC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3C94640", Offset = "0x3C93040", VA = "0x183C94640", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3C946B0", Offset = "0x3C930B0", VA = "0x183C946B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey KBLKMCBLENC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3C93A40", Offset = "0x3C92440", VA = "0x183C93A40")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3C943A0", Offset = "0x3C92DA0", VA = "0x183C943A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3C93740", Offset = "0x3C92140", VA = "0x183C93740", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3C944C0", Offset = "0x3C92EC0", VA = "0x183C944C0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3C93580", Offset = "0x3C91F80", VA = "0x183C93580", Slot = "9")]
	public void Add(TKey IGFDDANAMMH, TVal MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3C935C0", Offset = "0x3C91FC0", VA = "0x183C935C0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> FPEJLKINELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3C937A0", Offset = "0x3C921A0", VA = "0x183C937A0", Slot = "8")]
	public bool ContainsKey(TKey IGFDDANAMMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3C93800", Offset = "0x3C92200", VA = "0x183C93800", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> FPEJLKINELB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3C943E0", Offset = "0x3C92DE0", VA = "0x183C943E0", Slot = "10")]
	public bool Remove(TKey IGFDDANAMMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3C94410", Offset = "0x3C92E10", VA = "0x183C94410", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> FPEJLKINELB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x362CEE0", Offset = "0x362B8E0", VA = "0x18362CEE0", Slot = "11")]
	public bool TryGetValue(TKey IGFDDANAMMH, out TVal MFBGAMJDOKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3C93AB0", Offset = "0x3C924B0", VA = "0x183C93AB0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3C93830", Offset = "0x3C92230", VA = "0x183C93830", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] HPOICFFOIAP, int IEPKLEKMEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3C93CE0", Offset = "0x3C926E0", VA = "0x183C93CE0")]
	public void IFPOOIAJHAI(TVal GNMCFHMDDGA, TKey IGFDDANAMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3C93D50", Offset = "0x3C92750", VA = "0x183C93D50")]
	public void IFPOOIAJHAI(KeyValuePair<TVal, TKey> FPEJLKINELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3C942E0", Offset = "0x3C92CE0", VA = "0x183C942E0")]
	public bool MODKPHNNCKL(TVal IGFDDANAMMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3C93330", Offset = "0x3C91D30", VA = "0x183C93330")]
	public bool AAFBPIPDPOL(KeyValuePair<TVal, TKey> FPEJLKINELB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3C93BB0", Offset = "0x3C925B0", VA = "0x183C93BB0")]
	public bool HEOHJOBENDL(TVal IGFDDANAMMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3C93BB0", Offset = "0x3C925B0", VA = "0x183C93BB0")]
	public bool HEOHJOBENDL(KeyValuePair<TVal, TKey> FPEJLKINELB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3C94270", Offset = "0x3C92C70", VA = "0x183C94270")]
	public bool JBPBACKGAAO(TVal IGFDDANAMMH, out TKey MFBGAMJDOKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3C93630", Offset = "0x3C92030", VA = "0x183C93630")]
	public IEnumerator<KeyValuePair<TVal, TKey>> BIDBFILMNKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3C939A0", Offset = "0x3C923A0", VA = "0x183C939A0")]
	private void EMPLDNNOCOA(TKey IGFDDANAMMH, TVal GNMCFHMDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3C93480", Offset = "0x3C91E80", VA = "0x183C93480")]
	private void ABHCAFKDGML(TKey IGFDDANAMMH, TVal GNMCFHMDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3C93D90", Offset = "0x3C92790", VA = "0x183C93D90")]
	private bool INDEFLEHOCG(TKey IGFDDANAMMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3C940A0", Offset = "0x3C92AA0", VA = "0x183C940A0")]
	private bool INDEFLEHOCG(TVal GNMCFHMDDGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x3C94560", Offset = "0x3C92F60", VA = "0x183C94560")]
	public AHFCLFBIBIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[DefaultMember("Item")]
public class BNNOEMHACOH<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private global::BNNOEMHACOH<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x41214C0", Offset = "0x411FEC0", VA = "0x1841214C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x4123440", Offset = "0x4121E40", VA = "0x184123440")]
		public Enumerator(global::BNNOEMHACOH<T> CKDPLHPNFKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x411EC00", Offset = "0x411D600", VA = "0x18411EC00", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x411FE20", Offset = "0x411E820", VA = "0x18411FE20", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x411BE20", Offset = "0x411A820", VA = "0x18411BE20")]
		private void FKGOCEOGGOJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private T[] APLMHJDDDBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private int ACBJBFDCGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private int MMHNKCEJLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private int LHIPGOMOMEB;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int GNKNLJGDNJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3628470", Offset = "0x3626E70", VA = "0x183628470")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T KBLKMCBLENC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3628670", Offset = "0x3627070", VA = "0x183628670")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x362A0F0", Offset = "0x3628AF0", VA = "0x18362A0F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x362A380", Offset = "0x3628D80", VA = "0x18362A380")]
	public BNNOEMHACOH(int ICKPJJPJOOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x36292C0", Offset = "0x3627CC0", VA = "0x1836292C0")]
	public void IFPOOIAJHAI(T ENLKJOJFGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3628FD0", Offset = "0x36279D0", VA = "0x183628FD0")]
	public void GDFLELNAEGM(IEnumerable<T> ELHMOBCGDNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x362A1E0", Offset = "0x3628BE0", VA = "0x18362A1E0")]
	public void PDOAHDCGLGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x36284B0", Offset = "0x3626EB0", VA = "0x1836284B0")]
	public void FCKJOBFLALO(int HGMGPFAJPJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x36295B0", Offset = "0x3627FB0", VA = "0x1836295B0")]
	public void KDINPPNKCFA(int HGMGPFAJPJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3629A30", Offset = "0x3628430", VA = "0x183629A30")]
	public void LBHMDAPPMDG(T[] HPOICFFOIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3629F70", Offset = "0x3628970", VA = "0x183629F70")]
	public Enumerator ODEOKNNCFHI()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x362A200", Offset = "0x3628C00", VA = "0x18362A200", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x362A200", Offset = "0x3628C00", VA = "0x18362A200", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3629E50", Offset = "0x3628850", VA = "0x183629E50")]
	private int MJENDKDOKPD(int ALJOMNDNEBM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3628440", Offset = "0x3626E40", VA = "0x183628440")]
	private int ACBKNGIBOHA(int ALJOMNDNEBM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class OPJLJIMLKBN<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Func<Internal, External> NBBCAFHJANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Func<External, Internal> LPJAJCIHLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private IList<Internal> ECNPNAMGIHB;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IList<Internal> IMGOIBNLOAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6F0", Offset = "0x7AE0F0", VA = "0x1807AF6F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x831AC0", Offset = "0x8304C0", VA = "0x180831AC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool GOJJAFPEPMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x856FD0", Offset = "0x8559D0", VA = "0x180856FD0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x856FE0", Offset = "0x8559E0", VA = "0x180856FE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public External KBLKMCBLENC
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3B449C0", Offset = "0x3B433C0", VA = "0x183B449C0", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3B44A60", Offset = "0x3B43460", VA = "0x183B44A60", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int GNKNLJGDNJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3B44960", Offset = "0x3B43360", VA = "0x183B44960", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x3804580", Offset = "0x3802F80", VA = "0x183804580")]
	public OPJLJIMLKBN(Func<Internal, External> NBBCAFHJANO, Func<External, Internal> LPJAJCIHLAP, bool HMMIOMHIJFE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3B446D0", Offset = "0x3B430D0", VA = "0x183B446D0", Slot = "6")]
	public int IndexOf(External FPEJLKINELB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3B44350", Offset = "0x3B42D50", VA = "0x183B44350", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x3B443B0", Offset = "0x3B42DB0", VA = "0x183B443B0", Slot = "13")]
	public bool Contains(External FPEJLKINELB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3B44440", Offset = "0x3B42E40", VA = "0x183B44440", Slot = "14")]
	public void CopyTo(External[] HPOICFFOIAP, int IEPKLEKMEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3B442C0", Offset = "0x3B42CC0", VA = "0x183B442C0", Slot = "11")]
	public void Add(External FPEJLKINELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3B447C0", Offset = "0x3B431C0", VA = "0x183B447C0", Slot = "7")]
	public void Insert(int ALJOMNDNEBM, External FPEJLKINELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3B448D0", Offset = "0x3B432D0", VA = "0x183B448D0", Slot = "15")]
	public bool Remove(External FPEJLKINELB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3B44860", Offset = "0x3B43260", VA = "0x183B44860", Slot = "8")]
	public void RemoveAt(int ALJOMNDNEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3B44660", Offset = "0x3B43060", VA = "0x183B44660", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x327A800", Offset = "0x3279200", VA = "0x18327A800", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class HCHNHGELLFF<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly Func<Internal, External> NBBCAFHJANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private IReadOnlyList<Internal> ECNPNAMGIHB;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyList<Internal> IMGOIBNLOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7D2590", Offset = "0x7D0F90", VA = "0x1807D2590")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool GOJJAFPEPMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7FDE80", Offset = "0x7FC880", VA = "0x1807FDE80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public External KBLKMCBLENC
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x45543A0", Offset = "0x4552DA0", VA = "0x1845543A0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int GNKNLJGDNJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x4554340", Offset = "0x4552D40", VA = "0x184554340", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x34E7CA0", Offset = "0x34E66A0", VA = "0x1834E7CA0")]
	public HCHNHGELLFF(Func<Internal, External> NBBCAFHJANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x45542F0", Offset = "0x4552CF0", VA = "0x1845542F0")]
	public HCHNHGELLFF(IReadOnlyList<Internal> ECNPNAMGIHB, Func<Internal, External> NBBCAFHJANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x45540D0", Offset = "0x4552AD0", VA = "0x1845540D0")]
	public void LBHMDAPPMDG(External[] HPOICFFOIAP, int IEPKLEKMEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x4554060", Offset = "0x4552A60", VA = "0x184554060", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3631A40", Offset = "0x3630440", VA = "0x183631A40", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[DefaultMember("Item")]
public class NBCBIMILMPP<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private IReadOnlyList<Internal> ECNPNAMGIHB;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IReadOnlyList<Internal> IMGOIBNLOAH
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7D2880", Offset = "0x7D1280", VA = "0x1807D2880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool GOJJAFPEPMK
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7FDE80", Offset = "0x7FC880", VA = "0x1807FDE80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public External KBLKMCBLENC
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x390B710", Offset = "0x390A110", VA = "0x18390B710", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int GNKNLJGDNJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x390B6B0", Offset = "0x390A0B0", VA = "0x18390B6B0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x34E7CA0", Offset = "0x34E66A0", VA = "0x1834E7CA0")]
	public NBCBIMILMPP(IReadOnlyList<Internal> ECNPNAMGIHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x390B370", Offset = "0x3909D70", VA = "0x18390B370")]
	public bool AAFBPIPDPOL(External FPEJLKINELB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x390B480", Offset = "0x3909E80", VA = "0x18390B480")]
	public void LBHMDAPPMDG(External[] HPOICFFOIAP, int IEPKLEKMEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x390B410", Offset = "0x3909E10", VA = "0x18390B410", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x327A800", Offset = "0x3279200", VA = "0x18327A800", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public abstract class PIIOKMKKCCI
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void JPEIFGDINJG(object[] LIKLGHJBPPH);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	protected PIIOKMKKCCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public abstract class JGLHGMFHPIJ<T> : PIIOKMKKCCI
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	protected struct IFFOGOMAGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public enum ABLPAMHFCIP
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
		public ABLPAMHFCIP EMKINACMDLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public T DJJNLDOINEG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int CENGAEEFEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly bool PLHPGHEMALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	protected readonly bool LNHBAGDDKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	protected List<T> GAKGMGODICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<IFFOGOMAGCJ> POJAGNLGLHE;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool AMECPEFPCHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x3FCC5D0", Offset = "0x3FCAFD0", VA = "0x183FCC5D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3FCCCB0", Offset = "0x3FCB6B0", VA = "0x183FCCCB0")]
	protected JGLHGMFHPIJ(bool LNHBAGDDKGL, bool PLHPGHEMALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3FCC610", Offset = "0x3FCB010", VA = "0x183FCC610")]
	protected bool GDKKOEFPEPL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3FCCAE0", Offset = "0x3FCB4E0", VA = "0x183FCCAE0")]
	protected void PCBKNDCELDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3FCC930", Offset = "0x3FCB330", VA = "0x183FCC930")]
	protected void KKMJDGJEMON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x35627A0", Offset = "0x35611A0", VA = "0x1835627A0")]
	private static void APJBDAFEPAA<U>(ref List<U> ECNPNAMGIHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3FCC7D0", Offset = "0x3FCB1D0", VA = "0x183FCC7D0", Slot = "5")]
	public void IFPOOIAJHAI(T DJJNLDOINEG, bool ACKGEKKJDDC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x3FCC690", Offset = "0x3FCB090", VA = "0x183FCC690", Slot = "6")]
	public void HEOHJOBENDL(T DJJNLDOINEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3FCCBA0", Offset = "0x3FCB5A0", VA = "0x183FCCBA0")]
	public void PDOAHDCGLGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface JLOHCBFJAMF
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IFPOOIAJHAI(Action DJJNLDOINEG, bool ACKGEKKJDDC = false);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HEOHJOBENDL(Action DJJNLDOINEG);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public sealed class JAENCPCNABI : global::JGLHGMFHPIJ<Action>, JLOHCBFJAMF
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6A699E0", Offset = "0x6A683E0", VA = "0x186A699E0")]
	public JAENCPCNABI(bool LNHBAGDDKGL = false, bool PLHPGHEMALC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6A696A0", Offset = "0x6A680A0", VA = "0x186A696A0")]
	public void ADHECPIMCJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6A69970", Offset = "0x6A68370", VA = "0x186A69970", Slot = "4")]
	public override void JPEIFGDINJG(object[] LIKLGHJBPPH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6A69910", Offset = "0x6A68310", VA = "0x186A69910")]
	public static JAENCPCNABI JFLIOIDFJMD(JAENCPCNABI OMCKPCEFBBP, Action DJJNLDOINEG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6A698B0", Offset = "0x6A682B0", VA = "0x186A698B0")]
	public static JAENCPCNABI HEFAHJMMEJO(JAENCPCNABI OMCKPCEFBBP, Action DJJNLDOINEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface NFODNCFBKOE<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IFPOOIAJHAI(Action<T> DJJNLDOINEG, bool ACKGEKKJDDC = false);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HEOHJOBENDL(Action<T> DJJNLDOINEG);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class DMMLEDLKPJG<T> : global::JGLHGMFHPIJ<Action<T>>, global::NFODNCFBKOE<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3163170", Offset = "0x3161B70", VA = "0x183163170")]
	public DMMLEDLKPJG(bool LNHBAGDDKGL = false, bool PLHPGHEMALC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3B8A7D0", Offset = "0x3B891D0", VA = "0x183B8A7D0")]
	public void ADHECPIMCJJ(T ENLKJOJFGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3B8CBF0", Offset = "0x3B8B5F0", VA = "0x183B8CBF0", Slot = "4")]
	public override void JPEIFGDINJG(object[] LIKLGHJBPPH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x3B8B460", Offset = "0x3B89E60", VA = "0x183B8B460")]
	public static global::DMMLEDLKPJG<T> JFLIOIDFJMD(global::DMMLEDLKPJG<T> OMCKPCEFBBP, Action<T> DJJNLDOINEG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3B8B3C0", Offset = "0x3B89DC0", VA = "0x183B8B3C0")]
	public static global::DMMLEDLKPJG<T> HEFAHJMMEJO(global::DMMLEDLKPJG<T> OMCKPCEFBBP, Action<T> DJJNLDOINEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface PLLANLACOHL<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IFPOOIAJHAI(Action<T, U> DJJNLDOINEG, bool ACKGEKKJDDC = false);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HEOHJOBENDL(Action<T, U> DJJNLDOINEG);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class HGIFLDAHCKA<T, U> : global::JGLHGMFHPIJ<Action<T, U>>, global::PLLANLACOHL<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x3163170", Offset = "0x3161B70", VA = "0x183163170")]
	public HGIFLDAHCKA(bool LNHBAGDDKGL = false, bool PLHPGHEMALC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3E34A70", Offset = "0x3E33470", VA = "0x183E34A70")]
	public void ADHECPIMCJJ(T ENLKJOJFGLO, U BIFJNDBGKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3E37AB0", Offset = "0x3E364B0", VA = "0x183E37AB0", Slot = "4")]
	public override void JPEIFGDINJG(object[] LIKLGHJBPPH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x3E36200", Offset = "0x3E34C00", VA = "0x183E36200")]
	public static global::HGIFLDAHCKA<T, U> JFLIOIDFJMD(global::HGIFLDAHCKA<T, U> OMCKPCEFBBP, Action<T, U> DJJNLDOINEG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x3E36160", Offset = "0x3E34B60", VA = "0x183E36160")]
	public static global::HGIFLDAHCKA<T, U> HEFAHJMMEJO(global::HGIFLDAHCKA<T, U> OMCKPCEFBBP, Action<T, U> DJJNLDOINEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface DBNLNHBCOPI<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IFPOOIAJHAI(Action<T, U, V> DJJNLDOINEG, bool ACKGEKKJDDC = false);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HEOHJOBENDL(Action<T, U, V> DJJNLDOINEG);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class IINGBGFGMKE<T, U, V> : global::JGLHGMFHPIJ<Action<T, U, V>>, global::DBNLNHBCOPI<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x3163170", Offset = "0x3161B70", VA = "0x183163170")]
	public IINGBGFGMKE(bool LNHBAGDDKGL = false, bool PLHPGHEMALC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x32B3860", Offset = "0x32B2260", VA = "0x1832B3860")]
	public void ADHECPIMCJJ(T ENLKJOJFGLO, U BIFJNDBGKPI, V PKKHHJKMKKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x32B54B0", Offset = "0x32B3EB0", VA = "0x1832B54B0", Slot = "4")]
	public override void JPEIFGDINJG(object[] LIKLGHJBPPH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x32B4780", Offset = "0x32B3180", VA = "0x1832B4780")]
	public static global::IINGBGFGMKE<T, U, V> JFLIOIDFJMD(global::IINGBGFGMKE<T, U, V> OMCKPCEFBBP, Action<T, U, V> DJJNLDOINEG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x32B46E0", Offset = "0x32B30E0", VA = "0x1832B46E0")]
	public static global::IINGBGFGMKE<T, U, V> HEFAHJMMEJO(global::IINGBGFGMKE<T, U, V> OMCKPCEFBBP, Action<T, U, V> DJJNLDOINEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface BBCPANICFOP<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IFPOOIAJHAI(Action<T, U, V, W> DJJNLDOINEG, bool ACKGEKKJDDC = false);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HEOHJOBENDL(Action<T, U, V, W> DJJNLDOINEG);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class EPDEBJOIPBE<T, U, V, W> : global::JGLHGMFHPIJ<Action<T, U, V, W>>, global::BBCPANICFOP<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3163170", Offset = "0x3161B70", VA = "0x183163170")]
	public EPDEBJOIPBE(bool LNHBAGDDKGL = false, bool PLHPGHEMALC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x31611E0", Offset = "0x315FBE0", VA = "0x1831611E0")]
	public void ADHECPIMCJJ(T ENLKJOJFGLO, U BIFJNDBGKPI, V PKKHHJKMKKB, W IEKEOJNEALB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x3162240", Offset = "0x3160C40", VA = "0x183162240", Slot = "4")]
	public override void JPEIFGDINJG(object[] LIKLGHJBPPH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x3161C60", Offset = "0x3160660", VA = "0x183161C60")]
	public static global::EPDEBJOIPBE<T, U, V, W> JFLIOIDFJMD(global::EPDEBJOIPBE<T, U, V, W> OMCKPCEFBBP, Action<T, U, V, W> DJJNLDOINEG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x3161BC0", Offset = "0x31605C0", VA = "0x183161BC0")]
	public static global::EPDEBJOIPBE<T, U, V, W> HEFAHJMMEJO(global::EPDEBJOIPBE<T, U, V, W> OMCKPCEFBBP, Action<T, U, V, W> DJJNLDOINEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface LDEKOLNAJLL<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IFPOOIAJHAI(Action<T, U, V, W, X> DJJNLDOINEG, bool ACKGEKKJDDC = false);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HEOHJOBENDL(Action<T, U, V, W, X> DJJNLDOINEG);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class CJJNMJICBOO<T, U, V, W, X> : global::JGLHGMFHPIJ<Action<T, U, V, W, X>>, global::LDEKOLNAJLL<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x3163170", Offset = "0x3161B70", VA = "0x183163170")]
	public CJJNMJICBOO(bool LNHBAGDDKGL = false, bool PLHPGHEMALC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x4537D90", Offset = "0x4536790", VA = "0x184537D90")]
	public void ADHECPIMCJJ(T ENLKJOJFGLO, U BIFJNDBGKPI, V PKKHHJKMKKB, W IEKEOJNEALB, X KCAHJOFJKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x4538490", Offset = "0x4536E90", VA = "0x184538490", Slot = "4")]
	public override void JPEIFGDINJG(object[] LIKLGHJBPPH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x45383F0", Offset = "0x4536DF0", VA = "0x1845383F0")]
	public static global::CJJNMJICBOO<T, U, V, W, X> JFLIOIDFJMD(global::CJJNMJICBOO<T, U, V, W, X> OMCKPCEFBBP, Action<T, U, V, W, X> DJJNLDOINEG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x4538350", Offset = "0x4536D50", VA = "0x184538350")]
	public static global::CJJNMJICBOO<T, U, V, W, X> HEFAHJMMEJO(global::CJJNMJICBOO<T, U, V, W, X> OMCKPCEFBBP, Action<T, U, V, W, X> DJJNLDOINEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface OKOMDKGLLCD<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IFPOOIAJHAI(Action<T, U, V, W, X, Y> DJJNLDOINEG, bool ACKGEKKJDDC = false);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HEOHJOBENDL(Action<T, U, V, W, X, Y> DJJNLDOINEG);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class PHJAHDIEFHG<T, U, V, W, X, Y> : global::JGLHGMFHPIJ<Action<T, U, V, W, X, Y>>, global::OKOMDKGLLCD<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3163170", Offset = "0x3161B70", VA = "0x183163170")]
	public PHJAHDIEFHG(bool LNHBAGDDKGL = false, bool PLHPGHEMALC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x43D4560", Offset = "0x43D2F60", VA = "0x1843D4560")]
	public void ADHECPIMCJJ(T ENLKJOJFGLO, U BIFJNDBGKPI, V PKKHHJKMKKB, W IEKEOJNEALB, X KCAHJOFJKBP, Y NBBBAMBDAJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x43D55E0", Offset = "0x43D3FE0", VA = "0x1843D55E0", Slot = "4")]
	public override void JPEIFGDINJG(object[] LIKLGHJBPPH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x43D4E80", Offset = "0x43D3880", VA = "0x1843D4E80")]
	public static global::PHJAHDIEFHG<T, U, V, W, X, Y> JFLIOIDFJMD(global::PHJAHDIEFHG<T, U, V, W, X, Y> OMCKPCEFBBP, Action<T, U, V, W, X, Y> DJJNLDOINEG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x43D4DE0", Offset = "0x43D37E0", VA = "0x1843D4DE0")]
	public static global::PHJAHDIEFHG<T, U, V, W, X, Y> HEFAHJMMEJO(global::PHJAHDIEFHG<T, U, V, W, X, Y> OMCKPCEFBBP, Action<T, U, V, W, X, Y> DJJNLDOINEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class GLFLMCONMHA<T>
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public readonly struct JNIIBJPMKME : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly global::GLFLMCONMHA<T> DECIKEBPMPI;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public T ONBMIOJBCHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x3FD30A0", Offset = "0x3FD1AA0", VA = "0x183FD30A0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3FD30C0", Offset = "0x3FD1AC0", VA = "0x183FD30C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x875C70", Offset = "0x874670", VA = "0x180875C70")]
		public JNIIBJPMKME(global::GLFLMCONMHA<T> DECIKEBPMPI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct INJECGFGGDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder<JNIIBJPMKME> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public global::GLFLMCONMHA<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x32C5640", Offset = "0x32C4040", VA = "0x1832C5640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x2F0D3D0", Offset = "0x2F0BDD0", VA = "0x182F0D3D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct OBMEDGBCOLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AsyncTaskMethodBuilder<JNIIBJPMKME> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public global::GLFLMCONMHA<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x389ACC0", Offset = "0x38996C0", VA = "0x18389ACC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x2F0D3D0", Offset = "0x2F0BDD0", VA = "0x182F0D3D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly SemaphoreSlim AOCCHMNGNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private T ICGNJELMMFG;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int ENAKOPHKGBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x3FF6120", Offset = "0x3FF4B20", VA = "0x183FF6120")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x3FF6290", Offset = "0x3FF4C90", VA = "0x183FF6290")]
	public GLFLMCONMHA(in T ICGNJELMMFG, int EAIIIKBHCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x3FF61C0", Offset = "0x3FF4BC0", VA = "0x183FF61C0")]
	public GLFLMCONMHA(in T ICGNJELMMFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x3FF6140", Offset = "0x3FF4B40", VA = "0x183FF6140")]
	public JNIIBJPMKME PKOEPMCEGGH()
	{
		return default(JNIIBJPMKME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3FF6180", Offset = "0x3FF4B80", VA = "0x183FF6180")]
	public JNIIBJPMKME PKOEPMCEGGH(CancellationToken FAPLHFKLMOL)
	{
		return default(JNIIBJPMKME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x3FF5B80", Offset = "0x3FF4580", VA = "0x183FF5B80")]
	[AsyncStateMachine(typeof(global::GLFLMCONMHA<>.INJECGFGGDP))]
	public Task<JNIIBJPMKME> BMLLMKEEBAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x3FF5E50", Offset = "0x3FF4850", VA = "0x183FF5E50")]
	[AsyncStateMachine(typeof(global::GLFLMCONMHA<>.OBMEDGBCOLB))]
	public Task<JNIIBJPMKME> BMLLMKEEBAK(CancellationToken FAPLHFKLMOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class DEOANMJLBID
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6A68B10", Offset = "0x6A67510", VA = "0x186A68B10")]
	public static global::GLFLMCONMHA<LEKKGHCNCEK> IDLIIDOEAFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6A68AA0", Offset = "0x6A674A0", VA = "0x186A68AA0")]
	public static global::GLFLMCONMHA<LEKKGHCNCEK> IDLIIDOEAFG(int EAIIIKBHCMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2918CA0", Offset = "0x29176A0", VA = "0x182918CA0")]
	public static global::GLFLMCONMHA<T> IDLIIDOEAFG<T>(in T ICGNJELMMFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x292C9A0", Offset = "0x292B3A0", VA = "0x18292C9A0")]
	public static global::GLFLMCONMHA<T> IDLIIDOEAFG<T>(in T ICGNJELMMFG, int EAIIIKBHCMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class CGBPKHNPMDG<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public delegate Task<TResult> HBCBPPMMLCO(TRequest CEKCHJKLGMA, CancellationToken FAPLHFKLMOL);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public enum JCCOAIHNJMC
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class HKPOLKJELJA
	{
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private const float EANCLJFOLJJ = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TimeSpan KNCJMIFIIFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int DBNLKDJGCCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public JCCOAIHNJMC HEAJINAHDIH;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly HKPOLKJELJA NHIBPFHOELB;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float PGNDGABCGAK
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x4736430", Offset = "0x4734E30", VA = "0x184736430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TimeSpan GACMBCEIMPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x47365F0", Offset = "0x4734FF0", VA = "0x1847365F0")]
		public HKPOLKJELJA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private readonly struct IHEDFBPHABP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly TRequest CEKCHJKLGMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public readonly CancellationToken FAPLHFKLMOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public readonly TaskCompletionSource<TResult> IAMCJDDLKBG;

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x36DF180", Offset = "0x36DDB80", VA = "0x1836DF180")]
		public IHEDFBPHABP(TRequest CEKCHJKLGMA, TaskCompletionSource<TResult> IAMCJDDLKBG, CancellationToken FAPLHFKLMOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class CDFOLDFNJJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x25118A0", Offset = "0x25102A0", VA = "0x1825118A0")]
		public CDFOLDFNJJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2A08AA0", Offset = "0x2A074A0", VA = "0x182A08AA0")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct EEPCNIBBLLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public global::CGBPKHNPMDG<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3D55130", Offset = "0x3D53B30", VA = "0x183D55130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x9396C0", Offset = "0x9380C0", VA = "0x1809396C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct OHFIJGBLKJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public global::CGBPKHNPMDG<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private IHEDFBPHABP <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3EDB810", Offset = "0x3EDA210", VA = "0x183EDB810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x9396C0", Offset = "0x9380C0", VA = "0x1809396C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CancellationTokenSource EJAEKOKGONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly List<IHEDFBPHABP> HBCBIHCBONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly HKPOLKJELJA LCIDGONKPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly HBCBPPMMLCO EHLFGGFDMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Task IMHLBJBMOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int CPBLDEIKOGE;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x42AD340", Offset = "0x42ABD40", VA = "0x1842AD340")]
	public CGBPKHNPMDG(HBCBPPMMLCO EHLFGGFDMFP, [Optional] HKPOLKJELJA LCIDGONKPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x42ABDB0", Offset = "0x42AA7B0", VA = "0x1842ABDB0")]
	public Task<TResult> ECBMGCECELI(TRequest CEKCHJKLGMA, CancellationToken FAPLHFKLMOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x42ABBA0", Offset = "0x42AA5A0", VA = "0x1842ABBA0")]
	private void DLNPFFGIKCE(IHEDFBPHABP JIAMKGBJGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x42AB8A0", Offset = "0x42AA2A0", VA = "0x1842AB8A0")]
	[AsyncStateMachine(typeof(global::CGBPKHNPMDG<, >.EEPCNIBBLLK))]
	private Task BDLHPJMNEBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x42AC4C0", Offset = "0x42AAEC0", VA = "0x1842AC4C0")]
	private IHEDFBPHABP FBFLDCKHELO()
	{
		return default(IHEDFBPHABP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x42ACCE0", Offset = "0x42AB6E0", VA = "0x1842ACCE0")]
	[AsyncStateMachine(typeof(global::CGBPKHNPMDG<, >.OHFIJGBLKJJ))]
	private Task FFDHJHMAAJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x42AD0C0", Offset = "0x42ABAC0", VA = "0x1842AD0C0")]
	private void HOKGBCEGAEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x42ABD70", Offset = "0x42AA770", VA = "0x1842ABD70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[DefaultMember("Item")]
public class PFNIBDNAIEB<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly List<T> ECNPNAMGIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private HashSet<T> NCIJFFICMFE;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int GNKNLJGDNJB
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2A08AA0", Offset = "0x2A074A0", VA = "0x182A08AA0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool GOJJAFPEPMK
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7373D0", Offset = "0x735DD0", VA = "0x1807373D0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public T KBLKMCBLENC
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x347CDF0", Offset = "0x347B7F0", VA = "0x18347CDF0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3C64700", Offset = "0x3C63100", VA = "0x183C64700", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x3272080", Offset = "0x3270A80", VA = "0x183272080", Slot = "11")]
	public void Add(T FPEJLKINELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x3C64400", Offset = "0x3C62E00", VA = "0x183C64400")]
	public bool PLIOJAFPAGG(T FPEJLKINELB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3C64570", Offset = "0x3C62F70", VA = "0x183C64570", Slot = "15")]
	public bool Remove(T FPEJLKINELB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3C64260", Offset = "0x3C62C60", VA = "0x183C64260", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x3C645F0", Offset = "0x3C62FF0", VA = "0x183C645F0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x3C64100", Offset = "0x3C62B00", VA = "0x183C64100", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x3802010", Offset = "0x3800A10", VA = "0x183802010", Slot = "13")]
	public bool Contains(T FPEJLKINELB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x3C64160", Offset = "0x3C62B60", VA = "0x183C64160", Slot = "14")]
	public void CopyTo(T[] HPOICFFOIAP, int IEPKLEKMEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x3C642E0", Offset = "0x3C62CE0", VA = "0x183C642E0", Slot = "6")]
	public int IndexOf(T FPEJLKINELB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x3C64310", Offset = "0x3C62D10", VA = "0x183C64310", Slot = "7")]
	public void Insert(int ALJOMNDNEBM, T FPEJLKINELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x3C644A0", Offset = "0x3C62EA0", VA = "0x183C644A0", Slot = "8")]
	public void RemoveAt(int ALJOMNDNEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x3C64190", Offset = "0x3C62B90", VA = "0x183C64190")]
	public void FNJCFDMDFDI(Predicate<T> KEJJCNMBGLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x3C643D0", Offset = "0x3C62DD0", VA = "0x183C643D0")]
	public void JNECJFMIGPJ(Comparison<T> CCKNFHPCDFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x3C64620", Offset = "0x3C63020", VA = "0x183C64620")]
	public PFNIBDNAIEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class AJGCDOOAEAM
{
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6A67AE0", Offset = "0x6A664E0", VA = "0x186A67AE0")]
	public static Vector3 EKLGJJNCLCK(this GameObject OJBDJCCAFCN, float BGIJKEHGALC)
	{
		return default(Vector3);
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xDBF170", Offset = "0xDBDB70", VA = "0x180DBF170")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x1CE5A30", Offset = "0x1CE4430", VA = "0x181CE5A30")]
		public SerializedGuid(in Guid GDCMPFDFIDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E9B0", Offset = "0x6A6D3B0", VA = "0x186A6E9B0")]
		public static SerializedGuid KAPNLMPAIAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E790", Offset = "0x6A6D190", VA = "0x186A6E790")]
		public static SerializedGuid DLJIOFMJFGI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x6A6EAD0", Offset = "0x6A6D4D0", VA = "0x186A6EAD0")]
		public bool MPMONFPIFAG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x1CE5A00", Offset = "0x1CE4400", VA = "0x181CE5A00", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x6A6EB60", Offset = "0x6A6D560", VA = "0x186A6EB60", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x6A6EA40", Offset = "0x6A6D440", VA = "0x186A6EA40")]
		public bool KHPOGCBLNFJ(in Guid GDCMPFDFIDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E820", Offset = "0x6A6D220", VA = "0x186A6E820", Slot = "7")]
		public bool Equals(SerializedGuid EHBPAFKHADK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E8D0", Offset = "0x6A6D2D0", VA = "0x186A6E8D0", Slot = "0")]
		public override bool Equals(object OMHIFHKMIMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x1CE5950", Offset = "0x1CE4350", VA = "0x181CE5950", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x1CE5790", Offset = "0x1CE4190", VA = "0x181CE5790", Slot = "6")]
		public int CompareTo(SerializedGuid EHBPAFKHADK)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class PHDJDNEPFPO : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly Type GKLPCJPHGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly string KGEBLKIABHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly bool CMADKOHMBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly bool LNBGNKJOOFG;

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6A6CFE0", Offset = "0x6A6B9E0", VA = "0x186A6CFE0")]
	public PHDJDNEPFPO(Type IGAAMECPKOJ, string FHEJKNKGNKO, bool GIEDLPCGGPE = false, bool PBBLBINEPIA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface DFAJBMNCBLN
{
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface EGLPKIIFOJK<T> : DFAJBMNCBLN
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	T ONBMIOJBCHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool FHNFDNNKLLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	string NCIEAJKFMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::EGLPKIIFOJK<T> PLHCEGJJIJK(Action<T> GLMOIHECAFP);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::EGLPKIIFOJK<T> LFBANIPGHHP(Action<T> GLMOIHECAFP);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::EGLPKIIFOJK<T> NAFEPMFDMAF(Action<T, T> ELDMOMFDPIK);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::EGLPKIIFOJK<T> LFLMMIHAHOI(Action<T, T> ELDMOMFDPIK);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::EGLPKIIFOJK<T> CNFAIJGKLAO(Action<string> DGKKDGGEBAK);

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::EGLPKIIFOJK<T> AOJIKEPDMDG(Action<string> DGKKDGGEBAK);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class FEEAMOHNDKO<T> : global::EGLPKIIFOJK<T>, DFAJBMNCBLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private global::HGIFLDAHCKA<T, T> EIMJOCHDICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private global::DMMLEDLKPJG<T> NKMOBANKAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private global::DMMLEDLKPJG<string> GHJOFKECJAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private string MCCDEFDHGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private T MIMDGHHHHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private bool MALJCHCEHFJ;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public T ONBMIOJBCHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x738BA0", Offset = "0x7375A0", VA = "0x180738BA0", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3283460", Offset = "0x3281E60", VA = "0x183283460", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool FHNFDNNKLLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x878090", Offset = "0x876A90", VA = "0x180878090", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public string NCIEAJKFMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x737430", Offset = "0x735E30", VA = "0x180737430", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x2691170", Offset = "0x268FB70", VA = "0x182691170", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x382F030", Offset = "0x382DA30", VA = "0x18382F030")]
	private void AGPCCBACEAN(T CBBKOHPGNJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x382F290", Offset = "0x382DC90", VA = "0x18382F290")]
	private void JDGHGMNPHCG(string MDEEJIBNIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x382F140", Offset = "0x382DB40", VA = "0x18382F140")]
	public void CIPJLEDKNPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x382F3E0", Offset = "0x382DDE0", VA = "0x18382F3E0", Slot = "6")]
	public global::EGLPKIIFOJK<T> NAFEPMFDMAF(Action<T, T> ELDMOMFDPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x382F390", Offset = "0x382DD90", VA = "0x18382F390", Slot = "7")]
	public global::EGLPKIIFOJK<T> LFLMMIHAHOI(Action<T, T> ELDMOMFDPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x382F430", Offset = "0x382DE30", VA = "0x18382F430", Slot = "4")]
	public global::EGLPKIIFOJK<T> PLHCEGJJIJK(Action<T> ELDMOMFDPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x382F340", Offset = "0x382DD40", VA = "0x18382F340", Slot = "5")]
	public global::EGLPKIIFOJK<T> LFBANIPGHHP(Action<T> GLMOIHECAFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x382F1F0", Offset = "0x382DBF0", VA = "0x18382F1F0", Slot = "8")]
	public global::EGLPKIIFOJK<T> CNFAIJGKLAO(Action<string> DGKKDGGEBAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x382F0D0", Offset = "0x382DAD0", VA = "0x18382F0D0", Slot = "9")]
	public global::EGLPKIIFOJK<T> AOJIKEPDMDG(Action<string> DGKKDGGEBAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x382F4C0", Offset = "0x382DEC0", VA = "0x18382F4C0")]
	public FEEAMOHNDKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class NFGFMMKGBNF
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class CPFDHJFFKMG<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public global::EGLPKIIFOJK<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public global::APDKDJOBEAE<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x25118A0", Offset = "0x25102A0", VA = "0x1825118A0")]
		public CPFDHJFFKMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x42846A0", Offset = "0x42830A0", VA = "0x1842846A0")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x3C809C0", Offset = "0x3C7F3C0", VA = "0x183C809C0")]
	public static global::DJAOLOOILHN<T> JILIAHNOHMA<T>(this global::EGLPKIIFOJK<T> PKPPCIKIIJB, Action<T> KFICNKMCGGK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class NKNMKIOICJF<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public readonly struct FPHHPOGINLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public readonly long PNFMKFPEIBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public readonly long PKLIAGMKJMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public readonly int PJHCFJDFHLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public readonly int FIECGALLCHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public readonly bool NHPDMGOIEOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private readonly string NPKOCPMOIBG;

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x4660830", Offset = "0x465F230", VA = "0x184660830")]
		public FPHHPOGINLK(long PNFMKFPEIBD, int PJHCFJDFHLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x46608A0", Offset = "0x465F2A0", VA = "0x1846608A0")]
		public FPHHPOGINLK(long PNFMKFPEIBD, long PKLIAGMKJMC, int PJHCFJDFHLJ, int FIECGALLCHD, bool NHPDMGOIEOJ, string NPKOCPMOIBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x4660730", Offset = "0x465F130", VA = "0x184660730")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void LLGHMKNPCKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x46606E0", Offset = "0x465F0E0", VA = "0x1846606E0")]
		public int ELGDJPAGMDN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x46606C0", Offset = "0x465F0C0", VA = "0x1846606C0")]
		public int CJDEHMPBJFE(int OPPLLEHOLMJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x4660650", Offset = "0x465F050", VA = "0x184660650")]
		public double AFOLJBGDNPH()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x46607A0", Offset = "0x465F1A0", VA = "0x1846607A0")]
		public FPHHPOGINLK MKHDEJLLIHM(long PKLIAGMKJMC, int FIECGALLCHD)
		{
			return default(FPHHPOGINLK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class FPPGLJFLHHB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public readonly TKey LAPHJCILMHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private readonly global::NKNMKIOICJF<TKey> FCGBKHLAIBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private List<FPPGLJFLHHB> DNLCNIJJKDF;

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string JJKLLEMOMNO
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x3612190", Offset = "0x3610B90", VA = "0x183612190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x39C2640", Offset = "0x39C1040", VA = "0x1839C2640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public IEnumerable<FPPGLJFLHHB> PLEEMIOGEJD
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x4665F00", Offset = "0x4664900", VA = "0x184665F00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public FPHHPOGINLK JJBNPGABJDP
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xCF53B0", Offset = "0xCF3DB0", VA = "0x180CF53B0")]
			[CompilerGenerated]
			get
			{
				return default(FPHHPOGINLK);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x4665DF0", Offset = "0x46647F0", VA = "0x184665DF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x4665F20", Offset = "0x4664920", VA = "0x184665F20")]
		internal FPPGLJFLHHB(global::NKNMKIOICJF<TKey> FCGBKHLAIBH, TKey IGFDDANAMMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x4665B20", Offset = "0x4664520", VA = "0x184665B20")]
		public FPPGLJFLHHB BDKFPKFKBGN(TKey IGFDDANAMMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x4665E20", Offset = "0x4664820", VA = "0x184665E20")]
		public void JJGMFFCAGAC(TKey IGFDDANAMMH, Action<FPPGLJFLHHB> DJJNLDOINEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x35598C0", Offset = "0x35582C0", VA = "0x1835598C0")]
		public T JJGMFFCAGAC<T>(TKey IGFDDANAMMH, Func<FPPGLJFLHHB, T> KOKFMIAEJPJ)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x3559750", Offset = "0x3558150", VA = "0x183559750")]
		[AsyncStateMachine(typeof(DOEPJNEHINE))]
		public Task<T> EAHIJAPKPJB<T>(TKey IGFDDANAMMH, Func<FPPGLJFLHHB, Task<T>> KOKFMIAEJPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x4665C30", Offset = "0x4664630", VA = "0x184665C30", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class IBIGJJPKOEP : IEnumerable<(TKey, List<TKey>, FPHHPOGINLK)>, IEnumerable, IEnumerator<(TKey, List<TKey>, FPHHPOGINLK)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private (TKey key, List<TKey> path, FPHHPOGINLK timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public global::NKNMKIOICJF<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private IEnumerator<(TKey key, List<TKey> path, FPHHPOGINLK timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		private (TKey, List<TKey>, FPHHPOGINLK) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x4053BD0", Offset = "0x40525D0", VA = "0x184053BD0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, FPHHPOGINLK));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x4053C40", Offset = "0x4052640", VA = "0x184053C40", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x4053CF0", Offset = "0x40526F0", VA = "0x184053CF0")]
		[DebuggerHidden]
		public IBIGJJPKOEP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x3144E90", Offset = "0x3143890", VA = "0x183144E90", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x4053860", Offset = "0x4052260", VA = "0x184053860", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x4053CA0", Offset = "0x40526A0", VA = "0x184053CA0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x4053C00", Offset = "0x4052600", VA = "0x184053C00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x4053B10", Offset = "0x4052510", VA = "0x184053B10", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, FPHHPOGINLK)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x34E8C50", Offset = "0x34E7650", VA = "0x1834E8C50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class CPIFDIIJHJC : IEnumerable<(TKey, List<TKey>, FPHHPOGINLK)>, IEnumerable, IEnumerator<(TKey, List<TKey>, FPHHPOGINLK)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private (TKey key, List<TKey> path, FPHHPOGINLK timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private FPPGLJFLHHB timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public FPPGLJFLHHB <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public global::NKNMKIOICJF<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private IEnumerator<FPPGLJFLHHB> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private IEnumerator<(TKey key, List<TKey> path, FPHHPOGINLK timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		private (TKey, List<TKey>, FPHHPOGINLK) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x4053BD0", Offset = "0x40525D0", VA = "0x184053BD0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, FPHHPOGINLK));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x4286030", Offset = "0x4284A30", VA = "0x184286030", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x4053CF0", Offset = "0x40526F0", VA = "0x184053CF0")]
		[DebuggerHidden]
		public CPIFDIIJHJC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x4286090", Offset = "0x4284A90", VA = "0x184286090", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4285940", Offset = "0x4284340", VA = "0x184285940", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x4286130", Offset = "0x4284B30", VA = "0x184286130")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x4286190", Offset = "0x4284B90", VA = "0x184286190")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x4285FF0", Offset = "0x42849F0", VA = "0x184285FF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x4285EE0", Offset = "0x42848E0", VA = "0x184285EE0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, FPHHPOGINLK)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x4285FC0", Offset = "0x42849C0", VA = "0x184285FC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly Action<TKey, FPHHPOGINLK> FOIDHLJNBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly Action<TKey, FPHHPOGINLK> IIMFCMGMDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly Action<global::NKNMKIOICJF<TKey>> ONFLGDBEEBF;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private const string GGANABCMPNM = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly FPPGLJFLHHB ANDMGEJBGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private bool FNOJIFMFPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int LHBABGMIAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly Stopwatch BNLNLKOJKLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly int OIJPDIBCGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private string OMBDCNIIJIE;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public FPPGLJFLHHB EGLNJCMPLPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x737430", Offset = "0x735E30", VA = "0x180737430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	[NotNull]
	public string JJKLLEMOMNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x73B590", Offset = "0x739F90", VA = "0x18073B590")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x327A940", Offset = "0x3279340", VA = "0x18327A940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public long IAEEOOLABAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x327A9F0", Offset = "0x32793F0", VA = "0x18327A9F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int CIPCCPFJCJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x327A9A0", Offset = "0x32793A0", VA = "0x18327A9A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x327AB90", Offset = "0x3279590", VA = "0x18327AB90")]
	public NKNMKIOICJF(TKey PFIOINALEHE, [Optional] int? PJHCFJDFHLJ, [Optional][CanBeNull] Stopwatch BNLNLKOJKLA, [Optional] Action<TKey, FPHHPOGINLK> FOIDHLJNBNJ, [Optional] Action<TKey, FPHHPOGINLK> IIMFCMGMDID, [Optional] Action<global::NKNMKIOICJF<TKey>> ONFLGDBEEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x327A8B0", Offset = "0x32792B0", VA = "0x18327A8B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x327AA10", Offset = "0x3279410", VA = "0x18327AA10")]
	public void KJEGPNJBOEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x327A9D0", Offset = "0x32793D0", VA = "0x18327A9D0")]
	public void JGLEDBIPOMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x327AB00", Offset = "0x3279500", VA = "0x18327AB00")]
	[IteratorStateMachine(typeof(global::NKNMKIOICJF<>.IBIGJJPKOEP))]
	public IEnumerable<(TKey, List<TKey>, FPHHPOGINLK)> OPHIHNGBJOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x327AA30", Offset = "0x3279430", VA = "0x18327AA30")]
	[IteratorStateMachine(typeof(global::NKNMKIOICJF<>.CPIFDIIJHJC))]
	private IEnumerable<(TKey, List<TKey>, FPHHPOGINLK)> OPHIHNGBJOH(List<TKey> KEADNAEDGGE, FPPGLJFLHHB JOEOPOODNOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x327A830", Offset = "0x3279230", VA = "0x18327A830")]
	private (long, int) DFLDBPEDBAC()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public abstract class JKMPNCNBNNJ<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut FODHCGJKGOD(global::NKNMKIOICJF<TKey> FCGBKHLAIBH);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x25118A0", Offset = "0x25102A0", VA = "0x1825118A0")]
	protected JKMPNCNBNNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public abstract class NKLPCMFEKHG<TKey> : global::JKMPNCNBNNJ<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public delegate string JFNCHIHALGE(TKey IGFDDANAMMH);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x327A790", Offset = "0x3279190", VA = "0x18327A790")]
	protected string GLLPGNHMEHM(double PKBFGDGCDND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x327A510", Offset = "0x3278F10", VA = "0x18327A510")]
	protected string CKDBCCONCBI(int FLDAHFKODBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x327A570", Offset = "0x3278F70", VA = "0x18327A570")]
	private static string DDJPIKHGKDK(TKey IGFDDANAMMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x327A6E0", Offset = "0x32790E0", VA = "0x18327A6E0", Slot = "4")]
	public override string FODHCGJKGOD(global::NKNMKIOICJF<TKey> FCGBKHLAIBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x327A5B0", Offset = "0x3278FB0", VA = "0x18327A5B0")]
	public string FODHCGJKGOD(global::NKNMKIOICJF<TKey> FCGBKHLAIBH, [NotNull] JFNCHIHALGE EEADCOODNNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string MHHJNKJCJKL(global::NKNMKIOICJF<TKey> FCGBKHLAIBH, [NotNull] JFNCHIHALGE EEADCOODNNN);

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x327A800", Offset = "0x3279200", VA = "0x18327A800")]
	protected NKLPCMFEKHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class BHIMGBBBEGL<TKey> : global::JKMPNCNBNNJ<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public delegate string MMKJLALJPDF(TKey IGFDDANAMMH);

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private const int EJPPPDNAPEE = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly string DFPIPGPLNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly double JIKKCBANLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly bool NCPIKFKKMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly int IHHAAHPNPPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly ISet<string> NMKIBAOMPIH;

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x487D4A0", Offset = "0x487BEA0", VA = "0x18487D4A0")]
	private static string DDJPIKHGKDK(TKey IGFDDANAMMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x487DE00", Offset = "0x487C800", VA = "0x18487DE00")]
	public BHIMGBBBEGL(string DFPIPGPLNCF = "F2", double JIKKCBANLAC = double.MaxValue, bool NCPIKFKKMGG = false, int IHHAAHPNPPA = int.MaxValue, [Optional] ISet<string> NMKIBAOMPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x487D660", Offset = "0x487C060", VA = "0x18487D660", Slot = "4")]
	public override Dictionary<string, string> FODHCGJKGOD(global::NKNMKIOICJF<TKey> FCGBKHLAIBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x487D3C0", Offset = "0x487BDC0", VA = "0x18487D3C0")]
	private bool BPOAJGMHNMP(string HCIEPLICGOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x487D710", Offset = "0x487C110", VA = "0x18487D710")]
	public Dictionary<string, string> FODHCGJKGOD(global::NKNMKIOICJF<TKey> FCGBKHLAIBH, MMKJLALJPDF EEADCOODNNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x487DC50", Offset = "0x487C650", VA = "0x18487DC50")]
	private string HMHEDHINFFM(StringBuilder HJFIKHHHAEI, List<TKey> PAIBCLOHHPN, MMKJLALJPDF EEADCOODNNN, bool PHFCGJDPHJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x487D4E0", Offset = "0x487BEE0", VA = "0x18487D4E0")]
	private static void FEFCLEBCEEE(StringBuilder FPMOGHLGMOB, string HDJJIEAAGPE, bool IJOHPBLNPDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class JJHILEJLIEJ<TKey> : global::NKLPCMFEKHG<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private struct FIJPMHFPLJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public JFNCHIHALGE keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public static global::JJHILEJLIEJ<TKey> FINLHCLDLDF;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private const int NPGJLPMMCMM = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly string[] KKPLJMJCJKO;

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x3FD1410", Offset = "0x3FCFE10", VA = "0x183FD1410")]
	private JJHILEJLIEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x3FD03D0", Offset = "0x3FCEDD0", VA = "0x183FD03D0", Slot = "5")]
	protected override string MHHJNKJCJKL(global::NKNMKIOICJF<TKey> FCGBKHLAIBH, JFNCHIHALGE EEADCOODNNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x3FD02E0", Offset = "0x3FCECE0", VA = "0x183FD02E0")]
	[CompilerGenerated]
	internal static string JDDAHLHHHEB(string LBHKBMNMKMI, TKey IGFDDANAMMH, ref FIJPMHFPLJO P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class NKLFAMHGOGE<TKey> : global::NKLPCMFEKHG<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class BKLMHFEEBKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public JFNCHIHALGE keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x25118A0", Offset = "0x25102A0", VA = "0x1825118A0")]
		public BKLMHFEEBKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x34E7120", Offset = "0x34E5B20", VA = "0x1834E7120")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x3279BF0", Offset = "0x32785F0", VA = "0x183279BF0", Slot = "5")]
	protected override string MHHJNKJCJKL(global::NKNMKIOICJF<TKey> FCGBKHLAIBH, JFNCHIHALGE EEADCOODNNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x327A4E0", Offset = "0x3278EE0", VA = "0x18327A4E0")]
	public NKLFAMHGOGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public sealed class AAFIMFCLDIL : global::NKNMKIOICJF<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class MIDADEMMNJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Action<AAFIMFCLDIL> callback;

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public MIDADEMMNJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x6A6C570", Offset = "0x6A6AF70", VA = "0x186A6C570")]
		internal void <Wrap>b__0(global::NKNMKIOICJF<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6A67990", Offset = "0x6A66390", VA = "0x186A67990")]
	public AAFIMFCLDIL([Optional] string KPCCJGCECDG, [Optional] int? PJHCFJDFHLJ, [Optional] Stopwatch BNLNLKOJKLA, [Optional] Action<string, FPHHPOGINLK> FOIDHLJNBNJ, [Optional] Action<string, FPHHPOGINLK> IIMFCMGMDID, [Optional] Action<AAFIMFCLDIL> ONFLGDBEEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6A678B0", Offset = "0x6A662B0", VA = "0x186A678B0")]
	private static Action<global::NKNMKIOICJF<string>> JJGMFFCAGAC(Action<AAFIMFCLDIL> KFICNKMCGGK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class NEKBAEBPEBA
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private class FGEFCAHNLBC : NEKBAEBPEBA
	{
		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public static NEKBAEBPEBA FINLHCLDLDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x6A69000", Offset = "0x6A67A00", VA = "0x186A69000")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public override DateTime EGDAFOCKENB
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x6A68FB0", Offset = "0x6A679B0", VA = "0x186A68FB0", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public override float DIDPFJCKMCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x1E1F1A0", Offset = "0x1E1DBA0", VA = "0x181E1F1A0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x6A69100", Offset = "0x6A67B00", VA = "0x186A69100")]
		public FGEFCAHNLBC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private static NEKBAEBPEBA KAEEJIANKFL;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public static NEKBAEBPEBA NHIBPFHOELB
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x6A6C600", Offset = "0x6A6B000", VA = "0x186A6C600")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public abstract DateTime EGDAFOCKENB
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public abstract float DIDPFJCKMCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	protected NEKBAEBPEBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class LHNJNMMKMCC : global::IIFDNMBIFEB<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x6A6C380", Offset = "0x6A6AD80", VA = "0x186A6C380")]
	public LHNJNMMKMCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class IIFDNMBIFEB<T> : global::CMDAMFNAEHI<T>, KOAFDOGMAPI, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public Task<T> FNAPLPLPCMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	private Task PGDLACEFEJH
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x25114D0", Offset = "0x250FED0", VA = "0x1825114D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public global::DJAOLOOILHN<T> LKJCOMJKBMP
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private OFEHPCFKLFI GMECCKJOKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x2690210", Offset = "0x268EC10", VA = "0x182690210", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x32B2580", Offset = "0x32B0F80", VA = "0x1832B2580")]
	public IIFDNMBIFEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class EAKIOBEEFCE : global::DOMGILFCHJK<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x6A68B70", Offset = "0x6A67570", VA = "0x186A68B70")]
	public EAKIOBEEFCE(Exception GMPDCLNOOMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class DOMGILFCHJK<T> : global::CMDAMFNAEHI<T>, KOAFDOGMAPI, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public Task<T> FNAPLPLPCMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	private Task PGDLACEFEJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x25114D0", Offset = "0x250FED0", VA = "0x1825114D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public global::DJAOLOOILHN<T> LKJCOMJKBMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	private OFEHPCFKLFI GMECCKJOKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x2690210", Offset = "0x268EC10", VA = "0x182690210", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x3B98F50", Offset = "0x3B97950", VA = "0x183B98F50")]
	public DOMGILFCHJK(Exception GMPDCLNOOMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface KOAFDOGMAPI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	[NotNull]
	Task FNAPLPLPCMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	[NotNull]
	OFEHPCFKLFI LKJCOMJKBMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public interface CMDAMFNAEHI<T> : KOAFDOGMAPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	[NotNull]
	new Task<T> FNAPLPLPCMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	[NotNull]
	new global::DJAOLOOILHN<T> LKJCOMJKBMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public abstract class FAODLOBENJB<TTask, T> : global::CMDAMFNAEHI<T>, KOAFDOGMAPI, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class IKBJGFIHFFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public global::FAODLOBENJB<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x25118A0", Offset = "0x25102A0", VA = "0x1825118A0")]
		public IKBJGFIHFFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static bool ONCDBFLLOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly Task<T> CLOLJDGJLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	protected readonly CancellationTokenSource PHAHKIOMFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private bool FNOJIFMFPJK;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Task<T> FNAPLPLPCMI
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	private Task PGDLACEFEJH
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public global::DJAOLOOILHN<T> LKJCOMJKBMP
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private OFEHPCFKLFI GMECCKJOKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x269E220", Offset = "0x269CC20", VA = "0x18269E220", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool FKIMOIOBPDE
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x856FD0", Offset = "0x8559D0", VA = "0x180856FD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x381B420", Offset = "0x3819E20", VA = "0x18381B420")]
	static FAODLOBENJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x381B590", Offset = "0x3819F90", VA = "0x18381B590")]
	protected FAODLOBENJB(TTask CLOLJDGJLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x381AEA0", Offset = "0x38198A0", VA = "0x18381AEA0", Slot = "1")]
	~FAODLOBENJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x381AE70", Offset = "0x3819870", VA = "0x18381AE70", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x381AF10", Offset = "0x3819910", VA = "0x18381AF10")]
	private void NOOJKGDANLO(bool AGPINBIDJOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T DGGDIKBJGFC(TTask JPMFJMNENEB);

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void DDMPIEALBBO();
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public static class JGAKAKHCAAA
{
	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6A69D90", Offset = "0x6A68790", VA = "0x186A69D90")]
	[NotNull]
	public static byte[] HKJMMMMKFNM(this KPEAOLIIHNP NCCGIAKNGAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6A69D20", Offset = "0x6A68720", VA = "0x186A69D20")]
	[NotNull]
	public static byte[] HKJMMMMKFNM(this KPEAOLIIHNP NCCGIAKNGAD, HashAlgorithmName OEMCNGCKLEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6A69E00", Offset = "0x6A68800", VA = "0x186A69E00")]
	public static bool JCJLCODMFEG([CanBeNull] this KPEAOLIIHNP NCCGIAKNGAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6A69F90", Offset = "0x6A68990", VA = "0x186A69F90")]
	public static bool JCJLCODMFEG([CanBeNull] this KPEAOLIIHNP NCCGIAKNGAD, out string MCCDEFDHGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6A69CB0", Offset = "0x6A686B0", VA = "0x186A69CB0")]
	private static string FBDPLAKFLIB([CanBeNull] byte[] AHIMNOMEIMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x6A6A130", Offset = "0x6A68B30", VA = "0x186A6A130")]
	private static bool NCPKKIPGFOD([NotNull] KPEAOLIIHNP NCCGIAKNGAD, [CanBeNull] out byte[] HNBAEGIJCIN, [CanBeNull] out byte[] BANFIJPJHOO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public static class JAIGFGPLDIH
{
	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6A69A40", Offset = "0x6A68440", VA = "0x186A69A40")]
	[NotNull]
	public static byte[] HKJMMMMKFNM(this NEFAFJJHHOP KJLEEEIEBPI, byte[] PJFDJHKLCND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x6A69A80", Offset = "0x6A68480", VA = "0x186A69A80")]
	[NotNull]
	public static byte[] HKJMMMMKFNM(this NEFAFJJHHOP KJLEEEIEBPI, HashAlgorithmName OEMCNGCKLEO, byte[] PJFDJHKLCND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public interface NEFAFJJHHOP
{
	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash OGHEGNBLHPM);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public interface KPEAOLIIHNP : NEFAFJJHHOP
{
	[Cpp2IlInjected.Token(Token = "0x17000064")]
	[CanBeNull]
	byte[] AAIMBONLMAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	[CanBeNull]
	byte[] OFFIGDEAKCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	UnityEngine.Object IBIIMINHPBA
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public static class KKOJIJKBENM
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private class LKOPDFNPOFL : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x6A6C4F0", Offset = "0x6A6AEF0", VA = "0x186A6C4F0")]
		public LKOPDFNPOFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6A6C490", Offset = "0x6A6AE90", VA = "0x186A6C490", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private const byte GFEIMOFGMNM = 1;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private const byte KLGIKEMJMHI = 0;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly ArrayPool<byte> BJBEECCEKHI;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static bool BPKKKJIMDNF;

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x36F74D0", Offset = "0x36F5ED0", VA = "0x1836F74D0")]
	[Conditional("UNITY_EDITOR")]
	private static void DPEOHFHOIMG<T>(params T[] DFCMFGNHBJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B170", Offset = "0x6A69B70", VA = "0x186A6B170")]
	public static IDisposable CFICOCFOJPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B450", Offset = "0x6A69E50", VA = "0x186A6B450")]
	public static void FDCHAJMBMIN(this IncrementalHash LMGBHIACOFG, [CanBeNull] GameObject OJBDJCCAFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x36F77C0", Offset = "0x36F61C0", VA = "0x1836F77C0")]
	public static void FDCHAJMBMIN<T>(this IncrementalHash LMGBHIACOFG, [CanBeNull] T DHGNJCDIFDM) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x36F7440", Offset = "0x36F5E40", VA = "0x1836F7440")]
	public static void BGAMOIFLHFM<T>(this IncrementalHash LMGBHIACOFG, [CanBeNull] T KJLEEEIEBPI) where T : NEFAFJJHHOP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x36F7890", Offset = "0x36F6290", VA = "0x1836F7890")]
	public static void NKPDAOELKDP<T>(this IncrementalHash LMGBHIACOFG, [CanBeNull] IList<T> OLFAKKAODBI) where T : NEFAFJJHHOP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x6A6C0E0", Offset = "0x6A6AAE0", VA = "0x186A6C0E0")]
	private static bool NKKBPPOKNHM([CanBeNull] NEFAFJJHHOP KJLEEEIEBPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x6A6C170", Offset = "0x6A6AB70", VA = "0x186A6C170")]
	public static void PMEIGNDMPEP(this IncrementalHash OGHEGNBLHPM, [CanBeNull] string FGNCNBCDPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B540", Offset = "0x6A69F40", VA = "0x186A6B540")]
	public static void FIILJGDMBMA(this IncrementalHash OGHEGNBLHPM, long LLKHMFAKGNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B940", Offset = "0x6A6A340", VA = "0x186A6B940")]
	public static void HNDAJCKBDCA(this IncrementalHash OGHEGNBLHPM, int FEDBFLKOJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x6A6BF10", Offset = "0x6A6A910", VA = "0x186A6BF10")]
	public static void LHKNKBIEECI(this IncrementalHash OGHEGNBLHPM, short NKNINMHACGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x6A6BB10", Offset = "0x6A6A510", VA = "0x186A6BB10")]
	public static void JJLBECNLHGF(this IncrementalHash OGHEGNBLHPM, byte BIHEBCFOPNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B280", Offset = "0x6A69C80", VA = "0x186A6B280")]
	public static void EGMNOHGHBDP(this IncrementalHash OGHEGNBLHPM, bool PCPLOIDCDPN, bool IFKJJLKEEGC = false, bool GBOFFNKFMOA = false, bool COPOGNOMBCO = false, bool BEMPGMDKIJE = false, bool NEDEBKEDHGL = false, bool BEJBOGEABBF = false, bool PJBCNBIDFBG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x36F7CF0", Offset = "0x36F66F0", VA = "0x1836F7CF0")]
	public static void NMEEHONDENO<T>(this IncrementalHash OGHEGNBLHPM, T MKLGBIEKHBL) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B8E0", Offset = "0x6A6A2E0", VA = "0x186A6B8E0")]
	public static void HIPAICLKHLP(this IncrementalHash OGHEGNBLHPM, float PEJPCFKHLFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x6A6BEB0", Offset = "0x6A6A8B0", VA = "0x186A6BEB0")]
	public static void KHKFMDHKMLF(this IncrementalHash OGHEGNBLHPM, double JIKALMNKKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x6A6BC80", Offset = "0x6A6A680", VA = "0x186A6BC80")]
	public static void JKPOKGJJHAL(this IncrementalHash OGHEGNBLHPM, ulong KCCFNKGGILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B710", Offset = "0x6A6A110", VA = "0x186A6B710")]
	public static void FKBDCKKLPBJ(this IncrementalHash OGHEGNBLHPM, uint CCFECDGLCKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B210", Offset = "0x6A69C10", VA = "0x186A6B210")]
	public static void CLMDIMCDLBE(this IncrementalHash OGHEGNBLHPM, ushort OANPJMCPGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B770", Offset = "0x6A6A170", VA = "0x186A6B770")]
	public static void FOGNFIGNHLE(this IncrementalHash OGHEGNBLHPM, Vector3 BFECPIHFNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x6A6BCF0", Offset = "0x6A6A6F0", VA = "0x186A6BCF0")]
	public static void JMIFPIDDEID(this IncrementalHash OGHEGNBLHPM, Quaternion INNBAPIPEKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class PCGALPGNOOO : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public readonly Type GKLPCJPHGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public readonly string KGEBLKIABHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public readonly bool CMADKOHMBJI;

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x6A6CEB0", Offset = "0x6A6B8B0", VA = "0x186A6CEB0")]
	public PCGALPGNOOO(Type IGAAMECPKOJ, string FHEJKNKGNKO, bool GIEDLPCGGPE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class NEPJBJOFFJO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x6A6C810", Offset = "0x6A6B210", VA = "0x186A6C810")]
	public NEPJBJOFFJO(string MDEEJIBNIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x6A6C790", Offset = "0x6A6B190", VA = "0x186A6C790")]
	public NEPJBJOFFJO(string MDEEJIBNIAD, Exception DBGECBFFDPP)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x755A00", Offset = "0x754400", VA = "0x180755A00")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x80B660", Offset = "0x80A060", VA = "0x18080B660")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public T this[int HLFOHCODFGN, int CNIHJCFDMPA]
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x459BFA0", Offset = "0x459A9A0", VA = "0x18459BFA0")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x459C040", Offset = "0x459AA40", VA = "0x18459C040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x459BF10", Offset = "0x459A910", VA = "0x18459BF10")]
		public Array2D(uint ALOPIDFKKAE, uint NKGGLAGGPGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x459BE90", Offset = "0x459A890", VA = "0x18459BE90")]
		public void PDOAHDCGLGB()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6A67EA0", Offset = "0x6A668A0", VA = "0x186A67EA0")]
		public Array2DVector3(uint ALOPIDFKKAE, uint NKGGLAGGPGJ)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
internal static class PMICJJPJHHO
{
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public const int AICLOKAIFFP = -1;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public const int KGIADCPPLEK = 0;
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[DefaultMember("Item")]
public class MKPHHDEIJDO<THandle, TValue> : IDisposable where THandle : struct, LFLEFMNCAPN where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly List<THandle> IMKAAFPDJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly List<TValue> IBILAOBJNIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly Func<TValue> DPPHLNOCEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Action<TValue> FMBGEICDGAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private int CFNPBAGGGOC;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public TValue KBLKMCBLENC
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x3AE2520", Offset = "0x3AE0F20", VA = "0x183AE2520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x3AE2E00", Offset = "0x3AE1800", VA = "0x183AE2E00")]
	public MKPHHDEIJDO(Action<TValue> FMBGEICDGAO, [Optional] Func<TValue> DPPHLNOCEMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x3AE23D0", Offset = "0x3AE0DD0", VA = "0x183AE23D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x3AE2A10", Offset = "0x3AE1410", VA = "0x183AE2A10")]
	public THandle KMLFLFAGFOK()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x3AE2830", Offset = "0x3AE1230", VA = "0x183AE2830")]
	public THandle IFPOOIAJHAI(TValue MFBGAMJDOKA)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x3AE26B0", Offset = "0x3AE10B0", VA = "0x183AE26B0")]
	public bool HEOHJOBENDL(THandle DFKGNJHDLAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x3AE2450", Offset = "0x3AE0E50", VA = "0x183AE2450")]
	public bool EDLFOMBBBBL(THandle DFKGNJHDLAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x3AE2BC0", Offset = "0x3AE15C0", VA = "0x183AE2BC0")]
	public bool MDMJPHIOICO(THandle DFKGNJHDLAL, out TValue MFBGAMJDOKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x3AE2250", Offset = "0x3AE0C50", VA = "0x183AE2250")]
	public TValue ABMJNALEGDK(THandle DFKGNJHDLAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x3AE2CA0", Offset = "0x3AE16A0", VA = "0x183AE2CA0")]
	public bool OJCAMDKMMGI(THandle DFKGNJHDLAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x3AE2680", Offset = "0x3AE1080", VA = "0x183AE2680")]
	private THandle HCKJANJJPBP(int ALJOMNDNEBM)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x3AE28A0", Offset = "0x3AE12A0", VA = "0x183AE28A0")]
	private TValue JILIAHNOHMA(int ALJOMNDNEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x3AE2C60", Offset = "0x3AE1660", VA = "0x183AE2C60")]
	private void MPKLLGJGMHJ(int ALJOMNDNEBM, in THandle DFKGNJHDLAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x3AE22A0", Offset = "0x3AE0CA0", VA = "0x183AE22A0")]
	private void AGPCCBACEAN(int ALJOMNDNEBM, in TValue MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x3AE2AB0", Offset = "0x3AE14B0", VA = "0x183AE2AB0")]
	private THandle LDAHGJJMMEM()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x3AE2D50", Offset = "0x3AE1750", VA = "0x183AE2D50")]
	private void PLFCOMMPADK(THandle DFKGNJHDLAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x3AE2670", Offset = "0x3AE1070", VA = "0x183AE2670")]
	private int GLAIIOGOMDK(int LHIPGOMOMEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x3AE22E0", Offset = "0x3AE0CE0", VA = "0x183AE22E0")]
	private bool BIDGGIGGNAM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x8EDEE0", Offset = "0x8EC8E0", VA = "0x1808EDEE0")]
	private void DLDCHLKNGJO(THandle DFKGNJHDLAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x3AE22F0", Offset = "0x3AE0CF0", VA = "0x183AE22F0")]
	private bool DMADBKJOEKI(out THandle DFKGNJHDLAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x3AE2760", Offset = "0x3AE1160", VA = "0x183AE2760")]
	private bool IBANFBFOPML(out THandle DFKGNJHDLAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x3AE2370", Offset = "0x3AE0D70", VA = "0x183AE2370")]
	private void DOPBMBFGJDI(THandle DFKGNJHDLAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x3AE2550", Offset = "0x3AE0F50", VA = "0x183AE2550")]
	private void FMMIMMPDOJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public interface LFLEFMNCAPN
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	int EOGKCECFNOA
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	int GGPKANELEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public interface EIJDEJKCJCH<T> : LFLEFMNCAPN, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public static class PHDPJMJIPHK
{
	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x1A44B70", Offset = "0x1A43570", VA = "0x181A44B70")]
	public static bool ECANAHLFLLB<T>(this T DFKGNJHDLAL, T EHBPAFKHADK) where T : struct, LFLEFMNCAPN
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x394BE80", Offset = "0x394A880", VA = "0x18394BE80")]
	public static bool GGNGOEANAEK<T>(this T DFKGNJHDLAL) where T : struct, LFLEFMNCAPN
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x6A6D050", Offset = "0x6A6BA50", VA = "0x186A6D050")]
	public static string APNFEIIGCDF(this LFLEFMNCAPN DFKGNJHDLAL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public class KBGKCBHMGCJ
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private enum DNBLMIGPKNA : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int OGHEGNBLHPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private bool JLONBFEKAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private DNBLMIGPKNA GFHEAAHHEHC;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool INOBADPFMME
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x6A6A250", Offset = "0x6A68C50", VA = "0x186A6A250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool MBMFOAKINBM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x6A6AFA0", Offset = "0x6A699A0", VA = "0x186A6AFA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B140", Offset = "0x6A69B40", VA = "0x186A6B140")]
	public KBGKCBHMGCJ(bool JLONBFEKAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x6A6A750", Offset = "0x6A69150", VA = "0x186A6A750")]
	public void EGFAJHFPADM(object OMHIFHKMIMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B020", Offset = "0x6A69A20", VA = "0x186A6B020")]
	public void OEDHPIIDFPA(int MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x6A6A740", Offset = "0x6A69140", VA = "0x186A6A740")]
	public void DPBKAEBJIJB(uint CDCPEDOIOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x6A6AE40", Offset = "0x6A69840", VA = "0x186A6AE40")]
	public void GFLHMPINFGI(bool AFNCAKJFPFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6A6A260", Offset = "0x6A68C60", VA = "0x186A6A260")]
	public void CNKNCIGMOON(long KKPJCAJFFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x6A6AF60", Offset = "0x6A69960", VA = "0x186A6AF60")]
	public void IGPCBPGGOAK(ulong NOIFEJKNNBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B0D0", Offset = "0x6A69AD0", VA = "0x186A6B0D0")]
	public void PLFFAELGJMO(string ANIDBJJMJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x6A6AED0", Offset = "0x6A698D0", VA = "0x186A6AED0")]
	public void HGKLACIBFMI(Enum GMPDCLNOOMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6A6A2A0", Offset = "0x6A68CA0", VA = "0x186A6A2A0")]
	public void CPFELJBGBAG(IList ECNPNAMGIHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x38DFC90", Offset = "0x38DE690", VA = "0x1838DFC90")]
	public void DACEJFNGGFB<T, U>(Dictionary<T, U> EFMBJGPJNLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6A6A3D0", Offset = "0x6A68DD0", VA = "0x186A6A3D0")]
	private void DOFPIBJPIAJ(IDictionary EFMBJGPJNLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6A6AE60", Offset = "0x6A69860", VA = "0x186A6AE60")]
	public int GMEFFDMEAII()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6A6ADD0", Offset = "0x6A697D0", VA = "0x186A6ADD0")]
	public short FDFIMMBODAK()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B0C0", Offset = "0x6A69AC0", VA = "0x186A6B0C0")]
	public void PDOAHDCGLGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x6A6AFB0", Offset = "0x6A699B0", VA = "0x186A6AFB0")]
	private void OCILEDPLPIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public abstract class GMOGEMOCDDD<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	internal class LLLJGBLAJJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public TNode IKHBPJOEIEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public TNode EOBFGLJBCIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public MKLOPDBOBII KEHJLNIPGPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public List<MKLOPDBOBII> GEIDHKEDOIB;

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x25118A0", Offset = "0x25102A0", VA = "0x1825118A0")]
		public LLLJGBLAJJO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	internal struct MKLOPDBOBII : IComparable<MKLOPDBOBII>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public int ALIOAOHFFLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public TClaimant CABLIGKGLBM;

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0xA34BF0", Offset = "0xA335F0", VA = "0x180A34BF0")]
		public MKLOPDBOBII(int ALIOAOHFFLI, TClaimant CABLIGKGLBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x3AE19E0", Offset = "0x3AE03E0", VA = "0x183AE19E0")]
		public bool JIFBMLKEMGK(in MKLOPDBOBII EHBPAFKHADK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x3AE1A40", Offset = "0x3AE0440", VA = "0x183AE1A40")]
		public bool JMJBLDNMLLP(in MKLOPDBOBII EHBPAFKHADK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x3AE19D0", Offset = "0x3AE03D0", VA = "0x183AE19D0", Slot = "4")]
		public int CompareTo(MKLOPDBOBII EHBPAFKHADK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x3AE1A50", Offset = "0x3AE0450", VA = "0x183AE1A50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public enum HNAAELKPDJP
	{
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class JLICAOFJLJF : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public global::GMOGEMOCDDD<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x3272740", Offset = "0x3271140", VA = "0x183272740")]
		[DebuggerHidden]
		public JLICAOFJLJF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x3FD24F0", Offset = "0x3FD0EF0", VA = "0x183FD24F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x3FD26B0", Offset = "0x3FD10B0", VA = "0x183FD26B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x3FD25D0", Offset = "0x3FD0FD0", VA = "0x183FD25D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x268E710", Offset = "0x268D110", VA = "0x18268E710", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static readonly global::GIANNHJPJIO<LLLJGBLAJJO> OJAEMIMEBHE;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private static readonly global::GIANNHJPJIO<List<MKLOPDBOBII>> JCPEKJGOCOA;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static int JAAIDKINLLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	internal readonly Dictionary<TClaimant, TNode> CBPMBAJGKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	internal readonly Dictionary<TNode, LLLJGBLAJJO> MAEFLDBJOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private HNAAELKPDJP DPFIFMCONAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private bool ILMLECMLEKB;

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode EOCIMCBAGPH(TNode GBBOAEGAMHF);

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void CMGHPGKNBKI(TNode GBBOAEGAMHF, TClaimant EJPIAPLIIIK, TClaimant EPJNHCKKKKI);

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x3FF8FB0", Offset = "0x3FF79B0", VA = "0x183FF8FB0")]
	public GMOGEMOCDDD(HNAAELKPDJP DPFIFMCONAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x3FF7860", Offset = "0x3FF6260", VA = "0x183FF7860")]
	public void ALIPKHCLDAH(TNode GBBOAEGAMHF, TNode KLJNAJJPMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x3FF79E0", Offset = "0x3FF63E0", VA = "0x183FF79E0")]
	public void CMBAHJENHGB(TClaimant CABLIGKGLBM, TNode FEILCMNDPPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x3FF7F10", Offset = "0x3FF6910", VA = "0x183FF7F10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x3FF8430", Offset = "0x3FF6E30", VA = "0x183FF8430")]
	private void GBHMIPCMDII(TClaimant CABLIGKGLBM, TNode ENONEKCGMBG, TNode FEILCMNDPPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x3FF83D0", Offset = "0x3FF6DD0", VA = "0x183FF83D0")]
	private int FKNCPMNJAAC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x3FF8980", Offset = "0x3FF7380", VA = "0x183FF8980")]
	private void KILDPGNAOCD(TClaimant CABLIGKGLBM, TNode KPNLPLFABBN, TNode NLHHFBGKIOA, int HFDCDLEIKCL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x3FF8C30", Offset = "0x3FF7630", VA = "0x183FF8C30")]
	private void NLPCGHADFHA(MKLOPDBOBII ELBPIJHBENA, LLLJGBLAJJO PGKFNPJJKMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x3FF8170", Offset = "0x3FF6B70", VA = "0x183FF8170")]
	private void FFIICMPEMJL(TClaimant CABLIGKGLBM, TNode KPNLPLFABBN, TNode NLHHFBGKIOA, int HFDCDLEIKCL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x3FF86B0", Offset = "0x3FF70B0", VA = "0x183FF86B0")]
	private void JMJLLFJHCAM(MKLOPDBOBII ELBPIJHBENA, TNode GBBOAEGAMHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x3FF78E0", Offset = "0x3FF62E0", VA = "0x183FF78E0")]
	private void BJIONMIHADP(MKLOPDBOBII ELBPIJHBENA, LLLJGBLAJJO PGKFNPJJKMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x3FF84D0", Offset = "0x3FF6ED0", VA = "0x183FF84D0")]
	private void GGPKMDBJJKN(LLLJGBLAJJO PGKFNPJJKMC, bool OOEENMCMLFF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x3FF7AE0", Offset = "0x3FF64E0", VA = "0x183FF7AE0")]
	private void DALEIFKIIJJ(LLLJGBLAJJO PGKFNPJJKMC, TNode KLJNAJJPMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x3FF85E0", Offset = "0x3FF6FE0", VA = "0x183FF85E0")]
	[IteratorStateMachine(typeof(global::GMOGEMOCDDD<, >.JLICAOFJLJF))]
	private IEnumerable<TNode> GOIBDCPJFOH(TNode KPNLPLFABBN, TNode NLHHFBGKIOA, bool BMFGELCDGHJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x3FF7E50", Offset = "0x3FF6850", VA = "0x183FF7E50")]
	private LLLJGBLAJJO DBJAGNEPDLC(TNode GBBOAEGAMHF, TNode EOBFGLJBCIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x3FF8CC0", Offset = "0x3FF76C0", VA = "0x183FF8CC0")]
	private LLLJGBLAJJO PHFOKMNNOCA(TNode GBBOAEGAMHF, TNode EOBFGLJBCIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x3FF87C0", Offset = "0x3FF71C0", VA = "0x183FF87C0")]
	private void KHHKJIJOHHP(LLLJGBLAJJO PGKFNPJJKMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class OEONMLAGOJM<T> : IEnumerable<global::OEONMLAGOJM<T>.NPHBOOBJJCM>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public struct NPHBOOBJJCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public T MFBGAMJDOKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public int ALJOMNDNEBM;
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class PHICBAGPMDH : IEnumerator<NPHBOOBJJCM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private global::OEONMLAGOJM<T> IAGLEADCODA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private int ALJOMNDNEBM;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x2510110", Offset = "0x250EB10", VA = "0x182510110", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public NPHBOOBJJCM LEJKACPKMMA
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x43D4400", Offset = "0x43D2E00", VA = "0x1843D4400", Slot = "4")]
			get
			{
				return default(NPHBOOBJJCM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x9354C0", Offset = "0x933EC0", VA = "0x1809354C0")]
		public PHICBAGPMDH(global::OEONMLAGOJM<T> IAGLEADCODA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x43D4300", Offset = "0x43D2D00", VA = "0x1843D4300", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x9354B0", Offset = "0x933EB0", VA = "0x1809354B0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x1446D00", Offset = "0x1445700", VA = "0x181446D00", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	private struct EHOMMPCDAMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public bool PBDCCNKLBJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public T MFBGAMJDOKA;
	}

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private const int DDEGPNOCEHA = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly Dictionary<T, int> IBHAEEDKNOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private EHOMMPCDAMI[] POPFGLIDIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private int NGPNJFFKHFN;

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public int ADKLEHBDHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x7E5910", Offset = "0x7E4310", VA = "0x1807E5910")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x7E5930", Offset = "0x7E4330", VA = "0x1807E5930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public int GNKNLJGDNJB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x2A08AA0", Offset = "0x2A074A0", VA = "0x182A08AA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x3ED41B0", Offset = "0x3ED2BB0", VA = "0x183ED41B0")]
	public OEONMLAGOJM(int ICKPJJPJOOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x3ED4690", Offset = "0x3ED3090", VA = "0x183ED4690")]
	public OEONMLAGOJM(NPHBOOBJJCM[] AFFMHGOJMAM, bool JNKOLMMKOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x3ED3280", Offset = "0x3ED1C80", VA = "0x183ED3280")]
	public int EDMFFPCNDNN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x3ED3A40", Offset = "0x3ED2440", VA = "0x183ED3A40")]
	private int OLPAJDMKLEK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x3ED3190", Offset = "0x3ED1B90", VA = "0x183ED3190", Slot = "6")]
	protected virtual uint BOOCIAKGDKJ(uint OGHEGNBLHPM, T MFBGAMJDOKA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x3ED34D0", Offset = "0x3ED1ED0", VA = "0x183ED34D0")]
	public bool IAHPLFOOEKF(T MFBGAMJDOKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x3ED31E0", Offset = "0x3ED1BE0", VA = "0x183ED31E0")]
	public bool DHBDDNDAJDH(int ALJOMNDNEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x3ED2DC0", Offset = "0x3ED17C0", VA = "0x183ED2DC0")]
	public bool AAFBPIPDPOL(Func<T, bool> KPLFGOOOGNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x3ED37F0", Offset = "0x3ED21F0", VA = "0x183ED37F0")]
	public int KEOLHEFCKHN(T MFBGAMJDOKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x3ED36E0", Offset = "0x3ED20E0", VA = "0x183ED36E0")]
	public T JILIAHNOHMA(int ALJOMNDNEBM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x3ED3C40", Offset = "0x3ED2640", VA = "0x183ED3C40")]
	public void PDOAHDCGLGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x3ED3CC0", Offset = "0x3ED26C0", VA = "0x183ED3CC0")]
	public bool PLIOJAFPAGG(T MFBGAMJDOKA, bool BNPECNNIONC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x3ED3F30", Offset = "0x3ED2930", VA = "0x183ED3F30")]
	public bool PLIOJAFPAGG(T MFBGAMJDOKA, int ALJOMNDNEBM, bool BNPECNNIONC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x3ED3410", Offset = "0x3ED1E10", VA = "0x183ED3410")]
	public bool HEOHJOBENDL(T MFBGAMJDOKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x3ED3140", Offset = "0x3ED1B40", VA = "0x183ED3140")]
	public bool BLHADIBIAOF(int ALJOMNDNEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x3ED3510", Offset = "0x3ED1F10", VA = "0x183ED3510")]
	private void INDEFLEHOCG(int ALJOMNDNEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x3ED3000", Offset = "0x3ED1A00", VA = "0x183ED3000")]
	public NPHBOOBJJCM[] BBOEFAOBLKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x3ED32F0", Offset = "0x3ED1CF0", VA = "0x183ED32F0")]
	private int FEGJDKAPHJD(int ACBJBFDCGOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x3ED4130", Offset = "0x3ED2B30", VA = "0x183ED4130", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x3ED4130", Offset = "0x3ED2B30", VA = "0x183ED4130", Slot = "4")]
	private IEnumerator<NPHBOOBJJCM> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct ICOHICBCCDO<Handle> where Handle : LFLEFMNCAPN, new()
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private struct MBGGCICCJMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly global::ICOHICBCCDO<Handle> HGALBLDGOJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private int ALJOMNDNEBM;

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public int MDJAPEPENON
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x4679610", Offset = "0x4678010", VA = "0x184679610")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public Handle LKBCKINDELD
		{
			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x4679150", Offset = "0x4677B50", VA = "0x184679150")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x4679A90", Offset = "0x4678490", VA = "0x184679A90")]
		public MBGGCICCJMD(global::ICOHICBCCDO<Handle> HGALBLDGOJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x46798B0", Offset = "0x46782B0", VA = "0x1846798B0")]
		public KCOEGNOBJPH IDLIIDOEAFG(in KCOEGNOBJPH NHAGEBCMLPC)
		{
			return default(KCOEGNOBJPH);
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x4679810", Offset = "0x4678210", VA = "0x184679810")]
		public FNNCDEJNIOD IDLIIDOEAFG(in FNNCDEJNIOD NHAGEBCMLPC)
		{
			return default(FNNCDEJNIOD);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x46789F0", Offset = "0x46773F0", VA = "0x1846789F0")]
		public bool CCIHDANHBIF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x46799A0", Offset = "0x46783A0", VA = "0x1846799A0")]
		private int IGNOLPBBGFG(string MDEEJIBNIAD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x4678DF0", Offset = "0x46777F0", VA = "0x184678DF0")]
		private Handle CEEHKCIFOMG(string MDEEJIBNIAD)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public struct KCOEGNOBJPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private MBGGCICCJMD HIJCOJHGKED;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public int LEJKACPKMMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x3778810", Offset = "0x3777210", VA = "0x183778810")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x36245F0", Offset = "0x3622FF0", VA = "0x1836245F0")]
		public KCOEGNOBJPH(global::ICOHICBCCDO<Handle> HGALBLDGOJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x36243B0", Offset = "0x3622DB0", VA = "0x1836243B0")]
		public bool CCIHDANHBIF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x37788D0", Offset = "0x37772D0", VA = "0x1837788D0")]
		public KCOEGNOBJPH ODEOKNNCFHI()
		{
			return default(KCOEGNOBJPH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public struct FNNCDEJNIOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private MBGGCICCJMD HIJCOJHGKED;

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public Handle LEJKACPKMMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x3624470", Offset = "0x3622E70", VA = "0x183624470")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x36245F0", Offset = "0x3622FF0", VA = "0x1836245F0")]
		public FNNCDEJNIOD(global::ICOHICBCCDO<Handle> HGALBLDGOJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x36243B0", Offset = "0x3622DB0", VA = "0x1836243B0")]
		public bool CCIHDANHBIF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x3624570", Offset = "0x3622F70", VA = "0x183624570")]
		public FNNCDEJNIOD ODEOKNNCFHI()
		{
			return default(FNNCDEJNIOD);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private NativeList<int> FJHCCBIBAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private NativeList<int> IJDJBNPILNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private int EAABCDPHEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private int DBOGFJCEFMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private bool DJKOAEDFFNN;

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public bool DBBBFNFEPMK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x856FD0", Offset = "0x8559D0", VA = "0x180856FD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public int OAFOLGMAGAE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x4068970", Offset = "0x4067370", VA = "0x184068970")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public int MGPLPDAKNHK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x7D3CF0", Offset = "0x7D26F0", VA = "0x1807D3CF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public int DBIEHONOFKH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x7D3CF0", Offset = "0x7D26F0", VA = "0x1807D3CF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public KCOEGNOBJPH DAEIONHNEHI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x4066590", Offset = "0x4064F90", VA = "0x184066590")]
		get
		{
			return default(KCOEGNOBJPH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public FNNCDEJNIOD GBLDKBKBHIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x4064880", Offset = "0x4063280", VA = "0x184064880")]
		get
		{
			return default(FNNCDEJNIOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x4068CC0", Offset = "0x40676C0", VA = "0x184068CC0")]
	public ICOHICBCCDO(int BAOPFEOAANG, Allocator APPJGCOGPBM = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x40681F0", Offset = "0x4066BF0", VA = "0x1840681F0")]
	public void NOOJKGDANLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x21AE440", Offset = "0x21ACE40", VA = "0x1821AE440")]
	public static int GLAIIOGOMDK(int PKKHHJKMKKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x4067270", Offset = "0x4065C70", VA = "0x184067270")]
	public static bool MIFKDAPEMFK(int PKKHHJKMKKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x4068A70", Offset = "0x4067470", VA = "0x184068A70")]
	public static bool PKNGCKCPGKK(int PKKHHJKMKKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x4068610", Offset = "0x4067010", VA = "0x184068610")]
	public bool ONIGAOPDIIM(int ALJOMNDNEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x4064920", Offset = "0x4063320", VA = "0x184064920")]
	public bool FBANNCEBJKJ(int ALJOMNDNEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x4065C90", Offset = "0x4064690", VA = "0x184065C90")]
	public bool HLKGEAANLKI(Handle DFKGNJHDLAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x4066C70", Offset = "0x4065670", VA = "0x184066C70")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void MBOGJEFLPMM(Handle DFKGNJHDLAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x4068120", Offset = "0x4066B20", VA = "0x184068120")]
	public Handle NEBGENBMFMO()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x4067BB0", Offset = "0x40665B0", VA = "0x184067BB0")]
	public void MPKJFKGIJEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x4065630", Offset = "0x4064030", VA = "0x184065630")]
	public void HGFJAPNGHIG(Handle DFKGNJHDLAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x40645C0", Offset = "0x4062FC0", VA = "0x1840645C0")]
	public bool BIGDAGICMKG(Handle DFKGNJHDLAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x856FD0", Offset = "0x8559D0", VA = "0x180856FD0")]
	private bool GGPNLGBHOEA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x4066210", Offset = "0x4064C10", VA = "0x184066210")]
	private bool ICAHEGELFEB(int ALJOMNDNEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x4064F10", Offset = "0x4063910", VA = "0x184064F10")]
	private void GALLOOEILDA(out int ALJOMNDNEBM, out int LHIPGOMOMEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x4065A30", Offset = "0x4064430", VA = "0x184065A30")]
	private void HJPBGPGLFAL(Handle DFKGNJHDLAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x4065540", Offset = "0x4063F40", VA = "0x184065540")]
	private void HBNDLPJACHI(int ALJOMNDNEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x4066380", Offset = "0x4064D80", VA = "0x184066380")]
	private bool JEIKLDJCFFO(out int ALJOMNDNEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x4065360", Offset = "0x4063D60", VA = "0x184065360")]
	private static Handle GMJDAKNPEOL(int ALJOMNDNEBM, int LHIPGOMOMEB)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[DefaultMember("Item")]
public struct DDHALPPBFJD<Handle, T> where Handle : LFLEFMNCAPN, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private global::ICOHICBCCDO<Handle> BDDODGIHNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private T[] GDMABLBEEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private Action<T> GLBDKPKHPBK;

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public bool DBBBFNFEPMK
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x4363880", Offset = "0x4362280", VA = "0x184363880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public int OAFOLGMAGAE
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x4363DE0", Offset = "0x43627E0", VA = "0x184363DE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public int GNKNLJGDNJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x4360EB0", Offset = "0x435F8B0", VA = "0x184360EB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public T KBLKMCBLENC
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x43621D0", Offset = "0x4360BD0", VA = "0x1843621D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x4363FE0", Offset = "0x43629E0", VA = "0x184363FE0")]
	public DDHALPPBFJD(int BAOPFEOAANG, [Optional] Action<T> GLBDKPKHPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x4363C30", Offset = "0x4362630", VA = "0x184363C30")]
	public void NOOJKGDANLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x43633B0", Offset = "0x4361DB0", VA = "0x1843633B0")]
	public bool HLKGEAANLKI(Handle DFKGNJHDLAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void MBOGJEFLPMM(Handle DFKGNJHDLAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x4360DF0", Offset = "0x435F7F0", VA = "0x184360DF0")]
	public T ABMJNALEGDK(Handle DFKGNJHDLAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x4363AF0", Offset = "0x43624F0", VA = "0x184363AF0")]
	public bool MDMJPHIOICO(Handle DFKGNJHDLAL, out T OMHIFHKMIMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x43617D0", Offset = "0x43601D0", VA = "0x1843617D0")]
	public void CKIEIOOCMAM(Handle DFKGNJHDLAL, T HJNKMHAJABM, out T EEKLGNEJGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x43616B0", Offset = "0x43600B0", VA = "0x1843616B0")]
	public void CKIEIOOCMAM(Handle DFKGNJHDLAL, T HJNKMHAJABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x4360F40", Offset = "0x435F940", VA = "0x184360F40")]
	public bool BPHKCHFMHEA(Handle DFKGNJHDLAL, T HJNKMHAJABM, out T EEKLGNEJGDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x43612E0", Offset = "0x435FCE0", VA = "0x1843612E0")]
	public bool BPHKCHFMHEA(Handle DFKGNJHDLAL, T HJNKMHAJABM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x4363650", Offset = "0x4362050", VA = "0x184363650")]
	public Handle IFPOOIAJHAI(T OMHIFHKMIMJ)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x43622C0", Offset = "0x4360CC0", VA = "0x1843622C0")]
	public void FNJCFDMDFDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x4363060", Offset = "0x4361A60", VA = "0x184363060")]
	public void HEOHJOBENDL(Handle DFKGNJHDLAL, out T EEKLGNEJGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x4362C50", Offset = "0x4361650", VA = "0x184362C50")]
	public void HEOHJOBENDL(Handle DFKGNJHDLAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x4361A90", Offset = "0x4360490", VA = "0x184361A90")]
	public bool DMPFIDBHEAD(Handle DFKGNJHDLAL, out T EEKLGNEJGDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x4361B70", Offset = "0x4360570", VA = "0x184361B70")]
	public bool DMPFIDBHEAD(Handle DFKGNJHDLAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x4360EE0", Offset = "0x435F8E0", VA = "0x184360EE0")]
	private T BLHADIBIAOF(int ALJOMNDNEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x4362B80", Offset = "0x4361580", VA = "0x184362B80")]
	private void GINEDIGGOIB(int JHMIBCAPGFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class GIANNHJPJIO<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly Stack<T> HGALBLDGOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly List<T> CGHDCNKOPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private readonly int MNFIKNJJIPC;

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public int FFALBMIHJOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x3612190", Offset = "0x3610B90", VA = "0x183612190")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int HMGPOAAPPML
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x3AD4850", Offset = "0x3AD3250", VA = "0x183AD4850")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x3FE3C20", Offset = "0x3FE2620", VA = "0x183FE3C20")]
	public static global::GIANNHJPJIO<T> FGGECHKKFDM(int ICKPJJPJOOC = 0, int MNFIKNJJIPC = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x3FE3D80", Offset = "0x3FE2780", VA = "0x183FE3D80")]
	public static global::GIANNHJPJIO<T> LLGLLOBLPII(int ICKPJJPJOOC = 0, int MNFIKNJJIPC = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x3FE40F0", Offset = "0x3FE2AF0", VA = "0x183FE40F0")]
	public GIANNHJPJIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x3FE3F60", Offset = "0x3FE2960", VA = "0x183FE3F60")]
	public GIANNHJPJIO(int ICKPJJPJOOC, int MNFIKNJJIPC = int.MaxValue, bool EDIMAPHHJIN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x3FE3E50", Offset = "0x3FE2850", VA = "0x183FE3E50")]
	public T NFDNIPICANI()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x3FE3840", Offset = "0x3FE2240", VA = "0x183FE3840")]
	public void CFLDMNJOPIN(T MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x3FE3770", Offset = "0x3FE2170", VA = "0x183FE3770")]
	private void BDHDIENILDI(T MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x3FE3C00", Offset = "0x3FE2600", VA = "0x183FE3C00")]
	private void EOKHNBEEPAD(T MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x3FE38F0", Offset = "0x3FE22F0", VA = "0x183FE38F0")]
	[Conditional("DEBUG_BUILD")]
	private void CGIIBLCKLJD(T LGNCBIMHCOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x3FE3CF0", Offset = "0x3FE26F0", VA = "0x183FE3CF0")]
	[Conditional("DEBUG_BUILD")]
	private void JHODPHKFMHH(T LGNCBIMHCOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x3FE3B10", Offset = "0x3FE2510", VA = "0x183FE3B10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x3FE3970", Offset = "0x3FE2370", VA = "0x183FE3970")]
	private void CLKIFFFDNAC(IEnumerable<T> IBILAOBJNIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class DIAHLCCMFCH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private Dictionary<int, T> AHKMGODEDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private T MOMLEOMKCOK;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public virtual T NAJAPBMDIFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x7D2590", Offset = "0x7D0F90", VA = "0x1807D2590", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public bool ECDKDGMLFOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x43306E0", Offset = "0x432F0E0", VA = "0x1843306E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x4330680", Offset = "0x432F080", VA = "0x184330680")]
	public bool FMHGDPNPEHP(T MFBGAMJDOKA, int ALIOAOHFFLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x32C5250", Offset = "0x32C3C50", VA = "0x1832C5250")]
	public bool NHIFDNAHCNB(int ALIOAOHFFLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x4330AF0", Offset = "0x432F4F0", VA = "0x184330AF0")]
	public T LKDLKANGPEM(int LHDNNJDLFNC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x4330CE0", Offset = "0x432F6E0", VA = "0x184330CE0")]
	public void PDOAHDCGLGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x4330750", Offset = "0x432F150", VA = "0x184330750")]
	private bool LIGMKANNBAA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x4330720", Offset = "0x432F120", VA = "0x184330720")]
	public bool JBPBACKGAAO(int ALIOAOHFFLI, out T MFBGAMJDOKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x32C52B0", Offset = "0x32C3CB0", VA = "0x1832C52B0")]
	public DIAHLCCMFCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public class ANGEGPCFEBB<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	protected struct FPONJHPKKGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public T ONBMIOJBCHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public int PNPDJPOHNLM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	protected readonly List<FPONJHPKKGF> APLMHJDDDBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private T LAGLPHEMKOJ;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public int GNKNLJGDNJB
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x2A08AA0", Offset = "0x2A074A0", VA = "0x182A08AA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x4758630", Offset = "0x4757030", VA = "0x184758630")]
	public bool AAFBPIPDPOL(T MFBGAMJDOKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x4758B90", Offset = "0x4757590", VA = "0x184758B90")]
	public void IFPOOIAJHAI(T MFBGAMJDOKA, int ALIOAOHFFLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x4758A70", Offset = "0x4757470", VA = "0x184758A70")]
	public bool HEOHJOBENDL(T MFBGAMJDOKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x4758CA0", Offset = "0x47576A0", VA = "0x184758CA0")]
	public void PDOAHDCGLGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x4758C30", Offset = "0x4757630", VA = "0x184758C30")]
	public T LMADKNMHPDM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x4758A00", Offset = "0x4757400", VA = "0x184758A00")]
	public T FBFLDCKHELO()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x4758840", Offset = "0x4757240", VA = "0x184758840")]
	private void CKPJNHMLPPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x4758D00", Offset = "0x4757700", VA = "0x184758D00")]
	public ANGEGPCFEBB()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		[ADNNDKFKEGG(MAMLNCPNJJC.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x6A6D2F0", Offset = "0x6A6BCF0", VA = "0x186A6D2F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x6A6D680", Offset = "0x6A6C080", VA = "0x186A6D680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x6A6D500", Offset = "0x6A6BF00", VA = "0x186A6D500")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x6A6D7E0", Offset = "0x6A6C1E0", VA = "0x186A6D7E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x6A6D210", Offset = "0x6A6BC10", VA = "0x186A6D210")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x6A6D5A0", Offset = "0x6A6BFA0", VA = "0x186A6D5A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x6A6D420", Offset = "0x6A6BE20", VA = "0x186A6D420")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D1C0", Offset = "0x6A6BBC0", VA = "0x186A6D1C0")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public interface GMCMGGAFFKI
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public abstract class ResourcePrefabReference<T> : GMCMGGAFFKI where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x47AD920", Offset = "0x47AC320", VA = "0x1847AD920", Slot = "4")]
		public virtual T DNCJFBNGAPL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x25118A0", Offset = "0x25102A0", VA = "0x1825118A0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public class BDEFMNEHDHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly Dictionary<byte, HBBIPDINOCE> OGHNLPPKGNP;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public HBBIPDINOCE CHPEMLGHGKM
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x7D2880", Offset = "0x7D1280", VA = "0x1807D2880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public Vector2 KFDPJMPMNJH
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0xD013F0", Offset = "0xCFFDF0", VA = "0x180D013F0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x76B7D0", Offset = "0x76A1D0", VA = "0x18076B7D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public Vector2 INDLBDNBIIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x13A22C0", Offset = "0x13A0CC0", VA = "0x1813A22C0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x84CCE0", Offset = "0x84B6E0", VA = "0x18084CCE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public Vector2 MMNEODGMGJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x6A685E0", Offset = "0x6A66FE0", VA = "0x186A685E0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x8464C0", Offset = "0x844EC0", VA = "0x1808464C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public int NGHHDMMHKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x8EDA80", Offset = "0x8EC480", VA = "0x1808EDA80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x8EDEE0", Offset = "0x8EC8E0", VA = "0x1808EDEE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x6A68600", Offset = "0x6A67000", VA = "0x186A68600")]
	public BDEFMNEHDHG(Bounds ALIKJCKCGLO, Vector2[] DFBBBCODDDP, int GOLAFLCBICB, byte ACBJBFDCGOJ, float CLABKJBMAFK = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x6A68400", Offset = "0x6A66E00", VA = "0x186A68400")]
	public HBBIPDINOCE GEDJAPAELIJ(byte ALJOMNDNEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x6A68300", Offset = "0x6A66D00", VA = "0x186A68300")]
	public void EPGLMNAKGLN(Vector3 LHCEFCJDGIJ, float EJJBJPNFNHD, float CFOCLPDJCJM, ref List<byte> KOKHEJELMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x6A68460", Offset = "0x6A66E60", VA = "0x186A68460")]
	public void KGMHJLIAPEL(HBBIPDINOCE.LHELKABBBFL OCHILLFNONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x6A68480", Offset = "0x6A66E80", VA = "0x186A68480")]
	private HBBIPDINOCE NKIGDGDEIBI(byte ALJOMNDNEBM, HBBIPDINOCE.HHIDBLJMPGL JOECHPBBCNJ, HBBIPDINOCE EOBFGLJBCIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x6A67F00", Offset = "0x6A66900", VA = "0x186A67F00")]
	private void DFMDKCPIFDI(HBBIPDINOCE EOBFGLJBCIJ, Vector2[] DFBBBCODDDP, int ELOFJBPOKCC, int PDJFGKEIPNI, int CHNOJLHENHG, int ACNIPLEDEAJ, float CLABKJBMAFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public class HBBIPDINOCE
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public enum HHIDBLJMPGL
	{
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public enum LHELKABBBFL
	{
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public byte LMACIDEDPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public Vector3 LIMAKKEBHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public Vector3 PMGBHJMMFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public Vector3 KLHBICGFCMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public Vector3 GAOOGHBIJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public HHIDBLJMPGL NGEGEKLDCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public HBBIPDINOCE NLJMPCEPHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public List<HBBIPDINOCE> LEBGPGPNBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	public bool CMBDLOAGGDM;

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x6A69620", Offset = "0x6A68020", VA = "0x186A69620")]
	public HBBIPDINOCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x6A69640", Offset = "0x6A68040", VA = "0x186A69640")]
	public HBBIPDINOCE(byte BEEBALICHLA, HHIDBLJMPGL JOECHPBBCNJ, HBBIPDINOCE EOBFGLJBCIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x6A69220", Offset = "0x6A67C20", VA = "0x186A69220")]
	public void BMKFLEEHJJC(HBBIPDINOCE PGDGHENJBJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
	public void KGMHJLIAPEL(int HOMMHBBLFIL, LHELKABBBFL OCHILLFNONC, int EILIMKGDFGJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x6A692E0", Offset = "0x6A67CE0", VA = "0x186A692E0")]
	public void EPGLMNAKGLN(List<byte> KOKHEJELMNC, Vector3 LHCEFCJDGIJ, float EJJBJPNFNHD, float CFOCLPDJCJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x6A695D0", Offset = "0x6A67FD0", VA = "0x186A695D0")]
	public bool LOBNFLGABBL(Vector3 GHLCFEHGEFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x6A69590", Offset = "0x6A67F90", VA = "0x186A69590")]
	public bool GKIGADFNLAC(Vector3 GHLCFEHGEFC, float ILDDCJLKPEJ)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		public struct BEIJJECFKBA<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			private readonly List<Component> ECNPNAMGIHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			private readonly bool FAHPCIBCOPH;

			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0x115F880", Offset = "0x115E280", VA = "0x18115F880")]
			public BEIJJECFKBA(List<Component> ECNPNAMGIHB, bool FAHPCIBCOPH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x4868890", Offset = "0x4867290", VA = "0x184868890")]
			public PJELBKMJMEB<T> ODEOKNNCFHI()
			{
				return default(PJELBKMJMEB<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x4868900", Offset = "0x4867300", VA = "0x184868900", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0x4868900", Offset = "0x4867300", VA = "0x184868900", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009E")]
		public struct PJELBKMJMEB<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			private readonly List<Component> ECNPNAMGIHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			private readonly bool FAHPCIBCOPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			private int ALJOMNDNEBM;

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public T LEJKACPKMMA
			{
				[Cpp2IlInjected.Token(Token = "0x6000389")]
				[Cpp2IlInjected.Address(RVA = "0x43E0B20", Offset = "0x43DF520", VA = "0x1843E0B20", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600038A")]
				[Cpp2IlInjected.Address(RVA = "0x43E0AB0", Offset = "0x43DF4B0", VA = "0x1843E0AB0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x43E0AF0", Offset = "0x43DF4F0", VA = "0x1843E0AF0")]
			public PJELBKMJMEB(List<Component> ECNPNAMGIHB, bool FAHPCIBCOPH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x43E09F0", Offset = "0x43DF3F0", VA = "0x1843E09F0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x43E0A00", Offset = "0x43DF400", VA = "0x1843E0A00", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x3BC0090", Offset = "0x3BBEA90", VA = "0x183BC0090", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x6A6F4B0", Offset = "0x6A6DEB0", VA = "0x186A6F4B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x6A6F470", Offset = "0x6A6DE70", VA = "0x186A6F470")]
		public ToolHierarchyCache(GameObject LNBPLDMMKPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x6A6F290", Offset = "0x6A6DC90", VA = "0x186A6F290")]
		private void NCBKDFJCMBF(GameObject LNBPLDMMKPA, bool BFIMHHIKINE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x6A6F200", Offset = "0x6A6DC00", VA = "0x186A6F200")]
		public static void NCBKDFJCMBF(GameObject LNBPLDMMKPA, ref ToolHierarchyCache JBCAAIHLJAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x6A6F020", Offset = "0x6A6DA20", VA = "0x186A6F020")]
		public void CJNMOENLGKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x6A6F030", Offset = "0x6A6DA30", VA = "0x186A6F030")]
		public void EBICENLCGAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x34F9940", Offset = "0x34F8340", VA = "0x1834F9940")]
		public void CCHPPBELLGM<T>(Action<T> DJJNLDOINEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x6A6EF50", Offset = "0x6A6D950", VA = "0x186A6EF50")]
		public Component ALGBIFLECMM(Type EMKINACMDLO, bool FAHPCIBCOPH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x34F98C0", Offset = "0x34F82C0", VA = "0x1834F98C0")]
		public T ALGBIFLECMM<T>(bool FAHPCIBCOPH = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x6A6F180", Offset = "0x6A6DB80", VA = "0x186A6F180")]
		public BEIJJECFKBA<Component> HGHMDHDKDAC(Type EMKINACMDLO, bool FAHPCIBCOPH = false)
		{
			return default(BEIJJECFKBA<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x34F9BD0", Offset = "0x34F85D0", VA = "0x1834F9BD0")]
		public BEIJJECFKBA<T> HGHMDHDKDAC<T>(bool FAHPCIBCOPH = false) where T : class
		{
			return default(BEIJJECFKBA<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x6A6EC00", Offset = "0x6A6D600", VA = "0x186A6EC00")]
		public List<Component> AIJJFEKNFOB(Type EMKINACMDLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x6A6F080", Offset = "0x6A6DA80", VA = "0x186A6F080", Slot = "4")]
		public bool Equals(ToolHierarchyCache KCAHJOFJKBP, ToolHierarchyCache NBBBAMBDAJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x6A6F100", Offset = "0x6A6DB00", VA = "0x186A6F100", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache OMHIFHKMIMJ)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class KPDDPPLBKMN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private int ICKPJJPJOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private int KNHPAFNJLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private List<T> KNIJIHCLOLF;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public int GNKNLJGDNJB
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x3612190", Offset = "0x3610B90", VA = "0x183612190")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public T FELGMGCNPJG
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x3BC4610", Offset = "0x3BC3010", VA = "0x183BC4610")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public T JPBHKMPKCPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x3BC4570", Offset = "0x3BC2F70", VA = "0x183BC4570")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public T IPIAPKMEGJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x3BC4770", Offset = "0x3BC3170", VA = "0x183BC4770")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x3BC4820", Offset = "0x3BC3220", VA = "0x183BC4820")]
	public KPDDPPLBKMN(int ICKPJJPJOOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x3BC4490", Offset = "0x3BC2E90", VA = "0x183BC4490")]
	public void IFPOOIAJHAI(T GBEAAPEADNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x3BC47E0", Offset = "0x3BC31E0", VA = "0x183BC47E0")]
	public void PDOAHDCGLGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x3BC4320", Offset = "0x3BC2D20", VA = "0x183BC4320")]
	public void GALBIKGCMMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x3BC42D0", Offset = "0x3BC2CD0", VA = "0x183BC42D0")]
	public void FBNDIPJGNGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x3BC47D0", Offset = "0x3BC31D0", VA = "0x183BC47D0")]
	public void NCNDJLJPCIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public class KPNMGDHIHPL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private bool NBGMKIKMJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private Action DJJNLDOINEG;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public static KPNMGDHIHPL MGIGNBGBCAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x6A6C300", Offset = "0x6A6AD00", VA = "0x186A6C300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool HJANPAMPGGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x7E6A20", Offset = "0x7E5420", VA = "0x1807E6A20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x871740", Offset = "0x870140", VA = "0x180871740")]
	public KPNMGDHIHPL(Action DJJNLDOINEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x6A6C2E0", Offset = "0x6A6ACE0", VA = "0x186A6C2E0")]
	public void IEOLHNPKHKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x6A6C2E0", Offset = "0x6A6ACE0", VA = "0x186A6C2E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public static class PGJFABBMGPE
{
	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x6A6CF10", Offset = "0x6A6B910", VA = "0x186A6CF10")]
	public static void MPNNAMHPBEB(MLJMKOJHCLB PMLIFLOCEOB, string CPBGBCOILJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
	public static void MPNNAMHPBEB(IEnumerable<object> GJLENILPINE, string CPBGBCOILJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public class HCFBMAIGBGM<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	private struct OPNOMFFHIEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public int PNPDJPOHNLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public T ONBMIOJBCHK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private readonly Dictionary<object, OPNOMFFHIEO> AHKMGODEDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private readonly EqualityComparer<T> NHPIBPFANKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private T MOMLEOMKCOK;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public virtual T NAJAPBMDIFA
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x94C330", Offset = "0x94AD30", VA = "0x18094C330", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x94C520", Offset = "0x94AF20", VA = "0x18094C520", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool ECDKDGMLFOP
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x454F010", Offset = "0x454DA10", VA = "0x18454F010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public object EHPIICGOOIM
	{
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x738BA0", Offset = "0x7375A0", VA = "0x180738BA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x7D4370", Offset = "0x7D2D70", VA = "0x1807D4370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x454EDC0", Offset = "0x454D7C0", VA = "0x18454EDC0")]
	public bool FMHGDPNPEHP(T MFBGAMJDOKA, object HMAOAMDKNDD, int ALIOAOHFFLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x45536C0", Offset = "0x45520C0", VA = "0x1845536C0")]
	public bool NHIFDNAHCNB(object HMAOAMDKNDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x454F040", Offset = "0x454DA40", VA = "0x18454F040")]
	public bool JBPBACKGAAO(object HMAOAMDKNDD, out T MFBGAMJDOKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x3EDA2F0", Offset = "0x3ED8CF0", VA = "0x183EDA2F0")]
	public void PDOAHDCGLGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x45533F0", Offset = "0x4551DF0", VA = "0x1845533F0")]
	private bool LIGMKANNBAA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x4553730", Offset = "0x4552130", VA = "0x184553730")]
	public HCFBMAIGBGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public class EELGDGCAIED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public readonly string JHFNCCFAECF;

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x82DEC0", Offset = "0x82C8C0", VA = "0x18082DEC0")]
	public EELGDGCAIED(string PIBNFDKCLPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x6A68D30", Offset = "0x6A67730", VA = "0x186A68D30")]
	public EELGDGCAIED(UnityEngine.Object JKIADIOPBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x6A68CE0", Offset = "0x6A676E0", VA = "0x186A68CE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class NNIFMOPFNIE
{
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private static byte[] FNNHBCFPBIC;

	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private static int IPKGAJADJFC;

	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private static int DIJMLDGECMG;

	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private static BigInteger DGOGINAIMEE;

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public NNIFMOPFNIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x6A6C880", Offset = "0x6A6B280", VA = "0x186A6C880")]
	private static string DAIOEIOFDHG(byte[] LPDJCHOFJLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x6A6C990", Offset = "0x6A6B390", VA = "0x186A6C990")]
	public static string LIOEFPBPBEO(byte[] AHIMNOMEIMA, bool ADOOPHPHCDD)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000194")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
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
