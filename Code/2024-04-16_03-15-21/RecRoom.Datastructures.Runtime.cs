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
using Microsoft.CodeAnalysis;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDC50", VA = "0x1807DEA50")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6106D20", Offset = "0x6105F20", VA = "0x186106D20")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DED90", Offset = "0x7DDF90", VA = "0x1807DED90")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7DEDD0", Offset = "0x7DDFD0", VA = "0x1807DEDD0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class OCAAIBBFGHH : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F40", Offset = "0x7C3140", VA = "0x1807C3F40")]
	public OCAAIBBFGHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, HPKNOMGBJGL, OEDGKHMLBEJ, ISerializationCallbackReceiver
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[SerializeField]
	private byte[] stableHash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	private byte[] seed;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public byte[] StableHash
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7B40F0", Offset = "0x7B32F0", VA = "0x1807B40F0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7B40E0", Offset = "0x7B32E0", VA = "0x1807B40E0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7B4110", Offset = "0x7B3310", VA = "0x1807B4110", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8788E0", Offset = "0x877AE0", VA = "0x1808788E0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash BKPDJAAHMDI);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x89F080", Offset = "0x89E280", VA = "0x18089F080")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[ABENGEDDIKJ]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[ABENGEDDIKJ]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6108D10", Offset = "0x6107F10", VA = "0x186108D10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6108CD0", Offset = "0x6107ED0", VA = "0x186108CD0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6108D50", Offset = "0x6107F50", VA = "0x186108D50")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6108F00", Offset = "0x6108100", VA = "0x186108F00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6108E70", Offset = "0x6108070", VA = "0x186108E70")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x939B60", Offset = "0x938D60", VA = "0x180939B60")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9F2660", Offset = "0x9F1860", VA = "0x1809F2660")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6108C90", Offset = "0x6107E90", VA = "0x186108C90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6108DE0", Offset = "0x6107FE0", VA = "0x186108DE0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6108700", Offset = "0x6107900", VA = "0x186108700")]
	public void CopyBounds(SavedExtents MEJMHKPOODP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6108BE0", Offset = "0x6107DE0", VA = "0x186108BE0")]
	public void SetLocalSpaceBounds(Bounds JEMDHGJDKNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xA2A270", Offset = "0xA29470", VA = "0x180A2A270")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6108BD0", Offset = "0x6107DD0", VA = "0x186108BD0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x61087F0", Offset = "0x61079F0", VA = "0x1861087F0")]
	private void IKGGJNCICGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x61089B0", Offset = "0x6107BB0", VA = "0x1861089B0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x61080C0", Offset = "0x61072C0", VA = "0x1861080C0")]
	public static void CalculateLocalBoundsFor(GameObject CHIOFKOKCNE, [Out] Bounds JEMDHGJDKNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6108730", Offset = "0x6107930", VA = "0x186108730")]
	private static void IDKJHKCAGDJ(Bounds HIOEJKGFIKI, Color PHDOOEGGBGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6108C00", Offset = "0x6107E00", VA = "0x186108C00")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7B3110", Offset = "0x7B2310", VA = "0x1807B3110")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7BE610", Offset = "0x7BD810", VA = "0x1807BE610")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xE58480", Offset = "0xE57680", VA = "0x180E58480")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4389610", Offset = "0x4388810", VA = "0x184389610")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "4")]
	public virtual void FBKABJLCHIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[OCAAIBBFGHH]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4389240", Offset = "0x4388440", VA = "0x184389240", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4388030", Offset = "0x4387230", VA = "0x184388030", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4389550", Offset = "0x4388750", VA = "0x184389550")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class FMNHLAEBHHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public FMNHLAEBHHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x37C1450", Offset = "0x37C0650", VA = "0x1837C1450")]
		internal int JNMGCACCGKC(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[OCAAIBBFGHH]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x343CBB0", Offset = "0x343BDB0", VA = "0x18343CBB0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x343CBF0", Offset = "0x343BDF0", VA = "0x18343CBF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x343CAD0", Offset = "0x343BCD0", VA = "0x18343CAD0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey GHBNLDGJPCB]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x343CB50", Offset = "0x343BD50", VA = "0x18343CB50", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x343C9D0", Offset = "0x343BBD0", VA = "0x18343C9D0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x343C720", Offset = "0x343B920", VA = "0x18343C720", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x343BC60", Offset = "0x343AE60", VA = "0x18343BC60", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x343BBD0", Offset = "0x343ADD0", VA = "0x18343BBD0", Slot = "14")]
	protected virtual string KLNKEDIBPJG(TKeyVal HLNNHLKICCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x343BAF0", Offset = "0x343ACF0", VA = "0x18343BAF0", Slot = "4")]
	public bool ContainsKey(TKey GHBNLDGJPCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x343C8A0", Offset = "0x343BAA0", VA = "0x18343C8A0", Slot = "5")]
	public bool TryGetValue(TKey GHBNLDGJPCB, [Out] TVal EKDDCPALANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x343BB30", Offset = "0x343AD30", VA = "0x18343BB30", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x343BB30", Offset = "0x343AD30", VA = "0x18343BB30", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x343C8E0", Offset = "0x343BAE0", VA = "0x18343C8E0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class DIFCIKDICCI<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class KFOACMBIJOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public float DOHDJPEFMJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public T LJLHDNLHLNB;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public KFOACMBIJOH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class BJNJDPKDLLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public BJNJDPKDLLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x47C8B90", Offset = "0x47C7D90", VA = "0x1847C8B90")]
		internal bool AEKIJBNIFOB(KFOACMBIJOH sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly float ABKGNHIEDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly float ODPKIANFCOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<KFOACMBIJOH> KNCEKGIADGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private HBOIKJHBDPP<KFOACMBIJOH> AELFKJGPLDK;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int ANEDNCPKLEC
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x509ABF0", Offset = "0x5099DF0", VA = "0x18509ABF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x509ACD0", Offset = "0x5099ED0", VA = "0x18509ACD0")]
	public DIFCIKDICCI(float GHCPBHACCOM, float MJHMGFKALKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x509AA80", Offset = "0x5099C80", VA = "0x18509AA80")]
	public bool LJKEOJJNPOP(float NOOMBIPKGEF, T EKDDCPALANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x509A640", Offset = "0x5099840", VA = "0x18509A640")]
	public IEnumerable<T> JKKJPMNMAHJ(float NOOMBIPKGEF, [Optional] float? HLJDJNIPAHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x509A1C0", Offset = "0x50993C0", VA = "0x18509A1C0")]
	public void DBHKOJLPIHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x509A220", Offset = "0x5099420", VA = "0x18509A220")]
	private void DDMIFPHNHNB(float NOOMBIPKGEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class POFKLJDJNAF<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct NMKDDADEBFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public T LJLHDNLHLNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public float KEEFJHFLJBM;
	}

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static float IBCLOPAOLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private List<T> PMLJCCJIEJA;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private const int IFJALNILEGI = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private NMKDDADEBFJ[] BLGDAGLONDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int MJPNCIDAACK;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float COPJOBNLMFP
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x83EDC0", Offset = "0x83DFC0", VA = "0x18083EDC0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x86ECE0", Offset = "0x86DEE0", VA = "0x18086ECE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x41C0240", Offset = "0x41BF440", VA = "0x1841C0240")]
	public POFKLJDJNAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x41C0260", Offset = "0x41BF460", VA = "0x1841C0260")]
	public POFKLJDJNAF(int ANCJPCFOHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x41BFE90", Offset = "0x41BF090", VA = "0x1841BFE90")]
	public void GHBEENLPKLN(float NOOMBIPKGEF, T EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x41BF8B0", Offset = "0x41BEAB0", VA = "0x1841BF8B0")]
	public void DBHKOJLPIHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x41BFBF0", Offset = "0x41BEDF0", VA = "0x1841BFBF0")]
	public bool EIAEICFALCF(float NAKJEPNEEIE, float DEIGDMCDHFC, [Out] T EKDDCPALANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x41BF5F0", Offset = "0x41BE7F0", VA = "0x1841BF5F0")]
	public bool AHIAAPFMNML(float NAKJEPNEEIE, float DEIGDMCDHFC, [Out] T EKDDCPALANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x41BFF50", Offset = "0x41BF150", VA = "0x1841BFF50")]
	public void HAMOCDMMIKC(float NAKJEPNEEIE, float DEIGDMCDHFC, List<T> ENIOLEEEFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x41C01C0", Offset = "0x41BF3C0", VA = "0x1841C01C0")]
	private int LOENFDIOLPB(int IHGPKIKGFMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x41BF780", Offset = "0x41BE980", VA = "0x1841BF780")]
	private void CHPMBABACLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T FHMBHCOPDAG();

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T GBDCCKDKPPJ(T EKDDCPALANJ, float EEEPNFLJEFK);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T CNOOIEGLGKH(T DEHAFGPDPHM, T FAFKEFEMLFH);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T JKKOBBDBJFD(T DEHAFGPDPHM, T FAFKEFEMLFH);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class HBKMMOHBLPH : POFKLJDJNAF<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7C47D0", Offset = "0x7C39D0", VA = "0x1807C47D0", Slot = "4")]
	protected override Vector3 FHMBHCOPDAG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x61050F0", Offset = "0x61042F0", VA = "0x1861050F0", Slot = "5")]
	protected override Vector3 GBDCCKDKPPJ(Vector3 EKDDCPALANJ, float EEEPNFLJEFK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x61050A0", Offset = "0x61042A0", VA = "0x1861050A0", Slot = "6")]
	protected override Vector3 CNOOIEGLGKH(Vector3 DEHAFGPDPHM, Vector3 FAFKEFEMLFH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6105130", Offset = "0x6104330", VA = "0x186105130", Slot = "7")]
	protected override Vector3 JKKOBBDBJFD(Vector3 DEHAFGPDPHM, Vector3 FAFKEFEMLFH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x61051B0", Offset = "0x61043B0", VA = "0x1861051B0")]
	public HBKMMOHBLPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class LKHIJDACPMC
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2911FA0", Offset = "0x29111A0", VA = "0x182911FA0")]
	public static JMPNLFGJEMK<T1, T2> DMOLILFLBFL<T1, T2>(T1 BPHOFMFECFH, T2 FLLOOOOHOBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2912020", Offset = "0x2911220", VA = "0x182912020")]
	public static OHJDGDINNKP<T1, T2, T3> DMOLILFLBFL<T1, T2, T3>(T1 BPHOFMFECFH, T2 FLLOOOOHOBI, T3 DNNBMLOECOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3F723A0", Offset = "0x3F715A0", VA = "0x183F723A0")]
	internal static int NNEMDHGJKFM(int AOJMHIBCBMP, int BDNMEJDFNBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5536B50", Offset = "0x5535D50", VA = "0x185536B50")]
	internal static int NNEMDHGJKFM(int AOJMHIBCBMP, int BDNMEJDFNBD, int GCOCDGGAOEF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class JMPNLFGJEMK<T1, T2> : IComparable<JMPNLFGJEMK<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly T1 CGBONFMHGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly T2 KDMPNLPMIFL;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3C4D540", Offset = "0x3C4C740", VA = "0x183C4D540")]
	public JMPNLFGJEMK(T1 BPHOFMFECFH, T2 FLLOOOOHOBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3C4C3E0", Offset = "0x3C4B5E0", VA = "0x183C4C3E0", Slot = "4")]
	public int CompareTo(JMPNLFGJEMK<T1, T2> MEJMHKPOODP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3C4C6E0", Offset = "0x3C4B8E0", VA = "0x183C4C6E0", Slot = "0")]
	public override bool Equals(object MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3C4CDA0", Offset = "0x3C4BFA0", VA = "0x183C4CDA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3C4CF90", Offset = "0x3C4C190", VA = "0x183C4CF90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class OHJDGDINNKP<T1, T2, T3> : IComparable<OHJDGDINNKP<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly T1 CGBONFMHGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly T2 KDMPNLPMIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly T3 AOLJIJMJMCN;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4101130", Offset = "0x4100330", VA = "0x184101130")]
	public OHJDGDINNKP(T1 BPHOFMFECFH, T2 FLLOOOOHOBI, T3 DNNBMLOECOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4100980", Offset = "0x40FFB80", VA = "0x184100980", Slot = "4")]
	public int CompareTo(OHJDGDINNKP<T1, T2, T3> MEJMHKPOODP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4100BB0", Offset = "0x40FFDB0", VA = "0x184100BB0", Slot = "0")]
	public override bool Equals(object MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4100D40", Offset = "0x40FFF40", VA = "0x184100D40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4100F80", Offset = "0x4100180", VA = "0x184100F80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T LJLHDNLHLNB
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2144C80", Offset = "0x2143E80", VA = "0x182144C80")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2144BD0", Offset = "0x2143DD0", VA = "0x182144BD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float DEEFDHNDGDM
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8B9370", Offset = "0x8B8570", VA = "0x1808B9370")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4574500", Offset = "0x4573700", VA = "0x184574500")]
	public T AGLKLHNKFEI(float EEEPNFLJEFK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x45747F0", Offset = "0x45739F0", VA = "0x1845747F0")]
	public T EEAMICBLPDD(float EEEPNFLJEFK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T OILGCJHNECL(T DEHAFGPDPHM, T FAFKEFEMLFH, float EEEPNFLJEFK);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6105020", Offset = "0x6104220", VA = "0x186105020", Slot = "4")]
	protected override float OILGCJHNECL(float DEHAFGPDPHM, float FAFKEFEMLFH, float EEEPNFLJEFK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6105060", Offset = "0x6104260", VA = "0x186105060")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xCF1980", Offset = "0xCF0B80", VA = "0x180CF1980", Slot = "4")]
	protected override Vector3 OILGCJHNECL(Vector3 DEHAFGPDPHM, Vector3 FAFKEFEMLFH, float EEEPNFLJEFK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6109C00", Offset = "0x6108E00", VA = "0x186109C00")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6104E50", Offset = "0x6104050", VA = "0x186104E50", Slot = "4")]
	protected override Color OILGCJHNECL(Color DEHAFGPDPHM, Color FAFKEFEMLFH, float EEEPNFLJEFK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6104F10", Offset = "0x6104110", VA = "0x186104F10")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class MIAAMPJPADD : GMCGKADNICE<string>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6106CD0", Offset = "0x6105ED0", VA = "0x186106CD0")]
	public MIAAMPJPADD(int ONEEJBCNCKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6106C60", Offset = "0x6105E60", VA = "0x186106C60", Slot = "6")]
	protected override uint PLOHKOCJHPB(uint BKPDJAAHMDI, string EKDDCPALANJ)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class BFMJNNNGFIC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly IDisposable EELHBDDPCDG;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public BFMJNNNGFIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct PAOOCFNJBLA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> KBNAJFMOKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int FKJNDIBCFIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int CMBPHDJNIPG;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x38387F0", Offset = "0x38379F0", VA = "0x1838387F0")]
	private PAOOCFNJBLA(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> MBBKNOHDLNL, int FOOBGCCMALF, int GBIOFCEABIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x418F220", Offset = "0x418E420", VA = "0x18418F220")]
	public static PAOOCFNJBLA<T> DHBNKMCPKNO()
	{
		return default(PAOOCFNJBLA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x418DEA0", Offset = "0x418D0A0", VA = "0x18418DEA0")]
	public (int, int, Task<T>) BDFNGLPIIAA(int BJLBPPPFCJE, [Optional] CancellationToken IOOGCHJMBIE, double AJKELOHAHIE = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x418F800", Offset = "0x418EA00", VA = "0x18418F800")]
	public void ONFFOLBDCFH(int BJLBPPPFCJE, int GBIOFCEABIN, [In] T IFJGEIAONPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class FLIGOECJFFD
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6104F50", Offset = "0x6104150", VA = "0x186104F50")]
	public static PAOOCFNJBLA<NFDBFOHCHGK> DHBNKMCPKNO()
	{
		return default(PAOOCFNJBLA<NFDBFOHCHGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6104FA0", Offset = "0x61041A0", VA = "0x186104FA0")]
	public static void ONFFOLBDCFH([In] this PAOOCFNJBLA<NFDBFOHCHGK> AOFIGDLFNLH, int BJLBPPPFCJE, int GBIOFCEABIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class KAHFDMOGNCF<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<TKey, TVal> HGEHCFPOFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly Dictionary<TVal, TKey> JKMBCPCLMPI;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int GIHIJMKOGEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x322EEE0", Offset = "0x322E0E0", VA = "0x18322EEE0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool APKLFGKPCKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ICollection<TKey> OKELJLLLMNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3BEC170", Offset = "0x3BEB370", VA = "0x183BEC170", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ICollection<TVal> DNHPKLHNLHH
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3CA3580", Offset = "0x3CA2780", VA = "0x183CA3580", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TVal KFIAMJJGJCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x3CA3520", Offset = "0x3CA2720", VA = "0x183CA3520", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3CA35C0", Offset = "0x3CA27C0", VA = "0x183CA35C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey KFIAMJJGJCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3CA31F0", Offset = "0x3CA23F0", VA = "0x183CA31F0")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3CA2920", Offset = "0x3CA1B20", VA = "0x183CA2920", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3CA32C0", Offset = "0x3CA24C0", VA = "0x183CA32C0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3CA28F0", Offset = "0x3CA1AF0", VA = "0x183CA28F0", Slot = "9")]
	public void Add(TKey GHBNLDGJPCB, TVal EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3CA28C0", Offset = "0x3CA1AC0", VA = "0x183CA28C0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> KBNEJAIFICP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3C34EB0", Offset = "0x3C340B0", VA = "0x183C34EB0", Slot = "8")]
	public bool ContainsKey(TKey GHBNLDGJPCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3CA29D0", Offset = "0x3CA1BD0", VA = "0x183CA29D0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> KBNEJAIFICP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3CA3270", Offset = "0x3CA2470", VA = "0x183CA3270", Slot = "10")]
	public bool Remove(TKey GHBNLDGJPCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3CA3240", Offset = "0x3CA2440", VA = "0x183CA3240", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> KBNEJAIFICP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3CA33B0", Offset = "0x3CA25B0", VA = "0x183CA33B0", Slot = "11")]
	public bool TryGetValue(TKey GHBNLDGJPCB, [Out] TVal EKDDCPALANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3CA2CD0", Offset = "0x3CA1ED0", VA = "0x183CA2CD0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3CA2A00", Offset = "0x3CA1C00", VA = "0x183CA2A00", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] BLGDAGLONDD, int IMCGHBJCPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3CA2FC0", Offset = "0x3CA21C0", VA = "0x183CA2FC0")]
	public bool JNNFGFKBPPN(TVal GHBNLDGJPCB, [Out] TKey EKDDCPALANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3CA3110", Offset = "0x3CA2310", VA = "0x183CA3110")]
	private void KMGMDNGPBMN(TKey GHBNLDGJPCB, TVal FKBAIKAGEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3CA2E60", Offset = "0x3CA2060", VA = "0x183CA2E60")]
	private void HLAIPOHPOHP(TKey GHBNLDGJPCB, TVal FKBAIKAGEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3CA2A70", Offset = "0x3CA1C70", VA = "0x183CA2A70")]
	private bool ECHAEMOBOCA(TKey GHBNLDGJPCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3CA33F0", Offset = "0x3CA25F0", VA = "0x183CA33F0")]
	public KAHFDMOGNCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[DefaultMember("Item")]
public class LPEGCALGKJD<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private LPEGCALGKJD<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x3484A80", Offset = "0x3483C80", VA = "0x183484A80", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x3488FB0", Offset = "0x34881B0", VA = "0x183488FB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x348A600", Offset = "0x3489800", VA = "0x18348A600")]
		public Enumerator(LPEGCALGKJD<T> ENIOLEEEFGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x3486A90", Offset = "0x3485C90", VA = "0x183486A90", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3488520", Offset = "0x3487720", VA = "0x183488520", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3485FC0", Offset = "0x34851C0", VA = "0x183485FC0")]
		private void JGIKJILCFEK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private T[] HHOIGACGJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private int BHOMKDDOKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private int FPIKPOCAMFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int BKPHPJDBECD;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int GIHIJMKOGEP
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3D6DC70", Offset = "0x3D6CE70", VA = "0x183D6DC70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T KFIAMJJGJCP
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x3D6E9D0", Offset = "0x3D6DBD0", VA = "0x183D6E9D0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x3D6D9B0", Offset = "0x3D6CBB0", VA = "0x183D6D9B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3D6F760", Offset = "0x3D6E960", VA = "0x183D6F760")]
	public LPEGCALGKJD(int ONEEJBCNCKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3D6DDA0", Offset = "0x3D6CFA0", VA = "0x183D6DDA0")]
	public void GHBEENLPKLN(T EEEPNFLJEFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3D6DC50", Offset = "0x3D6CE50", VA = "0x183D6DC50")]
	public void DBHKOJLPIHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3D6EB40", Offset = "0x3D6DD40", VA = "0x183D6EB40")]
	public void OMHEKGFBLFH(int KMJOEPJMADC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3D6EEC0", Offset = "0x3D6E0C0", VA = "0x183D6EEC0")]
	public void PGAGAIDENBL(T[] BLGDAGLONDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3D6E280", Offset = "0x3D6D480", VA = "0x183D6E280")]
	public Enumerator LEPKJMNOIOO()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3D6F480", Offset = "0x3D6E680", VA = "0x183D6F480", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3D6F480", Offset = "0x3D6E680", VA = "0x183D6F480", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3D6E5C0", Offset = "0x3D6D7C0", VA = "0x183D6E5C0")]
	private int NAODIOGOAMH(int MBGANDEDPDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3D6DC20", Offset = "0x3D6CE20", VA = "0x183D6DC20")]
	private int BHFIIIDKMFB(int MBGANDEDPDN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class FABKAHJICFB<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public delegate Task<TResult> LKMBJPPMPAF(TRequest NOGNLJBIFAF, CancellationToken IOOGCHJMBIE);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public enum KEENHCJPMMN
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class OLILHIPHBFD
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private const float HKCBEDPLNEH = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TimeSpan LMFGCJEPEHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int CINNIBCIDEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public KEENHCJPMMN NBAMCGHDDAD;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static readonly OLILHIPHBFD LMPCLGLBJMP;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float OIGJBFKHNLC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x4108C70", Offset = "0x4107E70", VA = "0x184108C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public TimeSpan OOODEBJEJOP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x4108D50", Offset = "0x4107F50", VA = "0x184108D50")]
		public OLILHIPHBFD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private readonly struct JIMFKNDHDBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly TRequest NOGNLJBIFAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly CancellationToken IOOGCHJMBIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly TaskCompletionSource<TResult> JLBCNFNJHEH;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x3C1DE20", Offset = "0x3C1D020", VA = "0x183C1DE20")]
		public JIMFKNDHDBK(TRequest NOGNLJBIFAF, TaskCompletionSource<TResult> JLBCNFNJHEH, CancellationToken IOOGCHJMBIE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct BFOIJPPKHCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public FABKAHJICFB<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x47BBE70", Offset = "0x47BB070", VA = "0x1847BBE70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x47BC230", Offset = "0x47BB430", VA = "0x1847BC230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct IDPLMALHDOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public FABKAHJICFB<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private JIMFKNDHDBK <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x3A1FFB0", Offset = "0x3A1F1B0", VA = "0x183A1FFB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x3A20520", Offset = "0x3A1F720", VA = "0x183A20520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly CancellationTokenSource BLACDNCJOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly List<JIMFKNDHDBK> EPDDGHOBDHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly OLILHIPHBFD GAGLGPCMKOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly LKMBJPPMPAF JNMOHJHGMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Task BHCIBGBOLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private int AANEDGGLIHD;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x37558E0", Offset = "0x3754AE0", VA = "0x1837558E0")]
	public FABKAHJICFB(LKMBJPPMPAF JNMOHJHGMBB, [Optional] OLILHIPHBFD GAGLGPCMKOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x37541C0", Offset = "0x37533C0", VA = "0x1837541C0")]
	public Task<TResult> DKCLBKOMLLH(TRequest NOGNLJBIFAF, CancellationToken IOOGCHJMBIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3754750", Offset = "0x3753950", VA = "0x183754750")]
	private void EHAHAEMFENH(JIMFKNDHDBK JOHLDHMKHNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x37555D0", Offset = "0x37547D0", VA = "0x1837555D0")]
	[AsyncStateMachine(typeof(FABKAHJICFB<, >.BFOIJPPKHCE))]
	private Task PJJLGEMHLEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3754D90", Offset = "0x3753F90", VA = "0x183754D90")]
	private JIMFKNDHDBK PAHJLPKHAGA()
	{
		return default(JIMFKNDHDBK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3754BB0", Offset = "0x3753DB0", VA = "0x183754BB0")]
	[AsyncStateMachine(typeof(FABKAHJICFB<, >.IDPLMALHDOD))]
	private Task LICHKJCHNJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x37548D0", Offset = "0x3753AD0", VA = "0x1837548D0")]
	private void JHMDJJBJDCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x37545D0", Offset = "0x37537D0", VA = "0x1837545D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class FPJLEBGIGIM<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly List<T> LBDHFFKKBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private HashSet<T> LFCAGELHIEA;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int GIHIJMKOGEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x322EEE0", Offset = "0x322E0E0", VA = "0x18322EEE0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool APKLFGKPCKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public T KFIAMJJGJCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x37C9740", Offset = "0x37C8940", VA = "0x1837C9740", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x37C9780", Offset = "0x37C8980", VA = "0x1837C9780", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x37595D0", Offset = "0x37587D0", VA = "0x1837595D0", Slot = "11")]
	public void Add(T KBNEJAIFICP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x37C91F0", Offset = "0x37C83F0", VA = "0x1837C91F0")]
	public bool PLJNONPJNEA(T KBNEJAIFICP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x37C95A0", Offset = "0x37C87A0", VA = "0x1837C95A0", Slot = "15")]
	public bool Remove(T KBNEJAIFICP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x37C8F90", Offset = "0x37C8190", VA = "0x1837C8F90", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x37C9630", Offset = "0x37C8830", VA = "0x1837C9630", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x37C8EC0", Offset = "0x37C80C0", VA = "0x1837C8EC0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x37C8F20", Offset = "0x37C8120", VA = "0x1837C8F20", Slot = "13")]
	public bool Contains(T KBNEJAIFICP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x37C8F60", Offset = "0x37C8160", VA = "0x1837C8F60", Slot = "14")]
	public void CopyTo(T[] BLGDAGLONDD, int IMCGHBJCPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x37C9010", Offset = "0x37C8210", VA = "0x1837C9010", Slot = "6")]
	public int IndexOf(T KBNEJAIFICP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x37C9120", Offset = "0x37C8320", VA = "0x1837C9120", Slot = "7")]
	public void Insert(int MBGANDEDPDN, T KBNEJAIFICP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x37C9350", Offset = "0x37C8550", VA = "0x1837C9350", Slot = "8")]
	public void RemoveAt(int MBGANDEDPDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x37C9650", Offset = "0x37C8850", VA = "0x1837C9650")]
	public FPJLEBGIGIM()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
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

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x1FBC260", Offset = "0x1FBB460", VA = "0x181FBC260")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x61092A0", Offset = "0x61084A0", VA = "0x1861092A0")]
		public SerializedGuid([In] Guid JJMGPACFMMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x61090A0", Offset = "0x61082A0", VA = "0x1861090A0")]
		public static SerializedGuid HCGNGAHHBKJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6109120", Offset = "0x6108320", VA = "0x186109120")]
		public static SerializedGuid NCHHCKPCGMH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6109190", Offset = "0x6108390", VA = "0x186109190")]
		public bool OBLLEJJIIHM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6109270", Offset = "0x6108470", VA = "0x186109270", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x61091F0", Offset = "0x61083F0", VA = "0x1861091F0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6108FC0", Offset = "0x61081C0", VA = "0x186108FC0", Slot = "7")]
		public bool Equals(SerializedGuid MEJMHKPOODP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6109000", Offset = "0x6108200", VA = "0x186109000", Slot = "0")]
		public override bool Equals(object GLMGCMELGFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6109090", Offset = "0x6108290", VA = "0x186109090", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6108F90", Offset = "0x6108190", VA = "0x186108F90", Slot = "6")]
		public int CompareTo(SerializedGuid MEJMHKPOODP)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class KGCGNOCCCAH : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly Type ENILKBNGAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly string FLMPEAFJOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool FNAGHPCMPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool HAIEEIOICGF;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6106620", Offset = "0x6105820", VA = "0x186106620")]
	public KGCGNOCCCAH(Type FGKGGDBKGGD, string AJNDPAKLJKF, bool ODHCJJFLNPC = false, bool CPOLJFNPKCC = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class FMDPIFHBCJG<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public readonly struct BLPCMNDFPMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly long HMNCNIJAMDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly long KPODOAJPNMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public readonly int HBCLGFKLNFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly int GMDGDNMOGDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly bool ALIMGFPJIFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly string ECIIKLMPILO;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x47D60A0", Offset = "0x47D52A0", VA = "0x1847D60A0")]
		public BLPCMNDFPMH(long HMNCNIJAMDN, int HBCLGFKLNFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x47D6070", Offset = "0x47D5270", VA = "0x1847D6070")]
		public BLPCMNDFPMH(long HMNCNIJAMDN, long KPODOAJPNMF, int HBCLGFKLNFN, int GMDGDNMOGDB, bool ALIMGFPJIFM, string ECIIKLMPILO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x47D5F00", Offset = "0x47D5100", VA = "0x1847D5F00")]
		public int ABIHNKFMKOB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x47D5FB0", Offset = "0x47D51B0", VA = "0x1847D5FB0")]
		public int KDPIFOOBBGC(int HMAFMFHEPOF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x47D5F50", Offset = "0x47D5150", VA = "0x1847D5F50")]
		public double ALFONDDLEAA()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x47D5FD0", Offset = "0x47D51D0", VA = "0x1847D5FD0")]
		public BLPCMNDFPMH KGINCDPPGAB(long KPODOAJPNMF, int GMDGDNMOGDB)
		{
			return default(BLPCMNDFPMH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class BBMCKKPJOID : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private struct MECHLFDOELF<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public BBMCKKPJOID <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Func<BBMCKKPJOID, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private BBMCKKPJOID <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x3F11BA0", Offset = "0x3F10DA0", VA = "0x183F11BA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x3F12090", Offset = "0x3F11290", VA = "0x183F12090", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly TKey NFEHEBDHPKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly FMDPIFHBCJG<TKey> LCCLFFMGBGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly IOBNAOMELJK AOBMECMACLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private List<BBMCKKPJOID> HFFIFEMGHLI;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public string CBDFMMICMPM
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x47A83C0", Offset = "0x47A75C0", VA = "0x1847A83C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public IEnumerable<BBMCKKPJOID> FCLBFFIINLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x47A8390", Offset = "0x47A7590", VA = "0x1847A8390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public BLPCMNDFPMH NAODNGOKKOE
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x47A8010", Offset = "0x47A7210", VA = "0x1847A8010")]
			[CompilerGenerated]
			get
			{
				return default(BLPCMNDFPMH);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x47A8210", Offset = "0x47A7410", VA = "0x1847A8210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x47A83F0", Offset = "0x47A75F0", VA = "0x1847A83F0")]
		internal BBMCKKPJOID(FMDPIFHBCJG<TKey> LCCLFFMGBGA, TKey GHBNLDGJPCB, IOBNAOMELJK AOBMECMACLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x47A8240", Offset = "0x47A7440", VA = "0x1847A8240")]
		public BBMCKKPJOID FKLNPJCKCMC(TKey GHBNLDGJPCB, [Optional] IOBNAOMELJK? LAEJGKCODCN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x238A350", Offset = "0x2389550", VA = "0x18238A350")]
		[AsyncStateMachine(typeof(MECHLFDOELF<>))]
		public Task<T> EAHEHCGGDMP<T>(TKey GHBNLDGJPCB, Func<BBMCKKPJOID, Task<T>> CMJCJMMJFOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x47A8030", Offset = "0x47A7230", VA = "0x1847A8030", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class LFMOCFILNLE : IEnumerable<(TKey, List<TKey>, BLPCMNDFPMH)>, IEnumerable, IEnumerator<(TKey, List<TKey>, BLPCMNDFPMH)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private (TKey key, List<TKey> path, BLPCMNDFPMH timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public FMDPIFHBCJG<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IEnumerator<(TKey key, List<TKey> path, BLPCMNDFPMH timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private (TKey, List<TKey>, BLPCMNDFPMH) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x1FBE810", Offset = "0x1FBDA10", VA = "0x181FBE810", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, BLPCMNDFPMH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x3D5B5E0", Offset = "0x3D5A7E0", VA = "0x183D5B5E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x1FBE900", Offset = "0x1FBDB00", VA = "0x181FBE900")]
		[DebuggerHidden]
		public LFMOCFILNLE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x36544B0", Offset = "0x36536B0", VA = "0x1836544B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3D5B150", Offset = "0x3D5A350", VA = "0x183D5B150", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3D5B100", Offset = "0x3D5A300", VA = "0x183D5B100")]
		private void KNOPPBKNOBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x3D5B590", Offset = "0x3D5A790", VA = "0x183D5B590", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3D5B4D0", Offset = "0x3D5A6D0", VA = "0x183D5B4D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, BLPCMNDFPMH)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3403960", Offset = "0x3402B60", VA = "0x183403960", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class BIKEGLJBDPM : IEnumerable<(TKey, List<TKey>, BLPCMNDFPMH)>, IEnumerable, IEnumerator<(TKey, List<TKey>, BLPCMNDFPMH)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private (TKey key, List<TKey> path, BLPCMNDFPMH timerEntry) <>2__current;

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
		private BBMCKKPJOID timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public BBMCKKPJOID <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public FMDPIFHBCJG<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private IEnumerator<BBMCKKPJOID> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private IEnumerator<(TKey key, List<TKey> path, BLPCMNDFPMH timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, BLPCMNDFPMH) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x1FBE810", Offset = "0x1FBDA10", VA = "0x181FBE810", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, BLPCMNDFPMH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x47C6BF0", Offset = "0x47C5DF0", VA = "0x1847C6BF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x1FBE900", Offset = "0x1FBDB00", VA = "0x181FBE900")]
		[DebuggerHidden]
		public BIKEGLJBDPM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x47C6C50", Offset = "0x47C5E50", VA = "0x1847C6C50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x47C6360", Offset = "0x47C5560", VA = "0x1847C6360", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x47C6300", Offset = "0x47C5500", VA = "0x1847C6300")]
		private void KNOPPBKNOBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x47C62A0", Offset = "0x47C54A0", VA = "0x1847C62A0")]
		private void KEKJABDJFPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x47C6BA0", Offset = "0x47C5DA0", VA = "0x1847C6BA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x47C6AC0", Offset = "0x47C5CC0", VA = "0x1847C6AC0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, BLPCMNDFPMH)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x439ACE0", Offset = "0x4399EE0", VA = "0x18439ACE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly Action<TKey, BLPCMNDFPMH, IOBNAOMELJK> AANPCEDCNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Action<TKey, BLPCMNDFPMH, IOBNAOMELJK> JKDIKCJIFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly Action<FMDPIFHBCJG<TKey>, IOBNAOMELJK> PENCLAHNNEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly IOBNAOMELJK AOBMECMACLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly BBMCKKPJOID GOBGBINKKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private bool FKFJMFIPHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int MDJJOBMPKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly Stopwatch HPBFPIBIPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly int NGMLJOEGPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private string LHDGDMOANHJ;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public BBMCKKPJOID PIPBCIFCOOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	[NotNull]
	public string CBDFMMICMPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7BBF60", Offset = "0x7BB160", VA = "0x1807BBF60")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x37C0D00", Offset = "0x37BFF00", VA = "0x1837C0D00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x37C0D60", Offset = "0x37BFF60", VA = "0x1837C0D60")]
	public FMDPIFHBCJG(TKey OMOMBDMGJLP, IOBNAOMELJK AOBMECMACLL, [Optional] int? HBCLGFKLNFN, [Optional][CanBeNull] Stopwatch HPBFPIBIPPO, [Optional] Action<TKey, BLPCMNDFPMH, IOBNAOMELJK> AANPCEDCNAD, [Optional] Action<TKey, BLPCMNDFPMH, IOBNAOMELJK> JKDIKCJIFFC, [Optional] Action<FMDPIFHBCJG<TKey>, IOBNAOMELJK> PENCLAHNNEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x37C0C70", Offset = "0x37BFE70", VA = "0x1837C0C70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x37C0B10", Offset = "0x37BFD10", VA = "0x1837C0B10")]
	[IteratorStateMachine(typeof(FMDPIFHBCJG<>.LFMOCFILNLE))]
	public IEnumerable<(TKey, List<TKey>, BLPCMNDFPMH)> DPKOPDJGLMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x37C0BA0", Offset = "0x37BFDA0", VA = "0x1837C0BA0")]
	[IteratorStateMachine(typeof(FMDPIFHBCJG<>.BIKEGLJBDPM))]
	private IEnumerable<(TKey, List<TKey>, BLPCMNDFPMH)> DPKOPDJGLMB(List<TKey> HJAAHPMFKAB, BBMCKKPJOID EGBGGCNMABG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x37C0A90", Offset = "0x37BFC90", VA = "0x1837C0A90")]
	private (long, int) ANKMONIJOBM()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public abstract class ALHJBBKFJCG<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut CHEMDLCMAMB(FMDPIFHBCJG<TKey> LCCLFFMGBGA);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	protected ALHJBBKFJCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public abstract class AGCEDDIOBLJ<TKey> : ALHJBBKFJCG<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate string BIEBJFLOKNL(TKey GHBNLDGJPCB);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3840180", Offset = "0x383F380", VA = "0x183840180")]
	private static string DOKBNKJMCLB(TKey GHBNLDGJPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x383FF90", Offset = "0x383F190", VA = "0x18383FF90", Slot = "4")]
	public override string CHEMDLCMAMB(FMDPIFHBCJG<TKey> LCCLFFMGBGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3840040", Offset = "0x383F240", VA = "0x183840040")]
	public string CHEMDLCMAMB(FMDPIFHBCJG<TKey> LCCLFFMGBGA, [NotNull] BIEBJFLOKNL LCCKKENFDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string MCFPPLOBEPH(FMDPIFHBCJG<TKey> LCCLFFMGBGA, [NotNull] BIEBJFLOKNL LCCKKENFDBE);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x377B020", Offset = "0x377A220", VA = "0x18377B020")]
	protected AGCEDDIOBLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class PFGKCPMCLGL<TKey> : ALHJBBKFJCG<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public delegate string FJFACCLNHFL(TKey GHBNLDGJPCB);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly string MLGNOFAPNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly double NEBHMCENLMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly bool CPMKCAOEJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly int CCHNIOKJDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly ISet<string> NFFAMNAAJKK;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x41A4700", Offset = "0x41A3900", VA = "0x1841A4700")]
	private static string DOKBNKJMCLB(TKey GHBNLDGJPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x41A4970", Offset = "0x41A3B70", VA = "0x1841A4970")]
	public PFGKCPMCLGL(string MLGNOFAPNAD = "F2", double NEBHMCENLMN = double.MaxValue, bool CPMKCAOEJPN = false, int CCHNIOKJDCH = int.MaxValue, [Optional] ISet<string> NFFAMNAAJKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x41A4650", Offset = "0x41A3850", VA = "0x1841A4650", Slot = "4")]
	public override Dictionary<string, string> CHEMDLCMAMB(FMDPIFHBCJG<TKey> LCCLFFMGBGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x41A4740", Offset = "0x41A3940", VA = "0x1841A4740")]
	private bool HOBMJKABJEA(string HHNKLGJGDNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x41A40A0", Offset = "0x41A32A0", VA = "0x1841A40A0")]
	public Dictionary<string, string> CHEMDLCMAMB(FMDPIFHBCJG<TKey> LCCLFFMGBGA, FJFACCLNHFL LCCKKENFDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x41A3E90", Offset = "0x41A3090", VA = "0x1841A3E90")]
	private string ADMEAPPJELJ(StringBuilder EBCDEFCFIMH, List<TKey> ICMPIGMAPIB, FJFACCLNHFL LCCKKENFDBE, bool EEBBOEFIBIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x41A4810", Offset = "0x41A3A10", VA = "0x1841A4810")]
	private static void JNHANBAOBOK(StringBuilder JMMOJNKPIGN, string OJEONKODMAB, bool MFPGKKCFLLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class JEKJDOCJFCP<TKey> : AGCEDDIOBLJ<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct HLGGGPOIPMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public BIEBJFLOKNL keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static JEKJDOCJFCP<TKey> EELHBDDPCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly string[] AODANMJMELB;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3BEFE40", Offset = "0x3BEF040", VA = "0x183BEFE40")]
	private JEKJDOCJFCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3BEEF00", Offset = "0x3BEE100", VA = "0x183BEEF00", Slot = "5")]
	protected override string MCFPPLOBEPH(FMDPIFHBCJG<TKey> LCCLFFMGBGA, BIEBJFLOKNL LCCKKENFDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3BEEE10", Offset = "0x3BEE010", VA = "0x183BEEE10")]
	[CompilerGenerated]
	internal static string EJIGBCNENNJ(string MAPFDCDHBBA, TKey GHBNLDGJPCB, HLGGGPOIPMJ P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class HOPOAFJKBKB : FMDPIFHBCJG<string>
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class CAPMGIECJMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Action<HOPOAFJKBKB, IOBNAOMELJK> callback;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public CAPMGIECJMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6104DC0", Offset = "0x6103FC0", VA = "0x186104DC0")]
		internal void LCCEGGPLIKB(FMDPIFHBCJG<string> timer, IOBNAOMELJK log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x61052D0", Offset = "0x61044D0", VA = "0x1861052D0")]
	public HOPOAFJKBKB(IOBNAOMELJK AOBMECMACLL, [Optional] string GCMNABGKEGP, [Optional] int? HBCLGFKLNFN, [Optional] Stopwatch HPBFPIBIPPO, [Optional] Action<string, BLPCMNDFPMH, IOBNAOMELJK> AANPCEDCNAD, [Optional] Action<string, BLPCMNDFPMH, IOBNAOMELJK> JKDIKCJIFFC, [Optional] Action<HOPOAFJKBKB, IOBNAOMELJK> PENCLAHNNEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6105210", Offset = "0x6104410", VA = "0x186105210")]
	private static Action<FMDPIFHBCJG<string>, IOBNAOMELJK> PNFBNMJNGML(Action<HOPOAFJKBKB, IOBNAOMELJK> CMMPHMKBCDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class PGNKBADIDBJ
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private class LDJAKEELFFM : PGNKBADIDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public static PGNKBADIDBJ EELHBDDPCDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x6106B20", Offset = "0x6105D20", VA = "0x186106B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override float JMLDAHHHDHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x1DCF110", Offset = "0x1DCE310", VA = "0x181DCF110", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6106C10", Offset = "0x6105E10", VA = "0x186106C10")]
		public LDJAKEELFFM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static PGNKBADIDBJ OMFEHLKGLJF;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static PGNKBADIDBJ LMPCLGLBJMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6107A30", Offset = "0x6106C30", VA = "0x186107A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public abstract float JMLDAHHHDHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	protected PGNKBADIDBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface FAENJJPEFPM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool OIOOJDHLJDP
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface DHELPBBEMKN<T> : FAENJJPEFPM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	[NotNull]
	Task<T> IPFGBMEGLDG
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	[NotNull]
	OCNPNNKFOAO<T> JHLOFJLPOOO
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class LPKCANGLCKN
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private sealed class GKMGGANFBDN<T> : KJFKPPGENKF<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override Task<T?> IPFGBMEGLDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override OCNPNNKFOAO<T?> JHLOFJLPOOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x7B40E0", Offset = "0x7B32E0", VA = "0x1807B40E0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x387AAD0", Offset = "0x3879CD0", VA = "0x18387AAD0")]
		public GKMGGANFBDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "10")]
		protected override void LGOFFAEBDEO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private sealed class DPKHFNMJNOJ<T> : KJFKPPGENKF<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override Task<T> IPFGBMEGLDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override OCNPNNKFOAO<T> JHLOFJLPOOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x7B40E0", Offset = "0x7B32E0", VA = "0x1807B40E0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x50B11F0", Offset = "0x50B03F0", VA = "0x1850B11F0")]
		public DPKHFNMJNOJ(Exception OGMFBLJMCMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "10")]
		protected override void LGOFFAEBDEO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private sealed class MIFICNLBJGM<T> : KJFKPPGENKF<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private struct LLMGBCOPLKF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public Task<DHELPBBEMKN<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			private TaskAwaiter<DHELPBBEMKN<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x3D640A0", Offset = "0x3D632A0", VA = "0x183D640A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x3D64560", Offset = "0x3D63760", VA = "0x183D64560", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private struct FNFCPNGDCDM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public Task<DHELPBBEMKN<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private TaskAwaiter<DHELPBBEMKN<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x37C2FA0", Offset = "0x37C21A0", VA = "0x1837C2FA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x37C3230", Offset = "0x37C2430", VA = "0x1837C3230", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly Task<DHELPBBEMKN<T>> OPBKKFEEFIE;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override Task<T> IPFGBMEGLDG
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x7B40E0", Offset = "0x7B32E0", VA = "0x1807B40E0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override OCNPNNKFOAO<T> JHLOFJLPOOO
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x7B4130", Offset = "0x7B3330", VA = "0x1807B4130", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x3F26980", Offset = "0x3F25B80", VA = "0x183F26980")]
		public MIFICNLBJGM(Task<DHELPBBEMKN<T>> PNJMCNKOIDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x3F267B0", Offset = "0x3F259B0", VA = "0x183F267B0", Slot = "10")]
		protected override void LGOFFAEBDEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x3F26830", Offset = "0x3F25A30", VA = "0x183F26830")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(MIFICNLBJGM<>.LLMGBCOPLKF))]
		internal static Task<T> PECHIFDOHHJ(Task<DHELPBBEMKN<T>> PNJMCNKOIDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x3F266D0", Offset = "0x3F258D0", VA = "0x183F266D0")]
		[AsyncStateMachine(typeof(MIFICNLBJGM<>.FNFCPNGDCDM))]
		[CompilerGenerated]
		internal static Task CEGBLJKIFAH(Task<DHELPBBEMKN<T>> PNJMCNKOIDP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x29268D0", Offset = "0x2925AD0", VA = "0x1829268D0")]
	public static DHELPBBEMKN<T> NONABGLHMDJ<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x26C4DD0", Offset = "0x26C3FD0", VA = "0x1826C4DD0")]
	public static DHELPBBEMKN<T> HFADKDCLHDL<T>(Exception OGMFBLJMCMJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x26C4DD0", Offset = "0x26C3FD0", VA = "0x1826C4DD0")]
	public static DHELPBBEMKN<T> NLKNFJBPNHB<T>(Task<DHELPBBEMKN<T>> PNJMCNKOIDP) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public abstract class KJFKPPGENKF<T> : DHELPBBEMKN<T>, FAENJJPEFPM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly string BJGNCJLLHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly IGCMLGNPGHK FNBDLMDDDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private bool FKFJMFIPHOO;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool OIOOJDHLJDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xA09C40", Offset = "0xA08E40", VA = "0x180A09C40", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public abstract Task<T> IPFGBMEGLDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public abstract OCNPNNKFOAO<T> JHLOFJLPOOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x3CBC470", Offset = "0x3CBB670", VA = "0x183CBC470")]
	public KJFKPPGENKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x3CBC120", Offset = "0x3CBB320", VA = "0x183CBC120", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void LGOFFAEBDEO();
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public abstract class LBMGNDIFOJK<TTask, T> : KJFKPPGENKF<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class OPHJBCAJKNA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public OPHJBCAJKNA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x321F570", Offset = "0x321E770", VA = "0x18321F570", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x321F830", Offset = "0x321EA30", VA = "0x18321F830", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public LBMGNDIFOJK<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public OPHJBCAJKNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x4110610", Offset = "0x410F810", VA = "0x184110610")]
		[AsyncStateMachine(typeof(LBMGNDIFOJK<, >.OPHJBCAJKNA.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> DGHIGIMBKIK(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly Task<T> PNJMCNKOIDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	protected readonly CancellationTokenSource NNJMHFBOJHC;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public override Task<T> IPFGBMEGLDG
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public override OCNPNNKFOAO<T> JHLOFJLPOOO
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7B40E0", Offset = "0x7B32E0", VA = "0x1807B40E0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3D53B20", Offset = "0x3D52D20", VA = "0x183D53B20")]
	protected LBMGNDIFOJK(TTask PNJMCNKOIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3D53AD0", Offset = "0x3D52CD0", VA = "0x183D53AD0", Slot = "10")]
	protected override void LGOFFAEBDEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T NDFPIBAFPEP(TTask NEGGBFINEKF);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void KIEMHKGFADM();
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class IIOAAOJPOPB<T> : KJFKPPGENKF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly MLDGFFPINMO<Task<T>> GFEJFCFFNCG;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public override Task<T> IPFGBMEGLDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x3879850", Offset = "0x3878A50", VA = "0x183879850", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public override OCNPNNKFOAO<T> JHLOFJLPOOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7B40E0", Offset = "0x7B32E0", VA = "0x1807B40E0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3A46CB0", Offset = "0x3A45EB0", VA = "0x183A46CB0")]
	public IIOAAOJPOPB(MLDGFFPINMO<Task<T>> PNPOLJAJIDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x3A46C90", Offset = "0x3A45E90", VA = "0x183A46C90", Slot = "10")]
	protected override void LGOFFAEBDEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class BDINPGOBGPE
{
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6104820", Offset = "0x6103A20", VA = "0x186104820")]
	[NotNull]
	public static byte[] FNBFCIBBJJC(this HPKNOMGBJGL NPNBBFHLJNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6104890", Offset = "0x6103A90", VA = "0x186104890")]
	[NotNull]
	public static byte[] FNBFCIBBJJC(this HPKNOMGBJGL NPNBBFHLJNH, HashAlgorithmName POIMEBLPGPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6104900", Offset = "0x6103B00", VA = "0x186104900")]
	public static bool GBPLJHKEHJL([CanBeNull] this HPKNOMGBJGL NPNBBFHLJNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6104A90", Offset = "0x6103C90", VA = "0x186104A90")]
	public static bool GBPLJHKEHJL([CanBeNull] this HPKNOMGBJGL NPNBBFHLJNH, [Out] string AABEEDLKHEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6104C30", Offset = "0x6103E30", VA = "0x186104C30")]
	private static bool MECMBFACANA([NotNull] HPKNOMGBJGL NPNBBFHLJNH, [Out][CanBeNull] byte[] NFLKKBPIEEH, [Out][CanBeNull] byte[] LLCCHKCCFPL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class KCACGHEGJGA
{
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x61063E0", Offset = "0x61055E0", VA = "0x1861063E0")]
	[NotNull]
	public static byte[] FNBFCIBBJJC(this OEDGKHMLBEJ DJOADILJCBL, HashAlgorithmName POIMEBLPGPJ, byte[] GHGGEEPLFPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface OEDGKHMLBEJ
{
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash BKPDJAAHMDI);
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface HPKNOMGBJGL : OEDGKHMLBEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	[CanBeNull]
	byte[] AAAINCALGAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	[CanBeNull]
	byte[] IEFLMIPCEEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class OOFNLKIBCIM
{
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static readonly ArrayPool<byte> NJELNIGFDEK;

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static bool CKJDBOIIINO;

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2A09CB0", Offset = "0x2A08EB0", VA = "0x182A09CB0")]
	public static void GMIACCFDOLB<T>(this IncrementalHash JAIOKFIMFIC, [CanBeNull] T KECFIHOGMCI) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x2A09D70", Offset = "0x2A08F70", VA = "0x182A09D70")]
	public static void HMCEDGLCEAE<T>(this IncrementalHash JAIOKFIMFIC, [CanBeNull] T DJOADILJCBL) where T : OEDGKHMLBEJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2A09E00", Offset = "0x2A09000", VA = "0x182A09E00")]
	public static void KKOCNILEJCE<T>(this IncrementalHash JAIOKFIMFIC, [CanBeNull] IList<T> GIKEKMHELAG) where T : OEDGKHMLBEJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6107440", Offset = "0x6106640", VA = "0x186107440")]
	private static bool LBMJBOENGPD([CanBeNull] OEDGKHMLBEJ DJOADILJCBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6106DA0", Offset = "0x6105FA0", VA = "0x186106DA0")]
	public static void ECIEDJPJBGD(this IncrementalHash BKPDJAAHMDI, [CanBeNull] string CPPJBOMFOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x61070E0", Offset = "0x61062E0", VA = "0x1861070E0")]
	public static void JOIPJIEFALN(this IncrementalHash BKPDJAAHMDI, long LCPMMFCNHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6107700", Offset = "0x6106900", VA = "0x186107700")]
	public static void PHIPBOPLHLG(this IncrementalHash BKPDJAAHMDI, int IKEMIJKBLEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6107530", Offset = "0x6106730", VA = "0x186107530")]
	public static void OJMFHENCKJO(this IncrementalHash BKPDJAAHMDI, short MMDHHONEGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6106E00", Offset = "0x6106000", VA = "0x186106E00")]
	public static void HNOBHGEBKJO(this IncrementalHash BKPDJAAHMDI, byte NIDHJOBJCGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6106F10", Offset = "0x6106110", VA = "0x186106F10")]
	public static void IBCMDCDEPIH(this IncrementalHash BKPDJAAHMDI, bool HFJBFDMOAPL, bool ODBBJLHLELH = false, bool NBFGJEOBFFB = false, bool JAJOEAHMBIF = false, bool ELGHLJFJPJI = false, bool LCLLAPCPGBE = false, bool GEEGIIKGBMA = false, bool OGHPOEGMIIK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x2A0A320", Offset = "0x2A09520", VA = "0x182A0A320")]
	public static void OGKOEECNEFG<T>(this IncrementalHash BKPDJAAHMDI, T CDEGJDLAKFC) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6107080", Offset = "0x6106280", VA = "0x186107080")]
	public static void IHGANBDKPCF(this IncrementalHash BKPDJAAHMDI, float OJBMAOAILEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x61078D0", Offset = "0x6106AD0", VA = "0x1861078D0")]
	public static void PONPDPBOLDF(this IncrementalHash BKPDJAAHMDI, ulong HJNLFEPBKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x61072B0", Offset = "0x61064B0", VA = "0x1861072B0")]
	public static void KGFCCPOBOAI(this IncrementalHash BKPDJAAHMDI, uint HEGBGCLMIHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x61074D0", Offset = "0x61066D0", VA = "0x1861074D0")]
	public static void OFMHDMJEJJC(this IncrementalHash BKPDJAAHMDI, ushort OAFCHFPNNNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6107310", Offset = "0x6106510", VA = "0x186107310")]
	public static void KPNMHOAIFOO(this IncrementalHash BKPDJAAHMDI, Vector3 LBNGEBELEAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class IBHMIFKIPFF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6105420", Offset = "0x6104620", VA = "0x186105420")]
	public IBHMIFKIPFF(string FFDOAJJEAOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class AKBMFNFMPGC<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	internal class PNJMLDLPJED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public TNode AOFIGDLFNLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public TNode DLAKBCKOLFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public GDABFJENGME PDJKKMEADLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public List<GDABFJENGME> OAHHKBIFMBN;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public PNJMLDLPJED()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal struct GDABFJENGME : IComparable<GDABFJENGME>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int CJCOBDOEDHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public TClaimant AOEDGAOBIEO;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xC29F90", Offset = "0xC29190", VA = "0x180C29F90")]
		public GDABFJENGME(int CJCOBDOEDHO, TClaimant AOEDGAOBIEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3858870", Offset = "0x3857A70", VA = "0x183858870")]
		public bool PLNMOKNOJMO([In] GDABFJENGME MEJMHKPOODP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3858860", Offset = "0x3857A60", VA = "0x183858860")]
		public bool INEGALGPAJC([In] GDABFJENGME MEJMHKPOODP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3858850", Offset = "0x3857A50", VA = "0x183858850", Slot = "4")]
		public int CompareTo(GDABFJENGME MEJMHKPOODP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x38588D0", Offset = "0x3857AD0", VA = "0x1838588D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public enum NBLGHIKDKIA
	{
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class MBHCDOENGJC : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public AKBMFNFMPGC<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x80AF90", Offset = "0x80A190", VA = "0x18080AF90")]
		[DebuggerHidden]
		public MBHCDOENGJC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3F077C0", Offset = "0x3F069C0", VA = "0x183F077C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3F07980", Offset = "0x3F06B80", VA = "0x183F07980", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3F078A0", Offset = "0x3F06AA0", VA = "0x183F078A0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3786170", Offset = "0x3785370", VA = "0x183786170", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly HBOIKJHBDPP<PNJMLDLPJED> KNLAFNDDFEB;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly HBOIKJHBDPP<List<GDABFJENGME>> DIBJLKAFDLI;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static int OLNKPBMJOMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	internal readonly Dictionary<TClaimant, TNode> BAJFEBOPMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	internal readonly Dictionary<TNode, PNJMLDLPJED> EKKGGDAOFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private NBLGHIKDKIA PAIKDKBMDIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private bool KABNGLCHEKD;

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode OPAHCEDNAIB(TNode JCCACJKHFKB);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void HLKIBEEHJBP(TNode JCCACJKHFKB, TClaimant LFNKNPIHAFD, TClaimant OOMGIMEAAOH);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x38B2500", Offset = "0x38B1700", VA = "0x1838B2500")]
	public AKBMFNFMPGC(NBLGHIKDKIA PAIKDKBMDIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x38B1880", Offset = "0x38B0A80", VA = "0x1838B1880")]
	public void MDLCGGDDELD(TNode JCCACJKHFKB, TNode EBKJLIBKJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x38B1510", Offset = "0x38B0710", VA = "0x1838B1510")]
	public void GEFANOFAEMN(TClaimant AOEDGAOBIEO, TNode MDELCNEJIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x38B11E0", Offset = "0x38B03E0", VA = "0x1838B11E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x38B1700", Offset = "0x38B0900", VA = "0x1838B1700")]
	private void IHOIDEJLDFF(TClaimant AOEDGAOBIEO, TNode AIECCOJMOIF, TNode MDELCNEJIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x38B1380", Offset = "0x38B0580", VA = "0x1838B1380")]
	private int FADGGJEGDAN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x38B2040", Offset = "0x38B1240", VA = "0x1838B2040")]
	private void PPLMCMAMDEH(TClaimant AOEDGAOBIEO, TNode JFCIMLNIKMG, TNode DOCGKJJCLDL, int GHBPLLNECLF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x38B1050", Offset = "0x38B0250", VA = "0x1838B1050")]
	private void BEEHINLOBIB(GDABFJENGME BPCKNKLMHMP, PNJMLDLPJED AFEJHPJDDFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x38B1D80", Offset = "0x38B0F80", VA = "0x1838B1D80")]
	private void PCJDJJJANNM(TClaimant AOEDGAOBIEO, TNode JFCIMLNIKMG, TNode DOCGKJJCLDL, int GHBPLLNECLF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x38B10D0", Offset = "0x38B02D0", VA = "0x1838B10D0")]
	private void DLAEMBJCGPJ(GDABFJENGME BPCKNKLMHMP, TNode JCCACJKHFKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x38B0E10", Offset = "0x38B0010", VA = "0x1838B0E10")]
	private void AJBKAPKLKNK(GDABFJENGME BPCKNKLMHMP, PNJMLDLPJED AFEJHPJDDFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x38B13F0", Offset = "0x38B05F0", VA = "0x1838B13F0")]
	private void FLKKGMDPBOB(PNJMLDLPJED AFEJHPJDDFE, bool HGBMPBCBPBA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x38B1910", Offset = "0x38B0B10", VA = "0x1838B1910")]
	private void NEKKGKEGNDE(PNJMLDLPJED AFEJHPJDDFE, TNode EBKJLIBKJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x38B1630", Offset = "0x38B0830", VA = "0x1838B1630")]
	[IteratorStateMachine(typeof(AKBMFNFMPGC<, >.MBHCDOENGJC))]
	private IEnumerable<TNode> HLAOGCLKCLP(TNode JFCIMLNIKMG, TNode DOCGKJJCLDL, bool NGGPMKCBFNO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x38B17A0", Offset = "0x38B09A0", VA = "0x1838B17A0")]
	private PNJMLDLPJED JKIEPHHANIA(TNode JCCACJKHFKB, TNode DLAKBCKOLFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x38B1C30", Offset = "0x38B0E30", VA = "0x1838B1C30")]
	private PNJMLDLPJED OIGOCPKOKOC(TNode JCCACJKHFKB, TNode DLAKBCKOLFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x38B0EF0", Offset = "0x38B00F0", VA = "0x1838B0EF0")]
	private void ANDOCEIMHOF(PNJMLDLPJED AFEJHPJDDFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class GMCGKADNICE<T> : IEnumerable<GMCGKADNICE<T>.MJLNEKFNPAH>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct MJLNEKFNPAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public T EKDDCPALANJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int MBGANDEDPDN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public class HAEEALIJOJH : IEnumerator<MJLNEKFNPAH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private GMCGKADNICE<T> KJCPAPDPNDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private int MBGANDEDPDN;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x343D2E0", Offset = "0x343C4E0", VA = "0x18343D2E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public MJLNEKFNPAH KOOHOOFHLKE
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x38E1300", Offset = "0x38E0500", VA = "0x1838E1300", Slot = "4")]
			get
			{
				return default(MJLNEKFNPAH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x38E1210", Offset = "0x38E0410", VA = "0x1838E1210")]
		public HAEEALIJOJH(GMCGKADNICE<T> KJCPAPDPNDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x38E1190", Offset = "0x38E0390", VA = "0x1838E1190", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3490130", Offset = "0x348F330", VA = "0x183490130", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x86E6E0", Offset = "0x86D8E0", VA = "0x18086E6E0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private struct AOLDECKOBEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public bool PNMKLGKNKFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public T EKDDCPALANJ;
	}

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private const int PAKALMCDALL = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly Dictionary<T, int> EOKNDNMHPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private AOLDECKOBEE[] HGMLKBHMGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private int GNOFHDHKIKL;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int DGIHMCOEFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7F41B0", Offset = "0x7F33B0", VA = "0x1807F41B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x7F3FE0", Offset = "0x7F31E0", VA = "0x1807F3FE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int GIHIJMKOGEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x322EEE0", Offset = "0x322E0E0", VA = "0x18322EEE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x388AEF0", Offset = "0x388A0F0", VA = "0x18388AEF0")]
	public GMCGKADNICE(int ONEEJBCNCKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x388AB40", Offset = "0x3889D40", VA = "0x18388AB40")]
	public GMCGKADNICE(MJLNEKFNPAH[] AHAGGAKLODN, bool IEKADICPJEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x3889F70", Offset = "0x3889170", VA = "0x183889F70")]
	public int DGOHMODCJGP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x388A160", Offset = "0x3889360", VA = "0x18388A160")]
	private int MKNNABJNILI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x388AAA0", Offset = "0x3889CA0", VA = "0x18388AAA0", Slot = "6")]
	protected virtual uint PLOHKOCJHPB(uint BKPDJAAHMDI, T EKDDCPALANJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x388A540", Offset = "0x3889740", VA = "0x18388A540")]
	public bool NDKNFMGOBDF(T EKDDCPALANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x388A050", Offset = "0x3889250", VA = "0x18388A050")]
	public int HBDKKJFOMOL(T EKDDCPALANJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x3889EB0", Offset = "0x38890B0", VA = "0x183889EB0")]
	public T DEFCJDJADPC(int MBGANDEDPDN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x388A820", Offset = "0x3889A20", VA = "0x18388A820")]
	public bool PLJNONPJNEA(T EKDDCPALANJ, bool BCAHBFGGOKC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x388A870", Offset = "0x3889A70", VA = "0x18388A870")]
	public bool PLJNONPJNEA(T EKDDCPALANJ, int MBGANDEDPDN, bool BCAHBFGGOKC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x388A110", Offset = "0x3889310", VA = "0x18388A110")]
	private int HIAFEKLBJOD(int BHOMKDDOKFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x388AAC0", Offset = "0x3889CC0", VA = "0x18388AAC0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x388AAC0", Offset = "0x3889CC0", VA = "0x18388AAC0", Slot = "4")]
	private IEnumerator<MJLNEKFNPAH> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class HBOIKJHBDPP<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly Stack<T> PCPOGAIKLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly List<T> BAEEDICDPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly int EJFMDEPDBDL;

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x393FB30", Offset = "0x393ED30", VA = "0x18393FB30")]
	public static HBOIKJHBDPP<T> OEMGBONHHHO(int ONEEJBCNCKG = 0, int EJFMDEPDBDL = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x393FA50", Offset = "0x393EC50", VA = "0x18393FA50")]
	public static HBOIKJHBDPP<T> NDJFFKFPGDD(int ONEEJBCNCKG = 0, int EJFMDEPDBDL = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x393FDA0", Offset = "0x393EFA0", VA = "0x18393FDA0")]
	public HBOIKJHBDPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x393FC10", Offset = "0x393EE10", VA = "0x18393FC10")]
	public HBOIKJHBDPP(int ONEEJBCNCKG, int EJFMDEPDBDL = int.MaxValue, bool OAFGFGAEIEI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x393F540", Offset = "0x393E740", VA = "0x18393F540")]
	public T HBHJOJPNNIN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x393F6C0", Offset = "0x393E8C0", VA = "0x18393F6C0")]
	public void JKJINJEHPOI(T EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x393F790", Offset = "0x393E990", VA = "0x18393F790")]
	private void MHEGCMBDMAC(T EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x393F6A0", Offset = "0x393E8A0", VA = "0x18393F6A0")]
	private void HJCPCPNAFOG(T EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x393F410", Offset = "0x393E610", VA = "0x18393F410", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x393F860", Offset = "0x393EA60", VA = "0x18393F860")]
	private void MONFFEJPBJP(IEnumerable<T> DBIFCPFENHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class GAMKFAPIDAD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private Dictionary<int, T> DMIBENMKHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private T ICIBDFKGIBD;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual T GJCFIHNHJCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7B40F0", Offset = "0x7B32F0", VA = "0x1807B40F0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x384E520", Offset = "0x384D720", VA = "0x18384E520")]
	public bool JIKFOBMFIPM(T EKDDCPALANJ, int CJCOBDOEDHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x384E4C0", Offset = "0x384D6C0", VA = "0x18384E4C0")]
	public bool FPDJGBKEMHG(int CJCOBDOEDHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x384E120", Offset = "0x384D320", VA = "0x18384E120")]
	public T BJBOGNAECGP(int AGNIBLHLOGP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x384E090", Offset = "0x384D290", VA = "0x18384E090")]
	private bool AOBDIMNJBGO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x384E600", Offset = "0x384D800", VA = "0x18384E600")]
	public bool JNNFGFKBPPN(int CJCOBDOEDHO, [Out] T EKDDCPALANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x384E640", Offset = "0x384D840", VA = "0x18384E640")]
	public GAMKFAPIDAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class CENAMBCGKPC<T>
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	protected struct JBDNJBHNAAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public T LJLHDNLHLNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public int MNJPBCOPING;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	protected readonly List<JBDNJBHNAAH> HHOIGACGJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private T NLFFEDACBII;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int GIHIJMKOGEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x322EEE0", Offset = "0x322E0E0", VA = "0x18322EEE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x4A14250", Offset = "0x4A13450", VA = "0x184A14250")]
	public bool FFANKOOFEPM(T EKDDCPALANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x4A143C0", Offset = "0x4A135C0", VA = "0x184A143C0")]
	public void GHBEENLPKLN(T EKDDCPALANJ, int CJCOBDOEDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x4A14120", Offset = "0x4A13320", VA = "0x184A14120")]
	public bool FBCLMIGJMFH(T EKDDCPALANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x4A13F60", Offset = "0x4A13160", VA = "0x184A13F60")]
	public void DBHKOJLPIHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x4A14460", Offset = "0x4A13660", VA = "0x184A14460")]
	public T LNDPPKDNBOC()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x4A13FC0", Offset = "0x4A131C0", VA = "0x184A13FC0")]
	private void DKONFDODJJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x4A144E0", Offset = "0x4A136E0", VA = "0x184A144E0")]
	public CENAMBCGKPC()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[SerializeField]
		[PCEENEOFAOO(DGCAKKBAIEP.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x6107CC0", Offset = "0x6106EC0", VA = "0x186107CC0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x6107F90", Offset = "0x6107190", VA = "0x186107F90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x6107EA0", Offset = "0x61070A0", VA = "0x186107EA0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x6107C10", Offset = "0x6106E10", VA = "0x186107C10")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x6107EE0", Offset = "0x61070E0", VA = "0x186107EE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x6107DF0", Offset = "0x6106FF0", VA = "0x186107DF0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x6107B90", Offset = "0x6106D90", VA = "0x186107B90")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x4354540", Offset = "0x4353740", VA = "0x184354540", Slot = "4")]
		public virtual T KKJPMPBPAEE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class JIPJJACHFCN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly Dictionary<byte, LCDMEOHMMEB> DEJMFJJICON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly HBOIKJHBDPP<LCDMEOHMMEB> BIIAMLKHHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly bool OEFGEIFKLMJ;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public LCDMEOHMMEB HGNCDGPCPPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7B4120", Offset = "0x7B3320", VA = "0x1807B4120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public Vector2 FIHPPMAHKCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xBAE020", Offset = "0xBAD220", VA = "0x180BAE020")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xE9A060", Offset = "0xE99260", VA = "0x180E9A060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private Vector2 EDBFCPCKNHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xEC9920", Offset = "0xEC8B20", VA = "0x180EC9920")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public Vector2 OPMKEBNBEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6105F30", Offset = "0x6105130", VA = "0x186105F30")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7B77D0", Offset = "0x7B69D0", VA = "0x1807B77D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public int BCHDNICAMMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7BF2B0", Offset = "0x7BE4B0", VA = "0x1807BF2B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7BF620", Offset = "0x7BE820", VA = "0x1807BF620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6105F50", Offset = "0x6105150", VA = "0x186105F50")]
	public JIPJJACHFCN(Bounds NPFNKJBACHJ, Vector2[] JIJEGODKCIG, int DLPOLNCJBKE, byte BHOMKDDOKFH, float LMIHLCBMAHE = 0f, [Optional] HBOIKJHBDPP<LCDMEOHMMEB> BIIAMLKHHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6105900", Offset = "0x6104B00", VA = "0x186105900")]
	public LCDMEOHMMEB KDGEPLPDIKH(byte MBGANDEDPDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6105830", Offset = "0x6104A30", VA = "0x186105830")]
	public void KANDLHHKNLN(Vector3 JCMPCLFLJHD, float GNJOBODOEHD, float OBNMDKKFGID, List<byte> LLBHLKFKCBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5891700", Offset = "0x5890900", VA = "0x185891700")]
	public void FLHHBCOKONC(LCDMEOHMMEB.NCGKOPNDJAO FKJJHDAAOBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6105680", Offset = "0x6104880", VA = "0x186105680")]
	public static int DELIFBOHFJL(Vector2[] JIJEGODKCIG, int DLPOLNCJBKE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6105480", Offset = "0x6104680", VA = "0x186105480")]
	private LCDMEOHMMEB DCEIIKGGOHM(byte MBGANDEDPDN, LCDMEOHMMEB.OBEMGHMIFHN GBMBHIGGEGI, LCDMEOHMMEB DLAKBCKOLFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6105960", Offset = "0x6104B60", VA = "0x186105960")]
	private void LINMLIODHJL(LCDMEOHMMEB DLAKBCKOLFN, Vector2[] JIJEGODKCIG, int CMEMMLLOCOG, int AGFHFGIEHNG, int PMHJLDFDMHB, int CMOOKMDAMLI, float LMIHLCBMAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x6105D10", Offset = "0x6104F10", VA = "0x186105D10")]
	private void MLLEBHENKFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x6105770", Offset = "0x6104970", VA = "0x186105770", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x61057D0", Offset = "0x61049D0", VA = "0x1861057D0", Slot = "1")]
	~JIPJJACHFCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class LCDMEOHMMEB
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public enum OBEMGHMIFHN
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public enum NCGKOPNDJAO
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public byte PAIBFKFLOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public Vector3 GDCJHLILNON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public Vector3 ODOBGAEOPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public Vector3 CABGFABINAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public Vector3 PLPCBALFFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public OBEMGHMIFHN APNHIHNODPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public LCDMEOHMMEB IIBNAPJLELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public List<LCDMEOHMMEB> GDHDHGEDJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public bool OMBDOMDJMNP;

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x6106B00", Offset = "0x6105D00", VA = "0x186106B00")]
	public LCDMEOHMMEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x61066F0", Offset = "0x61058F0", VA = "0x1861066F0")]
	public void JJAHBJFPKEC(LCDMEOHMMEB MMGOAMJJJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620")]
	public void FLHHBCOKONC(int OHLGEPFPBED, NCGKOPNDJAO FKJJHDAAOBL, int NNFJCCCGKCE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6106810", Offset = "0x6105A10", VA = "0x186106810")]
	public void KANDLHHKNLN(List<byte> LLBHLKFKCBF, Vector3 JCMPCLFLJHD, float GNJOBODOEHD, float OBNMDKKFGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6106690", Offset = "0x6105890", VA = "0x186106690")]
	public bool EBKOFDEPBFK(Vector3 EBFLKLNOENC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x61066C0", Offset = "0x61058C0", VA = "0x1861066C0")]
	public bool GCDFCJLCOIH(Vector3 EBFLKLNOENC, float GIHJLBHHCJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6106A70", Offset = "0x6105C70", VA = "0x186106A70")]
	public void MEJEOBIHPJE()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		public struct GNJDCKGMHJL<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			private readonly List<Component> LBDHFFKKBHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			private readonly bool IDAEAGLAPHD;

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x3890760", Offset = "0x388F960", VA = "0x183890760")]
			public GNJDCKGMHJL(List<Component> LBDHFFKKBHH, bool IDAEAGLAPHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x3890630", Offset = "0x388F830", VA = "0x183890630")]
			public EAELMACGNCB<T> LEPKJMNOIOO()
			{
				return default(EAELMACGNCB<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x3890690", Offset = "0x388F890", VA = "0x183890690", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x3890690", Offset = "0x388F890", VA = "0x183890690", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		public struct EAELMACGNCB<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			private readonly List<Component> LBDHFFKKBHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			private readonly bool IDAEAGLAPHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			private int MBGANDEDPDN;

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			public T KOOHOOFHLKE
			{
				[Cpp2IlInjected.Token(Token = "0x60001F8")]
				[Cpp2IlInjected.Address(RVA = "0x33FE2E0", Offset = "0x33FD4E0", VA = "0x1833FE2E0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001F9")]
				[Cpp2IlInjected.Address(RVA = "0x33FE270", Offset = "0x33FD470", VA = "0x1833FE270", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x33FE2B0", Offset = "0x33FD4B0", VA = "0x1833FE2B0")]
			public EAELMACGNCB(List<Component> LBDHFFKKBHH, bool IDAEAGLAPHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x33FE1A0", Offset = "0x33FD3A0", VA = "0x1833FE1A0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x33FE1B0", Offset = "0x33FD3B0", VA = "0x1833FE1B0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x33FE260", Offset = "0x33FD460", VA = "0x1833FE260", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x61098D0", Offset = "0x6108AD0", VA = "0x1861098D0")]
		private void MEJEOBIHPJE(GameObject LPJEIMNEFOH, bool HLOIBGCELIK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x6109710", Offset = "0x6108910", VA = "0x186109710")]
		public static void MEJEOBIHPJE(GameObject LPJEIMNEFOH, ToolHierarchyCache KFPKKDDFIOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x2B4CE60", Offset = "0x2B4C060", VA = "0x182B4CE60")]
		public void NFBLJFDGEJC<T>(Action<T> OFOIHENMFDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x2B4CDF0", Offset = "0x2B4BFF0", VA = "0x182B4CDF0")]
		public T JDNMCOCLHFM<T>(bool IDAEAGLAPHD = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x2B4CD30", Offset = "0x2B4BF30", VA = "0x182B4CD30")]
		public GNJDCKGMHJL<T> GIKLHGCEPOF<T>(bool IDAEAGLAPHD = false) where T : class
		{
			return default(GNJDCKGMHJL<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x61092D0", Offset = "0x61084D0", VA = "0x1861092D0")]
		public List<Component> BAKKJAIJCJN(Type MJMAEGDPBNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x6109620", Offset = "0x6108820", VA = "0x186109620", Slot = "4")]
		public bool Equals(ToolHierarchyCache EFCGILCAOIA, ToolHierarchyCache DDIIOJEJOLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x61096A0", Offset = "0x61088A0", VA = "0x1861096A0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache GLMGCMELGFD)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class GJMIGEOBKNL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private int ONEEJBCNCKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private int FGOLBBBLMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private List<T> JNKAEOBAPMA;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int GIHIJMKOGEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3879850", Offset = "0x3878A50", VA = "0x183879850")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public T CECLBNHPHAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3879C30", Offset = "0x3878E30", VA = "0x183879C30")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public T MONBCHCBDCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x3879740", Offset = "0x3878940", VA = "0x183879740")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public T MFJAHOKNPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3879B00", Offset = "0x3878D00", VA = "0x183879B00")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x3879D80", Offset = "0x3878F80", VA = "0x183879D80")]
	public GJMIGEOBKNL(int ONEEJBCNCKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x3879890", Offset = "0x3878A90", VA = "0x183879890")]
	public void GHBEENLPKLN(T FCODEMMIGPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x3879800", Offset = "0x3878A00", VA = "0x183879800")]
	public void DBHKOJLPIHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x3879B70", Offset = "0x3878D70", VA = "0x183879B70")]
	public void OEOFGKPDBDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x3879A60", Offset = "0x3878C60", VA = "0x183879A60")]
	public void HILKKDAPKEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x3879840", Offset = "0x3878A40", VA = "0x183879840")]
	public void FKIMOLKFDIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class PHJHNNIPFDE<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private struct BGEHGBGBNDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public int MNJPBCOPING;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public T LJLHDNLHLNB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly Dictionary<object, BGEHGBGBNDF> DMIBENMKHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly EqualityComparer<T> ADDAEMIBMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private T ICIBDFKGIBD;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public virtual T GJCFIHNHJCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x1064390", Offset = "0x1063590", VA = "0x181064390", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x41AEFE0", Offset = "0x41AE1E0", VA = "0x1841AEFE0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool HKKPLCHHKIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x41AF000", Offset = "0x41AE200", VA = "0x1841AF000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public object JDGPLCJNMMD
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x7B4100", Offset = "0x7B3300", VA = "0x1807B4100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x41AEDA0", Offset = "0x41ADFA0", VA = "0x1841AEDA0")]
	public bool JIKFOBMFIPM(T EKDDCPALANJ, object GMMJMENGHCD, int CJCOBDOEDHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x41AED20", Offset = "0x41ADF20", VA = "0x1841AED20")]
	public bool FPDJGBKEMHG(object GMMJMENGHCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x41AEF60", Offset = "0x41AE160", VA = "0x1841AEF60")]
	public bool JNNFGFKBPPN(object GMMJMENGHCD, [Out] T EKDDCPALANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x41AECF0", Offset = "0x41ADEF0", VA = "0x1841AECF0")]
	public void DBHKOJLPIHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x41AE790", Offset = "0x41AD990", VA = "0x1841AE790")]
	private bool AOBDIMNJBGO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x41AF040", Offset = "0x41AE240", VA = "0x1841AF040")]
	public PHJHNNIPFDE()
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
