// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using System;

// namespace GameWish.Game
// {
//     public class EntityState<T> : FSMState<T> where T : EntityBase
//     {
//         private EventRegisterHelper m_EventRegisterHelper;
//         protected EntityFSMCompo m_Owner;
//         public EntityState(EntityFSMCompo owner) : base()
//         {
//             m_Owner = owner;
//         }

//         public override void Enter(T mgr)
//         {
//         }

//         public override void Exit(T mgr)
//         {
//             UnRegisterAllEvent();
//         }

//         public override void Execute(T mgr, float dt)
//         {
//         }

//         // 状态事件,参考Qarth.AbstractPage
//         protected void SendEvent<K>(K key, params object[] args) where K : IConvertible
//         {
//             EventSystem.S.Send(key, args);
//         }

//         protected void RegisterEvent<K>(K key, OnEvent callback) where K : IConvertible
//         {
//             if (m_EventRegisterHelper == null)
//             {
//                 m_EventRegisterHelper = ObjectPool<EventRegisterHelper>.S.Allocate();
//                 m_EventRegisterHelper.eventSystem = EventSystem.S;
//             }

//             m_EventRegisterHelper.Register(key, callback);
//         }

//         protected void UnRegisterAllEvent()
//         {
//             if (m_EventRegisterHelper == null)
//             {
//                 return;
//             }

//             ObjectPool<EventRegisterHelper>.S.Recycle(m_EventRegisterHelper);
//             m_EventRegisterHelper = null;
//         }

//     }
// }