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
using RecRoom.Attributes;
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
		[Cpp2IlInjected.Address(RVA = "0x7EC840", Offset = "0x7EB240", VA = "0x1807EC840")]
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
		[Cpp2IlInjected.Address(RVA = "0x6310110", Offset = "0x630EB10", VA = "0x186310110")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7ED890", Offset = "0x7EC290", VA = "0x1807ED890")]
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
		[Cpp2IlInjected.Address(RVA = "0x7ED8D0", Offset = "0x7EC2D0", VA = "0x1807ED8D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class JGDGCNDKLAN : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x137BD10", Offset = "0x137A710", VA = "0x18137BD10")]
	public JGDGCNDKLAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, LPKBIPDLCCA, MFENFNEOGBG, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7C4AA0", Offset = "0x7C34A0", VA = "0x1807C4AA0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7C5500", Offset = "0x7C3F00", VA = "0x1807C5500", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7C4AB0", Offset = "0x7C34B0", VA = "0x1807C4AB0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x830920", Offset = "0x82F320", VA = "0x180830920", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash NKHBKFIGNJB);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8AAA60", Offset = "0x8A9460", VA = "0x1808AAA60")]
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
	[ReadOnlyField]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[ReadOnlyField]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6311640", Offset = "0x6310040", VA = "0x186311640")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6311600", Offset = "0x6310000", VA = "0x186311600")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6311680", Offset = "0x6310080", VA = "0x186311680")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6311830", Offset = "0x6310230", VA = "0x186311830")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x63117A0", Offset = "0x63101A0", VA = "0x1863117A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x956600", Offset = "0x955000", VA = "0x180956600")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA141A0", Offset = "0xA12BA0", VA = "0x180A141A0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x63115C0", Offset = "0x630FFC0", VA = "0x1863115C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6311710", Offset = "0x6310110", VA = "0x186311710")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6311030", Offset = "0x630FA30", VA = "0x186311030")]
	public void CopyBounds(SavedExtents HKMMPHJFKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6311510", Offset = "0x630FF10", VA = "0x186311510")]
	public void SetLocalSpaceBounds(Bounds HGLKDEKBOHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xA43E30", Offset = "0xA42830", VA = "0x180A43E30")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6311440", Offset = "0x630FE40", VA = "0x186311440")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6311060", Offset = "0x630FA60", VA = "0x186311060")]
	private void DDIMOOFKIME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6311220", Offset = "0x630FC20", VA = "0x186311220")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x63109C0", Offset = "0x630F3C0", VA = "0x1863109C0")]
	public static void CalculateLocalBoundsFor(GameObject PACDKKMGCFJ, [Out] Bounds HGLKDEKBOHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6311450", Offset = "0x630FE50", VA = "0x186311450")]
	private static void PJCJNICBPPI(Bounds AMHFHPBEBNM, Color KMFGKGNHDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6311530", Offset = "0x630FF30", VA = "0x186311530")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C2110", Offset = "0x7C0B10", VA = "0x1807C2110")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7C8780", Offset = "0x7C7180", VA = "0x1807C8780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xE93C40", Offset = "0xE92640", VA = "0x180E93C40")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x44DDA60", Offset = "0x44DC460", VA = "0x1844DDA60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "4")]
	public virtual void JNCCCCMOHNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
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
	[JGDGCNDKLAN]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x44DD690", Offset = "0x44DC090", VA = "0x1844DD690", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x44DC140", Offset = "0x44DAB40", VA = "0x1844DC140", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x44DD9A0", Offset = "0x44DC3A0", VA = "0x1844DD9A0")]
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
	private sealed class EMJOMBOGADN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public EMJOMBOGADN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x351C460", Offset = "0x351AE60", VA = "0x18351C460")]
		internal int KALGJPIHCEC(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[JGDGCNDKLAN]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x35325B0", Offset = "0x3530FB0", VA = "0x1835325B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x35325F0", Offset = "0x3530FF0", VA = "0x1835325F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x35324D0", Offset = "0x3530ED0", VA = "0x1835324D0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey KLDFLAABJKH]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3532550", Offset = "0x3530F50", VA = "0x183532550", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x35323D0", Offset = "0x3530DD0", VA = "0x1835323D0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3532120", Offset = "0x3530B20", VA = "0x183532120", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3531660", Offset = "0x3530060", VA = "0x183531660", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3531630", Offset = "0x3530030", VA = "0x183531630", Slot = "14")]
	protected virtual string ODMCFJBAFCA(TKeyVal LOGHPKNKBHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x35314F0", Offset = "0x352FEF0", VA = "0x1835314F0", Slot = "4")]
	public bool ContainsKey(TKey KLDFLAABJKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x35322A0", Offset = "0x3530CA0", VA = "0x1835322A0", Slot = "5")]
	public bool TryGetValue(TKey KLDFLAABJKH, [Out] TVal AEJBOLFACJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3531530", Offset = "0x352FF30", VA = "0x183531530", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3531530", Offset = "0x352FF30", VA = "0x183531530", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x35322E0", Offset = "0x3530CE0", VA = "0x1835322E0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class GHOFGGHJCEI<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class NCEGFGCIMAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public float IOJOMHLMLPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public T DPMGLPAKGNP;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public NCEGFGCIMAM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class GGNEGELNOFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public GGNEGELNOFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3981F60", Offset = "0x3980960", VA = "0x183981F60")]
		internal bool FDFAOAJJCMM(NCEGFGCIMAM sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly float JHFGMKAAKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly float IAHACBLALHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<NCEGFGCIMAM> JMIDPHADHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private PEIMMEBIMLB<NCEGFGCIMAM> KPFIEILMJEL;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int HECIJHOCIKC
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3988F70", Offset = "0x3987970", VA = "0x183988F70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3989AA0", Offset = "0x39884A0", VA = "0x183989AA0")]
	public GHOFGGHJCEI(float IGEPOFODMBM, float CEHPMHEJHMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3989050", Offset = "0x3987A50", VA = "0x183989050")]
	public bool FFDAABKODFM(float PAJOJJHFNPD, T AEJBOLFACJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3989610", Offset = "0x3988010", VA = "0x183989610")]
	public IEnumerable<T> FJPGOIDIHDK(float PAJOJJHFNPD, [Optional] float? ILHEOCLMAKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3989A40", Offset = "0x3988440", VA = "0x183989A40")]
	public void LDCFGOINEDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3989900", Offset = "0x3988300", VA = "0x183989900")]
	private void JPGJJKKHGEM(float PAJOJJHFNPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class PPKMANDHHOC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct LFALOEPBFDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public T DPMGLPAKGNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public float KJBNJJNAOKB;
	}

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static float OFHLJBDLKNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private List<T> IOHLACEAPOK;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private const int MAINOHLGJGH = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private LFALOEPBFDG[] KKAKPOKBAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int HBKABIECEMA;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float JALDFOAMPFG
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x85F2A0", Offset = "0x85DCA0", VA = "0x18085F2A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8719D0", Offset = "0x8703D0", VA = "0x1808719D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4324C30", Offset = "0x4323630", VA = "0x184324C30")]
	public PPKMANDHHOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4324C50", Offset = "0x4323650", VA = "0x184324C50")]
	public PPKMANDHHOC(int CBAOPDHODHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x43242F0", Offset = "0x4322CF0", VA = "0x1843242F0")]
	public void BIPEDCDHLGG(float PAJOJJHFNPD, T AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4324780", Offset = "0x4323180", VA = "0x184324780")]
	public void LDCFGOINEDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4323E00", Offset = "0x4322800", VA = "0x184323E00")]
	public bool ANIOMHJBODP(float IJBOKNKJPIJ, float GCGHBENNAFK, [Out] T AEJBOLFACJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4324870", Offset = "0x4323270", VA = "0x184324870")]
	public bool OLKDEBDFIEI(float IJBOKNKJPIJ, float GCGHBENNAFK, [Out] T AEJBOLFACJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4324540", Offset = "0x4322F40", VA = "0x184324540")]
	public void GEKJCDKLNIP(float IJBOKNKJPIJ, float GCGHBENNAFK, List<T> PJIBFCJPNLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4324660", Offset = "0x4323060", VA = "0x184324660")]
	private int IMNNIEBMCDE(int LBPDKKNKAGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x43243B0", Offset = "0x4322DB0", VA = "0x1843243B0")]
	private void DBHIAJPNCDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T MDANDFPAHLC();

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T MLBKDJOENIN(T AEJBOLFACJC, float BIKAIHEBIHG);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T FHLBDLFOOOD(T OOMAGBGJFDN, T CBOPOPHGBGK);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T HMFPJIGJLHC(T OOMAGBGJFDN, T CBOPOPHGBGK);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class IEGENFDDMKF : PPKMANDHHOC<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7D2D60", Offset = "0x7D1760", VA = "0x1807D2D60", Slot = "4")]
	protected override Vector3 MDANDFPAHLC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x630F300", Offset = "0x630DD00", VA = "0x18630F300", Slot = "5")]
	protected override Vector3 MLBKDJOENIN(Vector3 AEJBOLFACJC, float BIKAIHEBIHG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x630F230", Offset = "0x630DC30", VA = "0x18630F230", Slot = "6")]
	protected override Vector3 FHLBDLFOOOD(Vector3 OOMAGBGJFDN, Vector3 CBOPOPHGBGK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x630F280", Offset = "0x630DC80", VA = "0x18630F280", Slot = "7")]
	protected override Vector3 HMFPJIGJLHC(Vector3 OOMAGBGJFDN, Vector3 CBOPOPHGBGK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x630F340", Offset = "0x630DD40", VA = "0x18630F340")]
	public IEGENFDDMKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class BDFOJLFPBLE
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2716360", Offset = "0x2714D60", VA = "0x182716360")]
	public static GGACKPBODFE<T1, T2> HGOBECNKDLP<T1, T2>(T1 EKKKMFIOLFH, T2 FNAPCPDOKIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x27163E0", Offset = "0x2714DE0", VA = "0x1827163E0")]
	public static BDPFLDALLJE<T1, T2, T3> HGOBECNKDLP<T1, T2, T3>(T1 EKKKMFIOLFH, T2 FNAPCPDOKIB, T3 PMELLGCGAGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x40A2D60", Offset = "0x40A1760", VA = "0x1840A2D60")]
	internal static int BDCJPFLLGJE(int EJAJGHMMLJC, int LPJIADEOMPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x570C6A0", Offset = "0x570B0A0", VA = "0x18570C6A0")]
	internal static int BDCJPFLLGJE(int EJAJGHMMLJC, int LPJIADEOMPE, int EEJONHKKOON)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class GGACKPBODFE<T1, T2> : IComparable<GGACKPBODFE<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly T1 BCLDKNHJOHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly T2 KKCEGMMKFFM;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3963DC0", Offset = "0x39627C0", VA = "0x183963DC0")]
	public GGACKPBODFE(T1 EKKKMFIOLFH, T2 FNAPCPDOKIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3962B60", Offset = "0x3961560", VA = "0x183962B60", Slot = "4")]
	public int CompareTo(GGACKPBODFE<T1, T2> HKMMPHJFKEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x39631F0", Offset = "0x3961BF0", VA = "0x1839631F0", Slot = "0")]
	public override bool Equals(object HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x39634C0", Offset = "0x3961EC0", VA = "0x1839634C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3963AA0", Offset = "0x39624A0", VA = "0x183963AA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class BDPFLDALLJE<T1, T2, T3> : IComparable<BDPFLDALLJE<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly T1 BCLDKNHJOHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly T2 KKCEGMMKFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly T3 LDBCKIKKNLC;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x49372C0", Offset = "0x4935CC0", VA = "0x1849372C0")]
	public BDPFLDALLJE(T1 EKKKMFIOLFH, T2 FNAPCPDOKIB, T3 PMELLGCGAGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4936B10", Offset = "0x4935510", VA = "0x184936B10", Slot = "4")]
	public int CompareTo(BDPFLDALLJE<T1, T2, T3> HKMMPHJFKEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4936C40", Offset = "0x4935640", VA = "0x184936C40", Slot = "0")]
	public override bool Equals(object HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4936F60", Offset = "0x4935960", VA = "0x184936F60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4937000", Offset = "0x4935A00", VA = "0x184937000", Slot = "3")]
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
	public T DPMGLPAKGNP
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x21B4640", Offset = "0x21B3040", VA = "0x1821B4640")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x21B4650", Offset = "0x21B3050", VA = "0x1821B4650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float BNHEKBBMGND
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8AEA90", Offset = "0x8AD490", VA = "0x1808AEA90")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x46D5190", Offset = "0x46D3B90", VA = "0x1846D5190")]
	public T GLBCCDNIIMH(float BIKAIHEBIHG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x46D53A0", Offset = "0x46D3DA0", VA = "0x1846D53A0")]
	public T NFAFAAIHHEE(float BIKAIHEBIHG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T ECEHCHBLHOD(T OOMAGBGJFDN, T CBOPOPHGBGK, float BIKAIHEBIHG);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x630E860", Offset = "0x630D260", VA = "0x18630E860", Slot = "4")]
	protected override float ECEHCHBLHOD(float OOMAGBGJFDN, float CBOPOPHGBGK, float BIKAIHEBIHG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x630E8A0", Offset = "0x630D2A0", VA = "0x18630E8A0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xD25F50", Offset = "0xD24950", VA = "0x180D25F50", Slot = "4")]
	protected override Vector3 ECEHCHBLHOD(Vector3 OOMAGBGJFDN, Vector3 CBOPOPHGBGK, float BIKAIHEBIHG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6312540", Offset = "0x6310F40", VA = "0x186312540")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x630E610", Offset = "0x630D010", VA = "0x18630E610", Slot = "4")]
	protected override Color ECEHCHBLHOD(Color OOMAGBGJFDN, Color CBOPOPHGBGK, float BIKAIHEBIHG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x630E6D0", Offset = "0x630D0D0", VA = "0x18630E6D0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class AGPMFAONLFI : LCMJKNGCHHH<string>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x630D050", Offset = "0x630BA50", VA = "0x18630D050")]
	public AGPMFAONLFI(int JDNEKMCCAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x630CFE0", Offset = "0x630B9E0", VA = "0x18630CFE0", Slot = "6")]
	protected override uint ADOBPICADCG(uint NKHBKFIGNJB, string AEJBOLFACJC)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class OKEPHJIBMMP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly IDisposable AINFBDJPIJL;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public OKEPHJIBMMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct MMJFLDJNBMF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> IDNKIKLHJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int MLGBDNHAIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int KHEPPGJAENN;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4053140", Offset = "0x4051B40", VA = "0x184053140")]
	private MMJFLDJNBMF(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> BLFEIFNMFGP, int DJDCODCALHP, int HHFNHFOBMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4053050", Offset = "0x4051A50", VA = "0x184053050")]
	public static MMJFLDJNBMF<T> OLCPJHCMOKI()
	{
		return default(MMJFLDJNBMF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4051650", Offset = "0x4050050", VA = "0x184051650")]
	public (int, int, Task<T>) NAILLJHGCEN(int OFMNGOBJEKH, [Optional] CancellationToken CFAFANOFDNJ, double BAFOADOMFEH = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4050F90", Offset = "0x404F990", VA = "0x184050F90")]
	public void CNFEBCEDIKK(int OFMNGOBJEKH, int HHFNHFOBMEF, [In] T LKBGEIGOHEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class MCNFOJHDKLH
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x63100C0", Offset = "0x630EAC0", VA = "0x1863100C0")]
	public static MMJFLDJNBMF<PHKKIFFGKBG> OLCPJHCMOKI()
	{
		return default(MMJFLDJNBMF<PHKKIFFGKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6310040", Offset = "0x630EA40", VA = "0x186310040")]
	public static void CNFEBCEDIKK([In] this MMJFLDJNBMF<PHKKIFFGKBG> CMJEIEIDHIK, int OFMNGOBJEKH, int HHFNHFOBMEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class IPDDJNIOCNG<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<TKey, TVal> KKHCLPPJDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly Dictionary<TVal, TKey> BHBPMOHCLOJ;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int IAGPAHCAHED
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x32DCC30", Offset = "0x32DB630", VA = "0x1832DCC30", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool FIKMFADPAMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ICollection<TKey> HCMLLGDIBEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x38C4C90", Offset = "0x38C3690", VA = "0x1838C4C90", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ICollection<TVal> PMCNHJDBEMD
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3ADA010", Offset = "0x3AD8A10", VA = "0x183ADA010", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TVal MIEEOIIACLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x3AD9FB0", Offset = "0x3AD89B0", VA = "0x183AD9FB0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3ADA050", Offset = "0x3AD8A50", VA = "0x183ADA050", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey MIEEOIIACLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3AD9610", Offset = "0x3AD8010", VA = "0x183AD9610")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3AD9370", Offset = "0x3AD7D70", VA = "0x183AD9370", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3AD9DF0", Offset = "0x3AD87F0", VA = "0x183AD9DF0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3AD9320", Offset = "0x3AD7D20", VA = "0x183AD9320", Slot = "9")]
	public void Add(TKey KLDFLAABJKH, TVal AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3AD92B0", Offset = "0x3AD7CB0", VA = "0x183AD92B0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> ODDGLLCBILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3AD93D0", Offset = "0x3AD7DD0", VA = "0x183AD93D0", Slot = "8")]
	public bool ContainsKey(TKey KLDFLAABJKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3AD9460", Offset = "0x3AD7E60", VA = "0x183AD9460", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> ODDGLLCBILG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3AD9CD0", Offset = "0x3AD86D0", VA = "0x183AD9CD0", Slot = "10")]
	public bool Remove(TKey KLDFLAABJKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3AD9CF0", Offset = "0x3AD86F0", VA = "0x183AD9CF0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> ODDGLLCBILG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3AD9E40", Offset = "0x3AD8840", VA = "0x183AD9E40", Slot = "11")]
	public bool TryGetValue(TKey KLDFLAABJKH, [Out] TVal AEJBOLFACJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3AD9580", Offset = "0x3AD7F80", VA = "0x183AD9580", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3AD9490", Offset = "0x3AD7E90", VA = "0x183AD9490", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] KKAKPOKBAHF, int CJLMKFIOCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3AD9AA0", Offset = "0x3AD84A0", VA = "0x183AD9AA0")]
	public bool PJCFHHABBNE(TVal KLDFLAABJKH, [Out] TKey AEJBOLFACJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3AD9C30", Offset = "0x3AD8630", VA = "0x183AD9C30")]
	private void PNGDCEAGCOM(TKey KLDFLAABJKH, TVal OONFDHNBOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3AD9720", Offset = "0x3AD8120", VA = "0x183AD9720")]
	private void LHBKJPOEJEG(TKey KLDFLAABJKH, TVal OONFDHNBOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3AD9900", Offset = "0x3AD8300", VA = "0x183AD9900")]
	private bool PHKEEJDCBEG(TKey KLDFLAABJKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3AD9E80", Offset = "0x3AD8880", VA = "0x183AD9E80")]
	public IPDDJNIOCNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[DefaultMember("Item")]
public class HHPEFNPPEKO<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private HHPEFNPPEKO<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x3578520", Offset = "0x3576F20", VA = "0x183578520", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x3584C70", Offset = "0x3583670", VA = "0x183584C70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x3585F70", Offset = "0x3584970", VA = "0x183585F70")]
		public Enumerator(HHPEFNPPEKO<T> PJIBFCJPNLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x3583840", Offset = "0x3582240", VA = "0x183583840", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3584560", Offset = "0x3582F60", VA = "0x183584560", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3583130", Offset = "0x3581B30", VA = "0x183583130")]
		private void IMCMMEBPADA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private T[] IHGGEODABFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private int ALMDOMLFINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private int FDDACKAJOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int LHMJGBJEDAH;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int IAGPAHCAHED
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x39F4DB0", Offset = "0x39F37B0", VA = "0x1839F4DB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T MIEEOIIACLC
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x39F55E0", Offset = "0x39F3FE0", VA = "0x1839F55E0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x39F5A20", Offset = "0x39F4420", VA = "0x1839F5A20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x39F6630", Offset = "0x39F5030", VA = "0x1839F6630")]
	public HHPEFNPPEKO(int JDNEKMCCAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x39F4810", Offset = "0x39F3210", VA = "0x1839F4810")]
	public void BIPEDCDHLGG(T BIKAIHEBIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x39F57B0", Offset = "0x39F41B0", VA = "0x1839F57B0")]
	public void LDCFGOINEDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x39F4D10", Offset = "0x39F3710", VA = "0x1839F4D10")]
	public void BPJHNEAAGCG(int GBACAOOHJGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x39F5AB0", Offset = "0x39F44B0", VA = "0x1839F5AB0")]
	public void OBJFIFCBBDL(T[] KKAKPOKBAHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x39F5710", Offset = "0x39F4110", VA = "0x1839F5710")]
	public Enumerator HOEJGHKHDAP()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x39F63D0", Offset = "0x39F4DD0", VA = "0x1839F63D0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x39F63D0", Offset = "0x39F4DD0", VA = "0x1839F63D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x39F51F0", Offset = "0x39F3BF0", VA = "0x1839F51F0")]
	private int HCCEDHADFAE(int ABBNIPHGMGH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x39F5780", Offset = "0x39F4180", VA = "0x1839F5780")]
	private int JNDMCCAGAKM(int ABBNIPHGMGH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class MPLEOKNNHLK<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public delegate Task<TResult> JHAPPBEJKEO(TRequest ELBMMMMNOAO, CancellationToken CFAFANOFDNJ);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public enum HNBPAFHKAOI
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class LDAJBKJBDLN
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private const float PHAOKMDMIPI = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TimeSpan CBANCJIKLDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int MNAPPAPMANG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public HNBPAFHKAOI OCDCHAECHAF;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static readonly LDAJBKJBDLN GMHFJIOGOCL;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float AIIKEDFIBCJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x3E295B0", Offset = "0x3E27FB0", VA = "0x183E295B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public TimeSpan IPLDCKMKNMF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x3E29770", Offset = "0x3E28170", VA = "0x183E29770")]
		public LDAJBKJBDLN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private readonly struct KLFEKEIAOIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly TRequest ELBMMMMNOAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly CancellationToken CFAFANOFDNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly TaskCompletionSource<TResult> DJLLJHIIGHE;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x3D73120", Offset = "0x3D71B20", VA = "0x183D73120")]
		public KLFEKEIAOIB(TRequest ELBMMMMNOAO, TaskCompletionSource<TResult> DJLLJHIIGHE, CancellationToken CFAFANOFDNJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct BBAGECBEJDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public MPLEOKNNHLK<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4927650", Offset = "0x4926050", VA = "0x184927650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x4927A70", Offset = "0x4926470", VA = "0x184927A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct MNABGHAGGGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public MPLEOKNNHLK<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private KLFEKEIAOIB <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x4053E00", Offset = "0x4052800", VA = "0x184053E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x40543D0", Offset = "0x4052DD0", VA = "0x1840543D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly CancellationTokenSource MLNFMEEJOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly List<KLFEKEIAOIB> BFALBGOCOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly LDAJBKJBDLN AALOKIKFHPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly JHAPPBEJKEO IAJGAKAFLGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Task PKNKJEAMLGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private int OBMGHBCKDMM;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4079CF0", Offset = "0x40786F0", VA = "0x184079CF0")]
	public MPLEOKNNHLK(JHAPPBEJKEO IAJGAKAFLGF, [Optional] LDAJBKJBDLN AALOKIKFHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4078D00", Offset = "0x4077700", VA = "0x184078D00")]
	public Task<TResult> JKKOMBCEJMD(TRequest ELBMMMMNOAO, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x40798D0", Offset = "0x40782D0", VA = "0x1840798D0")]
	private void NGKGIJAFNPE(KLFEKEIAOIB ADGDPMPEIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4078930", Offset = "0x4077330", VA = "0x184078930")]
	[AsyncStateMachine(typeof(MPLEOKNNHLK<, >.BBAGECBEJDI))]
	private Task FMJLLIMBJMD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4079340", Offset = "0x4077D40", VA = "0x184079340")]
	private KLFEKEIAOIB KODNBMDFLHM()
	{
		return default(KLFEKEIAOIB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4078770", Offset = "0x4077170", VA = "0x184078770")]
	[AsyncStateMachine(typeof(MPLEOKNNHLK<, >.MNABGHAGGGG))]
	private Task FKNMDHPBKMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x40783A0", Offset = "0x4076DA0", VA = "0x1840783A0")]
	private void FGEIHDGKEOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4078270", Offset = "0x4076C70", VA = "0x184078270", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class BKIJCJLHNOG<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly List<T> GOJPHGMMOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private HashSet<T> LBNIOFILJKN;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int IAGPAHCAHED
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x32DCC30", Offset = "0x32DB630", VA = "0x1832DCC30", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool FIKMFADPAMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public T MIEEOIIACLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3511460", Offset = "0x350FE60", VA = "0x183511460", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x49588E0", Offset = "0x49572E0", VA = "0x1849588E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x38BF1A0", Offset = "0x38BDBA0", VA = "0x1838BF1A0", Slot = "11")]
	public void Add(T ODDGLLCBILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4958460", Offset = "0x4956E60", VA = "0x184958460")]
	public bool MFACCNDNDKF(T ODDGLLCBILG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4958760", Offset = "0x4957160", VA = "0x184958760", Slot = "15")]
	public bool Remove(T ODDGLLCBILG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x42276B0", Offset = "0x42260B0", VA = "0x1842276B0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3902340", Offset = "0x3900D40", VA = "0x183902340", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4958140", Offset = "0x4956B40", VA = "0x184958140", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x49581A0", Offset = "0x4956BA0", VA = "0x1849581A0", Slot = "13")]
	public bool Contains(T ODDGLLCBILG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x49581E0", Offset = "0x4956BE0", VA = "0x1849581E0", Slot = "14")]
	public void CopyTo(T[] KKAKPOKBAHF, int CJLMKFIOCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3DB1CF0", Offset = "0x3DB06F0", VA = "0x183DB1CF0", Slot = "6")]
	public int IndexOf(T ODDGLLCBILG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x4958210", Offset = "0x4956C10", VA = "0x184958210", Slot = "7")]
	public void Insert(int ABBNIPHGMGH, T ODDGLLCBILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x49585F0", Offset = "0x4956FF0", VA = "0x1849585F0", Slot = "8")]
	public void RemoveAt(int ABBNIPHGMGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x49587F0", Offset = "0x49571F0", VA = "0x1849587F0")]
	public BKIJCJLHNOG()
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
			[Cpp2IlInjected.Address(RVA = "0x203DC50", Offset = "0x203C650", VA = "0x18203DC50")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6311BD0", Offset = "0x63105D0", VA = "0x186311BD0")]
		public SerializedGuid([In] Guid JHOGCCPFJGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6311930", Offset = "0x6310330", VA = "0x186311930")]
		public static SerializedGuid CMCEKPMJLHF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x63118C0", Offset = "0x63102C0", VA = "0x1863118C0")]
		public static SerializedGuid BAPHFHODIJH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6311AC0", Offset = "0x63104C0", VA = "0x186311AC0")]
		public bool MJOGKGKNLAM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6311BA0", Offset = "0x63105A0", VA = "0x186311BA0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6311B20", Offset = "0x6310520", VA = "0x186311B20", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x63119E0", Offset = "0x63103E0", VA = "0x1863119E0", Slot = "7")]
		public bool Equals(SerializedGuid HKMMPHJFKEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6311A20", Offset = "0x6310420", VA = "0x186311A20", Slot = "0")]
		public override bool Equals(object COMOOAEHALC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6311AB0", Offset = "0x63104B0", VA = "0x186311AB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x63119B0", Offset = "0x63103B0", VA = "0x1863119B0", Slot = "6")]
		public int CompareTo(SerializedGuid HKMMPHJFKEA)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class GNDPBCELOAK : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly Type BNEGDPCGMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly string ADKHKLBKNOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool COOMMNPGGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool OJLFDEMBMJC;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x630EA50", Offset = "0x630D450", VA = "0x18630EA50")]
	public GNDPBCELOAK(Type DDJDBBIHNNN, string JDPHIHLIMPE, bool CJAPMCOJDFB = false, bool BNBMFCDIGGM = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class MJHALEONFCB<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public readonly struct BEJONDCAKJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly long IFOEMBIHGHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly long LKGHBKAOMFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public readonly int BBLLIELGMHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly int PJGHAAKLAIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly bool PHKMDDAIDMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly string HGEHIBEGMPB;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x493E210", Offset = "0x493CC10", VA = "0x18493E210")]
		public BEJONDCAKJO(long IFOEMBIHGHC, int BBLLIELGMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x493E1E0", Offset = "0x493CBE0", VA = "0x18493E1E0")]
		public BEJONDCAKJO(long IFOEMBIHGHC, long LKGHBKAOMFC, int BBLLIELGMHK, int PJGHAAKLAIA, bool PHKMDDAIDMG, string HGEHIBEGMPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x493E110", Offset = "0x493CB10", VA = "0x18493E110")]
		public int NMNMMEECEIN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x493E160", Offset = "0x493CB60", VA = "0x18493E160")]
		public int OACMNEKOIAG(int CGPDEMLPDEO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x493E180", Offset = "0x493CB80", VA = "0x18493E180")]
		public double PMCJOBANBEB()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x493E070", Offset = "0x493CA70", VA = "0x18493E070")]
		public BEJONDCAKJO KCJIAHEHMMJ(long LKGHBKAOMFC, int PJGHAAKLAIA)
		{
			return default(BEJONDCAKJO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class KDBHCAJIBOE : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private struct DPPLACCGIKF<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public KDBHCAJIBOE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Func<KDBHCAJIBOE, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private KDBHCAJIBOE <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x527BAA0", Offset = "0x527A4A0", VA = "0x18527BAA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x34FC700", Offset = "0x34FB100", VA = "0x1834FC700", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly TKey ILKHIKNJEKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly MJHALEONFCB<TKey> MDGFMJGBLAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly LBNENDFDEJK EMEAPIGMNBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private List<KDBHCAJIBOE> HFEKCCAPFND;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public string EFPGEBKIAEB
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x3D57EC0", Offset = "0x3D568C0", VA = "0x183D57EC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public IEnumerable<KDBHCAJIBOE> PFDJACJHAON
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x3D57D20", Offset = "0x3D56720", VA = "0x183D57D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public BEJONDCAKJO OCGEEJFANDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x3D57D50", Offset = "0x3D56750", VA = "0x183D57D50")]
			[CompilerGenerated]
			get
			{
				return default(BEJONDCAKJO);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x3D57CF0", Offset = "0x3D566F0", VA = "0x183D57CF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3D57EF0", Offset = "0x3D568F0", VA = "0x183D57EF0")]
		internal KDBHCAJIBOE(MJHALEONFCB<TKey> MDGFMJGBLAI, TKey KLDFLAABJKH, LBNENDFDEJK EMEAPIGMNBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3D57D70", Offset = "0x3D56770", VA = "0x183D57D70")]
		public KDBHCAJIBOE KHJOMJJIEIG(TKey KLDFLAABJKH, [Optional] LBNENDFDEJK? GNPNPELLJLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x281EB10", Offset = "0x281D510", VA = "0x18281EB10")]
		[AsyncStateMachine(typeof(DPPLACCGIKF<>))]
		public Task<T> LABDDMJHBDF<T>(TKey KLDFLAABJKH, Func<KDBHCAJIBOE, Task<T>> KNCKABMPAIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3D57B10", Offset = "0x3D56510", VA = "0x183D57B10", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class BAGCNFAGIEL : IEnumerable<(TKey, List<TKey>, BEJONDCAKJO)>, IEnumerable, IEnumerator<(TKey, List<TKey>, BEJONDCAKJO)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private (TKey key, List<TKey> path, BEJONDCAKJO timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public MJHALEONFCB<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IEnumerator<(TKey key, List<TKey> path, BEJONDCAKJO timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private (TKey, List<TKey>, BEJONDCAKJO) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x2048040", Offset = "0x2046A40", VA = "0x182048040", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, BEJONDCAKJO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x49200E0", Offset = "0x491EAE0", VA = "0x1849200E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2048130", Offset = "0x2046B30", VA = "0x182048130")]
		[DebuggerHidden]
		public BAGCNFAGIEL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x38305C0", Offset = "0x382EFC0", VA = "0x1838305C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x491FC50", Offset = "0x491E650", VA = "0x18491FC50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x491FC00", Offset = "0x491E600", VA = "0x18491FC00")]
		private void AOIIEBMEGKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4920090", Offset = "0x491EA90", VA = "0x184920090", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x491FFD0", Offset = "0x491E9D0", VA = "0x18491FFD0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, BEJONDCAKJO)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x35190B0", Offset = "0x3517AB0", VA = "0x1835190B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class AEPGEJDPFOJ : IEnumerable<(TKey, List<TKey>, BEJONDCAKJO)>, IEnumerable, IEnumerator<(TKey, List<TKey>, BEJONDCAKJO)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private (TKey key, List<TKey> path, BEJONDCAKJO timerEntry) <>2__current;

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
		private KDBHCAJIBOE timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public KDBHCAJIBOE <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public MJHALEONFCB<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private IEnumerator<KDBHCAJIBOE> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private IEnumerator<(TKey key, List<TKey> path, BEJONDCAKJO timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, BEJONDCAKJO) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x2048040", Offset = "0x2046A40", VA = "0x182048040", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, BEJONDCAKJO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x3970B20", Offset = "0x396F520", VA = "0x183970B20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2048130", Offset = "0x2046B30", VA = "0x182048130")]
		[DebuggerHidden]
		public AEPGEJDPFOJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3970B80", Offset = "0x396F580", VA = "0x183970B80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3970260", Offset = "0x396EC60", VA = "0x183970260", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3970200", Offset = "0x396EC00", VA = "0x183970200")]
		private void AOIIEBMEGKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x39701A0", Offset = "0x396EBA0", VA = "0x1839701A0")]
		private void AFFHFGLBOCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3970AD0", Offset = "0x396F4D0", VA = "0x183970AD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x39709C0", Offset = "0x396F3C0", VA = "0x1839709C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, BEJONDCAKJO)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x3970AA0", Offset = "0x396F4A0", VA = "0x183970AA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly Action<TKey, BEJONDCAKJO, LBNENDFDEJK> NOPDBOHMGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Action<TKey, BEJONDCAKJO, LBNENDFDEJK> LENPGLCCDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly Action<MJHALEONFCB<TKey>, LBNENDFDEJK> BAKHJJIKPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly LBNENDFDEJK EMEAPIGMNBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly KDBHCAJIBOE DHJBIMIDGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private bool OGOJAHMCHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int EBHAKPFNKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly Stopwatch FLGPGEDOAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly int KNGGEEKLKJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private string LFECEPDGAAG;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public KDBHCAJIBOE BFHGAINCPOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	[NotNull]
	public string EFPGEBKIAEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7C6940", Offset = "0x7C5340", VA = "0x1807C6940")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x40442A0", Offset = "0x4042CA0", VA = "0x1840442A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4044300", Offset = "0x4042D00", VA = "0x184044300")]
	public MJHALEONFCB(TKey DPLHACACIDM, LBNENDFDEJK EMEAPIGMNBK, [Optional] int? BBLLIELGMHK, [Optional][CanBeNull] Stopwatch FLGPGEDOAJG, [Optional] Action<TKey, BEJONDCAKJO, LBNENDFDEJK> NOPDBOHMGJE, [Optional] Action<TKey, BEJONDCAKJO, LBNENDFDEJK> LENPGLCCDJD, [Optional] Action<MJHALEONFCB<TKey>, LBNENDFDEJK> BAKHJJIKPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4044030", Offset = "0x4042A30", VA = "0x184044030", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x40440C0", Offset = "0x4042AC0", VA = "0x1840440C0")]
	[IteratorStateMachine(typeof(MJHALEONFCB<>.BAGCNFAGIEL))]
	public IEnumerable<(TKey, List<TKey>, BEJONDCAKJO)> HKCJEJANEGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4044150", Offset = "0x4042B50", VA = "0x184044150")]
	[IteratorStateMachine(typeof(MJHALEONFCB<>.AEPGEJDPFOJ))]
	private IEnumerable<(TKey, List<TKey>, BEJONDCAKJO)> HKCJEJANEGM(List<TKey> NBJNGHHJOKO, KDBHCAJIBOE PBJFGPEMNJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4044220", Offset = "0x4042C20", VA = "0x184044220")]
	private (long, int) KFAHEINFKPC()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public abstract class HELIBMECLMJ<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut EMJBCFIBPOE(MJHALEONFCB<TKey> MDGFMJGBLAI);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	protected HELIBMECLMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public abstract class BEDDGPLCDHK<TKey> : HELIBMECLMJ<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate string EKHICCIGKCK(TKey KLDFLAABJKH);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x4937500", Offset = "0x4935F00", VA = "0x184937500")]
	private static string FMBKEOOCDFJ(TKey KLDFLAABJKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x4937310", Offset = "0x4935D10", VA = "0x184937310", Slot = "4")]
	public override string EMJBCFIBPOE(MJHALEONFCB<TKey> MDGFMJGBLAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x49373C0", Offset = "0x4935DC0", VA = "0x1849373C0")]
	public string EMJBCFIBPOE(MJHALEONFCB<TKey> MDGFMJGBLAI, [NotNull] EKHICCIGKCK FHEJJFDDKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string MCPOMDGBOCM(MJHALEONFCB<TKey> MDGFMJGBLAI, [NotNull] EKHICCIGKCK FHEJJFDDKJK);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3AE6770", Offset = "0x3AE5170", VA = "0x183AE6770")]
	protected BEDDGPLCDHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class EBGBHCGGDFI<TKey> : HELIBMECLMJ<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public delegate string EMOAHGLJEEO(TKey KLDFLAABJKH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly string KMMGCBOCIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly double HDDABOCLIEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly bool EBEMMFJBEMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly int PKNJEPEGEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly ISet<string> DJMLEOBOGHO;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x34D19A0", Offset = "0x34D03A0", VA = "0x1834D19A0")]
	private static string FMBKEOOCDFJ(TKey KLDFLAABJKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x34D1E30", Offset = "0x34D0830", VA = "0x1834D1E30")]
	public EBGBHCGGDFI(string KMMGCBOCIAB = "F2", double HDDABOCLIEG = double.MaxValue, bool EBEMMFJBEMN = false, int PKNJEPEGEOC = int.MaxValue, [Optional] ISet<string> DJMLEOBOGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x34D1340", Offset = "0x34CFD40", VA = "0x1834D1340", Slot = "4")]
	public override Dictionary<string, string> EMJBCFIBPOE(MJHALEONFCB<TKey> MDGFMJGBLAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x34D19E0", Offset = "0x34D03E0", VA = "0x1834D19E0")]
	private bool ICCOGIPIMIJ(string PDPPPKLBGLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x34D13F0", Offset = "0x34CFDF0", VA = "0x1834D13F0")]
	public Dictionary<string, string> EMJBCFIBPOE(MJHALEONFCB<TKey> MDGFMJGBLAI, EMOAHGLJEEO FHEJJFDDKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x34D1C20", Offset = "0x34D0620", VA = "0x1834D1C20")]
	private string ODGLEADDGAB(StringBuilder NODAGDHFAKG, List<TKey> FIAFIMFBCND, EMOAHGLJEEO FHEJJFDDKJK, bool EPFMNCDDGKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x34D1AC0", Offset = "0x34D04C0", VA = "0x1834D1AC0")]
	private static void IHLFAKPIDHL(StringBuilder OPNJBLMGEEN, string MLIODJIAAEL, bool AIOBBGFINAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class LONLLCECDPP<TKey> : BEDDGPLCDHK<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct NKEPIDPMOJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public EKHICCIGKCK keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static LONLLCECDPP<TKey> AINFBDJPIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly string[] PKNOJCOGBOM;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3E57D30", Offset = "0x3E56730", VA = "0x183E57D30")]
	private LONLLCECDPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3E56D10", Offset = "0x3E55710", VA = "0x183E56D10", Slot = "5")]
	protected override string MCPOMDGBOCM(MJHALEONFCB<TKey> MDGFMJGBLAI, EKHICCIGKCK FHEJJFDDKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3E57B10", Offset = "0x3E56510", VA = "0x183E57B10")]
	[CompilerGenerated]
	internal static string PCIKCFPOIEC(string EMPNCPFKFOJ, TKey KLDFLAABJKH, NKEPIDPMOJO P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class PDHIKCDJDLD : MJHALEONFCB<string>
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class APMBNMEGOFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Action<PDHIKCDJDLD, LBNENDFDEJK> callback;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public APMBNMEGOFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x630E0F0", Offset = "0x630CAF0", VA = "0x18630E0F0")]
		internal void ELCLEDECGAA(MJHALEONFCB<string> timer, LBNENDFDEJK log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x63102D0", Offset = "0x630ECD0", VA = "0x1863102D0")]
	public PDHIKCDJDLD(LBNENDFDEJK EMEAPIGMNBK, [Optional] string ELACGEDDHPJ, [Optional] int? BBLLIELGMHK, [Optional] Stopwatch FLGPGEDOAJG, [Optional] Action<string, BEJONDCAKJO, LBNENDFDEJK> NOPDBOHMGJE, [Optional] Action<string, BEJONDCAKJO, LBNENDFDEJK> LENPGLCCDJD, [Optional] Action<PDHIKCDJDLD, LBNENDFDEJK> BAKHJJIKPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6310210", Offset = "0x630EC10", VA = "0x186310210")]
	private static Action<MJHALEONFCB<string>, LBNENDFDEJK> OCGIFGIFJBL(Action<PDHIKCDJDLD, LBNENDFDEJK> JNDJHGKPENH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class GMCOCLPAFOK
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private class FLMNNLKAMOM : GMCOCLPAFOK
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public static GMCOCLPAFOK AINFBDJPIJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x630E710", Offset = "0x630D110", VA = "0x18630E710")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override float JLFLLENLOMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x85EBE0", Offset = "0x85D5E0", VA = "0x18085EBE0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x630E810", Offset = "0x630D210", VA = "0x18630E810")]
		public FLMNNLKAMOM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static GMCOCLPAFOK MEECEDMCAMC;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static GMCOCLPAFOK GMHFJIOGOCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x630E8E0", Offset = "0x630D2E0", VA = "0x18630E8E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public abstract float JLFLLENLOMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	protected GMCOCLPAFOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface KKILGLJEJLC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool DNNOPBKFOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface NGGDDPJIFIN<T> : KKILGLJEJLC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	[NotNull]
	Task<T> MKMICJEMIPC
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	[NotNull]
	NOCKNPDCDFN<T> FGCIIKBPCJF
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class HOHEHGJPDAC
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private sealed class OPCDADIFJGH<T> : DGPNADCMPPB<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override Task<T?> MKMICJEMIPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NOCKNPDCDFN<T?> FGCIIKBPCJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x7C5500", Offset = "0x7C3F00", VA = "0x1807C5500", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x4231D00", Offset = "0x4230700", VA = "0x184231D00")]
		public OPCDADIFJGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "10")]
		protected override void CPBJKKIAIDA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private sealed class KIHCJCDOCIN<T> : DGPNADCMPPB<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override Task<T> MKMICJEMIPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NOCKNPDCDFN<T> FGCIIKBPCJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x7C5500", Offset = "0x7C3F00", VA = "0x1807C5500", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x3D69930", Offset = "0x3D68330", VA = "0x183D69930")]
		public KIHCJCDOCIN(Exception JJIAPADECIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "10")]
		protected override void CPBJKKIAIDA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private sealed class IHJPKELIAGG<T> : DGPNADCMPPB<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private struct FDOJFLLEOCN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public Task<NGGDDPJIFIN<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			private TaskAwaiter<NGGDDPJIFIN<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x387ABE0", Offset = "0x38795E0", VA = "0x18387ABE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x387B090", Offset = "0x3879A90", VA = "0x18387B090", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private struct GICHIEFJFMP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public Task<NGGDDPJIFIN<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private TaskAwaiter<NGGDDPJIFIN<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x398B3D0", Offset = "0x3989DD0", VA = "0x18398B3D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x398B5F0", Offset = "0x3989FF0", VA = "0x18398B5F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly Task<NGGDDPJIFIN<T>> DKBFKLLAIKE;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override Task<T> MKMICJEMIPC
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x7C5500", Offset = "0x7C3F00", VA = "0x1807C5500", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override NOCKNPDCDFN<T> FGCIIKBPCJF
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x7C5AA0", Offset = "0x7C44A0", VA = "0x1807C5AA0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x3AB6040", Offset = "0x3AB4A40", VA = "0x183AB6040")]
		public IHJPKELIAGG(Task<NGGDDPJIFIN<T>> KPCFMNKKKMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x3AB5E70", Offset = "0x3AB4870", VA = "0x183AB5E70", Slot = "10")]
		protected override void CPBJKKIAIDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x3AB5EF0", Offset = "0x3AB48F0", VA = "0x183AB5EF0")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(IHJPKELIAGG<>.FDOJFLLEOCN))]
		internal static Task<T> HPAOACLLHGF(Task<NGGDDPJIFIN<T>> KPCFMNKKKMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x3AB5D90", Offset = "0x3AB4790", VA = "0x183AB5D90")]
		[AsyncStateMachine(typeof(IHJPKELIAGG<>.GICHIEFJFMP))]
		[CompilerGenerated]
		internal static Task APGIFDIMMCC(Task<NGGDDPJIFIN<T>> KPCFMNKKKMJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2970380", Offset = "0x296ED80", VA = "0x182970380")]
	public static NGGDDPJIFIN<T> ENNIKGPCCFB<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x271BA70", Offset = "0x271A470", VA = "0x18271BA70")]
	public static NGGDDPJIFIN<T> MEOOEEDKOND<T>(Exception JJIAPADECIB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x271BA70", Offset = "0x271A470", VA = "0x18271BA70")]
	public static NGGDDPJIFIN<T> OJNHIGNCLDN<T>(Task<NGGDDPJIFIN<T>> KPCFMNKKKMJ) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public abstract class DGPNADCMPPB<T> : NGGDDPJIFIN<T>, KKILGLJEJLC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly string JAAJIBMEJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly CNDCANKNEFB DONMMBNMEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private bool OGOJAHMCHNJ;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool DNNOPBKFOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xA30700", Offset = "0xA2F100", VA = "0x180A30700", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public abstract Task<T> MKMICJEMIPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public abstract NOCKNPDCDFN<T> FGCIIKBPCJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x524E860", Offset = "0x524D260", VA = "0x18524E860")]
	public DGPNADCMPPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x524E580", Offset = "0x524CF80", VA = "0x18524E580", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void CPBJKKIAIDA();
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public abstract class NPKMBFFFIFA<TTask, T> : DGPNADCMPPB<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class BPFKHFAOPBP
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
			public BPFKHFAOPBP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x32CC4E0", Offset = "0x32CAEE0", VA = "0x1832CC4E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x32CC7A0", Offset = "0x32CB1A0", VA = "0x1832CC7A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public NPKMBFFFIFA<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public BPFKHFAOPBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x49733C0", Offset = "0x4971DC0", VA = "0x1849733C0")]
		[AsyncStateMachine(typeof(NPKMBFFFIFA<, >.BPFKHFAOPBP.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> NCMBMONJEBC(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly Task<T> KPCFMNKKKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	protected readonly CancellationTokenSource NCPJPNOCKEL;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public override Task<T> MKMICJEMIPC
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public override NOCKNPDCDFN<T> FGCIIKBPCJF
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7C5500", Offset = "0x7C3F00", VA = "0x1807C5500", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x40EC2E0", Offset = "0x40EACE0", VA = "0x1840EC2E0")]
	protected NPKMBFFFIFA(TTask KPCFMNKKKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x40EC0D0", Offset = "0x40EAAD0", VA = "0x1840EC0D0", Slot = "10")]
	protected override void CPBJKKIAIDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T CDGDFAGEMJP(TTask HKKKEIOEHAC);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void CEHCKDJCNPF();
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class IADBJEDBNIJ<T> : DGPNADCMPPB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly AOKOEPMOBFO<Task<T>> LFMBLNEAOCL;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public override Task<T> MKMICJEMIPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x3A0D050", Offset = "0x3A0BA50", VA = "0x183A0D050", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public override NOCKNPDCDFN<T> FGCIIKBPCJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7C5500", Offset = "0x7C3F00", VA = "0x1807C5500", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3A9FDB0", Offset = "0x3A9E7B0", VA = "0x183A9FDB0")]
	public IADBJEDBNIJ(AOKOEPMOBFO<Task<T>> HENMOOCIHIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x3A9FD90", Offset = "0x3A9E790", VA = "0x183A9FD90", Slot = "10")]
	protected override void CPBJKKIAIDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class HJNGPLMNGAE
{
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x630EF80", Offset = "0x630D980", VA = "0x18630EF80")]
	[NotNull]
	public static byte[] OOKLPDOPHBE(this LPKBIPDLCCA NCBEEKHHLLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x630EF10", Offset = "0x630D910", VA = "0x18630EF10")]
	[NotNull]
	public static byte[] OOKLPDOPHBE(this LPKBIPDLCCA NCBEEKHHLLI, HashAlgorithmName PEEOLOFAFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x630EAC0", Offset = "0x630D4C0", VA = "0x18630EAC0")]
	public static bool BJLDFPPCBJG([CanBeNull] this LPKBIPDLCCA NCBEEKHHLLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x630EC50", Offset = "0x630D650", VA = "0x18630EC50")]
	public static bool BJLDFPPCBJG([CanBeNull] this LPKBIPDLCCA NCBEEKHHLLI, [Out] string MBGOEMJAPEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x630EDF0", Offset = "0x630D7F0", VA = "0x18630EDF0")]
	private static bool OCAMLJIHNEJ([NotNull] LPKBIPDLCCA NCBEEKHHLLI, [Out][CanBeNull] byte[] AANFEFHKJII, [Out][CanBeNull] byte[] GCFPBJPFMIL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class IADKFFKHIAA
{
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x630EFF0", Offset = "0x630D9F0", VA = "0x18630EFF0")]
	[NotNull]
	public static byte[] OOKLPDOPHBE(this MFENFNEOGBG GPHNKOOLHHJ, HashAlgorithmName PEEOLOFAFBF, byte[] GLGBHHMAJJC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface MFENFNEOGBG
{
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash NKHBKFIGNJB);
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface LPKBIPDLCCA : MFENFNEOGBG
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	[CanBeNull]
	byte[] LPOIICEANNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	[CanBeNull]
	byte[] JICCMPFNABF
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class KEJNKPNPPGE
{
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static readonly ArrayPool<byte> JLAEICFFDLL;

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static bool MOCBGCIDEJK;

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x29C7270", Offset = "0x29C5C70", VA = "0x1829C7270")]
	public static void LBBIJHMFPLK<T>(this IncrementalHash HKJNJDMHLDJ, [CanBeNull] T KLKCJLEHBJG) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x29C6CC0", Offset = "0x29C56C0", VA = "0x1829C6CC0")]
	public static void HKEAHPJIBGG<T>(this IncrementalHash HKJNJDMHLDJ, [CanBeNull] T GPHNKOOLHHJ) where T : MFENFNEOGBG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x29C6D50", Offset = "0x29C5750", VA = "0x1829C6D50")]
	public static void KOJPPDIMKKL<T>(this IncrementalHash HKJNJDMHLDJ, [CanBeNull] IList<T> AEIECICNFJB) where T : MFENFNEOGBG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x630FC70", Offset = "0x630E670", VA = "0x18630FC70")]
	private static bool NAGNMCIPLBJ([CanBeNull] MFENFNEOGBG GPHNKOOLHHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x630F8D0", Offset = "0x630E2D0", VA = "0x18630F8D0")]
	public static void GIMJENPDKDI(this IncrementalHash NKHBKFIGNJB, [CanBeNull] string AIOGJMLIBCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x630F3A0", Offset = "0x630DDA0", VA = "0x18630F3A0")]
	public static void ACEGOEKCOAP(this IncrementalHash NKHBKFIGNJB, long AKNCLLEKLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x630FD00", Offset = "0x630E700", VA = "0x18630FD00")]
	public static void NIOJMLKEFMD(this IncrementalHash NKHBKFIGNJB, int KHBEJDJEFOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x630FAA0", Offset = "0x630E4A0", VA = "0x18630FAA0")]
	public static void KLDAOKPEJNM(this IncrementalHash NKHBKFIGNJB, short HFMPABGGHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x630F930", Offset = "0x630E330", VA = "0x18630F930")]
	public static void GPFBEJCNBMO(this IncrementalHash NKHBKFIGNJB, byte KAMPIOFCDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x630F760", Offset = "0x630E160", VA = "0x18630F760")]
	public static void ELEFKPJIOBC(this IncrementalHash NKHBKFIGNJB, bool FAGFENFHIIN, bool AAIAGFHONMC = false, bool FFLOPHHKCPF = false, bool BOEEANPNLOJ = false, bool HECKGMOKPLA = false, bool EHFOLLHEHHK = false, bool MINOKFIJPDC = false, bool MJENDLOOLBI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x29C6690", Offset = "0x29C5090", VA = "0x1829C6690")]
	public static void FHBIHOIOAKE<T>(this IncrementalHash NKHBKFIGNJB, T OPIDCOCFJHF) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x630F6A0", Offset = "0x630E0A0", VA = "0x18630F6A0")]
	public static void DACLAILEBFN(this IncrementalHash NKHBKFIGNJB, float IFMNIPAFMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x630FED0", Offset = "0x630E8D0", VA = "0x18630FED0")]
	public static void OBAGDJEFHEI(this IncrementalHash NKHBKFIGNJB, ulong JHDDMKFDPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x630FA40", Offset = "0x630E440", VA = "0x18630FA40")]
	public static void KKNCBNMEOJP(this IncrementalHash NKHBKFIGNJB, uint KODOMHIPNIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x630F700", Offset = "0x630E100", VA = "0x18630F700")]
	public static void DFIGLIPGLIJ(this IncrementalHash NKHBKFIGNJB, ushort BCNJOCGFBFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x630F570", Offset = "0x630DF70", VA = "0x18630F570")]
	public static void CNJMBANAOHN(this IncrementalHash NKHBKFIGNJB, Vector3 NMALOPDEICP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class PHBLCIBPGJM : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6310420", Offset = "0x630EE20", VA = "0x186310420")]
	public PHBLCIBPGJM(string CPPFNMDMGHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class EKMAKOEJDJI<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	internal class OEOFLNCMPEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public TNode CMJEIEIDHIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public TNode HHJLJBMAMDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public EENAHMCNHJJ DLKCOBBNNLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public List<EENAHMCNHJJ> MPDPGPJPGLL;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public OEOFLNCMPEC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal struct EENAHMCNHJJ : IComparable<EENAHMCNHJJ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int NBNHCPDHIKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public TClaimant OOLDMLFPFKO;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xC56530", Offset = "0xC54F30", VA = "0x180C56530")]
		public EENAHMCNHJJ(int NBNHCPDHIKN, TClaimant OOLDMLFPFKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x34D7D20", Offset = "0x34D6720", VA = "0x1834D7D20")]
		public bool PHLKMGAKEKN([In] EENAHMCNHJJ HKMMPHJFKEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x34D7D00", Offset = "0x34D6700", VA = "0x1834D7D00")]
		public bool CKIKCKKGMFN([In] EENAHMCNHJJ HKMMPHJFKEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x34D7D10", Offset = "0x34D6710", VA = "0x1834D7D10", Slot = "4")]
		public int CompareTo(EENAHMCNHJJ HKMMPHJFKEA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x34D7D80", Offset = "0x34D6780", VA = "0x1834D7D80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public enum IKBEPCBIIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class AJOPCPHDNJA : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
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
		public EKMAKOEJDJI<TClaimant, TNode> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x820E60", Offset = "0x81F860", VA = "0x180820E60")]
		[DebuggerHidden]
		public AJOPCPHDNJA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x39796E0", Offset = "0x39780E0", VA = "0x1839796E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x39798A0", Offset = "0x39782A0", VA = "0x1839798A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x39797C0", Offset = "0x39781C0", VA = "0x1839797C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x351A170", Offset = "0x3518B70", VA = "0x18351A170", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly PEIMMEBIMLB<OEOFLNCMPEC> NJMICGGDMHN;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly PEIMMEBIMLB<List<EENAHMCNHJJ>> AJPMDCKPABN;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static int GFGCHLPCPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	internal readonly Dictionary<TClaimant, TNode> HPPEODLKFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	internal readonly Dictionary<TNode, OEOFLNCMPEC> JDJEMJMOIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private IKBEPCBIIBJ MMMGCOBDJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private bool ODKMMAOGKAJ;

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode IGCDOLLFKEN(TNode KDIAAEPKAII);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void BCJGLJJCDFA(TNode KDIAAEPKAII, TClaimant HAMFMOKBIDB, TClaimant NFPIHOHAADH);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x351BCD0", Offset = "0x351A6D0", VA = "0x18351BCD0")]
	public EKMAKOEJDJI(IKBEPCBIIBJ MMMGCOBDJOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x351A5B0", Offset = "0x3518FB0", VA = "0x18351A5B0")]
	public void ALFNOKEPDLF(TNode KDIAAEPKAII, TNode GCDDFMLCKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x351B5F0", Offset = "0x3519FF0", VA = "0x18351B5F0")]
	public void LLCCNOGCCHL(TClaimant OOLDMLFPFKO, TNode DKIILALJDNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x351A640", Offset = "0x3519040", VA = "0x18351A640", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x351ABF0", Offset = "0x35195F0", VA = "0x18351ABF0")]
	private void HALJOPAEMAN(TClaimant OOLDMLFPFKO, TNode NPPELLCPBEB, TNode DKIILALJDNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x351B070", Offset = "0x3519A70", VA = "0x18351B070")]
	private int JKCKLNELBHE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x351A8D0", Offset = "0x35192D0", VA = "0x18351A8D0")]
	private void GGLJNDEKOHH(TClaimant OOLDMLFPFKO, TNode HPEIFOMALIH, TNode IMKPNBLFMEL, int PDFDCEFECEF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x351B940", Offset = "0x351A340", VA = "0x18351B940")]
	private void PKOJOODEEJJ(EENAHMCNHJJ MMKLILKLOEM, OEOFLNCMPEC DCIMIGOEEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x351ADB0", Offset = "0x35197B0", VA = "0x18351ADB0")]
	private void JBAOBJJJJKF(TClaimant OOLDMLFPFKO, TNode HPEIFOMALIH, TNode IMKPNBLFMEL, int PDFDCEFECEF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x351B0E0", Offset = "0x3519AE0", VA = "0x18351B0E0")]
	private void KBGLMCKKHJO(EENAHMCNHJJ MMKLILKLOEM, TNode KDIAAEPKAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x351B1F0", Offset = "0x3519BF0", VA = "0x18351B1F0")]
	private void KJEPGAMKEKL(EENAHMCNHJJ MMKLILKLOEM, OEOFLNCMPEC DCIMIGOEEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x351AC90", Offset = "0x3519690", VA = "0x18351AC90")]
	private void IOKJNHNPPNB(OEOFLNCMPEC DCIMIGOEEFD, bool OJJGNBKIBOC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x351B2D0", Offset = "0x3519CD0", VA = "0x18351B2D0")]
	private void KNHBGKMBBIE(OEOFLNCMPEC DCIMIGOEEFD, TNode GCDDFMLCKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x351B710", Offset = "0x351A110", VA = "0x18351B710")]
	[IteratorStateMachine(typeof(EKMAKOEJDJI<, >.AJOPCPHDNJA))]
	private IEnumerable<TNode> NKMPMICDHAD(TNode HPEIFOMALIH, TNode IMKPNBLFMEL, bool HEAJKPMCEMM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x351A7F0", Offset = "0x35191F0", VA = "0x18351A7F0")]
	private OEOFLNCMPEC ECNOJJMJBNP(TNode KDIAAEPKAII, TNode HHJLJBMAMDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x351B7E0", Offset = "0x351A1E0", VA = "0x18351B7E0")]
	private OEOFLNCMPEC OAJIOKJDFMK(TNode KDIAAEPKAII, TNode HHJLJBMAMDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x351B9C0", Offset = "0x351A3C0", VA = "0x18351B9C0")]
	private void PMEBHJBJGBD(OEOFLNCMPEC DCIMIGOEEFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class LCMJKNGCHHH<T> : IEnumerable<LCMJKNGCHHH<T>.HMMMHIPGBLE>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct HMMMHIPGBLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public T AEJBOLFACJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int ABBNIPHGMGH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public class EMDFJKLHOPP : IEnumerator<HMMMHIPGBLE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private LCMJKNGCHHH<T> BFHKNAPPOBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private int ABBNIPHGMGH;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x351BFC0", Offset = "0x351A9C0", VA = "0x18351BFC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public HMMMHIPGBLE EIIOCLGDIGI
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x351C120", Offset = "0x351AB20", VA = "0x18351C120", Slot = "4")]
			get
			{
				return default(HMMMHIPGBLE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x351C030", Offset = "0x351AA30", VA = "0x18351C030")]
		public EMDFJKLHOPP(LCMJKNGCHHH<T> BFHKNAPPOBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x351BE40", Offset = "0x351A840", VA = "0x18351BE40", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x351BF40", Offset = "0x351A940", VA = "0x18351BF40", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8A8380", Offset = "0x8A6D80", VA = "0x1808A8380", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private struct KCBLNDEOEDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public bool DCOCBLKDDFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public T AEJBOLFACJC;
	}

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private const int KFEMNKPNDGC = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly Dictionary<T, int> CLOEEODDGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private KCBLNDEOEDC[] BCJHHINGHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private int BHBDFKAMEKA;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int KFNDACNMKMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x802330", Offset = "0x800D30", VA = "0x180802330")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x801E10", Offset = "0x800810", VA = "0x180801E10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int IAGPAHCAHED
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x32DCC30", Offset = "0x32DB630", VA = "0x1832DCC30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x3E290C0", Offset = "0x3E27AC0", VA = "0x183E290C0")]
	public LCMJKNGCHHH(int JDNEKMCCAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x3E29190", Offset = "0x3E27B90", VA = "0x183E29190")]
	public LCMJKNGCHHH(HMMMHIPGBLE[] ANLMDLGMGKG, bool AEIAIAGGICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x3E28730", Offset = "0x3E27130", VA = "0x183E28730")]
	public int KPKPMCAEOJD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x3E28560", Offset = "0x3E26F60", VA = "0x183E28560")]
	private int KIFBFFJGONM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x3E28080", Offset = "0x3E26A80", VA = "0x183E28080", Slot = "6")]
	protected virtual uint ADOBPICADCG(uint NKHBKFIGNJB, T AEJBOLFACJC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x3E28110", Offset = "0x3E26B10", VA = "0x183E28110")]
	public bool DEKGIPHGOOI(T AEJBOLFACJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x3E28320", Offset = "0x3E26D20", VA = "0x183E28320")]
	public int JFGPHPKIMNL(T AEJBOLFACJC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x3E28250", Offset = "0x3E26C50", VA = "0x183E28250")]
	public T GOLKKAOHAMH(int ABBNIPHGMGH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x3E289B0", Offset = "0x3E273B0", VA = "0x183E289B0")]
	public bool MFACCNDNDKF(T AEJBOLFACJC, bool NIDFPJKIMDB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x3E287B0", Offset = "0x3E271B0", VA = "0x183E287B0")]
	public bool MFACCNDNDKF(T AEJBOLFACJC, int ABBNIPHGMGH, bool NIDFPJKIMDB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x3E28160", Offset = "0x3E26B60", VA = "0x183E28160")]
	private int EOIKKMMJLFL(int ALMDOMLFINK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x3E28C90", Offset = "0x3E27690", VA = "0x183E28C90", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x3E28C90", Offset = "0x3E27690", VA = "0x183E28C90", Slot = "4")]
	private IEnumerator<HMMMHIPGBLE> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class PEIMMEBIMLB<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly Stack<T> NKBBNCALGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly List<T> ABNJBCGGJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly int GKBLCPHJAAA;

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x42ED290", Offset = "0x42EBC90", VA = "0x1842ED290")]
	public static PEIMMEBIMLB<T> OBJMPBOBJJJ(int JDNEKMCCAKP = 0, int GKBLCPHJAAA = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x42ECB70", Offset = "0x42EB570", VA = "0x1842ECB70")]
	public static PEIMMEBIMLB<T> BEAICMAPCFF(int JDNEKMCCAKP = 0, int GKBLCPHJAAA = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x42ED370", Offset = "0x42EBD70", VA = "0x1842ED370")]
	public PEIMMEBIMLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x42ED3A0", Offset = "0x42EBDA0", VA = "0x1842ED3A0")]
	public PEIMMEBIMLB(int JDNEKMCCAKP, int GKBLCPHJAAA = int.MaxValue, bool EFPDGAMHGDD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x42ECF40", Offset = "0x42EB940", VA = "0x1842ECF40")]
	public T HFIKCANMJDK()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x42ECC70", Offset = "0x42EB670", VA = "0x1842ECC70")]
	public void DMFHFELNIKK(T AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x42ECE70", Offset = "0x42EB870", VA = "0x1842ECE70")]
	private void EJMOICPANMC(T AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x42ECC50", Offset = "0x42EB650", VA = "0x1842ECC50")]
	private void BFFKMFAJIHH(T AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x42ECD40", Offset = "0x42EB740", VA = "0x1842ECD40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x42ED0A0", Offset = "0x42EBAA0", VA = "0x1842ED0A0")]
	private void IKGJMOHEJBF(IEnumerable<T> KCNHIGOABNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class JKCLLKPEPIP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private Dictionary<int, T> CGFGKINIJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private T NCCEBHMIAEB;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual T KMMOAJKONIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7C4AA0", Offset = "0x7C34A0", VA = "0x1807C4AA0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x3C80BC0", Offset = "0x3C7F5C0", VA = "0x183C80BC0")]
	public bool NPBIGPPLMMP(T AEJBOLFACJC, int NBNHCPDHIKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x3C80750", Offset = "0x3C7F150", VA = "0x183C80750")]
	public bool FKIPJHLLKAC(int NBNHCPDHIKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x3C807B0", Offset = "0x3C7F1B0", VA = "0x183C807B0")]
	public T IIGKHEKKJPF(int FMPKAJKNNPH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x3C806C0", Offset = "0x3C7F0C0", VA = "0x183C806C0")]
	private bool ABJAEAGLMBL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x3C80C30", Offset = "0x3C7F630", VA = "0x183C80C30")]
	public bool PJCFHHABBNE(int NBNHCPDHIKN, [Out] T AEJBOLFACJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x3C80C70", Offset = "0x3C7F670", VA = "0x183C80C70")]
	public JKCLLKPEPIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class HOJOGOEGCAC<T>
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	protected struct IJHENADNLCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public T DPMGLPAKGNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public int IJONMJDGNBP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	protected readonly List<IJHENADNLCL> IHGGEODABFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private T AOHKBDKBKNB;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int IAGPAHCAHED
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x32DCC30", Offset = "0x32DB630", VA = "0x1832DCC30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x3A0CDD0", Offset = "0x3A0B7D0", VA = "0x183A0CDD0")]
	public bool OBHCHEDFPHH(T AEJBOLFACJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x3A0C9C0", Offset = "0x3A0B3C0", VA = "0x183A0C9C0")]
	public void BIPEDCDHLGG(T AEJBOLFACJC, int NBNHCPDHIKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x3A0CB40", Offset = "0x3A0B540", VA = "0x183A0CB40")]
	public bool MDELFCPLFEE(T AEJBOLFACJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x3A0CAE0", Offset = "0x3A0B4E0", VA = "0x183A0CAE0")]
	public void LDCFGOINEDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x3A0CA60", Offset = "0x3A0B460", VA = "0x183A0CA60")]
	public T GCBCLLADLOD()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x3A0CC70", Offset = "0x3A0B670", VA = "0x183A0CC70")]
	private void MECNIFCFBML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x3A0CF40", Offset = "0x3A0B940", VA = "0x183A0CF40")]
	public HOJOGOEGCAC()
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
		[JBAFOAIPPLI(PHOLEAOCMFP.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x63105C0", Offset = "0x630EFC0", VA = "0x1863105C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x6310890", Offset = "0x630F290", VA = "0x186310890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x63107A0", Offset = "0x630F1A0", VA = "0x1863107A0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x6310510", Offset = "0x630EF10", VA = "0x186310510")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x63107E0", Offset = "0x630F1E0", VA = "0x1863107E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x63106F0", Offset = "0x630F0F0", VA = "0x1863106F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x6310480", Offset = "0x630EE80", VA = "0x186310480")]
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
		[Cpp2IlInjected.Address(RVA = "0x449D360", Offset = "0x449BD60", VA = "0x18449D360", Slot = "4")]
		public virtual T NOKHAOOKKHP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class AOKFLBHMIEG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private Dictionary<byte, CJIBKDMMLNI> MJLKIHDNECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly PEIMMEBIMLB<CJIBKDMMLNI> IEKABPIOBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly bool LMIMELPPOKM;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public CJIBKDMMLNI MBHDLJAPJLK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7C4FA0", Offset = "0x7C39A0", VA = "0x1807C4FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public Vector2 PGIHFBBDDJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xBDADC0", Offset = "0xBD97C0", VA = "0x180BDADC0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xEC86E0", Offset = "0xEC70E0", VA = "0x180EC86E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private Vector2 LNMDAHHPEAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xF407B0", Offset = "0xF3F1B0", VA = "0x180F407B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public Vector2 PFLMEOEJEJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x630D800", Offset = "0x630C200", VA = "0x18630D800")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7C9BE0", Offset = "0x7C85E0", VA = "0x1807C9BE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public int JOODEFJIIBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7C5520", Offset = "0x7C3F20", VA = "0x1807C5520")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C3EF0", VA = "0x1807C54F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x630E030", Offset = "0x630CA30", VA = "0x18630E030")]
	public AOKFLBHMIEG(Bounds KOALGBFPCKM, Vector2[] FEAFOLHCNKD, int LJCJNIBMGKO, byte ALMDOMLFINK, float MDGDLCEEDOD = 0f, [Optional] PEIMMEBIMLB<CJIBKDMMLNI> IEKABPIOBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x630D360", Offset = "0x630BD60", VA = "0x18630D360")]
	public void HELADBNALDD(Bounds KOALGBFPCKM, Vector2[] FEAFOLHCNKD, int LJCJNIBMGKO, byte ALMDOMLFINK, float MDGDLCEEDOD = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x630DFD0", Offset = "0x630C9D0", VA = "0x18630DFD0")]
	public CJIBKDMMLNI OFKHCHNMPKG(byte ABBNIPHGMGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x630DBF0", Offset = "0x630C5F0", VA = "0x18630DBF0")]
	public void JFGBIBKHLDN(Vector3 DGOJEOCFHHN, float CJHHFNJDDNG, float JIGHINHOKFP, List<byte> DHJNAICJBKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x630DBD0", Offset = "0x630C5D0", VA = "0x18630DBD0")]
	public void IICGJHAIMED(CJIBKDMMLNI.KPBLHFCEKFA GPEPDIFJIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x630DCC0", Offset = "0x630C6C0", VA = "0x18630DCC0")]
	public static int KCPHODKCFGD(Vector2[] FEAFOLHCNKD, int LJCJNIBMGKO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x630D100", Offset = "0x630BB00", VA = "0x18630D100")]
	private CJIBKDMMLNI FAALHKALMOM(byte ABBNIPHGMGH, CJIBKDMMLNI.DHNGPHEDHJI DDINPOOAFHC, CJIBKDMMLNI HHJLJBMAMDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x630D820", Offset = "0x630C220", VA = "0x18630D820")]
	private void ICHFIGCEIFP(CJIBKDMMLNI HHJLJBMAMDD, Vector2[] FEAFOLHCNKD, int AEMEDNFKNMC, int IHANEJMOBPC, int BMAMDLAOLCK, int EGDHGFNPDFJ, float MDGDLCEEDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x630DDB0", Offset = "0x630C7B0", VA = "0x18630DDB0")]
	private void NLIPOCJNKKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x630D0A0", Offset = "0x630BAA0", VA = "0x18630D0A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x630D300", Offset = "0x630BD00", VA = "0x18630D300", Slot = "1")]
	~AOKFLBHMIEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class CJIBKDMMLNI
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public enum DHNGPHEDHJI
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public enum KPBLHFCEKFA
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
	public byte PHMNCFOHEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public Vector3 JHNCLCOKNJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public Vector3 LIKCBNMIJLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public Vector3 EINBLJAIJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public Vector3 NMEKCOBAIBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public DHNGPHEDHJI FABBILCAECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public CJIBKDMMLNI OCIMJODBDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public List<CJIBKDMMLNI> HBOIJAFCCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public bool IEBJBCEHJOA;

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x630E5F0", Offset = "0x630CFF0", VA = "0x18630E5F0")]
	public CJIBKDMMLNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x630E180", Offset = "0x630CB80", VA = "0x18630E180")]
	public void HMKOOHPFFKM(CJIBKDMMLNI APJECMEEJIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0")]
	public void IICGJHAIMED(int FANGFCGOMOH, KPBLHFCEKFA GPEPDIFJIKE, int LDPLJMEDBBK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x630E2D0", Offset = "0x630CCD0", VA = "0x18630E2D0")]
	public void JFGBIBKHLDN(List<byte> DHJNAICJBKI, Vector3 DGOJEOCFHHN, float CJHHFNJDDNG, float JIGHINHOKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x630E2A0", Offset = "0x630CCA0", VA = "0x18630E2A0")]
	public bool IJECJMCKENK(Vector3 OENLNJOIKNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x630E530", Offset = "0x630CF30", VA = "0x18630E530")]
	public bool JPDJEGJCLND(Vector3 OENLNJOIKNJ, float AAOMJLHIIDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x630E560", Offset = "0x630CF60", VA = "0x18630E560")]
	public void MPOMBMILLLK()
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
		public struct BEJBAAJJENB<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			private readonly List<Component> GOJPHGMMOOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			private readonly bool IDFHGKJGPOP;

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x397D9B0", Offset = "0x397C3B0", VA = "0x18397D9B0")]
			public BEJBAAJJENB(List<Component> GOJPHGMMOOM, bool IDFHGKJGPOP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x493DF40", Offset = "0x493C940", VA = "0x18493DF40")]
			public KBAGPJPGCFH<T> HOEJGHKHDAP()
			{
				return default(KBAGPJPGCFH<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x493DFA0", Offset = "0x493C9A0", VA = "0x18493DFA0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x493DFA0", Offset = "0x493C9A0", VA = "0x18493DFA0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		public struct KBAGPJPGCFH<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			private readonly List<Component> GOJPHGMMOOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			private readonly bool IDFHGKJGPOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			private int ABBNIPHGMGH;

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			public T EIIOCLGDIGI
			{
				[Cpp2IlInjected.Token(Token = "0x60001F9")]
				[Cpp2IlInjected.Address(RVA = "0x3D50240", Offset = "0x3D4EC40", VA = "0x183D50240", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001FA")]
				[Cpp2IlInjected.Address(RVA = "0x3D501D0", Offset = "0x3D4EBD0", VA = "0x183D501D0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x3D50210", Offset = "0x3D4EC10", VA = "0x183D50210")]
			public KBAGPJPGCFH(List<Component> GOJPHGMMOOM, bool IDFHGKJGPOP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x3D50110", Offset = "0x3D4EB10", VA = "0x183D50110", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x3D50120", Offset = "0x3D4EB20", VA = "0x183D50120", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x3576600", Offset = "0x3575000", VA = "0x183576600", Slot = "8")]
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

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x6311EB0", Offset = "0x63108B0", VA = "0x186311EB0")]
		private void MPOMBMILLLK(GameObject BGNGBPICAOC, bool AHPBABJEPBH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x6311CF0", Offset = "0x63106F0", VA = "0x186311CF0")]
		public static void MPOMBMILLLK(GameObject BGNGBPICAOC, ToolHierarchyCache OALDLMHJPOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x2C15610", Offset = "0x2C14010", VA = "0x182C15610")]
		public void NLAPKEKIEIJ<T>(Action<T> HKIJJKKNOIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x2C154E0", Offset = "0x2C13EE0", VA = "0x182C154E0")]
		public T CMHNCPENAKM<T>(bool IDFHGKJGPOP = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x2C15550", Offset = "0x2C13F50", VA = "0x182C15550")]
		public BEJBAAJJENB<T> IIPAHMOBPNC<T>(bool IDFHGKJGPOP = false) where T : class
		{
			return default(BEJBAAJJENB<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x6312020", Offset = "0x6310A20", VA = "0x186312020")]
		public List<Component> NIBHLGIENCA(Type CGEOAHHPHHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x6311C00", Offset = "0x6310600", VA = "0x186311C00", Slot = "4")]
		public bool Equals(ToolHierarchyCache HMCMBMJNNLE, ToolHierarchyCache EGPNAKGBGLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x6311C80", Offset = "0x6310680", VA = "0x186311C80", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache COMOOAEHALC)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class IEMHPKFCFGG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private int JDNEKMCCAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private int PDCHMCGEDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private List<T> FFBCCHKMKPB;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int IAGPAHCAHED
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3A0D050", Offset = "0x3A0BA50", VA = "0x183A0D050")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public T CAFNOMJCOAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x3AAB340", Offset = "0x3AA9D40", VA = "0x183AAB340")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public T EHCEAJHGMNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3AAB280", Offset = "0x3AA9C80", VA = "0x183AAB280")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public T JBOMLEOPKIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3AAB0A0", Offset = "0x3AA9AA0", VA = "0x183AAB0A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x3AAB4D0", Offset = "0x3AA9ED0", VA = "0x183AAB4D0")]
	public IEMHPKFCFGG(int JDNEKMCCAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x3AAAFB0", Offset = "0x3AA99B0", VA = "0x183AAAFB0")]
	public void BIPEDCDHLGG(T HJJMAGNDANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x3AAB490", Offset = "0x3AA9E90", VA = "0x183AAB490")]
	public void LDCFGOINEDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x3AAB160", Offset = "0x3AA9B60", VA = "0x183AAB160")]
	public void ICFHHCAGCLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x3AAB230", Offset = "0x3AA9C30", VA = "0x183AAB230")]
	public void JIAMOJPDNDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x3AAB220", Offset = "0x3AA9C20", VA = "0x183AAB220")]
	public void JDAEPIEPGHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class OBLDBHPKJKC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private struct MJGAEBCBOEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public int IJONMJDGNBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public T DPMGLPAKGNP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly Dictionary<object, MJGAEBCBOEK> CGFGKINIJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly EqualityComparer<T> KIIHGDMMHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private T NCCEBHMIAEB;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public virtual T KMMOAJKONIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x1056740", Offset = "0x1055140", VA = "0x181056740", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x41FE090", Offset = "0x41FCA90", VA = "0x1841FE090", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool CHJPLJCBCNN
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x41FD5D0", Offset = "0x41FBFD0", VA = "0x1841FD5D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public object OAAKCDNMBPH
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7C8FA0", Offset = "0x7C79A0", VA = "0x1807C8FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x41FD6C0", Offset = "0x41FC0C0", VA = "0x1841FD6C0")]
	public bool NPBIGPPLMMP(T AEJBOLFACJC, object AIDIDMJCFEK, int NBNHCPDHIKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x41FD610", Offset = "0x41FC010", VA = "0x1841FD610")]
	public bool FKIPJHLLKAC(object AIDIDMJCFEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x41FE4F0", Offset = "0x41FCEF0", VA = "0x1841FE4F0")]
	public bool PJCFHHABBNE(object AIDIDMJCFEK, [Out] T AEJBOLFACJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x41FD690", Offset = "0x41FC090", VA = "0x1841FD690")]
	public void LDCFGOINEDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x41FB890", Offset = "0x41FA290", VA = "0x1841FB890")]
	private bool ABJAEAGLMBL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x41FE8D0", Offset = "0x41FD2D0", VA = "0x1841FE8D0")]
	public OBLDBHPKJKC()
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
