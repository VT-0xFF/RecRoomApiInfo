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
		[Cpp2IlInjected.Address(RVA = "0x876AF0", Offset = "0x8754F0", VA = "0x180876AF0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x689CF60", Offset = "0x689B960", VA = "0x18689CF60")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8775C0", Offset = "0x875FC0", VA = "0x1808775C0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x877600", Offset = "0x876000", VA = "0x180877600")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class LNNBNNOKPFO : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x14C46D0", Offset = "0x14C30D0", VA = "0x1814C46D0")]
	public LNNBNNOKPFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, GAPMKMHMAPO, LCBACAIGJGJ, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x84EC00", Offset = "0x84D600", VA = "0x18084EC00", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x850E50", Offset = "0x84F850", VA = "0x180850E50", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x850E40", Offset = "0x84F840", VA = "0x180850E40", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x915430", Offset = "0x913E30", VA = "0x180915430", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash JAJGGBFDMEJ);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8BBBC0", Offset = "0x8BA5C0", VA = "0x1808BBBC0")]
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
	[HideInInspector]
	[ReadOnlyField]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x689F500", Offset = "0x689DF00", VA = "0x18689F500")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x689F4C0", Offset = "0x689DEC0", VA = "0x18689F4C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x689F540", Offset = "0x689DF40", VA = "0x18689F540")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x689F6F0", Offset = "0x689E0F0", VA = "0x18689F6F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x689F660", Offset = "0x689E060", VA = "0x18689F660")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8BBBB0", Offset = "0x8BA5B0", VA = "0x1808BBBB0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB70", Offset = "0x8BA570", VA = "0x1808BBB70")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x689F480", Offset = "0x689DE80", VA = "0x18689F480")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x689F5D0", Offset = "0x689DFD0", VA = "0x18689F5D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x689EEF0", Offset = "0x689D8F0", VA = "0x18689EEF0")]
	public void CopyBounds(SavedExtents HENLEJBGFIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x689F3D0", Offset = "0x689DDD0", VA = "0x18689F3D0")]
	public void SetLocalSpaceBounds(Bounds MLDDEDEPBMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xBA9F90", Offset = "0xBA8990", VA = "0x180BA9F90")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x689F3C0", Offset = "0x689DDC0", VA = "0x18689F3C0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x689EF20", Offset = "0x689D920", VA = "0x18689EF20")]
	private void JMGJCAJEKDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x689F1A0", Offset = "0x689DBA0", VA = "0x18689F1A0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x689E880", Offset = "0x689D280", VA = "0x18689E880")]
	public static void CalculateLocalBoundsFor(GameObject AOOABPFBFDN, [Out] Bounds MLDDEDEPBMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x689F0E0", Offset = "0x689DAE0", VA = "0x18689F0E0")]
	private static void NECPBCDPJOM(Bounds JCAJPPHEFGK, Color PEJELGOBPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x689F3F0", Offset = "0x689DDF0", VA = "0x18689F3F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x84C1A0", Offset = "0x84ABA0", VA = "0x18084C1A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x856690", Offset = "0x855090", VA = "0x180856690")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xFC1950", Offset = "0xFC0350", VA = "0x180FC1950")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4920B80", Offset = "0x491F580", VA = "0x184920B80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "4")]
	public virtual void NFIFMNOPHHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
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
	[SerializeField]
	[LNNBNNOKPFO]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x49206F0", Offset = "0x491F0F0", VA = "0x1849206F0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x491EEB0", Offset = "0x491D8B0", VA = "0x18491EEB0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4920A80", Offset = "0x491F480", VA = "0x184920A80")]
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
	private sealed class PLHAMJHPEEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public PLHAMJHPEEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x46DCF50", Offset = "0x46DB950", VA = "0x1846DCF50")]
		internal int FOBOMGEGJMD(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[LNNBNNOKPFO]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3889770", Offset = "0x3888170", VA = "0x183889770", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x38897D0", Offset = "0x38881D0", VA = "0x1838897D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3889650", Offset = "0x3888050", VA = "0x183889650", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey LDDEKIBHION]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3889710", Offset = "0x3888110", VA = "0x183889710", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3889500", Offset = "0x3887F00", VA = "0x183889500", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x38891C0", Offset = "0x3887BC0", VA = "0x1838891C0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x38885F0", Offset = "0x3886FF0", VA = "0x1838885F0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3888590", Offset = "0x3886F90", VA = "0x183888590", Slot = "14")]
	protected virtual string HGOHNBLHKAH(TKeyVal OJHHAMBPONB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3888460", Offset = "0x3886E60", VA = "0x183888460", Slot = "4")]
	public bool ContainsKey(TKey LDDEKIBHION)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3889380", Offset = "0x3887D80", VA = "0x183889380", Slot = "5")]
	public bool TryGetValue(TKey LDDEKIBHION, [Out] TVal DBOBEHLEAAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x38884C0", Offset = "0x3886EC0", VA = "0x1838884C0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x38884C0", Offset = "0x3886EC0", VA = "0x1838884C0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x38893E0", Offset = "0x3887DE0", VA = "0x1838893E0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class IPCMMBENLKO<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class EHGCNBNPMPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public float ACMGCLBIHOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public T NHLIMKDHAIB;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public EHGCNBNPMPP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class GJMJGHPKPLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public GJMJGHPKPLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3D370E0", Offset = "0x3D35AE0", VA = "0x183D370E0")]
		internal bool CAFLIHCEIMC(EHGCNBNPMPP sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly float LENJNOEJOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly float GJLLIHENIHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<EHGCNBNPMPP> KPHAMNEGKML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private FAPICAHKDGJ<EHGCNBNPMPP> JFDFOFMKJPJ;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int BLJJLGJOKKK
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3EAD550", Offset = "0x3EABF50", VA = "0x183EAD550")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3EADB00", Offset = "0x3EAC500", VA = "0x183EADB00")]
	public IPCMMBENLKO(float EIILDBHNGKP, float GIKIGCIGKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3EAD5C0", Offset = "0x3EABFC0", VA = "0x183EAD5C0")]
	public bool NDGFKFCFDLK(float DIGHAFDHPKH, T DBOBEHLEAAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3EACD50", Offset = "0x3EAB750", VA = "0x183EACD50")]
	public IEnumerable<T> BGJLKJCFIAH(float DIGHAFDHPKH, [Optional] float? JBIIMCDPNCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3EAD430", Offset = "0x3EABE30", VA = "0x183EAD430")]
	public void EIMPLACCFNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3EAD950", Offset = "0x3EAC350", VA = "0x183EAD950")]
	private void ODHMNCGPKDI(float DIGHAFDHPKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class JAACAOBEHEA<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct MBJOCFFAPBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public T NHLIMKDHAIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public float KKGCHBOKDPE;
	}

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static float OFGAMFJIMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private List<T> COBPAANNKOE;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private const int FJFFIKBPMAL = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private MBJOCFFAPBL[] MHMBNFEOIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int KILDLGEEDAH;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float JFPLLPMCHGN
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x986CE0", Offset = "0x9856E0", VA = "0x180986CE0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9A5DA0", Offset = "0x9A47A0", VA = "0x1809A5DA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x403A460", Offset = "0x4038E60", VA = "0x18403A460")]
	public JAACAOBEHEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x403A330", Offset = "0x4038D30", VA = "0x18403A330")]
	public JAACAOBEHEA(int BKEGNEKBPFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x403A190", Offset = "0x4038B90", VA = "0x18403A190")]
	public void KODKNHDNNHA(float DIGHAFDHPKH, T DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4039D50", Offset = "0x4038750", VA = "0x184039D50")]
	public void EIMPLACCFNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4039B00", Offset = "0x4038500", VA = "0x184039B00")]
	public bool EEDDDKMGMBN(float BGLJOMDLLPF, float JDLDHBJAKDH, [Out] T DBOBEHLEAAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4039E40", Offset = "0x4038840", VA = "0x184039E40")]
	public bool FCOFCIOAAAL(float BGLJOMDLLPF, float JDLDHBJAKDH, [Out] T DBOBEHLEAAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x403A010", Offset = "0x4038A10", VA = "0x18403A010")]
	public void HJGBHNKEGCD(float BGLJOMDLLPF, float JDLDHBJAKDH, List<T> BLNHMFAPOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x403A2A0", Offset = "0x4038CA0", VA = "0x18403A2A0")]
	private int ODDJMFMFOCA(int GEBLIGMMHGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4039AB0", Offset = "0x40384B0", VA = "0x184039AB0")]
	private void ACDLOBKAJNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T KHHJDGKOOJI();

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T CEICIFJLDCJ(T DBOBEHLEAAE, float FOCADABILLC);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T DIAFEBBFGBP(T NNEJNMNIIPM, T MENCHHOFOIO);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T MPPCKPHNLNH(T NNEJNMNIIPM, T MENCHHOFOIO);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class IHBODGPIPNI : JAACAOBEHEA<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x85CCE0", Offset = "0x85B6E0", VA = "0x18085CCE0", Slot = "4")]
	protected override Vector3 KHHJDGKOOJI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x689CA60", Offset = "0x689B460", VA = "0x18689CA60", Slot = "5")]
	protected override Vector3 CEICIFJLDCJ(Vector3 DBOBEHLEAAE, float FOCADABILLC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x689CAA0", Offset = "0x689B4A0", VA = "0x18689CAA0", Slot = "6")]
	protected override Vector3 DIAFEBBFGBP(Vector3 NNEJNMNIIPM, Vector3 MENCHHOFOIO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x689CAF0", Offset = "0x689B4F0", VA = "0x18689CAF0", Slot = "7")]
	protected override Vector3 MPPCKPHNLNH(Vector3 NNEJNMNIIPM, Vector3 MENCHHOFOIO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x689CB70", Offset = "0x689B570", VA = "0x18689CB70")]
	public IHBODGPIPNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class JFMBBKHMGOO
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A570", Offset = "0x2B78F70", VA = "0x182B7A570")]
	public static OCFNCIBPGEJ<T1, T2> CBNOJCEAKCL<T1, T2>(T1 DLFNDKFHNEJ, T2 MPDGAPIOBJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A610", Offset = "0x2B79010", VA = "0x182B7A610")]
	public static AGOKKIJLCII<T1, T2, T3> CBNOJCEAKCL<T1, T2, T3>(T1 DLFNDKFHNEJ, T2 MPDGAPIOBJB, T3 CNMOIDIFENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x44B9440", Offset = "0x44B7E40", VA = "0x1844B9440")]
	internal static int ACIHHMKAONN(int OFLJKPNJLGO, int NJFBMCOHKLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5C5ACD0", Offset = "0x5C596D0", VA = "0x185C5ACD0")]
	internal static int ACIHHMKAONN(int OFLJKPNJLGO, int NJFBMCOHKLI, int BFMFDEMHHHA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class OCFNCIBPGEJ<T1, T2> : IComparable<OCFNCIBPGEJ<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly T1 KPHAKHELKOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly T2 GNPJGEDMEGC;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x45F87C0", Offset = "0x45F71C0", VA = "0x1845F87C0")]
	public OCFNCIBPGEJ(T1 DLFNDKFHNEJ, T2 MPDGAPIOBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x45F6B50", Offset = "0x45F5550", VA = "0x1845F6B50", Slot = "4")]
	public int CompareTo(OCFNCIBPGEJ<T1, T2> HENLEJBGFIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x45F71C0", Offset = "0x45F5BC0", VA = "0x1845F71C0", Slot = "0")]
	public override bool Equals(object HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x45F7A60", Offset = "0x45F6460", VA = "0x1845F7A60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x45F8310", Offset = "0x45F6D10", VA = "0x1845F8310", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class AGOKKIJLCII<T1, T2, T3> : IComparable<AGOKKIJLCII<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly T1 KPHAKHELKOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly T2 GNPJGEDMEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly T3 AHLGJLBDBKD;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3CDB4C0", Offset = "0x3CD9EC0", VA = "0x183CDB4C0")]
	public AGOKKIJLCII(T1 DLFNDKFHNEJ, T2 MPDGAPIOBJB, T3 CNMOIDIFENP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3CDAB90", Offset = "0x3CD9590", VA = "0x183CDAB90", Slot = "4")]
	public int CompareTo(AGOKKIJLCII<T1, T2, T3> HENLEJBGFIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3CDAE40", Offset = "0x3CD9840", VA = "0x183CDAE40", Slot = "0")]
	public override bool Equals(object HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3CDB0D0", Offset = "0x3CD9AD0", VA = "0x183CDB0D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3CDB310", Offset = "0x3CD9D10", VA = "0x183CDB310", Slot = "3")]
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
	public T NHLIMKDHAIB
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x22F3730", Offset = "0x22F2130", VA = "0x1822F3730")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x22F3740", Offset = "0x22F2140", VA = "0x1822F3740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float IOBCEHKDHOM
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB10", Offset = "0x8BA510", VA = "0x1808BBB10")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4B5CE40", Offset = "0x4B5B840", VA = "0x184B5CE40")]
	public T IMAFJACPPIA(float FOCADABILLC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4B5CBE0", Offset = "0x4B5B5E0", VA = "0x184B5CBE0")]
	public T EPFPGMHAHLO(float FOCADABILLC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T MGIFAAKIGOL(T NNEJNMNIIPM, T MENCHHOFOIO, float FOCADABILLC);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x689BD40", Offset = "0x689A740", VA = "0x18689BD40", Slot = "4")]
	protected override float MGIFAAKIGOL(float NNEJNMNIIPM, float MENCHHOFOIO, float FOCADABILLC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x689BD80", Offset = "0x689A780", VA = "0x18689BD80")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xE72170", Offset = "0xE70B70", VA = "0x180E72170", Slot = "4")]
	protected override Vector3 MGIFAAKIGOL(Vector3 NNEJNMNIIPM, Vector3 MENCHHOFOIO, float FOCADABILLC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x68A0330", Offset = "0x689ED30", VA = "0x1868A0330")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x689B980", Offset = "0x689A380", VA = "0x18689B980", Slot = "4")]
	protected override Color MGIFAAKIGOL(Color NNEJNMNIIPM, Color MENCHHOFOIO, float FOCADABILLC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x689BA40", Offset = "0x689A440", VA = "0x18689BA40")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class AACAOFJOJMF : MCOIIBJFDAM<string>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x689AEC0", Offset = "0x68998C0", VA = "0x18689AEC0")]
	public AACAOFJOJMF(int OLPFIFFGHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x689AE50", Offset = "0x6899850", VA = "0x18689AE50", Slot = "6")]
	protected override uint MLFLIKABEFP(uint JAJGGBFDMEJ, string DBOBEHLEAAE)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class DIBEMDLAKDP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly IDisposable OHJMENPNAKB;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public DIBEMDLAKDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct DCPCFGAKLAJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> GNLLPGGDIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int MBFDELOOIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int HOPLJGIDIML;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3D292F0", Offset = "0x3D27CF0", VA = "0x183D292F0")]
	private DCPCFGAKLAJ(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> GHLNEIMKDAA, int OJMECIMOALE, int JPDDLNHOEAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5762360", Offset = "0x5760D60", VA = "0x185762360")]
	public static DCPCFGAKLAJ<T> KHKANEAPNIK()
	{
		return default(DCPCFGAKLAJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x57639C0", Offset = "0x57623C0", VA = "0x1857639C0")]
	public (int, int, Task<T>) PNFDAPHOJMO(int IOILMCLNKLG, [Optional] CancellationToken AOLOJHLCMLE, double PBLACMAEFME = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5761D80", Offset = "0x5760780", VA = "0x185761D80")]
	public void EFKFAMBLLGK(int IOILMCLNKLG, int JPDDLNHOEAE, [In] T EBPHIJANMPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class OFMKNLKOHGK
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x689D060", Offset = "0x689BA60", VA = "0x18689D060")]
	public static DCPCFGAKLAJ<LMMCANLFCCL> KHKANEAPNIK()
	{
		return default(DCPCFGAKLAJ<LMMCANLFCCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x689CFE0", Offset = "0x689B9E0", VA = "0x18689CFE0")]
	public static void EFKFAMBLLGK([In] this DCPCFGAKLAJ<LMMCANLFCCL> BBCPNLGGBMJ, int IOILMCLNKLG, int JPDDLNHOEAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class PINJDEFJIPF<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<TKey, TVal> OKENDLJHAAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly Dictionary<TVal, TKey> CBJNNIGKLJG;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int BGDNEMFMALE
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3563C40", Offset = "0x3562640", VA = "0x183563C40", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool DODHMAHIADE
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ICollection<TKey> JDHEAGIPOBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3C341D0", Offset = "0x3C32BD0", VA = "0x183C341D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ICollection<TVal> CJDGMCBMBLK
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x42A2B60", Offset = "0x42A1560", VA = "0x1842A2B60", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TVal PBAJKHBLIBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x46D31E0", Offset = "0x46D1BE0", VA = "0x1846D31E0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x46D3240", Offset = "0x46D1C40", VA = "0x1846D3240", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey PBAJKHBLIBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x46D2920", Offset = "0x46D1320", VA = "0x1846D2920")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x46D2450", Offset = "0x46D0E50", VA = "0x1846D2450", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x46D2FC0", Offset = "0x46D19C0", VA = "0x1846D2FC0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x46D2050", Offset = "0x46D0A50", VA = "0x1846D2050", Slot = "9")]
	public void Add(TKey LDDEKIBHION, TVal DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x46D20A0", Offset = "0x46D0AA0", VA = "0x1846D20A0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> IMMLPPOHEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3DAEB90", Offset = "0x3DAD590", VA = "0x183DAEB90", Slot = "8")]
	public bool ContainsKey(TKey LDDEKIBHION)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x46D24F0", Offset = "0x46D0EF0", VA = "0x1846D24F0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> IMMLPPOHEAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x46D2EF0", Offset = "0x46D18F0", VA = "0x1846D2EF0", Slot = "10")]
	public bool Remove(TKey LDDEKIBHION)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x46D2F30", Offset = "0x46D1930", VA = "0x1846D2F30", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> IMMLPPOHEAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x46D3060", Offset = "0x46D1A60", VA = "0x1846D3060", Slot = "11")]
	public bool TryGetValue(TKey LDDEKIBHION, [Out] TVal DBOBEHLEAAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x46D2CC0", Offset = "0x46D16C0", VA = "0x1846D2CC0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x46D25B0", Offset = "0x46D0FB0", VA = "0x1846D25B0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] MHMBNFEOIBK, int KJCAHDMHMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x46D2E50", Offset = "0x46D1850", VA = "0x1846D2E50")]
	public bool NMDJKMBCDDJ(TVal LDDEKIBHION, [Out] TKey DBOBEHLEAAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x46D2630", Offset = "0x46D1030", VA = "0x1846D2630")]
	private void EJPOONGMBDG(TKey LDDEKIBHION, TVal EHIEOLDDJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x46D21C0", Offset = "0x46D0BC0", VA = "0x1846D21C0")]
	private void CKEPPAMNMJF(TKey LDDEKIBHION, TVal EHIEOLDDJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x46D2980", Offset = "0x46D1380", VA = "0x1846D2980")]
	private bool GPJPHJANEMD(TKey LDDEKIBHION)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x46D30C0", Offset = "0x46D1AC0", VA = "0x1846D30C0")]
	public PINJDEFJIPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[DefaultMember("Item")]
public class AIOEOCPOGPH<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private AIOEOCPOGPH<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x38D5B00", Offset = "0x38D4500", VA = "0x1838D5B00", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x38E0110", Offset = "0x38DEB10", VA = "0x1838E0110", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x38E0490", Offset = "0x38DEE90", VA = "0x1838E0490")]
		public Enumerator(AIOEOCPOGPH<T> BLNHMFAPOOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x38DE740", Offset = "0x38DD140", VA = "0x1838DE740", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x38DEE30", Offset = "0x38DD830", VA = "0x1838DEE30", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x38DDF60", Offset = "0x38DC960", VA = "0x1838DDF60")]
		private void IJMMGPEFNGH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private T[] LHIBAIKPHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private int PFNBAEBFNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private int HKIJEAMDPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int OKMBFDMPMHM;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int BGDNEMFMALE
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3CE7B20", Offset = "0x3CE6520", VA = "0x183CE7B20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T PBAJKHBLIBN
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x3CE7E20", Offset = "0x3CE6820", VA = "0x183CE7E20")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x3CE7A70", Offset = "0x3CE6470", VA = "0x183CE7A70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3CE81C0", Offset = "0x3CE6BC0", VA = "0x183CE81C0")]
	public AIOEOCPOGPH(int OLPFIFFGHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3CE7EF0", Offset = "0x3CE68F0", VA = "0x183CE7EF0")]
	public void KODKNHDNNHA(T FOCADABILLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3CE7E00", Offset = "0x3CE6800", VA = "0x183CE7E00")]
	public void EIMPLACCFNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3CE8010", Offset = "0x3CE6A10", VA = "0x183CE8010")]
	public void LOELLEJLIID(int OHELHAFFKFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3CE7C90", Offset = "0x3CE6690", VA = "0x183CE7C90")]
	public void DBFIPIGFGPB(T[] MHMBNFEOIBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3CE80E0", Offset = "0x3CE6AE0", VA = "0x183CE80E0")]
	public Enumerator PNMCCDOOLCI()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3CE8120", Offset = "0x3CE6B20", VA = "0x183CE8120", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3CE8120", Offset = "0x3CE6B20", VA = "0x183CE8120", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3CE7B60", Offset = "0x3CE6560", VA = "0x183CE7B60")]
	private int BKMHIBOOOJE(int ILOCEPPJPDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3CE7EC0", Offset = "0x3CE68C0", VA = "0x183CE7EC0")]
	private int JLBGGHJJCFF(int ILOCEPPJPDO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class FHHBAIJDFEL<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public delegate Task<TResult> FEMGAEPMDDF(TRequest BJLMEIJMPBN, CancellationToken AOLOJHLCMLE);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public enum CFHLFAPKDEN
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class IBPPDFACGLE
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private const float AAJHDDKFKGI = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TimeSpan JONJLMIPNCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int KOAHNAFJNHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public CFHLFAPKDEN DGFEFNEFIOP;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static readonly IBPPDFACGLE LDMJBAPJLGF;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float OFOKCHLEFAA
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x3E91670", Offset = "0x3E90070", VA = "0x183E91670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public TimeSpan BMMKIFAKOKG
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x84EC70", Offset = "0x84D670", VA = "0x18084EC70")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x3E917C0", Offset = "0x3E901C0", VA = "0x183E917C0")]
		public IBPPDFACGLE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private readonly struct AGNPOIDMHDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly TRequest BJLMEIJMPBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly CancellationToken AOLOJHLCMLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly TaskCompletionSource<TResult> CPKLFCGBIPC;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x3CDAB40", Offset = "0x3CD9540", VA = "0x183CDAB40")]
		public AGNPOIDMHDC(TRequest BJLMEIJMPBN, TaskCompletionSource<TResult> CPKLFCGBIPC, CancellationToken AOLOJHLCMLE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct BAHAJHFBKJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public FHHBAIJDFEL<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4DD3F00", Offset = "0x4DD2900", VA = "0x184DD3F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x4DD4360", Offset = "0x4DD2D60", VA = "0x184DD4360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct HMAAAFOEPCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public FHHBAIJDFEL<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private AGNPOIDMHDC <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x3DE34B0", Offset = "0x3DE1EB0", VA = "0x183DE34B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x3DE3B40", Offset = "0x3DE2540", VA = "0x183DE3B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly CancellationTokenSource LMFDMILDBGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly List<AGNPOIDMHDC> FJFFJBLIKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly IBPPDFACGLE DCCHICFNNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly FEMGAEPMDDF OHNIPBIEHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Task KCODKOGDEBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private int LGAHKOGHKLB;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3C071F0", Offset = "0x3C05BF0", VA = "0x183C071F0")]
	public FHHBAIJDFEL(FEMGAEPMDDF OHNIPBIEHBK, [Optional] IBPPDFACGLE DCCHICFNNIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3C06B20", Offset = "0x3C05520", VA = "0x183C06B20")]
	public Task<TResult> MPMDBBNFOEK(TRequest BJLMEIJMPBN, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3C06000", Offset = "0x3C04A00", VA = "0x183C06000")]
	private void IEFENDGCEEC(AGNPOIDMHDC BINOINCOHND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3C05F30", Offset = "0x3C04930", VA = "0x183C05F30")]
	[AsyncStateMachine(typeof(FHHBAIJDFEL<, >.BAHAJHFBKJB))]
	private Task IAPOHPGBJBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3C06280", Offset = "0x3C04C80", VA = "0x183C06280")]
	private AGNPOIDMHDC KOJPDMMFJAL()
	{
		return default(AGNPOIDMHDC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3C05960", Offset = "0x3C04360", VA = "0x183C05960")]
	[AsyncStateMachine(typeof(FHHBAIJDFEL<, >.HMAAAFOEPCJ))]
	private Task AIBCCEBKKKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3C05C50", Offset = "0x3C04650", VA = "0x183C05C50")]
	private void AKEMAMHAEMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3C05D50", Offset = "0x3C04750", VA = "0x183C05D50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class HKMENKFDOMJ<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly List<T> AGFBCPPODBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private HashSet<T> EFFMJFFKDPK;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int BGDNEMFMALE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x3563C40", Offset = "0x3562640", VA = "0x183563C40", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool DODHMAHIADE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public T PBAJKHBLIBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2833400", Offset = "0x2831E00", VA = "0x182833400", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3DE0300", Offset = "0x3DDED00", VA = "0x183DE0300", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3C6C640", Offset = "0x3C6B040", VA = "0x183C6C640", Slot = "11")]
	public void Add(T IMMLPPOHEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3DDFBC0", Offset = "0x3DDE5C0", VA = "0x183DDFBC0")]
	public bool MAFHIDCFLPD(T IMMLPPOHEAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3DE0060", Offset = "0x3DDEA60", VA = "0x183DE0060", Slot = "15")]
	public bool Remove(T IMMLPPOHEAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3D36E10", Offset = "0x3D35810", VA = "0x183D36E10", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3BD1400", Offset = "0x3BCFE00", VA = "0x183BD1400", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3DDF780", Offset = "0x3DDE180", VA = "0x183DDF780", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3DDF820", Offset = "0x3DDE220", VA = "0x183DDF820", Slot = "13")]
	public bool Contains(T IMMLPPOHEAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3DDF870", Offset = "0x3DDE270", VA = "0x183DDF870", Slot = "14")]
	public void CopyTo(T[] MHMBNFEOIBK, int KJCAHDMHMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3DDF8D0", Offset = "0x3DDE2D0", VA = "0x183DDF8D0", Slot = "6")]
	public int IndexOf(T IMMLPPOHEAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3DDF930", Offset = "0x3DDE330", VA = "0x183DDF930", Slot = "7")]
	public void Insert(int ILOCEPPJPDO, T IMMLPPOHEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3DDFDC0", Offset = "0x3DDE7C0", VA = "0x183DDFDC0", Slot = "8")]
	public void RemoveAt(int ILOCEPPJPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3DE01E0", Offset = "0x3DDEBE0", VA = "0x183DE01E0")]
	public HKMENKFDOMJ()
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
			[Cpp2IlInjected.Address(RVA = "0x21868E0", Offset = "0x21852E0", VA = "0x1821868E0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x689FA90", Offset = "0x689E490", VA = "0x18689FA90")]
		public SerializedGuid([In] Guid JCMDDLFAGEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x689F960", Offset = "0x689E360", VA = "0x18689F960")]
		public static SerializedGuid LIBKBBEFAIP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x689F780", Offset = "0x689E180", VA = "0x18689F780")]
		public static SerializedGuid CKOPBLMHBDC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x689F820", Offset = "0x689E220", VA = "0x18689F820")]
		public bool DJEJGGIOHNN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x689FA60", Offset = "0x689E460", VA = "0x18689FA60", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x689F9E0", Offset = "0x689E3E0", VA = "0x18689F9E0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x689F880", Offset = "0x689E280", VA = "0x18689F880", Slot = "7")]
		public bool Equals(SerializedGuid HENLEJBGFIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x689F8C0", Offset = "0x689E2C0", VA = "0x18689F8C0", Slot = "0")]
		public override bool Equals(object GKHPLGCJCPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x689F950", Offset = "0x689E350", VA = "0x18689F950", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x689F7F0", Offset = "0x689E1F0", VA = "0x18689F7F0", Slot = "6")]
		public int CompareTo(SerializedGuid HENLEJBGFIE)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class KGFJICPHKBO : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly Type AEOLEFOJCPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly string PAJCNLCLKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool HCAAGOMDKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool NKHLOBBJPGD;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x689CDA0", Offset = "0x689B7A0", VA = "0x18689CDA0")]
	public KGFJICPHKBO(Type FLGNOEOOBED, string ILEAFNPBDNJ, bool MEKCGBJAJHK = false, bool BADIEAGEMII = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class MIJAEHJIGEB<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public readonly struct HPJAPHLAJIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly long JNJNNGKGNPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly long INBFOOFHLNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public readonly int LBELFMKFHIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly int MBHIHMIENEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly bool APBPOCNNKPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly string EIJGMJLPMCD;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3DE7E50", Offset = "0x3DE6850", VA = "0x183DE7E50")]
		public HPJAPHLAJIM(long JNJNNGKGNPO, int LBELFMKFHIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3DE7E20", Offset = "0x3DE6820", VA = "0x183DE7E20")]
		public HPJAPHLAJIM(long JNJNNGKGNPO, long INBFOOFHLNK, int LBELFMKFHIK, int MBHIHMIENEJ, bool APBPOCNNKPL, string EIJGMJLPMCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3DE7CB0", Offset = "0x3DE66B0", VA = "0x183DE7CB0")]
		public int BCJJPFKCECC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3DE7D00", Offset = "0x3DE6700", VA = "0x183DE7D00")]
		public int BLKEMDCNLJB(int GHBKGAHHOLD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3DE7DC0", Offset = "0x3DE67C0", VA = "0x183DE7DC0")]
		public double MGFGFGKDNNG()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3DE7D20", Offset = "0x3DE6720", VA = "0x183DE7D20")]
		public HPJAPHLAJIM HHKNHPMDNPJ(long INBFOOFHLNK, int MBHIHMIENEJ)
		{
			return default(HPJAPHLAJIM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class OBFKFOAMCEP : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private struct OJIIPCPMILP<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public OBFKFOAMCEP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Func<OBFKFOAMCEP, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private OBFKFOAMCEP <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x4608F70", Offset = "0x4607970", VA = "0x184608F70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x41C0730", Offset = "0x41BF130", VA = "0x1841C0730", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly TKey KJIEMALOMPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly MIJAEHJIGEB<TKey> GJLENOHHOLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public readonly LGKLDLNGEGN DHOGKNDCDMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private List<OBFKFOAMCEP> DLABEBINCMJ;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public string DCDKGDOHLJH
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x45F51A0", Offset = "0x45F3BA0", VA = "0x1845F51A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public IEnumerable<OBFKFOAMCEP> BEPAPADOIGN
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x45F51F0", Offset = "0x45F3BF0", VA = "0x1845F51F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public HPJAPHLAJIM IFLOEGGPDIK
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x45F54B0", Offset = "0x45F3EB0", VA = "0x1845F54B0")]
			[CompilerGenerated]
			get
			{
				return default(HPJAPHLAJIM);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x45F5480", Offset = "0x45F3E80", VA = "0x1845F5480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x45F5680", Offset = "0x45F4080", VA = "0x1845F5680")]
		internal OBFKFOAMCEP(MIJAEHJIGEB<TKey> GJLENOHHOLD, TKey LDDEKIBHION, LGKLDLNGEGN DHOGKNDCDMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x45F54D0", Offset = "0x45F3ED0", VA = "0x1845F54D0")]
		public OBFKFOAMCEP OMNGCNGKNDC(TKey LDDEKIBHION, [Optional] LGKLDLNGEGN? ELNNDILEKLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3450", Offset = "0x2BA1E50", VA = "0x182BA3450")]
		[AsyncStateMachine(typeof(OJIIPCPMILP<>))]
		public Task<T> NOAMEGPPGMN<T>(TKey LDDEKIBHION, Func<OBFKFOAMCEP, Task<T>> MFKPABNLOJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x45F5230", Offset = "0x45F3C30", VA = "0x1845F5230", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class LDJFBGFJPPE : IEnumerable<(TKey, List<TKey>, HPJAPHLAJIM)>, IEnumerable, IEnumerator<(TKey, List<TKey>, HPJAPHLAJIM)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private (TKey key, List<TKey> path, HPJAPHLAJIM timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public MIJAEHJIGEB<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IEnumerator<(TKey key, List<TKey> path, HPJAPHLAJIM timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private (TKey, List<TKey>, HPJAPHLAJIM) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x2184B60", Offset = "0x2183560", VA = "0x182184B60", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, HPJAPHLAJIM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x426B2D0", Offset = "0x4269CD0", VA = "0x18426B2D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2184C50", Offset = "0x2183650", VA = "0x182184C50")]
		[DebuggerHidden]
		public LDJFBGFJPPE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x3A71070", Offset = "0x3A6FA70", VA = "0x183A71070", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x426ADC0", Offset = "0x42697C0", VA = "0x18426ADC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x426AD70", Offset = "0x4269770", VA = "0x18426AD70")]
		private void KBJJHHPKCPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x426B280", Offset = "0x4269C80", VA = "0x18426B280", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x426B1B0", Offset = "0x4269BB0", VA = "0x18426B1B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, HPJAPHLAJIM)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3A79660", Offset = "0x3A78060", VA = "0x183A79660", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class NMCONGDCFJB : IEnumerable<(TKey, List<TKey>, HPJAPHLAJIM)>, IEnumerable, IEnumerator<(TKey, List<TKey>, HPJAPHLAJIM)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private (TKey key, List<TKey> path, HPJAPHLAJIM timerEntry) <>2__current;

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
		private OBFKFOAMCEP timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public OBFKFOAMCEP <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public MIJAEHJIGEB<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private IEnumerator<OBFKFOAMCEP> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private IEnumerator<(TKey key, List<TKey> path, HPJAPHLAJIM timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, HPJAPHLAJIM) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x2184B60", Offset = "0x2183560", VA = "0x182184B60", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, HPJAPHLAJIM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x44FAC10", Offset = "0x44F9610", VA = "0x1844FAC10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2184C50", Offset = "0x2183650", VA = "0x182184C50")]
		[DebuggerHidden]
		public NMCONGDCFJB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x44FAC70", Offset = "0x44F9670", VA = "0x1844FAC70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x44FA2C0", Offset = "0x44F8CC0", VA = "0x1844FA2C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x44FA260", Offset = "0x44F8C60", VA = "0x1844FA260")]
		private void KBJJHHPKCPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x44FA200", Offset = "0x44F8C00", VA = "0x1844FA200")]
		private void FLCLOIILAFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x44FABC0", Offset = "0x44F95C0", VA = "0x1844FABC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x44FAA80", Offset = "0x44F9480", VA = "0x1844FAA80", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, HPJAPHLAJIM)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x44FAB80", Offset = "0x44F9580", VA = "0x1844FAB80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly Action<TKey, HPJAPHLAJIM, LGKLDLNGEGN> DLHLPKNDECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Action<TKey, HPJAPHLAJIM, LGKLDLNGEGN> NIJPKJNEIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly Action<MIJAEHJIGEB<TKey>, LGKLDLNGEGN> LNOEFOMHKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly LGKLDLNGEGN DHOGKNDCDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly OBFKFOAMCEP BJAAKEGHLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private bool HEPHGBKCGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int IBFNELKBBCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly Stopwatch MDHFBMJBCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly int EOPCAJOIPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private string LCEIIJKBMPF;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public OBFKFOAMCEP DGGJNLOBJGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x84EEA0", Offset = "0x84D8A0", VA = "0x18084EEA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	[NotNull]
	public string DCDKGDOHLJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x84FCE0", Offset = "0x84E6E0", VA = "0x18084FCE0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x44755E0", Offset = "0x4473FE0", VA = "0x1844755E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4475910", Offset = "0x4474310", VA = "0x184475910")]
	public MIJAEHJIGEB(TKey OCLLHJMLAOE, LGKLDLNGEGN DHOGKNDCDMM, [Optional] int? LBELFMKFHIK, [Optional][CanBeNull] Stopwatch MDHFBMJBCHB, [Optional] Action<TKey, HPJAPHLAJIM, LGKLDLNGEGN> DLHLPKNDECJ, [Optional] Action<TKey, HPJAPHLAJIM, LGKLDLNGEGN> NIJPKJNEIMA, [Optional] Action<MIJAEHJIGEB<TKey>, LGKLDLNGEGN> LNOEFOMHKBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x44756C0", Offset = "0x44740C0", VA = "0x1844756C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4475790", Offset = "0x4474190", VA = "0x184475790")]
	[IteratorStateMachine(typeof(MIJAEHJIGEB<>.LDJFBGFJPPE))]
	public IEnumerable<(TKey, List<TKey>, HPJAPHLAJIM)> ECHDCCHIDLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4475830", Offset = "0x4474230", VA = "0x184475830")]
	[IteratorStateMachine(typeof(MIJAEHJIGEB<>.NMCONGDCFJB))]
	private IEnumerable<(TKey, List<TKey>, HPJAPHLAJIM)> ECHDCCHIDLL(List<TKey> LLLIHNDJKKC, OBFKFOAMCEP MMKIFKKPIHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4475640", Offset = "0x4474040", VA = "0x184475640")]
	private (long, int) DCFGFGJBBJK()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public abstract class FPPAJOPCIMI<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut BJBFKCMJNIN(MIJAEHJIGEB<TKey> GJLENOHHOLD);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	protected FPPAJOPCIMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public abstract class NAKODGAJLDK<TKey> : FPPAJOPCIMI<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate string BADLDNIDBPC(TKey LDDEKIBHION);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x44C9B90", Offset = "0x44C8590", VA = "0x1844C9B90")]
	private static string HPFMLJCIGJF(TKey LDDEKIBHION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x44C9AB0", Offset = "0x44C84B0", VA = "0x1844C9AB0", Slot = "4")]
	public override string BJBFKCMJNIN(MIJAEHJIGEB<TKey> GJLENOHHOLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x44C9960", Offset = "0x44C8360", VA = "0x1844C9960")]
	public string BJBFKCMJNIN(MIJAEHJIGEB<TKey> GJLENOHHOLD, [NotNull] BADLDNIDBPC FAEEDAMFIHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string OKMNEOFKGFH(MIJAEHJIGEB<TKey> GJLENOHHOLD, [NotNull] BADLDNIDBPC FAEEDAMFIHE);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3DC5430", Offset = "0x3DC3E30", VA = "0x183DC5430")]
	protected NAKODGAJLDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class OFOHALJJPEI<TKey> : FPPAJOPCIMI<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public delegate string IMEDJCMJAJK(TKey LDDEKIBHION);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly string BOPPMFJEOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly double FDMCJIPPKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly bool PHHDEBFELMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly int MOMPNBBCMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly ISet<string> KLKKNHKGBMF;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x45FEBE0", Offset = "0x45FD5E0", VA = "0x1845FEBE0")]
	private static string HPFMLJCIGJF(TKey LDDEKIBHION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x45FED80", Offset = "0x45FD780", VA = "0x1845FED80")]
	public OFOHALJJPEI(string BOPPMFJEOIA = "F2", double FDMCJIPPKNK = double.MaxValue, bool PHHDEBFELMP = false, int MOMPNBBCMNO = int.MaxValue, [Optional] ISet<string> KLKKNHKGBMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x45FE7C0", Offset = "0x45FD1C0", VA = "0x1845FE7C0", Slot = "4")]
	public override Dictionary<string, string> BJBFKCMJNIN(MIJAEHJIGEB<TKey> GJLENOHHOLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x45FEB10", Offset = "0x45FD510", VA = "0x1845FEB10")]
	private bool FJDCABMGOJF(string CJDECMJJIFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x45FE180", Offset = "0x45FCB80", VA = "0x1845FE180")]
	public Dictionary<string, string> BJBFKCMJNIN(MIJAEHJIGEB<TKey> GJLENOHHOLD, IMEDJCMJAJK FAEEDAMFIHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x45FE8A0", Offset = "0x45FD2A0", VA = "0x1845FE8A0")]
	private string CDOIJMPDMNF(StringBuilder GMPDKLMGFEP, List<TKey> BKOKONMCENB, IMEDJCMJAJK FAEEDAMFIHE, bool JAPKMLLCKMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x45FEC20", Offset = "0x45FD620", VA = "0x1845FEC20")]
	private static void JAIAFOEHIAI(StringBuilder OEFKHAPEHEI, string HHGIGPGNAMF, bool FMGFAPDMKKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class HCIGEGKPMMO<TKey> : NAKODGAJLDK<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct NLOHLLLBGCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public BADLDNIDBPC keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static HCIGEGKPMMO<TKey> OHJMENPNAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly string[] DAPBAFBLIJJ;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3DAE880", Offset = "0x3DAD280", VA = "0x183DAE880")]
	private HCIGEGKPMMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3DAD910", Offset = "0x3DAC310", VA = "0x183DAD910", Slot = "5")]
	protected override string OKMNEOFKGFH(MIJAEHJIGEB<TKey> GJLENOHHOLD, BADLDNIDBPC FAEEDAMFIHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3DAD810", Offset = "0x3DAC210", VA = "0x183DAD810")]
	[CompilerGenerated]
	internal static string FOPBPJNIBEB(string NEBPJHGAKGG, TKey LDDEKIBHION, NLOHLLLBGCE P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class OLLONFLHLAF : MIJAEHJIGEB<string>
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class CECAAIHHJOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Action<OLLONFLHLAF, LGKLDLNGEGN> callback;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public CECAAIHHJOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x689B8F0", Offset = "0x689A2F0", VA = "0x18689B8F0")]
		internal void OIHLFDBOHPC(MIJAEHJIGEB<string> timer, LGKLDLNGEGN log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x689D170", Offset = "0x689BB70", VA = "0x18689D170")]
	public OLLONFLHLAF(LGKLDLNGEGN DHOGKNDCDMM, [Optional] string CHMBMDOLMEL, [Optional] int? LBELFMKFHIK, [Optional] Stopwatch MDHFBMJBCHB, [Optional] Action<string, HPJAPHLAJIM, LGKLDLNGEGN> DLHLPKNDECJ, [Optional] Action<string, HPJAPHLAJIM, LGKLDLNGEGN> NIJPKJNEIMA, [Optional] Action<OLLONFLHLAF, LGKLDLNGEGN> LNOEFOMHKBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x689D0B0", Offset = "0x689BAB0", VA = "0x18689D0B0")]
	private static Action<MIJAEHJIGEB<string>, LGKLDLNGEGN> BIKCEBPEBMA(Action<OLLONFLHLAF, LGKLDLNGEGN> BHKFHJNIBAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class JKJAPEJEFAC
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private class KPHJGDAOPHB : JKJAPEJEFAC
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public static JKJAPEJEFAC OHJMENPNAKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x689CE10", Offset = "0x689B810", VA = "0x18689CE10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override float KBKADDINFMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x986060", Offset = "0x984A60", VA = "0x180986060", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x689CF10", Offset = "0x689B910", VA = "0x18689CF10")]
		public KPHJGDAOPHB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static JKJAPEJEFAC NHPNJMCAMFF;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static JKJAPEJEFAC LDMJBAPJLGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x689CC30", Offset = "0x689B630", VA = "0x18689CC30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public abstract float KBKADDINFMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	protected JKJAPEJEFAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface GKEFEFBOJBB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool FIGHPIBDBNL
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface AMHDMMJJKND<T> : GKEFEFBOJBB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	[NotNull]
	Task<T> CANEGADKBAE
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	[NotNull]
	CPAHEHFKIFF<T> MBAAKDLOMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class OBIIFFOINCC
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2C9D270", Offset = "0x2C9BC70", VA = "0x182C9D270")]
	public static AMHDMMJJKND<TResource> DGBJODNHNIN<TResource, TId>(this JHFAOJJKCFJ<TId, TResource> ICBOJFKFPLA, TId OBDGAAHPMCD, [Optional] Func<TId, CancellationToken, Task<TResource>>? CHBKHALOMNF) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class JEIBIECCIBD
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private sealed class ILIIPLDJLKI<T> : IDJJAMGHOCK<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override Task<T?> CANEGADKBAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override CPAHEHFKIFF<T?> MBAAKDLOMFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x850E50", Offset = "0x84F850", VA = "0x180850E50", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x3EA65E0", Offset = "0x3EA4FE0", VA = "0x183EA65E0")]
		public ILIIPLDJLKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "10")]
		protected override void CFANECHHBKF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private sealed class KJDGGJFDIJH<T> : IDJJAMGHOCK<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly T DDCIALOFCJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly Action<T>? IGBIIJDPKBE;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override Task<T> CANEGADKBAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x84EC40", Offset = "0x84D640", VA = "0x18084EC40", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override CPAHEHFKIFF<T> MBAAKDLOMFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x84FE00", Offset = "0x84E800", VA = "0x18084FE00", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x41E3650", Offset = "0x41E2050", VA = "0x1841E3650")]
		public KJDGGJFDIJH(T OMEKNKALOKC, Action<T>? LBAFLCIBONF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x41E35F0", Offset = "0x41E1FF0", VA = "0x1841E35F0", Slot = "10")]
		protected override void CFANECHHBKF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private sealed class MFHDIKNNKIH<T> : IDJJAMGHOCK<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override Task<T> CANEGADKBAE
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override CPAHEHFKIFF<T> MBAAKDLOMFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x850E50", Offset = "0x84F850", VA = "0x180850E50", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x446EAB0", Offset = "0x446D4B0", VA = "0x18446EAB0")]
		public MFHDIKNNKIH(Exception PCNDFGCCCEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "10")]
		protected override void CFANECHHBKF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private sealed class OGPCBJAPMMH<T> : IDJJAMGHOCK<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct EPODNIAJNFN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public Task<AMHDMMJJKND<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private TaskAwaiter<AMHDMMJJKND<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x3881910", Offset = "0x3880310", VA = "0x183881910", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x3881E10", Offset = "0x3880810", VA = "0x183881E10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct NGOAOECILKH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public Task<AMHDMMJJKND<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private TaskAwaiter<AMHDMMJJKND<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x44E2700", Offset = "0x44E1100", VA = "0x1844E2700", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x44E2990", Offset = "0x44E1390", VA = "0x1844E2990", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly Task<AMHDMMJJKND<T>> FBANJDNLJCP;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override Task<T> CANEGADKBAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x850E50", Offset = "0x84F850", VA = "0x180850E50", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override CPAHEHFKIFF<T> MBAAKDLOMFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x84EC50", Offset = "0x84D650", VA = "0x18084EC50", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x45FFB70", Offset = "0x45FE570", VA = "0x1845FFB70")]
		public OGPCBJAPMMH(Task<AMHDMMJJKND<T>> JCINMAJOONI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x45FF5B0", Offset = "0x45FDFB0", VA = "0x1845FF5B0", Slot = "10")]
		protected override void CFANECHHBKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x45FF6D0", Offset = "0x45FE0D0", VA = "0x1845FF6D0")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(OGPCBJAPMMH<>.EPODNIAJNFN))]
		internal static Task<T> MMELBACGJFL(Task<AMHDMMJJKND<T>> JCINMAJOONI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x45FF9B0", Offset = "0x45FE3B0", VA = "0x1845FF9B0")]
		[AsyncStateMachine(typeof(OGPCBJAPMMH<>.NGOAOECILKH))]
		[CompilerGenerated]
		internal static Task OOJMKGMNNNO(Task<AMHDMMJJKND<T>> JCINMAJOONI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private sealed class DBKFOCJLCAF<TIn, TOut> : IDJJAMGHOCK<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private struct OGBMAFOAMCG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public AsyncTaskMethodBuilder<TOut> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public Func<TIn, TOut> transformFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public Task<TIn> innerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private Func<TIn, TOut> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private TaskAwaiter<TIn> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x45FEE80", Offset = "0x45FD880", VA = "0x1845FEE80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x3EA4310", Offset = "0x3EA2D10", VA = "0x183EA4310", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly AMHDMMJJKND<TIn> LNEPGBFFFKF;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override Task<TOut> CANEGADKBAE
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x850E50", Offset = "0x84F850", VA = "0x180850E50", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override CPAHEHFKIFF<TOut> MBAAKDLOMFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x84EC50", Offset = "0x84D650", VA = "0x18084EC50", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x5759050", Offset = "0x5757A50", VA = "0x185759050")]
		public DBKFOCJLCAF(AMHDMMJJKND<TIn> APAHIJDLPBG, Func<TIn, TOut> EDKDJMHBCAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x5758CB0", Offset = "0x57576B0", VA = "0x185758CB0", Slot = "10")]
		protected override void CFANECHHBKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x5758D50", Offset = "0x5757750", VA = "0x185758D50")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(DBKFOCJLCAF<, >.OGBMAFOAMCG))]
		internal static Task<TOut> DMPPNKIHIJO(Task<TIn> DCFODCMIFMF, Func<TIn, TOut> EDKDJMHBCAI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2B79C70", Offset = "0x2B78670", VA = "0x182B79C70")]
	public static AMHDMMJJKND<T> EOPMNGGGOOO<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2B79CF0", Offset = "0x2B786F0", VA = "0x182B79CF0")]
	public static AMHDMMJJKND<T> HAPKBGPFDNH<T>(T EBPHIJANMPN, [Optional] Action<T>? LBAFLCIBONF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x2960650", Offset = "0x295F050", VA = "0x182960650")]
	public static AMHDMMJJKND<T> FLOFFCAIPHA<T>(Exception PCNDFGCCCEA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x2960650", Offset = "0x295F050", VA = "0x182960650")]
	public static AMHDMMJJKND<T> KLECLPGFIOJ<T>(Task<AMHDMMJJKND<T>> JCINMAJOONI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x28BF6B0", Offset = "0x28BE0B0", VA = "0x1828BF6B0")]
	public static AMHDMMJJKND<TOut> JKDHBCECKGL<TOut, TIn>(AMHDMMJJKND<TIn> AHCMMMOBCPP, Func<TIn, TOut> EDKDJMHBCAI) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public abstract class IDJJAMGHOCK<T> : AMHDMMJJKND<T>, GKEFEFBOJBB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static readonly string DOOIGKFIAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly EIFADGOBFBO KBDJBCDAFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private bool HEPHGBKCGHN;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool FIGHPIBDBNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xB6E860", Offset = "0xB6D260", VA = "0x180B6E860", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public abstract Task<T> CANEGADKBAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public abstract CPAHEHFKIFF<T> MBAAKDLOMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x3E94960", Offset = "0x3E93360", VA = "0x183E94960")]
	public IDJJAMGHOCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x3E945B0", Offset = "0x3E92FB0", VA = "0x183E945B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void CFANECHHBKF();
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public abstract class ANPIOJKBJMC<TTask, T> : IDJJAMGHOCK<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class NPHIIFGDPFN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public NPHIIFGDPFN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x3551C30", Offset = "0x3550630", VA = "0x183551C30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x3551EF0", Offset = "0x35508F0", VA = "0x183551EF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public ANPIOJKBJMC<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public NPHIIFGDPFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x4503B20", Offset = "0x4502520", VA = "0x184503B20")]
		[AsyncStateMachine(typeof(ANPIOJKBJMC<, >.NPHIIFGDPFN.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> MEKMJCLPPAM(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly Task<T> JCINMAJOONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	protected readonly CancellationTokenSource NBIMBFBEBLN;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public override Task<T> CANEGADKBAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public override CPAHEHFKIFF<T> MBAAKDLOMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x850E50", Offset = "0x84F850", VA = "0x180850E50", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x3E14FA0", Offset = "0x3E139A0", VA = "0x183E14FA0")]
	protected ANPIOJKBJMC(TTask JCINMAJOONI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3E14F50", Offset = "0x3E13950", VA = "0x183E14F50", Slot = "10")]
	protected override void CFANECHHBKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T JEFCGHPKEMH(TTask CNHNLIMLNBJ);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void OLNEJMGCPEH();
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class AJHHJODMGJE<T> : IDJJAMGHOCK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly MAGIJMJBHDB<Task<T>> MNKMMMJDFNO;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public override Task<T> CANEGADKBAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3832FD0", Offset = "0x38319D0", VA = "0x183832FD0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public override CPAHEHFKIFF<T> MBAAKDLOMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x850E50", Offset = "0x84F850", VA = "0x180850E50", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3CFEE30", Offset = "0x3CFD830", VA = "0x183CFEE30")]
	public AJHHJODMGJE(MAGIJMJBHDB<Task<T>> OBDBNDCJFND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x3CFEE10", Offset = "0x3CFD810", VA = "0x183CFEE10", Slot = "10")]
	protected override void CFANECHHBKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class ANEEOCCBCNI
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x689B030", Offset = "0x6899A30", VA = "0x18689B030")]
	[NotNull]
	public static byte[] JNFHGBMOPCN(this GAPMKMHMAPO NDJDIBHNGPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x689B0A0", Offset = "0x6899AA0", VA = "0x18689B0A0")]
	[NotNull]
	public static byte[] JNFHGBMOPCN(this GAPMKMHMAPO NDJDIBHNGPE, HashAlgorithmName CINIPLOKHME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x689B2B0", Offset = "0x6899CB0", VA = "0x18689B2B0")]
	public static bool PPIGKGJAALN([CanBeNull] this GAPMKMHMAPO NDJDIBHNGPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x689B110", Offset = "0x6899B10", VA = "0x18689B110")]
	public static bool PPIGKGJAALN([CanBeNull] this GAPMKMHMAPO NDJDIBHNGPE, [Out] string BKMJJACFCBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x689AF10", Offset = "0x6899910", VA = "0x18689AF10")]
	private static bool IANLGPHNIDO([NotNull] GAPMKMHMAPO NDJDIBHNGPE, [Out][CanBeNull] byte[] ADCPJGMFMID, [Out][CanBeNull] byte[] EHOGNFJIEMG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class EOCKANLIPDH
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x689BB00", Offset = "0x689A500", VA = "0x18689BB00")]
	[NotNull]
	public static byte[] JNFHGBMOPCN(this LCBACAIGJGJ CONKMJLIAME, HashAlgorithmName CINIPLOKHME, byte[] EILFHFHFFGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface LCBACAIGJGJ
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash JAJGGBFDMEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface GAPMKMHMAPO : LCBACAIGJGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	[CanBeNull]
	byte[] DNGHKECELJP
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	[CanBeNull]
	byte[] EBACELKOKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class ICDMCJPIACG
{
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly ArrayPool<byte> GEEJIONGIHO;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static bool CICPBGILKPC;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2B54AC0", Offset = "0x2B534C0", VA = "0x182B54AC0")]
	public static void MLJKGEPGGIL<T>(this IncrementalHash CKOMOANLFOF, [CanBeNull] T BHOOAGJPBFO) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2B54510", Offset = "0x2B52F10", VA = "0x182B54510")]
	public static void LMFMHHENILM<T>(this IncrementalHash CKOMOANLFOF, [CanBeNull] T CONKMJLIAME) where T : LCBACAIGJGJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2B545A0", Offset = "0x2B52FA0", VA = "0x182B545A0")]
	public static void MHGNMOIEALK<T>(this IncrementalHash CKOMOANLFOF, [CanBeNull] IList<T> BLNNLCOPCOD) where T : LCBACAIGJGJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x689C010", Offset = "0x689AA10", VA = "0x18689C010")]
	private static bool HBAGAMAHBIA([CanBeNull] LCBACAIGJGJ CONKMJLIAME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x689BF50", Offset = "0x689A950", VA = "0x18689BF50")]
	public static void GDPFHACLNAL(this IncrementalHash JAJGGBFDMEJ, [CanBeNull] string MAJEIOLAHBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x689C780", Offset = "0x689B180", VA = "0x18689C780")]
	public static void PDLBFLKCJFJ(this IncrementalHash JAJGGBFDMEJ, long BCCGIONIKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x689C2D0", Offset = "0x689ACD0", VA = "0x18689C2D0")]
	public static void KHOLEGIAKCG(this IncrementalHash JAJGGBFDMEJ, int CFDNCDFKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x689C100", Offset = "0x689AB00", VA = "0x18689C100")]
	public static void IJMODCOEGII(this IncrementalHash JAJGGBFDMEJ, short DLOFMCLNJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x689C4A0", Offset = "0x689AEA0", VA = "0x18689C4A0")]
	public static void LMPLNKHJAJC(this IncrementalHash JAJGGBFDMEJ, byte DEIKCLFELPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x689C610", Offset = "0x689B010", VA = "0x18689C610")]
	public static void OBOCJJMLPIB(this IncrementalHash JAJGGBFDMEJ, bool HKFEDABNAAK, bool BHHIPPGKLFJ = false, bool LAJOJBIJLNK = false, bool DNJLDGJGKBN = false, bool ILDACEFAONM = false, bool JDADEODNBBL = false, bool NMDEGJNCHFO = false, bool IDCOKNGDHDL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x2B54B80", Offset = "0x2B53580", VA = "0x182B54B80")]
	public static void MLPAHPFCKGE<T>(this IncrementalHash JAJGGBFDMEJ, T BLJILELIBPK) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x689BFB0", Offset = "0x689A9B0", VA = "0x18689BFB0")]
	public static void GODMDFAMPJB(this IncrementalHash JAJGGBFDMEJ, float PEFPDDCLFCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x689BEF0", Offset = "0x689A8F0", VA = "0x18689BEF0")]
	public static void DOPDDJADBAF(this IncrementalHash JAJGGBFDMEJ, ulong HMELIHANCKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x689C5B0", Offset = "0x689AFB0", VA = "0x18689C5B0")]
	public static void MOKKGCAMANA(this IncrementalHash JAJGGBFDMEJ, uint GNHMHPGIMFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x689C0A0", Offset = "0x689AAA0", VA = "0x18689C0A0")]
	public static void HLMEAPAAOOK(this IncrementalHash JAJGGBFDMEJ, ushort BBEDJGLDDEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x689BDC0", Offset = "0x689A7C0", VA = "0x18689BDC0")]
	public static void DMMHALNJDNG(this IncrementalHash JAJGGBFDMEJ, Vector3 IFMEPHBOOOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class JGGJGHKLIPM : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x689CBD0", Offset = "0x689B5D0", VA = "0x18689CBD0")]
	public JGGJGHKLIPM(string BDCMABOIIFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public abstract class DDNEJLADDCD<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	internal class IGJGDNDKFEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public TNode BBCPNLGGBMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public TNode EMNGIAIDBPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public PLAIDGDOLCE BDGKMFGNNGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public List<PLAIDGDOLCE> NIDNBPCAOMK;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public IGJGDNDKFEM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	internal struct PLAIDGDOLCE : IComparable<PLAIDGDOLCE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int AJDJDACIIPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public TClaimant EBJCKNLJOGJ;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xD90010", Offset = "0xD8EA10", VA = "0x180D90010")]
		public PLAIDGDOLCE(int AJDJDACIIPE, TClaimant EBJCKNLJOGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x46DB680", Offset = "0x46DA080", VA = "0x1846DB680")]
		public bool LLDOCLEDCBM([In] PLAIDGDOLCE HENLEJBGFIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x46DB670", Offset = "0x46DA070", VA = "0x1846DB670")]
		public bool HFGJHOMBCNG([In] PLAIDGDOLCE HENLEJBGFIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x46DB660", Offset = "0x46DA060", VA = "0x1846DB660", Slot = "4")]
		public int CompareTo(PLAIDGDOLCE HENLEJBGFIE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x46DB6E0", Offset = "0x46DA0E0", VA = "0x1846DB6E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public enum HIMJNKDPAPH
	{
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class HIBCGBPOHIK : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public DDNEJLADDCD<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x8A7B40", Offset = "0x8A6540", VA = "0x1808A7B40")]
		[DebuggerHidden]
		public HIBCGBPOHIK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3DCE9E0", Offset = "0x3DCD3E0", VA = "0x183DCE9E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3DCEBC0", Offset = "0x3DCD5C0", VA = "0x183DCEBC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3DCEAC0", Offset = "0x3DCD4C0", VA = "0x183DCEAC0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3A72620", Offset = "0x3A71020", VA = "0x183A72620", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly FAPICAHKDGJ<IGJGDNDKFEM> KEDDAJOLOON;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly FAPICAHKDGJ<List<PLAIDGDOLCE>> LCMPLBJLCLI;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static int MMPFKEAIBHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	internal readonly Dictionary<TClaimant, TNode> FLHDBHPGAKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	internal readonly Dictionary<TNode, IGJGDNDKFEM> DGAIOOOPCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private HIMJNKDPAPH MBMNLIPEPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private bool MENBJDNCHDA;

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode ELIAGIAABGB(TNode CDPKDOCKGIC);

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void CKDOFNDHLGO(TNode CDPKDOCKGIC, TClaimant MGMEKLHHGLA, TClaimant HDGGLOACNBN);

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x5766690", Offset = "0x5765090", VA = "0x185766690")]
	public DDNEJLADDCD(HIMJNKDPAPH MBMNLIPEPEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x5765640", Offset = "0x5764040", VA = "0x185765640")]
	public void FPBCADLGBKG(TNode CDPKDOCKGIC, TNode AEJHEFECOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x5766250", Offset = "0x5764C50", VA = "0x185766250")]
	public void OBCCOFAMMDK(TClaimant EBJCKNLJOGJ, TNode POIABPOACCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x5765430", Offset = "0x5763E30", VA = "0x185765430", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x5766050", Offset = "0x5764A50", VA = "0x185766050")]
	private void NJOPDLNFOJN(TClaimant EBJCKNLJOGJ, TNode PLPBCDNGDPI, TNode POIABPOACCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x5764CE0", Offset = "0x57636E0", VA = "0x185764CE0")]
	private int CLNIBDGLKDM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x57650F0", Offset = "0x5763AF0", VA = "0x1857650F0")]
	private void DMHIGFBCBOC(TClaimant EBJCKNLJOGJ, TNode JEEFCIKIIMA, TNode EINNADCIGFA, int LIAJOBGBILK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x5765020", Offset = "0x5763A20", VA = "0x185765020")]
	private void DLPIMLLNHDK(PLAIDGDOLCE FNOPDHILJPL, IGJGDNDKFEM FKCBGDEDKJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x5765860", Offset = "0x5764260", VA = "0x185765860")]
	private void IHBKPCPDGIN(TClaimant EBJCKNLJOGJ, TNode JEEFCIKIIMA, TNode EINNADCIGFA, int LIAJOBGBILK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x5766120", Offset = "0x5764B20", VA = "0x185766120")]
	private void NKCBGDINJOJ(PLAIDGDOLCE FNOPDHILJPL, TNode CDPKDOCKGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x5765700", Offset = "0x5764100", VA = "0x185765700")]
	private void GNGEMGFKMBN(PLAIDGDOLCE FNOPDHILJPL, IGJGDNDKFEM FKCBGDEDKJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x5764D50", Offset = "0x5763750", VA = "0x185764D50")]
	private void CNIKDACGLND(IGJGDNDKFEM FKCBGDEDKJB, bool CLOJFPNKJDM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x5765B40", Offset = "0x5764540", VA = "0x185765B40")]
	private void LEGBOGJHEOO(IGJGDNDKFEM FKCBGDEDKJB, TNode AEJHEFECOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x57663D0", Offset = "0x5764DD0", VA = "0x1857663D0")]
	[IteratorStateMachine(typeof(DDNEJLADDCD<, >.HIBCGBPOHIK))]
	private IEnumerable<TNode> OJOPAJKGAGK(TNode JEEFCIKIIMA, TNode EINNADCIGFA, bool HHAMOJPGNKK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x5764BD0", Offset = "0x57635D0", VA = "0x185764BD0")]
	private IGJGDNDKFEM BCDEADEJMIJ(TNode CDPKDOCKGIC, TNode EMNGIAIDBPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x5764EA0", Offset = "0x57638A0", VA = "0x185764EA0")]
	private IGJGDNDKFEM DGDDMJPHOKE(TNode CDPKDOCKGIC, TNode EMNGIAIDBPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x5765E90", Offset = "0x5764890", VA = "0x185765E90")]
	private void MHOMMPJCEPK(IGJGDNDKFEM FKCBGDEDKJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class MCOIIBJFDAM<T> : IEnumerable<MCOIIBJFDAM<T>.DFEHFMKGOOO>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct DFEHFMKGOOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public T DBOBEHLEAAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public int ILOCEPPJPDO;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class GKBJACAMKMF : IEnumerator<DFEHFMKGOOO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private MCOIIBJFDAM<T> KMADMHLPGOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private int ILOCEPPJPDO;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x388A3B0", Offset = "0x3888DB0", VA = "0x18388A3B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public DFEHFMKGOOO NHBEFFGDNPC
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x3D37D20", Offset = "0x3D36720", VA = "0x183D37D20", Slot = "4")]
			get
			{
				return default(DFEHFMKGOOO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3D37CE0", Offset = "0x3D366E0", VA = "0x183D37CE0")]
		public GKBJACAMKMF(MCOIIBJFDAM<T> KMADMHLPGOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3D37BE0", Offset = "0x3D365E0", VA = "0x183D37BE0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x38DEE20", Offset = "0x38DD820", VA = "0x1838DEE20", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x9284A0", Offset = "0x926EA0", VA = "0x1809284A0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	private struct JOANNHAGMGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public bool CKJLEHBPDCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public T DBOBEHLEAAE;
	}

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private const int JMOHEIBJLEA = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly Dictionary<T, int> BHPFGGBBDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private JOANNHAGMGC[] JILIMFHHGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private int EGFONJJHHMH;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public int GNDIKHHLODG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x88BD30", Offset = "0x88A730", VA = "0x18088BD30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x88B180", Offset = "0x889B80", VA = "0x18088B180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int BGDNEMFMALE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3563C40", Offset = "0x3562640", VA = "0x183563C40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x44679F0", Offset = "0x44663F0", VA = "0x1844679F0")]
	public MCOIIBJFDAM(int OLPFIFFGHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x44675D0", Offset = "0x4465FD0", VA = "0x1844675D0")]
	public MCOIIBJFDAM(DFEHFMKGOOO[] GNMBKGLGDJP, bool LOKOJGOIIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x44672A0", Offset = "0x4465CA0", VA = "0x1844672A0")]
	public int MELNHCOLNLE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x4466750", Offset = "0x4465150", VA = "0x184466750")]
	private int ABCBBFMJEPG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x4467420", Offset = "0x4465E20", VA = "0x184467420", Slot = "6")]
	protected virtual uint MLFLIKABEFP(uint JAJGGBFDMEJ, T DBOBEHLEAAE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x44673C0", Offset = "0x4465DC0", VA = "0x1844673C0")]
	public bool MGJGGIIDGHB(T DBOBEHLEAAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x4466B50", Offset = "0x4465550", VA = "0x184466B50")]
	public int BCGDIOILKAC(T DBOBEHLEAAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x44674C0", Offset = "0x4465EC0", VA = "0x1844674C0")]
	public T OGMPHPCIBNO(int ILOCEPPJPDO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x4466CF0", Offset = "0x44656F0", VA = "0x184466CF0")]
	public bool MAFHIDCFLPD(T DBOBEHLEAAE, bool EAPGJKFAICC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x4466FF0", Offset = "0x44659F0", VA = "0x184466FF0")]
	public bool MAFHIDCFLPD(T DBOBEHLEAAE, int ILOCEPPJPDO, bool EAPGJKFAICC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x4466CA0", Offset = "0x44656A0", VA = "0x184466CA0")]
	private int IDACFJGNCIP(int PFNBAEBFNFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x4467530", Offset = "0x4465F30", VA = "0x184467530", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x4467530", Offset = "0x4465F30", VA = "0x184467530", Slot = "4")]
	private IEnumerator<DFEHFMKGOOO> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class FAPICAHKDGJ<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly Stack<T> GKJNKNICBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly List<T> DIIJDIJMMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly int LDAKJKLPFLF;

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x3BE75C0", Offset = "0x3BE5FC0", VA = "0x183BE75C0")]
	public static FAPICAHKDGJ<T> CDLIPLLCOMJ(int OLPFIFFGHOM = 0, int LDAKJKLPFLF = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x3BE74D0", Offset = "0x3BE5ED0", VA = "0x183BE74D0")]
	public static FAPICAHKDGJ<T> ACPOJCDEKBB(int OLPFIFFGHOM = 0, int LDAKJKLPFLF = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x3BE7FA0", Offset = "0x3BE69A0", VA = "0x183BE7FA0")]
	public FAPICAHKDGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x3BE7D90", Offset = "0x3BE6790", VA = "0x183BE7D90")]
	public FAPICAHKDGJ(int OLPFIFFGHOM, int LDAKJKLPFLF = int.MaxValue, bool KMFDPNDGLFK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x3BE7830", Offset = "0x3BE6230", VA = "0x183BE7830")]
	public T GCHNOJACEIH()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x3BE79D0", Offset = "0x3BE63D0", VA = "0x183BE79D0")]
	public void IPJKJLPDPPI(T DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x3BE7C90", Offset = "0x3BE6690", VA = "0x183BE7C90")]
	private void MBPDCNANNNO(T DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x3BE7490", Offset = "0x3BE5E90", VA = "0x183BE7490")]
	private void AAPHGBKPGOA(T DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x3BE76B0", Offset = "0x3BE60B0", VA = "0x183BE76B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x3BE7AA0", Offset = "0x3BE64A0", VA = "0x183BE7AA0")]
	private void KCACFNPLPPI(IEnumerable<T> AHBFNFFEMPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class BPPJLKOJJJC<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private Dictionary<int, T> NLHDNBOLFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private T LMDIPLBBCLL;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public virtual T LBOMINNNKJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x84EC00", Offset = "0x84D600", VA = "0x18084EC00", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x4E39AF0", Offset = "0x4E384F0", VA = "0x184E39AF0")]
	public bool LHEEOHBDCCH(T DBOBEHLEAAE, int AJDJDACIIPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x3830970", Offset = "0x382F370", VA = "0x183830970")]
	public bool GLFBFJPCLNC(int AJDJDACIIPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x4E39900", Offset = "0x4E38300", VA = "0x184E39900")]
	public T EONPBHOJGBA(int GHMEIGEKNEF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x4E39CE0", Offset = "0x4E386E0", VA = "0x184E39CE0")]
	private bool MJNGLHKONHM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x4E39E20", Offset = "0x4E38820", VA = "0x184E39E20")]
	public bool NMDJKMBCDDJ(int AJDJDACIIPE, [Out] T DBOBEHLEAAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x3832F20", Offset = "0x3831920", VA = "0x183832F20")]
	public BPPJLKOJJJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class GDKGCBFKIGB<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	protected struct HCNEIIDJNFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public T NHLIMKDHAIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int NPDKMGOOEAM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly List<HCNEIIDJNFC> LHIBAIKPHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private T MHODIAEHMIE;

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public int BGDNEMFMALE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3563C40", Offset = "0x3562640", VA = "0x183563C40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x3D15F30", Offset = "0x3D14930", VA = "0x183D15F30")]
	public bool IKNOCAOHLJM(T DBOBEHLEAAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x3D16230", Offset = "0x3D14C30", VA = "0x183D16230")]
	public void KODKNHDNNHA(T DBOBEHLEAAE, int AJDJDACIIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x3D16410", Offset = "0x3D14E10", VA = "0x183D16410")]
	public bool PLMGPBLKDNE(T DBOBEHLEAAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x3D15D10", Offset = "0x3D14710", VA = "0x183D15D10")]
	public void EIMPLACCFNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x3D16370", Offset = "0x3D14D70", VA = "0x183D16370")]
	public T MGJMBFGEOPI()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x3D15A40", Offset = "0x3D14440", VA = "0x183D15A40")]
	protected void CIGKPLALCJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x3D16780", Offset = "0x3D15180", VA = "0x183D16780")]
	public GDKGCBFKIGB()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[GBAJCKFHNAK(MJDOLBEDPIO.Self, false, false, false)]
		[SerializeField]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x689E480", Offset = "0x689CE80", VA = "0x18689E480")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x689E750", Offset = "0x689D150", VA = "0x18689E750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x689E660", Offset = "0x689D060", VA = "0x18689E660")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x689E3D0", Offset = "0x689CDD0", VA = "0x18689E3D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x689E6A0", Offset = "0x689D0A0", VA = "0x18689E6A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x689E5B0", Offset = "0x689CFB0", VA = "0x18689E5B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x689E340", Offset = "0x689CD40", VA = "0x18689E340")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x48E5D40", Offset = "0x48E4740", VA = "0x1848E5D40", Slot = "4")]
		public virtual T LGGKJPKFMKL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class PPCNJHOCMHN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private Dictionary<byte, APIMCKLGHOA> PGJNFKCBDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private readonly FAPICAHKDGJ<APIMCKLGHOA> OIMKAOHGFGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private readonly bool BGGBECBPKCJ;

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public APIMCKLGHOA ACAKNDPGJGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x84EC70", Offset = "0x84D670", VA = "0x18084EC70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x84EC30", Offset = "0x84D630", VA = "0x18084EC30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public Vector2 MMOFANICCPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xD1EC80", Offset = "0xD1D680", VA = "0x180D1EC80")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x1005DD0", Offset = "0x10047D0", VA = "0x181005DD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	private Vector2 INDCDJFGLGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x1064C00", Offset = "0x1063600", VA = "0x181064C00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Vector2 JALEILNNAIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x689D640", Offset = "0x689C040", VA = "0x18689D640")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x84EC20", Offset = "0x84D620", VA = "0x18084EC20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public int HGBPDPLIFOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x858B50", Offset = "0x857550", VA = "0x180858B50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x858ED0", Offset = "0x8578D0", VA = "0x180858ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x689E280", Offset = "0x689CC80", VA = "0x18689E280")]
	public PPCNJHOCMHN(Bounds PAJEMPPAHBN, Vector2[] PNNDHJEEBMJ, int GLGPBBABDAI, byte PFNBAEBFNFJ, float NGONMFAFMEE = 0f, [Optional] FAPICAHKDGJ<APIMCKLGHOA> OIMKAOHGFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x689DC90", Offset = "0x689C690", VA = "0x18689DC90")]
	public void JHPCGHALKLI(Bounds PAJEMPPAHBN, Vector2[] PNNDHJEEBMJ, int GLGPBBABDAI, byte PFNBAEBFNFJ, float NGONMFAFMEE = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x689E220", Offset = "0x689CC20", VA = "0x18689E220")]
	public APIMCKLGHOA OMIFGFMOHOB(byte ILOCEPPJPDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x689E130", Offset = "0x689CB30", VA = "0x18689E130")]
	public void LAMFDKEMKDM(Vector3 GLNEOPDBMFP, float BAOGJCMIAHD, float BCCPIMAEBHL, List<byte> LGOAABFMLDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x689E200", Offset = "0x689CC00", VA = "0x18689E200")]
	public void OGGFJPDPOEB(APIMCKLGHOA.KGABODHGOBL OPEIINGEKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x689D2C0", Offset = "0x689BCC0", VA = "0x18689D2C0")]
	public static int DBANJKKCDBF(Vector2[] PNNDHJEEBMJ, int GLGPBBABDAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x689D410", Offset = "0x689BE10", VA = "0x18689D410")]
	private APIMCKLGHOA EFDHHBMFPDN(byte ILOCEPPJPDO, APIMCKLGHOA.BFONHOBAFAL FIIAJGODPKM, APIMCKLGHOA EMNGIAIDBPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x689D8E0", Offset = "0x689C2E0", VA = "0x18689D8E0")]
	private void JFCEHANNDCL(APIMCKLGHOA EMNGIAIDBPA, Vector2[] PNNDHJEEBMJ, int DKDEMOCIPGP, int IOIGDIGPBKK, int FJLPPPIMIJG, int FBGKDJFNFAN, float NGONMFAFMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x689D6C0", Offset = "0x689C0C0", VA = "0x18689D6C0")]
	private void IEOKKLJBIGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x689D3B0", Offset = "0x689BDB0", VA = "0x18689D3B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x689D660", Offset = "0x689C060", VA = "0x18689D660", Slot = "1")]
	~PPCNJHOCMHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class APIMCKLGHOA
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public enum BFONHOBAFAL
	{
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public enum KGABODHGOBL
	{
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public byte FOBLAHOCEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public Vector3 OHIGOIMIMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public Vector3 DLJBGHKKEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public Vector3 BKHEOPHGEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public Vector3 ENNFDECMPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public BFONHOBAFAL NFGBJMADOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public APIMCKLGHOA LKABBOLBEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public List<APIMCKLGHOA> EPEBKKJGHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public bool FJKKEOJNBGH;

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x689B8D0", Offset = "0x689A2D0", VA = "0x18689B8D0")]
	public APIMCKLGHOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x689B530", Offset = "0x6899F30", VA = "0x18689B530")]
	public void HLDFMJHFEAO(APIMCKLGHOA DPEMCBKEJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
	public void OGGFJPDPOEB(int FAIAKNFMPOA, KGABODHGOBL OPEIINGEKFD, int KIIBEDOPJOG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x689B670", Offset = "0x689A070", VA = "0x18689B670")]
	public void LAMFDKEMKDM(List<byte> LGOAABFMLDM, Vector3 GLNEOPDBMFP, float BAOGJCMIAHD, float BCCPIMAEBHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x689B500", Offset = "0x6899F00", VA = "0x18689B500")]
	public bool COCAEIBLGLM(Vector3 EKHDIPBLLBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x689B440", Offset = "0x6899E40", VA = "0x18689B440")]
	public bool CAEDHFDDDED(Vector3 EKHDIPBLLBK, float HCOEAPMCMBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x689B470", Offset = "0x6899E70", VA = "0x18689B470")]
	public void CCPNKNOIBEC()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000068")]
		public struct GCEHPEEJFOE<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			private readonly List<Component> AGFBCPPODBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			private readonly bool JMMOHHKCBIE;

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x3CF9B90", Offset = "0x3CF8590", VA = "0x183CF9B90")]
			public GCEHPEEJFOE(List<Component> AGFBCPPODBI, bool JMMOHHKCBIE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x3CF9A60", Offset = "0x3CF8460", VA = "0x183CF9A60")]
			public ANIPNKBEBKN<T> PNMCCDOOLCI()
			{
				return default(ANIPNKBEBKN<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x3CF9AC0", Offset = "0x3CF84C0", VA = "0x183CF9AC0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x3CF9AC0", Offset = "0x3CF84C0", VA = "0x183CF9AC0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		public struct ANIPNKBEBKN<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			private readonly List<Component> AGFBCPPODBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			private readonly bool JMMOHHKCBIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			private int ILOCEPPJPDO;

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			public T NHBEFFGDNPC
			{
				[Cpp2IlInjected.Token(Token = "0x6000209")]
				[Cpp2IlInjected.Address(RVA = "0x3E148C0", Offset = "0x3E132C0", VA = "0x183E148C0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600020A")]
				[Cpp2IlInjected.Address(RVA = "0x3E14850", Offset = "0x3E13250", VA = "0x183E14850", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x3E14890", Offset = "0x3E13290", VA = "0x183E14890")]
			public ANIPNKBEBKN(List<Component> AGFBCPPODBI, bool JMMOHHKCBIE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x3E14790", Offset = "0x3E13190", VA = "0x183E14790", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x3E147A0", Offset = "0x3E131A0", VA = "0x183E147A0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x38D0310", Offset = "0x38CED10", VA = "0x1838D0310", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x68A01A0", Offset = "0x689EBA0", VA = "0x1868A01A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x689FB50", Offset = "0x689E550", VA = "0x18689FB50")]
		private void CCPNKNOIBEC(GameObject DLAKGLDPKHI, bool JFKDELALDJD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x689FAC0", Offset = "0x689E4C0", VA = "0x18689FAC0")]
		public static void CCPNKNOIBEC(GameObject DLAKGLDPKHI, ToolHierarchyCache ICBOJFKFPLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x689FCC0", Offset = "0x689E6C0", VA = "0x18689FCC0")]
		public void EMCCOPJBKBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x2E4B430", Offset = "0x2E49E30", VA = "0x182E4B430")]
		public void KNDJCKLIHOJ<T>(Action<T> GKKKLNHPKBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x2E4B390", Offset = "0x2E49D90", VA = "0x182E4B390")]
		public T GHNHCBHEMEB<T>(bool JMMOHHKCBIE = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x2E4B2D0", Offset = "0x2E49CD0", VA = "0x182E4B2D0")]
		public GCEHPEEJFOE<T> FKLKAJNOPMM<T>(bool JMMOHHKCBIE = false) where T : class
		{
			return default(GCEHPEEJFOE<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x689FD50", Offset = "0x689E750", VA = "0x18689FD50")]
		public List<Component> FCHJFDIDNDH(Type ADDOHDGDFOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x689FCD0", Offset = "0x689E6D0", VA = "0x18689FCD0", Slot = "4")]
		public bool Equals(ToolHierarchyCache PHDMOAMCFBE, ToolHierarchyCache CPHIHAJIIFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x68A00A0", Offset = "0x689EAA0", VA = "0x1868A00A0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache GKHPLGCJCPF)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class EBGMMHODHLB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private int OLPFIFFGHOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private int DFKHDIKCILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private List<T> BMPGIBDBMEA;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int BGDNEMFMALE
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x3832FD0", Offset = "0x38319D0", VA = "0x183832FD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public T FIFIAJBOHJL
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3833610", Offset = "0x3832010", VA = "0x183833610")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public T HJGKOJMFCGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3833090", Offset = "0x3831A90", VA = "0x183833090")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public T GDDDMDMPNEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x38331F0", Offset = "0x3831BF0", VA = "0x1838331F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x3833800", Offset = "0x3832200", VA = "0x183833800")]
	public EBGMMHODHLB(int OLPFIFFGHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x38334B0", Offset = "0x3831EB0", VA = "0x1838334B0")]
	public void KODKNHDNNHA(T BMGPJBNLIJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x3833120", Offset = "0x3831B20", VA = "0x183833120")]
	public void EIMPLACCFNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x3833270", Offset = "0x3831C70", VA = "0x183833270")]
	public void IFNKKINILOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x38337A0", Offset = "0x38321A0", VA = "0x1838337A0")]
	public void MJHNCNCPBIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x3833110", Offset = "0x3831B10", VA = "0x183833110")]
	public void DLINDFEPOOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class LOGIDLDKBHN<T>
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	private struct HHMGMELNLNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public int NPDKMGOOEAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public T NHLIMKDHAIB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly Dictionary<object, HHMGMELNLNO> NLHDNBOLFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly EqualityComparer<T> JAALDCCPJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private T LMDIPLBBCLL;

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public virtual T LBOMINNNKJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x8C0BC0", Offset = "0x8BF5C0", VA = "0x1808C0BC0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x42A2BD0", Offset = "0x42A15D0", VA = "0x1842A2BD0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool GDMEHHNGNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x42A2D20", Offset = "0x42A1720", VA = "0x1842A2D20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public object POJDKDBKBEA
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x84EEA0", Offset = "0x84D8A0", VA = "0x18084EEA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x850E60", Offset = "0x84F860", VA = "0x180850E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x42A3930", Offset = "0x42A2330", VA = "0x1842A3930")]
	public bool LHEEOHBDCCH(T DBOBEHLEAAE, object JCIFCENKMKP, int AJDJDACIIPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x42A2C60", Offset = "0x42A1660", VA = "0x1842A2C60")]
	public bool GLFBFJPCLNC(object JCIFCENKMKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x42A6DF0", Offset = "0x42A57F0", VA = "0x1842A6DF0")]
	public bool NMDJKMBCDDJ(object JCIFCENKMKP, [Out] T DBOBEHLEAAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x42A2B60", Offset = "0x42A1560", VA = "0x1842A2B60")]
	public void EIMPLACCFNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x42A5D90", Offset = "0x42A4790", VA = "0x1842A5D90")]
	private bool MJNGLHKONHM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x42A6FC0", Offset = "0x42A59C0", VA = "0x1842A6FC0")]
	public LOGIDLDKBHN()
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
